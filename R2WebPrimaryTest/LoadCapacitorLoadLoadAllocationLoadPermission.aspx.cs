using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2CoreTransportationAndLoadNotification.TransportCompanies;
using PayanehClassLibrary.LoadNotification.LoadPermission;


namespace R2WebPrimaryTest
{
    public partial class LoadCapacitorLoadLoadAllocationLoadPermission : System.Web.UI.Page
    {
        #region "General Properties"

        public struct PermissionPrintingDataStructure
        {
            public string TurnId;
            public string nEstelamId;
            public string StrExitDate;
            public string StrExitTime;
            public string CompanyName;
            public string CarTruckLoaderTypeName;
            public string pelak;
            public string Serial;
            public string DriverTruckFullNameFamily;
            public string DriverTruckDrivingLicenseNo;
            public string ProductName;
            public string TargetCityName;
            public string StrPriceSug;
            public string StrDescription;
            public string PermissionUserName;
            public string OtherNote;
        }

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
                    BtnViewLoads.Click += BtnViewLoads_ClickHandler;
                    UCViewerLoadCapacitorLoads.UCLoadCapacitorLoadSelectedEvent += UCViewerLoadCapacitorLoads_UCLoadCapacitorLoadSelectedEventHandler;
                    BtnLoadAllocationLoadPermission.Click += BtnLoadAllocationLoadPermission_Click;
                    BtnRepeatPrint.Click += BtnRepeatPrint_Click;
                    R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure NSSTransportCompany = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS);
                    TransportCompanyTitle.Text = "شرکت حمل و نقل " + NSSTransportCompany.TCTitle;
                    UCViewerLoadCapacitorLoads.UCViewSedimentedLoadCapacitorLoads(NSSTransportCompany.TCId);
                    UCViewerLoadCapacitorLoads.UCCaption = "لیست بار رسوب شده";
                    LblMessage.Text = string.Empty;
                
               
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }

        }

        public PermissionPrintingDataStructure PPDS = new PermissionPrintingDataStructure();
        protected void BtnRepeatPrint_Click(object sender, EventArgs e)
        {
            try
            { }
            catch (Exception ex)
            { Response.Write("<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void BtnLoadAllocationLoadPermission_Click(object sender, EventArgs e)
        {
            try
            { LoadNotificationLoadPermissionManagement.CarTruckRelationDriverTruck(UCSmartCardsInquiry.UCGetTruckSmartCardNo(), UCSmartCardsInquiry.UCGetTruckDriverSmartCardNo()); }
            catch (Exception ex) {; }

            try
            {
                BtnLoadAllocationLoadPermission.Enabled = false;
                Int64 myCompanyCode = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId;
                Int64 mynEstelamId = UCViewerNSSLoadCapacitorLoad.UCGetNSSCurrent.nEstelamId;
                LoadNotificationLoadPermissionManagement.CarTruckRelationDriverTruck(UCSmartCardsInquiry.UCGetTruckSmartCardNo(), UCSmartCardsInquiry.UCGetTruckDriverSmartCardNo());
                Int64 myTurnId = LoadNotificationLoadPermissionManagement.TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(myCompanyCode, mynEstelamId, UCSmartCardsInquiry.UCGetTruckSmartCardNo(), UCSmartCardsInquiry.UCGetTruckDriverSmartCardNo());
                PermissionPrinting.GetInformationforRemotePermissionPrinting(mynEstelamId, myTurnId, ref PPDS.StrExitDate, ref PPDS.StrExitTime, ref PPDS.nEstelamId, ref PPDS.TurnId, ref PPDS.CompanyName, ref PPDS.CarTruckLoaderTypeName, ref PPDS.pelak, ref PPDS.Serial, ref PPDS.DriverTruckFullNameFamily, ref PPDS.DriverTruckDrivingLicenseNo, ref PPDS.ProductName, ref PPDS.TargetCityName, ref PPDS.StrPriceSug, ref PPDS.StrDescription, ref PPDS.PermissionUserName, ref PPDS.OtherNote);
                PPDS.TurnId = myTurnId.ToString();
                PPDS.nEstelamId = mynEstelamId.ToString();
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }

        }

        private void UCViewerLoadCapacitorLoads_UCLoadCapacitorLoadSelectedEventHandler(object sender, UserControls.UCViewerLoadCapacitorLoads.nEstelamIdEventArgs e)
        {
            try
            {
                BtnLoadAllocationLoadPermission.Enabled = true;
                UCViewerNSSLoadCapacitorLoad.Visible = true;
                UCViewerNSSLoadCapacitorLoad.UCViewNSSLoadCapacitorLoad(e.nEstelamId);
            }
            catch (Exception ex)
            { LblMessage.Text = ex.Message; }
        }

        protected void BtnViewLoads_ClickHandler(object sender, EventArgs e)
        { UCViewerLoadCapacitorLoads.UCViewSedimentedLoadCapacitorLoads(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2Core.UserManagement.R2CoreMClassLoginManagement.CurrentUserNSS).TCId); }

        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion

    }
}