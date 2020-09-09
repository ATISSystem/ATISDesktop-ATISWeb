
Imports System.Reflection
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcMoneyWalletReturnAmount
    Inherits FrmcGeneral


    Private _NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
    Private ReadOnly _DateTime As R2DateTime = New R2DateTime()



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcMoneyWalletReturnAmount))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


    Public Sub FrmRefresh()
        UcButton.UCEnable = True
        UcMoneyWallet.UCRefresh()
        UcMoney.UCValue = 0
    End Sub

    Private Sub ViewInf(YourCardNo As String)
        Try
            FrmRefresh()
            _NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourCardNo)
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTerafficCard)
            UcAccountingCollection.UCViewAccounting(_NSSTerafficCard)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub FrmcMoneyWalletReturnAmount__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            ViewInf(CardNo)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcTempExitTerafficCard__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            UcButton.UCEnable = False
            UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSSTerafficCard, BagPayType.AddMoney, UcMoney.UCValue, R2CoreParkingSystemAccountings.MoneyWalletReturnAmount)
            UcAccountingCollection.UCViewAccounting(_NSSTerafficCard)
            R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(0,R2CoreLogType.Note,"بازگشت مبلغ به کیف پول انجام گرفت",_NSSTerafficCard.CardNo,0,0,0,0,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId,_DateTime.GetCurrentDateTimeMilladiFormated(),_DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "بازگشت مبلغ به کیف پول انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcrfidCardTextMaintainer_UC13PressedEvent(YourText As String) Handles UcrfidCardTextMaintainer.UC13PressedEvent
        Try
            ViewInf(YourText)
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