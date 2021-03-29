
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class UCLoadAllocationManipulationByLoadCapacitorLoads
    Inherits UCGeneralExtended

    Public Event UCTurnIdEnteredEvent(NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCViewNSSLoadCapacitorLoad(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
        Try
            UcLoadAllocationManipulation.UCViewNSSLoadCapacitorLoad(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcLoadAllocationManipulation_UCTurnIdEnteredEvent(NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) Handles UcLoadAllocationManipulation.UCTurnIdEnteredEvent
        Try
            RaiseEvent UCTurnIdEnteredEvent(NSSTurn)
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
