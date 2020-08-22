using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WfTommorowLoadsManipulation : System.Web.UI.Page
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
                WcLoadCapacitorLoadManipulation.WcCurrentListTypeIssued = LoadCapacitorLoadsListType.TommorowLoad;
                WcLoadCapacitorLoadManipulation.WcInformationChangedEvent += WcLoadCapacitorLoadManipulation_WcInformationChangedEvent;
                WcLoadCapacitorLoadsCollectionIntelligently.WcCurrentListType = WcLoadCapacitorLoadsCollectionIntelligently.WcCurrentListType = LoadCapacitorLoadsListType.TommorowLoad;
                WcLoadCapacitorLoadsCollectionIntelligently.WcViewInformation();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void WcLoadCapacitorLoadManipulation_WcInformationChangedEvent(object sender, EventArgs e)
        {
            try
            { WcLoadCapacitorLoadsCollectionIntelligently.WcViewInformation(); }
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