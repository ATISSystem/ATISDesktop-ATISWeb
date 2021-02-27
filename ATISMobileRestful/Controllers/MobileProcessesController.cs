
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ATISMobileRestful.Models;
using R2Core.LoggingManagement;
using R2Core.MobileProcessesManagement;
using R2Core.MobileProcessesManagement.Exceptions;
using R2Core.SoftwareUserManagement;

namespace ATISMobileRestful.Controllers
{
    public class MobileProcessesController : ApiController
    {
        [HttpGet]
        public List<MobileProcess> GetMobileProcesses(Int64 YourSoftwareUserId)
        {
            List<MobileProcess> _MobileProcesses = new List<MobileProcess>();
            try
            {
                List<R2StandardMobileProcessStructure> Lst = null;
                Lst = R2CoreMClassMobileProcessesManagement.GetMobileProcesses(R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourSoftwareUserId));
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new MobileProcess();
                    Item.PId = Lst[Loopx].PId;
                    Item.PName = Lst[Loopx].PName;
                    Item.PTitle = Lst[Loopx].PTitle;
                    Item.TargetMobilePage = Lst[Loopx].TargetMobilePage;
                    Item.Description = Lst[Loopx].Description;
                    Item.PForeColor = Lst[Loopx].PForeColor;
                    Item.PBackColor = Lst[Loopx].PBackColor;
                    _MobileProcesses.Add(Item);
                }
                return _MobileProcesses;
            }
            catch (SoftwareUserHasNotAnyMobileProcessPermissionException ex)
            {return _MobileProcesses; }
            catch (Exception ex)
            { throw ex; }
        }
    }
}

