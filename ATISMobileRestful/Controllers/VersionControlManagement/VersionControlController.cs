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

namespace ATISMobileRestful.Controllers.VersionControlManagement
{
    public class VersionControlController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage HaveNewerVersion()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient2PartHashed(Request);

                Request.Headers.TryGetValues("AuthCode", out IEnumerable<string> AuthCode);
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
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage GetAppLastVersionNumber()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                 WebAPi.AuthenticateClient2PartHashed(Request);

                string WebApiVersionNumber = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[0].Split(':')[1];
                string WebApiVersionName = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[1].Split(':')[1];
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(WebApiVersionNumber), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }



    }
}
