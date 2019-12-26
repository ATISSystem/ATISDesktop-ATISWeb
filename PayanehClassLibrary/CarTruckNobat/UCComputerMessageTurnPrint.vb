
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrinting

Public Class UCComputerMessageTurnPrint
    Inherits UCComputerMessage




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

    Private Sub UcButtonNobatPrint_UCClickedEvent() Handles UcButtonNobatPrint.UCClickedEvent
        Try
            R2CoreTransportationAndLoadNotificationMClassTurnPrintingManagement.TurnPrint(_NSS.DataStruct.Data1)
            UCDeactiveComputerMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        UcButtonNobatPrint.UCEnable = False
    End Sub

    Private Sub UCComputerMessageTurnPrint_UCViewNSSCompleted() Handles Me.UCViewNSSCompleted
        Try
            Dim NSSDriverTruck As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(_NSS.DataStruct.Data1).NSSCar.nIdCar))
            Try
                UcDriverImage.UCViewDriverImage(NSSDriverTruck.NSSDriver)
            Catch ex As Exception
            End Try
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
