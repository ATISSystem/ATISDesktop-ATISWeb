using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using R2Core.LoggingManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.TrafficCardsManagement;
using R2CoreTransportationAndLoadNotification.MobileUsers;

namespace ATISMobileRestful.Controllers
{
    public class MoneyWalletChargingMVCController : Controller
    {
        R2Core.DateAndTimeManagement.R2DateTime _R2DateTime = new R2Core.DateAndTimeManagement.R2DateTime();

        public ActionResult PaymentVerification(Int64 YourMUId, Int64 YourAmount)
        {
            try
            {
                if (Request.QueryString["Status"] != "" && Request.QueryString["Status"] != null && Request.QueryString["Authority"] != "" && Request.QueryString["Authority"] != null)
                {
                    if (Request.QueryString["Status"].ToString().Equals("OK"))
                    {
                        long RefID;
                        System.Net.ServicePointManager.Expect100Continue = false;
                        zarinpal.ServiceReference.PaymentGatewayImplementationServicePortTypeClient zp = new zarinpal.ServiceReference.PaymentGatewayImplementationServicePortTypeClient();
                        int Status = zp.PaymentVerification("aed16bb9-485a-416d-9891-d0b8d2bc98cc", Request.QueryString["Authority"].ToString(), (int)YourAmount, out RefID);
                        if (Status == 100)
                        {
                            Int64 Amount = YourAmount * 10;
                            R2CoreParkingSystemStandardTrafficCardStructure NSSTrafficCard = R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement.GetNSSTerafficCard(R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement.GetNSSMobileUser(YourMUId));
                            Int64 CurrentCharge = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard);
                            R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, Amount, R2CoreParkingSystemAccountings.ChargeType, R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser());
                            R2CoreParkingSystemMClassMoneyWalletChargeManagement.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, Amount, R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), 0, 0, _R2DateTime.GetCurrentTime()));
                            R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(0, R2CoreTransportationAndLoadNotification.Logging.R2CoreTransportationAndLoadNotificationLogType.ATISMobileMoneyWalletsCharging, "شارژ کیف پول از طریق آتیس موبایل", NSSTrafficCard.CardNo, YourMUId.ToString(), Amount.ToString(), String.Empty, String.Empty, R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser().UserId, _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull()));
                            Int64 LastCharge = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard);
                            ViewBag.IsSuccess = true; ViewBag.RefId = RefID;
                            ViewBag.Message1 = NSSTrafficCard.CardNo + "شاخص کیف پول: ";
                            ViewBag.Message2 = CurrentCharge.ToString() + "موجودی قبلی: ";
                            ViewBag.Message3 = Amount.ToString() + "مبلغ شارژ: ";
                            ViewBag.Message4 = LastCharge.ToString() + "موجودی نهایی: ";
                        }
                        else
                        { ViewBag.IsSuccess = false; ViewBag.Message = Status; }
                    }
                    else
                    { ViewBag.IsSuccess = false; ViewBag.Message = "Error! Authority: " + Request.QueryString["Authority"].ToString() + " Status: " + Request.QueryString["Status"].ToString(); }
                }
                else
                { ViewBag.IsSuccess = false; ViewBag.Message = "Invalid Input"; }
            }
            catch (Exception ex)
            { ViewBag.IsSuccess = false; ViewBag.Message = ex.Message; }
            return View();
        }

    }
}