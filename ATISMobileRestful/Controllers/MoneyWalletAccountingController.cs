using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using R2Core.LoggingManagement;
using R2Core.PublicProc;
using R2Core.SoftwareUserManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.TrafficCardsManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using ATISMobileRestful.Models;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;
using R2CoreParkingSystem.MoneyWalletManagement;

namespace ATISMobileRestful.Controllers
{
    public class MoneyWalletAccountingController : ApiController
    {
        [HttpGet]
        public List<Models.MoneyWalletAccounting> GetMoneyWalletAccounting(Int64 YourUserId)
        {
            R2CoreParkingSystemStandardTrafficCardStructure NSSTrafficCard = R2CoreTransportationAndLoadNotification.TerraficCardsManagement.R2CoreTransportationAndLoadNotificationMClassTerraficCardsManagement.GetNSSTerafficCard(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId));
            List<Models.MoneyWalletAccounting> _MoneyWalletAccountings = new List<Models.MoneyWalletAccounting>();
            try
            {
                var Lst = R2CoreParkingSystemMClassAccountingManagement.GetAccountingCollection(NSSTrafficCard, 50);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.MoneyWalletAccounting();
                    Item.AccountName = Lst[Loopx].AccountName;
                    Item.AccountDateTime = Lst[Loopx].DateShamsiA + "\n" + Lst[Loopx].TimeA;
                    Item.CurrentCharge = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].CurrentChargeA);
                    Item.Mblgh = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].MblghA);
                    Item.ReminderCharge = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].ReminderChargeA);
                    Item.ComputerName = Lst[Loopx].ComputerName;
                    Item.UserName = Lst[Loopx].UserName;
                    Item.BackGroundColorName = Lst[Loopx].ColorName;
                    Item.ForeGroundColorName = R2CoreMClassPublicProcedures.IdealBlackWhiteTextColor(Color.FromName(Lst[Loopx].ColorName)).Name;
                    _MoneyWalletAccountings.Add(Item);
                }
                return _MoneyWalletAccountings;
            }
            catch (Exception ex)
            { return _MoneyWalletAccountings; }
        }

        [HttpGet]
        public MessageStruct GetMoneyWalletIDandReminderCharge(Int64 YourUserId)
        {
            try
            {
                R2CoreParkingSystemStandardTrafficCardStructure NSSTrafficCard = R2CoreTransportationAndLoadNotificationMClassTerraficCardsManagement.GetNSSTerafficCard(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId));
                Int64 ReminderCharge = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard);
                return new MessageStruct { ErrorCode = false, Message1 = NSSTrafficCard.CardNo, Message2 = ReminderCharge.ToString(), Message3 = string.Empty };
            }
            catch (Exception ex)
            { throw ex; }
        }

    }
}
