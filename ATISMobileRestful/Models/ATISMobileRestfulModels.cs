using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Drawing;

namespace ATISMobileRestful.Models
{
    public class LoadCapacitorLoad
    {
        public string LoadnEstelamId { get; set; }
        public string LoadCapacitorLoadTitleTargetCityTotalAmount { get; set; }
        public string TransportCompanyTarrifPrice { get; set; }
        public string Description { get; set; }
    }

    public class MoneyWalletAccounting
    {
        public string AccountName { get; set; }
        public string AccountDateTime { get; set; }
        public string CurrentCharge { get; set; }
        public string Mblgh { get; set; }
        public string ReminderCharge { get; set; }
        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public string BackGroundColorName { get; set; }
        public string ForeGroundColorName { get; set; }

    }

    public class Province
    {
        public string ProvinceId { get; set; }
        public string ProvinceTitle { get; set; }
    }

    public class MessageStruct
    {
        public Boolean ErrorCode { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Message3 { get; set; }
    }

    public class LoadAllocationsforTruckDriver
    {
        public string LoadAllocationId { get; set; }
        public string Description { get; set; }
        public Color DescriptionColor { get; set; }
    }

    public class TruckDriver
    {
        public string NameFamily { get; set; }
        public string FatherName { get; set; }
        public string SmartCardNo { get; set; }
        public string NationalCode { get; set; }
        public string Tel { get; set; }
        public string DrivingLicenceNo { get; set; }
        public string Address { get; set; }
        public string DriverId { get; set; }
    }

    public class Truck
    {
        public string TruckId { get; set; }
        public string LPString { get; set; }
        public string LoaderTitle { get; set; }
        public string SmartCardNo { get; set; }
        public string AnnouncementHallSubGroups { get; set; }
    }

    public class Turns
    {
        public string TurnId { get; set; }
        public string OtaghdarTurnNumber { get; set; }
        public string TurnDateTime { get; set; }
        public string TurnStatusTitle { get; set; }
        public string LPPString { get; set; }
        public string TruckDriver { get; set; }
    }

    public class MobileProcess
    {
        public string PId { get; set; }
        public string PName { get; set; }
        public string PTitle { get; set; }
        public string TargetMobilePage { get; set; }
        public string Description { get; set; }
        public Color PForeColor { get; set; }
        public Color PBackColor { get; set; }
    }

    public class PermissionsIssued
    { public string ReportItemHeader { get; set; } public string ReportItemDetails { get; set; } }

    public class AnnouncedLoadsReportClearanceLoadsReport
    { public string ReportItemHeader { get; set; } public string ReportItemDetails { get; set; } }

    public class DriverSelfDeclaration
    {
        public Int64 DSDId { get; set; }
        public String DSDName { get; set; }
        public String DSDTitle { get; set; }
        public String DefaultValue { get; set; }
        public String DSDValue { get; set; }
    }


}