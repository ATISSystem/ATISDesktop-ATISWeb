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

namespace ATISMobileRestful.Controllers.TruckManagement
{
    public class TrucksController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTruck()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                var InstanseSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var Truck = InstanceTrucks.GetNSSTruck(InstanseSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
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
            { return WebAPi.CreateContentMessage(ex); }
            catch (AnnouncementHallSubGroupRelationTruckNotExistException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (GetNSSException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (TruckNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
