
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.DateAndTimeManagement;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.TransportTarrifsParameters;
using R2CoreTransportationAndLoadNotification.TransportTarrifsParameters.Exceptions;

namespace ATISWeb.TransportationAndLoadNotification.LoadCapacitorManagement
{
    public partial class WCTransportTarrifsParameters : System.Web.UI.UserControl
    {

        #region "General Properties"



        #endregion

        #region "Subroutins And Functions"

        public void WcViewInformation(R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure YourNSS)
        {
            try
            {
                ChkboxlistTPTParams.Items.Clear();
                var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                TxtLoaderType.Text = InstanceAnnouncementHalls.GetNSSAnnouncementHallSubGroup(YourNSS.AHSGId).AHSGTitle;
                var InstanceTransportTarrifsParameters = new R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager();
                var Lst = InstanceTransportTarrifsParameters.GetListofTransportTarrifsParams(YourNSS.TPTParams);
                //if (Lst.Count == 0) { this.Visible = false; } else { this.Visible = true; }
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    ListItem Li = new ListItem(Lst[Loopx].TPTPTitle + " - " + (Lst[Loopx].Mblgh == 0 ? "توافقی" : Lst[Loopx].Mblgh.ToString()), Lst[Loopx].TPTPDId.ToString());
                    Li.Selected = Lst[Loopx].Checked;
                    Li.Attributes.Add("class", "btn-check");
                    ChkboxlistTPTParams.Items.Add(Li);
                }
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        public void WcViewInformation(R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure YourNSS)
        {
            try
            {
                TxtLoaderType.Text = YourNSS.AHSGTitle;
                ChkboxlistTPTParams.Items.Clear();
                var InstanceTransportTarrifsParameters = new R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager();
                var Lst = InstanceTransportTarrifsParameters.GetListofTransportTarrifsParams(YourNSS);
                //this.Visible = true;
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    ListItem Li = new ListItem(Lst[Loopx].TPTPTitle + " - " + (Lst[Loopx].Mblgh == 0 ? "توافقی" : Lst[Loopx].Mblgh.ToString()), Lst[Loopx].TPTPDId.ToString());
                    Li.Selected = Lst[Loopx].Checked;
                    Li.Attributes.Add("class", "btn-check");
                    ChkboxlistTPTParams.Items.Add(Li);
                }
            }
            catch (TransportPriceTarrifParameterDetailsforAHSGNotFoundException ex)
            { /*this.Visible = false; return;*/ }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }

        }

        public String WCGetTPTParams()
        {
            string TPTParamsDetails = string.Empty;
            foreach (ListItem Li in ChkboxlistTPTParams.Items)
            { TPTParamsDetails += Li.Value + ":" + ((Li.Selected) ? "1" : "0") + ";"; }
            if (TPTParamsDetails == string.Empty) { return string.Empty; }
            return TPTParamsDetails.Substring(0, TPTParamsDetails.Length - 1);
        }

        public void WcRefreshInformation()
        {
            try
            {
                ChkboxlistTPTParams.Items.Clear();
                TxtLoaderType.Text = string.Empty;
            }
            catch (Exception ex)
            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
        }

        #endregion

        #region "Events"

        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            { }
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