using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Text;
using Newtonsoft.Json;

using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.SoftwareUserManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;

namespace ATISMobileRestful.Controllers.TurnManagement
{
    public class TurnsController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetTurns()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientTurnsRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                var Lst = InstanceTurns.GetTurns(NSSSoftwareuser);
                List<Models.Turns> _Turns = new List<Models.Turns>();
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

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_Turns), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
