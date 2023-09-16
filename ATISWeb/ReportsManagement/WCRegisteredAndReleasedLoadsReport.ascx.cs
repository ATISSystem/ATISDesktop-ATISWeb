
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Globalization;

using ATISWeb.LoginManagement.Exceptions;
using R2Core.DateAndTimeManagement;
using R2Core.DatabaseManagement;
using System.Data.SqlClient;
using System.Data;
using R2Core.PublicProc;
using R2CoreTransportationAndLoadNotification.TransportTarrifsParameters;
using System.Drawing;
using R2Core.SecurityAlgorithmsManagement.Exceptions;

namespace ATISWeb.ReportsManagement
{
    public partial class WCRegisteredAndReleasedLoadsReport : System.Web.UI.UserControl
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        private void WCChangeBtnViewReportVisablity()
        {
            if (BtnViewReport.Enabled)
            { BtnViewReport.Enabled = false; BtnViewReport.BackColor = Color.Gray; }
            else { BtnViewReport.Enabled = true; BtnViewReport.BackColor = Color.Green; }
        }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnViewReport.Click += BtnViewReport_Click;
        }

        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + "123" + "');", true);
                WCChangeBtnViewReportVisablity();
                var InstanceTransportTarrifsParameters = new R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager();
                var Lst = PayanehClassLibrary.ReportsManagement.PayanehClassLibraryMClassReportsManagement.PayanehClassLibraryRegisteredAndReleasedLoads(0, 0, Int64.MinValue, new R2StandardDateAndTimeStructure(DateTime.Now, TxtDateShamsi1.Text, "00:00:00"), new R2StandardDateAndTimeStructure(DateTime.Now, TxtDateShamsi2.Text, "00:00:00"), Int64.MinValue, Int64.MinValue);
                if (Lst.Count == 0)
                { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','گزارید');", true); WCChangeBtnViewReportVisablity(); ; return; }
                while (TblViewReport.Rows.Count > 1) TblViewReport.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].CompositStringLoadPermissionStatus; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].CompositStringTime + " " + Lst[Loopx].CompositStringDate; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].CompositStringDriverName; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].DischargingPlace; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].LoadingPlace; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].TPTParams; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrAddress; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrBarname; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrDescription; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].LoadStatusName; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = (Lst[Loopx].AHSGTitle); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Convert.ToInt64(Lst[Loopx].StrPriceSug)).ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrCityName.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nCarNumKol.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nTonaj.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].StrGoodName; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].dDateElam + " - " + Lst[Loopx].dTimeElam; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].nEstelamid.ToString(); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].CompanyName; tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    TblViewReport.Rows.Add(tempRow);
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblViewReport.Rows.Add(tempFooterRow);
            }
            catch (SqlInjectionException ex)
            {
                WCChangeBtnViewReportVisablity();
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true);
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            {
                WCChangeBtnViewReportVisablity();
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true);
            }
            WCChangeBtnViewReportVisablity();
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