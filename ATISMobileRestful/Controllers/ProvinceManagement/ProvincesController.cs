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

                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var AHId = Content.Split(';')[2];
                var AHSGId = Content.Split(';')[3];
                var LoadCapacitorLoadsListType = Content.Split(';')[4];
                List<Models.Province> _Provinces = new List<Models.Province>();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var Lst = InstanceLoadCapacitorLoad.GetProvincesWithNumberOfLoads(Convert.ToInt64(AHId), Convert.ToInt64(AHSGId), Convert.ToInt64(LoadCapacitorLoadsListType));
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
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadTargetsforProvinceNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }
    }
}
