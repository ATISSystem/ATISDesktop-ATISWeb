
Imports System.Reflection
Imports R2Core.ExceptionManagement

Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.Drivers

Public Class UCCarAndDriverPresenter
    Inherits UCCarAndDriver



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"



    Public Sub UCRefresh()
        UcLabelCar.UCValue = ""
        UcLabelDriverFirst.UCValue = ""
        UcLabelDriverSecond.UCValue = ""
    End Sub
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCCarAndTrafficCard_UCCarWasSetEvent(nIdCar As Long) Handles Me.UCCarWasSetEvent
        Try
            UcLabelCar.UCValue = R2CoreParkingSystemMClassCars.GetNSSCar(nIdCar).GetCarPelakSerialComposit()
            Try
                UcLabelDriverFirst.UCValue = R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(nIdCar)).StrPersonFullName
                UcLabelDriverSecond.UCValue = R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonSecond(nIdCar)).StrPersonFullName
            Catch exxx As GetDataException
            Catch exx As GetNSSException
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCCarAndTrafficCard_UCCarNotExistEvent() Handles Me.UCCarNotExistEvent
        UCRefresh()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
