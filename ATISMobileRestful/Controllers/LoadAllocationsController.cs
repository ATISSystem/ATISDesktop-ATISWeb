using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Web.Http;

using R2Core.SoftwareUserManagement;
using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.LoadAllocation;
using R2CoreTransportationAndLoadNotification.Turns.Exceptions;
using PayanehClassLibrary.TurnRegisterRequest;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.ConfigurationsManagement;

using ATISMobileRestful.Models;
using R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions;

namespace ATISMobileRestful.Controllers
{
    public class LoadAllocationsController : ApiController
    {
        [HttpGet]
        public MessageStruct LoadAllocationAgent(Int64 YourUserId, Int64 YournEstelamId)
        {
            try
            {
                //return new MessageStruct { ErrorCode = false, Message1 = String.Empty, Message2 = String.Empty, Message3 = string.Empty };
                R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure myNSSLoadCapacitorLoad = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId);
                //if (IsActiveLoadAllocationforThisLoad(myNSSLoadCapacitorLoad))
                //{ }
                Int64 myTurnId = Int64.MinValue;
                try
                { myTurnId = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourUserId)).nEnterExitId; }
                catch (TurnNotFoundException ex)
                { PayanehClassLibraryMClassTurnRegisterRequestManagement.RealTimeTurnRegisterRequestforAjent(YourUserId, YournEstelamId, false, false, ref myTurnId); }
                Int64 LAId = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationRegistering(YournEstelamId, myTurnId, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                return new MessageStruct { ErrorCode = false, Message1 = "تخصیص بار انجام شد", Message2 = LAId.ToString(), Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public MessageStruct LoadAllocationCancelling(Int64 YourLoadAllocationId)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationCancelling(YourLoadAllocationId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser());
                return new MessageStruct { ErrorCode = false, Message1 = "تخصیص بار کنسل شد", Message2 = YourLoadAllocationId.ToString(), Message3 = string.Empty };
            }
            catch (TimingNotReachedException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (TurnHandlingNotAllowedBecuaseTurnStatusException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public List<Models.LoadAllocationsforTruckDriver> GetLoadAllocationsforTruckDriver(Int64 YourUserId)
        {
            List<Models.LoadAllocationsforTruckDriver> _LoadAllocations = new List<Models.LoadAllocationsforTruckDriver>();
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocationsforTruckDriver(YourUserId );
                StringBuilder SB = new StringBuilder();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.LoadAllocationsforTruckDriver();
                    SB.Clear();
                    SB.Append("کد مرجع: " + Lst[Loopx].LoadCapacitorLoadnEstelamId + "\r\n");
                    SB.Append(Lst[Loopx].LoadCapacitorLoadGoodTitle.Trim() + " " + Lst[Loopx].LoadCapacitorLoadTargetTitle.Trim() + " تعداد: " + Lst[Loopx].LoadCapacitorLoadnCarNumKol.Trim() + "\r\n");
                    //SB.Append("نوع بار: " + Lst[Loopx].LoadCapacitorLoadLoaderTypeTitle.Trim() + "\r\n");
                    SB.Append("شرکت حمل و نقل: " + Lst[Loopx].TransportCompanyTitle.Trim() + " " + Lst[Loopx].TransportCompanyTel.Trim() + "\r\n");
                    SB.Append("تعرفه: " + Lst[Loopx].LoadCapacitorLoadStrPriceSug.Trim() + "\r\n");
                    SB.Append("توضیحات بار: " + Lst[Loopx].LoadCapacitorLoadStrDescription.Trim() + " " + Lst[Loopx].LoadCapacitorLoadStrAddress.Trim() + "\r\n");
                    //SB.Append("آدرس: " + Lst[Loopx].LoadCapacitorLoadStrAddress.Trim() + "\r\n");
                    SB.Append("زمان اعلام بار: " + Lst[Loopx].LoadCapacitorLoaddDateElam.Trim() + " " + Lst[Loopx].LoadCapacitorLoaddTimeElam.Trim() + "\r\n");
                    SB.Append("وضعیت بار: " + Lst[Loopx].LoadCapacitorLoadStatusTitle.Trim() + "\r\n");
                    SB.Append("سالن: " + Lst[Loopx].LoadCapacitorLoadAHSGTitle.Trim() + "\r\n");
                    SB.Append("وضعیت تخصیص بار: " + Lst[Loopx].LoadAllocationStatusTitle.Trim() + "\r\n");
                    SB.Append("زمان تخصیص: " + Lst[Loopx].LoadAllocationDateShamsi.Trim() + " " + Lst[Loopx].LoadAllocationTime.Trim() + "\r\n");
                    SB.Append("توضیحات تخصیص: " + Lst[Loopx].LoadAllocationNote.Trim() + "\r\n");
                    Item.Description = SB.ToString();
                    Item.DescriptionColor = Lst[Loopx].LoadAllocationStatusColor;
                    Item.LoadAllocationId = "شماره تخصیص:" + Lst[Loopx].LoadAllocationId + " - " + "اولویت:" + Lst[Loopx].LoadAllocationPriority;
                    _LoadAllocations.Add(Item);
                }
                return _LoadAllocations;
            }
            catch (Exception ex)
            { return _LoadAllocations; }

        }

        [HttpGet]
        public MessageStruct IncreasePriority(Int64 YourLoadAllocationId)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.IncreasePriority(YourLoadAllocationId);
                return new MessageStruct { ErrorCode = false, Message1 = "افزایش اولویت انجام شد", Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }

        [HttpGet]
        public MessageStruct DecreasePriority(Int64 YourLoadAllocationId)
        {
            try
            {
                R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.DecreasePriority(YourLoadAllocationId);
                return new MessageStruct { ErrorCode = false, Message1 = "کاهش اولویت انجام شد", Message2 = string.Empty, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }


    }
}
