
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.DataBaseManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.ExceptionManagement
Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class FrmcAnnouncementHallAutomation
    Inherits FrmcGeneral



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefresh()
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcAnnouncementHallAutomation))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        UcCarAndDriverPresenter.UCRefresh()
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyCarId(CarId)
            UcViewerTankTreiler.UCViewTankTreilerStatus(NSSCarTruck)
            UcMoneyWallet.UCRefresh()
            UcCarAndDriverPresenter.UCRefresh()
            UcucCarTruckNobatCollection.UCRefresh()
            UcCarEnterExitStatus.UCRefresh()
            Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(CarId))
                UcMoneyWallet.UCViewMoneyWalletOnlyCharge(NSSTerafficCard)
                UcCarEnterExitStatus.UCViewStatus(NSSTerafficCard)
            Catch ex As Exception
                FrmcViewLocalMessage("اطلاعات پایه کارت تردد و خودرو و روابط آن ها تکمیل نیست")
            End Try
            UcCarAndDriverPresenter.UCSetCar(CarId)
            UcucCarTruckNobatCollection.UCViewCollection(NSSCarTruck)
        Catch exx As GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exxx As GetDataException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exxx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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