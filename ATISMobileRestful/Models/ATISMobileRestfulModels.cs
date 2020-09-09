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




}