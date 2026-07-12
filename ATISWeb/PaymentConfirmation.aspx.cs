using R2Core.ConfigurationManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb
{
    public partial class PaymentConfirmation : System.Web.UI.Page
    {
        private string Authority;

        protected void Page_Load(object sender, EventArgs e)
        {
            Authority = Request.QueryString["Authority"];
            BtnPaymentConfirmation.Click += BtnPaymentConfirmation_Click;

        }

        private void BtnPaymentConfirmation_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();

                Response.Redirect(InstanceConfiguration.GetConfigString(R2CoreConfigurations.AqayepardakhtPaymentGate, 2) + Authority);

            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }

        }
    }
}
