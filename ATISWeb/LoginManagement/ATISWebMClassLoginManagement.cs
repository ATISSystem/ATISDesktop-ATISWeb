using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using R2Core.UserManagement;

namespace ATISWeb.LoginManagement
{
    public class ATISWebMClassLoginManagement
    {
        public static R2CoreStandardUserStructure GetNSSCurrentUser()
        {
            try
            {
                if (HttpContext.Current.Session["CurrentUser"] != null)
                { return (R2CoreStandardUserStructure)HttpContext.Current.Session["CurrentUser"]; }
                throw new Exception("مجددا به سیستم وارد شوید");
            }
            catch (Exception ex)
            {throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }
    }
}