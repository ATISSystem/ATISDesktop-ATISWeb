using System;
using System.IO;
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
using R2Core.SecurityAlgorithmsManagement;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2Core.LoggingManagement;
using R2Core.DateAndTimeManagement;
using R2Core.BlackIPs;
using R2Core.BlackIPs.Exceptions;

using ATISWeb.LoggingManagement;
using ATISWeb.PublicProcedures;
using System.Text;

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

        public class ImageRawData
        { public byte[] IRawData; }

        public class AESAlgorithms
        {
            public byte[] ImageToBytes(System.Drawing.Image value)
            {
                ImageConverter converter = new ImageConverter();
                byte[] arr = (byte[])converter.ConvertTo(value, typeof(byte[]));
                return arr;
            }
            public System.Drawing.Image BytesToImage(byte[] value)
            {
                using (var ms = new MemoryStream(value))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            public string EncodeBytes(byte[] value) => Convert.ToBase64String(value);
            public byte[] DecodeBytes(string value) => Convert.FromBase64String(value);
            public string StringHash(byte[] value)
            {
                using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(value);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString().ToLower();
                }
            }
        }

        public class JsonImage
        {
            private AESAlgorithms _AESAlgorithms = new AESAlgorithms();
            public string hash { get; set; } = string.Empty;
            public int len { get; set; } = 0;
            public string image { get; set; } = string.Empty;
            public JsonImage() { }
            public JsonImage(System.Drawing.Image value)
            {
                byte[] img_sources = _AESAlgorithms.ImageToBytes(value);
                hash = _AESAlgorithms.StringHash(img_sources);
                len = img_sources.Length;
                image = _AESAlgorithms.EncodeBytes(img_sources);
            }
            public byte[] GetRawData()
            {
                byte[] data = _AESAlgorithms.DecodeBytes(image);

                if (data.Length != len) throw new Exception("Error data len");
                if (!_AESAlgorithms.StringHash(data).Equals(hash)) throw new Exception("Error hash");

                return data;
            }

        }

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
                //ImgCaptcha.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String((new JsonImage(CImage)).GetRawData());
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
                R2CoreStandardSoftwareUserStructure NSS = R2CoreMClassSoftwareUsersManagement.GetNSSUser(TxtUserShenaseh.Text, TxtUserPassword.Text,R2CoreTransportationAndLoadNotification.SoftwareUserManagement.R2CoreTransportationAndLoadNotificationSoftwareUserTypes.TransportCompany );
                Session.Add("CurrentUser", NSS);
                Session.Timeout = 20;
                if (InstanceLogging.GetNSSLogType(ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication).Active)
                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication, InstanceLogging.GetNSSLogType(ATISWebLogTypes.SuccessfulSoftwareUserShenasehPasswordAuthentication).LogTitle, ClientIP, NSS.UserName, string.Empty, string.Empty, string.Empty, InstanceSoftwareUsers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }

                if (DateTime.Compare(_DateTime.GetMilladiDateTimeFromDateShamsiFull(NSS.UserPasswordExpiration, "00:00:00"), _DateTime.GetCurrentDateTimeMilladi()) < 0)
                {
                    Response.Redirect("/LoginManagement/WfChangeSoftwareUserPassword.aspx");
                    return;
                };

                WcUserAuthenticationSuccessEvent?.Invoke(this, e);
            }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + "شناسه یا رمز عبور قابل پذیرش نیست" + "');", true); }
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