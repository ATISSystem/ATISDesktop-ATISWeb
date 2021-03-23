
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

using ATISMobileRestful.Exceptions;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;

namespace ATISMobileRestful.Controllers.AnnouncementHallsManagement
{
    public class AnnouncementHallsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetAnnouncementHallsAnnouncementhAllSubGroupsJOINT()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClient3PartHashed(Request);

                var InstanceAnnouncementHalls = new R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager();
                var Lst = InstanceAnnouncementHalls.GetAnnouncementHallsAnnouncementHallSubGroupsJOINT();
                var LstPair = new List<KeyValuePair<string, string>>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                { LstPair.Add(new KeyValuePair<string, string>(Lst[Loopx].NSSAnnouncementHallSubGroup.AHSGId.ToString(), Lst[Loopx].NSSAnnouncementHallSubGroup.AHSGTitle)); }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(LstPair), Encoding.UTF8, "application/json");
                return response;
            }
            catch (WebApiClientUnAuthorizedException ex)
            { return WebAPi.CreateContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateContentMessage(ex); }
        }

    }
}
