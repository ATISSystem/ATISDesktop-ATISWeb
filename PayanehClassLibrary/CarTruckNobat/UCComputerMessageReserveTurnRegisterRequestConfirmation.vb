

Imports System.Reflection
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.TurnRegisterRequest
Imports R2Core.ExceptionManagement
Imports R2Core.RFIDCardsManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class UCComputerMessageReserveTurnRegisterRequestConfirmation
    Inherits UCComputerMessage



    'Note Data1=TRRId Data2=TurnRegisterCardId


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

    Private Sub UcButtonConfirmation_UCClickedEvent() Handles UcButtonConfirmation.UCClickedEvent
        Try
            StartReading()

        Catch ex As Exception When TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, True)
        End Try
        UcButtonConfirmation.UCEnable = False
    End Sub

    Private Sub UCComputerMessageReserveTurnRegisterRequestConfirmation__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            Dim NSSTurnRegisterCard =R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            If NSSTurnRegisterCard.CardId = _NSS.DataStruct.Data2 Then
                PayanehClassLibraryMClassTurnRegisterRequestManagement.ReserveTurnRegisterRequest(NSSTurnRegisterCard,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCDeactiveComputerMessage()
            Else
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning,"", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
            End If
        Catch ex As Exception

        End Try
        StartReading()
    End Sub

    Private Sub UCComputerMessageReserveTurnRegisterRequestConfirmation__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    'Private Sub UCComputerMessageEmergencyTurnRegisterRequestConfirmation_UCViewNSSCompleted() Handles Me.UCViewNSSCompleted
    '    Try
    '        Dim NSSDriverTruck As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSS.DataStruct.Data1))
    '        Try
    '            UcDriverImage.UCViewDriverImage(NSSDriverTruck.NSSDriver)
    '        Catch ex As Exception
    '        End Try
    '    Catch ex As Exception
    '        UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
    '    End Try
    'End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
