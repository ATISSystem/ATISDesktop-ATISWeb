
Imports System.Reflection

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement

Public Class UCConfigurationOfComputersOfCore
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
        Try
            UcTextBoxRFIDCardReadersTypeFirst.UCRefresh()
            UcTextBoxRFIDCardReadersTypeSecond.UCRefresh()
            UcTextBoxRFIDCardNoSimulate.UCRefresh()
            UcNumberRFIDCardReaderDelay.UCRefresh()
            UcNumberTimeOut.UCRefresh()
            UcNumberSupremaTimeOut.UCRefresh()
            UcNumberSupremaBrightness.UCRefresh()
            UcNumberSupremaSensitivity.UCRefresh()
            UcNumberSupremaTemplateType.UCRefresh()
            UcNumberSupremaSecurityLevel.UCRefresh()
            UcNumberSupremaEnrollQuality.UCRefresh()
            UcNumberDermalogLifenessScoreForRegister.UCRefresh()
            UcNumberDermalogLifenessScoreForPresent.UCRefresh()
            UcNumberDermalogVerifyScore.UCRefresh()
            UcNumberDermalogNISTQuality.UCRefresh()
            UcNumberUCUCComputerMessageCollectionTopN.UCRefresh()
            UcNumberUCUCComputerMessageCollectionSweepDelay.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FillConfigurationObjects()
        Try
            UcTextBoxRFIDCardReadersTypeFirst.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReadersType, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            UcTextBoxRFIDCardReadersTypeSecond.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReadersType, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            UcTextBoxRFIDCardNoSimulate.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReaderSetting, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            UcNumberRFIDCardReaderDelay.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReaderSetting, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            RBRFIDCardReaderBeepEnableActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReaderSetting, UcSearcherComputers.UCGetSelectedNSS.OCode, 2) = "1"
            RBRFIDCardReaderBeepEnableUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.RFIDCardReaderSetting, UcSearcherComputers.UCGetSelectedNSS.OCode, 2) <> "1"
            UcNumberTimeOut.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            PnlColorErrorType.BackColor = Color.FromName(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 1))
            PnlColorErrorInDataEntry.BackColor = Color.FromName(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 2))
            PnlColorWarning.BackColor = Color.FromName(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 3))
            PnlColorSuccessProccess.BackColor = Color.FromName(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 4))
            PnlColorInformation.BackColor = Color.FromName(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, UcSearcherComputers.UCGetSelectedNSS.OCode, 5))
            RBSupremaScannerExistActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBSupremaScannerExistUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            UcNumberSupremaTimeOut.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            UcNumberSupremaBrightness.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 2)
            UcNumberSupremaSensitivity.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 3)
            UcNumberSupremaSecurityLevel.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 6)
            UcNumberSupremaTemplateType.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 7)
            UcNumberSupremaEnrollQuality.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 8)
            RBSupremaDetectCoreActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 4) = "1"
            RBSupremaDetectCoreUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 4) <> "1"
            RBSupremaDetectFakeActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 5) = "1"
            RBSupremaDetectFakeUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Suprema, UcSearcherComputers.UCGetSelectedNSS.OCode, 5) <> "1"
            UcNumberDermalogLifenessScoreForPresent.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Dermalog, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            UcNumberDermalogLifenessScoreForRegister.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Dermalog, UcSearcherComputers.UCGetSelectedNSS.OCode, 3)
            UcNumberDermalogNISTQuality.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Dermalog, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
            UcNumberDermalogVerifyScore.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.Dermalog, UcSearcherComputers.UCGetSelectedNSS.OCode, 2)
            RBVerifyIdentifyFPUCEnableActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.VerifyIdentifyFPUCEnable, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) = "1"
            RBVerifyIdentifyFPUCEnableUnActive.Checked = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.VerifyIdentifyFPUCEnable, UcSearcherComputers.UCGetSelectedNSS.OCode, 0) <> "1"
            UcNumberUCUCComputerMessageCollectionTopN.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.UCUCComputerMessageCollection, UcSearcherComputers.UCGetSelectedNSS.OCode, 0)
            UcNumberUCUCComputerMessageCollectionSweepDelay.UCValue = R2CoreMClassConfigurationOfComputersManagement.GetConfigString(R2CoreConfigurations.UCUCComputerMessageCollection, UcSearcherComputers.UCGetSelectedNSS.OCode, 1)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCConfigurationOfComputersOfCore_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            Dim MId As Int64 = UcSearcherComputers.UCGetSelectedNSS.OCode
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.RFIDCardReadersType, MId, 0, UcTextBoxRFIDCardReadersTypeFirst.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.RFIDCardReadersType, MId, 1, UcTextBoxRFIDCardReadersTypeSecond.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.RFIDCardReaderSetting, MId, 0, UcTextBoxRFIDCardNoSimulate.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.RFIDCardReaderSetting, MId, 1, UcNumberRFIDCardReaderDelay.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.RFIDCardReaderSetting, MId, 2, IIf(RBRFIDCardReaderBeepEnableActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 0, UcNumberTimeOut.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 1, PnlColorErrorType.BackColor.Name)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 2, PnlColorErrorInDataEntry.BackColor.Name)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 3, PnlColorWarning.BackColor.Name)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 4, PnlColorSuccessProccess.BackColor.Name)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.FrmcDialogMessage, MId, 5, PnlColorInformation.BackColor.Name)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 0, IIf(RBSupremaScannerExistActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 1, UcNumberSupremaTimeOut.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 2, UcNumberSupremaBrightness.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 3, UcNumberSupremaSensitivity.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 6, UcNumberSupremaSecurityLevel.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 7, UcNumberSupremaTemplateType.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 8, UcNumberSupremaEnrollQuality.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 4, IIf(RBSupremaDetectCoreActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Suprema, MId, 5, IIf(RBSupremaDetectFakeActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Dermalog, MId, 0, UcNumberDermalogLifenessScoreForPresent.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Dermalog, MId, 3, UcNumberDermalogLifenessScoreForRegister.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Dermalog, MId, 1, UcNumberDermalogNISTQuality.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.Dermalog, MId, 2, UcNumberDermalogVerifyScore.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.VerifyIdentifyFPUCEnable, MId, 0, IIf(RBVerifyIdentifyFPUCEnableActive.Checked, "1", "0"))
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.UCUCComputerMessageCollection, MId, 0, UcNumberUCUCComputerMessageCollectionTopN.UCValue)
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(R2CoreConfigurations.UCUCComputerMessageCollection, MId, 1, UcNumberUCUCComputerMessageCollectionSweepDelay.UCValue)
            UCRaiseChangeConfigurationCompletedMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PnlColorErrorInDataEntry_Click(sender As Object, e As EventArgs) Handles PnlColorErrorInDataEntry.Click
        Try
            Dim ColorD As New ColorDialog
            If ColorD.ShowDialog() = DialogResult.OK Then
                PnlColorErrorInDataEntry.BackColor = ColorD.Color
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PnlColorErrorType_Click(sender As Object, e As EventArgs) Handles PnlColorErrorType.Click
        Try
            Dim ColorD As New ColorDialog
            If ColorD.ShowDialog() = DialogResult.OK Then
                PnlColorErrorType.BackColor = ColorD.Color
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub PnlColorInformation_Click(sender As Object, e As EventArgs) Handles PnlColorInformation.Click
        Try
            Dim ColorD As New ColorDialog
            If ColorD.ShowDialog() = DialogResult.OK Then
                PnlColorInformation.BackColor = ColorD.Color
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub PnlColorSuccessProccess_Click(sender As Object, e As EventArgs) Handles PnlColorSuccessProccess.Click
        Try
            Dim ColorD As New ColorDialog
            If ColorD.ShowDialog() = DialogResult.OK Then
                PnlColorSuccessProccess.BackColor = ColorD.Color
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub PnlColorWarning_Click(sender As Object, e As EventArgs) Handles PnlColorWarning.Click
        Try
            Dim ColorD As New ColorDialog
            If ColorD.ShowDialog() = DialogResult.OK Then
                PnlColorWarning.BackColor = ColorD.Color
            End If
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

