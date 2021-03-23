using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement.Exceptions;
using R2Core.SoftwareUserManagement;

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

                if (ATISWebMClassLoginManagement.GetNSSCurrentUser().UserPassword == TxtCurrentUserPassword.Text)
                {
                    if (R2CoreMClassSoftwareUsersManagement.IsUserRegistered(new R2CoreStandardSoftwareUserStructure(0,string.Empty , string.Empty, ATISWebMClassLoginManagement.GetNSSCurrentUser().UserShenaseh, TxtNewUserPassword.Text.Trim(), null, false, false,Int64.MinValue  , null, null, null, Int64.MinValue, new DateTime() , null, false  ,false   )))
                    {
                        Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + "رمز عبور جدید مورد تایید نیست" + "');", true);
                        return;
                    }

                    R2CoreMClassSoftwareUsersManagement.ChangeUserPassword(new R2CoreStandardSoftwareUserStructure(ATISWebMClassLoginManagement.GetNSSCurrentUser().UserId,string.Empty , null, null, TxtNewUserPassword.Text.Trim(), null, false, false, Int64.MinValue, null, null, null, Int64.MinValue, new DateTime(), null, false, false));
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "رمز عبور تغییر یافت" + "');", true);
                }
                else { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + "رمز عبور فعلی کاربر نادرست است" + "');", true); }
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