
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ATISWeb.LoginManagement;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.FileShareRawGroupsManagement;
using R2Core.PublicProc;
using R2Core.SMS;


namespace ATISWeb.FilesManagement
{
    public partial class WCUploadFile : System.Web.UI.UserControl
    {

        R2DateTime _DateTime = new R2DateTime();

        protected void Page_Load(object sender, EventArgs e)
        {
            BtnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var InstanceLogin = new ATISWebMClassLoginManager();
                var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                if (!UpLoadFile.HasFile)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + "فایل مورد نظر را انتخاب نمایید" + "');", true);
                    return;
                }
                var myFileExit = false;
                if (InstancePublicProcedures.IsExistFile(R2CoreRawGroups.UploadedFiles, TxtFileName.Text.Trim(), InstanceLogin.GetNSSCurrentUser()))
                { myFileExit = true; }
                InstancePublicProcedures.SaveFile(R2CoreRawGroups.UploadedFiles, TxtFileName.Text.Trim(), UpLoadFile.FileBytes, InstanceLogin.GetNSSCurrentUser());
                if (myFileExit)
                { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "فایل با نام مورد نظر قبلا بارگذاری شده است و مجددا با موفقیت بارگذاری شد" + "');", true); }
                else
                { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('2','" + "فایل با موفقیت بارگذاری شد" + "');", true); }
                /*ارسال اس ام اس آپلود فایل به موبایل جنرال*/
                R2CoreSMSSendRecive SMSSender = new R2CoreSMSSendRecive();
                SMSSender.SendSms(new R2CoreStandardSMSStructure(Int64.MinValue, InstanceConfiguration.GetConfigString(R2CoreConfigurations.SmsSystemSetting, 1), "آپلود فایل", 1, _DateTime.GetCurrentDateTimeMilladi(), true, null, null));
            }
            catch (Exception ex)
            { Page.ClientScript.RegisterStartupScript(GetType(), "WcViewAlert", "WcViewAlert('1','" + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\\n " + ex.Message + "');", true); }

        }
    }
}