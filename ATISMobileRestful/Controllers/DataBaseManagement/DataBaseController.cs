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

namespace ATISMobileRestful.Controllers.DataBaseManagement
{
    public class DataBaseController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpGet]
        public HttpResponseMessage ConfirmAMUStatus()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                //باید در فایروال از اتک جلوگیری شود
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientConfirmAMUStatusRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientConfirmAMUStatusRequest).LogTitle, WebAPi.GetClientIpAddress(Request), String.Empty, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null));

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
