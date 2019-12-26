
Imports System.Reflection

Imports R2Core.ProcessesManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement


Public Class FrmcMoneyWalletCharge
    Inherits FrmcGeneral

    Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing

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
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcMoneyWalletCharge))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcMoneyWalletCharge_UCMoneyWalletChargedEvent(Mblgh As Long) Handles UcMoneyWalletCharge.UCMoneyWalletChargedEvent
        Try
            UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.UCViewChargeSavabegh(_NSSTrafficCard)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyWalletCharge_UCMoneyWalletChargeUserCanceledEvent() Handles UcMoneyWalletCharge.UCMoneyWalletChargeUserCanceledEvent
        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmMoneyWalletCharge__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            _NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            UcMoneyWalletCharge.UCPrepare(_NSSTrafficCard)
            UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.UCViewChargeSavabegh(_NSSTrafficCard)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmMoneyWalletCharge__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent
    End Sub

    Private Sub FrmcMoneyWalletCharge__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent
        Try
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcMoneyWalletCharge__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletChargeSavabegh" Then
                UcMoneyWalletChargeSavabeghCollection.UCViewChargeSavabegh(_NSSTrafficCard)
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlAccounting" Then
                UcAccountingCollection.UCViewAccounting(_NSSTrafficCard)
            End If
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