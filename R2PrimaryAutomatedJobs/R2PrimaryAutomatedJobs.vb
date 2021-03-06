

Imports System.Timers
Imports R2Core.BlackIPs
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SMS
Imports R2Core.SMSSendAndRecieved
Imports R2Core.SoftwareUserManagement

Public Class R2PrimaryAutomatedJobs

    Private WithEvents _AutomatedJobsTimer As System.Timers.Timer = New System.Timers.Timer
    Private _DateTime = New R2DateTime


    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.

        Try
            If EventLog.SourceExists("R2PrimaryAutomatedJobs") Then
            Else
                EventLog.CreateEventSource("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs")
            End If
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs Start ...", EventLogEntryType.SuccessAudit)

            _DateTime = New R2DateTime()
            R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())

            _AutomatedJobsTimer.Interval = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.R2PrimaryAutomatedJobsSetting, 0) * 1000
            _AutomatedJobsTimer.Enabled = True
            _AutomatedJobsTimer.Start()

        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "OnStart()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try

    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.

        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()
            _AutomatedJobsTimer = Nothing
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "OnStop()." + ex.Message.ToString, EventLogEntryType.Error)
        End Try

    End Sub

    Private Sub _AutomatedJobsTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _AutomatedJobsTimer.Elapsed
        Try
            _AutomatedJobsTimer.Enabled = False
            _AutomatedJobsTimer.Stop()

            'ارسال اس ام اس های اکتیو سازی کاربران موبایل آتیس موبایل
            Try
                R2CoreSMSMClassSMSDomainManagement.SMSDomainSendRecieved()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSDomainSendRecieved:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'بررسی آی پی های سیاه و قرار دادن آن ها در لیست سیاه آی پی ها
            Try
                Dim InstanceBlackIPs = New R2CoreInstanceBlackIPsManager
                InstanceBlackIPs.DoStrategyControl()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "BlackIPs.DoStrategyControl:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try


        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString, EventLogEntryType.Error)
        End Try

        _AutomatedJobsTimer.Enabled = True
        _AutomatedJobsTimer.Start()

    End Sub


End Class
