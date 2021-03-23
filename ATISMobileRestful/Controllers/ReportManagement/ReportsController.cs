using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;

using R2CoreTransportationAndLoadNotification.LoadPermission;
using ATISMobileRestful.Exceptions;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;

namespace ATISMobileRestful.Controllers.ReportManagement
{
    public class ReportsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetLoadPermissionsIssuedOrderByPriorityReport()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("AHSGId", out IEnumerable<string> AHSGId);
                var InstanceReport = new R2CoreTransportationAndLoadNotificationInstanceLoadPermissionManager();
                List<KeyValuePair<string, string>> Lst = InstanceReport.ReportingInformationProviderLoadPermissionsIssuedOrderByPriorityReport(Convert.ToInt64(AHSGId.FirstOrDefault()));
                List<Models.PermissionsIssued> _PermissionsIssued = new List<Models.PermissionsIssued>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.PermissionsIssued();
                    Item.ReportItemHeader = Lst[Loopx].Key;
                    Item.ReportItemDetails = Lst[Loopx].Value;
                    _PermissionsIssued.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_PermissionsIssued), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }
    }
}
