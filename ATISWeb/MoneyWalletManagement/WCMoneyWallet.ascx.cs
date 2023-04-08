
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;

using R2CoreParkingSystem.TrafficCardsManagement;


namespace ATISWeb.MoneyWalletManagement
{
    public partial class WCMoneyWallet : System.Web.UI.UserControl
    {

        #region "General Properties"
        private R2CoreParkingSystemStandardTrafficCardStructure _WCCurrentNSS = null;
        public R2CoreParkingSystemStandardTrafficCardStructure WCCurrentNSS
        {
            get { return _WCCurrentNSS; }
            set
            {
                _WCCurrentNSS = value;
                WCCurrentNSSChangedEvent?.Invoke(this, new EventArgs());
            }
        }
        #endregion

        #region "Subroutins And Functions"
        #endregion

        #region "Events"
        public event EventHandler WCCurrentNSSChangedEvent;
        #endregion

        #region "Event Handlers"
        protected void Page_Load(object sender, EventArgs e)
        {

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