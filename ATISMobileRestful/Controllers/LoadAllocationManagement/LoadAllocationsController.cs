using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

using R2Core.SoftwareUserManagement;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.LoadAllocation;
using R2CoreTransportationAndLoadNotification.Turns.Exceptions;
using PayanehClassLibrary.TurnRegisterRequest;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.ConfigurationsManagement;
using R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions;
using ATISMobileRestful.Models;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions;
using R2CoreTransportationAndLoadNotification.RequesterManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.DateAndTimeManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;

namespace ATISMobileRestful.Controllers.LoadAllocationManagement
{
    public class LoadAllocationsController : ApiController
    {
        R2DateTime _DateTime = new R2DateTime();

        [HttpPost]
        public HttpResponseMessage LoadAllocationAgent()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientLoadAllocationRegisteringRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(new R2CoreSoftwareUserMobile(MobileNumber));
                var nEstelamId = Content.Split(';')[2];
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var NSSLoadCapacitorLoad = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(nEstelamId).nEstelamKey);
                if (NSSLoadCapacitorLoad.LoadStatus == R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented)
                { throw new Exception("تخصیص بار رسوبی تا اطلاع ثانوی ممکن نیست"); }

                Int64 myTurnId = Int64.MinValue;
                try
                {
                    var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                    myTurnId = InstanceTurns.GetNSSTurn(NSSSoftwareuser).nEnterExitId;
                }
                catch (Exception ex)
                { throw ex; }

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                Int64 LAId = InstanceLoadAllocation.LoadAllocationRegistering(NSSLoadCapacitorLoad.nEstelamId, myTurnId, NSSSoftwareuser, R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullLoadAllocationRegisteringAgent);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationNotAllowedBecauseCarHasBlackListException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationRegisteringReachedEndTimeException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (RequesterHasNotPermissionforLoadAllocationRegisteringException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TurnNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TruckDriverNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage LoadAllocationCancelling()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientLoadAllocationCancellingRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Content.Split(';')[2];

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.LoadAllocationCancelling(Convert.ToInt64(LoadAllocationId), R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser, NSSSoftwareuser);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TimingNotReachedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TurnHandlingNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationCancellingNotAllowedBecauseTurnStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TurnNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetLoadAllocationsforTruckDriver()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientLoadAllocationsRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                List<Models.LoadAllocationsforTruckDriver> _LoadAllocations = new List<Models.LoadAllocationsforTruckDriver>();
                var Lst = InstanceLoadAllocation.GetLoadAllocationsforTruckDriver(NSSSoftwareuser.UserId);
                StringBuilder SB = new StringBuilder();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadAllocationsforTruckDriver();
                    SB.Clear();
                    SB.Append("شرکت حمل و نقل: " + Lst[Loopx].TransportCompanyTitle.Trim() + " " + Lst[Loopx].TransportCompanyTel.Trim() + "\r\n");
                    SB.Append("کد مرجع: " + Lst[Loopx].LoadCapacitorLoadnEstelamId + "\r\n");
                    SB.Append(Lst[Loopx].LoadCapacitorLoadGoodTitle.Trim() + " " + Lst[Loopx].LoadCapacitorLoadTargetTitle.Trim() + " تعدادبار: " + Lst[Loopx].LoadCapacitorLoadnCarNumKol.Trim() + "\r\n");
                    SB.Append("تعرفه: " + Lst[Loopx].LoadCapacitorLoadStrPriceSug.Trim() + "\r\n");
                    SB.Append("توضیحات بار: " + Lst[Loopx].LoadCapacitorLoadStrDescription.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrAddress.Trim() + "\r\n");
                    SB.Append("وضعیت تخصیص بار: " + Lst[Loopx].LoadAllocationStatusTitle.Trim() + "\r\n");
                    SB.Append("توضیحات تخصیص: " + Lst[Loopx].LoadAllocationNote.Trim() + "\r\n");
                    Item.Description = SB.ToString();
                    Item.DescriptionColor = Lst[Loopx].LoadAllocationStatusColor;
                    Item.LoadAllocationId = "شماره تخصیص:" + Lst[Loopx].LoadAllocationId + " - " + "اولویت:" + Lst[Loopx].LoadAllocationPriority;
                    _LoadAllocations.Add(Item);
                }
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_LoadAllocations), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage IncreasePriority()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientIncreasePriorityRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Content.Split(';')[2];

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.IncreasePriority(Convert.ToInt64(LoadAllocationId));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TimingNotReachedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TurnNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage DecreasePriority()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientDecreasePriorityRequest);

                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Content.Split(';')[2];

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.DecreasePriority(Convert.ToInt64(LoadAllocationId));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TimingNotReachedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TurnNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }


    }
}
