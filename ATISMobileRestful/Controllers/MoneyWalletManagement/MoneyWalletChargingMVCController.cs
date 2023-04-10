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
                    { MonetarySupplySource = R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate; Authority = Request.QueryString["token"]; }
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
                        if (NSSSoftwareUser.UserTypeId == R2CoreParkingSystemSoftwareUserTypes.Driver)
                        { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
                        else if(NSSSoftwareUser.UserTypeId == R2CoreTransportationAndLoadNotificationSoftwareUserTypes.TransportCompany )
                        { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSVirtualChargingSoftwareUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
                        else
                        { throw new WebApiClientPaymentVerificationException("PaymentVerificationLocation3"); }
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


        //public ActionResult PaymentVerification()
        //{
        //    /*درگاه پرداخت زرین پال*/
        //    ATISMobileWebApi WebAPi = new ATISMobileWebApi();

        //    try
        //    {
        //        //تایید اعتبار کلاینت
        //        WebAPi.AuthenticateClientPaymentVerification(Request, Request.QueryString["Authority"]);

        //        var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
        //        var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
        //        var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
        //        var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();

        //        ViewBag.Title = "سامانه آتیس";
        //        if (Request.QueryString["Status"] != "" && Request.QueryString["Status"] != null && Request.QueryString["Authority"] != "" && Request.QueryString["Authority"] != null)
        //        {
        //            if (Request.QueryString["Status"].ToString().Equals("OK"))
        //            {
        //                var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
        //                var PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate, Request.QueryString["Authority"].ToString(), WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword));
        //                var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
        //                var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
        //                while ((NSSPaymentRequest.RefId == string.Empty) & (NSSPaymentRequest.VerificationErrors == string.Empty))
        //                { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
        //                if (NSSPaymentRequest.RefId != string.Empty)
        //                {
        //                    var InstanceAES = new AESAlgorithmsManager();
        //                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
        //                    var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(NSSPaymentRequest.SoftwareUserId);
        //                    var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);
        //                    Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
        //                    InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, NSSPaymentRequest.Amount, R2CoreParkingSystemAccountings.ChargeType, NSSSoftwareUser);
        //                    if (NSSSoftwareUser.UserTypeId == R2CoreParkingSystemSoftwareUserTypes.Driver)
        //                    { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
        //                    else
        //                    { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSVirtualChargingSoftwareUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
        //                    Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
        //                    ViewBag.IsSuccess = true; ViewBag.RefId = NSSPaymentRequest.RefId;
        //                    ViewBag.Message1 = NSSTrafficCard.CardNo + "  شاخص کیف پول ";
        //                    ViewBag.Message2 = CurrentCharge.ToString() + "  موجودی قبلی ";
        //                    ViewBag.Message3 = NSSPaymentRequest.Amount.ToString() + "  مبلغ شارژ ";
        //                    ViewBag.Message4 = LastCharge.ToString() + "  موجودی نهایی ";
        //                }
        //                else
        //                { ViewBag.IsSuccess = false; ViewBag.Message = NSSPaymentRequest.VerificationErrors; }
        //            }
        //            else
        //            { ViewBag.IsSuccess = false; ViewBag.Message = "Error! : Status: " + Request.QueryString["Status"].ToString(); }
        //        }
        //        else
        //        { ViewBag.IsSuccess = false; ViewBag.Message = "Invalid Input"; }
        //    }
        //    catch (Exception ex)
        //    { ViewBag.IsSuccess = false; ViewBag.Message = ex.Message; }
        //    return View();
        //}

        //public ActionResult PaymentVerification()
        //{
        //    //درگاه پرداخت شپا
        //    ATISMobileWebApi WebAPi = new ATISMobileWebApi();
        //    try
        //    {
        //        //تایید اعتبار کلاینت
        //        WebAPi.AuthenticateClientPaymentVerification(Request, Request.QueryString["token"]);

        //        var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
        //        var InstanceMoneyWallets = new R2CoreParkingSystemInstanceMoneyWalletManager();
        //        var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
        //        var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();

        //        if (Request.QueryString["token"] != "" && Request.QueryString["token"] != null)
        //        {
        //            var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
        //            var PayId = WS.WebMethodVerificationRequest(R2CoreMonetaryCreditSupplySources.ShepaPaymentGate, Request.QueryString["token"].ToString(), WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword));
        //            var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
        //            var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
        //            while ((NSSPaymentRequest.RefId == string.Empty) & (NSSPaymentRequest.VerificationErrors == string.Empty))
        //            { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
        //            if (NSSPaymentRequest.RefId != string.Empty)
        //            {
        //                var InstanceAES = new AESAlgorithmsManager();
        //                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
        //                var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(NSSPaymentRequest.SoftwareUserId);
        //                var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);
        //                Int64 CurrentCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
        //                InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.AddMoney, NSSPaymentRequest.Amount, R2CoreParkingSystemAccountings.ChargeType, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
        //                if (NSSSoftwareUser.UserTypeId == R2CoreParkingSystemSoftwareUserTypes.Driver)
        //                { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSSystemUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
        //                else
        //                { InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, InstanceSoftwareUsers.GetNSSVirtualChargingSoftwareUser().UserId, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + CurrentCharge, 0, _R2DateTime.GetCurrentTime())); }
        //                Int64 LastCharge = InstanceMoneyWallets.GetMoneyWalletCharge(NSSTrafficCard);
        //                ViewBag.IsSuccess = true; ViewBag.RefId = NSSPaymentRequest.RefId;
        //                ViewBag.Message1 = NSSTrafficCard.CardNo + "  شاخص کیف پول ";
        //                ViewBag.Message2 = CurrentCharge.ToString() + "  موجودی قبلی ";
        //                ViewBag.Message3 = NSSPaymentRequest.Amount.ToString() + "  مبلغ شارژ ";
        //                ViewBag.Message4 = LastCharge.ToString() + "  موجودی نهایی ";
        //            }
        //            else
        //            { ViewBag.IsSuccess = false; ViewBag.Message = NSSPaymentRequest.VerificationErrors; }
        //        }
        //        else
        //        { ViewBag.IsSuccess = false; ViewBag.Message = "Invalid Input"; }
        //    }
        //    catch (Exception ex)
        //    { ViewBag.IsSuccess = false; ViewBag.Message = ex.Message; }
        //    return View();
        //}


    }
}