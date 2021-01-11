
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControlInfraction


Public Class UCManipulationBillOfLadingControlInfraction
    Inherits UCBillOfLadingControlInfraction

    Public Event UCBillOfLadingControlInfractionDeletedEvent(BLCIId As Int64)


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
            UcViewerNSSBillOfLadingControlInfractionExtended.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCManipulationBillOfLadingControlInfraction_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            UcViewerNSSBillOfLadingControlInfractionExtended.UCViewNSS(UCNSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonCButtonDeleteBLCI_UCClickedEvent() Handles UcButtonCButtonDeleteBLCI.UCClickedEvent
        Try
            If MessageBox.Show("تصمیم دارید اطلاعات تخلفات کنترل بارنامه را حذف نمایید", "ATIS System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
                R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlInfractionManagement.BillOfLadingControlInfractionDeleting(UCNSSCurrent.BLCIId)
                UcViewerNSSBillOfLadingControlInfractionExtended.UCRefreshGeneral()
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخلفات کنترل بارنامه با موفقیت حذف گردید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                RaiseEvent UCBillOfLadingControlInfractionDeletedEvent(UCNSSCurrent.BLCId)
            End If
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
