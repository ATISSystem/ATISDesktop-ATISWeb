using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;
using System.Text;
using Newtonsoft.Json;

using ATISMobileRestful.Models;
using ATISMobileRestful.Exceptions;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using ATISMobileRestful.Logging;
using R2Core.DateAndTimeManagement;

namespace ATISMobileRestful.Controllers.VersionControlManagement
{
    public class VersionControlController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpGet]
        public HttpResponseMessage HaveNewerVersion()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                //باید در فایروال از اتک جلوگیری شود
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientVersionControlRequest , InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientVersionControlRequest ).LogTitle, WebAPi.GetClientIpAddress(Request), String.Empty, string.Empty, string.Empty, string.Empty, InstanceSoftwareusers.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), null));

                //کنترل اطلاعات ورژن ارسالی و ورژن موجود روی سایت
                string WebApiVersionNumber = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[0].Split(':')[1].Trim();
                string WebApiVersionName = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[1].Split(':')[1].Trim();
                Request.Headers.TryGetValues("VersionNumber", out IEnumerable<string> VersionNumber);
                Request.Headers.TryGetValues("VersionName", out IEnumerable<string> VersionName);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                if (VersionNumber.FirstOrDefault().Trim() != WebApiVersionNumber || VersionName.FirstOrDefault().Trim() != WebApiVersionName)
                { response.Content = new StringContent(JsonConvert.SerializeObject(Boolean.TrueString), Encoding.UTF8, "application/json"); }
                else
                { response.Content = new StringContent(JsonConvert.SerializeObject(Boolean.FalseString), Encoding.UTF8, "application/json"); }
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
