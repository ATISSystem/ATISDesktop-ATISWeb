using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.LoadPermission;
using R2CoreTransportationAndLoadNotification.LoadCapacitor;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

namespace ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement
{
    public partial class WcLoadCapacitorLoadLoadPermissionsIssued : System.Web.UI.UserControl
    {
        #region "General Properties"

        private LoadCapacitorLoadsListType _WcCurrentListTypeIssued = LoadCapacitorLoadsListType.None;
        public LoadCapacitorLoadsListType WcCurrentListTypeIssued
        {
            get { return _WcCurrentListTypeIssued; }
            set
            { _WcCurrentListTypeIssued = value; WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcCurrentListType = value; }
        }


        #endregion

        #region "Subroutins And Functions"

        public void WcViewInformation(Int64 YournEstelamId)
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

                for (int i = 0; i <= Lst.Count - 1; i++)
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
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack) { WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcViewInformation(); }
                WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcLoadCapacitorLoadSelectedEvent += WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent;
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent(object sender, LoadCapacitorManagement.WcLoadCapacitorLoadsCollectionSummaryIntelligently.nEstelamIdEventArgs e)
        {
            try
            { WcViewInformation(e.nEstelamId); }
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