using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Models;

namespace ATISMobileRestful.Controllers
{
    public class SoftwareUsersController : ApiController
    {
        [HttpGet]
        public MessageStruct RegisterMobileNumber(String YourMobileNumber)
        {
            try
            {
                string VerificationCode = R2CoreMClassSoftwareUsersManagement.RegisteringMobileNumber(YourMobileNumber);
                return new MessageStruct { ErrorCode = false, Message1 = VerificationCode, Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (MobileNumberNotFoundException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public MessageStruct LogoutSoftwareUser(Int64 YourUserId)
        {
            try
            {
                R2CoreMClassSoftwareUsersManagement.LogoutSoftwareUser(YourUserId);
                return new MessageStruct { ErrorCode = false, Message1 = string.Empty, Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public MessageStruct LoginSoftwareUser(String YourMobileNumber, String YourVerificationCode)
        {
            try
            {
                Int64 UserId =R2CoreMClassSoftwareUsersManagement.LoginSoftwareUser(YourMobileNumber, YourVerificationCode);
                return new MessageStruct { ErrorCode = false, Message1 = UserId.ToString(), Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (SoftwareUserNotMatchException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

    }
}
