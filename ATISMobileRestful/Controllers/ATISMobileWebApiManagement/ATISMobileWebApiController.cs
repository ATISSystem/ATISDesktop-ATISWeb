using ATISMobileRestful.Exceptions;
using ATISMobileRestful.Logging;
using Newtonsoft.Json;
using R2Core.BlackIPs;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ATISMobileRestful.Controllers.ATISMobileWebApiManagement
{
    public class ATISMobileWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ISWebApiLive()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient(Request, ATISMobileWebApiLogTypes.WebApiClientIsWebAPIAliveRequest);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject("ATISMobileWebAPiIsLive"), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
