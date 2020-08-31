using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATISWeb.ATISStartManagement
{
    public partial class WfATISStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { DownloadATISMobile.Click += DownloadATISMobile_Click; }

        private void DownloadATISMobile_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileStream fs = null;
                fs = System.IO.File.Open(HttpContext.Current.Server.MapPath("~/App_Data/ATISMobile.APK"), FileMode.Open);
                byte[] btFile = new byte[fs.Length];
                fs.Read(btFile, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                Response.Buffer = true;
                Response.Expires = 0;
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Type", "application/octet-stream");
                //Response.AddHeader("Content-Length", btFile.Length.ToString);
                Response.AddHeader("Content-Disposition", "attachment;filename=ATISMobile.apk");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(btFile);
                Response.End();
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message + "');", true); }
        }
    }
}