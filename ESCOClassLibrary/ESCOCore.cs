using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;

using ESCOCore.Configurations;
using ESCOCore.Exceptions;
using R2Core.BaseStandardClass;
using R2Core.ConfigurationManagement;
using R2Core.DateAndTimeManagement;
using R2Core.DatabaseManagement;
using R2Core.SoftwareUserManagement;
using R2Core.SMS;

namespace ESCOCore
{
    namespace SendSMS
    {
        public class ESCOCoreSendSMSStructure
        {
            public ESCOCoreSendSMSStructure()
            {
                MsgId = Int64.MinValue;
                Msg1 = String.Empty;
                Msg2 = String.Empty;
                DateTimeMilladi = DateTime.Now;
                ShamsiDate = String.Empty;
                Time = string.Empty;
                UserId = long.MinValue;
                SentStatus = false;
            }
            public ESCOCoreSendSMSStructure(Int64 YourMsgId, string YourMsg1, string YourMsg2, DateTime YourDateTimeMilladi, string YourShamsiDate, string YourTime, Int64 YourUserId, bool YourSentStatus)
            {
                MsgId = YourMsgId;
                Msg1 = YourMsg1;
                Msg2 = YourMsg2;
                DateTimeMilladi = YourDateTimeMilladi;
                ShamsiDate = YourShamsiDate;
                Time = YourTime;
                UserId = YourUserId;
                SentStatus = YourSentStatus;
            }

            public Int64 MsgId;
            public string Msg1;
            public string Msg2;
            public DateTime DateTimeMilladi;
            public string ShamsiDate;
            public string Time;
            public Int64 UserId;
            public bool SentStatus;

        }

        public class ESCOCoreSendSMSManager
        {
            private R2DateTime _DateTime = new R2DateTime();

            private string GetAnnouncedLoadsReport()
            {
                //بار اعلام شده      
                try
                {
                    var TodayShamsiDate = _DateTime.GetCurrentDateShamsiFull();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var AHSGIds = InstanceConfiguration.GetConfigString(ESCOCoreConfigurations.ESCO, 2).Split('-');
                    var AHSGIdsSqlString = string.Empty;
                    for (int Loopx = 0; Loopx <= AHSGIds.Length - 1; Loopx++)
                    {
                        if (Loopx == 0)
                        { AHSGIdsSqlString = AHSGIdsSqlString + "Loads.AHSGId=" + AHSGIds[Loopx]; }
                        else
                        { AHSGIdsSqlString = AHSGIdsSqlString + " or Loads.AHSGId=" + AHSGIds[Loopx]; }
                    }
                    DataSet DS = null;
                    var InstanceSqlDataBOX = new R2Core.DatabaseManagement.R2CoreInstanseSqlDataBOXManager();

                    //if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(), "Select Loads.nBarCode,Products.strGoodName, Count(*) as Jam from dbtransport.dbo.tbEnterExit as Turns Inner Join dbtransport.dbo.tbElam as Loads On Turns.nEstelamID = Loads.nEstelamID Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode = Products.strGoodCode Where Turns.strExitDate = '" + TodayShamsiDate + "' and Turns.LoadPermissionStatus = 1 and (" + AHSGIdsSqlString + ") Group By Loads.nBarCode, Products.strGoodName", 300, ref DS).GetRecordsCount() == 0)
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(), "Select Loads.nBarCode,Products.strGoodName, sum(Loads.nCarNumKol) as Jam from dbtransport.dbo.tbElam AS Loads Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode = Products.strGoodCode Where Loads.dDateElam = '" + TodayShamsiDate + "' and (LoadStatus <> 3 and LoadStatus <> 4 and LoadStatus <> 6) and (" + AHSGIdsSqlString + ") Group By Loads.nBarCode, Products.strGoodName", 300, ref DS).GetRecordsCount() == 0)
                    { return string.Empty  ; }

                    StringBuilder SB = new StringBuilder();
                    SB.AppendLine(InstanceConfiguration.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle,4));
                    SB.AppendLine(TodayShamsiDate);
                    for (int loopx = 0; loopx <= DS.Tables[0].Rows.Count - 1; loopx++)
                    { SB.AppendLine(DS.Tables[0].Rows[loopx]["strGoodName"].ToString() + " - " + DS.Tables[0].Rows[loopx]["Jam"].ToString()); }
                    return SB.ToString();
                }
                catch (Exception ex)
                { throw ex; }
            }

            private bool WasSendedSMSToday()
            {
                try
                {
                    DataSet DS = null;
                    var InstanceSqlDataBOX = new R2CoreInstanseSqlDataBOXManager();
                    if (InstanceSqlDataBOX.GetDataBOX(new R2PrimarySqlConnection(), "Select * from ESCO.dbo.TblMessages Where ShamsiDate='" + _DateTime.GetCurrentDateShamsiFull() + "' and SentStatus=1", 0, ref DS).GetRecordsCount() == 0)
                    { return false; }
                    else
                    { return true; }
                }
                catch (Exception ex)
                { throw ex; }
            }

            public void SendSMSofAnnouncedLoads(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = (new R2PrimarySqlConnection()).GetConnection();

                try
                {
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();

                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(ESCOCoreConfigurations.ESCO, 0)) { throw new ESCOCoreSendSMSISNotActiveException(); }
                    //کنترل زمان اجرای فرآیند
                    var TimeofDay = _DateTime.GetCurrentTime();
                    if (!((TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) > TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(ESCOCoreConfigurations.ESCO, 1).Split('-')[0], @"hh\:mm\:ss", CultureInfo.InvariantCulture)) &
                       (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(ESCOCoreConfigurations.ESCO, 1).Split('-')[1], @"hh\:mm\:ss", CultureInfo.InvariantCulture))))
                    { return; }
                    //کنترل این که پیام امروز ارسال شده است یا نه
                    if (WasSendedSMSToday())
                    { return; }

                    var Msg =GetAnnouncedLoadsReport();
                    //درج رکورد
                    SqlCmd.CommandText = "Insert Into ESCO.dbo.TblMessages(Msg1,Msg2,DateTimeMilladi,ShamsiDate,Time,UserId,SentStatus) Values('" + Msg + "','','" + _DateTime.GetCurrentDateTimeMilladiFormated() + "','" + _DateTime.GetCurrentDateShamsiFull() + "','" + _DateTime.GetCurrentTime() + "'," + YourNSSSoftwareUser.UserId + ",1)";
                    SqlCmd.Connection.Open();
                    SqlCmd.ExecuteNonQuery();
                    SqlCmd.Connection.Close();

                    //ارسال اس ام اس
                    if (!(Msg ==string.Empty))
                    {
                        var TargetMobileNumbers = InstanceConfiguration.GetConfigString(ESCOCoreConfigurations.ESCO, 3).Split('-');
                        R2CoreSMSSendRecive SMSSender = new R2CoreSMSSendRecive();
                        for (int Loopx = 0; Loopx <= TargetMobileNumbers.Length - 1; Loopx++)
                        { SMSSender.SendSms(new R2CoreStandardSMSStructure(Int64.MinValue, TargetMobileNumbers[Loopx], Msg, 6, _DateTime.GetCurrentDateTimeMilladi(), true, null, null)); }
                    }

                }
                catch (ESCOCoreSendSMSISNotActiveException ex)
                { /*No Activity Needed*/}
                catch (Exception ex)
                {
                    if (SqlCmd.Connection.State != ConnectionState.Closed) { SqlCmd.Connection.Close(); }
                    throw ex;
                }
            }

        }

    }

    namespace Configurations
    {
        public abstract class ESCOCoreConfigurations : R2CoreConfigurations
        { public static readonly Int64 ESCO = 85; }

    }

    namespace Exceptions
    {
        public class ESCOCoreSendSMSISNotActiveException : ApplicationException
        {
            public override string Message
            {
                get { return "سرویس ارسال اس ام اس ذوب آهن اصفهان غیرفعال است"; }
            }
        }

    }

}


