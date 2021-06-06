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

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletAccountingController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetMoneyWalletAccounting()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletAccountingRequest);

                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var NSSSoftwareUser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceAccounting = new R2CoreParkingSystemInstanceAccountingManager();
                var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
                List<Models.MoneyWalletAccounting> _MoneyWalletAccountings = new List<Models.MoneyWalletAccounting>();
                var Lst = InstanceAccounting.GetAccountingCollection(NSSTrafficCard, 50);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.MoneyWalletAccounting();
                    Item.AccountName = Lst[Loopx].AccountName;
                    Item.AccountDateTime = Lst[Loopx].DateShamsiA + "\n" + Lst[Loopx].TimeA;
                    Item.CurrentCharge = InstancePublicProcedures.ParseSignDigitToSignString(Lst[Loopx].CurrentChargeA);
                    Item.Mblgh = InstancePublicProcedures.ParseSignDigitToSignString(Lst[Loopx].MblghA);
                    Item.ReminderCharge = InstancePublicProcedures.ParseSignDigitToSignString(Lst[Loopx].ReminderChargeA);
                    Item.ComputerName = Lst[Loopx].ComputerName;
                    Item.UserName = Lst[Loopx].UserName;
                    Item.BackGroundColorName = Lst[Loopx].ColorName;
                    Item.ForeGroundColorName = InstancePublicProcedures.IdealBlackWhiteTextColor(Color.FromName(Lst[Loopx].ColorName)).Name;
                    _MoneyWalletAccountings.Add(Item);
                }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_MoneyWalletAccountings), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetMoneyWalletIDandReminderCharge()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletIDandReminderChargeRequest);

                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var NSSSoftwareUser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
                Int64 ReminderCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = NSSTrafficCard.CardNo, Message2 = ReminderCharge.ToString(), Message3 = string.Empty }), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
