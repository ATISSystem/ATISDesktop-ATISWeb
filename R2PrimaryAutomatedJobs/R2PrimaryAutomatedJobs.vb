

Imports System.Timers

Imports R2Core.BlackIPs
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SMS
Imports R2Core.SMS.SMSHandling
Imports R2Core.SMS.SMSOwners
Imports R2Core.SMS.SMSSendRecive
Imports R2Core.SoftwareUserManagement
Imports R2CoreParkingSystem.SMS.SMSControllingMoneyWallet

Public Class R2PrimaryAutomatedJobs

    Private WithEvents _AutomatedJobsTimer As System.Timers.Timer = New System.Timers.Timer
    Private _DateTime = New R2DateTime
    Private _FailStatus As Boolean = True


    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.

        Try
            If EventLog.SourceExists("R2PrimaryAutomatedJobs") Then
            Else
                EventLog.CreateEventSource("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs")
            End If

            _AutomatedJobsTimer.Interval = 1000
            _AutomatedJobsTimer.Enabled = True
            _AutomatedJobsTimer.Start()

            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs Start ...", EventLogEntryType.SuccessAudit)

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

            'خواندن اینتروال سرویس از بانک
            Do While _FailStatus
                Try
                    Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                    _DateTime = New R2DateTime()
                    R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                    _AutomatedJobsTimer.Interval = InstanceConfiguration.GetConfig(R2CoreConfigurations.R2PrimaryAutomatedJobsSetting, 0, 0) * 1000
                    _FailStatus = False
                    EventLog.WriteEntry("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString, EventLogEntryType.SuccessAudit)
                Catch ex As Exception
                    _FailStatus = True
                    EventLog.WriteEntry("R2PrimaryAutomatedJobs", "R2PrimaryAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit)
                    System.Threading.Thread.Sleep(15000)
                End Try
            Loop

            'غیرفعال سازی اس ام اس هایی که اعتبار زمانی ندارند
            Try
                Dim InstanceSMSHandling = New R2CoreSMSHandlingManager
                InstanceSMSHandling.SMSGarbage()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSHandling.SMSGarbage:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'فرآیند ارسال اس ام اس ها
            Try
                Dim InstanceSMSSending = New R2CoreSMSSendingManager
                InstanceSMSSending.Sending(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSSending.Sending:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'فرآیند دریافت اس ام اس ها
            Try
                Dim InstanceSMSReciving = New R2CoreSMSRecivingManager
                InstanceSMSReciving.Reciving()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSReciving.Reciving:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'فرآیند هندلینگ اس ام اس های دریافت شده
            Try
                Dim InstanceSMSHandling = New R2CoreSMSHandlingManager
                InstanceSMSHandling.RecivedSMSHandling(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSHandling.RecivedSMSHandling:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'بررسی آی پی های سیاه و قرار دادن آن ها در لیست سیاه آی پی ها
            Try
                Dim InstanceBlackIPs = New R2CoreInstanceBlackIPsManager
                InstanceBlackIPs.DoStrategyControl()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "BlackIPs.DoStrategyControl:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'ثبت اکانتینگ کیف پول کنترلی اس ام اس
            Try
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                R2CoreParkingSystemMClassSMSControllingMoneyWalletManagement.ControllingMoneyWalletAccounting(InstanceSoftwareUsers.GetNSSSystemUser())
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSControllingMoneyWallet.ControllingMoneyWalletAccounting:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try

            'ارسال اس ام اس پلیز شارژ
            Try
                Dim InstanceSMSOwners = New R2CoreMClassSMSOwnersManager
                InstanceSMSOwners.SendSMSOwnersPleaseCharge()
            Catch ex As Exception
                EventLog.WriteEntry("R2PrimaryAutomatedJobs", "SMSOwners.SendSMSOwnersPleaseCharge:" + ex.Message.ToString, EventLogEntryType.Error)
            End Try



        Catch ex As Exception
            EventLog.WriteEntry("R2PrimaryAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString, EventLogEntryType.Error)
        End Try

        _AutomatedJobsTimer.Enabled = True
        _AutomatedJobsTimer.Start()

    End Sub


End Class
