
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
using ESCOCore.SMS;
using ESCOCore.Exceptions;

namespace ESCOAutomatedJobs
{
    public partial class ESCOAutomatedJobs : ServiceBase
    {
        private System.Timers.Timer _AutomatedJobsTimer = new System.Timers.Timer();
        private R2DateTime _DateTime;
        private Boolean _FailStatus = true;


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

                _AutomatedJobsTimer.Interval = 1000;
                _AutomatedJobsTimer.Enabled = true;
                _AutomatedJobsTimer.Start();

                EventLog.WriteEntry("ESCOAutomatedJobs", "ESCOAutomatedJobs Start ...", EventLogEntryType.SuccessAudit);
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

                //خواندن اینتروال سرویس از بانک
                while (_FailStatus)
                {
                    try
                    {
                        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                        _DateTime = new R2DateTime();
                        R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                        _AutomatedJobsTimer.Interval = Convert.ToInt64(InstanceConfiguration.GetConfig(ESCOCoreConfigurations.ESCO, 4, 0)) * 1000 * 60;
                        _FailStatus = false;
                        EventLog.WriteEntry("ESCOAutomatedJobs", "ESCOAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString(), EventLogEntryType.SuccessAudit);
                    }
                    catch (Exception ex)
                    {
                        _FailStatus = true;
                        EventLog.WriteEntry("ESCOAutomatedJobs", "ESCOAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit);
                        System.Threading.Thread.Sleep(15000);
                    }
                }

                //ارسال اس ام اس بار اعلام شده 
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceSendSMSManager = new ESCOCoreSendSMSManager();
                    InstanceSendSMSManager.SendSMSofAnnouncedLoads(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (ESCOCoreSendSMSFailedException ex)
                { EventLog.WriteEntry("ESCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }
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
