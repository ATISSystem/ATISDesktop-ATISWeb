

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.DriverSelfDeclaration;
using R2CoreTransportationAndLoadNotification.Trucks;


namespace ATISWeb.TransportationAndLoadNotification.DriverSelfDeclaration
{
    public partial class WCDriverSelfDeclarationViewer : System.Web.UI.UserControl
    {
        #region "General Properties"

        #endregion

        #region "Subroutins And Functions"

        public void WcViewInformation(R2CoreTransportationAndLoadNotificationStandardTruckStructure YourNSS)
        {
            try
            {
                var InstanceDriverSelfDeclaration = new R2CoreTransportationAndLoadNotificationInstanceDriverSelfDeclarationManager();
                var Lst = InstanceDriverSelfDeclaration.GetDeclarations(YourNSS,false );

                while (TblDSDs.Rows.Count > 1) TblDSDs.Rows.RemoveAt(1);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    TableRow tempRow = new TableRow();
                    TableCell tempCell = null;
                    tempCell = new TableCell();
                    tempCell.Text = Lst[Loopx].DSDTitle + " - " + (Lst[Loopx].DSDValue == String.Empty ? "اظهار نشده" : Lst[Loopx].DSDValue); tempCell.CssClass = "R2FontBHomaSmall"; tempRow.Cells.Add(tempCell); tempCell.HorizontalAlign = HorizontalAlign.Center;
                    TblDSDs.Rows.Add(tempRow);

                }
                TableFooterRow tempFooterRow = new TableFooterRow();
                tempFooterRow.BackColor = Color.LightBlue;
                tempFooterRow.BorderColor = Color.LightBlue;
                TblDSDs.Rows.Add(tempFooterRow);
                try
                {
                    var Allowed = InstanceDriverSelfDeclaration.GetAllowedLoadingCapacity(YourNSS) + "  تن ";
                    LblAllowedLoadingCapacity.Text = "ظرفیت مجاز بارگیری : " + Allowed;
                }
                catch (Exception ex)
                { LblAllowedLoadingCapacity.Text = "ظرفیت مجاز بارگیری : نامعلوم"; }
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        public void WcRefreshInformation()
        {
            try
            { TblDSDs.Rows.Clear(); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        #endregion

        #region "Events"

        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            { }
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