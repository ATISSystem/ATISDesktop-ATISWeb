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

    }
}
