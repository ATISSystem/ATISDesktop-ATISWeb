using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

using R2CoreTransportationAndLoadNotification.TruckDrivers;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.LoggingManagement;
using R2CoreParkingSystem.Drivers;
using R2Core.SoftwareUserManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreParkingSystem.Cars;
using PayanehClassLibrary.DriverTrucksManagement;

namespace ATISMobileRestful.Controllers.TruckDriverManagement
{
    public class TruckDriversController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetTruckDriver()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientTruckDriverRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanseTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                var TruckDriver = InstanseTruckDrivers.GetNSSTruckDriver(NSSSoftwareuser);
                var Item = new Models.TruckDriver();
                Item.NameFamily = TruckDriver.NSSDriver.StrPersonFullName;
                Item.FatherName = "فرزند: " + TruckDriver.NSSDriver.StrFatherName;
                Item.SmartCardNo = "شماره هوشمند: " + TruckDriver.StrSmartCardNo;
                Item.NationalCode = "کد ملی: " + TruckDriver.NSSDriver.StrNationalCode;
                Item.Tel = "تلفن: " + TruckDriver.NSSDriver.StrIdNo;
                Item.DrivingLicenceNo = "گواهینامه: " + TruckDriver.NSSDriver.strDrivingLicenceNo;
                Item.Address = "آدرس: " + TruckDriver.NSSDriver.StrAddress;
                Item.DriverId = "کد راننده: " + TruckDriver.NSSDriver.nIdPerson;

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(Item), Encoding.UTF8, "application/json");
                return response;
            }
            catch (TruckDriverNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByMobileNumberException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage TruckDriverInqueryWithLicensePlate()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith2Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientTruckDriverInqueryWithLicensePlate );

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];

                var InstanceTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(InstanceTruckDrivers.GetNSSTruckDriverWithLicensePlate(new R2CoreTransportationAndLoadNotificationStandardTruckStructure(new R2StandardCarStructure(null, null, LPPelak, LPSerial, null), null)).NSSDriver.StrPersonFullName), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }

        [HttpPost]
        public HttpResponseMessage SendTruckDriverChangeRequestMessage()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith3Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientSendTruckDriverChangeMessageRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];
                var TruckDriverNationalCode = Content.Split(';')[4];

                var InstanceDriverTrucks = new PayanehClassLibraryMClassDriverTrucksManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                InstanceDriverTrucks.SendTruckDriverChangeRequestMessage(InstanceTrucks.GetNSSTruckWithLicensePlate(new R2CoreTransportationAndLoadNotificationStandardTruckStructure(new R2StandardCarStructure(null, null, LPPelak, LPSerial, null), null)), TruckDriverNationalCode, NSSSoftwareuser);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }


    }
}
