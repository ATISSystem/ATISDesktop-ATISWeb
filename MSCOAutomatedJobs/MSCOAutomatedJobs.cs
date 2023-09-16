using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.SoftwareUserManagement;
using R2Core.LoggingManagement;
using MSCOCore.Configurations;
using MSCOCore.AnnouncementProcess;

namespace MSCOAutomatedJobs
{
    public partial class MSCOAutomatedJobs : ServiceBase
    {
        private System.Timers.Timer _AutomatedJobsTimer = new System.Timers.Timer();
        private R2DateTime _DateTime;
        private Boolean _FailStatus = true;

        public MSCOAutomatedJobs()
        {
            InitializeComponent();
            _AutomatedJobsTimer.Elapsed += _AutomatedJobsTimer_Elapsed;
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                if (EventLog.SourceExists("MSCOAutomatedJobs"))
                { }
                else
                { EventLog.CreateEventSource("MSCOAutomatedJobs", "MSCOAutomatedJobs"); }

                _AutomatedJobsTimer.Interval = 1000;
                _AutomatedJobsTimer.Enabled = true;
                _AutomatedJobsTimer.Start();

                EventLog.WriteEntry("MSCOAutomatedJobs", "MSCOAutomatedJobs Start ...", EventLogEntryType.SuccessAudit);
            }
            catch (Exception ex)
            { EventLog.WriteEntry("MSCOAutomatedJobs", "OnStart()." + ex.Message.ToString(), EventLogEntryType.Error); }
        }

        protected override void OnStop()
        {
            try
            {
                _AutomatedJobsTimer.Enabled = false;
                _AutomatedJobsTimer.Stop();
                _AutomatedJobsTimer = null;
                EventLog.WriteEntry("MSCOAutomatedJobs", "MSCOAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit);
            }
            catch (Exception ex)
            { EventLog.WriteEntry("MSCOAutomatedJobs", "OnStop()." + ex.Message.ToString(), EventLogEntryType.Error); }
        }

        private void _AutomatedJobsTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                _AutomatedJobsTimer.Enabled = false;
                _AutomatedJobsTimer.Stop();

                //خواندن اینتروال سرویس از بانک
                while (_FailStatus)
                {
                    try
                    {
                        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                        _DateTime = new R2DateTime();
                        R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                        _AutomatedJobsTimer.Interval = Convert.ToInt64(InstanceConfiguration.GetConfig(MSCOCoreConfigurations.MSCO, 1, 0)) * 1000 * 60;
                        _FailStatus = false;
                        EventLog.WriteEntry("MSCOAutomatedJobs", "MSCOAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString(), EventLogEntryType.SuccessAudit);
                    }
                    catch (Exception ex)
                    {
                        _FailStatus = true;
                        EventLog.WriteEntry("MSCOAutomatedJobs", "MSCOAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit);
                        System.Threading.Thread.Sleep(15000);
                    }
                }

                //ایجاد فایل های اعلام بار شرکت ها 
                try
                {
                    var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    InstanceAnnouncementforTransportCompanies.CreateAnnouncementFileforTransportCompanies (InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("MSCOAutomatedJobs.CreateAnnouncementFile", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

                //اعلام بار خودکار شرکت ها
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                    InstanceAnnouncementforTransportCompanies.LoadsAnnouncementforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("MSCOAutomatedJobs.LoadsAnnouncement", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

                //ارسال ایمیل شرکت ها
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                    InstanceAnnouncementforTransportCompanies.SentEmailforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("MSCOAutomatedJobs.SendEmail", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

            }
            catch (Exception ex)
            { EventLog.WriteEntry("MSCOAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString(), EventLogEntryType.Error); }
            _AutomatedJobsTimer.Enabled = true;
            _AutomatedJobsTimer.Start();
        }
    }
}

