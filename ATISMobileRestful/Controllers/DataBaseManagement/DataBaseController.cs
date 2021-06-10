using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

using ATISMobileRestful.Exceptions;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using ATISMobileRestful.Logging;
using R2Core.DateAndTimeManagement;
using R2Core.BlackIPs;

namespace ATISMobileRestful.Controllers.DataBaseManagement
{
    public class DataBaseController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage ConfirmAMUStatus()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient(Request, ATISMobileWebApiLogTypes.WebApiClientConfirmAMUStatusRequest);

                string AMUStatus = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                bool Confirmed = false;
                if (String.IsNullOrEmpty(AMUStatus))
                { Confirmed = false; }
                else
                { if (AMUStatus.Split(';').Length != 2) { Confirmed = false; } else { Confirmed = true ; } }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(Confirmed), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
