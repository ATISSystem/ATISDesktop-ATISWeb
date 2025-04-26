
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Windows.Forms

Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.DateAndTimeManagement.CalendarManagement.PersianCalendar
Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement
Imports R2Core.LoggingManagement
Imports R2Core.NetworkInternetManagement.Exceptions
Imports R2Core.DesktopProcessesManagement
Imports R2Core.PublicProc
Imports R2Core.R2PrimaryFileSharingWS
Imports R2Core.ReportsManagement
Imports R2Core.SoftwareUserManagement
Imports R2Core.EntityRelationManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions
Imports R2CoreTransportationAndLoadNotification.ComputerMessages
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorAccounting
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadOtherThanManipulation
Imports R2CoreTransportationAndLoadNotification.LoaderTypes.Exceptions
Imports R2CoreTransportationAndLoadNotification.TransportCompanies
Imports R2CoreTransportationAndLoadNotification.TransportCompanies.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadTargets
Imports R2CoreTransportationAndLoadNotification.TransportTarrifs
Imports R2CoreTransportationAndLoadNotification.TransportTarrifs.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadPermission
Imports R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions
Imports R2CoreTransportationAndLoadNotification.Goods.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.Logging
Imports R2CoreTransportationAndLoadNotification.TruckDrivers
Imports R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions
Imports R2CoreTransportationAndLoadNotification.TurnAttendance.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.TurnAttendance
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrinting
Imports R2CoreTransportationAndLoadNotification.Turns.TurnRegisterRequest
Imports R2CoreTransportationAndLoadNotification.AnnouncementTiming
Imports R2CoreTransportationAndLoadNotification.LoadTargets.Exceptions
Imports R2CoreTransportationAndLoadNotification.Rmto
Imports R2CoreTransportationAndLoadNotification.TruckLoaderTypes
Imports R2CoreTransportationAndLoadNotification.TruckLoaderTypes.Exceptions
Imports R2CoreTransportationAndLoadNotification.EntityRelations
Imports R2CoreParkingSystem.EntityRelations
Imports R2CoreParkingSystem.RequesterManagement
Imports R2CoreParkingSystem.PermissionManagement
Imports R2CoreParkingSystem.EntityManagement
Imports R2Core.SecurityAlgorithmsManagement.SQLInjectionPrevention
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.SoftwareUserManagement.Exceptions
Imports R2Core.MoneyWallet.Exceptions
Imports R2CoreTransportationAndLoadNotification.TransportTarrifsParameters.Exceptions
Imports R2CoreParkingSystem.SoftwareUsersManagement
Imports R2CoreTransportationAndLoadNotification.SoftwareUserManagement
Imports R2CoreParkingSystem.SMS.SMSTypes
Imports R2CoreParkingSystem
Imports R2CoreParkingSystem.PredefinedMessagesManagement
Imports R2Core.PredefinedMessagesManagement
Imports R2Core.SoftwareUserManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.TrucksNativeness
Imports R2CoreTransportationAndLoadNotification.Goods
Imports R2CoreTransportationAndLoadNotification.TrucksNativeness.Exceptions
Imports R2Core.SMS.SMSHandling
Imports R2CoreTransportationAndLoadNotification.LoadSources

Namespace Rmto
    Public MustInherit Class RmtoWebService
        Private Shared Service As RmtoWS.PKG_RMTO_WSService
        Public Shared RmtoURL As String = "http://smartcard.rmto.ir"

        Public Enum InfoType
            GET_DRIVER_BY_SHC = 0
            GET_DRIVER_BY_SHM = 1
            GET_DRIVER_BY_SHP = 2
            GET_FREIGHTER_BY_SHC = 3
            GET_FREIGHTER_BY_VIN = 4
            GET_FREIGHTER_BY_SHP = 5
            GET_PASSENGER_BY_SHC = 6
            GET_PASSENGER_BY_VIN = 7
            GET_PASSENGER_BY_SHP = 8
        End Enum

        Private Shared Function GetInf(ByVal YourInfoType As InfoType, ByVal YourDFP As String) As String()
            Try
                Dim InstanceLogging = New R2CoreInstanceLoggingManager
                If Not R2Core.NetworkInternetManagement.R2CoreMClassComputerMessagesManagement.IsInternetAvailable() Then
                    Throw New InternetIsnotAvailableException
                End If

                Authentication()

                If InstanceLogging.GetNSSLogType(R2CoreTransportationAndLoadNotificationLogType.RmtoWebServiceRequest).Active Then
                    InstanceLogging.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreTransportationAndLoadNotificationLogType.RmtoWebServiceRequest, InstanceLogging.GetNSSLogType(R2CoreTransportationAndLoadNotificationLogType.RmtoWebServiceRequest).LogTitle, "InfoType=" + YourInfoType.ToString(), "YourDFP=" + YourDFP, String.Empty, String.Empty, String.Empty, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser.UserId, Nothing, Nothing))
                End If

                If YourInfoType = InfoType.GET_DRIVER_BY_SHC Then
                    Return Service.RMTO_WEB_SERVICES(YourDFP, "", "", "", "", "", "", "", "", "", "2043148", 41, "Biinfo878").Split(";")
                    'Return Service.RMTO_WEB_SERVICES("Biinfo878", 41, "2043148", "", "", "", "", "", "", "", "", "", YourDFP).Split(";")
                ElseIf YourInfoType = InfoType.GET_DRIVER_BY_SHM Then
                    Return Service.RMTO_WEB_SERVICES(YourDFP, "", "", "", "", "", "", "", "", "", "2043148", 3, "Biinfo878").Split(";")
                    'Return Service.RMTO_WEB_SERVICES("Biinfo878", 3, "2043148", "", "", "", "", "", "", "", "", "", YourDFP).Split(";")
                ElseIf YourInfoType = InfoType.GET_FREIGHTER_BY_SHC Then
                    Return Service.RMTO_WEB_SERVICES(YourDFP, "", "", "", "", "", "", "", "", "", "2043148", 4, "Biinfo878").Split(";")
                    'Return Service.RMTO_WEB_SERVICES("Biinfo878", 4, "2043148", "", "", "", "", "", "", "", "", "", YourDFP).Split(";")
                ElseIf YourInfoType = InfoType.GET_FREIGHTER_BY_VIN Then
                    Return Service.RMTO_WEB_SERVICES(YourDFP, "", "", "", "", "", "", "", "", "", "2043148", 6, "Biinfo878").Split(";")
                    'Return Service.RMTO_WEB_SERVICES("Biinfo878", 6, "2043148", "", "", "", "", "", "", "", "", "", YourDFP).Split(";")
                End If
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTruckDriver(YourNationalCode As String) As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
            Try
                Dim ComposeString As String() = GetInf(InfoType.GET_DRIVER_BY_SHM, YourNationalCode)
                Dim NSSTruckDriver As New R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
                NSSTruckDriver.NSSDriver = New R2StandardDriverStructure()
                NSSTruckDriver.StrSmartCardNo = ComposeString(1).Split(":")(1)
                NSSTruckDriver.NSSDriver.StrFatherName = ComposeString(6).Split(":")(1)
                NSSTruckDriver.NSSDriver.StrNationalCode = ComposeString(3).Split(":")(1)
                NSSTruckDriver.NSSDriver.StrPersonFullName = ComposeString(4).Split(":")(1) + ";" + ComposeString(5).Split(":")(1)
                NSSTruckDriver.NSSDriver.strDrivingLicenceNo = ComposeString(9).Split(":")(1)
                Return NSSTruckDriver
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function ISTruckDriverSmartCardActive(YourSmartCardNo As String) As Boolean
            Try
                Dim ComposeString As String() = GetInf(InfoType.GET_DRIVER_BY_SHC, YourSmartCardNo)
                Dim Active As Boolean = ComposeString(11).Split(":")(1)
                Return Active
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New RMTOWebServiceSmartCardInvalidException
            End Try
        End Function

        Public Shared Function GetNSSTruck(YourSmartCardNo As String) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim ComposeString As String() = GetInf(InfoType.GET_FREIGHTER_BY_SHC, YourSmartCardNo)
                Dim NSSTruck As New R2CoreTransportationAndLoadNotificationStandardTruckStructure
                NSSTruck.NSSCar = New R2StandardCarStructure()
                NSSTruck.SmartCardNo = YourSmartCardNo
                NSSTruck.NSSCar.StrCarNo = ComposeString(5).Split(":")(1) + ComposeString(6).Split(":")(1) + ComposeString(7).Split(":")(1)
                NSSTruck.NSSCar.StrCarSerialNo = ComposeString(3).Split(":")(1)
                NSSTruck.NSSCar.nIdCity = R2CoreParkingSystemMClassCitys.GetnCityCodeFromStrCityName(ComposeString(4).Split(":")(1))
                NSSTruck.NSSCar.snCarType = ComposeString(12).Split(":")(1)
                Return NSSTruck
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New RMTOWebServiceSmartCardInvalidException
            End Try
        End Function

        Public Shared Function ISTruckSmartCardActive(YourSmartCardNo As String) As Boolean
            Try
                Dim ComposeString As String() = GetInf(InfoType.GET_FREIGHTER_BY_SHC, YourSmartCardNo)
                Dim Active As Boolean = ComposeString(8).Split(":")(1)
                Return Active
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New RMTOWebServiceSmartCardInvalidException
            End Try
        End Function

        Private Shared Sub Authentication()
            Try
                If Not R2Core.NetworkInternetManagement.R2CoreMClassComputerMessagesManagement.IsInternetAvailable() Then
                    Throw New InternetIsnotAvailableException
                End If
                ''Dim UserName As String = "tr_web_service"
                ''Dim Password As String = "tr_web_service123"
                Dim UserName As String = "Biinfo878"
                Dim Password As String = "2043148"
                Service = New RmtoWS.PKG_RMTO_WSService()
                Dim Credential As System.Net.CredentialCache = New System.Net.CredentialCache
                Credential.Add(New Uri(Service.Url), "Basic", New System.Net.NetworkCredential(UserName, Password))
                Service.Credentials = Credential
            Catch ex As ConnectionIsNotAvailableException
                Throw ex
            Catch ex As InternetIsnotAvailableException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Public Class RMTOWebServiceSmartCardInvalidException
        Inherits ApplicationException
        Public Overrides ReadOnly Property Message As String
            Get
                Return "شماره وارد شده نادرست است یا سایت کارت هوشمند در دسترس نیست"
            End Get
        End Property
    End Class

    'Public Class RMTOSmartCardSiteIsNotAvailableException
    '    Inherits ApplicationException
    '    Public Overrides ReadOnly Property Message As String
    '        Get
    '            Return "سایت کارت هوشمند در دسترس نیست"
    '        End Get
    '    End Property
    'End Class


End Namespace

Namespace ReportManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationReports
        Inherits R2CoreReports

        Public Shared ReadOnly BillOfLadingControlReport As Int64 = 29
        Public Shared ReadOnly BillOfLadingControlInfractionsReport As Int64 = 30

    End Class

    Public Class R2CoreTransportationAndLoadNotificationReportsManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Sub ReportingInformationProviderBillOfLadingControlReport(YourBLCId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblBillOfLadingControlsReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblBillOfLadingControlsReport
                                    Select BLC.BLCId,BLC.BLCTitle,BLC.TCOId,BLC.TCOTitle,BLC.DateShamsi,BLC.Time,SoftwareUser.Username,'' as ReportDateTime,
                                           BLCDetails.BLCIndex,BLCDetails.BLNo,BLCDetails.BlSerial,BLCDetails.BLDateShamsi,BLCDetails.BLTime,BLCDetails.BLSenderTitle,BLCDetails.BLSenderNationalCode,BLCDetails.BLReceiverTitle,
	                                       BLCDetails.BLReceiverNationalCode,BLCDetails.BLFirstTruckDriver,BLCDetails.BLTruckNo,BLCDetails.BLTruckSerialNo,BLCDetails.BLTruckSmartCardNo,BLCDetails.BLPrice,
	                                       BLCDetails.BLSourceTitle,BLCDetails.BLTargetTitle,BLCDetails.BLGoodTitle,BLCDetails.BLWeight,BLCDetails.BLLoaderTypeTitle
                                    from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC
                                       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlDetails as BLCDetails On BLC.BLCId=BLCDetails.BLCId
                                       Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUser On BLC.UserId=SoftwareUser.UserId
                                    Where BLC.BLCId=" & YourBLCId & " Order By BLCDetails.BLCIndex "
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblBillOfLadingControlsReport Set ReportDateTime='" & _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + " - " + _DateTime.GetCurrentTime() & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub ReportingInformationProviderBillOfLadingControlInfractionReport(YourBLCIId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimaryReportsSqlConnection).GetConnection()
            Try
                Dim _DateTime As R2DateTime = New R2DateTime
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Delete R2PrimaryReports.dbo.TblBillOfLadingControlInfractionsReport" : CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert Into R2PrimaryReports.dbo.TblBillOfLadingControlInfractionsReport
                                          Select BLCInfraction.BLCIId,BLCInfraction.BLCId,BLC.BLCTitle,BLCInfraction.DateShamsi,BLCInfraction.Time,SoftwareUser.UserName,BLCInfraction.Note,'' as ReportDateTime,
                                                 BLCInfractionDetail.BLCIIndex,BLCInfractionDetail.TruckAnalyze,BLCInfractionDetail.TonajAnalyze,BLCInfractionDetail.SenderAnalyze,BLCInfractionDetail.RecieverAnalyze,
	                                             BLCInfractionDetail.SameSenderRecieverAnalyze,BLCInfractionDetail.LoadSourceInvalid 
                                          from R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractions as BLCInfraction
                                              Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControlInfractionDetails as BLCInfractionDetail On BLCInfraction.BLCIId=BLCInfractionDetail.BLCIId
                                              Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblBillOfLadingControls as BLC On BLCInfraction.BLCId=BLC.BLCId
                                              Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUser On BLCInfraction.UserId=SoftwareUser.UserId
                                          Where BLCInfraction.BLCIId=" & YourBLCIId & " Order By BLCInfractionDetail.BLCIIndex"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update R2PrimaryReports.dbo.TblBillOfLadingControlInfractionsReport Set ReportDateTime='" & _DateTime.GetCurrentDateShamsiFull().Replace("/", "") + " - " + _DateTime.GetCurrentTime() & "'"
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

Namespace Logging

    Public MustInherit Class R2CoreTransportationAndLoadNotificationLogType
        Inherits R2CoreLogType

        Public Shared ReadOnly Property LoadCapacitorSedimentingFailed As Int64 = 11
        Public Shared ReadOnly Property TurnExpirationFailed As Int64 = 12
        Public Shared ReadOnly Property RmtoWebServiceRequest As Int64 = 13
        Public Shared ReadOnly Property LoadAllocationsAccessStatistics As Int64 = 14
        Public Shared ReadOnly Property TransferringTommorowLoads As Int64 = 15
        Public Shared ReadOnly Property ATISMobileMoneyWalletsCharging As Int64 = 16
    End Class

End Namespace

Namespace ComputerMessages

    Public MustInherit Class R2CoreTransportationAndLoadNotificationComputerMessageTypes
        Inherits R2Core.ComputerMessagesManagement.R2CoreComputerMessageTypes
        Public Shared ReadOnly EmergencyTurnRegisterRequestConfirmation As Int64 = 2
        Public Shared ReadOnly TurnPrint As Int64 = 3
        Public Shared ReadOnly ReserveTurnRegisterRequestConfirmation As Int64 = 7
    End Class

End Namespace

Namespace FileShareRawGroupsManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationRawGroups
        Inherits R2Core.FileShareRawGroupsManagement.R2CoreRawGroups

        Public Shared ReadOnly TurnRegisterRequestAttachements As Int64 = 5

        Public Shared ReadOnly DriverSelfDeclarations As Int64 = 8

    End Class

End Namespace

Namespace ConfigurationsManagement
    Public MustInherit Class R2CoreTransportationAndLoadNotificationConfigurations
        Inherits R2CoreConfigurations
        Public Shared ReadOnly Property TurnControlling As Int64 = 34
        Public Shared ReadOnly Property AnnouncementHallMonitoring As Int64 = 52
        Public Shared ReadOnly Property LoadCapacitorLoadManipulationSetting As Int64 = 54
        Public Shared ReadOnly Property AnnouncementHallAnnounceTime As Int64 = 55
        Public Shared ReadOnly Property AnnouncementHallsTurnCancellationSetting As Int64 = 56
        Public Shared ReadOnly Property AnnouncementHallsTruckDriverAttendance As Int64 = 57
        Public Shared ReadOnly Property DefaultTransportationAndLoadNotificationConfigs As Int64 = 58
        Public Shared ReadOnly Property AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting As Int64 = 59
        Public Shared ReadOnly Property AnnouncementHallsTurnRegisteringSetting As Int64 = 61
        Public Shared ReadOnly Property AnnouncementHallsLoadPermissionsSetting As Int64 = 62
        Public Shared ReadOnly Property AnnouncementHallsLoadSedimentationSetting As Int64 = 63
        Public Shared ReadOnly Property AnnouncementHallsAutomaticProcessesTiming As Int64 = 68
        Public Shared ReadOnly Property AnnouncementHallsLoadAllocationSetting As Int64 = 69
        Public Shared ReadOnly Property TommorowLoads As Int64 = 71
        Public Shared ReadOnly Property DriverSelfDeclarationSetting As Int64 = 86
        Public Shared ReadOnly Property XXX As Int64 = 88
        Public Shared ReadOnly Property IndigenousTrucks As Int64 = 89
        Public Shared ReadOnly Property AnnouncementHallsLoadCapacitorControl As Int64 = 91
        Public Shared ReadOnly Property BillOfLading As Int64 = 92
        Public Shared ReadOnly Property LoadingDischargingPlaces As Int64 = 93


    End Class

    Public Class R2CoreTransportationAndLoadNotificationInstanceConfigurationOfAnnouncementHallsManager
        Public Function GetConfig(YourCId As Int64, YourAHId As Int64) As Object
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds, New Boolean).GetRecordsCount = 0 Then
                    Throw New ConfigurationOfAnnouncementHallNotFoundException
                End If
                Return Ds.Tables(0).Rows(0).Item("CValue")
            Catch ex As ConfigurationOfAnnouncementHallNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfig(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Object
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds, New Boolean).GetRecordsCount = 0 Then
                    Throw New ConfigurationOfAnnouncementHallNotFoundException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigString(YourCId As Int64, YourAHId As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId).trim
            Catch ex As ConfigurationOfAnnouncementHallNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigInt64(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigBoolean(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetConfigString(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex).trim
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement
        'Inherits R2CoreMClassConfigurationManagement

        Public Shared Function GetConfigOnLine(YourCId As Int64, YourAHId As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "")
                Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Ds.Tables(0).Rows(0).Item("CValue").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds, New Boolean).GetRecordsCount = 0 Then
                    Throw New ConfigurationOfAnnouncementHallNotFoundException
                End If
                Return Split(Ds.Tables(0).Rows(0).Item("CValue"), ";")(YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64, YourAHId As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds, New Boolean).GetRecordsCount = 0 Then
                    Throw New ConfigurationOfAnnouncementHallNotFoundException
                End If
                Return Ds.Tables(0).Rows(0).Item("CValue")
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex).trim
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigString(YourCId As Int64, YourAHId As Int64) As String
            Try
                Return GetConfig(YourCId, YourAHId).trim
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt32(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Int32
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigBoolean(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Boolean
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigInt64(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Int64
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigDouble(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Double
            Try
                Dim xRong As Double = GetConfig(YourCId, YourAHId, YourIndex)
                Return xRong
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfigByte(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Byte
            Try
                Return GetConfig(YourCId, YourAHId, YourIndex)
            Catch exx As ConfigurationOfAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Overloads Shared Sub SetConfiguration(YourCId As Int64, YourAHId As Int64, YourCValue As String)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Set CValue = '" & YourCValue & "' Where CId=" & YourCId & " and AHId=" & YourAHId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Overloads Shared Sub SetConfiguration(YourCId As Int64, YourAHId As Int64, YourIndex As Int64, YourCValue As String)
            Try
                Dim CurrentConfigValue As String = GetConfigOnLine(YourCId, YourAHId)
                Dim CurrentConfigValueSplitted As String() = Split(CurrentConfigValue, ";")
                Dim SB As New StringBuilder
                For Loopx As Int64 = 0 To CurrentConfigValueSplitted.Length - 1
                    If Loopx = YourIndex Then
                        SB.Append(YourCValue)
                    Else
                        SB.Append(CurrentConfigValueSplitted(Loopx))
                    End If
                    If Loopx < CurrentConfigValueSplitted.Length - 1 Then SB.Append(";")
                Next
                SetConfiguration(YourCId, YourAHId, SB.ToString())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class

    Namespace Exceptions
        Public Class ConfigurationOfAnnouncementHallNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پیکربندی مرتبط با سالن اعلام بار یافت نشد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace TransportTarrifs

    Public Class R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure

        Public Sub New()
            MyBase.New()
            _AHId = 0
            _AHSGId = 0
            _TargetCityId = Int64.MinValue
            _Tarrif = 0
            _DateTimeMilladi = Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _OActive = False
        End Sub

        Public Sub New(ByVal YourAHId As Int64, YourAHSGId As Int64, YourTargetCityId As Int64, YourTarrif As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourOActive As Boolean)
            _AHId = YourAHId
            _AHSGId = YourAHSGId
            _TargetCityId = YourTargetCityId
            _Tarrif = YourTarrif
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Time = YourTime
            _OActive = YourOActive
        End Sub


        Public Property AHId As Int64
        Public Property AHSGId As Int64
        Public Property TargetCityId As Int64
        Public Property Tarrif As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property OActive As Boolean

    End Class

    Public Class R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsManager
        Private _DateTime As New R2DateTime

        Public Sub TransportTarrifRegistering(YourTargetCityId As Int64, YourSourceCityId As Int64, YourAHId As Int64, YourAHSGId As Int64, YourTarrif As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs Set OActive=0
                                      where SourceCityId=" & YourSourceCityId & " and TargetCityId=" & YourTargetCityId & " and AHId=" & YourAHId & " and AHSGId=" & YourAHSGId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Insert R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs(AHId,AHSGId,SourceCityId,TargetCityId,Tarrif,DateTimeMilladi,DateShamsi,Time,OActive)
                                      values(" & YourAHId & "," & YourAHSGId & "," & YourSourceCityId & "," & YourTargetCityId & "," & YourTarrif & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "',1)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSTransportTarrif(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Try
                Dim DS As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs Where (AHId=" & YourNSS.AHId & ") and (AHSGId=" & YourNSS.AHSGId & ") and (TargetCityId=" & YourNSS.nCityCode & ") and (SourceCityId=" & YourNSS.nBarSource & ") and OActive=1", 3600, DS, New Boolean).GetRecordsCount() = 0 Then Throw New TransportPriceTarrifNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure(DS.Tables(0).Rows(0).Item("AHId"), DS.Tables(0).Rows(0).Item("AHSGId"), DS.Tables(0).Rows(0).Item("TargetCityId"), DS.Tables(0).Rows(0).Item("Tarrif"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("OActive"))
            Catch exx As TransportPriceTarrifNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetUltimateTransportTarrif(YourAHSGId As Int64, YournTonaj As Double, YourTarrif As Int64) As Double
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.Parameters.Add("@AHSGId", SqlDbType.BigInt) : CmdSql.Parameters("@AHSGId").Value = YourAHSGId
                CmdSql.Parameters.Add("@Tarrif", SqlDbType.BigInt) : CmdSql.Parameters("@Tarrif").Value = YourTarrif
                CmdSql.Parameters.Add("@Tonaj", SqlDbType.Float) : CmdSql.Parameters("@Tonaj").Value = YournTonaj
                CmdSql.CommandType = CommandType.StoredProcedure
                CmdSql.CommandText = "R2PrimaryTransportationAndLoadNotification.dbo.GetUltimateTransportTarrif"
                Dim Tarrif = CmdSql.ExecuteScalar
                CmdSql.Connection.Close()
                Return Tarrif
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTransportTarrifsManagement
        Public Shared Function GetNSSTransportTarrif(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs Where (AHId=" & YourNSS.AHId & ") and (AHSGId=" & YourNSS.AHSGId & ") and (TargetCityId=" & YourNSS.nCityCode & ") and OActive=1", 3600, DS, New Boolean).GetRecordsCount() = 0 Then Throw New TransportPriceTarrifNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure(DS.Tables(0).Rows(0).Item("AHId"), DS.Tables(0).Rows(0).Item("AHSGId"), DS.Tables(0).Rows(0).Item("TargetCityId"), DS.Tables(0).Rows(0).Item("Tarrif"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("OActive"))
            Catch exx As TransportPriceTarrifNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

    Namespace Exceptions
        Public Class TransportPriceTarrifNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نرخ حمل یا تعرفه برای مسیر مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace TransportTarrifsParameters

    Public MustInherit Class R2CoreTransportationAndLoadNotificationTransportTarrifsParameters
        Inherits R2CoreConfigurations
        Public Shared Shadows ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Two_Baskool As Int64 = 1
        Public Shared ReadOnly Property Three_Baskool As Int64 = 2
        Public Shared ReadOnly Property Four_Baskool As Int64 = 3
        Public Shared ReadOnly Property LastNight As Int64 = 4
        Public Shared ReadOnly Property Two_LoadingLocation As Int64 = 5
        Public Shared ReadOnly Property Three_LoadingLocation As Int64 = 6
        Public Shared ReadOnly Property Four_LoadingLocation As Int64 = 7
        Public Shared ReadOnly Property Project As Int64 = 9
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersStructure

        Public Sub New()
            MyBase.New()
            _TPTPId = Int64.MinValue
            _TPTPName = String.Empty
            _TPTPTitle = String.Empty
            _TPTPColor = String.Empty
            _Core = String.Empty
            _UserId = Int64.MinValue
            _DateTimeMilladi = DateTime.Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _ViewFlag = Boolean.FalseString
            _Active = Boolean.FalseString
            _Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourTPTPId As Int64, YourTPTPName As String, YourTPTPTitle As String, YourTPTPColor As String, YourCore As String, YourUserId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            _TPTPId = YourTPTPId
            _TPTPName = YourTPTPName
            _TPTPTitle = YourTPTPTitle
            _TPTPColor = YourTPTPColor
            _Core = YourCore
            _UserId = YourUserId
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Time = YourTime
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property TPTPId As Int64
        Public Property TPTPName As String
        Public Property TPTPTitle As String
        Public Property TPTPColor As String
        Public Property Core As String
        Public Property UserId As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure

        Public Sub New()
            MyBase.New()
            _TPTPDId = Int64.MinValue
            _AHSGId = Int64.MinValue
            _TPTPId = Int64.MinValue
            _Mblgh = Int64.MaxValue
            _DateTimeMilladi = DateTime.Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _RelationActive = Boolean.FalseString
            _Checked = Boolean.FalseString
            _TPTPTitle = String.Empty
        End Sub

        Public Sub New(YourTPTPDId As Int64, YourAHSGId As Int64, YourTPTPId As Int64, YourMblgh As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourRelationActive As Boolean, YourChecked As Boolean, YourTPTPTitle As String)
            _TPTPDId = YourTPTPDId
            _AHSGId = YourAHSGId
            _TPTPId = YourTPTPId
            _Mblgh = YourMblgh
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Time = YourTime
            _RelationActive = YourRelationActive
            _Checked = YourChecked
            _TPTPTitle = YourTPTPTitle
        End Sub

        Public Property TPTPDId As Int64
        Public Property AHSGId As Int64
        Public Property TPTPId As Int64
        Public Property Mblgh As Int64
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property RelationActive As Boolean
        Public Property Checked As Boolean
        Public Property TPTPTitle As String
    End Class

    Public Class R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsParametersManager

        Public Function GetNSSTransportTarrifsParameterDetail(YourTTPDId As Int64) As R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure
            Try
                Dim DS As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                      "Select Top 1 TransportPriceTarrifsParameters.TPTPTitle,Details.* from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParametersDetails as Details
                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On Details.AHSGId=AnnouncementHallSubGroups.AHSGId 
                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParameters as TransportPriceTarrifsParameters On Details.TPTPId=TransportPriceTarrifsParameters.TPTPId 
                       Where Details.TPTPDId=" & YourTTPDId & "", 3600, DS, New Boolean).GetRecordsCount = 0 Then
                    Throw New TransportPriceTarrifParameterDetailNotFoundException
                End If
                Return New R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure(DS.Tables(0).Rows(0).Item("TPTPDId"), DS.Tables(0).Rows(0).Item("AHSGId"), DS.Tables(0).Rows(0).Item("TPTPId"), DS.Tables(0).Rows(0).Item("Mblgh"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("RelationActive"), False, DS.Tables(0).Rows(0).Item("TPTPTitle").trim)
            Catch ex As TransportPriceTarrifParameterDetailNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetListofTransportTarrifsParams(YourTPTParams As String) As List(Of R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure)
            ' Standard String : TPTPDId1:0;TPTPDId2:1;.....
            Try
                Dim Params As String() = YourTPTParams.Split(";")
                Dim Lst = New List(Of R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure)
                If Params(0).Trim = String.Empty Then Return Lst
                For Loopx As Int64 = 0 To Params.Length - 1
                    Dim TPTParamDetailId As Int64 = Params(Loopx).Split(":")(0).Trim
                    Dim Checked As Boolean = IIf(Params(Loopx).Split(":")(1).Trim = "1", True, False)
                    Dim NSS = GetNSSTransportTarrifsParameterDetail(TPTParamDetailId)
                    NSS.Checked = Checked
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As TransportPriceTarrifParameterDetailNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetListofTransportTarrifsParams(YourNSSAHSG As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure)
            Try
                Dim DS As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                      "Select TransportPriceTarrifsParameters.TPTPTitle,Details.*,0 as Checked from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParametersDetails as Details
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On Details.AHSGId=AnnouncementHallSubGroups.AHSGId 
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParameters as TransportPriceTarrifsParameters On Details.TPTPId=TransportPriceTarrifsParameters.TPTPId 
                       Where AnnouncementHallSubGroups.AHSGId=" & YourNSSAHSG.AHSGId & " AND AnnouncementHallSubGroups.Active=1 AND Details.RelationActive=1 AND TransportPriceTarrifsParameters.Active=1 AND TransportPriceTarrifsParameters.Deleted=0
                       Order By TransportPriceTarrifsParameters.TPTPId ", 3600, DS, New Boolean).GetRecordsCount = 0 Then
                    Throw New TransportPriceTarrifParameterDetailsforAHSGNotFoundException
                End If
                Dim Lst = New List(Of R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows().Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardTransportTarrifsParametersDetailsStructure(DS.Tables(0).Rows(Loopx).Item("TPTPDId"), DS.Tables(0).Rows(Loopx).Item("AHSGId"), DS.Tables(0).Rows(Loopx).Item("TPTPId"), DS.Tables(0).Rows(Loopx).Item("Mblgh"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("Time"), DS.Tables(0).Rows(Loopx).Item("RelationActive"), DS.Tables(0).Rows(Loopx).Item("Checked"), DS.Tables(0).Rows(Loopx).Item("TPTPTitle")))
                Next
                Return Lst
            Catch ex As TransportPriceTarrifParameterDetailsforAHSGNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function HaveAnyTransportTarrifsParams(YourNSSAHSG As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) As Boolean
            Try
                Dim DS As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                      "Select TransportPriceTarrifsParameters.TPTPId from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParametersDetails as Details
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AnnouncementHallSubGroups On Details.AHSGId=AnnouncementHallSubGroups.AHSGId 
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifsParameters as TransportPriceTarrifsParameters On Details.TPTPId=TransportPriceTarrifsParameters.TPTPId 
                       Where AnnouncementHallSubGroups.AHSGId=" & YourNSSAHSG.AHSGId & " AND AnnouncementHallSubGroups.Active=1 AND Details.RelationActive=1 AND TransportPriceTarrifsParameters.Active=1 AND TransportPriceTarrifsParameters.Deleted=0
                       Order By TransportPriceTarrifsParameters.TPTPId ", 3600, DS, New Boolean).GetRecordsCount = 0 Then
                    Return False
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTotalofTransportTarrifsParameters(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Int64
            Try
                Dim Total As Int64 = 0
                Dim Params = YourNSS.TPTParams.Split(";")
                If Params(0) = String.Empty Then Return 0
                For Loopx As Int64 = 0 To Params.Length - 1
                    Dim TPTPDId As Int64 = Params(Loopx).Split(":")(0)
                    Dim Checked As Boolean = Params(Loopx).Split(":")(1)
                    Dim NSS = GetNSSTransportTarrifsParameterDetail(TPTPDId)
                    If Checked Then
                        Total = Total + NSS.Mblgh
                    End If
                Next
                Return Total
            Catch ex As TransportPriceTarrifParameterDetailNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTransportTarrifsComposit(YourTPTParams As String) As String
            ' Standard String : TPTPDId1:0;TPTPDId2:1;.....
            Try
                Dim Params As String() = YourTPTParams.Split(";")
                If Params(0).Trim = String.Empty Then Return String.Empty
                Dim SB = New StringBuilder
                For Loopx As Int64 = 0 To Params.Length - 1
                    Dim TPTParamDetailId As Int64 = Params(Loopx).Split(":")(0).Trim
                    Dim Checked As Boolean = IIf(Params(Loopx).Split(":")(1).Trim = "1", True, False)
                    Dim NSS = GetNSSTransportTarrifsParameterDetail(TPTParamDetailId)
                    If Checked Then SB.AppendLine(NSS.TPTPTitle + " : " + IIf(NSS.Mblgh = 0, "توافقی", NSS.Mblgh.ToString))
                Next
                Return SB.ToString
            Catch ex As TransportPriceTarrifParameterDetailNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class

    Namespace Exceptions
        Public Class TransportPriceTarrifParameterDetailNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پارامتر موثر در تعرفه حمل با شاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class TransportPriceTarrifParameterDetailsforAHSGNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پارامتر موثر در تعرفه حمل مرتبط  با زیرگروه اعلام بار با شاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class TransportPriceTarrifParameterDetailsNotAdjustedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "پارامترهای موثر در تعرفه حمل به درستی انتخاب و تنظیم نشده اند"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace Turns

    Public Enum TurnType
        None = 0
        Temporary = 1 'موقتی
        Permanent = 2 'دائمی
    End Enum

    Public MustInherit Class TurnStatuses
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Registered As Int64 = 1
        Public Shared ReadOnly Property CancelledUser As Int64 = 2
        Public Shared ReadOnly Property CancelledUnderScore As Int64 = 3
        Public Shared ReadOnly Property CancelledSystem As Int64 = 4
        Public Shared ReadOnly Property CancelledLoadPermissionCancelled As Int64 = 5
        Public Shared ReadOnly Property UsedLoadPermissionRegistered As Int64 = 6
        Public Shared ReadOnly Property UsedLoadAllocationRegistered As Int64 = 7
        Public Shared ReadOnly Property ResuscitationLoadPermissionCancelled As Int64 = 8
        Public Shared ReadOnly Property ResuscitationLoadAllocationCancelled As Int64 = 9
        Public Shared ReadOnly Property ResuscitationUser As Int64 = 10
        Public Shared ReadOnly Property TurnExpired As Int64 = 11

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTurnStatusStructure
        Public Sub New()
            _TurnStatusId = Int64.MinValue
            _TurnStatusTitle = String.Empty
            _TurnStatusColor = String.Empty
        End Sub

        Public Sub New(ByVal YourTurnStatusId As Int64, ByVal YourTurnStatusTitle As String, YourTurnStatusColor As String)
            _TurnStatusId = YourTurnStatusId
            _TurnStatusTitle = YourTurnStatusTitle
            _TurnStatusColor = YourTurnStatusColor
        End Sub

        Public Property TurnStatusId As Int64
        Public Property TurnStatusTitle As String
        Public Property TurnStatusColor As String
        Public Property Description As String
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTurnStructure
        Public Sub New()
            MyBase.New()
            _nEnterExitId = Int64.MinValue
            _EnterDate = String.Empty
            _EnterTime = String.Empty
            _NSSTruckDriver = Nothing
            _bFlagDriver = True
            _nUserIdEnter = Int64.MinValue
            _BillOfLadingNumber = String.Empty
            _OtaghdarTurnNumber = String.Empty
            _StrCardNo = Int64.MinValue
            _TurnStatus = Turns.TurnStatuses.None
            _RegisteringTimeStamp = DateTime.Now
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourBillOfLadingNumber As String, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64, YourTurnStatus As Int64, YourRegisteringTimeStamp As DateTime)
            _nEnterExitId = YournEnterExitId
            _EnterDate = YourEnterDate
            _EnterTime = YourEnterTime
            _NSSTruckDriver = YourNSSTruckDriver
            _bFlagDriver = YourbFlagDriver
            _nUserIdEnter = YournUserIdEnter
            _BillOfLadingNumber = YourBillOfLadingNumber
            _OtaghdarTurnNumber = YourOtaghdarTurnNumber
            _StrCardNo = YourStrCardNo
            _TurnStatus = YourTurnStatus
            _RegisteringTimeStamp = YourRegisteringTimeStamp
        End Sub

        Public Property nEnterExitId As Int64
        Public Property EnterDate As String
        Public Property EnterTime As String
        Public Property NSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
        Public Property bFlagDriver As Boolean
        Public Property nUserIdEnter As Int64
        Public Property BillOfLadingNumber As String
        Public Property OtaghdarTurnNumber As String
        Public Property StrCardNo As Int64
        Public Property TurnStatus As Int64
        Public Property RegisteringTimeStamp As DateTime

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
        Inherits R2CoreTransportationAndLoadNotificationStandardTurnStructure
        Public Sub New()
            MyBase.New()
            _LicensePlatePString = String.Empty
            _TurnStatusTitle = String.Empty
            _UserName = String.Empty
            _TruckDriver = String.Empty
            _LastChangedDate = String.Empty
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourBillOfLadingNumber As String, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64, YourTurnStatus As Int64, YourRegisteringTimeStamp As DateTime, YourLicensePlatePString As String, YourTurnStatusTitle As String, YourUserName As String, YourTruckDriver As String, YourLastChangedDate As String)
            MyBase.New(YournEnterExitId, YourEnterDate, YourEnterTime, YourNSSTruckDriver, YourbFlagDriver, YournUserIdEnter, YourBillOfLadingNumber, YourOtaghdarTurnNumber, YourStrCardNo, YourTurnStatus, YourRegisteringTimeStamp)
            _LicensePlatePString = YourLicensePlatePString
            _TurnStatusTitle = YourTurnStatusTitle
            _UserName = YourUserName
            _TruckDriver = YourTruckDriver
            _LastChangedDate = YourLastChangedDate
        End Sub

        Public Property LicensePlatePString As String
        Public Property TurnStatusTitle As String
        Public Property UserName As String
        Public Property TruckDriver As String
        Public Property LastChangedDate As String
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTurnCreditStructure
        Public Sub New()
            MyBase.New()
            SeqTId = Int64.MinValue
            UserId = Int64.MinValue
            SignificantTurnId = Int64.MinValue
            OtaghdarTurnNumber = String.Empty
            DateTimeMilladi = Now
            DateShamsi = String.Empty
            Time = String.Empty
            Active = Boolean.FalseString
            ViewFlag = Boolean.FalseString
            Deleted = Boolean.TrueString
        End Sub

        Public Sub New(YourSeqTId As Int64, YourUserId As Int64, YourSignificantTurnId As Int64, YourOtaghdarTurnNumber As String, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourActive As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
            SeqTId = YourSeqTId
            UserId = YourUserId
            SignificantTurnId = YourSignificantTurnId
            OtaghdarTurnNumber = YourOtaghdarTurnNumber
            DateTimeMilladi = YourDateTimeMilladi
            DateShamsi = YourDateShamsi
            Time = YourTime
            Active = YourActive
            ViewFlag = YourViewFlag
            Deleted = YourDeleted
        End Sub

        Public Property SeqTId As Int64
        Public Property UserId As Int64
        Public Property SignificantTurnId As Int64
        Public Property OtaghdarTurnNumber As String
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property Active As Boolean
        Public Property ViewFlag As Boolean
        Public Property Deleted As Boolean

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardActiveTurnStructure
        Inherits R2CoreTransportationAndLoadNotificationStandardTurnStructure

        Public Sub New()
            MyBase.New
            TruckSmartCardNo = String.Empty
        End Sub

        Public Sub New(YourTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure, YourTruckSmartCardNo As String, YourPelak As String, YourSerial As String)
            MyBase.New(YourTurn.nEnterExitId, YourTurn.EnterDate, YourTurn.EnterTime, YourTurn.NSSTruckDriver, YourTurn.bFlagDriver, YourTurn.nUserIdEnter, YourTurn.BillOfLadingNumber, YourTurn.OtaghdarTurnNumber, YourTurn.StrCardNo, YourTurn.TurnStatus, YourTurn.RegisteringTimeStamp)
            _TruckSmartCardNo = YourTruckSmartCardNo
            _Pelak = YourPelak
            _Serial = YourSerial
        End Sub

        Public Property TruckSmartCardNo As String
        Public Property Pelak As String
        Public Property Serial As String


    End Class

    Public Class R2CoreTransportationAndLoadNotificationInstanceTurnsManager
        Private _DateTime As New R2DateTime

        Public Function GetAllOfCurrentActiveTurns() As List(Of R2CoreTransportationAndLoadNotificationStandardActiveTurnStructure)
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim DS As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                            "Select  Turns.*,Cars.strBodyNo as TruckSmartCardNo,Cars.strCarNo as Pelak,Cars.strCarSerialNo as Serial  from dbtransport.dbo.tbEnterExit as Turns
                                 Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar 
                                 Where Cars.ViewFlag=1 and (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10)
                                 Order By Turns.nEnterExitId", 0, DS, New Boolean).GetRecordsCount = 0 Then Throw New AnyActiveTurnNotExistException
                Dim Lst = New List(Of R2CoreTransportationAndLoadNotificationStandardActiveTurnStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardActiveTurnStructure(New R2CoreTransportationAndLoadNotification.Turns.R2CoreTransportationAndLoadNotificationStandardTurnStructure(DS.Tables(0).Rows(Loopx).Item("nEnterExitId"), DS.Tables(0).Rows(Loopx).Item("StrEnterDate").trim, DS.Tables(0).Rows(Loopx).Item("StrEnterTime").trim, InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(DS.Tables(0).Rows(Loopx).Item("nDriverCode")), False), DS.Tables(0).Rows(Loopx).Item("bFlagDriver"), DS.Tables(0).Rows(Loopx).Item("nUserIdEnter"), DS.Tables(0).Rows(Loopx).Item("BillOfLadingNumber").trim, DS.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber").trim, DS.Tables(0).Rows(Loopx).Item("StrCardNo"), DS.Tables(0).Rows(Loopx).Item("TurnStatus"), DS.Tables(0).Rows(Loopx).Item("RegisteringTimeStamp")), DS.Tables(0).Rows(Loopx).Item("TruckSmartCardNo"), DS.Tables(0).Rows(Loopx).Item("Pelak"), DS.Tables(0).Rows(Loopx).Item("Serial")))
                Next
                Return Lst
            Catch ex As AnyActiveTurnNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTurnStatus(YourTurnStatusId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStatusStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                         "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses Where TurnStatusId=" & YourTurnStatusId & "", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnStatusNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnStatusStructure = New R2CoreTransportationAndLoadNotificationStandardTurnStatusStructure
                NSS.TurnStatusId = Ds.Tables(0).Rows(0).Item("TurnStatusId")
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle")
                NSS.TurnStatusColor = Ds.Tables(0).Rows(0).Item("TurnStatusColor")
                NSS.Description = Ds.Tables(0).Rows(0).Item("Description")
                Return NSS
            Catch ex As TurnStatusNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetFirstActiveTurn(YourNSSSequentialTurn As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim DS As DataSet = Nothing
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "
                  Select Top 1 * from dbtransport.dbo.tbEnterExit as Turns
                  Where (Turns.TurnStatus=" & TurnStatuses.Registered & " or Turns.TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & " or Turns.TurnStatus=" & TurnStatuses.ResuscitationUser & ") 
                        and substring(Turns.OtaghdarTurnNumber,1,1)='" & YourNSSSequentialTurn.SequentialTurnKeyWord & "' 
                  Order By Turns.nEnterExitId", 300, DS, New Boolean).GetRecordsCount = 0 Then Throw New FirstActiveTurnNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardTurnStructure(DS.Tables(0).Rows(0).Item("nEnterExitId"), DS.Tables(0).Rows(0).Item("StrEnterDate").trim, DS.Tables(0).Rows(0).Item("StrEnterTime").trim, InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(DS.Tables(0).Rows(0).Item("nDriverCode")), False), DS.Tables(0).Rows(0).Item("bFlagDriver"), DS.Tables(0).Rows(0).Item("nUserIdEnter"), DS.Tables(0).Rows(0).Item("BillOfLadingNumber").trim, DS.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, DS.Tables(0).Rows(0).Item("StrCardNo"), DS.Tables(0).Rows(0).Item("TurnStatus"), DS.Tables(0).Rows(0).Item("RegisteringTimeStamp"))
            Catch ex As FirstActiveTurnNotFoundException
                Throw New FirstActiveTurnNotFoundException
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetLastActiveTurn(YourNSSCar As R2StandardCarStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from dbtransport.dbo.TbEnterExit Where StrCardNo=" & YourNSSCar.nIdCar & " and (bFlagDriver=0) Order By nEnterExitId desc", 0, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New LastActiveTurnNotFoundException
                End If
                Return New R2CoreTransportationAndLoadNotificationStandardTurnStructure(Ds.Tables(0).Rows(0).Item("nEnterExitId"), Ds.Tables(0).Rows(0).Item("StrEnterDate"), Ds.Tables(0).Rows(0).Item("StrEnterTime"), InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), False), Ds.Tables(0).Rows(0).Item("bFlagDriver"), Ds.Tables(0).Rows(0).Item("nUserIdEnter"), Ds.Tables(0).Rows(0).Item("BillOfLadingNumber").trim, Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, Ds.Tables(0).Rows(0).Item("StrCardNo"), Ds.Tables(0).Rows(0).Item("TurnStatus"), Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp"))
            Catch ex As LastActiveTurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTurns(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                   "Select  (Select Count(*) from dbtransport.dbo.tbEnterExit as TurnsX
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On SUBSTRING(TurnsX.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS=SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS
                             Where SeqT.Active=1 and SeqT.Deleted=0 and SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS=SUBSTRING(DataBox.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS and TurnsX.nEnterExitId<DataBox.nEnterExitId and (TurnsX.TurnStatus=1 or TurnsX.TurnStatus=7 or TurnsX.TurnStatus=8 or TurnsX.TurnStatus=9 or TurnsX.TurnStatus=10)) as TurnDistanceToValidity,DataBox.*
                    from
                      (Select Top 5 Turns.nEnterExitId,Turns.StrEnterDate,Turns.StrEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.StrCardNo,
                                    Turns.TurnStatus,Cars.strCarNo +'-'+ Cars.strCarSerialNo as LPString,Persons.strPersonFullName,TurnStatuses.TurnStatusTitle,SoftwareUsers.UserName as Username,Turns.RegisteringTimeStamp
                       from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
	                     Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1
	                     Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                         Inner Join dbtransport.dbo.TbPerson as Persons On Drivers.nIDDriver=Persons.nIDPerson 
                         Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Drivers.nIDDriver=CarAndPersons.nIDPerson
                         Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
                         Inner Join dbtransport.dbo.tbCarType as CarTypes On Cars.snCarType=CarTypes.snCarType 
                         Inner Join dbtransport.dbo.tbEnterExit as Turns On Cars.nIDCar=Turns.strCardno 
                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatuses On Turns.TurnStatus=TurnStatuses.TurnStatusId 
                         Inner Join R2Primary.dbo.TblSoftwareUsers as TurnCreatorUsers On Turns.nUserIdEnter=TurnCreatorUsers.UserId 
                       Where SoftwareUsers.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and EntityRelations.RelationActive=1 and Cars.ViewFlag=1 and CarAndPersons.snRelation=2 
                             and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
	                   Order By CarAndPersons.nIDCarAndPerson Desc,Turns.nEnterExitId Desc) as DataBox
                    Order By DataBox.nEnterExitId Desc", 300, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                    NSS.nEnterExitId = Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")
                    NSS.EnterDate = Ds.Tables(0).Rows(Loopx).Item("StrEnterDate")
                    NSS.EnterTime = Ds.Tables(0).Rows(Loopx).Item("StrEnterTime")
                    Dim InstanceTruckDriver = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                    NSS.NSSTruckDriver = InstanceTruckDriver.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nDriverCode")), False)
                    NSS.bFlagDriver = Ds.Tables(0).Rows(Loopx).Item("bFlagDriver")
                    NSS.nUserIdEnter = Ds.Tables(0).Rows(Loopx).Item("nUserIdEnter")
                    NSS.TurnStatus = Ds.Tables(0).Rows(Loopx).Item("TurnStatus")
                    NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber").ToString + " - " + IIf(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTurnReadeyforLoadAllocationRegistering(NSS), Ds.Tables(0).Rows(Loopx).Item("TurnDistanceToValidity").ToString, "اعتبار ندارد")
                    NSS.StrCardNo = Ds.Tables(0).Rows(Loopx).Item("StrCardNo")
                    NSS.LicensePlatePString = Ds.Tables(0).Rows(Loopx).Item("LPString").trim
                    NSS.TruckDriver = Ds.Tables(0).Rows(Loopx).Item("strPersonFullName").trim
                    NSS.TurnStatusTitle = Ds.Tables(0).Rows(Loopx).Item("TurnStatusTitle").trim
                    NSS.UserName = Ds.Tables(0).Rows(Loopx).Item("Username").trim
                    NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(Loopx).Item("RegisteringTimeStamp")
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTurns(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                   "Select Top 5 Turns.nEnterExitId,Turns.StrEnterDate,Turns.StrEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.StrCardNo,
                                      Turns.TurnStatus,Turns.strElamDate , Cars.strCarNo +'-'+ Cars.strCarSerialNo as LPString,Turns.strDriverName,TurnStatus.TurnStatusTitle,TurnStatus.Description,TurnCreatorUsers.UserName as Username,Turns.RegisteringTimeStamp
                    From dbtransport.dbo.tbEnterExit as Turns
                       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On Turns.TurnStatus=TurnStatus.TurnStatusId
                       Inner Join R2Primary.DBO.TblSoftwareUsers AS TurnCreatorUsers On Turns.nUserIdEnter=TurnCreatorUsers.UserId 
                       Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar 
                    Where Cars.ViewFlag = 1 And Cars.nIDCar = " & YourNSSTruck.NSSCar.nIdCar & " Order By Turns.nEnterExitId Desc", 120, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New TurnNotFoundException
                End If
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                    NSS.nEnterExitId = Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")
                    NSS.EnterDate = Ds.Tables(0).Rows(Loopx).Item("StrEnterDate")
                    NSS.EnterTime = Ds.Tables(0).Rows(Loopx).Item("StrEnterTime")
                    Dim InstanceTruckDriver = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                    NSS.NSSTruckDriver = InstanceTruckDriver.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nDriverCode")), False)
                    NSS.bFlagDriver = Ds.Tables(0).Rows(Loopx).Item("bFlagDriver")
                    NSS.nUserIdEnter = Ds.Tables(0).Rows(Loopx).Item("nUserIdEnter")
                    NSS.TurnStatus = Ds.Tables(0).Rows(Loopx).Item("TurnStatus")
                    NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber").ToString
                    NSS.StrCardNo = Ds.Tables(0).Rows(Loopx).Item("StrCardNo")
                    NSS.LicensePlatePString = Ds.Tables(0).Rows(Loopx).Item("LPString").trim
                    NSS.TruckDriver = Ds.Tables(0).Rows(Loopx).Item("strDriverName").trim
                    NSS.TurnStatusTitle = Ds.Tables(0).Rows(Loopx).Item("TurnStatusTitle").trim
                    NSS.UserName = Ds.Tables(0).Rows(Loopx).Item("Username").trim
                    NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(Loopx).Item("RegisteringTimeStamp")
                    If Not DBNull.Value.Equals(Ds.Tables(0).Rows(Loopx).Item("strelamdate")) Then
                        NSS.LastChangedDate = Ds.Tables(0).Rows(Loopx).Item("strelamdate").trim
                    End If
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As TruckDriverNotFoundException
                Throw ex
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTurn(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                   "Select Top 1 TurnCreatorUsers.UserName,TurnStatus.TurnStatusTitle,Persons.strPersonFullName,Cars.strCarNo+'-'+Cars.strCarSerialNo as LPString,Turns.nEnterExitId,Turns.strEnterDate,Turns.strEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.strCardno,Turns.TurnStatus,Turns.RegisteringTimeStamp,Turns.strElamDate
                   from dbtransport.dbo.tbEnterExit as Turns
                       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On Turns.TurnStatus=TurnStatus.TurnStatusId
                       Inner Join R2Primary.DBO.TblSoftwareUsers AS TurnCreatorUsers On Turns.nUserIdEnter=TurnCreatorUsers.UserId 
                       Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar 
                       Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Cars.nIDCar=CarAndPersons.nIDCar 
                       Inner Join dbtransport.dbo.TbDriver as Drivers On CarAndPersons.nIDPerson=Drivers.nIDDriver 
	                   Inner Join dbtransport.dbo.TbPerson as Persons On Persons.nIDPerson=Drivers.nIDDriver 
	                   Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Drivers.nIDDriver=EntityRelations.E2 
	                   Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On EntityRelations.E1=SoftwareUsers.UserId 
                     Where (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10) and Cars.ViewFlag=1  and CarAndPersons.snRelation=2
                           and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and EntityRelations.RelationActive=1 and SoftwareUsers.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 
                           and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                     Order By CarAndPersons.nIDCarAndPerson Desc,Turns.nEnterExitId Desc", 300, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                NSS.NSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), False)
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.TurnStatus = Ds.Tables(0).Rows(0).Item("TurnStatus")
                NSS.LicensePlatePString = Ds.Tables(0).Rows(0).Item("LPString").trim
                NSS.TruckDriver = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle").trim
                NSS.UserName = Ds.Tables(0).Rows(0).Item("Username").trim
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                If Not DBNull.Value.Equals(Ds.Tables(0).Rows(0).Item("strelamdate")) Then
                    NSS.LastChangedDate = Ds.Tables(0).Rows(0).Item("strelamdate").trim
                End If
                Return NSS
            Catch ex As TruckDriverNotFoundException
                Throw ex
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSLastTurn(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                   "Select Top 1 TurnCreatorUsers.UserName,TurnStatus.TurnStatusTitle,Persons.strPersonFullName,Cars.strCarNo+'-'+Cars.strCarSerialNo as LPString,Turns.nEnterExitId,Turns.strEnterDate,Turns.strEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.strCardno,Turns.TurnStatus,Turns.RegisteringTimeStamp,Turns.strElamDate
                   from dbtransport.dbo.tbEnterExit as Turns
                       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On Turns.TurnStatus=TurnStatus.TurnStatusId
                       Inner Join R2Primary.DBO.TblSoftwareUsers AS TurnCreatorUsers On Turns.nUserIdEnter=TurnCreatorUsers.UserId 
                       Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar 
                       Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Cars.nIDCar=CarAndPersons.nIDCar 
                       Inner Join dbtransport.dbo.TbDriver as Drivers On CarAndPersons.nIDPerson=Drivers.nIDDriver 
	                   Inner Join dbtransport.dbo.TbPerson as Persons On Persons.nIDPerson=Drivers.nIDDriver 
	                   Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Drivers.nIDDriver=EntityRelations.E2 
	                   Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On EntityRelations.E1=SoftwareUsers.UserId 
                     Where Cars.ViewFlag=1  and CarAndPersons.snRelation=2
                           and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and EntityRelations.RelationActive=1 and SoftwareUsers.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 
                           and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                     Order By CarAndPersons.nIDCarAndPerson Desc,Turns.nEnterExitId Desc", 5, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                NSS.NSSTruckDriver = InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), False)
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.TurnStatus = Ds.Tables(0).Rows(0).Item("TurnStatus")
                NSS.LicensePlatePString = Ds.Tables(0).Rows(0).Item("LPString").trim
                NSS.TruckDriver = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle").trim
                NSS.UserName = Ds.Tables(0).Rows(0).Item("Username").trim
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                If Not DBNull.Value.Equals(Ds.Tables(0).Rows(0).Item("strelamdate")) Then
                    NSS.LastChangedDate = Ds.Tables(0).Rows(0).Item("strelamdate").trim
                End If
                Return NSS
            Catch ex As TruckDriverNotFoundException
                Throw ex
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTurn(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Users.UserName,TurnStatus.TurnStatusTitle,Person.strPersonFullName,Car.strCarNo+'-'+car.strCarSerialNo as LPString, EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,EnterExit.nDriverCode,EnterExit.bFlagDriver,EnterExit.nUserIdEnter,EnterExit.OtaghdarTurnNumber,EnterExit.strCardno,EnterExit.TurnStatus,EnterExit.RegisteringTimeStamp
                            from dbtransport.dbo.tbEnterExit as EnterExit 
                               Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                               Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On EnterExit.TurnStatus=TurnStatus.TurnStatusId
                               Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On EnterExit.nUserIdEnter=Users.UserId Where EnterExit.nEnterExitId=" & YourTurnId & "", 0, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                Dim InstanceTruckDriver = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                NSS.NSSTruckDriver = InstanceTruckDriver.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), False)
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.TurnStatus = Ds.Tables(0).Rows(0).Item("TurnStatus")
                NSS.LicensePlatePString = Ds.Tables(0).Rows(0).Item("LPString").trim
                NSS.TruckDriver = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle").trim
                NSS.UserName = Ds.Tables(0).Rows(0).Item("Username").trim
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                Return NSS
            Catch exx As TurnNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsTurnReadeyforLoadAllocationRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
            Try
                Return IsTurnReadeyforLoadAllocationRegistering_(YourNSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Function IsTurnReadeyforLoadAllocationRegistering_(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
            Try

                If YourNSSTurn.TurnStatus = TurnStatuses.Registered Or YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Sub LoadAllocationRegistering_(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'کنترل وضعیت نوبت
                If Not (YourNSSTurn.TurnStatus = TurnStatuses.Registered Or YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & " Where nEnterExitId=" & YourNSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As TurnHandlingNotAllowedBecuaseTurnStatusException
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoadAllocationRegistering(YourTurnId As Int64)
            Try
                Dim NSSTurn = GetNSSTurn(YourTurnId)
                LoadAllocationRegistering_(NSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoadAllocationRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Try
                LoadAllocationRegistering_(YourNSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function IsTurnReadyforLoadAllocationCancelling(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Try
                If YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadPermissionRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.TurnExpired Or
                   YourNSSTurn.TurnStatus = TurnStatuses.CancelledLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.CancelledSystem Or
                   YourNSSTurn.TurnStatus = TurnStatuses.CancelledUnderScore Or YourNSSTurn.TurnStatus = TurnStatuses.CancelledUser Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsTurnReadyforLoadAllocationChangePriority(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Try
                If YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadPermissionRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.TurnExpired Or
                   YourNSSTurn.TurnStatus = TurnStatuses.CancelledLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.CancelledSystem Or
                   YourNSSTurn.TurnStatus = TurnStatuses.CancelledUnderScore Or YourNSSTurn.TurnStatus = TurnStatuses.CancelledUser Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub LoadAllocationCancelling(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'کنترل وضعیت نوبت
                If Not (YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or
                        YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or
                        YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & " Where nEnterExitId=" & YourNSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As TurnNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw ex
            Catch ex As TurnHandlingNotAllowedBecuaseTurnStatusException
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSTruck(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 StrCardNo from dbtransport.dbo.TbEnterExit Where nEnterExitId=" & YourTurnId & "", 300, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New RelationBetweenTurnAndTruckNotFoundException
                End If
                Return InstanceTrucks.GetNSSTruck(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("StrCardNo")))
            Catch exx As RelationBetweenTurnAndTruckNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsTurnReadeyforLoadPermissionRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
            Try
                If YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub LoadPermissionRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure, YourTransaction As SqlCommand)
            Try
                'کنترل وضعیت نوبت
                If Not (YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                YourTransaction.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.UsedLoadPermissionRegistered & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & YourNSSTurn.nEnterExitId & ""
                YourTransaction.ExecuteNonQuery()
            Catch ex As GetNSSException
                Throw ex
            Catch ex As TurnHandlingNotAllowedBecuaseTurnStatusException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoadPermissionCancelling(YourTurnId As Int64, YourResuscitationFlag As Boolean)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim NSSTurn = InstanceTurns.GetNSSTurn(YourTurnId)
                'کنترل وضعیت نوبت
                If Not (NSSTurn.TurnStatus = TurnStatuses.UsedLoadPermissionRegistered) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                If YourResuscitationFlag = True Then
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & ",bFlag=0,bFlagDriver=0 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                Else
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledLoadPermissionCancelled & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Function GetNSSTurn(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 * from dbtransport.dbo.TbEnterExit Where StrCardNo=" & YourNSSTruck.NSSCar.nIdCar & " and (bFlagDriver=0) Order By nEnterExitId desc", 1, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New TurnNotFoundException
                End If
                Return New R2CoreTransportationAndLoadNotificationStandardTurnStructure(Ds.Tables(0).Rows(0).Item("nEnterExitId"), Ds.Tables(0).Rows(0).Item("StrEnterDate").trim, Ds.Tables(0).Rows(0).Item("StrEnterTime").trim, InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), True), Ds.Tables(0).Rows(0).Item("bFlagDriver"), Ds.Tables(0).Rows(0).Item("nUserIdEnter"), Ds.Tables(0).Rows(0).Item("BillOfLadingNumber").trim, Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, Ds.Tables(0).Rows(0).Item("StrCardNo"), Ds.Tables(0).Rows(0).Item("TurnStatus"), Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp"))
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTurn(YourNSSTurnRegisteringRequest As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 Turns.* from dbtransport.dbo.tbEnterExit as Turns
                        Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Turns.nEnterExitId=EntityRelations.E1 
                        Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests as TurnRegisterRequests On EntityRelations.E2=TurnRegisterRequests.TRRId 
                      Where EntityRelations.RelationActive=1 and EntityRelations.ERTypeId=1 and TurnRegisterRequests.TRRId=" & YourNSSTurnRegisteringRequest.TRRId & "", 0, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New TurnNotFoundException
                End If
                Return New R2CoreTransportationAndLoadNotificationStandardTurnStructure(Ds.Tables(0).Rows(0).Item("nEnterExitId"), Ds.Tables(0).Rows(0).Item("StrEnterDate").trim, Ds.Tables(0).Rows(0).Item("StrEnterTime").trim, InstanceTruckDrivers.GetNSSTruckDriver(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("nDriverCode")), False), Ds.Tables(0).Rows(0).Item("bFlagDriver"), Ds.Tables(0).Rows(0).Item("nUserIdEnter"), Ds.Tables(0).Rows(0).Item("BillOfLadingNumber").trim, Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, Ds.Tables(0).Rows(0).Item("StrCardNo"), Ds.Tables(0).Rows(0).Item("TurnStatus"), Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp"))
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTurnRegisteringTimeStampWithTurnType(YourTurnType As TurnType) As R2StandardDateAndTimeStructure
            Try
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim TurnRegisteringTimeStamp As DateTime = IIf(YourTurnType = TurnType.Permanent, InstanceConfiguration.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 4), _DateTime.GetCurrentDateTimeMilladi)
                Return New R2StandardDateAndTimeStructure(TurnRegisteringTimeStamp, Nothing, Nothing)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSLastTurnCredit(YourSeqTId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnCreditStructure
            Try
                Dim DS As DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                    "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnCredits 
                     Where SeqTId=" & YourSeqTId & " and Active=1 and Deleted=0 
                     Order By DateTimeMilladi Desc", 0, DS, New Boolean).GetRecordsCount = 0 Then
                    Throw New LastTurnCreditNotFoundException
                Else
                    Return New R2CoreTransportationAndLoadNotificationStandardTurnCreditStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("UserId"), DS.Tables(0).Rows(0).Item("SignificantTurnId"), DS.Tables(0).Rows(0).Item("OtaghdarTurnNumber").trim, DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi").trim, DS.Tables(0).Rows(0).Item("Time").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
                End If
            Catch ex As LastTurnCreditNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSSoftwareUser(YourTurn As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) As R2CoreStandardSoftwareUserStructure
            Try
                Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                Dim Ds As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 SoftwareUsers.UserId from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                         Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1
	                     Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                         Inner Join dbtransport.dbo.TbPerson as Persons On Drivers.nIDDriver=Persons.nIDPerson 
                         Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Drivers.nIDDriver=CarAndPersons.nIDPerson
                         Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
                         Inner Join dbtransport.dbo.tbEnterExit as Turns On Cars.nIDCar=Turns.strCardno 
                      Where Turns.nEnterExitId=" & YourTurn.nEnterExitId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 and EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and EntityRelations.RelationActive=1 and Cars.ViewFlag=1 and CarAndPersons.snRelation=2 
                             and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
	                   Order By SoftwareUsers.UserId DESC", 300, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New SoftWareUserNotFoundException
                End If
                Dim InstanceSoftwareUsers = New R2Core.SoftwareUserManagement.R2CoreInstanseSoftwareUsersManager
                Return InstanceSoftwareUsers.GetNSSUser(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("UserId")))
            Catch ex As SoftWareUserNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnsManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function ExistActiveTurn(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select * from dbtransport.dbo.tbEnterExit as Turns
                      Where (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10) and Turns.bFlagDriver=0 and
                             Turns.strCardno=" & YourNSSTruck.NSSCar.nIdCar & "", 0, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTurn(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Users.UserName,TurnStatus.TurnStatusTitle,Person.strPersonFullName,Car.strCarNo+'-'+car.strCarSerialNo as LPString, EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,EnterExit.nDriverCode,EnterExit.bFlagDriver,EnterExit.nUserIdEnter,EnterExit.OtaghdarTurnNumber,EnterExit.strCardno,EnterExit.TurnStatus,EnterExit.RegisteringTimeStamp
                            from dbtransport.dbo.tbEnterExit as EnterExit 
                               Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                               Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On EnterExit.TurnStatus=TurnStatus.TurnStatusId
                               Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On EnterExit.nUserIdEnter=Users.UserId Where EnterExit.nEnterExitId=" & YourTurnId & "", 0, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                NSS.NSSTruckDriver = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(Ds.Tables(0).Rows(0).Item("nDriverCode"))
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.TurnStatus = Ds.Tables(0).Rows(0).Item("TurnStatus")
                NSS.LicensePlatePString = Ds.Tables(0).Rows(0).Item("LPString").trim
                NSS.TruckDriver = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle").trim
                NSS.UserName = Ds.Tables(0).Rows(0).Item("Username").trim
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                Return NSS
            Catch exx As TurnNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTurn(YourSeqTId As Int64, YourTurnId As String, YourTargetYearFull As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim CurrentSalShamsiFull As String = _DateTime.GetCurrentSalShamsiFull
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select Users.UserName,TurnStatus.TurnStatusTitle,Person.strPersonFullName,Car.strCarNo+'-'+car.strCarSerialNo as LPString, EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,EnterExit.nDriverCode,EnterExit.bFlagDriver,EnterExit.nUserIdEnter,EnterExit.OtaghdarTurnNumber,EnterExit.strCardno,EnterExit.TurnStatus,EnterExit.RegisteringTimeStamp
                                from dbtransport.dbo.tbEnterExit as EnterExit 
                                  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On SUBSTRING(EnterExit.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS= SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS
                                  Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                  Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On EnterExit.TurnStatus=TurnStatus.TurnStatusId
                                  Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On EnterExit.nUserIdEnter=Users.UserId 
                                Where SeqT.SeqTId=" & YourSeqTId & " and SUBSTRING(EnterExit.OtaghdarTurnNumber,2,4)='" & YourTargetYearFull & "' and ltrim(rtrim(SUBSTRING(EnterExit.OtaghdarTurnNumber,7,20)))='" & YourTurnId & "'", 1, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure = New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                NSS.nEnterExitId = Ds.Tables(0).Rows(0).Item("nEnterExitId")
                NSS.EnterDate = Ds.Tables(0).Rows(0).Item("StrEnterDate")
                NSS.EnterTime = Ds.Tables(0).Rows(0).Item("StrEnterTime")
                NSS.NSSTruckDriver = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(Ds.Tables(0).Rows(0).Item("nDriverCode"))
                NSS.bFlagDriver = Ds.Tables(0).Rows(0).Item("bFlagDriver")
                NSS.nUserIdEnter = Ds.Tables(0).Rows(0).Item("nUserIdEnter")
                NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(0).Item("OtaghdarTurnNumber")
                NSS.StrCardNo = Ds.Tables(0).Rows(0).Item("StrCardNo")
                NSS.TurnStatus = Ds.Tables(0).Rows(0).Item("TurnStatus")
                NSS.LicensePlatePString = Ds.Tables(0).Rows(0).Item("LPString").trim
                NSS.TruckDriver = Ds.Tables(0).Rows(0).Item("strPersonFullName").trim
                NSS.TurnStatusTitle = Ds.Tables(0).Rows(0).Item("TurnStatusTitle").trim
                NSS.UserName = Ds.Tables(0).Rows(0).Item("Username").trim
                NSS.RegisteringTimeStamp = Ds.Tables(0).Rows(0).Item("RegisteringTimeStamp")
                Return NSS
            Catch exx As TurnNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub LoadPermissionRegistering(YourTurnId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Dim NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourTurnId)
                'کنترل وضعیت نوبت
                If Not (NSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select Top 1 nEnterExitId From dbtransport.dbo.TbEnterExit with (tablockx) Where nEnterExitId=" & YourTurnId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.UsedLoadPermissionRegistered & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As GetNSSException
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw ex
            Catch ex As TurnHandlingNotAllowedBecuaseTurnStatusException
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

        Public Shared Sub LoadPermissionCancelling(YourTurnId As Int64, YourResuscitationFlag As Boolean)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                'کنترل وضعیت نوبت
                If Not (NSSTurn.TurnStatus = TurnStatuses.UsedLoadPermissionRegistered) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select Top 1 nEnterExitId From dbtransport.dbo.TbEnterExit with (tablockx) Where nEnterExitId=" & YourTurnId & ""
                CmdSql.ExecuteNonQuery()
                If YourResuscitationFlag = True Then
                    If NSSTurn.RegisteringTimeStamp <> "2015-01-01 00:00:00.000" Then Throw New UnableResucitationTemporayTurnException
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & ",bFlag=0,bFlagDriver=0 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                Else
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledLoadPermissionCancelled & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As UnableResucitationTemporayTurnException
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

        'Public Shared Sub TurnExpirationCancelling(YourTurnId As Int64)
        '    Dim CmdSql As New SqlCommand
        '    CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
        '    Try
        '        Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
        '        'کنترل وضعیت نوبت
        '        If Not (NSSTurn.TurnStatus = TurnStatuses.Registered Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationUser) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException

        '        'تغییر وضعیت نوبت
        '        CmdSql.Connection.Open()
        '        CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
        '        CmdSql.CommandText = "Select Top 1 nEnterExitId From dbtransport.dbo.TbEnterExit with (tablockx) Where nEnterExitId=" & YourTurnId & ""
        '        CmdSql.ExecuteNonQuery()
        '        CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.TurnExpired & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
        '        CmdSql.ExecuteNonQuery()
        '        'ارسال تاییدیه صدور مجوز به آنلاین
        '        TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.DelNobat(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo, R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetNSSLoadTarget(NSSLoadCapacitorLoad.nCityCode).TargetTravelLength)

        '        CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

        '    Catch ex As Exception
        '        If CmdSql.Connection.State <> ConnectionState.Closed Then
        '            CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
        '        End If
        '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        '    End Try
        'End Sub

        Public Shared Function GetNSSTruck(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 StrCardNo from dbtransport.dbo.TbEnterExit Where nEnterExitId=" & YourTurnId & "", 1, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New RelationBetweenTurnAndTruckNotFoundException
                End If
                Return R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(Ds.Tables(0).Rows(0).Item("StrCardNo"))
            Catch exx As RelationBetweenTurnAndTruckNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTurnReadeyforLoadPermissionRegistering(YourTurnId As Int64) As Boolean
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                If NSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationUser Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Function IsTurnReadeyforLoadAllocationRegistering_(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
            Try

                If YourNSSTurn.TurnStatus = TurnStatuses.Registered Or YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTurnReadeyforLoadAllocationRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
            Try
                Return IsTurnReadeyforLoadAllocationRegistering_(YourNSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTerraficCardTypeforTurnRegisteringActive(YourNSS As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 TurnRegisteringActive from R2PrimaryTransportationAndLoadNotification.dbo.TblTerraficCardTypesforTurnRegistering Where TerraficCardTypeId=" & YourNSS.CardType & "", 3600, Ds, New Boolean)
                Return Ds.Tables(0).Rows(0).Item("TurnRegisteringActive")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTerraficCardTypeforTurnRegistering(YourNSS As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 TurnRegistering from R2PrimaryTransportationAndLoadNotification.dbo.TblTerraficCardTypesforTurnRegistering Where TerraficCardTypeId=" & YourNSS.CardType & "", 3600, Ds, New Boolean)
                Return Ds.Tables(0).Rows(0).Item("TurnRegistering")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace TurnPrinting
        Public Structure R2CoreTransportationAndLoadNotificationTurnPrintingInf
            Dim TurnId As Int64
            Dim TurnDate As String
            Dim TurnTime As String
            Dim MoneyWalletInventory As Int64
            Dim TruckDriver As String
            Dim LoaderType As String
            Dim LoaderFixType As String
            Dim TruckLP As String
            Dim TruckLPSerial As String
            Dim UserName As String
            Dim TerraficCard As String
            Dim TurnSequentialId As String
            Dim BlackList As String
            Dim AnnouncementHallTitle As String
            Dim AnnouncementHallSubGroupTitle As String
            Dim Description As String
        End Structure

        Public Class R2CoreTransportationAndLoadNotificationMClassTurnPrintingManager
            Private WithEvents _PrintDocumentNobat As PrintDocument = New PrintDocument()
            Private TurnPrintingInf As R2CoreTransportationAndLoadNotificationTurnPrintingInf

            Private Function GetTurnPrintingInf(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationTurnPrintingInf
                Try
                    Dim DS As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                      "Select Top 1 EnterExit.strDesc as Description,EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,RFIDCard.CardNo,RFIDCard.Charge,
                                    Person.strPersonFullName,LoaderType.LoaderTypeTitle,LoaderTypeFixStatus.LoaderTypeFixStatusTitle,Car.strCarNo,Car.strCarSerialNo,
	                                SoftwareUser.UserName,Substring(EnterExit.OtaghdarTurnNumber,7,20) as SequentialTurnId
	                                ,IsNull((Select Top 1 StrDesc from dbtransport.dbo.tbblacklist Where nTruckNo Collate Arabic_CI_AS_WS=Car.strCarNo Collate Arabic_CI_AS_WS and nPlakSerial Collate Arabic_CI_AS_WS=Car.strCarSerialNo Collate Arabic_CI_AS_WS and nPlakPlac=Car.nIDCity and flaga=0 Order By nID Desc),'') as BlackList,
                                    AH.AHTitle,AHSG.AHSGTitle
                       from dbtransport.dbo.tbEnterExit as EnterExit
                            Inner Join R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars as RFIDCardRCar On EnterExit.strCardno=RFIDCardRCar.nCarId
                            Inner Join R2Primary.dbo.TblRFIDCards as RFIDCard On RFIDCardRCar.CardId=RFIDCard.CardId
                            Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                            Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                            Inner Join R2PrimaryTransportationAndLoadNotification.DBO.TblLoaderTypes AS LoaderType On  LoaderType.LoaderTypeId=Car.snCarType
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypeFixStatuses as LoaderTypeFixStatus On LoaderType.LoaderTypeFixStatusId=LoaderTypeFixStatus.LoaderTypeFixStatusId
                            Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUser On EnterExit.nUserIdEnter=SoftwareUser.UserId
          					Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCar On EnterExit.strCardno=AHSGRCar.CarId
							Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRCar.AHSGId=AHSG.AHSGId
							Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups AS AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
							Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                       Where EnterExit.nEnterExitId=" & YourTurnId & " and RFIDCardRCar.RelationActive=1 
                             and ((DATEDIFF(SECOND,RFIDCardRCar.RelationTimeStamp,getdate())<240) or (RFIDCardRCar.RelationTimeStamp='2015-01-01 00:00:00.000'))  
                             and ((DATEDIFF(SECOND,AHSGRCar.RelationTimeStamp,getdate())<240) or (AHSGRCar.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                             and AHRAHSG.RelationActive=1 and AHSGRCar.RelationActive=1 
                       Order By AHSGRCar.Priority Asc,RFIDCardRCar.RelationId Desc,AHSGRCar.RelationId Desc", 1, DS, New Boolean).GetRecordsCount() = 0 Then Throw New TurnPrintingInfNotFoundException
                    Dim TurnPrintingInf As New R2CoreTransportationAndLoadNotificationTurnPrintingInf
                    TurnPrintingInf.TurnId = DS.Tables(0).Rows(0).Item("nEnterExitId")
                    TurnPrintingInf.TurnDate = DS.Tables(0).Rows(0).Item("strEnterDate").trim
                    TurnPrintingInf.TurnTime = DS.Tables(0).Rows(0).Item("strEnterTime").trim
                    TurnPrintingInf.MoneyWalletInventory = DS.Tables(0).Rows(0).Item("Charge")
                    TurnPrintingInf.TruckDriver = DS.Tables(0).Rows(0).Item("strPersonFullName").trim
                    TurnPrintingInf.LoaderType = DS.Tables(0).Rows(0).Item("LoaderTypeTitle").trim
                    TurnPrintingInf.LoaderFixType = DS.Tables(0).Rows(0).Item("LoaderTypeFixStatusTitle").trim
                    TurnPrintingInf.TruckLP = DS.Tables(0).Rows(0).Item("strCarNo").trim
                    TurnPrintingInf.TruckLPSerial = DS.Tables(0).Rows(0).Item("strCarSerialNo").trim
                    TurnPrintingInf.UserName = DS.Tables(0).Rows(0).Item("UserName").trim
                    TurnPrintingInf.TerraficCard = DS.Tables(0).Rows(0).Item("CardNo").trim
                    TurnPrintingInf.TurnSequentialId = DS.Tables(0).Rows(0).Item("SequentialTurnId")
                    TurnPrintingInf.BlackList = DS.Tables(0).Rows(0).Item("BlackList").trim
                    TurnPrintingInf.AnnouncementHallTitle = DS.Tables(0).Rows(0).Item("AHTitle").trim
                    TurnPrintingInf.AnnouncementHallSubGroupTitle = DS.Tables(0).Rows(0).Item("AHSGTitle").trim
                    TurnPrintingInf.Description = DS.Tables(0).Rows(0).Item("Description").trim
                    Return TurnPrintingInf
                Catch ex As TurnPrintingInfNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Sub TurnPrint(YourTurnId As Int64)
                Try
                    Dim InstanceConfigurationOfComputers = New R2CoreMClassConfigurationOfComputersManager
                    Dim InstanceComputers = New R2CoreMClassComputersManager
                    If InstanceConfigurationOfComputers.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.TurnControlling, InstanceComputers.GetNSSCurrentComputer.MId, 2) Then
                        TurnPrintingInf = GetTurnPrintingInf(YourTurnId)
                        'چاپ قبض نوبت
                        _PrintDocumentNobat.Print()
                    End If
                Catch ex As TurnPrintingInfNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Sub _PrintDocumentNobat_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentNobat.BeginPrint
            End Sub

            Private Sub _PrintDocumentNobat_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentNobat.EndPrint
            End Sub

            Private Sub _PrintDocumentNobat_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
                Try
                    Dim myPaperSizeHalf As Integer = _PrintDocumentNobat.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
                    Dim myStrFontPersonFullName As Font = New System.Drawing.Font("Badr", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                    Dim myStrFontAnnouncementHallName As Font = New System.Drawing.Font("Badr", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontAnnouncementHallSubGroupName As Font = New System.Drawing.Font("Badr", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    E.Graphics.DrawString(TurnPrintingInf.TurnDate, myStrFontMax, Brushes.DarkBlue, X, Y)
                    ''E.Graphics.DrawString(TurnPrintingInf.TurnId, myDigFont, Brushes.DarkBlue, X + 350, Y)
                    E.Graphics.DrawString(IIf(TurnPrintingInf.TurnSequentialId = String.Empty, "", Convert.ToInt64(TurnPrintingInf.TurnSequentialId)), myDigFont, Brushes.DarkBlue, X + 350, Y)
                    E.Graphics.DrawString(TurnPrintingInf.TurnTime, myStrFontMax, Brushes.DarkBlue, X, Y + 30)
                    E.Graphics.DrawString(R2CoreMClassPublicProcedures.ParseSignDigitToTashString(TurnPrintingInf.MoneyWalletInventory), myStrFontMax, Brushes.DarkBlue, X + 400, Y + 30)
                    E.Graphics.DrawString(TurnPrintingInf.TruckDriver, myStrFontPersonFullName, Brushes.DarkBlue, X + 280, Y + 50)
                    E.Graphics.DrawString(TurnPrintingInf.Description, myStrFontMax, Brushes.DarkBlue, X, Y + 150)
                    E.Graphics.DrawString(TurnPrintingInf.AnnouncementHallTitle, myStrFontAnnouncementHallName, Brushes.DarkBlue, X + 130, Y + 180)
                    E.Graphics.DrawString(TurnPrintingInf.AnnouncementHallSubGroupTitle, myStrFontAnnouncementHallSubGroupName, Brushes.DarkBlue, X + 150, Y + 215)
                    E.Graphics.DrawString(TurnPrintingInf.LoaderFixType, myStrFontMax, Brushes.DarkBlue, X, Y + 70)
                    E.Graphics.DrawString(TurnPrintingInf.LoaderType, myStrFontMax, Brushes.DarkBlue, X, Y + 90)
                    E.Graphics.DrawString(TurnPrintingInf.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 260, Y + 90)
                    Dim a As Char() = TurnPrintingInf.TruckLP.ToCharArray()
                    E.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 290, Y + 90)
                    E.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 300, Y + 90)
                    E.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 310, Y + 90)
                    E.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 325, Y + 90)
                    E.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 335, Y + 90)
                    E.Graphics.DrawString(a(2), myStrFontMax, Brushes.DarkBlue, X + 345, Y + 90)
                    E.Graphics.DrawString(TurnPrintingInf.UserName, myStrFontMax, Brushes.DarkBlue, X, Y + 110)
                    E.Graphics.DrawString(TurnPrintingInf.TerraficCard, myStrFontMax, Brushes.DarkBlue, X + 400, Y + 110)
                    ''E.Graphics.DrawString(IIf(TurnPrintingInf.TurnSequentialId = String.Empty, "", Convert.ToInt64(TurnPrintingInf.TurnSequentialId)), myDigFont, Brushes.DarkBlue, X, Y + 150)
                    E.Graphics.DrawString(TurnPrintingInf.BlackList, myStrFontMin, Brushes.DarkBlue, X, Y + 170)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentNobat.PrintPage
                Try
                    _PrintDocumentNobat_PrintPage_Printing(150, 40, e)
                Catch ex As Exception
                    MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

    End Namespace

    Namespace TurnPrintRequest

        Public MustInherit Class TurnPrintRequestTypes
            Public Shared ReadOnly Property None = 0
            Public Shared ReadOnly Property NoCost = 1
            Public Shared ReadOnly Property Replica = 2
        End Class

        Public Class R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManager

            Public Sub NoCostTurnPrintRequest(YourTurnId As Int64, YourTurnPrintRedirect As Boolean)
                Try
                    TurnPrintRequest(YourTurnId, YourTurnPrintRedirect)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Sub TurnPrintRequest(YourTurnId As Int64, YourTurnPrintRedirect As Boolean)
                Try
                    Dim InstanceTurnPrinting = New R2CoreTransportationAndLoadNotificationMClassTurnPrintingManager
                    Dim InstanceConfigurationOfComputers = New R2CoreMClassConfigurationOfComputersManager
                    Dim InstanceComputers = New R2CoreMClassComputersManager
                    Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                    If Not YourTurnPrintRedirect Then
                        InstanceTurnPrinting.TurnPrint(YourTurnId)
                    Else
                        If InstanceConfigurationOfComputers.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.TurnControlling, InstanceComputers.GetNSSCurrentComputer.MId, 0) = True Then
                            Dim DataStruct As DataStruct = New DataStruct()
                            DataStruct.Data1 = YourTurnId
                            Dim NSSTruck = InstanceTurns.GetNSSTruck(YourTurnId)
                            Dim InstanceComputerMessages = New R2CoreMClassComputerMessagesManager
                            InstanceComputerMessages.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, NSSTruck.NSSCar.GetCarPelakSerialComposit(), R2CoreTransportationAndLoadNotificationComputerMessageTypes.TurnPrint, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
                        End If
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnPrintRequestManagement

            Public Shared Sub NoCostTurnPrintRequest(YourTurnId As Int64, YourTurnPrintRedirect As Boolean)
                Try
                    TurnPrintRequest(YourTurnId, YourTurnPrintRedirect)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub ReplicaTurnPrintRequest(YourTurnId As Int64, YourTurnPrintRedirect As Boolean)
                Try
                    TurnPrintRequest(YourTurnId, YourTurnPrintRedirect)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub TurnPrintRequest(YourTurnId As Int64, YourTurnPrintRedirect As Boolean)
                Try
                    Dim InstanceTurnPrinting = New R2CoreTransportationAndLoadNotificationMClassTurnPrintingManager
                    If Not YourTurnPrintRedirect Then
                        InstanceTurnPrinting.TurnPrint(YourTurnId)
                    Else
                        If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.TurnControlling, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then
                            Dim DataStruct As DataStruct = New DataStruct()
                            DataStruct.Data1 = YourTurnId
                            Dim NSSTruck = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourTurnId)
                            R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, NSSTruck.NSSCar.GetCarPelakSerialComposit(), R2CoreTransportationAndLoadNotificationComputerMessageTypes.TurnPrint, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
                        End If
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub


        End Class

    End Namespace

    Namespace TurnRegisterRequest

        Public MustInherit Class TurnRegisterRequestTypes
            Public Shared ReadOnly Property None = 0
            Public Shared ReadOnly Property RealTime = 1
            Public Shared ReadOnly Property Emergency = 2
            Public Shared ReadOnly Property Reserve = 3
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure

            Public Sub New()
                _TRRTypeId = Int64.MinValue
                _TRRTypeName = String.Empty
                _TRRTypeTitle = String.Empty
                _TRRTypeColor = Color.Black
                _TurnExpirationHours = Int16.MinValue
                _Acitve = Boolean.FalseString
                _ViewFlag = Boolean.FalseString
                _Deleted = Boolean.FalseString
            End Sub

            Public Sub New(ByVal YourTRRTypeId As Int64, ByVal YourTRRTypeName As String, YourTRRTypeTitle As String, YourTRRTypeColor As Color, YourTurnExpirationHours As Int16, YourAcitve As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
                _TRRTypeId = YourTRRTypeId
                _TRRTypeName = YourTRRTypeName
                _TRRTypeTitle = YourTRRTypeTitle
                _TRRTypeColor = YourTRRTypeColor
                _TurnExpirationHours = YourTurnExpirationHours
                _Acitve = YourAcitve
                _ViewFlag = YourViewFlag
                _Deleted = YourDeleted
            End Sub

            Public Property TRRTypeId As Int64
            Public Property TRRTypeName As String
            Public Property TRRTypeTitle As String
            Public Property TRRTypeColor As Color
            Public Property TurnExpirationHours As Int16
            Public Property Acitve As Boolean
            Public Property ViewFlag As Boolean
            Public Property Deleted As Boolean
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
            Public Sub New()
                _TRRId = Int64.MinValue
                _TRRTypeId = Int64.MinValue
                _TruckId = Int64.MinValue
                _Description = String.Empty
                _UserId = Int64.MinValue
                _ComputerId = Int64.MinValue
                _DateTimeMilladi = Now
                DateShamsi = String.Empty
            End Sub

            Public Sub New(ByVal YourTRRId As Int64, ByVal YourTRRTypeId As Int64, YourTruckId As Int64, YourDescription As String, YourUserId As Int64, YourComputerId As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String)
                _TRRId = YourTRRId
                _TRRTypeId = YourTRRTypeId
                _TruckId = YourTruckId
                _Description = YourDescription
                _UserId = YourUserId
                _ComputerId = YourComputerId
                _DateTimeMilladi = YourDateTimeMilladi
                _DateShamsi = YourDateShamsi
            End Sub

            Public Property TRRId As Int64
            Public Property TRRTypeId As Int64
            Public Property TruckId As Int64
            Public Property Description As String
            Public Property UserId As Int64
            Public Property ComputerId As Int64
            Public Property DateTimeMilladi As DateTime
            Public Property DateShamsi As String
        End Class

        Public Class R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
            Private _DateTime As New R2DateTime
            Private _R2PrimaryFSWS As R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()

            Public Function GetNSSTurnRegisterRequestType(YourTurnRegisterRequestTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                Try
                    Dim Ds As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequestTypes as TRRTypes Where TRRTypes.TRRTypeId=" & YourTurnRegisterRequestTypeId & "", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestTypeNotFoundException
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                    NSS.TRRTypeId = Ds.Tables(0).Rows(0).Item("TRRTypeId")
                    NSS.TRRTypeName = Ds.Tables(0).Rows(0).Item("TRRTypeName").trim
                    NSS.TRRTypeTitle = Ds.Tables(0).Rows(0).Item("TRRTypeTitle").trim
                    NSS.TRRTypeColor = Color.FromName(Ds.Tables(0).Rows(0).Item("TRRTypeColor").trim)
                    NSS.TurnExpirationHours = Ds.Tables(0).Rows(0).Item("TurnExpirationHours")
                    NSS.ViewFlag = Ds.Tables(0).Rows(0).Item("ViewFlag")
                    NSS.Acitve = Ds.Tables(0).Rows(0).Item("Active")
                    NSS.Deleted = Ds.Tables(0).Rows(0).Item("Deleted")
                    Return NSS
                Catch ex As TurnRegisterRequestTypeNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function TurnRegisterRequestRegistering(YourNSSTRR As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourAttachement As R2CoreImage, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim InstanceComputers = New R2CoreMClassComputersManager
                    'تراکنش ثبت درخواست صدور نوبت
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select Top 1 TRRId From R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests With (tablockx) Order By TRRId Desc"
                    CmdSql.ExecuteNonQuery()
                    Dim TRRIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                    CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests(TRRId,TRRTypeId,TruckId,Description,UserId,ComputerId,DateTimeMilladi,DateShamsi) Values(" & TRRIdNew & "," & YourNSSTRR.TRRTypeId & "," & YourNSSTRR.TruckId & ",'" & YourNSSTRR.Description & "'," & YourUserNSS.UserId & "," & InstanceComputers.GetNSSCurrentComputer.MId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "')"
                    CmdSql.ExecuteNonQuery()
                    If YourAttachement IsNot Nothing Then SaveTurnRegisterRequestAttachement(YourAttachement, TRRIdNew, YourUserNSS)
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                    'ارسال کد درخواست
                    Return TRRIdNew
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Private Sub SaveTurnRegisterRequestAttachement(YourAttachement As R2CoreImage, YourTRRId As Int64, YourNSSUser As R2CoreStandardSoftwareUserStructure)
                Try
                    Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                    Dim FileInf = New R2CoreFile(YourTRRId.ToString() + InstanceConfiguration.GetConfigString(R2CoreConfigurations.JPGBitmap, 2))
                    _R2PrimaryFSWS.WebMethodSaveFile(FileShareRawGroupsManagement.R2CoreTransportationAndLoadNotificationRawGroups.TurnRegisterRequestAttachements, FileInf.FileName, YourAttachement.GetImageByte(), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Function GetNSSTurnRegisterRequest(YourTurnRegisterRequestId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
                Try
                    Dim Ds As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests as TRRs Where TRRs.TRRId=" & YourTurnRegisterRequestId & "", 1, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestNotFoundException
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
                    NSS.TRRId = Ds.Tables(0).Rows(0).Item("TRRId")
                    NSS.TRRTypeId = Ds.Tables(0).Rows(0).Item("TRRTypeId")
                    NSS.TruckId = Ds.Tables(0).Rows(0).Item("TruckId")
                    NSS.UserId = Ds.Tables(0).Rows(0).Item("UserId")
                    NSS.Description = Ds.Tables(0).Rows(0).Item("Description").trim
                    NSS.ComputerId = Ds.Tables(0).Rows(0).Item("ComputerId")
                    NSS.DateShamsi = Ds.Tables(0).Rows(0).Item("DateShamsi")
                    NSS.DateTimeMilladi = Ds.Tables(0).Rows(0).Item("DateTimeMilladi")
                    Return NSS
                Catch ex As TurnRegisterRequestNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function GetNSSTurnRegisteringRequestWithReservedDateTime(YourDateTime As R2StandardDateAndTimeStructure) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
                Try
                    Dim InstanceSequentialTurns = New R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager
                    Dim DS As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                           "Select Top 1 Turns.strEnterDate,Turns.strEnterTime,Turns.nEnterExitId,TurnRegisterRequests.* from dbtransport.dbo.tbEnterExit as Turns
                             Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Turns.nEnterExitId=EntityRelations.E1 
                             Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests as TurnRegisterRequests On TurnRegisterRequests.TRRId=EntityRelations.E2 
                            Where Turns.strEnterDate>='" & YourDateTime.DateShamsiFull & "' and Turns.strEnterTime>='" & YourDateTime.Time & "' and EntityRelations.ERTypeId=" & R2CoreTransportationAndLoadNotificationEntityRelationTypes.Turn_TurnRegisterRequest & " 
                                  and EntityRelations.RelationActive=1 and TurnRegisterRequests.TRRTypeId=" & TurnRegisterRequestTypes.Reserve & " and Substring(Turns.OtaghdarTurnNumber,1,1)='" & InstanceSequentialTurns.GetNSSSequentialTurn(SequentialTurns.SequentialTurns.None).SequentialTurnKeyWord & "'
                            Order By Turns.nEnterExitId Asc", 0, DS, New Boolean).GetRecordsCount = 0 Then
                        Throw New TurnRegisterRequestNotFoundException
                    End If
                    Return New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure(DS.Tables(0).Rows(0).Item("TRRId"), DS.Tables(0).Rows(0).Item("TRRTypeId"), DS.Tables(0).Rows(0).Item("TruckId"), DS.Tables(0).Rows(0).Item("Description").trim, DS.Tables(0).Rows(0).Item("UserId"), DS.Tables(0).Rows(0).Item("ComputerId"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi").trim)
                Catch ex As TurnRegisterRequestNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function


        End Class

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement
            Private Shared _DateTime As New R2DateTime
            Private Shared _R2PrimaryFSWS As R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()


            Public Shared Function GetNSSTurnRegisterRequestType(YourTurnRegisterRequestTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequestTypes as TRRTypes Where TRRTypes.TRRTypeId=" & YourTurnRegisterRequestTypeId & "", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestTypeNotFoundException
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                    NSS.TRRTypeId = Ds.Tables(0).Rows(0).Item("TRRTypeId")
                    NSS.TRRTypeName = Ds.Tables(0).Rows(0).Item("TRRTypeName").trim
                    NSS.TRRTypeTitle = Ds.Tables(0).Rows(0).Item("TRRTypeTitle").trim
                    NSS.TRRTypeColor = Color.FromName(Ds.Tables(0).Rows(0).Item("TRRTypeColor").trim)
                    NSS.TurnExpirationHours = Ds.Tables(0).Rows(0).Item("TurnExpirationHours")
                    NSS.ViewFlag = Ds.Tables(0).Rows(0).Item("ViewFlag")
                    NSS.Acitve = Ds.Tables(0).Rows(0).Item("Active")
                    NSS.Deleted = Ds.Tables(0).Rows(0).Item("Deleted")
                    Return NSS
                Catch ex As TurnRegisterRequestTypeNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSTurnRegisterRequest(YourTurnRegisterRequestId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests as TRRs Where TRRs.TRRId=" & YourTurnRegisterRequestId & "", 1, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestNotFoundException
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
                    NSS.TRRId = Ds.Tables(0).Rows(0).Item("TRRId")
                    NSS.TRRTypeId = Ds.Tables(0).Rows(0).Item("TRRTypeId")
                    NSS.TruckId = Ds.Tables(0).Rows(0).Item("TruckId")
                    NSS.UserId = Ds.Tables(0).Rows(0).Item("UserId")
                    NSS.Description = Ds.Tables(0).Rows(0).Item("Description").trim
                    NSS.ComputerId = Ds.Tables(0).Rows(0).Item("ComputerId")
                    NSS.DateShamsi = Ds.Tables(0).Rows(0).Item("DateShamsi")
                    NSS.DateTimeMilladi = Ds.Tables(0).Rows(0).Item("DateTimeMilladi")
                    Return NSS
                Catch ex As TurnRegisterRequestNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Private Shared Sub SaveTurnRegisterRequestAttachement(YourAttachement As R2CoreImage, YourTRRId As Int64, YourNSSUser As R2CoreStandardSoftwareUserStructure)
                Try
                    Dim FileInf = New R2CoreFile(YourTRRId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2))
                    _R2PrimaryFSWS.WebMethodSaveFile(FileShareRawGroupsManagement.R2CoreTransportationAndLoadNotificationRawGroups.TurnRegisterRequestAttachements, FileInf.FileName, YourAttachement.GetImageByte(), _R2PrimaryFSWS.WebMethodLogin(YourNSSUser.UserShenaseh, YourNSSUser.UserPassword))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function TurnRegisterRequestRegistering(YourNSSTRR As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourAttachement As R2CoreImage, YourUserNSS As R2CoreStandardSoftwareUserStructure) As Int64
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    'تراکنش ثبت درخواست صدور نوبت
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select Top 1 TRRId From R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests With (tablockx) Order By TRRId Desc"
                    CmdSql.ExecuteNonQuery()
                    Dim TRRIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                    CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests(TRRId,TRRTypeId,TruckId,Description,UserId,ComputerId,DateTimeMilladi,DateShamsi) Values(" & TRRIdNew & "," & YourNSSTRR.TRRTypeId & "," & YourNSSTRR.TruckId & ",'" & YourNSSTRR.Description & "'," & YourUserNSS.UserId & "," & R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "')"
                    CmdSql.ExecuteNonQuery()
                    If YourAttachement IsNot Nothing Then SaveTurnRegisterRequestAttachement(YourAttachement, TRRIdNew, YourUserNSS)
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                    'ارسال کد درخواست
                    Return TRRIdNew
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class


    End Namespace

    Namespace SequentialTurns

        Public MustInherit Class SequentialTurns
            Public Shared ReadOnly Property None As Int64 = 0
            Public Shared ReadOnly Property SequentialTurnOtaghdar As Int64 = 1
            Public Shared ReadOnly Property SequentialTurnZobi As Int64 = 2
            Public Shared ReadOnly Property SequentialTurnShahri As Int64 = 3
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
            Public Sub New()
                _SequentialTurnId = Int64.MinValue
                _SequentialTurnTitle = String.Empty
                _SequentialTurnColor = String.Empty
                _SequentialTurnKeyWord = String.Empty
                _Active = False
                _ViewFlag = False
                _Deleted = True
            End Sub

            Public Sub New(ByVal YourSequentialTurnId As Int64, ByVal YourSequentialTurnTitle As String, YourSequentialTurnColor As String, YourSequentialTurnKeyWord As String, YourActive As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
                _SequentialTurnId = YourSequentialTurnId
                _SequentialTurnTitle = YourSequentialTurnTitle
                _SequentialTurnColor = YourSequentialTurnColor
                _SequentialTurnKeyWord = YourSequentialTurnKeyWord
                _Active = YourActive
                _ViewFlag = YourViewFlag
                _Deleted = YourDeleted
            End Sub

            Public Property SequentialTurnId As Int64
            Public Property SequentialTurnTitle As String
            Public Property SequentialTurnColor As String
            Public Property SequentialTurnKeyWord As String
            Public Property Active As Boolean
            Public Property ViewFlag As Boolean
            Public Property Deleted As Boolean

        End Class

        Public Class R2CoreTransportationAndLoadNotificationInstanceSequentialTurnsManager

            Public Function GetSequentialTurns() As List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                Try
                    Dim Ds As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Distinct SeqT.SeqTId,SeqT.SeqTTitle,SeqT.SeqTColor,SeqT.SeqTKeyWord,SeqT.Active,SeqT.ViewFlag,SeqT.Deleted 
                         from R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT
                         Where SeqT.Deleted=0 and SeqT.Active=1", 3600, Ds, New Boolean)
                    Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(Ds.Tables(0).Rows(Loopx).Item("SeqTId"), Ds.Tables(0).Rows(Loopx).Item("SeqTTitle").trim, Ds.Tables(0).Rows(Loopx).Item("SeqTColor").trim, Ds.Tables(0).Rows(Loopx).Item("SeqTKeyWord"), Ds.Tables(0).Rows(Loopx).Item("ViewFlag"), Ds.Tables(0).Rows(Loopx).Item("Active"), Ds.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function GetSequentialTurns(YourNSSComputer As R2CoreStandardComputerStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Distinct SeqT.SeqTId,SeqT.SeqTTitle,SeqT.SeqTColor,SeqT.SeqTKeyWord,SeqT.Active,SeqT.ViewFlag,SeqT.Deleted from R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqT On SeqT.SeqTId=AHRSeqT.SeqTId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRSeqT.AHId=AH.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationComputers as AHRComp On AH.AHId=AHRComp.AHId
                            Inner Join R2Primary.dbo.TblComputers as Comp On AHRComp.ComId=Comp.MId
                          Where AHRComp.RelationActive=1 and AH.Deleted=0 and AHRSeqT.RelationActive=1 and SeqT.Deleted=0 and SeqT.ViewFlag=1 and Comp.MId=" & YourNSSComputer.MId & "", 3600, DS, New Boolean)
                    Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(Loopx).Item("SeqTId"), DS.Tables(0).Rows(Loopx).Item("SeqTTitle").trim, DS.Tables(0).Rows(Loopx).Item("SeqTColor").trim, DS.Tables(0).Rows(Loopx).Item("SeqTKeyWord"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function GetNSSSequentialTurn(YourSeqTId As Int64) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.DBO.TblSequentialTurns Where SeqTId=" & YourSeqTId & "", 3600, DS, New Boolean).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As SequentialTurnNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function GetNSSSequentialTurn(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim SeqTurnKeyWord = Mid(YourNSSTurn.OtaghdarTurnNumber, 1, 1)
                    Dim DS As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.DBO.TblSequentialTurns Where SeqTKeyWord='" & SeqTurnKeyWord & "'", 3600, DS, New Boolean).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As SequentialTurnNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Function GetNSSSequentialTurn(YourNSSAHSG As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                               "Select Top 1 SeqTId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationSequentialTurns as AHSGRSeqT
                                Where AHSGId=" & YourNSSAHSG.AHSGId & " and RelationActive=1 Order By RId Desc", 3600, DS, New Boolean).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return GetNSSSequentialTurn(Convert.ToInt64(DS.Tables(0).Rows(0).Item("SeqTId")))
                Catch ex As SequentialTurnNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement
            Public Shared Function GetNSSSequentialTurn(YourSeqTId As Int64) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.DBO.TblSequentialTurns Where SeqTId=" & YourSeqTId & "", 1, DS, New Boolean).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As SequentialTurnNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSSequentialTurn(YourNSSAnnouncementHall As AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                          Select Top 1 SeqTs.SeqTId from R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqTs
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqTs On SeqTs.SeqTId=AHRSeqTs.SeqTId 
	                        Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AHs on AHRSeqTs.AHId=AHs.AHId 
                          Where AHRSeqTs.RelationActive=1 and AHs.AHId=" & YourNSSAnnouncementHall.AHId & "", 1, DS, New Boolean).GetRecordsCount() = 0 Then Throw New GetDataException
                    Return GetNSSSequentialTurn(Convert.ToInt64(DS.Tables(0).Rows(0).Item("SeqTId")))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSSequentialTurn(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select  Top 1 SeqT.* from R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqT On SeqT.SeqTId=AHRSeqT.SeqTId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRSeqT.AHId=AH.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AH.AHId=AHRAHSG.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHRAHSG.AHSGId=AHSG.AHSGId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AHSGRCar On AHSG.AHSGId=AHSGRCar.AHSGId
                            Inner Join dbtransport.dbo.TbCar as Car On AHSGRCar.CarId=Car.nIDCar
                        Where AHRSeqT.RelationActive=1 and AH.Deleted=0 and AHRAHSG.RelationActive=1 and AHSG.Deleted=0 and AHSGRCar.RelationActive=1 and Car.nIDCar=" & YourNSSTruck.NSSCar.nIdCar & " and Car.ViewFlag=1 
                              and ((DATEDIFF(SECOND,AHSGRCar.RelationTimeStamp,getdate())<240) or (AHSGRCar.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                        Order By AHSGRCar.Priority Asc,AHSGRCar.RelationId Desc", 1, DS, New Boolean).GetRecordsCount() = 0 Then Throw New TruckRelatedSequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
                Catch ex As TruckRelatedSequentialTurnNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetSequentialTurns(YourNSSComputer As R2CoreStandardComputerStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Distinct SeqT.SeqTId,SeqT.SeqTTitle,SeqT.SeqTColor,SeqT.SeqTKeyWord,SeqT.Active,SeqT.ViewFlag,SeqT.Deleted from R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqT On SeqT.SeqTId=AHRSeqT.SeqTId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRSeqT.AHId=AH.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationComputers as AHRComp On AH.AHId=AHRComp.AHId
                            Inner Join R2Primary.dbo.TblComputers as Comp On AHRComp.ComId=Comp.MId
                          Where AHRComp.RelationActive=1 and AH.Deleted=0 and AHRSeqT.RelationActive=1 and SeqT.Deleted=0 and SeqT.ViewFlag=1 and Comp.MId=" & YourNSSComputer.MId & "", 3600, DS, New Boolean)
                    Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(Loopx).Item("SeqTId"), DS.Tables(0).Rows(Loopx).Item("SeqTTitle").trim, DS.Tables(0).Rows(Loopx).Item("SeqTColor").trim, DS.Tables(0).Rows(Loopx).Item("SeqTKeyWord"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSSequentialTurn(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                               "Select Top 1 SeqT.SeqTId from dbtransport.dbo.tbEnterExit as EnterExit 
                                      Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On SUBSTRING(EnterExit.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS=SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS
                                     Where EnterExit.nEnterExitId=" & YourNSSTurn.nEnterExitId & "", 1, DS, New Boolean).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                    Return GetNSSSequentialTurn(Convert.ToInt64(DS.Tables(0).Rows(0).Item("SeqTId")))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function


        End Class

        Namespace Exceptions
            Public Class SequentialTurnNotFoundException
                Inherits ApplicationException
                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "تسلسل نوبت با شماره شاخص مورد نظر وجود ندارد"
                    End Get
                End Property
            End Class

            Public Class TruckRelatedSequentialTurnNotFoundException
                Inherits ApplicationException
                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "برای ناوگان ، تسلسل نوبت مرتبط یافت نشد"
                    End Get
                End Property
            End Class

            Public Class SequentialTurnIsNotActiveException
                Inherits ApplicationException
                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "تسلسل نوبت برای ناوگان مورد نظر غیرفعال است"
                    End Get
                End Property
            End Class

            Public Class AnySequentialTurnDoNotSelectedException
                Inherits ApplicationException
                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "صف نوبت مورد نظر را انتخاب و یا مشخص نمایید"
                    End Get
                End Property
            End Class

        End Namespace

    End Namespace

    Namespace TurnRegisteringCostTariffs


    End Namespace

    Namespace TurnExpiration
        Public Class R2CoreTransportationAndLoadNotificationMClassTurnExpirationManager
            Private _DateTime As New R2DateTime

            Public Sub TurnCreditRegistering(YourNSSSeqTurn As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure, YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure, YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
                Try
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblTurnCredits Set Active=0 Where Active=1 and SeqTId=" & YourNSSSeqTurn.SequentialTurnId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTurnCredits(SeqTId,SignificantTurnId,OtaghdarTurnNumber,DateTimeMilladi,DateShamsi,Time,UserId,Active,ViewFlag,Deleted)
                                          Values(" & YourNSSSeqTurn.SequentialTurnId & "," & YourNSSTurn.nEnterExitId & ",'" & YourNSSTurn.OtaghdarTurnNumber.Trim & "','" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentTime & "'," & YourNSSSoftwareUser.UserId & ",1,1,0)"
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

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnExpirationManagement
            Private Shared _DateTime As New R2DateTime

            Public Shared Sub TurnsExpiration()
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Turns.nEnterExitId,TRRequests.TRRId from dbtransport.dbo.tbEnterExit as Turns
                         Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Turns.nEnterExitId=EntityRelations.E1
                         Inner Join R2PrimaryTransportationAndLoadNotification.DBO.TblTurnRegisterRequests AS TRRequests ON EntityRelations.E2=TRRequests.TRRId
                       Where (TurnStatus=1 or TurnStatus=8 or TurnStatus=9 or TurnStatus=10) and EntityRelations.RelationActive=1", 1, Ds, New Boolean).GetRecordsCount = 0 Then Return

                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Try
                            Dim NSSTurn = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(Convert.ToInt64(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")))
                            Dim NSSTurnRegisterRequest = R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement.GetNSSTurnRegisterRequest(Ds.Tables(0).Rows(Loopx).Item("TRRId"))
                            If NSSTurnRegisterRequest.TRRTypeId = TurnRegisterRequestTypes.RealTime Then
                                If IsTurnOfRealTimeTurnRegisterRequestExpired(NSSTurn) Then ChangeTurnStatusToExpiration(NSSTurn)
                            ElseIf NSSTurnRegisterRequest.TRRTypeId = TurnRegisterRequestTypes.Emergency Then
                                If IsTurnOfEmergencyTurnRegisterRequestExpired(NSSTurn) Then ChangeTurnStatusToExpiration(NSSTurn)
                            ElseIf NSSTurnRegisterRequest.TRRTypeId = TurnRegisterRequestTypes.Reserve Then
                                If IsTurnOfReservedTurnRegisterRequestExpired(NSSTurn) Then ChangeTurnStatusToExpiration(NSSTurn)
                            Else
                                Throw New TurnRegisterRequestTypeNotFoundException
                            End If
                        Catch ex As Exception
                            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(Nothing, R2CoreTransportationAndLoadNotificationLogType.TurnExpirationFailed, ex.Message, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, Nothing, Nothing, Nothing))
                        End Try
                    Next

                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub ChangeTurnStatusToExpiration(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
                Try


                Catch ex As Exception

                End Try
            End Sub

            Private Shared Function IsTurnOfRealTimeTurnRegisterRequestExpired(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
                Try

                Catch ex As Exception

                End Try
            End Function

            Private Shared Function IsTurnOfEmergencyTurnRegisterRequestExpired(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
                Try

                Catch ex As Exception

                End Try
            End Function

            Private Shared Function IsTurnOfReservedTurnRegisterRequestExpired(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As Boolean
                Try

                Catch ex As Exception

                End Try
            End Function

        End Class


    End Namespace

    Namespace Exceptions
        Public Class AnyActiveTurnNotExistException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "هیچ نوبت فعالی در سامانه وجود ندارد"
                End Get
            End Property
        End Class

        Public Class UnableResucitationTemporayTurnException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان احیاء نوبت موقت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class TurnPrintingInfNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات تکمیلی مرتبط با نوبت مورد نظر برای چاپ نوبت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class TurnNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "درحال حاضر نوبتی در سامانه وجود ندارد"
                End Get
            End Property
        End Class

        Public Class TurnHandlingNotAllowedBecuaseTurnStatusException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت فعلی نوبت مانع از اجرای این فرآیند شد"
                End Get
            End Property
        End Class

        Public Class RelationBetweenTurnAndTruckNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ناوگانی مرتبط با نوبت یافت نشد"
                End Get
            End Property
        End Class

        Public Class TurnRegisterRequestTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع درخواست صدور نوبت با شماره شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

        Public Class TurnRegisterRequestNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "درخواست صدور نوبت با شماره شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

        Public Class SoftwareUserRelatedTurnNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربری (راننده) مرتبط با نوبت مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

        Public Class RequesterNotAllowTurnIssueBySeqTException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "درخواست کننده ، مجوز درخواست صدور نوبت برای تسلسل نوبت مورد نظر را ندارد"
                End Get
            End Property
        End Class

        Public Class RequesterNotAllowTurnIssueByLastLoadPermissionedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "درخواست کننده ، مجوز درخواست صدور نوبت با توجه به نوع آخرین بار دریافت شده را ندارد"
                End Get
            End Property
        End Class

        Public Class FirstActiveTurnNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره اولین نوبت دارای اعتبار یافت نشد"
                End Get
            End Property
        End Class

        Public Class LastActiveTurnNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "آخرین نوبت فعال ناوگان یافت نشد"
                End Get
            End Property
        End Class

        Public Class LastTurnCreditNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "آخرین شماره اعتبار نوبت یافت نشد"
                End Get
            End Property
        End Class

        Public Class TurnStatusNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "رکوردی مبنی بر شاخص وضعیت نوبت در سامانه وجود ندارد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace TurnCancellation
    Public Class R2CoreTransportationAndLoadNotificationTurnCancellationManager
        Private _DateTime As New R2DateTime
        Private Const TurnCancellationLoadColor = "OrangeRed"
        Private Const NonTurnCancellationLoadColor = "Green"

        Private Function IsLoadTargetforTurnCancellation(YourLoadTargetId As Int64) As Boolean
            Try
                Dim DS As New DataSet
                Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                       "Select Top 1 LoadTargetId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadTargetsforTurnCancellation 
                        Where LoadTargetId=" & YourLoadTargetId & " and Active=1", 3600, DS, New Boolean).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsLoadforTurnCancellation(YourNSSLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Boolean
            Try
                Dim InstanceConfigurations As New R2CoreInstanceConfigurationManager
                If IsLoadTargetforTurnCancellation(YourNSSLoad.nCityCode) Then
                    If YourNSSLoad.nTonaj <= InstanceConfigurations.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 8) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Sub LoadforTurnCancellationRegistering(nEstelamId As Int64, YourCancellationFlag As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Dim myDescription As String = String.Empty
                If YourCancellationFlag Then
                    myDescription = TurnCancellationLoadColor
                Else
                    myDescription = NonTurnCancellationLoadColor
                End If
                CmdSql.Connection.Open()
                CmdSql.CommandText = " Insert into R2PrimaryTransportationAndLoadNotification.dbo.TblLoadsforTurnCancellation(nEstelamId,Description,DateShamsi,DateTimeMilladi,Time,Active) Values(" & nEstelamId & ",'" & myDescription & "','" & _DateTime.GetCurrentDateShamsiFull & "','" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentTime & "'," & IIf(YourCancellationFlag, 1, 0) & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoadforTurnCancellationActiving(nEstelamId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadsforTurnCancellation Set Active=1,Description='" & TurnCancellationLoadColor & "' Where nEstelamId=" & nEstelamId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Sub LoadforTurnCancellationUnActiving(nEstelamId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadsforTurnCancellation Set Active=0,Description='" & NonTurnCancellationLoadColor & "' Where nEstelamId=" & nEstelamId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class



End Namespace

Namespace TurnAttendance

    Public Class R2CoreTransportationAndLoadNotificationInstanceTurnAttendanceManager
        Private _DateTime As New R2DateTime

        Public Function IsPresentRegisteredInLast30Minute(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As UInt64) As Boolean
            Try
                Dim InstanceSqlDataBox = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceConfigurationOfAnnouncementHalls = New R2CoreTransportationAndLoadNotificationInstanceConfigurationOfAnnouncementHallsManager
                Dim Ds As DataSet
                If InstanceSqlDataBox.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateTimeMilladi From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "') Order By DateTimeMilladi Desc", 1, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Dim Last30Minute As Int64 = InstanceConfigurationOfAnnouncementHalls.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 1)
                    If DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), _DateTime.GetCurrentDateTimeMilladi) <= Last30Minute Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTurnDateTimeDiferenceToToday(YourTurnId As Int64) As Int64
            Try
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim InstancePublicProcedures = New R2CoreInstancePublicProceduresManager
                Dim NSSTurn = InstanceTurns.GetNSSTurn(YourTurnId)
                Dim TurnDateTime As String = _DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSTurn.EnterDate, NSSTurn.EnterTime)
                Return InstancePublicProcedures.GetDateDiff(DateInterval.Day, TurnDateTime, _DateTime.GetCurrentDateTimeMilladiFormated())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTotalNumberOfPresentRegistered(YourTurnId As Int64) As Int64
            Try
                Dim InstanceSqlDataBox = New R2CoreInstanseSqlDataBOXManager
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim NSSTurn = InstanceTurns.GetNSSTurn(YourTurnId)
                Dim DS As DataSet
                Return InstanceSqlDataBox.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) AS M From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") And (DateShamsi<>'" & NSSTurn.EnterDate & "') GROUP BY DateShamsi", 1, DS, New Boolean).GetRecordsCount()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetTotalNumberOfNeededPresent(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As Int64) As UInt16
            Try
                Dim InstanceTruck = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
                Dim InstanceConfigurationOfAnnouncementHalls = New R2CoreTransportationAndLoadNotificationInstanceConfigurationOfAnnouncementHallsManager
                Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
                Dim InstanceDateAndTimePersianCalendar = New R2CoreInstanceDateAndTimePersianCalendarManager
                Dim NSSTruck = InstanceTruck.GetNSSTruck(YourTurnId)
                Dim NSSTurn = InstanceTurns.GetNSSTurn(YourTurnId)
                'درصورتی که کنترل حاضری سالن مورد نظر غیرفعال باشد تعداد حاضری مورد نیاز 0 است
                If Not InstanceConfigurationOfAnnouncementHalls.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 0) Then Return 0
                'درصورتی که در محدوده خاصی زمانی کانفیگ شده عدم کنترل حاضری سالن مورد نظر باشیم تعداد حاضری مورد نیاز 0 است
                Dim PresentControlStartTime As String = InstanceConfigurationOfAnnouncementHalls.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 3)
                Dim PresentControlEndTime As String = InstanceConfigurationOfAnnouncementHalls.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 2)
                If Not ((_DateTime.GetCurrentTime() >= PresentControlStartTime) And (_DateTime.GetCurrentTime() <= PresentControlEndTime)) Then Return 0
                'اگر ناوگان بومی باشد یا بومی با پلاک غیربومی باشد تعداد حاضری مورد نیاز از کانفیگ بدست می آید
                'درغیر اینصورت طبق فرمول پیشنهاد شده انجام می شود
                If InstanceTruckNativeness.IsTruckIndigenous(NSSTruck) Then
                    Return InstanceConfigurationOfAnnouncementHalls.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 4)
                Else
                    If YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Zobi Then
                        'غير بومي ها در سالن ذوبی به تعداد اختلاف تاريخ صدور مجوز با تاريخ صدور نوبت باید حاضری داشته باشند
                        Return GetTurnDateTimeDiferenceToToday(YourTurnId) - InstanceDateAndTimePersianCalendar.GetHoliDayNumber(NSSTurn.EnterDate, _DateTime.GetCurrentDateShamsiFull)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Anbari Then
                        Return InstanceConfigurationOfAnnouncementHalls.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        Return InstanceConfigurationOfAnnouncementHalls.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Shahri Then
                        Return InstanceConfigurationOfAnnouncementHalls.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    End If
                End If
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsAmountOfTurnPresentsEnough(ByVal YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As UInt64) As Boolean
            Try
                'آیا آخرین حاضری نوبت در 30 دقیقه یا 3 ساعت اخیر مطابق پیکربندی سیستم ثبت شده است یا نه
                If IsPresentRegisteredInLast30Minute(YourNSSAnnouncementHall, YourTurnId) = False Then Throw New PresentNotRegisteredInLast30MinuteException
                'روزی که نوبت صادر شده نیازی به حاضری نیست
                If GetTurnDateTimeDiferenceToToday(YourTurnId) = 0 Then Return True
                'کنترل تعداد حاضری نوبت
                If GetTotalNumberOfPresentRegistered(YourTurnId) >= GetTotalNumberOfNeededPresent(YourNSSAnnouncementHall, YourTurnId) Then
                    Return True
                Else
                    Throw New PresentsNotEnoughException
                End If
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch exxx As PresentsNotEnoughException
                Throw exxx
            Catch exx As PresentNotRegisteredInLast30MinuteException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public MustInherit Class R2CoreTransportationAndLoadNotificationMClassTurnAttendanceManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetTotalNumberOfPresentRegistered(YourTurnId As Int64) As Int64
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Dim DS As DataSet
                Return R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) AS M From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") And (DateShamsi<>'" & NSSTurn.EnterDate & "') GROUP BY DateShamsi", 1, DS, New Boolean).GetRecordsCount()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsPresentRegisteredInLast30Minute(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As UInt64) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateTimeMilladi From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "') Order By DateTimeMilladi Desc", 1, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Dim Last30Minute As Int64 = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 1)
                    If DateDiff(DateInterval.Hour, Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), _DateTime.GetCurrentDateTimeMilladi) <= Last30Minute Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTurnDateTimeDiferenceToToday(YourTurnId As Int64) As Int64
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Dim TurnDateTime As String = _DateTime.GetMilladiDateTimeFromDateShamsiFull(NSSTurn.EnterDate, NSSTurn.EnterTime)
                Return R2CoreMClassPublicProcedures.GetDateDiff(DateInterval.Day, TurnDateTime, _DateTime.GetCurrentDateTimeMilladiFormated())
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsPresentsContinuous(ByVal YourTurnId As UInt64) As Boolean
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                If GetTotalNumberOfPresentRegistered(YourTurnId) + 1 >= GetTurnDateTimeDiferenceToToday(YourTurnId) - R2CoreDateAndTimePersianCalendarManagement.GetHoliDayNumber(NSSTurn.EnterDate, _DateTime.GetCurrentDateShamsiFull) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function IsThisDayTruckDriverPresentRegistered(ByVal YourTurnId As UInt64) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "')", 1, DS, New Boolean).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTotalNumberOfNeededPresent(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As Int64) As UInt16
            Try
                Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
                Dim NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourTurnId)
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                'درصورتی که کنترل حاضری سالن مورد نظر غیرفعال باشد تعداد حاضری مورد نیاز 0 است
                If Not R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 0) Then Return 0
                'درصورتی که در محدوده خاصی زمانی کانفیگ شده عدم کنترل حاضری سالن مورد نظر باشیم تعداد حاضری مورد نیاز 0 است
                Dim PresentControlStartTime As String = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 3)
                Dim PresentControlEndTime As String = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 2)
                If Not ((_DateTime.GetCurrentTime() >= PresentControlStartTime) And (_DateTime.GetCurrentTime() <= PresentControlEndTime)) Then Return 0
                'اگر ناوگان بومی باشد یا بومی با پلاک غیربومی باشد تعداد حاضری مورد نیاز از کانفیگ بدست می آید
                'درغیر اینصورت طبق فرمول پیشنهاد شده انجام می شود
                If InstanceTruckNativeness.IsTruckIndigenous(NSSTruck) Then
                    Return R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 4)
                Else
                    If YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Zobi Then
                        'غير بومي ها در سالن ذوبی به تعداد اختلاف تاريخ صدور مجوز با تاريخ صدور نوبت باید حاضری داشته باشند
                        Return GetTurnDateTimeDiferenceToToday(YourTurnId) - R2CoreDateAndTimePersianCalendarManagement.GetHoliDayNumber(NSSTurn.EnterDate, _DateTime.GetCurrentDateShamsiFull)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Anbari Then
                        Return R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Otaghdar Then
                        Return R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    ElseIf YourNSSAnnouncementHall.AHId = AnnouncementHalls.AnnouncementHalls.Shahri Then
                        Return R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, YourNSSAnnouncementHall.AHId, 5)
                    End If
                End If
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsAmountOfTurnPresentsEnough(ByVal YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As UInt64) As Boolean
            Try
                'آیا آخرین حاضری نوبت در 30 دقیقه یا 3 ساعت اخیر مطابق پیکربندی سیستم ثبت شده است یا نه
                If IsPresentRegisteredInLast30Minute(YourNSSAnnouncementHall, YourTurnId) = False Then Throw New PresentNotRegisteredInLast30MinuteException
                'روزی که نوبت صادر شده نیازی به حاضری نیست
                If GetTurnDateTimeDiferenceToToday(YourTurnId) = 0 Then Return True
                'کنترل تعداد حاضری نوبت
                If GetTotalNumberOfPresentRegistered(YourTurnId) >= GetTotalNumberOfNeededPresent(YourNSSAnnouncementHall, YourTurnId) Then
                    Return True
                Else
                    Throw New PresentsNotEnoughException
                End If
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch exxx As PresentsNotEnoughException
                Throw exxx
            Catch exx As PresentNotRegisteredInLast30MinuteException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function



    End Class

    Namespace Exceptions
        Public Class PresentNotRegisteredInLast30MinuteException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حاضري امروز راننده در محدوده زماني نزديك به صدور مجوز بار نيست"
                End Get
            End Property
        End Class

        Public Class PresentsNotEnoughException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "حاضري برای نوبت به تعداد کافی وجود ندارد"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace Goods
    Public Class R2CoreTransportationAndLoadNotificationStandardGoodStructure
        Inherits R2StandardStructure
        Public Sub New()
            MyBase.New()
            _GoodId = Int64.MinValue
            _GoodName = String.Empty
            _ViewFlag = Boolean.FalseString
            _Active = Boolean.FalseString
            _Deleted = Boolean.FalseString
        End Sub

        Public Sub New(ByVal YourGoodId As Int64, ByVal YourGoodName As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourGoodId, YourGoodName)
            _GoodId = YourGoodId
            _GoodName = YourGoodName
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property GoodId As Int64
        Public Property GoodName() As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean


    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassGoodsManagement
        Public Shared Function GetNSSGood(YourGoodId As Int64) As R2CoreTransportationAndLoadNotificationStandardGoodStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from dbtransport.dbo.TbProducts Where StrGoodCode=" & YourGoodId & "", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New GoodNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardGoodStructure = New R2CoreTransportationAndLoadNotificationStandardGoodStructure(Ds.Tables(0).Rows(0).Item("StrGoodCode"), Ds.Tables(0).Rows(0).Item("StrGoodName").TRIM, Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("Deleted"))
                Return NSS
            Catch exx As GoodNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetGoods_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSearchString)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select StrGoodCode,StrGoodName,ViewFlag,Active,Deleted From DBTransport.dbo.TbProducts Where StrGoodName Like '%" & YourSearchString.Replace("ی", "ي").Replace("ک", "ك") & "%' and ViewFlag=1 Order By StrGoodCode", 3600, DS, New Boolean)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardGoodStructure(DS.Tables(0).Rows(Loopx).Item("StrGoodCode"), DS.Tables(0).Rows(Loopx).Item("StrGoodName"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted")))
                Next
                Return Lst
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetGoods_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
            Try
                Dim InstanceSQLInjectionPrevention = New R2CoreSQLInjectionPreventionManager
                InstanceSQLInjectionPrevention.GeneralAuthorization(YourSearchString)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select StrGoodCode,StrGoodName,ViewFlag,Active,Deleted  From DBTransport.dbo.TbProducts Where Left(StrGoodName," & YourSearchString.Length & ")='" & YourSearchString.Replace("ی", "ي").Replace("ک", "ك") & "' Order By StrGoodCode", 3600, DS, New Boolean)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardGoodStructure(DS.Tables(0).Rows(Loopx).Item("StrGoodCode"), DS.Tables(0).Rows(Loopx).Item("StrGoodName"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted")))
                Next
                Return Lst
            Catch ex As SqlInjectionException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function



    End Class

    Namespace Exceptions
        Public Class GoodNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کالا با کد شاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace ProcessesManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationProcesses
        Inherits R2CoreDesktopProcesses

        Public Shared ReadOnly FrmcLoadPermissions As Int64 = 24
        Public Shared ReadOnly FrmcLoadCapacitor As Int64 = 44
        Public Shared ReadOnly FrmcLoadAllocations As Int64 = 45
        Public Shared ReadOnly FrmcBillOfLadingControl As Int64 = 62
        Public Shared ReadOnly FrmcTruckDriverLoadAllocationsPriorityApplied As Int64 = 63
        Public Shared ReadOnly FrmcLoadCapacitorMonitoring As Int64 = 64
        Public Shared ReadOnly FrmcTransportCompniesManipulation As Int64 = 68
        Public Shared ReadOnly FrmcMoneyWalletChargeByTransportCompany As Int64 = 72
        Public Shared ReadOnly FrmcLoadingAndDischargingPlaces As Int64 = 75

    End Class




End Namespace

Namespace EntityRelations

    Public MustInherit Class R2CoreTransportationAndLoadNotificationEntityRelationTypes
        Inherits R2CoreEntityRelationTypes
        Public Shared ReadOnly Turn_TurnRegisterRequest As Int64 = 1
    End Class

End Namespace

Namespace TerraficCardsManagement

    Public Class R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager
        Public Function GetNSSTerafficCard(YourNSSSoftwareUser As R2CoreStandardSoftwareUserStructure) As R2CoreParkingSystemStandardTrafficCardStructure
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
            Try
                Dim Ds As New DataSet
                If YourNSSSoftwareUser.UserTypeId = R2CoreParkingSystemSoftwareUserTypes.Driver Then
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                       "Select Top 1 TCardsRCar.CardId
                        from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                          Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On SoftwareUsers.UserId=EntityRelations.E1 
                          Inner Join dbtransport.dbo.TbDriver as Drivers On EntityRelations.E2=Drivers.nIDDriver 
                          Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Drivers.nIDDriver=CarAndPersons.nIDPerson
                          Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
                          Inner Join R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars as TCardsRCar On Cars.nIDCar=TCardsRCar.nCarId 
                        Where SoftwareUsers.UserId=" & YourNSSSoftwareUser.UserId & " and SoftwareUsers.UserActive=1 and SoftwareUsers.Deleted=0 and EntityRelations.RelationActive=1 and  
                              EntityRelations.ERTypeId=" & R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver & " and Cars.ViewFlag=1 and TCardsRCar.RelationActive=1 and CarAndPersons.snRelation=2 
                              and ((DATEDIFF(SECOND,TCardsRCar.RelationTimeStamp,getdate())<240) or (TCardsRCar.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                              and ((DATEDIFF(SECOND,CarAndPersons.RelationTimeStamp,getdate())<240) or (CarAndPersons.RelationTimeStamp='2015-01-01 00:00:00.000')) 
                        Order By CarAndPersons.nIDCarAndPerson Desc,TCardsRCar.RelationId Desc,TCardsRCar.RelationTimeStamp Desc", 0, Ds, New Boolean).GetRecordsCount <> 0 Then
                        Return InstanceTrafficCards.GetNSSTrafficCard(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CardId")))
                    Else
                        Throw New SoftwareUserMoneyWalletNotFoundException
                    End If
                ElseIf YourNSSSoftwareUser.UserTypeId = R2CoreTransportationAndLoadNotificationSoftwareUserTypes.TransportCompany Then
                    If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Top 1 TransportCompaniesRelationMoneyWallets.CardId from R2Primary.dbo.TblSoftwareUsers As SoftwareUsers
                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationSoftwareUsers as TransportCompaniesRelationSoftwareUsers On SoftwareUsers.UserId=TransportCompaniesRelationSoftwareUsers.UserId 
                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On TransportCompaniesRelationSoftwareUsers.TCId=TransportCompanies.TCId 
                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationMoneyWallets as TransportCompaniesRelationMoneyWallets On TransportCompanies.TCId=TransportCompaniesRelationMoneyWallets.TransportCompanyId 
                         Where SoftwareUsers.UserId =" & YourNSSSoftwareUser.UserId & " And SoftwareUsers.UserActive = 1 And SoftwareUsers.Deleted = 0 And TransportCompaniesRelationSoftwareUsers.RelationActive = 1 And TransportCompaniesRelationMoneyWallets.RelationActive = 1 
                         Order By TransportCompaniesRelationMoneyWallets.RelationId Desc", 0, Ds, New Boolean).GetRecordsCount <> 0 Then
                        Return InstanceTrafficCards.GetNSSTrafficCard(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CardId")))
                    Else
                        Throw New SoftwareUserMoneyWalletNotFoundException
                    End If
                Else
                    Throw New SoftwareUserMoneyWalletNotFoundException
                End If
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTerafficCard(YourNSSTransprortCompany As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure) As R2CoreParkingSystemStandardTrafficCardStructure
            Dim InstanceSqlDataBOX = New R2CoreInstanseSqlDataBOXManager
            Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
            Try
                Dim Ds As New DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                       "Select Top 1 MoneyWallets.CardId 
                        from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies
                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationMoneyWallets as TCsRMoneyWallets On TransportCompanies.TCId=TCsRMoneyWallets.TransportCompanyId 
   			  			   Inner Join R2Primary.dbo.TblRFIDCards as MoneyWallets On TCsRMoneyWallets.CardId=MoneyWallets.CardId  
                        Where MoneyWallets.Active=1 and TransportCompanies.Deleted=0 and  TCsRMoneyWallets.RelationActive=1 and TransportCompanies.TCId=" & YourNSSTransprortCompany.TCId & "", 0, Ds, New Boolean).GetRecordsCount <> 0 Then
                    Return InstanceTrafficCards.GetNSSTrafficCard(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CardId")))
                Else
                    Throw New SoftwareUserMoneyWalletNotFoundException
                End If
            Catch ex As SoftwareUserMoneyWalletNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTerraficCardsManagement

    End Class


End Namespace

Namespace SoftwareUserManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationSoftwareUserTypes
        Inherits R2CoreParkingSystemSoftwareUserTypes

        Public Shared ReadOnly Property TruckOwner As Int64 = 4
        Public Shared ReadOnly Property TruckersAssociation As Int64 = 5
        Public Shared ReadOnly Property TransportCompaniesAssociation As Int64 = 6
        Public Shared ReadOnly Property TransportCompany As Int64 = 7
        Public Shared ReadOnly Property WareHouses As Int64 = 8
        Public Shared ReadOnly Property BillOfLadingIssuingCompany As Int64 = 14

    End Class

    Public Class R2CoreTransportationAndLoadNotificationInstanceSoftwareUsersManager
        Public Function GetNSSSoftwareUser(YourTransportCompanyId As Int64) As R2CoreStandardSoftwareUserStructure
            Dim InstanceSqlDataBOX As New R2CoreInstanseSqlDataBOXManager
            Dim InstanceSoftwareUser As New R2CoreInstanseSoftwareUsersManager
            Try
                Dim Ds As DataSet
                If InstanceSqlDataBOX.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Top 1 SoftwareUsers.UserId from R2Primary.dbo.TblSoftwareUsers as SoftwareUsers
                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationSoftwareUsers as TCsRSoftwareUsers On SoftwareUsers.UserId=TCsRSoftwareUsers.UserId 
                          Where SoftwareUsers.Deleted=0 and TCsRSoftwareUsers.RelationActive=1 and TCsRSoftwareUsers.TCId=" & YourTransportCompanyId & "  Order by SoftwareUsers.UserId", 0, Ds, New Boolean).GetRecordsCount = 0 Then Throw New SoftwareUserRelatedThisTransportCompanyNotFoundException
                Return InstanceSoftwareUser.GetNSSUser(Convert.ToInt64(Ds.Tables(0).Rows(0).Item("UserId")))
            Catch ex As SoftwareUserRelatedThisTransportCompanyNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function



    End Class

    Namespace Exceptions
        Public Class SoftwareUserRelatedThisTransportCompanyNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مشخصات کاربری مرتبط  با شرکت حمل و نقل مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class SoftwareUserRelatedThisTruckNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مشخصات کاربری مرتبط  با ناوگان مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace RequesterManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationRequesters
        Inherits R2CoreParkingSystemRequesters

        Public Shared ReadOnly ATISRestfullLoadAllocationRegisteringAgent As Int64 = 1
        Public Shared ReadOnly UCLoadAllocationManipulation As Int64 = 2
        Public Shared ReadOnly FrmcTruckDriverLoadAllocationsPriorityApplied As Int64 = 3
        Public Shared ReadOnly WcLoadCapacitorLoadAllocationLoadPermissionIssue As Int64 = 4
        Public Shared ReadOnly ATISRestfullTurnControllerRealTimeTurnRegisterRequest As Int64 = 12
        Public Shared ReadOnly UCLoadPermissionCancellation As Int64 = 13
        Public Shared ReadOnly ATISRestfullTurnControlerTurnIssueRequest As Int64 = 15
    End Class



End Namespace

Namespace PermissionManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationPermissionTypes
        Inherits R2CoreParkingSystemPermissionTypes

        Public Shared ReadOnly RequestersAllowAHSGIdLoadAllocationRegistering As Int64 = 3
        Public Shared ReadOnly RequesterAllowLoadAllocationByLoadStatus As Int64 = 4
        Public Shared ReadOnly LoadAllocationUseTimeHandlingByLoadStatus As Int64 = 5
        Public Shared ReadOnly LoadPermissionUseTimeHandlingByLoadStatus As Int64 = 6
        Public Shared ReadOnly RequesterCanSendRequestforTurnIssueBySeqT As Int64 = 10
        Public Shared ReadOnly UserCanRequestReserveTurnRegistering As Int64 = 11
        Public Shared ReadOnly ComputerCanRequestReserveTurnRegistering As Int64 = 12
        Public Shared ReadOnly UserCanResuscitationReserveTurn As Int64 = 13
        Public Shared ReadOnly UserCanRequestEmergencyTurnRegistering As Int64 = 14
        Public Shared ReadOnly UserCanEditLoadCapacitorLoadAfterLoadAnnounce As Int64 = 15
        Public Shared ReadOnly RequesterCanSendRequestforTurnIssueByLastLoadPermissioned As Int64 = 16
        Public Shared ReadOnly SoftwareUserCanExcecuteTurnCancellation As Int64 = 17
        Public Shared ReadOnly SoftwareUserCanSendRealTimeTurnRegisteringRequestWithLicensePlate As Int64 = 18
        Public Shared ReadOnly SoftwareUserCanSendTruckorTruckDriverChangeRequest As Int64 = 19
        Public Shared ReadOnly SoftwareUserCanExcecuteTurnCancellationWithLicensePlate As Int64 = 20
        Public Shared ReadOnly SoftwareUserCanViewAnnouncedLoadsReportOrClearanceLoadsReport As Int64 = 21
        Public Shared ReadOnly SoftwareUserCanDeleteAnyofLoadCapacitorLoad As Int64 = 23
        Public Shared ReadOnly SoftwareUserCanViewListofAllTransportCompanies As Int64 = 24
        Public Shared ReadOnly SoftwareUserCanViewListofAllLoadsofLoadCapacitor As Int64 = 25
        Public Shared ReadOnly SoftwareUserCanViewListofLoadsofLoadCapacitorofOtherUser As Int64 = 26
        Public Shared ReadOnly SoftwareUserCanEditAnyofLoadCapacitorLoad As Int64 = 27
        Public Shared ReadOnly SoftwareUserCanCancellingLoadsViaLoadStatus As Int64 = 28
        Public Shared ReadOnly RequesterCanAllocateSedimentedLoadInTimeRange As Int64 = 29
        Public Shared ReadOnly UserCanRegisterOrEditLoadsAnyTonaj As Int64 = 31
        Public Shared ReadOnly UserCanViewAllofLoadsfromApplication As Int64 = 32
    End Class

End Namespace

Namespace EntityManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationEntities
        Inherits R2CoreParkingSystemEntities

        Public Shared ReadOnly AnnouncementHallSubGroups As Int64 = 5
        Public Shared ReadOnly LoadCapacitorLoadStatuses As Int64 = 6
        Public Shared ReadOnly SequentialTurns As Int64 = 7
        Public Shared ReadOnly IndigenousTrucksTypes As Int64 = 9

    End Class



End Namespace

Namespace CalendarManagement
    Namespace SpecializedPersianCalendar
        Public Class R2CoreTransportationAndLoadNotificationSpecializedPersianCalendarManager

            Private _DateTime As New R2DateTime

            Public Function GetFirstDateShamsiInRangeWithoutHoliday(YourTopBaseDateShamsi As String, YourTotalDay As Int64) As String
                Try
                    If Not _DateTime.ChekDateShamsiFullSyntax(YourTopBaseDateShamsi) Then Throw New ShamsiDateSyntaxNotValidException
                    Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                    Dim Ds As DataSet = Nothing
                    Dim Count = R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                             Where DateShamsi<
                                   (Select Top 1 * from 
                                       (Select Top " & YourTotalDay & " DateShamsi from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                                        Where PCType=0 and DateShamsi<='" & YourTopBaseDateShamsi & "' Order By DateShamsi desc) as DataBox
                                    Order By DateShamsi)
                             Order By DateShamsi Desc", 3600, Ds, New Boolean).GetRecordsCount()
                    If Count <> YourTotalDay Then Throw New FirstDateShamsiInRangeWithoutHolidayException
                    Return Ds.Tables(0).Rows(Count - 1).Item("DateShamsi")
                Catch ex As ShamsiDateSyntaxNotValidException
                    Throw ex
                Catch ex As FirstDateShamsiInRangeWithoutHolidayException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
                End Try
            End Function

            Public Function IsTodayIsHolidayforLoadAnnounce() As Boolean
                Try
                    Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                    Dim Ds As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select Top 1 LoadAnnounce from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                               Where DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "' 
                               Order By HId Desc", 3600, Ds, New Boolean)
                    Return Ds.Tables(0).Rows(0).Item("LoadAnnounce")
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
                End Try
            End Function

            Public Function IsTomorrowIsHolidayforLoadAnnounce() As Boolean
                Try
                    Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                    Dim Ds As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select Top 1 LoadAnnounce from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                               Where DateShamsi='" & _DateTime.GetNextDateShamsi & "' 
                               Order By HId Desc", 3600, Ds, New Boolean)
                    Return Ds.Tables(0).Rows(0).Item("LoadAnnounce")
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
                End Try
            End Function

            Public Function IsTodayIsHoliday() As Boolean
                Try
                    Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                    Dim Ds As DataSet = Nothing
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select Top 1 PCTYpe from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportationLoadNotificationSpecializedPersianCalendar 
                               Where DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "' 
                               Order By HId Desc", 3600, Ds, New Boolean)
                    Return Convert.ToBoolean(Ds.Tables(0).Rows(0).Item("PCTYpe"))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
                End Try
            End Function


        End Class


    End Namespace

End Namespace

Namespace SMS

    Namespace SMSTypes
        Public MustInherit Class R2CoreTransportationAndLoadNotificationSMSTypes
            Inherits R2CoreParkingSystemSMSTypes

            Public Shared ReadOnly Property LoadAllocationsLoadPermissionRegisteringFailed = 4
            Public Shared ReadOnly Property SendingTurnNumberSMS = 9
            Public Shared ReadOnly Property SendingLoadPermissionIssuedInfSMS = 10
            Public Shared ReadOnly Property LoadingAndDischargingPLacesChangeStatus = 18
            Public Shared ReadOnly Property TransportCompanyChangeActiveStatus = 19
            Public Shared ReadOnly Property ChangeLoadInformation = 20
        End Class

    End Namespace

    Namespace RecivedSMSCodes
        Public MustInherit Class RecivedSMSCodes
            Public Shared ReadOnly Property ChangeLoadSource = 4
            Public Shared ReadOnly Property ChangeLoadTarget = 5
        End Class
    End Namespace

    Namespace SMSHandling

        Public Class R2CoreTransportationAndLoadNotificationChangeLoadSource
            Inherits RecievedSMSHandler

            Public Sub New()
                MyBase.New()
            End Sub

            Private Sub HandlingEvent_Handler() Handles MyBase.HandlingEvent
                Try
                    Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                    Dim LoadCapacitorLoadManipulation = New R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager
                    LoadCapacitorLoadManipulation.ChangeLoadSource(MobileNumber, SMSContent)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

        Public Class R2CoreTransportationAndLoadNotificationChangeLoadTarget
            Inherits RecievedSMSHandler

            Public Sub New()
                MyBase.New()
            End Sub

            Private Sub HandlingEvent_Handler() Handles MyBase.HandlingEvent
                Try
                    Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                    Dim LoadCapacitorLoadManipulation = New R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManipulationManager
                    LoadCapacitorLoadManipulation.ChangeLoadTarget(MobileNumber, SMSContent)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

    End Namespace

End Namespace

Namespace TrucksNativeness

    Public Class TruckNativenessTypes
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Native As Int64 = 1
        Public Shared ReadOnly Property UnNative As Int64 = 2
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTruckNativenessTypeStructure
        Inherits R2StandardStructure
        Public Sub New()
            MyBase.New()
            _NId = Int64.MinValue
            _NName = String.Empty
            _NTitle = String.Empty
            _NColor = Color.Red
            _DateTimeMilladi = DateTime.Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _Active = Boolean.FalseString
            _ViewFlag = Boolean.FalseString
            _Deleted = Boolean.TrueString
        End Sub

        Public Sub New(YourNId As Int64, YourNName As String, YourNTitle As String, YourNColor As Color, YourDateTimeMilladi As DateTime, YOurDateShamsi As String, YourTime As String, YourActive As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
            MyBase.New(YourNId, YourNName)
            _NId = YourNId
            _NName = YourNName
            _NTitle = YourNTitle
            _NColor = YourNColor
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YOurDateShamsi
            _Time = YourTime
            _Active = YourActive
            _ViewFlag = YourViewFlag
            _Deleted = YourDeleted
        End Sub

        Public Property NId As Int64
        Public Property NName As String
        Public Property NTitle As String
        Public Property NColor As Drawing.Color
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property Active As Boolean
        Public Property ViewFlag As Boolean
        Public Property Deleted As Boolean



    End Class

    Public Structure R2CoreTransportationAndLoadNotificationsTruckNativenessStructure
        Dim TruckNativenessTypeId As Int64
        Dim TruckNativenessExpireDate As R2StandardDateAndTimeStructure
    End Structure

    Public Class R2CoreTransportationAndLoadNotificationsTruckNativenessManager
        Private _DateTime As New R2DateTime

        Public Function ChangeTruckNativeness(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourTruckNativenessExpireDate As R2StandardDateAndTimeStructure) As R2CoreTransportationAndLoadNotificationsTruckNativenessStructure
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                'کنترل محتوای پارامتر ارسالی
                If YourNSSTruck Is Nothing Then Throw New TruckNotFoundException
                'کنترل تغییر وضعیت بومی گری ناوگان بومی با پلاک بومی - که البته امکان پذیر نیست
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                Dim IndigenousTrucks() = InstanceConfiguration.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.IndigenousTrucks, 1).Split("-")
                If IndigenousTrucks.Contains(YourNSSTruck.NSSCar.StrCarSerialNo) Then Throw New IndigenousTruckChangeNativnessFailedException
                'تغییر وضعیت بومی گری
                Dim newTruckNativenessTypeId = TrucksNativeness.TruckNativenessTypes.None
                Dim NSS = GetNSSTruckNativeness(YourNSSTruck, True)
                If NSS.TruckNativenessTypeId = R2CoreTransportationAndLoadNotification.TrucksNativeness.TruckNativenessTypes.Native Then
                    newTruckNativenessTypeId = TruckNativenessTypes.UnNative
                ElseIf NSS.TruckNativenessTypeId = R2CoreTransportationAndLoadNotification.TrucksNativeness.TruckNativenessTypes.UnNative Then
                    newTruckNativenessTypeId = TruckNativenessTypes.Native
                Else
                    Throw New TruckNativenessTypeNotValidException
                End If
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Update dbtransport.dbo.TbCar Set CarNativenessTypeId=" & newTruckNativenessTypeId & ",CarNativenessExpireDate='" & YourTruckNativenessExpireDate.DateShamsiFull & "' Where nIdCar=" & YourNSSTruck.NSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Dim TruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessStructure
                TruckNativeness.TruckNativenessExpireDate = YourTruckNativenessExpireDate
                TruckNativeness.TruckNativenessTypeId = newTruckNativenessTypeId
                Return TruckNativeness
            Catch ex As IndigenousTruckChangeNativnessFailedException
                Throw ex
            Catch ex As TruckNotFoundException
                Throw ex
            Catch ex As TruckNativenessTypeNotValidException
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


        Public Function GetNSSTruckNativeness(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourImmediately As Boolean) As R2CoreTransportationAndLoadNotificationsTruckNativenessStructure
            Try
                If YourNSSTruck Is Nothing Then Throw New TruckNotFoundException
                Dim NSS = New R2CoreTransportationAndLoadNotificationsTruckNativenessStructure
                If YourImmediately Then
                    Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                    Da.SelectCommand = New SqlCommand("Select CarNativenessTypeId,CarNativenessExpireDate From  dbtransport.dbo.TbCar Where nIDCar=" & YourNSSTruck.NSSCar.nIdCar & "")
                    Da.SelectCommand.Connection = (New R2PrimarySubscriptionDBSqlConnection).GetConnection
                    If Da.Fill(Ds) <= 0 Then Throw New TruckNotFoundException
                    NSS.TruckNativenessTypeId = Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CarNativenessTypeId"))
                    NSS.TruckNativenessExpireDate = New R2StandardDateAndTimeStructure(Nothing, Ds.Tables(0).Rows(0).Item("CarNativenessExpireDate").trim, Nothing)
                    Return NSS
                Else
                    'If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select CarNativenessTypeId,CarNativenessExpireDate From  dbtransport.dbo.TbCar Where nIDCar=" & YourNSSTruck.NSSCar.nIdCar & "", 3600, Ds).GetRecordsCount() = 0 Then Throw New TruckNotFoundException
                    Dim DSCarsNativeness As New DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Case nIDCar,CarNativenessTypeId,CarNativenessExpireDate From  dbtransport.dbo.TbCar", 3600, DSCarsNativeness, New Boolean)
                    Dim DR() = DSCarsNativeness.Tables(0).Select("nIDCar=" + YourNSSTruck.NSSCar.nIdCar)
                    NSS.TruckNativenessTypeId = Convert.ToInt64(DR(0).Item("CarNativenessTypeId"))
                    NSS.TruckNativenessExpireDate = New R2StandardDateAndTimeStructure(Nothing, DR(0).Item("CarNativenessExpireDate").trim, Nothing)
                    Return NSS
                End If
            Catch ex As TruckNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Function GetNSSTruckNativenessType(YourTruckNativenessTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardTruckNativenessTypeStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection, "Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckNativenessTypes Where NId=" & YourTruckNativenessTypeId & "", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then Throw New TruckNativenessTypeNotFoundException
                Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTruckNativenessTypeStructure(Ds.Tables(0).Rows(0).Item("NId"), Ds.Tables(0).Rows(0).Item("NName").TRIM, Ds.Tables(0).Rows(0).Item("NTitle").TRIM, Color.FromName(Ds.Tables(0).Rows(0).Item("NColor").TRIM), Ds.Tables(0).Rows(0).Item("DateTimeMilladi"), Ds.Tables(0).Rows(0).Item("DateShamsi"), Ds.Tables(0).Rows(0).Item("Time"), Ds.Tables(0).Rows(0).Item("Active"), Ds.Tables(0).Rows(0).Item("ViewFlag"), Ds.Tables(0).Rows(0).Item("Deleted"))
                Return NSS
            Catch ex As TruckNativenessTypeNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try

        End Function

        Public Function GetTruckNativenessType(YourTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As Int64
            Try
                If IsTruckIndigenous(YourTruck) Then
                    Return TruckNativenessTypes.Native
                Else
                    Return TruckNativenessTypes.UnNative
                End If
            Catch ex As TruckNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
            End Try
        End Function

        Public Function IsTruckIndigenous(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As Boolean
            Try
                If YourNSSTruck Is Nothing Then Throw New TruckNotFoundException
                Dim InstanceSqlDataBox As New R2CoreInstanseSqlDataBOXManager
                Dim Ds As DataSet = Nothing
                Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySubscriptionDBSqlConnection,
                  "Select CarNativenessTypeId,CarNativenessExpireDate from DBtransport.dbo.TbCar
                   Where StrCarNo='" & YourNSSTruck.NSSCar.StrCarNo & "' and StrCarSerialNo='" & YourNSSTruck.NSSCar.StrCarSerialNo & "'", 3600, Ds, New Boolean).GetRecordsCount() = 0 Then
                    Throw New TruckNotFoundException
                End If
                If Convert.ToInt64(Ds.Tables(0).Rows(0).Item("CarNativenessTypeId")) = TruckNativenessTypes.Native Then
                    If Ds.Tables(0).Rows(0).Item("CarNativenessExpireDate").ToString.Trim = String.Empty Then
                        Return True
                    ElseIf Ds.Tables(0).Rows(0).Item("CarNativenessExpireDate").ToString.Trim > _DateTime.GetCurrentDateShamsiFull() Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As TruckNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
            End Try
        End Function

        Public Function IsTruckIndigenous(YourTurn As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) As Boolean
            Try
                Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
                Return IsTruckIndigenous(InstanceTrucks.GetNSSTruck(YourTurn, False))
            Catch ex As TruckNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions

        Public Class IndigenousTruckChangeNativnessFailedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تغییر وضعیت ناوگان امکان پذیر نیست"
                End Get
            End Property
        End Class

        Public Class NonIndigenousTrucksException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Dim InstancePredefinedMessages = New R2CoreMClassPredefinedMessagesManager
                    Return InstancePredefinedMessages.GetNSS(R2CoreTransportationAndLoadNotification.PredefinedMessagesManagement.R2CoreTransportationPredefinedMessages.UnIndigenousTrucks).MsgContent
                End Get
            End Property
        End Class

        Public Class TruckNativenessTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات بومی گری با کد شاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class TruckNativenessTypeNotValidException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "خدرو دارای اطلاعات بومی گری غیر مجاز و تعریف نشده است"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace PredefinedMessagesManagement

    Public MustInherit Class R2CoreTransportationPredefinedMessages
        Inherits R2CoreParkingSystemPredefinedMessages

        Public Shared ReadOnly UnIndigenousTrucks As Int64 = 15


    End Class

End Namespace












