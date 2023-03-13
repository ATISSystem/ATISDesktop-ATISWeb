using R2CoreTransportationAndLoadNotification.BillOfLading.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb.TransportationAndLoadNotification.LoadAllocationManagement
{
    public partial class WCEntryBillOfLadingNumber : System.Web.UI.UserControl
    {
        #region "General Properties"

        private string _WcBillOfLadingNumber = string.Empty;
        public string WcBillOfLadingNumber
        {
            get
            {
                if (_WcBillOfLadingNumber == string.Empty)
                { throw new BillOfLadingBillOfLadingNumberDosnotEntryException(); }
                return _WcBillOfLadingNumber;
            }
            set { _WcBillOfLadingNumber = value; }
        }


        #endregion

        #region "Subroutins And Functions"

        public void WCRefreshGeneral()
        { TxtBillOfLadingNumber.Text = string.Empty; }

        #endregion

        #region "Events"
        #endregion

        #region "Event Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            { TxtBillOfLadingNumber.TextChanged += TxtBillOfLadingNumber_TextChanged; }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }

        private void TxtBillOfLadingNumber_TextChanged(object sender, EventArgs e)
        { WcBillOfLadingNumber = TxtBillOfLadingNumber.Text; }

        #endregion

        #region "Override Methods"
        #endregion

        #region "Abstract Methods"
        #endregion

        #region "Implemented Members"
        #endregion
    }
}