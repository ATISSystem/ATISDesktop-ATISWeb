
Imports System.Reflection
Imports PayanehClassLibrary.ConfigurationManagement

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ConfigurationManagement

Public Class UCConfigurationOfPayanehCore
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
            RBElamControlFlagActive.Checked = IIf(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 0) = "1", True, False)
            RBElamControlFlagUnActive.Checked = IIf(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 0) = "1", False, True)
            RBFingerPrintScannerAttach.Checked = IIf(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 4) = "1", True, False)
            RBFingerPrintScannerUnAttach.Checked = IIf(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 4) = "1", False, True)
            UcNumberTruckDriverDelayHourForDermalog.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 5)
            UcMoneySherkatHazinehNobatTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 0)
            UcMoneySherkatHazinehNobat6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 5)
            UcMoneySherkatHazinehNobat10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 6)
            UcMoneyAnjomanHazinehNobatTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1)
            UcMoneyPrintCopyOfTurn.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 3)
            UcMoneyAnjomanHazinehNobatOtaghdar.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4)
            UcMoneyAnjomanHazinehChangeDriverTruck.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 9)
            UcMoneyAnjomanHazinehChangeTruck.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 10)
            UcMoneySherkatHazinehChangeDriverTruck.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 7)
            UcMoneySherkatHazinehChangeTruck.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 8)
            UcNumberBaseHoursTavaghofNobatTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 2)
            UcNumberBaseHoursTavaghofNobat10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 12)
            UcNumberBaseHoursTavaghofNobat6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayaneh, 11)
            UcMoneyAnjomanHazinehKiosk.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0)
            UcMoneySherkatHazinehKioskTereilli.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 1)
            UcMoneySherkatHazinehKiosk6Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 2)
            UcMoneySherkatHazinehKiosk10Charkh.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 3)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UCConfigurationOfPayanehCore_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.SalonFingerPrint, 0, IIf(RBElamControlFlagActive.Checked, "1", "0"))
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.SalonFingerPrint, 4, IIf(RBFingerPrintScannerAttach.Checked, "1", "0"))
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.SalonFingerPrint, 5, UcNumberTruckDriverDelayHourForDermalog.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 0, UcMoneySherkatHazinehNobatTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 5, UcMoneySherkatHazinehNobat6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 6, UcMoneySherkatHazinehNobat10Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1, UcMoneyAnjomanHazinehNobatTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 3, UcMoneyPrintCopyOfTurn.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4, UcMoneyAnjomanHazinehNobatOtaghdar.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 9, UcMoneyAnjomanHazinehChangeDriverTruck.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 10, UcMoneyAnjomanHazinehChangeTruck.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 7, UcMoneySherkatHazinehChangeDriverTruck.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 8, UcMoneySherkatHazinehChangeTruck.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 2, UcNumberBaseHoursTavaghofNobatTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 12, UcNumberBaseHoursTavaghofNobat10Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayaneh, 11, UcNumberBaseHoursTavaghofNobat6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0, UcMoneyAnjomanHazinehKiosk.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 1, UcMoneySherkatHazinehKioskTereilli.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 2, UcMoneySherkatHazinehKiosk6Charkh.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 3, UcMoneySherkatHazinehKiosk10Charkh.UCValue)
            UCRaiseChangeConfigurationCompletedMessage()
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
