using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using Newtonsoft.Json;

using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.LoggingManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement;
using R2CoreParkingSystem.Cars;
using PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls;
using R2CoreTransportationAndLoadNotification.Trucks.Exceptions;
using R2Core.ExceptionManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using PayanehClassLibrary.CarTrucksManagement;

namespace ATISMobileRestful.Controllers.TruckManagement
{
    public class TrucksController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetTruck()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientTruckRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var Truck = InstanceTrucks.GetNSSTruck(NSSSoftwareuser);
                var Item = new Models.Truck();
                Item.TruckId = "کد ناوگان: " + Truck.NSSCar.nIdCar;
                Item.LPString = "ناوگان: " + Truck.NSSCar.GetCarPelakSerialComposit();
                Item.LoaderTitle = "بارگیر: " + Truck.NSSCar.snCarType;
                Item.SmartCardNo = "هوشمند: " + Truck.SmartCardNo;
                Item.AnnouncementHallSubGroups = "گروه های مجاز بار : " + string.Join(",", InstanceTrucks.GetAnnouncementHallSubGroupsTitle(Truck));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(Item), Encoding.UTF8, "application/json");
                return response;
            }
            catch (AnnouncementHallSubGroupNotFoundException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (AnnouncementHallSubGroupRelationTruckNotExistException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (GetNSSException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (TruckNotFoundException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (UserNotExistByMobileNumberException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage SendTruckChangeRequestMessage()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith3Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientSendTruckChangeMessageRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];
                var NewTruckLicensePlate = Content.Split(';')[4];

                var InstanceCarTrucks = new PayanehClassLibraryMClassCarTrucksManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                InstanceCarTrucks.SendTruckChangeRequestMessage(InstanceTrucks.GetNSSTruckWithLicensePlate(new R2CoreTransportationAndLoadNotificationStandardTruckStructure(new R2StandardCarStructure(null, null, LPPelak, LPSerial, null), null)),NewTruckLicensePlate , NSSSoftwareuser);

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
