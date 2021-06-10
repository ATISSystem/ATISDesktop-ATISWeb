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
using R2Core.DateAndTimeManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using ATISMobileRestful.Logging;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;

namespace ATISMobileRestful.Controllers.ReportManagement
{
    public class ReportsController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage GetLoadPermissionsIssuedOrderByPriorityReport()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientLoadPermissionsIssuedOrderByPriorityReportRequest);

                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var AHSGId = Convert.ToInt64(Content.Split(';')[2]);
                var InstanceReport = new R2CoreTransportationAndLoadNotificationInstanceLoadPermissionManager();
                List<KeyValuePair<string, string>> Lst = InstanceReport.ReportingInformationProviderLoadPermissionsIssuedOrderByPriorityReport(AHSGId);
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
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
