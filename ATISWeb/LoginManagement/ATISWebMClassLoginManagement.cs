using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement.Exceptions;
using R2Core.SoftwareUserManagement;

namespace ATISWeb.LoginManagement
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