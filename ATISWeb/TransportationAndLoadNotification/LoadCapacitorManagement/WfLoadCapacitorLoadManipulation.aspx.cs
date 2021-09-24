using System;
using System.Reflection;
using System.Web.UI;

using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WfLoadCapacitorLoadManipulation : Page
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                WcLoadCapacitorLoadManipulation.WcCurrentListTypeIssued = LoadCapacitorLoadsListType.NotSedimented;
                WcLoadCapacitorLoadLoadPermissionsIssued.WcCurrentListTypeIssued = LoadCapacitorLoadsListType.None;
                WcLoadCapacitorLoadManipulation.WcInformationChangedEvent += WcLoadCapacitorLoadManipulation_WcInformationChangedEvent;
                WcLoadCapacitorLoadsCollectionIntelligently.WcCurrentListType = WcLoadCapacitorLoadsCollectionIntelligently.WcCurrentListType = LoadCapacitorLoadsListType.None ;
                WcLoadCapacitorLoadsCollectionIntelligently.WcViewInformation();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WcLoadCapacitorLoadManipulation_WcInformationChangedEvent(object sender, EventArgs e)
        {
            try
            {
                WcLoadCapacitorLoadLoadPermissionsIssued.WcViewInformation(WcLoadCapacitorLoadManipulation.WcGetNSS(false).nEstelamId);
                WcLoadCapacitorLoadsCollectionIntelligently.WcViewInformation();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +"." + ex.Message + "');", true);  }
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