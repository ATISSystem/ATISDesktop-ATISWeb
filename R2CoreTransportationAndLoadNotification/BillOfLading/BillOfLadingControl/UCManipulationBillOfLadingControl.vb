
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControlInfraction
Imports R2CoreTransportationAndLoadNotification.ReportManagement

Public Class UCManipulationBillOfLadingControl
    Inherits UCBillOfLadingControl

    Public Event UCBillOfLadingControlDeletedEvent(BLCId As Int64)
    Private _WS As R2Core.R2PrimaryWS.R2PrimaryWebService = New R2Core.R2PrimaryWS.R2PrimaryWebService()


#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcViewerNSSBillOfLadingControlExtended.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCManipulationBillOfLadingControl_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            UcViewerNSSBillOfLadingControlExtended.UCViewNSS(UCNSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonAnalyzeBLC_UCClickedEvent() Handles UcButtonCButtonAnalyzeBLC.UCClickedEvent
        Try
            Dim NSS = R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlInfractionManagement.BillOfLadingControlInfractionAnalyze(R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlManagement.GetNSSBillOfLadingControl(UCNSSCurrent.BLCId))
            If MessageBox.Show("اطلاعات کنترل بارنامه بررسی شد" + vbCrLf + "آیا می خواهید نتیجه بررسی تخلفات در بانک اطلاعاتی ذخیره گردد ؟", "ATIS System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlInfractionManagement.BillOfLadingControlInfractionRegistering(NSS, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخلفات کنترل بارنامه در بانک اطلاعاتی ذخیره گردید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonDeleteBLC_UCClickedEvent() Handles UcButtonCButtonDeleteBLC.UCClickedEvent
        Try
            If MessageBox.Show("تصمیم دارید اطلاعات کنترل بارنامه را حذف نمایید", "ATIS System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlManagement.BillOfLadingControlDeleting(UCNSSCurrent.BLCId)
                UcViewerNSSBillOfLadingControlExtended.UCRefreshGeneral()
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "کنترل بارنامه با موفقیت حذف گردید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                RaiseEvent UCBillOfLadingControlDeletedEvent(UCNSSCurrent.BLCId)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonViewBLC_UCClickedEvent() Handles UcButtonCButtonViewBLC.UCClickedEvent
        Cursor.Current = Cursors.WaitCursor
        Try
            _WS.WebMethodReportingInformationProviderBillOfLadingControlReport(UcViewerNSSBillOfLadingControlExtended.UCNSSCurrent.BLCId, _WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword))
            R2CoreGUIMClassInformationManagement.PrintReport(R2CoreTransportationAndLoadNotificationReports.BillOfLadingControlReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
