
Imports System.Reflection
Imports PayanehClassLibrary.ProcessesManagement
Imports PayanehClassLibrary.TruckersAssociationControllingMoneyWallet
Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement

Public Class FrmcTruckersAssociationControllingMoneyWallet
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
            FrmcRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcTruckersAssociationControllingMoneyWallet))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmcRefresh()
        Try
            UcMoneyWalletCharge.StartReading()
            PreparingUCMoneyWallet()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PreparingUCMoneyWallet()
        Try
            Dim NSS = TruckersAssociationControllingMoneyWalletManagement.GetNSSMoneyWallet()
            Dim Amount = Math.Abs(R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSS))
            UcMoneyWalletCharge.UCPrepare(NSS, Amount)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcTruckersAssociationControllingMoneyWallet__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent


    End Sub

    Private Sub FrmcTruckersAssociationControllingMoneyWallet__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletCharging" Then
                UcMoneyWalletCharge.StartReading()
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletAccounting" Then
                UcAccountingCollection.UCViewAccounting(TruckersAssociationControllingMoneyWalletManagement.GetNSSMoneyWallet())
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