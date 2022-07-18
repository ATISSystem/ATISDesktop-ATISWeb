using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using R2CoreTransportationAndLoadNotification.LoadPermission.LoadPermissionPrinting;
using ATISWeb.TransportationAndLoadNotification.LoadPermissionManagement.LoadPermissionPrinting;
using PayanehClassLibrary.CarTruckNobatManagement;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.Turns.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadAllocation;
using R2CoreTransportationAndLoadNotification.RequesterManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions;
using R2Core.ExceptionManagement;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.EnterExitManagement;
using R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions;
using R2CoreTransportationAndLoadNotification.TransportCompanies.Exceptions;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions;
using R2CoreTransportationAndLoadNotification.Trucks.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions;
using PayanehClassLibrary.CarTruckNobatManagement.Exceptions;
using R2Core.MoneyWallet.Exceptions;

namespace ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement
{
    public partial class WcLoadCapacitorLoadLoadAllocationLoadPermissionIssue : System.Web.UI.UserControl
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
                WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcCurrentListType = LoadCapacitorLoadsListType.Sedimented;
                WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcLoadCapacitorLoadSelectedEvent += WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent;
                if (!IsPostBack)
                { WcLoadCapacitorLoadsCollectionSummaryIntelligently.WcViewInformation(); }
                BtnLoadAllocation.Click += BtnLoadAllocation_Click;
                BtnNewLoadAllocation.Click += BtnNewLoadAllocation_Click;
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnNewLoadAllocation_Click(object sender, EventArgs e)
        {
            BtnLoadAllocation.Enabled = true;
            WcSmartCardsInquiry.WcRefreshInformation();
            LblTurnStatus.Text = String.Empty;
            LblTurnStatus.ForeColor = System.Drawing.Color.White;
            PnlTurnStatus.BackColor = System.Drawing.Color.Transparent;
        }

        private void WcLoadCapacitorLoadsCollectionSummaryIntelligently_WcLoadCapacitorLoadSelectedEvent(object sender, WcLoadCapacitorLoadsCollectionSummaryIntelligently.nEstelamIdEventArgs e)
        {
            try
            { WcViewerNSSLoadCapacitorLoad.WcViewNSS(e.nEstelamId); }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnLoadAllocation_Click(object sender, EventArgs e)
        {
            R2CoreTransportationAndLoadNotificationStandardTurnStructure NSSTurn = null;
            var InstanceCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();
            var InstanceLogin = new ATISWebMClassLoginManager();
            try
            {
                BtnLoadAllocation.Enabled = false;
                var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                var NSSTruck = WcSmartCardsInquiry.WcGetNSSTruck;
                var NSSTruckDriver = WcSmartCardsInquiry.WcGetNSSTruckDriver;
                var NSSTransportCompany = InstanceTransportCompanies.GetNSSTransportCompnay(InstanceLogin.GetNSSCurrentUser());
                var NSSLoadCapacitorLoad = WcViewerNSSLoadCapacitorLoad.WcGetNSSCurrent;

                //به دست آوردن نوبت موجود ناوگان و یا این که در صورت عدم وجود نوبت باید روابط موقت ایجاد گردد و نوبت صادر گردد
                //در این جا از کیف پول شرکت حمل و نقل استفاده شده است
                //سه رابطه ایجاد می گردد ناوگان-راننده و ناوگان-زیرگروه اعلام بار و ناوگان-کیف پول
                var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                var TempTurnReport = string.Empty;
                try
                {
                    NSSTurn = InstanceTurns.GetNSSTurn(NSSTruck);
                    TempTurnReport = "ناوگان نوبت دارد.برای تخصیص بار از نوبت موجود استفاده شد ";
                    PnlTurnStatus.BackColor = System.Drawing.Color.Green;
                }
                catch (TurnNotFoundException ex)
                {
                    NSSTurn = InstanceTurns.GetNSSTurn(InstanceCarTruckNobat.GetTurnofKiosk(NSSTruck, NSSTruckDriver, NSSTransportCompany, NSSLoadCapacitorLoad, InstanceLogin.GetNSSCurrentUser()));
                    TempTurnReport = "ناوگان نوبت ندارد.نوبت به صورت خودکار در سامانه صادر شد ";
                    PnlTurnStatus.BackColor = System.Drawing.Color.Red;
                }
                //تخصیص بار - آزاد سازی بار به صورت خودکار توسط سرور انجام می گردد
                //مشاهده و چاپ مجوز از طریق قسمت مجوزهای صادر شده در بارهای رسوبی قابل مشاهده است
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.LoadAllocationRegistering(NSSLoadCapacitorLoad.nEstelamId, NSSTurn, InstanceLogin.GetNSSCurrentUser(), R2CoreTransportationAndLoadNotificationRequesters.WcLoadCapacitorLoadAllocationLoadPermissionIssue,false ,true );
                LblTurnStatus.Text = TempTurnReport;
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','تخصیص بار با موفقیت انجام شد');", true);
            }
            catch (Exception ex) when (ex is SoftwareUserMoneyWalletNotFoundException ||
                                       ex is MoneyWalletCurrentChargeNotEnoughException ||
                                       ex is TurnRegisterRequestTypeNotFoundException ||
                                       ex is CarIsNotPresentInParkingException ||
                                       ex is SequentialTurnIsNotActiveException ||
                                       ex is TurnPrintingInfNotFoundException ||
                                       ex is GetNobatExceptionCarTruckIsTankTreiler ||
                                       ex is CarTruckTravelLengthNotOverYetException ||
                                       ex is GetNobatExceptionCarTruckHasNobat ||
                                       ex is GetNobatException ||
                                       ex is GetNSSException ||
                                       ex is TruckRelatedSequentialTurnNotFoundException ||
                                       ex is TransportCompanyNotFoundException ||
                                       ex is LoadCapacitorLoadNotFoundException ||
                                       ex is DataEntryException ||
                                       ex is AnnouncementHallSubGroupUnActiveException ||
                                       ex is AnnouncementHallSubGroupRelationTruckNotExistException ||
                                       ex is AnnouncementHallSubGroupNotFoundException ||
                                       ex is LoadAllocationRegisteringReachedEndTimeException ||
                                       ex is LoadAllocationMaximumAllowedNumberReachedException ||
                                       ex is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException ||
                                       ex is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException ||
                                       ex is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException ||
                                       ex is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException ||
                                       ex is LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException ||
                                       ex is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException ||
                                       ex is RegisteredLoadAllocationIsRepetitiousException ||
                                       ex is RequesterHasNotPermissionforLoadAllocationRegisteringException ||
                                       ex is LoadAllocationNotAllowedBecauseCarHasBlackListException ||
                                       ex is TimingNotReachedException ||
                                       ex is TurnNotFoundException ||
                                       ex is TruckNotFoundException ||
                                       ex is TurnHandlingNotAllowedBecuaseTurnStatusException ||
                                       ex is UnableAllocatingTommorowLoadException ||
                                       ex is RequesterNotAllowTurnIssueBySeqTException ||
                                       ex is RequesterNotAllowTurnIssueByLastLoadPermissionedException ||
                                       ex is LoadCapacitorLoadNotFoundException)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + ex.Message.Replace("\r\n", " ") + "');", true); }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
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