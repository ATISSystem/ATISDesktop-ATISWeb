
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.ExceptionManagement


Public Class UCComputerMessageProducerTurnPrintRequest
    Inherits UCComputerMessageProducer

    'Note Data1=TurnId


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

   


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerTurnPrint_UCRequestSend() Handles Me.UCRequestSend
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
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
