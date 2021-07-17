using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb
{
    public partial class DomainSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        { BtnExit.ServerClick += BtnExit_ServerClick; }

        private void BtnExit_ServerClick(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("/LoginManagement/Wflogin.aspx");
        }
    }
}