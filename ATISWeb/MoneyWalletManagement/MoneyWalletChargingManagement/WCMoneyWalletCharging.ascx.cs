

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using R2Core.ConfigurationManagement;
using R2Core.ExceptionManagement;
using R2Core.MonetaryCreditSupplySources;
using R2Core.MoneyWallet.PaymentRequests;
using R2CoreParkingSystem.MoneyWalletChargeManagement.MoneyWalletChargingAmountsManagement;
using R2CoreParkingSystem.RequesterManagement;
using R2CoreParkingSystem.SoftwareUsersManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;




namespace ATISWeb.MoneyWalletManagement.MoneyWalletChargingManagement
{
    public partial class WCMoneyWalletCharging : WCMoneyWallet
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        public void WcRefreshInformation()
        {
            try
            { WcViewInformation(); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private long WCGetSelected()
        {
            try
            {
                foreach (ListItem Li in RBListMoneyWalletChargingAmounts.Items)
                { if (Li.Selected) { return Convert.ToInt64(Li.Value); } }
                throw new DataEntryException("Any Item Not Selected ...");
            }
            catch (DataEntryException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }

        }

        private void WcViewInformation()
        {
            try
            {
                RBListMoneyWalletChargingAmounts.Items.Clear();
                var InstanceMoneyWalletChargingAmounts = new R2CoreParkingSystemMoneyWalletChargingAmountsManager();
                var Lst = InstanceMoneyWalletChargingAmounts.GetActiveAmounts(R2CoreParkingSystemRequesters.WCMoneyWalletCharging);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    ListItem Li = new ListItem(Lst[Loopx].MWCATitle, Lst[Loopx].MWCAId.ToString());
                    Li.Attributes.Add("class", "btn-check");
                    RBListMoneyWalletChargingAmounts.Items.Add(Li);
                }
            }
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
                if (!IsPostBack) { WcViewInformation(); }
                this.WCCurrentNSSChangedEvent += WCMoneyWalletCharging_WCCurrentNSSChangedEvent;
                BtnChargingg.Click += BtnChargingg_Click;
                var InstanceLogin = new ATISWebMClassLoginManager();
                var NSSSoftwareUser = InstanceLogin.GetNSSCurrentUser();
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                WCCurrentNSS = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
            }
            catch(Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnChargingg_Click(object sender, EventArgs e)
        {
            try
            {

                var WS = new R2Core.R2PrimaryWS.R2PrimaryWebService();
                var InstanceMoneyWalletChargingAmounts = new R2CoreParkingSystemMoneyWalletChargingAmountsManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceLogin = new ATISWebMClassLoginManager();
                var NSSSoftwareUser = InstanceLogin.GetNSSCurrentUser();

                var PayId = WS.WebMethodPaymentRequest(R2CoreMonetaryCreditSupplySources.ZarrinPalPaymentGate, InstanceMoneyWalletChargingAmounts.GetNSSAmount(WCGetSelected()).MWCARial, NSSSoftwareUser.UserId, WS.WebMethodLogin(NSSSoftwareUser.UserShenaseh, NSSSoftwareUser.UserPassword));
                //var PayId = WS.WebMethodPaymentRequest(R2CoreMonetaryCreditSupplySources.ShepaPaymentGate, InstanceMoneyWalletChargingAmounts.GetNSSAmount(WCGetSelected()).MWCARial, NSSSoftwareUser.UserId, WS.WebMethodLogin(NSSSoftwareUser.UserShenaseh, NSSSoftwareUser.UserPassword));
                var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId);
                while ((NSSPaymentRequest.Authority == string.Empty) & (NSSPaymentRequest.PaymentErrors == string.Empty))
                { System.Threading.Thread.Sleep(500); NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(PayId); }
                if (NSSPaymentRequest.Authority != string.Empty)
                {
                    Response.Redirect(InstanceConfiguration.GetConfigString(R2CoreConfigurations.ZarrinPalPaymentGate, 2) + NSSPaymentRequest.Authority);
                    //Response.Redirect(InstanceConfiguration.GetConfigString(R2CoreConfigurations.ShepaPaymentGate, 2) + NSSPaymentRequest.Authority);
                }
                else
                { throw new Exception(NSSPaymentRequest.PaymentErrors); }
            }
            catch(Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void WCMoneyWalletCharging_WCCurrentNSSChangedEvent(object sender, EventArgs e)
        { WCMoneyWalletCurrentCharge.WCCurrentNSS = this.WCCurrentNSS; }

        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion

    }
}