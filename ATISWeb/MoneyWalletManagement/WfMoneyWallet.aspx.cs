
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using R2Core.MoneyWallet.Exceptions;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;
using R2CoreTransportationAndLoadNotification.TransportCompanies;


namespace ATISWeb.MoneyWalletManagement
{
    public partial class WfMoneyWallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                { WCMoneyWalletCharging.WcRefreshInformation(); }
            }
            catch (SoftwareUserMoneyWalletNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }

        }
    }
}