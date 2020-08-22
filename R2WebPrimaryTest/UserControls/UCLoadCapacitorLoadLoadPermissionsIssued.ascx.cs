using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using R2CoreTransportationAndLoadNotification.LoadPermission;

namespace R2WebPrimaryTest.UserControls
{
    public partial class UCLoadCapacitorLoadLoadPermissionsIssued : System.Web.UI.UserControl
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        public void UCViewInformation(Int64 YournEstelamId)
        {
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.GetLoadPermissionsIssued(YournEstelamId);
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("StrDescription", typeof(string)));
                dt.Columns.Add(new DataColumn("IssuedLocation", typeof(string)));
                dt.Columns.Add(new DataColumn("strAddress", typeof(string)));
                dt.Columns.Add(new DataColumn("Mobile", typeof(string)));
                dt.Columns.Add(new DataColumn("StrExitDateTime", typeof(string)));
                dt.Columns.Add(new DataColumn("StrSmartcardNo", typeof(string)));
                dt.Columns.Add(new DataColumn("StrNationalCode", typeof(string)));
                dt.Columns.Add(new DataColumn("StrDrivingLicenceNo", typeof(string)));
                dt.Columns.Add(new DataColumn("TruckDriver", typeof(string)));
                dt.Columns.Add(new DataColumn("Truck", typeof(string)));

                //GridView1.AutoGenerateColumns = false;
                for ( int i = 0; i <= Lst.Count-1; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["StrDescription"] = Lst[i].StrDescription.Trim();
                    dr["IssuedLocation"] = Lst[i].IssuedLocation.Trim();
                    dr["strAddress"] = Lst[i].strAddress.Trim();
                    dr["Mobile"] = Lst[i].Mobile.Trim();
                    dr["StrExitDateTime"] = Lst[i].LoadPermissionDate.Trim() + "-" + Lst[i].LoadPermissionTime.Trim();
                    dr["StrSmartcardNo"] = Lst[i].StrSmartcardNo.Trim();
                    dr["StrNationalCode"] = Lst[i].StrNationalCode.Trim();
                    dr["StrDrivingLicenceNo"] = Lst[i].StrDrivingLicenceNo.Trim();
                    dr["TruckDriver"] = Lst[i].TruckDriver.Trim();
                    dr["Truck"] = Lst[i].Truck.Trim();
                    dt.Rows.Add(dr);

                }
                GridViewLoadCapacitorLoadLoadPermissionsIssued.DataSource = dt;
                GridViewLoadCapacitorLoadLoadPermissionsIssued.DataBind();
                GridViewLoadCapacitorLoadLoadPermissionsIssued.Caption = "لیست مجوزهای صادرشده کد مخزن " + YournEstelamId.ToString();
            }
            catch (Exception ex)
            {  Response.Write("<script>alert('" + ex.Message + "')</script>");}
        }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {

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