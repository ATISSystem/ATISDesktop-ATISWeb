using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Logging;
using R2CoreTransportationAndLoadNotification.LoadTargets;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;


namespace ATISMobileRestful.Controllers
{
    public class ProvincesController : ApiController
    {
        [HttpGet]
        public List<Models.Province> GetProvinces(Int64 YourAHId, Int64 YourAHSGId,LoadCapacitorLoadsListType YourLoadCapacitorLoadsListType)
        {
            List<Models.Province> _Provinces = new List<Models.Province>();
            try
            {
                var Lst =R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNumberOfLoadsOfProvinces(YourAHId, YourAHSGId,YourLoadCapacitorLoadsListType);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.Province();
                    Item.ProvinceId = "کداستان: "+Lst[Loopx].Province.ProvinceId.ToString();
                    Item.ProvinceTitle = Lst[Loopx].Province.ProvinceTitle+"  :  تعداد بار "+ Lst[Loopx].NumberOfLoads.ToString();
                    _Provinces.Add(Item);
                }
                return _Provinces;
            }
            catch (Exception ex)
            { return _Provinces; }
        }


    }
}
