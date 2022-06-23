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
using R2CoreTransportationAndLoadNotification.Rmto;
using R2Core.ExceptionManagement;
using R2Core.NetworkInternetManagement.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreTransportationAndLoadNotification.TruckDrivers;
using PayanehClassLibrary.DriverTrucksManagement.Exceptions;
using PayanehClassLibrary.PayanehWS;
using PayanehClassLibrary.CarTrucksManagement.Exceptions;

namespace ATISWeb.TransportationAndLoadNotification.SmartCards
{
    public partial class WcSmartCardsInquiry : System.Web.UI.UserControl
    {

        #region "General Properties"

        private R2CoreTransportationAndLoadNotificationStandardTruckStructure _WcNSSTruck = null;
        public R2CoreTransportationAndLoadNotificationStandardTruckStructure WcGetNSSTruck
        { get { if (_WcNSSTruck is null) { throw new DataEntryException(); } else { return _WcNSSTruck; } } }

        private R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure _WcNSSTruckDriver = null;
        public R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure WcGetNSSTruckDriver
        { get { if (_WcNSSTruckDriver is null) { throw new DataEntryException(); } else { return _WcNSSTruckDriver; } } }

        #endregion

        #region "Subroutins And Functions"

        public string WcGetTruckSmartCardNo()
        { return TxtTruckSmartCardNo.Text; }

        public string WcGetTruckDriverNationalCodeNo()
        { return TxtTruckDriverNationalCode.Text; }

        public void WcRefreshInformation()
        {
            TxtTruckDriverNationalCode.Text = string.Empty;
            LblTruckDriver.Text = string.Empty;
            TxtTruckSmartCardNo.Text = string.Empty;
            LblTruck.Text = string.Empty;
            BtnTruckSmartCardInquiryfromRMTO.Enabled = false;
            BtnTruckDriverNationalCodeInquiryfromRMTO.Enabled = false;
        }

        private void FillWcDriverTruckInffromATIS()
        {
            try
            {
                _WcNSSTruckDriver = null;
                if (TxtTruckDriverNationalCode.Text == String.Empty) { return; }
                R2StandardDriverTruckStructure NSS = null;
                var InstacneLogin = new ATISWebMClassLoginManager();
                var InstanceTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyNationalCode(TxtTruckDriverNationalCode.Text);
                _WcNSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(NSS.NSSDriver.nIdPerson));
            }
            catch (Exception ex) when (ex is DriverTruckInformationNotExistException || ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void FillWcDriverTruckInffromRMTO()
        {
            try
            {
                _WcNSSTruckDriver = null;
                if (TxtTruckDriverNationalCode.Text == String.Empty) { return; }
                R2StandardDriverTruckStructure NSS = null;
                var InstacneLogin = new ATISWebMClassLoginManager();
                var InstanceTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                PayanehWebService WS = new PayanehWebService();
                var TruckDriverId = WS.WebMethodGetDriverTruckByNationalCodefromRMTO(TxtTruckDriverNationalCode.Text, WS.WebMethodLogin(InstacneLogin.GetNSSCurrentUser().UserShenaseh, InstacneLogin.GetNSSCurrentUser().UserPassword));
                _WcNSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(TruckDriverId);
                WS = null;
            }
            catch (Exception ex) when (ex is DriverTruckInformationNotExistException || ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void FillWcTruckInffromATIS()
        {
            try
            {
                _WcNSSTruck = null;
                if (TxtTruckSmartCardNo.Text == String.Empty) { return; }
                R2StandardCarTruckStructure NSSCarTruck = null;
                var InstacneLogin = new ATISWebMClassLoginManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var InstanceCarTruck = new PayanehClassLibraryMClassCarTrucksManager();
                NSSCarTruck = InstanceCarTruck.GetNSSCarTruckBySmartCardNo(TxtTruckSmartCardNo.Text);
                _WcNSSTruck = InstanceTrucks.GetNSSTruck(Convert.ToInt64(NSSCarTruck.NSSCar.nIdCar));
            }
            catch (Exception ex) when (ex is TruckInformationNotExistException || ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void FillWcTruckInffromRMTO()
        {
            try
            {
                _WcNSSTruck = null;
                if (TxtTruckSmartCardNo.Text == String.Empty) { return; }
                var InstacneLogin = new ATISWebMClassLoginManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                PayanehWebService WS = new PayanehWebService();
                var TruckId = WS.WebMethodGetnIdCarTruckBySmartCarNo(TxtTruckSmartCardNo.Text, WS.WebMethodLogin(InstacneLogin.GetNSSCurrentUser().UserShenaseh, InstacneLogin.GetNSSCurrentUser().UserPassword));
                _WcNSSTruck = InstanceTrucks.GetNSSTruck(TruckId);
                WS = null;
            }
            catch (Exception ex) when (ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
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
            {
                BtnTruckSmartCardInquiryfromATIS.Click += BtnTruckSmartCardInquiryfromATIS_Click;
                BtnTruckSmartCardInquiryfromRMTO.Click += BtnTruckSmartCardInquiryfromRMTO_Click;
                BtnTruckDriverNationalCodeInquiryfromATIS.Click += BtnTruckDriverNationalCodeInquiryfromATIS_Click;
                BtnTruckDriverNationalCodeInquiryfromRMTO.Click += BtnTruckDriverNationalCodeInquiryfromRMTO_Click;
                if (IsPostBack)
                {
                    FillWcDriverTruckInffromATIS();
                    FillWcTruckInffromATIS();
                }
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverNationalCodeInquiryfromATIS_Click(object sender, EventArgs e)
        {
            try
            {
                BtnTruckDriverNationalCodeInquiryfromRMTO.Enabled = true;
                LblTruckDriver.Text = string.Empty;
                if (TxtTruckDriverNationalCode.Text.Trim() == string.Empty) { return; }
                FillWcDriverTruckInffromATIS();
                LblTruckDriver.Text = _WcNSSTruckDriver.NSSDriver.StrPersonFullName;
            }
            catch (Exception ex) when (ex is DriverTruckInformationNotExistException || ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverNationalCodeInquiryfromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                if (TxtTruckDriverNationalCode.Text.Trim() == string.Empty) { return; }
                FillWcDriverTruckInffromRMTO();
                LblTruckDriver.Text = _WcNSSTruckDriver.NSSDriver.StrPersonFullName;
            }
            catch (Exception ex) when (ex is DriverTruckInformationNotExistException || ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiryfromATIS_Click(object sender, EventArgs e)
        {
            try
            {
                BtnTruckSmartCardInquiryfromRMTO.Enabled = true;
                LblTruck.Text = string.Empty;
                if (TxtTruckSmartCardNo.Text.Trim() == string.Empty) { return; }
                FillWcTruckInffromATIS();
                LblTruck.Text = _WcNSSTruck.NSSCar.GetCarPelakSerialComposit();
            }
            catch (Exception ex) when (ex is TruckInformationNotExistException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiryfromRMTO_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruck.Text = string.Empty;
                if (TxtTruckSmartCardNo.Text.Trim() == string.Empty) { return; }
                FillWcTruckInffromRMTO();
                LblTruck.Text = _WcNSSTruck.NSSCar.GetCarPelakSerialComposit();
            }
            catch (Exception ex) when (ex is TruckInformationNotExistException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
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