using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using R2Core.WebProcessesManagement;
using ATISWeb.LoginManagement;

namespace ATISWeb.MenuManagement
{

    public partial class WfMainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    string DailyMessage = string.Empty;
                    string DailyMessageColor = string.Empty;
                    DailyMessage = PayanehClassLibrary.TransportCompanies.TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesDailyMessage(ref DailyMessageColor);
                    string FixMessage = PayanehClassLibrary.TransportCompanies.TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesFirstPageMessages();
                    string FixMessage1 = FixMessage.Split('-')[0].Trim();
                    string FixMessage2 = FixMessage.Split('-')[1].Trim();
                    string FixMessage3 = FixMessage.Split('-')[2].Trim();
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('" + DailyMessageColor + "','" + DailyMessage + "','" + FixMessage1 + "','" + FixMessage2 + "','" + FixMessage3 + "');", true);
                    ViewProcesses();
                }
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private TableCell GetTempCell(R2StandardWebProcessStructure YourNSS)
        {
            TableCell tempCell = new TableCell();
            WcProcess Wc = LoadControl("~/MenuManagement/WcProcess.ascx") as WcProcess;
            Wc.WcCurrentNSS = YourNSS;
            tempCell.Controls.Add(Wc);
            tempCell.HorizontalAlign = HorizontalAlign.Center;
            return tempCell;
        }

        private void ViewProcesses()
        {
            try
            {
                var Lst = R2CoreMClassWebProcessesManagement.GetWebProcesses(ATISWebMClassLoginManagement.GetNSSCurrentUser());
                int X = Lst.Count - 1;
                while (X >=0 )
                {
                    TableRow tempRow = new TableRow();
                    if (X >= 0)
                    { tempRow.Cells.Add(GetTempCell(Lst[X])); }
                    if (X - 1 >= 0)
                    { tempRow.Cells.Add(GetTempCell(Lst[X - 1])); }
                    if (X - 2 >= 0)
                    { tempRow.Cells.Add(GetTempCell(Lst[X - 2])); }
                    if (X - 3 >= 0)
                    { tempRow.Cells.Add(GetTempCell(Lst[X - 3])); }
                    TblProcesses.Rows.Add(tempRow);
                    X = X - 4;
                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblProcesses.Rows.Add(tempFooterRow);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }
    }
}