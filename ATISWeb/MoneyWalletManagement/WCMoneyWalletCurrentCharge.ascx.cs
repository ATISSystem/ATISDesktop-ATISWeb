
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ATISWeb.LoginManagement;
using R2Core.MoneyWallet.Exceptions;
using R2Core.PublicProc;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;

namespace ATISWeb.MoneyWalletManagement
{
    public partial class WCMoneyWalletCurrentCharge : ATISWeb.MoneyWalletManagement.WCMoneyWallet
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        public void WCRefreshInformation()
        {
            try { WCViewInformation(); }
            catch (ArgumentException ex)
            { throw ex; }
            catch (MoneyWalletNotExistException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WCViewInformation()
        {
            try
            {
                var InstanceMoneyWallet = new R2CoreParkingSystemInstanceMoneyWalletManager();
                var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();
                TxtCurrentCharge.Text = InstancePublicProcedures.ParseSignDigitToSignString(InstanceMoneyWallet.GetMoneyWalletCharge(WCCurrentNSS));
            }
            catch (ArgumentException ex)
            { throw ex; }
            catch (MoneyWalletNotExistException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"
        protected new void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BtnRenew.ServerClick += BtnRenew_ServerClick;
                this.WCCurrentNSSChangedEvent += WCMoneyWalletCurrentCharge_WCCurrentNSSChangedEvent;
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                var InstanceLogin = new ATISWebMClassLoginManager();
                var NSSSoftwareUser = InstanceLogin.GetNSSCurrentUser();
                WCCurrentNSS = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
            }
            catch (SoftwareUserMoneyWalletNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnRenew_ServerClick(object sender, EventArgs e)
        {
            try { WCViewInformation(); }
            catch (ArgumentException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (MoneyWalletNotExistException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WCMoneyWalletCurrentCharge_WCCurrentNSSChangedEvent(object sender, EventArgs e)
        {
            try { WCViewInformation(); }
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