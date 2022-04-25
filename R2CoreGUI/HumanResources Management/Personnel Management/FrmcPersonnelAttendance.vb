
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection
Imports WindowsHookLib

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.DesktopProcessesManagement
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.RFIDCardsManagement
Imports R2CoreGUI

Public Class FrmcPersonnelAttendance
    Inherits FrmcGeneral
    Implements R2Core.RFIDCardsManagement.R2CoreRFIDCardRequester

    Private WithEvents _SupremaControlTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer
    Private WithEvents _HookKeyboard As New WindowsHookLib.KeyboardHook
    Private WithEvents _MinimizeWithDelayTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer
    Private _DateTime As R2DateTime = New R2DateTime()





#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
            InitialSuprema()
            _HookKeyboard.InstallHook()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreDesktopProcesses.FrmcPersonnelAttendance))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmRefresh()
        Try
            UcPersonnelImage.UCRefresh()
            'UcFingerPrintCapturerSuprema.SendToBack()
            PicNU1.Image = Nothing : PicNU2.Image = Nothing : PicNU3.Image = Nothing : PicNU4.Image = Nothing
            InitialSuprema()
            UcListBoxPersonnelEnterExit.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub InitialSuprema()
        Try
            UcFingerPrintCapturerSuprema.UCInitialize()
            _SupremaControlTimer.Interval = 1000
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub _ViewPersonelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
    Private Sub ViewPersonelImage(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            If (UcPersonnelImage.InvokeRequired) Then
                Dim myDelegate As _ViewPersonelImage = New _ViewPersonelImage(AddressOf ViewPersonelImage)
                Dim params() As Object = New Object() {}
                BeginInvoke(myDelegate, params)
            Else
                UcPersonnelImage.UCViewPersonnelImage(YourNSSPersonnel, R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                UcPersonnelImage.BringToFront()
            End If

            If (UcListBoxPersonnelEnterExit.InvokeRequired) Then
                Dim myDelegate As _ViewPersonelImage = New _ViewPersonelImage(AddressOf ViewPersonelImage)
                Dim params() As Object = New Object() {}
                BeginInvoke(myDelegate, params)
            Else
                UcListBoxPersonnelEnterExit.UCViewPersonnelEnterExit(YourNSSPersonnel)
            End If

            'نمایش تعداد ورود و خروج
            Dim NuFP As Integer = R2CorePersonnelMClassManagement.GetNumberOfEnterExitAtThisDay(YourNSSPersonnel)
            If NuFP >= 1 Then PicNU1.Image = My.Resources.GreenFP
            If NuFP >= 2 Then PicNU2.Image = My.Resources.RedFP
            If NuFP >= 3 Then PicNU3.Image = My.Resources.GreenFP
            If NuFP >= 4 Then PicNU4.Image = My.Resources.RedFP
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub CaptureFingerPrint()
        Try
            If UcFingerPrintCapturerSuprema.Scanner.IsCapturing = True Then Exit Sub
            FrmRefresh()
            UcFingerPrintCapturerSuprema.BringToFront()
            _SupremaControlTimer.Enabled = True
            _SupremaControlTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub DisposeRequesting()
        Try
            UcFingerPrintCapturerSuprema.UCDisposeResources()
            _SupremaControlTimer.Enabled = False
            _SupremaControlTimer.Stop()
            _HookKeyboard.RemoveHook()
            _HookKeyboard.Dispose()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonEnableHook_UCClickedEvent()
        Try
            _HookKeyboard.InstallHook()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDisableHook_UCClickedEvent()
        Try
            _HookKeyboard.RemoveHook()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _HookKeyboard_KeyUp(sender As Object, e As KeyboardEventArgs) Handles _HookKeyboard.KeyUp
        Try
            If e.KeyCode = 17 Then 'Ctrl Key
                'R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.UCActivateThisRefrence(Me)
                R2Core.RFIDCardsManagement.R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
                CaptureFingerPrint()
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _SupremaControlTimer_Tick(sender As Object, e As EventArgs) Handles _SupremaControlTimer.Tick
        Try
            If UcFingerPrintCapturerSuprema.CapturingStatus = True Then
                _SupremaControlTimer.Enabled = False
                _SupremaControlTimer.Stop()
                Dim NSSPersonnel As R2CoreStandardPersonnelStructure = R2CorePersonnelMClassManagement.IdentificationPersonnel(UcFingerPrintCapturerSuprema.CurrentTemplate, UcFingerPrintCapturerSuprema.GetSecurityLevel, UcFingerPrintCapturerSuprema.GetTemplateType)
                If NSSPersonnel Is Nothing Then
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "پرسنل تشخیص داده نشد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Else
                    ViewPersonelImage(NSSPersonnel)
                    R2CorePersonnelMClassManagement.InsertPersonnelPrecent(NSSPersonnel)
                    UcListBoxPersonnelEnterExit.UCViewPersonnelEnterExit(NSSPersonnel)
                End If
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcPersonnelAttendance__UCDisposeRequest() Handles Me._UCDisposeRequest
        Try
            DisposeRequesting()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcPersonnelAttendance__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            Dim NSSPersonnel As R2CoreStandardPersonnelStructure = R2CorePersonnelMClassManagement.GetNSSPersonnel(CardNo)
            ViewPersonelImage(NSSPersonnel)
            R2CorePersonnelMClassManagement.InsertPersonnelPrecent(NSSPersonnel)
            UcListBoxPersonnelEnterExit.UCViewPersonnelEnterExit(NSSPersonnel)
        Catch exx As GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class