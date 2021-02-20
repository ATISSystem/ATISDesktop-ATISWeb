using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using R2CoreTransportationAndLoadNotification.TruckDrivers;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.LoggingManagement;
using R2CoreParkingSystem.Drivers;
using R2Core.SoftwareUserManagement;

namespace ATISMobileRestful.Controllers
{
    public class TruckDriversController : ApiController
    {
        [HttpGet]
        public Models.TruckDriver GetTruckDriver(Int64 YourUserId)
        {
            var Item = new Models.TruckDriver();
            try
            {
                var TruckDriver = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId));
                Item.NameFamily = TruckDriver.NSSDriver.StrPersonFullName;
                Item.FatherName = "فرزند: " + TruckDriver.NSSDriver.StrFatherName;
                Item.SmartCardNo = "شماره هوشمند: " + TruckDriver.StrSmartCardNo;
                Item.NationalCode = "کد ملی: " + TruckDriver.NSSDriver.StrNationalCode;
                Item.Tel = "تلفن: " + TruckDriver.NSSDriver.StrIdNo;
                Item.DrivingLicenceNo = "گواهینامه: " + TruckDriver.NSSDriver.strDrivingLicenceNo;
                Item.Address = "آدرس: " + TruckDriver.NSSDriver.StrAddress;
                Item.DriverId = "کد راننده: " + TruckDriver.NSSDriver.nIdPerson;
                //Item.DriverImage = R2CoreParkingSystemMClassDrivers.GetDriverImage(R2CoreParkingSystem.Drivers.R2CoreParkingSystemMClassDrivers.GetNSSDriver(TruckDriver.NSSDriver.nIdPerson)).GetImage();
                return Item;
            }
            catch (Exception ex)
            { return Item; }
        }

    }
}
