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
                EventLog.WriteEntry("MSCOAutomatedJobs", "MSCOAutomatedJobs Start ...", EventLogEntryType.SuccessAudit);
                _DateTime = new R2DateTime();
                R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                _AutomatedJobsTimer.Interval = R2CoreMClassConfigurationManagement.GetConfigInt64(MSCOCoreConfigurations.MSCO, 1) * 1000 * 60;
                _AutomatedJobsTimer.Enabled = true;
                _AutomatedJobsTimer.Start();
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
                //ارسال ایمیل شرکت ها 
                try
                {
                    var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    InstanceAnnouncementforTransportCompanies.SentEmailforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                }

                catch (Exception ex)
                { EventLog.WriteEntry("MSCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

                //اعلام بار خودکار شرکت ها
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                    InstanceAnnouncementforTransportCompanies.LoadsAnnouncementforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("MSCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }
            }
            catch (Exception ex)
            { EventLog.WriteEntry("MSCOAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString(), EventLogEntryType.Error); }
            _AutomatedJobsTimer.Enabled = true;
            _AutomatedJobsTimer.Start();
        }
    }
}

