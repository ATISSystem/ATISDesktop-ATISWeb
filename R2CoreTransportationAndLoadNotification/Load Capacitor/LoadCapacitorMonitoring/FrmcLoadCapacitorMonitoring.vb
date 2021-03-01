

Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.ProcessesManagement

Public Class FrmcLoadCapacitorMonitoring
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
            FrmRefresh()
            UcucLoadCapacitorLoadCollectionAdvance.UCTimerInterval = R2Core.ConfigurationManagement.R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallMonitoring, 0)
            UcucLoadCapacitorLoadCollectionAdvance.UCViewnCarNumZero = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreTransportationAndLoadNotificationProcesses.FrmcLoadCapacitorMonitoring))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class