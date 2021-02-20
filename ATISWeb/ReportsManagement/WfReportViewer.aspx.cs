using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Security.Principal;
using System.Net;


namespace ATISWeb.ReportsManagement
{
    public partial class WfReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string id = Request.QueryString["id"];

                rvSiteMapping.Visible = true;
                rvSiteMapping.Height = Unit.Pixel(200);
                rvSiteMapping.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;

                rvSiteMapping.ServerReport.ReportServerUrl = new Uri("http://37.255.209.4:1352/ReportSERVER");
                rvSiteMapping.ServerReport.ReportPath = "/Payaneh Reports/UsersChargeReport";
                rvSiteMapping.ServerReport.ReportServerCredentials = new ReportServerCredentials("administrator", "Biinfo878aB", "domain");

                rvSiteMapping.ServerReport.Refresh();
            }

        }
    }

    [Serializable]
    public class ReportServerCredentials : IReportServerCredentials
    {
        private string reportServerUserName;
        private string reportServerPassword;
        private string reportServerDomain;

        public ReportServerCredentials(string userName, string password, string domain)
        { reportServerUserName = userName; reportServerPassword = password; reportServerDomain = domain; }
        public WindowsIdentity ImpersonationUser
        { get { return null; } }

        public ICredentials NetworkCredentials
        { get { return new NetworkCredential(reportServerUserName, reportServerPassword, reportServerDomain); } }
        public void New(string userName, string password, string domain)
        { reportServerUserName = userName; reportServerPassword = password; reportServerDomain = domain; }

        public bool GetFormsCredentials(out Cookie authCookie, out string user, out string password, out string authority)
        { authCookie = null; user = null; password = null; authority = null; return false; }
    }

}