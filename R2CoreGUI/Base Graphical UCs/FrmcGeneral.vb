

Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices

Imports R2Core.ConfigurationManagement
Imports R2Core.ProcessesManagement
Imports R2Core.RFIDCardsManagement



Public Class FrmcGeneral
    Implements R2CoreRFIDCardRequester


    Protected _FrmMessageDialog As New FrmcMessageDialog
    Protected Event _RFIDCardReadedEvent(CardNo As String)
    Protected Event _RFIDCardStartToReadEvent()
    Protected Event _UCDisposeRequest()
    Protected Event _MenuRunRequestedEvent(UC As UCMenu)
    Protected Event _MenuRunCompletedEvent(UC As UCMenu)
    Protected Event _FormShownFirstTimerTickReachedEvent()
    Public Event _ExitRequest()

    Private WithEvents _LocalMessageCleanTimer As Windows.Forms.Timer = New Timer
    Private WithEvents _FormShownFirstTimer As Windows.Forms.Timer = New Timer
    Private _NSSProcess As R2StandardProcessStructure


#Region "General Properties"

    <Browsable(False)>
    Public ReadOnly Property GetNSSProcess As R2StandardProcessStructure
        Get
            Return _NSSProcess
        End Get
    End Property

    <Browsable(False)>
    Protected WriteOnly Property FrmFormShownFirstTimerInterval As Int64
        Set(value As Int64)
            If _FormShownFirstTimer Is Nothing Then _FormShownFirstTimer = New Windows.Forms.Timer
            _FormShownFirstTimer.Interval = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            ''PnlMain.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            _LocalMessageCleanTimer.Interval = 10000

            'If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
            'Else
            '    InitializeSpecial()
            'End If
            PnlHeader.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
            PnlHeader.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
            PnlBottom.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            PnlBottom.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Sub SetProcess(YourNSSProcess As R2StandardProcessStructure)
        Try
            _NSSProcess = YourNSSProcess
            LblformPersianName.Text = YourNSSProcess.PDisplayTitle
            LblformEnglishName.Text = YourNSSProcess.PName
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Sub InitializeSpecial()
        Try
            Dim RefHight As Int64 = R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.Location.Y + R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.Height + Me.Padding.Top * 2 + 10
            Me.Location = New Point(10, RefHight)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 20
            Me.Height = My.Computer.Screen.WorkingArea.Height - RefHight - 10
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
            SetNSSProcess()
            If GetNSSProcess IsNot Nothing Then CreateMenus()
            LblformPersianName.SendToBack()
            LblformEnglishName.SendToBack()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ExitForm()
        R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.UCCloseActiveForm(Me)
        RaiseEvent _ExitRequest()
    End Sub

    Protected Sub FrmcViewLocalMessage(ByVal YourMessage As String)
        LblLocalMessage.Text = YourMessage
        _LocalMessageCleanTimer.Enabled = True
        _LocalMessageCleanTimer.Start()
    End Sub

    Protected Sub FrmcClearLocalMessage()
        LblLocalMessage.Text = String.Empty
    End Sub

    Public Sub StartReading()
        Try
            R2Core.RFIDCardsManagement.R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub DisposeResources()
        Try
            For Each C As Control In Me.Controls
                If TypeOf C Is UCGeneral Then
                    DirectCast(C, UCGeneral).DisposeResources()
                End If
            Next
            RaiseEvent _UCDisposeRequest()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overridable Sub SetNSSProcess()
    End Sub

    Protected Sub CreateMenus()
        Try
            If GetNSSProcess.MenusTitle = String.Empty Then Exit Sub
            Dim MenusTitle() As String = Split(GetNSSProcess.MenusTitle, ";")
            Dim MenusPanel() As String = Split(GetNSSProcess.MenusPanel, ";")
            For Loopx As Int64 = MenusTitle.Length - 1 To 0 Step -1
                Dim NSSMenu As R2StandardMenuStructure = New R2StandardMenuStructure()
                NSSMenu.MenuTitle = MenusTitle(Loopx)
                NSSMenu.MenuPanel = MenusPanel(Loopx)
                Dim UC As UCMenu = New UCMenu(NSSMenu)
                AddHandler UC.UCClickedEvent, AddressOf UCMenus_UCClickedEventHandler
                UC.Dock = DockStyle.Left
                PnlHeader.Controls.Add(UC)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Sub ChangeMenuStatus(YourMenuPanel As String, YourStatus As Boolean)
        Try
            If GetNSSProcess.MenusTitle = String.Empty Then Exit Sub
            For Each UC As Control In PnlHeader.Controls
                If UC.GetType() Is GetType(UCMenu) Then
                    If DirectCast(UC,UCMenu).UCNSSMenu.MenuPanel = YourMenuPanel Then
                        UC.Enabled = YourStatus
                    End If
                End If
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcGeneral_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            _FormShownFirstTimer.Enabled = True
            _FormShownFirstTimer.Start()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _FormShownFirstTimer_Tick(sender As Object, e As EventArgs) Handles _FormShownFirstTimer.Tick
        Try
            _FormShownFirstTimer.Enabled = False
            _FormShownFirstTimer.Stop()
            RaiseEvent _FormShownFirstTimerTickReachedEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcGeneral_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
        Else
            Me.Owner = R2CoreGUIMClassGUIManagement.FrmMainMenu
        End If
    End Sub

    Private Sub PicExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicExit.Click
        ExitForm()
    End Sub

    Private Sub FrmcGeneral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _LocalMessageCleanTimer.Enabled = False
        _LocalMessageCleanTimer.Stop()
        _LocalMessageCleanTimer = Nothing
    End Sub

    Private Sub _LocalMessageCleanTimer_Tick(sender As Object, e As EventArgs) Handles _LocalMessageCleanTimer.Tick
        _LocalMessageCleanTimer.Enabled = False
        _LocalMessageCleanTimer.Stop()
        FrmcClearLocalMessage()
    End Sub

    Private Sub PicRFIDCardReaderInterface_StartReading_Click(sender As Object, e As EventArgs) Handles PicRFIDCardReaderInterface_StartReading.Click
        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Protected Sub UCMenus_UCClickedEventHandler(UC As UCMenu)
        Try
            RaiseEvent _MenuRunRequestedEvent(UC)
            If UC.UCNSSMenu.MenuPanel Is String.Empty Then Exit Try
            Dim Info As System.Reflection.FieldInfo = Me.GetType().GetField("_" & UC.UCNSSMenu.MenuPanel,
                                                                            System.Reflection.BindingFlags.NonPublic Or
                                                                            System.Reflection.BindingFlags.Instance Or
                                                                            System.Reflection.BindingFlags.Public Or
                                                                            System.Reflection.BindingFlags.IgnoreCase)

            If Info Is Nothing Then Throw New R2CoreMenuReflectedPanelNotFoundException
            Dim P As Panel = CType(Info.GetValue(Me), Panel)
            P.BringToFront()
            P.Focus()
        Catch ex As R2CoreMenuReflectedPanelNotFoundException
            FrmcViewLocalMessage(ex.Message)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        RaiseEvent _MenuRunCompletedEvent(UC)
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"

#End Region

#Region "Implemented Members"

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
        RaiseEvent _RFIDCardStartToReadEvent()
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        RaiseEvent _RFIDCardReadedEvent(CardNo)
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
        _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + MessageWarning, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        FrmcViewLocalMessage(MessageWarning)
    End Sub




#End Region















End Class
