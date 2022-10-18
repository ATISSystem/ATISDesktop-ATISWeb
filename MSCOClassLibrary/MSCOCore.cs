
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
using MSCOCore.MSCOProducts.Exceptions;
using MSCOCore.MSCOLoadTypes.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions;
using R2CoreTransportationAndLoadNotification.TransportCompanies.Exceptions;
using R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions;
using R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions;

namespace MSCOCore
{
    namespace AnnouncementProcessManagement
    {
        public class MSCOCoreAnnouncementforTransportCompaniesManager
        {
            private R2DateTime _DateTime = new R2DateTime();
            private R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService WS = new R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService();

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

            private R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure GetNSS(StringBuilder YourSB, R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                try
                {
                    var Lines = YourSB.ToString().Split('\n');
                    string myMSCOId = string.Empty, mySituation = string.Empty, myNL = string.Empty, myFirstDate = string.Empty, myFirstTime = string.Empty, mySecondDate = string.Empty, mySecondTime = string.Empty, myTargetId = string.Empty;
                    Int64 myTonaj = 0, mynCarNumKol = 1;
                    string mynoEmptyingDays = string.Empty, myLoadingLocations = string.Empty, myLBN = string.Empty, myLTN = string.Empty, myMSCOProductId = string.Empty;
                    Int16 myMultiLoads = 0;

                    for (int Loopx = 0; Loopx <= Lines.Length - 1; Loopx++)
                    {
                        if (Lines[Loopx].Trim() == string.Empty) { continue; }
                        if (Lines[Loopx].Substring(18, 1) == "N" || Lines[Loopx].Substring(18, 1) == "L")
                        {
                            if (Lines[Loopx].Substring(18, 1) == "L") { myMultiLoads += 1; }
                            myMSCOId = Lines[Loopx].Substring(0, 7);
                            mySituation = Lines[Loopx].Substring(7, 11);
                            myNL = Lines[Loopx].Substring(18, 1);
                            myFirstDate = Lines[Loopx].Substring(19, 8);
                            myFirstTime = Lines[Loopx].Substring(27, 4);
                            mySecondDate = Lines[Loopx].Substring(31, 8);
                            mySecondTime = Lines[Loopx].Substring(39, 4);
                            myTargetId = Lines[Loopx].Substring(43, 5);
                            myTonaj = myTonaj + Convert.ToInt64(Lines[Loopx].Substring(90, 5));
                            myLoadingLocations = (myLoadingLocations == string.Empty) ? Lines[Loopx].Substring(117, 2).Trim() : myLoadingLocations + "," + Lines[Loopx].Substring(117, 2).Trim();
                            myMSCOProductId = Lines[Loopx].Substring(134, 2).Trim();
                            myLBN = (myLBN == string.Empty) ? Lines[Loopx].Substring(269, 3).Trim() : myLBN;
                            continue;
                        }
                        mynoEmptyingDays = (mynoEmptyingDays == string.Empty) ? (((Loopx + 1) % 3) == 0 ? Lines[Loopx].Substring(221, 9).Trim() : string.Empty) : mynoEmptyingDays;
                        myLTN = (myLTN == string.Empty) ? (((Loopx + 1) % 3) == 0 ? Lines[Loopx].Substring(214, 3).Trim() : string.Empty) : myLTN;
                    }

                    var InstanceMSCOTargets = new MSCOMClassMSCOTargetsManager();
                    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                    var InstanceProducts = new MSCOCore.MSCOProducts.MSCOCoreMClassProductsManager();
                    var NSS = new R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure();

                    NSS.nEstelamId = 0;
                    NSS.nEstelamKey = string.Empty;
                    try
                    { NSS.nCityCode = InstanceMSCOTargets.GetNSSLoadTarget(myTargetId).NSSCity.nCityCode; }
                    catch (Exception ex)
                    { throw new Exception("مقصدحمل یافت نشد.شماره موقعیت: " + mySituation); }
                    NSS.nTonaj = double.Parse((Convert.ToInt64(myTonaj) / (double)1000).ToString());
                    NSS.nBarCode = InstanceProducts.GetProductId(myMSCOProductId);
                    NSS.nUserId = YourNSSSoftwareUser.UserId;
                    NSS.nCarNumKol = mynCarNumKol;
                    NSS.nCompCode = InstanceTransportCompanies.GetNSSTransportCompany(myMSCOId).TCId;
                    NSS.IsSpecialLoad = false;
                    NSS.nTruckType = InstanceMSCOTargets.GetNSSLoadTarget(myTargetId).NSSCity.nProvince == 21 ? 807 : 805;
                    NSS.StrAddress = string.Empty;
                    NSS.StrBarName = (myMSCOProductId == string.Empty) ? string.Empty : ("موقعیت: " + mySituation + " " + myLoadingLocations);
                    if (myNL == "L") { NSS.StrBarName += (myNL == "L") ? "\n" + myMultiLoads.ToString() + " باسکول " : string.Empty; }
                    NSS.StrPriceSug = 0;
                    NSS.StrDescription = "بارگیری از " + myFirstDate + " ساعت: " + myFirstTime + " تا " + mySecondDate + " ساعت: " + mySecondTime + "\n";
                    if (mynoEmptyingDays != string.Empty) { NSS.StrDescription = NSS.StrDescription + "روزهای عدم تخلیه: " + mynoEmptyingDays + "\n"; }
                    if (myLBN != string.Empty) { NSS.StrDescription = NSS.StrDescription + "لبه دار بارگیری ندارد" + "\n"; }
                    if (myLTN != string.Empty) { NSS.StrDescription = NSS.StrDescription + "لبه دار تخلیه ندارد"; }
                    return NSS;
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (MSCOCoreMSCOTargetnotfoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }
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

            private void LoadsAnnouncement(StringBuilder YourSB, R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                try
                {
                    var InstanceLoadCapacitorLoadManipulation = new R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var CurrentShamsiDate = _DateTime.GetCurrentDateShamsiFullWithoutSlashes();
                    var NextShamsiDate = _DateTime.GetNextDateShamsiWithoutSlashes();
                    var myFirstDate = YourSB.ToString().Substring(19, 8);
                    var myFirstTime = _DateTime.GetDelimetedTime(YourSB.ToString().Substring(27, 4));

                    if (myFirstDate == CurrentShamsiDate)
                    {
                        if (GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB, YourNSSSoftwareUser)); return; }
                        else { return; }
                    }
                    else if (myFirstDate == NextShamsiDate)
                    {
                        if (TimeSpan.ParseExact(myFirstTime, @"hh\:mm\:ss", CultureInfo.InvariantCulture) <= TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 9), @"hh\:mm\:ss", CultureInfo.InvariantCulture))
                        {
                            if (GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB, YourNSSSoftwareUser)); return; }
                            else { return; }
                        }
                        else
                        { if (!GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB, YourNSSSoftwareUser)); return; } }
                    }
                    else
                    { if (!GetAnnounceFirstStep()) { InstanceLoadCapacitorLoadManipulation.LoadCapacitorLoadRegistering(GetNSS(YourSB, YourNSSSoftwareUser)); return; } }
                }
                catch (Exception ex) when
                  (ex is LoadCapacitorLoadNumberOverLimitException ||
                   ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException ||
                   ex is TransportCompanyISNotActiveException ||
                   ex is LoadCapacitorLoadRegisterTimePassedException ||
                   ex is TimingNotReachedException ||
                   ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException ||
                   ex is MSCOCoreTransportCompanyNotFoundException ||
                   ex is HasNotRelationBetweenProvinceAndAnnouncementHallSubGroup ||
                   ex is MSCOCoreMSCOTargetnotfoundException)
                { throw ex; }
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
                        var MSCOFileName = string.Empty;
                        try
                        {
                            //کنترل فعال بودن اعلام بار شرکت 
                            if (!InstanceTransportCompanies.IsActiveTransportCompanyAnnounce(TransportCompanyCode)) { throw new MSCOCoreAnnounceforTransportCompanyIsNotActiveException(); }

                            //کنترل موجود بودن فایل اعلام بار شرکت
                            MSCOFileName = InstanceConfiguration.GetConfigString(Configurations.MSCOCoreConfigurations.MSCO, 8) + _DateTime.GetCurrentDateShamsiFullWithoutSlashes() + TransportCompanyCode + (GetAnnounceFirstStep() ? ".Txt" : ".Txt.del");
                            if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, MSCOFileName + ".del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
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
                                string NLPart = string.Empty;
                                if (sr.EndOfStream) { LoadsAnnouncement(SB, YourNSSSoftwareUser); SB.Clear(); break; }
                                try
                                { NLPart = ReadedLine.Substring(18, 1); }
                                catch (Exception ex) { SB.AppendLine(ReadedLine); continue; }
                                if ((NLPart == "N" || NLPart == "L"))
                                {
                                    if (Sitution == string.Empty)
                                    { Sitution = ReadedLine.Substring(7, 11); SB.AppendLine(ReadedLine); continue; }
                                    else if ((Sitution != string.Empty) && (Sitution == ReadedLine.Substring(7, 11)))
                                    { SB.AppendLine(ReadedLine); continue; }
                                    else if ((Sitution != string.Empty) && (Sitution != ReadedLine.Substring(7, 11)))
                                    { Sitution = ReadedLine.Substring(7, 11); LoadsAnnouncement(SB, YourNSSSoftwareUser); SB.Clear(); SB.Append(ReadedLine); continue; }
                                }
                                else
                                { SB.AppendLine(ReadedLine); continue; }
                            }
                        }
                        catch (Exception ex) when
                          (ex is LoadCapacitorLoadNumberOverLimitException ||
                           ex is LoadCapacitorLoadnCarNumKolCanNotBeZeroException ||
                           ex is TransportCompanyISNotActiveException ||
                           ex is LoadCapacitorLoadRegisterTimePassedException ||
                           ex is TimingNotReachedException ||
                           ex is LoadCapacitorLoadRegisteringNotAllowedforThisAnnouncementHallSubGroupException ||
                           ex is MSCOCoreLoadsAnnouncementforTransportCompaniesFirstOrSecondStepNotReachedException ||
                           ex is MSCOCoreAnnounceforTransportCompanyIsNotActiveException ||
                           ex is MSCOCoreTransportCompanyNotFoundException ||
                           ex is MSCOCoreMSCOTCFileNotFoundException ||
                           ex is MSCOCoreMSCOTargetnotfoundException ||
                           ex is Exception)
                        {
                            if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, ex.Message + TransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                        }
                        //حذف فایل اعلام بار شرکت با حفظ سابقه
                        if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, MSCOFileName, WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))
                        { WS.WebMethodDeleteFileButKeepDeleted(R2CoreRawGroups.UploadedFiles, MSCOFileName, WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)); }
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

    namespace MSCOProducts
    {
        public class MSCOCoreMClassProductsManager
        {
            public Int64 GetProductId(string YourMSCOProductTitle)
            {
                try
                {
                    var DS = new System.Data.DataSet();
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                         @"Select Top 1 MSCOProducts.ProductId from MSCO.dbo.TblMSCOProducts as MSCOProducts
                           Where ltrim(rtrim(MSCOProducts.MSCOProductTitle)) = '" + YourMSCOProductTitle + "'" +
                           " and MSCOProducts.Active=1 and MSCOProducts.Deleted=0 Order By MSCOProducts.DateTimeMilladi Desc", 3600, ref DS).GetRecordsCount() == 0) { throw new MSCOCoreProductNotFoundException(); };
                    return System.Convert.ToInt64(DS.Tables[0].Rows[0]["ProductId"]);
                }
                catch (MSCOCoreProductNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }

            }
        }

        namespace Exceptions
        {
            public class MSCOCoreProductNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "محصول با اطلاعات پایه فولاد یافت نشد"; }
                }
            }
        }

    }

    namespace MSCOLoadTypes
    {
        public class MSCOCoreMClassLoadTypesManager
        {
            public string GetDescription(string YourMSCOLoadTypeTitle)
            {
                try
                {
                    var DS = new System.Data.DataSet();
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(),
                         @"Select Top 1 MSCOLoadTypes.Description from MSCO.dbo.TblMSCOLoadTypes as MSCOLoadTypes
                           Where ltrim(rtrim(MSCOLoadTypes.MSCOLoadTypeTitle)) = '" + YourMSCOLoadTypeTitle + "'" +
                           " and MSCOLoadTypes.Active=1 and MSCOLoadTypes.Deleted=0 Order By MSCOLoadTypes.DateTimeMilladi Desc", 3600, ref DS).GetRecordsCount() == 0) { throw new MSCOCoreLoadTypeTitleNotFoundException(); };
                    return System.Convert.ToString(DS.Tables[0].Rows[0]["Description"]);
                }
                catch (MSCOCoreLoadTypeTitleNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }
        }

        namespace Exceptions
        {
            public class MSCOCoreLoadTypeTitleNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "نوع بار با اطلاعات پایه فولاد یافت نشد"; }
                }
            }
        }

    }

}
