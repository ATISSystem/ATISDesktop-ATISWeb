

using MSCOCore.AnnouncementProcess;
using PayanehClassLibrary.CarTruckNobatManagement;
using R2Core.LoggingManagement;
using R2Core.SecurityAlgorithmsManagement.Captcha;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.DriverSelfDeclaration;
using R2CoreTransportationAndLoadNotification.LoadAllocation;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadPermission;
using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreTransportationAndLoadNotification.Turns.SequentialTurns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZibalGateway;
using Newtonsoft.Json;
using ESCOCore.Exceptions;
using ESCOCore.SMS;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2CoreParkingSystem.MoneyWalletChargeManagement;
using R2CoreTransportationAndLoadNotification.TerraficCardsManagement;
using R2Core.MoneyWallet.PaymentRequests;

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
            try
            {
                try
                {
                    var _R2DateTime = new R2DateTime();
                    var InstancePaymentRequests = new R2CoreInstansePaymentRequestsManager();
                    var NSSPaymentRequest = InstancePaymentRequests.GetNSSPayment(164477);
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var NSSSoftwareUser = InstanceSoftwareUsers.GetNSSUser(NSSPaymentRequest.SoftwareUserId);
                    var InstanceTrafficCards = new R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager();
                    var InstanceMoneyWalletCharge = new R2CoreParkingSystemInstanceMoneyWalletChargeManager();
                    var NSSTrafficCard = InstanceTrafficCards.GetNSSTerafficCard(NSSSoftwareUser);

                    InstanceMoneyWalletCharge.SabtCharge(new R2StandardMoneyWalletChargeStructure(NSSTrafficCard, NSSPaymentRequest.Amount, 157, "", _R2DateTime.GetCurrentDateTimeMilladi(), _R2DateTime.GetCurrentDateShamsiFull(), NSSPaymentRequest.Amount + 100, 0, _R2DateTime.GetCurrentTime()));

                    //var InstanceAES = new AESAlgorithmsManager();
                    //var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    //var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                    //var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                    //var AMUStatus = InstanceAES.Encrypt("b94248ec3c7ef10669adbe67ee194a03ac47f74e88186fd6fbdd129880c1", InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                    //+ ";" + InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));

                    //var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                    //var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();

                    //var NSSSoftwareuser = InstanceSoftwareUser.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile("09138361912"));
                    //InstanceSoftwareusers.LoginSoftwareUser(NSSSoftwareuser.MobileNumber);
                }
                catch (ESCOCoreSendSMSFailedException ex)
                { EventLog.WriteEntry("ESCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }
                catch (Exception ex)
                { EventLog.WriteEntry("ESCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

                //var InstanceSoftwareUsers = new R2Core.SoftwareUserManagement.R2CoreInstanseSoftwareUsersManager();

                //var NSSSoftwareuser = InstanceSoftwareUsers.GetNSSUser(21);
                //var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                //var InstanceDriverSelfDeclaration = new R2CoreTransportationAndLoadNotificationInstanceDriverSelfDeclarationManager();
                //var NSSTruck = InstanceTrucks.GetNSSTruck(NSSSoftwareuser);
                //var Lst = InstanceDriverSelfDeclaration.GetDeclarations(NSSTruck, false);
                //var x = 2;
                //try
                //{
                //    var InstanceLogging = new R2CoreInstanceLoggingManager();
                //    //ارسال ایمیل شرکت ها 
                //    try
                //    {
                //        var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                //        var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                //        InstanceAnnouncementforTransportCompanies.SentEmailforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                //    }

                //    catch (Exception ex)
                //    { EventLog.WriteEntry("MSCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }

                //    //اعلام بار خودکار شرکت ها
                //    try
                //    {
                //        var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                //        var InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                //        InstanceAnnouncementforTransportCompanies.LoadsAnnouncementforTransportCompanies(InstanceSoftwareUsers.GetNSSSystemUser());
                //    }
                //    catch (Exception ex)
                //    { EventLog.WriteEntry("MSCOAutomatedJobs", ":" + ex.Message.ToString(), EventLogEntryType.Error); }
                //}
                //catch (Exception ex)
                //{ EventLog.WriteEntry("MSCOAutomatedJobs", "_AutomatedJobsTimer_Elapsed:" + ex.Message.ToString(), EventLogEntryType.Error); }


                //var X = new ESCOCore.SendSMS.ESCOCoreSendSMSManager();
                //var Instance = new R2Core.SoftwareUserManagement.R2CoreInstanseSoftwareUsersManager();
                //X.SendSMSofAnnouncedLoads(Instance.GetNSSSystemUser());
                //MSCOCoreAnnouncementforTransportCompaniesManager InstanceAnnouncementforTransportCompanies = new MSCOCoreAnnouncementforTransportCompaniesManager();
                //InstanceAnnouncementforTransportCompanies.LoadsAnnouncementforTransportCompanies(R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());

                //var InstanceSequentialTrun = new R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager();
                //PayanehClassLibraryMClassCarTruckNobatManagement.TurnsCancellation("9:943623", InstanceSequentialTrun.GetNSSSequentialTurn(2), "1400");

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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string url = "https://gateway.zibal.ir/v1/request"; // url
            //    Zibal.makeRequest Request = new Zibal.makeRequest(); // define Request
            //    Request.merchant = "zibal"; // String
            //    Request.orderId = "1000"; // String
            //    Request.amount = 1000; //Integer
            //    Request.callbackUrl = "http://callback.com/api"; //String
            //    Request.description = "Hello Zibal !"; // String
            //    var httpResponse = Zibal.HttpRequestToZibal(url, JsonConvert.SerializeObject(Request));  // get Response
            //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) // make stream reader
            //    {
            //        var responseText = streamReader.ReadToEnd(); // read Response
            //        Zibal.makeRequest_response item = JsonConvert.DeserializeObject<Zibal.makeRequest_response>(responseText); // Deserilize as response class object
            //        // you can access track id with item.trackId , result with item.result and message with item.message
            //        // in asp.net you can use Response.Redirect("https://gateway.zibal.ir/start/item.trackId"); for start gateway and redirect to third-party gateway page
            //        // also you can use Response.Redirect("https://gateway.zibal.ir/start/item.trackId/direct"); for start gateway page directly
            //    }
            //}
            //catch (WebException ex)
            //{
            //    Console.WriteLine(ex.Message); // print exception error
            //}

        }


    }


}
