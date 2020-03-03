
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.BaseStandardClass
Imports R2CoreGUI.My.Resources
Imports R2Core.R2Enums
Imports R2Core.ExceptionManagement


Public Class UCSearcherAdvance
    Inherits UCGeneral

    Protected Event UCSearchOptional1RequestEvent(SearchString As String)
    Protected Event UCSearchOptional2RequestEvent(SearchString As String)
    Public Event UCItemSelectedEvent(SelectedItem As R2StandardStructure)
    Public Event UC13PressedEvent()
    Public Event UC27PressedEvent()
    Public Event UCIconRefreshRequestClicked()
    Private _UCFirstTimeFlag As Boolean = True


#Region "General Properties"

    Private _UCSelectedItem As Object = Nothing
    <Browsable(False)>
    Private Property UCSelectedItem() As Object
        Get
            Return _UCSelectedItem
        End Get
        Set(value As Object)
            Try
                _UCSelectedItem = value
                If Not IsNothing(value) Then RaiseEvent UCItemSelectedEvent(UCGetSelectedNSS())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Set
    End Property

    Private _UCMaximizeHight As Int64 = 120
    Public Property UCMaximizeHight() As Int64
        Get
            Return _UCMaximizeHight
        End Get
        Set(value As Int64)
            _UCMaximizeHight = value
        End Set
    End Property

    Private _UCMinimizeHight As Int64 = 31
    Public Property UCMinimizeHight() As Int64
        Get
            Return _UCMinimizeHight
        End Get
        Set(value As Int64)
            _UCMinimizeHight = value
        End Set
    End Property

    Public Enum UCModeType As Int16
        None = 0
        DropDown = 1
        Simple = 2
    End Enum

    Private _UCMode As UCModeType = UCMode.Simple
    Public Property UCMode As UCModeType
        Get
            Return _UCMode
        End Get
        Set(value As UCModeType)
            _UCMode = value
            If value = UCModeType.Simple Then PictureBoxArrows.Visible = False
        End Set
    End Property

    Private _UCIcon As Image = Nothing
    Public Property UCIcon() As Image
        Get
            Return _UCIcon
        End Get
        Set(value As Image)
            _UCIcon = value
            PictureBoxDomain.Image = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            UcPersianTextBox.UCBackColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            UcPersianTextBox.UCForeColor = value
            ListBox.ForeColor = value
        End Set
    End Property

    Private _UCFontSearch As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFontSearch() As Font
        Get
            Return _UCFontSearch
        End Get
        Set(value As Font)
            _UCFontSearch = value
            UcPersianTextBox.UCFont = value
        End Set
    End Property

    Private _UCFontList As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFontList() As Font
        Get
            Return _UCFontList
        End Get
        Set(value As Font)
            _UCFontList = value
            ListBox.Font = value
        End Set
    End Property

    Private _UCShowDomainIcon As Boolean = False
    Public Property UCShowDomainIcon() As Boolean
        Get
            Return _UCShowDomainIcon
        End Get
        Set(value As Boolean)
            _UCShowDomainIcon = value
            If value Then
                PictureBoxDomain.Visible = True
            Else
                PictureBoxDomain.Visible = False
            End If
        End Set
    End Property

    Private _UCMaximizeMinimizeStatus As MaxMin = MaxMin.Min
    <Browsable(False)>
    Private Property UCMaximizeMinimizeStatus
        Get
            Return _UCMaximizeMinimizeStatus
        End Get
        Set(value)
            _UCMaximizeMinimizeStatus = value
            If UCMode = UCModeType.DropDown Then
                If value = MaxMin.Min Then
                    Me.Size = New Size(Me.Width, UCMinimizeHight)
                    PictureBoxArrows.Image = Resources.DownArrow.ToBitmap()
                ElseIf MaxMin.Max Then
                    Me.BringToFront()
                    Me.Size = New Size(Me.Size.Width, UCMaximizeHight)
                    PictureBoxArrows.Image = Resources.UPArrow.ToBitmap()
                End If
            End If
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxArrows.Image = Resources.DownArrow.ToBitmap()
    End Sub

    Private Sub UCFillFirstTime()
        Try
            If _UCFirstTimeFlag = False Then Exit Sub
            _UCFirstTimeFlag = False
            RaiseEvent UCSearchOptional2RequestEvent("")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardStructure)
        Try
            UCSelectedItem = YourNSS.OCode + " : " + YourNSS.OName
            UcPersianTextBox.UCValue = YourNSS.OName
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCDoUserSelectedItem() As Boolean
        Try
            If UCSelectedItem = Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetSelectedNSS() As R2StandardStructure
        Try
            If UCSelectedItem = Nothing Then
                Throw New DataEntryException
            End If
            Return New R2StandardStructure(Split(UCSelectedItem, ":")(0), Split(UCSelectedItem, ":")(1))
        Catch ex As DataEntryException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Protected Sub UCFillListBox(YourInf As List(Of R2StandardStructure))
        Try
            ListBox.Items.Clear()
            For Loopx As Int64 = 0 To YourInf.Count - 1
                ListBox.Items.Add(YourInf(Loopx).OCode + "  :  " + YourInf(Loopx).OName)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshGeneral()
        UCSelectedItem = Nothing
        UCRefresh()
    End Sub

    Private Sub UCRefresh()
        UcPersianTextBox.UCRefresh()
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianTextBox_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox.UC13PressedEvent
        Try
            RaiseEvent UCSearchOptional1RequestEvent(UcPersianTextBox.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCEnterControlPressedEvent(PersianText As String) Handles UcPersianTextBox.UCEnterControlPressedEvent
        Try
            RaiseEvent UCSearchOptional2RequestEvent(UcPersianTextBox.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UC27PressedEvent() Handles UcPersianTextBox.UC27PressedEvent
        Try
            UCMaximizeMinimizeStatus = MaxMin.Min
            RaiseEvent UC27PressedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                UCMaximizeMinimizeStatus = MaxMin.Min
                UcPersianTextBox.UCValue = Split(ListBox.SelectedItem, ":")(1)
                UCSelectedItem = ListBox.SelectedItem
                RaiseEvent UC13PressedEvent()
            End If
            If Asc(e.KeyChar) = 27 Then
                UCMaximizeMinimizeStatus = MaxMin.Min
                RaiseEvent UC27PressedEvent()
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBox_DoubleClick(sender As Object, e As EventArgs) Handles ListBox.DoubleClick
        Try
            UCMaximizeMinimizeStatus = MaxMin.Min
            UcPersianTextBox.UCValue = Split(ListBox.SelectedItem, ":")(1)
            UCSelectedItem = ListBox.SelectedItem
            RaiseEvent UC13PressedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCGotFocusEvent() Handles UcPersianTextBox.UCGotFocusEvent
        Try
            UCFillFirstTime()
            UCMaximizeMinimizeStatus = MaxMin.Max
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCDownArrowKeyPressedEvent() Handles UcPersianTextBox.UCDownArrowKeyPressedEvent
        Try
            ListBox.Focus()
            If ListBox.SelectedIndex < 0 Then ListBox.SelectedIndex = 0
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ListBox.KeyUp
        Try
            If e.KeyData = Keys.Up And ListBox.SelectedIndex = 0 Then
                ListBox.SelectedIndex = -1
                UcPersianTextBox.Focus()
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcher_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        Try
            UCFillFirstTime()
            UCMaximizeMinimizeStatus = MaxMin.Max
            UcPersianTextBox.UCFocus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PictureBoxArrows_Click(sender As Object, e As EventArgs) Handles PictureBoxArrows.Click
        Try
            If UCMaximizeMinimizeStatus = MaxMin.Min Then
                UCMaximizeMinimizeStatus = MaxMin.Max
            ElseIf UCMaximizeMinimizeStatus = MaxMin.Max Then
                UCMaximizeMinimizeStatus = MaxMin.Min
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PictureBoxRefresh_Click(sender As Object, e As EventArgs) Handles PictureBoxRefresh.Click
        Try
            RaiseEvent UCIconRefreshRequestClicked()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBox_SizeChanged(sender As Object, e As EventArgs) Handles ListBox.SizeChanged
        ListBox.Size = New Size(ListBox.Width, PnlListBox.Size.Height - 6)
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class



