
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad

Public Class UCLoadAllocationManipulationByLoadCapacitorLoads
    Inherits UCGeneralExtended


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public sub UCViewNSSLoadCapacitorLoad(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
        Try
            UcLoadAllocationManipulation.UCViewNSSLoadCapacitorLoad(YourNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class
