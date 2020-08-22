using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using R2Core.UserManagement;

namespace R2WebPrimaryTest.UserControls
{
    public partial class UCLogin : System.Web.UI.UserControl
    {
        public event EventHandler UCUserAuthenticationSuccessEvent;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                R2CoreStandardUserStructure NSS = R2CoreMClassLoginManagement.GetNSSUser(TxtUserShenaseh.Text, TxtUserPassword.Text);
                R2CoreMClassLoginManagement.SetCurrentUserbyShenasehPassword(new R2CoreStandardUserStructure(0, "", TxtUserShenaseh.Text, TxtUserPassword.Text, "", false, false));
                UCUserAuthenticationSuccessEvent?.Invoke(this,e);
            }
            catch (Exception ex)
            {
                LblMessage.Text = ex.Message;
                //Guid guidKey = Guid.NewGuid();
                //Page pg = (Page)HttpContext.Current.Handler;
                //string strScript = "alert('" + ex.Message + "');";
                //pg.ClientScript.RegisterStartupScript(pg.GetType(), guidKey.ToString(), strScript, true);
            }
        }
    }
}