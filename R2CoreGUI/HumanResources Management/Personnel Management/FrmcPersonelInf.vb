
Imports System.Globalization
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.DateAndTimeManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.ProcessesManagement
Imports R2CoreGUI

Public Class FrmcPersonelInf
    Inherits FrmcGeneral

    Private WithEvents SupremaControlerTimer As Windows.Forms.Timer = New Windows.Forms.Timer
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
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreProcesses.FrmcPersonnelInf))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmRefresh()
        Try
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


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersonnelPnlPersonnelImage_UCViewPersonnelInformationCompleted(PersonnelId As Long) Handles UcPersonnelPnlPersonnelImage.UCViewPersonnelInformationCompleted
        Try
            UcPersonnelImage.UCViewPersonnelImage(R2CorePersonnelMClassManagement.GetNSSPersonnel(PersonnelId))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonPersonnelImageSave_UCClickedEvent() Handles UcButtonPersonnelImageSave.UCClickedEvent
        Try
            UcPersonnelImage.UCSavePersonnelImage(UcPersonnelPnlPersonnelImage.UCGetNSS())
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تصویر پرسنل ذخیره شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSelectPersonnelImage_UCClickedEvent() Handles UcButtonSelectPersonnelImage.UCClickedEvent
        Try
            Dim Dialog As New OpenFileDialog
            If Dialog.ShowDialog = DialogResult.OK Then
                UcPersonnelImage.UCViewImage(New R2CoreImage(Image.FromFile(Dialog.FileName)))
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcPersonelInf__UCDisposeRequest() Handles Me._UCDisposeRequest
        Try
            SupremaControlerTimer.Enabled = False
            SupremaControlerTimer.Stop()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersonnelPnlPersonnelFingerPrints_UCViewPersonnelInformationCompleted(PersonnelId As Long) Handles UcPersonnelPnlPersonnelFingerPrints.UCViewPersonnelInformationCompleted
        Try
            UcButtonRegisteringFingerPrint1.UCEnable = True
            UcButtonRegisteringFingerPrint2.UCEnable = True
            UcButtonRegisteringFingerPrint3.UCEnable = True
            UcButtonRegisteringFingerPrint4.UCEnable = True
            InitialSuprema()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub SupremaControlerTimer_Tick(sender As Object, e As EventArgs) Handles SupremaControlerTimer.Tick
        Try
            If UcFingerPrintCapturerSuprema.CapturingStatus = True Then
                SupremaControlerTimer.Enabled = False
                SupremaControlerTimer.Stop()
                UcButtonRegisteringFingerPrint1.UCEnable = False
                UcButtonRegisteringFingerPrint2.UCEnable = False
                UcButtonRegisteringFingerPrint3.UCEnable = False
                UcButtonRegisteringFingerPrint4.UCEnable = False
                UcFingerPrintCapturerSuprema.Visible = False
                If WhichFP = R2CorePersonnelWhichFingerPrint.FP1 Then
                    R2CorePersonnelMClassManagement.SavePersonnelFingerPrints(UcPersonnelPnlPersonnelFingerPrints.UCGetNSS(), R2CorePersonnelWhichFingerPrint.FP1, UcFingerPrintCapturerSuprema.CurrentTemplate)
                    R2CorePersonnelMClassManagement.SavePersonnelFingerPrints(UcPersonnelPnlPersonnelFingerPrints.UCGetNSS(), R2CorePersonnelWhichFingerPrint.FP2, UcFingerPrintCapturerSuprema.CurrentTemplate)
                    R2CorePersonnelMClassManagement.SavePersonnelFingerPrints(UcPersonnelPnlPersonnelFingerPrints.UCGetNSS(), R2CorePersonnelWhichFingerPrint.FP3, UcFingerPrintCapturerSuprema.CurrentTemplate)
                    R2CorePersonnelMClassManagement.SavePersonnelFingerPrints(UcPersonnelPnlPersonnelFingerPrints.UCGetNSS(), R2CorePersonnelWhichFingerPrint.FP4, UcFingerPrintCapturerSuprema.CurrentTemplate)
                Else
                    R2CorePersonnelMClassManagement.SavePersonnelFingerPrints(UcPersonnelPnlPersonnelFingerPrints.UCGetNSS(), WhichFP, UcFingerPrintCapturerSuprema.CurrentTemplate)
                End If
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اثر انگشت با موفقیت ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private WhichFP As R2CorePersonnelWhichFingerPrint
    Private Sub UcButtonRegisteringFingerPrint1_UCClickedEvent() Handles UcButtonRegisteringFingerPrint1.UCClickedEvent
        Try
            WhichFP = R2CorePersonnelWhichFingerPrint.FP1
            UcFingerPrintCapturerSuprema.Visible = True
            SupremaControlerTimer.Enabled = True
            SupremaControlerTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonRegisteringFingerPrint2_UCClickedEvent() Handles UcButtonRegisteringFingerPrint2.UCClickedEvent
        Try
            WhichFP = R2CorePersonnelWhichFingerPrint.FP2
            UcFingerPrintCapturerSuprema.Visible = True
            SupremaControlerTimer.Enabled = True
            SupremaControlerTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonRegisteringFingerPrint3_UCClickedEvent() Handles UcButtonRegisteringFingerPrint3.UCClickedEvent
        Try
            WhichFP = R2CorePersonnelWhichFingerPrint.FP3
            UcFingerPrintCapturerSuprema.Visible = True
            SupremaControlerTimer.Enabled = True
            SupremaControlerTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonRegisteringFingerPrint4_UCClickedEvent() Handles UcButtonRegisteringFingerPrint4.UCClickedEvent
        Try
            WhichFP = R2CorePersonnelWhichFingerPrint.FP4
            UcFingerPrintCapturerSuprema.Visible = True
            SupremaControlerTimer.Enabled = True
            SupremaControlerTimer.Start()
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonInsertpersonnelPresent_UCClickedEvent() Handles UcButtonInsertpersonnelPresent.UCClickedEvent
        Try
            R2CorePersonnelMClassManagement.InsertPersonnelPrecentAtThisDateTime(UcPersonnelPnlInsertPersonnelPresent.UCGetNSS(), New R2StandardDateAndTimeStructure(DateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), _DateTime.ConvertToShamsiDateFull(DateTimePicker.Value), _DateTime.GetTimeOfDate(DateTimePicker.Value)))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, " حاضری پرسنل ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcPersonelInf__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent

    End Sub

    Private Sub FrmcPersonelInf__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlPersonnelInfList" Then
                UcucPersonnelCollection.UCViewPersonnelsByUCPersonnel()
            End If
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