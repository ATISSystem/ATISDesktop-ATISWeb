using ATISMobileRestful.Models;
using R2Core.PermissionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ATISMobileRestful.Controllers
{
    public class PermissionsController : ApiController
    {
        [HttpGet]
        public MessageStruct ExistPermission(Int64 YourPermissionTypeId, Int64 YourEntityIdFirst, Int64 YourEntityIdSecond)
        {
            try
            {
                
                bool P = R2CoreMClassPermissionsManagement.ExistPermission(YourPermissionTypeId, YourEntityIdFirst, YourEntityIdSecond);
                return new MessageStruct { ErrorCode = false, Message1 = P.ToString(), Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

    }
}
