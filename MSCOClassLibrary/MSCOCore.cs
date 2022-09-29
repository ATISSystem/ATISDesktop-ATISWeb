
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

using MSCOCore.MSCOTransportCompanies.Exceptions;
using R2Core.ConfigurationManagement;
using R2Core.DatabaseManagement;
using R2Core.DateAndTimeManagement;
using R2Core.Email;


using R2Core.FileShareRawGroupsManagement;
using R2Core.SoftwareUserManagement;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using MSCOCore.MSCOTransportCompanies;
using MSCOCore.AnnouncementProcessManagement.Exceptions;
using R2Core.BaseStandardClass;
using R2Core.LoggingManagement;
using R2Core.Email.Exceptions;
using MSCOCore.Logging;
using R2Core.PublicProc;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad;
using R2CoreTransportationAndLoadNotification.LoadTargets;
using MSCOCore.MSCOTargets.Exceptions;
using MSCOCore.MSCOTargets;
using R2CoreTransportationAndLoadNotification;

namespace MSCOCore
{
    namespace AnnouncementProcessManagement
    {
        public class MSCOCoreAnnouncementforTransportCompaniesManager
        {
            private R2DateTime _DateTime = new R2DateTime();

            public MSCOCoreAnnouncementforTransportCompaniesManager()
            { }

            private List<string> GetTransportCompaniesWhichAnounceActive()
            {
                try
                {
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    DataSet DS = null;
                    InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                        @"Select MSCOId from MSCO.dbo.TblMSCOTransportCompanies Where Announce=1 and Active=1 and Deleted=0
                          Order By MSCOId", 3600, ref DS);
                    List<String> Lst = new List<string>();
                    for (int Loopx = 0; Loopx <= DS.Tables[0].Rows.Count - 1; Loopx++)
                    { Lst.Add(DS.Tables[0].Rows[Loopx]["MSCOId"].ToString()); }
                    return Lst;
                }
                catch (Exception ex)
                { throw ex; }
            }

            private void SentEmail(string YourTransportCompanyCode, StringBuilder YourSB, R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                var InstanceEmail = new R2CoreEmailManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();

                try
                {
                    if (InstanceTransportCompanies.IsActiveTransportCompanySentMail(YourTransportCompanyCode))
                    { InstanceEmail.SendEmailWithTXTTypeAttachment(InstanceTransportCompanies.GetNSSTransportCompany(YourTransportCompanyCode).EmailAddress, YourSB, "اعلام بار", string.Empty, YourTransportCompanyCode + InstanceConfiguration.GetConfigString(MSCOCore.Configurations.MSCOCoreConfigurations.MSCO, 4)); }
                    System.Threading.Thread.Sleep(150000);
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message + YourTransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }
                catch (R2CoreEmailSystemIsNotActiveException ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }

                catch (Exception ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message.Substring(0, 80) + YourTransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }
            }

            private void CreateAnnouncementFileforTransportCompanies(string YourTransportCompanyCode, StringBuilder YourSB, R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                try
                {
                    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstancePublicProcedures = new R2CoreInstancePublicProceduresManager();

                    if (InstanceTransportCompanies.IsActiveTransportCompanyAnnounce(YourTransportCompanyCode))
                    { InstancePublicProcedures.SaveFile(R2CoreRawGroups.UploadedFiles, InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 8) + _DateTime.GetCurrentDateShamsiFullWithoutSlashes() + YourTransportCompanyCode + ".Txt", System.Text.Encoding.UTF8.GetBytes(YourSB.ToString()), YourNSSSoftwareUser); }
                }

                catch (MSCOCoreTransportCompanyNotFoundException ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message + YourTransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }
                catch (Exception ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message.Substring(0, 80) + YourTransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }
            }

            public void SentEmailforTransportCompanies(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                string TransportCompanyCode = null;
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceEmail = new R2CoreEmailManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                    var InstanceLogging = new R2CoreInstanceLoggingManager();

                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(Configurations.MSCOCoreConfigurations.MSCO, 0)) { throw new MSCOCoreAnnouncementforTransportCompaniesIsnotActiveException(); }
                    //کنترل زمان اجرای فرآیند
                    var TimeofDay = _DateTime.GetCurrentTime();
                    if (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 2), @"hh\:mm\:ss", CultureInfo.InvariantCulture)) { return; }
                    //کنترل موجود بودن فایل ارسالی فولاد
                    var WS = new R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService();
                    if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".txt.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword))) { return; }
                    if (!(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".txt", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))) { throw new MSCOCoreFilefromMSCORefrenceNotFoundException(); }

                    var SB = new StringBuilder();
                    var ms = new System.IO.MemoryStream(WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".txt", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)));
                    var sr = new System.IO.StreamReader(ms);
                    sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                    var FirstLine = sr.ReadLine();
                    var SecondLine = sr.ReadLine();
                    SB.AppendLine(FirstLine); SB.AppendLine(SecondLine);
                    var OtherLine = sr.ReadLine();
                    TransportCompanyCode = OtherLine.Substring(0, 7);
                    SB.AppendLine(OtherLine);

                    while (!(sr.EndOfStream))
                    {
                        OtherLine = sr.ReadLine();
                        if (OtherLine == String.Empty)
                        {
                            SB.AppendLine(OtherLine);
                            if (sr.EndOfStream)
                            {
                                SentEmail(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                CreateAnnouncementFileforTransportCompanies(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                break;
                            }
                            continue;
                        }
                        if (OtherLine.Substring(18, 1) == "N" || OtherLine.Substring(18, 1) == "L")
                        {
                            if (OtherLine.Substring(0, 7) == TransportCompanyCode)
                            { SB.AppendLine(OtherLine); continue; }
                            else
                            {
                                SentEmail(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                CreateAnnouncementFileforTransportCompanies(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                //شرکت جدید
                                SB.Clear();
                                TransportCompanyCode = OtherLine.Substring(0, 7);
                                SB.AppendLine(FirstLine); SB.AppendLine(SecondLine); SB.AppendLine(OtherLine);
                                continue;
                            }
                        }
                        else
                        {
                            SB.AppendLine(OtherLine);
                            if (sr.EndOfStream)
                            {
                                SentEmail(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                CreateAnnouncementFileforTransportCompanies(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                break;
                            }
                            continue;
                        }
                    }
                    //حذف فایل اعلام بار با حفظ سابقه
                    WS.WebMethodDeleteFileButKeepDeleted(R2CoreRawGroups.UploadedFiles, "msc" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".txt", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword));
                }
                catch (MSCOCoreFilefromMSCORefrenceNotFoundException ex)
                { throw ex; }
                catch (MSCOCoreAnnouncementforTransportCompaniesIsnotActiveException ex)
                { throw ex; }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            private R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure GetNSS(StringBuilder YourSB)
            {
                //try
                //{
                //    var Lines = YourSB.ToString().Split('\n');
                //    string myMSCOId, mySituation, myNL, myFirstDate, myFirstTime, mySecondDate, mySecondTime, myTargetId, 
                //           mynCarNumKol, myLoadingLocation, myMSCOGoodId, mynoEmptyingDays, myLBN, myLTN;
                //    Int64 myTonaj = 0;

                //    for (int Loopx = 0; Loopx <= Lines.Length - 1; Loopx++)
                //    {
                //        if (Lines[Loopx].Substring(18, 1) == "N" || Lines[Loopx].Substring(18, 1) == "L")
                //        {
                //            myMSCOId = Lines[0].Substring(0, 7);
                //            mySituation = Lines[0].Substring(7, 11);
                //            myNL = YourSB.ToString().Substring(18, 1);
                //            myFirstDate = Lines[0].Substring(19, 8);
                //            myFirstTime = Lines[0].Substring(27, 4);
                //            mySecondDate = Lines[0].Substring(31, 8);
                //            mySecondTime = Lines[0].Substring(39, 4);
                //            myTargetId = Lines[0].Substring(43, 5);
                //            myTonaj = myTonaj+ Lines[0].Substring(90, 5);
                //            mynCarNumKol = Lines[0].Substring(100, 1);
                //            myLoadingLocation = Lines[0].Substring(117, 2);
                //            myMSCOGoodId = Lines[0].Substring(134, 2);
                //            mynoEmptyingDays = Lines[3].Substring(222, 9);
                //            myLBN = Lines[0].Substring(269, 3);
                //            myLTN = Lines[3].Substring(214, 3);


                //        }
                //    }


                //    var InstanceMSCOTargets = new MSCOMClassMSCOTargetsManager();
                //    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                var NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure();
                //    NSS.nEstelamId = 0;
                //    NSS.nEstelamKey = string.Empty;
                //    NSS.nCityCode = InstanceMSCOTargets.GetNSSLoadTarget(myTargetId).NSSCity.nCityCode;
                //    NSS.nTonaj = double.Parse((System.Convert.ToInt64(myTonaj) / 1000).ToString());
                //    NSS.nBarCode = 5802000;
                //    NSS.nCompCode = InstanceTransportCompanies.GetNSSTransportCompany(myMSCOId).TCId;
                //    NSS.IsSpecialLoad = false;
                //    NSS.nTruckType = InstanceMSCOTargets.GetNSSLoadTarget(myTargetId).NSSCity.nProvince == 21 ? 807 : 805;
                //    NSS.StrAddress = String.Empty;
                //    NSS.nCarNumKol = System.Convert.ToInt64(mynCarNumKol);
                //    NSS.StrPriceSug = 0;
                //    NSS.StrDescription = "بارگیری از " + myFirstDate + myFirstTime + " تا " +
                //                         mySecondDate + mySecondTime + "\n" +
                //                         "موقعیت بارگیری " + myLoadingLocation + "\n" +
                //                         "شماره موقعیت " + mySituation + "\n" +
                //                         mynoEmptyingDays == string.Empty ? string.Empty : "روزهای عدم تخلیه " + mynoEmptyingDays + "\n" +
                //                         myLBN == string.Empty ? string.Empty : "لبه دار بارگیری ندارد" + "\n" +
                //                         myLTN == string.Empty ? string.Empty : "لبه دار تخلیه ندارد" + "\n";
                return NSS;



                //}
                //catch (MSCOCoreTransportCompanyNotFoundException ex)
                //{ throw ex; }
                //catch (MSCOCoreMSCOTargetnotfoundException ex)
                //{ throw ex; }
                //catch (Exception ex)
                //{ throw ex; }
            }

            private bool GetAnnounceFirstStep()
            {
                try
                {
                    var TimeofDay = _DateTime.GetCurrentTime();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    bool FirstAnnounce = false;
                    if (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) > TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 3), @"hh\:mm\:ss", CultureInfo.InvariantCulture) &&
                        TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 5), @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                    { FirstAnnounce = true; }
                    else if (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) > TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 6), @"hh\:mm\:ss", CultureInfo.InvariantCulture) &&
                        TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 7), @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                    { FirstAnnounce = false; }
                    else
                    { throw new MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException(); }
                    return FirstAnnounce;
                }
                catch (MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }
            }

            private void LoadsAnnouncement(StringBuilder YourSB)
            {
                try
                {
                    var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var CurrentShamsiDate = _DateTime.GetCurrentDateShamsiFullWithoutSlashes();
                    var NextShamsiDate = _DateTime.GetNextDateShamsiWithoutSlashes();
                    var myFirstDate = YourSB.ToString().Substring(19, 8);
                    var myFirstTime = YourSB.ToString().Substring(27, 4);

                    if (myFirstDate == CurrentShamsiDate)
                    {
                        if (GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB)); return; }
                        else { return; }
                    }
                    else if (myFirstDate == NextShamsiDate)
                    {
                        if (TimeSpan.ParseExact(myFirstTime, @"hh\:mm\:ss", CultureInfo.InvariantCulture) <= TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 9), @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                        {
                            if (GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB)); return; }
                            else { return; }
                        }
                        else
                        { if (!GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB)); return; } }
                    }
                    else
                    { if (!GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB)); return; } }
                }
                catch (MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }

            }

            public void LoadsAnnouncementforTransportCompanies(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                    var InstanceLogging = new R2CoreInstanceLoggingManager();

                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(Configurations.MSCOCoreConfigurations.MSCO, 0))
                    { throw new MSCOCoreAnnouncementforTransportCompaniesIsnotActiveException(); }

                    //بررسی این که در زمان اعلام بار مرحله اول و یا دوم قرار داریم 
                    try { GetAnnounceFirstStep(); }
                    catch (MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException ex) { throw ex; }


                    //اعلام بار
                    //لیست شرکت های فعال
                    List<string> LstTC = GetTransportCompaniesWhichAnounceActive();

                    for (int LoopxTC = 0; LoopxTC <= LstTC.Count - 1; LoopxTC++)
                    {
                        var TransportCompanyCode = LstTC[LoopxTC];

                        try
                        {
                            //کنترل فعال بودن اعلام بار شرکت
                            if (!InstanceTransportCompanies.IsActiveTransportCompanyAnnounce(TransportCompanyCode)) { throw new MSCOCoreAnnounceforTransportCompanyIsNotActiveException(); }

                            //کنترل موجود بودن فایل اعلام بار شرکت
                            var MSCOFileName = InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 8) + _DateTime.GetCurrentDateShamsiFullWithoutSlashes() + TransportCompanyCode + (GetAnnounceFirstStep() ? ".Txt" : ".Txt.Del");
                            var WS = new R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService();
                            if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, MSCOFileName + ".Del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
                            { continue; }
                            else if (!(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, MSCOFileName, WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword))))
                            { throw new MSCOCoreMSCOTCFileNotFoundException(); }
                            else
                            { }

                            //اعلام بار شرکت
                            var ms = new System.IO.MemoryStream(WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, MSCOFileName, WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)));
                            var sr = new System.IO.StreamReader(ms);
                            sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                            sr.ReadLine(); sr.ReadLine();
                            var SB = new StringBuilder();
                            var Sitution = string.Empty;
                            while (!sr.EndOfStream)
                            {
                                string ReadedLine = sr.ReadLine();
                                if (sr.EndOfStream) { LoadsAnnouncement(SB); SB.Clear(); break; }
                                if (ReadedLine.Substring(18, 1) == "N" || ReadedLine.Substring(18, 1) == "L")
                                {
                                    if (Sitution == string.Empty)
                                    { Sitution = ReadedLine.Substring(7, 11); SB.AppendLine(ReadedLine); continue; }
                                    else if ((Sitution != string.Empty) && (Sitution == ReadedLine.Substring(7, 11)))
                                    { SB.AppendLine(ReadedLine); continue; }
                                    else if ((Sitution != string.Empty) && (Sitution != ReadedLine.Substring(7, 11)))
                                    { Sitution = ReadedLine.Substring(7, 11); LoadsAnnouncement(SB); SB.Clear(); SB.Append(ReadedLine); continue; }
                                }
                                else
                                { SB.AppendLine(ReadedLine); continue; }
                            }
                            //حذف فایل اعلام بار شرکت با حفظ سابقه
                            WS.WebMethodDeleteFileButKeepDeleted(R2CoreRawGroups.UploadedFiles, MSCOFileName, WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword));
                        }
                        catch (Exception ex) when
                          (ex is MSCOCoreAnnounceforTransportCompanyIsNotActiveException ||
                           ex is MSCOCoreTransportCompanyNotFoundException ||
                           ex is MSCOCoreMSCOTCFileNotFoundException ||
                           ex is Exception)
                        {
                            if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message.Substring(0, 80) + TransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                        }
                    }
                }
                catch (MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException ex)
                { throw ex; }
                catch (MSCOCoreAnnouncementforTransportCompaniesIsnotActiveException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }
            }

        }

        namespace Exceptions
        {
            public class MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException : ApplicationException
            {
                public override string Message
                {
                    get { return "زمان سیستم درحال حاضر در یکی از مراحل اول و یا دوم اعلام بار قرار ندارد  "; }
                }
            }

            public class MSCOCoreMSCOTCFileNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "فایل اعلام بار شرکت حمل و نقل موجود نیست"; }
                }
            }

            public class MSCOCoreFilefromMSCORefrenceNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "فایل متنی مرجع اعلام بار فولاد مبارکه موجود نیست"; }
                }
            }

            public class MSCOCoreAnnouncementforTransportCompaniesIsnotActiveException : ApplicationException
            {
                public override string Message
                {
                    get { return "سرویس اعلام بار و ارسال ایمیل درخصوص اعلام بار فولاد غیرفعال است"; }
                }
            }

            public class MSCOCoreAnnounceforTransportCompanyIsNotActiveException : ApplicationException
            {
                public override string Message
                {
                    get { return "اعلام بار خودکار شرکت غیرفعال است"; }
                }
            }

        }
    }

    namespace MSCOTargets
    {
        public class MSCOMClassMSCOTargetsManager
        {
            public R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure GetNSSLoadTarget(string YourMSCOTargetId)
            {
                try
                {
                    DataSet DS = null;
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(), @"Select Top 1 CityId from MSCO.dbo.TblMSCOTargets Where MSCOCityId = '" + YourMSCOTargetId + "'  and RelationActive = 1 Order By OId Desc", 3600, ref DS).GetRecordsCount() != 0)
                    { return R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetNSSLoadTarget(Convert.ToInt64(DS.Tables[0].Rows[0]["CityId"])); }
                    else
                    { throw new MSCOCoreMSCOTargetnotfoundException(); }
                }
                catch (MSCOCoreMSCOTargetnotfoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }
            }


        }

        namespace Exceptions
        {
            public class MSCOCoreMSCOTargetnotfoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "مقصد حمل با کد پایه فولاد یافت نشد"; }
                }
            }

        }
    }

    namespace MSCOTransportCompanies
    {
        public class MSCOCoreMClassTransportCompaniesManager
        {
            public R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure GetNSSTransportCompany(string YourMSCOId)
            {
                try
                {
                    var DS = new System.Data.DataSet();
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    var InstanceTransportCompanies = new R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                         @"Select Top 1 TransportCompanies.TCId from MSCO.dbo.TblMSCOTransportCompanies as MSCOTransportCompanies
                             Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On MSCOTransportCompanies.TCId = TransportCompanies.TCId
                          Where ltrim(rtrim(MSCOTransportCompanies.MSCOId)) = '" + YourMSCOId + "' Order By MSCOTransportCompanies.DateTimeMilladi Desc", 3600, ref DS).GetRecordsCount() == 0) { throw new MSCOCoreTransportCompanyNotFoundException(); };
                    return InstanceTransportCompanies.GetNSSTransportCompany(System.Convert.ToInt64(DS.Tables[0].Rows[0]["TCId"]));
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            public bool IsActiveTransportCompanySentMail(string YourMSCOId)
            {
                try
                {
                    System.Data.DataSet DS = null;
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                         @"Select SendEmail from MSCO.dbo.TblMSCOTransportCompanies Where MSCOId='" + YourMSCOId + "'", 3600, ref DS).GetRecordsCount() == 0) { throw new MSCOCoreTransportCompanyNotFoundException(); };
                    return System.Convert.ToBoolean(DS.Tables[0].Rows[0]["SendEmail"]);
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            public bool IsActiveTransportCompanyAnnounce(string YourMSCOId)
            {
                try
                {
                    System.Data.DataSet DS = null;
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                         @"Select Announce from MSCO.dbo.TblMSCOTransportCompanies Where MSCOId='" + YourMSCOId + "'", 3600, ref DS).GetRecordsCount() == 0) { throw new MSCOCoreTransportCompanyNotFoundException(); };
                    return System.Convert.ToBoolean(DS.Tables[0].Rows[0]["Announce"]);
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

        }

        namespace Exceptions
        {
            public class MSCOCoreTransportCompanyNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "شرکت حمل و نقل با پایه اطلاعات فولاد مرتبط با شرکتی در سامانه آتیس یافت نشد"; }
                }
            }
        }

    }

    namespace Configurations
    {
        public abstract class MSCOCoreConfigurations : R2CoreConfigurations
        { public static readonly Int64 MSCO = 82; }

    }

    namespace Logging
    {
        public abstract class MSCOCoreloggings : R2CoreLogType
        { public static readonly Int64 MSCOLogs = 63; }

    }

}
