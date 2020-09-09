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


namespace ATISMobileRestful.Controllers
{
    public class ProvincesController : ApiController
    {
        [HttpGet]
        public List<Models.Province> GetProvinces(Int64 YourAHId, Int64 YourAHSGId)
        {
            List<Models.Province> _Provinces = new List<Models.Province>();
            try
            {
                var Lst = R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetProvinces(YourAHId, YourAHSGId);
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.Province();
                    Item.ProvinceId = "کداستان: "+Lst[Loopx].ProvinceId.ToString();
                    Item.ProvinceTitle = Lst[Loopx].ProvinceTitle;
                    _Provinces.Add(Item);
                }
                return _Provinces;
            }
            catch (Exception ex)
            { return _Provinces; }
        }


    }
}
