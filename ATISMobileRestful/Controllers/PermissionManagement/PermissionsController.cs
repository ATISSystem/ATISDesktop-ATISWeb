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

                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var TargetMobileProcessId = Content.Split(';')[2];
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var InstansePermissions = new R2CoreInstansePermissionsManager();
                bool P = InstansePermissions.ExistPermission(R2CorePermissionTypes.SoftwareUsersAccessMobileProcesses, NSSSoftwareuser.UserId, Convert.ToInt64(TargetMobileProcessId));

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(P), Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
