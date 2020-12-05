using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using PayanehClassLibrary.CarTrucksManagement;
using PayanehClassLibrary.DriverTrucksManagement;
using PayanehClassLibrary.Rmto;
using R2Core.ExceptionManagement;

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


        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BtnTruckSmartCardInquiry.Click += BtnTruckSmartCardInquiry_Click;
                BtnTruckDriverSmartCardInquiry.Click += BtnTruckDriverSmartCardInquiry_Click;
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverSmartCardInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                R2StandardDriverTruckStructure NSS = null;
                try { NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(TxtTruckDriverSmartCardNo.Text); }
                catch (GetNSSException ex)
                { NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetDriverTruckfromRMTOAndInsertUpdateLocalDataBase(TxtTruckDriverSmartCardNo.Text); }
                LblTruckDriver.Text = NSS.NSSDriver.StrPersonFullName.Trim();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruck.Text = string.Empty;
                R2StandardCarTruckStructure NSS = null;
                NSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(TxtTruckSmartCardNo.Text, ATISWebMClassLoginManagement.GetNSSCurrentUser());
                LblTruck.Text = NSS.NSSCar.GetCarPelakSerialComposit();
            }
            catch (RMTOWebServiceSException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (GetNSSException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
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