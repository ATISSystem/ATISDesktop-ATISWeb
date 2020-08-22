using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using static R2WebPrimaryTest.UserControls.UCViewerLoadCapacitorLoads;

namespace R2WebPrimaryTest
{
    public partial class LoadCapacitorLoadManipulation : System.Web.UI.Page
    {

        #region "General Properties"
        #endregion

        #region "Subroutins And Functions"


        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"


        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["CheckRefresh"] = Session["CheckRefresh"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UCLoadCapacitorLoadManipulation.UCViewInformationCompleted += _Handler;
                UCLoadCapacitorLoadManipulation.UCInformationChangedEvent += UCLoadCapacitorLoadManipulation_UCInformationChangedEvent;
                UCViewerLoadCapacitorLoads.UCLoadCapacitorLoadSelectedEvent += UCLoadCapacitorLoadSelectedEvent;
                R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure NSSTransportCompany = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS);
                TransportCompanyTitle.Text = "شرکت حمل و نقل " + NSSTransportCompany.TCTitle;
                UCViewerLoadCapacitorLoads.UCViewNotSedimentedLoadCapacitorLoads(NSSTransportCompany.TCId);
                if (!IsPostBack)
                { Session["CheckRefresh"] = Server.UrlDecode(System.DateTime.Now.ToString()); }
                UCViewerLoadCapacitorLoads.UCCaption = "لیست بار موجود";
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        private void UCLoadCapacitorLoadManipulation_UCInformationChangedEvent(object sender, EventArgs e)
        {
            try { UCViewerLoadCapacitorLoads.UCViewNotSedimentedLoadCapacitorLoads(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        public void _Handler(object sender, EventArgs e)
        {
            try
            { UCLoadCapacitorLoadLoadPermissionsIssued.UCViewInformation(UCLoadCapacitorLoadManipulation.UCGetInformation(false).nEstelamId); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        private void UCLoadCapacitorLoadSelectedEvent(object Sender, nEstelamIdEventArgs e)
        {
            try
            {
                UCLoadCapacitorLoadManipulation.UCViewInformation(R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(e.nEstelamId));
                UCLoadCapacitorLoadLoadPermissionsIssued.UCViewInformation(e.nEstelamId);
            }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnViewLoads_Click(object sender, EventArgs e)
        {
            try { UCViewerLoadCapacitorLoads.UCViewNotSedimentedLoadCapacitorLoads(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId); }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
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