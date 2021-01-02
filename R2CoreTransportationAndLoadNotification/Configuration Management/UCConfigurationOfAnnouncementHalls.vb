
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement

Public Class UCConfigurationOfAnnouncementHalls
    Inherits UCConfiguration

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Private Sub UCRefresh()
        UcTextBoxAnnounceTime.UCRefresh()
        UcNumberTurnCancellationDateDiffforAgentJob.UCRefresh()
        UcNumberTruckDriverDelayHourForDermalog.UCRefresh()
        UcNumberPresentNeededIndigenousTruck.UCRefresh()
        UcNumberPresentNeededUnIndigenousTruck.UCRefresh()
        UcTextBoxIndigenousTruckSerials.UCRefresh()
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UCConfigurationOfTransportationAndLoadNotification_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 0, UcSearcherLoadSources.UCGetSelectedNSS.OCode)
            Dim Pattern As String = UcucAnnouncementHallSubGroupCollection.UCCurrentNSS.AHSGId.ToString + "="
            Dim IndexOfPattern As Int64 = Array.FindIndex(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallAnnounceTimes(UcucAnnouncementHallCollection.UCCurrentNSS.AHId).ToArray(), Function(x) Mid(x, 1, 3) = Pattern)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallAnnounceTime, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, IndexOfPattern, Pattern+UcTextBoxAnnounceTime.UCValue.Replace(" ",""))
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 0, "AHTurnCancellationDateDiffforAgentJob:" + UcNumberTurnCancellationDateDiffforAgentJob.UCValue.ToString())
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 0, IIf(RBElamControlFlagActive.Checked, "1", "0"))
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 1, UcNumberTruckDriverDelayHourForDermalog.UCValue)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 2, UcTimeEntry1.UCGetTime().Time)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 3, UcTimeEntry2.UCGetTime().Time)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 4, UcNumberPresentNeededIndigenousTruck.UCValue)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 5, UcNumberPresentNeededUnIndigenousTruck.UCValue)
            R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.SetConfiguration(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 6, UcTextBoxIndigenousTruckSerials.UCValue)
            UCRaiseChangeConfigurationCompletedMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAnnouncementHallCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallCollection.UCCurrentNSSChangedEvent
        Try
            UCRefresh()
            UcucAnnouncementHallSubGroupCollection.UCViewCollection(UcucAnnouncementHallCollection.UCCurrentNSS.AHId)
            UcNumberTurnCancellationDateDiffforAgentJob.UCValue = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 0), ":")(1)
            RBElamControlFlagActive.Checked = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 0) = "1"
            RBElamControlFlagUnActive.Checked = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 0) <> "1"
            UcNumberTruckDriverDelayHourForDermalog.UCValue = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 1)
            UcTimeEntry1.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 2)))
            UcTimeEntry2.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 3)))
            UcNumberPresentNeededIndigenousTruck.UCValue = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 4)
            UcNumberPresentNeededUnIndigenousTruck.UCValue = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 5)
            UcTextBoxIndigenousTruckSerials.UCValue = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, UcucAnnouncementHallCollection.UCCurrentNSS.AHId, 6)
            UcSearcherLoadSources.UCViewNSS(R2CoreTransportationAndLoadNotification.LoadSources.R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement.GetNSSLoadSource(R2Core.ConfigurationManagement.R2CoreMClassConfigurationManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 0)))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAnnouncementHallSubGroupCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallSubGroupCollection.UCCurrentNSSChangedEvent
        Try
            UcTextBoxAnnounceTime.UCRefresh()
            UcTextBoxAnnounceTime.UCValue = String.Join(" - ", R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallAnnounceTimes(UcucAnnouncementHallCollection.UCCurrentNSS.AHId, UcucAnnouncementHallSubGroupCollection.UCCurrentNSS.AHSGId))
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
