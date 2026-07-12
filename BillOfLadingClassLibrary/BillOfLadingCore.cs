

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

using R2Core.ConfigurationManagement;
using R2Core.DatabaseManagement;
using R2Core.DateAndTimeManagement;
using R2Core.Email;
using R2Core.FileShareRawGroupsManagement;
using R2Core.SoftwareUserManagement;
using R2Core.BaseStandardClass;
using R2Core.LoggingManagement;
using R2Core.Email.Exceptions;
using R2Core.PublicProc;
using R2Core.SMS;
using R2Core.SMS.SMSHandling;
using PayanehClassLibrary.CarTruckNobatManagement;
using PayanehClassLibrary.CarTruckNobatManagement.Exceptions;
using PayanehClassLibrary.DriverTrucksManagement.Exceptions;
using R2Core.ExceptionManagement;
using R2Core.PermissionManagement.Exceptions;
using R2Core.SecurityAlgorithmsManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.Turns.Exceptions;
using R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions;
using R2CoreParkingSystem.EnterExitManagement;
using R2CoreTransportationAndLoadNotification.Trucks.Exceptions;
using R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions;
using R2CoreParkingSystem.MoneyWalletManagement;
using R2CoreParkingSystem.TrafficCardsManagement.ExceptionManagement;
using R2CoreTransportationAndLoadNotification.ConfigurationsManagement;
using PayanehClassLibrary.SMS.SMSTypes;
using BillOfLadingCore.SMS.SMSTypes;
using BillOfLadingCore.Exceptions;
using BillOfLadingCore.Logging;
using R2CoreTransportationAndLoadNotification.TransportCompanies;
using PayanehClassLibrary.TransportCompanies;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using R2Core.NetworkInternetManagement.Exceptions;
using R2CoreTransportationAndLoadNotification.Rmto;
using R2CoreTransportationAndLoadNotification.TruckLoaderTypes;
using R2CoreTransportationAndLoadNotification.TruckLoaderTypes.Exceptions;
using R2CoreParkingSystem.City;
using BillOfLadingCore.BillOfLadingControl.BillOfLadingControlInfraction.Exceptions;
using BillOfLadingCore.BillOfLadingControl.BillOfLadingControl;
using BillOfLadingCore.BillOfLadingControl.BillOfLadingControl.Exceptions;
using static BillOfLadingCore.BillOfLadingControl.BillOfLadingControl.Exceptions.BillOfLadingControlMustHaveTitleForRegisteringException;
using R2CoreTransportationAndLoadNotification.Turns;
using PayanehClassLibrary.Logging;
using R2CoreTransportationAndLoadNotification.LoadPermission;
using R2CoreTransportationAndLoadNotification.Trucks;
using R2CoreTransportationAndLoadNotification.AnnouncementTiming;
using static System.Net.WebRequestMethods;
using BillOfLadingClassLibrary.ir.rmto.bar;
using PayanehClassLibrary.ConfigurationManagement;

namespace BillOfLadingCore
{
    namespace BillOfLading
    {
        public class BillOfLadingCoreBillOfLadingConditionedAnnouncementManager
        {
            static bool _FirstTimeExecute = true;
            private R2DateTime _DateTime = new R2DateTime();
            private R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService WS = new R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService();
            private List<long> LstTurnStatuses = new List<long>() { 2, 3, 4, 5, 6, 11 };

            public BillOfLadingCoreBillOfLadingConditionedAnnouncementManager()
            { }

            public void AttachBillOfLadingToLoadPermission(Int64 YournEstelamId, Int64 YourTurnId, String YourBillOfLadingNumber)
            {
                var CmdSql = new System.Data.SqlClient.SqlCommand();
                CmdSql.Connection = (new R2PrimarySqlConnection()).GetConnection();
                try
                {
                    if (YourBillOfLadingNumber == String.Empty) { return; }
                    CmdSql.Connection.Open();
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction();
                    CmdSql.CommandText = "Update dbtransport.dbo.tbEnterExit Set BillOfLadingNumber='" + YourBillOfLadingNumber + "' Where nEnterExitId=" + YourTurnId + "";
                    CmdSql.ExecuteNonQuery();
                    CmdSql.Transaction.Commit(); CmdSql.Connection.Close();
                }
                catch (Exception ex)
                {
                    if (CmdSql.Connection.State != ConnectionState.Closed)
                    { CmdSql.Transaction.Rollback(); CmdSql.Connection.Close(); }
                    throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                }
            }

            public void TurnsCancellationforNoBillOfLading(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                try
                {
                    var InstanceLogging = new R2CoreInstanceLoggingManager();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                    var InstanceMClassCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();

                    /*سرویس یک مرتبه اجرا می گردد*/
                    if (!_FirstTimeExecute) { return; }
                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 4)) { throw new BillOfLadingCoreTurnsCancellationByNoBillOfLadingIsnotActiveException(); }
                    //کنترل زمان اجرای فرآیند
                    var TimeofDay = _DateTime.GetCurrentTime();
                    if ((TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 5), @"hh\:mm\:ss", CultureInfo.InvariantCulture)) ||
                        (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) > TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 6), @"hh\:mm\:ss", CultureInfo.InvariantCulture))) { return; }
                    //کنترل موجود بودن فایل مرجع بارنامه
                    if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "NB" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".xlsx.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword))) { return; }
                    if (!(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "NB" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".xlsx", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))) { throw new BillOfLadingCoreFilefromRefrenceNotFoundException(); }
                    /*خواندن فایل از سرور فایل و کپی آن به فولدر اپ دیتا موقت*/
                    string tempFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "NB" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".xlsx";

                    using (var fileStream = System.IO.File.Create(tempFilePath))
                    {
                        var ms = new System.IO.MemoryStream(WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "NB" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".xlsx", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)));
                        ms.CopyTo(fileStream);
                    }
                    /*123456789123*/
                    /*123*/
                    /*لیست ناوگان بدون بارنامه*/
                    OleDbDataAdapter DaBillOfLading = new OleDbDataAdapter(); DataSet DsBillOfLading = new DataSet();


                    var TotalTurn = 0;
                    /*بررسی نوبت های فعال*/
                    for (int LoopBillOfLading = 0; LoopBillOfLading <= LstActiveTurns.Count - 1; LoopBillOfLading++)
                    {
                        /*لیست بارنامه ها از فایل موقت ایجاد شده*/
                        var Turn = LstActiveTurns[LoopBillOfLading];
                        var Concating = Turn.EnterDate + Turn.EnterTime.Substring(0, 5);
                        DaBillOfLading.SelectCommand = new OleDbCommand("Select * from TblXX Where TruckSmartCardNo='" + Turn.TruckSmartCardNo + "' and ((RegisteringDate+RegisteringTime)>='" + Concating + "')");
                        DaBillOfLading.SelectCommand.Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + tempFilePath + "'");
                        bool PelakSerial = false;
                        DsBillOfLading.Clear();
                        if (DaBillOfLading.Fill(DsBillOfLading) <= 0)
                        {
                            DaBillOfLading.SelectCommand.CommandText = "Select * from TblXX Where ( MID(TBLXX.[PELAK],4,3)+MID(TBLXX.[PELAK],3,1)+MID(TBLXX.[PELAK],1,2))='" + Turn.Pelak + "' and Serial='" + Turn.Serial + "' and ((RegisteringDate+RegisteringTime)>='" + Concating + "')";
                            DsBillOfLading.Clear();
                            if (DaBillOfLading.Fill(DsBillOfLading) <= 0)
                            {    /*ناوگان هیچ بارنامه ای بعد از صدور نوبت ندارد*/
                                continue;
                            }
                            else { PelakSerial = true; }
                        }
                        else { PelakSerial = false; }

                        if (DsBillOfLading.Tables[0].Rows.Count > 1)
                        {/*بیش از یک بارنامه بعد از نوبت فعال دارد*/}
                        else
                        {/*فقط یک بارنامه بعد از نوبت فعال دارد که ممکن است جزو نوبت های خودکار و شهری باشد*/
                            if (Turn.nUserIdEnter == R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId)
                            { /*نوبت در ساعات عادی نوبت خودکار توسط سیستم صادر نشده است*/
                                if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "NoAction : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, DsBillOfLading.Tables[0].Rows.Count.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                                continue;
                            }
                            else
                            { }
                        }

                        /*ابطال نوبت */
                        try
                        {
                            InstanceMClassCarTruckNobat.TurnCancellationWithLicensePlate(Turn.Pelak, Turn.Serial, YourNSSSoftwareUser, TurnStatuses.CancelledSystem);
                            if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "Action : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, DsBillOfLading.Tables[0].Rows.Count.ToString() + " " + PelakSerial.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                            TotalTurn += 1;
                        }
                        catch (Exception ex)
                        {
                            if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, ex.Message, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                        }
                    }

                    /*ثبت لاگ تعداد باطل شده*/
                    if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "TotalTurn=" + LstActiveTurns.Count.ToString(), "TotalTurnCancelled=" + TotalTurn.ToString(), string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }

                    /*حذف فایل موقت از اپ دیتا*/
                    System.IO.File.Delete(tempFilePath);

                    ////حذف فایل با حفظ سابقه
                    WS.WebMethodDeleteFileButKeepDeleted(R2CoreRawGroups.UploadedFiles, "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword));

                    /*ارسال اس ام اس اتمام موفقیت آمیز*/
                    SendSMSSuccess(TotalTurn, _DateTime.GetCurrentDateShamsiFull());

                    /*سرویس یک مرتبه اجرا شده است*/
                    _FirstTimeExecute = false;
                }
                catch (BillOfLadingCoreTurnsCancellationByNoBillOfLadingIsnotActiveException ex)
                { throw ex; }
                catch (BillOfLadingCoreFilefromRefrenceNotFoundException ex)
                { throw ex; }
                catch (Exception ex) when (ex is RequesterNotAllowTurnIssueBySeqTException || ex is RequesterNotAllowTurnIssueByLastLoadPermissionedException || ex is TruckRelatedSequentialTurnNotFoundException ||
                                           ex is CarIsNotPresentInParkingException || ex is GetNobatExceptionCarTruckIsTankTreiler || ex is CarTruckTravelLengthNotOverYetException || ex is GetNobatExceptionCarTruckHasNobat ||
                                           ex is GetNobatException || ex is SequentialTurnIsNotActiveException || ex is TruckNotFoundException || ex is SequentialTurnNotFoundException || ex is TruckDriverNotFoundException ||
                                           ex is TurnRegisterRequestNotFoundException || ex is GetNSSException || ex is GetDataException || ex is MoneyWalletCurrentChargeNotEnoughException || ex is TurnRegisterRequestTypeNotFoundException ||
                                           ex is TurnPrintingInfNotFoundException || ex is RelatedTerraficCardNotFoundException || ex is TerraficCardNotFoundException || ex is DriverTruckInformationNotExistException ||
                                           ex is SqlInjectionException || ex is PermissionException)
                { throw ex; }
                catch (AnyActiveTurnNotExistException ex)
                { throw ex; }
                catch (BillOfLadingCoreSendSMSFailedException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            //public void TurnsCancellation(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            //{
            //    try
            //    {
            //        var InstanceLogging = new R2CoreInstanceLoggingManager();
            //        var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
            //        var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
            //        var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
            //        var InstanceMClassCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();


            //        //کنترل فعال بودن سرویس
            //        if (!InstanceConfiguration.GetConfigBoolean(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 0)) { throw new BillOfLadingCoreTurnsCancellationIsnotActiveException(); }
            //        //کنترل زمان اجرای فرآیند
            //        var TimeofDay = _DateTime.GetCurrentTime();
            //        if (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 3), @"hh\:mm\:ss", CultureInfo.InvariantCulture)) { return; }
            //        //کنترل موجود بودن فایل مرجع بارنامه
            //        if (WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb.del", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword))) { return; }
            //        if (!(WS.WebMethodIOFileExist(R2CoreRawGroups.UploadedFiles, "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)))) { throw new BillOfLadingCoreFilefromRefrenceNotFoundException(); }
            //        /*خواندن فایل از سرور فایل و کپی آن به فولدر اپ دیتا موقت*/
            //        string tempFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb";
            //        //string tempFilePath = "c:\\"+ "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb";

            //        using (var fileStream = System.IO.File.Create(tempFilePath))
            //        {
            //            var ms = new System.IO.MemoryStream(WS.WebMethodGetFile(R2CoreRawGroups.UploadedFiles, "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword)));
            //            ms.CopyTo(fileStream);
            //        }

            //        /*لیست نوبت های فعال*/
            //        var LstActiveTurns = InstanceTurns.GetAllOfCurrentActiveTurns();

            //        OleDbDataAdapter DaBillOfLading = new OleDbDataAdapter(); DataSet DsBillOfLading = new DataSet();

            //        var TotalTurn = 0;
            //        /*بررسی نوبت های فعال*/
            //        for (int LoopBillOfLading = 0; LoopBillOfLading <= LstActiveTurns.Count - 1; LoopBillOfLading++)
            //        {
            //            /*لیست بارنامه ها از فایل موقت ایجاد شده*/
            //            var Turn = LstActiveTurns[LoopBillOfLading];
            //            var Concating = Turn.EnterDate + Turn.EnterTime.Substring(0, 5);
            //            DaBillOfLading.SelectCommand = new OleDbCommand("Select * from TblXX Where TruckSmartCardNo='" + Turn.TruckSmartCardNo + "' and ((RegisteringDate+RegisteringTime)>='" + Concating + "')");
            //            DaBillOfLading.SelectCommand.Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + tempFilePath + "'");
            //            bool PelakSerial = false;
            //            DsBillOfLading.Clear();
            //            if (DaBillOfLading.Fill(DsBillOfLading) <= 0)
            //            {
            //                DaBillOfLading.SelectCommand.CommandText = "Select * from TblXX Where ( MID(TBLXX.[PELAK],4,3)+MID(TBLXX.[PELAK],3,1)+MID(TBLXX.[PELAK],1,2))='" + Turn.Pelak + "' and Serial='" + Turn.Serial + "' and ((RegisteringDate+RegisteringTime)>='" + Concating + "')";
            //                DsBillOfLading.Clear();
            //                if (DaBillOfLading.Fill(DsBillOfLading) <= 0)
            //                {    /*ناوگان هیچ بارنامه ای بعد از صدور نوبت ندارد*/
            //                    continue;
            //                }
            //                else { PelakSerial = true; }
            //            }
            //            else { PelakSerial = false; }

            //            if (DsBillOfLading.Tables[0].Rows.Count > 1)
            //            {/*بیش از یک بارنامه بعد از نوبت فعال دارد*/}
            //            else
            //            {/*فقط یک بارنامه بعد از نوبت فعال دارد که ممکن است جزو نوبت های خودکار و شهری باشد*/
            //                if (Turn.nUserIdEnter == R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId)
            //                { /*نوبت در ساعات عادی نوبت خودکار توسط سیستم صادر نشده است*/
            //                    if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
            //                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "NoAction : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, DsBillOfLading.Tables[0].Rows.Count.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
            //                    continue;
            //                }
            //                else
            //                { }
            //            }

            //            /*ابطال نوبت */
            //            try
            //            {
            //                InstanceMClassCarTruckNobat.TurnCancellationWithLicensePlate(Turn.Pelak, Turn.Serial, YourNSSSoftwareUser, TurnStatuses.CancelledSystem);
            //                if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
            //                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "Action : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, DsBillOfLading.Tables[0].Rows.Count.ToString() + " " + PelakSerial.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
            //                TotalTurn += 1;
            //            }
            //            catch (Exception ex)
            //            {
            //                if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
            //                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, ex.Message, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
            //            }
            //        }

            //        /*ثبت لاگ تعداد باطل شده*/
            //        if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
            //        { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "TotalTurn=" + LstActiveTurns.Count.ToString(), "TotalTurnCancelled=" + TotalTurn.ToString(), string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }

            //        /*حذف فایل موقت از اپ دیتا*/
            //        System.IO.File.Delete(tempFilePath);

            //        ////حذف فایل با حفظ سابقه
            //        WS.WebMethodDeleteFileButKeepDeleted(R2CoreRawGroups.UploadedFiles, "BL" + _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + ".mdb", WS.WebMethodLogin(InstanceSoftwareUsers.GetNSSSystemUser().UserShenaseh, InstanceSoftwareUsers.GetNSSSystemUser().UserPassword));

            //        /*ارسال اس ام اس اتمام موفقیت آمیز*/
            //        SendSMSSuccess(TotalTurn, _DateTime.GetCurrentDateShamsiFull());
            //    }
            //    catch (BillOfLadingCoreTurnsCancellationIsnotActiveException ex)
            //    { throw ex; }
            //    catch (BillOfLadingCoreFilefromRefrenceNotFoundException ex)
            //    { throw ex; }
            //    catch (Exception ex) when (ex is RequesterNotAllowTurnIssueBySeqTException || ex is RequesterNotAllowTurnIssueByLastLoadPermissionedException || ex is TruckRelatedSequentialTurnNotFoundException ||
            //                               ex is CarIsNotPresentInParkingException || ex is GetNobatExceptionCarTruckIsTankTreiler || ex is CarTruckTravelLengthNotOverYetException || ex is GetNobatExceptionCarTruckHasNobat ||
            //                               ex is GetNobatException || ex is SequentialTurnIsNotActiveException || ex is TruckNotFoundException || ex is SequentialTurnNotFoundException || ex is TruckDriverNotFoundException ||
            //                               ex is TurnRegisterRequestNotFoundException || ex is GetNSSException || ex is GetDataException || ex is MoneyWalletCurrentChargeNotEnoughException || ex is TurnRegisterRequestTypeNotFoundException ||
            //                               ex is TurnPrintingInfNotFoundException || ex is RelatedTerraficCardNotFoundException || ex is TerraficCardNotFoundException || ex is DriverTruckInformationNotExistException ||
            //                               ex is SqlInjectionException || ex is PermissionException)
            //    { throw ex; }
            //    catch (AnyActiveTurnNotExistException ex)
            //    { throw ex; }
            //    catch (BillOfLadingCoreSendSMSFailedException ex)
            //    { throw ex; }
            //    catch (Exception ex)
            //    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            //}

            public void TurnsCancellation(R2CoreStandardSoftwareUserStructure YourNSSSoftwareUser)
            {
                try
                {
                    var InstanceLogging = new R2CoreInstanceLoggingManager();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var InstanceTurns = new R2CoreTransportationAndLoadNotificationInstanceTurnsManager();
                    var InstanceMClassCarTruckNobat = new PayanehClassLibraryMClassCarTruckNobatManager();

                    //کنترل فعال بودن سرویس
                    if (!InstanceConfiguration.GetConfigBoolean(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 0)) { throw new BillOfLadingCoreTurnsCancellationIsnotActiveException(); }
                    //کنترل زمان اجرای فرآیند
                    var TimeofDay = _DateTime.GetCurrentTime();
                    if (TimeSpan.ParseExact(TimeofDay, @"hh\:mm\:ss", CultureInfo.InvariantCulture) < TimeSpan.ParseExact(InstanceConfiguration.GetConfigString(Configurations.BillOfLadingCoreConfigurations.BillOfLading, 3), @"hh\:mm\:ss", CultureInfo.InvariantCulture)) { return; }

                    /*لیست نوبت های فعال*/
                    var LstActiveTurns = InstanceTurns.GetAllOfCurrentActiveTurns();
                    var TotalTurn = 0;
                    /*بررسی نوبت های فعال*/
                    for (int LoopBillOfLading = 0; LoopBillOfLading <= LstActiveTurns.Count - 1; LoopBillOfLading++)
                    {
                        /*لیست بارنامه ها از فایل موقت ایجاد شده*/
                        var Turn = LstActiveTurns[LoopBillOfLading];
                        var BarInfoService = new BillOfLadingClassLibrary.ir.rmto.bar.BarInfoServiceAtis();
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                        string BarInf = string.Empty;
                        bool ServiceConnected = false;
                        Int64 ServiceConnectingCounting = 0;
                        while (!ServiceConnected)
                        {
                            try
                            {
                                BarInf = BarInfoService.GetFreighterBOLsCount("atis", "SM4W44W946", Turn.TruckSmartCardNo, Turn.EnterDate, Turn.EnterTime);
                                ServiceConnected = true; ServiceConnectingCounting = 0;
                            }
                            catch (Exception ex)
                            {
                                ServiceConnectingCounting += 1;
                                if (ServiceConnectingCounting == 300)
                                {
                                    if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "Bar.RMTO.Ir Connecting After 10 Times Failed ...", String.Empty, String.Empty, String.Empty, String.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                                }
                                System.Threading.Thread.Sleep(1000);
                            }

                        }
                        var YesNo = BarInf.Substring(0, 2);
                        if (YesNo.ToUpper() == "NO") { continue; }
                        var TotalNumberofBillofLading = Convert.ToInt64(BarInf.Split(';')[1]);
                        if (TotalNumberofBillofLading > 1)
                        {/*بیش از یک بارنامه بعد از نوبت فعال دارد*/}
                        else
                        {/*فقط یک بارنامه بعد از نوبت فعال دارد که ممکن است جزو نوبت های خودکار و شهری باشد*/
                            if (Turn.nUserIdEnter == R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId)
                            { /*نوبت در ساعات عادی نوبت خودکار توسط سیستم صادر نشده است*/
                                if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "NoAction : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, TotalNumberofBillofLading.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                                continue;
                            }
                            else
                            { }
                        }

                        /*ابطال نوبت */
                        try
                        {
                            if (LstTurnStatuses.Contains(InstanceTurns.GetTurnStatus(Turn.nEnterExitId))) { continue; }
                            InstanceMClassCarTruckNobat.SetbFlagDriverToTrueCancelledSystem(Turn.nEnterExitId, true, YourNSSSoftwareUser);
                            if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "Action : " + "TruckSmartCardNo=" + Turn.TruckSmartCardNo, Turn.Pelak + " - " + Turn.Serial, Turn.NSSTruckDriver.NSSDriver.StrPersonFullName, Turn.EnterDate + " " + Turn.EnterTime, TotalNumberofBillofLading.ToString(), YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                            TotalTurn += 1;
                        }
                        catch (Exception ex)
                        {
                            if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                            { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, ex.Message, string.Empty, string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                        }
                    }

                    /*ثبت لاگ تعداد باطل شده*/
                    if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                    { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "TotalTurn=" + LstActiveTurns.Count.ToString(), "TotalTurnCancelled=" + TotalTurn.ToString(), string.Empty, string.Empty, string.Empty, YourNSSSoftwareUser.UserId, _DateTime.GetCurrentDateTimeMilladi(), null)); }

                    /*ارسال اس ام اس اتمام موفقیت آمیز*/
                    if (TotalTurn != 0) { SendSMSSuccess(TotalTurn, _DateTime.GetCurrentDateShamsiFull()); }
                }
                catch (BillOfLadingCoreTurnsCancellationIsnotActiveException ex)
                { throw ex; }
                catch (BillOfLadingCoreFilefromRefrenceNotFoundException ex)
                { throw ex; }
                catch (Exception ex) when (ex is RequesterNotAllowTurnIssueBySeqTException || ex is RequesterNotAllowTurnIssueByLastLoadPermissionedException || ex is TruckRelatedSequentialTurnNotFoundException ||
                                           ex is CarIsNotPresentInParkingException || ex is GetNobatExceptionCarTruckIsTankTreiler || ex is CarTruckTravelLengthNotOverYetException || ex is GetNobatExceptionCarTruckHasNobat ||
                                           ex is GetNobatException || ex is SequentialTurnIsNotActiveException || ex is TruckNotFoundException || ex is SequentialTurnNotFoundException || ex is TruckDriverNotFoundException ||
                                           ex is TurnRegisterRequestNotFoundException || ex is GetNSSException || ex is GetDataException || ex is MoneyWalletCurrentChargeNotEnoughException || ex is TurnRegisterRequestTypeNotFoundException ||
                                           ex is TurnPrintingInfNotFoundException || ex is RelatedTerraficCardNotFoundException || ex is TerraficCardNotFoundException || ex is DriverTruckInformationNotExistException ||
                                           ex is SqlInjectionException || ex is PermissionException)
                { throw ex; }
                catch (AnyActiveTurnNotExistException ex)
                { throw ex; }
                catch (BillOfLadingCoreSendSMSFailedException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            private void SendSMSSuccess(Int64 YourTotalTurn, string YourShamsiDate)
            {
                try
                {
                    if (YourTotalTurn <= 10) { return; }
                    var InstanceConfiguration = new R2CoreInstanceConfigurationManager();
                    var TargetUsers = InstanceConfiguration.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.BillOfLading, 1).Split('-');
                    var LstUsers = new List<R2CoreStandardSoftwareUserStructure>();
                    var InstanceSoftwareUsers = new R2CoreInstanseSoftwareUsersManager();
                    for (int LoopxUsers = 0; LoopxUsers <= TargetUsers.Length - 1; LoopxUsers++)
                    { LstUsers.Add(InstanceSoftwareUsers.GetNSSUser(Convert.ToInt64(TargetUsers[LoopxUsers]))); }
                    var BillOfLadingData = new SMSCreationData() { Data1 = YourTotalTurn.ToString(), Data2 = YourShamsiDate };
                    var InstanceSMSHandling = new R2CoreSMSHandlingManager();
                    var SMSResult = InstanceSMSHandling.SendSMS(LstUsers, BillOfLadingCoreSMSTypes.BillOfLadingTurnCancellationSuccess, InstanceSMSHandling.RepeatSMSCreationData(BillOfLadingData, LstUsers.Count), true);
                    var SMSResultAnalyze = InstanceSMSHandling.GetSMSResultAnalyze(SMSResult);
                    if (!(SMSResultAnalyze == String.Empty)) { throw new BillOfLadingCoreSendSMSFailedException(SMSResultAnalyze); }
                }
                catch (BillOfLadingCoreSendSMSFailedException ex)
                { throw ex; }
                catch (Exception ex)
                { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message); }
            }

            public string GetBOLsCount(string YourSmartCardNo, string YourShamsiDate, string YourTIme)
            {
                try
                {
                    var InstanceLogging = new R2CoreInstanceLoggingManager();

                    var BarInfoService = new BillOfLadingClassLibrary.ir.rmto.bar.BarInfoServiceAtis();
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    string BarInf = string.Empty;
                    bool ServiceConnected = false;
                    Int64 ServiceConnectingCounting = 0;
                    while (!ServiceConnected)
                    {
                        try
                        {
                            BarInf = BarInfoService.GetFreighterBOLsCount("atis", "SM4W44W946", YourSmartCardNo, YourShamsiDate, YourTIme);
                            ServiceConnected = true; ServiceConnectingCounting = 0;
                        }
                        catch (Exception ex)
                        {
                            ServiceConnectingCounting += 1;
                            if (ServiceConnectingCounting == 300)
                            {
                                if (InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).Active)
                                { InstanceLogging.LogRegister(new R2CoreStandardLoggingStructure(0, BillOfLadingCoreloggings.BillOfLadingTurnsCancellation, InstanceLogging.GetNSSLogType(BillOfLadingCoreloggings.BillOfLadingTurnsCancellation).LogTitle, "Bar.RMTO.Ir Connecting After 10 Times Failed ...", String.Empty, String.Empty, String.Empty, String.Empty, 1, _DateTime.GetCurrentDateTimeMilladi(), null)); }
                            }
                            System.Threading.Thread.Sleep(1000);
                        }

                    }
                    return BarInf;
                }
                catch (Exception ex)
                { throw ex; }
            }
        }
    }

    namespace Exceptions
    {
        public class BillOfLadingCoreTurnsCancellationByNoBillOfLadingIsnotActiveException : ApplicationException
        {
            public override string Message
            {
                get { return "سرویس ابطال نوبت ها بر مبنای بدون بارنامه غیرفعال است"; }
            }
        }

        public class BillOfLadingBillOfLadingNumberDosnotEntryException : ApplicationException
        {
            public override string Message
            { get { return "شماره بارنامه وارد نشده است"; } }
        }

        public class BillOfLadingCoreSendSMSFailedException : ApplicationException
        {
            private string _Message;
            public BillOfLadingCoreSendSMSFailedException(string YourMessage)
            { _Message = "\r\n" + YourMessage; }

            public override string Message
            {
                get { return "ارسال اس ام اس با مشکل مواجه شد" + _Message; }
            }
        }

        public class BillOfLadingCoreTurnsCancellationIsnotActiveException : ApplicationException
        {
            public override string Message
            {
                get { return "سرویس ابطال نوبت ها بر مبنای بارنامه غیرفعال است"; }
            }
        }

        public class BillOfLadingCoreFilefromRefrenceNotFoundException : ApplicationException
        {
            public override string Message
            {
                get { return "فایل مرجع بارنامه با تاریخ امروز موجود نیست"; }
            }
        }

    }

    namespace SMS
    {
        namespace SMSTypes
        {
            public abstract class BillOfLadingCoreSMSTypes : PayanehClassLibrarySMSTypes
            {
                public static readonly Int64 BillOfLadingTurnCancellationSuccess = 17;
            }


        }
    }

    namespace Logging
    {
        public abstract class BillOfLadingCoreloggings : R2CoreLogType
        { public static readonly Int64 BillOfLadingTurnsCancellation = 73; }

    }

    namespace Configurations
    {
        public abstract class BillOfLadingCoreConfigurations : R2CoreConfigurations
        { public static readonly Int64 BillOfLading = 92; }

    }

    namespace BillOfLadingControl
    {
        namespace BillOfLadingControl
        {
            public class BillOfLadingCoreStandardBillOfLadingStructure : R2StandardStructure
            {
                public BillOfLadingCoreStandardBillOfLadingStructure()
                {
                    BLNo = string.Empty;
                    BLSerial = string.Empty;
                    BLDateShamsi = string.Empty;
                    BLTime = string.Empty;
                    BLSenderTitle = string.Empty;
                    BLSenderNationalCode = string.Empty;
                    BLReceiverTitle = string.Empty;
                    BLReceiverNationalCode = string.Empty;
                    BLFirstTruckDriver = string.Empty;
                    BLTruckNo = string.Empty;
                    BLTruckSerialNo = string.Empty;
                    BLTruckSmartCardNo = string.Empty;
                    BLPrice = string.Empty;
                    BLSourceTitle = string.Empty;
                    BLTargetTitle = string.Empty;
                    BLGoodTitle = string.Empty;
                    BLWeight = string.Empty;
                    BLLoaderTypeTitle = string.Empty;
                }

                public BillOfLadingCoreStandardBillOfLadingStructure(string YourBLNo, string YourBLSerial, string YourBLDateShamsi, string YourBLTime, string YourBLSenderTitle, string YourBLSenderNationalCode, string YourBLReceiverTitle, string YourBLReceiverNationalCode, string YourBLFirstTruckDriver, string YourBLTruckNo, string YourBLTruckSerialNo, string YourBLTruckSmartCardNo, string YourBLPrice, string YourBLSourceTitle, string YourBLTargetTitle, string YourBLGoodTitle, string YourBLWeight, string YourBLLoaderTypeTitle) : base(YourBLNo, YourBLSerial)
                {
                    BLNo = YourBLNo;
                    BLSerial = YourBLSerial;
                    BLDateShamsi = YourBLDateShamsi;
                    BLTime = YourBLTime;
                    BLSenderTitle = YourBLSenderTitle;
                    BLSenderNationalCode = YourBLSenderNationalCode;
                    BLReceiverTitle = YourBLReceiverTitle;
                    BLReceiverNationalCode = YourBLReceiverNationalCode;
                    BLFirstTruckDriver = YourBLFirstTruckDriver;
                    BLTruckNo = YourBLTruckNo;
                    BLTruckSerialNo = YourBLTruckSerialNo;
                    BLTruckSmartCardNo = YourBLTruckSmartCardNo;
                    BLPrice = YourBLPrice;
                    BLSourceTitle = YourBLSourceTitle;
                    BLTargetTitle = YourBLTargetTitle;
                    BLGoodTitle = YourBLGoodTitle;
                    BLWeight = YourBLWeight;
                    BLLoaderTypeTitle = YourBLLoaderTypeTitle;
                }

                public string BLNo;
                public string BLSerial;
                public string BLDateShamsi;
                public string BLTime;
                public string BLSenderTitle;
                public string BLSenderNationalCode;
                public string BLReceiverTitle;
                public string BLReceiverNationalCode;
                public string BLFirstTruckDriver;
                public string BLTruckNo;
                public string BLTruckSerialNo;
                public string BLTruckSmartCardNo;
                public string BLPrice;
                public string BLSourceTitle;
                public string BLTargetTitle;
                public string BLGoodTitle;
                public string BLWeight;
                public string BLLoaderTypeTitle;
            }

            public class BillOfLadingCoreStandardBillOfLadingControlStructure
            {
                public BillOfLadingCoreStandardBillOfLadingControlStructure()
                {
                    BLCId = Int64.MinValue;
                    BLCTitle = String.Empty;
                    TCOId = String.Empty;
                    TCOTitle = String.Empty;
                    DateTimeMilladi = DateTime.Now;
                    DateShamsi = String.Empty;
                    Time = String.Empty;
                    UserId = Int64.MinValue;
                    Boolean.TryParse(Boolean.FalseString, out Active);
                    Boolean.TryParse(Boolean.FalseString, out ViewFlag);
                    Boolean.TryParse(Boolean.FalseString, out Deleted);
                    BillOfLadings = null;
                }

                public BillOfLadingCoreStandardBillOfLadingControlStructure(Int64 YourBLCId, string YourBLCTitle, String YourTCOId, String YourTCOTitle, DateTime YourDateTimeMilladi, String YourDateShamsi, String YourTime, Int64 YourUserId, Boolean YourActive, Boolean YourViewFlag, Boolean YourDeleted, List<BillOfLadingCoreStandardBillOfLadingStructure> YourBillOfLadings)
                {
                    BLCId = YourBLCId;
                    BLCTitle = YourBLCTitle;
                    TCOId = YourTCOId;
                    TCOTitle = YourTCOTitle;
                    DateTimeMilladi = YourDateTimeMilladi;
                    DateShamsi = YourDateShamsi;
                    Time = YourTime;
                    UserId = YourUserId;
                    Active = YourActive;
                    ViewFlag = YourViewFlag;
                    Deleted = YourDeleted;
                    BillOfLadings = YourBillOfLadings;
                }

                public Int64 BLCId;
                public String BLCTitle;
                public String TCOId;
                public String TCOTitle;
                public DateTime DateTimeMilladi;
                public String DateShamsi;
                public String Time;
                public Int64 UserId;
                public Boolean Active;
                public Boolean ViewFlag;
                public Boolean Deleted;
                public List<BillOfLadingCoreStandardBillOfLadingStructure> BillOfLadings;

            }

            public class BillOfLadingCoreStandardBillOfLadingControlExtendedStructure : BillOfLadingCoreStandardBillOfLadingControlStructure
            {
                public BillOfLadingCoreStandardBillOfLadingControlExtendedStructure() : base()
                {
                    DateTimeComposite = String.Empty;
                    UserName = String.Empty;
                    Status = String.Empty;
                }

                public BillOfLadingCoreStandardBillOfLadingControlExtendedStructure(BillOfLadingCoreStandardBillOfLadingControlStructure YourNSS, String YourDateTimeComposite, String YourUserName, String YourStatus) : base(YourNSS.BLCId, YourNSS.BLCTitle, YourNSS.TCOId, YourNSS.TCOTitle, YourNSS.DateTimeMilladi, YourNSS.DateShamsi, YourNSS.Time, YourNSS.UserId, YourNSS.Active, YourNSS.ViewFlag, YourNSS.Deleted, YourNSS.BillOfLadings)
                {
                    DateTimeComposite = YourDateTimeComposite;
                    UserName = YourUserName;
                    Status = YourStatus;
                }

                public String DateTimeComposite;
                public String UserName;
                public String Status;


            }

            public abstract class BillOfLadingCoreMClassBillOfLadingControlManagement
            {
                private static R2DateTime _DateTime = new R2DateTime();

                public static List<BillOfLadingCoreStandardBillOfLadingControlStructure> GetBillOfLadingControlHeaders(String YourSearchString)
                {
                    try
                    {
                        DataSet DS = null; Boolean DataChangeStatus = false;
                        R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(), "Select distinct BLC.* from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC " +
                            "Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as BLCDetails On BLC.BLCId = BLCDetails.BLCId " +
                            "Where Deleted = 0 and blc.BLCTitle like '%" + YourSearchString + "%' Order By BLC.DateTimeMilladi Desc", 0, ref DS, ref DataChangeStatus);
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingControlStructure>();
                        for (int Loopx = 0; Loopx <= DS.Tables[0].Rows.Count - 1; Loopx++)
                        { Lst.Add(new BillOfLadingCoreStandardBillOfLadingControlStructure(Convert.ToInt64(DS.Tables[0].Rows[Loopx]["BLCId"]), DS.Tables[0].Rows[Loopx]["BLCTitle"].ToString(), DS.Tables[0].Rows[Loopx]["TCOId"].ToString(), DS.Tables[0].Rows[Loopx]["TCOTitle"].ToString(), Convert.ToDateTime(DS.Tables[0].Rows[Loopx]["DateTimeMilladi"]), DS.Tables[0].Rows[Loopx]["DateShamsi"].ToString(), DS.Tables[0].Rows[Loopx]["Time"].ToString(), Convert.ToInt64(DS.Tables[0].Rows[Loopx]["UserId"]), Convert.ToBoolean(DS.Tables[0].Rows[Loopx]["Active"]), Convert.ToBoolean(DS.Tables[0].Rows[Loopx]["ViewFlag"]), Convert.ToBoolean(DS.Tables[0].Rows[Loopx]["Deleted"]), null)); }
                        return Lst;
                    }
                    catch (Exception ex)
                    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }
                }

                public static BillOfLadingCoreStandardBillOfLadingControlExtendedStructure GetNSSBillOfLadingControl(Int64 YourBLCId)
                {
                    try
                    {
                        DataSet DS = new DataSet(); Boolean DataChangeStatus = false;
                        if (R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(),
                                        "Select BLC.BLCTitle,BLC.TCOId,BLC.TCOTitle,BLC.DateTimeMilladi,BLC.DateShamsi,BLC.Time,BLC.UserId,BLC.ViewFlag,BLC.Active,BLC.Deleted,BLCDetail.*,(Replace(BLC.DateShamsi,'/','')+'-'+Replace(BLC.Time,':','')) AS DateTimeComposite,SoftwareUsers.UserName as UserName,IIf(BLC.Active=1,'فعال','غیرفعال') as Status " +
                                          " From R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC" +
                                          " Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as BLCDetail On BLC.BLCId= BLCDetail.BLCId" +
                                          " Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On BLC.UserId= SoftwareUsers.UserId" +
                                          " Where BLC.BLCId= " + YourBLCId + " Order By BLCDetail.BLCIndex", 3600, ref DS, ref DataChangeStatus).GetRecordsCount() == 0) { throw new BillOfLadingControlNotFoundException(); }
                        var NSSBLC = new BillOfLadingCoreStandardBillOfLadingControlExtendedStructure();
                        NSSBLC.BLCId = Convert.ToInt64(DS.Tables[0].Rows[0]["BLCId"]);
                        NSSBLC.BLCTitle = DS.Tables[0].Rows[0]["BLCTitle"].ToString();
                        NSSBLC.TCOId = DS.Tables[0].Rows[0]["TCOId"].ToString();
                        NSSBLC.TCOTitle = DS.Tables[0].Rows[0]["TCOTitle"].ToString();
                        NSSBLC.DateTimeMilladi = Convert.ToDateTime(DS.Tables[0].Rows[0]["DateTimeMilladi"]);
                        NSSBLC.DateShamsi = DS.Tables[0].Rows[0]["DateShamsi"].ToString();
                        NSSBLC.Time = DS.Tables[0].Rows[0]["Time"].ToString();
                        NSSBLC.UserId = Convert.ToInt64(DS.Tables[0].Rows[0]["UserId"]);
                        NSSBLC.ViewFlag = Convert.ToBoolean(DS.Tables[0].Rows[0]["ViewFlag"]);
                        NSSBLC.Active = Convert.ToBoolean(DS.Tables[0].Rows[0]["Active"]);
                        NSSBLC.Deleted = Convert.ToBoolean(DS.Tables[0].Rows[0]["Deleted"]);
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingStructure>();
                        for (int Loopx = 0; Loopx <= DS.Tables[0].Rows.Count - 1; Loopx++)
                        {
                            var NSSBL = new BillOfLadingCoreStandardBillOfLadingStructure(DS.Tables[0].Rows[Loopx]["BLNo"].ToString(), DS.Tables[0].Rows[Loopx]["BLSerial"].ToString(), DS.Tables[0].Rows[Loopx]["BLDateShamsi"].ToString(), DS.Tables[0].Rows[Loopx]["BLTime"].ToString(), DS.Tables[0].Rows[Loopx]["BLSenderTitle"].ToString(), DS.Tables[0].Rows[Loopx]["BLSenderNationalCode"].ToString(), DS.Tables[0].Rows[Loopx]["BLReceiverTitle"].ToString(), DS.Tables[0].Rows[Loopx]["BLReceiverNationalCode"].ToString(), DS.Tables[0].Rows[Loopx]["BLFirstTruckDriver"].ToString(), DS.Tables[0].Rows[Loopx]["BLTruckNo"].ToString(), DS.Tables[0].Rows[Loopx]["BLTruckSerialNo"].ToString(), DS.Tables[0].Rows[Loopx]["BLTruckSmartCardNo"].ToString(), DS.Tables[0].Rows[Loopx]["BLPrice"].ToString(), DS.Tables[0].Rows[Loopx]["BLSourceTitle"].ToString(), DS.Tables[0].Rows[Loopx]["BLTargetTitle"].ToString(), DS.Tables[0].Rows[Loopx]["BLGoodTitle"].ToString(), DS.Tables[0].Rows[Loopx]["BLWeight"].ToString(), DS.Tables[0].Rows[Loopx]["BLLoaderTypeTitle"].ToString());
                            Lst.Add(NSSBL);
                        }
                        NSSBLC.BillOfLadings = Lst;
                        NSSBLC.DateTimeComposite = DS.Tables[0].Rows[0]["DateTimeComposite"].ToString();
                        NSSBLC.UserName = DS.Tables[0].Rows[0]["UserName"].ToString();
                        NSSBLC.Status = DS.Tables[0].Rows[0]["Status"].ToString();
                        return NSSBLC;
                    }
                    catch (BillOfLadingControlNotFoundException ex)
                    { throw ex; }
                    catch (Exception ex)
                    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }
                }

                public static Int64 BillOfLadingControlRegistering(BillOfLadingCoreStandardBillOfLadingControlStructure YourNSSBillOfLadingControl, R2CoreStandardSoftwareUserStructure YourNSSUser)
                {
                    System.Data.SqlClient.SqlCommand CmdSql = new System.Data.SqlClient.SqlCommand();
                    CmdSql.Connection = (new R2PrimarySqlConnection()).GetConnection();
                    try
                    {
                        if (YourNSSBillOfLadingControl.BLCTitle.Trim() == String.Empty) { throw new BillOfLadingControlMustHaveTitleForRegisteringException(); }
                        CmdSql.Connection.Open();
                        CmdSql.Transaction = CmdSql.Connection.BeginTransaction();
                        CmdSql.CommandText = "Select Top 1 BLCId From R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls with (tablockx) Order By BLCId Desc";
                        CmdSql.ExecuteNonQuery();
                        CmdSql.CommandText = "Select IDENT_CURRENT('R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls') ";
                        Int64 BLCIdNew = Convert.ToInt64(CmdSql.ExecuteScalar()) + 1;
                        CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls(BLCTitle,TCOId,TCOTitle,DateTimeMilladi,DateShamsi,Time,UserId,ViewFlag,Active,Deleted) Values('" + YourNSSBillOfLadingControl.BLCTitle + "','" + YourNSSBillOfLadingControl.TCOId + "','" + YourNSSBillOfLadingControl.TCOTitle + "','" + _DateTime.GetCurrentDateTimeMilladiFormated() + "','" + _DateTime.GetCurrentDateShamsiFull() + "','" + _DateTime.GetCurrentTime() + "'," + YourNSSUser.UserId + ",1,1,0)";
                        CmdSql.ExecuteNonQuery();
                        for (int Loopx = 0; Loopx <= YourNSSBillOfLadingControl.BillOfLadings.Count - 1; Loopx++)
                        {
                            CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails(BLCId,BLCIndex,BLNo,BlSerial,BLDateShamsi,BLTime,BLSenderTitle,BLSenderNationalCode,BLReceiverTitle,BLReceiverNationalCode,BLFirstTruckDriver,BLTruckNo,BLTruckSerialNo,BLTruckSmartCardNo,BLPrice,BLSourceTitle,BLTargetTitle,BLGoodTitle,BLWeight,BLLoaderTypeTitle) Values(" + BLCIdNew.ToString() + "," + (Loopx + 1).ToString() + ",'" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLNo + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSerial + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLDateShamsi + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTime + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderTitle + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderNationalCode + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverTitle + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverNationalCode + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLFirstTruckDriver + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTruckNo + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTruckSerialNo + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTruckSmartCardNo + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLPrice + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSourceTitle + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTargetTitle + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLGoodTitle + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLWeight + "','" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLLoaderTypeTitle.Trim() + "')";
                            CmdSql.ExecuteNonQuery();
                        }
                        CmdSql.Transaction.Commit(); CmdSql.Connection.Close();
                        return BLCIdNew;
                    }
                    catch (BillOfLadingControlMustHaveTitleForRegisteringException ex)
                    { throw ex; }
                    catch (Exception ex)
                    {
                        if (CmdSql.Connection.State != ConnectionState.Closed)
                        { CmdSql.Transaction.Rollback(); CmdSql.Connection.Close(); }
                        throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                    }
                }

                public static BillOfLadingCoreStandardBillOfLadingControlStructure ReadBillOfLadingControl(String YourPathOfFile)
                {
                    try
                    {
                        /*خواندن فایل*/
                        OleDbDataAdapter Da = new OleDbDataAdapter(); DataSet Ds = new DataSet();
                        try
                        {
                            Da.SelectCommand = new OleDbCommand();
                            Da.SelectCommand.Connection = new OleDbConnection(R2CoreMClassDatabaseManagement.GetOLEDbConnectionString(YourPathOfFile));
                            Da.SelectCommand.CommandText = "Select f36 as TransportCompany,f37 as  BlNo,f34 as BLSerial,f31 as BLDateShamsi,f29 as BLTime,f26 as BLSenderTitle,f23 as BLSenderNationalCode,f20 as BLReceiverTitle,f16 as BLReceiverNationalCode,f13 as BLFirstTruckDriver,f10 as BLTruckSmartCardNo,f8 as BLTruckNo,f7 as BLTruckSerialNo,f6 as BLPrice,f5 as BLSourceTitle,f4 as BLTargetTitle,f3 as BLGoodTitle,f2 as BLWeight,f1 as BLLoaderTypeTitle from [Rpt14BarnamehForCmpany$] Order By f38";
                            Da.Fill(Ds);
                        }
                        catch (Exception ex)
                        { throw new ReadingBillOfLadingControlFailedException(); }
                        /*ایجاد Dirty NSS*/
                        var NSSBillOfLadingControl = new BillOfLadingCoreStandardBillOfLadingControlStructure();
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingStructure>();
                        try
                        {
                            for (int Loopx = 0; Loopx <= Ds.Tables[0].Rows.Count - 1; Loopx++)
                            {
                                int myBlNo;
                                if (int.TryParse(Ds.Tables[0].Rows[Loopx]["BLNo"].ToString(), out myBlNo))
                                {
                                    var myBlNo_ = Ds.Tables[0].Rows[Loopx]["BlNo"].ToString();
                                    var myBLSerial = Ds.Tables[0].Rows[Loopx]["BLSerial"].ToString();
                                    var myBLDateShamsi = Ds.Tables[0].Rows[Loopx]["BLDateShamsi"].ToString();
                                    var myBLTime = Ds.Tables[0].Rows[Loopx]["BLTime"].ToString();
                                    var myBLSenderTitle = Ds.Tables[0].Rows[Loopx]["BLSenderTitle"].ToString();
                                    var myBLSenderNationalCode = Ds.Tables[0].Rows[Loopx]["BLSenderNationalCode"].ToString();
                                    var myBLReceiverTitle = Ds.Tables[0].Rows[Loopx]["BLReceiverTitle"].ToString();
                                    var myBLReceiverNationalCode = Ds.Tables[0].Rows[Loopx]["BLReceiverNationalCode"].ToString();
                                    var myBLFirstTruckDriver = Ds.Tables[0].Rows[Loopx]["BLFirstTruckDriver"].ToString();
                                    var myBLTruckSmartCardNo = Ds.Tables[0].Rows[Loopx]["BLTruckSmartCardNo"].ToString();
                                    var myBLTruckNo = Ds.Tables[0].Rows[Loopx]["BLTruckNo"].ToString();
                                    var myBLTruckSerialNo = Ds.Tables[0].Rows[Loopx]["BLTruckSerialNo"].ToString();
                                    var myBLPrice = Ds.Tables[0].Rows[Loopx]["BLPrice"].ToString().Replace(",", "");
                                    var myBLSourceTitle = Ds.Tables[0].Rows[Loopx]["BLSourceTitle"].ToString();
                                    var myBLTargetTitle = Ds.Tables[0].Rows[Loopx]["BLTargetTitle"].ToString();
                                    var myBLGoodTitle = Ds.Tables[0].Rows[Loopx]["BLGoodTitle"].ToString();
                                    var myBLWeight = Ds.Tables[0].Rows[Loopx]["BLWeight"].ToString();
                                    var myBLLoaderTypeTitle = Ds.Tables[0].Rows[Loopx]["BLLoaderTypeTitle"].ToString();
                                    Lst.Add(new BillOfLadingCoreStandardBillOfLadingStructure(myBlNo_, myBLSerial, myBLDateShamsi, myBLTime, myBLSenderTitle, myBLSenderNationalCode, myBLReceiverTitle, myBLReceiverNationalCode, myBLFirstTruckDriver, myBLTruckNo, myBLTruckSerialNo, myBLTruckSmartCardNo, myBLPrice, myBLSourceTitle, myBLTargetTitle, myBLGoodTitle, myBLWeight, myBLLoaderTypeTitle));
                                }
                            }
                            NSSBillOfLadingControl.BillOfLadings = Lst;

                            String[] TC = null;
                            int TCCounter = 0;
                            do
                            {
                                if (Ds.Tables[0].Rows[TCCounter][0].ToString() != String.Empty)
                                { TC = Ds.Tables[0].Rows[TCCounter][0].ToString().Split(' '); }
                                else
                                { TCCounter += 1; }

                            } while (TC is null);
                            NSSBillOfLadingControl.TCOId = TC[TC.Length - 2];
                            NSSBillOfLadingControl.TCOTitle = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompanyByOrganizationId(Convert.ToInt16(NSSBillOfLadingControl.TCOId)).TCTitle;
                        }
                        catch (TransportCompanyNotFoundException ex)
                        { throw ex; }
                        catch (Exception ex)
                        { throw new BillOfLadingControlFileHasInvalidStructureException(); }
                        return NSSBillOfLadingControl;
                    }

                    catch (TransportCompanyNotFoundException ex)
                    { throw ex; }
                    catch (BillOfLadingControlFileHasInvalidStructureException ex)
                    { throw ex; }
                    catch (ReadingBillOfLadingControlFailedException ex)
                    { throw ex; }
                    catch (Exception ex)
                    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }
                }

                public static void BillOfLadingControlDeleting(Int64 YourBLCId)
                {
                    var CmdSql = new System.Data.SqlClient.SqlCommand();
                    CmdSql.Connection = (new R2PrimarySqlConnection()).GetConnection();
                    try
                    {
                        CmdSql.Connection.Open();
                        CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls Set Deleted=1,Active=0 Where BLCId=" + YourBLCId + "";
                        CmdSql.ExecuteNonQuery();
                        CmdSql.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        if (CmdSql.Connection.State != ConnectionState.Closed) { CmdSql.Connection.Close(); }
                        throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                    }
                }
            }

            namespace Exceptions
            {
                public class BillOfLadingControlNotFoundException : ApplicationException
                {
                    public override string Message
                    { get { return "کنترل بارنامه با شماره شاخص مورد نظر وجود ندارد"; } }
                }

                public class ReadingBillOfLadingControlFailedException : ApplicationException
                {
                    public override string Message
                    { get { return "خطا هنگام خواندن اطلاعات از فایل کنترل بارنامه"; } }
                }

                public class BillOfLadingControlMustHaveTitleForRegisteringException : ApplicationException
                {
                    public override string Message
                    { get { return "کنترل بارنامه برای ذخیره در بانک اطلاعاتی باید دارای یک عنوان باشد"; } }

                    public class BillOfLadingControlFileHasInvalidStructureException : ApplicationException
                    {
                        public override string Message
                        { get { return "ساختار فایل کنترل بارنامه مطابق با پیکربندی سیستم نیست"; } }
                    }
                }



            }

        }

        namespace BillOfLadingControlInfraction
        {
            public class BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure
            {
                public BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure() : base()
                {
                    BLCIId = Int64.MinValue;
                    BLCIIndex = Int64.MinValue;
                    TruckAnalyze = String.Empty;
                    TonajAnalyze = String.Empty;
                    SenderAnalyze = String.Empty;
                    RecieverAnalyze = String.Empty;
                    SameSenderRecieverAnalyze = String.Empty;
                    LoadSourceInvalidAnalyze = String.Empty;
                }

                public BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure(Int64 YourBLCIId, Int64 YourBLCIIndex, String YourTruckAnalyze, String YourTonajAnalyze, String YourSenderAnalyze, String YourRecieverAnalyze, String YourSameSenderRecieverAnalyze, String YourLoadSourceInvalidAnalyze) : base()
                {
                    BLCIId = YourBLCIId;
                    BLCIIndex = YourBLCIIndex;
                    TruckAnalyze = YourTruckAnalyze;
                    TonajAnalyze = YourTonajAnalyze;
                    SenderAnalyze = YourSenderAnalyze;
                    RecieverAnalyze = YourRecieverAnalyze;
                    SameSenderRecieverAnalyze = YourSameSenderRecieverAnalyze;
                    LoadSourceInvalidAnalyze = YourLoadSourceInvalidAnalyze;
                }

                public Int64 BLCIId;
                public Int64 BLCIIndex;
                public String TruckAnalyze;
                public String TonajAnalyze;
                public String SenderAnalyze;
                public String RecieverAnalyze;
                public String SameSenderRecieverAnalyze;
                public String LoadSourceInvalidAnalyze;

            }

            public class BillOfLadingCoreStandardBillOfLadingControlInfractionStructure
            {
                public BillOfLadingCoreStandardBillOfLadingControlInfractionStructure() : base()
                {

                    BLCIId = Int64.MinValue;
                    BLCId = Int64.MinValue;
                    DateTimeMilladi = DateTime.Now;
                    DateShamsi = String.Empty;
                    Time = String.Empty;
                    UserId = Int64.MinValue;
                    Note = String.Empty;
                    Boolean.TryParse(Boolean.FalseString, out RelationActive);
                    InfractionDetails = null;
                }

                public BillOfLadingCoreStandardBillOfLadingControlInfractionStructure(Int64 YourBLCIId, Int64 YourBLCId, DateTime YourDateTimeMilladi, String YourDateShamsi, String YourTime, Int64 YourUserId, String YourNote, Boolean YourRelationActive, List<BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure> YourInfractionDetails) : base()
                {
                    BLCIId = YourBLCIId;
                    BLCId = YourBLCId;
                    DateTimeMilladi = YourDateTimeMilladi;
                    DateShamsi = YourDateShamsi;
                    Time = YourTime;
                    UserId = YourUserId;
                    Note = YourNote;
                    RelationActive = YourRelationActive;
                    InfractionDetails = YourInfractionDetails;
                }

                public Int64 BLCIId;
                public Int64 BLCId;
                public DateTime DateTimeMilladi;
                public String DateShamsi;
                public String Time;
                public Int64 UserId;
                public String Note;
                public Boolean RelationActive;
                public List<BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure> InfractionDetails;
            }

            public class BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure : BillOfLadingCoreStandardBillOfLadingControlInfractionStructure
            {
                public BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure() : base()
                {
                    DateTimeComposite = String.Empty;
                    UserName = String.Empty;
                    Status = String.Empty;
                    BLCTitle = String.Empty;
                }


                public BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure(BillOfLadingCoreStandardBillOfLadingControlInfractionStructure YourNSS, String YourDateTimeComposite, String YourUserName, String YourStatus, String YourBLCTitle) : base(YourNSS.BLCIId, YourNSS.BLCId, YourNSS.DateTimeMilladi, YourNSS.DateShamsi, YourNSS.Time, YourNSS.UserId, YourNSS.Note, YourNSS.RelationActive, YourNSS.InfractionDetails)
                {
                    DateTimeComposite = YourDateTimeComposite;
                    UserName = YourUserName;
                    Status = YourStatus;
                    BLCTitle = YourBLCTitle;
                }

                public String DateTimeComposite;
                public String UserName;
                public String Status;
                public String BLCTitle;

            }

            public abstract class BillOfLadingCoreMClassBillOfLadingControlInfractionManagement
            {
                private static R2DateTime _DateTime = new R2DateTime();
                public static List<BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure> GetBillOfLadingControlInfractionHeaders(String YourSearchString)
                {
                    try
                    {
                        DataSet DS = null; Boolean DataChangeStatus = false;
                        R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(),
                             "Select distinct BLCI.*,BLC.BLCTitle " +
                                      "from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions as BLCI " +
                                      " Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractionDetails as BLCIDetails On BLCI.BLCIId = BLCIDetails.BLCIId " +
                                      " Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC On BLCI.BLCId = BLC.BLCId " +
                                      " Where BLC.Deleted = 0 and BLC.Active = 1 and BLC.ViewFlag = 1 and BLCI.RelationActive = 1 and BLC.BLCTitle like '%" + YourSearchString + "%' Order By BLCI.DateTimeMilladi Desc", 0, ref DS, ref DataChangeStatus);
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure>();
                        for (int Loopx = 0; Loopx <= DS.Tables[0].Rows.Count - 1; Loopx++)
                        { Lst.Add(new BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure(new BillOfLadingCoreStandardBillOfLadingControlInfractionStructure(Convert.ToInt64(DS.Tables[0].Rows[Loopx]["BLCIId"]), Convert.ToInt64(DS.Tables[0].Rows[Loopx]["BLCId"]), Convert.ToDateTime(DS.Tables[0].Rows[Loopx]["DateTimeMilladi"]), DS.Tables[0].Rows[Loopx]["DateShamsi"].ToString(), DS.Tables[0].Rows[Loopx]["Time"].ToString(), Convert.ToInt64(DS.Tables[0].Rows[Loopx]["UserId"]), DS.Tables[0].Rows[Loopx]["Note"].ToString(), Convert.ToBoolean(DS.Tables[0].Rows[Loopx]["RelationActive"]), null), null, null, null, DS.Tables[0].Rows[Loopx]["BLCTitle"].ToString())); }
                        return Lst;
                    }
                    catch (Exception ex)
                    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }
                }

                public static BillOfLadingCoreStandardBillOfLadingControlInfractionStructure BillOfLadingControlInfractionAnalyze(BillOfLadingCoreStandardBillOfLadingControlStructure YourNSSBillOfLadingControl)
                {
                    try
                    {
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                        var NSSBillOfLadingControlInfraction = new BillOfLadingCoreStandardBillOfLadingControlInfractionStructure();
                        NSSBillOfLadingControlInfraction.BLCId = YourNSSBillOfLadingControl.BLCId;
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure>();
                        for (int Loopx = 0; Loopx <= YourNSSBillOfLadingControl.BillOfLadings.Count - 1; Loopx++)
                        {
                            var NSSBillOfLadingControlInfractionDetail = new BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure();
                            NSSBillOfLadingControlInfractionDetail.BLCIIndex = Loopx;
                            /*بررسی هوشمند ناوگان موجودیت و فعال بودن*/
                            try
                            {
                                if (RmtoWebService.ISTruckSmartCardActive(YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLTruckSmartCardNo))
                                { NSSBillOfLadingControlInfractionDetail.TruckAnalyze = "فعال"; }
                                else
                                { NSSBillOfLadingControlInfractionDetail.TruckAnalyze = "غیر فعال"; }
                            }
                            catch (Exception ex) when (ex is InternetIsnotAvailableException || ex is RMTOWebServiceSmartCardInvalidException || ex is ConnectionIsNotAvailableException || ex is InvalidOperationException)
                            { NSSBillOfLadingControlInfractionDetail.TruckAnalyze = ex.Message; }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }


                            /*کنترل آیتم وزن در بارنامه با حداکثر تناژ مجاز بارگیر*/
                            try
                            {
                                if (R2CoreTransportationAndLoadNotificationTruckLoaderTypeManagement.GetTonajMax(YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLLoaderTypeTitle.Trim()) < Convert.ToInt64(YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLWeight))
                                { NSSBillOfLadingControlInfractionDetail.TonajAnalyze = "تناژ غیر مجاز"; }
                                else
                                { NSSBillOfLadingControlInfractionDetail.TonajAnalyze = "تناژ مجاز"; }
                            }
                            catch (TruckLoaderTypeNotFoundException ex)
                            { NSSBillOfLadingControlInfractionDetail.TonajAnalyze = ex.Message; }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }


                            /*مقایسه کد ملی و نام فرستنده در بارنامه با سوابق قبلی*/
                            try
                            {
                                DataSet Ds = new DataSet(); Boolean DataChangeStatus = false;
                                if (R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(), "Select Top 1 BLC.BLCTitle,BLC.DateShamsi,BLC.Time,Detail.BLCIndex from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as Detail On BLC.BLCId = Detail.BLCId  Where(Detail.BLSenderNationalCode = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderNationalCode + "' and Detail.BLSenderTitle <> '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderTitle + "') or (Detail.BLSenderTitle = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderTitle + "' and Detail.BLSenderNationalCode <> '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderNationalCode + "')", 3600, ref Ds, ref DataChangeStatus).GetRecordsCount() != 0)
                                { NSSBillOfLadingControlInfractionDetail.SenderAnalyze = Ds.Tables[0].Rows[0]["BLCTitle"].ToString() + " - " + Ds.Tables[0].Rows[0]["DateShamsi"].ToString().Replace("/", "") + Ds.Tables[0].Rows[0]["Time"].ToString().Replace(":", "") + " - " + " Index:" + Ds.Tables[0].Rows[0]["BLCIndex"].ToString(); }
                            }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }


                            /*مقایسه کد ملی و نام گیرنده در بارنامه با سوابق قبلی*/
                            try
                            {
                                DataSet Ds = new DataSet(); Boolean DataChangeStatus = false;
                                if (R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(), "Select Top 1 BLC.BLCTitle,BLC.DateShamsi,BLC.Time,Detail.BLCIndex from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as Detail On BLC.BLCId = Detail.BLCId   Where(Detail.BLReceiverNationalCode = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverNationalCode + "' and Detail.BLReceiverTitle <> '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverTitle + "')  or (Detail.BLReceiverTitle = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverTitle + "' and Detail.BLReceiverNationalCode <> '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverNationalCode + "')", 3600, ref Ds, ref DataChangeStatus).GetRecordsCount() != 0)
                                { NSSBillOfLadingControlInfractionDetail.RecieverAnalyze = Ds.Tables[0].Rows[0]["BLCTitle"].ToString() + " - " + Ds.Tables[0].Rows[0]["DateShamsi"].ToString().Replace("/", "") + Ds.Tables[0].Rows[0]["Time"].ToString().Replace(":", "") + " - " + " Index:" + Ds.Tables[0].Rows[0]["BLCIndex"].ToString(); }
                            }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }


                            /*گیرنده فرستنده یکسان ولی محموله در سوابق قبلی وجود ندارد*/
                            try
                            {
                                if (YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderNationalCode == YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLReceiverNationalCode)
                                {
                                    DataSet Ds = new DataSet(); Boolean DataChangeStatus = false;
                                    if (R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(), "Select Top 1 BLC.BLCTitle from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as Detail On BLC.BLCId = Detail.BLCId Where Detail.BLReceiverNationalCode = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSenderNationalCode + "' and Detail.BLGoodTitle = '" + YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLGoodTitle + "' and BLC.BLCId <> " + YourNSSBillOfLadingControl.BLCId + "", 3600, ref Ds, ref DataChangeStatus).GetRecordsCount() == 0)
                                    { NSSBillOfLadingControlInfractionDetail.SameSenderRecieverAnalyze = "محموله در سوابق قبلی وجود ندارد"; }
                                }
                            }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }


                            /*کنترل مبدا بارنامه با مبادی مجاز استانی*/
                            try
                            {
                                Int64 Province = R2CoreParkingSystemMClassCitys.GetNSSCity(YourNSSBillOfLadingControl.BillOfLadings[Loopx].BLSourceTitle).nProvince;
                                if (Province != R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 3))
                                { NSSBillOfLadingControlInfractionDetail.LoadSourceInvalidAnalyze = "مبدا غیر مجاز"; }
                            }
                            catch (GetNSSException ex)
                            { NSSBillOfLadingControlInfractionDetail.LoadSourceInvalidAnalyze = "استان مبدا یافت نشد"; }
                            catch (Exception ex)
                            { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }

                            Lst.Add(NSSBillOfLadingControlInfractionDetail);
                        }
                        NSSBillOfLadingControlInfraction.InfractionDetails = Lst;
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                        return NSSBillOfLadingControlInfraction;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                        throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                    }

                }

                public static Int64 BillOfLadingControlInfractionRegistering(BillOfLadingCoreStandardBillOfLadingControlInfractionStructure YourNSSBillOfLadingControlInfraction, R2CoreStandardSoftwareUserStructure YourNSSUser)
                {
                    var CmdSql = new System.Data.SqlClient.SqlCommand();
                    CmdSql.Connection = (new R2PrimarySqlConnection()).GetConnection();
                    try
                    {
                        CmdSql.Connection.Open();
                        CmdSql.Transaction = CmdSql.Connection.BeginTransaction();
                        CmdSql.CommandText = "Select Top 1 BLCIId From R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions with (tablockx) Order By BLCIId Desc";
                        CmdSql.ExecuteNonQuery();
                        CmdSql.CommandText = "Select IDENT_CURRENT('R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions') ";
                        Int64 BLCIIdNew = Convert.ToInt64(CmdSql.ExecuteScalar()) + 1;
                        CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions(BLCId,DateTimeMilladi,DateShamsi,Time,UserId,Note,RelationActive) Values(" + YourNSSBillOfLadingControlInfraction.BLCId + ",'" + _DateTime.GetCurrentDateTimeMilladiFormated() + "','" + _DateTime.GetCurrentDateShamsiFull() + "','" + _DateTime.GetCurrentTime() + "'," + YourNSSUser.UserId + ",'" + YourNSSBillOfLadingControlInfraction.Note + "',1)";
                        CmdSql.ExecuteNonQuery();
                        for (int Loopx = 0; Loopx <= YourNSSBillOfLadingControlInfraction.InfractionDetails.Count - 1; Loopx++)
                        {
                            CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractionDetails(BLCIId,BLCIIndex,TruckAnalyze,TonajAnalyze,SenderAnalyze,RecieverAnalyze,SameSenderRecieverAnalyze,LoadSourceInvalid) Values(" + BLCIIdNew + "," + Loopx + 1 + ",'" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].TruckAnalyze + "','" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].TonajAnalyze + "','" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].SenderAnalyze + "','" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].RecieverAnalyze + "','" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].SameSenderRecieverAnalyze + "','" + YourNSSBillOfLadingControlInfraction.InfractionDetails[Loopx].LoadSourceInvalidAnalyze + "')";
                            CmdSql.ExecuteNonQuery();
                        }
                        CmdSql.Transaction.Commit(); CmdSql.Connection.Close();
                        return BLCIIdNew;
                    }
                    catch (BillOfLadingControlMustHaveTitleForRegisteringException ex)
                    { throw ex; }
                    catch (Exception ex)
                    {
                        if (CmdSql.Connection.State != ConnectionState.Closed) { CmdSql.Transaction.Rollback(); CmdSql.Connection.Close(); }
                        throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                    }
                }

                public static void BillOfLadingControlInfractionDeleting(Int64 YourBLCIId)
                {
                    System.Data.SqlClient.SqlCommand CmdSql = new System.Data.SqlClient.SqlCommand();
                    CmdSql.Connection = (new R2PrimarySqlConnection()).GetConnection();
                    try
                    {
                        CmdSql.Connection.Open();
                        CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions Set RelationActive=0 Where BLCIId=" + YourBLCIId + "";
                        CmdSql.ExecuteNonQuery();
                        CmdSql.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        if (CmdSql.Connection.State != ConnectionState.Closed)
                        {
                            CmdSql.Connection.Close();
                            throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message);
                        }
                    }
                }

                public static BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure GetNSSBillOfLadingControlInfraction(Int64 YourBLCIId)
                {
                    try
                    {
                        DataSet DS = new DataSet(); Boolean DataChangeStatus = false;
                        if (R2ClassSqlDataBOXManagement.GetDataBOX(new R2PrimarySqlConnection(),
                                "Select BLC.BLCId,BLC.BLCTitle,BLCI.DateTimeMilladi,BLCI.DateShamsi,BLCI.Time,BLCI.UserId,BLCI.Note,BLCI.RelationActive,BLCIDetail.*,(Replace(BLCI.DateShamsi,'/','')+'-'+Replace(BLCI.Time,':','')) AS DateTimeComposite,SoftwareUsers.UserName as UserName,IIf(BLCI.RelationActive=1,'فعال','غیرفعال') as Status " +
                                    " From R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions as BLCI " +
                                    "   Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC On BLCI.BLCId = BLC.BLCId " +
                                    "      Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractionDetails as BLCIDetail On BLCI.BLCIId = BLCIDetail.BLCIId " +
                                    "     Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On BLCI.UserId = SoftwareUsers.UserId " +
                                    "  Where BLCI.BLCIId = " + YourBLCIId + " Order By BLCIDetail.BLCIIndex", 3600, ref DS, ref DataChangeStatus).GetRecordsCount() == 0) { throw new BillOfLadingControlInfractionNotFoundException(); }

                        var NSSBLCI = new BillOfLadingCoreStandardBillOfLadingControlInfractionExtendedStructure();
                        NSSBLCI.BLCIId = Convert.ToInt64(DS.Tables[0].Rows[0]["BLCIId"]);
                        NSSBLCI.BLCId = Convert.ToInt64(DS.Tables[0].Rows[0]["BLCId"]);
                        NSSBLCI.DateTimeMilladi = Convert.ToDateTime(DS.Tables[0].Rows[0]["DateTimeMilladi"]);
                        NSSBLCI.DateShamsi = DS.Tables[0].Rows[0]["DateShamsi"].ToString();
                        NSSBLCI.Time = DS.Tables[0].Rows[0]["Time"].ToString();
                        NSSBLCI.UserId = Convert.ToInt64(DS.Tables[0].Rows[0]["UserId"]);
                        NSSBLCI.Note = DS.Tables[0].Rows[0]["Note"].ToString();
                        NSSBLCI.RelationActive = Convert.ToBoolean(DS.Tables[0].Rows[0]["RelationActive"]);
                        var Lst = new List<BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure>();
                        for (int Loopx = 0; Loopx <= DS.Tables[0].Rows.Count - 1; Loopx++)
                        {
                            var NSSDetail = new BillOfLadingCoreStandardBillOfLadingControlInfractionDetailStructure(Convert.ToInt64(DS.Tables[0].Rows[Loopx]["BLCIId"]), Convert.ToInt64(DS.Tables[0].Rows[Loopx]["BLCIIndex"]), DS.Tables[0].Rows[Loopx]["TruckAnalyze"].ToString(), DS.Tables[0].Rows[Loopx]["TonajAnalyze"].ToString(), DS.Tables[0].Rows[Loopx]["SenderAnalyze"].ToString(), DS.Tables[0].Rows[Loopx]["RecieverAnalyze"].ToString(), DS.Tables[0].Rows[Loopx]["SameSenderRecieverAnalyze"].ToString(), DS.Tables[0].Rows[Loopx]["LoadSourceInvalid"].ToString());
                            Lst.Add(NSSDetail);
                        }

                        NSSBLCI.InfractionDetails = Lst;
                        NSSBLCI.DateTimeComposite = DS.Tables[0].Rows[0]["DateTimeComposite"].ToString();
                        NSSBLCI.UserName = DS.Tables[0].Rows[0]["UserName"].ToString();
                        NSSBLCI.Status = DS.Tables[0].Rows[0]["Status"].ToString();
                        NSSBLCI.BLCTitle = DS.Tables[0].Rows[0]["BLCTitle"].ToString();
                        return NSSBLCI;
                    }
                    catch (BillOfLadingControlInfractionNotFoundException ex)
                    { throw ex; }
                    catch (Exception ex)
                    { throw new Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "\n\r" + ex.Message); }

                }
            }

            namespace Exceptions
            {
                public class BillOfLadingControlInfractionNotFoundException : ApplicationException
                {
                    public override string Message
                    { get { return "تخلفات فایل کنترل بارنامه با شماره شاخص مورد نظر وجود ندارد"; } }
                }

            }



        }

    }




}
