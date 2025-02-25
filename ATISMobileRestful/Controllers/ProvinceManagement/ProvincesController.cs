using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;
using System.Text;

using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.LoadTargets;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation;
using R2CoreTransportationAndLoadNotification.LoadTargets.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.ConfigurationManagement;
using R2Core.SoftwareUserManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using ATISMobileRestful.Exceptions;
using R2Core.DateAndTimeManagement;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;
using R2CoreTransportationAndLoadNotification.Turns;
using R2Core.SiteIsBusy;
using R2Core.SiteIsBusy.Exceptions;
using R2CoreTransportationAndLoadNotification.RequesterManagement;

namespace ATISMobileRestful.Controllers.ProvinceManagement
{
    public class ProvincesController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage GetProvinces()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonceWith3Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientProvincesRequest);

                var InstanceSiteIsBusy = new R2CoreSiteIsBusyManager();
                InstanceSiteIsBusy.SiteIsBusy();

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var AHId = Content.Split(';')[2];
                var AHSGId = Content.Split(';')[3];
                var LoadCapacitorLoadsListType = Content.Split(';')[4];
                Int64 LoadStatusId = Convert.ToInt64(LoadCapacitorLoadsListType) == (long)R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered ? Convert.ToInt64(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered) : Convert.ToInt64(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented);

                List<Models.Province> _Provinces = new List<Models.Province>();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var Lst = InstanceLoadCapacitorLoad.GetProvincesWithNumberOfLoadsforApplication(R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullLoadAllocationRegisteringAgent, NSSSoftwareuser, Convert.ToInt64(AHSGId), LoadStatusId);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.Province();
                    Item.ProvinceId = "کداستان: " + Lst[Loopx].Province.ProvinceId.ToString();
                    Item.ProvinceTitle = Lst[Loopx].Province.ProvinceTitle + "  :  تعداد بار " + Lst[Loopx].NumberOfLoads.ToString();
                    _Provinces.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_Provinces), Encoding.UTF8, "application/json");
                return response;
            }
            catch (R2CoreSiteIsBusyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadTargetsforProvinceNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
