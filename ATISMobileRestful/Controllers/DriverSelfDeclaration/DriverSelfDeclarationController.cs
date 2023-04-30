
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

using R2CoreTransportationAndLoadNotification.Trucks;
using ATISMobileRestful.Logging;
using R2CoreTransportationAndLoadNotification.DriverSelfDeclaration;
using System.Text;
using R2Core.ExceptionManagement;
using R2CoreTransportationAndLoadNotification.Trucks.Exceptions;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SoftwareUserManagement;
using R2Core.ConfigurationManagement;
using R2Core.SoftwareUserManagement.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.DriverSelfDeclaration.Exceptions;

namespace ATISMobileRestful.Controllers.DriverSelfDeclaration
{
    public class DriverSelfDeclarationController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetDeclarationInf()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientGetDriverSelfDeclarations);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var InstanceDriverSelfDeclaration = new R2CoreTransportationAndLoadNotificationInstanceDriverSelfDeclarationManager();
                var NSSTruck = InstanceTrucks.GetNSSTruck(NSSSoftwareuser);
                var Lst = InstanceDriverSelfDeclaration.GetDeclarations(NSSTruck,false );
                List<Models.DriverSelfDeclaration> _DSDs = new List<Models.DriverSelfDeclaration>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.DriverSelfDeclaration();
                    Item.DSDId = Lst[Loopx].DSDId;
                    Item.DSDName = Lst[Loopx].DSDName;
                    Item.DSDTitle = Lst[Loopx].DSDTitle;
                    Item.DefaultValue = "مثال : " + Lst[Loopx].DefaultValue;
                    Item.DSDValue = Lst[Loopx].DSDValue;
                    _DSDs.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_DSDs), Encoding.UTF8, "application/json");
                return response;
            }
            catch (GetNSSException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TruckNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage SetDeclarationInf()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientSetDriverSelfDeclarations);

                var InstanceAES = new AESAlgorithmsManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var NSSTruck = InstanceTrucks.GetNSSTruck(NSSSoftwareuser);
                var DSDs = Content.Split(';')[2];
                var InstanceDriverSelfDeclaration = new R2CoreTransportationAndLoadNotificationInstanceDriverSelfDeclarationManager();
                //ثبت مشخصات
                InstanceDriverSelfDeclaration.SetDeclarations(DSDs, NSSTruck, NSSSoftwareuser);
                //بروز رسانی مشخصات در اپلیکیشن
                InstanceDriverSelfDeclaration.GetDeclarations(NSSTruck,true );
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (DriverSelfDeclarationsEmtpyNotAllowdException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByMobileNumberException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TruckNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (GetNSSException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (SqlInjectionException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (DriverSelfDeclarationParameterNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetValid()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientGetDriverSelfDeclarations);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTrucks = new R2CoreTransportationAndLoadNotificationInstanceTrucksManager();
                var InstanceDriverSelfDeclaration = new R2CoreTransportationAndLoadNotificationInstanceDriverSelfDeclarationManager();
                var NSSTruck = InstanceTrucks.GetNSSTruck(NSSSoftwareuser);
                var Lst = InstanceDriverSelfDeclaration.GetDeclarations(NSSTruck, false);
                List<Models.DriverSelfDeclaration> _DSDs = new List<Models.DriverSelfDeclaration>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.DriverSelfDeclaration();
                    Item.DSDId = Lst[Loopx].DSDId;
                    Item.DSDName = Lst[Loopx].DSDName;
                    Item.DSDTitle = Lst[Loopx].DSDTitle;
                    Item.DefaultValue = "مثال : " + Lst[Loopx].DefaultValue;
                    Item.DSDValue = Lst[Loopx].DSDValue;
                    _DSDs.Add(Item);
                }
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_DSDs), Encoding.UTF8, "application/json");
                return response;
            }
            catch (GetNSSException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TruckNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

    }
}
