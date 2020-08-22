using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb.LoginManagement
{
    public partial class WfLogin : System.Web.UI.Page
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
            try { WcLogin.WcUserAuthenticationSuccessEvent += WcLogin_WcUserAuthenticationSuccessEvent; }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WcLogin_WcUserAuthenticationSuccessEvent(object sender, EventArgs e)
        {
            try { Response.Redirect("/MenuManagement/WfMainMenu.aspx"); }
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