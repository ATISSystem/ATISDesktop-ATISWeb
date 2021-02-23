using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.ExceptionManagement;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISWeb.LoginManagement
{
    public partial class WcLogin : System.Web.UI.UserControl
    {
        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        public event EventHandler WcUserAuthenticationSuccessEvent;
        #endregion

        #region "Event Handlers"
        protected void Page_Load(object sender, EventArgs e)
        {
            try { BtnSubmit.Click += BtnSubmit_Click; }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreMClassSoftwareUsersManagement.AuthenticationUserbyShenasehPassword(new R2CoreStandardSoftwareUserStructure(0, "", TxtUserShenaseh.Text, TxtUserPassword.Text, "", false, false, Int64.MinValue, string.Empty, string.Empty, string.Empty, Int64.MinValue, new DateTime(), null, false, false));
                R2CoreStandardSoftwareUserStructure NSS = R2CoreMClassSoftwareUsersManagement.GetNSSUser(TxtUserShenaseh.Text, TxtUserPassword.Text);
                Session.Add("CurrentUser", NSS);
                Session.Timeout = 60;
                WcUserAuthenticationSuccessEvent?.Invoke(this, e);
            }
            catch (Exception ex) when (ex is UserIsNotActiveException || ex is UserNotExistException || ex is GetNSSException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
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