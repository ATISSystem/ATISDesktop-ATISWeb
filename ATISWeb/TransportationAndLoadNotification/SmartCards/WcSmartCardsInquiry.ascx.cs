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

namespace ATISWeb.TransportationAndLoadNotification.SmartCards
{
    public partial class WcSmartCardsInquiry : System.Web.UI.UserControl
    {

        #region "General Properties"
        private PayanehClassLibrary.PayanehWS.PayanehWebService WS = new PayanehClassLibrary.PayanehWS.PayanehWebService();

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
        }

        private void FillWcDriverTruckInf()
        {
            try
            {
                R2StandardDriverTruckStructure NSS = null;
                var InstanceTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                try
                {
                    NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyNationalCode(TxtTruckDriverNationalCode.Text);
                    _WcNSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(NSS.NSSDriver.nIdPerson));
                }
                catch (DriverTruckInformationNotExistException ex)
                {
                    var TruckDriverId = WS.WebMethodGetDriverTruckByNationalCodefromRMTO(TxtTruckDriverNationalCode.Text, WS.WebMethodLogin(ATISWebMClassLoginManagement.GetNSSCurrentUser().UserShenaseh, ATISWebMClassLoginManagement.GetNSSCurrentUser().UserPassword));
                    _WcNSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(TruckDriverId);
                }


            }
            catch (Exception ex) when (ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void FillWcTruckInf()
        {
            try
            {
                var CarId = WS.WebMethodGetnIdCarTruckBySmartCarNo(TxtTruckSmartCardNo.Text, WS.WebMethodLogin(ATISWebMClassLoginManagement.GetNSSCurrentUser().UserShenaseh, ATISWebMClassLoginManagement.GetNSSCurrentUser().UserPassword));
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                _WcNSSTruck = InstanceTrucks.GetNSSTruck(CarId);
            }
            catch (Exception ex) when (ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
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
                BtnTruckSmartCardInquiry.Click += BtnTruckSmartCardInquiry_Click;
                BtnTruckDriverNationalCodeInquiry.Click += BtnTruckDriverNationalCodeInquiry_Click;
                if (IsPostBack)
                {
                    FillWcDriverTruckInf();
                    FillWcTruckInf();
                }
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckDriverNationalCodeInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruckDriver.Text = string.Empty;
                if (TxtTruckDriverNationalCode.Text == string.Empty) { return; }
                FillWcDriverTruckInf();
                LblTruckDriver.Text = _WcNSSTruckDriver.NSSDriver.StrPersonFullName;
            }
            catch (Exception ex) when (ex is SqlInjectionException || ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnTruckSmartCardInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                LblTruck.Text = string.Empty;
                if (TxtTruckSmartCardNo.Text == string.Empty) { return; }
                FillWcTruckInf();
                LblTruck.Text = _WcNSSTruck.NSSCar.GetCarPelakSerialComposit();
            }
            catch (Exception ex) when (ex is RMTOWebServiceSmartCardInvalidException || ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException)
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