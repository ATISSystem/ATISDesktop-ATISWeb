using System;
using System.Reflection;
using System.Web.UI;
using R2Core.ExceptionManagement;
using R2Core.PublicProc;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WcViewerNSSLoadCapacitorLoad : UserControl
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"

        public R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure WcGetNSSCurrent
        {
            get
            {
                try
                {
                    if (TxtnEstelamId.Text == string.Empty)
                    { throw new DataEntryException(); }
                    else
                    {
                        var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                        return InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(Convert.ToInt64(TxtnEstelamId.Text), true);
                    }
                }
                catch (DataEntryException ex)
                { throw ex; }
                catch (LoadCapacitorLoadNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }
        }

        public void WcRefreshInformation()
        {
            try
            {
                TxtnEstelamId.Text = string.Empty;
                LblDateTimeofLoadRegistering.Text = string.Empty;
                LblLoadTitle.Text = string.Empty;
                LblTargetCity.Text = string.Empty;
                LblLoaderType.Text = string.Empty;
                LblnCarNumKol.Text = string.Empty;
                LblnCarNum.Text = string.Empty;
                LblTarrif.Text = string.Empty;
                LblLoadReceiver.Text = string.Empty;
                LblDescription.Text = string.Empty;
                LblAddress.Text = string.Empty;
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        public void WcViewNSS(Int64 YournEstelamId)
        {
            try
            {
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var NSS = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(YournEstelamId,true);
                TxtnEstelamId.Text = NSS.nEstelamId.ToString();
                LblDateTimeofLoadRegistering.Text = NSS.dDateElam + " - " + NSS.dTimeElam;
                LblLoadTitle.Text = NSS.GoodTitle;
                LblTargetCity.Text = NSS.LoadTargetTitle;
                LblLoaderType.Text = NSS.LoaderTypeTitle;
                LblnCarNumKol.Text = NSS.nCarNumKol.ToString();
                LblnCarNum.Text = NSS.nCarNum.ToString();
                LblTarrif.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Convert.ToInt64(NSS.StrPriceSug.ToString()));
                LblDescription.Text = NSS.StrDescription;
                LblAddress.Text = NSS.StrAddress;
                LblLoadReceiver.Text = NSS.StrBarName;
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
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