
Imports System.Timers

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.Logging
Imports PayanehClassLibrary.TruckersAssociationControllingMoneyWallet
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadOtherThanManipulation
Imports R2CoreTransportationAndLoadNotification.LoadSedimentation
Imports R2CoreTransportationAndLoadNotification.Logging


Public Class PayanehAmirKabirAutomatedJobs

    Private WithEvents _AutomatedJobsTimer As System.Timers.Timer = New System.Timers.Timer
    Private _DateTime As R2DateTime


    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Try
            If EventLog.SourceExists("PayanehAmirKabirAutomatedJobs") Then
            Else
                EventLog.CreateEventSource("PayanehAmirKabirAutomatedJobs", "PayanehAmirKabirAutomatedJobs")
            End If
            EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "PayanehAmirKabirAutomatedJobs Start ...", EventLogEntryType.SuccessAudit)

            _DateTime = New R2DateTime()
            R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())

            _AutomatedJobsTimer.Interval = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.PayanehAmirKabirAutomatedJobsSetting, 0) * 1000
            _AutomatedJobsTimer.Enabled = True
            _AutomatedJobsTimer.Start()

        Catch ex As Exception
            EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "OnStart()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try


    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()
            _AutomatedJobsTimer = Nothing
            EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "PayanehAmirKabirAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "OnStop()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try

    End Sub

    Private Sub _AutomatedJobsTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _AutomatedJobsTimer.Elapsed
        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()

            'انتقال بار با وضعیت فردا به بار با وضعیت امروز
            Try
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.TransferringTommorowLoads()
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "TransferringTommorowLoads:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'صدور خودکار مجوزهای سالن های اعلام بار
            Try
                Dim InstanceLoadAllocation = New R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                InstanceLoadAllocation.LoadAllocationsLoadPermissionRegistering(InstanceSoftwareUsers.GetNSSSystemUser())
                InstanceSoftwareUsers = Nothing
                InstanceLoadAllocation = Nothing
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "LoadAllocationsLoadPermissionRegistering:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'فراخوانی سرویس رسوب بار در سالن اعلام بار
            Try
                Dim InstanceLoadSedimentation = New R2CoreTransportationAndLoadNotificationMClassLoadSedimentationManager
                InstanceLoadSedimentation.SedimentingProcess()
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "SedimentingProcess:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'ابطال گروهی نوبت ها
            Try
                PayanehClassLibraryMClassCarTruckNobatManagement.TurnsCancellationBaseOnDuration()
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "TurnsCancellation:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'ثبت اکانتینگ کیف پول کنترلی کامیونداران
            Try
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                TruckersAssociationControllingMoneyWalletManagement.ControllingMoneyWalletAccounting(InstanceSoftwareUsers.GetNSSSystemUser())
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "ControllingMoneyWalletAccounting:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'صدور خودکار نوبت ها
            Try
                PayanehClassLibraryMClassCarTruckNobatManagement.AutomaticTurnRegistering()
            Catch ex As Exception
                EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "AutomaticTurnRegistering:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try



        Catch ex As Exception
            EventLog.WriteEntry("PayanehAmirKabirAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString, EventLogEntryType.Error)
        End Try

        _AutomatedJobsTimer.Enabled = True
        _AutomatedJobsTimer.Start()
    End Sub


End Class
