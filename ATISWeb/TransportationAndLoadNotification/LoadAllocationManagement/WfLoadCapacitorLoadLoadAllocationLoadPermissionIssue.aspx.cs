using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;

namespace ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement
{
    public partial class WfLoadCapacitorLoadLoadAllocationLoadPermissionIssue : System.Web.UI.Page
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
                WcLoadCapacitorLoadLoadPermissionsIssued.WcCurrentListTypeIssued = LoadCapacitorLoadsListType.Sedimented;
                WcLoadCapacitorLoadsCollectionIntelligently.WcCurrentListType =LoadCapacitorLoadsListType.Sedimented;
                WcLoadCapacitorLoadsCollectionIntelligently.WcViewInformation();
            }
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