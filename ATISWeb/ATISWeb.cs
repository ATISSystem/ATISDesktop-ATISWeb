using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

using ATISWeb.LoginManagement.Exceptions;
using R2Core.BlackIPs;
using R2Core.LoggingManagement;
using R2Core.SoftwareUserManagement;

namespace ATISWeb
{
    namespace LoginManagement
    {
        public class ATISWebMClassLoginManager
        {
            public R2CoreStandardSoftwareUserStructure GetNSSCurrentUser()
            {
                try
                {
                    if (HttpContext.Current.Session["CurrentUser"] != null)
                    { return (R2CoreStandardSoftwareUserStructure)HttpContext.Current.Session["CurrentUser"]; }
                    throw new PleaseReloginException();
                }
                catch (PleaseReloginException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }
        }

        namespace Exceptions
        {
            public class PleaseReloginException : ApplicationException
            {
                public override string Message
                { get { return "مدت زمان مجاز استفاده از سیستم به پایان رسید.لطفا مجددا وارد سیستم شوید"; } }
            }
        }

    }

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