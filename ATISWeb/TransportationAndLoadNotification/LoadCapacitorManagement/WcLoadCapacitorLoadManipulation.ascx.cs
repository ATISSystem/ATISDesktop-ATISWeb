using System;
using System.Reflection;
using System.Web.UI;

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

        #endregion

        #region "Subroutins And Functions"

        public R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure WcGetNSS(bool YourDirty)
        {
            try
            {
                if (YourDirty)
                { if (!(TxtnEstelamId.Text == string.Empty | TxtnEstelamId.Text == "0")) { throw new DataEntryException("از کلید ویرایش بار استفاده کنید"); } }
                else
                { if (TxtnEstelamId.Text == string.Empty | TxtnEstelamId.Text == "0") { throw new DataEntryException("از کلید ثبت بار استفاده کنید"); } }

                if (TxtSearchLoad.Text == string.Empty) { throw new DataEntryException("نوع بار انتخاب نشده است"); }
                if (TxtSearchTargetCity.Text == string.Empty) { throw new DataEntryException("مقصد انتخاب نشده است"); }
                if (TxtSearchLoaderType.Text == string.Empty) { throw new DataEntryException("بارگیر انتخاب نشده است"); }
                if (TxtnCarNumKol.Text == string.Empty) { throw new DataEntryException("تعداد بار نادرست است"); }
                if (TxtTarrif.Text == string.Empty) { TxtTarrif.Text = "0"; }
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = null;
                if (TxtnEstelamId.Text != "0" & TxtnEstelamId.Text != string.Empty)
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(Convert.ToInt64(TxtnEstelamId.Text), string.Empty, TxtLoadReciever.Text, Convert.ToInt64(TxtSearchTargetCity.Text.Split('#')[0]), Convert.ToInt64(TxtSearchLoad.Text.Split('#')[0]), R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(ATISWebMClassLoginManagement.GetNSSCurrentUser()).TCId,true, Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]), TxtAddress.Text, ATISWebMClassLoginManagement.GetNSSCurrentUser().UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, 21310000, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0])).AHId, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0])).AHSGId); }
                else
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, string.Empty, TxtLoadReciever.Text, Convert.ToInt64(TxtSearchTargetCity.Text.Split('#')[0]), Convert.ToInt64(TxtSearchLoad.Text.Split('#')[0]), R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(ATISWebMClassLoginManagement.GetNSSCurrentUser()).TCId,true, Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0]), TxtAddress.Text, ATISWebMClassLoginManagement.GetNSSCurrentUser().UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, 21310000, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0])).AHId, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(TxtSearchLoaderType.Text.Split('#')[0])).AHSGId); }
                return NSS;
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); return null; }
            catch (DataEntryException ex)
            { throw ex; }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "\\n" + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message); }
        }

        public void WcViewInformation(R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure YourNSS)
        {
            try
            {
                TxtnEstelamId.Text = YourNSS.nEstelamId.ToString();
                TxtDateTimeofLoadRegistering.Text = YourNSS.dTimeElam + " - " + YourNSS.dDateElam;
                TxtLoadReciever.Text = YourNSS.StrBarName;
                TxtSearchTargetCity.Text = YourNSS.nCityCode + "    #    " + YourNSS.LoadTargetTitle.Trim();
                TxtSearchLoad.Text = YourNSS.nBarCode + "    #    " + YourNSS.GoodTitle.Trim();
                TxtSearchLoaderType.Text = YourNSS.nTruckType + "    #    " + YourNSS.LoaderTypeTitle.Trim();
                TxtAddress.Text = YourNSS.StrAddress;
                TxtnCarNumKol.Text = YourNSS.nCarNumKol.ToString();
                TxtTarrif.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourNSS.StrPriceSug);
                TxtDescription.Text = YourNSS.StrDescription;
                WcViewInformationCompleted?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillGoods(string YourSearchString)
        {
            try
            {
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
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        private void WcFillTargets(string YourSearchString)
        {
            try
            {
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
                TxtTarrif.Text = string.Empty;
                TxtLoadReciever.Text = string.Empty;
                TxtAddress.Text = string.Empty;
                TxtDescription.Text = string.Empty;
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
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
                BtnSearchTargetCity.ServerClick += BtnSearchTargetCity_ServerClick;
                DropDownListLoad.SelectedIndexChanged += DropDownListGoods_SelectedIndexChanged;
                DropDownListLoaderType.SelectedIndexChanged += DropDownListLoaderType_SelectedIndexChanged;
                DropDownListTargetCity.SelectedIndexChanged += DropDownListTargetCity_SelectedIndexChanged;
                BtnLoadCancelling.Click += BtnLoadCancelling_Click;
                BtnLoadDeleting.Click += BtnLoadDeleting_Click;
                BtnLoadRegistering.Click += BtnLoadRegistering_Click;
                BtnLoadEditing.Click += BtnLoadEditing_Click;
                BtnNewLoad.Click += BtnNewLoad_Click;
                if (!Page.IsPostBack)
                { }
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnSearchTargetCity_ServerClick(object sender, EventArgs e)
        {
            try { WcFillTargets(TxtSearchTargetCity.Text); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnSearchLoad_ServerClick(object sender, EventArgs e)
        {
            try { WcFillGoods(TxtSearchLoad.Text); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnSearchLoaderType_ServerClick(object sender, EventArgs e)
        {
            try { WcFillLoaderTypes(TxtSearchLoaderType.Text); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent(object sender, WcLoadCapacitorLoadsCollectionSummaryIntelligently.nEstelamIdEventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure NSS = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(e.nEstelamId);
                WcViewInformation(NSS);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnNewLoad_Click(object sender, EventArgs e)
        {
            try
            { WcRefreshInformation(); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnLoadRegistering_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = WcGetNSS(true);
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                long mynEstelamId = InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(NSS);
                WcViewInformation(R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(mynEstelamId));
                WcInformationChangedEvent?.Invoke(this, new EventArgs());
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت به ثبت رسید" + "');", true);
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex) when (ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException || ex is LoadCapacitorLoadNumberOverLimitException || ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException || ex is TransportCompanyISNotActiveException || ex is LoadCapacitorLoadRegisterTimePassedException || ex is LoadCapacitorLoadEditTimePassedException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DataEntryException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n " + ex.Message + "');", true); }
        }

        private void BtnLoadEditing_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = WcGetNSS(false);
                InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadEditing(NSS, ATISWebMClassLoginManagement.GetNSSCurrentUser());
                WcViewInformation(InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(NSS.nEstelamId));
                WcInformationChangedEvent?.Invoke(this, new EventArgs());
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "ویرایش بار با موفقیت انجام شد" + "');", true);
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex) when (ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException || ex is LoadCapacitorLoadNumberOverLimitException || ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException || ex is TransportCompanyISNotActiveException || ex is LoadCapacitorLoadRegisterTimePassedException || ex is LoadCapacitorLoadEditTimePassedException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex) when (ex is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException || ex is LoadCapacitorLoadNotFoundException || ex is LoadCapacitorLoadEditingChangeAHIdNotAllowedException || ex is LoaderTypeRelationAnnouncementHallNotFoundException || ex is LoaderTypeRelationAnnouncementHallSubGroupNotFoundException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (DataEntryException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + " \\n " + ex.Message + "');", true); }
        }

        private void BtnLoadDeleting_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSSTemp = WcGetNSS(false);
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(NSSTemp.nEstelamId);

                if (NSS.nEstelamId != 0)
                {
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadDeleting(NSS, ATISWebMClassLoginManagement.GetNSSCurrentUser());
                    WcRefreshInformation();
                    WcInformationChangedEvent?.Invoke(this, new EventArgs());
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت حذف شد" + "');", true);
                }
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (LoadCapacitorLoadDeleteTimePassedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message + "');", true); }

        }

        private void BtnLoadCancelling_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSSTemp = WcGetNSS(false);
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(NSSTemp.nEstelamId);

                if (NSS.nEstelamId != 0)
                {
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadCancelling(NSS, ATISWebMClassLoginManagement.GetNSSCurrentUser());
                    WcRefreshInformation();
                    WcInformationChangedEvent?.Invoke(this, new EventArgs());
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "بار با موفقیت کنسل شد" + "');", true);
                }
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (LoadCapacitorLoadCancelTimeNotReachedException ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message + "');", true); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message + "');", true); }

        }

        private void DropDownListTargetCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListTargetCity.SelectedIndex > 0) { TxtSearchTargetCity.Text = DropDownListTargetCity.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message + "');", true); }
        }

        private void DropDownListLoaderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { if (DropDownListLoaderType.SelectedIndex > 0) { TxtSearchLoaderType.Text = DropDownListLoaderType.SelectedValue.Trim(); } }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message + "');", true); }
        }

        private void DropDownListGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { if (DropDownListLoad.SelectedIndex > 0) { TxtSearchLoad.Text = DropDownListLoad.SelectedValue.Trim(); } }
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