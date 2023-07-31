
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTruckNobatManagement.Exceptions
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.DriverTrucksManagement.Exceptions
Imports PayanehClassLibrary.RequesterManagement
Imports PayanehClassLibrary.TurnRegisterRequest
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class UCComputerMessageEmergencyTurnRegisterRequestConfirmation
    Inherits UCComputerMessage

    'Note Data1=nCarId Data2=TurnRegisterRequestId


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
            Dim InstanceTurnRegisterRequest = New PayanehClassLibraryMClassTurnRegisterRequestManager
            InstanceTurnRegisterRequest.EmergencyTurnRegister(_NSS.DataStruct, True, PayanehClassLibraryRequesters.UCComputerMessageEmergencyTurnRegisterRequestConfirmation, TurnType.Permanent, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS, False)
            UCDeactiveComputerMessage()
        Catch ex As Exception When TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException OrElse TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException OrElse TypeOf ex Is DriverTruckInformationNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, True)
        End Try
        UcButtonConfirmation.UCEnable = False
    End Sub

    Private Sub UCComputerMessageEmergencyTurnRegisterRequestConfirmation_UCViewNSSCompleted() Handles Me.UCViewNSSCompleted
        Try
            Dim NSSDriverTruck As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSS.DataStruct.Data1))
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
