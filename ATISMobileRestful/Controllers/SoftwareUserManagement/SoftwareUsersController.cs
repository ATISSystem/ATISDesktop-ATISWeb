using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Models;
using ATISMobileRestful.Exceptions;
using R2Core.LoggingManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.ConfigurationManagement;
using ATISMobileRestful.Logging;
using R2Core.DatabaseManagement;
using R2Core.DateAndTimeManagement;
using System.Data;
using R2Core.SecurityAlgorithmsManagement.Captcha;
using ATISMobileRestful.SecurityAlgorithms;
using R2Core.BlackIPs;
using R2Core.SecurityAlgorithmsManagement.ExpressionValidationAlgorithms;
using R2Core.SecurityAlgorithmsManagement.ExpressionValidationAlgorithms.Exceptions;
using R2Core.PredefinedMessagesManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2Core.MoneyWallet.Exceptions;

namespace ATISMobileRestful.Controllers.SoftwareUserManagement
{
    public class SoftwareUsersController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage RegisterMobileNumber()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientRegisteringMobileNumber(Request);

                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var MobileNumber = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var NSSSoftwareUser = InstanceSoftwareusers.RegisteringMobileNumber(MobileNumber);
                //کسر هزینه فعال سازی - از بابت اس ام اس
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
                if (InstanceConfiguration.GetConfigBoolean(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 10))
                { if (!NSSTrafficCard.NoMoney) { InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.MinusMoney, InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 11), R2CoreParkingSystemAccountings.RegisteringSoftwareUserSMSCost, InstanceSoftwareusers.GetNSSSystemUser()); } }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(string.Empty), Encoding.UTF8, "application/json");
                return response;
            }
            catch (SoftwareUserMoneyWalletNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (MobileNumberIsInvalidException ex)
            { return WebAPi.CreateErrorContentMessage((new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.MobileNumberIsInvalid).MsgContent); }
            catch (MobileNumberNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage((new R2CoreMClassPredefinedMessagesManager()).GetNSS(R2CorePredefinedMessages.MobileNumberNotFoundException).MsgContent); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage LogoutSoftwareUser()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientLogoutSoftwareUserRequest);

                var NSSSoftwareUser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                InstanceSoftwareUser.LogoutSoftwareUser(NSSSoftwareUser.UserId);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (UserNotExistByMobileNumberException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage LoginSoftwareUser()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientVerificationCode(Request);

                var InstanceAES = new AESAlgorithmsManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = Content.Split(';')[0];
                var NSSSoftwareuser = InstanceSoftwareUser.GetNSSUserUnChangeable (new R2CoreSoftwareUserMobile(MobileNumber));
                InstanceSoftwareusers.LoginSoftwareUser(NSSSoftwareuser.MobileNumber);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                var AMUStatus = InstanceAES.Encrypt(NSSSoftwareuser.MobileNumber, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + ";" + InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                response.Content = new StringContent(JsonConvert.SerializeObject(AMUStatus), Encoding.UTF8, "application/json");
                return response;
            }
            catch (SoftwareUserNotMatchException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetNonce()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientGetNonce(Request, ATISMobileWebApiLogTypes.WebApiClientNonceRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareuser = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var nonce = InstanceSoftwareuser.GetNonceforSoftwareUser(new R2CoreSoftwareUserMobile(MobileNumber));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(nonce), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetCaptcha()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientGetCaptcha(Request);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceCaptcha = new R2CoreInstanceCaptchaManager();
                var CaptchaImage = InstanceCaptcha.GenerateCaptcha(InstanceSoftwareusers.GetCaptchaNumericforSoftwareUser(NSSSoftwareuser));
                ImageRawData IImage = new ImageRawData();
                IImage.IRawData = (new JsonImage(CaptchaImage)).GetRawData();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(IImage), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        private void InvalidateCaptcha(HttpRequestMessage YourRequest)
        {
            try
            {
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(YourRequest.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable (new R2CoreSoftwareUserMobile(MobileNumber));
                InstanceSoftwareusers.CaptchaInvalidateforSoftwareUser(NSSSoftwareuser);
            }
            catch (Exception ex)
            { throw ex; }
        }
        [HttpPost]
        public HttpResponseMessage GetPersonalNonce()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientGetPersonalNonce(Request);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var PersonalNonce = InstanceSoftwareusers.GetPersonalNonceforSoftwareUser(NSSSoftwareuser);
                InvalidateCaptcha(Request);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(PersonalNonce), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            {
                InvalidateCaptcha(Request);
                return WebAPi.CreateErrorContentMessage(ex);
            }
        }


    }
}
