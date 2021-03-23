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

namespace ATISMobileRestful.Controllers.TruckDriverManagement
{
    public class TruckDriversController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTruckDriver()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                var InstanseSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanseTruckDrivers = new R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager();
                var TruckDriver = InstanseTruckDrivers.GetNSSTruckDriver(InstanseSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
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
