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
                var IP = WebAPi.GetClientIpAddress(Request);
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                InstanceBlackIP.AuthorizationIP(IP);
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var MobileNumber = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientRegisterMobileNumberRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientRegisterMobileNumberRequest).LogTitle, IP, MobileNumber, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null));

                InstanceSoftwareusers.RegisteringMobileNumber(MobileNumber);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(string.Empty), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (MobileNumberNotFoundException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
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
            catch (WebApiClientUnAuthorizedException ex)
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
                WebAPi.AuthenticateClientVerificationCodeNonce(Request);

                var InstanceAES = new AESAlgorithmsManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                InstanceSoftwareusers.LoginSoftwareUser(NSSSoftwareuser.MobileNumber);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                var AMUStatus = InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + ";" + InstanceAES.Encrypt(NSSSoftwareuser.MobileNumber, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                response.Content = new StringContent(JsonConvert.SerializeObject(AMUStatus), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
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
                var IP = WebAPi.GetClientIpAddress(Request);
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                InstanceBlackIP.AuthorizationIP(IP);
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var MobileNumber = InstanceAES.Decrypt(JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result), InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientNonceRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientNonceRequest).LogTitle, IP, MobileNumber, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null));

                //تولید نانس
                var nonce = InstanceSoftwareusers.GetNonceforSoftwareUser(new R2CoreSoftwareUserMobile(MobileNumber));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(nonce), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserIsNotActiveException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (UserNotExistException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
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
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientCaptchaRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceCaptcha = new R2CoreInstanceCaptchaManager();
                var CaptchaImage = InstanceCaptcha.GenerateCaptcha(InstanceSoftwareusers.GetCaptchaforSoftwareUser(NSSSoftwareuser));
                ImageRawData IImage = new ImageRawData();
                IImage.IRawData = (new JsonImage(CaptchaImage)).GetRawData();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(IImage), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (UserIsNotActiveException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (UserNotExistException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
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
                InstanceSoftwareusers.CaptchaInvalidateforSoftwareUser(new R2CoreSoftwareUserMobile(MobileNumber));
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
                WebAPi.AuthenticateClientApikeyNonceWith3Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientPersonalNonceRequest);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var UserShenaseh = Content.Split(';')[2];
                var UserPassword = Content.Split(';')[3];
                var Captcha = Content.Split(';')[4];
                InstanceSoftwareusers.AuthenticationUserByUserShenasehUserPasswordCaptcha(new R2CoreSoftwareUserMobile(MobileNumber), UserShenaseh, UserPassword, Captcha);

                //تولید نانس شخصی
                var PersonalNonce = InstanceSoftwareusers.GetPersonalNonceforSoftwareUser(new R2CoreSoftwareUserMobile(MobileNumber));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(PersonalNonce), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { InvalidateCaptcha(Request); return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIsNotActiveException ex)
            { InvalidateCaptcha(Request); return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistException ex)
            { InvalidateCaptcha(Request); return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { InvalidateCaptcha(Request); return WebAPi.CreateErrorContentMessage(ex); }
        }


    }
}
