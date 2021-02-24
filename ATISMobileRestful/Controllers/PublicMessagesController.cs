using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ATISMobileRestful.Models;
using R2Core.ConfigurationManagement;

namespace ATISMobileRestful.Controllers
{
    public class PublicMessagesController : ApiController
    {
        [HttpGet]
        public MessageStruct GetPublicMessage(Int64 YourMessageIndex)
        {
            try
            {
                string Message = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.PublicMessagesforSoftWareUsers, YourMessageIndex);
                return new MessageStruct { ErrorCode = false, Message1 = Message, Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }


    }
}
