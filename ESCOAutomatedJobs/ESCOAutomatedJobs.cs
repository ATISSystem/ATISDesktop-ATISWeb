
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
using ESCOCore.Configurations;
using R2Core.LoggingManagement;

namespace ESCOAutomatedJobs
{
    public partial class ESCOAutomatedJobs : ServiceBase
    {
        private System.Timers.Timer _AutomatedJobsTimer = new System.Timers.Timer();
        private R2DateTime _DateTime;


        public ESCOAutomatedJobs()
        {
            InitializeComponent();
            _AutomatedJobsTimer.Elapsed += _AutomatedJobsTimer_Elapsed;
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                if (EventLog.SourceExists("ESCOAutomatedJobs"))
                { }
                else
                { EventLog.CreateEventSource("ESCOAutomatedJobs", "ESCOAutomatedJobs"); }
                EventLog.WriteEntry("ESCOAutomatedJobs", "ESCOAutomatedJobs Start ...", EventLogEntryType.SuccessAudit);
                _DateTime = new R2DateTime();
                R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                _AutomatedJobsTimer.Interval = R2CoreMClassConfigurationManagement.GetConfigInt64(ESCOCoreConfigurations.ESCO, 4) * 1000 * 60;
                _AutomatedJobsTimer.Enabled = true;
                _AutomatedJobsTimer.Start();
            }
            catch (Exception ex)
            { EventLog.WriteEntry("ESCOAutomatedJobs", "OnStart()." + ex.Message.ToString(), EventLogEntryType.Error); }

        }

        protected override void OnStop()
        {
            try
            {
                _AutomatedJobsTimer.Enabled = false;
                _AutomatedJobsTimer.Stop();
                _AutomatedJobsTimer = null;
                EventLog.WriteEntry("ESCOAutomatedJobs", "ESCOAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit);
            }
            catch (Exception ex)
            { EventLog.WriteEntry("ESCOAutomatedJobs", "OnStop()." + ex.Message.ToString(), EventLogEntryType.Error); }

        }

        private void _AutomatedJobsTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                _AutomatedJobsTimer.Enabled = false;
                _AutomatedJobsTimer.Stop();
                //ارسال اس ام اس بار اعلام شده 
                try
                {
                    var InstanceSendSMS = new ESCOCore.SendSMS.ESCOCoreSendSMSManager();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    InstanceSendSMS.SendSMSofAnnouncedLoads(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("ESCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }
            }
            catch (Exception ex)
            { EventLog.WriteEntry("ESCOAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString(), EventLogEntryType.Error); }
            _AutomatedJobsTimer.Enabled = true;
            _AutomatedJobsTimer.Start();
        }

    }
}
