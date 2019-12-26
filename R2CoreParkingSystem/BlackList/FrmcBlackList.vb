
Imports System.Reflection
Imports R2Core.ExceptionManagement

Imports R2Core.ProcessesManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcBlackList
    Inherits FrmcGeneral

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcBlackList))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


    Public Sub FrmRefresh()
        Try
            UcMoneyWallet.UCRefresh()
            UcucBlackListCollection.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcucBlackListCollection_UCPardakhtRequestEvent(NSSBlackList As R2StandardBlackListStructure, Mblgh As Long) Handles UcucBlackListCollection.UCPardakhtRequestEvent
        Try
            Dim nIdCar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCar(New R2StandardLicensePlateStructure(NSSBlackList.nTruckNo, NSSBlackList.nPlakSerial, R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(NSSBlackList.nPlakPlac), R2PelakType.None))
            Dim _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(nIdCar))
            If UcMoneyWallet.UCGetMoneyWalletCurrentCharge >= Mblgh Then
                UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.MinusMoney, Mblgh, R2CoreParkingSystemAccountings.BlackList)
                R2CoreParkingSystemMClassBlackList.ChangeBlackListMblgh(NSSBlackList,Mblgh)
            Else
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "موجودی کیف پول کافی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucBlackListCollection_UCViewInformationCompleted(CarId As String) Handles UcucBlackListCollection.UCViewInformationCompleted
        Try
            Dim _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(CarId))
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTrafficCard)
        Catch exx As GetDataException
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