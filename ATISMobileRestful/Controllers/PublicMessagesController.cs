using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ATISMobileRestful.Models;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.ExceptionManagement;
using R2Core.SoftwareUserManagement;
using R2Core.SoftwareUserManagement.Exceptions;

namespace ATISMobileRestful.Controllers
{
    public class PublicMessagesController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();
        [HttpGet]
        public MessageStruct GetPublicMessage(Int64 YourUserId)
        {
            try
            {
                R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId);
                string[] AllConfig = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers).Split(';');
                string Message = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 1);
                string ExpirationDate = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, 0);
                if (R2CoreMclassDateAndTimeManagement.GetPersianDaysDiffDate(_DateTime.GetCurrentDateShamsiFull(), ExpirationDate) >= 0)
                { return new MessageStruct { ErrorCode = false, Message1 = Message, Message2 = string.Empty, Message3 = string.Empty }; }
                else
                { return new MessageStruct { ErrorCode = false, Message1 = string.Empty, Message2 = string.Empty, Message3 = string.Empty }; }
            }
            catch (UserIdNotExistException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
