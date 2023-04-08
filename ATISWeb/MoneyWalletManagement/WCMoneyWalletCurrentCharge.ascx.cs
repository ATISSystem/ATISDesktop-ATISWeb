
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.PublicProc;
using R2CoreParkingSystem.MoneyWalletManagement;


namespace ATISWeb.MoneyWalletManagement
{
    public partial class WCMoneyWalletCurrentCharge : ATISWeb.MoneyWalletManagement.WCMoneyWallet
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"
        protected new void Page_Load(object sender, EventArgs e)
        { this.WCCurrentNSSChangedEvent += WCMoneyWalletCurrentCharge_WCCurrentNSSChangedEvent; }

        private void WCMoneyWalletCurrentCharge_WCCurrentNSSChangedEvent(object sender, EventArgs e)
        {
            try
            {
                var InstanceMoneyWallet = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();
                TxtCurrentCharge.Text = InstancePublicProcedures.ParseSignDigitToSignString(InstanceMoneyWallet.GetMoneyWalletCharge(WCCurrentNSS));
            }
            catch (ArgumentException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (MoneyWalletNotExistException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion

    }
}