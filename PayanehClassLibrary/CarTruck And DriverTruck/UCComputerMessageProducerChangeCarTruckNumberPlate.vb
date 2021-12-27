

Imports System.Drawing
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.ExceptionManagement
Imports R2Core.PermissionManagement.Exceptions
Imports R2Core.RFIDCardsManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.TrafficCardsManagement.ExceptionManagement
Imports R2CoreTransportationAndLoadNotification.Trucks

Public Class UCComputerMessageProducerChangeCarTruckNumberPlate
    Inherits UCComputerMessageProducer


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

    Private Sub UCComputerMessageProducerChangeCarTruckNumberPlate_UCRequestSend() Handles Me.UCRequestSend
        Try
            Dim InstanceCarTrucks = New PayanehClassLibraryMClassCarTrucksManager
            Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager

            InstanceCarTrucks.SendTruckChangeRequestMessage(InstanceTrucks.GetNSSTruck(UcCarTruck.UCGetNSS.NSSCar.nIdCar), UcPersianTextBoxNewTruck.UCValue, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCSuccessSendingNotification()
        Catch ex As Exception When TypeOf ex Is SqlInjectionException _
                               OrElse TypeOf ex Is PermissionException _
                               OrElse TypeOf ex Is DataEntryException _
                               OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                               OrElse TypeOf ex Is TerraficCardNotFoundException _
                               OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                               OrElse TypeOf ex Is MoneyWalletNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
