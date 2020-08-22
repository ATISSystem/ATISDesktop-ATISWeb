using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.TransportCompanies;
using R2Core.UserManagement;

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
                R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure NSS = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS);
                TxtTransportCompanyTitle.Text = NSS.TCTitle.Trim();
            }
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