using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

using R2Core.DateAndTimeManagement;
using R2Core.UserManagement;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.LoadCapacitor;
using R2CoreTransportationAndLoadNotification.Goods;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation;
using R2CoreTransportationAndLoadNotification.LoadTargets;
using R2CoreTransportationAndLoadNotification.LoaderTypes;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using R2WebPrimaryTest.UserControls;

namespace R2WebPrimaryTest
{
    public partial class UCLoadCapacitorLoadManipulation : System.Web.UI.UserControl
    {
        private readonly R2DateTime _DateTime = new R2DateTime();
        public event EventHandler UCViewInformationCompleted;
        public event EventHandler UCInformationChangedEvent;


        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        public R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure UCGetInformation(bool YourDirty)
        {
            try
            {
                if ((!YourDirty) & (LblnEstelamId.Text == string.Empty | LblnEstelamId.Text == "0")) { throw new Exception("بار انتخاب نشده است"); }
                if (DropDownListGoods.SelectedIndex < 0) { throw new Exception("نوع بار انتخاب نشده است"); }
                if (DropDownListTargets.SelectedIndex < 0) { throw new Exception("مقصد انتخاب نشده است"); }
                if (DropDownListLoaderType.SelectedIndex < 0) { throw new Exception("بارگیر انتخاب نشده است"); }
                if (TxtnCarNumKol.Text == string.Empty) { throw new Exception("تعداد بار نادرست است"); }
                if (TxtTarrif.Text == string.Empty) { TxtTarrif.Text = "0"; }
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = null;
                if (LblnEstelamId.Text != "0" & LblnEstelamId.Text != string.Empty)
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(Convert.ToInt64(LblnEstelamId.Text), TxtStrBarName.Text, Convert.ToInt64(DropDownListTargets.Text.Split(' ')[0]), Convert.ToInt64(DropDownListGoods.Text.Split(' ')[0]), R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId, Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0]), TxtAddress.Text, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, 21310000, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0])).AHId, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0])).AHSGId); }
                else
                { NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, TxtStrBarName.Text, Convert.ToInt64(DropDownListTargets.Text.Split(' ')[0]), Convert.ToInt64(DropDownListGoods.Text.Split(' ')[0]), R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId, Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0]), TxtAddress.Text, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, Convert.ToInt64(TxtnCarNumKol.Text), Convert.ToInt64(TxtTarrif.Text.Replace(",", "")), TxtDescription.Text, _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime(), Convert.ToInt64(TxtnCarNumKol.Text), R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered, 21310000, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByLoaderTypeId(Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0])).AHId, R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(Convert.ToInt64(DropDownListLoaderType.Text.Split(' ')[0])).AHSGId); }
                return NSS;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void UCViewInformation(R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure YourNSS)
        {
            try
            {
                LblnEstelamId.Text = YourNSS.nEstelamId.ToString();
                LblDateElam.Text = YourNSS.dDateElam + "-" + YourNSS.dTimeElam;
                TxtStrBarName.Text = YourNSS.StrBarName;
                TxtSearchTarget.Text = YourNSS.nCityCode.ToString();
                TxtSearchGood.Text = YourNSS.nBarCode.ToString();
                TxtSearchLoaderType.Text = YourNSS.nTruckType.ToString();
                TxtAddress.Text = YourNSS.StrAddress;
                TxtnCarNumKol.Text = YourNSS.nCarNumKol.ToString();
                TxtTarrif.Text = YourNSS.StrPriceSug.ToString();
                TxtDescription.Text = YourNSS.StrDescription;
                UCViewInformationCompleted?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "/n/r" + ex.Message); }
        }

        private void FillGoods(string YourSearchString)
        {
            DropDownListGoods.Items.Clear();
            var myGoods = R2CoreTransportationAndLoadNotificationMClassGoodsManagement.GetGoods_SearchIntroCharacters(YourSearchString);
            for (int loop = 0; loop <= myGoods.Count - 1; loop++)
            {
                var myGood = myGoods[loop];
                DropDownListGoods.Items.Add(myGood.GoodId + "  " + myGood.GoodName);
            }
        }

        private void FillTargets(string YourSearchString)
        {
            DropDownListTargets.Items.Clear();
            var myTargets = R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetLoadTargets_SearchIntroCharacters(YourSearchString);
            for (int loop = 0; loop <= myTargets.Count - 1; loop++)
            {
                var myTarget = myTargets[loop];
                DropDownListTargets.Items.Add(myTarget.NSSCity.nCityCode + "  " + myTarget.NSSCity.StrCityName);
            }
        }

        private void FillLoaderTypes(string YourSearchString)
        {
            DropDownListLoaderType.Items.Clear();
            var myLoaderTypes = R2CoreTransportationAndLoadNotificationMClassLoaderTypesManagement.GetLoaderTypes_SearchIntroCharacters(YourSearchString);
            for (int loop = 0; loop <= myLoaderTypes.Count - 1; loop++)
            {
                var myLoader = myLoaderTypes[loop];
                DropDownListLoaderType.Items.Add(myLoader.LoaderTypeId + "  " + myLoader.LoaderTypeTitle);
            }
        }

        public void UCRefreshInformation()
        {
            LblnEstelamId.Text = string.Empty;
            LblDateElam.Text = string.Empty;
            TxtnCarNumKol.Text = string.Empty;
            TxtTarrif.Text = string.Empty;
            TxtStrBarName.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtDescription.Text = string.Empty;
        }

        #endregion

        #region "Events"





        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    //FillGoods(TxtSearchGood.Text);
                    //FillTargets(TxtSearchTarget.Text);
                    //FillLoaderTypes(TxtSearchLoaderType.Text);
                }
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }

        }

        protected void TxtSearchGood_TextChanged(object sender, EventArgs e)
        {
            try { FillGoods(TxtSearchGood.Text); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void TxtSearchTarget_TextChanged(object sender, EventArgs e)
        {
            try { FillTargets(TxtSearchTarget.Text); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void TxtSearchLoaderType_TextChanged(object sender, EventArgs e)
        {
            try { FillLoaderTypes(TxtSearchLoaderType.Text); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnCancelling_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = UCGetInformation(false);
                if (NSS.nEstelamId != 0)
                {
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadCancelling(NSS.nEstelamId);
                    UCRefreshInformation();
                    UCInformationChangedEvent?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnDeleting_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = UCGetInformation(false);
                if (NSS.nEstelamId != 0)
                {
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadDeleting(NSS.nEstelamId);
                    UCRefreshInformation();
                    UCInformationChangedEvent?.Invoke(this, new EventArgs());
                }
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnRegistering_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure NSS = UCGetInformation(true);
                if (NSS.nEstelamId != 0)
                { R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadEditing(NSS); }
                else
                {
                    long mynEstelamId = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadRegistering(NSS);
                    UCViewInformation(R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(mynEstelamId));
                }
                UCInformationChangedEvent?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnNewLoad_Click(object sender, EventArgs e)
        {
            try
            { UCRefreshInformation(); }
            catch (Exception ex)
            { Response.Write("<script>alert('Refreshed ...')</script>"); }
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