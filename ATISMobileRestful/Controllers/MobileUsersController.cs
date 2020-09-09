using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

using R2CoreTransportationAndLoadNotification.MobileUsers;
using R2CoreTransportationAndLoadNotification.MobileUsers.Exeptions;
using ATISMobileRestful.Models;

namespace ATISMobileRestful.Controllers
{
    public class MobileUsersController : ApiController
    {
        [HttpGet]
        public MessageStruct RegisterMobileUser(String YourMobileNumber, String YourNameFamily)
        {
            try
            {
                string VerificationCode = R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement.RegisterMobileUser(YourMobileNumber, YourNameFamily);
                return new MessageStruct { ErrorCode = false, Message1 = VerificationCode, Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (TruckDriverMobileNumberNotFoundException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public MessageStruct UnRegisterMobileUser(Int64 YourMUId)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement.UnRegisterMobileUser(YourMUId);
                return new MessageStruct { ErrorCode = false, Message1 = string.Empty, Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }


        [HttpGet]
        public MessageStruct ActiveMobileUser(String YourMobileNumber, String YourVerificationCode)
        {
            try
            {
                Int64 MUId = R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement.ActiveMobileUser(YourMobileNumber, YourVerificationCode);
                return new MessageStruct { ErrorCode = false, Message1 = MUId.ToString(), Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (MobileUserNotMatchException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }


    }
}
