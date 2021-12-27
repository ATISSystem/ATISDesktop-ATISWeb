

Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTruckNobatManagement.Exceptions
Imports PayanehClassLibrary.DriverTrucksManagement.Exceptions
Imports PayanehClassLibrary.TurnRegisterRequest
Imports PayanehClassLibrary.TurnRegisterRequest.Exceptions
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class UCResuscitationReserveTurn
    Inherits UCGeneral


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

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            UcDriver.UCRefreshGeneral()
            UcDriver.UCViewDriverInformation(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
        Catch ex As Exception When TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
            UcDriverImage.UCViewDriverImage(DriverTrucksManagement.PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId)).NSSDriver)
        Catch ex As Exception
        End Try
        UCButtonResuscitation.UCEnable = True
    End Sub

    Private Sub UCButtonResuscitation_UCClickedEvent() Handles UCButtonResuscitation.UCClickedEvent
        Try
            UCButtonResuscitation.UCEnable = False
            PayanehClassLibraryMClassTurnRegisterRequestManagement.ResuscitationReserveTurn(UcNumberTRRId.UCValue, R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(UcCar.UCGetNSS().nIdCar), True, PayanehClassLibrary.RequesterManagement.PayanehClassLibraryRequesters.UCResuscitationReserveTurn, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "نوبت رزرو با موفقیت احیاء شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is TurnRegisteringRequestIdIsNotaReserveTypeException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnNotFoundException _
                                OrElse TypeOf ex Is ReserveTurnAlreadyUsedException _
                                OrElse TypeOf ex Is TurnRegisteringRequestDateTimeExpiredException _
                                OrElse TypeOf ex Is UserCanNotResuscitationReserveTurnException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException
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
