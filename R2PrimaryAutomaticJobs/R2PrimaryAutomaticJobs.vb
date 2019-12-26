

Imports System.Timers

Public Class R2PrimaryAutomaticJobs

    Private WithEvents AutomaticJobsTimer As System.Timers.Timer = New System.Timers.Timer


    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            'ايجاد اونت لوگ
            If EventLog.Exists("R2PrimaryAutomaticJobs") = False Then EventLog.CreateEventSource("R2PrimaryAutomaticJobsSource", "R2PrimaryAutomaticJobs")
            'تنظيمات تايمر
            AutomaticJobsTimer.Interval = 1000
            AutomaticJobsTimer.Enabled = True
            AutomaticJobsTimer.Start()
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "AutomaticJobsTimer Start Succefull.", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "R2PrimaryAutomaticJobs.OnStart" + vbCrLf + ex.Message.ToString, EventLogEntryType.Error)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        Try
            AutomaticJobsTimer.Stop()
            AutomaticJobsTimer = Nothing
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "AutomaticJobsTimer Stop Succefull.", EventLogEntryType.SuccessAudit)
        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "R2PrimaryAutomaticJobs.OnStop" + vbCrLf + ex.Message.ToString, EventLogEntryType.Error)
        End Try
    End Sub

    Private Sub AutomaticJobsTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles AutomaticJobsTimer.Elapsed
        Try
            AutomaticJobsTimer.Stop()
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "AutomaticJobsTimer.Stop Line Passed ...", EventLogEntryType.SuccessAudit)

            Try
                
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "AutomaticJobsTimer_Elapsed.Sediment" + vbCrLf + ex.Message.ToString, EventLogEntryType.Error)
            End Try
            

        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomaticJobsSource", "AutomaticJobsTimer_Elapsed" + vbCrLf + ex.Message.ToString, EventLogEntryType.Error)
        End Try
        AutomaticJobsTimer.Start()
    End Sub
End Class
