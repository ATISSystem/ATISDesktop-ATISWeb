using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PayanehClassLibrary.CarTrucksManagement;
using PayanehClassLibrary.DriverTrucksManagement;

namespace ATISWeb.TransportationAndLoadNotification.SmartCards
{
    public partial class WcSmartCardsInquiry : System.Web.UI.UserControl
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        public string WcGetTruckSmartCardNo()
        { return TxtTruckSmartCardNo.Text; }

        public string WcGetTruckDriverSmartCardNo()
        { return TxtTruckDriverSmartCardNo.Text; }

        public void WcRefreshInformation()
        {
            TxtTruckDriverSmartCardNo.Text = string.Empty;
            TxtTruckSmartCardNo.Text = string.Empty;
        }

        private void WcViewTruck(R2StandardCarTruckStructure YourNSS)
        { LblTruck.Text = YourNSS.NSSCar.GetCarPelakSerialComposit(); }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BtnTruckSmartCardInquiryfromRMTO.Click += BtnTruckSmartCardInquiryfromRMTO_Click;
                BtnTruckSmartCardInquiryfromLocal.Click += BtnTruckSmartCardInquiryfromLocal_Click;
                BtnTruckDriverSmartCardInquiryfromLocal.Click += BtnTruckDriverSmartCardInquiryfromLocal_Click;
                BtnTruckDriverSmartCardInquiryfromRMTO.Click += BtnTruckDriverSmartCardInquiryfromRMTO_Click;
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverSmartCardInquiryfromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                R2StandardDriverTruckStructure NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetDriverTruckfromRMTOAndInsertUpdateLocalDataBase(TxtTruckDriverSmartCardNo.Text);
                LblTruckDriver.Text = NSS.NSSDriver.StrPersonFullName.Trim();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverSmartCardInquiryfromLocal_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                R2StandardDriverTruckStructure NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(TxtTruckDriverSmartCardNo.Text);
                LblTruckDriver.Text = NSS.NSSDriver.StrPersonFullName.Trim();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiryfromLocal_Click(object sender, EventArgs e)
        {
            try
            {
                R2StandardCarTruckStructure NSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyBodyNo(TxtTruckSmartCardNo.Text);
                WcViewTruck(NSS);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiryfromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                R2StandardCarTruckStructure NSS = PayanehClassLibraryMClassCarTrucksManagement.GetCarTruckfromRMTOAndInsertUpdateLocalDataBase(TxtTruckSmartCardNo.Text);
                WcViewTruck(NSS);
            }
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