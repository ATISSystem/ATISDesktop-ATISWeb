using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


namespace R2WebPrimaryTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnLoadAllocationLoadPermission.Click += BtnLoadAllocationLoadPermission_ClickHandler;
            BtnLoadRegistering.Click += BtnLoadRegistering_ClickHandler;
        }

        private void BtnLoadRegistering_ClickHandler(object sender, EventArgs e)
        { Response.Redirect("LoadCapacitorLoadManipulation.aspx"); }

        private void BtnLoadAllocationLoadPermission_ClickHandler(object sender, EventArgs e)
        { Response.Redirect("LoadCapacitorLoadLoadAllocationLoadPermission.aspx"); }

      



    }
}