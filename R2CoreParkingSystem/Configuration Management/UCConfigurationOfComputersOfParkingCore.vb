
Imports System.Drawing
Imports System.Reflection

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ConfigurationManagement

Public Class UCConfigurationOfComputersOfParkingCore
    Inherits UCConfiguration

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCRefresh()
        UcTextBoxCamera1CameraCnn1.UCRefresh()
        UcTextBoxCamera1CameraCnn2.UCRefresh()
        UcTextBoxCamera2CameraCnn1.UCRefresh()
        UcTextBoxCamera2CameraCnn2.UCRefresh()
        UcTextBoxCamera1CameraName.UCRefresh()
        UcTextBoxCamera1UserName.UCRefresh()
        UcTextBoxCamera1UserPassword.UCRefresh()
        UcTextBoxCamera2CameraName.UCRefresh()
        UcTextBoxCamera2UserName.UCRefresh()
        UcTextBoxCamera2UserPassword.UCRefresh()
        UcMoneyChargeDefaultMblgh.UCRefresh()
        UcNumberTimerClearLastReadedTeraficCardInterval.UCRefresh()
        UcTextBoxTerafficCardsTypeSupport.UCRefresh()
        UcTextBoxTrafficCardEERequestStatusWithMaabarMatch.UCRefresh()
    End Sub


    Private Sub FillConfigurationObjects()
        Try
            RBCamera1CameraActiveEnable.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBCamera1CameraActiveDisable.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            RBCamera2CameraActiveEnable.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBCamera2CameraActiveDisable.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            UcTextBoxCamera1CameraCnn1.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 2)
            UcTextBoxCamera1CameraCnn2.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 3)
            UcTextBoxCamera2CameraCnn1.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 2)
            UcTextBoxCamera2CameraCnn2.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 3)
            UcTextBoxCamera1CameraName.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            UcTextBoxCamera2CameraName.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            UcTextBoxCamera1UserName.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 6)
            UcTextBoxCamera2UserName.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 6)
            UcTextBoxCamera1UserPassword.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera1, UcSearcherComputers.UCGetSelectedNSS.OCode, 7)
            UcTextBoxCamera2UserPassword.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.Camera2, UcSearcherComputers.UCGetSelectedNSS.OCode, 7)
            RBChargePrintFlagActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.MoneyWalletCharge, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBChargePrintFlagUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.MoneyWalletCharge, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            UcMoneyChargeDefaultMblgh.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.MoneyWalletCharge, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            RBChargeMblghCanEditActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.MoneyWalletCharge, UcSearcherComputers.UCGetSelectedNSS.OCode, 2) = "1"
            RBChargeMblghCanEditUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.MoneyWalletCharge, UcSearcherComputers.UCGetSelectedNSS.OCode, 2) <> "1"
            RBEnterExitAccountingCanPrintActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.EnterExitAccountingCanPrint, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBEnterExitAccountingCanPrintUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.EnterExitAccountingCanPrint, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            RBSepasPrintDocumentPrintActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.SepasSystem, UcSearcherComputers.UCGetSelectedNSS.OCode, 1) = "1"
            RBSepasPrintDocumentPrintUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.SepasSystem, UcSearcherComputers.UCGetSelectedNSS.OCode, 1) <> "1"
            UcNumberTimerClearLastReadedTeraficCardInterval.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.FrmcEnterExitSetting, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            RBLPRIsAciveActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.LPRIsActive, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBLPRIsAciveUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.LPRIsActive, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            RBChargeActiveOnThisLocationActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBChargeActiveOnThisLocationUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            RBSaveCarPictureActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.SaveCarPicture, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBSaveCarPictureUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreParkingSystemConfigurations.SaveCarPicture, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCConfigurationOfComputersOfParkingCore_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            Dim MId As Int64 = UcSearcherComputers.UCGetSelectedNSS.OCode
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 0, IIf(RBCamera1CameraActiveEnable.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 0, IIf(RBCamera2CameraActiveEnable.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 2, UcTextBoxCamera1CameraCnn1.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 3, UcTextBoxCamera1CameraCnn2.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 2, UcTextBoxCamera2CameraCnn1.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 3, UcTextBoxCamera2CameraCnn2.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 1, UcTextBoxCamera1CameraName.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 1, UcTextBoxCamera2CameraName.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 6, UcTextBoxCamera1UserName.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 6, UcTextBoxCamera2UserName.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera1, MId, 7, UcTextBoxCamera1UserPassword.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.Camera2, MId, 7, UcTextBoxCamera2UserPassword.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.MoneyWalletCharge, MId, 0, IIf(RBChargePrintFlagActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.MoneyWalletCharge, MId, 1, UcMoneyChargeDefaultMblgh.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.MoneyWalletCharge, MId, 2, IIf(RBChargeMblghCanEditActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.EnterExitAccountingCanPrint, MId, 0, IIf(RBEnterExitAccountingCanPrintActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.SepasSystem, MId, 1, IIf(RBSepasPrintDocumentPrintActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.FrmcEnterExitSetting, MId, 0, UcNumberTimerClearLastReadedTeraficCardInterval.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.LPRIsActive, MId, 0, IIf(RBLPRIsAciveActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, MId, 0, IIf(RBChargeActiveOnThisLocationActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreParkingSystemConfigurations.SaveCarPicture, MId, 0, IIf(RBSaveCarPictureActive.Checked, "1", "0"))
            UCRaiseChangeConfigurationCompletedMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcSearcherComputers_UC13PressedEvent() Handles UcSearcherComputers.UC13PressedEvent
        Try
            FillConfigurationObjects()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
