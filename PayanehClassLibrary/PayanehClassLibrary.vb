
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
Imports R2Core.SMSSendAndRecieved
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

Namespace Logging

    Public MustInherit Class PayanehClassLibraryLogType
        Inherits R2CoreLogType

        Public Shared ReadOnly Property CarTruckUpdateInfSuccess As Int64 = 17
        Public Shared ReadOnly Property CarTruckUpdateInfNotSuccess As Int64 = 18

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

    Public Enum TurnStatus
        None = 0
        Registered = 1
        CancelledUser = 2
        CancelledUserUnderScore = 3
        CancelledSystem = 4
        UsedLoadPermissionRegistered = 5
        UsedLoadAllocationRegistered = 6
        ResuscitationLoadPermissionCancelled = 7
        ResuscitationLoadAllocationCancelled = 8
        ResuscitationUser = 9
    End Enum

    Public Class R2StandardCarTruckNobatStructure
        Private _nEnterExitId As Int64
        Private _EnterDate As String
        Private _EnterTime As String
        Private _NSSDriverTruck As R2StandardDriverTruckStructure
        Private _bFlagDriver As Boolean
        Private _NUserIdEnter As Int64
        Private _OtaghdarTurnNumber As String
        Private _StrCardNo As Int64


        Public Sub New()
            MyBase.New()
            _nEnterExitId = 0 : _EnterDate = "" : _EnterTime = "" : _NSSDriverTruck = Nothing : _bFlagDriver = True : _NUserIdEnter = 0 : _OtaghdarTurnNumber = "" : _StrCardNo = 0
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSDriverTruck As R2StandardDriverTruckStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64)
            _nEnterExitId = YournEnterExitId
            _EnterDate = YourEnterDate
            _EnterTime = YourEnterTime
            _NSSDriverTruck = YourNSSDriverTruck
            _bFlagDriver = YourbFlagDriver
            _NUserIdEnter = YournUserIdEnter
            _OtaghdarTurnNumber = YourOtaghdarTurnNumber
            _StrCardNo = YourStrCardNo
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
        Public Property StrCardNo() As Int64
            Get
                Return _StrCardNo
            End Get
            Set(ByVal Value As Int64)
                _StrCardNo = Value
            End Set
        End Property




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

        Public Shared Function GetListOfAllnEnterExitId(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) As List(Of String)
            Try
                Dim SeqTKeyWord As String = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(YourNSSAnnouncementHall).SequentialTurnKeyWord
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "
                       Select Substring(Turns.OtaghdarTurnNumber,7,6) as OtaghdarTurnNumber,Turns.StrEnterDate from dbtransport.dbo.TbEnterExit as Turns
                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCars On Turns.strCardno=AHSGRCars.CarId 
                        Where bFlagDriver=0 and AHSGRCars.AHSGId=" & YourNSSAnnouncementHallSubGroup.AHSGId & " and Substring(OtaghdarTurnNumber,1,1)='" & SeqTKeyWord & "' and AHSGRCars.RelationActive=1 Order By nEnterExitId", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New GetDataException
                End If
                Dim Lst As List(Of String) = New List(Of String)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(CType(Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber"), String) & "  -  " & CType(Ds.Tables(0).Rows(Loopx).Item("StrEnterDate"), String))
                Next
                Return Lst
            Catch exx As GetDataException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetCarTravellength(YournIdCar As Int64) As Int64
            Try
                Dim Da As New SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 * from dbtransport.dbo.TbEnterExit as E 
                                                     Inner join TbCity as C on E.nCityCode=C.nCityCode 
                                                   Where E.StrCardNo=" & YournIdCar & " and E.TurnStatus=" & R2CoreTransportationAndLoadNotification.Turns.TurnStatuses.UsedLoadPermissionRegistered & "  
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
                Return NSS
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNobat(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, ByRef YourMblgh As Int64, YourTurnRegisterRequestId As Int64, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                'احراز کد ناوگان از رابطه کارت و پلاک
                Dim nIDcar As Int64
                Dim NSSCarTruck As R2StandardCarTruckStructure
                Try
                    nIDcar = R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(YourTrafficCard.CardId)
                    NSSCarTruck = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(nIDcar)
                Catch exx As GetDataException
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات کارت تردد و پلاک ناوگان متصل نیستند", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات کارت تردد و پلاک ناوگان متصل نیستند")
                End Try

                'آیا تسلسل نوبت مرتبط با ناوگان باری فعال است
                Dim NSSSeqT As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(NSSCarTruck.NSSCar.nIdCar))
                If Not NSSSeqT.Active Then
                    Throw New SequentialTurnIsNotActiveException
                End If

                'احراز راننده ناوگان از رابطه ناوگان راننده
                Dim nIdPerson As Int64
                Dim NSSDriverTruck As R2StandardDriverTruckStructure
                Try
                    nIdPerson = R2CoreParkingSystemMClassCars.GetnIdPersonFirst(nIDcar)
                    NSSDriverTruck = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(nIdPerson)
                Catch exx As GetDataException
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات راننده متصل به ناوگان مشخص نیست", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات راننده متصل به ناوگان مشخص نیست")
                End Try

                'کنترل تانکر مخزندار
                If PayanehClassLibraryMClassCarTruckNobatManagement.IsCarTruckTankTreiler(NSSCarTruck) Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "ناوگان موردنظر در لیست تانکرهای مخزندار قرار دارد", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatExceptionCarTruckIsTankTreiler
                End If

                'کنترل دارابودن نوبت در آنلاین
                Dim TWSMessage As String = TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.ExistNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                If TWSMessage.Trim <> String.Empty Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "صدور نوبت امکان پذیر نیست" + vbCrLf + TWSMessage, YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + TWSMessage)
                End If

                'کنتر دارا بودن نوبت فعال قبلی
                Dim NSSTruck = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(NSSCarTruck.NSSCar.nIdCar)
                If R2CoreTransportationAndLoadNotificationMClassTurnsManagement.ExistActiveTurn(NSSTruck, NSSSeqT) Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "ناوگان نوبت دارد", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatExceptionCarTruckHasNobat
                End If

                'کنترل اینکه راننده نوبت دیگر نداشته باشد
                If IsDriverHasNobat(nIdPerson) = True Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "راننده با ناوگان دیگر نوبت دارد", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "راننده با ناوگان دیگر نوبت دارد")
                End If

                'کنترل طول سفر
                Try
                    Dim TravelLength As Int64 = GetCarTravellength(nIDcar)
                    Dim NSSLOadCapacitor As TransportCompaniesStandardLoadCapacitorLoadStructure = LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.GetCapacitorLoadLoadByCarTruckLastLoadPermissionByCarTruck(NSSCarTruck)
                    If TravelLength < 0 Then
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, GetCarTravellengthFormated(nIDcar) + vbCrLf + "طول سفر ناوگان به پایان نرسیده است", YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                        Throw New CarTruckTravelLengthNotOverYetException(GetCarTravellengthFormated(nIDcar))
                    End If
                Catch exx As CarTruckHasNotAnyLoadPermissionException
                End Try

                'شاخص درخواست صدور نوبت
                Dim NSSTRR = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId)

                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                'شاخص فرعی نوبت برای انواع ناوگان متفاوت است و سیاست متفاوت دارد
                'در چاپ قبض نوبت صفرهای اضافه نوبت فرعی حذف می گردند
                'Example -> Tereilli Start : T1397/000001  
                'Example -> Otaghdar Start : O1397/000001  
                'Example -> Shahri Start : S1397/000001  
                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,10) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                SequentialTurnId = CmdSql.ExecuteScalar + 1
                SequentialTurnId_ = NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()

                'این خطوط بعد از حذف سپاس باید حذف گردند فعلا موقتی هستند
                CmdSql.CommandText = "Select top 1 nIdNobat from dbtransport.dbo.tbGhabz with (tablockx) order by nIdNobat desc"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('dbtransport.dbo.TbGhabz')"
                Dim mynIdGhabz As Int64 = CmdSql.ExecuteScalar + 1

                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus) Values(" & mynIdEnterExit & "," & NSSCarTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTRR.Description & "',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',0,0," & NSSDriverTruck.NSSDriver.nIdPerson & "," & mynIdGhabz & ",'" & SequentialTurnId_ & "'," & TurnStatus.Registered & "," & R2CoreTransportationAndLoadNotification.LoadPermission.R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ")"
                CmdSql.ExecuteNonQuery()

                'این خطوط بعد از حذف سپاس باید حذف گردند فعلا موقتی هستند
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbGhabz(nIdNobat,nIdCar,nIdDriver,StrDateEnter,StrDateExit,StrDateShEnter,StrDateShExit,StrTimeEnter,StrTimeExit,StrBarcodeNo,StrTime,IdUserEnter,IdUserExit,nSumPaid,nSumPaidEnter,nSumPaidExit,FlagA,snEnterAim,bEbtal) Values(" & mynIdEnterExit & "," & NSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentTime() & "','" & YourTrafficCard.CardNo & "','" & _DateTime.GetCurrentTime() & "'," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,0,0,1,1,0)"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbGhabz(nIdNobat,nIdCar,nIdDriver,StrDateEnter,StrDateExit,StrDateShEnter,StrDateShExit,StrTimeEnter,StrTimeExit,StrBarcodeNo,StrTime,IdUserEnter,IdUserExit,nSumPaid,nSumPaidEnter,nSumPaidExit,FlagA,snEnterAim,bEbtal) Values(0," & NSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentTime() & "','" & YourTrafficCard.CardNo & "','" & _DateTime.GetCurrentTime() & "'," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,0,0,1,1,0)"
                CmdSql.ExecuteNonQuery()

                'هزینه نوبت انجمن و شرکت
                YourMblgh = GetSherkatHazinehNobatMblgh(YourTrafficCard)
                If YourMblgh > 0 Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourTrafficCard, BagPayType.MinusMoney, YourMblgh, R2CoreParkingSystemAccountings.SherkatHazinehNobat, YourUserNSS)
                If YourTrafficCard.CardType = TerafficCardType.Tereili Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, YourUserNSS)
                If YourTrafficCard.CardType = TerafficCardType.SixCharkh Or YourTrafficCard.CardType = TerafficCardType.TenCharkh Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, YourUserNSS)
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

                'ارسال نوبت ناوگان برای سیستم آنلاین
                If YourTrafficCard.CardType = TerafficCardType.Tereili And R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TWS, 0) Then
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.AddNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                    'R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "ارسال نوبت ناوگان برای سیستم آنلاین", YourTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassSoftwareUsersManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                End If
                If YourTrafficCard.CardType = TerafficCardType.SixCharkh Or YourTrafficCard.CardType = TerafficCardType.TenCharkh And R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.TWS, 1) Then
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.AddNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                    'R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "ارسال نوبت ناوگان برای سیستم آنلاین", YourTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassSoftwareUsersManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                End If

                Return mynIdEnterExit
            Catch ex As TruckRelatedSequentialTurnNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As TurnRegisterRequestNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw ex
            Catch exxxxxxx As CarIsNotPresentInParkingException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxxxxxx
            Catch exxxxxxx As GetNobatExceptionCarTruckIsTankTreiler
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxxxxxx
            Catch exxxxxx As CarTruckTravelLengthNotOverYetException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxxxxx
            Catch exxxxx As GetNSSException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxxxx
            Catch exxxx As GetNobatExceptionCarTruckHasNobat
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxxx
            Catch exxx As GetNobatExceptionCarTruckIsShahri
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exxx
            Catch exx As GetNobatException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                Throw exx
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback()
                    CmdSql.Connection.Close()
                End If
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "بروز خطای اساسی هنگام صدور نوبت" + ex.Message, YourTrafficCard.CardNo, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNewReserveTurn(YourTurnRegisterRequestId As Int64, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
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

                'شاخص فرعی نوبت برای انواع ناوگان متفاوت است و سیاست متفاوت دارد
                'در چاپ قبض نوبت صفرهای اضافه نوبت فرعی حذف می گردند
                'Example -> Tereilli Start : T1397/000001  
                'Example -> Otaghdar Start : O1397/000001  
                'Example -> Shahri Start : S1397/000001  
                'Example -> None Start : N1399/000001  
                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,10) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                SequentialTurnId = CmdSql.ExecuteScalar + 1
                SequentialTurnId_ = NSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()

                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus) Values(" & mynIdEnterExit & "," & NSSTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTRR.Description & "',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',1,1," & NSSDriverTruck.NSSDriver.nIdPerson & ",0,'" & SequentialTurnId_ & "'," & TurnStatus.CancelledSystem & "," & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ")"
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

        Public Shared Function GetNobatKiosk(YourNSSCarTruck As R2StandardCarTruckStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                'احراز راننده ناوگان از رابطه ناوگان راننده
                Dim nIdPerson As Int64
                Dim NSSDriverTruck As R2StandardDriverTruckStructure
                Try
                    nIdPerson = R2CoreParkingSystemMClassCars.GetnIdPersonFirst(YourNSSCarTruck.NSSCar.nIdCar)
                    NSSDriverTruck = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(nIdPerson)
                Catch exx As GetDataException
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات راننده متصل به ناوگان مشخص نیست", String.Empty, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    Throw New GetNobatException("صدور نوبت امکان پذیر نیست" + vbCrLf + "مشخصات راننده متصل به ناوگان مشخص نیست")
                End Try

                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                'شاخص فرعی نوبت برای انواع ناوگان متفاوت است و سیاست متفاوت دارد
                'Example -> Tereilli Start : T1397/000001  
                'Example -> Otaghdar Start : O1397/000001  
                'در چاپ قبض نوبت صفرهای اضافه نوبت فرعی حذف می گردند
                Dim TereilliNobatId As Int64
                Dim TereilliNobatId_ As String
                Dim OtaghdarNobatId As Int64
                Dim OtaghdarNobatId_ As String
                Dim NSSAnnouncemenetHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByLoaderTypeId(YourNSSCarTruck.NSSCar.snCarType)
                If NSSAnnouncemenetHall.AHId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Zobi Or NSSAnnouncemenetHall.AHId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Anbari Then
                    CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,10) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='T" + _DateTime.GetCurrentSalShamsiFull() + "' order by OtaghdarTurnNumber desc"
                    TereilliNobatId = CmdSql.ExecuteScalar + 1
                    TereilliNobatId_ = "T" + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - TereilliNobatId.ToString().Trim().Length) + TereilliNobatId.ToString().Trim()
                ElseIf NSSAnnouncemenetHall.AHId <> AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Zobi And NSSAnnouncemenetHall.AHId <> AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Anbari Then
                    CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,10) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='O" + _DateTime.GetCurrentSalShamsiFull() + "' order by OtaghdarTurnNumber desc"
                    OtaghdarNobatId = CmdSql.ExecuteScalar + 1
                    OtaghdarNobatId_ = "O" + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - OtaghdarNobatId.ToString().Trim().Length) + OtaghdarNobatId.ToString().Trim()
                Else
                    TereilliNobatId_ = String.Empty
                    OtaghdarNobatId_ = String.Empty
                End If

                'این خطوط بعد از حذف سپاس باید حذف گردند فعلا موقتی هستند
                CmdSql.CommandText = "Select top 1 nIdNobat from dbtransport.dbo.tbGhabz with (tablockx) order by nIdNobat desc"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('dbtransport.dbo.TbGhabz')"
                Dim mynIdGhabz As Int64 = CmdSql.ExecuteScalar + 1

                'ثبت نوبت ناوگان باری
                If NSSAnnouncemenetHall.AHId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Zobi Or NSSAnnouncemenetHall.AHId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Anbari Then
                    CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus) Values(" & mynIdEnterExit & "," & YourNSSCarTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','3800000',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',0,0," & NSSDriverTruck.NSSDriver.nIdPerson & "," & mynIdGhabz & ",'" & TereilliNobatId_ & "'," & TurnStatus.Registered & "," & R2CoreTransportationAndLoadNotification.LoadPermission.R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ")"
                    CmdSql.ExecuteNonQuery()
                Else
                    CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus) Values(" & mynIdEnterExit & "," & YourNSSCarTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','3800000',0," & YourUserNSS.UserId & ",'" & NSSDriverTruck.NSSDriver.StrPersonFullName & "',0,0," & NSSDriverTruck.NSSDriver.nIdPerson & "," & mynIdGhabz & ",'" & OtaghdarNobatId_ & "'," & TurnStatus.Registered & "," & R2CoreTransportationAndLoadNotification.LoadPermission.R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ")"
                    CmdSql.ExecuteNonQuery()
                End If

                'این خطوط بعد از حذف سپاس باید حذف گردند فعلا موقتی هستند
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbGhabz(nIdNobat,nIdCar,nIdDriver,StrDateEnter,StrDateExit,StrDateShEnter,StrDateShExit,StrTimeEnter,StrTimeExit,StrBarcodeNo,StrTime,IdUserEnter,IdUserExit,nSumPaid,nSumPaidEnter,nSumPaidExit,FlagA,snEnterAim,bEbtal) Values(" & mynIdEnterExit & "," & YourNSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentTime() & "','" & String.Empty & "','" & _DateTime.GetCurrentTime() & "'," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,0,0,1,1,0)"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbGhabz(nIdNobat,nIdCar,nIdDriver,StrDateEnter,StrDateExit,StrDateShEnter,StrDateShExit,StrTimeEnter,StrTimeExit,StrBarcodeNo,StrTime,IdUserEnter,IdUserExit,nSumPaid,nSumPaidEnter,nSumPaidExit,FlagA,snEnterAim,bEbtal) Values(0," & YourNSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentTime() & "','" & String.Empty & "','" & _DateTime.GetCurrentTime() & "'," & YourUserNSS.UserId & "," & YourUserNSS.UserId & ",0,0,0,1,1,0)"
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

                Return mynIdEnterExit
            Catch exx As GetNSSException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw exx
            Catch exxx As GetDataException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw exxx
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "بروز خطای اساسی هنگام صدور نوبت" + ex.Message, String.Empty, 0, 0, 0, 0, YourUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNewTurnIdforAgent(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YournEstelamId As Int64, YourTurnRegisterRequestId As Int64, YourMoneyWalletInventoryControl As Boolean) As Int64
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim myNSSLoadCapacitorLoad = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                Dim myNSSAnnouncementHall = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(myNSSLoadCapacitorLoad.AHId)
                If R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetAnnouncementHallSubGroups(YourNSSTruck).Where(Function(x) x = myNSSLoadCapacitorLoad.AHSGId).Count = 0 Then Throw New LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException
                Dim myNSSSeqT = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(myNSSAnnouncementHall)
                'آیا تسلسل نوبت مرتبط با ناوگان باری فعال است
                If Not myNSSSeqT.Active Then Throw New SequentialTurnIsNotActiveException
                'احراز راننده ناوگان از رابطه ناوگان راننده
                Dim myNSSTruckDriver = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(YourNSSTruck)
                'کنتر دارا بودن نوبت فعال قبلی
                If R2CoreTransportationAndLoadNotificationMClassTurnsManagement.ExistActiveTurn(YourNSSTruck, myNSSSeqT) Then Throw New GetNobatExceptionCarTruckHasNobat
                'شاخص درخواست صدور نوبت
                Dim NSSTRR = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequest(YourTurnRegisterRequestId)
                'تراکنش صدور نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                'شاخص اصلی نوبت برای تمام انواع ناوگان یکدست و یکپارچه محاسبه می شود و سیاست یکسانی دارد
                CmdSql.CommandText = "Select top 1 nEnterExitId from dbtransport.dbo.tbEnterExit with (tablockx) order by nEnterExitId desc"
                Dim mynIdEnterExit As Int64 = CmdSql.ExecuteScalar + 1

                'شاخص فرعی نوبت برای انواع ناوگان متفاوت است و سیاست متفاوت دارد - در چاپ قبض نوبت صفرهای اضافه نوبت فرعی حذف می گردند
                'Example -> Tereilli Start : T1397/000001  Otaghdar Start : O1397/000001  Shahri Start : S1397/000001  Anbari Start : A1397/000001  
                Dim SequentialTurnId As Int64 = Int64.MinValue
                Dim SequentialTurnId_ As String = String.Empty
                CmdSql.CommandText = "Select top 1 Substring(OtaghdarTurnNumber,7,10) from tbenterexit with (tablockx) Where Substring(OtaghdarTurnNumber,1,5)='" & myNSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() & "' order by OtaghdarTurnNumber desc"
                SequentialTurnId = CmdSql.ExecuteScalar + 1
                SequentialTurnId_ = myNSSSeqT.SequentialTurnKeyWord.Trim + _DateTime.GetCurrentSalShamsiFull() + "/" + R2CoreMClassPublicProcedures.RepeatStr("0", 6 - SequentialTurnId.ToString().Trim().Length) + SequentialTurnId.ToString().Trim()
                'ثبت نوبت ناوگان باری
                CmdSql.CommandText = "Insert Into dbtransport.dbo.TbEnterExit(nEnterExitId,StrCardNo,StrEnterDate,StrEnterTime,StrDesc,bEnterExit,nUserIdEnter,StrDriverName,bFlag,bFlagDriver,nDriverCode,nGhabzId,OtaghdarTurnNumber,TurnStatus,LoadPermissionStatus) Values(" & mynIdEnterExit & "," & YourNSSTruck.NSSCar.nIdCar & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & NSSTRR.Description & "',0," & R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId & ",'" & myNSSTruckDriver.NSSDriver.StrPersonFullName & "',0,0," & myNSSTruckDriver.NSSDriver.nIdPerson & ",0,'" & SequentialTurnId_ & "'," & TurnStatus.Registered & "," & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.None & ")"
                CmdSql.ExecuteNonQuery()
                'هزینه نوبت انجمن و شرکت
                If YourMoneyWalletInventoryControl Then
                    Dim myNSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                    Dim myMblgh = GetSherkatHazinehNobatMblgh(myNSSTrafficCard)
                    If myMblgh > 0 Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(myNSSTrafficCard, BagPayType.MinusMoney, myMblgh, R2CoreParkingSystemAccountings.SherkatHazinehNobat, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    If myNSSTrafficCard.CardType = TerafficCardType.Tereili Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(myNSSTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 1), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                    If myNSSTrafficCard.CardType = TerafficCardType.SixCharkh Or myNSSTrafficCard.CardType = TerafficCardType.TenCharkh Then R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(myNSSTrafficCard, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 4), R2CoreParkingSystemAccountings.AnjomanHazinehNobat, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                End If
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Return mynIdEnterExit
            Catch ex As Exception When TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
                                       OrElse TypeOf ex Is AnnouncementHallNotFoundException _
                                       OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                                       OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                                       OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                       OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                       OrElse TypeOf ex Is TruckDriverNotFoundException _
                                       OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                       OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                       OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                       OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                       OrElse TypeOf ex Is GetNSSException _
                                       OrElse TypeOf ex Is GetDataException _
                                       OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri _
                                       OrElse TypeOf ex Is GetNobatException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Fail, "بروز خطای اساسی هنگام صدور نوبت" + ex.Message, YourNSSTruck.NSSCar.GetCarPelakSerialComposit, 0, 0, 0, 0, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
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

        'Public Shared Sub InsertRecordIntotbGhabz(YourNSSCarTruck As R2StandardCarTruckStructure, YourNSSDriverTruck As R2StandardDriverTruckStructure, YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourMblgh As Int64)
        '    Dim CmdSql As SqlCommand = New SqlCommand
        '    CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
        '    Try
        '        CmdSql.Connection.Open()
        '        CmdSql.Transaction = CmdSql.Connection.BeginTransaction
        '        CmdSql.CommandText = "Select top 1 nIdNobat from dbtransport.dbo.tbGhabz with (tablockx) order by nIdNobat desc"
        '        CmdSql.ExecuteNonQuery()
        '        'CmdSql.CommandText = "Select IDENT_CURRENT('TbGhabz')"
        '        'Dim mynIdGhabz As Int64 = CmdSql.ExecuteScalar + 1
        '        CmdSql.CommandText = "Insert Into dbtransport.dbo.TbGhabz(nIdNobat,nIdCar,nIdDriver,StrDateEnter,StrDateExit,StrDateShEnter,StrDateShExit,StrTimeEnter,StrTimeExit,StrBarcodeNo,StrTime,IdUserEnter,IdUserExit,nSumPaid,nSumPaidEnter,nSumPaidExit,FlagA,snEnterAim,bEbtal) Values(0," & YourNSSCarTruck.NSSCar.nIdCar & "," & YourNSSDriverTruck.NSSDriver.nIdPerson & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "','" & _DateTime.GetCurrentTime() & "','" & YourNSSTerafficCard.CardNo & "','" & _DateTime.GetCurrentTime() & "'," & R2CoreMClassSoftwareUsersManagement.CurrentUserNSS.UserId & "," & R2CoreMClassSoftwareUsersManagement.CurrentUserNSS.UserId & ",0," & YourMblgh & ",0,0,1,0)"
        '        CmdSql.ExecuteNonQuery()
        '        CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
        '    Catch ex As Exception
        '        If CmdSql.Connection.State <> ConnectionState.Closed Then
        '            CmdSql.Transaction.Rollback()
        '            CmdSql.Connection.Close()
        '        End If
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

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
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatus.CancelledUser & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & YournEnterExitId & ""
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

        Public Shared Sub TurnsCancellation(YourTopSequentialTurnNumber As String , YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure, YourYearShamsi As String)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                Dim SeqTKeyWord As String = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(YourNSSAnnouncementHall).SequentialTurnKeyWord
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("
                       Select nEnterExitId from dbtransport.dbo.TbEnterExit as Turns
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCars On Turns.strCardno=AHSGRCars.CarId 
                        Where (SUBSTRING(Turns.OtaghdarTurnNumber,2,20) < = '" & YourYearShamsi+"/"+ YourTopSequentialTurnNumber & "') and 
                              (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ") and 
                              AHSGRCars.AHSGId=" & YourNSSAnnouncementHallSubGroup.AHSGId & " and 
                              AHSGRCars.RelationActive=1
                        Order By nEnterExitId")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)
                'در بانک سیستم محلی
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit
                                        Set TurnStatus=" & TurnStatuses.CancelledUnderScore & ",bFlag=1,bFlagDriver=1 
                                        Where nEnterExitId In   
                                          (Select nEnterExitId from dbtransport.dbo.TbEnterExit as Turns
                                                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCars On Turns.strCardno=AHSGRCars.CarId 
                                           Where (SUBSTRING(Turns.OtaghdarTurnNumber,2,20) < = '" & YourYearShamsi+"/"+ YourTopSequentialTurnNumber & "') and 
                                                 (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & "  or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ") and 
                                                 AHSGRCars.AHSGId=" & YourNSSAnnouncementHallSubGroup.AHSGId & " and 
                                                 AHSGRCars.RelationActive=1)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                'در آنلاین
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")).NSSCar.nIdCar)
                    TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSCarTruck.NSSCar.StrCarNo, NSSCarTruck.NSSCar.StrCarSerialNo)
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function SetbFlagDriverToFalse(YournEnterExitId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatus.ResuscitationUser & ",bFlag=1,bFlagDriver=0 Where nEnterExitId=" & YournEnterExitId & ""
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
                Return New R2StandardCarTruckNobatStructure(Ds.Tables(0).Rows(0).Item("nEnterExitId"), Ds.Tables(0).Rows(0).Item("StrEnterDate"), Ds.Tables(0).Rows(0).Item("StrEnterTime"), PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(Ds.Tables(0).Rows(0).Item("nDriverCode")), Ds.Tables(0).Rows(0).Item("bFlagDriver"), Ds.Tables(0).Rows(0).Item("nUserIdEnter"), Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, Ds.Tables(0).Rows(0).Item("StrCardNo"))
            Catch exx As GetNobatException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsCarTruckTankTreiler(YourNSS As R2StandardCarTruckStructure) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from PayanehAmirKabir.dbo.TblTankTrailers Where Deleted=0 and OActive=1 and Pelak='" & YourNSS.NSSCar.StrCarNo & "' and Serial='" & YourNSS.NSSCar.StrCarSerialNo & "'", 0, Ds).GetRecordsCount() = 0 Then
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
                CmdSql.Connection.Open()
                If IsCarTruckTankTreiler(YourNSS) Then
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

        Public Shared Function GetCarTruckNobatCollection(YourTruckId As Int64, YourTotalNumberofRecordsRequested As Int64) As List(Of R2StandardCarTruckNobatStructure)
            Try
                Dim Lst As List(Of R2StandardCarTruckNobatStructure) = New List(Of R2StandardCarTruckNobatStructure)
                Dim Ds As New DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2ClassSqlConnectionSepas, "Select Top " & YourTotalNumberofRecordsRequested & " * from dbtransport.dbo.TbEnterExit Where StrCardNo='" & YourTruckId & "' Order By nEnterExitId Desc", 1, Ds)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As R2StandardCarTruckNobatStructure = New R2StandardCarTruckNobatStructure(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId"), Ds.Tables(0).Rows(Loopx).Item("StrEnterDate"), Ds.Tables(0).Rows(Loopx).Item("StrEnterTime"), PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(Ds.Tables(0).Rows(Loopx).Item("nDriverCode")), Ds.Tables(0).Rows(Loopx).Item("bFlagDriver"), Ds.Tables(0).Rows(Loopx).Item("nUserIdEnter"), Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber"), Ds.Tables(0).Rows(Loopx).Item("StrCardNo"))
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


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

    Public Class GetNobatExceptionCarTruckIsShahri
        Inherits ApplicationException

        Public Overrides ReadOnly Property Message As String
            Get
                Return "ناوگان مورد نظر شهری می باشد"
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
    End Class


End Namespace

Namespace TurnRegisterRequest

    Public NotInheritable Class PayanehClassLibraryMClassTurnRegisterRequestManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function IsMoneyWalletInventoryIsEnoughForTurnRegistering(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                If R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(YourNSSTrafficCard) < PayanehClassLibraryMClassCarTruckNobatManagement.GetHazinehSodoorNobat(YourNSSTrafficCard) Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function RealTimeTurnRegisterRequestforAjent(YourSoftwareUserId As Int64, YournEstelamId As Int64, YourTruckMustBePresent As Boolean, YourMoneyWalletInventoryControl As Boolean, ByRef YourTurnId As Int64) As Int64
            Try
                Dim myNSSSoftwareUser = R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourSoftwareUserId)
                Dim myNSSTruck = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(myNSSSoftwareUser)
                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure
                If YourMoneyWalletInventoryControl Then
                    NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(myNSSTruck.NSSCar.nIdCar))
                    If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException
                End If
                'کنترل حضور ناوگان در پارکینگ - درصورتی که طبق کانفیگ باید حضورداشته باشد ولی حضور نداشته باشد آنگاه اکسپشن پرتاب می گردد
                If YourTruckMustBePresent Then R2CoreTransportationAndLoadNotificationMClassTurnsManagement.TruckPresentInParkingForTurnRegisteringControl(myNSSTruck)
                'ثبت درخواست صدور نوبت بلادرنگ
                Dim TurnRegisterRequestId = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.RealTime, myNSSTruck.NSSCar.nIdCar, R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.RealTime).TRRTypeTitle, Nothing, Nothing, Nothing, Nothing), Nothing, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
                'ثبت نوبت
                YourTurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetNewTurnIdforAgent(myNSSTruck, YournEstelamId, TurnRegisterRequestId, False)
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, YourTurnId, TurnRegisterRequestId, Nothing), RelationDeactiveTypes.BothDeactive)
                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException _
                                  OrElse TypeOf ex Is TruckNotFoundException _
                                  OrElse TypeOf ex Is CarIsNotPresentInParkingException _
                                  OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                  OrElse TypeOf ex Is SequentialTurnIsNotActiveException _
                                  OrElse TypeOf ex Is TurnPrintingInfNotFoundException _
                                  OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler _
                                  OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException _
                                  OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat _
                                  OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri _
                                  OrElse TypeOf ex Is GetNobatException _
                                  OrElse TypeOf ex Is GetNSSException _
                                  OrElse TypeOf ex Is AnnouncementHallNotFoundException _
                                  OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                                  OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                                  OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                  OrElse TypeOf ex Is TruckDriverNotFoundException _
                                  OrElse TypeOf ex Is GetDataException _
                                  OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function RealTimeTurnRegisterRequest(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourTurnPrintRedirect As Boolean, YourMoneyWalletInventoryControl As Boolean, ByRef YourTurnId As Int64, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                If YourMoneyWalletInventoryControl Then If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException
                'ثبت درخواست صدور نوبت بلادرنگ
                Dim TurnRegisterRequestId = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.RealTime, YourNSSTruck.NSSCar.nIdCar, R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.RealTime).TRRTypeTitle, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ثبت نوبت
                YourTurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetNobat(NSSTrafficCard, Nothing, TurnRegisterRequestId, YourUserNSS)
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, YourTurnId, TurnRegisterRequestId, Nothing), RelationDeactiveTypes.BothDeactive)
                'درخواست چاپ نوبت
                PayanehClassLibraryMClassCarTruckNobatManagement.NoCostTurnPrintRequest(PayanehClassLibraryMClassCarTruckNobatManagement.GetNSSCarTruckNobat(YourTurnId), YourTurnPrintRedirect)
                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function EmergencyTurnRegisterRequest(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourMoneyWalletInventoryControl As Boolean, YourEmergencyTurnRegisterRequestNote As String, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                'کنترل موجودی کیف پول برای هزینه صدور نوبت - درصورتی که موجودی کافی نباشداکسپشن پرتاب می گردد 
                If YourMoneyWalletInventoryControl Then If Not IsMoneyWalletInventoryIsEnoughForTurnRegistering(NSSTrafficCard) Then Throw New MoneyWalletCurrentChargeNotEnoughException
                'ثبت درخواست صدور نوبت اضطراری
                Dim TurnRegisterRequestId = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.Emergency, YourNSSTruck.NSSCar.nIdCar, R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.Emergency).TRRTypeTitle & " " & YourEmergencyTurnRegisterRequestNote, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ارسال پیام تایید درخواست صدور نوبت اضطراری
                Dim DataStruct As DataStruct = New DataStruct()
                DataStruct.Data1 = YourNSSTruck.NSSCar.nIdCar
                DataStruct.Data2 = TurnRegisterRequestId
                R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, YourNSSTruck.NSSCar.GetCarPelakSerialComposit() + " " + YourEmergencyTurnRegisterRequestNote, R2CoreTransportationAndLoadNotificationComputerMessageTypes.EmergencyTurnRegisterRequestConfirmation, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Note YourDataStruct: Data1=nCarId Data2=TurnRegisterRequestId
        Public Shared Sub EmergencyTurnRegister(YourDataStruct As DataStruct, YourTurnPrintRedirect As Boolean, YourUserNSS As R2CoreStandardSoftwareUserStructure)
            Try
                Dim NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourDataStruct.Data1))
                'ثبت نوبت
                Dim YourTurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetNobat(NSSTrafficCard, Nothing, YourDataStruct.Data2, YourUserNSS)
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, YourTurnId, YourDataStruct.Data2, Nothing), RelationDeactiveTypes.BothDeactive)
                'درخواست چاپ نوبت
                R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManagement.NoCostTurnPrintRequest(YourTurnId, YourTurnPrintRedirect)
            Catch ex As Exception When TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is TruckRelatedSequentialTurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function ReserveTurnRegisterRequest(YourNSSTurnRegisterCard As R2CoreParkingSystemStandardTrafficCardStructure, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                'ثبت درخواست صدور نوبت رزرو
                Dim TurnRegisterRequestId = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.TurnRegisterRequestRegistering(New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(Nothing, TurnRegisterRequestTypes.Reserve, R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 1), R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequestType(TurnRegisterRequestTypes.Reserve).TRRTypeTitle & ";" & YourNSSTurnRegisterCard.CardId, Nothing, Nothing, Nothing, Nothing), Nothing, YourUserNSS)
                'ارسال پیام تایید درخواست صدور نوبت اضطراری
                Dim DataStruct As DataStruct = New DataStruct()
                DataStruct.Data1 = TurnRegisterRequestId
                DataStruct.Data2 = YourNSSTurnRegisterCard.CardId
                R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, YourNSSTurnRegisterCard.CardNo + " :شماره کارت ", R2CoreTransportationAndLoadNotificationComputerMessageTypes.ReserveTurnRegisterRequestConfirmation, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
                Return TurnRegisterRequestId
            Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        'Input  : YourDataStruct: Data1=TRRId Data2=TurnRegisterCardId Data3=TruckDriverMobileNumber
        'Output : Data1=TurnId Data2=DateShamsi+' - '+Time
        Public Shared Function ReserveTurnRegister(YourDataStruct As DataStruct, YourUserNSS As R2CoreStandardSoftwareUserStructure) As DataStruct
            Dim SMSSender = New R2CoreSMSSendRecive
            Try
                'ثبت نوبت
                Dim myTurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetNewReserveTurn(YourDataStruct.Data1, YourUserNSS)
                'ثبت رابطه نوبت با درخواست صدور نوبت از طریق فضانام مدیریت روابط نهادی
                R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(New R2StandardEntityRelationStructure(Nothing, R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest, myTurnId, YourDataStruct.Data1, Nothing), RelationDeactiveTypes.BothDeactive)
                'ارسال پیام به راننده
                SMSSender.SendSms(New R2CoreSMSStandardSmsStructure(Nothing, YourDataStruct.Data3, R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 3) + ":" + myTurnId.ToString(), 12, Nothing, 1, Nothing, Nothing))
                Dim myOutputData As New DataStruct
                myOutputData.Data1 = myTurnId
                myOutputData.Data2 = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(myTurnId).EnterDate + " - " + R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(myTurnId).EnterTime
                Return myOutputData
            Catch ex As Exception When TypeOf ex Is TruckNotFoundException _
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



    End Class




End Namespace

Namespace ConfigurationManagement

    Public MustInherit Class PayanehClassLibraryConfigurations
        Inherits R2CoreTransportationAndLoadNotification.ConfigurationsManagement.R2CoreTransportationAndLoadNotificationConfigurations

        Public Shared ReadOnly Property Clock4 As Int64 = 22
        Public Shared ReadOnly Property SalonFingerPrint As Int64 = 26
        Public Shared ReadOnly Property TarrifsPayaneh As Int64 = 31
        Public Shared ReadOnly Property ElamBarMonitoringInterval As Int64 = 33
        Public Shared ReadOnly Property NobatGetFP_ChkViewTruckNobat As Int64 = 34
        Public Shared ReadOnly Property TWS As Int64 = 51
        Public Shared ReadOnly Property AnnouncementHallMonitoring = 52
        Public Shared ReadOnly Property TarrifsPayanehKiosk = 53
        Public Shared ReadOnly Property PayanehAmirKabirAutomatedJobsSetting = 64



    End Class

    Public NotInheritable Class PayanehClassLibraryMClassConfigurationManagement
    End Class

    Public NotInheritable Class PayanehClassLibraryMClassConfigurationOfAnnouncementHallsManagement
        Inherits R2CoreMClassConfigurationManagement

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
                    Throw New GetNSSException
                End If
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UpdateDriverTruck(YourNSS As R2StandardDriverTruckStructure)
            Dim CmdSql As SqlCommand = New SqlCommand
            CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Try
                If IsExistDriverTruck(YourNSS) = True Then Throw New DriverTruckSmartCardNoAlreadyAvailabletException
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
                If R2ClassSqlDataBOXManagement.GetDataBOX(New DataBaseManagement.R2ClassSqlConnectionSepas, "Select StrCarNo,StrCarSerialNo from dbtransport.dbo.TbCar Where strCarNo='" & YourNSS.NSSCar.StrCarNo & "' and strCarSerialNo='" & YourNSS.NSSCar.StrCarSerialNo & "' ", 1, DS).GetRecordsCount <> 0 Then
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
                Da.SelectCommand = New SqlCommand("Select Top 1 nIdCar,StrBodyNo from dbtransport.dbo.TbCar Where strCarNo='" & YourLP.Pelak & "' and strCarSerialNo='" & YourLP.Serial & "' Order By nIdCar Desc")
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
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
               "Select Top 1 * from dbtransport.dbo.TbCar Where StrBodyNo='" & YourSmartCardNo.Trim() & "' Order By nIdCar Desc",
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
    End Class

    Public Class PayanehClassLibraryMClassReportsManagement

        Private Shared _DateTime As New R2DateTime


        Public Shared Sub ReportingInformationProviderContractorCompanyFinancialReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourVatStatus As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime
                Dim myMahName As String = _DateTime.GetPersianMonthName(YourDateTime1.DateShamsiFull)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "delete R2PrimaryReports.dbo.TblEnterExitByMblghReport" : CmdSql.ExecuteNonQuery()
                Dim Da As New SqlClient.SqlDataAdapter
                Da.SelectCommand = New SqlClient.SqlCommand
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()

                Dim myDateShamsi1 As String = YourDateTime1.DateShamsiFull
                Dim myDateShamsi2 As String = YourDateTime2.DateShamsiFull

                Dim DSSixCharkh As New DataSet
                Dim DSSavari As New DataSet
                Dim DSTereiliTenCharkh As New DataSet
                Dim DSExit As New DataSet
                Dim DSReturnAmount As New DataSet
                Dim myReturnAmount As Int64 = 0
                Dim myConcat1 As String = myDateShamsi1.Replace("/", "") + YourDateTime1.Time.Replace(":", "")
                Dim myConcat2 As String = myDateShamsi1.Replace("/", "") + YourDateTime2.Time.Replace(":", "")
                Dim myCurrentDate As String = myDateShamsi1

                Do

                    'If myDateShamsi1 = "1396/05/01" Then
                    '    myConcat1 = myDateShamsi1.Replace("/", "") + "00:00:00"
                    'Else
                    '    myConcat1 = myDateShamsi1.Replace("/", "") + YourDateTime1.Time.Replace(":", "")
                    'End If
                    'If myDateShamsi2 = "1396/05/01" Then
                    '    myConcat2 = myDateShamsi1.Replace("/", "") + "23:59:59"
                    'Else
                    '    myConcat2 = myDateShamsi1.Replace("/", "") + YourDateTime2.Time.Replace(":", "")
                    'End If

                    Dim mySixCharkhEnterTotal As Int64 = 0
                    Dim mySixCharkhEnterJam As Int64 = 0
                    Dim mySavariEnterTotal As Int64 = 0
                    Dim mySavariEnterJam As Int64 = 0
                    Dim myTereiliTenCharkhEnterTotal As Int64 = 0
                    Dim myTereiliTenCharkhEnterJam As Int64 = 0
                    Dim myExitJam As Int64 = 0
                    Dim myJamKol As Int64 = 0

                    'شش چرخ یا دو محور
                    Da.SelectCommand.CommandText = "Select Count(*) as Total,Sum(E.MblghA) as Jam FROM R2Primary.dbo.TblAccounting as E inner join (SELECT CARDID,CARDTYPE FROM R2Primary.dbo.TblRFIDCards ) as R on E.CardId=R.CardId WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And ((E.EEAccountingProcessType=1) or (E.EEAccountingProcessType=17) or (E.EEAccountingProcessType=8) or (E.EEAccountingProcessType=11))  And ((E.MblghA=40000) Or (E.MblghA=43600) Or (E.MblghA=45000) Or (E.MblghA=65400) Or (E.MblghA=85020))"
                    DSSixCharkh.Tables.Clear()
                    Da.Fill(DSSixCharkh)
                    mySixCharkhEnterTotal = DSSixCharkh.Tables(0).Rows(0).Item("Total")
                    If Not DBNull.Value.Equals(DSSixCharkh.Tables(0).Rows(0).Item("Jam")) Then
                        If YourVatStatus = False Then
                            mySixCharkhEnterJam = DSSixCharkh.Tables(0).Rows(0).Item("Jam")
                        Else
                            'mySixCharkhEnterJam = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 2) * mySixCharkhEnterTotal
                            mySixCharkhEnterJam = DSSixCharkh.Tables(0).Rows(0).Item("Jam") * 100 / 109
                        End If
                        myJamKol += mySixCharkhEnterJam
                    End If

                    'سواری
                    Da.SelectCommand.CommandText = "Select Count(*) as Total,Sum(E.MblghA) as Jam FROM R2Primary.dbo.TblAccounting as E inner join (SELECT CARDID,CARDTYPE FROM R2Primary.dbo.TblRFIDCards ) as R on E.CardId=R.CardId WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And ((E.EEAccountingProcessType=1) or (E.EEAccountingProcessType=17))  And ((E.MblghA=14170) Or (E.MblghA=15000) Or (E.MblghA=21255) Or (E.MblghA=27250))"
                    DSSavari.Tables.Clear()
                    Da.Fill(DSSavari)
                    mySavariEnterTotal = DSSavari.Tables(0).Rows(0).Item("Total")
                    If Not DBNull.Value.Equals(DSSavari.Tables(0).Rows(0).Item("Jam")) Then
                        If YourVatStatus = False Then
                            mySavariEnterJam = DSSavari.Tables(0).Rows(0).Item("Jam")
                        Else
                            'mySavariEnterJam = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 0) * mySavariEnterTotal
                            mySavariEnterJam = DSSavari.Tables(0).Rows(0).Item("Jam") * 100 / 109
                        End If
                        myJamKol += mySavariEnterJam
                    End If

                    'ده و چرخ تریلی یا سه محور به بالا
                    'Da.SelectCommand.CommandText = "Select Count(*) as Total,Sum(E.MblghA) as Jam FROM R2Primary.dbo.TblAccounting as E inner join (SELECT CARDID,CARDTYPE FROM R2Primary.dbo.TblRFIDCards ) as R on E.CardId=R.CardId WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And ((E.EEAccountingProcessType=1) OR (E.EEAccountingProcessType=7) OR (E.EEAccountingProcessType=8) OR (E.EEAccountingProcessType=11)) And (R.CardType=" & TerafficCardType.TenCharkh & " or R.CardType=" & TerafficCardType.Tereili & ")"
                    Da.SelectCommand.CommandText = "Select Count(*) as Total,Sum(E.MblghA) as Jam fROM R2Primary.dbo.TblAccounting as E WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And ((E.EEAccountingProcessType=1) OR (E.EEAccountingProcessType=17) or (E.EEAccountingProcessType=7) OR (E.EEAccountingProcessType=8) OR (E.EEAccountingProcessType=11)) And ((E.MblghA=60000) or (E.MblghA=59950) or (E.MblghA=81750) or (E.MblghA=105730))"
                    DSTereiliTenCharkh.Tables.Clear()
                    Dim C As Color = Color.BlanchedAlmond
                    Da.Fill(DSTereiliTenCharkh)
                    myTereiliTenCharkhEnterTotal = DSTereiliTenCharkh.Tables(0).Rows(0).Item("Total")
                    If Not DBNull.Value.Equals(DSTereiliTenCharkh.Tables(0).Rows(0).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myTereiliTenCharkhEnterJam = DSTereiliTenCharkh.Tables(0).Rows(0).Item("Jam")
                        Else
                            'myTereiliTenCharkhEnterJam = R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.TarrifsMblghApproved, 3) * myTereiliTenCharkhEnterTotal
                            myTereiliTenCharkhEnterJam = DSTereiliTenCharkh.Tables(0).Rows(0).Item("Jam") * 100 / 109
                        End If
                        myJamKol += myTereiliTenCharkhEnterJam
                    End If

                    'خروج
                    Da.SelectCommand.CommandText = "Select Sum(E.MblghA) as Jam FROM R2Primary.dbo.TblAccounting as E inner join (SELECT CARDID,CARDTYPE FROM R2Primary.dbo.TblRFIDCards ) as R on E.CardId=R.CardId WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And (E.EEAccountingProcessType=2)"
                    DSExit.Tables.Clear()
                    Da.Fill(DSExit)
                    If Not DBNull.Value.Equals(DSExit.Tables(0).Rows(0).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myExitJam = DSExit.Tables(0).Rows(0).Item("Jam")
                        Else
                            myExitJam = (DSExit.Tables(0).Rows(0).Item("Jam") * 100 / 109)
                        End If
                        myJamKol += myExitJam
                    End If
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblEnterExitByMblghReport(DateShamsi1,DateShamsi2,Time1,Time2,ReportDateShamsi,ReportTime,DateShamsi,SixCharkhEnterTotal,SixCharkhEnterJam,SavariEnterTotal,SavariEnterJam,TereiliTenCharkhEnterTotal,TereiliTenCharkhEnterJam,ExitJam,JamKol,MahName,ReturnAmount) values('" & YourDateTime1.DateShamsiFull & "','" & YourDateTime2.DateShamsiFull & "','" & YourDateTime1.Time & "','" & YourDateTime2.Time & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "','" & myCurrentDate & "'," & mySixCharkhEnterTotal & "," & mySixCharkhEnterJam & "," & mySavariEnterTotal & "," & mySavariEnterJam & "," & myTereiliTenCharkhEnterTotal & "," & myTereiliTenCharkhEnterJam & "," & myExitJam & "," & myJamKol & ",'" & myMahName & "',0)"
                    CmdSql.ExecuteNonQuery()

                    'بازگشت مبلغ
                    Da.SelectCommand.CommandText = "Select Sum(E.MblghA) as Jam FROM R2Primary.dbo.TblAccounting as E inner join (SELECT CARDID,CARDTYPE FROM R2Primary.dbo.TblRFIDCards ) as R on E.CardId=R.CardId WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & myConcat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & myConcat2 & "')) And (E.EEAccountingProcessType=15)"
                    DSReturnAmount.Tables.Clear()
                    Da.Fill(DSReturnAmount)
                    If Not DBNull.Value.Equals(DSReturnAmount.Tables(0).Rows(0).Item("Jam")) Then
                        If YourVatStatus = False Then
                            myReturnAmount = myReturnAmount + DSReturnAmount.Tables(0).Rows(0).Item("Jam")
                        Else
                            myReturnAmount = myReturnAmount + (DSReturnAmount.Tables(0).Rows(0).Item("Jam") * 100 / 109)
                        End If
                    End If
                    myCurrentDate = R2Core.PublicProc.R2CoreMClassPublicProcedures.GetNextShamsiDate(myCurrentDate)
                    myConcat1 = myCurrentDate.Replace("/", "") + YourDateTime1.Time.Replace(":", "")
                    myConcat2 = myCurrentDate.Replace("/", "") + YourDateTime2.Time.Replace(":", "")
                Loop While myCurrentDate.Replace("/", "") <= YourDateTime2.DateShamsiFull.Replace("/", "")

                'ثبت جمع کل مبالغ بازگشت شده
                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblEnterExitByMblghReport Set ReturnAmount = " & myReturnAmount & ""
                CmdSql.ExecuteNonQuery()

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderTruckersAssociationFinancialReport(YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime

                Dim _JamMblgh As Int64 = 0
                Dim _JamTeadad As Int64 = 0
                Dim DSRFIDCards As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblRFIDCards", 1, DSRFIDCards)

                Dim Concat1 As String = YourDateTime1.GetConcatString
                Dim Concat2 As String = YourDateTime2.GetConcatString
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "delete R2PrimaryReports.dbo.TblTruckersAssociationFinancialReport"
                CmdSql.ExecuteNonQuery()
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlClient.SqlCommand("select e.cardid,E.DateShamsiA,E.TimeA ,E.EEAccountingProcessType ,E.PelakA,E.SerialA ,E.MblghA  from R2Primary.dbo.TblAccounting as E WHERE (((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,':',''))>='" & Concat1 & "') And ((Replace(E.DateShamsiA,'/','')+Replace(E.TimeA,'/',''))<='" & Concat2 & "')) And (E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehNobat & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezUpTo72Saat & "  OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk & "  OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.PrintCopyOfTurn & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeCarTruckNumberPlate & " OR E.EEAccountingProcessType=" & R2CoreParkingSystemAccountings.AnjomanChangeDriverTruck & ") and ISNULl(Deleted,0)<>1   ORDER BY E.DateMilladiA")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
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
                  from tbenterexit as Turns
	                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations On Turns.nEnterExitId=LoadAllocations.TurnId 
	                 Inner Join tbcar as C on Turns.strCardno=C.nIDCar 
	                 Inner Join tbCompany as Co on Turns.nCompCode=CO.nCompCode 
	                 Inner Join tbCity as Ci on Turns.nCityCode=CI.nCityCode 
	                 Inner Join tbProducts as P on Turns.nBarCode=p.strGoodCode 
                  where Turns.nDriverCode='" & YourDriverId & "' and Turns.strExitDate>='" & YourDateTime1.DateShamsiFull & "' and Turns.strExitDate<='" & YourDateTime2.DateShamsiFull & "'  and LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.PermissionSucceeded & " 
                  Order By Turns.nEnterExitId Desc")
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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

        Public Shared Sub ReportingInformationProviderCapacitorLoadsforAnnounceReport(YourAnnouncementHallId As AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls, YourAnnouncementHallSubGroupId As AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                If YourAnnouncementHallSubGroupId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.None Then
                    Da.SelectCommand = New SqlClient.SqlCommand("
                             Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNum,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                             from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationLoaderTypes as AHRCarType On CT.snCarType=AHRCarType.LoaderTypeId 
                               inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRCarType.AHId=AH.AHId	
                             Where AHRCarType.RelationActive=1 and AH.AHId=" & YourAnnouncementHallId & " and E.bFlag=0 and (E.LoadStatus=1 or E.LoadStatus=2) and E.nCarNum>0 
                             Order By C.nProvince,strCityName,nTruckType")
                Else
                    Da.SelectCommand = New SqlClient.SqlCommand("
                             Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNum,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                             from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
	                           inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
	                           inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
	                           inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRCarType On CT.snCarType=AHSGRCarType.LoaderTypeId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCarType.AHSGId=AHSG.AHSGId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId 
	                           inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId 
                             Where AHSGRCarType.RelationActive=1 and AHRAHSG.RelationActive=1 and AH.AHId=" & YourAnnouncementHallId & " and AHSG.AHSGId=" & YourAnnouncementHallSubGroupId & " and E.bFlag=0 and (E.LoadStatus=1 or E.LoadStatus=2) and E.nCarNum>0 
                             Order By C.nProvince,strCityName,nTruckType")
                End If

                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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
                    Dim mynCarNum As Int64 = Ds.Tables(0).Rows(Loopx).Item("nCarNum")
                    Dim myStrPriceSug As String = Ds.Tables(0).Rows(Loopx).Item("strPriceSug").trim
                    Dim myStrDescription As String = Ds.Tables(0).Rows(Loopx).Item("strDescription").trim
                    Dim myStrAddress As String = Ds.Tables(0).Rows(Loopx).Item("strAddress").trim
                    Dim myStrBarname As String = Ds.Tables(0).Rows(Loopx).Item("strBarName").trim
                    Dim mydDateElam As String = Ds.Tables(0).Rows(Loopx).Item("dDateElam").trim
                    Dim mydTimeElam As String = Ds.Tables(0).Rows(Loopx).Item("dTimeElam").trim
                    Dim myCompanyName As String = Ds.Tables(0).Rows(Loopx).Item("StrCompName").trim
                    Dim myStrCarName As String = Ds.Tables(0).Rows(Loopx).Item("StrCarName").trim
                    CmdSql.CommandText = "insert into R2PrimaryReports.dbo.TblCapacitorLoadsforAnnounceReport (AnnoucementHallName,nEstelamId,StrGoodName,StrCityName,nCarNumKol,StrCompanyName,StrPriceSug,StrDescription,StrAddress,StrBarName,dDateElam,dTimeElam,StrCarName) values('" & myAnnouncementHallName & "'," & mynEstelamid & ",'" & myStrGoodName & "','" & myStrCityName & "'," & mynCarNum & ",'" & myCompanyName & "','" & myStrPriceSug & "','" & myStrDescription & "','" & myStrAddress & "','" & myStrBarname & "','" & mydDateElam & "','" & mydTimeElam & "','" & myStrCarName & "')"
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

        Public Shared Sub ReportingInformationProviderCapacitorLoadsCompanyRegisteredLoadsReport(YourAnnouncementHallId As AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls, YourCompanyCode As Int64, YourDateTime1 As R2StandardDateAndTimeStructure, YourDateTime2 As R2StandardDateAndTimeStructure, YourTargetCityId As Int64)
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
                If YourAnnouncementHallId = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.General Then
                    If YourCompanyCode = Int64.MinValue Then
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join dbtransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                            Where (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + "
                            Order By E.dDateElam,E.nCompCode,E.nTruckType,E.dTimeElam")
                    Else
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                            Where E.nCompCode=" & YourCompanyCode & " and (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + "
                            Order By E.dDateElam,E.nTruckType,E.dTimeElam")
                    End If
                Else
                    If YourCompanyCode = Int64.MinValue Then
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                            Where E.nTruckType in (Select AHRCarType.LoaderTypeId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationLoaderTypes as AHRCarType Where AHRCarType.AHId=" & YourAnnouncementHallId & " ) and (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " 
                            Order By E.dDateElam,E.nCompCode,E.dTimeElam")
                    Else
                        Da.SelectCommand = New SqlClient.SqlCommand("
                            Select E.nEstelamID,P.strGoodName,C.strCityName,E.nCarNumKol,E.strPriceSug,E.strDescription,E.strAddress,E.strBarName,E.dDateElam,E.dTimeElam,CO.strCompName,CT.StrCarName 
                            from DBTransport.dbo.tbElam as E 
                               inner join DBTransport.dbo.tbProducts as P On E.nBarcode=P.strGoodCode 
                               inner join DBTransport.dbo.tbCity as C On E.nCityCode=C.nCityCode 
                               inner join DBTransport.dbo.tbCompany as CO On e.nCompCode=CO.nCompCode 
                               inner join DBTransport.dbo.tbCarType as CT On E.nTruckType=CT.snCarType 
                            Where E.nTruckType in (Select AHRCarType.LoaderTypeId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationLoaderTypes as AHRCarType Where AHRCarType.AHId=" & YourAnnouncementHallId & " ) and  E.nCompCode=" & YourCompanyCode & " and (E.dDateElam>='" & YourDateTime1.DateShamsiFull & "' and E.dDateElam<='" & YourDateTime2.DateShamsiFull & "' )" + TargetCitySql + " 
                            Order By e.nEstelamID")
                    End If
                End If
                Da.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                If Da.Fill(Ds) <> 0 Then
                    'لیست کلیه مجوزهای صادرشده برای کلیه بارهای فوق
                    Dim nEstelamIdMax As Int64 = Ds.Tables(0).Select("", "nEstelamId Desc")(0)(0)
                    Dim nEstelamIdMin As Int64 = Ds.Tables(0).Select("", "nEstelamId Asc")(0)(0)
                    Dim DaLoadPermission As New SqlClient.SqlDataAdapter : Dim DsLoadPermission As New DataSet
                    DaLoadPermission.SelectCommand = New SqlCommand("
                         Select LoadPermissions.nEstelamId,LoadPermissions.StrExitDate,LoadPermissions.StrExitTime,LoadPermissions.StrDriverName,Cars.strCarNo,Cars.strCarSerialNo 
                         from DBTransport.dbo.TbEnterExit as LoadPermissions
                         Inner Join dbtransport.dbo.TbCar as Cars On  LoadPermissions.strCardno=Cars.nIDCar 
                         Where nEstelamId>=" & nEstelamIdMin & " and nEstelamId<=" & nEstelamIdMax & " and bFlag=1 and bFlagDriver=1")
                    DaLoadPermission.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
                    DaLoadPermission.Fill(DsLoadPermission)

                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        'اطلاعات بار
                        Dim mynEstelamid As String = Ds.Tables(0).Rows(Loopx).Item("nEstelamId")
                        Dim myStrGoodName As String = Ds.Tables(0).Rows(Loopx).Item("strGoodName").trim
                        Dim myStrCityName As String = Ds.Tables(0).Rows(Loopx).Item("strCityName").trim
                        Dim mynCarNumKol As Int64 = Ds.Tables(0).Rows(Loopx).Item("nCarNumKol")
                        Dim myStrPriceSug As String = Ds.Tables(0).Rows(Loopx).Item("strPriceSug").trim
                        Dim myStrDescription As String = Ds.Tables(0).Rows(Loopx).Item("strDescription").trim
                        Dim myStrAddress As String = Ds.Tables(0).Rows(Loopx).Item("strAddress").trim
                        Dim myStrBarname As String = Ds.Tables(0).Rows(Loopx).Item("strBarName").trim
                        Dim mydDateElam As String = Ds.Tables(0).Rows(Loopx).Item("dDateElam").trim
                        Dim mydTimeElam As String = Ds.Tables(0).Rows(Loopx).Item("dTimeElam").trim
                        Dim myCompanyName As String = Ds.Tables(0).Rows(Loopx).Item("StrCompName").trim
                        Dim myStrCarName As String = Ds.Tables(0).Rows(Loopx).Item("StrCarName").trim

                        'اطلاعات مجوزهای صادره
                        Dim LoadPermissions As DataRow()
                        LoadPermissions = DsLoadPermission.Tables(0).Select("nEstelamId=" + mynEstelamid)
                        Dim CompositStringDriverName As String = String.Empty
                        Dim CompositStringDate As String = String.Empty
                        Dim CompositStringTime As String = String.Empty
                        For LoopPermissions As Int64 = 0 To LoadPermissions.Count() - 1
                            CompositStringDate = CompositStringDate & LoadPermissions(LoopPermissions)(1).trim & vbCrLf
                            CompositStringTime = CompositStringTime & LoadPermissions(LoopPermissions)(2).trim & vbCrLf
                            Dim Truck As String = LoadPermissions(LoopPermissions)(4).trim + " - " + LoadPermissions(LoopPermissions)(5).trim
                            CompositStringDriverName = CompositStringDriverName & LoadPermissions(LoopPermissions)(3).trim & " " & Truck & vbCrLf
                        Next
                        CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblCapacitorLoadsCompanyRegisteredLoads(nEstelamId,StrGoodName,StrCityName,nCarNumKol,StrCompanyName,StrPriceSug,StrDescription,StrAddress,StrBarName,dDateElam,dTimeElam,StrCarName,StrExitDate,StrExitTime,StrDriverName) values(" & mynEstelamid & ",'" & myStrGoodName & "','" & myStrCityName & "'," & mynCarNumKol & ",'" & myCompanyName & "','" & myStrPriceSug & "','" & myStrDescription & "','" & myStrAddress & "','" & myStrBarname & "','" & mydDateElam & "','" & mydTimeElam & "','" & myStrCarName & "','" & CompositStringDate & "','" & CompositStringTime & "','" & CompositStringDriverName & "')"
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

                DaRegisteredLoad.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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

                DaReleasedLoad.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Anbari Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbariShemsh Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbariSaderati Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariSaderatiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbarRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & " Where TransportCompanyId=" & nCompCode & ""
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
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.Anbari Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariAnbariReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbariShemsh Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbariSaderati Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariSaderatiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariSaderatiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHallSubGroups.AnbarRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariCoilReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceReport Set AnbariCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & " Where TransportCompanyId=" & nCompCode & ""
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
                DaRegisteredLoad.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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
                DaReleasedLoad.SelectCommand.Connection = (New R2ClassSqlConnectionSepas).GetConnection()
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
                    If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Khavar Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar6 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar10 Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Anbari Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Anbari Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbariShemsh Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbariSaderati Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariSaderatiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbarRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Zobi Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Zobi Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiShemsh Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiSaderati Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    ElseIf DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Shahri Then
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Shahri Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        If DsRegisteredLoad.Tables(0).Rows(Loopx).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ShahriRol Then CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriCoilAnnounced=" & DsRegisteredLoad.Tables(0).Rows(Loopx).Item("Jam") & ""
                        CmdSql.ExecuteNonQuery()
                    End If
                Next

                'مرحله سوم ایجاد تعداد بار ترخیص شده
                For Loopy As Int64 = 0 To DsReleasedLoad.Tables(0).Rows.Count - 1
                    If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Khavar Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set OtaghdarKhavarReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar6 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar6CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Otaghdar10 Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set Otaghdar10CharkhReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Anbari Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Anbari Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariAnbariReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbariShemsh Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbariSaderati Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariSaderatiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariSaderatiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.AnbarRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariCoilReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set AnbariCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Zobi Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Zobi Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiZobiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiShemsh Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiShemshReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiSaderati Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiSaderatiReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ZobiRol Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ZobiCoilReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                    ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.Shahri Then
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.Shahri Then
                            If DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriReleasedInAnnouncementHall=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            ElseIf DsReleasedLoad.Tables(0).Rows(Loopy).Item("ReleaseLocation") = R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany Then
                                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblAnnouncementHallPerformanceGeneralStatisticsReport Set ShahriShahriReleasedInTransportCompany=" & DsReleasedLoad.Tables(0).Rows(Loopy).Item("Teadad") & ""
                            End If
                        End If
                        If DsReleasedLoad.Tables(0).Rows(Loopy).Item("AHSGId") = AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHallSubGroups.ShahriRol Then
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
                         AHSGRCars.AHSGId=" & YourNSSAnnouncementHallSubGroup.AHSGId & " and AHSGRCars.RelationActive=1 
                   Order By Turns.strEnterDate,Turns.strEnterTime")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                Ds.Tables.Clear()
                Da.Fill(Ds)

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblTruckDriversWaitingToGetLoadPermissionReport" : CmdSql.ExecuteNonQuery()
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblTruckDriversWaitingToGetLoadPermissionReport(EnterExitId,SequentialId,TurnDate,TurnTime,SleepDays,SequentialTurnTitle,TruckDriver,Truck) Values(" & Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")) & "," & Ds.Tables(0).Rows(Loopx).Item("SequentialId") & ",'" & Ds.Tables(0).Rows(Loopx).Item("strEnterDate") & "','" & Ds.Tables(0).Rows(Loopx).Item("strEnterTime") & "'," & Ds.Tables(0).Rows(Loopx).Item("SleepDays") & ",'" & Ds.Tables(0).Rows(Loopx).Item("SeqTTitle").trim & "','" & Ds.Tables(0).Rows(Loopx).Item("strPersonFullName").trim & "','" & Ds.Tables(0).Rows(Loopx).Item("strCarNo").trim + "-" + Ds.Tables(0).Rows(Loopx).Item("strCarSerialNo").trim & "')"
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
                                 Products.strGoodName,LoadTargets.strCityName,Turns.strExitDate+'-'+strExitTime as LoadPermissionDateTime,TransportCompanies.TCTitle,AnnouncementHallSubGroups.AHSGTitle,Loads.strDescription 
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

    End Class

End Namespace

Namespace AnnouncementHallsManagement

    Namespace AnnouncementHalls

        Public Enum AnnouncementHalls
            None = 0
            General = 1
            Zobi = 2
            Anbari = 3
            Otaghdar = 4
            Shahri = 5
        End Enum

        Public Enum AnnouncementHallSubGroups
            None = 0
            Khavar = 1
            Otaghdar6 = 2
            Otaghdar10 = 3
            Anbari = 4
            AnbariShemsh = 5
            AnbariSaderati = 6
            Zobi = 7
            ZobiShemsh = 8
            ZobiSaderati = 9
            AnbarRol = 10
            ZobiRol = 11
            Shahri = 12
            ShahriRol = 13
        End Enum

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

Namespace LoadNotification.LoadManipulation




End Namespace

Namespace LoadNotification.LoadAllocation

    Public NotInheritable Class LoadNotificationLoadAllocationManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Sub TransportCompanyLoadCapacitorSedimentLoadAllocationMessageProduce(YourComapnyCode As Int64, YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String)
            Try
                Dim DataStruct As DataStruct = New DataStruct()
                DataStruct.Data1 = YourComapnyCode
                DataStruct.Data2 = YournEstelamId
                DataStruct.Data3 = YourCarTruckSmartCardNo
                DataStruct.Data4 = YourDriverTruckSmartCardNo
                R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, "شماره هوشمند ناوگان باری :" + YourCarTruckSmartCardNo.Trim, 6, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Sub

    End Class





End Namespace

Namespace LoadNotification.LoadPermission

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

        Public Shared Function TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(YourComapnyCode As Int64, YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String, YourNSSUser As R2CoreStandardSoftwareUserStructure) As Int64
            Try
                ''کنترل حداقل موجودی در کیف پول شرکت حمل و نقل
                'Dim NSSMoneyWallet As R2CoreParkingSystemStandardTrafficCardStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyMoneyWallet(YourComapnyCode)
                'If R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSMoneyWallet) < GetHazinehSedimentLoadPermission(YournEstelamId) Then
                '    Throw New TransportCompanyMoneyWalletInventoryIsLowException
                'End If

                'صدور نوبت برای ناوگان باری
                'در صورتی که راننده خودش نوبت داشته باشد از همان استفاده می شود
                Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(YourCarTruckSmartCardNo, YourNSSUser)
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                Dim TurnShouldBeUseInTransportCompany As Boolean = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 1)

                Dim TurnId As Int64
                If TurnShouldBeUseInTransportCompany Then
                    Try
                        TurnId = PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(NSSCarTruck.NSSCar).nEnterExitId
                    Catch exx As GetNobatException
                        TurnId = CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatKiosk(NSSCarTruck, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                    Catch ex As Exception
                        Throw ex
                    End Try
                Else
                    TurnId = CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatKiosk(NSSCarTruck, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                End If


                Dim NSSCarTruckNobat As R2StandardCarTruckNobatStructure = PayanehClassLibraryMClassCarTruckNobatManagement.GetNSSCarTruckNobat(TurnId)

                'صدور مجوز بارگیری برای ناوگان باری
                Try
                    TransportCompanyLoadCapacitorSedimentLoadPermisiion(TurnId, YournEstelamId, PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(NSSCarTruck.NSSCar.nIdCar)), R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
                Catch ex As Exception
                    'درصورتی که صدور مجوز با مشکل مواجه شود نوبت صادرشده باطل می گردد
                    PayanehClassLibrary.CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.SetbFlagDriverToTrue(TurnId, False)
                    Throw ex
                End Try

                ''اکانتینگ کیف پول
                ''محاسبه هزینه شرکت با توجه به نوع ناوگان باری
                ''اگر از نوبت موجود راننده استفاده شود اکانت برای کیف پول شرکت ثبت نمی شود
                'If NSSCarTruckNobat.nUserIdEnter = R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId Then
                '    Dim HazinehAS As Int64 = 0
                '    Dim NSS As TransportCompaniesStandardLoadCapacitorLoadStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)
                '    If NSS.nTruckType = 505 Or NSS.nTruckType = 455 Or NSS.nTruckType = 700 Or NSS.nTruckType = 605 Then
                '        HazinehAS = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 1)
                '    Else
                '        HazinehAS = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 2)
                '    End If
                '    'شرکت
                '    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSMoneyWallet, BagPayType.MinusMoney, HazinehAS, R2CoreParkingSystemAccountings.SherkatHazinehSodoorMojavezKiosk)
                '    'انجمن
                '    R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(NSSMoneyWallet, BagPayType.MinusMoney, R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayanehKiosk, 0), R2CoreParkingSystemAccountings.AnjomanHazinehSodorMojavezKiosk)
                'End If

                Return TurnId

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Function

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

        Public Shared Sub CarTruckRelationDriverTruck(YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String, YourNSSUser As R2CoreStandardSoftwareUserStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Try
                If YourDriverTruckSmartCardNo = String.Empty Or YourCarTruckSmartCardNo = String.Empty Then Throw New Exception("شماره هوشمند راننده یا ناوگان نادرست است")
                Dim NSSCarTruck As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(YourCarTruckSmartCardNo, YourNSSUser)
                Dim NSSDriverTruck As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(YourDriverTruckSmartCardNo)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Insert into Dbtransport.dbo.TbCarAndPerson(nIdCar,nIdPerson,snRelation,dDate) Values(" & NSSCarTruck.NSSCar.nIdCar & "," & NSSDriverTruck.NSSDriver.nIdPerson & ",2,'" & _DateTime.GetCurrentDateShamsiFull() & "')"
                Try
                    CmdSql.ExecuteNonQuery()
                Catch ex As Exception
                    CmdSql.CommandText = "Update Dbtransport.dbo.TbCarAndPerson Set nIdPerson=" & NSSDriverTruck.NSSDriver.nIdPerson & ",dDate='" & _DateTime.GetCurrentDateShamsiFull() & "'  Where (nIdCar=" & NSSCarTruck.NSSCar.nIdCar & ") and snRelation=2"
                    CmdSql.ExecuteNonQuery()
                End Try

                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message + vbCrLf + "خطا ممکن است به دلیل تداخل در ثبت اطلاعات پایه راننده و ناوگان باشد")
            End Try
        End Sub

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
            Catch exx As CarTruckHasNotAnyLoadPermissionException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public Class PermissionPrinting

        Private Shared WithEvents _PrintDocumentPermission As PrintDocument = New PrintDocument()
        Private Shared _NSSCarTruck As R2StandardCarTruckStructure
        Private Shared _NSSCarTruckNobat As R2StandardCarTruckNobatStructure
        Private Shared _NSSTransportCompanyStandardLoadCapacitorLoad As TransportCompaniesStandardLoadCapacitorLoadStructure
        Private Shared _ExitDate, _ExitTime As String
        Private Shared _LoadPermissionUserExit As String

        Public Shared Sub GetInformationforRemotePermissionPrinting(YournEstelamId As Int64, YourTurnId As Int64, ByRef StrExitDate As String, ByRef StrExitTime As String, ByRef nEstelamId As String, ByRef TurnId As String, ByRef CompanyName As String, ByRef CarTruckLoaderTypeName As String, ByRef Pelak As String, ByRef Serial As String, ByRef DriverTruckFullNameFamily As String, ByRef DriverTruckDrivingLicenseNo As String, ByRef ProductName As String, ByRef TargetCityName As String, ByRef StrPriceSug As String, ByRef StrDescription As String, ByRef PermissionUserName As String, ByRef OtherNote As String, ByRef LAId As String)
            Try
                _NSSCarTruckNobat = PayanehClassLibraryMClassCarTruckNobatManagement.GetNSSCarTruckNobat(YourTurnId)
                _NSSTransportCompanyStandardLoadCapacitorLoad = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)
                _NSSCarTruck = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(_NSSCarTruckNobat.StrCardNo)

                StrExitDate = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data1
                StrExitTime = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data2
                PermissionUserName = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data3
                nEstelamId = YournEstelamId
                TurnId = YourTurnId
                Try
                    LAId = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(YournEstelamId, YourTurnId).LAId.ToString()
                Catch exx As LoadAllocationNotFoundException
                    LAId = 0
                Catch ex As Exception
                    Throw ex
                End Try
                CompanyName = TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyName(_NSSTransportCompanyStandardLoadCapacitorLoad.nCompCode)
                CarTruckLoaderTypeName = R2CoreParkingSystem.CarType.R2CoreParkingSystemMClassCarType.GetCarTypeNameFromsnCarType(_NSSCarTruck.NSSCar.snCarType)
                Pelak = _NSSCarTruck.NSSCar.StrCarNo
                Serial = _NSSCarTruck.NSSCar.StrCarSerialNo
                DriverTruckFullNameFamily = _NSSCarTruckNobat.NSSDriverTruck.NSSDriver.StrPersonFullName
                DriverTruckDrivingLicenseNo = _NSSCarTruckNobat.NSSDriverTruck.NSSDriver.strDrivingLicenceNo
                ProductName = TransportCompaniesLoadCapacitorLoadManipulation.GetProductName(_NSSTransportCompanyStandardLoadCapacitorLoad.nBarCode)
                TargetCityName = R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(_NSSTransportCompanyStandardLoadCapacitorLoad.nCityCode)
                StrPriceSug = _NSSTransportCompanyStandardLoadCapacitorLoad.StrPriceSug
                StrDescription = _NSSTransportCompanyStandardLoadCapacitorLoad.StrDescription
                Dim HazinehSedimentLoadPermission As Int64 = LoadNotificationLoadPermissionManagement.GetHazinehSedimentLoadPermission(YournEstelamId)
                If _NSSCarTruckNobat.nUserIdEnter = R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser().UserId Then
                    OtherNote = HazinehSedimentLoadPermission.ToString() + ":هزينه پايانه،نوبت و ارزش افزوده-ريال"
                Else
                    OtherNote = 0.ToString() + ":هزينه پايانه،نوبت و ارزش افزوده-ريال"
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub PrintPermission(YournEstelamId As Int64, YourTurnId As Int64)
            Try
                _NSSCarTruckNobat = PayanehClassLibraryMClassCarTruckNobatManagement.GetNSSCarTruckNobat(YourTurnId)
                _NSSTransportCompanyStandardLoadCapacitorLoad = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(YournEstelamId)
                _NSSCarTruck = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(_NSSCarTruckNobat.StrCardNo)
                _ExitDate = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data1
                _ExitTime = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data2
                _LoadPermissionUserExit = LoadNotificationLoadPermissionManagement.GetLoadPermissionInf(YournEstelamId, YourTurnId).Data3
                'چاپ مجوز
                _PrintDocumentPermission.Print()
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Sub _PrintDocumentPermission_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.BeginPrint
        End Sub

        Private Shared Sub _PrintDocumentPermission_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.EndPrint
        End Sub

        Private Shared Sub _PrintDocumentPermission_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
            Try
                Dim myPaperSizeHalf As Integer = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
                Dim myStrFontPersonFullName As Font = New System.Drawing.Font("Badr", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                E.Graphics.DrawString(_ExitDate, myStrFontMax, Brushes.DarkBlue, X, Y)
                E.Graphics.DrawString(_NSSTransportCompanyStandardLoadCapacitorLoad.nEstelamId, myDigFont, Brushes.DarkBlue, X + 420, Y)
                E.Graphics.DrawString(_ExitTime, myStrFontMax, Brushes.DarkBlue, X, Y + 50)
                E.Graphics.DrawString(_NSSCarTruckNobat.nEnterExitId, myStrFontMax, Brushes.DarkBlue, X + 420, Y + 30)
                E.Graphics.DrawString(TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyName(_NSSTransportCompanyStandardLoadCapacitorLoad.nCompCode), myStrFontMax, Brushes.DarkBlue, X + 350, Y + 130)
                E.Graphics.DrawString(_NSSCarTruck.NSSCar.StrCarSerialNo + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170)
                Dim a As Char() = _NSSCarTruck.NSSCar.StrCarNo.Trim.ToCharArray()
                E.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170)
                E.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170)
                E.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170)
                E.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170)
                E.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170)
                E.Graphics.DrawString(a(2), myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170)


                ''E.Graphics.DrawString(R2CoreParkingSystemMClassCars.GetNSSCar(_NSSCarTruckNobat.StrCardNo).GetCarPelakSerialComposit(), myStrFontPersonFullName, Brushes.DarkBlue, X + 280, Y + 50)

                E.Graphics.DrawString(R2CoreParkingSystem.CarType.R2CoreParkingSystemMClassCarType.GetCarTypeNameFromsnCarType(_NSSCarTruck.NSSCar.snCarType), myStrFontMax, Brushes.DarkBlue, X + 350, Y + 170)
                E.Graphics.DrawString(_NSSCarTruckNobat.NSSDriverTruck.NSSDriver.strDrivingLicenceNo, myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210)
                E.Graphics.DrawString(_NSSCarTruckNobat.NSSDriverTruck.NSSDriver.StrPersonFullName, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210)
                E.Graphics.DrawString(R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(_NSSTransportCompanyStandardLoadCapacitorLoad.nCityCode), myStrFontMax, Brushes.DarkBlue, X, Y + 230)

                E.Graphics.DrawString(_NSSTransportCompanyStandardLoadCapacitorLoad.StrPriceSug, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 270)
                E.Graphics.DrawString(_NSSTransportCompanyStandardLoadCapacitorLoad.StrDescription, myStrFontMax, Brushes.DarkBlue, X, Y + 290)

                E.Graphics.DrawString(_LoadPermissionUserExit, myStrFontMax, Brushes.DarkBlue, X, Y + 320)

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Sub _PrintDocumentPermission_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentPermission.PrintPage
            Try
                _PrintDocumentPermission_PrintPage_Printing(100, 80, e)
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
































































































































































































































































































