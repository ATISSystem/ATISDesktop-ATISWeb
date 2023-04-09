
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
using R2CoreParkingSystem.AccountingManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;

namespace ATISWeb.MoneyWalletManagement
{
    public partial class WCMoneyWalletAccouning : WCMoneyWallet 
    {
        #region "General Properties"

        #endregion

        #region "Subroutins And Functions"

        private void WcViewInformation()
        {
            try
            {
                var InstanceAccounting = new R2CoreParkingSystemInstanceAccountingManager();
                var Lst = InstanceAccounting.GetAccountingCollection(WCCurrentNSS, 50);
                while (TblMoneyWalletAccounting.Rows.Count > 1) TblMoneyWalletAccounting.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].UserName; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].ComputerName ; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].ReminderChargeA); tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].MblghA); tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Lst[Loopx].CurrentChargeA); tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].TimeA ; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].DateShamsiA; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].AccountName; tempCell.CssClass = "R2FontBHomaMedium"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    TblMoneyWalletAccounting.Rows.Add(tempRow);
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblMoneyWalletAccounting.Rows.Add(tempFooterRow);
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
                this.WCCurrentNSSChangedEvent += WCMoneyWalletAccouning_WCCurrentNSSChangedEvent;
                var InstanceLogin = new ATISWebMClassLoginManager();
                var NSSSoftwareUser = InstanceLogin.GetNSSCurrentUser();
                var InstanceTerraficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                WCCurrentNSS = InstanceTerraficCards.GetNSSTerafficCard(NSSSoftwareUser);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void WCMoneyWalletAccouning_WCCurrentNSSChangedEvent(object sender, EventArgs e)
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