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
using ATISMobileRestful.Logging;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using R2Core.DateAndTimeManagement;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;

namespace ATISMobileRestful.Controllers.LoadCapacitorManagement
{
    public class LoadCapacitorController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage GetLoadCapacitorLoads()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonceWith4Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientLoadsReviewRequest);

                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var AHId = Content.Split(';')[2];
                var AHSGId = Content.Split(';')[3];
                var ProvinceId = Content.Split(';')[4];
                var ListType = Content.Split(';')[5];
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                Int64 ListTypeConv = Convert.ToInt64(ListType) == (long)LoadCapacitorLoadsListType.NotSedimented ? Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.AllOfLoadsWithoutSedimentedLoads) : Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.SedimentedLoads);
                var Lst = InstanceLoadCapacitorLoad.GetLoadCapacitorLoadsfromSubscriptionDB(Convert.ToInt64(AHId), Convert.ToInt64(AHSGId), ListTypeConv, false, true, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince, Int64.MinValue, Convert.ToInt64(ProvinceId));
                List<Models.LoadCapacitorLoad> _Loads = new List<Models.LoadCapacitorLoad>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadCapacitorLoad();
                    Item.LoadnEstelamId = "کد مرجع : " + Lst[Loopx].nEstelamId;
                    Item.LoadCapacitorLoadTitleTargetCityTotalAmount = Lst[Loopx].GoodTitle.Trim() + " - " + Lst[Loopx].LoadTargetTitle.Trim() + " تعداد : " + Lst[Loopx].nCarNum.ToString().Trim()+"  تناژ بار : "+ Lst[Loopx].nTonaj.ToString().Trim();
                    Item.TransportCompanyTarrifPrice = Lst[Loopx].TransportCompanyTitle.Trim() + " تلفن: " + Lst[Loopx].TransportCompanyTel.Trim() + "\n نرخ پایه : " + R2CoreMClassPublicProcedures.R2MakeCamaYourDigit(Convert.ToUInt64(Lst[Loopx].StrPriceSug));
                    Item.Description = Lst[Loopx].StrDescription.Trim() + " " + Lst[Loopx].StrBarName.Trim() + " " + Lst[Loopx].StrAddress.Trim();
                    _Loads.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_Loads), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByMobileNumberException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
