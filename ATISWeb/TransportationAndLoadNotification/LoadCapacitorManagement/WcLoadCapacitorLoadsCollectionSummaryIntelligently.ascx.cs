using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using ATISWeb.LoginManagement.Exceptions;
using R2Core.PublicProc;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WcLoadCapacitorLoadsCollectionSummaryIntelligently : System.Web.UI.UserControl
    {

        #region "General Properties"

        public LoadCapacitorLoadsListType WcCurrentListType = LoadCapacitorLoadsListType.None;

        private string _UCCaption = string.Empty;
        public string UCCaption
        {
            get { return _UCCaption; }
            set
            {
                _UCCaption = value;
                LblCaption.Text = value;
            }
        }

        #endregion

        #region "Subroutins And Functions"

        public void WcViewInformation()
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                List<R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure> Lst = null;
                if (WcCurrentListType == LoadCapacitorLoadsListType.NotSedimented)
                {
                    LblCaption.Text = "لیست بار موجود";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetExistenceNonZeroLoads(InstanceLogin.GetNSSCurrentUser());
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.Sedimented)
                {
                    LblCaption.Text = "لیست بار رسوب شده";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetSedimentedLoadCapacitorLoads(InstanceLogin.GetNSSCurrentUser());
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.TommorowLoad)
                {
                    LblCaption.Text = "لیست بار فردا";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTommorowLoadCapacitorLoads(InstanceLogin.GetNSSCurrentUser());
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.None)
                {
                    LblCaption.Text = "لیست بار";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetAllLoadCapacitorLoads(InstanceLogin.GetNSSCurrentUser());
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.LastButNotTommorowLoad )
                {
                    LblCaption.Text = "لیست بار اعلام شده اخیر";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLastLoadCapacitorLoads(InstanceLogin.GetNSSCurrentUser());
                }

                DropDownListLoads.Items.Clear();
                DropDownListLoads.Items.Add("انتخاب کنید ...");
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    string Item = Lst[Loopx].nEstelamId + " # " + Lst[Loopx].GoodTitle + " " + Lst[Loopx].LoadTargetTitle+ " . " + Lst[Loopx].TransportCompanyTitle+ " . " + Lst[Loopx].UserName ;
                    DropDownListLoads.Items.Add(Item);
                }
            }
            catch (PleaseReloginException ex)
            { Response.Redirect("/LoginManagement/Wflogin.aspx"); }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        #endregion

        #region "Events"

        public class nEstelamIdEventArgs : EventArgs
        { public Int64 nEstelamId { get; set; } }

        public event EventHandler<nEstelamIdEventArgs> WcLoadCapacitorLoadSelectedEvent;

        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            { BtnRenew.ServerClick += BtnRenew_ServerClick; }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void BtnRenew_ServerClick(object sender, EventArgs e)
        {
            try
            {
                DropDownListLoads.Enabled = false; WcViewInformation();
                DropDownListLoads.Enabled = true;
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n" + ex.Message + "');", true); }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DropDownListLoads.SelectedIndex > 0)
                { WcLoadCapacitorLoadSelectedEvent?.Invoke(this, new nEstelamIdEventArgs() { nEstelamId = System.Convert.ToInt64(DropDownListLoads.SelectedItem.Text.Split('#')[0]) }); }
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