using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

using R2Core.ExceptionManagement;
using R2Core.SecurityAlgorithmsManagement.Captcha;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using System.IO;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2Core.LoggingManagement;
using ATISWeb.LoggingManagement;
using R2Core.DateAndTimeManagement;
using ATISWeb.PublicProcedures;
using R2Core.BlackIPs;
using R2Core.BlackIPs.Exceptions;

namespace ATISWeb.LoginManagement
{
    public partial class WcLogin : System.Web.UI.UserControl
    {
        private R2DateTime _DateTime = new R2DateTime();
        private R2CoreInstanceLoggingManager InstanceLogging = new R2CoreInstanceLoggingManager();
        private R2CoreInstanseSoftwareUsersManager InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
        private ATISWebPublicProceduresManager InstancePublicProcedures = new ATISWebPublicProceduresManager();
        private R2CoreInstanceBlackIPsManager InstanceBlackIPs = new R2CoreInstanceBlackIPsManager();

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        private void FillCaptcha()
        {
            try
            {
                var Captcha = new R2CoreInstanceCaptchaManager();
                string CWord = Captcha.GenerateFakeWord(5);
                Session["_CaptchaWord"] = CWord;
                Bitmap CImage = Captcha.GenerateCaptcha(CWord);
                CImage.Save(Server.MapPath("~/Images/Captcha.jpg"));
                ImgCaptcha.ImageUrl = "~/Images/Captcha.jpg";
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }
        #endregion

        #region "Events"
        public event EventHandler WcUserAuthenticationSuccessEvent;
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BtnSubmit.Click += BtnSubmit_Click;
                ImgBRecaptcha.Click += ImgBRecaptcha_Click;
                if (!Page.IsPostBack)
                { FillCaptcha(); }
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void ImgBRecaptcha_Click(object sender, ImageClickEventArgs e)
        {
            try { FillCaptcha(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string ClientIP = null;
            try
            {
                ClientIP = InstancePublicProcedures.GetClientIpAddress(Request);
                InstanceBlackIPs.AuthorizationIP(ClientIP);

                if (Session["_CaptchaWord"].ToString() != TxtCaptcha.Text) { throw new CaptchaWordNotCorrectException(); }
                R2CoreMClassSoftwareUsersManagement.AuthenticationUserbyShenasehPassword(new R2CoreStandardSoftwareUserStructure(0, string.Empty, string.Empty, "", TxtUserShenaseh.Text, TxtUserPassword.Text, string.Empty, "", false, false, Int64.MinValue, string.Empty, string.Empty, string.Empty, new DateTime(), 0, string.Empty, new DateTime(), 0, string.Empty, new DateTime(), string.Empty, false, Int64.MinValue, new DateTime(), null, false, false));
                R2CoreStandardSoftwareUserStructure NSS = R2CoreMClassSoftwareUsersManagement.GetNSSUser(TxtUserShenaseh.Text, TxtUserPassword.Text);
                Session.Add("CurrentUser", NSS);
                Session.Timeout = 20;
                if (InstanceLogging.GetNSSLogType(ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication, InstanceLogging.GetNSSLogType(ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication).LogTitle, ClientIP, NSS.UserName , string.Empty, string.Empty, string.Empty, InstanceSoftwareUsers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                WcUserAuthenticationSuccessEvent?.Invoke(this, e);
            }
            catch (AuthorizationIPIPIsBlackException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex) when (ex is UserIsNotActiveException || ex is UserNotExistException || ex is GetNSSException || ex is CaptchaWordNotCorrectException)
            {
                if (InstanceLogging.GetNSSLogType(ATISWebLogTypes.UnSuccessfulSoftwareUserShenasehPasswordAuthentication).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISWebLogTypes.UnSuccessfulSoftwareUserShenasehPasswordAuthentication, InstanceLogging.GetNSSLogType(ATISWebLogTypes.UnSuccessfulSoftwareUserShenasehPasswordAuthentication).LogTitle, ClientIP, string.Empty, string.Empty, string.Empty, string.Empty, InstanceSoftwareUsers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
            FillCaptcha();
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