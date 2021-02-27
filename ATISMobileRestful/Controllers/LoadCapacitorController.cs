using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

using R2Core.PublicProc;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

using ATISMobileRestful.Models;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISMobileRestful.Controllers
{
    public class LoadCapacitorController : ApiController
    {
        [HttpGet]
        public List<Models.LoadCapacitorLoad> GetLoadCapacitorLoads(Int64 YourUserId, Int64 YourAHId, Int64 YourAHSGId, Int64 YourProvinceId = Int64.MinValue, LoadCapacitorLoadsListType YourLoadCapacitorLoadsListType = LoadCapacitorLoadsListType.NotSedimented)
        {
            List<Models.LoadCapacitorLoad> _Loads = new List<Models.LoadCapacitorLoad>();
            try
            {
                R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId);
                List<R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure> Lst = null;
                Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLoadCapacitorLoads(YourAHId, YourAHSGId, YourLoadCapacitorLoadsListType is LoadCapacitorLoadsListType.NotSedimented ? Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.AllOfLoadsWithoutSedimentedLoads) : Convert.ToInt64(AnnouncementHallAnnounceTimeTypes.SedimentedLoads), false, true, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince, Int64.MinValue, YourProvinceId);
                R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(long.MinValue, R2CoreTransportationAndLoadNotificationLogType.LoadCapacitorAccessStatistics, "آمار بازدید از بار موجود در مخزن بار", YourAHId.ToString(), YourAHSGId.ToString(), String.Empty, String.Empty, String.Empty, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId, DateTime.Now, null));
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
            catch (UserIdNotExistException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

    }
}
