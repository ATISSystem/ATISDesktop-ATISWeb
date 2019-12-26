
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
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

Public Class FrmcTempExitTerafficCard
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
        FrmRefreshGeneral()
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcTempExitTerafficCard))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefreshGeneral()
        UcButtonTaeed.UCEnable = True
        UcrfidCardTextMaintainer.UCRefresh()
        UcMoneyWallet.UCRefresh()
        UcMoney.UCValue = 0
    End Sub

    Public Sub FrmRefresh()
        UcButtonTaeed.UCEnable = True
        UcMoneyWallet.UCRefresh()
        UcMoney.UCValue = 0
    End Sub

    Private Sub SetTerraficCard(YourTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            _NSSTerafficCard = YourTerraficCard
            FrmRefresh()
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTerafficCard)
            UcrfidCardTextMaintainer.UCValue = _NSSTerafficCard.CardNo
            UcAccountingCollection.UCViewAccounting(_NSSTerafficCard)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    'Private Sub BtnAccountingReport_Click(sender As Object, e As EventArgs) 
    '    Try
    '        UcAccountingCollection.UCViewAccounting(_NSSTerafficCard)
    '        'PnlAccountingReport.BringToFront()
    '        'PnlAccountingReport.Focus()
    '    Catch ex As Exception
    '        _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
    '    End Try
    'End Sub

    Private Sub FrmcTempExitTerafficCard__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            SetTerraficCard(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo))
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

    Private Sub UcrfidCardTextMaintainer_UC13PressedEvent(YourText As String) Handles UcrfidCardTextMaintainer.UC13PressedEvent
        Try
            SetTerraficCard(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourText))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonTaeed_UCClickedEvent() Handles UcButtonTaeed.UCClickedEvent
        Try
            R2CoreParkingSystemMClassEnterExitManagement.ExitTempTerafficCard(_NSSTerafficCard, UcMoney.UCValueWithoutComa)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "خروج موقت کارت تردد انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As TerafficCardLastExitedException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت تردد قبلا خروج شده است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exxx As MoneyWalletCurrentChargeNotEnoughException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "موجودی کافی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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