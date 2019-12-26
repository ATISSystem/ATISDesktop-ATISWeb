
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns


Public Class UCViewerNSSTurnDataEntry
    Inherits UCTurn

    Public Event UC13PressedEvent()
    Private _FrmMessageDialog As FrmcMessageDialog


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _FrmMessageDialog = New FrmcMessageDialog()
            UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewInformation()
        Try
            Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = UCNSSCurrent
            UcNumberTurnId.UCValue = Mid(NSS.OtaghdarTurnNumber,7,20)
            UcLabelTruck.UCValue = NSS.LicensePlatePString
            UcLabelTruckDriver.UCValue = NSS.TruckDriver
            UcLabelDateTimeComposite.UCValue = NSS.EnterDate + " - " + NSS.EnterTime
            UcLabelTurnStatus.UCValue = NSS.TurnStatusTitle
            UcucSequentialTurnCollection.UCSimulateThisNSS(R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(UCNSSCurrent))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        UcNumberTurnId.UCRefresh()
        UcLabelTruck.UCRefresh()
        UcLabelTruckDriver.UCRefresh()
        UcLabelDateTimeComposite.UCRefresh()
        UcLabelTurnStatus.UCRefresh()
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcNumberTurnId_UC13Pressed(UserNumber As String) Handles UcNumberTurnId.UC13Pressed
        Try
            UCNSSCurrent = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(UcucSequentialTurnCollection.UCCurrentNSS.SequentialTurnId,UcNumberTurnId.UCValue)
            UCViewInformation()
            RaiseEvent UC13PressedEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSTurnDataEntry_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewInformation()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSTurnDataEntry_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        UcNumberTurnId.UCFocus()
    End Sub

    Private Sub UcucSequentialTurnCollection_UCCurrentNSSChangedEvent() Handles UcucSequentialTurnCollection.UCCurrentNSSChangedEvent
        UcNumberTurnId.UCFocus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
