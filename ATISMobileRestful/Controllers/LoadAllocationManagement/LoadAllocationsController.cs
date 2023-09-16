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
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;
using R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions;
using R2Core.SiteIsBusy.Exceptions;

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
                //TimeSpan now = DateTime.Now.TimeOfDay;
                //if ((new TimeSpan(12, 45, 0) <= now && now <= new TimeSpan(13, 00, 0)) || 
                //    (new TimeSpan(15, 30, 0) <= now && now <= new TimeSpan(15, 35, 0)))
                //{ throw new TimingNotReachedException(); }

                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith1Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientLoadAllocationRegisteringRequest);

                var InstanceAES = new AESAlgorithmsManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var nEstelamId = Convert.ToInt64(Content.Split(';')[2]);

                R2CoreTransportationAndLoadNotificationStandardTurnStructure myNSSTurn = null ;
                try
                {
                    var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                    myNSSTurn = InstanceTurns.GetNSSTurn(NSSSoftwareuser);
                }
                catch (Exception ex)
                { throw ex; }

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.LoadAllocationRegistering(nEstelamId, myNSSTurn, NSSSoftwareuser, R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullLoadAllocationRegisteringAgent,false ,false );
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LastLoadPermissionIssuedforThisTurnException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
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
            catch (TruckDriverNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (TruckTotalLoadPermissionReachedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (RequesterCanNotAllocateSedimentedLoadInTimeRangeException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationTimeNotReachedException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        private void AuthorizationLoadAllocationIdWithSoftwareUser(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser, Int64 YourLoadAllocationId)
        {
            try
            {
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                var InstanceTurn = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                if (InstanceTurn.GetNSSTurn(YourNSSSoftwareUser).nEnterExitId != InstanceLoadAllocation.GetTurnIdfromLoadAllocationId(YourLoadAllocationId))
                { throw new LoadAllocationIdNotPairWithDriverException(); }
            }
            catch (Exception ex)
            { throw ex; }
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
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Convert.ToInt64(Content.Split(';')[2]);
                AuthorizationLoadAllocationIdWithSoftwareUser(NSSSoftwareuser, LoadAllocationId);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.LoadAllocationCancelling(LoadAllocationId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser, NSSSoftwareuser);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
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

                var InstanceSiteIsBusy = new R2Core.SiteIsBusy.R2CoreSiteIsBusyManager();
                InstanceSiteIsBusy.SiteIsBusy();

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
                    SB.Append("کد بار: " + Lst[Loopx].LoadCapacitorLoadnEstelamId + "\r\n");
                    SB.Append(Lst[Loopx].LoadCapacitorLoadGoodTitle.Trim() + " " + Lst[Loopx].LoadCapacitorLoadTargetTitle.Trim() + " تعدادبار: " + Lst[Loopx].LoadCapacitorLoadnCarNumKol.Trim() + " تناژ بار: " + Lst[Loopx].LoadCapacitorLoadnTonaj.Trim() + "\r\n");
                    SB.Append("تعرفه: " + Lst[Loopx].LoadCapacitorLoadStrPriceSug.Trim() + "\r\n");
                    SB.Append("پارامترهای موثر: " + Lst[Loopx].TPTParams.Trim() + "\r\n");
                    SB.Append("محل بارگیری: " + Lst[Loopx].LoadingPlace.Trim() + "\r\n");
                    SB.Append("محل تخلیه: " + Lst[Loopx].DischargingPlace.Trim() + "\r\n");
                    SB.Append("توضیحات بار: " + Lst[Loopx].LoadCapacitorLoadStrDescription.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrBarName.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrAddress.Trim() + "\r\n");
                    SB.Append("وضعیت تخصیص بار: " + Lst[Loopx].LoadAllocationStatusTitle.Trim() + "\r\n");
                    SB.Append("توضیحات تخصیص: " + Lst[Loopx].LoadAllocationNote.Trim() + "\r\n");
                    SB.Append("طول سفر: " + Lst[Loopx].LoadCapacitorLoadTargetTravelength.Trim() + "\r\n");
                    Item.Description = SB.ToString();
                    Item.DescriptionColor = Lst[Loopx].LoadAllocationStatusColor;
                    Item.LoadAllocationId = "شماره تخصیص:" + Lst[Loopx].LoadAllocationId + " - " + "اولویت:" + Lst[Loopx].LoadAllocationPriority;
                    _LoadAllocations.Add(Item);
                }
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_LoadAllocations), Encoding.UTF8, "application/json");
                return response;
            }
            catch (R2CoreSiteIsBusyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage GetLoadPermissionsViaLicensePlate()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonceWith2Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientGetLoadPermissionsViaLicensePlate);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                List<Models.LoadAllocationsforTruckDriver> _LoadAllocations = new List<Models.LoadAllocationsforTruckDriver>();
                var Lst = InstanceLoadAllocation.GetLoadPermissionsViaLicensePlate(LPPelak, LPSerial);
                StringBuilder SB = new StringBuilder();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadAllocationsforTruckDriver();
                    SB.Clear();
                    SB.Append("شرکت حمل و نقل: " + Lst[Loopx].TransportCompanyTitle.Trim() + " " + Lst[Loopx].TransportCompanyTel.Trim() + "\r\n");
                    SB.Append("کد مرجع: " + Lst[Loopx].LoadCapacitorLoadnEstelamId + "\r\n");
                    SB.Append(Lst[Loopx].LoadCapacitorLoadGoodTitle.Trim() + " " + Lst[Loopx].LoadCapacitorLoadTargetTitle.Trim() + " تعدادبار: " + Lst[Loopx].LoadCapacitorLoadnCarNumKol.Trim() + "\r\n");
                    SB.Append("تعرفه: " + Lst[Loopx].LoadCapacitorLoadStrPriceSug.Trim() + "\r\n");
                    SB.Append("توضیحات بار: " + Lst[Loopx].LoadCapacitorLoadStrDescription.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrBarName.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrAddress.Trim() + "\r\n");
                    SB.Append("تناژ بار: " + Lst[Loopx].LoadCapacitorLoadnTonaj.Trim()+ "\r\n");
                    SB.Append("وضعیت تخصیص بار: " + Lst[Loopx].LoadAllocationStatusTitle.Trim() + "\r\n");
                    SB.Append("تاریخ تخصیص بار: " + Lst[Loopx].LoadPermissionDate + " - " + Lst[Loopx].LoadPermissionTime + "\r\n");
                    SB.Append("توضیحات تخصیص: " + Lst[Loopx].LoadAllocationNote.Trim() + "\r\n");
                    SB.Append("طول سفر: " + Lst[Loopx].LoadCapacitorLoadTargetTravelength.Trim() + "\r\n");
                    Item.Description = SB.ToString();
                    Item.DescriptionColor = Lst[Loopx].LoadAllocationStatusColor;
                    Item.LoadAllocationId = "شماره تخصیص:" + Lst[Loopx].LoadAllocationId + " - " + "اولویت:" + Lst[Loopx].LoadAllocationPriority;
                    _LoadAllocations.Add(Item);
                }
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_LoadAllocations), Encoding.UTF8, "application/json");
                return response;
            }
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
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Convert.ToInt64(Content.Split(';')[2]);
                AuthorizationLoadAllocationIdWithSoftwareUser(NSSSoftwareuser, LoadAllocationId);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.IncreasePriority(LoadAllocationId);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
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
                var NSSSoftwareuser = InstanceSoftwareusers.GetNSSUserUnChangeable(new R2CoreSoftwareUserMobile(MobileNumber));
                var LoadAllocationId = Convert.ToInt64(Content.Split(';')[2]);
                AuthorizationLoadAllocationIdWithSoftwareUser(NSSSoftwareuser, LoadAllocationId);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.DecreasePriority(LoadAllocationId);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
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
