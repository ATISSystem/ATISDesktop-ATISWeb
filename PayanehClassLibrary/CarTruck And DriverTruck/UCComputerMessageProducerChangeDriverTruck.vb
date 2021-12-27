
Imports System.Drawing
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DriverTrucksManagement
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

Public Class UCComputerMessageProducerChangeDriverTruck
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

    Private Sub UCComputerMessageProducerChangeDriverTruck_UCRequestSend() Handles Me.UCRequestSend
        Try
            Dim InstanceDriverTrucks = New PayanehClassLibraryMClassDriverTrucksManager
            Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
            InstanceDriverTrucks.SendTruckDriverChangeRequestMessage(InstanceTrucks.GetNSSTruck(UcCarTruck.UCGetNSS.NSSCar.nIdCar), UcTextBoxTruckDriverNationalCode.UCValue, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCSuccessSendingNotification()
        Catch ex As Exception When TypeOf ex Is SqlInjectionException _
                               OrElse TypeOf ex Is PermissionException _
                               OrElse TypeOf ex Is DataEntryException _
                               OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                               OrElse TypeOf ex Is TerraficCardNotFoundException _
                               OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                               OrElse TypeOf ex Is MoneyWalletNotExistException _
                               OrElse TypeOf ex Is GetNSSException _
                               OrElse TypeOf ex Is GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCGotFocusEvent()
        Try
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
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
