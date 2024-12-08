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
using BillOfLadingCore.Configurations;
using BillOfLadingCore.BillOfLading;

namespace BillOfLadingAutomatedJobs
{
    public partial class BillOfLadingAutomatedJobs : ServiceBase
    {
        private System.Timers.Timer _AutomatedJobsTimer = new System.Timers.Timer();
        private R2DateTime _DateTime;
        private Boolean _FailStatus = true;

        public BillOfLadingAutomatedJobs()
        {
            InitializeComponent();
            _AutomatedJobsTimer.Elapsed += _AutomatedJobsTimer_Elapsed;
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                if (EventLog.SourceExists("BillOfLadingAutomatedJobs"))
                { }
                else
                { EventLog.CreateEventSource("BillOfLadingAutomatedJobs", "BillOfLadingAutomatedJobs"); }

                _AutomatedJobsTimer.Interval = 1000;
                _AutomatedJobsTimer.Enabled = true;
                _AutomatedJobsTimer.Start();

                EventLog.WriteEntry("BillOfLadingAutomatedJobs", "BillOfLadingAutomatedJobs Start ...", EventLogEntryType.SuccessAudit);
            }
            catch (Exception ex)
            { EventLog.WriteEntry("BillOfLadingAutomatedJobs", "OnStart()." + ex.Message.ToString(), EventLogEntryType.Error); }

        }

        protected override void OnStop()
        {
            try
            {
                _AutomatedJobsTimer.Enabled = false;
                _AutomatedJobsTimer.Stop();
                _AutomatedJobsTimer = null;
                EventLog.WriteEntry("BillOfLadingAutomatedJobs", "BillOfLadingAutomatedJobs Stop ...", EventLogEntryType.SuccessAudit);
            }
            catch (Exception ex)
            { EventLog.WriteEntry("BillOfLadingAutomatedJobs", "OnStop()." + ex.Message.ToString(), EventLogEntryType.Error); }

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
                        _AutomatedJobsTimer.Interval = Convert.ToInt64(InstanceConfiguration.GetConfig( BillOfLadingCoreConfigurations.BillOfLading , 2, 3600)) * 1000 * 60;
                        _FailStatus = false;
                        EventLog.WriteEntry("BillOfLadingAutomatedJobs", "BillOfLadingAutomatedJobs.Interval=" + _AutomatedJobsTimer.Interval.ToString(), EventLogEntryType.SuccessAudit);
                    }
                    catch (Exception ex)
                    {
                        _FailStatus = true;
                        EventLog.WriteEntry("BillOfLadingAutomatedJobs", "BillOfLadingAutomatedJobs.Interval Setting Failed", EventLogEntryType.SuccessAudit);
                        System.Threading.Thread.Sleep(15000);
                    }
                }

                //ابطال نوبت ها بر اساس بارنامه 
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceBillOfLadingConditionedAnnouncement = new BillOfLadingCoreBillOfLadingConditionedAnnouncementManager();
                    InstanceBillOfLadingConditionedAnnouncement.TurnsCancellation(InstanceSoftwareUsers.GetNSSSystemUser());
                }
                catch (Exception ex)
                { EventLog.WriteEntry("BillOfLadingAutomatedJobs:",ex.Message.ToString(), EventLogEntryType.Error); }
            }
            catch (Exception ex)
            { EventLog.WriteEntry("BillOfLadingAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString(), EventLogEntryType.Error); }
            _AutomatedJobsTimer.Enabled = true;
            _AutomatedJobsTimer.Start();
        }

    }
}
