
Imports System.Reflection

Imports PayanehClassLibrary.ConfigurationManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement

Imports R2CoreGUI

Public Class UCConfigurationOfTransportCompanies
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
            UcPersianTextBoxDailyMessage.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 5)
            UcPersianTextBoxMsg1.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 7)
            UcPersianTextBoxMsg2.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 8)
            UcPersianTextBoxMsg3.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 9)
            Dim ConfigTimeforViewLastNonHolidaySedimentLoads As String = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 4)
            UcTimeEntryConfigTimeforViewLastNonHolidaySedimentLoads.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, ConfigTimeforViewLastNonHolidaySedimentLoads))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCConfigurationOfTransportCompanies_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 5, UcPersianTextBoxDailyMessage.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 7, UcPersianTextBoxMsg1.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 8, UcPersianTextBoxMsg2.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 9, UcPersianTextBoxMsg3.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 4, UcTimeEntryConfigTimeforViewLastNonHolidaySedimentLoads.UCGetTime().Time)
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
