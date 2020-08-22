using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using R2Core.UserManagement;

namespace ATISWeb.LoginManagement
{
    public partial class WcChangePasswordofCurrentUser : System.Web.UI.UserControl
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        { BtnSubmit.Click += BtnSubmit_Click; }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNewUserPassword.Text != TxtNewUserPasswordConfirm.Text) { throw new Exception("رمز عبور جدید را کنترل نمایید"); }

                if (R2CoreMClassLoginManagement.CurrentUserNSS.UserPassword == TxtCurrentUserPassword.Text)
                { R2CoreMClassLoginManagement.ChangeUserPassword(new R2CoreStandardUserStructure(R2CoreMClassLoginManagement.CurrentUserNSS.UserId, null, null, TxtNewUserPassword.Text.Trim(), null, false, true)); }
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "رمز عبور تغییر یافت" + "');", true);
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