using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using R2Core.ExceptionManagement;
using R2Core.UserManagement;
using R2Core.UserManagement.Exceptions;

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
                if (R2CoreMClassLoginManagement.AuthenticationUserbyShenasehPassword(new R2CoreStandardUserStructure(0, "", TxtUserShenaseh.Text, TxtUserPassword.Text, "", false, false)))
                {
                    R2CoreStandardUserStructure NSS = R2CoreMClassLoginManagement.GetNSSUser(TxtUserShenaseh.Text, TxtUserPassword.Text);
                    Session.Add("CurrentUser", NSS);
                    Session.Timeout = 60;
                    WcUserAuthenticationSuccessEvent?.Invoke(this, e);
                }
                else
                { }
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