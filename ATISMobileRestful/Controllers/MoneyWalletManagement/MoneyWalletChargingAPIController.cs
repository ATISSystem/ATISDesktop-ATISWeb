using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;

using ATISMobileRestful.Exceptions;
using ATISMobileRestful.Models;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISMobileRestful.Controllers.MoneyWalletManagement
{
    public class MoneyWalletChargingAPIController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PaymentRequest()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                Request.Headers.TryGetValues("Amount", out IEnumerable<string> Amount);
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                System.Net.ServicePointManager.Expect100Continue = false;
                ServiceReference.PaymentGatewayImplementationServicePortTypeClient zp = new ServiceReference.PaymentGatewayImplementationServicePortTypeClient();
                string Authority;
                int Status = zp.PaymentRequest("aed16bb9-485a-416d-9891-d0b8d2bc98cc", Convert.ToInt32(Amount.FirstOrDefault()), "درخواست پرداخت-زرین پال-آتیس", String.Empty, String.Empty, "http://ATISMobile.ir:38468/MoneyWalletChargingMVC/PaymentVerification/?YourUserId=" + InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()).UserId.ToString()  + "&YourAmount=" + Amount.FirstOrDefault(), out Authority);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                if (Status == 100)
                { response.Content=new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = Authority, Message2 = "https://www.zarinpal.com/pg/StartPay/", Message3 = string.Empty }),Encoding.UTF8,"application/json"); }
                else
                { response.Content=new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = true, Message1 = "Error : " + Status.ToString(), Message2 = string.Empty, Message3 = string.Empty }),Encoding.UTF8,"application.json"); }
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
