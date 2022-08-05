
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
using System.Globalization;
using R2Core.BaseStandardClass;
using R2Core.LoggingManagement;
using R2Core.Email.Exceptions;
using MSCOCore.Logging;

namespace MSCOCore
{
    namespace AnnouncementProcessManagement
    {
        public class MSCOCoreSendingAnnounceEmailforTransportCompaniesManager
        {
            private R2DateTime _DateTime = new R2DateTime();

            public MSCOCoreSendingAnnounceEmailforTransportCompaniesManager()
            { }

            private void  SentMail(string  YourTransportCompanyCode ,StringBuilder YourSB, R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                var InstanceLogging = new R2CoreInstanceLoggingManager();
                var InstanceEmail = new R2CoreEmailManager();
                var InstanceConfiguration = new R2CoreInstanceConfigurationManager();

                try
                {
                    if (InstanceTransportCompanies.IsActiveTransportCompanySentMail(YourTransportCompanyCode))
                    {InstanceEmail.SendEmailWithTXTTypeAttachment(InstanceTransportCompanies.GetNSSTransportCompany(YourTransportCompanyCode).EmailAddress, YourSB, "اعلام بار", string.Empty, YourTransportCompanyCode + InstanceConfiguration.GetConfigString(MSCOCore.Configurations.MSCOCoreConfigurations.MSCO, 4));                                         }
                }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                {
                    if (InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, MSCOCoreloggings.MSCOLogs, InstanceLogging.GetNSSLogType(MSCOCoreloggings.MSCOLogs).LogTitle, "TransportCompanyCode not found:" + YourTransportCompanyCode, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                }
                catch (R2CoreEmailSystemIsNotActiveException ex)
                { throw ex; }
                catch (Exception ex)
                { throw ex; }


            }

            public void SendingAnnounceEmailforTransportCompanies(R2CoreStandardSoftwareUserStructure  YourNSSSoftwareUser )
            {
                try
                {
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceEmail = new R2CoreEmailManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstanceTransportCompanies = new MSCOCoreMClassTransportCompaniesManager();
                    var InstanceLogging = new R2CoreInstanceLoggingManager();

                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(Configurations.MSCOCoreConfigurations.MSCO, 0)) { throw new MSCOCoreSendingAnnounceEmailforTransportCompaniesIsnotActiveException(); }
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
                    var TransportCompanyCode = OtherLine.Substring(0, 7);
                    SB.AppendLine(OtherLine);

                    while (!(sr.EndOfStream))
                    {
                        OtherLine = sr.ReadLine();
                        if (OtherLine == String.Empty)
                        {
                            SB.AppendLine(OtherLine);
                            if (sr.EndOfStream)
                            {
                                SentMail(TransportCompanyCode ,SB,YourNSSSoftwareUser );
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
                                //ایمیل اطلاعات
                                SentMail(TransportCompanyCode, SB, YourNSSSoftwareUser);
                                System.Threading.Thread.Sleep(5000);
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
                                SentMail(TransportCompanyCode, SB, YourNSSSoftwareUser);
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
                catch (MSCOCoreSendingAnnounceEmailforTransportCompaniesIsnotActiveException ex)
                { throw ex; }
                catch (MSCOCoreTransportCompanyNotFoundException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }


        }

        namespace Exceptions
        {
            public class MSCOCoreFilefromMSCORefrenceNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "فایل متنی مرجع اعلام بار فولاد مبارکه موجود نیست"; }
                }
            }

            public class MSCOCoreSendingAnnounceEmailforTransportCompaniesIsnotActiveException : ApplicationException
            {
                public override string Message
                {
                    get { return "سرویس ارسال ایمیل درخصوص اعلام بار فولاد غیرفعال است"; }
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
                    System.Data.DataSet DS=null ;
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


        }

        namespace Exceptions
        {
            public class MSCOCoreTransportCompanyNotFoundException : ApplicationException
            {
                public override string Message
                {
                    get { return "شرکت حمل و نقل با پایه اطلاعات فولاد یافت نشد"; }
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
