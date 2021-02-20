using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ATISWeb.MenuManagement
{

    public partial class WfMainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string DailyMessage = string.Empty;
                string DailyMessageColor = string.Empty;
                DailyMessage = PayanehClassLibrary.TransportCompanies.TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesDailyMessage(ref DailyMessageColor);
                string FixMessage = PayanehClassLibrary.TransportCompanies.TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesFirstPageMessages();
                string FixMessage1 = FixMessage.Split('-')[0].Trim();
                string FixMessage2 = FixMessage.Split('-')[1].Trim();
                string FixMessage3 = FixMessage.Split('-')[2].Trim();
                Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('" + DailyMessageColor + "','" + DailyMessage + "','" + FixMessage1 + "','" + FixMessage2 + "','" + FixMessage3 + "');", true);
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }
    }
}