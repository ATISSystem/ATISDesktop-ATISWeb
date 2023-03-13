using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

using ATISMobileRestful.Exceptions;
using ATISMobileRestful.Models;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using R2Core.LoggingManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using ATISMobileRestful.Logging;
using R2Core.DateAndTimeManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement.Exceptions;
using R2Core.MoneyWallet.MoneyWalletCharging;
using R2Core.MonetaryCreditSupplySources;
using R2Core.MoneyWallet.PaymentRequests;

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletChargingAPIController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage PaymentRequest()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientMoneyWalletPaymentRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var Amount = Convert.ToInt32(Content.Split(';')[2]) * 10;
                if (Amount > 1000000)
                { throw new ChargingAmountInvalidException(); }

                var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
                var PayId = WS.WebMethodPaymentRequest(R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate, Amount, NSSSoftwareuser.UserId, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword));
                //var PayId = WS.WebMethodPaymentRequest(R2CoreMonetaryCreditSupplySources.ShepaPaymentGate, Amount, NSSSoftwareuser.UserId, WS.WebMethodLogin(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserShenaseh, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserPassword)); var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
                while ((NSSPaymentRequest.Authority == string.Empty) & (NSSPaymentRequest.PaymentErrors == string.Empty))
                { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
                if (NSSPaymentRequest.Authority != string.Empty)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = NSSPaymentRequest.Authority, Message2 = InstanceConfiguration.GetConfigString(R2CoreConfigurations.ZarrinPalPaymentGate, 2), Message3 = string.Empty }), Encoding.UTF8, "application/json");
                    //response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = NSSPaymentRequest.Authority, Message2 = InstanceConfiguration.GetConfigString(R2CoreConfigurations.ShepaPaymentGate , 2), Message3 = string.Empty }), Encoding.UTF8, "application/json");
                    return response;
                }
                else
                { throw new Exception(NSSPaymentRequest.PaymentErrors); }
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
