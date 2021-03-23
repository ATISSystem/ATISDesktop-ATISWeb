using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;

using R2Core.PublicProc;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using ATISMobileRestful.Models;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Exceptions;

namespace ATISMobileRestful.Controllers.LoadCapacitorManagement
{
    public class LoadCapacitorController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetLoadCapacitorLoads()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                Request.Headers.TryGetValues("AHId", out IEnumerable<string> AHId);
                Request.Headers.TryGetValues("AHSGId", out IEnumerable<string> AHSGId);
                Request.Headers.TryGetValues("ProvinceId", out IEnumerable<string> ProvinceId);
                Request.Headers.TryGetValues("ListType", out IEnumerable<string> ListType);

                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                Int64 ListTypeConv =Convert.ToInt64(ListType.FirstOrDefault()) == (long)LoadCapacitorLoadsListType.NotSedimented ? Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.AllOfLoadsWithoutSedimentedLoads) : Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.SedimentedLoads);
                var Lst = InstanceLoadCapacitorLoad.GetLoadCapacitorLoads(Convert.ToInt64(AHId.FirstOrDefault()), Convert.ToInt64(AHSGId.FirstOrDefault()), ListTypeConv, false, true, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince, Int64.MinValue, Convert.ToInt64(ProvinceId.FirstOrDefault()));
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanseSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(long.MinValue, R2CoreTransportationAndLoadNotificationLogType.LoadCapacitorAccessStatistics, "آمار بازدید از بار موجود در مخزن بار", AHId.FirstOrDefault(), AHSGId.FirstOrDefault(), String.Empty, String.Empty, String.Empty, InstanseSoftwareUser.GetNSSSystemUser().UserId, DateTime.Now, null));
                List<Models.LoadCapacitorLoad> _Loads = new List<Models.LoadCapacitorLoad>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadCapacitorLoad();
                    Item.LoadnEstelamId = "کد مرجع : " + Lst[Loopx].nEstelamId;
                    Item.LoadCapacitorLoadTitleTargetCityTotalAmount = Lst[Loopx].GoodTitle.Trim() + " - " + Lst[Loopx].LoadTargetTitle.Trim() + "   تعداد : " + Lst[Loopx].nCarNum.ToString().Trim();
                    Item.TransportCompanyTarrifPrice = Lst[Loopx].TransportCompanyTitle.Trim() + " تلفن: " + Lst[Loopx].TransportCompanyTel.Trim() + "\n نرخ پایه : " + R2CoreMClassPublicProcedures.R2MakeCamaYourDigit(Convert.ToUInt64(Lst[Loopx].StrPriceSug));
                    Item.Description = Lst[Loopx].StrDescription.Trim() + " " + Lst[Loopx].StrBarName.Trim() + " " + Lst[Loopx].StrAddress.Trim();
                    _Loads.Add(Item);
                }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_Loads), Encoding.UTF8, "application/json");
                return response;
            }
            catch(UserIdNotExistException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
