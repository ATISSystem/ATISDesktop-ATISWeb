using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;

using R2Core.DateAndTimeManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;

namespace ATISMobileRestful
{
    public class ATISMobileWebApi
    {
        R2DateTime _DateTime = new R2DateTime();
        MD5Hasher _MD5Hasher = new MD5Hasher();

        private static string GetAPPId()
        { return "0D992C8C-3F8A-428A-8638-25B94D04BEA7"; }

        private string GetAuthCode2PartHashed()
        { return _MD5Hasher.GenerateMD5String(GetAPPId() + ":" + DateTime.Now.Day); }

        private string GetAuthCode3PartHashed(string YourApiKey)
        { try { return _MD5Hasher.GenerateMD5String(GetAPPId() + ":" + DateTime.Now.Day + ":" + YourApiKey); } catch (Exception ex) { throw ex; } }

        public string GetAuthCode4PartHashed(string YourApiKey, string YourLast5Digit)
        { try { return _MD5Hasher.GenerateMD5String(GetAPPId() + ":" + DateTime.Now.Day + ":" + YourApiKey + ":" + YourLast5Digit); } catch (Exception ex) { throw ex; } }

        public void AuthenticateClient2PartHashed(HttpRequestMessage YourRequest)
        {
            try
            {
                YourRequest.Headers.TryGetValues("AuthCode", out IEnumerable<string> AuthCode);
                if (AuthCode.FirstOrDefault() == GetAuthCode2PartHashed())
                { }
                else
                { throw new WebApiClientUnAuthorizedException(); }
            }
            catch (WebApiClientUnAuthorizedException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClient3PartHashed(HttpRequestMessage YourRequest)
        {
            try
            {
                YourRequest.Headers.TryGetValues("AuthCode", out IEnumerable<string> AuthCode);
                YourRequest.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                if (AuthCode.FirstOrDefault() == GetAuthCode3PartHashed(ApiKey.FirstOrDefault()))
                {
                    R2CoreInstanseSoftwareUsersManager Instanse = new R2CoreInstanseSoftwareUsersManager();
                    Instanse.AuthenticationUserByApiKey(ApiKey.FirstOrDefault());
                }
                else
                { throw new WebApiClientUnAuthorizedException(); }
            }
            catch (UserNotExistByApiKeyException ex)
            { throw ex; }
            catch (UserIsNotActiveException ex)
            { throw ex; }
            catch (WebApiClientUnAuthorizedException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public void AuthenticateClient4PartHashed(HttpRequestMessage YourRequest)
        {
            try
            {
                YourRequest.Headers.TryGetValues("AuthCode", out IEnumerable<string> AuthCode);
                YourRequest.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                YourRequest.Headers.TryGetValues("Last5Digit", out IEnumerable<string> Last5Digit);
                if (AuthCode.FirstOrDefault() == GetAuthCode4PartHashed(ApiKey.FirstOrDefault(), Last5Digit.FirstOrDefault()))
                {
                    R2CoreInstanseSoftwareUsersManager Instanse = new R2CoreInstanseSoftwareUsersManager();
                    Instanse.AuthenticationUserByApiKey(ApiKey.FirstOrDefault(), Last5Digit.First());
                }
                else
                { throw new WebApiClientUnAuthorizedException(); }
            }
            catch (UserLast5DigitNotMatchingException ex)
            { throw ex; }
            catch (UserNotExistException ex)
            { throw ex; }
            catch (UserIsNotActiveException ex)
            { throw ex; }
            catch (WebApiClientUnAuthorizedException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public HttpResponseMessage CreateContentMessage(Exception YourException)
        {
            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            response.Content = new StringContent(JsonConvert.SerializeObject(YourException.Message), Encoding.UTF8, "application/json");
            return response;
        }

        private const string HttpContext = "MS_HttpContext";
        private const string RemoteEndpointMessage = "System.ServiceModel.Channels.RemoteEndpointMessageProperty";
        public string GetClientIpAddress(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey(HttpContext))
            {
                dynamic ctx = request.Properties[HttpContext];
                if (ctx != null)
                {
                    return ctx.Request.UserHostAddress;
                }
            }

            if (request.Properties.ContainsKey(RemoteEndpointMessage))
            {
                dynamic remoteEndpoint = request.Properties[RemoteEndpointMessage];
                if (remoteEndpoint != null)
                {
                    return remoteEndpoint.Address;
                }
            }

            return null;
        }


    }
    namespace Logging
    {
        public abstract class ATISMobileWebApiLogTypes : R2CoreTransportationAndLoadNotificationLogType 
        {
            public static Int64 WebApiClientIp = 20;
        }

    }


    namespace Exceptions
    {
        public class WebApiClientUnAuthorizedException : ApplicationException
        {
            public override string Message
            { get { return "خطای امنیتی کد: 38 با واحد پشتیبانی آتیس تماس بگیرید"; } }
        }

    }
}