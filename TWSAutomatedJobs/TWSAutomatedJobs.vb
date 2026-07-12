

Imports System.Timers
Imports PayanehClassLibrary.ConfigurationManagement

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SMS
Imports R2Core.SoftwareUserManagement
Imports R2CoreTransportationAndLoadNotification.TWS

Public Class TWSAutomatedJobs

    Private WithEvents _AutomatedJobsTimer As System.Timers.Timer = New System.Timers.Timer
    Private _DateTime As R2DateTime
    Private _FailStatus As Boolean = True

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Try
            If EventLog.SourceExists("TWSAutomatedJobs") Then
            Else
                EventLog.CreateEventSource("TWSAutomatedJobs", "TWSAutomatedJobs")
            End If

            _AutomatedJobsTimer.Interval = 5000
            _AutomatedJobsTimer.Enabled = True
            _AutomatedJobsTimer.Start()

            EventLog.WriteEntry("TWSAutomatedJobs", "TWSAutomatedJobs Start ...", EventLogEntryType.SuccessAudit)

        Catch ex As Exception
            EventLog.WriteEntry("TWSAutomatedJobs", "OnStart():" + ex.Message.ToString, EventLogEntryType.Error)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()
            _AutomatedJobsTimer = Nothing
            EventLog.WriteEntry("TWSAutomatedJobs", "TWSAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("TWSAutomatedJobs", "OnStop()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try
    End Sub

    Private Sub _AutomatedJobsTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _AutomatedJobsTimer.Elapsed
        Try
            Dim InstanceLogging = New R2CoreInstanceLoggingManager

            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()

            'خواندن اینتروال سرویس از بانک
            Do While _FailStatus
                Try
                    Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                    _DateTime = New R2DateTime()
                    R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                    _AutomatedJobsTimer.Interval = InstanceConfiguration.GetConfig(PayanehClassLibraryConfigurations.TWS, 0, 3600) * 1000
                    _FailStatus = False
                    EventLog.WriteEntry("TWSAutomatedJobs", "TWSAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString, EventLogEntryType.SuccessAudit)
                Catch ex As Exception
                    _FailStatus = True
                    EventLog.WriteEntry("TWSAutomatedJobs", "TWSAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit)
                    System.Threading.Thread.Sleep(15000)
                End Try
            Loop

            'ارسال مجوزهای صادر شده به نوبت آنلاین
            Try
                Dim InstanceTWS = New R2CoreTransportationAndLoadNotificationsTWSManager
                InstanceTWS.TWSCapacitorSendLoadPermissions()
            Catch ex As Exception
                EventLog.WriteEntry("TWSAutomatedJobs", "TWSCapacitorSendLoadPermissions:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

        Catch ex As Exception
            EventLog.WriteEntry("TWSAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString, EventLogEntryType.Error)
        End Try

        _AutomatedJobsTimer.Enabled = True
        _AutomatedJobsTimer.Start()
    End Sub


End Class
