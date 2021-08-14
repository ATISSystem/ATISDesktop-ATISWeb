using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;

using ATISMobileRestful.Logging;
using R2Core.BlackIPs;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.LoggingManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SoftwareUserManagement;
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.TrafficCardsManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletChargingMVCController : Controller
    {
        private R2DateTime _R2DateTime = new R2DateTime();

        public ActionResult PaymentVerification()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();

            try
            {
                //تایید اعتبار کلاینت
                var IP = Request.UserHostAddress;
                var InstanceBlackIP = new R2CoreInstanceBlackIPsManager();
                InstanceBlackIP.AuthorizationIP(IP);

                var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceLogging = new R2CoreInstanceLoggingManager();

                ViewBag.IsSuccess = true;
                return View();

                //////for test 14000520
                ////InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail , InstanceLogging.GetNSSLogType(R2CoreLogType.Fail ).LogTitle, Request.UserHostAddress, "ApiKey=" + YourApiKey.Split(' ')[0],"Amount="+ YourApiKey.Split(' ')[1], "Authority=" + Request.QueryString["Authority"], string.Empty , InstanceSoftwareUsers.GetNSSSystemUser().UserId, _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull()));

                ////var APIKey = YourApiKey.Split(' ')[0];
                ////Int64 Amount = System.Convert.ToInt64(YourApiKey.Split(' ')[1]);

                //if (Request.QueryString["Status"] != "" && Request.QueryString["Status"] != null && Request.QueryString["Authority"] != "" && Request.QueryString["Authority"] != null)
                //{
                //    if (Request.QueryString["Status"].ToString().Equals("OK"))
                //    {
                //        var RefId = string.Empty;
                //        var ErrorCode = string.Empty;
                //        var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
                //        WS.WebMethodVerificationRequest(Request.QueryString["Authority"].ToString(), Amount, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword), ref RefId, ref ErrorCode);
                //        if (ErrorCode == string.Empty)
                //        {
                //            var InstanceAES = new AESAlgorithmsManager();
                //            var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                //            var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(InstanceAES.Decrypt(APIKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)));
                //            var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);
                //            Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                //            InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, Amount, R2CoreParkingSystemAccountings.ChargeType, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                //            InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime()));
                //            InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest, InstanceLogging.GetNSSLogType(ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentSucceededRequest).LogTitle, Request.UserHostAddress, "UserId=" + NSSSoftwareUser.UserId.ToString(), "Amount=" + Amount.ToString(), "Authority=" + Request.QueryString["Authority"], "RefID=" + RefId, InstanceSoftwareUsers.GetNSSSystemUser().UserId, _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull()));
                //            Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                //            ViewBag.IsSuccess = true; ViewBag.RefId = RefId ;
                //            ViewBag.Message1 = NSSTrafficCard.CardNo + "  شاخص کیف پول ";
                //            ViewBag.Message2 = CurrentCharge.ToString() + "  موجودی قبلی ";
                //            ViewBag.Message3 = Amount.ToString() + "  مبلغ شارژ ";
                //            ViewBag.Message4 = LastCharge.ToString() + "  موجودی نهایی ";
                //        }
                //        else
                //        { ViewBag.IsSuccess = false; ViewBag.Message = ErrorCode; }
                //    }
                //    else
                //    { ViewBag.IsSuccess = false; ViewBag.Message = "Error! : Status: " + Request.QueryString["Status"].ToString(); }
                //}
                //else
                //{ ViewBag.IsSuccess = false; ViewBag.Message = "Invalid Input"; }
            }
            catch (Exception ex)
            { ViewBag.IsSuccess = false; ViewBag.Message = ex.Message; }
            return View();
        }

    }
}