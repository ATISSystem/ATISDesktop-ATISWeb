using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using R2Core.DateAndTimeManagement;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.TrafficCardsManagement;


namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletChargingMVCController : Controller
    {
        private R2DateTime _R2DateTime = new R2DateTime();

        public ActionResult PaymentVerification(Int64 YourUserId, Int64 YourAmount)
        {
            var InstanceTrafficCards = new R2CoreTransportationAndLoadNotification.TerraficCardsManagement.R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
            var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
            var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
            var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
            var InstanceLogging = new R2CoreInstanceLoggingManager();
            try
            {
                if (Request.QueryString["Status"] != "" && Request.QueryString["Status"] != null && Request.QueryString["Authority"] != "" && Request.QueryString["Authority"] != null)
                {
                    if (Request.QueryString["Status"].ToString().Equals("OK"))
                    {
                        long RefID;
                        System.Net.ServicePointManager.Expect100Continue = false;
                        ServiceReference.PaymentGatewayImplementationServicePortTypeClient zp = new ServiceReference.PaymentGatewayImplementationServicePortTypeClient();
                        int Status = zp.PaymentVerification("aed16bb9-485a-416d-9891-d0b8d2bc98cc", Request.QueryString["Authority"].ToString(), (int)YourAmount, out RefID);
                        if (Status == 100)
                        {
                            Int64 Amount = YourAmount * 10;
                           var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(InstanceSoftwareUsers.GetNSSUser(YourUserId));
                            Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                            InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, Amount, R2CoreParkingSystemAccountings.ChargeType, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                            InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime()));
                            InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, R2CoreTransportationAndLoadNotification.Logging.R2CoreTransportationAndLoadNotificationLogType.ATISMobileMoneyWalletsCharging, "شارژ کیف پول از طریق سایت آتیس", NSSTrafficCard.CardNo, YourUserId.ToString(), Amount.ToString(), String.Empty, String.Empty, InstanceSoftwareUsers.GetNSSSystemUser().UserId, _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull()));
                            Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
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