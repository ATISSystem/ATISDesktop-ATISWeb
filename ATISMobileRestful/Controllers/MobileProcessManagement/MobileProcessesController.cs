
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

using ATISMobileRestful.Exceptions;
using ATISMobileRestful.Models;
using R2Core.MobileProcessesManagement;
using R2Core.MobileProcessesManagement.Exceptions;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISMobileRestful.Controllers.MobileProcessManagement
{
    public class MobileProcessesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetMobileProcesses()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                R2CoreInstanceMobileProcessesManager InstanceMobileProcesses = new R2CoreInstanceMobileProcessesManager();
                R2CoreInstanseSoftwareUsersManager InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                List<MobileProcess> _MobileProcesses = new List<MobileProcess>();
                var Lst = InstanceMobileProcesses.GetMobileProcesses(InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new MobileProcess();
                    Item.PId = Lst[Loopx].PId;
                    Item.PName = Lst[Loopx].PName;
                    Item.PTitle = Lst[Loopx].PTitle;
                    Item.TargetMobilePage = Lst[Loopx].TargetMobilePageDelegate ;
                    Item.Description = Lst[Loopx].Description;
                    Item.PForeColor = Lst[Loopx].PForeColor;
                    Item.PBackColor = Lst[Loopx].PBackColor;
                    _MobileProcesses.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_MobileProcesses), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (SoftwareUserHasNotAnyMobileProcessPermissionException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch(UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }
    }
}

