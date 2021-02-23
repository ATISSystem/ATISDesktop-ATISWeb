using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.LoggingManagement;

namespace ATISMobileRestful.Controllers
{
    public class TrucksController : ApiController
    {
        [HttpGet]
        public Models.Truck GetTruck(Int64 YourUserId)
        {
            var Item = new Models.Truck();
            try
            {
                var Truck = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId));
                Item.TruckId  = "کد ناوگان: "+Truck.NSSCar.nIdCar ;
                Item.LPString = "ناوگان: " + Truck.NSSCar.GetCarPelakSerialComposit();
                Item.LoaderTitle = "بارگیر: " + Truck.NSSCar.snCarType;
                Item.SmartCardNo = "هوشمند: " + Truck.SmartCardNo;
                Item.AnnouncementHallSubGroups="گروه های مجاز بار : "+string.Join(",",R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetAnnouncementHallSubGroupsTitle(Truck));
                return Item;
            }
            catch (Exception ex)
            { return Item; }
        }

    }
}
