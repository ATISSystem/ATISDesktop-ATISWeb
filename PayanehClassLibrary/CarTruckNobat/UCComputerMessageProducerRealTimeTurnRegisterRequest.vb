
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class UCComputerMessageProducerRealTimeTurnRegisterRequest
    Inherits UCComputerMessageProducer


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRealTimeTurnRegisterRequest()
        Try
            Dim NSSTruckTemp = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(UcCar.UCGetNSS.nIdCar)
            'کنترل حضور ناوگان در پارکینگ - درصورتی که طبق کانفیگ باید حضورداشته باشد ولی حضور نداشته باشد آنگاه اکسپشن پرتاب می گردد
            R2CoreTransportationAndLoadNotificationMClassTurnsManagement.TruckPresentInParkingForTurnRegisteringControl(NSSTruckTemp)
            TurnRegisterRequest.PayanehClassLibraryMClassTurnRegisterRequestManagement.RealTimeTurnRegisterRequest(NSSTruckTemp, True, True, Nothing, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerRealTimeTurnRegisterRequest_UCRequestSend() Handles Me.UCRequestSend
        Try
            UCRealTimeTurnRegisterRequest()
            UCSuccessSendingNotification()
        Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception When TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Information, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            UcDriver.UCViewDriverInformation(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات راننده کامل نیست", "به اتاق کامپیوتر مراجعه نمایید", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Exit Sub
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            Exit Sub
        End Try

        Try
            UcCarImage.UCViewCarEnterExitImage(UcCar.UCGetNSS())
        Catch ex As Exception
        End Try
        Try
            UcDriverImage.UCViewDriverImage(PayanehClassLibrary.DriverTrucksManagement.PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId)).NSSDriver)
        Catch ex As Exception
        End Try
        UCSendIsActive = True
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
