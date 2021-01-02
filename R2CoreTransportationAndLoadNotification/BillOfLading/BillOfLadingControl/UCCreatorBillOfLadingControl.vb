Imports System.Data.OleDb
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports R2Core.ExceptionManagement

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.Exceptions

Public Class UCCreatorBillOfLadingControl
    Inherits UCGeneral

    Public Event UCBillOfLadingControlCreatedEvent(BLCId As Int64)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonPathOfFile_UCClickedEvent() Handles UcButtonPathOfFile.UCClickedEvent
        Try
            Dim FDialog = New OpenFileDialog
            If FDialog.ShowDialog() Then
                If FDialog.CheckFileExists Then
                    UcTextBoxPathOfFile.UCValue = FDialog.FileName
                Else
                    Throw New FileNotFoundException
                End If
            End If
        Catch ex As FileNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonTransferInformation_UCClickedEvent() Handles UcButtonTransferInformation.UCClickedEvent
        Try
            Dim NSSBillOfLadingControl = R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlManagement.ReadBillOfLadingControl(UcTextBoxPathOfFile.UCValue)
            NSSBillOfLadingControl.BLCTitle = UcPersianTextBoxBLCTitle.UCValue
            If MessageBox.Show("اطلاعات فایل کنترل بارنامه در بانک اطلاعاتی ذخیره گردد؟", "ATIS System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                Dim BLCId = R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlManagement.BillOfLadingControlRegistering(NSSBillOfLadingControl, R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser())
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اطلاعات فایل کنترل بارنامه با موفقیت در بانک اطلاعاتی ذخیره گردید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                RaiseEvent UCBillOfLadingControlCreatedEvent(BLCId)
            End If
        Catch ex As  BillOfLadingControlMustHaveTitleForRegisteringException
UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As ReadingBillOfLadingControlFailedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxBLCTitle_UCGotFocusEvent() Handles UcPersianTextBoxBLCTitle.UCGotFocusEvent
        Try
            UcPersianTextBoxBLCTitle.UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
