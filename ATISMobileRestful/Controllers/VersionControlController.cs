using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;
using System.Text;

using ATISMobileRestful.Models;

namespace ATISMobileRestful.Controllers
{
    public class VersionControlController : ApiController
    {
        [HttpGet]
        public bool HaveNewerVersion(string YourVersionNumber, string YourVersionName)
        {
            string VersionNumber = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[0].Split(':')[1];
            string VersionName = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[1].Split(':')[1];
            if (YourVersionNumber.Trim() != VersionNumber.Trim() || YourVersionName.Trim() != VersionName.Trim())
            { return true; }
            else
            { return false; }
        }

        [HttpGet]
        public MessageStruct GetLastVersionNumber()
        {
            try
            {
                string VersionNumber = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[0].Split(':')[1];
                string VersionName = File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/NewerVersionInfo.txt"), Encoding.UTF8).Split(';')[1].Split(':')[1];
                return new MessageStruct() { ErrorCode = false, Message1 = VersionNumber, Message2 = VersionName, Message3 = string.Empty };
            }
            catch (Exception ex)
            { return new MessageStruct() { ErrorCode = true, Message1 = ex.Message, Message2 = string.Empty, Message3 = string.Empty }; }
        }



    }
}
