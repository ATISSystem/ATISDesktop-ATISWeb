using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;

using ATISMobileRestful.Exceptions;
using ATISMobileRestful.Models;
using R2Core.PermissionManagement;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using R2Core.LoggingManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using ATISMobileRestful.Logging;
using R2Core.DateAndTimeManagement;

namespace ATISMobileRestful.Controllers.PermissionManagement
{
    public class PermissionsController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage ExistPermission()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientExistPermissionRequest);

                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var TargetMobileProcessId = Content.Split(';')[2];
                var InstansePermissions = new R2CoreInstansePermissionsManager();
                bool P = InstansePermissions.ExistPermission(R2CorePermissionTypes.SoftwareUsersAccessMobileProcesses, WebAPi.GetNSSSoftwareUser(Request).UserId, Convert.ToInt64(TargetMobileProcessId));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(P), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (SoftwareUserNotMatchException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
