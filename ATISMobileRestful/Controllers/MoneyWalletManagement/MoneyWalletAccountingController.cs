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

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletAccountingController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetMoneyWalletAccounting()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAccounting = new R2CoreParkingSystemInstanceAccountingManager();
                var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
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
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage GetMoneyWalletIDandReminderCharge()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
                Int64 ReminderCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = NSSTrafficCard.CardNo, Message2 = ReminderCharge.ToString(), Message3 = string.Empty }), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
