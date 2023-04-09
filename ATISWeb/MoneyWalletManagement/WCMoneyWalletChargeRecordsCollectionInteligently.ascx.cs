
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using R2Core.PublicProc;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;

namespace ATISWeb.MoneyWalletManagement
{
    public partial class WCMoneyWalletChargeRecordsCollectionInteligently : WCMoneyWallet
    {
        #region "General Properties"

        #endregion

        #region "Subroutins And Functions"

        private  void WcViewInformation()
        {
            try
            {
                var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
                var Lst = InstanceMoneyWalletCharge.GetMoneyWalletChargeCollection(WCCurrentNSS, 50);
                while (TblMoneyWalletChargeRecordsCollection.Rows.Count > 1) TblMoneyWalletChargeRecordsCollection.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].UserName; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].Mblgh); tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].TimeCharge; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].DateShamsi ; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    TblMoneyWalletChargeRecordsCollection.Rows.Add(tempRow);
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblMoneyWalletChargeRecordsCollection.Rows.Add(tempFooterRow);
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
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
                BtnRefresh.Click += BtnRefresh_Click;
                this.WCCurrentNSSChangedEvent += WCMoneyWalletChargeRecordsCollectionInteligently_WCCurrentNSSChangedEvent;
                var InstanceLogin = new ATISWebMClassLoginManager();
                var NSSSoftwareUser = InstanceLogin.GetNSSCurrentUser();
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                WCCurrentNSS = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void WCMoneyWalletChargeRecordsCollectionInteligently_WCCurrentNSSChangedEvent(object sender, EventArgs e)
        {
            try
            { WcViewInformation(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try { WcViewInformation(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
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