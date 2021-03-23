using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

using ATISMobileRestful.Exceptions;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISMobileRestful.Controllers.PublicMessageManagement
{
    public class PublicMessagesController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpGet]
        public HttpResponseMessage GetPublicMessage()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient2PartHashed(Request);

                string[] AllConfig = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers).Split(';');
                string Message = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 1);
                string ExpirationDate = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 0);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                if (R2CoreMclassDateAndTimeManagement.GetPersianDaysDiffDate(_DateTime.GetCurrentDateShamsiFull(), ExpirationDate) >= 0)
                { response.Content = new StringContent(JsonConvert.SerializeObject(Message), Encoding.UTF8, "application/json"); }
                else
                { response.Content = new StringContent(JsonConvert.SerializeObject(string.Empty), Encoding.UTF8, "application/json"); }
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage GetPublicAnotation()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient2PartHashed(Request);

                string[] AllConfig = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers).Split(';');
                string Message = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 1);
                string ExpirationDate = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 0);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                if (R2CoreMclassDateAndTimeManagement.GetPersianDaysDiffDate(_DateTime.GetCurrentDateShamsiFull(), ExpirationDate) >= 0)
                { response.Content = new StringContent(JsonConvert.SerializeObject(Message), Encoding.UTF8, "application/json"); }
                else
                { response.Content = new StringContent(JsonConvert.SerializeObject(string.Empty), Encoding.UTF8, "application/json"); }
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }
    }
}
