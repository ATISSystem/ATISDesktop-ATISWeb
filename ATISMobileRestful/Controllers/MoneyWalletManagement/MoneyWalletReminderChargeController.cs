using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;

using R2Core.LoggingManagement;
using R2Core.PublicProc;
using R2Core.SoftwareUserManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.TrafficCardsManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using ATISMobileRestful.Models;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.PermissionManagement;
using R2CoreParkingSystem.MobileProcessesManagement;

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletReminderChargeController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage GetMoneyWalletReminderCharge()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletIDandReminderChargeRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareuser);
                Int64 ReminderCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = ReminderCharge.ToString(), Message2 = string.Empty, Message3 = string.Empty }), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
