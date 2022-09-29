
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.ServiceModel
Imports System.Text
Imports System.Windows.Forms


Imports PayanehClassLibrary.AnnouncementHallsManagement
Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DataBaseManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.LoadNotification.LoadPermission
Imports PayanehClassLibrary.TransportCompanies
Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.PublicProc
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.ExceptionManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.DateAndTimeManagement.CalendarManagement.PersianCalendar
Imports R2Core.EntityRelationManagement
Imports R2Core.LoggingManagement
Imports R2Core.NetworkInternetManagement.Exceptions
Imports R2Core.DesktopProcessesManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletChargeManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.ProcessesManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.ComputerMessages
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.EntityRelations
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadPermission
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.TruckDrivers
Imports R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrinting
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrintRequest
Imports R2CoreTransportationAndLoadNotification.Turns.TurnRegisterRequest
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.Rmto
Imports PayanehClassLibrary.DriverTrucksManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports TWSClassLibrary.TDBClientManagement
Imports PayanehClassLibrary.Logging
Imports PayanehClassLibrary.ReportsManagement
Imports PayanehClassLibrary.TruckersAssociationControllingMoneyWallet.Exceptions
Imports R2Core.SecurityAlgorithmsManagement.SQLInjectionPrevention
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.AnnouncementTiming
Imports PayanehClassLibrary.TurnRegisterRequest
Imports R2CoreTransportationAndLoadNotification.TransportCompanies
Imports R2CoreTransportationAndLoadNotification.TerraficCardsManagement
Imports R2CoreTransportationAndLoadNotification.TerraficCardsManagement.Exceptions
Imports R2Core.PermissionManagement
Imports R2CoreTransportationAndLoadNotification.PermissionManagement
Imports R2CoreTransportationAndLoadNotification.RequesterManagement
Imports PayanehClassLibrary.RequesterManagement
Imports PayanehClassLibrary.TurnRegisterRequest.Exceptions
Imports PayanehClassLibrary.CarTruckNobatManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions
Imports R2CoreParkingSystem.TrafficCardsManagement.ExceptionManagement
Imports R2Core.PermissionManagement.Exceptions
Imports PayanehClassLibrary.ComputerMessages
Imports R2CoreParkingSystem.CarType
Imports R2CoreParkingSystem.Logging
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions
Imports PayanehClassLibrary.CarTrucksManagement.Exceptions
Imports R2Core.MoneyWallet.Exceptions

Namespace Logging

    Public MustInherit Class PayanehClassLibraryLogType
        Inherits R2CoreParkingSystemLogType

        Public Shared ReadOnly Property CarTruckUpdateInfSuccess As Int64 = 17
        Public Shared ReadOnly Property CarTruckUpdateInfNotSuccess As Int64 = 18
        Public Shared ReadOnly Property TurnsCancellation As Int64 = 21
        Public Shared ReadOnly Property AutomaticTurnRegistering As Int64 = 52
    End Class

End Namespace

Namespace ComputerMessages

    Public MustInherit Class PayanehClassLibraryComputerMessageTypes
        Inherits R2Core.ComputerMessagesManagement.R2CoreComputerMessageTypes
        Public Shared ReadOnly ChangeDriverTruck As Int64 = 4
        Public Shared ReadOnly ChangeCarTruckNumberPlate As Int64 = 5
    End Class

End Namespace

Namespace DataBaseManagement
    Public Class R2ClassSqlConnectionSepas
        Inherits R2ClassSqlConnection

        Public Sub New()
            MyBase.New()
            Try
                _Connection = New SqlClient.SqlConnection(DefaultConnectionString.Replace("@", "Dbtransport"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

End Namespace

Namespace CarTruckNobatManagement

    Public Class R2StandardCarTruckNobatStructure
        Private _nEnterExitId As Int64
        Private _EnterDate As String
        Private _EnterTime As String
        Private _NSSDriverTruck As R2StandardDriverTruckStructure
        Private _bFlagDriver As Boolean
        Private _NUserIdEnter As Int64
        Private _OtaghdarTurnNumber As String
        Private _StrCardNo As Int64
        Private _RegisteringTimeStamp As DateTime


        Public Sub New()
            MyBase.New()
            _nEnterExitId = 0 : _EnterDate = "" : _EnterTime = "" : _NSSDriverTruck = Nothing : _bFlagDriver = True : _NUserIdEnter = 0 : _OtaghdarTurnNumber = "" : _StrCardNo = 0 : _RegisteringTimeStamp = Now
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSDriverTruck As R2StandardDriverTruckStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64, YourRegisteringTimeStamp As DateTime)
            _nEnterExitId = YournEnterExitId
            _EnterDate = YourEnterDate
            _EnterTime = YourEnterTime
            _NSSDriverTruck = YourNSSDriverTruck
            _bFlagDriver = YourbFlagDriver
            _NUserIdEnter = YournUserIdEnter
            _OtaghdarTurnNumber = YourOtaghdarTurnNumber
            _StrCardNo = YourStrCardNo
            _RegisteringTimeStamp = YourRegisteringTimeStamp
        End Sub

        Public Property nEnterExitId() As Int64
            Get
                Return _nEnterExitId
            End Get
            Set(ByVal Value As Int64)
                _nEnterExitId = Value
            End Set
        End Property
        Public Property EnterDate() As String
            Get
                Return _EnterDate
            End Get
            Set(ByVal Value As String)
                _EnterDate = Value
            End Set
        End Property
        Public Property EnterTime() As String
            Get
                Return _EnterTime
            End Get
            Set(ByVal Value As String)
                _EnterTime = Value
            End Set
        End Property
        Public Property NSSDriverTruck() As R2StandardDriverTruckStructure
            Get
                Return _NSSDriverTruck
            End Get
            Set(ByVal Value As R2StandardDriverTruckStructure)
                _NSSDriverTruck = Value
            End Set
        End Property
        Public Property bFlagDriver() As Boolean
            Get
                Return _bFlagDriver
            End Get
            Set(ByVal Value As Boolean)
                _bFlagDriver = Value
            End Set
        End Property
        Public Property nUserIdEnter() As Int64
            Get
                Return _NUserIdEnter
            End Get
            Set(ByVal Value As Int64)
                _NUserIdEnter = Value
            End Set
        End Property
        Public Property OtaghdarTurnNumber() As String
            Get
                Return _OtaghdarTurnNumber
            End Get
            Set(ByVal Value As String)
                _OtaghdarTurnNumber = Value
            End Set
        End Property
        Public ReadOnly Property OtaghdarTurnNumberSummary() As String
            Get
                Return Mid(_OtaghdarTurnNumber, 7, 20)
            End Get
        End Property
        Public Property StrCardNo() As Int64
            Get
                Return _StrCardNo
            End Get
            Set(ByVal Value As Int64)
                _StrCardNo = Value
            End Set
        End Property
        Public Property RegisteringTimeStamp() As DateTime
            Get
                Return _RegisteringTimeStamp
            End Get
            Set(ByVal Value As DateTime)
                _RegisteringTimeStamp = Value
            End Set
        End Property




    End Class

    Public Structure PayanehClassLibraryTurnDetails
        Public nEnterExitId As Int64
        Public TruckLPString As String
        Public StrEnterDate As String
        Public StrEnterTime As String
        Public TruckDriver As String
        Public OtaghdarSeqTurnNumber As String
        Public TurnStatusTitle As String
    End Structure

    Public Class PayanehClassLibraryMClassCarTruckNobatManager
        Private _DateTime As New DateAndTimeManagement.R2DateTime

        Private Sub TurnsCancellation(YourNSSSequentialTurn As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim TimeOfDay = New R2StandardDateAndTimeStructure(_DateTime.GetCurrentDateTimeMilladiFormated, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime)
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceConfigurations = New R2CoreInstanceConfigurationManager
                Dim DSTurns As DataSet = Nothing
                Dim TotalTurns = InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                       "Select nEnterExitId from dbtransport.dbo.tbEnterExit as Turns
                        Where (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ") and
                              Substring(Turns.OtaghdarTurnNumber,1,1)='" & YourNSSSequentialTurn.SequentialTurnKeyWord & "' and
                              ((Turns.strCardno in (Select Distinct nIDCar from dbtransport.dbo.TbCar Where strCarSerialNo in ('13','23','43','53')
                                                    Union
                                                    Select Distinct nIDCar from dbtransport.dbo.TbCar as Cars 
                                                      Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP as IndigenousTrucksWithUNNativeLP On Cars.strCarNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Pelak Collate Arabic_CI_AI_WS and Cars.strCarSerialNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Serial Collate Arabic_CI_AI_WS 
							                        Where IndigenousTrucksWithUNNativeLP.EnghezaDate>='" & TimeOfDay.DateShamsiFull & "' or IndigenousTrucksWithUNNativeLP.EnghezaDate='') and
	                            Turns.strEnterDate Collate Arabic_CI_AI_WS<=(Select Top 1 DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                             Where DateShamsi<
                                                                                (Select Top 1 DateShamsi from 
                                                                                  (Select Top " & InstanceConfigurations.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 5) & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                                   Where PCType=0 and DateShamsi<='" & TimeOfDay.DateShamsiFull & "' Order By DateShamsi desc) as DataBox
                                                                                 Order By DateShamsi)
                                                                             Order By DateShamsi Desc)
   	                           )
	                           or
	                           (Turns.strCardno not in (Select Distinct nIDCar from dbtransport.dbo.TbCar Where strCarSerialNo in ('13','23','43','53')
                                                        Union
                                                        Select Distinct nIDCar from dbtransport.dbo.TbCar as Cars 
                                                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP as IndigenousTrucksWithUNNativeLP On Cars.strCarNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Pelak Collate Arabic_CI_AI_WS and Cars.strCarSerialNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Serial Collate Arabic_CI_AI_WS
 						                                Where IndigenousTrucksWithUNNativeLP.EnghezaDate>='" & TimeOfDay.DateShamsiFull & "' or IndigenousTrucksWithUNNativeLP.EnghezaDate='') and
	                            Turns.strEnterDate Collate Arabic_CI_AI_WS<=(Select Top 1 DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                             Where DateShamsi<
                                                                                (Select Top 1 DateShamsi from 
                                                                                  (Select Top " & InstanceConfigurations.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 6) & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                                   Where PCType=0 and DateShamsi<='" & TimeOfDay.DateShamsiFull & "' Order By DateShamsi desc) as DataBox
                                                                                 Order By DateShamsi)
                                                                             Order By DateShamsi Desc)
 	                           )
                              )
                        order by nEnterExitId Desc", 0, DSTurns).GetRecordsCount
                If TotalTurns > 0 Then
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText =
                     "Update dbtransport.dbo.TbEnterExit
                      Set TurnStatus=" & TurnStatuses.CancelledUnderScore & ",bFlag=1,bFlagDriver=1,strElamDate='" & TimeOfDay.DateShamsiFull & "',strElamTime='" & TimeOfDay.Time & "',nUserIdExit=" & YourNSSSoftwareUser.UserId & " 
                      Where nEnterExitId In   
                       (Select nEnterExitId from dbtransport.dbo.tbEnterExit as Turns
                        Where (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ") and
                              Substring(Turns.OtaghdarTurnNumber,1,1)='" & YourNSSSequentialTurn.SequentialTurnKeyWord & "' and
                              ((Turns.strCardno in (Select Distinct nIDCar from dbtransport.dbo.TbCar Where strCarSerialNo in ('13','23','43','53')
                                                    Union
                                                    Select Distinct nIDCar from dbtransport.dbo.TbCar as Cars 
                                                      Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP as IndigenousTrucksWithUNNativeLP On Cars.strCarNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Pelak Collate Arabic_CI_AI_WS and Cars.strCarSerialNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Serial Collate Arabic_CI_AI_WS 
							                        Where IndigenousTrucksWithUNNativeLP.EnghezaDate>='" & TimeOfDay.DateShamsiFull & "' or IndigenousTrucksWithUNNativeLP.EnghezaDate='') and
	                            Turns.strEnterDate Collate Arabic_CI_AI_WS<=(Select Top 1 DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                             Where DateShamsi<
                                                                                (Select Top 1 DateShamsi from 
                                                                                  (Select Top " & InstanceConfigurations.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 5) & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                                   Where PCType=0 and DateShamsi<='" & TimeOfDay.DateShamsiFull & "' Order By DateShamsi desc) as DataBox
                                                                                 Order By DateShamsi)
                                                                             Order By DateShamsi Desc)
   	                           )
	                           or
	                           (Turns.strCardno not in (Select Distinct nIDCar from dbtransport.dbo.TbCar Where strCarSerialNo in ('13','23','43','53')
                                                        Union
                                                        Select Distinct nIDCar from dbtransport.dbo.TbCar as Cars 
                                                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP as IndigenousTrucksWithUNNativeLP On Cars.strCarNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Pelak Collate Arabic_CI_AI_WS and Cars.strCarSerialNo Collate Arabic_CI_AI_WS=IndigenousTrucksWithUNNativeLP.Serial Collate Arabic_CI_AI_WS
 						                                Where IndigenousTrucksWithUNNativeLP.EnghezaDate>='" & TimeOfDay.DateShamsiFull & "' or IndigenousTrucksWithUNNativeLP.EnghezaDate='') and
	                            Turns.strEnterDate Collate Arabic_CI_AI_WS<=(Select Top 1 DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                             Where DateShamsi<
                                                                                (Select Top 1 DateShamsi from 
                                                                                  (Select Top " & InstanceConfigurations.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 6) & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                                                                   Where PCType=0 and DateShamsi<='" & TimeOfDay.DateShamsiFull & "' Order By DateShamsi desc) as DataBox
                                                                                 Order By DateShamsi)
                                                                             Order By DateShamsi Desc)
 	                           )
                              )
                       )"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                    'در آنلاین
                    For LoopOnLine As Int64 = 0 To DSTurns.Tables(0).Rows.Count - 1
                        Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(DSTurns.Tables(0).Rows(LoopOnLine).Item("nEnterExitId")).NSSCar.nIdCar)
                        TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                    Next
                    'Dim TurnsSB = New StringBuilder
                    'For LoopxLog As Int64 = 0 To DSTurns.Tables(0).Rows.Count - 1
                    '    TurnsSB.Append(DSTurns.Tables(0).Rows(LoopxLog).Item("nEnterExitId")).Append(",")
                    'Next
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(Nothing, PayanehClassLibraryLogType.TurnsCancellation, "کنسل کردن گروهی نوبت ها", "SeqT=" + YourNSSSequentialTurn.SequentialTurnTitle, "TotalTurn=" + TotalTurns.ToString, String.Empty, String.Empty, String.Empty, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, Nothing, Nothing))
                End If
            Catch ex As SqlInjectionException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub TurnsCancellation(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanExcecuteTurnCancellation, YourNSSSoftwareUser.UserId, 0) Then Throw New PermissionException

                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim InstanceSequentialTurns = New R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager
                Dim InstanceConfigurations = New R2CoreInstanceConfigurationManager
                Dim TimeofDay = _DateTime.GetCurrentTime
                'طبق کانفیگ سیستم کلا ابطال نوبت ها فعال باشد یا نه
                If Not InstanceConfigurations.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 0) Then Return
                'کنترل این که ممکن است هنوز آزاد سازی بار تمام نشده باشد لذا ابطال نوبت ها نباید انجام گیرد حتی اگر زمان ابطال نوبت ها فرارسیده باشد
                Dim InstanceLoadAllocation = New R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager
                If InstanceLoadAllocation.GetLoadAllocationsforLoadPermissionRegistering().Count <> 0 Then Exit Sub
                'ابطال نوبت ها
                Dim LstSeqTs = InstanceSequentialTurns.GetSequentialTurns()
                For Loopx As Int64 = 0 To LstSeqTs.Count - 1
                    Dim ComposeSearchString As String = LstSeqTs(Loopx).SequentialTurnId.ToString + "="
                    Dim AllSeqTConfig As String() = Split(InstanceConfigurations.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 2), "-")
                    Dim ConfigSeqTTurnsCancellationActiveFlag As Boolean = Split(Mid(AllSeqTConfig.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllSeqTConfig.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "|")(0)
                    Dim ConfigSeqTTurnsCancellationStartSendingTime As String = Split(Mid(AllSeqTConfig.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllSeqTConfig.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "|")(1)
                    If Not ConfigSeqTTurnsCancellationActiveFlag Then Continue For
                    If TimeofDay < ConfigSeqTTurnsCancellationStartSendingTime Then Continue For
                    TurnsCancellation(LstSeqTs(Loopx), YourNSSSoftwareUser)
                Next
            Catch ex As PermissionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub TurnCancellationWithLicensePlate(YourLPPelak As String, YourLPSerial As String, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourLPPelak)
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourLPSerial)

                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanExcecuteTurnCancellationWithLicensePlate, YourNSSSoftwareUser.UserId, 0) Then Throw New PermissionException

                Dim InstanceCarTrucks = New PayanehClassLibraryMClassCarTrucksManager
                Dim NSSTruck = New R2CoreTransportationAndLoadNotificationStandardTruckStructure(New R2StandardCarStructure(Nothing, Nothing, YourLPPelak, YourLPSerial, Nothing), Nothing)
                Dim TruckId As Int64 = Nothing
                If InstanceCarTrucks.IsExistCarTruckWithLicensePlate(New R2StandardCarTruckStructure(NSSTruck.NSSCar, Nothing), TruckId) Then
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledUser & ",bFlag=1,bFlagDriver=1,nUserIdExit=" & YourNSSSoftwareUser.UserId & " 
                                          Where StrCardNo=" & TruckId & " and (TurnStatus=" & TurnStatuses.Registered & " or TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & " or TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & " or TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or TurnStatus=" & TurnStatuses.ResuscitationUser & ")"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                    If R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TWS, 0) Then
                        TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo)
                    End If
                Else
                    Throw New TruckNotFoundException
                End If
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                                OrElse TypeOf ex Is TerraficCardNotFoundException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException _
                                OrElse TypeOf ex Is SqlInjectionException _
                                OrElse TypeOf ex Is PermissionException
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetTurnofKiosk(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure, YourNSSTransportCompany As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure, YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim InstanceTerraficCards = New R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager
                Dim NSSMoneyWallet = InstanceTerraficCards.GetNSSTerafficCard(YourNSSTransportCompany)
                Dim CurrentDateTimeMilladiFormated = _DateTime.GetCurrentDateTimeMilladiFormated
                Dim CurrentDateShamsiFull = _DateTime.GetCurrentDateShamsiFull
                'تراکنش ثبت روابط موقت ناوگان و راننده باری و کیف پول و زیرگروه اعلام بار
                'کلیه روابط به صورت موقت ایجاد می گردند و از طریق فیلد تایم استمپ در کل سیستم ایزوله می شوند و شناسایی می گردند
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Insert into dbtransport.dbo.TbCarAndPerson(nIDCar,nIDPerson,snRelation,dDate,strDesc,RelationTimeStamp)
                  				      Values(" & YourNSSTruck.NSSCar.nIdCar & "," & YourNSSTruckDriver.NSSDriver.nIdPerson & ",2,'" & CurrentDateShamsiFull & "','TempRelation','" & CurrentDateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars(CardId, nCarId, RelationActive, RelationTimeStamp) 
                  				      Values(" & NSSMoneyWallet.CardId & "," & YourNSSTruck.NSSCar.nIdCar & ",1,'" & CurrentDateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars(CarId,AHSGId,Priority,RelationActive,RelationTimeStamp)
	         				          Values(" & YourNSSTruck.NSSCar.nIdCar & "," & YourNSSLoadCapacitorLoad.AHSGId & ",1,1,'" & CurrentDateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Dim TurnId = Int64.MinValue
                Dim InstanceTurnRegisterRequest = New PayanehClassLibraryMClassTurnRegisterRequestManager
                Dim TurnRegisterRequestId = InstanceTurnRegisterRequest.RealTimeTurnRegisterRequest(YourNSSTruck, True, True, TurnId, PayanehClassLibraryRequesters.GetTurnofKiosk, TurnType.Temporary, YourUserNSS)
                Return TurnId
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is SoftwareUserMoneyWalletNotFoundException _
                                OrElse TypeOf ex Is LoadCapacitorLoadNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetHazinehSodoorNobat(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                If YourNSSTerafficCard.CardType = TerafficCardType.Tereili Then Return GetSherkatHazinehNobatMblgh(YourNSSTerafficCard) + InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1)
                If YourNSSTerafficCard.CardType = TerafficCardType.SixCharkh Or YourNSSTerafficCard.CardType = TerafficCardType.TenCharkh Then Return GetSherkatHazinehNobatMblgh(YourNSSTerafficCard) + InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetSherkatHazinehNobatMblgh(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                'این روتین فعلا فقط مخصوص تریلی است که اقدام به صدور نوبت در اتاق کامپیوترر می کند - محاسبه هزینه متفاوت از تردد نیست
                'در صورتی که ناوگان در محدوده 72 ساعت از صدور نوبت باشد(نه تردد) و مجددا نوبت بخواهد هزینه دارد - مثلا بار تهران می برد و قبل 72 برمیگردد نوبت بزند
                'مبلغ پایه هزینه صدور نوبت برای شرکت از کانفیگ
                Dim mySherkatHazinehNobat As Int64
                Dim CurrentDateTimeMilladi = _DateTime.GetCurrentDateTimeMilladi
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If YourTrafficCard.CardType = TerafficCardType.Tereili Then mySherkatHazinehNobat = InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 0)
                If YourTrafficCard.CardType = TerafficCardType.SixCharkh Then mySherkatHazinehNobat = InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 5)
                If YourTrafficCard.CardType = TerafficCardType.TenCharkh Then mySherkatHazinehNobat = InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 6)
                'احراز معیار محاسبه
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & " or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SherkatHazinehNobat & " ) order by DateMilladiA desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Return mySherkatHazinehNobat
                Dim Tavaghof As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), CurrentDateTimeMilladi)
                If YourTrafficCard.CardType = TerafficCardType.Tereili Then
                    If Tavaghof >= InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 2) Then
                        Return mySherkatHazinehNobat
                    Else
                        If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), CurrentDateTimeMilladi)
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                    If Tavaghof >= InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 11) Then
                        Return mySherkatHazinehNobat
                    Else
                        If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), CurrentDateTimeMilladi)
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    If Tavaghof >= InstanceConfiguration.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 12) Then
                        Return mySherkatHazinehNobat
                    Else
                        If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), CurrentDateTimeMilladi)
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSCarTruckNobat(YournEnterExitId As Int64) As R2StandardCarTruckNobatStructure
            Try
                Dim Ds As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceDriverTrucks = New PayanehClassLibraryMClassDriverTrucksManager
                If InstanceSqlDataBOX.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select Top 1 * from dbtransport.dbo.TbEnterExit Where nEnterExitId=" & YournEnterExitId & "", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Dim NSS As R2StandardCarTruckNobatStructure = New R2StandardCarTruckNobatStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                NSS.NSSDriverTruck = InstanceDriverTrucks.GetNSSDriverTruckbyDriverId(Ds.Tables(0).Rows(0).Item("nDriverCode"))
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                Return NSS
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetReserveTurn(YourTurnRegisterRequestId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                'ناوگان پیش فرض 
                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Dim NSSTruck = InstanceTrucks.GetNSSDefaultTruck()
                'راننده ناوگان پیش فرض
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim NSSDriverTruck = InstanceTruckDrivers.GetNSSDefaultTruckDriver()
                'تسلسل نوبت پیش فرض
                Dim InstanceSequentialTurns = New R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager
                Dim NSSSeqT = InstanceSequentialTurns.GetNSSSequentialTurn(SequentialTurns.None)
                'شاخص درخواست صدور نوبت
                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim NSSTRR = InstanceTurnRegisterRequest.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId)
                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,20) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                SequentialTurnId = CmdSql.ExecuteScalar + 1
                SequentialTurnId_ = NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim TurnRegisteringTimeStamp = InstanceTurns.GetTurnRegisteringTimeStampWithTurnType(YourTurnType)

                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus,RegisteringTimeStamp) Values(" & mynIdEnterExit & "," & NSSTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTRR.Description & "',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',1,1," & NSSDriverTruck.NSSDriver.nIdPerson & ",0,'" & SequentialTurnId_ & "'," & TurnStatuses.CancelledSystem & "," & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ",'" & TurnRegisteringTimeStamp.DateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

                Return mynIdEnterExit
            Catch ex As Exception When TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub SetbFlagDriverToTrue(YournEnterExitId As Int64, DoSendtoTWSFlag As Boolean, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim InstanceCarTrucks = New PayanehClassLibraryMClassCarTrucksManager
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledUser & ",bFlag=1,bFlagDriver=1,nUserIdExit=" & YourNSSSoftwareUser.UserId & " Where nEnterExitId=" & YournEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                If DoSendtoTWSFlag Then
                    Dim NSSCarTruck As R2StandardCarTruckStructure = InstanceCarTrucks.GetNSSCarTruckByCarId(InstanceTurns.GetNSSTruck(YournEnterExitId).NSSCar.nIdCar)
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                End If
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetAllofActiveTurns(YourNSSSequentialTurn As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure) As List(Of PayanehClassLibraryTurnDetails)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas,
                     "Select Turns.nEnterExitId,Cars.strCarNo+'-'+Cars.strCarSerialNo as TruckLPString,Turns.strEnterDate,Turns.strEnterTime,Turns.strDriverName,OtaghdarTurnNumber,TurnStatuses.TurnStatusTitle 
                       from dbtransport.dbo.TbEnterExit as Turns
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SequentialTurns On SUBSTRING(Turns.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS = SequentialTurns.SeqTKeyWord  Collate Arabic_CI_AI_WS
                          Inner Join dbtransport.dbo.tbCar AS Cars On Turns.strCardno=Cars.nIDCar 
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatuses On Turns.TurnStatus=TurnStatuses.TurnStatusId 
                       Where (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ")
                             and Substring(OtaghdarTurnNumber,1,1)='" & YourNSSSequentialTurn.SequentialTurnKeyWord & "' and SequentialTurns.Active=1 and SequentialTurns.Deleted=0 and Cars.ViewFlag=1
                       Order By nEnterExitId Desc", 0, Ds).GetRecordsCount() = 0 Then
                    Throw New GetDataException
                End If
                Dim Lst = New List(Of PayanehClassLibraryTurnDetails)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim ST = New PayanehClassLibraryTurnDetails
                    ST.nEnterExitId = Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")
                    ST.TruckLPString = Ds.Tables(0).Rows(Loopx).Item("TruckLPString").trim
                    ST.StrEnterDate = Ds.Tables(0).Rows(Loopx).Item("strEnterDate").trim
                    ST.StrEnterTime = Ds.Tables(0).Rows(Loopx).Item("strEnterTime").trim
                    ST.TruckDriver = Ds.Tables(0).Rows(Loopx).Item("strDriverName").trim
                    ST.OtaghdarSeqTurnNumber = Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber").trim
                    ST.TurnStatusTitle = Ds.Tables(0).Rows(Loopx).Item("TurnStatusTitle").trim
                    Lst.Add(ST)
                Next
                Return Lst
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class PayanehClassLibraryMClassCarTruckNobatManagement

        Private Shared _DateTime As New DateAndTimeManagement.R2DateTime

        Private Shared Function GetReplicaTurnPrintRequestCost(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
            Try
                'هزینه چاپ قبض نوبت  - المثنی
                Dim ReplicaTurnPrintCost As Int64
                If YourNSSTerafficCard.CardType = TerafficCardType.Tereili Then ReplicaTurnPrintCost = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 3)
                If YourNSSTerafficCard.CardType = TerafficCardType.SixCharkh Or YourNSSTerafficCard.CardType = TerafficCardType.TenCharkh Then ReplicaTurnPrintCost = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4)
                Return ReplicaTurnPrintCost
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ReplicaTurnPrintRequest(YourNSSCarTruckNobat As R2StandardCarTruckNobatStructure, YourTurnPrintRedirect As Boolean, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourNSSCarTruckNobat.nEnterExitId).NSSCar.nIdCar))
                'کنترل موجودی کیف پول به منظور کسر هزینه چاپ قبض نوبت  - المثنی
                Dim ReplicaTurnPrintCost = GetReplicaTurnPrintRequestCost(NSSTerafficCard)
                If R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTerafficCard) < ReplicaTurnPrintCost Then
                    Throw New MoneyWalletCurrentChargeNotEnoughException
                End If
                R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, ReplicaTurnPrintCost, R2CoreParkingSystemAccountings.PrintCopyOfTurn, YourUserNSS)
                R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManagement.ReplicaTurnPrintRequest(YourNSSCarTruckNobat.nEnterExitId, YourTurnPrintRedirect)
            Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException OrElse TypeOf ex Is MoneyWalletNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub NoCostTurnPrintRequest(YourNSSCarTruckNobat As R2StandardCarTruckNobatStructure, YourTurnPrintRedirect As Boolean)
            Try
                R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManagement.NoCostTurnPrintRequest(YourNSSCarTruckNobat.nEnterExitId, YourTurnPrintRedirect)
            Catch ex As Exception When TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetCarTravellength(YournIdCar As Int64) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 * from dbtransport.dbo.TbEnterExit as E 
                                                     Inner join TbCity as C on E.nCityCode=C.nCityCode 
                                                   Where E.StrCardNo=" & YournIdCar & " and ((E.TurnStatus=" & TurnStatuses.UsedLoadPermissionRegistered & ")  or (E.TurnStatus=" & TurnStatuses.CancelledLoadPermissionCancelled & "))
                                                   Order By nEnterExitId Desc")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Return 0
                Else
                    Dim MinuteTravelLenght As Int64 = (Ds.Tables(0).Rows(0).Item("nDistance") / 25) * 60
                    Dim DateTimeMilladiExit As DateTime = _DateTime.GetMilladiDateTimeFromDateShamsiFull(Ds.Tables(0).Rows(0).Item("StrExitDate"), Ds.Tables(0).Rows(0).Item("StrExitTime"))
                    Dim Diff As Int64 = R2CoreMClassPublicProcedures.GetDateDiff(DateInterval.Minute, DateTimeMilladiExit, _DateTime.GetCurrentDateTimeMilladiFormated())
                    Return (Diff - MinuteTravelLenght)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarTravellengthFormated(YournIdCar As Int64) As String
            Try
                Dim TLenght As Int64 = Math.Abs(GetCarTravellength(YournIdCar))
                Dim THours As Int64 = Int(TLenght / 60)
                Dim TMinutes As Int64 = TLenght - THours * 60
                Dim TString As String = String.Empty
                If THours <> 0 Then TString = THours.ToString() + " ساعت "
                If TMinutes <> 0 Then TString = TString + vbCrLf + TMinutes.ToString() + " دقیقه "
                Return TString
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsDriverHasNobat(YournIdPerson As Int64) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 nEnterExitId from dbtransport.dbo.TbEnterExit Where nDriverCode=" & YournIdPerson & " and bFlagDriver=0 Order By nEnterExitId desc")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCarTruckNobat(YournEnterExitId As Int64) As R2StandardCarTruckNobatStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select Top 1 * from dbtransport.dbo.TbEnterExit Where nEnterExitId=" & YournEnterExitId & "", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNSSException
                End If
                Dim NSS As R2StandardCarTruckNobatStructure = New R2StandardCarTruckNobatStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                NSS.NSSDriverTruck = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(Ds.Tables(0).Rows(0).Item("nDriverCode"))
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                Return NSS
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetReserveTurn(YourTurnRegisterRequestId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                'ناوگان پیش فرض 
                Dim NSSTruck = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSDefaultTruck()
                'راننده ناوگان پیش فرض
                Dim NSSDriverTruck = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSDefaultTruckDriver()
                'تسلسل نوبت پیش فرض
                Dim NSSSeqT = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(SequentialTurns.None)
                'شاخص درخواست صدور نوبت
                Dim NSSTRR = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId)
                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,20) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                SequentialTurnId = CmdSql.ExecuteScalar + 1
                SequentialTurnId_ = NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim TurnRegisteringTimeStamp = InstanceTurns.GetTurnRegisteringTimeStampWithTurnType(YourTurnType)

                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus,RegisteringTimeStamp) Values(" & mynIdEnterExit & "," & NSSTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTRR.Description & "',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',1,1," & NSSDriverTruck.NSSDriver.nIdPerson & ",0,'" & SequentialTurnId_ & "'," & TurnStatuses.CancelledSystem & "," & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ",'" & TurnRegisteringTimeStamp.DateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

                Return mynIdEnterExit
            Catch ex As Exception When TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetHazinehSodoorNobat(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                If YourNSSTerafficCard.CardType = TerafficCardType.Tereili Then Return GetSherkatHazinehNobatMblgh(YourNSSTerafficCard) + R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1)
                If YourNSSTerafficCard.CardType = TerafficCardType.SixCharkh Or YourNSSTerafficCard.CardType = TerafficCardType.TenCharkh Then Return GetSherkatHazinehNobatMblgh(YourNSSTerafficCard) + R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetSherkatHazinehNobatMblgh(ByVal YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                'این روتین فعلا فقط مخصوص تریلی است که اقدام به صدور نوبت در اتاق کامپیوترر می کند - محاسبه هزینه متفاوت از تردد نیست
                'در صورتی که ناوگان در محدوده 72 ساعت از صدور نوبت باشد(نه تردد) و مجددا نوبت بخواهد هزینه دارد - مثلا بار تهران می برد و قبل 72 برمیگردد نوبت بزند
                'مبلغ پایه هزینه صدور نوبت برای شرکت از کانفیگ
                Dim mySherkatHazinehNobat As Int64
                If YourTrafficCard.CardType = TerafficCardType.Tereili Then mySherkatHazinehNobat = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 0)
                If YourTrafficCard.CardType = TerafficCardType.SixCharkh Then mySherkatHazinehNobat = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 5)
                If YourTrafficCard.CardType = TerafficCardType.TenCharkh Then mySherkatHazinehNobat = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 6)
                'احراز معیار محاسبه
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (MblghA<>0) and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.EnterType & " or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SherkatHazinehNobat & " ) order by DateMilladiA desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Return mySherkatHazinehNobat
                Dim Tavaghof As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                If YourTrafficCard.CardType = TerafficCardType.Tereili Then
                    If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 2) Then
                        Return mySherkatHazinehNobat
                    Else
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.SixCharkh Then
                    If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 11) Then
                        Return mySherkatHazinehNobat
                    Else
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                ElseIf YourTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    If Tavaghof >= R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 12) Then
                        Return mySherkatHazinehNobat
                    Else
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateMilladiA from R2Primary.dbo.TblAccounting Where (CardId=" & YourTrafficCard.CardId & ") and (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & ") order by DateMilladiA desc", 1, Ds).GetRecordsCount <> 0 Then
                            Dim TavaghofLastNobat As Int64 = DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi())
                            If TavaghofLastNobat <= Tavaghof Then
                                Return mySherkatHazinehNobat
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function SetbFlagDriverToTrue(YournEnterExitId As Int64, DoSendtoTWSFlag As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledUser & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & YournEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                If DoSendtoTWSFlag Then
                    Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YournEnterExitId).NSSCar.nIdCar)
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                End If
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub TempTurnsCancellation()
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                'آیا سرویس ابطال نوبت های موقت بر اساس کانفیگ فعال است یا نه
                If Not InstanceConfiguration.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 3) Then Return
                Dim myCurrentDateShamsi = _DateTime.GetCurrentDateShamsiFull
                Dim TotalTurns As Int64
                Dim DS As DataSet
                TotalTurns = InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                     "Select nEnterExitId from dbtransport.dbo.tbEnterExit
                      Where strEnterDate='" & myCurrentDateShamsi & "' and (TurnStatus=1 or TurnStatus=7 or TurnStatus=8 or TurnStatus=9 or TurnStatus=10) 
                            and DATEDIFF(MINUTE,RegisteringTimeStamp,GETDATE())>" & InstanceConfiguration.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 4) & " and RegisteringTimeStamp<>'2015-01-01 00:00:00.000'", 0, DS).GetRecordsCount
                If TotalTurns <> 0 Then
                    CmdSql.CommandText = "Update dbtransport.dbo.tbEnterExit Set TurnStatus=" & TurnStatuses.CancelledSystem & ",bFlag=1,bFlagDriver=1,nUserIdExit=1
                                          Where strEnterDate='" & myCurrentDateShamsi & "' and (TurnStatus=1 or TurnStatus=7 or TurnStatus=8 or TurnStatus=9 or TurnStatus=10)
                                                and DATEDIFF(MINUTE,RegisteringTimeStamp,GETDATE())>" & InstanceConfiguration.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnCancellationSetting, 4) & " and RegisteringTimeStamp<>'2015-01-01 00:00:00.000'"
                    CmdSql.Connection.Open()
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(Nothing, PayanehClassLibraryLogType.TurnsCancellation, "کنسل کردن نوبت های موقت", "TotalTurns=" + TotalTurns.ToString, String.Empty, String.Empty, String.Empty, String.Empty, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, Nothing, Nothing))
                End If
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function SetbFlagDriverToFalse(YournEnterExitId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationUser & ",bFlag=1,bFlagDriver=0 Where nEnterExitId=" & YournEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNobatDateShamsi(YournEnterExitId As Int64) As String
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Top 1 StrEnterDate,StrEnterTime From dbtransport.dbo.TbEnterExit Where nenterexitid=" & YournEnterExitId & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Throw New NobatNotExistException
                Else
                    Return Ds.Tables(0).Rows(0).Item("StrEnterDate").trim
                End If
            Catch exx As NobatNotExistException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNobatTime(YournEnterExitId As Int64) As String
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Top 1 StrEnterDate,StrEnterTime From dbtransport.dbo.TbEnterExit Where nenterexitid=" & YournEnterExitId & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Throw New NobatNotExistException
                Else
                    Return Ds.Tables(0).Rows(0).Item("StrEnterTime").trim
                End If
            Catch exx As NobatNotExistException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNobatDateMilladi(YournEnterExitId As Int64) As DateTime
            Try
                Return _DateTime.GetMilladiDateTimeFromDateShamsiFull(GetNobatDateShamsi(YournEnterExitId), GetNobatTime(YournEnterExitId))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNobatDifrenceDayToToday(YournEnterExitId As Int64) As Int64
            Try
                Return R2CoreMClassPublicProcedures.GetDateDiff(DateInterval.Day, GetNobatDateMilladi(YournEnterExitId), _DateTime.GetCurrentDateTimeMilladiFormated())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLastActiveNSSNobat(YourNSSCar As R2StandardCarStructure) As R2StandardCarTruckNobatStructure
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 * from dbtransport.dbo.TbEnterExit Where StrCardNo=" & YourNSSCar.nIdCar & " and (bFlagDriver=0) Order By nEnterExitId desc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetNobatException("ناوگان نوبت ندارد")
                End If
                Return New R2StandardCarTruckNobatStructure(Ds.Tables(0).Rows(0).Item("nEnterExitId"), Ds.Tables(0).Rows(0).Item("StrEnterDate"), Ds.Tables(0).Rows(0).Item("StrEnterTime"), PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(Ds.Tables(0).Rows(0).Item("nDriverCode")), Ds.Tables(0).Rows(0).Item("bFlagDriver"), Ds.Tables(0).Rows(0).Item("nUserIdEnter"), Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, Ds.Tables(0).Rows(0).Item("StrCardNo"), Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp"))
            Catch exx As GetNobatException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsCarTruckTankTreiler(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from PayanehAmirKabir.dbo.TblTankTrailers Where Deleted=0 and OActive=1 and Pelak='" & YourNSSTruck.NSSCar.StrCarNo & "' and Serial='" & YourNSSTruck.NSSCar.StrCarSerialNo & "'", 0, Ds).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ChangeCarTruckTankTreilerStatus(YourNSS As R2StandardCarTruckStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                CmdSql.Connection.Open()
                If IsCarTruckTankTreiler(InstanceTrucks.GetNSSTruck(YourNSS.NSSCar.nIdCar)) Then
                    CmdSql.CommandText = "Update PayanehAmirKabir.dbo.TblTankTrailers Set OActive=0 Where ltrim(rtrim(Pelak))='" & YourNSS.NSSCar.StrCarNo & "' and ltrim(rtrim(Serial))= '" & YourNSS.NSSCar.StrCarSerialNo & "'"
                Else
                    CmdSql.CommandText = "Update PayanehAmirKabir.dbo.TblTankTrailers Set OActive=1 Where ltrim(rtrim(Pelak))='" & YourNSS.NSSCar.StrCarNo & "' and ltrim(rtrim(Serial))= '" & YourNSS.NSSCar.StrCarSerialNo & "'"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub AutomaticTurnRegistering()
            Try
                'ابتدا تولید رشته ساب کوری
                'گروه های اعلام بار
                Dim InstanceAnnouncementHalls = New R2CoreTransportationAndLoadNotificationInstanceAnnouncementHallsManager
                Dim AnnouncementHalls = InstanceAnnouncementHalls.GetAnnouncementHalls()
                Dim SubQuery = String.Empty
                For LoopAnnouncementHalls As Int16 = 0 To AnnouncementHalls.Count - 1
                    Dim AHSGsConfig = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnRegisteringSetting, AnnouncementHalls(LoopAnnouncementHalls).AHId, 0), "-")
                    'زیرگروه های اعلام بار
                    Dim AnnouncementHallsSubGroups = InstanceAnnouncementHalls.GetAnnouncementHallSubGroups(AnnouncementHalls(LoopAnnouncementHalls).AHId)
                    For LoopAnnouncementHallsSubGroups As Int16 = 0 To AnnouncementHallsSubGroups.Count - 1
                        Dim LoopIndex = LoopAnnouncementHallsSubGroups
                        Dim IsActiveAutomaticTurnRegistering As Boolean = Split(AHSGsConfig.Where(Function(x) AnnouncementHallsSubGroups(LoopIndex).AHSGId = Split(x, ":")(0))(0), ":")(2)
                        If IsActiveAutomaticTurnRegistering Then
                            Dim AHSGId = AnnouncementHallsSubGroups(LoopIndex).AHSGId
                            Dim AHId = InstanceAnnouncementHalls.GetNSSAnnouncementHallByAnnouncementHallSubGroup(AHSGId).AHId
                            Dim AHSGIdLastAnnounceTime = InstanceAnnouncementHalls.GetAnnouncemenetHallLastAnnounceTime(AHId, AHSGId)
                            SubQuery = SubQuery + " or (AHSGId=" & AnnouncementHallsSubGroups(LoopIndex).AHSGId.ToString() & " and Turns.strExitTime > '" & AHSGIdLastAnnounceTime.Time & "')"
                        End If
                    Next
                Next

                'بدست آوردن لیست نوبت هایی که مجوز برایشان  صادر شده و باید نوبت برایشان صادر شود
                Dim Query = "Select Turns.strBarnameNo,Turns.nEnterExitId,Turns.strCardno,Loads.AHId,Loads.AHSGId from dbtransport.dbo.tbEnterExit as Turns
                                       Inner Join dbtransport.dbo.tbElam as Loads On Turns.nEstelamID=Loads.nEstelamID 
                                 Where  Turns.strCardno not in (Select strCardno from dbtransport.dbo.tbEnterExit Where (TurnStatus=1 or TurnStatus=7 or TurnStatus=8 or TurnStatus=9 or TurnStatus=10) and strEnterDate='" & _DateTime.GetCurrentDateShamsiFull & "') and 
                                        Turns.TurnStatus = 6 And Turns.strExitDate ='" & _DateTime.GetCurrentDateShamsiFull & "' and (2=3" + SubQuery + ")" + " Order By Turns.nEnterExitId Asc"
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                Dim InstanceTiming = New R2CoreTransportationAndLoadNotificationInstanceAnnouncementTimingManager
                Dim InstanceLogging = New R2CoreInstanceLoggingManager
                Dim CurrentTime = _DateTime.GetCurrentTime()
                Dim DsTurns As DataSet = Nothing
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, Query, 0, DsTurns).GetRecordsCount <> 0 Then
                    For LoopTurns As Int64 = 0 To DsTurns.Tables(0).Rows.Count - 1
                        Dim AHId As Int64 = DsTurns.Tables(0).Rows(LoopTurns).Item("AHId")
                        Dim AHSGId As Int64 = DsTurns.Tables(0).Rows(LoopTurns).Item("AHSGId")
                        Dim nIdCar As Int64 = DsTurns.Tables(0).Rows(LoopTurns).Item("strCardno")
                        Dim nEnterExitId As Int64 = DsTurns.Tables(0).Rows(LoopTurns).Item("nEnterExitId")
                        Try
                            If InstanceTiming.IsTimingActive(AHId, AHSGId) Then
                                If Convert.ToInt32(DsTurns.Tables(0).Rows(LoopTurns).Item("strBarnameNo")) <> R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                    If InstanceTiming.GetTiming(AHId, AHSGId, CurrentTime) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InAutomaticTurnRegistering Then
                                        Continue For
                                    End If
                                End If
                            End If
                            'کنترل حضور ناوگان در پارکینگ - درصورتی که طبق کانفیگ باید حضورداشته باشد ولی حضور نداشته باشد آنگاه اکسپشن پرتاب می گردد
                            Dim NSSCarTruck = New R2CoreTransportationAndLoadNotificationStandardTruckStructure(New R2StandardCarStructure(nIdCar, Nothing, Nothing, Nothing, Nothing), Nothing)
                            Dim TurnId As Int64 = Int64.MinValue
                            Dim InstanceTurnRegisterRequest = New PayanehClassLibraryMClassTurnRegisterRequestManager
                            Dim TurnRegisterRequestId = InstanceTurnRegisterRequest.RealTimeTurnRegisterRequest(NSSCarTruck, True, True, TurnId, PayanehClassLibraryRequesters.AutomaticTurnRegistering, TurnType.Permanent, InstanceSoftwareUsers.GetNSSSystemUser())
                            If InstanceLogging.GetNSSLogType(PayanehClassLibraryLogType.AutomaticTurnRegistering).Active Then
                                InstanceLogging.LogRegister(New R2CoreStandardLoggingStructure(0, PayanehClassLibraryLogType.AutomaticTurnRegistering, InstanceLogging.GetNSSLogType(PayanehClassLibraryLogType.AutomaticTurnRegistering).LogTitle, "nIdCar=" + nIdCar.ToString(), "TurnRegisterRequestId=" + TurnRegisterRequestId.ToString(), String.Empty, String.Empty, String.Empty, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), Nothing))
                            End If
                        Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                                OrElse TypeOf ex Is LoadCapacitorLoadNotFoundException
                            If InstanceLogging.GetNSSLogType(PayanehClassLibraryLogType.AutomaticTurnRegistering).Active Then
                                InstanceLogging.LogRegister(New R2CoreStandardLoggingStructure(0, PayanehClassLibraryLogType.AutomaticTurnRegistering, InstanceLogging.GetNSSLogType(PayanehClassLibraryLogType.AutomaticTurnRegistering).LogTitle, "nIdCar=" + nIdCar.ToString(), ex.Message, "CurrentTurnId=" + nEnterExitId.ToString(), "AHId=" + AHId.ToString(), "AHSGId=" + AHSGId.ToString(), R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId, _DateTime.GetCurrentDateTimeMilladi(), Nothing))
                            End If
                        End Try
                    Next
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

    Public Class TurnRegisteringStrategy

        Protected _DateTime As New R2DateTime
        Protected Event DoStrategyRequestedEvent()
        Protected NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
        Protected NSSTurnRegisteringRequest As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure = Nothing
        Protected NSSSequentialTurn As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = Nothing
        Protected NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = Nothing
        Protected NSSDriverTruck As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure = Nothing
        Protected NSSSoftwareUser As R2CoreStandardSoftwareUserStructure = Nothing
        Protected NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = Nothing
        Protected TurnType As TurnType = TurnType.None
        Private CostOfTurnRegistering As Int64 = Int64.MinValue

        Public ReadOnly Property GetCostOfTurnRegistering As Int64
            Get
                Return CostOfTurnRegistering
            End Get
        End Property

        Public ReadOnly Property GetNSSTurn() As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Get
                Return NSSTurn
            End Get
        End Property

        Public Sub New()
        End Sub

        Public Sub New(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSTurnRegisteringRequest As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure, YourRequesterId As Int64, YourTurnType As TurnType)
            Try
                NSSTrafficCard = YourNSSTrafficCard
                NSSTurnRegisteringRequest = YourNSSTurnRegisteringRequest
                NSSSoftwareUser = YourUserNSS
                TurnType = YourTurnType

                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                'احراز کد ناوگان از رابطه کارت و پلاک
                Try
                    NSSTruck = InstanceTrucks.GetNSSTruck(PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(YourNSSTrafficCard.CardId)).NSSCar.nIdCar)
                Catch ex As GetDataException
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات کارت تردد و پلاک ناوگان متصل نیستند")
                End Try

                'آیا تسلسل نوبت مرتبط با ناوگان باری فعال است
                NSSSequentialTurn = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(NSSTruck.NSSCar.nIdCar))
                If Not NSSSequentialTurn.Active Then
                    Throw New SequentialTurnIsNotActiveException
                End If

                'کنترل مجوز درخواست صدور نوبت توسط رکستر خاص بر اساس تسلسل نوبت
                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.RequesterCanSendRequestforTurnIssueBySeqT, YourRequesterId, NSSSequentialTurn.SequentialTurnId) Then Throw New RequesterNotAllowTurnIssueBySeqTException

                'کنترل مجوز درخواست صدور نوبت توسط رکستر خاص بر اساس نوع آخرین بار دریافت شده
                Dim InstanceLoadPermission = New R2CoreTransportationAndLoadNotificationInstanceLoadPermissionManager
                Dim NSSLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = Nothing
                Try
                    NSSLoad = InstanceLoadPermission.GetTruckLastLoadWhichPermissioned(NSSTruck)
                    If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.RequesterCanSendRequestforTurnIssueByLastLoadPermissioned, YourRequesterId, NSSLoad.AHSGId) Then Throw New RequesterNotAllowTurnIssueByLastLoadPermissionedException
                Catch ex As RequesterNotAllowTurnIssueByLastLoadPermissionedException
                    Throw ex
                Catch ex As LoadCapacitorLoadNotFoundException
                    Throw ex
                Catch ex As TruckHasNotAnyLoadPermissionException
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try

                'احراز راننده ناوگان از رابطه ناوگان راننده
                Try
                    NSSDriverTruck = InstanceTruckDrivers.GetNSSTruckDriver(PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(NSSTruck.NSSCar.nIdCar)).NSSDriver.nIdPerson)
                Catch ex As DriverTruckInformationNotExistException
                    Throw ex
                End Try

                'کنترل تانکر مخزندار
                If PayanehClassLibraryMClassCarTruckNobatManagement.IsCarTruckTankTreiler(NSSTruck) Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "ناوگان موردنظر در لیست تانکرهای مخزندار قرار دارد", NSSTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatExceptionCarTruckIsTankTreiler
                End If

                'کنترل دارابودن نوبت در آنلاین
                Dim TWSMessage As String = TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.ExistNobat(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo)
                If TWSMessage.Trim <> String.Empty Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "صدور نوبت امکان پذیر نیست" + vbCrLf + TWSMessage, NSSTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + TWSMessage)
                End If

                'کنتر دارا بودن نوبت فعال قبلی
                If R2CoreTransportationAndLoadNotificationMClassTurnsManagement.ExistActiveTurn(NSSTruck, NSSSequentialTurn) Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "ناوگان نوبت دارد", NSSTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatExceptionCarTruckHasNobat
                End If

                'کنترل اینکه راننده نوبت دیگر نداشته باشد
                If PayanehClassLibraryMClassCarTruckNobatManagement.IsDriverHasNobat(NSSDriverTruck.NSSDriver.nIdPerson) = True Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "راننده با ناوگان دیگر نوبت دارد", NSSTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "راننده با ناوگان دیگر نوبت دارد")
                End If

                'کنترل طول سفر
                Try
                    Dim TravelLength As Int64 = PayanehClassLibraryMClassCarTruckNobatManagement.GetCarTravellength(NSSTruck.NSSCar.nIdCar)
                    'Dim NSSLOadCapacitor = LoadNotificationLoadPermissionManagement.GetCapacitorLoadLoadByCarTruckLastLoadPermissionByCarTruck(PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(NSSTruck.NSSCar.nIdCar))
                    If TravelLength < 0 Then
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, PayanehClassLibraryMClassCarTruckNobatManagement.GetCarTravellengthFormated(NSSTruck.NSSCar.nIdCar) + vbCrLf + "طول سفر ناوگان به پایان نرسیده است", NSSTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                        Throw New CarTruckTravelLengthNotOverYetException(PayanehClassLibraryMClassCarTruckNobatManagement.GetCarTravellengthFormated(NSSTruck.NSSCar.nIdCar))
                    End If
                Catch ex As CarTruckHasNotAnyLoadPermissionException
                End Try

            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException _
                                OrElse TypeOf ex Is LoadCapacitorLoadNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub DoStrategy()
            Try
                RaiseEvent DoStrategyRequestedEvent()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub DoStrategyComplementaryWorks()
            Try
                'هزینه نوبت انجمن و شرکت
                CostOfTurnRegistering = PayanehClassLibraryMClassCarTruckNobatManagement.GetSherkatHazinehNobatMblgh(NSSTrafficCard)
                If CostOfTurnRegistering > 0 Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.MinusMoney, CostOfTurnRegistering, R2CoreParkingSystemAccountings.SherkatHazinehNobat, NSSSoftwareUser)
                If NSSTrafficCard.CardType = TerafficCardType.Tereili Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, NSSSoftwareUser)
                If NSSTrafficCard.CardType = TerafficCardType.SixCharkh Or NSSTrafficCard.CardType = TerafficCardType.TenCharkh Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, NSSSoftwareUser)

                'ارسال نوبت ناوگان برای سیستم آنلاین
                If NSSTrafficCard.CardType = TerafficCardType.Tereili And R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TWS, 0) Then
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.AddNobat(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo)
                End If
                If NSSTrafficCard.CardType = TerafficCardType.SixCharkh Or NSSTrafficCard.CardType = TerafficCardType.TenCharkh And R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TWS, 1) Then
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.AddNobat(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class RealTimeTurnRegisteringStrategy
        Inherits TurnRegisteringStrategy

        Public Sub New(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSTurnRegisteringRequest As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure, YourRequesterId As Int64, YourTurnType As TurnType)
            MyBase.New(YourNSSTrafficCard, YourNSSTurnRegisteringRequest, YourUserNSS, YourRequesterId, YourTurnType)
        End Sub

        Private Sub DoStrategyRequestedEvent_Handler() Handles MyClass.DoStrategyRequestedEvent
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,20) from dbtransport.dbo.tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSequentialTurn.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                Dim TurnIdTemp As String = CmdSql.ExecuteScalar
                If TurnIdTemp = String.Empty Then
                    SequentialTurnId = 1
                Else
                    SequentialTurnId = Split(TurnIdTemp, ":")(0) + 1
                End If
                SequentialTurnId_ = NSSSequentialTurn.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()
                Dim TurnRegisteringTimeStamp = InstanceTurns.GetTurnRegisteringTimeStampWithTurnType(TurnType)
                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus,RegisteringTimeStamp) Values(" & mynIdEnterExit & "," & NSSTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTurnRegisteringRequest.Description & "',0," & NSSSoftwareUser.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',0,0," & NSSDriverTruck.NSSDriver.nIdPerson & ",0,'" & SequentialTurnId_ & "'," & TurnStatuses.Registered & "," & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ",'" & TurnRegisteringTimeStamp.DateTimeMilladiFormated & "')"
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                NSSTurn = InstanceTurns.GetNSSTurn(mynIdEnterExit)
                DoStrategyComplementaryWorks()
            Catch ex As Exception When TypeOf ex Is TurnNotFoundException OrElse TypeOf ex Is ReserveTurnAlreadyUsedException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class ReserveTurnRegisteringStrategy
        Inherits TurnRegisteringStrategy

        Public Sub New(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourNSSTurnRegisteringRequest As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure, YourRequesterId As Int64, YourTurnType As TurnType)
            MyBase.New(YourNSSTrafficCard, YourNSSTurnRegisteringRequest, YourUserNSS, YourRequesterId, YourTurnType)
        End Sub

        Private Sub DoStrategyRequestedEvent_Handler() Handles MyClass.DoStrategyRequestedEvent
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                NSSTurn = InstanceTurns.GetNSSTurn(NSSTurnRegisteringRequest)
                If NSSTurn.TurnStatus <> TurnStatuses.CancelledSystem Then Throw New ReserveTurnAlreadyUsedException
                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'محاسبه تسلسل نوبت
                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,20) from dbtransport.dbo.tbEnterExit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSequentialTurn.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' and nEnterExitId<" & NSSTurn.nEnterExitId & " order by OtaghdarTurnNumber desc"
                Dim TurnIdTemp As String = CmdSql.ExecuteScalar
                If TurnIdTemp = String.Empty Then Throw New ResuscitationReserveTurnFailedException
                SequentialTurnId = Split(TurnIdTemp, ":")(0)
                SequentialTurnId_ = NSSSequentialTurn.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim() + ":" + NSSTurn.nEnterExitId.ToString
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim TurnRegisteringTimeStamp = IIf(TurnType = TurnType.Permanent, InstanceConfiguration.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 4), _DateTime.GetCurrentDateTimeMilladiFormated)
                'احیاء نوبت رزرو
                CmdSql.CommandText = "Update dbtransport.dbo.tbEnterExit 
                                      Set strCardno=" & NSSTruck.NSSCar.nIdCar & ",strDriverName='" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',strDesc=strDesc+' - " & NSSSoftwareUser.UserName & "',bFlag=0,bFlagDriver=0,nDriverCode=" & NSSDriverTruck.NSSDriver.nIdPerson & ",OtaghdarTurnNumber='" & SequentialTurnId_ & "',TurnStatus=" & TurnStatuses.Registered & ",RegisteringTimeStamp='" & TurnRegisteringTimeStamp & "'
                                      Where nEnterExitId = " & NSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                DoStrategyComplementaryWorks()
            Catch ex As Exception When TypeOf ex Is TurnNotFoundException OrElse TypeOf ex Is ReserveTurnAlreadyUsedException OrElse TypeOf ex Is ResuscitationReserveTurnFailedException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Exceptions

        Public Class ResuscitationReserveTurnFailedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان احیاء نوبت رزرو وجود ندارد"
                End Get
            End Property
        End Class

        Public Class GetNobatException
            Inherits ApplicationException

            Private _Message As String = String.Empty

            Public Sub New(YourMessage As String)
                _Message = YourMessage
            End Sub

            Public Overrides ReadOnly Property Message As String
                Get
                    Return _Message
                End Get
            End Property
        End Class

        Public Class NobatNotExistException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره نوبت مورد نظر در سیستم ثبت نشده است"
                End Get
            End Property
        End Class

        Public Class GetNobatExceptionCarTruckIsTankTreiler
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ناوگان مورد نظر در لیست تانکرهای مخزندار قرار دارد" + vbCrLf + "امکان صدور نوبت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class GetNobatExceptionCarTruckHasNobat
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ناوگان نوبت دارد"
                End Get
            End Property
        End Class

        Public Class ViewCarTruckTurnsTerraficCardNotSupportException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع کارت تردد مطابقت ندارد"
                End Get
            End Property
        End Class

        Public Class CarTruckTravelLengthNotOverYetException
            Inherits ApplicationException
            Private _ConsumerMessage As String = String.Empty

            Public Sub New(YourMessage As String)
                _ConsumerMessage = YourMessage
            End Sub

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "طول سفر ناوگان باری به پایان نرسیده است" + vbCrLf + _ConsumerMessage
                End Get
            End Property

            Public ReadOnly Property WithoutConsumerMessage As String
                Get
                    Return "طول سفر ناوگان باری به پایان نرسیده است"
                End Get
            End Property

        End Class

        Public Class ReserveTurnAlreadyUsedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوبت رزرو مرتبط با شماره درخواست قبلا احیاء شده است"
                End Get
            End Property
        End Class

        Public Class LastTurnIdWhichCancelledDuringTurnsCancellationProcessNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "آخرین شماره اعتبار،باطل شده طی فرآیند ابطال نوبت ها ، وجود ندارد "
                End Get
            End Property
        End Class


    End Namespace


End Namespace

Namespace TurnRegisterRequest

    Public NotInheritable Class PayanehClassLibraryMClassTurnRegisterRequestManager
        Private _DateTime As New R2DateTime

        Public Sub RealTimeTurnRegisterRequestWithLicensePlate(YourLPPelak As String, YourLPSerial As String, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure, YourRequesterId As Int64, YourTurnType As TurnType)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourLPPelak)
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourLPSerial)

                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanSendRealTimeTurnRegisteringRequestWithLicensePlate, YourNSSSoftwareUser.UserId, 0) Then Throw New PermissionException

                Dim InstanceCarTrucks = New PayanehClassLibraryMClassCarTrucksManager
                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Dim InstanceTurnRegisterRequest = New PayanehClassLibraryMClassTurnRegisterRequestManager
                Dim NSSTruck = New R2CoreTransportationAndLoadNotificationStandardTruckStructure(New R2StandardCarStructure(Nothing, Nothing, YourLPPelak, YourLPSerial, Nothing), Nothing)
                Dim TruckId As Int64 = Nothing
                If InstanceCarTrucks.IsExistCarTruckWithLicensePlate(New R2StandardCarTruckStructure(NSSTruck.NSSCar, Nothing), TruckId) Then
                    NSSTruck = InstanceTrucks.GetNSSTruck(TruckId)
                    LoadNotificationLoadPermissionManagement.DoControlforTruckPresentInParkingAndLastLoadPermission(NSSTruck)
                    Dim TurnId As Int64
                    InstanceTurnRegisterRequest.RealTimeTurnRegisterRequest(NSSTruck, False, True, TurnId, YourRequesterId, YourTurnType, YourNSSSoftwareUser)
                Else
                    Throw New TruckNotFoundException
                End If
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                                OrElse TypeOf ex Is TerraficCardNotFoundException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException _
                                OrElse TypeOf ex Is SqlInjectionException _
                                OrElse TypeOf ex Is PermissionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function IsMoneyWalletInventoryIsEnoughForTurnRegistering(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                Dim InstanceMoneyWallet = New R2CoreParkingSystemInstanceMoneyWalletManager
                Dim InstanceCarTruckNobat = New PayanehClassLibraryMClassCarTruckNobatManager
                If InstanceMoneyWallet.GetMoneyWalletCharge(YourNSSTrafficCard) < InstanceCarTruckNobat.GetHazinehSodoorNobat(YourNSSTrafficCard) Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function RealTimeTurnRegisterRequest(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourTurnPrintRedirect As Boolean, YourMoneyWalletInventoryControl As Boolean, ByRef YourTurnId As Int64, YourRequesterId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim InstanceTrafficCard = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim NSSTrafficCard = InstanceTrafficCard.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                If YourMoneyWalletInventoryControl Then If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException
                'ثبت درخواست صدور نوبت بلادرنگ
                Dim TurnRegisterRequestId = InstanceTurnRegisterRequest.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.RealTime, YourNSSTruck.NSSCar.nIdCar, InstanceTurnRegisterRequest.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.RealTime).TRRTypeTitle, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ثبت نوبت
                Dim Strategy = New RealTimeTurnRegisteringStrategy(NSSTrafficCard, InstanceTurnRegisterRequest.GetNSSTurnRegisterRequest(TurnRegisterRequestId), YourUserNSS, YourRequesterId, YourTurnType)
                Strategy.DoStrategy()
                YourTurnId = Strategy.GetNSSTurn.nEnterExitId
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                Dim InstanceEntityRelation = New R2CoreMClassEntityRelationManager
                InstanceEntityRelation.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, YourTurnId, TurnRegisterRequestId, Nothing), RelationDeactiveTypes.BothDeactive)
                'درخواست چاپ نوبت
                'Dim InstanceTurnPrintRequest = New R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManager
                'InstanceTurnPrintRequest.NoCostTurnPrintRequest(YourTurnId, YourTurnPrintRedirect)

                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException _
                                OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                                OrElse TypeOf ex Is LoadCapacitorLoadNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function EmergencyTurnRegisterRequest(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourMoneyWalletInventoryControl As Boolean, YourEmergencyTurnRegisterRequestNote As String, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.UserCanRequestEmergencyTurnRegistering, YourUserNSS.UserId, 0) Then Throw New UserCanNotRequestEmergencyTurnRegisteringException
                Dim NSSTrafficCard = InstanceTrafficCards.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                If YourMoneyWalletInventoryControl Then If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException
                'ثبت درخواست صدور نوبت اضطراری
                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim TurnRegisterRequestId = InstanceTurnRegisterRequest.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.Emergency, YourNSSTruck.NSSCar.nIdCar, InstanceTurnRegisterRequest.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.Emergency).TRRTypeTitle & " " & YourEmergencyTurnRegisterRequestNote, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ارسال پیام تایید درخواست صدور نوبت اضطراری
                Dim DataStruct As DataStruct = New DataStruct()
                DataStruct.Data1 = YourNSSTruck.NSSCar.nIdCar
                DataStruct.Data2 = TurnRegisterRequestId
                Dim InstanceComputerMessages = New R2CoreMClassComputerMessagesManager
                InstanceComputerMessages.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, YourNSSTruck.NSSCar.GetCarPelakSerialComposit() + " " + YourEmergencyTurnRegisterRequestNote, R2CoreTransportationAndLoadNotificationComputerMessageTypes.EmergencyTurnRegisterRequestConfirmation, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                OrElse TypeOf ex Is UserCanNotRequestEmergencyTurnRegisteringException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Note YourDataStruct: Data1=nCarId Data2=TurnRegisterRequestId
        Public Sub EmergencyTurnRegister(YourDataStruct As DataStruct, YourTurnPrintRedirect As Boolean, YourRequesterId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim NSSTrafficCard = InstanceTrafficCards.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourDataStruct.Data1))
                'ثبت نوبت
                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim Strategy = New RealTimeTurnRegisteringStrategy(NSSTrafficCard, InstanceTurnRegisterRequest.GetNSSTurnRegisterRequest(YourDataStruct.Data2), YourUserNSS, YourRequesterId, YourTurnType)
                Strategy.DoStrategy()
                Dim TurnId = Strategy.GetNSSTurn.nEnterExitId
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                Dim InstanceEntityRelation = New R2CoreMClassEntityRelationManager
                InstanceEntityRelation.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, TurnId, YourDataStruct.Data2, Nothing), RelationDeactiveTypes.BothDeactive)
                'درخواست چاپ نوبت
                Dim InstanceTurnPrintRequest = New R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManager
                InstanceTurnPrintRequest.NoCostTurnPrintRequest(TurnId, YourTurnPrintRedirect)
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function ReserveTurnRegisterRequest(YourComputerId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                'کنترل مجوز
                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.UserCanRequestReserveTurnRegistering, YourUserNSS.UserId, 0) Then Throw New UserCanNotRequestReserveTurnRegisteringException
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.ComputerCanRequestReserveTurnRegistering, YourComputerId, 0) Then Throw New ComputerCanNotRequestReserveTurnRegisteringException
                'ثبت درخواست صدور نوبت رزرو
                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim TurnRegisterRequestId = InstanceTurnRegisterRequest.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.Reserve, InstanceConfiguration.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 1), InstanceTurnRegisterRequest.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.Reserve).TRRTypeTitle, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ثبت نوبت
                Dim InstanceCarTruckNobat = New PayanehClassLibraryMClassCarTruckNobatManager
                Dim TurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetReserveTurn(TurnRegisterRequestId, YourTurnType, YourUserNSS)
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, TurnId, TurnRegisterRequestId, Nothing), RelationDeactiveTypes.BothDeactive)

                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is UserCanNotRequestReserveTurnRegisteringException _
                                OrElse TypeOf ex Is ComputerCanNotRequestReserveTurnRegisteringException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException

                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function ResuscitationReserveTurn(YourTurnRegisterRequestId As Int64, YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourMoneyWalletInventoryControl As Boolean, YourRequesterId As Int64, YourTurnType As TurnType, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.UserCanResuscitationReserveTurn, YourUserNSS.UserId, 0) Then Throw New UserCanNotResuscitationReserveTurnException

                Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
                Dim NSSTRR = InstanceTurnRegisterRequest.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId)
                If NSSTRR.TRRTypeId <> TurnRegisterRequestTypes.Reserve Then Throw New TurnRegisteringRequestIdIsNotaReserveTypeException
                If DateDiff(DateInterval.Hour, NSSTRR.DateTimeMilladi, _DateTime.GetCurrentDateTimeMilladi) > InstanceTurnRegisterRequest.GetNSSTurnRegisterRequestType(NSSTRR.TRRTypeId).TurnExpirationHours Then Throw New TurnRegisteringRequestDateTimeExpiredException

                Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim NSSTrafficCard = InstanceTrafficCards.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))

                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                If YourMoneyWalletInventoryControl Then If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException

                'ثبت نوبت
                Dim Strategy = New ReserveTurnRegisteringStrategy(NSSTrafficCard, InstanceTurnRegisterRequest.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId), YourUserNSS, YourRequesterId, YourTurnType)
                Strategy.DoStrategy()
                Return Strategy.GetNSSTurn.nEnterExitId
            Catch ex As Exception When TypeOf ex Is RequesterNotAllowTurnIssueBySeqTException _
                                OrElse TypeOf ex Is RequesterNotAllowTurnIssueByLastLoadPermissionedException _
                                OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException _
                                OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                OrElse TypeOf ex Is GetNobatException _
                                OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException _
                                OrElse TypeOf ex Is TurnRegisteringRequestIdIsNotaReserveTypeException _
                                OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                OrElse TypeOf ex Is TurnNotFoundException _
                                OrElse TypeOf ex Is ReserveTurnAlreadyUsedException _
                                OrElse TypeOf ex Is TurnRegisteringRequestDateTimeExpiredException _
                                OrElse TypeOf ex Is UserCanNotResuscitationReserveTurnException _
                                OrElse TypeOf ex Is DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions
        Public Class UserCanNotResuscitationReserveTurnException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربر مجوز احیاء نوبت رزرو را ندارد"
                End Get
            End Property
        End Class

        Public Class UserCanNotRequestEmergencyTurnRegisteringException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربر مجوز درخواست صدور نوبت اضطراری ندارد"
                End Get
            End Property
        End Class


        Public Class UserCanNotRequestReserveTurnRegisteringException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربر مجوز درخواست صدور نوبت رزرو را ندارد"
                End Get
            End Property
        End Class

        Public Class ComputerCanNotRequestReserveTurnRegisteringException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "در این مکان مجوز درخواست صدور نوبت رزرو وجود ندارد"
                End Get
            End Property
        End Class

        Public Class TurnRegisteringRequestIdIsNotaReserveTypeException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره درخواست ، نوعی از درخواست صدور نوبت رزرو نیست"
                End Get
            End Property
        End Class

        Public Class TurnRegisteringRequestDateTimeExpiredException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان اعتبار نوبت رزرو به اتمام رسیده است"
                End Get
            End Property
        End Class


    End Namespace



End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class PayanehClassLibraryConfigurations
        Inherits R2CoreTransportationAndLoadNotificationConfigurations

        Public Shared ReadOnly Property Clock4 As Int64 = 22
        Public Shared ReadOnly Property SalonFingerPrint As Int64 = 26
        Public Shared ReadOnly Property TarrifsPayaneh As Int64 = 31
        Public Shared ReadOnly Property ElamBarMonitoringInterval As Int64 = 33
        Public Shared ReadOnly Property TWS As Int64 = 51
        Public Shared ReadOnly Property TarrifsPayanehKiosk As Int64 = 53
        Public Shared ReadOnly Property PayanehAmirKabirAutomatedJobsSetting As Int64 = 64
        Public Shared ReadOnly Property TruckersAssociationControllingMoneyWallet As Int64 = 75



    End Class

    Public NotInheritable Class PayanehClassLibraryMClassConfigurationManagement
    End Class

    Public NotInheritable Class PayanehClassLibraryMClassConfigurationOfAnnouncementHallsManagement
        'Inherits R2CoreMClassConfigurationManagement

        Public Shared Function GetConfig(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " And AHId=" & YourAHId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64, YourAHId As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " And AHId=" & YourAHId & "", 3600, Ds).GetRecordsCount = 0 Then
                    Throw New GetDataException
                End If
                Return Ds.Tables(0).Rows(0).Item("CValue")
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex).trim
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourAHId As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId).trim
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt32(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Int32
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigBoolean(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt64(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigDouble(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Double
            Try
                Dim xRong As Double = GetConfig(YourCId, YourAHId, YourIndex)
                Return xRong
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigByte(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Byte
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

End Namespace

Namespace DriverTrucksManagement

    Public Class R2StandardDriverTruckStructure

        Private myNSSDriver As R2StandardDriverStructure
        Private myStrSmartCardNo As String



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myNSSDriver = Nothing : myStrSmartCardNo = ""
        End Sub

        Public Sub New(ByVal NSSDriver As R2StandardDriverStructure, ByVal StrSmartCardNo As String)
            myNSSDriver = NSSDriver
            myStrSmartCardNo = StrSmartCardNo
        End Sub
#End Region
#Region "Properting Management"
        Public Property NSSDriver() As R2StandardDriverStructure
            Get
                Return myNSSDriver
            End Get
            Set(ByVal Value As R2StandardDriverStructure)
                myNSSDriver = Value
            End Set
        End Property
        Public Property StrSmartCardNo() As String
            Get
                Return myStrSmartCardNo
            End Get
            Set(ByVal Value As String)
                myStrSmartCardNo = Value
            End Set
        End Property

#End Region


    End Class

    Public Class PayanehClassLibraryMClassDriverTrucksManager
        Public Sub SendTruckDriverChangeRequestMessage(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourTruckDriverNationalCode As String, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourTruckDriverNationalCode)

                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanSendTruckorTruckDriverChangeRequest, YourNSSSoftwareUser.UserId, 0) Then Throw New PermissionException

                If YourTruckDriverNationalCode = String.Empty Then Throw New DataEntryException

                Dim SherkatHazinehChangeDriverTruck As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 7)
                Dim AnjomanHazinehChangeDriverTruck As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 9)

                'کنترل موجودی کیف پول و کسر هزینه
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceMoneyWallet = New R2CoreParkingSystemInstanceMoneyWalletManager
                Dim NSSTerafficCard = InstanceTrafficCards.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                If InstanceMoneyWallet.GetMoneyWalletCharge(NSSTerafficCard) < SherkatHazinehChangeDriverTruck + AnjomanHazinehChangeDriverTruck Then Throw New MoneyWalletCurrentChargeNotEnoughException
                InstanceMoneyWallet.ActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, SherkatHazinehChangeDriverTruck, R2CoreParkingSystemAccountings.SherkatChangeDriverTruck, YourNSSSoftwareUser)
                InstanceMoneyWallet.ActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, AnjomanHazinehChangeDriverTruck, R2CoreParkingSystemAccountings.AnjomanChangeDriverTruck, YourNSSSoftwareUser)

                R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, "ناوگان: " + YourNSSTruck.NSSCar.GetCarPelakSerialComposit + " کد ملی راننده جدید: " + YourTruckDriverNationalCode, PayanehClassLibraryComputerMessageTypes.ChangeDriverTruck, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, New DataStruct()))

            Catch ex As Exception When TypeOf ex Is SqlInjectionException _
                               OrElse TypeOf ex Is PermissionException _
                               OrElse TypeOf ex Is DataEntryException _
                               OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                               OrElse TypeOf ex Is TerraficCardNotFoundException _
                               OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                               OrElse TypeOf ex Is MoneyWalletNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Sub

        Public Function GetNSSDriverTruckbyDriverId(YournIdPerson As String) As R2StandardDriverTruckStructure
            Try
                Dim InstanceDrivers = New R2CoreParkingSystemInstanceDriversManager
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where P.nIdPerson=" & YournIdPerson & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardDriverTruckStructure = New R2StandardDriverTruckStructure
                    NSS.NSSDriver = InstanceDrivers.GetNSSDriver(YournIdPerson)
                    NSS.StrSmartCardNo = Ds.Tables(0).Rows(0).Item("StrSmartCardNo")
                    Return NSS
                Else
                    Throw New DriverTruckInformationNotExistException
                End If
            Catch ex As DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class PayanehClassLibraryMClassDriverTrucksManagement

        Public Shared Function GetNSSTruckDriver(YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure) As R2StandardDriverTruckStructure
            Try
                Return New R2StandardDriverTruckStructure(YourNSSTruckDriver.NSSDriver, YourNSSTruckDriver.StrSmartCardNo)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistDriverTruck(YourNSS As R2StandardDriverTruckStructure) As Boolean
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourNSS.StrSmartCardNo)

                Dim DS As New DataSet
                ''If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select P.StrPersonFullName from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIdPerson=D.nIdDriver Where D.StrSmartCardNo='" & YourNSS.StrSmartCardNo & "' and P.NIdPerson<>" & YourNSS.NSSDriver.nIdPerson & "", 1, DS).GetRecordsCount <> 0 Then
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select P.StrPersonFullName from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIdPerson=D.nIdDriver Where D.StrSmartCardNo='" & YourNSS.StrSmartCardNo & "'", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistDriverTruck(YourMobileNumber As String) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select nIDPerson from dbtransport.dbo.TbPerson Where strAddress='" & YourMobileNumber.Trim & "'", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistDriverTruckByNationalCode(YourNationalCode As String) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select nIDPerson from dbtransport.dbo.TbPerson Where strNationalCode='" & YourNationalCode.Trim & "'", 0, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSDriverTruckbyDriverId(YournIdPerson As String) As R2StandardDriverTruckStructure
            Try

                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where P.nIdPerson=" & YournIdPerson & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardDriverTruckStructure = New R2StandardDriverTruckStructure
                    NSS.NSSDriver = R2CoreParkingSystemMClassDrivers.GetNSSDriver(YournIdPerson)
                    NSS.StrSmartCardNo = Ds.Tables(0).Rows(0).Item("StrSmartCardNo")
                    Return NSS
                Else
                    Throw New DriverTruckInformationNotExistException
                End If
            Catch ex As DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateDriverTruck(YourNSS As R2StandardDriverTruckStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                'If IsExistDriverTruck(YourNSS) = True Then Throw New DriverTruckSmartCardNoAlreadyAvailabletException
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdPerson As Int64 = YourNSS.NSSDriver.nIdPerson
                CmdSql.CommandText = "Update TbDriver Set StrSmartCardNo='" & YourNSS.StrSmartCardNo & "' Where nIdDriver=" & mynIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As DriverTruckSmartCardNoAlreadyAvailabletException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetNSSDriverTruckbySmartCardNo(YournSamrtCardNo As String) As R2StandardDriverTruckStructure
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YournSamrtCardNo)

                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 * from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where D.StrSmartCardNo='" & YournSamrtCardNo & "' Order By P.nIDPerson Desc")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()

                If Da.Fill(Ds) <> 0 Then
                    Dim NSSDriver As R2StandardDriverStructure = New R2StandardDriverStructure
                    NSSDriver.nIdPerson = Ds.Tables(0).Rows(0).Item("nIdPerson")
                    NSSDriver.StrPersonFullName = Ds.Tables(0).Rows(0).Item("StrPersonName").trim + " " + Ds.Tables(0).Rows(0).Item("StrPersonFamily").trim
                    NSSDriver.StrNationalCode = Ds.Tables(0).Rows(0).Item("StrNationalCode")
                    NSSDriver.StrFatherName = Ds.Tables(0).Rows(0).Item("StrFatherName")
                    NSSDriver.StrAddress = Ds.Tables(0).Rows(0).Item("StrAddress")
                    NSSDriver.StrIdNo = Ds.Tables(0).Rows(0).Item("StrIdNo") 'تلفن
                    NSSDriver.strDrivingLicenceNo = Ds.Tables(0).Rows(0).Item("strDrivingLicenceNo")
                    Dim NSSDriverTruck As R2StandardDriverTruckStructure = New R2StandardDriverTruckStructure()
                    NSSDriverTruck.NSSDriver = NSSDriver
                    NSSDriverTruck.StrSmartCardNo = Ds.Tables(0).Rows(0).Item("StrSmartCardNo")
                    Return NSSDriverTruck
                Else
                    Throw New DriverTruckInformationNotExistException
                End If
            Catch ex As DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSDriverTruckbyNationalCode(YourNationalCode As String) As R2StandardDriverTruckStructure
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourNationalCode)

                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 * from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIDPerson=D.nIDDriver Where P.StrNationalCode='" & YourNationalCode & "' Order By P.nIDPerson Desc")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSSDriver As R2StandardDriverStructure = New R2StandardDriverStructure
                    NSSDriver.nIdPerson = Ds.Tables(0).Rows(0).Item("nIdPerson")
                    NSSDriver.StrPersonFullName = Ds.Tables(0).Rows(0).Item("StrPersonName").trim + " " + Ds.Tables(0).Rows(0).Item("StrPersonFamily").trim
                    NSSDriver.StrNationalCode = Ds.Tables(0).Rows(0).Item("StrNationalCode")
                    NSSDriver.StrFatherName = Ds.Tables(0).Rows(0).Item("StrFatherName")
                    NSSDriver.StrAddress = Ds.Tables(0).Rows(0).Item("StrAddress")
                    NSSDriver.StrIdNo = Ds.Tables(0).Rows(0).Item("StrIdNo") 'تلفن
                    NSSDriver.strDrivingLicenceNo = Ds.Tables(0).Rows(0).Item("strDrivingLicenceNo")
                    Dim NSSDriverTruck As R2StandardDriverTruckStructure = New R2StandardDriverTruckStructure()
                    NSSDriverTruck.NSSDriver = NSSDriver
                    NSSDriverTruck.StrSmartCardNo = Ds.Tables(0).Rows(0).Item("StrSmartCardNo")
                    Return NSSDriverTruck
                Else
                    Throw New DriverTruckInformationNotExistException
                End If
            Catch ex As DriverTruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetDriverTruckfromRMTOAndInsertUpdateLocalDataBase(YourSmartCardNo As String) As R2StandardDriverTruckStructure
            Try
                Dim NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSTruckDriver(RmtoWebService.GetNSSTruckDriver(YourSmartCardNo))
                If IsExistDriverTruck(NSS) = True Then
                    Dim nIdPerson As Int64 = GetNSSDriverTruckbySmartCardNo(YourSmartCardNo).NSSDriver.nIdPerson
                    NSS.NSSDriver.nIdPerson = nIdPerson
                    R2CoreParkingSystemMClassDrivers.UpdateDriver(NSS.NSSDriver, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    PayanehClassLibraryMClassDriverTrucksManagement.UpdateDriverTruck(NSS)
                Else
                    Dim nIdPerson As Int64 = R2CoreParkingSystemMClassDrivers.InsertDriver(NSS.NSSDriver, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    NSS.NSSDriver.nIdPerson = nIdPerson
                    PayanehClassLibraryMClassDriverTrucksManagement.UpdateDriverTruck(NSS)
                End If
                Return GetNSSDriverTruckbySmartCardNo(YourSmartCardNo)
            Catch ex As Exception When TypeOf ex Is InternetIsnotAvailableException OrElse
                                       TypeOf ex Is RMTOWebServiceSmartCardInvalidException OrElse
                                       TypeOf ex Is ConnectionIsNotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetDriverTruckfromRMTOAndInsertUpdateLocalDataBaseByNationalCode(YourNationalCode As String) As R2StandardDriverTruckStructure
            Try
                Dim NSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSTruckDriver(RmtoWebService.GetNSSTruckDriver(YourNationalCode))
                If IsExistDriverTruckByNationalCode(NSS.NSSDriver.StrNationalCode) = True Then
                    Dim nIdPerson As Int64 = GetNSSDriverTruckbyNationalCode(NSS.NSSDriver.StrNationalCode).NSSDriver.nIdPerson
                    NSS.NSSDriver.nIdPerson = nIdPerson
                    NSS.NSSDriver.StrIdNo = IIf(GetNSSDriverTruckbyNationalCode(NSS.NSSDriver.StrNationalCode).NSSDriver.StrIdNo = String.Empty, "09130000000", GetNSSDriverTruckbyNationalCode(NSS.NSSDriver.StrNationalCode).NSSDriver.StrIdNo)
                    R2CoreParkingSystemMClassDrivers.UpdateDriver(NSS.NSSDriver, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    PayanehClassLibraryMClassDriverTrucksManagement.UpdateDriverTruck(NSS)
                Else
                    If NSS.NSSDriver.StrIdNo = String.Empty Then NSS.NSSDriver.StrIdNo = "09130000000"
                    Dim nIdPerson As Int64 = R2CoreParkingSystemMClassDrivers.InsertDriver(NSS.NSSDriver, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    NSS.NSSDriver.nIdPerson = nIdPerson
                    PayanehClassLibraryMClassDriverTrucksManagement.UpdateDriverTruck(NSS)
                End If
                Return GetNSSDriverTruckbyNationalCode(YourNationalCode)
            Catch ex As Exception When TypeOf ex Is InternetIsnotAvailableException OrElse
                                       TypeOf ex Is RMTOWebServiceSmartCardInvalidException OrElse
                                       TypeOf ex Is ConnectionIsNotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions

        Public Class DriverTruckSmartCardNoAlreadyAvailabletException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "راننده با شماره هوشمند مورد نظر قبلا ثبت شده است"
                End Get
            End Property
        End Class

        Public Class DriverTruckInformationNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات پایه راننده ثبت نشده است"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace CarTrucksManagement

    Public Class R2StandardCarTruckStructure

        Private myNSSCar As R2StandardCarStructure
        Private myStrBodyNo As String



#Region "Constructing Management"
        Public Sub New()
            MyBase.New()
            myNSSCar = Nothing : myStrBodyNo = ""
        End Sub

        Public Sub New(ByVal NSSCar As R2StandardCarStructure, ByVal StrBodyNo As String)
            myNSSCar = NSSCar
            myStrBodyNo = StrBodyNo
        End Sub
#End Region
#Region "Properting Management"
        Public Property NSSCar() As R2StandardCarStructure
            Get
                Return myNSSCar
            End Get
            Set(ByVal Value As R2StandardCarStructure)
                myNSSCar = Value
            End Set
        End Property
        Public Property StrBodyNo() As String
            Get
                Return myStrBodyNo
            End Get
            Set(ByVal Value As String)
                myStrBodyNo = Value
            End Set
        End Property

#End Region


    End Class

    Public Class PayanehClassLibraryMClassCarTrucksManager
        Public Function IsExistCarTruckWithLicensePlate(YourNSS As R2StandardCarTruckStructure, ByRef TruckId As Int64) As Boolean
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim DS As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2ClassSqlConnectionSepas,
                    "Select Top 1 nIdCar,StrCarNo,StrCarSerialNo from dbtransport.dbo.TbCar Where strCarNo='" & YourNSS.NSSCar.StrCarNo & "' and strCarSerialNo='" & YourNSS.NSSCar.StrCarSerialNo & "'  and ViewFlag=1 Order By nIDCar Desc", 0, DS).GetRecordsCount <> 0 Then
                    TruckId = DS.Tables(0).Rows(0).Item("nIdCar")
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub SendTruckChangeRequestMessage(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNewTruckLicensePlate As String, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourNewTruckLicensePlate)

                Dim InstancePermissions = New R2CoreInstansePermissionsManager
                If Not InstancePermissions.ExistPermission(R2CoreTransportationAndLoadNotificationPermissionTypes.SoftwareUserCanSendTruckorTruckDriverChangeRequest, YourNSSSoftwareUser.UserId, 0) Then Throw New PermissionException

                If YourNewTruckLicensePlate = String.Empty Then Throw New DataEntryException

                Dim SherkatHazinehChangeCarTruckNumberPlate As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 8)
                Dim AnjomanHazinehChangeCarTruckNumberPlate As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 10)

                'کنترل موجودی کیف پول و کسر هزینه
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
                Dim InstanceMoneyWallet = New R2CoreParkingSystemInstanceMoneyWalletManager
                Dim NSSTerafficCard = InstanceTrafficCards.GetNSSTrafficCard(InstanceCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                If InstanceMoneyWallet.GetMoneyWalletCharge(NSSTerafficCard) < SherkatHazinehChangeCarTruckNumberPlate + AnjomanHazinehChangeCarTruckNumberPlate Then Throw New MoneyWalletCurrentChargeNotEnoughException
                InstanceMoneyWallet.ActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, SherkatHazinehChangeCarTruckNumberPlate, R2CoreParkingSystemAccountings.SherkatChangeCarTruckNumberPlate, YourNSSSoftwareUser)
                InstanceMoneyWallet.ActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, AnjomanHazinehChangeCarTruckNumberPlate, R2CoreParkingSystemAccountings.AnjomanChangeCarTruckNumberPlate, YourNSSSoftwareUser)

                R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, "ناوگان: " + YourNSSTruck.NSSCar.GetCarPelakSerialComposit + " ناوگان جدید: " + YourNewTruckLicensePlate, PayanehClassLibraryComputerMessageTypes.ChangeCarTruckNumberPlate, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, New DataStruct()))

            Catch ex As Exception When TypeOf ex Is SqlInjectionException _
                               OrElse TypeOf ex Is PermissionException _
                               OrElse TypeOf ex Is DataEntryException _
                               OrElse TypeOf ex Is RelatedTerraficCardNotFoundException _
                               OrElse TypeOf ex Is TerraficCardNotFoundException _
                               OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                               OrElse TypeOf ex Is MoneyWalletNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSCarTruckByCarId(YournIdCar As String) As R2StandardCarTruckStructure
            Try
                Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbCar Where nIdCar=" & YournIdCar & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardCarTruckStructure = New R2StandardCarTruckStructure
                    NSS.NSSCar = InstanceCars.GetNSSCar(YournIdCar)
                    NSS.StrBodyNo = Ds.Tables(0).Rows(0).Item("StrBodyNo")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSCarTruckBySmartCardNo(YourSmartCardNo As String) As R2StandardCarTruckStructure
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSmartCardNo)

                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
               "Select Top 1 * from dbtransport.dbo.TbCar Where StrBodyNo='" & YourSmartCardNo.Trim() & "' and ViewFlag=1 Order By nIdCar Desc",
                                                          0, Ds).GetRecordsCount() <> 0 Then
                    Dim NSSCarTruck As R2StandardCarTruckStructure = Nothing
                    Dim NSSCar = New R2StandardCarStructure()
                    NSSCarTruck = New R2StandardCarTruckStructure()
                    NSSCar.nIdCar = Ds.Tables(0).Rows(0).Item("nIdCar")
                    NSSCar.StrCarNo = Ds.Tables(0).Rows(0).Item("StrCarNo").trim
                    NSSCar.StrCarSerialNo = Ds.Tables(0).Rows(0).Item("StrCarSerialNo")
                    NSSCar.nIdCity = Ds.Tables(0).Rows(0).Item("nIdCity")
                    NSSCar.snCarType = Ds.Tables(0).Rows(0).Item("snCarType")
                    NSSCarTruck.NSSCar = NSSCar
                    NSSCarTruck.StrBodyNo = Ds.Tables(0).Rows(0).Item("StrBodyNo")
                    Return NSSCarTruck
                Else
                    Throw New TruckInformationNotExistException
                End If
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As TruckInformationNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public Class PayanehClassLibraryMClassCarTrucksManagement

        Public Shared Function GetNSSTruck(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As R2StandardCarTruckStructure
            Try
                Return New R2StandardCarTruckStructure(YourNSSTruck.NSSCar, YourNSSTruck.SmartCardNo)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistCarTruckBySmartCardNo(YourNSS As R2StandardCarTruckStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCarNo,StrCarSerialNo from dbtransport.dbo.TbCar Where StrBodyNo='" & YourNSS.StrBodyNo & "'", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistCarTruckByLP(YourNSS As R2StandardCarTruckStructure) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas,
                        "Select StrCarNo,StrCarSerialNo from dbtransport.dbo.TbCar Where ltrim(rtrim(strCarNo))='" & YourNSS.NSSCar.StrCarNo & "' and ltrim(rtrim(strCarSerialNo))='" & YourNSS.NSSCar.StrCarSerialNo & "' ", 0, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCarTruckByCarId(YournIdCar As String) As R2StandardCarTruckStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select * from dbtransport.dbo.TbCar Where nIdCar=" & YournIdCar & "")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardCarTruckStructure = New R2StandardCarTruckStructure
                    NSS.NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(YournIdCar)
                    NSS.StrBodyNo = Ds.Tables(0).Rows(0).Item("StrBodyNo")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSCarTruckByLP(YourLP As R2StandardLicensePlateStructure) As R2StandardCarTruckStructure
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 nIdCar,StrBodyNo from dbtransport.dbo.TbCar Where ltrim(rtrim(strCarNo))='" & YourLP.Pelak & "' and ltrim(rtrim(strCarSerialNo))='" & YourLP.Serial & "' and Viewflag=1 Order By nIdCar Desc")
                Da.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Dim NSS As R2StandardCarTruckStructure = New R2StandardCarTruckStructure
                    NSS.NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(Ds.Tables(0).Rows(0).Item("nIdCar"))
                    NSS.StrBodyNo = Ds.Tables(0).Rows(0).Item("StrBodyNo")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateCarTruck(YourNSS As R2StandardCarTruckStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                Dim mynIdCar As Int64 = YourNSS.NSSCar.nIdCar
                CmdSql.CommandText = "Update dbtransport.dbo.TbCar Set StrBodyNo='" & YourNSS.StrBodyNo & "' Where nIdCar=" & mynIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetNSSCarTruckBySmartCardNoWithUpdating(YourSmartCardNo As String, YourUserNSS As R2CoreStandardSoftwareUserStructure) As R2StandardCarTruckStructure
            Dim NSSCarTruck As R2StandardCarTruckStructure = Nothing
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSmartCardNo)

                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
               "Select Top 1 * from dbtransport.dbo.TbCar Where StrBodyNo='" & YourSmartCardNo.Trim() & "' and ViewFlag=1 Order By nIdCar Desc",
                                                          0, Ds).GetRecordsCount() <> 0 Then
                    Dim NSSCar = New R2StandardCarStructure()
                    NSSCarTruck = New R2StandardCarTruckStructure()
                    NSSCar.nIdCar = Ds.Tables(0).Rows(0).Item("nIdCar")
                    NSSCar.StrCarNo = Ds.Tables(0).Rows(0).Item("StrCarNo").trim
                    NSSCar.StrCarSerialNo = Ds.Tables(0).Rows(0).Item("StrCarSerialNo")
                    NSSCar.nIdCity = Ds.Tables(0).Rows(0).Item("nIdCity")
                    NSSCar.snCarType = Ds.Tables(0).Rows(0).Item("snCarType")
                    NSSCarTruck.NSSCar = NSSCar
                    NSSCarTruck.StrBodyNo = Ds.Tables(0).Rows(0).Item("StrBodyNo")
                End If
                Dim NSSTruckRmto As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSTruck(RmtoWebService.GetNSSTruck(YourSmartCardNo))
                If Object.Equals(NSSCarTruck, Nothing) Then
                    'NotExist In LocalDataBase
                    If IsExistCarTruckByLP(NSSTruckRmto) = True Then
                        Dim nIdCar As Int64 = GetNSSCarTruckByLP(New R2StandardLicensePlateStructure(NSSTruckRmto.NSSCar.StrCarNo, NSSTruckRmto.NSSCar.StrCarSerialNo, Nothing, Nothing)).NSSCar.nIdCar
                        NSSTruckRmto.NSSCar.nIdCar = nIdCar
                        PayanehClassLibraryMClassCarTrucksManagement.UpdateCarTruck(NSSTruckRmto)
                        Return NSSTruckRmto
                    Else
                        Dim nIdCar As Int64 = R2CoreParkingSystemMClassCars.InsertCar(NSSTruckRmto.NSSCar, YourUserNSS)
                        NSSTruckRmto.NSSCar.nIdCar = nIdCar
                        PayanehClassLibraryMClassCarTrucksManagement.UpdateCarTruck(NSSTruckRmto)
                        Return NSSTruckRmto
                    End If
                Else
                    'Exit In LocalDataBase
                    NSSCarTruck.NSSCar.StrCarNo = NSSTruckRmto.NSSCar.StrCarNo
                    NSSCarTruck.NSSCar.StrCarSerialNo = NSSTruckRmto.NSSCar.StrCarSerialNo
                    R2CoreParkingSystemMClassCars.UpdateCar(NSSCarTruck.NSSCar)
                    Return NSSCarTruck
                End If
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception When TypeOf ex Is InternetIsnotAvailableException OrElse
                                       TypeOf ex Is RMTOWebServiceSmartCardInvalidException OrElse
                                       TypeOf ex Is ConnectionIsNotAvailableException
                If Object.Equals(NSSCarTruck, Nothing) Then
                    Throw ex
                Else
                    Return NSSCarTruck
                End If
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class


    Namespace Exceptions
        Public Class TruckInformationNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات پایه ناوگان ثبت نشده است"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace ProcessesManagement

    Public MustInherit Class PayanehClassLibraryProcesses
        Inherits R2CoreParkingSystemProcesses

        Public Shared ReadOnly FrmcCarAndDriversInformation As Int64 = 11
        Public Shared ReadOnly FrmcSodoorNobat As Int64 = 12
        Public Shared ReadOnly FrmcBoomiExceptTruck As Int64 = 13
        Public Shared ReadOnly FrmcDriverTruckFingerPrintRegister As Int64 = 14
        Public Shared ReadOnly FrmcTruckDriverOneFPSabtFutronic As Int64 = 15
        Public Shared ReadOnly FrmcDriverTruckPresentDermalog As Int64 = 16
        Public Shared ReadOnly FrmcTruckDriverPresentSabtSuprema As Int64 = 17
        Public Shared ReadOnly FrmcEnterExit As Int64 = 18
        Public Shared ReadOnly FrmcTransferPersonelFingerPrintsIntoClock4 As Int64 = 19
        Public Shared ReadOnly FrmcContractorCompanyFinancialReport As Int64 = 21
        Public Shared ReadOnly FrmcTruckersAssociationFinancialReport As Int64 = 23
        Public Shared ReadOnly FrmcAnnouncementHallAutomation As Int64 = 31
        Public Shared ReadOnly FrmcDriverTruckLoadsReport As Int64 = 32
        Public Shared ReadOnly FrmcAnnouncementHallMonitoringControlPanel As Int64 = 33
        Public Shared ReadOnly FrmcTurnsComputerMessageProducer As Int64 = 34
        Public Shared ReadOnly FrmcChangeDriverTruckAndCarTruckNumberPlateComputerMessageProducer As Int64 = 39
        Public Shared ReadOnly FrmcCapacitorLoadsforAnnounceReport As Int64 = 40
        Public Shared ReadOnly FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport As Int64 = 41
        Public Shared ReadOnly FrmcAnnouncementHallsPerformanceReport As Int64 = 42
        Public Shared ReadOnly FrmcAnnouncementHallsPerformanceGeneralStatisticsReport As Int64 = 43
        Public Shared ReadOnly FrmcPublicConfigurations As Int64 = 46
        Public Shared ReadOnly FrmcClientConfigurations As Int64 = 47
        Public Shared ReadOnly FrmcTruckDriversWaitingToGetLoadPermissionReport As Int64 = 52
        Public Shared ReadOnly FrmcTrucksAverageOfSleepDaysToGetLoadPermissionReport As Int64 = 53
        Public Shared ReadOnly FrmcTravelLengthOfLoadTargetsReport As Int64 = 54
        Public Shared ReadOnly FrmcTransportPriceTarrifsReport As Int64 = 55
        Public Shared ReadOnly FrmcIndigenousTrucksWithUNNativeLPReport As Int64 = 56
        Public Shared ReadOnly FrmcSedimentedLoadsReport As Int64 = 58
        Public Shared ReadOnly FrmcLoadPermissionsIssuedOrderByPriorityReport As Int64 = 61
        Public Shared ReadOnly FrmcTruckersAssociationControllingMoneyWallet As Int64 = 65
        Public Shared ReadOnly FrmcClearanceLoadsReport As Int64 = 66
        Public Shared ReadOnly FrmcSaleOfSoftwareUserActivationSMSReport As Int64 = 67
        Public Shared ReadOnly FrmcSoftwareUserManagement As Int64 = 70


    End Class

End Namespace

Namespace DriverTruckPresentManagement

    Public Enum PresentType
        None = 0
        EnterExit = 1
        Salon = 2
    End Enum

    Public Class DriverTruckFPsExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "اثر انگشت راننده باری قبلا ثبت شده است"
            End Get
        End Property
    End Class

    Public Class DriverTruckFingerPrintNeededException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "حداقل یک اثر انگشت از راننده باری باید ثبت شود"
            End Get
        End Property
    End Class

    Public MustInherit Class PayanehClassLibraryMClassDriverTruckSalonPresentManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetCountOfFPSSabted() As UInt64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Count(*) as CCount from R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("CCount")
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub SaveDriverTruckFPs(YourNSSDriverTruck As R2StandardDriverTruckStructure, YourListOfFPs As Generic.List(Of Dermalog.AFIS.FourprintSegmentation.SegmentedFingerprint), YourDriverImage As R2CoreImage, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                If YourDriverImage.GetImage() Is Nothing Then
                    Throw New DriverImageNothingException
                End If

                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select DriverId from R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints where DriverId=" & YourNSSDriverTruck.NSSDriver.nIdPerson & "", 1, DS).GetRecordsCount = 0 Then
                Else
                    Throw New DriverTruckFPsExistException
                End If

                Dim FPTemplate1 As Byte() = Nothing, FPTemplate2 As Byte() = Nothing, FPTemplate3 As Byte() = Nothing, FPTemplate4 As Byte() = Nothing, FPTemplate5 As Byte() = Nothing, FPTemplate6 As Byte() = Nothing, FPTemplate7 As Byte() = Nothing, FPTemplate8 As Byte() = Nothing, FPTemplate9 As Byte() = Nothing, FPTemplate10 As Byte() = Nothing
                Dim FPTemplateFlag1 As Boolean = False, FPTemplateFlag2 As Boolean = False, FPTemplateFlag3 As Boolean = False, FPTemplateFlag4 As Boolean = False, FPTemplateFlag5 As Boolean = False, FPTemplateFlag6 As Boolean = False, FPTemplateFlag7 As Boolean = False, FPTemplateFlag8 As Boolean = False, FPTemplateFlag9 As Boolean = False, FPTemplateFlag10 As Boolean = False
                Dim FPTemplateLocation1 As String, FPTemplateLocation2 As String, FPTemplateLocation3 As String, FPTemplateLocation4 As String, FPTemplateLocation5 As String, FPTemplateLocation6 As String, FPTemplateLocation7 As String, FPTemplateLocation8 As String, FPTemplateLocation9 As String, FPTemplateLocation10 As String
                Dim EnCoderDermalog As Dermalog.AFIS.FingerCode3.Encoder = New Dermalog.AFIS.FingerCode3.Encoder
                EnCoderDermalog.Format = Dermalog.AFIS.FingerCode3.Enums.TemplateFormat.ISO19794_2_2005
                Dim P As SqlClient.SqlParameter
                If YourListOfFPs.Count = 0 Then
                    Throw New DriverTruckFingerPrintNeededException
                ElseIf YourListOfFPs.Count > 0 Then
                    FPTemplate1 = EnCoderDermalog.Encode(YourListOfFPs(0).Image).GetData
                    FPTemplateFlag1 = True
                    FPTemplateLocation1 = YourListOfFPs(0).Hand.ToString + YourListOfFPs(0).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate1", SqlDbType.VarBinary) : P.Value = FPTemplate1
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag1", FPTemplateFlag1)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation1", FPTemplateLocation1)
                Else
                    FPTemplate1 = New Byte() {0}
                    FPTemplateFlag1 = False
                    FPTemplateLocation1 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate1", SqlDbType.VarBinary) : P.Value = FPTemplate1
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag1", FPTemplateFlag1)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation1", FPTemplateLocation1)
                End If
                If YourListOfFPs.Count > 1 Then
                    FPTemplate2 = EnCoderDermalog.Encode(YourListOfFPs(1).Image).GetData
                    FPTemplateFlag2 = True
                    FPTemplateLocation2 = YourListOfFPs(1).Hand.ToString + YourListOfFPs(1).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate2", SqlDbType.VarBinary) : P.Value = FPTemplate2
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag2", FPTemplateFlag2)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation2", FPTemplateLocation2)
                Else
                    FPTemplate2 = New Byte() {0}
                    FPTemplateFlag2 = False
                    FPTemplateLocation2 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate2", SqlDbType.VarBinary) : P.Value = FPTemplate2
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag2", FPTemplateFlag2)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation2", FPTemplateLocation2)
                End If
                If YourListOfFPs.Count > 2 Then
                    FPTemplate3 = EnCoderDermalog.Encode(YourListOfFPs(2).Image).GetData
                    FPTemplateFlag3 = True
                    FPTemplateLocation3 = YourListOfFPs(2).Hand.ToString + YourListOfFPs(2).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate3", SqlDbType.VarBinary) : P.Value = FPTemplate3
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag3", FPTemplateFlag3)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation3", FPTemplateLocation3)
                Else
                    FPTemplate3 = New Byte() {0}
                    FPTemplateFlag3 = False
                    FPTemplateLocation3 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate3", SqlDbType.VarBinary) : P.Value = FPTemplate3
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag3", FPTemplateFlag3)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation3", FPTemplateLocation3)
                End If
                If YourListOfFPs.Count > 3 Then
                    FPTemplate4 = EnCoderDermalog.Encode(YourListOfFPs(3).Image).GetData
                    FPTemplateFlag4 = True
                    FPTemplateLocation4 = YourListOfFPs(3).Hand.ToString + YourListOfFPs(3).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate4", SqlDbType.VarBinary) : P.Value = FPTemplate4
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag4", FPTemplateFlag4)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation4", FPTemplateLocation4)
                Else
                    FPTemplate4 = New Byte() {0}
                    FPTemplateFlag4 = False
                    FPTemplateLocation4 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate4", SqlDbType.VarBinary) : P.Value = FPTemplate4
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag4", FPTemplateFlag4)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation4", FPTemplateLocation4)
                End If
                If YourListOfFPs.Count > 4 Then
                    FPTemplate5 = EnCoderDermalog.Encode(YourListOfFPs(4).Image).GetData
                    FPTemplateFlag5 = True
                    FPTemplateLocation5 = YourListOfFPs(4).Hand.ToString + YourListOfFPs(4).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate5", SqlDbType.VarBinary) : P.Value = FPTemplate5
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag5", FPTemplateFlag5)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation5", FPTemplateLocation5)
                Else
                    FPTemplate5 = New Byte() {0}
                    FPTemplateFlag5 = False
                    FPTemplateLocation5 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate5", SqlDbType.VarBinary) : P.Value = FPTemplate5
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag5", FPTemplateFlag5)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation5", FPTemplateLocation5)
                End If
                If YourListOfFPs.Count > 5 Then
                    FPTemplate6 = EnCoderDermalog.Encode(YourListOfFPs(5).Image).GetData
                    FPTemplateFlag6 = True
                    FPTemplateLocation6 = YourListOfFPs(5).Hand.ToString + YourListOfFPs(5).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate6", SqlDbType.VarBinary) : P.Value = FPTemplate6
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag6", FPTemplateFlag6)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation6", FPTemplateLocation6)
                Else
                    FPTemplate6 = New Byte() {0}
                    FPTemplateFlag6 = False
                    FPTemplateLocation6 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate6", SqlDbType.VarBinary) : P.Value = FPTemplate6
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag6", FPTemplateFlag6)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation6", FPTemplateLocation6)
                End If
                If YourListOfFPs.Count > 6 Then
                    FPTemplate7 = EnCoderDermalog.Encode(YourListOfFPs(6).Image).GetData
                    FPTemplateFlag7 = True
                    FPTemplateLocation7 = YourListOfFPs(6).Hand.ToString + YourListOfFPs(6).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate7", SqlDbType.VarBinary) : P.Value = FPTemplate7
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag7", FPTemplateFlag7)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation7", FPTemplateLocation7)
                Else
                    FPTemplate7 = New Byte() {0}
                    FPTemplateFlag7 = False
                    FPTemplateLocation7 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate7", SqlDbType.VarBinary) : P.Value = FPTemplate7
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag7", FPTemplateFlag7)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation7", FPTemplateLocation7)
                End If
                If YourListOfFPs.Count > 7 Then
                    FPTemplate8 = EnCoderDermalog.Encode(YourListOfFPs(7).Image).GetData
                    FPTemplateFlag8 = True
                    FPTemplateLocation8 = YourListOfFPs(7).Hand.ToString + YourListOfFPs(7).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate8", SqlDbType.VarBinary) : P.Value = FPTemplate8
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag8", FPTemplateFlag8)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation8", FPTemplateLocation8)
                Else
                    FPTemplate8 = New Byte() {0}
                    FPTemplateFlag8 = False
                    FPTemplateLocation8 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate8", SqlDbType.VarBinary) : P.Value = FPTemplate8
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag8", FPTemplateFlag8)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation8", FPTemplateLocation8)
                End If
                If YourListOfFPs.Count > 8 Then
                    FPTemplate9 = EnCoderDermalog.Encode(YourListOfFPs(8).Image).GetData
                    FPTemplateFlag9 = True
                    FPTemplateLocation9 = YourListOfFPs(8).Hand.ToString + YourListOfFPs(8).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate9", SqlDbType.VarBinary) : P.Value = FPTemplate9
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag9", FPTemplateFlag9)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation9", FPTemplateLocation9)
                Else
                    FPTemplate9 = New Byte() {0}
                    FPTemplateFlag9 = False
                    FPTemplateLocation9 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate9", SqlDbType.VarBinary) : P.Value = FPTemplate9
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag9", FPTemplateFlag9)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation9", FPTemplateLocation9)
                End If
                If YourListOfFPs.Count > 9 Then
                    FPTemplate10 = EnCoderDermalog.Encode(YourListOfFPs(9).Image).GetData
                    FPTemplateFlag10 = True
                    FPTemplateLocation10 = YourListOfFPs(9).Hand.ToString + YourListOfFPs(9).Position.ToString
                    P = New SqlClient.SqlParameter("@FPTemplate10", SqlDbType.VarBinary) : P.Value = FPTemplate10
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag10", FPTemplateFlag10)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation10", FPTemplateLocation10)
                Else
                    FPTemplate10 = New Byte() {0}
                    FPTemplateFlag10 = False
                    FPTemplateLocation10 = Dermalog.AFIS.FourprintSegmentation.HandPositions.Unknown
                    P = New SqlClient.SqlParameter("@FPTemplate10", SqlDbType.VarBinary) : P.Value = FPTemplate10
                    CmdSql.Parameters.Add(P)
                    CmdSql.Parameters.AddWithValue("@FPTemplateFlag10", FPTemplateFlag10)
                    CmdSql.Parameters.AddWithValue("@FPTemplateLocation10", FPTemplateLocation10)
                End If

                CmdSql.Parameters.AddWithValue("@DriverId", YourNSSDriverTruck.NSSDriver.nIdPerson)
                Dim R2DateAndTime As New R2DateTime
                CmdSql.Parameters.AddWithValue("@DateTimeMilladi", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
                CmdSql.Parameters.AddWithValue("@DateShamsi", R2DateAndTime.GetCurrentDateShamsiFull)
                CmdSql.Parameters.AddWithValue("@UserId", YourUserNSS.UserId)
                CmdSql.Parameters.AddWithValue("@NameFamily", YourNSSDriverTruck.NSSDriver.StrPersonFullName)
                CmdSql.Parameters.AddWithValue("@SmartCardNo", YourNSSDriverTruck.StrSmartCardNo)
                CmdSql.Parameters.AddWithValue("@LicenseNo", YourNSSDriverTruck.NSSDriver.strDrivingLicenceNo)
                CmdSql.Parameters.AddWithValue("@NationalCode", YourNSSDriverTruck.NSSDriver.StrNationalCode)
                CmdSql.Parameters.AddWithValue("@FPActive", True)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Values(@DriverId,@FPTemplate1,@FPTemplateFlag1,@FPTemplateLocation1,@FPTemplate2,@FPTemplateFlag2,@FPTemplateLocation2,@FPTemplate3,@FPTemplateFlag3,@FPTemplateLocation3,@FPTemplate4,@FPTemplateFlag4,@FPTemplateLocation4,@FPTemplate5,@FPTemplateFlag5,@FPTemplateLocation5,@FPTemplate6,@FPTemplateFlag6,@FPTemplateLocation6,@FPTemplate7,@FPTemplateFlag7,@FPTemplateLocation7,@FPTemplate8,@FPTemplateFlag8,@FPTemplateLocation8,@FPTemplate9,@FPTemplateFlag9,@FPTemplateLocation9,@FPTemplate10,@FPTemplateFlag10,@FPTemplateLocation10,@DateTimeMilladi,@DateShamsi,@UserId,@NameFamily,@SmartCardNo,@LicenseNo,@NationalCode,@FPActive)"
                CmdSql.ExecuteNonQuery()
                R2CoreParkingSystemMClassDrivers.SaveDriverImage(YourNSSDriverTruck.NSSDriver, YourDriverImage, YourUserNSS)
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch exx As DriverImageNothingException
                Throw exx
            Catch exxx As DriverTruckFPsExistException
                Throw exxx
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeleteDriverTruckFPs(YourNSSDriverTruck As R2StandardDriverTruckStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Delete R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints where DriverId=" & YourNSSDriverTruck.NSSDriver.nIdPerson & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Sub

        Public Shared Function GetSalonStartDateForPresentControlDifrenceToNobatDate(YournEnterExitId As Int64) As Int64
            Try
                Dim SalonStartDateForPresentControl As Date = _DateTime.GetMilladiDateTimeFromDateShamsiFull(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 1), "00:00:00")
                Return R2CoreMClassPublicProcedures.GetDateDiff(DateInterval.Day, SalonStartDateForPresentControl, PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateMilladi(YournEnterExitId))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetPresentSabted(YournEnterExitId As Int64) As Int64
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Count(*) as M from (Select Distinct DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YournEnterExitId & ") AND (DateShamsi<>'" & PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateShamsi(YournEnterExitId) & "')) as Counting")
                Da.SelectCommand.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) <> 0 Then
                    Return Ds.Tables(0).Rows(0).Item("M")
                Else
                    Return 0
                End If

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function Is30MinutePresentSabted(ByVal YournEnterExitId As UInt64) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Top 1 DateTimeMilladi From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YournEnterExitId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "') Order By DateTimeMilladi Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Return False
                Else
                    If DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), _DateTime.GetCurrentDateTimeMilladi) <= R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.SalonFingerPrint, 5) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ExistIndigenousTrucksWithUNNativeLP(ByVal YourPelak As String, ByVal YourSerial As String) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP Where (Pelak='" & YourPelak & "') and (Serial='" & YourSerial & "') and (EnghezaDate='' or EnghezaDate>='" & _DateTime.GetCurrentDateShamsiFull() & "')")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsDriverTruckPresentsContinuous(ByVal YournEnterExitId As UInt64) As Boolean
            Try
                If GetPresentSabted(YournEnterExitId) >= PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDifrenceDayToToday(YournEnterExitId) - R2CoreDateAndTimePersianCalendarManagement.GetHoliDayNumber(PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateShamsi(YournEnterExitId), _DateTime.GetCurrentDateShamsiFull) - 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsDriverTruckPresentOkForSodoorMojavez(ByVal YournEnterExitId As UInt64, ByVal YourLP As R2StandardLicensePlateStructure) As Boolean
            Try
                'کلیه بومی ها وغیر بومی ها باید حاضری داشته باشند
                If GetPresentSabted(YournEnterExitId) = 0 Then
                    If PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDifrenceDayToToday(YournEnterExitId) = 0 Then
                        Return True
                    Else
                        Throw New IsDriverTruckPresentOkException("نوبت مورد نظر حاضری ندارد")
                    End If
                End If

                'باید همه بومی ها و غیر بومی ها در محدوده نزدیک به صدور مجوز حاضری داشته باشند 
                If Is30MinutePresentSabted(YournEnterExitId) = True Then
                    If YourLP.Serial.Trim <> "13" And YourLP.Serial.Trim <> "23" And YourLP.Serial.Trim <> "43" Then
                        If ExistIndigenousTrucksWithUNNativeLP(YourLP.Pelak, YourLP.Serial) = True Then
                            Return True
                        End If
                        'تاريخ راه اندازي سیستم تایید هویت بعد از صدور نوبت یا همان روز صدور نوبت است
                        If GetSalonStartDateForPresentControlDifrenceToNobatDate(YournEnterExitId) >= 0 Then
                            Return True
                        Else
                            If GetPresentSabted(YournEnterExitId) >= PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDifrenceDayToToday(YournEnterExitId) - R2CoreDateAndTimePersianCalendarManagement.GetHoliDayNumber(PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateShamsi(YournEnterExitId), _DateTime.GetCurrentDateShamsiFull) Then
                                Return True
                            Else
                                Throw New IsDriverTruckPresentOkException("حاضري برای نوبت به تعداد کافی وجود ندارد")
                            End If
                        End If
                    Else
                        Return True
                    End If
                Else
                    Throw New IsDriverTruckPresentOkException("حاضري امروز راننده در محدوده زماني نزديك به صدور مجوز بار نيست")
                End If
            Catch exx As IsDriverTruckPresentOkException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetBedehyJamForDriverTruckSalonPresentSystem(ByVal YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Int64
            Try
                ''''Dim BedehyJam As Int64 = 0
                ''''Dim RangePayehTavaghof As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 2) * 60
                ''''Dim MblghPayehSalon As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 0) + R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1)
                '''''فعلا کل بدهی صفر فرض می شود
                ''''BedehyJam = 0
                '''''بررسی اینکه ناوگان در پایانه حضور داشته باشد
                ''''If R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(YourNSSTerafficCard, Nothing) = R2EnterExitRequestType.ExitRequest Then
                ''''    'ناوگان در پایانه حضور دارد
                ''''    BedehyJam = BedehyJam + 0
                ''''Else
                ''''    Dim EETavaghof As Int64 = RangePayehTavaghof + 1
                ''''    Try
                ''''        'اگر رکورد ورود وجود داشته باشد دقیقا توقف بدست می آید
                ''''        EETavaghof = R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitTavaghof(DateInterval.Minute, YourNSSTerafficCard)
                ''''    Catch ex As GetDataException
                ''''        'ناوگان رکوردی مبنی بر ورود برای محاسبه توقف ندارد
                ''''    End Try
                ''''    If EETavaghof > RangePayehTavaghof Then
                ''''        'تردد در محدوده 72 ساعت نیست و بیشتر است و بنابراین باید کیف پول مبلغ 7000 موجودی داشته باشد
                ''''        'کنترل این که هزینه سالن در 72 ساعت دو مرتبه کم نشود
                ''''        Dim DsControl As New DataSet
                ''''        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select top 1 DateMilladiA from R2Primary.dbo.TblAccounting where CardId=" & YourNSSTerafficCard.CardId & " and EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SherkatHazinehSodoorMojavezUpTo72Saat & "  order by DateMilladiA desc", 1, DsControl).GetRecordsCount <> 0 Then
                ''''            Dim SherkatHazinehSodoorMojavezUpTo72SaatDateDiff As Long = DateDiff(DateInterval.Minute, DsControl.Tables(0).Rows(0).Item("DateMilladiA"), _DateTime.GetCurrentDateTimeMilladi)
                ''''            If SherkatHazinehSodoorMojavezUpTo72SaatDateDiff < RangePayehTavaghof Then
                ''''                'از پرداخت 7000 هنوز 72 ساعت نگذشته است
                ''''                BedehyJam = BedehyJam + 0
                ''''            ElseIf SherkatHazinehSodoorMojavezUpTo72SaatDateDiff >= RangePayehTavaghof Then
                ''''                'از پرداخت 7000 72 ساعت گذشته است
                ''''                BedehyJam = BedehyJam + MblghPayehSalon
                ''''            End If
                ''''        Else
                ''''            'کلا 7000 را پرداخت نکرده است
                ''''            BedehyJam = BedehyJam + MblghPayehSalon
                ''''        End If
                ''''    Else
                ''''        'تردد در محدوده 72 ساعت است
                ''''        BedehyJam = BedehyJam + 0
                ''''    End If
                ''''End If
                '''''محاسبه مبلغ کسری موجودی
                ''''BedehyJam = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(YourNSSTerafficCard) - BedehyJam
                ''''Return BedehyJam
                Return 0
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Class IsDriverTruckPresentOkException
            Inherits ApplicationException

            Private _Message As String = String.Empty

            Public Sub New(YourMessage As String)
                _Message = YourMessage
            End Sub

            Public Overrides ReadOnly Property Message As String
                Get
                    Return _Message
                End Get
            End Property
        End Class

        Public Shared Function HaveDriversFingerPrintSabted(ByVal YourNSSCar As R2StandardCarStructure) As Boolean
            Try
                Dim DriverCount As UInt16 = R2CoreParkingSystemMClassDrivers.GetCountOfDriversAttachedCar(YourNSSCar)
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand()
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                If DriverCount = 0 Then
                    Return False
                End If
                If DriverCount = 1 Or DriverCount = 2 Then
                    Dim FirstnIdPerson As Int64 = R2CoreParkingSystemMClassCars.GetnIdPersonFirst(YourNSSCar.nIdCar)
                    Da.SelectCommand.CommandText = "Select DriverId From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Where (DriverId=" & FirstnIdPerson & ")"
                    Ds.Tables.Clear()
                    If Da.Fill(Ds) = 0 Then Return False
                End If
                If DriverCount = 2 Then
                    Dim SecondnIdPerson As Int64 = R2CoreParkingSystemMClassCars.GetnIdPersonSecond(YourNSSCar.nIdCar)
                    Da.SelectCommand.CommandText = "Select DriverId From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Where (DriverId=" & SecondnIdPerson & ")"
                    Ds.Tables.Clear()
                    If Da.Fill(Ds) = 0 Then Return False
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function HaveFirstDriverFingerPrintSabted(ByVal YourNSSCar As R2StandardCarStructure) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand()
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Dim FirstnIdPerson As Int64 = R2CoreParkingSystemMClassCars.GetnIdPersonFirst(YourNSSCar.nIdCar)
                Da.SelectCommand.CommandText = "Select DriverId From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Where (DriverId=" & FirstnIdPerson & ")"
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Return False
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function HaveSecondDriverFingerPrintSabted(ByVal YourNSSCar As R2StandardCarStructure) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand()
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Dim SecondnIdPerson As Int64 = R2CoreParkingSystemMClassCars.GetnIdPersonSecond(YourNSSCar.nIdCar)
                Da.SelectCommand.CommandText = "Select DriverId From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Where (DriverId=" & SecondnIdPerson & ")"
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Return False
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsDriverTruckFingerPrintActive(YourNSSDriverTruck As R2StandardDriverTruckStructure) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 FPActive from R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints Where DriverId=" & YourNSSDriverTruck.NSSDriver.nIdPerson & "", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New Exception("راننده " + YourNSSDriverTruck.NSSDriver.StrPersonFullName + " یافت نشد")
                Else
                    Return Ds.Tables(0).Rows(0).Item("FPActive")
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetPresentNeeded(ByVal YournEnterExitId As Int64) As UInt16
            Try
                Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YournEnterExitId).NSSCar.nIdCar)
                'بومي ها فقط يك حاضري نياز دارند
                If NSSCarTruck.NSSCar.StrCarSerialNo = "13" Or NSSCarTruck.NSSCar.StrCarSerialNo = "23" Or NSSCarTruck.NSSCar.StrCarSerialNo = "43" Then
                    Return 1
                Else
                    'غير بومي ها به تعداد اختلاف تاريخ صدور مجوز با تاريخ صدور نوبت
                    'غير بومي هايي كه در جدول استثنا قرار دارند هم بومي محسوب مي شوند و يك حاضري نياز دارند
                    'در صورتي كه تاريخ صدور نوبت قبل از راه اندازي سيستم كنترل اثر انگشت باشد فرمول به شكل زير است
                    If ExistIndigenousTrucksWithUNNativeLP(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo) = True Then
                        Return 1
                    Else
                        'وقتی همان روز صدور نوبت بار نيز دريافت می شود
                        If PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDifrenceDayToToday(YournEnterExitId) = 0 Then
                            Return 1
                        End If
                        'تاريخ راه اندازي بعد از صدور نوبت یا همان روز صدور نوبت است
                        If GetSalonStartDateForPresentControlDifrenceToNobatDate(YournEnterExitId) >= 0 Then
                            Return 1
                        Else
                            'تاريخ راه اندازي قبل از صدور نوبت است
                            Return PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDifrenceDayToToday(YournEnterExitId) - R2CoreDateAndTimePersianCalendarManagement.GetHoliDayNumber(PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateShamsi(YournEnterExitId), _DateTime.GetCurrentDateShamsiFull)
                        End If
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsThisDayTruckDriverPresentSabted(ByVal YournEnterExitId As UInt64) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YournEnterExitId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "')")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function




    End Class

    Public MustInherit Class PayanehClassLibraryMClassDriverTruckEnterExitPresentManagement


        Public Enum OneFingerType
            None = 0
            First = 1
            Second = 2
        End Enum

        'Public Sub OneFPTemplateSabt(ByVal YourDriverId As Integer, ByVal YourTemplate1 As Byte(), ByVal YourTemplate2 As Byte(), ByRef YourDriverPicture As Drawing.Bitmap)
        '    Dim CmdSql As New SqlClient.SqlCommand
        '    CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
        '    Try
        '        CmdSql.Parameters.AddWithValue("@DriverId", YourDriverId)
        '        CmdSql.Parameters.AddWithValue("@DriverNameFamily", SepasDriverName + ";" + SepasDriverFamily)
        '        CmdSql.Parameters.AddWithValue("@UserId", R2Core.UserManagement.R2CoreMClassSoftwareUsersManagement.CurrentUserNSS.UserId)
        '        CmdSql.Parameters.AddWithValue("@CarId", SepasCarId)
        '        CmdSql.Parameters.AddWithValue("@CardNo", RFIDCardNo)
        '        CmdSql.Parameters.AddWithValue("@PelakSerial", CarLP.GetLPString)
        '        CmdSql.Parameters.AddWithValue("@DateTimeMilladi", _DateTime.GetCurrentDateTimeMilladiFormated)
        '        CmdSql.Parameters.AddWithValue("@DateShamsi", _DateTime.GetCurrentDateShamsiFull)
        '        Dim P As SqlClient.SqlParameter
        '        P = New SqlClient.SqlParameter("@OneFPTemplate1", SqlDbType.VarBinary) : P.Value = YourTemplate1
        '        CmdSql.Parameters.Add(P)
        '        P = New SqlClient.SqlParameter("@OneFPTemplate2", SqlDbType.VarBinary) : P.Value = YourTemplate2
        '        CmdSql.Parameters.Add(P)
        '        CmdSql.Parameters.AddWithValue("@OneFPActive", True)
        '        CmdSql.Connection.Open()
        '        CmdSql.CommandText = "Insert Into TblFingerPrintsOneFP Values(@DriverId,@DriverNameFamily,@UserId,@CarId,@CardNo,@PelakSerial,@DateTimeMilladi,@DateShamsi,@OneFPTemplate1,@OneFPTemplate2,@OneFPActive)"
        '        CmdSql.ExecuteNonQuery()
        '        CmdSql.Connection.Close()
        '        'تصویر راننده و تصویر اثر انگشت 
        '        If YourDriverPicture IsNot Nothing Then YourDriverPicture.Save(("\\172.20.30.18\OneFPTruckDriversPicture\" + SepasCarId.ToString() + _DateTime.GetCurrentDateShamsiFull() + _DateTime.GetCurrentTime() + "_.jpeg").Replace("/", "").Replace(":", ""), Drawing.Imaging.ImageFormat.Jpeg)
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

        Public Sub OneFPTemplateUpdate(ByVal YourDriverId As Integer, ByVal YourTemplate As Byte(), ByVal YourOneFingerType As OneFingerType)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.Parameters.AddWithValue("@DriverId", YourDriverId)
                Dim P As SqlClient.SqlParameter
                If YourOneFingerType = OneFingerType.First Then
                    P = New SqlClient.SqlParameter("@OneFPTemplate1", SqlDbType.VarBinary) : P.Value = YourTemplate
                    CmdSql.Parameters.Add(P)
                    CmdSql.CommandText = "Update TblFingerPrintsOneFP Set OneFPTemplate1=@OneFPTemplate1 Where DriverId=@DriverId"
                    CmdSql.ExecuteNonQuery()
                Else
                    P = New SqlClient.SqlParameter("@OneFPTemplate2", SqlDbType.VarBinary) : P.Value = YourTemplate
                    CmdSql.Parameters.Add(P)
                    CmdSql.CommandText = "Update TblFingerPrintsOneFP Set OneFPTemplate2=@OneFPTemplate2 Where DriverId=@DriverId"
                    CmdSql.ExecuteNonQuery()
                End If
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function ExistOneFPTemplate(ByVal YourDriverId As Integer) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select DriverId From TblFingerPrintsOneFP Where DriverId=" & YourDriverId & "")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                Ds.Tables.Clear()
                Da.Fill(Ds)
                If Ds.Tables(0).Rows.Count = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsActiveOneFPTemplate(ByVal YourDriverId As Integer) As Boolean
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("Select OneFPActive From TblFingerPrintsOneFP Where DriverId=" & YourDriverId & "")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                Ds.Tables.Clear()
                Da.Fill(Ds)
                If Ds.Tables(0).Rows.Count = 0 Then
                    Return False
                Else
                    If Ds.Tables(0).Rows(0).Item("OneFPActive") = True Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function



    End Class

End Namespace

Namespace KioskManagement

    Public Structure Company
        Public CompanyCode As Int32
        Public CompanyName As String
        Public CompanyCityCode As Int32
    End Structure

    Public Structure Bar
        Public EstelamId As Int64
        Public CityCode As String
        Public CityName As String
        Public Tonaj As Decimal
        Public BarCode As Int64
        Public BarName As String
        Public CompanyCode As Int64
        Public CompanyName As String
        Public CarNum As Int16
        Public DateElam As String
        Public TimeElam As String
        Public CarNumKol As Int16
        Public BarSource As Int64
        Public PriceSug As String
        Public Description As String
        Public DateExit As String
        Public TimeExit As String
    End Structure

    Public Enum KioskLogType
        None = 0
        SodoorMojavez = 1
        EditMojavez = 2
        DeleteMojavez = 3
        PrintMojavez = 4
        CancelMojavez = 5
    End Enum

    Public Enum KioskLogStatus
        None = 0
        SodoorMojavezCreateNewPelakSerial = 1
    End Enum

    Public MustInherit Class PayanehClassLibraryMClassKioskManagement

        Private _DateTime As New R2DateTime
        Private _MblghSodoorLoadingLicenseKioskAnjoman As Int64 = 10000
        Private _MblghSodoorLoadingLicenseKioskSherkat As Int64 = 60000
        'Public Sub SodoorLoadingLicense(ByVal YourCompany As Company, ByVal YourBar As Bar, ByVal YourUserId As Int64)
        '    Dim CmdSqlSepas As New SqlClient.SqlCommand
        '    CmdSqlSepas.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
        '    Dim CmdSqlR2 As New SqlClient.SqlCommand
        '    CmdSqlR2.Connection = (New R2PrimarySqlConnection).GetConnection()
        '    Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(RFIDCardNo)
        '    Dim NSSCar As R2StandardCarStructure = R2CoreParkingSystemMClassCars.GetNSSCar(SepasCarId)
        '    Try
        '        'ثبت تغییرات صدور مجوز در سپاس
        '        If YourBar.CarNum = 1 Then
        '            'بار با کم شدن یک بار کلا تمام می شود
        '            CmdSqlSepas.CommandText = "Update tbelam set bflag=1,ncarnum=ncarnum-1,bflagcarnum=1,dDateExit='" & _DateTime.GetCurrentDateShamsiFull & "',dTimeExit='" & _DateTime.GetCurrentTime & "' where nestelamid=" & YourBar.EstelamId & ""
        '        Else
        '            'بار باز هم مانده دارد و تمام نمی شود
        '            CmdSqlSepas.CommandText = "Update tbelam set bflag=0,ncarnum=ncarnum-1,bflagcarnum=1,dDateExit='" & _DateTime.GetCurrentDateShamsiFull & "',dTimeExit='" & _DateTime.GetCurrentTime & "' where nestelamid=" & YourBar.EstelamId & ""
        '        End If
        '        CmdSqlSepas.Connection.Open()
        '        CmdSqlSepas.ExecuteNonQuery()
        '        CmdSqlSepas.Connection.Close()
        '        'ثبت اکانتینگ و سابقه شارژ در اتوماسیون
        '        Dim myCurrentCharge As Int64 = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard)
        '        Dim myTash As Int64 = myCurrentCharge + _MblghSodoorLoadingLicenseKioskAnjoman + _MblghSodoorLoadingLicenseKioskSherkat
        '        R2CoreParkingSystemMClassMoneyWalletChargeManagement.SabtCharge(New R2StandardMoneyWalletChargeStructure(NSSTrafficCard, _MblghSodoorLoadingLicenseKioskAnjoman + _MblghSodoorLoadingLicenseKioskSherkat, YourUserId, "", _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, myTash, 0, _DateTime.GetCurrentTime))
        '        R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemMClassAccountingManagement.InsertAccounting(New R2CoreParkingSystem.AccountingManagement.R2StandardEnterExitAccountingStructure(NSSTrafficCard, R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemAccountings.ChargeType, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, _DateTime.GetCurrentDateTimeMilladiFormated, NSSCar, R2CoreMClassConfigurationManagement.GetComputerCode, _MblghSodoorLoadingLicenseKioskAnjoman + _MblghSodoorLoadingLicenseKioskSherkat, YourUserId, myCurrentCharge, myTash))
        '        'اکانت 1000 انجمن
        '        myCurrentCharge = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard)
        '        myTash = myCurrentCharge - _MblghSodoorLoadingLicenseKioskAnjoman
        '        CmdSqlR2.Connection.Open()
        '        CmdSqlR2.CommandText = "update tblrfidcards set charge=charge-" & _MblghSodoorLoadingLicenseKioskAnjoman & " where cardid=" & NSSTrafficCard.CardId & ""
        '        CmdSqlR2.ExecuteNonQuery()
        '        CmdSqlR2.Connection.Close()
        '        R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemMClassAccountingManagement.InsertAccounting(New R2CoreParkingSystem.AccountingManagement.R2StandardEnterExitAccountingStructure(NSSTrafficCard, R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, _DateTime.GetCurrentDateTimeMilladiFormated, NSSCar, R2CoreMClassConfigurationManagement.GetComputerCode, _MblghSodoorLoadingLicenseKioskAnjoman, YourUserId, myCurrentCharge, myTash))
        '        'اکانت 6000 شرکت
        '        myCurrentCharge = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTrafficCard)
        '        myTash = myCurrentCharge - _MblghSodoorLoadingLicenseKioskSherkat
        '        CmdSqlR2.Connection.Open()
        '        CmdSqlR2.CommandText = "update tblrfidcards set charge=charge-" & _MblghSodoorLoadingLicenseKioskSherkat & " where cardid=" & NSSTrafficCard.CardId & ""
        '        CmdSqlR2.ExecuteNonQuery()
        '        CmdSqlR2.Connection.Close()
        '        R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemMClassAccountingManagement.InsertAccounting(New R2CoreParkingSystem.AccountingManagement.R2StandardEnterExitAccountingStructure(NSSTrafficCard, R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemAccountings.SherkatHazinehSodoorMojavezKiosk, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, _DateTime.GetCurrentDateTimeMilladiFormated, NSSCar, R2CoreMClassConfigurationManagement.GetComputerCode, _MblghSodoorLoadingLicenseKioskSherkat, YourUserId, myCurrentCharge, myTash))
        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

    End Class



End Namespace

Namespace ReportsManagement

    Public MustInherit Class PayanehReports
        Inherits R2Core.ReportsManagement.R2CoreReports

        Public Shared ReadOnly TruckersAssociationFinancialReport As Int64 = 2
        Public Shared ReadOnly ContractorCompanyFinancialReport As Int64 = 3
        Public Shared ReadOnly DriverTruckLoadsReport As Int64 = 4
        Public Shared ReadOnly CapacitorLoadsforAnnounceReport As Int64 = 6
        Public Shared ReadOnly CapacitorLoadsTransportCompaniesRegisteredLoadsReport As Int64 = 7
        Public Shared ReadOnly OtaghdarAnnouncementHallPerformanceReport As Int64 = 8
        Public Shared ReadOnly ZobiAnnouncementHallPerformanceReport As Int64 = 9
        Public Shared ReadOnly AnbariAnnouncementHallPerformanceReport As Int64 = 10
        Public Shared ReadOnly ShahriAnnouncementHallPerformanceReport As Int64 = 11
        Public Shared ReadOnly AnnouncementHallPerformanceGeneralStatisticsReport As Int64 = 12
        Public Shared ReadOnly TruckDriversWaitingToGetLoadPermissionReport As Int64 = 17
        Public Shared ReadOnly TrucksAverageOfSleepDaysToGetLoadPermissionReport As Int64 = 18
        Public Shared ReadOnly TravelLengthOfLoadTargetsReport As Int64 = 19
        Public Shared ReadOnly TransportPriceTarrifsReport As Int64 = 20
        Public Shared ReadOnly IndigenousTrucksWithUNNativeLPReport As Int64 = 21
        Public Shared ReadOnly SedimentedLoadsByTransportCompnayTargetCityReport As Int64 = 24
        Public Shared ReadOnly SedimentedLoadsByTargetCityReport As Int64 = 25
        Public Shared ReadOnly LoadPermissionsIssuedOrderByPriorityReport As Int64 = 28
        Public Shared ReadOnly ClearanceLoadsReport As Int64 = 31
        Public Shared ReadOnly AnnouncedLoadsReport As Int64 = 32
        Public Shared ReadOnly SaleOfSoftwareUserActivationSMSReport As Int64 = 33
    End Class

    Public Class PayanehClassLibraryMClassReportsManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Sub ReportingInformationProviderContractorCompanyFinancialReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourVatStatus As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime
                Dim myMahName As String = _DateTime.GetPersianMonthName(YourDateTime2.DateShamsiFull)
                Dim myDateShamsi1 As String = YourDateTime1.DateShamsiFull
                Dim myDateShamsi2 As String = YourDateTime2.DateShamsiFull
                Dim myConcat1 As String = myDateShamsi1.Replace("/", "") + YourDateTime1.Time.Replace(":", "")
                Dim myConcat2 As String = myDateShamsi2.Replace("/", "") + YourDateTime2.Time.Replace(":", "")

                Dim Da As New SqlClient.SqlDataAdapter
                Da.SelectCommand = New SqlClient.SqlCommand
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Dim DSSixCharkh As New DataSet
                Dim DSSavari As New DataSet
                Dim DSTereiliTenCharkh As New DataSet
                Dim DSExitSixCharkh As New DataSet
                Dim DSExitTereiliTenCharkh As New DataSet
                Dim DSExitSavari As New DataSet
                Dim DSReturnAmount As New DataSet

                'شش چرخ یا دو محور
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                    Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          and ((Accounting.EEAccountingProcessType=1) or (Accounting.EEAccountingProcessType=17) or (Accounting.EEAccountingProcessType=8) or (Accounting.EEAccountingProcessType=11))  And ((Accounting.MblghA=40000) Or (Accounting.MblghA=43600) Or (Accounting.MblghA=45000) Or (Accounting.MblghA=65400) Or (Accounting.MblghA=85020)  Or (Accounting.MblghA=130000) Or (Accounting.MblghA=175000))
                                                    Group By DateShamsiA"
                DSSixCharkh.Tables.Clear()
                Da.Fill(DSSixCharkh)
                'سواری
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                    Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          and ((Accounting.EEAccountingProcessType=1) or (Accounting.EEAccountingProcessType=17))  And ((Accounting.MblghA=14170) Or (Accounting.MblghA=15000) Or (Accounting.MblghA=21255) Or (Accounting.MblghA=27250) Or (Accounting.MblghA=38000) Or (Accounting.MblghA=50000))
                                                    Group By DateShamsiA"
                DSSavari.Tables.Clear()
                Da.Fill(DSSavari)
                'ده و چرخ تریلی یا سه محور به بالا
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                    Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          and ((Accounting.EEAccountingProcessType=1) OR (Accounting.EEAccountingProcessType=17) or (Accounting.EEAccountingProcessType=7) OR (Accounting.EEAccountingProcessType=8) OR (Accounting.EEAccountingProcessType=11)) And ((Accounting.MblghA=60000) or (Accounting.MblghA=59950) or (Accounting.MblghA=81750) or (Accounting.MblghA=105730) or (Accounting.MblghA=160000) or (Accounting.MblghA=215000))
                                                    Group By DateShamsiA"
                DSTereiliTenCharkh.Tables.Clear()
                Da.Fill(DSTereiliTenCharkh)
                'خروج
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                 Inner Join TblRFIDCards as RFs On Accounting.CardId=RFs.CardId 
                                                Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          And (Accounting.EEAccountingProcessType=2) and RFs.CardType=4
                                                Group By DateShamsiA"
                DSExitSixCharkh.Tables.Clear()
                Da.Fill(DSExitSixCharkh)
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                 Inner Join TblRFIDCards as RFs On Accounting.CardId=RFs.CardId 
                                                Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          And (Accounting.EEAccountingProcessType=2) and RFs.CardType=1
                                                Group By DateShamsiA"
                DSExitSavari.Tables.Clear()
                Da.Fill(DSExitSavari)
                Da.SelectCommand.CommandText = "Select Accounting.DateShamsiA,Count(*) as Total,Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                 Inner Join TblRFIDCards as RFs On Accounting.CardId=RFs.CardId 
                                                Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                          And (Accounting.EEAccountingProcessType=2) and (RFs.CardType=2 or RFs.CardType=3)
                                                Group By DateShamsiA"
                DSExitTereiliTenCharkh.Tables.Clear()
                Da.Fill(DSExitTereiliTenCharkh)
                'بازگشت مبلغ
                Da.SelectCommand.CommandText = "Select Sum(Accounting.MblghA) as Jam from R2Primary.dbo.TblAccounting  as Accounting
                                                Where (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))>='" & myConcat1 & "' and (REPLACE(Accounting.DateShamsiA,'/','')+REPLACE(Accounting.TimeA,':',''))<='" & myConcat2 & "'
                                                      And (Accounting.EEAccountingProcessType=15)"
                DSReturnAmount.Tables.Clear()
                Da.Fill(DSReturnAmount)

                Dim myJamKol As Int64 = 0
                Dim myCurrentDate As String = myDateShamsi1
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblEnterExitByMblghReport" : CmdSql.ExecuteNonQuery()
                Do
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblEnterExitByMblghReport(DateShamsi1,DateShamsi2,Time1,Time2,ReportDateShamsi,ReportTime,DateShamsi,SixCharkhEnterTotal,SixCharkhEnterJam,SavariEnterTotal,SavariEnterJam,TereiliTenCharkhEnterTotal,TereiliTenCharkhEnterJam,ExitJamSixCharkh,ExitJamSavari,ExitJamTereiliTenCharkh,JamKol,MahName,ReturnAmount) values('" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "','" & YourDateTime1.Time & "','" & YourDateTime2.Time & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "','" & myCurrentDate & "',0,0,0,0,0,0,0,0,0,0" & ",'" & myMahName & "',0)"
                    CmdSql.ExecuteNonQuery()
                    myCurrentDate = R2Core.PublicProc.R2CoreMClassPublicProcedures.GetNextShamsiDate(myCurrentDate)
                Loop While myCurrentDate.Replace("/", "") <= YourDateTime2.DateShamsiFull.Replace("/", "")
                'نوشتن سواری
                Dim mySavariEnterTotal As Int64 = 0
                Dim mySavariEnterJam As Int64 = 0
                For Loopx As Int64 = 0 To DSSavari.Tables(0).Rows.Count - 1
                    mySavariEnterTotal = DSSavari.Tables(0).Rows(Loopx).Item("Total")
                    If Not DBNull.Value.Equals(DSSavari.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            mySavariEnterJam = DSSavari.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            mySavariEnterJam = DSSavari.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109
                        End If
                        myJamKol += mySavariEnterJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set SavariEnterTotal=" & mySavariEnterTotal & ",SavariEnterJam=" & mySavariEnterJam & " Where DateShamsi='" & DSSavari.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'نوشتن 6 چرخ
                Dim mySixCharkhEnterTotal As Int64 = 0
                Dim mySixCharkhEnterJam As Int64 = 0
                For Loopx As Int64 = 0 To DSSixCharkh.Tables(0).Rows.Count - 1
                    mySixCharkhEnterTotal = DSSixCharkh.Tables(0).Rows(Loopx).Item("Total")
                    If Not DBNull.Value.Equals(DSSixCharkh.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            mySixCharkhEnterJam = DSSixCharkh.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            mySixCharkhEnterJam = DSSixCharkh.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109
                        End If
                        myJamKol += mySixCharkhEnterJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set SixCharkhEnterTotal=" & mySixCharkhEnterTotal & ",SixCharkhEnterJam=" & mySixCharkhEnterJam & " Where DateShamsi='" & DSSixCharkh.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'نوشتن 10 چرخ و تریلی
                Dim myTereiliTenCharkhEnterTotal As Int64 = 0
                Dim myTereiliTenCharkhEnterJam As Int64 = 0
                For Loopx As Int64 = 0 To DSTereiliTenCharkh.Tables(0).Rows.Count - 1
                    myTereiliTenCharkhEnterTotal = DSTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Total")
                    If Not DBNull.Value.Equals(DSTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myTereiliTenCharkhEnterJam = DSTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            myTereiliTenCharkhEnterJam = DSTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109
                        End If
                        myJamKol += myTereiliTenCharkhEnterJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set TereiliTenCharkhEnterTotal=" & myTereiliTenCharkhEnterTotal & ",TereiliTenCharkhEnterJam=" & myTereiliTenCharkhEnterJam & " Where DateShamsi='" & DSTereiliTenCharkh.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'نوشتن خروجی یا همان مازاد
                'شش چرخ
                Dim myExitJam As Int64 = 0
                For Loopx As Int64 = 0 To DSExitSixCharkh.Tables(0).Rows.Count - 1
                    If Not DBNull.Value.Equals(DSExitSixCharkh.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myExitJam = DSExitSixCharkh.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            myExitJam = (DSExitSixCharkh.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109)
                        End If
                        myJamKol += myExitJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set ExitJamSixCharkh=" & myExitJam & " Where DateShamsi='" & DSExitSixCharkh.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'تریلی و 10 چرخ
                For Loopx As Int64 = 0 To DSExitTereiliTenCharkh.Tables(0).Rows.Count - 1
                    If Not DBNull.Value.Equals(DSExitTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myExitJam = DSExitTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            myExitJam = (DSExitTereiliTenCharkh.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109)
                        End If
                        myJamKol += myExitJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set ExitJamTereiliTenCharkh=" & myExitJam & " Where DateShamsi='" & DSExitTereiliTenCharkh.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'سواری
                For Loopx As Int64 = 0 To DSExitSavari.Tables(0).Rows.Count - 1
                    If Not DBNull.Value.Equals(DSExitSavari.Tables(0).Rows(Loopx).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myExitJam = DSExitSavari.Tables(0).Rows(Loopx).Item("Jam")
                        Else
                            myExitJam = (DSExitSavari.Tables(0).Rows(Loopx).Item("Jam") * 100 / 109)
                        End If
                        myJamKol += myExitJam
                    End If
                    CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set ExitJamSavari=" & myExitJam & " Where DateShamsi='" & DSExitSavari.Tables(0).Rows(Loopx).Item("DateShamsiA").trim & "'"
                    CmdSql.ExecuteNonQuery()
                Next
                'نوشتن بازگشت مبلغ
                Dim myReturnAmount As Int64 = 0
                If Not DBNull.Value.Equals(DSReturnAmount.Tables(0).Rows(0).Item("Jam")) Then
                    If YourVatStatus = False Then
                        myReturnAmount = DSReturnAmount.Tables(0).Rows(0).Item("Jam")
                    Else
                        myReturnAmount = DSReturnAmount.Tables(0).Rows(0).Item("Jam") * 100 / 109
                    End If
                End If
                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set ReturnAmount=" & myReturnAmount & ""
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Sub

        Public Shared Function GetAmountforTruckersAssociationControllingMoneyWallet() As Int64
            Try
                Dim NSSLast = R2CoreParkingSystemMClassAccountingManagement.GetNSSLastAccounting(R2CoreParkingSystemAccountings.TruckersAssociationControllingMoneyWallet)
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                                  "Select Sum(MblghA) as Amount from R2Primary.dbo.TblAccounting 
                                   Where DateMilladiA Between '" & _DateTime.GetMilladiDateTimeFromDateShamsiFullFormated(NSSLast.DateShamsiA, NSSLast.TimeA) & "' and '" & _DateTime.GetCurrentDateTimeMilladiFormated() & "'
                                         And (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezUpTo72Saat & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.PrintCopyOfTurn & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeCarTruckNumberPlate & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeDriverTruck & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SoftwareUserSMSOwnerServiceCost & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SoftwareUserShenasehPasswordSMSCost & " )
	                                     And ISNULl(Deleted,0)<>1", 0, Ds).GetRecordsCount = 0 Then
                    Return 0
                Else
                    Return IIf(Ds.Tables(0).Rows(0).Item("Amount").Equals(System.DBNull.Value), 0, Ds.Tables(0).Rows(0).Item("Amount"))
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub ReportingInformationProviderTruckersAssociationFinancialReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime

                Dim _JamMblgh As Int64 = 0
                Dim _JamTeadad As Int64 = 0
                Dim DSRFIDCards As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select * from R2Primary.dbo.TblRFIDCards", 1, DSRFIDCards)

                Dim Concat1 As String = YourDateTime1.GetConcatString
                Dim Concat2 As String = YourDateTime2.GetConcatString
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "delete R2PrimaryReports.dbo.TblTruckersAssociationFinancialReport"
                CmdSql.ExecuteNonQuery()
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("select e.cardid,E.DateShamsiA,E.TimeA ,E.EEAccountingProcessType ,E.PelakA,E.SerialA ,E.MblghA  from R2Primary.dbo.TblAccounting as E WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & Concat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & Concat2 & "')) And (E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezUpTo72Saat & "  OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk & "  OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.PrintCopyOfTurn & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeCarTruckNumberPlate & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeDriverTruck & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SoftwareUserSMSOwnerServiceCost & " Or EEAccountingProcessType=" & R2CoreParkingSystemAccountings.SoftwareUserShenasehPasswordSMSCost & ") and ISNULl(Deleted,0)<>1   ORDER BY E.DateMilladiA")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim DateShamsi As String = Ds.Tables(0).Rows(Loopx).Item("DateShamsiA")
                    Dim Time As String = Ds.Tables(0).Rows(Loopx).Item("TimeA")
                    Dim EEType As String = R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemMClassAccountingManagement.GetAccountingNamebyAccountingCode(Ds.Tables(0).Rows(Loopx).Item("EEAccountingProcessType"))
                    Dim RFCardNo As String
                    Try
                        RFCardNo = DSRFIDCards.Tables(0).Select("CardId=" + Ds.Tables(0).Rows(Loopx).Item("cardid").ToString.Trim())(0)("CardNo")
                    Catch ex As Exception
                    End Try
                    Dim Pelak As String = Ds.Tables(0).Rows(Loopx).Item("PelakA")
                    Dim Serial As String = Ds.Tables(0).Rows(Loopx).Item("SerialA")
                    Dim Mblgh As Int64 = Ds.Tables(0).Rows(Loopx).Item("MblghA")
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblTruckersAssociationFinancialReport(DateShamsi,Time,EEType,RFCardNo,Pelak,Serial,Mblgh,Time1,Date1,Time2,Date2,JamTeadad,JamMblgh) values('" & DateShamsi & "','" & Time & "','" & EEType & "','" & RFCardNo & "','" & Pelak & "','" & Serial & "'," & Mblgh & ",'" & YourDateTime1.Time & "','" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.Time & "','" & YourDateTime2.DateShamsiFull & "',0,0)"
                    CmdSql.ExecuteNonQuery()
                    _JamMblgh = _JamMblgh + Mblgh
                    _JamTeadad = _JamTeadad + 1
                Next
                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblTruckersAssociationFinancialReport Set JamMblgh= " & _JamMblgh & ",JamTeadad= " & _JamTeadad & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderDriverTruckLoadsReport(YourDriverId As Int64, YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("
                  Select LoadAllocations.LAId,Turns.strDriverName,c.strCarNo,c.strCarSerialNo,co.strCompName,Turns.strExitDate,Turns.nEstelamID,Turns.OtaghdarTurnNumber,ci.strCityName,p.strGoodName,Turns.strBarnameNo as LoadPermissionLocation 
                  from Dbtransport.dbo.tbenterexit as Turns
	                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations On Turns.nEnterExitId=LoadAllocations.TurnId 
	                 Inner Join Dbtransport.dbo.tbcar as C on Turns.strCardno=C.nIDCar 
	                 Inner Join Dbtransport.dbo.tbCompany as Co on Turns.nCompCode=CO.nCompCode 
	                 Inner Join Dbtransport.dbo.tbCity as Ci on Turns.nCityCode=CI.nCityCode 
	                 Inner Join Dbtransport.dbo.tbProducts as P on Turns.nBarCode=p.strGoodCode 
                  where Turns.nDriverCode='" & YourDriverId & "' and Turns.strExitDate>='" & YourDateTime1.DateShamsiFull & "' and Turns.strExitDate<='" & YourDateTime2.DateShamsiFull & "'  and LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.PermissionSucceeded & " 
                  Order By Turns.nEnterExitId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "delete R2PrimaryReports.dbo.TblDriverTruckLoadsReport"
                CmdSql.ExecuteNonQuery()

                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim myStrDrivername As String = Ds.Tables(0).Rows(Loopx).Item("strdrivername").trim
                    Dim myStrTruckno As String = Ds.Tables(0).Rows(Loopx).Item("strCarNo").trim
                    Dim myStrSerialno As String = Ds.Tables(0).Rows(Loopx).Item("strCarSerialNo").trim
                    Dim myStrCompname As String = Ds.Tables(0).Rows(Loopx).Item("strcompname").trim
                    Dim mydDateElam As String = Ds.Tables(0).Rows(Loopx).Item("strExitDate").trim
                    Dim mynEstelamid As String = Ds.Tables(0).Rows(Loopx).Item("nEstelamID")
                    Dim mydDateExit As String = Ds.Tables(0).Rows(Loopx).Item("strExitDate").trim
                    Dim myOtaghdarTurnNumber As String = Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber")
                    Dim myStrCityName As String = Ds.Tables(0).Rows(Loopx).Item("strCityName").trim
                    Dim myStrBarname As String = Ds.Tables(0).Rows(Loopx).Item("strGoodName").trim
                    Dim myLoadPermissionLocation As String = IIf(Ds.Tables(0).Rows(Loopx).Item("LoadPermissionLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall, "سالن اعلام بار", "سیستم")
                    Dim myLoadAllocationId As Int64 = Ds.Tables(0).Rows(Loopx).Item("LAId")
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblDriverTruckLoadsReport(Radifx,StrDriverName,StrTruckNo,StrSerialNo,StrCompName,dDateElam,nEstelamId,dDateExit,OtaghdarTurnNumber,StrCityName,StrBarName,LoadPermissionLocation,LoadAllocationId) values(" & Loopx & ",'" & myStrDrivername & "','" & myStrTruckno & "','" & myStrSerialno & "','" & myStrCompname & "','" & mydDateElam & "','" & mynEstelamid & "','" & mydDateExit & "','" & myOtaghdarTurnNumber & "','" & myStrCityName & "','" & myStrBarname & "','" & myLoadPermissionLocation & "'," & myLoadAllocationId & ")"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderCapacitorLoadsforAnnounceReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                If YourAnnouncementHallSubGroupId = AnnouncementHalls.None Then
                    Da.SelectCommand = New SqlClient.SqlCommand("
                             Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNum,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                             from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationLoaderTypes as AHRCarType On CT.snCarType=AHRCarType.LoaderTypeId 
                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRCarType.AHId=AH.AHId	
                             Where  E.dDateElam='" & _DateTime.GetCurrentDateShamsiFull & "' and AHRCarType.RelationActive=1 and AH.AHId=" & YourAnnouncementHallId & " and E.bFlag=0 and (E.LoadStatus=1 or E.LoadStatus=2) and E.nCarNum>0 
                             Order By C.nProvince,strCityName,nTruckType")
                Else
                    Da.SelectCommand = New SqlClient.SqlCommand("
                             Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNum,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                             from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
	                           inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
	                           inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
	                           inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On CT.snCarType=AHSGRCarType.LoaderTypeId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId 
                             Where  E.dDateElam='" & _DateTime.GetCurrentDateShamsiFull & "' and AHSGRCarType.RelationActive=1 and AHRAHSG.RelationActive=1 and AH.AHId=" & YourAnnouncementHallId & " and AHSG.AHSGId=" & YourAnnouncementHallSubGroupId & " and E.bFlag=0 and (E.LoadStatus=1 or E.LoadStatus=2) and E.nCarNum>0 
                             Order By C.nProvince,strCityName,nTruckType")
                End If

                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblCapacitorLoadsforAnnounceReport "
                CmdSql.ExecuteNonQuery()

                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim myAnnouncementHallName As String = PayanehClassLibraryAnnouncementHallsManagement.GetNSSAnnouncementHall(YourAnnouncementHallId).AHName
                    Dim mynEstelamid As String = Ds.Tables(0).Rows(Loopx).Item("nEstelamId")
                    Dim myStrGoodName As String = Ds.Tables(0).Rows(Loopx).Item("strGoodName").trim
                    Dim myStrCityName As String = Ds.Tables(0).Rows(Loopx).Item("strCityName").trim
                    Dim mynTonaj As Int64 = Ds.Tables(0).Rows(Loopx).Item("nTonaj")
                    Dim mynCarNum As Int64 = Ds.Tables(0).Rows(Loopx).Item("nCarNum")
                    Dim myStrPriceSug As String = Ds.Tables(0).Rows(Loopx).Item("strPriceSug").trim
                    Dim myStrDescription As String = Ds.Tables(0).Rows(Loopx).Item("strDescription").trim
                    Dim myStrAddress As String = Ds.Tables(0).Rows(Loopx).Item("strAddress").trim
                    Dim myStrBarname As String = Ds.Tables(0).Rows(Loopx).Item("strBarName").trim
                    Dim mydDateElam As String = Ds.Tables(0).Rows(Loopx).Item("dDateElam").trim
                    Dim mydTimeElam As String = Ds.Tables(0).Rows(Loopx).Item("dTimeElam").trim
                    Dim myCompanyName As String = Ds.Tables(0).Rows(Loopx).Item("StrCompName").trim
                    Dim myStrCarName As String = Ds.Tables(0).Rows(Loopx).Item("StrCarName").trim

                    Dim P As SqlClient.SqlParameter
                    P = New SqlClient.SqlParameter("@AnnoucementHallName", SqlDbType.NVarChar) : P.Value = myAnnouncementHallName
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@nEstelamId", SqlDbType.Int) : P.Value = mynEstelamid
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrGoodName", SqlDbType.NVarChar) : P.Value = myStrGoodName
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrCityName", SqlDbType.NVarChar) : P.Value = myStrCityName
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@nTonaj", SqlDbType.Float) : P.Value = mynTonaj
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@nCarNumKol", SqlDbType.Int) : P.Value = mynCarNum
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrCompanyName", SqlDbType.NVarChar) : P.Value = myCompanyName
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrPriceSug", SqlDbType.NVarChar) : P.Value = myStrPriceSug
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrDescription", SqlDbType.NVarChar) : P.Value = myStrDescription
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrAddress", SqlDbType.NVarChar) : P.Value = myStrAddress
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrBarName", SqlDbType.NVarChar) : P.Value = myStrBarname
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@dDateElam", SqlDbType.NVarChar) : P.Value = mydDateElam
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@dTimeElam", SqlDbType.NVarChar) : P.Value = mydTimeElam
                    CmdSql.Parameters.Add(P)
                    P = New SqlClient.SqlParameter("@StrCarName", SqlDbType.NVarChar) : P.Value = myStrCarName
                    CmdSql.Parameters.Add(P)
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblCapacitorLoadsforAnnounceReport (@AnnoucementHallName,@nEstelamId,@StrGoodName,@StrCityName,@nTonaj,@nCarNumKol,@StrCompanyName,@StrPriceSug,@StrDescription,@StrAddress,@StrBarName,@dDateElam,@dTimeElam,@StrCarName)"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderCapacitorLoadsCompanyRegisteredLoadsReport(YourAHId As Int64, YourAHSGId As Int64, YourCompanyCode As Int64, YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourTargetCityId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                'شروع تراکنش ثبت اطلاعات گزارش
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblCapacitorLoadsCompanyRegisteredLoads"
                CmdSql.ExecuteNonQuery()

                'لیست بار ثبتی
                Dim TargetCitySql As String = IIf(YourTargetCityId = Int64.MinValue, String.Empty, " and E.nCityCode=" & YourTargetCityId & "")
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                If YourAHId = AnnouncementHalls.None Then 'AHId=None and AHSGId<>None
                    If YourCompanyCode = Int64.MinValue Then
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,AnnouncementHallSubGroups.AHSGTitle,LoadCapacitorLoadStatuses.LoadStatusName
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AnnouncementHalls On E.AHId=AnnouncementHalls.AHId 
	                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On E.AHSGId=AnnouncementHallSubGroups.AHSGId               
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses as LoadCapacitorLoadStatuses On e.LoadStatus=LoadCapacitorLoadStatuses.LoadStatusId 
                            Where (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " and AnnouncementHalls.ViewFlag=1 and AnnouncementHalls.Deleted=0 and AnnouncementHallSubGroups.ViewFlag=1 and AnnouncementHallSubGroups.Deleted=0
                                  and AnnouncementHallSubGroups.AHSGId=" & YourAHSGId & "
                            Order By E.dDateElam,E.nCompCode,E.nTruckType,E.dTimeElam")
                    Else
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,AnnouncementHallSubGroups.AHSGTitle,LoadCapacitorLoadStatuses.LoadStatusName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AnnouncementHalls On E.AHId=AnnouncementHalls.AHId 
	                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On E.AHSGId=AnnouncementHallSubGroups.AHSGId 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses as LoadCapacitorLoadStatuses On e.LoadStatus=LoadCapacitorLoadStatuses.LoadStatusId 
                            Where E.nCompCode=" & YourCompanyCode & " and (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " and AnnouncementHalls.ViewFlag=1 and AnnouncementHalls.Deleted=0 and AnnouncementHallSubGroups.ViewFlag=1 and AnnouncementHallSubGroups.Deleted=0
                                  and AnnouncementHallSubGroups.AHSGId=" & YourAHSGId & " 
                            Order By E.dDateElam,E.nTruckType,E.dTimeElam")
                    End If
                Else  'AHId<>None and AHSGId=None
                    If YourCompanyCode = Int64.MinValue Then
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,AnnouncementHallSubGroups.AHSGTitle,LoadCapacitorLoadStatuses.LoadStatusName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AnnouncementHalls On E.AHId=AnnouncementHalls.AHId 
	                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On E.AHSGId=AnnouncementHallSubGroups.AHSGId                             
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses as LoadCapacitorLoadStatuses On e.LoadStatus=LoadCapacitorLoadStatuses.LoadStatusId 
                            Where (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " and AnnouncementHalls.ViewFlag=1 and AnnouncementHalls.Deleted=0 and AnnouncementHallSubGroups.ViewFlag=1 and AnnouncementHallSubGroups.Deleted=0 
                                  and AnnouncementHalls.AHId=" & YourAHId & "
                            Order By E.dDateElam,E.nCompCode,E.dTimeElam")
                    Else
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nTonaj,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,AnnouncementHallSubGroups.AHSGTitle,LoadCapacitorLoadStatuses.LoadStatusName
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AnnouncementHalls On E.AHId=AnnouncementHalls.AHId 
   	                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On E.AHSGId=AnnouncementHallSubGroups.AHSGId                             
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses as LoadCapacitorLoadStatuses On e.LoadStatus=LoadCapacitorLoadStatuses.LoadStatusId 
                            Where E.nCompCode=" & YourCompanyCode & " and (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " and AnnouncementHalls.ViewFlag=1 and AnnouncementHalls.Deleted=0 and AnnouncementHallSubGroups.ViewFlag=1 and AnnouncementHallSubGroups.Deleted=0 
                                  and AnnouncementHalls.AHId=" & YourAHId & "
                            Order By e.nEstelamID")
                    End If
                End If
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                If Da.Fill(Ds) <> 0 Then
                    'لیست کلیه مجوزهای صادرشده برای کلیه بارهای فوق
                    Dim nEstelamIds = "'" + Ds.Tables(0).Rows(0).Item("nEstelamId").ToString + "'"
                    For Each nEstelamId As DataRow In Ds.Tables(0).Rows
                        nEstelamIds += ",'" + nEstelamId.Item("nEstelamId").ToString + "'"
                    Next
                    Dim DaLoadPermission As New SqlClient.SqlDataAdapter : Dim DsLoadPermission As New DataSet
                    DaLoadPermission.SelectCommand = New SqlCommand("
                         Select LoadPermissions.nEstelamId,LoadPermissions.StrExitDate,LoadPermissions.StrExitTime,LoadPermissions.StrDriverName,Cars.strCarNo,Cars.strCarSerialNo,LoadPermissionStatuses.LoadPermissionStatusTitle,Cars.StrBodyNo,LoadAllocations.LANote,LoadPermissions.OtaghdarTurnNumber as SequentialTurnNumber 
                           from DBTransport.dbo.TbEnterExit as LoadPermissions
                             Inner Join dbtransport.dbo.TbCar as Cars On LoadPermissions.strCardno=Cars.nIDCar 
                             Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses as LoadPermissionStatuses On LoadPermissionStatuses.LoadPermissionStatusId=LoadPermissions.LoadPermissionStatus 
							 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations On LoadPermissions.nEstelamID=LoadAllocations.nEstelamId  and LoadPermissions.nEnterExitId=LoadAllocations.TurnId 
                         Where LoadPermissions.nEstelamId In (" & nEstelamIds & ")")
                    DaLoadPermission.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                    DaLoadPermission.Fill(DsLoadPermission)

                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        'اطلاعات بار
                        Dim mynEstelamid As String = Ds.Tables(0).Rows(Loopx).Item("nEstelamId")
                        Dim myStrGoodName As String = Ds.Tables(0).Rows(Loopx).Item("strGoodName").trim
                        Dim myStrCityName As String = Ds.Tables(0).Rows(Loopx).Item("strCityName").trim
                        Dim mynTonaj As Double = Ds.Tables(0).Rows(Loopx).Item("nTonaj")
                        Dim mynCarNumKol As Int64 = Ds.Tables(0).Rows(Loopx).Item("nCarNumKol")
                        Dim myStrPriceSug As String = Ds.Tables(0).Rows(Loopx).Item("strPriceSug").trim
                        Dim myStrDescription As String = Ds.Tables(0).Rows(Loopx).Item("strDescription").trim
                        Dim myStrAddress As String = Ds.Tables(0).Rows(Loopx).Item("strAddress").trim
                        Dim myStrBarname As String = Ds.Tables(0).Rows(Loopx).Item("strBarName").trim
                        Dim mydDateElam As String = Ds.Tables(0).Rows(Loopx).Item("dDateElam").trim
                        Dim mydTimeElam As String = Ds.Tables(0).Rows(Loopx).Item("dTimeElam").trim
                        Dim myCompanyName As String = Ds.Tables(0).Rows(Loopx).Item("StrCompName").trim
                        Dim myAHSGTitle As String = Ds.Tables(0).Rows(Loopx).Item("AHSGTitle").trim
                        Dim myLoadStatusName = Ds.Tables(0).Rows(Loopx).Item("LoadStatusName").trim

                        'اطلاعات مجوزهای صادره
                        Dim LoadPermissions As DataRow()
                        LoadPermissions = DsLoadPermission.Tables(0).Select("nEstelamId=" + mynEstelamid)
                        Dim CompositStringDriverName As String = String.Empty
                        Dim CompositStringDate = String.Empty
                        Dim CompositStringTime = String.Empty
                        Dim CompositStringLoadPermissionStatus = String.Empty
                        For LoopPermissions As Int64 = 0 To LoadPermissions.Count() - 1
                            CompositStringDate = CompositStringDate & LoadPermissions(LoopPermissions)(1).trim & vbCrLf
                            CompositStringTime = CompositStringTime & LoadPermissions(LoopPermissions)(2).trim + " - " + LoadPermissions(LoopPermissions)(9).trim & vbCrLf
                            CompositStringLoadPermissionStatus = CompositStringLoadPermissionStatus & LoadPermissions(LoopPermissions)(8).trim + vbCrLf
                            Dim Truck As String = LoadPermissions(LoopPermissions)(4).trim + " - " + LoadPermissions(LoopPermissions)(5).trim
                            Dim SmartCardId = LoadPermissions(LoopPermissions)(7).trim
                            CompositStringDriverName = CompositStringDriverName & LoadPermissions(LoopPermissions)(3).trim & " " & Truck & " " + SmartCardId + vbCrLf
                        Next

                        Dim P As SqlClient.SqlParameter
                        P = New SqlClient.SqlParameter("@nEstelamId", SqlDbType.Int) : P.Value = mynEstelamid
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrGoodName", SqlDbType.VarChar) : P.Value = myStrGoodName
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrCityName", SqlDbType.VarChar) : P.Value = myStrCityName
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@nTonaj", SqlDbType.Float) : P.Value = mynTonaj
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@nCarNumKol", SqlDbType.Int) : P.Value = mynCarNumKol
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrCompanyName", SqlDbType.VarChar) : P.Value = myCompanyName
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrPriceSug", SqlDbType.VarChar) : P.Value = myStrPriceSug
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrDescription", SqlDbType.VarChar) : P.Value = myStrDescription
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrAddress", SqlDbType.VarChar) : P.Value = myStrAddress
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrBarName", SqlDbType.VarChar) : P.Value = myStrBarname
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@dDateElam", SqlDbType.VarChar) : P.Value = mydDateElam
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@dTimeElam", SqlDbType.VarChar) : P.Value = mydTimeElam
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@AHSGTitle", SqlDbType.VarChar) : P.Value = myAHSGTitle
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrExitDate", SqlDbType.VarChar) : P.Value = CompositStringDate
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrExitTime", SqlDbType.VarChar) : P.Value = CompositStringTime
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@StrDriverName", SqlDbType.VarChar) : P.Value = CompositStringDriverName
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@LoadPermissionStatus", SqlDbType.VarChar) : P.Value = CompositStringLoadPermissionStatus
                        CmdSql.Parameters.Add(P)
                        P = New SqlClient.SqlParameter("@LoadStatusName", SqlDbType.VarChar) : P.Value = myLoadStatusName
                        CmdSql.Parameters.Add(P)
                        CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblCapacitorLoadsCompanyRegisteredLoads(@nEstelamId,@StrGoodName,@StrCityName,@nTonaj,@nCarNumKol,@StrCompanyName,@StrPriceSug,@StrDescription,@StrAddress,@StrBarName,@dDateElam,@dTimeElam,@AHSGTitle,@StrExitDate,@StrExitTime,@StrDriverName,@LoadPermissionStatus,@LoadStatusName)"
                        CmdSql.ExecuteNonQuery()
                    Next
                End If

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderAnnouncementHallPerformanceReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourNSSAnnouncementHall As PayanehClassLibraryStandardAnnouncementHallStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                'آماده سازی اطلاعات مورد نیاز
                Dim DaRegisteredLoad As New SqlClient.SqlDataAdapter : Dim DsRegisteredLoad As New DataSet
                DaRegisteredLoad.SelectCommand = New SqlCommand("Select ElamInf.*,Comp.strCompName from (Select Elam.nCompCode,AH.AHId,AHSG.AHSGId,Sum(Elam.nCarNumKol) as Jam from dbtransport.dbo.tbElam as Elam 
                                                    inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On Elam.nTruckType=AHSGRCarType.LoaderTypeId
                                                    inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId
                                                    inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                                                    inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                                                  Where Elam.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and Elam.dDateElam<='" & YourDateTime2.DateShamsiFull & "' and AH.AHId=" & YourNSSAnnouncementHall.AHId & " and Elam.LoadStatus<>3 and Elam.LoadStatus<>4 and Elam.LoadStatus<>6  
                                                  Group By Elam.nCompCode,AH.AHId,AHSG.AHSGId) as ElamInf
                                                    inner join dbtransport.dbo.tbCompany as Comp On ElamInf.nCompCode=Comp.nCompCode
                                                            Order By ElamInf.nCompCode,ElamInf.AHId,ElamInf.AHSGId")

                DaRegisteredLoad.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                DsRegisteredLoad.Tables.Clear()
                DaRegisteredLoad.Fill(DsRegisteredLoad)
                Dim DaReleasedLoad As New SqlClient.SqlDataAdapter : Dim DsReleasedLoad As New DataSet
                DaReleasedLoad.SelectCommand = New SqlCommand("Select Elam.nCompCode,AH.AHId,AHSG.AHSGId,EnterExit.strBarnameNo as ReleaseLocation,Count(*) as Teadad from dbtransport.dbo.tbElam as Elam 
                                                               inner join dbtransport..tbEnterExit as EnterExit On Elam.nEstelamID=EnterExit.nEstelamID
                                                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On Elam.nTruckType=AHSGRCarType.LoaderTypeId
                                                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId
                                                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                                                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                                                             Where  EnterExit.LoadPermissionStatus=1 and Elam.dDateElam>='" & YourDateTime1.DateShamsiFull & "'  and Elam.dDateElam<='" & YourDateTime2.DateShamsiFull & "' and EnterExit.bFlag=1 and EnterExit.bFlagDriver=1 and AH.AHId=" & YourNSSAnnouncementHall.AHId & " 
                                                             Group By Elam.nCompCode,AH.AHId,AHSG.AHSGId,EnterExit.strBarnameNo")

                DaReleasedLoad.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                DsReleasedLoad.Tables.Clear()
                DaReleasedLoad.Fill(DsReleasedLoad)

                'شروع تراکنش
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport"
                CmdSql.ExecuteNonQuery()

                'مرحله اول ایجاد کد و نام شرکت های حمل و نقل
                Dim myTransportCompanies As List(Of R2StandardStructure) = TransportCompanies.TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanies("")
                For Loopx As Int64 = 0 To myTransportCompanies.Count - 1
                    Dim TransportCompanyId As Int64 = myTransportCompanies(Loopx).OCode
                    Dim TransportCompanyName As String = myTransportCompanies(Loopx).OName
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport(TransportCompanyId,TransportCompanyName,
                                           OtaghdarKhavarAnnounced,Otaghdar6CharkhAnnounced,Otaghdar10CharkhAnnounced,AnbariAnbariAnnounced,AnbariShemshAnnounced,AnbariSaderatiAnnounced,AnbariCoilAnnounced,ZobiZobiAnnounced,ZobiShemshAnnounced,ZobiSaderatiAnnounced,ZobiCoilAnnounced,ShahriShahriAnnounced,ShahriCoilAnnounced,
                                           OtaghdarKhavarReleasedInAnnouncementHall,OtaghdarKhavarReleasedInTransportCompany,Otaghdar6CharkhReleasedInAnnouncementHall,Otaghdar6CharkhReleasedInTransportCompany,Otaghdar10CharkhReleasedInAnnouncementHall,Otaghdar10CharkhReleasedInTransportCompany,AnbariAnbariReleasedInAnnouncementHall,	AnbariAnbariReleasedInTransportCompany,AnbariShemshReleasedInAnnouncementHall,AnbariShemshReleasedInTransportCompany,AnbariSaderatiReleasedInAnnouncementHall,AnbariSaderatiReleasedInTransportCompany,AnbariCoilReleasedInAnnouncementHall,AnbariCoilReleasedInTransportCompany,ZobiZobiReleasedInAnnouncementHall,ZobiZobiReleasedInTransportCompany,ZobiShemshReleasedInAnnouncementHall,ZobiShemshReleasedInTransportCompany,ZobiSaderatiReleasedInAnnouncementHall,ZobiSaderatiReleasedInTransportCompany,ZobiCoilReleasedInAnnouncementHall,ZobiCoilReleasedInTransportCompany,ShahriShahriReleasedInAnnouncementHall,ShahriShahriReleasedInTransportCompany,ShahriCoilReleasedInAnnouncemetHall,ShahriCoilReleasedInTransportCompany,
                                           Date1,Date2,CurrentDateShamsi,CurrentTime,Note) Values(" & TransportCompanyId & ",'" & TransportCompanyName & "',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & YourNSSAnnouncementHall.AHName & "')"
                    CmdSql.ExecuteNonQuery()
                Next
                'مرحله دوم ایجاد تعداد بار ثبت شده یا اعلام شده
                Dim nCompCode As Int64
                For Loopx As Int64 = 0 To DsRegisteredLoad.Tables(0).Rows.Count - 1
                    nCompCode = DsRegisteredLoad.Tables(0).Rows(Loopx).Item("nCompCode")
                    If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Khavar Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set OtaghdarKhavarAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar6 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar6CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar10 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar10CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Anbari Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.WareHouseOutShahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.WareHouseShahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Zobi Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Zobi Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiZobiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiShemsh Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiSaderati Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiSaderatiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Shahri Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Shahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ShahriShahriAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ShahriRol Then CmdSql.CommandText = "Update TblAnnouncementHallPerformanceReport Set ShahriCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        CmdSql.ExecuteNonQuery()
                    End If
                Next
                'مرحله سوم ایجاد تعداد بار ترخیص شده
                For Loopy As Int64 = 0 To DsReleasedLoad.Tables(0).Rows.Count - 1
                    nCompCode = DsReleasedLoad.Tables(0).Rows(Loopy).Item("nCompCode")
                    If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Khavar Then

                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set OtaghdarKhavarReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set OtaghdarKhavarReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar6 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar6CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar6CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar10 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar10CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set Otaghdar10CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Anbari Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.WareHouseOutShahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.WareHouseShahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Zobi Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Zobi Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiZobiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiZobiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiShemsh Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiSaderati Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiSaderatiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiSaderatiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ZobiRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiCoilReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ZobiCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Shahri Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Shahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ShahriShahriReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ShahriShahriReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.ShahriRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ShahriCoilReleasedInAnnouncemetHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set ShahriCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                    End If
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderAnnouncementHallPerformanceGeneralStatisticsReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                'آماده سازی اطلاعات مورد نیاز
                Dim DaRegisteredLoad As New SqlClient.SqlDataAdapter : Dim DsRegisteredLoad As New DataSet
                DaRegisteredLoad.SelectCommand = New SqlCommand("
                     Select AH.AHId,AHSG.AHSGId,Sum(Elam.nCarNumKol) as Jam from dbtransport.dbo.tbElam as Elam 
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On Elam.nTruckType=AHSGRCarType.LoaderTypeId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                     Where Elam.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and Elam.dDateElam<='" & YourDateTime2.DateShamsiFull & "' and Elam.LoadStatus<>3 and Elam.LoadStatus<>4 and Elam.LoadStatus<>6
                     Group By AH.AHId,AHSG.AHSGId")
                DaRegisteredLoad.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                DsRegisteredLoad.Tables.Clear()
                DaRegisteredLoad.Fill(DsRegisteredLoad)
                Dim DaReleasedLoad As New SqlClient.SqlDataAdapter : Dim DsReleasedLoad As New DataSet
                DaReleasedLoad.SelectCommand = New SqlCommand("
                     Select AH.AHId,AHSG.AHSGId,EnterExit.strBarnameNo as ReleaseLocation,Count(*) as Teadad from dbtransport.dbo.tbElam as Elam 
                        inner join dbtransport..tbEnterExit as EnterExit On Elam.nEstelamID=EnterExit.nEstelamID
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On Elam.nTruckType=AHSGRCarType.LoaderTypeId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                        inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                     Where EnterExit.LoadPermissionStatus=1 and Elam.dDateElam>='" & YourDateTime1.DateShamsiFull & "'  and Elam.dDateElam<='" & YourDateTime2.DateShamsiFull & "' and EnterExit.bFlag=1 and EnterExit.bFlagDriver=1
                     Group By AH.AHId,AHSG.AHSGId,EnterExit.strBarnameNo")
                DaReleasedLoad.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                DsReleasedLoad.Tables.Clear()
                DaReleasedLoad.Fill(DsReleasedLoad)

                'شروع تراکنش
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport(OtaghdarKhavarAnnounced,Otaghdar6CharkhAnnounced,Otaghdar10CharkhAnnounced,
                                        AnbariAnbariAnnounced,AnbariShemshAnnounced,AnbariSaderatiAnnounced,AnbariCoilAnnounced,
                                        ZobiZobiAnnounced,ZobiShemshAnnounced,ZobiSaderatiAnnounced,ZobiCoilAnnounced,
                                        ShahriShahriAnnounced,ShahriCoilAnnounced,
                                        OtaghdarKhavarReleasedInAnnouncementHall,OtaghdarKhavarReleasedInTransportCompany,Otaghdar6CharkhReleasedInAnnouncementHall,Otaghdar6CharkhReleasedInTransportCompany,Otaghdar10CharkhReleasedInAnnouncementHall,Otaghdar10CharkhReleasedInTransportCompany,
                                        AnbariAnbariReleasedInAnnouncementHall,AnbariAnbariReleasedInTransportCompany,AnbariShemshReleasedInAnnouncementHall,AnbariShemshReleasedInTransportCompany,AnbariSaderatiReleasedInAnnouncementHall,AnbariSaderatiReleasedInTransportCompany,AnbariCoilReleasedInAnnouncementHall,AnbariCoilReleasedInTransportCompany,
                                        ZobiZobiReleasedInAnnouncementHall,ZobiZobiReleasedInTransportCompany,ZobiShemshReleasedInAnnouncementHall,ZobiShemshReleasedInTransportCompany,ZobiSaderatiReleasedInAnnouncementHall,ZobiSaderatiReleasedInTransportCompany,ZobiCoilReleasedInAnnouncementHall,ZobiCoilReleasedInTransportCompany,
                                        ShahriShahriReleasedInAnnouncementHall,ShahriShahriReleasedInTransportCompany,ShahriCoilReleasedInAnnouncemetHall,ShahriCoilReleasedInTransportCompany,
                                        Date1,Date2,CurrentDateShamsi,CurrentTime,Note) Values(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','')"
                CmdSql.ExecuteNonQuery()

                'مرحله دوم ایجاد تعداد بار ثبت شده یا اعلام شده
                For Loopx As Int64 = 0 To DsRegisteredLoad.Tables(0).Rows.Count - 1
                    If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHalls.Otaghdar Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.Khavar Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.Otaghdar6 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.Otaghdar10 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHalls.Anbari Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.WareHouseOutShahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.WareHouseShahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHalls.Zobi Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.Zobi Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.ZobiShemsh Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.ZobiSaderati Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.ZobiRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHalls.Shahri Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.Shahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallSubGroups.ShahriRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    End If
                Next

                'مرحله سوم ایجاد تعداد بار ترخیص شده
                For Loopy As Int64 = 0 To DsReleasedLoad.Tables(0).Rows.Count - 1
                    If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHalls.Otaghdar Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.Khavar Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.Otaghdar6 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.Otaghdar10 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHalls.Anbari Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.WareHouseOutShahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.WareHouseShahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHalls.Zobi Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.Zobi Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.ZobiShemsh Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.ZobiSaderati Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.ZobiRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHalls.Shahri Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.Shahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallSubGroups.ShahriRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriCoilReleasedInAnnouncemetHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    End If
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTruckDriversWaitingToGetLoadPermissionReport(YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            'گزارش رانندگان منتظر دریافت مجوز بارگیری
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("
                   Select Turns.nEnterExitId,Substring(Turns.OtaghdarTurnNumber,7,20) as SequentialId,Turns.strEnterDate,Turns.strEnterTime,DATEDIFF(day,dbtransport.dbo.Udf_Shamsi2Milady(Turns.strEnterDate),getdate()) as SleepDays,SeqT.SeqTTitle,Persons.strPersonFullName,Cars.strCarNo,Cars.strCarSerialNo
                   from dbtransport.dbo.tbEnterExit as Turns
                     Inner Join dbtransport.dbo.TbPerson as Persons On Turns.nDriverCode=Persons.nIDPerson
                     Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar
	                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCars On Turns.strCardno=AHSGRCars.CarId 
	                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On Substring(Turns.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS=SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS
                   Where (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10) and 
                         AHSGRCars.AHSGId=" & YourNSSAnnouncementHallSubGroup.AHSGId & " and AHSGRCars.RelationActive=1 and ((DATEDIFF(SECOND,AHSGRCars.RelationTimeStamp,getdate())<240) or (AHSGRCars.RelationTimeStamp='2015-01-01 00:00:00.000'))  
                   Order By Turns.strEnterDate,Turns.strEnterTime,AHSGRCars.RelationId Desc")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTruckDriversWaitingToGetLoadPermissionReport" : CmdSql.ExecuteNonQuery()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTruckDriversWaitingToGetLoadPermissionReport(EnterExitId,SequentialId,TurnDate,TurnTime,SleepDays,SequentialTurnTitle,TruckDriver,Truck) Values(" & Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")) & ",'" & Ds.Tables(0).Rows(Loopx).Item("SequentialId") & "','" & Ds.Tables(0).Rows(Loopx).Item("strEnterDate") & "','" & Ds.Tables(0).Rows(Loopx).Item("strEnterTime") & "'," & Ds.Tables(0).Rows(Loopx).Item("SleepDays") & ",'" & Ds.Tables(0).Rows(Loopx).Item("SeqTTitle").trim & "','" & Ds.Tables(0).Rows(Loopx).Item("strPersonFullName").trim & "','" & Ds.Tables(0).Rows(Loopx).Item("strCarNo").trim + "-" + Ds.Tables(0).Rows(Loopx).Item("strCarSerialNo").trim & "')"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTrucksAverageOfSleepDaysToGetLoadPermissionReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourAnnouncementHallId As Int64)
            'گزارش میانگین خواب ناوگان باری برای دریافت مجوز بارگیری
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("
                   Select Turns.nEnterExitId,SUBSTRING(turns.OtaghdarTurnNumber,7,20) as SequentialId,Cars.strCarNo,Cars.strCarSerialNo,Turns.strEnterDate,Turns.strEnterTime,Turns.strExitDate,Turns.strExitTime,DATEDIFF(day,dbtransport.dbo.Udf_Shamsi2Milady(Turns.strEnterDate),dbtransport.dbo.Udf_Shamsi2Milady(Turns.strExitDate)) as SleepDays from dbtransport.dbo.tbEnterExit as Turns
                    Inner Join dbtransport.dbo.tbCar as Cars On Turns.strCardno=Cars.nIDCar
                      Where (Turns.strExitDate>='" & YourDateTime1.DateShamsiFull & " ' and Turns.strExitDate<='" & YourDateTime2.DateShamsiFull & "') and 
	                         substring(Turns.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS In 
		                         (Select SeqT.SeqTKeyWord from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH
			                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqT On AH.AHId=AHRSeqT.AHId
			                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On AHRSeqT.SeqTId=SeqT.SeqTId 
			                       Where AH.AHId=" & YourAnnouncementHallId & " and AH.Deleted=0 and AHRSeqT.RelationActive=1)")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTrucksAverageOfSleepDaysToGetLoadPermissionReport" : CmdSql.ExecuteNonQuery()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTrucksAverageOfSleepDaysToGetLoadPermissionReport(EnterExitId,SequentialId,Truck,TurnDate,TurnTime,LoadPermissionDate,LoadPermissionTime,SleepDays) Values(" & Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")) & "," & Ds.Tables(0).Rows(Loopx).Item("SequentialId") & ",'" & Ds.Tables(0).Rows(Loopx).Item("strCarNo").trim + "-" + Ds.Tables(0).Rows(Loopx).Item("strCarSerialNo").trim & "','" & Ds.Tables(0).Rows(Loopx).Item("strEnterDate") & "','" & Ds.Tables(0).Rows(Loopx).Item("strEnterTime") & "','" & Ds.Tables(0).Rows(Loopx).Item("strExitDate") & "','" & Ds.Tables(0).Rows(Loopx).Item("strExitTime") & "'," & Ds.Tables(0).Rows(Loopx).Item("SleepDays") & ")"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTravelLengthOfLoadTargetsReport()
            'گزارش میانگین خواب ناوگان باری برای دریافت مجوز بارگیری
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Citys.nCityCode,Citys.strCityName,Cast(Citys.nDistance/25 as bigint) as TravelLength,Provinces.ProvinceName from dbtransport.dbo.tbCity as Citys
                                                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblProvinces as Provinces On Citys.nProvince=Provinces.ProvinceId
                                                    Where Citys.Deleted=0 and Provinces.Deleted=0 and Citys.ViewFlag=1 Order By Provinces.ProvinceName")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTravelLengthOfLoadTargetsReport" : CmdSql.ExecuteNonQuery()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTravelLengthOfLoadTargetsReport(nCityCode,StrCityName,TravelLength,ProvinceName) Values(" & Ds.Tables(0).Rows(Loopx).Item("nCityCode") & ",'" & Ds.Tables(0).Rows(Loopx).Item("strCityName") & "'," & Ds.Tables(0).Rows(Loopx).Item("TravelLength") & ",'" & Ds.Tables(0).Rows(Loopx).Item("ProvinceName") & "')"
                    CmdSql.ExecuteNonQuery()
                Next
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTransportPriceTarrifsReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64, YourOActiveStatus As Boolean)
            'گزارش تعرفه های حمل بار
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim OActiveSqlString As String = IIf(YourOActiveStatus = True, " Tarrifs.OActive=1 and ", "")
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTransportPriceTarrifsReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTransportPriceTarrifsReport
                   Select AH.AHTitle,AHSG.AHSGTitle,Tarrifs.TargetCityId,Citys.strCityName,Tarrifs.Tarrif,Tarrifs.DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs as Tarrifs
                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls AS AH On Tarrifs.AHId=AH.AHId
                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On Tarrifs.AHSGId=AHSG.AHSGId
                     Inner Join dbtransport.dbo.tbCity as Citys On Tarrifs.TargetCityId=Citys.nCityCode
                       Where " + OActiveSqlString + " Tarrifs.AHId=" & YourAnnouncementHallId & " and Tarrifs.AHSGId=" & YourAnnouncementHallSubGroupId & " and Citys.Deleted=0 and AH.Deleted=0 and AHSG.Deleted=0
                       Order By Citys.strCityName,Tarrifs.DateTimeMilladi"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderIndigenousTrucksWithUNNativeLPReport()
            'گزارش ناوگان باری بومی با پلاک غیربومی
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblIndigenousTrucksWithUNNativeLPReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblIndigenousTrucksWithUNNativeLPReport 
                           Select IndigenousTrucksWithUNNativeLP.Pelak,IndigenousTrucksWithUNNativeLP.Serial,SoftwareUsers.UserName,IndigenousTrucksWithUNNativeLP.DateShamsi,IndigenousTrucksWithUNNativeLP.EnghezaDate from R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP as IndigenousTrucksWithUNNativeLP
                             Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On IndigenousTrucksWithUNNativeLP.UserId=SoftwareUsers.UserId
                           Where IndigenousTrucksWithUNNativeLP.EnghezaDate='' or IndigenousTrucksWithUNNativeLP.EnghezaDate>='" & _DateTime.GetCurrentDateShamsiFull() & "'
                           Order By IndigenousTrucksWithUNNativeLP.DateTimeMilladi"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Enum SedimentedLoadsReportType
            None = 0
            ByTransportCompanyTargetCity = 1
            ByTargetCity = 2
        End Enum

        Public Shared Sub ReportingInformationProviderSedimentedLoadsReport(YourDate1 As R2StandardDateAndTimeStructure, YourDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourSedimentedLoadReportType As SedimentedLoadsReportType)
            'گزارش بار رسوبی سالن های اعلام بار
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim AnnouncementHall As String = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(YourAHId).AHTitle
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblSedimentedLoadsReport" : CmdSql.ExecuteNonQuery()
                If YourSedimentedLoadReportType = SedimentedLoadsReportType.ByTransportCompanyTargetCity Then
                    CmdSql.CommandText = "
                  Insert Into R2PrimaryReports.dbo.TblSedimentedLoadsReport
                   Select TargetCity.strCityName,TransportCompanies.strCompName,Sum(SedimentedAmount)  as SedimentedAmount,Sum(AnnouncedAmount) as AnnouncedAmount,'" & AnnouncementHall & "','" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "' from 
                     (Select LoadCapacitor.nEstelamID,LoadCapacitor.nCompCode,LoadCapacitor.nCityCode,(LoadCapacitor.nCarNumKol-LoadPermissions.ReleasedAmount) as SedimentedAmount,LoadCapacitor.nCarNumKol as AnnouncedAmount,LoadCapacitor.dDateElam from dbtransport.dbo.tbElam as LoadCapacitor
                       Inner Join (Select nEstelamID,Count(*) as ReleasedAmount from dbtransport.dbo.tbEnterExit as LoadPermissions Group By LoadPermissions.nEstelamID) as LoadPermissions On LoadCapacitor.nEstelamID=LoadPermissions.nEstelamID 
                      Where LoadCapacitor.nCarNumKol>LoadPermissions.ReleasedAmount and LoadCapacitor.dDateElam>='" & YourDate1.DateShamsiFull & "' and LoadCapacitor.dDateElam<='" & YourDate2.DateShamsiFull & "' and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.LoadStatus<>4 and LoadCapacitor.LoadStatus<>3
                      Union
                      Select LoadCapacitor.nEstelamID,LoadCapacitor.nCompCode,LoadCapacitor.nCityCode,LoadCapacitor.nCarNumKol as SedimentedAmount,LoadCapacitor.nCarNumKol as AnnouncedAmount,LoadCapacitor.dDateElam from dbtransport.dbo.tbElam as LoadCapacitor
                      Where isnull(LoadCapacitor.dDateExit,'')='' and LoadCapacitor.dDateElam>='" & YourDate1.DateShamsiFull & "' and LoadCapacitor.dDateElam<='" & YourDate2.DateShamsiFull & "' and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.LoadStatus<>4 and LoadCapacitor.LoadStatus<>3) as DataBox
                   Inner Join dbtransport.dbo.tbCompany as TransportCompanies On DataBox.nCompCode=TransportCompanies.nCompCode
                   Inner Join dbtransport.dbo.tbCity as TargetCity On DataBox.nCityCode=TargetCity.nCityCode  
                   Group By strCompName,strCityName
                   Order By strCompName"
                ElseIf YourSedimentedLoadReportType = SedimentedLoadsReportType.ByTargetCity Then
                    CmdSql.CommandText = "
                  Insert Into R2PrimaryReports.dbo.TblSedimentedLoadsReport
                   Select TargetCity.strCityName,'',Sum(SedimentedAmount)  as SedimentedAmount,Sum(AnnouncedAmount) as AnnouncedAmount,'" & AnnouncementHall & "','" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "' from 
                     (Select LoadCapacitor.nEstelamID,LoadCapacitor.nCompCode,LoadCapacitor.nCityCode,(LoadCapacitor.nCarNumKol-LoadPermissions.ReleasedAmount) as SedimentedAmount,LoadCapacitor.nCarNumKol as AnnouncedAmount,LoadCapacitor.dDateElam from dbtransport.dbo.tbElam as LoadCapacitor
                       Inner Join (Select nEstelamID,Count(*) as ReleasedAmount from dbtransport.dbo.tbEnterExit as LoadPermissions Group By LoadPermissions.nEstelamID) as LoadPermissions On LoadCapacitor.nEstelamID=LoadPermissions.nEstelamID 
                      Where LoadCapacitor.nCarNumKol>LoadPermissions.ReleasedAmount and LoadCapacitor.dDateElam>='" & YourDate1.DateShamsiFull & "' and LoadCapacitor.dDateElam<='" & YourDate2.DateShamsiFull & "' and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.LoadStatus<>4 and LoadCapacitor.LoadStatus<>3
                      Union
                      Select LoadCapacitor.nEstelamID,LoadCapacitor.nCompCode,LoadCapacitor.nCityCode,LoadCapacitor.nCarNumKol as SedimentedAmount,LoadCapacitor.nCarNumKol as AnnouncedAmount,LoadCapacitor.dDateElam from dbtransport.dbo.tbElam as LoadCapacitor
                      Where isnull(LoadCapacitor.dDateExit,'')='' and LoadCapacitor.dDateElam>='" & YourDate1.DateShamsiFull & "' and LoadCapacitor.dDateElam<='" & YourDate2.DateShamsiFull & "' and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.LoadStatus<>4 and LoadCapacitor.LoadStatus<>3) as DataBox
                   Inner Join dbtransport.dbo.tbCompany as TransportCompanies On DataBox.nCompCode=TransportCompanies.nCompCode
                   Inner Join dbtransport.dbo.tbCity as TargetCity On DataBox.nCityCode=TargetCity.nCityCode  
                   Group By StrCityName"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderLoadPermissionIssuedOrderByPriorityReport(YourDate1 As R2StandardDateAndTimeStructure, YourDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourAHSGId As Int64)
            'گزارش مجوزهای صادر شده برای نوبت ها به ترتیب زمان صدور مجوز و اولویت انتخابی
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblLoadPermissionIssuedOrderByPriorityReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "
                        Insert Into R2PrimaryReports.dbo.TblLoadPermissionIssuedOrderByPriorityReport
                          Select Turns.OtaghdarTurnNumber,ltrim(rtrim(Replace(Persons.strPersonFullName ,';',' '))) as PersonFullName,Trucks.strCarNo+'-'+Trucks.strCarSerialNo as Truck,LoadAllocations.LAId,LoadAllocations.Priority,Loads.nEstelamID,
                                 Products.strGoodName,LoadTargets.strCityName,Turns.strExitDate+'-'+strExitTime as LoadPermissionDateTime,TransportCompanies.TCTitle,AnnouncementHallSubGroups.AHSGTitle,Loads.strDescription,Loads.strBarName,Loads.strAddress 
                          from dbtransport.dbo.tbEnterExit as Turns
                            Inner Join dbtransport.dbo.tbElam as Loads On Turns.nEstelamID=Loads.nEstelamID
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On Loads.AHSGId=AnnouncementHallSubGroups.AHSGId 
							Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Loads.nCompCode=TransportCompanies.TCId 
                            Inner Join dbtransport.dbo.tbCity as LoadTargets On Loads.nCityCode=LoadTargets.nCityCode
                            Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode=Products.strGoodCode
                            Inner Join dbtransport.dbo.TbPerson as Persons On Turns.nDriverCode=Persons.nIDPerson
                            Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver
                            Inner Join dbtransport.dbo.TbCar as Trucks On Turns.strCardno=Trucks.nIDCar
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations On Turns.nEnterExitId=LoadAllocations.TurnId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses as LoadAllocationStatuses On LoadAllocations.LAStatusId=LoadAllocationStatuses.LoadAllocationStatusId
                          Where Turns.strExitDate>='" & YourDate1.DateShamsiFull & "' and Turns.strExitDate<='" & YourDate2.DateShamsiFull & "' and Turns.TurnStatus=6 and Turns.LoadPermissionStatus=1 and
                                LoadAllocations.LAStatusId=2 and AnnouncementHallSubGroups.AHSGId=" & YourAHSGId & " 
                          Order By LoadAllocations.DateTimeMilladi"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderClearanceLoadsReport(YourDate1 As R2StandardDateAndTimeStructure, YourDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourAHSGId As Int64)
            'گزارش بار آزاد شده
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblClearanceLoadsReport" : CmdSql.ExecuteNonQuery()
                If YourAHId = Nothing Then
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblClearanceLoadsReport
                                         Select Loads.nBarCode,Products.strGoodName, Count(*),'" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "' from dbtransport.dbo.tbEnterExit as Turns
                                            Inner Join dbtransport.dbo.tbElam  as Loads On Turns.nEstelamID=Loads.nEstelamID 
                                            Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode =Products.strGoodCode 
                                         Where (Turns.strExitDate>='" & YourDate1.DateShamsiFull & "' and Turns.strExitDate<='" & YourDate2.DateShamsiFull & "') and Turns.LoadPermissionStatus=1 and Loads.AHSGId=" & YourAHSGId & "
                                         Group By Loads.nBarCode,Products.strGoodName"
                Else
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblClearanceLoadsReport
                                         Select Loads.nBarCode,Products.strGoodName, Count(*),'" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "' from dbtransport.dbo.tbEnterExit as Turns
                                            Inner Join dbtransport.dbo.tbElam  as Loads On Turns.nEstelamID=Loads.nEstelamID 
                                            Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode =Products.strGoodCode 
                                         Where (Turns.strExitDate>='" & YourDate1.DateShamsiFull & "' and Turns.strExitDate<='" & YourDate2.DateShamsiFull & "') and Turns.LoadPermissionStatus=1 and Loads.AHId=" & YourAHId & "
                                         Group By Loads.nBarCode,Products.strGoodName"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderAnnouncedLoadsReport(YourDate1 As R2StandardDateAndTimeStructure, YourDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourAHSGId As Int64)
            'گزارش بار آزاد شده
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblAnnouncedLoadsReport" : CmdSql.ExecuteNonQuery()
                If YourAHId = Nothing Then
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblAnnouncedLoadsReport
                                         Select Loads.nBarCode,Products.strGoodName, sum(Loads.nCarNumKol) ,'" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "'
	                                     from dbtransport.dbo.tbElam AS Loads
                                             Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode =Products.strGoodCode 
                                         Where Loads.dDateElam>='" & YourDate1.DateShamsiFull & "' and dDateElam<='" & YourDate2.DateShamsiFull & "' and (LoadStatus<>3 and LoadStatus<>4 and LoadStatus<>6)  and Loads.AHSGId=" & YourAHSGId & "
                                         Group By Loads.nBarCode,Products.strGoodName"
                Else
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblAnnouncedLoadsReport
                                         Select Loads.nBarCode,Products.strGoodName, sum(Loads.nCarNumKol) ,'" & YourDate1.DateShamsiFull & "','" & YourDate2.DateShamsiFull & "'
	                                     from dbtransport.dbo.tbElam AS Loads
                                             Inner Join dbtransport.dbo.tbProducts as Products On Loads.nBarcode =Products.strGoodCode 
                                         Where Loads.dDateElam>='" & YourDate1.DateShamsiFull & "' and dDateElam<='" & YourDate2.DateShamsiFull & "' and (LoadStatus<>3 and LoadStatus<>4 and LoadStatus<>6)  and Loads.AHId=" & YourAHId & "
                                         Group By Loads.nBarCode,Products.strGoodName"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderSaleOfSoftwareUserActivationSMSReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblSaleOfSoftwareUserActivationSMSReport"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblSaleOfSoftwareUserActivationSMSReport
                                         Select '" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "','" & YourDateTime1.Time & "','" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.Time & "','" & YourDateTime2.DateShamsiFull & "',Sum(MblghA),Count(*)
                                         from R2Primary.dbo.TblAccounting 
                                         Where DateMilladiA Between '" & _DateTime.GetMilladiDateTimeFromDateShamsiFullFormated(YourDateTime1.DateShamsiFull, YourDateTime1.Time) & "' and '" & _DateTime.GetMilladiDateTimeFromDateShamsiFullFormated(YourDateTime2.DateShamsiFull, YourDateTime2.Time) & "'
                                         And (EEAccountingProcessType=" & R2CoreParkingSystemAccountings.RegisteringSoftwareUserSMSCost & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

End Namespace

Namespace AnnouncementHallsManagement

    Namespace AnnouncementHalls

        'Public Enum AnnouncementHalls
        '    None = 0
        '    General = 1
        '    Zobi = 2
        '    Anbari = 3
        '    Otaghdar = 4
        '    Shahri = 5
        'End Enum

        'Public Enum AnnouncementHallSubGroups
        '    None = 0
        '    Khavar = 1
        '    Otaghdar6 = 2
        '    Otaghdar10 = 3
        '    Anbari = 4
        '    AnbariShemsh = 5
        '    AnbariSaderati = 6
        '    Zobi = 7
        '    ZobiShemsh = 8
        '    ZobiSaderati = 9
        '    AnbarRol = 10
        '    ZobiRol = 11
        '    Shahri = 12
        '    ShahriRol = 13
        '    WareHouseOutShari = 14
        '    WareHouseShari = 15
        'End Enum

        Public Class PayanehClassLibraryStandardAnnouncementHallStructure

            Public Sub New()
                MyBase.New()
                _AHId = 0
                _AHName = String.Empty
            End Sub

            Public Sub New(ByVal YourAHId As Int64, YourAHName As String)
                _AHId = YourAHId
                _AHName = YourAHName
            End Sub


            Public Property AHId As Int64
            Public Property AHName As String

        End Class

        Public Class PayanehClassLibraryStandardAnnouncementHallSubGroupStructure

            Public Sub New()
                MyBase.New()
                _AHSGId = 0
                _AHSGName = String.Empty
            End Sub

            Public Sub New(ByVal YourAHSGId As Int64, YourAHSGName As String)
                _AHSGId = YourAHSGId
                _AHSGName = YourAHSGName
            End Sub


            Public Property AHSGId As Int64
            Public Property AHSGName As String

        End Class

        Public MustInherit Class PayanehClassLibraryAnnouncementHallsManagement
            Public Shared Function GetNSSAnnouncementHall(YourAHId As Int64) As PayanehClassLibraryStandardAnnouncementHallStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls Where AHId=" & YourAHId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallNotFoundException
                    Return New PayanehClassLibraryStandardAnnouncementHallStructure(DS.Tables(0).Rows(0).Item("AHId"), DS.Tables(0).Rows(0).Item("AHTitle"))
                Catch exx As AnnouncementHallNotFoundException
                    Throw exx
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSAnnouncementHallByCarTruckTypeId(YourCarTruckTypeId As Int64) As PayanehClassLibraryStandardAnnouncementHallStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 AHId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationLoaderTypes Where LoaderTypeId=" & YourCarTruckTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallNotFoundException
                    Return GetNSSAnnouncementHall(DS.Tables(0).Rows(0).Item("AHId"))
                Catch exx As AnnouncementHallNotFoundException
                    Throw exx
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class

        Public Class CarTruckTypeRelationAnnouncementHallSubGroupNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شاخص نوع بارگیر با هیچ شاخصی از لیست زیرگروه سالن های اعلام بار مرتبط نیست"
                End Get
            End Property
        End Class

        Public Class CarTruckTypeRelationAnnouncementHallNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شاخص نوع بارگیر با هیچ شاخصی از لیست سالن های اعلام بار مرتبط نیست"
                End Get
            End Property
        End Class

        Public Class AnnouncementHallNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "سالن اعلام بار با اطلاعات مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class AnnouncementHallSubGroupNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زیرگروه سالن اعلام بار با اطلاعات مورد نظر یافت نشد"
                End Get
            End Property
        End Class


    End Namespace

    Namespace AnnouncementHallsMonitoring

        Public Class PayanehClassLibraryMClassElamBarMonitoringManagement

            Public CompanyName As String
            Public BarName As String
            Public TargetName As String
            Public BarDescription As String
            Public Function SetBarInf(ByVal YourSepastbElamnEstelamId As Integer) As Boolean
                Try
                    Dim DaSepas As New SqlClient.SqlDataAdapter : Dim DsSepas As New DataSet
                    DaSepas.SelectCommand = New SqlClient.SqlCommand("select C.strCompName ,P.strGoodName ,CI.strCityName ,E.strDescription  from TbElam as E inner join tbCompany as C on E.nCompCode=C.nCompCode INNER JOIN tbProducts as P on E.nBarcode=P.strGoodCode INNER JOIN tbcity as CI on E.nCitycode=CI.nCityCode where E.nEstelamID=" & YourSepastbElamnEstelamId & "")
                    DaSepas.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                    DsSepas.Tables.Clear()
                    If DaSepas.Fill(DsSepas) = 0 Then
                        Return False
                    Else
                        CompanyName = DsSepas.Tables(0).Rows(0).Item("strCompName")
                        BarName = DsSepas.Tables(0).Rows(0).Item("strGoodName")
                        TargetName = DsSepas.Tables(0).Rows(0).Item("strCityName")
                        BarDescription = DsSepas.Tables(0).Rows(0).Item("strDescription")
                        Return True
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public EtebarNobat As Integer
            Public Function SetEtebarNobat() As Boolean
                Try
                    Dim DaSepas As New SqlClient.SqlDataAdapter : Dim DsSepas As New DataSet
                    DaSepas.SelectCommand = New SqlClient.SqlCommand("select top 1 nenterexitid from dbtransport.dbo.tbEnterExit where bFlagDriver =0 order by strEnterDate asc,strEnterTime asc")
                    DaSepas.SelectCommand.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
                    DsSepas.Tables.Clear()
                    If DaSepas.Fill(DsSepas) = 0 Then
                        Return False
                    Else
                        EtebarNobat = DsSepas.Tables(0).Rows(0).Item("nenterexitid")
                        Return True
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public LastMId As Integer = 0
            Public Function SetLastMId() As Boolean
                Try
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlClient.SqlCommand("select top 1 mid from TblElamBarMonitoring order by MId desc")
                    Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection
                    Ds.Tables.Clear()
                    If Da.Fill(Ds) = 0 Then
                        Return False
                    Else
                        LastMId = Ds.Tables(0).Rows(0).Item("mid")
                        Return True
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try


            End Function
        End Class

        Public Class PayanehClassLibraryMClassAnnouncementHallMonitoringManagement

            Private Shared _DateTime As New R2DateTime
            Public Shared Function GetMonitoringPersianTextMessage() As String
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from TblAnnouncementHallMonitoringBulletin Order By DateTimeMilladi Desc", 1, Ds).GetRecordsCount <> 0 Then
                        Return Ds.Tables(0).Rows(0).Item("TMessage").trim
                    End If
                    Return String.Empty
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub SabtMonitoringPersianTextMessage(YourMonitoringPersianTextMessage As String)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Insert Into TblAnnouncementHallMonitoringBulletin(TMessage,DateTimeMilladi,DateShamsi,Time) Values('" & YourMonitoringPersianTextMessage & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "')"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class


    End Namespace



End Namespace

Namespace CarTruckLoad

    Public Class PayanehClassLibraryMClassCarTruckLoadManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Sub ActivateSedimentalZobi()
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'SedimentZobi', @enabled = 1"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeActivateSedimentalZobi()
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'SedimentZobi', @enabled = 0"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ChangeSedimentalTimeZobi(YourTime As R2StandardDateAndTimeStructure)
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                If _DateTime.ChekTimeSyntax(YourTime.Time) = False Then
                    Throw New Exception("زمان رسوب بار وارد شده نادرست است")
                End If
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "exec msdb..sp_update_schedule  @name = 'SchSedimentZobi', @active_start_time='" + YourTime.Time.Replace(":", "") + "'"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ActivateSedimentalAnbari_Otaghdar()
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari09-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari10-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari11-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari12-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari13-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari14-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari15-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari16-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari17-30', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari18', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar10', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar11', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar12', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar13', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar14', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar15', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar16', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar17', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar18', @enabled = 1" : Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DeActivateSedimentalAnbari_Otaghdar()
            Dim Cmdsql As New SqlClient.SqlCommand
            Cmdsql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Cmdsql.Connection.Open()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari09-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari10-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari11-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari12-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari13-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari14-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari15-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari16-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari17-30', @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Anbari18'   , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar10' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar11' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar12' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar13' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar14' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar15' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar16' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar17' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "exec msdb..sp_update_job  @job_name = 'Sediment_Otaghdar18' , @enabled = 0" : Cmdsql.ExecuteNonQuery()
                Cmdsql.Connection.Close()
            Catch ex As Exception
                If Cmdsql.Connection.State <> ConnectionState.Closed Then Cmdsql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

End Namespace

Namespace HumanManagement

    Namespace Personnel
        Public Class PayanehClassLibraryMClassPersonnelAttendanceManagement

            Public Shared Function GetDSPersonelFingerPrints(YourSalFull As String, YourMonthCode As String) As DataSet
                Dim CmdSqlAttendance As New SqlClient.SqlCommand
                CmdSqlAttendance.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim myMahString As String = YourSalFull.Trim + "/" + YourMonthCode
                    Dim DS As New DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select I.PIdOther,A.DateShamsi,A.Time from R2Primary.dbo.TblPersonelAttendance as A inner join R2Primary.dbo.TblPersonelInf as I on a.PId=i.PId where (Substring(A.DateShamsi,1,7)='" & myMahString & "') AND (Flag=1)", 1, DS).GetRecordsCount = 0 Then 'Flag=1 So Data Not Readed Last And Must Read 
                        Throw New Exception("در محدوده زمانی مورد نظر اطلاعاتی یافت نشد")
                    Else
                        'غیر فعال کردن رکوردهای خوانده شده
                        CmdSqlAttendance.Connection.Open()
                        CmdSqlAttendance.CommandText = "Update R2Primary.dbo.TblPersonelAttendance  Set Flag=0 where Substring(DateShamsi,1,7)='" & myMahString & "'"
                        CmdSqlAttendance.ExecuteNonQuery()
                        CmdSqlAttendance.Connection.Close()
                        Return DS
                    End If
                Catch ex As Exception
                    If CmdSqlAttendance.Connection.State <> ConnectionState.Closed Then CmdSqlAttendance.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub TransferPersonelFingerPrintsIntoClock4(YourSalFull As String, YourMonthCodeFull As String)
                Dim myClockTableName As String = "C" + YourSalFull.Trim + YourMonthCodeFull
                Dim CmdSqlClock4 As New OleDb.OleDbCommand
                Try
                    Dim DS As DataSet = GetDSPersonelFingerPrints(YourSalFull, YourMonthCodeFull)

                    'شروع تراکنش ثبت
                    CmdSqlClock4.Connection = New OleDb.OleDbConnection(R2CoreMClassConfigurationOfComputersManagement.GetConfigString(PayanehClassLibraryConfigurations.Clock4, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0).Replace("*", ";"))
                    CmdSqlClock4.Connection.Open()
                    CmdSqlClock4.Transaction = CmdSqlClock4.Connection.BeginTransaction
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Dim myPIdOther As String = DS.Tables(0).Rows(Loopx).Item("PIdOther").trim
                        Dim myDateShamsi As String = DS.Tables(0).Rows(Loopx).Item("DateShamsi").trim
                        Dim myTimeInteger As Int64 = Mid(DS.Tables(0).Rows(Loopx).Item("Time").trim, 1, 2) * 60 + Mid(DS.Tables(0).Rows(Loopx).Item("Time").trim, 4, 2)
                        CmdSqlClock4.CommandText = "Insert Into " & myClockTableName & " Values('" & myPIdOther & "','" & myDateShamsi & "'," & myTimeInteger & ",1,0,'" & myDateShamsi & "'," & myTimeInteger & ",1,0,0,'Admin')"
                        CmdSqlClock4.ExecuteNonQuery()
                    Next
                    CmdSqlClock4.Transaction.Commit() : CmdSqlClock4.Connection.Close()
                Catch ex As Exception
                    If CmdSqlClock4.Connection.State <> ConnectionState.Closed Then
                        CmdSqlClock4.Transaction.Rollback() : CmdSqlClock4.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub


        End Class



    End Namespace

End Namespace

Namespace SoftwareUserWorkingGroupsManagement

    Public MustInherit Class PayanehClassLibrarySoftwareUserWorkingGroups
        Public Shared ReadOnly SodoorNobat As Int64 = 2
        Public Shared ReadOnly NobatPrint As Int64 = 3
        Public Shared ReadOnly ChangeDriverTruck As Int64 = 4
        Public Shared ReadOnly ChangeCarTruckNumberPlate As Int64 = 5
        Public Shared ReadOnly SedimentedLoadAllocationAndPermission As Int64 = 6
    End Class


End Namespace

Namespace TransportCompanies

    Public Class TransportCompaniesStandardLoadCapacitorLoadStructure


#Region "Constructing Management"

        Public Sub New()
            MyBase.New()
            _nEstelamId = 0
            _StrBarName = String.Empty
            _nCityCode = 0
            _nBarCode = 0
            _nCompCode = 0
            _nTruckType = 0
            _StrAddress = String.Empty
            _nCarNumKol = 0
            _StrPriceSug = String.Empty
            _StrDescription = String.Empty
            _dDateElam = String.Empty
            _dTimeElam = String.Empty
            _nCarNum = 0
        End Sub

        Public Sub New(ByVal YournEstelamId As Int64, YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournCarNumKol As Int64, YourStrPriceSug As String, YourStrDescription As String, YourdDateElam As String, YourdTimeElam As String, YournCarNum As Int64)
            _nEstelamId = YournEstelamId
            _StrBarName = YourStrBarName
            _nCityCode = YournCityCode
            _nBarCode = YournBarCode
            _nCompCode = YournCompCode
            _nTruckType = YournTruckType
            _StrAddress = YourStrAddress
            _nCarNumKol = YournCarNumKol
            _StrPriceSug = YourStrPriceSug
            _StrDescription = YourStrDescription
            _dDateElam = YourdDateElam
            _dTimeElam = YourdTimeElam
            _nCarNum = YournCarNum
        End Sub

#End Region

#Region "Properting Management"

        Public Property nEstelamId As Int64
        Public Property StrBarName As String
        Public Property nCityCode As Int64
        Public Property nBarCode As Int64
        Public Property nCompCode As Int64
        Public Property nTruckType As Int64
        Public Property StrAddress As String
        Public Property nCarNumKol As Int64
        Public Property StrPriceSug As String
        Public Property StrDescription As String
        Public Property dDateElam() As String
        Public Property dTimeElam() As String
        Public Property nCarNum As Int64


#End Region
    End Class

    Public Class PayanehClassLibraryTransportCompaniesManager
        Private _DateTime As New R2DateTime

        Public Function GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId As Int64) As TransportCompaniesStandardLoadCapacitorLoadStructure
            Try
                Dim DS As DataSet = Nothing
                Dim InstanceSqlData = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlData.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * From dbtransport.dbo.TbElam Where nEstelamId=" & YournEstelamId & "", 1, DS).GetRecordsCount <> 0 Then
                    Dim NSS As New TransportCompaniesStandardLoadCapacitorLoadStructure
                    NSS.nEstelamId = YournEstelamId
                    NSS.nTruckType = DS.Tables(0).Rows(0).Item("nTruckType")
                    NSS.StrAddress = DS.Tables(0).Rows(0).Item("StrAddress")
                    NSS.StrBarName = DS.Tables(0).Rows(0).Item("StrBarName")
                    NSS.StrDescription = DS.Tables(0).Rows(0).Item("StrDescription")
                    NSS.StrPriceSug = DS.Tables(0).Rows(0).Item("strPriceSug")
                    NSS.dDateElam = DS.Tables(0).Rows(0).Item("dDateElam")
                    NSS.dTimeElam = DS.Tables(0).Rows(0).Item("dTimeElam")
                    NSS.nBarCode = DS.Tables(0).Rows(0).Item("nBarCode")
                    NSS.nCarNum = DS.Tables(0).Rows(0).Item("nCarNum")
                    NSS.nCarNumKol = DS.Tables(0).Rows(0).Item("nCarNumKol")
                    NSS.nCityCode = DS.Tables(0).Rows(0).Item("nCityCode")
                    NSS.nCompCode = DS.Tables(0).Rows(0).Item("nCompCode")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTransportCompanyName(YourCompanyCode As Int64) As String
            Try
                Dim DS As DataSet = Nothing
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 StrCompName From dbtransport.dbo.TbCompany Where nCompCode=" & YourCompanyCode & "", 3600, DS).GetRecordsCount <> 0 Then
                    Return DS.Tables(0).Rows(0).Item("StrCompName")
                Else
                    Throw New TransportCompanyNotFoundException
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetProductName(YourProductCode As Int64) As String
            Try
                Dim DS As DataSet = Nothing
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 StrGoodName From dbtransport.dbo.TbProducts Where StrGoodCode=" & YourProductCode & "", 3600, DS).GetRecordsCount <> 0 Then
                    Return DS.Tables(0).Rows(0).Item("StrGoodName")
                Else
                    Throw New ProductNotFoundException
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class TransportCompaniesLoadCapacitorLoadManipulation

        Private Shared _DateTime As New R2DateTime

        Public Enum LoadCapacitorLoadStatus
            None = 0
            Registered = 1
            Edited = 2
            Deleted = 3
            EditedDecrement = 4
            EditedIncrement = 5
            Cancelled = 6
            Sedimented = 7
        End Enum

        Public Shared Function IsLoadCapacitorLoadAnnounceTimePassed(YourNSS As TransportCompaniesStandardLoadCapacitorLoadStructure) As Boolean
            Try
                Dim NSSAH As PayanehClassLibraryStandardAnnouncementHallStructure = PayanehClassLibraryAnnouncementHallsManagement.GetNSSAnnouncementHallByCarTruckTypeId(YourNSS.nTruckType)
                Dim ConfigV As String() = Split(PayanehClassLibraryMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(PayanehClassLibraryConfigurations.AnnouncementHallAnnounceTime, NSSAH.AHId, 0), "-")
                Dim CurrentTime As String = _DateTime.GetCurrentTime()
                Dim NSSLoadCapacitorLoad As TransportCompaniesStandardLoadCapacitorLoadStructure = GetNSSTransportCompanyLoadCapacitorLoad(YourNSS.nEstelamId)
                If NSSLoadCapacitorLoad.dTimeElam < ConfigV(0) Then If CurrentTime < ConfigV(0) Then Return False Else Return True
                For Loopx As Int64 = 0 To ConfigV.Length - 1
                    If Loopx < ConfigV.Length - 1 Then
                        If NSSLoadCapacitorLoad.dTimeElam >= ConfigV(Loopx) And NSSLoadCapacitorLoad.dTimeElam < ConfigV(Loopx + 1) Then
                            If CurrentTime < ConfigV(Loopx + 1) Then Return False Else Return True
                        End If
                    End If
                Next
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ISCompanyActive(YourCompanyCode As Int64) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select ViewFlag from DBTransport.dbo.tbcompany Where nCompCode = " & YourCompanyCode & "", 1, DS).GetRecordsCount() = 0 Then Throw New TransportCompanyNotFoundException
                Return DS.Tables(0).Rows(0).Item("ViewFlag")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanies(YourSearchString As String) As List(Of R2StandardStructure)
            Try
                Dim DS As DataSet = Nothing
                Dim Lst As New List(Of R2StandardStructure)
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select nCompCode,StrCompName From dbtransport.dbo.TbCompany Where StrCompName Like '%" & YourSearchString & "%' and ViewFlag=1 Order By StrCompName", 3600, DS).GetRecordsCount() <> 0 Then
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2StandardStructure(DS.Tables(0).Rows(Loopx).Item("nCompCode"), DS.Tables(0).Rows(Loopx).Item("StrCompName")))
                    Next
                Else
                    Return Nothing
                End If
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoads() As DataSet
            Try
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select StrGoodCode,StrGoodName From dbtransport.dbo.TbProducts Order By StrGoodName", 3600, DS)
                Return DS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCities() As DataSet
            Try
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select nCityCode,StrCityName From dbtransport.dbo.TbCity Where Deleted=0 and ViewFlag=1 Order By StrCityName", 3600, DS)
                Return DS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarTypes() As DataSet
            Try
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select snCarType,StrCarName From dbtransport.dbo.TbCarType Where ViewFlag=1 Order By StrCarName", 3600, DS)
                Return DS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanyLoadCapacitorLoads(YourCompanyCode As Int64) As DataSet
            Try
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select nEstelamId,StrBarName,nCityCode,nBarCode,nTruckType,StrAddress,nCarNumKol,StrPriceSug,StrDescription,dDateElam,dTimeElam,nCarNum From dbtransport.dbo.TbElam Where nCompCode=" & YourCompanyCode & " and bFlag=0 and (LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered & "  or LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined & ") Order By nEstelamId ", 1, DS)
                Return DS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanyName(YourCompanyCode As Int64) As String
            Try
                Dim DS As DataSet = Nothing
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 StrCompName From dbtransport.dbo.TbCompany Where nCompCode=" & YourCompanyCode & "", 3600, DS).GetRecordsCount <> 0 Then
                    Return DS.Tables(0).Rows(0).Item("StrCompName")
                Else
                    Throw New TransportCompanyNotFoundException
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetProductName(YourProductCode As Int64) As String
            Try
                Dim DS As DataSet = Nothing
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top 1 StrGoodName From dbtransport.dbo.TbProducts Where StrGoodCode=" & YourProductCode & "", 3600, DS).GetRecordsCount <> 0 Then
                    Return DS.Tables(0).Rows(0).Item("StrGoodName")
                Else
                    Throw New ProductNotFoundException
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId As Int64) As TransportCompaniesStandardLoadCapacitorLoadStructure
            Try
                Dim DS As DataSet = Nothing
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select * From dbtransport.dbo.TbElam Where nEstelamId=" & YournEstelamId & "", 1, DS).GetRecordsCount <> 0 Then
                    Dim NSS As New TransportCompaniesStandardLoadCapacitorLoadStructure
                    NSS.nEstelamId = YournEstelamId
                    NSS.nTruckType = DS.Tables(0).Rows(0).Item("nTruckType")
                    NSS.StrAddress = DS.Tables(0).Rows(0).Item("StrAddress")
                    NSS.StrBarName = DS.Tables(0).Rows(0).Item("StrBarName")
                    NSS.StrDescription = DS.Tables(0).Rows(0).Item("StrDescription")
                    NSS.StrPriceSug = DS.Tables(0).Rows(0).Item("strPriceSug")
                    NSS.dDateElam = DS.Tables(0).Rows(0).Item("dDateElam")
                    NSS.dTimeElam = DS.Tables(0).Rows(0).Item("dTimeElam")
                    NSS.nBarCode = DS.Tables(0).Rows(0).Item("nBarCode")
                    NSS.nCarNum = DS.Tables(0).Rows(0).Item("nCarNum")
                    NSS.nCarNumKol = DS.Tables(0).Rows(0).Item("nCarNumKol")
                    NSS.nCityCode = DS.Tables(0).Rows(0).Item("nCityCode")
                    NSS.nCompCode = DS.Tables(0).Rows(0).Item("nCompCode")
                    Return NSS
                Else
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanyMoneyWallet(YourTransportCompanyCode As Int64) As R2CoreParkingSystemStandardTrafficCardStructure
            Try
                Dim DS As DataSet = Nothing
                Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select CardId From R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationMoneyWallets Where TransportCompanyId=" & YourTransportCompanyCode & " and RelationActive=1", 1, DS).GetRecordsCount <> 0 Then
                    NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(DS.Tables(0).Rows(0).Item("CardId"))
                    Return NSSTerafficCard
                Else
                    Throw New TransportCompanyHaveNotPinCodeException
                End If
            Catch exx As TransportCompanyHaveNotPinCodeException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanyMoneyWalletInventory(YourTransportCompanyCode As Int64) As Int64
            Try
                Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = GetTransportCompanyMoneyWallet(YourTransportCompanyCode)
                Return R2CoreParkingSystem.MoneyWalletManagement.R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTerafficCard)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompaniesDailyMessage(ByRef YourDailyMessageColor As String) As String
            Try
                YourDailyMessageColor = R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 6)
                Return R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 5)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompaniesFirstPageMessages() As String
            Try
                Return R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 7) & " - " & R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 8) & " - " & R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 9)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class TransportCompanyLoadCapacitorLoadEditTimePassedException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "زمان ویرایش اطلاعات بار به پایان رسیده است"
            End Get
        End Property
    End Class

    Public Class TransportCompanyLoadCapacitorLoadNumberOverLimitException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "تعداد بار بیش از حد مجاز است"
            End Get
        End Property
    End Class

    Public Class TransportCompanyLoadCapacitorLoadDeleteTimePassedException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "زمان حذف بار به پایان رسیده است"
            End Get
        End Property
    End Class

    Public Class TransportCompanyLoadCapacitorLoadRegisterTimePassedException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "زمان ثبت بار به پایان رسیده است"
            End Get
        End Property
    End Class

    Public Class TarrifsTransportPriceNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "نرخ حمل یا تعرفه برای مسیر مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class TransportCompanyNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کد حمل و نقل شرکت مورد نظر یافت نشد"
            End Get
        End Property
    End Class

    Public Class TransportCompanyISNotActiveException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "کد شرکت حمل و نقل مورد نظر غیرفعال است"
            End Get
        End Property
    End Class

    Public Class ProductNotFoundException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "نوع بار مورد نظر در سیستم ثبت نشده است"
            End Get
        End Property
    End Class

    Public Class TransportCompanyHaveNotPinCodeException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "برای شرکت حمل و نقل مورد نظر پین کد تعریف نشده است"
            End Get
        End Property
    End Class

    Public Class TransportCompanynCarNumKolCanNotBeZeroException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "مقادیر صفر و کمتر از آن برای تعداد بار مجاز نیست"
            End Get
        End Property
    End Class


End Namespace

Namespace LoadNotification.LoadPermission

    Public Class PayanehClassLibraryLoadPermissionManager
        Private _DateTime As New R2DateTime

        Public Function GetLoadPermissionInf(YournEstelamId As Int64, YourTurnId As Int64) As DataStruct
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 StrExitDate,StrExitTime,nUserIdExit From DBTransport.dbo.TbEnterExit Where nEnterExitId=" & YourTurnId & " and nEstelamId=" & YournEstelamId & "")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Throw New LoadPermissionNotExistException
                Dim LoadPermissionDataStruct As New DataStruct
                LoadPermissionDataStruct.Data1 = IIf(Ds.Tables(0).Rows(0).Item("StrExitDate").Equals(System.DBNull.Value), String.Empty, Ds.Tables(0).Rows(0).Item("StrExitDate").trim)
                LoadPermissionDataStruct.Data2 = IIf(Ds.Tables(0).Rows(0).Item("StrExitTime").Equals(System.DBNull.Value), String.Empty, Ds.Tables(0).Rows(0).Item("StrExitTime").trim)
                LoadPermissionDataStruct.Data3 = IIf(Ds.Tables(0).Rows(0).Item("nUserIdExit").Equals(System.DBNull.Value), String.Empty, DirectCast(R2CoreMClassSoftwareUsersManagement.GetNSSUser(Ds.Tables(0).Rows(0).Item("nUserIdExit")), R2CoreStandardSoftwareUserStructure).UserName)
                Return LoadPermissionDataStruct
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Public NotInheritable Class LoadNotificationLoadPermissionManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetHazinehSedimentLoadPermission(YournEstelamId As Int64) As Int64
            Try
                Dim NSS As TransportCompaniesStandardLoadCapacitorLoadStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)
                If NSS.nTruckType = 505 Or NSS.nTruckType = 455 Or NSS.nTruckType = 700 Then
                    Return R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0) + R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 1)
                ElseIf NSS.nTruckType <> 505 And NSS.nTruckType <> 455 And NSS.nTruckType <> 700 Then
                    Return R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0) + R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 2)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Shared Function TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(YourComapnyCode As Int64, YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String, YourNSSUser As R2CoreStandardSoftwareUserStructure) As Int64
        '    Try
        '        ''کنترل حداقل موجودی در کیف پول شرکت حمل و نقل
        '        'Dim NSSMoneyWallet As R2CoreParkingSystemStandardTrafficCardStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyMoneyWallet(YourComapnyCode)
        '        'If R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSMoneyWallet) < GetHazinehSedimentLoadPermission(YournEstelamId) Then
        '        '    Throw New TransportCompanyMoneyWalletInventoryIsLowException
        '        'End If

        '        'صدور نوبت برای ناوگان باری
        '        'در صورتی که راننده خودش نوبت داشته باشد از همان استفاده می شود
        '        Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(YourCarTruckSmartCardNo, YourNSSUser)
        '        Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
        '        Dim TurnShouldBeUseInTransportCompany As Boolean = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 1)

        '        Dim TurnId As Int64
        '        If TurnShouldBeUseInTransportCompany Then
        '            Try
        '                TurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(NSSCarTruck.NSSCar).nEnterExitId
        '            Catch exx As GetNobatException
        '                TurnId = CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatKiosk(NSSCarTruck, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
        '            Catch ex As Exception
        '                Throw ex
        '            End Try
        '        Else
        '            TurnId = CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatKiosk(NSSCarTruck, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
        '        End If


        '        Dim NSSCarTruckNobat As R2StandardCarTruckNobatStructure = PayanehClassLibraryMClassCarTruckNobatManagement.GetNSSCarTruckNobat(TurnId)

        '        'صدور مجوز بارگیری برای ناوگان باری
        '        Try
        '            TransportCompanyLoadCapacitorSedimentLoadPermisiion(TurnId, YournEstelamId, PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(NSSCarTruck.NSSCar.nIdCar)), R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
        '        Catch ex As Exception
        '            'درصورتی که صدور مجوز با مشکل مواجه شود نوبت صادرشده باطل می گردد
        '            PayanehClassLibraryMClassCarTruckNobatManagement.SetbFlagDriverToTrue(TurnId, False)
        '            Throw ex
        '        End Try

        '        ''اکانتینگ کیف پول
        '        ''محاسبه هزینه شرکت با توجه به نوع ناوگان باری
        '        ''اگر از نوبت موجود راننده استفاده شود اکانت برای کیف پول شرکت ثبت نمی شود
        '        'If NSSCarTruckNobat.nUserIdEnter = R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId Then
        '        '    Dim HazinehAS As Int64 = 0
        '        '    Dim NSS As TransportCompaniesStandardLoadCapacitorLoadStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)
        '        '    If NSS.nTruckType = 505 Or NSS.nTruckType = 455 Or NSS.nTruckType = 700 Or NSS.nTruckType = 605 Then
        '        '        HazinehAS = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 1)
        '        '    Else
        '        '        HazinehAS = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 2)
        '        '    End If
        '        '    'شرکت
        '        '    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSMoneyWallet, BagPayType.MinusMoney, HazinehAS, R2CoreParkingSystemAccountings.SherkatHazinehSodoorMojavezKiosk)
        '        '    'انجمن
        '        '    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSMoneyWallet, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0), R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk)
        '        'End If

        '        Return TurnId

        '    Catch ex As Exception
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try

        'End Function

        Public Shared Sub TransportCompanyLoadCapacitorSedimentLoadPermisiion(YourTurnId As Int64, YournEstelamId As Int64, YourNSSDriverTruck As R2StandardDriverTruckStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim NSS As TransportCompaniesStandardLoadCapacitorLoadStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select nCarNum from DBTransport.dbo.TbElam  with (tablockx) Where nEstelamId=" & YournEstelamId & ""
                Dim nCarNum As Int64 = CmdSql.ExecuteScalar()
                If nCarNum < 1 Then Throw New TransportCompanyCapacitorLoadnCarNumIslowException
                CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set nCarNum=nCarNum-1,dDateExit='" & _DateTime.GetCurrentDateShamsiFull() & "',dTimeExit='" & _DateTime.GetCurrentTime() & "' Where nEstelamId=" & YournEstelamId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update DBTransport.dbo.TbEnterExit Set StrBarnameNo=1,StrExitDate='" & _DateTime.GetCurrentDateShamsiFull() & "',StrExitTime='" & _DateTime.GetCurrentTime() & "',nCityCode=" & NSS.nCityCode & ",nBarCode=" & NSS.nBarCode & ",bEnterExit=1,nUserIdExit=" & YourUserNSS.UserId & ",nCompCode=" & NSS.nCompCode & ",StrDriverName='" & YourNSSDriverTruck.NSSDriver.StrPersonFullName & "',nDriverCode=" & YourNSSDriverTruck.NSSDriver.nIdPerson & ",bflag=1,bflagDriver=1,TurnStatus=" & R2CoreTransportationAndLoadNotification.Turns.TurnStatuses.UsedLoadPermissionRegistered & ",nEstelamId=" & NSS.nEstelamId & ",nCarNum=" & NSS.nCarNum - 1 & ",LoadPermissionStatus=" & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.Registered & " Where nEnterExitId=" & YourTurnId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetLoadPermissionInf(YournEstelamId As Int64, YourTurnId As Int64) As DataStruct
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 StrExitDate,StrExitTime,nUserIdExit From DBTransport.dbo.TbEnterExit Where nEnterExitId=" & YourTurnId & " and nEstelamId=" & YournEstelamId & "")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                If Da.Fill(Ds) = 0 Then Throw New LoadPermissionNotExistException
                Dim LoadPermissionDataStruct As New DataStruct
                LoadPermissionDataStruct.Data1 = IIf(Ds.Tables(0).Rows(0).Item("StrExitDate").Equals(System.DBNull.Value), String.Empty, Ds.Tables(0).Rows(0).Item("StrExitDate").trim)
                LoadPermissionDataStruct.Data2 = IIf(Ds.Tables(0).Rows(0).Item("StrExitTime").Equals(System.DBNull.Value), String.Empty, Ds.Tables(0).Rows(0).Item("StrExitTime").trim)
                LoadPermissionDataStruct.Data3 = IIf(Ds.Tables(0).Rows(0).Item("nUserIdExit").Equals(System.DBNull.Value), String.Empty, DirectCast(R2CoreMClassSoftwareUsersManagement.GetNSSUser(Ds.Tables(0).Rows(0).Item("nUserIdExit")), R2CoreStandardSoftwareUserStructure).UserName)
                Return LoadPermissionDataStruct
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Public Shared Sub CarTruckRelationDriverTruck(YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String, YourNSSUser As R2CoreStandardSoftwareUserStructure)
        '    Dim CmdSql As New SqlClient.SqlCommand
        '    CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
        '    Try
        '        'SqlInjectionPrevention
        '        Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
        '        InstanceSQLInjectionPrevention.GeneralAuthorization(YourCarTruckSmartCardNo)
        '        InstanceSQLInjectionPrevention.GeneralAuthorization(YourDriverTruckSmartCardNo)

        '        If YourDriverTruckSmartCardNo = String.Empty Or YourCarTruckSmartCardNo = String.Empty Then Throw New Exception("شماره هوشمند راننده یا ناوگان نادرست است")
        '        Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(YourCarTruckSmartCardNo, YourNSSUser)
        '        Dim NSSDriverTruck As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(YourDriverTruckSmartCardNo)
        '        CmdSql.Connection.Open()
        '        CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
        '        CmdSql.CommandText = "Insert into Dbtransport.dbo.TbCarAndPerson(nIdCar,nIdPerson,snRelation,dDate,RelationTimeStamp) Values(" & NSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",2,'" & _DateTime.GetCurrentDateShamsiFull() & "','2015-01-01 00:00:00.000')"
        '        Try
        '            CmdSql.ExecuteNonQuery()
        '        Catch ex As Exception
        '            CmdSql.CommandText = "Update Dbtransport.dbo.TbCarAndPerson Set nIdPerson=" & NSSDriverTruck.NSSDriver.nIdPerson & ",dDate='" & _DateTime.GetCurrentDateShamsiFull() & "'  Where (nIdCar=" & NSSCarTruck.NSSCar.nIdCar & ") and snRelation=2"
        '            CmdSql.ExecuteNonQuery()
        '        End Try

        '        CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

        '    Catch ex As Exception
        '        If CmdSql.Connection.State <> ConnectionState.Closed Then
        '            CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
        '        End If
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message + vbCrLf + "خطا ممکن است به دلیل تداخل در ثبت اطلاعات پایه راننده و ناوگان باشد")
        '    End Try
        'End Sub

        Public Shared Sub ResuscitationSedimentedLoadbynEstelamId(YournEstelamId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select nCarNum from DBTransport.dbo.tbelam  Where nEstelamId=" & YournEstelamId & " and nCarNum>0", 1, DS).GetRecordsCount() = 0 Then
                    Throw New ResuscitationSedimentedLoadException
                End If

                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update DBTransport.dbo.tbelam Set bflag=0 Where nEstelamId=" & YournEstelamId & " and nCarNum>0"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetCapacitorLoadLoadByCarTruckLastLoadPermissionByCarTruck(YourNSSCarTruck As R2StandardCarTruckStructure) As TransportCompaniesStandardLoadCapacitorLoadStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "select Top 1 nEstelamID  from dbtransport.dbo.tbEnterExit Where (strCardno = " & YourNSSCarTruck.NSSCar.nIdCar & ")  and isnull(nestelamid,0)<>0 Order By nEnterExitId Desc", 1, DS).GetRecordsCount() = 0 Then Throw New CarTruckHasNotAnyLoadPermissionException
                Return TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(DS.Tables(0).Rows(0).Item("nEstelamID"))
            Catch ex As CarTruckHasNotAnyLoadPermissionException
                Throw ex
            Catch ex As GetNSSException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub DoControlforTruckPresentInParkingAndLastLoadPermission(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
            Try
                Dim InstanceLoadCapacitorLoad = New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure
                Dim InstanceLoadPermission = New R2CoreTransportationAndLoadNotificationInstanceLoadPermissionManager
                'بررسی شرط حضور ناوگان باری در پارکینگ هنگام صدور نوبت با توجه به پیکربندی برای هر زیرگروه اعلام بار
                Dim NSSLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = Nothing
                Try
                    NSSLoad = InstanceLoadPermission.GetTruckLastLoadWhichPermissioned(YourNSSTruck)
                Catch ex As TruckHasNotAnyLoadPermissionException
                    'برای ناوگان هیچ مجوزی تاکنون صادر نشده است و بنابراین باید در پایانه حضور داشته باشد
                    Dim NSSTerraficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                    If R2CoreParkingSystem.EnterExitManagement.R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(NSSTerraficCard, Nothing) = R2EnterExitRequestType.EnterRequest Then Throw New CarIsNotPresentInParkingException
                    Return
                Catch ex As CarIsNotPresentInParkingException
                    Throw ex
                Catch ex As RelatedTerraficCardNotFoundException
                    Throw ex
                Catch ex As TerraficCardNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try

                'برای ناوگان قبلا مجوز صادر شده است و باید کنترل شود بار چه نوعی بوده براساس کانفیگ تصمیم گیری شود
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsActiveTurnRegisteringIssueControlforAnnouncementHall(NSSLoad.AHId, NSSLoad.AHSGId) Then
                    Dim NSSTerraficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                    If R2CoreParkingSystem.EnterExitManagement.R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(NSSTerraficCard, Nothing) = R2EnterExitRequestType.EnterRequest Then Throw New CarIsNotPresentInParkingException
                End If
            Catch ex As RelatedTerraficCardNotFoundException
                Throw ex
            Catch ex As TerraficCardNotFoundException
                Throw ex
            Catch ex As CarIsNotPresentInParkingException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub



    End Class

    Public Class TransportCompanyMoneyWalletInventoryIsLowException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "موجودی کبف پول شرکت حمل و نقل کافی نیست"
            End Get
        End Property
    End Class

    Public Class TransportCompanyCapacitorLoadnCarNumIslowException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "موجودی بار به صفر رسیده است"
            End Get
        End Property
    End Class

    Public Class LoadPermissionNotExistException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "مجوز بارگیری با مشخصات مورد نظر ثبت نشده است"
            End Get
        End Property
    End Class

    Public Class ResuscitationSedimentedLoadException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "بار رسوبی با کد استعلام مورد نظر وجود ندارد" + vbCrLf + "ممکن است تعداد بار به صفر رسیده باشد"
            End Get
        End Property
    End Class

    Public Class CarTruckHasNotAnyLoadPermissionException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "برای ناوگان مورد نظر تاکنون هیچ مجوزی در سالن اعلام بار برای بارگیری صادر نشده است"
            End Get
        End Property
    End Class



End Namespace

Namespace TruckersAssociationControllingMoneyWallet

    Public MustInherit Class TruckersAssociationControllingMoneyWalletManagement

        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetNSSMoneyWallet() As R2CoreParkingSystemStandardTrafficCardStructure
            Try

                Return R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 4))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared _ControllingMoneyWalletAccountingExcecutedFlag As Boolean = False
        Public Shared Sub ControllingMoneyWalletAccounting(YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceConfigurations = New R2CoreInstanceConfigurationManager
                Dim InstancePersianCallendar = New R2CoreInstanceDateAndTimePersianCalendarManager
                'کنترل زمان اجرای فرآیند بر اساس کانفیگ
                Dim TimeOfDay = _DateTime.GetTimeOfDate(Now)
                If TimeOfDay >= "00:00:00" And TimeOfDay <= "00:05:00" Then
                    _ControllingMoneyWalletAccountingExcecutedFlag = False
                    Return
                ElseIf TimeOfDay < InstanceConfigurations.GetConfigString(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 6) Then
                    Return
                Else
                End If
                'این فرآیند در روز فقط باید یکبار اجرا گردد و نه بیشتر
                'خط کد زیر یعنی فرآیند امروز قبلا در بازه معین اجرا یکبار اجرا شده است
                If _ControllingMoneyWalletAccountingExcecutedFlag Then Return
                'طبق کانفیگ سیستم کلا اکانتینگ فعال باشد یا نه
                If Not InstanceConfigurations.GetConfigBoolean(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 1) Then Return
                'آغاز فرآیند اکانتینگ
                'آخرین اکانت ثبت شده
                Dim NSSLastAccounting = R2CoreParkingSystemMClassAccountingManagement.GetNSSLastAccounting(R2CoreParkingSystemAccountings.TruckersAssociationControllingMoneyWallet)
                'امروز یک مرتبه اکانت ثبت شده پس نیازی به ثبت مجدد نیست
                If NSSLastAccounting.DateShamsiA = _DateTime.GetCurrentDateShamsiFull Then Return
                Dim Amount As Int64 = PayanehClassLibraryMClassReportsManagement.GetAmountforTruckersAssociationControllingMoneyWallet()
                'کسر هزینه شرکت خودگردان
                If R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 2) Then
                    Dim CostofSelfGoverning = R2CoreMClassConfigurationManagement.GetConfigInt32(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 3)
                    Amount = Amount * (100 / (100 + CostofSelfGoverning))
                End If
                'ثبت اکانت
                Dim NSSControllingMoneyWallet = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 4))
                R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSControllingMoneyWallet, BagPayType.MinusMoney, Amount, R2CoreParkingSystemAccountings.TruckersAssociationControllingMoneyWallet, YourNSSUser)
                _ControllingMoneyWalletAccountingExcecutedFlag = True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DoControlforControllingMoneyWallet()
            Try
                Dim InstanceConfigurations = New R2CoreInstanceConfigurationManager
                Dim NSS = TruckersAssociationControllingMoneyWalletManagement.GetNSSMoneyWallet()
                Dim Amount = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSS)
                If Amount < R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TruckersAssociationControllingMoneyWallet, 5) Then
                    Throw New TruckersAssociationControllingMoneyWalletCriticalAmountReachedException
                End If
            Catch ex As TruckersAssociationControllingMoneyWalletCriticalAmountReachedException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Exceptions
        Public Class TruckersAssociationControllingMoneyWalletCriticalAmountReachedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کیف پول کنترلی کامیونداران نیاز به شارژ دارد"
                End Get
            End Property
        End Class

    End Namespace




End Namespace

Namespace RequesterManagement

    Public MustInherit Class PayanehClassLibraryRequesters
        Inherits R2CoreTransportationAndLoadNotificationRequesters

        Public Shared ReadOnly AutomaticTurnRegistering As Int64 = 5
        Public Shared ReadOnly FrmcEnterExit As Int64 = 6
        Public Shared ReadOnly FrmcTurnRegisterRequest As Int64 = 7
        Public Shared ReadOnly UCComputerMessageEmergencyTurnRegisterRequestConfirmation As Int64 = 8
        Public Shared ReadOnly UCComputerMessageProducerRealTimeTurnRegisterRequest As Int64 = 9
        Public Shared ReadOnly GetTurnofKiosk As Int64 = 10
        Public Shared ReadOnly UCResuscitationReserveTurn As Int64 = 11

    End Class


End Namespace































































































































































































































































































