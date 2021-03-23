using ATISMobileRestful.Exceptions;
using Newtonsoft.Json;
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
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject("ATISMobileWebAPiIsLive"), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }
    }
}
