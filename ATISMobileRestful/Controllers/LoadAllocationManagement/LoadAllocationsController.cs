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

namespace ATISMobileRestful.Controllers.LoadAllocationManagement
{
    public class LoadAllocationsController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage LoadAllocationAgent()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                Request.Headers.TryGetValues("nEstelamKey", out IEnumerable<string> nEstelamKey);

                var InstanceSoftwareUser = new R2CoreInstanseSoftwareUsersManager();
                var InstanceLoadCapacitorLoad = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager();
                var NSSSoftwareuser = InstanceSoftwareUser.GetNSSUser(ApiKey.FirstOrDefault());
                var NSSLoadCapacitorLoad = InstanceLoadCapacitorLoad.GetNSSLoadCapacitorLoad(nEstelamKey.FirstOrDefault());


                Int64 myTurnId = Int64.MinValue;
                try
                {
                    var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                    myTurnId = InstanceTurns.GetNSSTurn(NSSSoftwareuser).nEnterExitId;
                }
                catch (TurnNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }

                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                Int64 LAId = InstanceLoadAllocation.LoadAllocationRegistering(NSSLoadCapacitorLoad.nEstelamId, myTurnId, NSSSoftwareuser, R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullLoadAllocationRegisteringAgent);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationRegisteringReachedEndTimeException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (RequesterHasNotPermissionforLoadAllocationRegisteringException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadCapacitorLoadNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (TurnNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpDelete]
        public HttpResponseMessage LoadAllocationCancelling()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                Request.Headers.TryGetValues("LoadAllocationId", out IEnumerable<string> LoadAllocationId);
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.LoadAllocationCancelling(Convert.ToInt64(LoadAllocationId.FirstOrDefault()), R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser, InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (TimingNotReachedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (TurnHandlingNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationCancellingNotAllowedBecauseTurnStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpGet]
        public HttpResponseMessage GetLoadAllocationsforTruckDriver()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                Request.Headers.TryGetValues("ApiKey", out IEnumerable<string> ApiKey);
                var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                List<Models.LoadAllocationsforTruckDriver> _LoadAllocations = new List<Models.LoadAllocationsforTruckDriver>();
                var Lst = InstanceLoadAllocation.GetLoadAllocationsforTruckDriver(InstanceSoftwareUsers.GetNSSUser(ApiKey.FirstOrDefault()).UserId);
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
            { return WebAPi.CreateContentMessage(ex); }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationNotFoundException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpPut]
        public HttpResponseMessage IncreasePriority()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                Request.Headers.TryGetValues("LoadAllocationId", out IEnumerable<string> LoadAllocationId);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.IncreasePriority(Convert.ToInt64(LoadAllocationId.FirstOrDefault()));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

        [HttpPut]
        public HttpResponseMessage DecreasePriority()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient4PartHashed(Request);

                Request.Headers.TryGetValues("LoadAllocationId", out IEnumerable<string> LoadAllocationId);
                var InstanceLoadAllocation = new R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager();
                InstanceLoadAllocation.DecreasePriority(Convert.ToInt64(LoadAllocationId.FirstOrDefault()));
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (LoadAllocationChangePriorityNotAllowedBecauseLoadAllocationStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (LoadAllocationChangePriorityNotAllowedBecuaseTurnStatusException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }


    }
}
