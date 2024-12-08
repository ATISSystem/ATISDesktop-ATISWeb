using System;
using System.Reflection;
using System.Web.UI;
using System.Globalization;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using R2Core.DateAndTimeManagement;
using R2Core.PublicProc;
using R2Core.ExceptionManagement;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.Goods;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation;
using R2CoreTransportationAndLoadNotification.LoaderTypes;
using R2CoreTransportationAndLoadNotification.LoadTargets;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using R2CoreTransportationAndLoadNotification.TransportCompanies.Exceptions;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.PermissionManagement;
using R2Core.PermissionManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.TransportTarrifsParameters.Exceptions;
using R2CoreTransportationAndLoadNotification.TransportTarrifsParameters;
using R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces;
using R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces.Exceptions;
using R2CoreParkingSystem.City.Execption;
using R2CoreTransportationAndLoadNotification.TransportTarrifs;
using R2CoreTransportationAndLoadNotification.TransportTarrifs.Exceptions;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WcLoadCapacitorLoadManipulation : UserControl
    {
        private readonly R2DateTime _DateTime = new R2DateTime();


        #region "General Properties"

        private LoadCapacitorLoadsListType _WcCurrentListTypeIssued = LoadCapacitorLoadsListType.None;
        public LoadCapacitorLoadsListType WcCurrentListTypeIssued
        {
            get { return _WcCurrentListTypeIssued; }
            set
            { _WcCurrentListTypeIssued = value; WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcCurrentListType = value; }
        }

        public object TxtSearchtc { get; private set; }

        #endregion

        #region "Subroutins And Functions"

        public R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure WcGetNSS(bool YourDirty)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                if (YourDirty)
                { if (!(TxtnEstelamId.Text == string.Empty | TxtnEstelamId.Text == "0")) { throw new DataEntryException("از کلید ویرایش بار استفاده کنید"); } }
                else
                { if (TxtnEstelamId.Text == string.Empty | TxtnEstelamId.Text == "0") { throw new DataEntryException("از کلید ثبت بار استفاده کنید"); } }

                if (TxtSearchLoad.Text == string.Empty) { throw new DataEntryException("نوع بار انتخاب نشده است"); }
                if (TxtSearchTargetCity.Text == string.Empty) { throw new DataEntryException("مقصد انتخاب نشده است"); }
                //if (TxtSearchTargetCity.Text.Split('#')[0] == "21310000") { throw new DataEntryException("کد مقصد مورد نظر فقط برای مبدا قابل انتخاب است"); }
                if (TxtSearchSourceCity.Text == string.Empty) { throw new DataEntryException("مبدا انتخاب نشده است"); }
                if (TxtSearchLoaderType.Text == string.Empty) { throw new DataEntryException("بارگیر انتخاب نشده است"); }
                if (TxtSearchTC.Text == string.Empty) { throw new DataEntryException("شرکت حمل و نقل انتخاب نشده است"); }
                if (TxtSearchLoadingPlace.Text == string.Empty) { throw new DataEntryException("محل بارگیری انتخاب نشده است"); }
                if (TxtSearchDischargingPlace.Text == string.Empty) { throw new DataEntryException("محل تخلیه انتخاب نشده است"); }
                if (TxtnCarNumKol.Text == string.Empty) { throw new DataEntryException("تعداد بار نادرست است"); }
                if (!(R2CoreTransportationAndLoadNotificationMClassGoodsManagement.GetNSSGood(Convert.ToInt64(TxtSearchLoad.Text.Split('#')[0])).Active))
                { throw new DataEntryException("امکان انتخاب بار مورد نظر وجود ندارد"); }
                Double TonajValue = 0;
                if (!(Double.TryParse(TxtnTonaj.Text.Replace("/", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out TonajValue))) { throw new DataEntryException("تناژ بار نادرست است"); }
                if (!(TonajValue >= 1 && TonajValue <= 150)) { throw new DataEntryException("تناژ بار نادرست است"); }
                if (TxtTarrif.Text == string.Empty) { TxtTarrif.Text = "0"; }
                if ((TxtAddress.Text.Length > 50) || (TxtDescription.Text.Length > 250) || (TxtLoadReciever.Text.Length > 50)) { throw new DataEntryException("تعداد حروف وارد شده در هر یک از فیلدها بیش از 50 حرف مجاز نیست"); }
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = null;
                var NSSAnnouncementHall = InstanceAnnouncementHalls.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]));
                var NSSAnnouncementHallSubGroup = InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]));
                if (TxtnEstelamId.Text != "0" & TxtnEstelamId.Text != string.Empty)
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(Convert.ToInt64(TxtnEstelamId.Text), string.Empty, TxtLoadReciever.Text, Convert.ToInt64(TxtSearchTargetCity.Text.Split('#')[0]), TonajValue, Convert.ToInt64(TxtSearchLoad.Text.Split('#')[0]), Convert.ToInt64(TxtSearchTC.Text.Split('#')[0]), false, Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]), TxtAddress.Text, InstanceLogin.GetNSSCurrentUser().UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, Convert.ToInt64(TxtSearchSourceCity.Text.Split('#')[0]), NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, WCTransportTarrifsParameters1.WCGetTPTParams(NSSAnnouncementHallSubGroup), false, Convert.ToInt64(TxtSearchLoadingPlace.Text.Split('#')[0]), Convert.ToInt64(TxtSearchDischargingPlace.Text.Split('#')[0])); }
                else
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, string.Empty, TxtLoadReciever.Text, Convert.ToInt64(TxtSearchTargetCity.Text.Split('#')[0]), TonajValue, Convert.ToInt64(TxtSearchLoad.Text.Split('#')[0]), Convert.ToInt64(TxtSearchTC.Text.Split('#')[0]), false, Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]), TxtAddress.Text, InstanceLogin.GetNSSCurrentUser().UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, Convert.ToInt64(TxtSearchSourceCity.Text.Split('#')[0]), NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, WCTransportTarrifsParameters1.WCGetTPTParams(NSSAnnouncementHallSubGroup), false, Convert.ToInt64(TxtSearchLoadingPlace.Text.Split('#')[0]), Convert.ToInt64(TxtSearchDischargingPlace.Text.Split('#')[0])); }
                return NSS;

            }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { throw ex; }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); return null; }
            catch (DataEntryException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "\\n" + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message); }
        }

        private void WCViewTarrif(Int64 YourTarrif)
        { TxtTarrif.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourTarrif); }

        public void WcViewInformation(R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure YourNSS)
        {
            try
            {
                TxtnEstelamId.Text = YourNSS.nEstelamId.ToString();
                TxtDateTimeofLoadRegistering.Text = YourNSS.dTimeElam + " - " + YourNSS.dDateElam;
                TxtLoadReciever.Text = YourNSS.StrBarName;
                TxtSearchSourceCity.Text = YourNSS.nBarSource + "    #    " + YourNSS.LoadSourceTitle.Trim();
                TxtSearchTargetCity.Text = YourNSS.nCityCode + "    #    " + YourNSS.LoadTargetTitle.Trim();
                TxtSearchLoad.Text = YourNSS.nBarCode + "    #    " + YourNSS.GoodTitle.Trim();
                TxtSearchLoaderType.Text = YourNSS.nTruckType + "    #    " + YourNSS.LoaderTypeTitle.Trim();
                TxtSearchTC.Text = YourNSS.nCompCode + "    #    " + YourNSS.TransportCompanyTitle.Trim();
                TxtSearchLoadingPlace.Text = YourNSS.LoadingPlaceId + "    #    " + YourNSS.LoadingPlaceTitle.Trim();
                TxtSearchDischargingPlace.Text = YourNSS.DischargingPlaceId + "    #    " + YourNSS.DischargingPlaceTitle.Trim();
                TxtAddress.Text = YourNSS.StrAddress;
                TxtnCarNumKol.Text = YourNSS.nCarNumKol.ToString();
                TxtnTonaj.Text = YourNSS.nTonaj.ToString();
                WCViewTarrif(YourNSS.StrPriceSug);
                TxtDescription.Text = YourNSS.StrDescription;
                WCUpdateWCTransportTarrifsParametersByLoad(YourNSS);
                WcViewInformationCompleted?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillGoods(string YourSearchString)
        {
            try
            {
                if (YourSearchString == String.Empty) { return; }
                DropDownListLoad.Items.Clear();
                DropDownListLoad.Items.Add("انتخاب کنید ...");
                DropDownListLoad.Enabled = false;
                var myGoods = R2CoreTransportationAndLoadNotificationMClassGoodsManagement.GetGoods_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myGoods.Count - 1; loop++)
                {
                    var myGood = myGoods[loop];
                    DropDownListLoad.Items.Add(myGood.GoodId + "    #    " + myGood.GoodName);
                }
                DropDownListLoad.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillTargets(string YourSearchString)
        {
            try
            {
                if (YourSearchString == String.Empty) { return; }
                DropDownListTargetCity.Items.Clear();
                DropDownListTargetCity.Items.Add("انتخاب کنید ...");
                DropDownListTargetCity.Enabled = false;
                var myTargets = R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetLoadTargets_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myTargets.Count - 1; loop++)
                {
                    var myTarget = myTargets[loop];
                    DropDownListTargetCity.Items.Add(myTarget.NSSCity.nCityCode + "    #    " + myTarget.NSSCity.StrCityName);
                }
                DropDownListTargetCity.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillSources(string YourSearchString)
        {
            try
            {
                if (YourSearchString == String.Empty) { return; }
                DropDownListSourceCity.Items.Clear();
                DropDownListSourceCity.Items.Add("انتخاب کنید ...");
                DropDownListSourceCity.Enabled = false;
                var mySources = R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetLoadTargets_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= mySources.Count - 1; loop++)
                {
                    var mySource = mySources[loop];
                    DropDownListSourceCity.Items.Add(mySource.NSSCity.nCityCode + "    #    " + mySource.NSSCity.StrCityName);
                }
                DropDownListSourceCity.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillLoaderTypes(string YourSearchString)
        {
            try
            {
                DropDownListLoaderType.Items.Clear();
                DropDownListLoaderType.Items.Add("انتخاب کنید ...");
                DropDownListLoaderType.Enabled = false;
                var myLoaderTypes = R2CoreTransportationAndLoadNotificationMClassLoaderTypesManagement.GetLoaderTypes_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myLoaderTypes.Count - 1; loop++)
                {
                    var myLoader = myLoaderTypes[loop];
                    DropDownListLoaderType.Items.Add(myLoader.LoaderTypeId + "    #    " + myLoader.LoaderTypeTitle);
                }
                DropDownListLoaderType.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillTransportCompanies(string YourSearchString)
        {
            try
            {
                DropDownListTC.Items.Clear();
                DropDownListTC.Items.Add("انتخاب کنید ...");
                DropDownListTC.Enabled = false;

                var myTCs = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetTransportCompanies_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myTCs.Count - 1; loop++)
                {
                    var myTC = myTCs[loop];
                    DropDownListTC.Items.Add(myTC.TCId + "    #    " + myTC.TCTitle);
                }
                DropDownListTC.Enabled = true;
            }
            catch (TransportCompanyNotFoundException ex)
            { throw ex; }
            catch (PermissionException ex)
            { throw ex; }
            catch (PleaseReloginException ex)
            { throw ex; }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillLoadingPlaces(string YourSearchString)
        {
            try
            {
                if (YourSearchString == String.Empty) { return; }
                var InstanceLoadingAndDischargingPlaces = new R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces.R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager();
                DropDownListLoadingPlace.Items.Clear();
                DropDownListLoadingPlace.Items.Add("انتخاب کنید ...");
                DropDownListLoadingPlace.Enabled = false;
                var myLoadingPlaces = InstanceLoadingAndDischargingPlaces.GetLoadingAndDischargingPlaces_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myLoadingPlaces.Count - 1; loop++)
                {
                    var myLoadingPlace = myLoadingPlaces[loop];
                    DropDownListLoadingPlace.Items.Add(myLoadingPlace.LADPlaceId + "    #    " + myLoadingPlace.LADPlaceTitle);
                }
                DropDownListLoadingPlace.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillDischargingPlaces(string YourSearchString)
        {
            try
            {
                if (YourSearchString == String.Empty) { return; }
                var InstanceLoadingAndDischargingPlaces = new R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces.R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager();
                DropDownListDischargingPlace.Items.Clear();
                DropDownListDischargingPlace.Items.Add("انتخاب کنید ...");
                DropDownListDischargingPlace.Enabled = false;
                var myDischargingPlaces = InstanceLoadingAndDischargingPlaces.GetLoadingAndDischargingPlaces_SearchIntroCharacters(YourSearchString);
                for (int loop = 0; loop <= myDischargingPlaces.Count - 1; loop++)
                {
                    var myDischargingPlace = myDischargingPlaces[loop];
                    DropDownListDischargingPlace.Items.Add(myDischargingPlace.LADPlaceId + "    #    " + myDischargingPlace.LADPlaceTitle);
                }
                DropDownListDischargingPlace.Enabled = true;
            }
            catch (SqlInjectionException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        public void WcRefreshInformation()
        {
            try
            {
                TxtnEstelamId.Text = string.Empty;
                TxtDateTimeofLoadRegistering.Text = string.Empty;
                TxtnCarNumKol.Text = string.Empty;
                TxtnTonaj.Text = string.Empty;
                TxtTarrif.Text = string.Empty;
                TxtLoadReciever.Text = string.Empty;
                TxtAddress.Text = string.Empty;
                TxtDescription.Text = string.Empty;
                var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                if (TxtSearchLoaderType.Text.Split('#')[0].Trim() == String.Empty)
                { WCTransportTarrifsParameters1.WcRefreshInformation(); }
                else
                { WCTransportTarrifsParameters1.WcViewInformation(InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]))); }
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WCUpdateWCTransportTarrifsParametersByLoad(R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure YourNSS)
        {
            try
            { WCTransportTarrifsParameters1.WcViewInformation(YourNSS); }
            catch (Exception ex)
            { throw ex; }
        }

        private void WCUpdateWCTransportTarrifsParametersByAHSGId()
        {
            try
            {
                if (TxtSearchLoaderType.Text.Trim() == string.Empty) { return; }
                var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                WCTransportTarrifsParameters1.WcViewInformation(InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0])));
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region "Events"

        public event EventHandler WcViewInformationCompleted;
        public event EventHandler WcInformationChangedEvent;

        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcLoadCapacitorLoadSelectedEvent += WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent;
                if (!IsPostBack) { WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcViewInformation(); }
                BtnSearchLoaderType.ServerClick += BtnSearchLoaderType_ServerClick;
                BtnSearchLoad.ServerClick += BtnSearchLoad_ServerClick;
                BtnSearchSourceCity.ServerClick += BtnSearchSourceCity_ServerClick;
                BtnSearchTargetCity.ServerClick += BtnSearchTargetCity_ServerClick;
                BtnSearchTarrif.ServerClick += BtnSearchTarrif_ServerClick;
                BtnSearchTC.ServerClick += BtnSearchTC_ServerClick;
                BtnSearchDischargingPlace.ServerClick += BtnSearchDischargingPlace_ServerClick;
                BtnSearchLoadingPlace.ServerClick += BtnSearchLoadingPlace_ServerClick;
                DropDownListLoad.SelectedIndexChanged += DropDownListGoods_SelectedIndexChanged;
                DropDownListLoaderType.SelectedIndexChanged += DropDownListLoaderType_SelectedIndexChanged;
                DropDownListSourceCity.SelectedIndexChanged += DropDownListSourceCity_SelectedIndexChanged;
                DropDownListTargetCity.SelectedIndexChanged += DropDownListTargetCity_SelectedIndexChanged;
                DropDownListTC.SelectedIndexChanged += DropDownListTC_SelectedIndexChanged;
                DropDownListDischargingPlace.SelectedIndexChanged += DropDownListDischargingPlace_SelectedIndexChanged;
                DropDownListLoadingPlace.SelectedIndexChanged += DropDownListLoadingPlace_SelectedIndexChanged;
                BtnLoadCancelling.Click += BtnLoadCancelling_Click;
                BtnLoadDeleting.Click += BtnLoadDeleting_Click;
                BtnLoadRegistering.Click += BtnLoadRegistering_Click;
                BtnLoadEditing.Click += BtnLoadEditing_Click;
                BtnReRegistering.Click += BtnReRegistering_Click;
                BtnNewLoad.Click += BtnNewLoad_Click;

                //کنترل مجوز دسترسی کاربر برای مشاهده لیست کامل شرکت های حمل و نقل
                DropDownListTC.Enabled = false;
                TxtSearchTC.Enabled = false;
                BtnSearchTC.Visible = false;
                if (!IsPostBack)
                {

                    var InstancePermissions = new R2Core.PermissionManagement.R2CoreInstansePermissionsManager();
                    var InstanceLogin = new ATISWeb.LoginManagement.ATISWebMClassLoginManager();
                    if (!InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanViewListofAllTransportCompanies, InstanceLogin.GetNSSCurrentUser().UserId, 0))
                    {
                        var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                        var TC = InstanceTransportCompanies.GetNSSTransportCompnay(InstanceLogin.GetNSSCurrentUser());
                        TxtSearchTC.Text = TC.TCId + "    #    " + TC.TCTitle.Trim();
                        return;
                    }
                    DropDownListTC.Enabled = true;
                    BtnSearchTC.Visible = true;
                    TxtSearchTC.Enabled = true;
                }
            }
            catch (TransportCompanyNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PermissionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchLoadingPlace_ServerClick(object sender, EventArgs e)
        {
            try { WcFillLoadingPlaces(TxtSearchLoadingPlace.Text); }
            catch (LoadingPlaceNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PermissionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchDischargingPlace_ServerClick(object sender, EventArgs e)
        {
            try { WcFillDischargingPlaces(TxtSearchDischargingPlace.Text); }
            catch (DischargingPlaceNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PermissionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchTC_ServerClick(object sender, EventArgs e)
        {
            try { WcFillTransportCompanies(TxtSearchTC.Text); }
            catch (TransportCompanyNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PermissionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchTargetCity_ServerClick(object sender, EventArgs e)
        {
            try { WcFillTargets(TxtSearchTargetCity.Text); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchTarrif_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if ((TxtSearchLoaderType.Text.Split('#')[0] != String.Empty) && (TxtSearchTargetCity.Text.Split('#')[0] != String.Empty))
                {
                    var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                    var NSSAnnouncementHall = InstanceAnnouncementHalls.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]));
                    var NSSAnnouncementHallSubGroup = InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]));
                    var NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, string.Empty, null, Convert.ToInt64(TxtSearchTargetCity.Text.Split('#')[0]), double.MinValue, long.MinValue, long.MinValue, false, long.MinValue, null, long.MinValue, long.MinValue, long.MinValue, string.Empty, null, String.Empty, long.MinValue, long.MinValue, Convert.ToInt64(TxtSearchSourceCity.Text.Split('#')[0]), NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, null, false, long.MinValue, long.MinValue);
                    var InstanceTransportTarrifs = new R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsManager();
                    var Tarrif = InstanceTransportTarrifs.GetNSSTransportTarrif(NSS).Tarrif;
                    WCViewTarrif(Tarrif);
                }
            }
            catch (TransportPriceTarrifNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "lkfwlkflskdf" + "');", true);
                WCViewTarrif(0);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true);
                WCViewTarrif(0);
            }
        }

        private void BtnSearchSourceCity_ServerClick(object sender, EventArgs e)
        {
            try { WcFillSources(TxtSearchSourceCity.Text); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchLoad_ServerClick(object sender, EventArgs e)
        {
            try { WcFillGoods(TxtSearchLoad.Text); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnSearchLoaderType_ServerClick(object sender, EventArgs e)
        {
            try { WcFillLoaderTypes(TxtSearchLoaderType.Text); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent(object sender, WcLoadCapacitorLoadsCollectionSummaryIntelligently.nEstelamIdEventArgs e)
        {
            try
            {
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var NSS = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(e.nEstelamId, true);
                WcViewInformation(NSS);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnNewLoad_Click(object sender, EventArgs e)
        {
            try
            { WcRefreshInformation(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnLoadRegistering_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = WcGetNSS(true);
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                long mynEstelamId = InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(NSS);
                WcViewInformation(InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(mynEstelamId, true));
                WcInformationChangedEvent?.Invoke(this, new EventArgs());
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت به ثبت رسید" + "');", true);
            }
            catch (LoadTargetorLoadSourceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadingPlaceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DischargingPlaceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadingAndDischargingPlaceNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadTonajExceededException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadRegisteringInHolidayNotAllowedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex) when (ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException || ex is LoadCapacitorLoadNumberOverLimitException || ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException || ex is TransportCompanyISNotActiveException || ex is LoadCapacitorLoadRegisterTimePassedException || ex is LoadCapacitorLoadEditTimePassedException || ex is HasNotRelationBetweenProvinceAndAnnouncementHallSubGroup || ex is TransportPriceTarrifParameterDetailNotFoundException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DataEntryException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnLoadEditing_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = WcGetNSS(false);
                InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadEditing(NSS, InstanceLogin.GetNSSCurrentUser());
                WcViewInformation(InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(NSS.nEstelamId, true));
                WcInformationChangedEvent?.Invoke(this, new EventArgs());
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "ویرایش بار با موفقیت انجام شد" + "');", true);
            }
            catch (LoadTargetorLoadSourceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadingPlaceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DischargingPlaceIsUnActiveException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadingAndDischargingPlaceNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadTonajExceededException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (EditOrDeleteReRegisteredLoadNotAllowedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (SqlInjectionException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex) when (ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException || ex is LoadCapacitorLoadNumberOverLimitException || ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException || ex is TransportCompanyISNotActiveException || ex is LoadCapacitorLoadRegisterTimePassedException || ex is LoadCapacitorLoadEditTimePassedException || ex is TransportPriceTarrifParameterDetailNotFoundException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex) when (ex is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException || ex is LoadCapacitorLoadNotFoundException || ex is LoadCapacitorLoadEditingChangeAHIdNotAllowedException || ex is LoaderTypeRelationAnnouncementHallNotFoundException || ex is LoaderTypeRelationAnnouncementHallSubGroupNotFoundException || ex is HasNotRelationBetweenProvinceAndAnnouncementHallSubGroup)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DataEntryException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnReRegistering_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSSTemp = WcGetNSS(false);
                if (NSSTemp.nEstelamId != 0)
                {
                    InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadReRegistering(NSSTemp.nEstelamId, InstanceLogin.GetNSSCurrentUser());
                    WcInformationChangedEvent?.Invoke(this, new EventArgs());
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "فرآیند اعلام مجدد بار با موفقیت انجام شد" + "');", true);
                }
            }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (DataEntryException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadRegisterTimePassedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadReRegisteringTimePassedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadReRegisteringNotAllowedBecuasenCarNumException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadReRegisteringNotAllowedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void BtnLoadDeleting_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSSTemp = WcGetNSS(false);
                var NSS = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(NSSTemp.nEstelamId, true);

                if (NSS.nEstelamId != 0)
                {
                    InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadDeleting(NSS, InstanceLogin.GetNSSCurrentUser());
                    WcRefreshInformation();
                    WcInformationChangedEvent?.Invoke(this, new EventArgs());
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت حذف شد" + "');", true);
                }
            }
            catch (EditOrDeleteReRegisteredLoadNotAllowedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (LoadCapacitorLoadDeleteTimePassedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (SoftwareUserCanNotDeleteLoadCapacitorLoadException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }

        }

        private void BtnLoadCancelling_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSSTemp = WcGetNSS(false);
                var NSS = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(NSSTemp.nEstelamId, true);
                if (NSS.nEstelamId != 0)
                {
                    InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadCancelling(NSS, InstanceLogin.GetNSSCurrentUser());
                    WcRefreshInformation();
                    WcInformationChangedEvent?.Invoke(this, new EventArgs());
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت کنسل شد" + "');", true);
                }
            }
            catch (TransportPriceTarrifParameterDetailsNotAdjustedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (LoadCapacitorLoadCancelTimeNotReachedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }

        }

        private void DropDownListSourceCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListSourceCity.SelectedIndex > 0) { TxtSearchSourceCity.Text = DropDownListSourceCity.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListTargetCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { if (DropDownListTargetCity.SelectedIndex > 0) { TxtSearchTargetCity.Text = DropDownListTargetCity.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListLoaderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { if (DropDownListLoaderType.SelectedIndex > 0) { TxtSearchLoaderType.Text = DropDownListLoaderType.SelectedValue.Trim(); WCUpdateWCTransportTarrifsParametersByAHSGId(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListLoad.SelectedIndex > 0) { TxtSearchLoad.Text = DropDownListLoad.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListTC.SelectedIndex > 0) { TxtSearchTC.Text = DropDownListTC.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListLoadingPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListLoadingPlace.SelectedIndex > 0) { TxtSearchLoadingPlace.Text = DropDownListLoadingPlace.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
        }

        private void DropDownListDischargingPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListDischargingPlace.SelectedIndex > 0) { TxtSearchDischargingPlace.Text = DropDownListDischargingPlace.SelectedValue.Trim(); } }
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