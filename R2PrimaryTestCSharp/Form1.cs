using R2Core.SecurityAlgorithmsManagement.Captcha;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.LoadAllocation;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadPermission;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2PrimaryTestCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class PermissionsIssued
        { public string ReportItem { get; set; } }

        private void Button1_Click(object sender, EventArgs e)
        {
            var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
            var NSSSoftwareuser = InstanceSoftwareUsers.GetNSSUser(new R2CoreSoftwareUserMobile("09130843148"));
            var InstanceAES = new AESAlgorithmsManager();

            System.Net.ServicePointManager.Expect100Continue = false;
            ServiceReference.PaymentGatewayImplementationServicePortTypeClient zp = new ServiceReference.PaymentGatewayImplementationServicePortTypeClient();
            string Authority;
            int Status = zp.PaymentRequest("aed16bb9-485a-416d-9891-d0b8d2bc98cc", 1, "درخواست پرداخت-زرین پال-آتیس", String.Empty, String.Empty, "https://ATISMobile.ir:8083/MoneyWalletChargingMVC/PaymentVerification/?YourAPIKey=" + InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3)) + "&YourAmount=1", out Authority);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            if (Status == 100)
            { response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = false, Message1 = Authority, Message2 = "https://www.zarinpal.com/pg/StartPay/", Message3 = string.Empty }), Encoding.UTF8, "application/json"); }
            else
            { response.Content = new StringContent(JsonConvert.SerializeObject(new MessageStruct { ErrorCode = true, Message1 = "Error : " + Status.ToString(), Message2 = string.Empty, Message3 = string.Empty }), Encoding.UTF8, "application.json"); }
            return response;

            //var listOfStrings = new string[] { "as", "AS" };
            //var myString = "AsDFG";
            //bool b = listOfStrings.Any(s => myString.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0);
            //listOfStrings.Any(s => s.Equals(myString, StringComparison.OrdinalIgnoreCase));

            //var InstanceCaptcha = new R2CoreInstanceCaptchaManager();
            //var FakeWord = InstanceCaptcha.GenerateFakeWordNumeric(5);
            //var CaptchaImage = InstanceCaptcha.GenerateCaptcha(FakeWord);
            //pictureBox1.Image = CaptchaImage;
            //  var InstanceReport = new R2CoreTransportationAndLoadNotificationInstanceLoadPermissionManager();
            //var Lst=  InstanceReport.ReportingInformationProviderLoadPermissionsIssuedOrderByPriorityReport(7);
            //  List<PermissionsIssued> _PermissionsIssued = new List<PermissionsIssued>();
            //  for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
            //  {
            //      var Item = new PermissionsIssued();
            //      //Item.ReportItem = Lst[Loopx];
            //      _PermissionsIssued.Add(Item);
            //  }

            //var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
            //var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();

            //var Lst = InstanceLoadAllocation.GetLoadAllocationsforTruckDriver(InstanceSoftwareUsers.GetNSSUser("50299aa592ccef6eaa8b603bc587192e").UserId);


            //var InstanceLoadCapacitorLoad = new  R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();

            //var Lst = InstanceLoadCapacitorLoad.GetLoadCapacitorLoads(Convert.ToInt64("2"), Convert.ToInt64("7"), 4, false, true, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince, Int64.MinValue, Convert.ToInt64("11"));

            //StringBuilder hash = new StringBuilder();
            //MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            //byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes("0D992C8C-3F8A-428A-8638-25B94D04BEA7" + ":" + DateTime.Now.Day));
            //for (int i = 0; i < bytes.Length; i++)
            //{ hash.Append(bytes[i].ToString("x2")); }
            //var x = hash.ToString();

        }
    }


}
