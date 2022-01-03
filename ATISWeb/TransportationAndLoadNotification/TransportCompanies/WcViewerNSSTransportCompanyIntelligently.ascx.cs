using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using R2Core.SoftwareUserManagement;

namespace ATISWeb.TransportationAndLoadNotification.TransportCompanies
{
    public partial class WcViewerNSSTransportCompanyIntelligently : System.Web.UI.UserControl
    {
        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure NSS = InstanceTransportCompanies.GetNSSTransportCompnay(InstanceLogin.GetNSSCurrentUser());
                TxtTransportCompanyTitle.Text = NSS.TCTitle.Trim();
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }
        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion

    }
}