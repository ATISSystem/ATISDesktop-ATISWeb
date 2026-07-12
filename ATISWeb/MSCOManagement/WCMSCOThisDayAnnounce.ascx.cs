using ATISWeb.LoginManagement;
using MSCOCore.AnnouncementProcess.Exceptions;
using MSCOCore.MSCOTransportCompanies;
using R2Core.DateAndTimeManagement;
using R2Core.FileShareRawGroupsManagement;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb.MSCOManagement
{
    public partial class WCMSCOThisDayAnnounce : System.Web.UI.UserControl
    {
        private R2DateTime _DateTime = new R2DateTime();
        private R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService WS = new R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnThisDayAnnounce.Click += BtnThisDayAnnounce_Click;
        }

        private void BtnThisDayAnnounce_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceMSCOTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                var InstanceSoftwareUsers = new R2Core.SoftwareUserManagement.R2CoreInstanseSoftwareUsersManager();

                var NSS = InstanceTransportCompanies.GetNSSTransportCompnay(InstanceLogin.GetNSSCurrentUser());
                var MSCOId = InstanceMSCOTransportCompanies.GetTransportCompanyMSCOId(NSS.TCId);

                byte[] btFile;
                var FileNameIS = "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt";
                if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
                { btFile = WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)); }
                else if(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
                { btFile = WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)); }
                else if(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt.del.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
                { btFile = WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + MSCOId + ".txt.del.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)); }
                else { throw new MSCOCore.AnnouncementProcess.Exceptions.MSCOCoreMSCOTCFileNotFoundException() ; }
                Response.Buffer = true;
                Response.Expires = 0;
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Type", "application/octet-stream");
                //Response.AddHeader("Content-Length", btFile.Length.ToString);
                Response.AddHeader("Content-Disposition", "attachment;filename="+ FileNameIS);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(btFile);
                Response.End();
            }
            catch (MSCOCoreMSCOTCFileNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" +ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

    }
}