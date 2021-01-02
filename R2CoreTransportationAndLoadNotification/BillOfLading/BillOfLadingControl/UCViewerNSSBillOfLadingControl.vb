
Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.LoadPermission

Public Class UCViewerNSSBillOfLadingControl
    Inherits UCBillOfLadingControl

    Public Event UCClickedEvent(UC As UCViewerNSSBillOfLadingControl)


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

    Private Sub UcLabels_UCClickedEvent() Handles UcLabelTime.UCClickedEvent, UcLabelDateShamsi.UCClickedEvent, UcLabelBLCTitle.UCClickedEvent
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSBillOfLadingControl_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlStructure) Handles Me.UCViewNSSRequested
        Try
            UcLabelDateShamsi.UCValue = NSSCurrent.DateShamsi
            UcLabelTime.UCValue = NSSCurrent.Time
            UcLabelBLCTitle.UCValue = NSSCurrent.BLCTitle
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
