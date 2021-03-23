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

namespace ATISMobileRestful.Controllers.SoftwareUserManagement
{
    public class SoftwareUsersController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage RegisterMobileNumber()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient2PartHashed(Request);

                string MobileNumber = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var Instanse = new R2CoreInstanseSoftwareUsersManager();
                Instanse.RegisteringMobileNumber(MobileNumber);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (MobileNumberNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpPut]
        public HttpResponseMessage LogoutSoftwareUser()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                R2CoreInstanseSoftwareUsersManager Instanse = new R2CoreInstanseSoftwareUsersManager();
                string ApiKey = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                Instanse.LogoutSoftwareUser(Instanse.GetNSSUser(ApiKey).UserId);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;

            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage LoginSoftwareUser()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient2PartHashed(Request);

                Request.Headers.TryGetValues("MobileNumber", out IEnumerable<string> MobileNumber);
                Request.Headers.TryGetValues("VerificationCode", out IEnumerable<string> VerificationCode);
                R2CoreInstanseSoftwareUsersManager Instanse = new R2CoreInstanseSoftwareUsersManager();
                Int64 UserId = Instanse.LoginSoftwareUser(MobileNumber.FirstOrDefault(), VerificationCode.FirstOrDefault());
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(UserId), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (SoftwareUserNotMatchException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage ApiKeyLast5DigitParing()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject("ParingSucceded"), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserIsNotActiveException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
