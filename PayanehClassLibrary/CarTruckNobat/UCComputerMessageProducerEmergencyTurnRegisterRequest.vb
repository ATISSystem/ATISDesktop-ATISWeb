

Imports System.Reflection
Imports PayanehClassLibrary.TurnRegisterRequest.Exceptions
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions

Public Class UCComputerMessageProducerEmergencyTurnRegisterRequest
    Inherits UCComputerMessageProducer

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCEmergencyTurnRegisterRequest()
        Try
            TurnRegisterRequest.PayanehClassLibraryMClassTurnRegisterRequestManagement.EmergencyTurnRegisterRequest(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(UcCar.UCGetNSS.nIdCar), True, UcPersianTextBoxNote.UCValue, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
            OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
            OrElse TypeOf ex Is UserCanNotRequestEmergencyTurnRegisteringException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerEmergencyTurnRegisterRequest_UCRequestSend() Handles Me.UCRequestSend
        Try
            UCEmergencyTurnRegisterRequest()
            UCSuccessSendingNotification()
        Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
            OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
            OrElse TypeOf ex Is UserCanNotRequestEmergencyTurnRegisteringException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
