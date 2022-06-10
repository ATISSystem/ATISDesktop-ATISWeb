using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Text;
using Newtonsoft.Json;

using R2Core.LoggingManagement;
using R2CoreTransportationAndLoadNotification.Turns;
using R2CoreTransportationAndLoadNotification.Logging;
using R2Core.SoftwareUserManagement;
using ATISMobileRestful.Exceptions;
using R2Core.SoftwareUserManagement.Exceptions;
using ATISMobileRestful.Logging;
using R2Core.PermissionManagement;
using R2CoreTransportationAndLoadNotification.MobileProcessesManagement;
using R2Core.ConfigurationManagement;
using R2Core.SecurityAlgorithmsManagement.AESAlgorithms;
using R2Core.SecurityAlgorithmsManagement.Hashing;
using PayanehClassLibrary.TurnRegisterRequest;
using R2CoreTransportationAndLoadNotification.RequesterManagement;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls;
using PayanehClassLibrary.CarTruckNobatManagement;
using R2CoreTransportationAndLoadNotification.Turns.SequentialTurns;

namespace ATISMobileRestful.Controllers.TurnManagement
{
    public class TurnsController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetTurns()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientTurnsRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                var InstanceSequentialTurns = new R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager();
                var Lst = InstanceTurns.GetTurns(NSSSoftwareuser);
                List<Models.Turns> _Turns = new List<Models.Turns>();
                for (int Loopx = 0; Loopx <= Lst.Count - 1; Loopx++)
                {
                    var Item = new Models.Turns();
                    Item.TurnId = Lst[Loopx].nEnterExitId.ToString();
                    var OtaghdarTurnNumber = Lst[Loopx].OtaghdarTurnNumber.Trim().Split('-')[0];
                    var TurnDistanceToValidity = Lst[Loopx].OtaghdarTurnNumber.Trim().Split('-')[1];
                    Item.OtaghdarTurnNumber = "شماره نوبت : " + OtaghdarTurnNumber + " فاصله شما تا اعتبار : " + TurnDistanceToValidity;
                    if (Loopx == 0)
                    {
                        var NSSSeqTurn = InstanceSequentialTurns.GetNSSSequentialTurn(Lst[Loopx]);
                        Item.OtaghdarTurnNumber += "\r\n" + "شماره اعتبار : " + InstanceTurns.GetFirstActiveTurn(NSSSeqTurn).OtaghdarTurnNumber ;
                    }
                    Item.TurnDateTime = "زمان: " + Lst[Loopx].EnterDate.Trim() + " - " + Lst[Loopx].EnterTime.Trim();
                    Item.TurnStatusTitle = "وضعیت نوبت: " + Lst[Loopx].TurnStatusTitle.Trim();
                    Item.LPPString = "ناوگان: " + Lst[Loopx].LicensePlatePString.Trim();
                    Item.TruckDriver = "راننده: " + Lst[Loopx].TruckDriver.Trim();
                    _Turns.Add(Item);
                }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(_Turns), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateSuccessContentMessage(string.Empty); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
        }

        [HttpPost]
        public HttpResponseMessage RealTimeTurnRegisterRequest()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith2Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientRealTimeTurnRegisterRequest);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];

                var InstanceTurnRegisterRequest = new PayanehClassLibraryMClassTurnRegisterRequestManager();
                InstanceTurnRegisterRequest.RealTimeTurnRegisterRequestWithLicensePlate(LPPelak, LPSerial, NSSSoftwareuser, R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullTurnControllerRealTimeTurnRegisterRequest,TurnType.Permanent);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }

        [HttpPost]
        public HttpResponseMessage TurnCancellation()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith2Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientTurnCancellation );

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var LPPelak = Content.Split(';')[2];
                var LPSerial = Content.Split(';')[3];

                var InstanceCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();
                InstanceCarTruckNobat.TurnCancellationWithLicensePlate(LPPelak, LPSerial, NSSSoftwareuser);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }

        [HttpPost]
        public HttpResponseMessage TurnsCancellation()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNoncePersonalNonceWith2Parameter(Request, ATISMobileWebApiLogTypes.WebApiClientTurnsCancellation);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceSequentialTrun = new R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));
                var TopSequentialTurnNumber = Content.Split(';')[2];
                var YearShamsi = Content.Split(';')[3];

                //var InstanceCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();
                //InstanceCarTruckNobat.TurnsCancellation(TopSequentialTurnNumber, InstanceSequentialTrun.GetNSSSequentialTurn(2), YearShamsi, NSSSoftwareuser);

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }

        [HttpPost]
        public HttpResponseMessage GetFirstActiveTurn()
        {
            ATISMobileWebApi WebAPi = new ATISMobileWebApi();
            try
            {
                //تایید اعتبار کلاینت
                WebAPi.AuthenticateClientApikeyNonce(Request, ATISMobileWebApiLogTypes.WebApiClientGetLastTurnIdWhichCancelledDuringTurnsCancellationProcess);

                var NSSSoftwareuser = WebAPi.GetNSSSoftwareUser(Request);
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                var InstanceSoftwareusers = new R2CoreInstanseSoftwareUsersManager();
                var InstanceSequentialTrun = new R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager();
                var InstanceAES = new AESAlgorithmsManager();
                var Content = JsonConvert.DeserializeObject<string>(Request.Content.ReadAsStringAsync().Result);
                var MobileNumber = InstanceAES.Decrypt(Content.Split(';')[0], InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3));

                var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                var InstanceSequentialTurns = new R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager();
                var NSSTurn = InstanceTurns.GetFirstActiveTurn(InstanceSequentialTurns.GetNSSSequentialTurn(Convert.ToInt64(SequentialTurns.SequentialTurnZobi)));

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(NSSTurn.OtaghdarTurnNumber), Encoding.UTF8, "application/json");
                return response;
            }
            catch (UserNotExistByApiKeyException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserLast5DigitNotMatchingException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (UserIdNotExistException ex)
            { return WebAPi.CreateErrorContentMessage(ex); }
            catch (Exception ex)
            { return WebAPi.CreateErrorContentMessage(ex); }

        }



    }
}
