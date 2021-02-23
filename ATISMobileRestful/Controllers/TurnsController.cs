using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.SoftwareUserManagement;

namespace ATISMobileRestful.Controllers
{
    public class TurnsController : ApiController
    {
        [HttpGet]
        public List<Models.Turns> GetTurns(Int64 YourUserId)
        {
            List<Models.Turns> _Turns = new List<Models.Turns>();
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetTurns(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId));
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.Turns();
                    Item.TurnId = Lst[Loopx].nEnterExitId.ToString();
                    var OtaghdarTurnNumber = Lst[Loopx].OtaghdarTurnNumber.Trim().Split(':')[0];
                    var TurnDistanceToValidity = Lst[Loopx].OtaghdarTurnNumber.Trim().Split(':')[1];
                    Item.OtaghdarTurnNumber = "شماره نوبت : " + OtaghdarTurnNumber + " فاصله شما تا اعتبار : " + TurnDistanceToValidity;
                    Item.TurnDateTime = "زمان: " + Lst[Loopx].EnterDate.Trim() + " - " + Lst[Loopx].EnterTime.Trim();
                    Item.TurnStatusTitle = "وضعیت نوبت: " + Lst[Loopx].TurnStatusTitle.Trim();
                    Item.LPPString = "ناوگان: " + Lst[Loopx].LicensePlatePString.Trim();
                    Item.TruckDriver = "راننده: " + Lst[Loopx].TruckDriver.Trim();
                    _Turns.Add(Item);
                }
                return _Turns;
            }
            catch (Exception ex)
            { return _Turns; }
        }

    }
}
