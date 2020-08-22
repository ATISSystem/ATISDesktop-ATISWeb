using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.PublicProc;
using R2Core.UserManagement;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportCompanies;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WcLoadCapacitorLoadsCollectionSummaryIntelligently : System.Web.UI.UserControl
    {

        #region "General Properties"

        public LoadCapacitorLoadsListType WcCurrentListType = LoadCapacitorLoadsListType.NotSedimented;

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
                var TCId = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompnay(R2CoreMClassLoginManagement.CurrentUserNSS).TCId;
                List<R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure> Lst = null;
                if (WcCurrentListType == LoadCapacitorLoadsListType.NotSedimented)
                {
                    LblCaption.Text = "لیست بار موجود";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNotSedimentedLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.Sedimented)
                {
                    LblCaption.Text = "لیست بار رسوب شده";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetSedimentedLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.TommorowLoad)
                {
                    LblCaption.Text = "لیست بار فردا";
                    Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTommorowLoadCapacitorLoads(TCId);
                }
                else if (WcCurrentListType == LoadCapacitorLoadsListType.None)
                { throw new Exception("نوع لیست بار صحیح نیست"); }

                DropDownListLoads.Items.Clear();
                DropDownListLoads.Items.Add("انتخاب کنید ...");
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    string Item = Lst[Loopx].nEstelamId + " # " + Lst[Loopx].GoodTitle + " " + Lst[Loopx].LoadTargetTitle;
                    DropDownListLoads.Items.Add(Item);
                }
            }
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
            {
                BtnRenew.ServerClick += BtnRenew_ServerClick;
            }
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