
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.WebProcessesManagement;

namespace ATISWeb.MenuManagement
{
    public partial class WcProcess : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {        }

        private R2StandardWebProcessStructure _WcCurrentNSS = null;

        public R2StandardWebProcessStructure WcCurrentNSS
        {
            get
            { return _WcCurrentNSS; }
            set
            {
                _WcCurrentNSS = value;
                LblProcessTitle.Text = WcCurrentNSS.PTitle.Trim() ;
                LblDescription.Text = WcCurrentNSS.Description.Trim() ;
                TargetURL.InnerText= WcCurrentNSS.PTitle.Trim() ;
                TargetURL.HRef = WcCurrentNSS.TargetWfProcess;
            }
        }

    }
}