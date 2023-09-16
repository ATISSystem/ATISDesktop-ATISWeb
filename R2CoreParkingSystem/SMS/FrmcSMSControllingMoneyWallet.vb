
Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2Core.PermissionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.SMS.SMSControllingMoneyWallet

Public Class FrmcSMSControllingMoneyWallet
    Inherits FrmcGeneral

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Sub New()

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
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreDesktopProcesses.FrmcSMSControllingMoneyWallet))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmcRefresh()
        Try
            PreparingUCMoneyWallet()
            Dim InstancePermissions = New R2CoreInstansePermissionsManager
            If Not InstancePermissions.ExistPermission(R2CorePermissionTypes.UserCanChargeSMSControllingMoneyWallet, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, 0) Then PnlMoneyWalletCharging.Enabled = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PreparingUCMoneyWallet()
        Try
            Dim NSS = R2CoreParkingSystemMClassSMSControllingMoneyWalletManagement.GetNSSMoneyWallet()
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

    Private Sub FrmcSMSControllingMoneyWallet__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent
    End Sub

    Private Sub FrmcSMSControllingMoneyWallet__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletCharging" Then
                PreparingUCMoneyWallet()
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletAccounting" Then
                UcAccountingCollection.UCViewAccounting(R2CoreParkingSystemMClassSMSControllingMoneyWalletManagement.GetNSSMoneyWallet())
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


End Class