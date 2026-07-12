
Imports System.Timers

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SoftwareUserManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.CarTruckNobatManagement

Public Class AutomaticTurnIssueAutomatedJobs

    Private WithEvents _AutomatedJobsTimer As System.Timers.Timer = New System.Timers.Timer
    Private _DateTime As R2DateTime
    Private _FailStatus As Boolean = True

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            If EventLog.SourceExists("AutomaticTurnIssueAutomatedJobs") Then
            Else
                EventLog.CreateEventSource("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs")
            End If

            _AutomatedJobsTimer.Interval = 1000
            _AutomatedJobsTimer.Enabled = True
            _AutomatedJobsTimer.Start()

            EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs Start ...", EventLogEntryType.SuccessAudit)

        Catch ex As Exception
            EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "OnStart()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()
            _AutomatedJobsTimer = Nothing
            EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "OnStop()." + ex.Message.ToString, EventLogEntryType.Error)
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
                    _AutomatedJobsTimer.Interval = 60000
                    _FailStatus = False
                    EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString, EventLogEntryType.SuccessAudit)
                Catch ex As Exception
                    _FailStatus = True
                    EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit)
                    System.Threading.Thread.Sleep(15000)
                End Try
            Loop

            'صدور خودکار نوبت ها
            Try
                PayanehClassLibraryMClassCarTruckNobatManagement.AutomaticTurnRegistering()
            Catch ex As Exception
                EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "AutomaticTurnIssueAutomatedJobs:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

        Catch ex As Exception
            EventLog.WriteEntry("AutomaticTurnIssueAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString, EventLogEntryType.Error)
        End Try

        _AutomatedJobsTimer.Enabled = True
        _AutomatedJobsTimer.Start()
    End Sub


End Class
