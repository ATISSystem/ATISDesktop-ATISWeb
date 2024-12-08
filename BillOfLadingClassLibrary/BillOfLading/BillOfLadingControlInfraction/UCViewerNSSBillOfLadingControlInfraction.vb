
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControlInfraction


Public Class UCViewerNSSBillOfLadingControlInfraction
    Inherits UCBillOfLadingControlInfraction

    Public Event UCClickedEvent(UC As UCViewerNSSBillOfLadingControlInfraction)


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

    Private Sub UCViewerNSSBillOfLadingControlInfraction_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlInfractionStructure) Handles Me.UCViewNSSRequested
        Try
            PnlInner.BackColor=UCBackColor
            Dim NSSExtended = DirectCast(NSSCurrent, R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlInfractionExtendedStructure)
            UcLabelDateShamsi.UCValue = NSSExtended.DateShamsi
            UcLabelTime.UCValue = NSSExtended.Time
            UcLabelBLCTitle.UCValue = NSSExtended.BLCTitle
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
