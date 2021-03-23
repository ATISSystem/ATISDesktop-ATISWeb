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

namespace ATISMobileRestful.Controllers.PermissionManagement
{
    public class PermissionsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ExistPermission()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                Request.Headers.TryGetValues("PermissionTypeId", out IEnumerable<string> PermissionTypeId);
                Request.Headers.TryGetValues("EntityIdSecond", out IEnumerable<string> EntityIdSecond);
                var InstanseSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstansePermissions = new R2CoreInstansePermissionsManager();
                bool P = InstansePermissions.ExistPermission(Convert.ToInt64(PermissionTypeId.FirstOrDefault()), InstanseSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()).UserId, Convert.ToInt64(EntityIdSecond.FirstOrDefault()));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(P), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
