
Imports System.Reflection
Imports WindowsHookLib

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.ProcessesManagement

Public Class FrmcPersonnelAttendance
    Inherits FrmcGeneral


    Private WithEvents SupremaControlerTimer As Windows.Forms.Timer = New Windows.Forms.Timer
    Private _DateTime As R2DateTime = New R2DateTime()
    Private WithEvents HookKeyboard As New WindowsHookLib.KeyboardHook



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
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreProcesses.FrmcPersonnelAttendance))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmRefresh()
        Try
            UcFingerPrintCapturerSuprema.SendToBack()
            UcPersonnelImage.UCRefresh()
            PicNU1.Image = Nothing : PicNU2.Image = Nothing : PicNU3.Image = Nothing : PicNU4.Image = Nothing
            InitialSuprema()
            UcListBoxPersonnelEnterExit.UCRefresh()
            HookKeyboard.InstallHook()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub InitialSuprema()
        Try
            UcFingerPrintCapturerSuprema.UCInitialize()
            SupremaControlerTimer.Interval = 1000
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
                UcPersonnelImage.UCViewPersonnelImage(YourNSSPersonnel)
                UcPersonnelImage.BringToFront()
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
            SupremaControlerTimer.Enabled = True
            SupremaControlerTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private WithEvents RefreshTimer As Windows.Forms.Timer = New Windows.Forms.Timer
    Private Sub SupremaControlerTimer_Tick(sender As Object, e As EventArgs) Handles SupremaControlerTimer.Tick
        Try
            If UcFingerPrintCapturerSuprema.CapturingStatus = True Then
                SupremaControlerTimer.Enabled = False
                SupremaControlerTimer.Stop()
                Dim NSSPersonnel As R2CoreStandardPersonnelStructure = R2CorePersonnelMClassManagement.IdentificationPersonnel(UcFingerPrintCapturerSuprema.CurrentTemplate, UcFingerPrintCapturerSuprema.GetSecurityLevel, UcFingerPrintCapturerSuprema.GetTemplateType)
                If NSSPersonnel Is Nothing Then
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "پرسنل تشخیص داده نشد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Else
                    ViewPersonelImage(NSSPersonnel)
                    R2CorePersonnelMClassManagement.InsertPersonnelPrecent(NSSPersonnel)
                    UcListBoxPersonnelEnterExit.UCViewPersonnelEnterExit(NSSPersonnel)
                    RefreshTimer.Interval = 30000
                    RefreshTimer.Enabled = True
                    RefreshTimer.Start()
                End If
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcPersonnelAttendance__UCDisposeRequest() Handles Me._UCDisposeRequest
        Try
            SupremaControlerTimer.Enabled = False
            SupremaControlerTimer.Stop()
            HookKeyboard.RemoveHook()
            HookKeyboard.Dispose()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub HookKeyboard_KeyUp(ByVal sender As Object, ByVal e As WindowsHookLib.KeyboardEventArgs) Handles HookKeyboard.KeyUp
        Try
            If e.KeyCode = 17 Then
                R2CoreGUIMClassGUIManagement.FrmMainMenu.UcCollectionofUCActiveForm.UCActivateThisRefrence(Me)
                CaptureFingerPrint()
            End If 'Ctrl Key
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonEnableHook_UCClickedEvent() Handles UcButtonEnableHook.UCClickedEvent
        Try
            HookKeyboard.InstallHook()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDisableHook_UCClickedEvent() Handles UcButtonDisableHook.UCClickedEvent
        Try
            HookKeyboard.RemoveHook()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        Try
            RefreshTimer.Enabled = False
            RefreshTimer.Stop()
            FrmRefresh()
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
            RefreshTimer.Interval = 30000
            RefreshTimer.Enabled = True
            RefreshTimer.Start()
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