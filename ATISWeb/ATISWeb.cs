using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using R2Core.BlackIPs;
using R2Core.LoggingManagement;

namespace ATISWeb
{
    namespace PublicProcedures
    {
        public class ATISWebPublicProceduresManager
        {
            public string GetClientIpAddress(System.Web.HttpRequest request)
            { return request.UserHostAddress; }
        }
    }

    namespace LoggingManagement
    {
        public abstract class ATISWebLogTypes : R2CoreLogType
        {
            public static Int64 UnSuccessfulSoftwareUserShenasehPasswordAuthentication = 50;
            public static Int64 SuccessfulSoftwareUserShenasehPasswordAuthentication = 51;

        }

    }

    namespace BlackIPs
    {

    }

}