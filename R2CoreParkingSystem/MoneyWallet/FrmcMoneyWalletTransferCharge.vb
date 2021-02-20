
Imports System.Reflection
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement

Imports R2Core.DesktopProcessesManagement
Imports R2Core.RFIDCardsManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcMoneyWalletTransferCharge
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime = New R2DateTime()

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
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcMoneyWalletTransferCharge))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub SourceHandle(YourCardNo As String)
        Try
            Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure
            NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourCardNo)
            UcMoneyWalletSource.UCViewMoneyWalletOnlyCharge(NSSTrafficCard)
            UcrfidCardTextMaintainerSource.UCValue = NSSTrafficCard.CardNo
            UcMoney.UCValue = R2CoreParkingSystem.MoneyWalletManagement.R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub TargetHandle(YourCardNo As String)
        Try
            Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure
            NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourCardNo)
            UcMoneyWalletTarget.UCViewMoneyWalletOnlyCharge(NSSTrafficCard)
            UcrfidCardTextMaintainerTarget.UCValue = NSSTrafficCard.CardNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        UcMoneyWalletSource.UCRefresh()
        UcMoneyWalletTarget.UCRefresh()
        UcrfidCardTextMaintainerSource.UCRefresh()
        UcrfidCardTextMaintainerTarget.UCRefresh()
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcTransferMoneyWalletCharge__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            If OpbSource.Checked = True Then
                SourceHandle(CardNo)
            ElseIf OpbTarget.Checked = True Then
                TargetHandle(CardNo)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcTransferMoneyWalletCharge__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    Private Sub UcrfidCardTextMaintainerSource_UC13PressedEvent(YourText As String) Handles UcrfidCardTextMaintainerSource.UC13PressedEvent
        Try
            SourceHandle(YourText)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcrfidCardTextMaintainerTarget_UC13PressedEvent(YourText As String) Handles UcrfidCardTextMaintainerTarget.UC13PressedEvent
        Try
            TargetHandle(YourText)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonTransfer_UCClickedEvent() Handles UcButtonTransfer.UCClickedEvent
        Try
            UcButtonTransfer.UCEnable = False
            Dim Charge As Int64 = UcMoney.UCValue
            If Charge >= 0 Then
                UcMoneyWalletSource.UCViewandActMoneyWalletNextStatus(UcMoneyWalletSource.UCGetTrafficCard, BagPayType.MinusMoney, Charge, R2CoreParkingSystemAccountings.TransferallChargeToAnother)
            Else
                UcMoneyWalletSource.UCViewandActMoneyWalletNextStatus(UcMoneyWalletSource.UCGetTrafficCard, BagPayType.AddMoney, Math.Abs(Charge), R2CoreParkingSystemAccountings.TransferallChargeToAnother)
            End If
            UcMoneyWalletTarget.UCViewandActMoneyWalletNextStatus(UcMoneyWalletTarget.UCGetTrafficCard, BagPayType.AddMoney, Charge, R2CoreParkingSystemAccountings.TransferallChargeToAnother)
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "انتقال موجودی انجام گرفت" + vbCrLf + UcMoneyWalletSource.UCGetTrafficCard.CardNo + " " + UcMoneyWalletTarget.UCGetTrafficCard.CardNo, UcMoneyWalletSource.UCGetTrafficCard.CardNo + " " + UcMoneyWalletTarget.UCGetTrafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "انتقال موجودی انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcMoneyWalletTransferCharge__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlTransfer" Then
                If OpbSource.Checked = True Then UcAccountingCollection.UCViewAccounting(UcMoneyWalletSource.UCGetTrafficCard)
                If OpbTarget.Checked = True Then UcAccountingCollection.UCViewAccounting(UcMoneyWalletTarget.UCGetTrafficCard)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcMoneyWalletTransferCharge__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent
    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class