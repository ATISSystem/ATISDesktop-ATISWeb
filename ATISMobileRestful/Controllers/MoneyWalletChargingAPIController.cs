using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ATISMobileRestful.Models;

namespace ATISMobileRestful.Controllers
{
    public class MoneyWalletChargingAPIController : ApiController
    {
        [HttpGet]
        public MessageStruct PaymentRequest(Int64 YourUserId, Int64 YourAmount)
        {
            try
            {
                System.Net.ServicePointManager.Expect100Continue = false;
                ServiceReference.PaymentGatewayImplementationServicePortTypeClient zp = new ServiceReference.PaymentGatewayImplementationServicePortTypeClient();
                string Authority;

                int Status = zp.PaymentRequest("aed16bb9-485a-416d-9891-d0b8d2bc98cc", (int)YourAmount, "درخواست پرداخت-زرین پال-آتیس", String.Empty, String.Empty, "http://ATISMobile.ir:3001/MoneyWalletChargingMVC/PaymentVerification/?YourUserId=" + YourUserId.ToString() + "&YourAmount=" + ((int)YourAmount).ToString(), out Authority);

                if (Status == 100)
                { return new MessageStruct { ErrorCode = false, Message1 = Authority, Message2 = "https://www.zarinpal.com/pg/StartPay/", Message3 = string.Empty }; }
                else
                { return new MessageStruct { ErrorCode = true, Message1 = "Error : " + Status.ToString(), Message2 = string.Empty, Message3 = string.Empty }; }
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

    }
}
