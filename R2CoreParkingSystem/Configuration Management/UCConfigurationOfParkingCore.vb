
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ConfigurationManagement


Public Class UCConfigurationOfParkingCore
    Inherits UCConfiguration


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            FillConfigurationObjects()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub FillConfigurationObjects()
        Try
            UcMoneyEnterSavari.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0)
            UcMoneyEnter10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1)
            UcMoneyEnter6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2)
            UcMoneyEnterTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3)
            UcMoneyEnterSavariTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 4)
            UcMoneyEnter10CharkhTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 5)
            UcMoneyEnter6CharkhTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 6)
            UcMoneyEnterTereilliTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 7)
            UcMoneyDelaySavari.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 0)
            UcMoneyDelay6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 1)
            UcMoneyDelay10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 2)
            UcMoneyDelayTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 3)
            UcMoneyDelaySavariTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 4)
            UcMoneyDelay6CharkhTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 5)
            UcMoneyDelay10CharkhTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 6)
            UcMoneyDelayTereilliTemp.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 7)
            UcMoneyNoVatEnterSavari.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 0)
            UcMoneyNoVatEnter6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 2)
            UcMoneyNoVatEnter10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 1)
            UcMoneyNoVatEnterTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 3)
            UcMoneyNoVatExtra.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 4)
            UcNumberEnterDelayHourForTempCards.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 0)
            UcNumberBaseHoursTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1)
            UcMoneyRFIDCardPrice.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 2)
            UcNumberNextToHours.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3)
            UcNumberBaseHoursSavari.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4)
            UcNumberBaseHours6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5)
            UcNumberBaseHours10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6)

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCConfigurationOfParkingCore_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 0, UcMoneyEnterSavari.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 1, UcMoneyEnter10Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 2, UcMoneyEnter6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 3, UcMoneyEnterTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 4, UcMoneyEnterSavariTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 5, UcMoneyEnter10CharkhTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 6, UcMoneyEnter6CharkhTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghPaye, 7, UcMoneyEnterTereilliTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 0, UcMoneyDelaySavari.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 1, UcMoneyDelay10Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 2, UcMoneyDelay6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 3, UcMoneyDelayTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 4, UcMoneyDelaySavariTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 5, UcMoneyDelay10CharkhTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 6, UcMoneyDelay6CharkhTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghDelay, 7, UcMoneyDelayTereilliTemp.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 0, UcMoneyNoVatEnterSavari.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 2, UcMoneyNoVatEnter6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 1, UcMoneyNoVatEnter10Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 3, UcMoneyNoVatEnterTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 4, UcMoneyNoVatExtra.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 0, UcNumberEnterDelayHourForTempCards.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 1, UcNumberBaseHoursTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 2, UcMoneyRFIDCardPrice.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 3, UcNumberNextToHours.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 4, UcNumberBaseHoursSavari.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 5, UcNumberBaseHours6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreParkingSystemConfigurations.TarrifsMeselanius, 6, UcNumberBaseHours10Charkh.UCValue)
            UCRaiseChangeConfigurationCompletedMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyNoVatEnter10Charkh_UCValidatedEvent() Handles UcMoneyNoVatEnter10Charkh.UCValidatedEvent
        Try
            UcMoneyEnter10Charkh.UCValue = Convert.ToInt64(UcMoneyNoVatEnter10Charkh.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnter10Charkh.UCValue)
            UcMoneyEnter10CharkhTemp.UCValue = Convert.ToInt64(UcMoneyNoVatEnter10Charkh.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnter10Charkh.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyNoVatEnter6Charkh_UCValidatedEvent() Handles UcMoneyNoVatEnter6Charkh.UCValidatedEvent
        Try
            UcMoneyEnter6Charkh.UCValue = Convert.ToInt64(UcMoneyNoVatEnter6Charkh.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnter6Charkh.UCValue)
            UcMoneyEnter6CharkhTemp.UCValue = Convert.ToInt64(UcMoneyNoVatEnter6Charkh.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnter6Charkh.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyNoVatEnterSavari_UCValidatedEvent() Handles UcMoneyNoVatEnterSavari.UCValidatedEvent
        Try
            UcMoneyEnterSavari.UCValue = Convert.ToInt64(UcMoneyNoVatEnterSavari.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterSavari.UCValue)
            UcMoneyEnterSavariTemp.UCValue = Convert.ToInt64(UcMoneyNoVatEnterSavari.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterSavari.UCValue)
            UcMoneyDelaySavari.UCValue = Convert.ToInt64(UcMoneyNoVatEnterSavari.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterSavari.UCValue)
            UcMoneyDelaySavariTemp.UCValue = Convert.ToInt64(UcMoneyNoVatEnterSavari.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterSavari.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyNoVatEnterTereilli_UCValidatedEvent() Handles UcMoneyNoVatEnterTereilli.UCValidatedEvent
        Try
            UcMoneyEnterTereilli.UCValue = Convert.ToInt64(UcMoneyNoVatEnterTereilli.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterTereilli.UCValue)
            UcMoneyEnterTereilliTemp.UCValue = Convert.ToInt64(UcMoneyNoVatEnterTereilli.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatEnterTereilli.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyNoVatExtra_UCValidatedEvent() Handles UcMoneyNoVatExtra.UCValidatedEvent
        Try
            UcMoneyDelay6Charkh.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
            UcMoneyDelay6CharkhTemp.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
            UcMoneyDelay10Charkh.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
            UcMoneyDelay10CharkhTemp.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
            UcMoneyDelayTereilli.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
            UcMoneyDelayTereilliTemp.UCValue = Convert.ToInt64(UcMoneyNoVatExtra.UCValue * (R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.GovernmentVat, 0) / 100) + UcMoneyNoVatExtra.UCValue)
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
