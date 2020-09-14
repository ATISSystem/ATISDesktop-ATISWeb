using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using R2Core.PublicProc;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

using ATISMobileRestful.Models;

namespace ATISMobileRestful.Controllers
{
    public class LoadCapacitorController : ApiController
    {
        [HttpGet]
        public List<Models.LoadCapacitorLoad> GetLoadCapacitorLoads(Int64 YourAHId, Int64 YourAHSGId, Int64 YourProvinceId = Int64.MinValue)
        {
            List<Models.LoadCapacitorLoad> _Loads = new List<Models.LoadCapacitorLoad>();
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLoadCapacitorLoads(YourAHId, YourAHSGId, Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.AllOfLoadsWithoutSedimentedLoads), false, true, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince, Int64.MinValue, YourProvinceId);
                R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(long.MinValue, R2CoreTransportationAndLoadNotificationLogType.LoadCapacitorAccessStatistics, "آمار بازدید از بار موجود در مخزن بار", YourAHId.ToString(), YourAHSGId.ToString(), String.Empty, String.Empty, String.Empty, R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser().UserId, DateTime.Now, null));
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadCapacitorLoad();
                    Item.LoadnEstelamId = "کد مرجع : " + Lst[Loopx].nEstelamId;
                    Item.LoadCapacitorLoadTitleTargetCityTotalAmount = Lst[Loopx].GoodTitle.Trim() + " - " + Lst[Loopx].LoadTargetTitle.Trim() + "   تعداد : " + Lst[Loopx].nCarNum.ToString().Trim();
                    Item.TransportCompanyTarrifPrice = Lst[Loopx].TransportCompanyTitle.Trim() + " تلفن: " + Lst[Loopx].TransportCompanyTel.Trim() + "\n نرخ پایه : " + R2CoreMClassPublicProcedures.R2MakeCamaYourDigit(Convert.ToUInt64(Lst[Loopx].StrPriceSug));
                    Item.Description = Lst[Loopx].StrDescription.Trim() + " " + Lst[Loopx].StrBarName.Trim() + " " + Lst[Loopx].StrAddress.Trim();
                    _Loads.Add(Item);
                }
                return _Loads;
            }
            catch (Exception ex)
            { return _Loads; }
        }

    }
}
