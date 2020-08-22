using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

namespace R2WebPrimaryTest.UserControls
{
    public partial class UCViewerNSSLoadCapacitorLoad : System.Web.UI.UserControl
    {

        #region "General Properties"

        public R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure UCGetNSSCurrent
        { get { return R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(Convert.ToInt64(LblnEstelamId.Text)); } }


        #endregion

        #region "Subroutins And Functions"

        private void UCClearInformation()
        {
            LblnEstelamId.Text = string.Empty;
            LbldDateTimeElam.Text = string.Empty;
            LblnCarNumKol.Text = string.Empty;
            LblGoodTitle.Text = string.Empty;
            LblLoadTargetTitle.Text = string.Empty;
            LblLoaderTypeTitle.Text = string.Empty;
            LblTarrifPrice.Text = string.Empty;
            LblStrDescription.Text = string.Empty;
            LblStrAddress.Text = string.Empty;
            LblStrBarName.Text = string.Empty;
        }

        public void UCViewNSSLoadCapacitorLoad(Int64 YournEstelamId)
        {
            try
            {
                UCClearInformation();
                var NSS = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId);
                LblnEstelamId.Text = NSS.nEstelamId.ToString();
                LbldDateTimeElam.Text = NSS.dDateElam + " - " + NSS.dTimeElam;
                LblnCarNumKol.Text = NSS.nCarNumKol.ToString();
                LblGoodTitle.Text = NSS.GoodTitle;
                LblLoadTargetTitle.Text = NSS.LoadTargetTitle;
                LblLoaderTypeTitle.Text = NSS.LoaderTypeTitle;
                LblTarrifPrice.Text = NSS.StrPriceSug.ToString();
                LblStrDescription.Text = NSS.StrDescription;
                LblStrAddress.Text = NSS.StrAddress;
                LblStrBarName.Text = NSS.StrBarName;
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "/n/r" + ex.Message); }
        }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        { }
        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion


    }
}