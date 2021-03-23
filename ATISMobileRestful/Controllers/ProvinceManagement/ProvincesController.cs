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

namespace ATISMobileRestful.Controllers.ProvinceManagement
{
    public class ProvincesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetProvinces()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("AHId", out IEnumerable<string> AHId);
                Request.Headers.TryGetValues("AHSGId", out IEnumerable<string> AHSGId);
                Request.Headers.TryGetValues("LoadCapacitorLoadsListType", out IEnumerable<string> LoadCapacitorLoadsListType);

                List<Models.Province> _Provinces = new List<Models.Province>();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var Lst = InstanceLoadCapacitorLoad.GetProvincesWithNumberOfLoads(Convert.ToInt64(AHId.FirstOrDefault()), Convert.ToInt64(AHSGId.FirstOrDefault()), Convert.ToInt64(LoadCapacitorLoadsListType.FirstOrDefault()));
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
            catch (LoadTargetsforProvinceNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }


    }
}
