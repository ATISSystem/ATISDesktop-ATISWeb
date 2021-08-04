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
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(new R2CoreSoftwareUserMobile(MobileNumber));
                var Amount = Convert.ToInt32(Content.Split(';')[2]);
                if (Amount > 100000)
                { throw new ChargingAmountInvalidException(); }

                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();

                string requesturl = "https://api.zarinpal.com/pg/v4/payment/request.json?merchant_id=" +
                    "aed16bb9-485a-416d-9891-d0b8d2bc98cc" + "&amount=" + Amount +
                    "&callback_url=" + "https://ATISMobile.ir:8083/MoneyWalletChargingMVC/PaymentVerification/?YourAPIKey=" + InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + "&YourAmount=" + Amount.ToString() +
                    "&description=" + "درخواست پرداخت-زرین پال-آتیس" +
                    "&metadata[0]=" + String.Empty + "& metadata[1]=" + String.Empty;
                var client = new RestClient(requesturl);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                IRestResponse requestresponse = client.Execute(request);
                Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(requestresponse.Content);
                string errorscode = jo["errors"].ToString();
                Newtonsoft.Json.Linq.JObject jodata = Newtonsoft.Json.Linq.JObject.Parse(requestresponse.Content);
                string dataauth = jodata["data"].ToString();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);

                if (dataauth != "[]")
                {
                    string Authority = jodata["data"]["authority"].ToString();
                    response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = Authority, Message2 = "https://www.zarinpal.com/pg/StartPay/", Message3 = string.Empty }), Encoding.UTF8, "application/json");
                }
                else
                { response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = true, Message1 = "Error : " + errorscode, Message2 = string.Empty, Message3 = string.Empty }), Encoding.UTF8, "application.json"); }
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
