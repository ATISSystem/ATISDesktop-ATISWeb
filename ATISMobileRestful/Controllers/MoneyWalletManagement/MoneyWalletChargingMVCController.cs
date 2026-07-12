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
using R2Core.MonetaryCreditSupplySources;
using R2Core.MoneyWallet.PaymentRequests;
using R2CoreParkingSystem.SoftwareUsersManagement;
using ATISMobileRestful.Exceptions;
using R2CoreTransportationAndLoadNotification.SoftwareUserManagement;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Policy;

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletChargingMVCController : Controller
    {
        private R2DateTime _R2DateTime = new R2DateTime();

        //این متد مخصوص آقای پرداخت است
        public async Task OnGetCallbackasync(string transid, string cardnumber, string tracking_number, string invoice_id, string bank, string status)
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();

            try
            {
                if ((status == "0") || (status == "2")) { return; }
                Int64 MonetarySupplySource = R2CoreMonetaryCreditSupplySources.AqayepardakhtPaymentGate;
                string Authority = transid;

                //تایید اعتبار کلاینت
                //WebAPi.AuthenticateClientPaymentVerification(Request, Authority);
                var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();

                ViewBag.Title = "سامانه آتیس";
                if (Authority != "" && Authority != null)
                {
                    var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
                    long PayId = long.MinValue;
                    PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.AqayepardakhtPaymentGate, Authority, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword));

                    var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                    var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
                    if (NSSPaymentRequest.VerificationErrors == "2") { throw new Exception("Duplicate Verify ..."); }

                    while ((NSSPaymentRequest.RefId == string.Empty) & (NSSPaymentRequest.VerificationErrors == string.Empty))
                    { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
                    if (NSSPaymentRequest.RefId != string.Empty)
                    {
                        var InstanceAES = new AESAlgorithmsManager();
                        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                        var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(NSSPaymentRequest.SoftwareUserId);
                        var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);
                        if (InstanceMoneyWalletCharge.ExistLastChargeMatchWith(Convert.ToInt64(NSSTrafficCard.CardId), NSSPaymentRequest.Amount))
                        { throw new Exception("Duplicate Charge ..."); }

                        Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                        InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, NSSPaymentRequest.Amount, R2CoreParkingSystemAccountings.ChargeType, NSSSoftwareUser);


                        //if ((NSSPaymentRequest.Amount == 200000) || (NSSPaymentRequest.Amount == 300000))
                        //{ InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSelfGoverningChargingSoftwareUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
                        //else
                        InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime()));

                        Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                        ViewBag.IsSuccess = true; ViewBag.RefId = NSSPaymentRequest.RefId;
                        ViewBag.Message1 = NSSTrafficCard.CardNo + "  شاخص کیف پول ";
                        ViewBag.Message2 = CurrentCharge.ToString() + "  موجودی قبلی ";
                        ViewBag.Message3 = NSSPaymentRequest.Amount.ToString() + "  مبلغ شارژ ";
                        ViewBag.Message4 = LastCharge.ToString() + "  موجودی نهایی ";
                    }
                    else
                    { ViewBag.IsSuccess = false; ViewBag.Message = NSSPaymentRequest.VerificationErrors; }
                }
                else
                { ViewBag.IsSuccess = false; ViewBag.Message = "Invalid Input"; }
            }
            catch (Exception ex)
            { ViewBag.IsSuccess = false; ViewBag.Message = ex.Message; }
            return;
        }


        public ActionResult PaymentVerification()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();

            try
            {
                //تشخیص درگاه پرداخت و منبع تامین اعتبار
                Int64 MonetarySupplySource = R2CoreMonetaryCreditSupplySources.None;
                string Authority = string.Empty;
                try
                {//زرین پال
                    if (Request.QueryString["Authority"] != "" && Request.QueryString["Authority"] != null)
                    { MonetarySupplySource = R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate; Authority = Request.QueryString["Authority"]; }
                }
                catch (Exception ex) { }
                try
                {//شپا
                    if (Request.QueryString["token"] != "" && Request.QueryString["token"] != null)
                    { MonetarySupplySource = R2CoreMonetaryCreditSupplySources.ShepaPaymentGate; Authority = Request.QueryString["token"]; }
                }
                catch (Exception ex) { }

                if (MonetarySupplySource == R2CoreMonetaryCreditSupplySources.None)
                { throw new WebApiClientPaymentVerificationException("PaymentVerificationLocation1"); }

                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientPaymentVerification(Request, Authority);
                var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();

                ViewBag.Title = "سامانه آتیس";
                if (Authority != "" && Authority != null)
                {
                    var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
                    long PayId = long.MinValue;
                    if (MonetarySupplySource == R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate)
                    { PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate, Authority, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword)); }
                    else if (MonetarySupplySource == R2CoreMonetaryCreditSupplySources.ShepaPaymentGate)
                    { PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.ShepaPaymentGate, Authority, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword)); }
                    else if (MonetarySupplySource == R2CoreMonetaryCreditSupplySources.AqayepardakhtPaymentGate)
                    { PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.AqayepardakhtPaymentGate, Authority, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword)); }
                    else { throw new WebApiClientPaymentVerificationException("PaymentVerificationLocation2"); }

                    var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                    var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
                    while ((NSSPaymentRequest.RefId == string.Empty) & (NSSPaymentRequest.VerificationErrors == string.Empty))
                    { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
                    if (NSSPaymentRequest.RefId != string.Empty)
                    {
                        var InstanceAES = new AESAlgorithmsManager();
                        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                        var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(NSSPaymentRequest.SoftwareUserId);
                        var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);
                        Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                        InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, NSSPaymentRequest.Amount, R2CoreParkingSystemAccountings.ChargeType, NSSSoftwareUser);

                        InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime()));
                        //if (NSSPaymentRequest.Amount != 600000)
                        //{ InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
                        //else
                        //{ InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSelfGoverningChargingSoftwareUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }

                        Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
                        ViewBag.IsSuccess = true; ViewBag.RefId = NSSPaymentRequest.RefId;
                        ViewBag.Message1 = NSSTrafficCard.CardNo + "  شاخص کیف پول ";
                        ViewBag.Message2 = CurrentCharge.ToString() + "  موجودی قبلی ";
                        ViewBag.Message3 = NSSPaymentRequest.Amount.ToString() + "  مبلغ شارژ ";
                        ViewBag.Message4 = LastCharge.ToString() + "  موجودی نهایی ";
                    }
                    else
                    { ViewBag.IsSuccess = false; ViewBag.Message = NSSPaymentRequest.VerificationErrors; }
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