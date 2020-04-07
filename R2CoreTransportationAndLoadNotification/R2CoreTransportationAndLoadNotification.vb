
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
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
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports R2Core.PublicProc
Imports R2Core.R2PrimaryFileSharingWS
Imports R2Core.UserManagement
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
Imports R2CoreTransportationAndLoadNotification.Trucks.IndigenousTrucks
Imports R2CoreTransportationAndLoadNotification.TurnAttendance
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrinting
Imports R2CoreTransportationAndLoadNotification.Turns.TurnRegisterRequest
Imports R2CoreTransportationAndLoadNotification.AnnouncementTiming
Imports R2CoreTransportationAndLoadNotification.MobileUsers
Imports R2CoreTransportationAndLoadNotification.MobileUsers.Exeptions


Namespace Logging

    Public MustInherit Class R2CoreTransportationAndLoadNotificationLogType
        Inherits R2CoreLogType

        Public Shared ReadOnly Property LoadCapacitorSedimentingFailed As Int64 = 11
        Public Shared ReadOnly Property TurnExpirationFailed As Int64 = 12
        Public Shared ReadOnly Property LoadCapacitorAccessStatistics As Int64 = 13
        Public Shared ReadOnly Property LoadAllocationsAccessStatistics As Int64 = 14

    End Class

End Namespace

Namespace ComputerMessages

    Public MustInherit Class R2CoreTransportationAndLoadNotificationComputerMessageTypes
        Inherits R2Core.ComputerMessagesManagement.R2CoreComputerMessageTypes
        Public Shared ReadOnly EmergencyTurnRegisterRequestConfirmation As Int64 = 2
        Public Shared ReadOnly TurnPrint As Int64 = 3
    End Class

End Namespace

Namespace FileShareRawGroupsManagement

    Public MustInherit Class R2CoreTransportationAndLoadNotificationRawGroups
        Inherits R2Core.FileShareRawGroupsManagement.R2CoreRawGroups

        Public Shared ReadOnly TurnRegisterRequestAttachements As Int64 = 5


    End Class

End Namespace

Namespace Trucks
    Public Class R2CoreTransportationAndLoadNotificationStandardTruckStructure
        Public Sub New()
            MyBase.New()
            _NSSCar = Nothing
            _SmartCardNo = String.Empty
        End Sub

        Public Sub New(ByVal YourNSSCar As R2StandardCarStructure, ByVal YourSmartCardNo As String)
            _NSSCar = YourNSSCar
            _SmartCardNo = YourSmartCardNo
        End Sub

        Public Property NSSCar() As R2StandardCarStructure
        Public Property SmartCardNo() As String

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTrucksManagement
        Public Shared Function GetNSSTruck(YourTruckId As Int64) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from dbtransport.dbo.TbCar Where nIdCar=" & YourTruckId & "", 1, DS).GetRecordsCount() = 0 Then Throw New TruckNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckStructure = New R2CoreTransportationAndLoadNotificationStandardTruckStructure
                NSS.NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(DS.Tables(0).Rows(0).Item("nIdCar"))
                NSS.SmartCardNo = DS.Tables(0).Rows(0).Item("StrBodyNo")
                Return NSS
            Catch exx As TruckNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTruck(YourNSSMobileUser As R2CoreTransportationAndLoadNotificationStandardMobileUserStructure) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Top 1 * from R2Primary.dbo.TblMobileUsers as MobileUsers
                            Inner Join dbtransport.dbo.TbPerson as Persons On MobileUsers.MUMobileNumber Collate Arabic_CI_AI_WS=Persons.strIDNO Collate Arabic_CI_AI_WS
	                        Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver 
                            Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Persons.nIDPerson=CarAndPersons.nIDPerson
	                        Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
                            Inner Join dbtransport.dbo.tbCarType as CarTypes On Cars.snCarType=CarTypes.snCarType 
                         Where MobileUsers.MUId=" & YourNSSMobileUser.MUId & " and CarAndPersons.snRelation=2 and Cars.ViewFlag=1 Order By Cars.nIDCar Desc", 1, DS).GetRecordsCount() = 0 Then Throw New TruckNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckStructure = New R2CoreTransportationAndLoadNotificationStandardTruckStructure
                NSS.NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(DS.Tables(0).Rows(0).Item("nIdCar"))
                NSS.NSSCar.snCarType = DS.Tables(0).Rows(0).Item("LoaderTypeName").trim() + " - " + DS.Tables(0).Rows(0).Item("strCarName").trim()
                NSS.SmartCardNo = DS.Tables(0).Rows(0).Item("StrBodyNo")
                Return NSS
            Catch exx As TruckNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallSubGroup(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                   "Select Top 1 AHSGId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars 
                    Where CarId=" & YourNSSTruck.NSSCar.nIdCar & " and RelationActive=1 
                    Order By Priority Asc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New AnnouncementHallSubGroupRelationTruckNotExistException
                End If
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroup(Ds.Tables(0).Rows(Loopx).Item("AHSGId")))
                Next
                Return Lst
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallSubGroups(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As List(Of Int64)
            Try
                Dim Ds As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select AHSGId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars
                         Where CarId=" & YourNSSTruck.NSSCar.nIdCar & " and RelationActive=1
                         Order By Priority Asc", 1, Ds).GetRecordsCount() = 0 Then
                    Throw New AnnouncementHallSubGroupRelationTruckNotExistException
                End If
                Dim Lst As List(Of Int64) = New List(Of Int64)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Lst.Add(Ds.Tables(0).Rows(Loopx).Item("AHSGId"))
                Next
                Return Lst
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTruck(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) As R2CoreTransportationAndLoadNotificationStandardTruckStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                 Select Trucks.nIDCar,Trucks.StrBodyNo from dbtransport.dbo.tbEnterExit as Turns Inner Join dbtransport.dbo.TbCar as Trucks On Turns.strCardno=Trucks.nIDCar 
                  Where Turns.nEnterExitId=" & YourNSSTurn.nEnterExitId & "", 1, DS).GetRecordsCount() = 0 Then Throw New TruckNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckStructure = New R2CoreTransportationAndLoadNotificationStandardTruckStructure
                NSS.NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(DS.Tables(0).Rows(0).Item("nIdCar"))
                NSS.SmartCardNo = DS.Tables(0).Rows(0).Item("StrBodyNo")
                Return NSS
            Catch exx As TruckNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallSubGroup(YourTruckId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
            Try
                Return GetNSSAnnouncementHallSubGroup(GetNSSTruck(YourTruckId))(0)
            Catch ex As AnnouncementHallSubGroupNotFoundException
                Throw ex
            Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub DisabledAllTruckRelationAnnouncementHallSubGroups(YourTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars Set RelationActive=0 Where CarId=" & YourTruck.NSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SetTruckRelationAnnouncementHallSubGroup(YourTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Try
                    If GetAnnouncementHallSubGroups(YourTruck).Where(Function(x) x = YourNSSAnnouncementHallSubGroup.AHSGId).Count <> 0 Then Exit Sub
                Catch ex As AnnouncementHallSubGroupRelationTruckNotExistException
                Catch ex As Exception
                    Throw ex
                End Try
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                CmdSql.CommandText = "Select Top 1 AnnouncementHallSubGroupsRelationCars.Priority from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars as AnnouncementHallSubGroupsRelationCars
                                      Where AnnouncementHallSubGroupsRelationCars.CarId=" & YourTruck.NSSCar.nIdCar & " and AnnouncementHallSubGroupsRelationCars.RelationActive=1
                                      Order By AnnouncementHallSubGroupsRelationCars.Priority Desc"
                Dim PriorityAnnouncementHallSubGroups = CmdSql.ExecuteScalar + 1
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationCars(CarId,AHSGId,RelationActive,Priority) Values(" & YourTruck.NSSCar.nIdCar & "," & YourNSSAnnouncementHallSubGroup.AHSGId & ",1," & PriorityAnnouncementHallSubGroups & ")"
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

    Namespace IndigenousTrucks
        Public MustInherit Class R2CoreTransportationAndLoadNotificationMClassIndigenousTrucksManagement
            Private Shared _DateTime As New R2DateTime
            Public Shared Function IsIndigenousTruck(ByVal YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As Boolean
                Try
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSAnnouncementHallSubGroup(YourNSSTruck)(0)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByAnnouncementHallSubGroup(NSSAnnouncementHallSubGroup.AHSGId)
                    Dim IndigousTrucks As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, NSSAnnouncementHall.AHId, 6), "-")
                    If IndigousTrucks.Contains(YourNSSTruck.NSSCar.StrCarSerialNo) Then
                        Return True
                    Else
                        Dim DS As DataSet
                        If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblIndigenousTrucksWithUNNativeLP Where (Pelak='" & YourNSSTruck.NSSCar.StrCarNo.Trim & "') and (Serial='" & YourNSSTruck.NSSCar.StrCarSerialNo.Trim & "')", 1, DS).GetRecordsCount() = 0 Then
                            Return False
                        Else
                            Return True
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


        End Class

    End Namespace

    Namespace Exceptions
        Public Class TruckNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "ناوگان با مشخصات مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class AnnouncementHallSubGroupRelationTruckNotExistException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "اطلاعات پایه - ارتباط بین ناوگان باری با زیرگروه سالن اعلام بار مشخص نیست"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace TruckDrivers
    Public Class R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
        Public Sub New()
            MyBase.New()
            _NSSDriver = Nothing
            _StrSmartCardNo = String.Empty
        End Sub

        Public Sub New(ByVal YourNSSDriver As R2StandardDriverStructure, ByVal YourStrSmartCardNo As String)
            _NSSDriver = YourNSSDriver
            _StrSmartCardNo = YourStrSmartCardNo
        End Sub

        Public Property NSSDriver() As R2StandardDriverStructure
        Public Property StrSmartCardNo() As String

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement
        Public Shared Function GetNSSTruckDriver(YourTruckDriverId As Int64) As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from dbtransport.dbo.TbDriver Where nIdDriver=" & YourTruckDriverId & "", 1, DS).GetRecordsCount() = 0 Then Throw New TruckDriverNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure = New R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
                NSS.NSSDriver = R2CoreParkingSystemMClassDrivers.GetNSSDriver(DS.Tables(0).Rows(0).Item("nIdDriver"))
                NSS.StrSmartCardNo = DS.Tables(0).Rows(0).Item("StrSmartCardNo")
                Return NSS
            Catch exx As TruckDriverNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTruckDriver(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure) As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 Drivers.nIdDriver,Drivers.StrSmartCardNo from dbtransport.dbo.TbCar as Cars
                              Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Cars.nIDCar=CarAndPersons.nIDCar 
                              Inner Join dbtransport.dbo.TbPerson as Persons On CarAndPersons.nIDPerson=Persons.nIDPerson 
                              Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver 
                      Where  Cars.nIDCar=" & YourNSSTruck.NSSCar.nIdCar & " and Cars.ViewFlag=1 and CarAndPersons.snRelation=2", 1, DS).GetRecordsCount() = 0 Then Throw New TruckDriverNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure = New R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
                NSS.NSSDriver = R2CoreParkingSystemMClassDrivers.GetNSSDriver(DS.Tables(0).Rows(0).Item("nIdDriver"))
                NSS.StrSmartCardNo = DS.Tables(0).Rows(0).Item("StrSmartCardNo")
                Return NSS
            Catch exx As TruckDriverNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTruckDriver(YourNSSMobileUser As R2CoreTransportationAndLoadNotificationStandardMobileUserStructure) As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Top 1 * from R2Primary.dbo.TblMobileUsers as MobileUsers
                          Inner Join dbtransport.dbo.TbPerson as Persons On MobileUsers.MUMobileNumber Collate Arabic_CI_AI_WS=Persons.strIDNO Collate Arabic_CI_AI_WS
	                      Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver 
                          Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Persons.nIDPerson=CarAndPersons.nIDPerson
                     Where MobileUsers.MUId=" & YourNSSMobileUser.MUId & " and CarAndPersons.snRelation=2 ", 1, DS).GetRecordsCount() = 0 Then Throw New TruckDriverNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure = New R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
                NSS.NSSDriver = R2CoreParkingSystemMClassDrivers.GetNSSDriver(DS.Tables(0).Rows(0).Item("nIdDriver"))
                NSS.StrSmartCardNo = DS.Tables(0).Rows(0).Item("StrSmartCardNo")
                Return NSS
            Catch exx As TruckDriverNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsExistTruckDriver(YourMobileNumber As String) As Boolean
            Try
                Dim DS As New DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select nIDPerson from dbtransport.dbo.TbPerson Where strIDNO='" & YourMobileNumber.Trim & "'", 1, DS).GetRecordsCount <> 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub TruckDriverMobileEditing(YourSmartCardNo As String, YourMobileNumber As String)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update dbtransport.dbo.TbPerson Set strIDNO='" & YourMobileNumber & "' 
                                      Where nIDPerson=(Select Top 1 nIDDriver from dbtransport.dbo.TbDriver Where strSmartcardNo='" & YourSmartCardNo & "' Order By nIDDriver Desc)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

    End Class

    Namespace Exceptions
        Public Class TruckDriverNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "راننده ناوگان باری با مشخصات مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace

End Namespace

Namespace ConfigurationsManagement
    Public MustInherit Class R2CoreTransportationAndLoadNotificationConfigurations
        Inherits R2CoreConfigurations

        Public Shared ReadOnly Property LoadCapacitorLoadNumberLimit = 54
        Public Shared ReadOnly Property AnnouncementHallAnnounceTime = 55
        Public Shared ReadOnly Property AnnouncementHallsTurnCancellationSetting = 56
        Public Shared ReadOnly Property AnnouncementHallsTruckDriverAttendance = 57
        Public Shared ReadOnly Property DefaultLoadSourceInf = 58
        Public Shared ReadOnly Property AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting = 59
        Public Shared ReadOnly Property AnnouncementHallsTurnRegisteringSetting = 61
        Public Shared ReadOnly Property AnnouncementHallsLoadPermissionsSetting = 62
        Public Shared ReadOnly Property AnnouncementHallsLoadSedimentationSetting = 63
        Public Shared ReadOnly Property AnnouncementHallsAutomaticProcessesTiming = 68
        Public Shared ReadOnly Property AnnouncementHallsLoadAllocationSetting = 69
    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement
        'Inherits R2CoreMClassConfigurationManagement

        Public Shared Function GetConfigOnLine(YourCId As Int64, YourAHId As Int64) As Object
            Try
                Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
                Da.SelectCommand = New SqlCommand("Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "")
                Da.SelectCommand.Connection = (New R2PrimarySqlConnection).GetConnection()
                If Da.Fill(Ds) = 0 Then Throw New GetDataException
                Return Ds.Tables(0).Rows(0).Item("CValue").trim
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetConfig(YourCId As Int64, YourAHId As Int64, YourIndex As Int64) As Object
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds).GetRecordsCount = 0 Then
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
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 CValue from R2PrimaryTransportationAndLoadNotification.dbo.TblConfigurationsOfAnnouncementHalls Where CId=" & YourCId & " and AHId=" & YourAHId & "", 3600, Ds).GetRecordsCount = 0 Then
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

Namespace TransportCompanies

    Public Interface ITransportCompanies

    End Interface

    Public Class R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _TCId = Int64.MinValue
            _TCTitle = String.Empty
            _TCOrganizationCode = Int64.MinValue
            _TCCityId = Int64.MinValue
            _TCColor = String.Empty
            _ViewFlag = False
            _Active = False
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourTCId As Int64, YourTCTitle As String, YourTCOrganizationCode As Int64, YourTCCityId As Int64, YourTColor As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourTCId, YourTCTitle)
            _TCId = YourTCId
            _TCTitle = YourTCTitle
            _TCOrganizationCode = YourTCOrganizationCode
            _TCCityId = YourTCCityId
            _TCColor = YourTColor
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Function GetColorFromARGB() As Color
            Try
                Return Color.FromArgb(Split(TCColor, ";")(0), Split(TCColor, ";")(1), Split(TCColor, ";")(2), Split(TCColor, ";")(3))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Property TCId As Int64
        Public Property TCTitle As String
        Public Property TCOrganizationCode As Int64
        Public Property TCCityId As Int64
        Public Property TCColor As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement
        Public Shared Function GetTransportCompanies_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies Where Left(TCTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By TCTitle", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(DS.Tables(0).Rows(Loopx).Item("TCId"), DS.Tables(0).Rows(Loopx).Item("TCTitle"), DS.Tables(0).Rows(Loopx).Item("TCOrganizationCode"), DS.Tables(0).Rows(Loopx).Item("TCCityId"), DS.Tables(0).Rows(Loopx).Item("TCColor").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompanies_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies Where TCTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By TCTitle", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(DS.Tables(0).Rows(Loopx).Item("TCId"), DS.Tables(0).Rows(Loopx).Item("TCTitle"), DS.Tables(0).Rows(Loopx).Item("TCOrganizationCode"), DS.Tables(0).Rows(Loopx).Item("TCCityId"), DS.Tables(0).Rows(Loopx).Item("TCColor").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTransportCompaniesFullOfWork(YourViewFlagControlStatus As Boolean, YourActiveControlStatus As Boolean, YourWorkDate1 As R2StandardDateAndTimeStructure, YourWorkDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourAHSGId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
                Dim SqlString As String = "Select TransportCompanies.* from (Select nCompCode,Sum(nCarNumKol) as Suming from dbtransport.dbo.tbElam Where (dDateElam>='" & YourWorkDate1.DateShamsiFull & "') and (dDateElam<='" & YourWorkDate2.DateShamsiFull & "') and AHId=" & YourAHId & " and AHSGId=" & YourAHSGId & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " Group By nCompCode) as Companies
                                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Companies.nCompCode=TransportCompanies.TCId
                                           Where Deleted=0"
                If YourViewFlagControlStatus Then SqlString = SqlString + " and ViewFlag=1"
                If YourActiveControlStatus Then SqlString = SqlString + " and Active=1"
                SqlString = SqlString + " Order By Companies.Suming Desc"
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, SqlString, 1, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(DS.Tables(0).Rows(Loopx).Item("TCId"), DS.Tables(0).Rows(Loopx).Item("TCTitle"), DS.Tables(0).Rows(Loopx).Item("TCOrganizationCode"), DS.Tables(0).Rows(Loopx).Item("TCCityId"), DS.Tables(0).Rows(Loopx).Item("TCColor").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTransportCompany(YourTransportCompanyId As Int64) As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies Where TCId=" & YourTransportCompanyId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New TransportCompanyNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(DS.Tables(0).Rows(0).Item("TCId"), DS.Tables(0).Rows(0).Item("TCTitle"), DS.Tables(0).Rows(0).Item("TCOrganizationCode"), DS.Tables(0).Rows(0).Item("TCCityId"), DS.Tables(0).Rows(0).Item("TCColor").trim, DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ISTransportCompanyActive(YourNSSTransportCompany As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Active from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies Where TCId = " & YourNSSTransportCompany.TCId & "", 1, DS).GetRecordsCount() = 0 Then Throw New TransportCompanyNotFoundException
                Return DS.Tables(0).Rows(0).Item("Active")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ExistComputerInTranportCompanies(YourComputerId As Int64) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select ComId from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompaniesRelationComputers Where ComId=" & YourComputerId & " and RelationActive=1", 1, DS).GetRecordsCount = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTransportCompanyFullOfWorkCompany(YourWorkDate1 As R2StandardDateAndTimeStructure, YourWorkDate2 As R2StandardDateAndTimeStructure, YourAHId As Int64, YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 nCompCode from (Select nCompCode,Sum(nCarNumKol) as Suming from dbtransport.dbo.tbElam Where (dDateElam>='" & YourWorkDate1.DateShamsiFull & "') and (dDateElam<='" & YourWorkDate2.DateShamsiFull & "') and AHId=" & YourAHId & " and AHSGId=" & YourAHSGId & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " Group By nCompCode) as Companies  Order By Companies.Suming Desc", 1, DS).GetRecordsCount() = 0 Then Throw New TransportCompanyNotFoundException
                Return GetNSSTransportCompany(DS.Tables(0).Rows(0).Item("nCompCode"))
            Catch ex As TransportCompanyNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions
        Public Class TransportCompanyNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کد شرکت حمل و نقل در بانک اطلاعاتی یافت نشد"
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


    End Namespace

End Namespace

Namespace LoadTargets

    Public Class R2CoreTransportationAndLoadNotificationStandardProvinceStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            ProvinceId = Int64.MinValue
            ProvinceTitle = String.Empty
        End Sub

        Public Sub New(ByVal YourProvinceId As Int64, YourProvinceTitle As String)
            MyBase.New(YourProvinceId, YourProvinceTitle)
            ProvinceId = YourProvinceId
            ProvinceTitle = YourProvinceTitle
        End Sub

        Public Property ProvinceId As Int64
        Public Property ProvinceTitle As String

    End Class

    Public Interface ILoadTargets

    End Interface

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _NSSCity = Nothing
            _TargetTravelLength = Int64.MinValue
        End Sub

        Public Sub New(ByVal YourNSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure)
            MyBase.New(YourNSSCity.nCityCode, YourNSSCity.StrCityName)
            _NSSCity = YourNSSCity
            _TargetTravelLength = YourNSSCity.nDistance
        End Sub

        Public Property NSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure
        Public Property TargetTravelLength As Int64

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement

        Public Shared Function GetProvinces(YourAHId As Int64, YourAHSGId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardProvinceStructure)
            Try
                Dim AHString = " and AHs.AHId=" & YourAHId & "" + IIf(YourAHSGId = Int64.MinValue, String.Empty, " and AHSGs.AHSGId=" & YourAHSGId & "")
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                 "Select distinct Provinces.ProvinceId, Provinces.ProvinceName 
                                  from DBTransport.dbo.tbElam as LoadCapacitor
	                                 Inner join DBTransport.dbo.tbCity as Cities On LoadCapacitor.nCityCode=Cities.nCityCode  
                                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblProvinces as Provinces On Cities.nProvince=Provinces.ProvinceId 
		                             Inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AHs On LoadCapacitor.AHId=AHs.AHId 
	                                 Inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSGs On LoadCapacitor.AHSGId=AHSGs.AHSGId 
                                  Where  LoadCapacitor.bFlag=0 and  (LoadCapacitor.LoadStatus=1 or LoadCapacitor.LoadStatus=2) and LoadCapacitor.nCarNum>0 and
                                         AHs.ViewFlag=1 and AHs.Deleted=0 and AHSGs.ViewFlag=1 and AHSGs.Deleted=0 and Provinces.ViewFlag=1 and Provinces.Deleted=0" + AHString + " Order By Provinces.ProvinceName", 1, DS).GetRecordsCount() = 0 Then Throw New LoadAllocationNotFoundException
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardProvinceStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardProvinceStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Dim NSS As R2CoreTransportationAndLoadNotificationStandardProvinceStructure = New R2CoreTransportationAndLoadNotificationStandardProvinceStructure
                    NSS.ProvinceId = DS.Tables(0).Rows(Loopx).Item("ProvinceId")
                    NSS.ProvinceTitle = DS.Tables(0).Rows(Loopx).Item("ProvinceName").trim
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoadTarget(YournIdTarget As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure
            Try
                Dim NSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure = R2CoreParkingSystemMClassCitys.GetNSSCity(YournIdTarget)
                If NSSCity Is Nothing Then Throw New GetNSSException
                Return New R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure(NSSCity)
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadTargets_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure)
            Try
                Dim LstCitys As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitys_SearchforLeftCharacters(YourSearchString)
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure) = LstCitys.Select(Function(X) New R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure(X)).ToList()
                Return Lst
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadTargets_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure)
            Try
                Dim LstCitys As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitys_SearchIntroCharacters(YourSearchString)
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure) = LstCitys.Select(Function(X) New R2CoreTransportationAndLoadNotificationStandardLoadTargetStructure(X)).ToList()
                Return Lst
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class


End Namespace

Namespace LoadSources

    Public Interface ILoadSources

    End Interface

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _NSSCity = Nothing
        End Sub

        Public Sub New(ByVal YourNSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure)
            MyBase.New(YourNSSCity.nCityCode, YourNSSCity.StrCityName)
            _NSSCity = YourNSSCity
        End Sub

        Public Property NSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement
        Public Shared Function GetNSSLoadSource(YournIdSource As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure
            Try
                Dim NSSCity As R2CoreParkingSystemMClassCitys.R2StandardCityStructure = R2CoreParkingSystemMClassCitys.GetNSSCity(YournIdSource)
                If NSSCity Is Nothing Then Throw New GetNSSException
                Return New R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure(NSSCity)
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadSources_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure)
            Try
                Dim LstCitys As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitys_SearchIntroCharacters(YourSearchString)
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure) = LstCitys.Select(Function(X) New R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure(X)).ToList()
                Return Lst
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadSources_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure)
            Try
                Dim LstCitys As List(Of R2CoreParkingSystemMClassCitys.R2StandardCityStructure) = R2CoreParkingSystemMClassCitys.GetListOfCitys_SearchforLeftCharacters(YourSearchString)
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure) = LstCitys.Select(Function(X) New R2CoreTransportationAndLoadNotificationStandardLoadSourceStructure(X)).ToList()
                Return Lst
            Catch exx As GetNSSException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class


End Namespace

Namespace LoaderTypes
    Public Class R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _LoaderTypeId = Int64.MinValue
            _LoaderTypeTitle = String.Empty
            _LoaderTypeOrganizationId = Int64.MinValue
            _LoaderTypeFixStatusId = Int64.MinValue
            _ViewFlag = False
            _Active = False
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourLoaderTypeId As Int64, YourLoaderTypeTitle As String, YourLoaderTypeOrganizationId As Int64, YourLoaderTypeFixStatusId As Int64, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourLoaderTypeId, YourLoaderTypeTitle)
            _LoaderTypeId = YourLoaderTypeId
            _LoaderTypeTitle = YourLoaderTypeTitle
            _LoaderTypeOrganizationId = YourLoaderTypeOrganizationId
            _LoaderTypeFixStatusId = YourLoaderTypeFixStatusId
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property LoaderTypeId As Int64
        Public Property LoaderTypeTitle As String
        Public Property LoaderTypeOrganizationId As Int64
        Public Property LoaderTypeFixStatusId As Int64
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoaderTypesManagement
        Public Shared Function GetLoaderTypes_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes Where Left(LoaderTypeTitle," & YourSearchString.Length & ")='" & YourSearchString & "' and Deleted=0 and Active=1 Order By LoaderTypeTitle", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure(DS.Tables(0).Rows(Loopx).Item("LoaderTypeId"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeTitle"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeOrgnizationId"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeFixStatusId"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoaderTypes_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes Where LoaderTypeTitle Like '%" & YourSearchString & "%' and Deleted=0 and Active=1 Order By LoaderTypeTitle", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure(DS.Tables(0).Rows(Loopx).Item("LoaderTypeId"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeTitle"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeOrgnizationId"), DS.Tables(0).Rows(Loopx).Item("LoaderTypeFixStatusId"), DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoaderType(YourLoaderTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes Where LoaderTypeId=" & YourLoaderTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New LoadTypeNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardLoaderTypeStructure(DS.Tables(0).Rows(0).Item("LoaderTypeId"), DS.Tables(0).Rows(0).Item("LoaderTypeTitle").trim, DS.Tables(0).Rows(0).Item("LoaderTypeOrgnizationId"), DS.Tables(0).Rows(0).Item("LoaderTypeFixStatusId"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As LoadTypeNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function


    End Class

    Namespace Exceptions
        Public Class LoadTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع بارگیر مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace


End Namespace

Namespace LoadCapacitor

    Namespace LoadCapacitorAccounting

        Public MustInherit Class R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes
            Public Shared ReadOnly Property None As Int64 = 0
            Public Shared ReadOnly Property Registering As Int64 = 1
            Public Shared ReadOnly Property Editing As Int64 = 2
            Public Shared ReadOnly Property Deleting As Int64 = 3
            Public Shared ReadOnly Property Incrementing As Int64 = 4
            Public Shared ReadOnly Property Decrementing As Int64 = 5
            Public Shared ReadOnly Property Cancelling As Int64 = 6
            Public Shared ReadOnly Property Releasing As Int64 = 7
            Public Shared ReadOnly Property LoadPermissionCancelling As Int64 = 8
            Public Shared ReadOnly Property Allocating As Int64 = 9
            Public Shared ReadOnly Property AllocationCancelling As Int64 = 10
            Public Shared ReadOnly Property FreeLining As Int64 = 11
            Public Shared ReadOnly Property Sedimenting As Int64 = 12
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure

            Public Sub New()
                MyBase.New()
                _nEstelamId = Int64.MinValue
                _AccountType = R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.None
                _Amount = Int64.MinValue
                _DateTimeMilladi = Nothing
                _DateShamsi = String.Empty
                _Time = String.Empty
                _UserId = Int64.MinValue
            End Sub

            Public Sub New(ByVal YournEstelamId As Int64, YourAccountType As Int64, YourAmount As Int64, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourUserId As Int64)
                _nEstelamId = YournEstelamId
                _AccountType = YourAccountType
                _Amount = YourAmount
                _DateTimeMilladi = YourDateTimeMilladi
                _DateShamsi = YourDateShamsi
                _Time = YourTime
                _UserId = YourUserId
            End Sub

            Public Property nEstelamId As Int64
            Public Property AccountType As Int64
            Public Property Amount As Int64
            Public Property DateTimeMilladi As DateTime
            Public Property DateShamsi As String
            Public Property Time As String
            Public Property UserId As Int64
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingTypeStructure

            Public Sub New()
                MyBase.New()
                _AId = Int64.MinValue
                _ATitle = String.Empty
                _Description = String.Empty
                _Color = String.Empty
            End Sub

            Public Sub New(ByVal YourAId As Int64, YourATitle As String, YourDescription As String, YourColor As String)
                _AId = YourAId
                _ATitle = YourATitle
                _Description = YourDescription
                _Color = YourColor
            End Sub

            Public Property AId As Int64
            Public Property ATitle As String
            Public Property Description As String
            Public Property Color As String
        End Class

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement

            Private Shared _DateTime As R2DateTime = New R2DateTime()
            Public Shared Sub InsertAccounting(ByVal YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure)
                Dim CmdSql As New SqlClient.SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting(nEstelamId,AccountType,Amount,DateTimeMilladi,DateShamsi,Time,UserId) values(" & YourNSS.nEstelamId & "," & YourNSS.AccountType & "," & YourNSS.Amount & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "'," & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & ")"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function GetLoadCapacitorLoadLastAccount(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Int64
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 AccountType from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting Where nEstelamId=" & YourNSS.nEstelamId & " Order By DateTimeMilladi Desc", 1, DS).GetRecordsCount() = 0 Then Throw New LoadCapacitorLoadNotFoundException
                    Return DS.Tables(0).Rows(0).Item("AccountType")
                Catch exx As LoadCapacitorLoadNotFoundException
                    Throw exx
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalLoadCapacitorLoadAllocating(YournEstelamId As Int64) As Int64
                Try
                    Dim DS As DataSet
                    Dim AllocatingCount As Int64 = R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting Where nEstelamId=" & YournEstelamId & " and AccountType=9", 0, DS).GetRecordsCount()
                    Dim AllocatingCancellingCount As Int64 = R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting Where nEstelamId=" & YournEstelamId & " and AccountType=10", 0, DS).GetRecordsCount()
                    Return AllocatingCount - AllocatingCancellingCount
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalLoadCapacitorLoadWhichCanAllocate(YournEstelamId As Int64) As Int64
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Return NSSLoadCapacitorLoad.nCarNum - GetTotalLoadCapacitorLoadAllocating(YournEstelamId)
                Catch ex As Exception

                End Try
            End Function

            Public Shared Function GetNSSLoadCapacitorLoadAccountingType(YourAccountingTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingTypeStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccountingType Where AId=" & YourAccountingTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New LoadCapacitorAccountingTypeNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingTypeStructure(DS.Tables(0).Rows(0).Item("AId"), DS.Tables(0).Rows(0).Item("ATitle").trim, DS.Tables(0).Rows(0).Item("Description").trim, DS.Tables(0).Rows(0).Item("Color").trim)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetAccountings(YournEstelamId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure)
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting Where nEstelamId=" & YournEstelamId & " Order By DateTimeMilladi Desc", 1, DS)
                    Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("AccountType"), DS.Tables(0).Rows(Loopx).Item("Amount"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("Time"), DS.Tables(0).Rows(Loopx).Item("UserId")))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfLoadAccounting(YourAccountingType As Int64, YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                     Select Sum(LoadCapacitorAccounting.Amount) as TotalAmount from  dbtransport.dbo.tbElam as LoadCapacitor 
                        Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting as LoadCapacitorAccounting On LoadCapacitor.nEstelamID=LoadCapacitorAccounting.nEstelamId 
                     Where LoadCapacitorAccounting.DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "' and  LoadCapacitorAccounting.AccountType=" & YourAccountingType & " and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.AHSGId=" & YourAHSGId & "", 1, DS).GetRecordsCount = 0 Then
                        Return 0
                    Else
                        Return DS.Tables(0).Rows(0).Item("TotalAmount")
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function





        End Class


    End Namespace

    Namespace LoadCapacitorLoad

        Public Enum R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions
            None = 0
            nEstelamId = 1
            TransportCompany = 2
            Product = 3
            TargetCity = 4
            nCarNumKol = 5
            TransportPrice = 6
            LoaderType = 7
            LoadStatus = 8
            TimeElam = 9
            ProductReciever = 10
            Address = 11
            User = 12
            TargetProvince = 13
        End Enum

        Public MustInherit Class R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses
            Public Shared ReadOnly Property None As Int64 = 0
            Public Shared ReadOnly Property Registered As Int64 = 1
            Public Shared ReadOnly Property FreeLined As Int64 = 2
            Public Shared ReadOnly Property Deleted As Int64 = 3
            Public Shared ReadOnly Property Cancelled As Int64 = 4
            Public Shared ReadOnly Property Sedimented As Int64 = 5
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStatusStructure

            Public Sub New()
                _LoadStatusId = Int64.MinValue
                _LoadStatusName = String.Empty
                _LoadStatusColor = String.Empty
            End Sub

            Public Sub New(ByVal YourLoadStatusId As Int64, YourLoadStatusName As String, YourLoadStatusColor As String)
                _LoadStatusId = YourLoadStatusId
                _LoadStatusName = YourLoadStatusName
                _LoadStatusColor = YourLoadStatusColor
            End Sub

            Public Property LoadStatusId As Int64
            Public Property LoadStatusName As String
            Public Property LoadStatusColor As String
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure

            Public Sub New()
                MyBase.New()
                _nEstelamId = Int64.MinValue
                _StrBarName = String.Empty
                _nCityCode = Int64.MinValue
                _nBarCode = Int64.MinValue
                _nCompCode = Int64.MinValue
                _nTruckType = Int64.MinValue
                _StrAddress = String.Empty
                _nUserId = Int64.MinValue
                _nCarNumKol = Int64.MinValue
                _StrPriceSug = Int64.MinValue
                _StrDescription = String.Empty
                _dDateElam = String.Empty
                _dTimeElam = String.Empty
                _nCarNum = Int64.MinValue
                _LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.None
                _nBarSource = Int64.MinValue
                _AHId = Int64.MinValue
                _AHSGId = Int64.MinValue
            End Sub

            Public Sub New(ByVal YournEstelamId As Int64, YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournUserId As Int64, YournCarNumKol As Int64, YourStrPriceSug As Int64, YourStrDescription As String, YourdDateElam As String, YourdTimeElam As String, YournCarNum As Int64, YourLoadStatus As Int64, YournBarSource As Int64, YourAHId As Int64, YourAHSGId As Int64)
                _nEstelamId = YournEstelamId
                _StrBarName = YourStrBarName
                _nCityCode = YournCityCode
                _nBarCode = YournBarCode
                _nCompCode = YournCompCode
                _nTruckType = YournTruckType
                _StrAddress = YourStrAddress
                _nUserId = YournUserId
                _nCarNumKol = YournCarNumKol
                _StrPriceSug = YourStrPriceSug
                _StrDescription = YourStrDescription
                _dDateElam = YourdDateElam
                _dTimeElam = YourdTimeElam
                _nCarNum = YournCarNum
                _LoadStatus = YourLoadStatus
                _nBarSource = YournBarSource
                _AHId = YourAHId
                _AHSGId = YourAHSGId
            End Sub

            Public Property nEstelamId As Int64
            Public Property StrBarName As String
            Public Property nCityCode As Int64
            Public Property nBarCode As Int64
            Public Property nCompCode As Int64
            Public Property nTruckType As Int64
            Public Property StrAddress As String
            Public Property nUserId As Int64
            Public Property nCarNumKol As Int64
            Public Property StrPriceSug As Int64
            Public Property StrDescription As String
            Public Property dDateElam() As String
            Public Property dTimeElam() As String
            Public Property nCarNum As Int64
            Public Property LoadStatus As Int64
            Public Property nBarSource As Int64
            Public Property AHId() As Int64
            Public Property AHSGId() As Int64
        End Class

        Public Class R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure
            Inherits R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure

            Public Sub New()
                MyBase.New()
                _TransportCompanyTitle = String.Empty
                _GoodTitle = String.Empty
                _LoadTargetTitle = String.Empty
                _LoaderTypeTitle = String.Empty
                _TransportCompanyTel = String.Empty
            End Sub

            Public Sub New(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure, YourTransportCompanyTitle As String, YourGoodTitle As String, YourLoadTargetTitle As String, YourLoaderTypeTitle As String, YourTransportCompanyTel As String)
                MyBase.New(YourNSS.nEstelamId, YourNSS.StrBarName, YourNSS.nCityCode, YourNSS.nBarCode, YourNSS.nCompCode, YourNSS.nTruckType, YourNSS.StrAddress, YourNSS.nUserId, YourNSS.nCarNumKol, YourNSS.StrPriceSug, YourNSS.StrDescription, YourNSS.dDateElam, YourNSS.dTimeElam, YourNSS.nCarNum, YourNSS.LoadStatus, YourNSS.nBarSource, YourNSS.AHId, YourNSS.AHSGId)
                _TransportCompanyTitle = YourTransportCompanyTitle
                _GoodTitle = YourGoodTitle
                _LoadTargetTitle = YourLoadTargetTitle
                _LoaderTypeTitle = YourLoaderTypeTitle
                _TransportCompanyTel = YourTransportCompanyTel
            End Sub

            Public Property TransportCompanyTitle As String
            Public Property TransportCompanyTel As String
            Public Property GoodTitle As String
            Public Property LoadTargetTitle As String
            Public Property LoaderTypeTitle As String

        End Class

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement
            Private Shared _DateTime As New R2DateTime

            Public Shared Function GetNSSLoadCapacitorLoadStatus(YourLoadCapacitorLoadStatusId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStatusStructure
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses Where LoadStatusId=" & YourLoadCapacitorLoadStatusId & "", 3600, DS).GetRecordsCount = 0 Then Throw New LoadCapacitorLoadStatusException
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStatusStructure
                    NSS.LoadStatusId = YourLoadCapacitorLoadStatusId
                    NSS.LoadStatusName = DS.Tables(0).Rows(0).Item("LoadStatusName").TRIM
                    NSS.LoadStatusColor = DS.Tables(0).Rows(0).Item("LoadStatusColor").TRIM
                    Return NSS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNSSLoadCapacitorLoad(YournEstelamId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure
                Try
                    Dim DS As DataSet = Nothing
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Elam.nEstelamID,Elam.strBarName,Elam.nCityCode,Elam.nBarcode,Elam.nCompCode,Elam.nTruckType,Elam.strAddress,Elam.nUserID,Elam.nCarNumKol,Elam.strPriceSug,Elam.strDescription,Elam.dDateElam,Elam.dTimeElam,Elam.nCarNum,Elam.LoadStatus,Elam.nBarSource,Elam.AHId,Elam.AHSGId,TransportCompanies.TCTitle,Product.strGoodName,City.strCityName,LoaderType.LoaderTypeTitle From DBTransport.dbo.TbElam as Elam Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Elam.nCompCode=TransportCompanies.TCId Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LoaderType On Elam.nTruckType=LoaderType.LoaderTypeId Where nEstelamId=" & YournEstelamId & "and LoadStatus<>3", 0, DS).GetRecordsCount <> 0 Then
                        Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure
                        NSS.nEstelamId = YournEstelamId
                        NSS.nTruckType = DS.Tables(0).Rows(0).Item("nTruckType")
                        NSS.StrAddress = DS.Tables(0).Rows(0).Item("StrAddress").trim
                        NSS.nUserId = DS.Tables(0).Rows(0).Item("nUserId")
                        NSS.StrBarName = DS.Tables(0).Rows(0).Item("StrBarName").trim
                        NSS.StrDescription = DS.Tables(0).Rows(0).Item("StrDescription").trim
                        NSS.StrPriceSug = DS.Tables(0).Rows(0).Item("strPriceSug")
                        NSS.dDateElam = DS.Tables(0).Rows(0).Item("dDateElam").TRIM
                        NSS.dTimeElam = DS.Tables(0).Rows(0).Item("dTimeElam").TRIM
                        NSS.nBarCode = DS.Tables(0).Rows(0).Item("nBarCode")
                        NSS.nCarNum = DS.Tables(0).Rows(0).Item("nCarNum")
                        NSS.nCarNumKol = DS.Tables(0).Rows(0).Item("nCarNumKol")
                        NSS.nCityCode = DS.Tables(0).Rows(0).Item("nCityCode")
                        NSS.nCompCode = DS.Tables(0).Rows(0).Item("nCompCode")
                        NSS.LoadStatus = DS.Tables(0).Rows(0).Item("LoadStatus")
                        NSS.nBarSource = DS.Tables(0).Rows(0).Item("nBarSource")
                        NSS.AHId = DS.Tables(0).Rows(0).Item("AHId")
                        NSS.AHSGId = DS.Tables(0).Rows(0).Item("AHSGId")
                        NSS.TransportCompanyTitle = DS.Tables(0).Rows(0).Item("TCTitle").trim
                        NSS.GoodTitle = DS.Tables(0).Rows(0).Item("strGoodName").trim
                        NSS.LoadTargetTitle = DS.Tables(0).Rows(0).Item("strCityName").trim
                        NSS.LoaderTypeTitle = DS.Tables(0).Rows(0).Item("LoaderTypeTitle").trim
                        Return NSS
                    Else
                        Throw New LoadCapacitorLoadNotFoundException
                    End If
                Catch exx As LoadCapacitorLoadNotFoundException
                    Throw exx
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetLoadCapacitorLoads(YourAHId As Int64, YourAHSGId As Int64, YourAHATTypeId As Int64, YournCarNumViewZeroFlag As Boolean, YourLoadStatusLimitation As Boolean, YourOrderingOptions As R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions, Optional YourTransportCompanyId As Int64 = Int64.MinValue, Optional YourProvinceId As Int64 = Int64.MinValue) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure)
                Try
                    Dim LastAnnounceTime As String
                    If YourAHSGId = Int64.MinValue Then
                        LastAnnounceTime = String.Empty
                    Else
                        LastAnnounceTime = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncemenetHallLastAnnounceTime(YourAHId, YourAHSGId).Time
                    End If
                    Dim DS As DataSet
                    Dim Sql As String
                    Sql = "Select Elam.nEstelamID,Elam.strBarName,Elam.nCityCode,Elam.nBarcode,Elam.nCompCode,Elam.nTruckType,Elam.strAddress,Elam.nUserID,Elam.nCarNumKol,Elam.strPriceSug,Elam.strDescription,Elam.dDateElam,Elam.dTimeElam,Elam.nCarNum,Elam.LoadStatus,Elam.nBarSource,Elam.AHId,Elam.AHSGId,TransportCompanies.TCTitle,TransportCompanies.TCTel,Product.strGoodName,City.strCityName,LoaderType.LoaderTypeTitle 
                           From DBTransport.dbo.TbElam as Elam 
	                          Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Elam.nCompCode=TransportCompanies.TCId 
                              Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode 
                              Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode 
                              Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LoaderType On Elam.nTruckType=LoaderType.LoaderTypeId 
                              Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblProvinces as Provinces on City.nProvince=Provinces.ProvinceId 
                           Where Elam.dDateElam ='" & _DateTime.GetCurrentDateShamsiFull() & "' and Elam.AHId=" & YourAHId & "" + IIf(YourAHSGId = Int64.MinValue, " ", " and Elam.AHSGId=" & YourAHSGId & "")
                    If YourLoadStatusLimitation Then Sql = Sql + " And Elam.LoadStatus<>3 And Elam.LoadStatus<>4"
                    If Not YournCarNumViewZeroFlag Then Sql = Sql + " And Elam.nCarNum>0"
                    If YourAHATTypeId = AnnouncementHallAnnounceTimeTypes.UnAnnounceLoads Then Sql = Sql + " And Elam.dTimeElam>='" & LastAnnounceTime & "' and Elam.LoadStatus<>5"
                    If YourAHATTypeId = AnnouncementHallAnnounceTimeTypes.LastAnnounceLoads Then Sql = Sql + " and Elam.dTimeElam<'" & LastAnnounceTime & "' and Elam.LoadStatus<>5"
                    If YourAHATTypeId = AnnouncementHallAnnounceTimeTypes.SedimentedLoads Then Sql = Sql + "  and Elam.LoadStatus=5"
                    If YourAHATTypeId = AnnouncementHallAnnounceTimeTypes.AllOfLoadsWithoutSedimentedLoads Then Sql = Sql + " and Elam.LoadStatus<>5"
                    If YourTransportCompanyId <> Int64.MinValue Then Sql = Sql + " and Elam.nCompCode=" & YourTransportCompanyId & ""
                    If YourProvinceId <> Int64.MinValue Then Sql = Sql + " and Provinces.ProvinceId=" & YourProvinceId & ""
                    Select Case YourOrderingOptions
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nEstelamId
                            Sql = Sql + " Order By Elam.nEstelamId Desc"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.Address
                            Sql = Sql + " Order By Elam.strAddress,Elam.nCityCode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.LoadStatus
                            Sql = Sql + " Order By Elam.LoadStatus Desc"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.LoaderType
                            Sql = Sql + " Order By LoaderType.LoaderTypeTitle,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.Product
                            Sql = Sql + " Order By Product.strGoodName,TransportCompanies.TCTitle"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.ProductReciever
                            Sql = Sql + " Order By Elam.strBarName Desc,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetCity
                            Sql = Sql + " Order By City.strCityName,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TimeElam
                            Sql = Sql + " Order By Elam.dTimeElam Desc"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TransportCompany
                            Sql = Sql + " Order By TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TransportPrice
                            Sql = Sql + " Order By Elam.strPriceSug Desc,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.User
                            Sql = Sql + " Order By Elam.nUserID Desc,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nCarNumKol
                            Sql = Sql + " Order By Elam.nCarNumKol Desc,TransportCompanies.TCTitle,Elam.nBarcode"
                        Case R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetProvince
                            Sql = Sql + " Order By City.nProvince,City.strCityName"

                    End Select
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, Sql, 0, DS)
                    Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure)
                    For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                        Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("StrBarName").trim, DS.Tables(0).Rows(Loopx).Item("nCityCode"), DS.Tables(0).Rows(Loopx).Item("nBarCode"), DS.Tables(0).Rows(Loopx).Item("nCompCode"), DS.Tables(0).Rows(Loopx).Item("nTruckType"), DS.Tables(0).Rows(Loopx).Item("StrAddress").trim, DS.Tables(0).Rows(Loopx).Item("nUserId"), DS.Tables(0).Rows(Loopx).Item("nCarNumKol"), DS.Tables(0).Rows(Loopx).Item("StrPriceSug"), DS.Tables(0).Rows(Loopx).Item("strDescription").trim, DS.Tables(0).Rows(Loopx).Item("dDateElam").trim, DS.Tables(0).Rows(Loopx).Item("dTimeElam").trim, DS.Tables(0).Rows(Loopx).Item("nCarNum"), DS.Tables(0).Rows(Loopx).Item("LoadStatus"), DS.Tables(0).Rows(Loopx).Item("nBarSource"), DS.Tables(0).Rows(Loopx).Item("AHId"), DS.Tables(0).Rows(Loopx).Item("AHSGId")), DS.Tables(0).Rows(Loopx).Item("TCTitle").trim, DS.Tables(0).Rows(Loopx).Item("strGoodName").trim, DS.Tables(0).Rows(Loopx).Item("strCityName").trim, DS.Tables(0).Rows(Loopx).Item("LoaderTypeTitle").trim, DS.Tables(0).Rows(Loopx).Item("TCTel").trim))
                    Next
                    Return Lst
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetNotSedimentedLoadCapacitorLoads(YourTransportCompanyId As Int64) As DataSet
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                      "Select Elam.nEstelamID,Elam.strBarName,Elam.nCityCode,Elam.nBarcode,Elam.nCompCode,Elam.nTruckType,Elam.strAddress,Elam.nCarNumKol,
                              Elam.strPriceSug,Elam.strDescription,Elam.dDateElam,Elam.dTimeElam,Elam.nCarNum,Elam.nBarSource From DBTransport.dbo.TbElam as Elam 
                        Where Elam.dDateElam='" & _DateTime.GetCurrentDateShamsiFull() & "' and Elam.LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " and Elam.LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & " and Elam.LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " and Elam.nCompCode=" & YourTransportCompanyId & " Order By Elam.nEstelamID", 1, DS)
                    Return DS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetSedimentedLoadCapacitorLoads(YourTransportCompanyId As Int64) As DataSet
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                      "Select Elam.nEstelamID,Elam.strBarName,Elam.nCityCode,Elam.nBarcode,Elam.nCompCode,Elam.nTruckType,Elam.strAddress,Elam.nCarNumKol,
                              Elam.strPriceSug,Elam.strDescription,Elam.dDateElam,Elam.dTimeElam,Elam.nCarNum,Elam.nBarSource From DBTransport.dbo.TbElam as Elam 
                        Where Elam.dDateElam='" & _DateTime.GetCurrentDateShamsiFull() & "' and Elam.LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & "
                               and Elam.nCompCode=" & YourTransportCompanyId & " Order By Elam.nEstelamID", 1, DS)
                    Return DS
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsLoadCapacitorLoadReadeyforLoadPermissionRegistering(YournEstelamId As Int64) As Boolean
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(NSSLoadCapacitorLoad.nTruckType)
                    'کنترل زمان ترخیص بار 
                    If Not R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, NSSLoadCapacitorLoad.dTimeElam)) Then
                        If Not NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined Then Return False
                    End If
                    'کنترل وضعیت بار
                    If Not (NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined) Then Return False
                    'کنترل تعداد بار
                    If NSSLoadCapacitorLoad.nCarNum < 1 Then Return False
                    Return True
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsLoadCapacitorLoadTimingReadeyforLoadAllocationRegistering(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure, YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) As Boolean
                Try
                    'کنترل تایمینگ تخصیص بار 
                    If Not R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(YourNSSAnnouncementHall.AHId, YourNSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, YourNSSLoadCapacitorLoad.dTimeElam)) Then
                        If Not YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined Then Return False
                    End If
                    Return True
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Private Shared Function IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering_(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Boolean
                Try
                    'کنترل وضعیت بار
                    If Not (YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered Or YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined) Then Return False
                    'کنترل تعداد بار
                    If R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.GetTotalLoadCapacitorLoadWhichCanAllocate(YourNSSLoadCapacitorLoad.nEstelamId) < 1 Then Return False
                    Return True
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering(YournEstelamId As Int64) As Boolean
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Return IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering_(NSSLoadCapacitorLoad)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Boolean
                Try
                    Return IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering_(YourNSSLoadCapacitorLoad)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Private Shared Function GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId As Int64, YourAHSGId As Int64, YourAccountType As Int64) As Int64
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                        "Select Sum(LoadCapacitorAccounting.Amount) as TotalAmount from  dbtransport.dbo.tbElam as LoadCapacitor 
                             Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorAccounting as LoadCapacitorAccounting On LoadCapacitor.nEstelamID=LoadCapacitorAccounting.nEstelamId 
                         Where LoadCapacitorAccounting.DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "' and  LoadCapacitorAccounting.AccountType=" & YourAccountType & " and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.AHSGId=" & YourAHSGId & "", 1, DS).GetRecordsCount = 0 Then
                        Return 0
                    Else
                        If IsDBNull(DS.Tables(0).Rows(0).Item("TotalAmount")) Then
                            Return 0
                        Else
                            Return DS.Tables(0).Rows(0).Item("TotalAmount")
                        End If
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfRegisteredLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Registering)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfDeletedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Deleting)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfIncrementedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Incrementing)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfDecrementedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Decrementing)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfFreeLinedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.FreeLining)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfAnnouncedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfRegisteredLoads(YourAHId, YourAHSGId) - GetTotalAmountOfDeletedLoads(YourAHId, YourAHSGId) + GetTotalAmountOfIncrementedLoads(YourAHId, YourAHSGId) - GetTotalAmountOfDecrementedLoads(YourAHId, YourAHSGId)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfLoadAllocated(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Allocating)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfLoadAllocationCancelled(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.AllocationCancelling)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfReleasedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Releasing)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfSedimentedLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Sedimenting)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfLoadPermissionCancelledLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.LoadPermissionCancelling)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfCancelledLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfLoadCapacitorLoadAccounting(YourAHId, YourAHSGId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Cancelling)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Function GetTotalAmountOfReminderOfLoads(YourAHId As Int64, YourAHSGId As Int64) As Int64
                Try
                    Return GetTotalAmountOfAnnouncedLoads(YourAHId, YourAHSGId) - GetTotalAmountOfReleasedLoads(YourAHId, YourAHSGId) - GetTotalAmountOfSedimentedLoads(YourAHId, YourAHSGId) + GetTotalAmountOfLoadPermissionCancelledLoads(YourAHId, YourAHSGId) - GetTotalAmountOfCancelledLoads(YourAHId, YourAHSGId)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

        End Class


    End Namespace

    Namespace LoadCapacitorLoadManipulation
        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement
            Private Shared _DateTime As New R2DateTime

            Public Shared Function LoadCapacitorLoadRegistering(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As Int64
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallfromLoadCapacitorLoad(YourNSS)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(YourNSS.nTruckType)
                    YourNSS.AHId = NSSAnnouncementHall.AHId
                    YourNSS.AHSGId = NSSAnnouncementHallSubGroup.AHSGId
                    'کنترل تعداد بار
                    If YourNSS.nCarNumKol > R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.LoadCapacitorLoadNumberLimit, 0) Then Throw New LoadCapacitorLoadNumberOverLimitException
                    If YourNSS.nCarNumKol < 1 Then Throw New LoadCapacitorLoadnCarNumKolCanNotBeZeroException
                    'کنترل اکتیو بودن شرکت حمل و نقل
                    If R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.ISTransportCompanyActive(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(YourNSS.nCompCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)) = False Then Throw New TransportCompanyISNotActiveException
                    'کنترل اتمام زمان ثبت بار
                    If _DateTime.GetCurrentTime() > R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallLeastAnnounceTime(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId).Time Then
                        Throw New LoadCapacitorLoadRegisterTimePassedException
                    End If

                    'استاندارد سازی نرخ حمل بر اساس تعرفه های سازمانی
                    Dim Tarrif As String = YourNSS.StrPriceSug
                    Try
                        Tarrif = R2CoreTransportationAndLoadNotificationMClassTransportTarrifsManagement.GetNSSTransportTarrif(YourNSS).Tarrif
                    Catch exx As TransportPriceTarrifNotFoundException
                    End Try

                    'ثبت بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select Top 1 nEstelamId From dbtransport.dbo.TbElam with (tablockx) Order By nEstelamId Desc"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Select IDENT_CURRENT('dbtransport.dbo.TbElam') "
                    Dim nEstelamIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                    CmdSql.CommandText = "Insert Into dbtransport.dbo.TbElam(StrBarName,nCityCode,nBarCode,bFlag,nCompCode,nTruckType,nCarNum,StrAddress,nUserId,dDateElam,dTimeElam,nCarNumKol,StrPriceSug,StrDescription,LoadStatus,nBarSource,AHId,AHSGId) Values('" & YourNSS.StrBarName & "'," & YourNSS.nCityCode & "," & YourNSS.nBarCode & ",0," & YourNSS.nCompCode & "," & YourNSS.nTruckType & "," & YourNSS.nCarNumKol & ",'" & YourNSS.StrAddress & "'," & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & ",'" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "'," & YourNSS.nCarNumKol & "," & Tarrif & ",'" & YourNSS.StrDescription & "'," & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered & ",21310000," & NSSAnnouncementHall.AHId & "," & NSSAnnouncementHallSubGroup.AHSGId & ")"
                    CmdSql.ExecuteNonQuery()
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(nEstelamIdNew, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Registering, YourNSS.nCarNumKol, Nothing, Nothing, Nothing, Nothing))
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                    'ارسال کد مخزن بار
                    Return nEstelamIdNew
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub LoadCapacitorLoadEditing(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = AnnouncementHalls.R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallfromLoadCapacitorLoad(YourNSS)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(YourNSS.nTruckType)
                    YourNSS.AHId = NSSAnnouncementHall.AHId
                    YourNSS.AHSGId = NSSAnnouncementHallSubGroup.AHSGId
                    Dim CurrentNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YourNSS.nEstelamId)
                    'کنترل اتمام زمان ویرایش بار
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, YourNSS.dTimeElam)) Then Throw New LoadCapacitorLoadEditTimePassedException
                    'کنترل تعداد بار
                    If YourNSS.nCarNumKol > R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.LoadCapacitorLoadNumberLimit, 0) Then Throw New LoadCapacitorLoadNumberOverLimitException
                    If YourNSS.nCarNumKol = 0 Then Throw New LoadCapacitorLoadnCarNumKolCanNotBeZeroException
                    'کنترل اکتیو بودن شرکت حمل و نقل
                    If R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.ISTransportCompanyActive(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(YourNSS.nCompCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)) = False Then Throw New TransportCompanyISNotActiveException

                    'استاندارد سازی نرخ حمل بر اساس تعرفه های سازمانی
                    Dim Tarrif As String = YourNSS.StrPriceSug
                    Try
                        Tarrif = R2CoreTransportationAndLoadNotificationMClassTransportTarrifsManagement.GetNSSTransportTarrif(YourNSS).Tarrif
                    Catch exx As TransportPriceTarrifNotFoundException
                    End Try

                    'ویرایش بار
                    Dim CurrentnCarNumKol As Int64 = CurrentNSSLoadCapacitorLoad.nCarNumKol
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    'کنترل وضعیت بار
                    If CurrentNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Or CurrentNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled Or CurrentNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException

                    CmdSql.CommandText = "Update dbtransport.dbo.TbElam Set nCompCode=" & YourNSS.nCompCode & ",nBarSource=" & 21310000 & ",AHId=" & NSSAnnouncementHall.AHId & ",AHSGId=" & NSSAnnouncementHallSubGroup.AHSGId & ",StrBarName='" & YourNSS.StrBarName & "',nCityCode=" & YourNSS.nCityCode & ",nBarCode=" & YourNSS.nBarCode & ",nTruckType=" & YourNSS.nTruckType & ",nCarNum=" & YourNSS.nCarNumKol & ",StrAddress='" & YourNSS.StrAddress & "',nCarNumKol=" & YourNSS.nCarNumKol & ",StrPriceSug='" & Tarrif & "',StrDescription='" & YourNSS.StrDescription & "' Where nEstelamId=" & YourNSS.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(YourNSS.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Editing, YourNSS.nCarNumKol, Nothing, Nothing, Nothing, Nothing))
                    If CurrentnCarNumKol > YourNSS.nCarNumKol Then
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(YourNSS.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Decrementing, CurrentnCarNumKol - YourNSS.nCarNumKol, Nothing, Nothing, Nothing, Nothing))
                    ElseIf CurrentnCarNumKol < YourNSS.nCarNumKol Then
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(YourNSS.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Incrementing, YourNSS.nCarNumKol - CurrentnCarNumKol, Nothing, Nothing, Nothing, Nothing))
                    End If
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadDeleting(YournEstelamId As Int64)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(NSSLoadCapacitorLoad.nTruckType)

                    'کنترل اتمام زمان حذف بار
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, NSSLoadCapacitorLoad.dTimeElam)) Then Throw New LoadCapacitorLoadDeleteTimePassedException
                    'حذف بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    'کنترل وضعیت بار
                    If Not (NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Registered Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined) Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException

                    CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Deleting, NSSLoadCapacitorLoad.nCarNumKol, Nothing, Nothing, Nothing, Nothing))
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadCancelling(YournEstelamId As Int64)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(NSSLoadCapacitorLoad.nTruckType)

                    'کنترل زمان کنسلی بار
                    If Not R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, NSSLoadCapacitorLoad.dTimeElam)) Then Throw New LoadCapacitorLoadCancelTimeNotReachedException
                    'حذف بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    'کنترل وضعیت بار
                    If NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException

                    CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & " Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Cancelling, 1, Nothing, Nothing, Nothing, Nothing))
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As Exception
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadFreeLining(YournEstelamId As Int64)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(NSSLoadCapacitorLoad.nTruckType)

                    'خط آزاد نمودن بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    'کنترل وضعیت بار
                    If NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
                    'کنترل زمان خط آزاد نمودن بار
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, NSSLoadCapacitorLoad.dTimeElam)) Then Throw New LoadCapacitorLoadFreeLiningTimePassedException

                    CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined & " Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.FreeLining, NSSLoadCapacitorLoad.nCarNumKol, Nothing, Nothing, Nothing, Nothing))
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

    Namespace LoadCapacitorLoadOtherThanManipulation
        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement
            Private Shared _DateTime As New R2DateTime

            Public Shared Sub LoadCapacitorLoadReleasing(YournEstelamId As Int64)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroupByLoaderTypeId(NSSLoadCapacitorLoad.nTruckType)

                    'کنترل زمان ترخیص بار 
                    If Not R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsAnnouncemenetHallAnnounceTimePassed(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, New R2StandardDateAndTimeStructure(Nothing, Nothing, NSSLoadCapacitorLoad.dTimeElam)) Then
                        If Not NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.FreeLined Then Throw New LoadCapacitorLoadReleaseTimeNotReachedException
                    End If

                    'ترخیص بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select nEstelamId from DBTransport.dbo.TbElam  with (tablockx) Where nEstelamId=" & YournEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'کنترل وضعیت بار
                    If NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
                    'کنترل تعداد بار
                    If NSSLoadCapacitorLoad.nCarNum < 1 Then Throw New LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException
                    CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set nCarNum=nCarNum-1,dDateExit='" & _DateTime.GetCurrentDateShamsiFull() & "',dTimeExit='" & _DateTime.GetCurrentTime() & "' Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Releasing, 1, Nothing, Nothing, Nothing, Nothing))
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                Catch ex As LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As LoadCapacitorLoadReleaseTimeNotReachedException
                    If CmdSql.Connection.State <> ConnectionState.Closed Then
                        CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                    End If
                    Throw ex
                Catch ex As GetNSSException
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

            Public Shared Sub LoadCapacitorLoadPermissionCancelling(YournEstelamId As Int64, YourLoadCapacitorLoadResuscitationFlag As Boolean)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    'کنسلی مجوز بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select nEstelamId from DBTransport.dbo.TbElam  with (tablockx) Where nEstelamId=" & YournEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'کنترل وضعیت بار
                    If NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Or NSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
                    If YourLoadCapacitorLoadResuscitationFlag Then
                        'بازگردانی بار
                        CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set nCarNum=nCarNum+1 Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.LoadPermissionCancelling, 1, Nothing, Nothing, Nothing, Nothing))
                    Else
                        'عدم بازگردانی بار و کنسلی کل بار باقیمانده
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadCancelling(YournEstelamId)
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.LoadPermissionCancelling, 1, Nothing, Nothing, Nothing, Nothing))
                        R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Cancelling, NSSLoadCapacitorLoad.nCarNum + 1, Nothing, Nothing, Nothing, Nothing))
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

            Private Shared Sub LoadCapacitorLoadAllocating_(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
                Try
                    'کنترل وضعیت بار
                    If YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled Or YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted Or YourNSSLoadCapacitorLoad.LoadStatus = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented Then Throw New LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(YourNSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Allocating, 1, Nothing, Nothing, Nothing, Nothing))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadAllocating(YournEstelamId As Int64)
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    LoadCapacitorLoadAllocating_(NSSLoadCapacitorLoad)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadAllocating(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
                Try
                    LoadCapacitorLoadAllocating_(YourNSSLoadCapacitorLoad)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadAllocationCancelling(YournEstelamId As Int64)
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    'کنترل وضعیت بار - نیازی نیست
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.AllocationCancelling, 1, Nothing, Nothing, Nothing, Nothing))
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Sub LoadCapacitorLoadSedimenting(YournEstelamId As Int64)
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                    Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                    'رسوب بار
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select nEstelamId from DBTransport.dbo.TbElam  with (tablockx) Where nEstelamId=" & YournEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Update DBTransport.dbo.TbElam Set LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " Where nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ""
                    CmdSql.ExecuteNonQuery()
                    'ثبت اکانت
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Sedimenting, NSSLoadCapacitorLoad.nCarNum, Nothing, Nothing, Nothing, Nothing))
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

    Namespace Exceptions
        Public Class LoadCapacitorLoadStatusException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت بار با کدشاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadNumberOverLimitException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تعداد بار بیش از حد مجاز است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadnCarNumKolCanNotBeZeroException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مقدار صفر برای تعداد بار مجاز نیست"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadRegisterTimePassedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان ثبت بار به پایان رسیده است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadEditTimePassedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان ویرایش اطلاعات بار به پایان رسیده است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadDeleteTimePassedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان حذف بار به پایان رسیده است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadCancelTimeNotReachedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان کنسلی بار فقط پس از اعلام بار امکان پذیر است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadReleaseTimeNotReachedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان ترخیص بار فقط پس از اعلام بار امکان پذیر است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadFreeLiningTimePassedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان خط آزاد نمودن بار فقط قبل از اعلام بار امکان پذیر است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت فعلی بار مانع از اجرای این فرآیند است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تعداد باقیمانده بار به صفر رسیده است و امکان ترخیص بار وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "بار با کدمخزن بار مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorAccountingTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع اکانت مخزن بار با کد مورد نظر یافت نشد"
                End Get
            End Property
        End Class

    End Namespace




End Namespace

Namespace AnnouncementHalls

    Public MustInherit Class AnnouncementHalls
        Public Shared ReadOnly Property None = 0
        Public Shared ReadOnly Property General = 1
        Public Shared ReadOnly Property Zobi = 2
        Public Shared ReadOnly Property Anbari = 3
        Public Shared ReadOnly Property Otaghdar = 4
        Public Shared ReadOnly Property Shahri = 5
    End Class

    Public MustInherit Class AnnouncementHallSubGroups
        Public Shared ReadOnly Property None = 0
        Public Shared ReadOnly Property Khavar = 1
        Public Shared ReadOnly Property Otaghdar6 = 2
        Public Shared ReadOnly Property Otaghdar10 = 3
        Public Shared ReadOnly Property Anbari = 4
        Public Shared ReadOnly Property AnbariShemsh = 5
        Public Shared ReadOnly Property AnbariSaderati = 6
        Public Shared ReadOnly Property Zobi = 7
        Public Shared ReadOnly Property ZobiShemsh = 8
        Public Shared ReadOnly Property ZobiSaderati = 9
        Public Shared ReadOnly Property AnbarRol = 10
        Public Shared ReadOnly Property ZobiRol = 11
        Public Shared ReadOnly Property Shahri = 12
        Public Shared ReadOnly Property ShahriRol = 13

    End Class

    Public MustInherit Class AnnouncementHallAnnounceTimeTypes
        Public Shared ReadOnly Property None = 0
        Public Shared ReadOnly Property LastAnnounceLoads = 1
        Public Shared ReadOnly Property UnAnnounceLoads = 2
        Public Shared ReadOnly Property SedimentedLoads = 3
        Public Shared ReadOnly Property AllOfLoadsWithoutSedimentedLoads = 4

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure

        Public Sub New()
            MyBase.New()
            _AHId = 0
            _AHTitle = String.Empty
            _AHColor = String.Empty
            _ViewFlag = False
            _Active = False
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourAHId As Int64, YourAHTitle As String, YourAHColor As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            _AHId = YourAHId
            _AHTitle = YourAHTitle
            _AHColor = YourAHColor
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub


        Public Property AHId As Int64
        Public Property AHTitle As String
        Public Property AHColor As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure

        Public Sub New()
            MyBase.New()
            _AHSGId = 0
            _AHSGTitle = String.Empty
            _ViewFlag = False
            _Active = False
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourAHSGId As Int64, YourAHSGTitle As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            _AHSGId = YourAHSGId
            _AHSGTitle = YourAHSGTitle
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub


        Public Property AHSGId As Int64
        Public Property AHSGTitle As String
        Public Property ViewFlag() As Boolean
        Public Property Active() As Boolean
        Public Property Deleted() As Boolean

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _AHATTypeId = Int64.MinValue
            _AHATTypeTitle = String.Empty
            _AHATTypeColor = String.Empty
            _Deleted = False
        End Sub

        Public Sub New(ByVal YourAHATTypeId As Int64, YourAHATTypeTitle As String, YourAHATTypeColor As String, YourDeleted As Boolean)
            _AHATTypeId = YourAHATTypeId
            _AHATTypeTitle = YourAHATTypeTitle
            _AHATTypeColor = YourAHATTypeColor
            _Deleted = YourDeleted
        End Sub


        Public Property AHATTypeId As Int64
        Public Property AHATTypeTitle As String
        Public Property AHATTypeColor As String
        Public Property Deleted As Boolean

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnouncementHallSubGroupJOINTStructure

        Public Sub New()
            MyBase.New()
            _NSSAnnounementHall = Nothing
            _NSSAnnouncementHallSubGroup = Nothing
        End Sub

        Public Sub New(ByVal YourNSSAnnounementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, YourNSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            _NSSAnnounementHall = YourNSSAnnounementHall
            _NSSAnnouncementHallSubGroup = YourNSSAnnouncementHallSubGroup
        End Sub

        Public Property NSSAnnounementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
        Public Property NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure

    End Class

    Public MustInherit Class R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetAnnouncementHallsAnnouncementHallSubGroupsJOINT() As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnouncementHallSubGroupJOINTStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                 Select AHs.AHId,AHSGs.AHSGId from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AHs
                    Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHs.AHId=AHRAHSG.AHId 
                    Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSGs On AHRAHSG.AHSGId=AHSGs.AHSGId 
                 Where AHs.Deleted=0 and AHs.ViewFlag=1 and AHRAHSG.RelationActive=1 and AHSGs.Deleted=0 and AHSGs.ViewFlag=1
                 Order By AHs.AHId,AHSGs.AHSGId", 3600, DS)

                Dim Lst = New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnouncementHallSubGroupJOINTStructure)
                For Loopx As Int32 = 0 To DS.Tables(0).Rows.Count - 1
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnouncementHallSubGroupJOINTStructure
                    NSS.NSSAnnounementHall = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(DS.Tables(0).Rows(Loopx).Item("AHId"))
                    NSS.NSSAnnouncementHallSubGroup = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroup(DS.Tables(0).Rows(Loopx).Item("AHSGId"))
                    Lst.Add(NSS)
                Next
                Return Lst

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHall(YourAHId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls Where AHId=" & YourAHId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure(DS.Tables(0).Rows(0).Item("AHId"), DS.Tables(0).Rows(0).Item("AHTitle").trim, DS.Tables(0).Rows(0).Item("AHColor").trim, DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As AnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallByAnnouncementHallSubGroup(YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                             "Select Top 1 AH.AHId,AH.AHTitle,AH.AHColor,AH.Active,AH.Deleted,AH.ViewFlag from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH 
                                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AH.AHId=AHRAHSG.AHId
                                 Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHRAHSG.AHSGId=AHSG.AHSGId
                                Where AHSG.AHSGId = " & YourAHSGId & " and AHSG.Deleted=0 and AHSG.ViewFlag=1 and AHRAHSG.RelationActive=1 and AH.Deleted=0 and AH.ViewFlag=1", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure(DS.Tables(0).Rows(0).Item("AHId"), DS.Tables(0).Rows(0).Item("AHTitle").trim, DS.Tables(0).Rows(0).Item("AHColor").trim, DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As AnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallSubGroup(YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups Where AHSGId=" & YourAHSGId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallSubGroupNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure(DS.Tables(0).Rows(0).Item("AHSGId"), DS.Tables(0).Rows(0).Item("AHSGTitle"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As AnnouncementHallSubGroupNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallAnnounceTimeType(YourAHATTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallAnnounceTimeTypes Where AHATTypeId=" & YourAHATTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New AnnouncementHallAnnounceTimeTypeNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure(DS.Tables(0).Rows(0).Item("AHATTypeId"), DS.Tables(0).Rows(0).Item("AHATTypeTitle"), DS.Tables(0).Rows(0).Item("AHATTypeColor"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch exx As AnnouncementHallAnnounceTimeTypeNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallByLoaderTypeId(YourLoaderTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                           Select Top 1 AH.AHId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LT 
                            inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRLT On LT.LoaderTypeId=AHSGRLT.LoaderTypeId
                            inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRLT.AHSGId=AHSG.AHSGId
                            inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                            inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                           Where LT.Deleted=0 and AHSGRLT.RelationActive=1 and AHSG.Deleted=0 and AHRAHSG.RelationActive=1 and AH.Deleted=0 and LT.LoaderTypeId=" & YourLoaderTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New LoaderTypeRelationAnnouncementHallNotFoundException
                Return GetNSSAnnouncementHall(DS.Tables(0).Rows(0).Item("AHId"))
            Catch exx As LoaderTypeRelationAnnouncementHallNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSAnnouncementHallSubGroupByLoaderTypeId(YourLoaderTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                              Select Top 1 AHSG.AHSGId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LT 
                                 inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroupsRelationLoaderTypes as AHSGRLT On LT.LoaderTypeId=AHSGRLT.LoaderTypeId
                                 inner join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHSGRLT.AHSGId=AHSG.AHSGId
                              Where LT.Deleted=0 and AHSGRLT.RelationActive=1 and AHSG.Deleted=0 and LT.LoaderTypeId=" & YourLoaderTypeId & "", 3600, DS).GetRecordsCount() = 0 Then Throw New LoaderTypeRelationAnnouncementHallSubGroupNotFoundException
                Return GetNSSAnnouncementHallSubGroup(DS.Tables(0).Rows(0).Item("AHSGId"))
            Catch exx As LoaderTypeRelationAnnouncementHallSubGroupNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallfromLoadCapacitorLoad(YourNSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
            Try
                Return GetNSSAnnouncementHallByLoaderTypeId(YourNSSLoadCapacitorLoad.nTruckType)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallLeastAnnounceTime(YourAHId As Int64, YourAHSGId As Int64) As R2StandardDateAndTimeStructure
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllAnnounceTimesofAnnouncementHall As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallAnnounceTime, YourAHId), ";")
                Dim AllAnnounceTimesofAnnouncementHallSubGroup = Split(Mid(AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "-")
                Return New R2StandardDateAndTimeStructure(Nothing, Nothing, AllAnnounceTimesofAnnouncementHallSubGroup(AllAnnounceTimesofAnnouncementHallSubGroup.Count - 1))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallFirstAnnounceTime(YourAHId As Int64, YourAHSGId As Int64) As R2StandardDateAndTimeStructure
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllAnnounceTimesofAnnouncementHall As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallAnnounceTime, YourAHId), ";")
                Dim AllAnnounceTimesofAnnouncementHallSubGroup = Split(Mid(AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "-")
                Return New R2StandardDateAndTimeStructure(Nothing, Nothing, AllAnnounceTimesofAnnouncementHallSubGroup(0))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallAnnounceTimes(YourAHId As Int64, YourAHSGId As Int64) As List(Of String)
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllAnnounceTimesofAnnouncementHall As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallAnnounceTime, YourAHId), ";")
                Dim AllAnnounceTimesofAnnouncementHallSubGroup = Split(Mid(AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnounceTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "-")
                Return AllAnnounceTimesofAnnouncementHallSubGroup.ToList
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallAnnounceTimes(YourAHId As Int64) As List(Of String)
            Try
                Dim AllAnnounceTimesofAnnouncementHall As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallAnnounceTime, YourAHId), ";")
                Return AllAnnounceTimesofAnnouncementHall.ToList
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsAnnouncemenetHallAnnounceTimePassed(YourAHId As Int64, YourAHSGId As Int64, YourDateTime As R2StandardDateAndTimeStructure) As Boolean
            Try
                Dim CurrentTime As String = _DateTime.GetCurrentTime()
                Dim AnnounceTimes As List(Of String) = GetAnnouncementHallAnnounceTimes(YourAHId, YourAHSGId)
                If YourDateTime.Time < AnnounceTimes(0) Then If CurrentTime < AnnounceTimes(0) Then Return False Else Return True
                For Loopx As Int64 = 0 To AnnounceTimes.Count - 1
                    If Loopx < AnnounceTimes.Count - 1 Then
                        If YourDateTime.Time >= AnnounceTimes(Loopx) And YourDateTime.Time < AnnounceTimes(Loopx + 1) Then
                            If CurrentTime < AnnounceTimes(Loopx + 1) Then Return False Else Return True
                        End If
                    End If
                Next
                Return True
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncemenetHallLastAnnounceTime(YourAHId As Int64, YourAHSGId As Int64) As R2StandardDateAndTimeStructure
            Try
                Dim CurrentTime As String = _DateTime.GetCurrentTime()
                Dim AnnounceTimes As List(Of String) = GetAnnouncementHallAnnounceTimes(YourAHId, YourAHSGId)
                If CurrentTime < AnnounceTimes(0) Then Return New R2StandardDateAndTimeStructure(Nothing, Nothing, "00:00:00")
                If CurrentTime >= AnnounceTimes(AnnounceTimes.Count - 1) Then Return New R2StandardDateAndTimeStructure(Nothing, Nothing, AnnounceTimes(AnnounceTimes.Count - 1))
                For Loopx As Int64 = 0 To AnnounceTimes.Count - 1
                    If Loopx < AnnounceTimes.Count - 1 Then
                        If CurrentTime >= AnnounceTimes(Loopx) And CurrentTime < AnnounceTimes(Loopx + 1) Then Return New R2StandardDateAndTimeStructure(Nothing, Nothing, AnnounceTimes(Loopx))
                    Else
                        Throw New Exception("تنظیمات زمان اعلام بار را در پیکربندی سیستم کنترل نمایید")
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHalls() As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                 "Select AH.AHId,AH.AHTitle,AH.AHColor,AH.Active,AH.Deleted,AH.ViewFlag from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH 
                                  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationComputers as AHRComp On AH.AHId=AHRComp.AHId
                                    Where AHRComp.ComId=" & R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId & " and AHRComp.RelationActive=1 and AH.Deleted=0 and ah.ViewFlag=1 ", 3600, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure(DS.Tables(0).Rows(Loopx).Item("AHId"), DS.Tables(0).Rows(Loopx).Item("AHTitle").trim, DS.Tables(0).Rows(Loopx).Item("AHColor").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallSubGroups(YourAHId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                  "Select AHSG.AHSGId,AHSG.AHSGTitle,AHSG.Active,AHSG.Deleted,AHSG.ViewFlag from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH 
                                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AH.AHId=AHRAHSG.AHId
                                     Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On AHRAHSG.AHSGId=AHSG.AHSGId
                                   Where AH.AHId = " & YourAHId & " and AHSG.Deleted=0 and AHSG.ViewFlag=1 and AHRAHSG.RelationActive=1 and AH.Deleted=0 and AH.ViewFlag=1", 3600, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure(DS.Tables(0).Rows(Loopx).Item("AHSGId"), DS.Tables(0).Rows(Loopx).Item("AHSGTitle").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag"), DS.Tables(0).Rows(Loopx).Item("Active"), DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetAnnouncementHallAnnounceTimeTypes() As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                           "Select AHATType.AHATTypeId,AHATType.AHATTypeTitle,AHATType.AHATTypeColor,AHATType.Deleted from R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallAnnounceTimeTypes as AHATType 
                                               Where AHATType.Deleted=0 Order By AHATType.AHATTypeId", 3600, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnounceTimeTypeStructure(DS.Tables(0).Rows(Loopx).Item("AHATTypeId"), DS.Tables(0).Rows(Loopx).Item("AHATTypeTitle").trim, DS.Tables(0).Rows(Loopx).Item("AHATTypeColor").trim, DS.Tables(0).Rows(Loopx).Item("Deleted")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsActiveTurnRegisteringIssueControlforAnnouncementHall(YourAHId As Int64, YourAHSGId As Int64) As Boolean
            Try
                Dim IssueControl As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTurnRegisteringSetting, YourAHId, 0), "-")
                Return Split(IssueControl.Where(Function(x) YourAHSGId = Split(x, ":")(0))(0), ":")(1) = "1"
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exceptions
        Public Class LoaderTypeRelationAnnouncementHallNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع بارگیر با هیچ یک از سالن های اعلام بار مرتبط نیست"
                End Get
            End Property
        End Class

        Public Class LoaderTypeRelationAnnouncementHallSubGroupNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع بارگیر با هیچ یک از زیرگروه های سالن های اعلام بار مرتبط نیست"
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

        Public Class AnnouncementHallAnnounceTimeTypeNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "نوع زمان اعلام بار با کدشاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class AnnouncementHallNotSelectedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "سالن اعلام بار مورد نظر انتخاب نشده است"
                End Get
            End Property
        End Class

        Public Class AnnouncementHallSubGroupUnActiveException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زیر گروه اعلام بار مورد نظر فعال نیست"
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

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTransportTarrifsManagement
        Public Shared Function GetNSSTransportTarrif(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) As R2CoreTransportationAndLoadNotificationStandardTransportTarrifStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs Where (AHId=" & YourNSS.AHId & ") and (AHSGId=" & YourNSS.AHSGId & ") and (TargetCityId=" & YourNSS.nCityCode & ") and OActive=1", 3600, DS).GetRecordsCount() = 0 Then Throw New TransportPriceTarrifNotFoundException
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

Namespace Turns
    Public MustInherit Class TurnStatuses
        Public Shared ReadOnly Property None = 0
        Public Shared ReadOnly Property Registered = 1
        Public Shared ReadOnly Property CancelledUser = 2
        Public Shared ReadOnly Property CancelledUnderScore = 3
        Public Shared ReadOnly Property CancelledSystem = 4
        Public Shared ReadOnly Property CancelledLoadPermissionCancelled = 5
        Public Shared ReadOnly Property UsedLoadPermissionRegistered = 6
        Public Shared ReadOnly Property UsedLoadAllocationRegistered = 7
        Public Shared ReadOnly Property ResuscitationLoadPermissionCancelled = 8
        Public Shared ReadOnly Property ResuscitationLoadAllocationCancelled = 9
        Public Shared ReadOnly Property ResuscitationUser = 10
        Public Shared ReadOnly Property TurnExpired = 11

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
            _OtaghdarTurnNumber = String.Empty
            _StrCardNo = Int64.MinValue
            _TurnStatus = Turns.TurnStatuses.None
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64, YourTurnStatus As Int64)
            _nEnterExitId = YournEnterExitId
            _EnterDate = YourEnterDate
            _EnterTime = YourEnterTime
            _NSSTruckDriver = YourNSSTruckDriver
            _bFlagDriver = YourbFlagDriver
            _nUserIdEnter = YournUserIdEnter
            _OtaghdarTurnNumber = YourOtaghdarTurnNumber
            _StrCardNo = YourStrCardNo
            _TurnStatus = YourTurnStatus
        End Sub

        Public Property nEnterExitId As Int64
        Public Property EnterDate As String
        Public Property EnterTime As String
        Public Property NSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure
        Public Property bFlagDriver As Boolean
        Public Property nUserIdEnter As Int64
        Public Property OtaghdarTurnNumber As String
        Public Property StrCardNo As Int64
        Public Property TurnStatus() As Int64
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
        Inherits R2CoreTransportationAndLoadNotificationStandardTurnStructure
        Public Sub New()
            MyBase.New()
            _LicensePlatePString = String.Empty
            _TurnStatusTitle = String.Empty
            _UserName = String.Empty
            _TruckDriver = String.Empty
        End Sub

        Public Sub New(ByVal YournEnterExitId As Int64, ByVal YourEnterDate As String, YourEnterTime As String, YourNSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure, YourbFlagDriver As Boolean, YournUserIdEnter As Int64, YourOtaghdarTurnNumber As String, YourStrCardNo As Int64, YourTurnStatus As Int64, YourLicensePlatePString As String, YourTurnStatusTitle As String, YourUserName As String, YourTruckDriver As String)
            MyBase.New(YournEnterExitId, YourEnterDate, YourEnterTime, YourNSSTruckDriver, YourbFlagDriver, YournUserIdEnter, YourOtaghdarTurnNumber, YourStrCardNo, YourTurnStatus)
            _LicensePlatePString = YourLicensePlatePString
            _TurnStatusTitle = YourTurnStatusTitle
            _UserName = YourUserName
            _TruckDriver = YourTruckDriver
        End Sub

        Public Property LicensePlatePString As String
        Public Property TurnStatusTitle As String
        Public Property UserName As String
        Public Property TruckDriver As String
    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnsManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function ExistActiveTurn(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNSSSeqT As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select * from dbtransport.dbo.tbEnterExit as Turns
                             Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqTs on Substring(Turns.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS=SeqTs.SeqTKeyWord Collate Arabic_CI_AI_WS
                      Where (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10) and Turns.bFlagDriver=0 and
                            SeqTs.Active=1 and SeqTs.Deleted=0 and Turns.strCardno=" & YourNSSTruck.NSSCar.nIdCar & " and SeqTs.SeqTId=" & YourNSSSeqT.SequentialTurnId & "", 0, Ds).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTurn(YourNSSMobileUser As R2CoreTransportationAndLoadNotificationStandardMobileUserStructure) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                   "Select Top 1 Users.UserName,TurnStatus.TurnStatusTitle,Persons.strPersonFullName,Cars.strCarNo+'-'+Cars.strCarSerialNo as LPString,Turns.nEnterExitId,Turns.strEnterDate,Turns.strEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.strCardno,Turns.TurnStatus
                       from dbtransport.dbo.tbEnterExit as Turns
                         Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On Turns.TurnStatus=TurnStatus.TurnStatusId
                         Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On Turns.nUserIdEnter=Users.UserId 
                         Inner Join dbtransport.dbo.TbCar as Cars On Turns.strCardno=Cars.nIDCar 
	                     Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Cars.nIDCar=CarAndPersons.nIDCar 
	                     Inner Join dbtransport.dbo.TbDriver as Drivers On CarAndPersons.nIDPerson=Drivers.nIDDriver 
	                     Inner Join dbtransport.dbo.TbPerson as Persons On Drivers.nIDDriver=Persons.nIDPerson
	                     Inner Join R2Primary.dbo.TblMobileUsers as MobileUsers On Persons.strIDNO Collate Arabic_CI_AI_WS=MobileUsers.MUMobileNumber Collate Arabic_CI_AI_WS
                       Where  (Turns.TurnStatus=1 or Turns.TurnStatus=7 or Turns.TurnStatus=8 or Turns.TurnStatus=9 or Turns.TurnStatus=10) and Cars.ViewFlag=1 
                              and CarAndPersons.snRelation=2 and MobileUsers.MUId=" & YourNSSMobileUser.MUId & " and MobileUsers.Active=1 and MobileUsers.Deleted=0 Order By Turns.nEnterExitId Desc", 0, Ds).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
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
                Return NSS
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTurns(YourNSSMobileUser As R2CoreTransportationAndLoadNotificationStandardMobileUserStructure) As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                   "Select Top 5 Turns.nEnterExitId,Turns.StrEnterDate,Turns.StrEnterTime,Turns.nDriverCode,Turns.bFlagDriver,Turns.nUserIdEnter,Turns.OtaghdarTurnNumber,Turns.StrCardNo,
                      Turns.TurnStatus,Cars.strCarNo +'-'+ Cars.strCarSerialNo as LPString,Persons.strPersonFullName,TurnStatuses.TurnStatusTitle,SoftwareUsers.UserName as Username from R2Primary.dbo.TblMobileUsers as MobileUsers
                       Inner Join dbtransport.dbo.TbPerson as Persons On MobileUsers.MUMobileNumber Collate Arabic_CI_AI_WS=Persons.strIDNO Collate Arabic_CI_AI_WS
	                   Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver 
                       Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Persons.nIDPerson=CarAndPersons.nIDPerson
	                   Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
	                   Inner Join dbtransport.dbo.tbCarType as CarTypes On Cars.snCarType=CarTypes.snCarType 
	                   Inner Join dbtransport.dbo.tbEnterExit as Turns On Cars.nIDCar=Turns.strCardno 
	                   Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatuses On Turns.TurnStatus=TurnStatuses.TurnStatusId 
                       Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On Turns.nUserIdEnter=SoftwareUsers.UserId 
                    Where MobileUsers.MUId=" & YourNSSMobileUser.MUId & " and CarAndPersons.snRelation=2 and Cars.ViewFlag=1 Order By Turns.nEnterExitId Desc", 0, Ds).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
                For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure
                    NSS.nEnterExitId = Ds.Tables(0).Rows(Loopx).Item("nEnterExitId")
                    NSS.EnterDate = Ds.Tables(0).Rows(Loopx).Item("StrEnterDate")
                    NSS.EnterTime = Ds.Tables(0).Rows(Loopx).Item("StrEnterTime")
                    NSS.NSSTruckDriver = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(Ds.Tables(0).Rows(Loopx).Item("nDriverCode"))
                    NSS.bFlagDriver = Ds.Tables(0).Rows(Loopx).Item("bFlagDriver")
                    NSS.nUserIdEnter = Ds.Tables(0).Rows(Loopx).Item("nUserIdEnter")
                    NSS.OtaghdarTurnNumber = Ds.Tables(0).Rows(Loopx).Item("OtaghdarTurnNumber")
                    NSS.StrCardNo = Ds.Tables(0).Rows(Loopx).Item("StrCardNo")
                    NSS.TurnStatus = Ds.Tables(0).Rows(Loopx).Item("TurnStatus")
                    NSS.LicensePlatePString = Ds.Tables(0).Rows(Loopx).Item("LPString").trim
                    NSS.TruckDriver = Ds.Tables(0).Rows(Loopx).Item("strPersonFullName").trim
                    NSS.TurnStatusTitle = Ds.Tables(0).Rows(Loopx).Item("TurnStatusTitle").trim
                    NSS.UserName = Ds.Tables(0).Rows(Loopx).Item("Username").trim
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As TurnNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTurn(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                         "Select Users.UserName,TurnStatus.TurnStatusTitle,Person.strPersonFullName,Car.strCarNo+'-'+car.strCarSerialNo as LPString, EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,EnterExit.nDriverCode,EnterExit.bFlagDriver,EnterExit.nUserIdEnter,EnterExit.OtaghdarTurnNumber,EnterExit.strCardno,EnterExit.TurnStatus
                            from dbtransport.dbo.tbEnterExit as EnterExit 
                               Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                               Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On EnterExit.TurnStatus=TurnStatus.TurnStatusId
                               Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On EnterExit.nUserIdEnter=Users.UserId Where EnterExit.nEnterExitId=" & YourTurnId & "", 0, Ds).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
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
                Return NSS
            Catch exx As TurnNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSTurn(YourSeqTId As Int64, YourTurnId As Int64, YourTargetYearFull As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            Try
                Dim CurrentSalShamsiFull As String = _DateTime.GetCurrentSalShamsiFull
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select Users.UserName,TurnStatus.TurnStatusTitle,Person.strPersonFullName,Car.strCarNo+'-'+car.strCarSerialNo as LPString, EnterExit.nEnterExitId,EnterExit.strEnterDate,EnterExit.strEnterTime,EnterExit.nDriverCode,EnterExit.bFlagDriver,EnterExit.nUserIdEnter,EnterExit.OtaghdarTurnNumber,EnterExit.strCardno,EnterExit.TurnStatus
                                from dbtransport.dbo.tbEnterExit as EnterExit 
                                  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On SUBSTRING(EnterExit.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS= SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS
                                  Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                  Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                  Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatus On EnterExit.TurnStatus=TurnStatus.TurnStatusId
                                  Inner Join R2Primary.DBO.TblSoftwareUsers AS Users On EnterExit.nUserIdEnter=Users.UserId 
                                Where SeqT.SeqTId=" & YourSeqTId & " and SUBSTRING(EnterExit.OtaghdarTurnNumber,2,4)='" & YourTargetYearFull & "' and SUBSTRING(EnterExit.OtaghdarTurnNumber,7,20)=" & YourTurnId & "", 1, Ds).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
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
                Return NSS
            Catch exx As TurnNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Sub LoadAllocationRegistering_(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'کنترل وضعیت نوبت
                If Not (YourNSSTurn.TurnStatus = TurnStatuses.Registered Or YourNSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or YourNSSTurn.TurnStatus = TurnStatuses.ResuscitationUser) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select Top 1 nEnterExitId From dbtransport.dbo.TbEnterExit with (tablockx) Where nEnterExitId=" & YourNSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.UsedLoadAllocationRegistered & " Where nEnterExitId=" & YourNSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub LoadAllocationRegistering(YourTurnId As Int64)
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                LoadAllocationRegistering_(NSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub LoadAllocationRegistering(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Try
                LoadAllocationRegistering_(YourNSSTurn)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub LoadAllocationCancelling(YourTurnId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                'کنترل وضعیت نوبت
                If Not (NSSTurn.TurnStatus = TurnStatuses.CancelledUser Or NSSTurn.TurnStatus = TurnStatuses.CancelledUnderScore Or NSSTurn.TurnStatus = TurnStatuses.CancelledSystem Or NSSTurn.TurnStatus = TurnStatuses.CancelledLoadPermissionCancelled Or NSSTurn.TurnStatus = TurnStatuses.UsedLoadPermissionRegistered Or NSSTurn.TurnStatus = TurnStatuses.UsedLoadAllocationRegistered Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadAllocationCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationLoadPermissionCancelled Or NSSTurn.TurnStatus = TurnStatuses.ResuscitationUser Or NSSTurn.TurnStatus = TurnStatuses.TurnExpired) Then Throw New TurnHandlingNotAllowedBecuaseTurnStatusException
                'تغییر وضعیت نوبت
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select Top 1 nEnterExitId From dbtransport.dbo.TbEnterExit with (tablockx) Where nEnterExitId=" & YourTurnId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationLoadAllocationCancelled & " Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Catch ex As TurnHandlingNotAllowedBecuaseTurnStatusException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

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
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.ResuscitationLoadPermissionCancelled & ",bFlag=0,bFlagDriver=0 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
                Else
                    CmdSql.CommandText = "Update dbtransport.dbo.TbEnterExit Set TurnStatus=" & TurnStatuses.CancelledLoadPermissionCancelled & ",bFlag=1,bFlagDriver=1 Where nEnterExitId=" & NSSTurn.nEnterExitId & ""
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
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 StrCardNo from dbtransport.dbo.TbEnterExit Where nEnterExitId=" & YourTurnId & "", 1, Ds).GetRecordsCount() = 0 Then
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

        Public Shared Function IsTurnReadeyforLoadAllocationRegistering(YourTurnId As Int64) As Boolean
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Return IsTurnReadeyforLoadAllocationRegistering_(NSSTurn)
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
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 TurnRegisteringActive from R2PrimaryTransportationAndLoadNotification.dbo.TblTerraficCardTypesforTurnRegistering Where TerraficCardTypeId=" & YourNSS.CardType & "", 3600, Ds)
                Return Ds.Tables(0).Rows(0).Item("TurnRegisteringActive")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsTerraficCardTypeforTurnRegistering(YourNSS As R2CoreParkingSystemStandardTrafficCardStructure) As Boolean
            Try
                Dim Ds As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 TurnRegistering from R2PrimaryTransportationAndLoadNotification.dbo.TblTerraficCardTypesforTurnRegistering Where TerraficCardTypeId=" & YourNSS.CardType & "", 3600, Ds)
                Return Ds.Tables(0).Rows(0).Item("TurnRegistering")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub TruckPresentInParkingForTurnRegisteringControl(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
            Try
                Dim NSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(YourNSSTruck.NSSCar.nIdCar))
                'بررسی شرط حضور ناوگان باری در پارکینگ هنگام صدور نوبت با توجه به پیکربندی برای هر زیرگروه اعلام بار
                Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSAnnouncementHallSubGroup(YourNSSTruck.NSSCar.nIdCar)
                Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallByAnnouncementHallSubGroup(NSSAnnouncementHallSubGroup.AHSGId)
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.IsActiveTurnRegisteringIssueControlforAnnouncementHall(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId) Then
                    If R2CoreParkingSystem.EnterExitManagement.R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(NSSTerraficCard, Nothing) = R2EnterExitRequestType.EnterRequest Then Throw New CarIsNotPresentInParkingException
                End If
            Catch ex As CarIsNotPresentInParkingException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub



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

        Public Class R2CoreTransportationAndLoadNotificationMClassTurnPrintingManagement

            Private Shared WithEvents _PrintDocumentNobat As PrintDocument = New PrintDocument()
            Private Shared TurnPrintingInf As R2CoreTransportationAndLoadNotificationTurnPrintingInf

            Private Shared Function GetTurnPrintingInf(YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationTurnPrintingInf
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
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
                       Where EnterExit.nEnterExitId=" & YourTurnId & " and RFIDCardRCar.RelationActive=1 and AHRAHSG.RelationActive=1 and AHSGRCar.RelationActive=1", 1, DS).GetRecordsCount() = 0 Then Throw New TurnPrintingInfNotFoundException
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

            Public Shared Sub TurnPrint(YourTurnId As Int64)
                Try
                    TurnPrintingInf = GetTurnPrintingInf(YourTurnId)
                    'چاپ قبض نوبت
                    _PrintDocumentNobat.Print()
                Catch ex As TurnPrintingInfNotFoundException
                    Throw ex
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentNobat_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentNobat.BeginPrint
            End Sub

            Private Shared Sub _PrintDocumentNobat_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentNobat.EndPrint
            End Sub

            Private Shared Sub _PrintDocumentNobat_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
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

            Private Shared Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentNobat.PrintPage
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
                    If Not YourTurnPrintRedirect Then
                        R2CoreTransportationAndLoadNotificationMClassTurnPrintingManagement.TurnPrint(YourTurnId)
                    Else
                        Dim DataStruct As DataStruct = New DataStruct()
                        DataStruct.Data1 = YourTurnId
                        Dim NSSTruck = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourTurnId)
                        R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, NSSTruck.NSSCar.GetCarPelakSerialComposit(), R2CoreTransportationAndLoadNotificationComputerMessageTypes.TurnPrint, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
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
                _Acitve = Boolean.FalseString
                _ViewFlag = Boolean.FalseString
                _Deleted = Boolean.FalseString
            End Sub

            Public Sub New(ByVal YourTRRTypeId As Int64, ByVal YourTRRTypeName As String, YourTRRTypeTitle As String, YourTRRTypeColor As Color, YourAcitve As Boolean, YourViewFlag As Boolean, YourDeleted As Boolean)
                _TRRTypeId = YourTRRTypeId
                _TRRTypeName = YourTRRTypeName
                _TRRTypeTitle = YourTRRTypeTitle
                _TRRTypeColor = YourTRRTypeColor
                _Acitve = YourAcitve
                _ViewFlag = YourViewFlag
                _Deleted = YourDeleted
            End Sub

            Public Property TRRTypeId As Int64
            Public Property TRRTypeName As String
            Public Property TRRTypeTitle As String
            Public Property TRRTypeColor As Color
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

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManagement
            Private Shared _DateTime As New R2DateTime
            Private Shared _R2PrimaryFSWS As R2Core.R2PrimaryFileSharingWS.R2PrimaryFileSharingWebService = New R2PrimaryFileSharingWebService()


            Public Shared Function GetNSSTurnRegisterRequestType(YourTurnRegisterRequestTypeId As Int64) As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequestTypes as TRRTypes Where TRRTypes.TRRTypeId=" & YourTurnRegisterRequestTypeId & "", 3600, Ds).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestTypeNotFoundException
                    Dim NSS = New R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestTypeStructure
                    NSS.TRRTypeId = Ds.Tables(0).Rows(0).Item("TRRTypeId")
                    NSS.TRRTypeName = Ds.Tables(0).Rows(0).Item("TRRTypeName").trim
                    NSS.TRRTypeTitle = Ds.Tables(0).Rows(0).Item("TRRTypeTitle").trim
                    NSS.TRRTypeColor = Color.FromName(Ds.Tables(0).Rows(0).Item("TRRTypeColor").trim)
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
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests as TRRs Where TRRs.TRRId=" & YourTurnRegisterRequestId & "", 1, Ds).GetRecordsCount() = 0 Then Throw New TurnRegisterRequestNotFoundException
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

            Private Shared Sub SaveTurnRegisterRequestAttachement(YourAttachement As R2CoreImage, YourTRRId As Int64)
                Try
                    Dim FileInf = New R2CoreFile(YourTRRId.ToString() + R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.JPGBitmap, 2))
                    _R2PrimaryFSWS.WebMethodSaveFile(FileShareRawGroupsManagement.R2CoreTransportationAndLoadNotificationRawGroups.TurnRegisterRequestAttachements, FileInf.FileName, YourAttachement.GetImageByte())
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Public Shared Function TurnRegisterRequestRegistering(YourNSSTRR As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure, YourAttachement As R2CoreImage) As Int64
                Dim CmdSql As New SqlCommand
                CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
                Try
                    'تراکنش ثبت درخواست صدور نوبت
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                    CmdSql.CommandText = "Select Top 1 TRRId From R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests With (tablockx) Order By TRRId Desc"
                    CmdSql.ExecuteNonQuery()
                    Dim TRRIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                    CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTurnRegisterRequests(TRRId,TRRTypeId,TruckId,Description,UserId,ComputerId,DateTimeMilladi,DateShamsi) Values(" & TRRIdNew & "," & YourNSSTRR.TRRTypeId & "," & YourNSSTRR.TruckId & ",'" & YourNSSTRR.Description & "'," & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & "," & R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "')"
                    CmdSql.ExecuteNonQuery()
                    If YourAttachement IsNot Nothing Then SaveTurnRegisterRequestAttachement(YourAttachement, TRRIdNew)
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
            Public Shared ReadOnly Property None = 0
            Public Shared ReadOnly Property SequentialTurnOtaghdar = 1
            Public Shared ReadOnly Property SequentialTurnZobi = 2
            Public Shared ReadOnly Property SequentialTurnShahri = 3
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

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement
            Public Shared Function GetNSSSequentialTurn(YourSeqTId As Int64) As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
                Try
                    Dim DS As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from R2PrimaryTransportationAndLoadNotification.DBO.TblSequentialTurns Where SeqTId=" & YourSeqTId & "", 1, DS).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
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
                          Where AHRSeqTs.RelationActive=1 and AHs.AHId=" & YourNSSAnnouncementHall.AHId & "", 1, DS).GetRecordsCount() = 0 Then Throw New GetDataException
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
                        Order By AHSGRCar.Priority Asc", 1, DS).GetRecordsCount() = 0 Then Throw New SequentialTurnNotFoundException
                    Return New R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure(DS.Tables(0).Rows(0).Item("SeqTId"), DS.Tables(0).Rows(0).Item("SeqTTitle").trim, DS.Tables(0).Rows(0).Item("SeqTColor").trim, DS.Tables(0).Rows(0).Item("SeqTKeyWord").trim, DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Deleted"))
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
                          Where AHRComp.RelationActive=1 and AH.Deleted=0 and AHRSeqT.RelationActive=1 and SeqT.Deleted=0 and SeqT.ViewFlag=1 and Comp.MId=" & YourNSSComputer.MId & "", 3600, DS)
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
                                     Where EnterExit.nEnterExitId=" & YourNSSTurn.nEnterExitId & "", 1, DS).GetRecordsCount() = 0 Then Throw New TurnNotFoundException
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

            Public Class SequentialTurnIsNotActiveException
                Inherits ApplicationException
                Public Overrides ReadOnly Property Message As String
                    Get
                        Return "تسلسل نوبت برای ناوگان مورد نظر غیرفعال است"
                    End Get
                End Property
            End Class

        End Namespace

    End Namespace

    Namespace TurnRegisteringCostTariffs


    End Namespace

    Namespace TurnExpiration
        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassTurnExpirationManagement
            Private Shared _DateTime As New R2DateTime

            Public Shared Sub TurnsExpiration()
                Try
                    Dim Ds As DataSet
                    If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select Turns.nEnterExitId,TRRequests.TRRId from dbtransport.dbo.tbEnterExit as Turns
                         Inner Join R2Primary.dbo.TblEntityRelations as EntityRelations On Turns.nEnterExitId=EntityRelations.E1
                         Inner Join R2PrimaryTransportationAndLoadNotification.DBO.TblTurnRegisterRequests AS TRRequests ON EntityRelations.E2=TRRequests.TRRId
                       Where (TurnStatus=1 or TurnStatus=8 or TurnStatus=9 or TurnStatus=10) and EntityRelations.RelationActive=1", 1, Ds).GetRecordsCount = 0 Then Return

                    For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                        Try
                            Dim NSSTurn = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(Ds.Tables(0).Rows(Loopx).Item("nEnterExitId"))
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

    End Namespace

End Namespace

Namespace TurnAttendance
    Public MustInherit Class R2CoreTransportationAndLoadNotificationMClassTurnAttendanceManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetTotalNumberOfPresentRegistered(YourTurnId As Int64) As Int64
            Try
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Dim DS As DataSet
                Return R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) AS M From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") And (DateShamsi<>'" & NSSTurn.EnterDate & "') GROUP BY DateShamsi", 1, DS).GetRecordsCount()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsPresentRegisteredInLast30Minute(YourNSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, ByVal YourTurnId As UInt64) As Boolean
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 DateTimeMilladi From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "') Order By DateTimeMilladi Desc", 1, Ds).GetRecordsCount() = 0 Then
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
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * From R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent Where (NobatId=" & YourTurnId & ") and (DateShamsi='" & _DateTime.GetCurrentDateShamsiFull & "')", 1, DS).GetRecordsCount() = 0 Then
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
                If R2CoreTransportationAndLoadNotificationMClassIndigenousTrucksManagement.IsIndigenousTruck(NSSTruck) Then
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

Namespace LoadPermission

    Public Enum R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation
        None = 0
        TransportCompany = 1
        AnnouncementHall = 2
    End Enum

    Public MustInherit Class R2CoreTransportationAndLoadNotificationLoadPermissionStatuses
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Registered As Int64 = 1
        Public Shared ReadOnly Property Cancelled As Int64 = 2
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure

        Public Sub New()
            _LoadPermissionStatusId = Int64.MinValue
            _LoadPermissionStatusTitle = String.Empty
            _LoadPermissionStatusColor = String.Empty
        End Sub

        Public Sub New(ByVal YourLoadPermissionStatusId As Int64, YourLoadPermissionStatusTitle As String, YourLoadPermissionStatusColor As String)
            _LoadPermissionStatusId = YourLoadPermissionStatusId
            _LoadPermissionStatusTitle = YourLoadPermissionStatusTitle
            _LoadPermissionStatusColor = YourLoadPermissionStatusColor
        End Sub

        Public Property LoadPermissionStatusId As Int64
        Public Property LoadPermissionStatusTitle As String
        Public Property LoadPermissionStatusColor As String
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure
        Public Sub New()
            MyBase.New()
            _nEstelamId = Long.MinValue
            _TurnId = Long.MinValue
            _LoadPermissionDate = String.Empty
            _LoadPermissionTime = String.Empty
            _LoadPermissionRegisteringLocation = String.Empty
            _UserId = Long.MinValue
            _LoadPermissionStatusId = Long.MinValue
        End Sub

        Public Sub New(ByVal YournEstelamId As Int64, ByVal YourTurnId As Int64, YourLoadPermissionDate As String, YourLoadPermissionTime As String, YourLoadPermissionRegisteringLocation As String, YourUserId As Int64, YourLoadPermissionStatusid As Int64)
            _nEstelamId = YournEstelamId
            _TurnId = YourTurnId
            _LoadPermissionDate = YourLoadPermissionDate
            _LoadPermissionTime = YourLoadPermissionTime
            _LoadPermissionRegisteringLocation = YourLoadPermissionRegisteringLocation
            _UserId = YourUserId
            _LoadPermissionStatusId = YourLoadPermissionStatusid
        End Sub

        Public Property nEstelamId As Int64
        Public Property TurnId As Int64
        Public Property LoadPermissionDate As String
        Public Property LoadPermissionTime As String
        Public Property LoadPermissionRegisteringLocation As String
        Public Property UserId As Int64
        Public Property LoadPermissionStatusId As Int64

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure
        Inherits R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure

        Public Sub New()
            MyBase.New()
            _TransportCompanyTitle = String.Empty
            _GoodTitle = String.Empty
            _LoadTargetTitle = String.Empty
            _StrDescription = String.Empty
            _Truck = String.Empty
            _TruckDriver = String.Empty
            _LoadPermissionStatusTitle = String.Empty
        End Sub

        Public Sub New(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure, ByVal YourTransportCompanyTitle As String, ByVal YourGoodTitle As String, YourLoadTargetTitle As String, YourStrDescription As String, YourTruck As String, YourTruckDriver As String, YourLoadPermissionStatusTitle As String)
            MyBase.New(YourNSS.nEstelamId, YourNSS.TurnId, YourNSS.LoadPermissionDate, YourNSS.LoadPermissionTime, YourNSS.LoadPermissionRegisteringLocation, YourNSS.UserId, YourNSS.LoadPermissionStatusId)
            _TransportCompanyTitle = YourTransportCompanyTitle
            _GoodTitle = YourGoodTitle
            _LoadTargetTitle = YourLoadTargetTitle
            _StrDescription = YourStrDescription
            _Truck = YourTruck
            _TruckDriver = YourTruckDriver
            _LoadPermissionStatusTitle = YourLoadPermissionStatusTitle
        End Sub

        Public Property TransportCompanyTitle As String
        Public Property GoodTitle As String
        Public Property LoadTargetTitle As String
        Public Property StrDescription As String
        Public Property Truck As String
        Public Property TruckDriver As String
        Public Property LoadPermissionStatusTitle As String

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetNSSLoadPermission(YournEstelamId As Int64, YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                            "Select EnterExit.nEstelamID,EnterExit.nEnterExitId,EnterExit.strExitDate,EnterExit.strExitTime,EnterExit.strBarnameNo,EnterExit.nUserIdExit,EnterExit.LoadPermissionStatus,
                                    TransportCompany.TCTitle,Product.strGoodName,City.strCityName,Elam.strDescription,Car.strCarNo+'-'+strCarSerialNo as Truck,Person.strPersonFullName,LoadPermissionStatus.LoadPermissionStatusTitle from dbtransport.dbo.tbEnterExit as EnterExit 
                                           Inner Join dbtransport.dbo.tbElam as Elam On EnterExit.nEstelamID=Elam.nEstelamID
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompany On Elam.nCompCode=TransportCompany.TCId
                                           Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode
                                           Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode
                                           Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                           Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses as LoadPermissionStatus On EnterExit.LoadPermissionStatus=LoadPermissionStatus.LoadPermissionStatusId
                             Where EnterExit.nEnterExitId=" & YourTurnId & " and EnterExit.nEstelamID=" & YournEstelamId & "", 1, DS).GetRecordsCount() = 0 Then Throw New LoadPermisionNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure(DS.Tables(0).Rows(0).Item("nEstelamId"), DS.Tables(0).Rows(0).Item("nEnterExitId"), DS.Tables(0).Rows(0).Item("StrExitDate").trim, DS.Tables(0).Rows(0).Item("StrExitTime").trim, DS.Tables(0).Rows(0).Item("strBarnameNo"), DS.Tables(0).Rows(0).Item("nUserIdExit"), DS.Tables(0).Rows(0).Item("LoadPermissionStatus")), DS.Tables(0).Rows(0).Item("TCTitle").trim, DS.Tables(0).Rows(0).Item("strGoodName").trim, DS.Tables(0).Rows(0).Item("strCityName").trim, DS.Tables(0).Rows(0).Item("strDescription").trim, DS.Tables(0).Rows(0).Item("Truck").trim, DS.Tables(0).Rows(0).Item("strPersonFullName").trim, DS.Tables(0).Rows(0).Item("LoadPermissionStatusTitle").trim)
            Catch exx As LoadPermisionNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoadPermissionStatus(YourLoadPermissionStatusId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure
            Try
                Dim DS As DataSet = Nothing
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses Where LoadPermissionStatusId=" & YourLoadPermissionStatusId & "", 3600, DS).GetRecordsCount = 0 Then Throw New LoadPermissionStatusNotFoundException
                Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure
                NSS.LoadPermissionStatusId = YourLoadPermissionStatusId
                NSS.LoadPermissionStatusTitle = DS.Tables(0).Rows(0).Item("LoadPermissionStatustitle").TRIM
                NSS.LoadPermissionStatusColor = DS.Tables(0).Rows(0).Item("LoadPermissionStatusColor").TRIM
                Return NSS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub LoadPermissionRegistering(YourLoadAllocationId As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTruck(YourLoadAllocationId.TurnId)
                Dim NSSTruckDriver As R2CoreTransportationAndLoadNotificationStandardTruckDriverStructure = R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.GetNSSTruckDriver(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(NSSTruck.NSSCar.nIdCar))
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YourLoadAllocationId.nEstelamId)
                'کنترل لیست سیاه
                Dim BlackList As List(Of R2CoreParkingSystem.BlackList.R2StandardBlackListStructure) = R2CoreParkingSystem.BlackList.R2CoreParkingSystemMClassBlackList.GetBlackList(New R2StandardCarStructure(NSSTruck.NSSCar.nIdCar, NSSTruck.NSSCar.snCarType, NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo, NSSTruck.NSSCar.nIdCity), R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.ActiveBlackLists)
                If BlackList.Count <> 0 Then Throw New LoadPermisionRegisteringFailedBecauseBlackListException(BlackList(0).StrDesc)
                'کنترل حاضری راننده باری
                If R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsTruckDriverAttendance, NSSLoadCapacitorLoad.AHId, 0) = True Then
                    R2CoreTransportationAndLoadNotificationMClassTurnAttendanceManagement.IsAmountOfTurnPresentsEnough(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId), YourLoadAllocationId.TurnId)
                End If
                'کنترل وضعیت نوبت
                If Not R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTurnReadeyforLoadPermissionRegistering(YourLoadAllocationId.TurnId) Then Throw New LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException
                'کنترل وضعیت بار در مخزن بار
                If Not R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.IsLoadCapacitorLoadReadeyforLoadPermissionRegistering(YourLoadAllocationId.nEstelamId) Then Throw New LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException

                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                R2CoreTransportationAndLoadNotificationMClassTurnsManagement.LoadPermissionRegistering(YourLoadAllocationId.TurnId)
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.LoadCapacitorLoadReleasing(NSSLoadCapacitorLoad.nEstelamId)
                CmdSql.CommandText = "Select nEstelamId from DBTransport.dbo.TbElam  with (tablockx) Where nEstelamId=" & YourLoadAllocationId.nEstelamId & ""
                CmdSql.ExecuteScalar()
                CmdSql.CommandText = "Update DBTransport.dbo.TbEnterExit Set StrBarnameNo=" & IIf(YourLoadAllocationId.UserId = R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSSystemUser.UserId, R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany, R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall) & ",StrExitDate='" & _DateTime.GetCurrentDateShamsiFull() & "',StrExitTime='" & _DateTime.GetCurrentTime() & "',nCityCode=" & NSSLoadCapacitorLoad.nCityCode & ",nBarCode=" & NSSLoadCapacitorLoad.nBarCode & ",bEnterExit=1,nUserIdExit=" & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & ",nCompCode=" & NSSLoadCapacitorLoad.nCompCode & ",StrDriverName='" & NSSTruckDriver.NSSDriver.StrPersonFullName & "',nDriverCode=" & NSSTruckDriver.NSSDriver.nIdPerson & ",nEstelamId=" & NSSLoadCapacitorLoad.nEstelamId & ",nCarNum=" & NSSLoadCapacitorLoad.nCarNum - 1 & ",LoadPermissionStatus=" & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.Registered & " Where nEnterExitId=" & YourLoadAllocationId.TurnId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                'ارسال تاییدیه صدور مجوز به آنلاین
                TWSClassLibrary.TDBClientManagement.TWSClassTDBClientManagement.Sodoor(NSSTruck.NSSCar.StrCarNo, NSSTruck.NSSCar.StrCarSerialNo, R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetNSSLoadTarget(NSSLoadCapacitorLoad.nCityCode).TargetTravelLength)

            Catch ex As Exception When TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException OrElse TypeOf ex Is PresentNotRegisteredInLast30MinuteException OrElse TypeOf ex Is PresentsNotEnoughException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseBlackListException OrElse TypeOf ex Is LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException OrElse TypeOf ex Is LoadCapacitorLoadReleaseTimeNotReachedException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException
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

        Public Shared Sub LoadPermissionCancelling(YournEstelamId As Int64, YourTurnId As Int64, YourTurnResuscitationFlag As Boolean, YourLoadCapacitorLoadResuscitationFlag As Boolean)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSLoadPermission As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure = GetNSSLoadPermission(YournEstelamId, YourTurnId)
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(NSSLoadPermission.nEstelamId, NSSLoadPermission.TurnId)
                'کنترل وضعیت مجوز
                If Not NSSLoadPermission.LoadPermissionStatusId = R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.Registered Then Throw New LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException
                'احیاء نوبت یا کنسلی نوبت به دلیل عدم احیاء
                R2CoreTransportationAndLoadNotificationMClassTurnsManagement.LoadPermissionCancelling(YourTurnId, YourTurnResuscitationFlag)
                R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.ChangeLoadAllocationStatus(NSSLoadAllocation.LAId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.PermissionCancelled)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set LANote='کنسلی مجوز'  Where LAId=" & NSSLoadAllocation.LAId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Update DBTransport.dbo.TbEnterExit Set LoadPermissionStatus=" & R2CoreTransportationAndLoadNotificationLoadPermissionStatuses.Cancelled & " Where nEnterExitId=" & YourTurnId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                'کنسلی مجوز بار ضمن ارسال وضعیت بازگردانی بار یا کنسلی بار
                If NSSLoadAllocation.DateShamsi < _DateTime.GetCurrentDateShamsiFull Then
                    'بار رسوب شده است و نیازی به عملیات خاصی نیست
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(NSSLoadCapacitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.LoadPermissionCancelling, 1, Nothing, Nothing, Nothing, Nothing))
                ElseIf NSSLoadAllocation.DateShamsi = _DateTime.GetCurrentDateShamsiFull Then
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.LoadCapacitorLoadPermissionCancelling(YournEstelamId, YourLoadCapacitorLoadResuscitationFlag)
                Else
                    Throw New GetDataException
                End If

            Catch exx As LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException
                Throw exx
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetLoadPermissions(YourAHId As Int64, YourAHSGId As Int64, YourLoadPermissionStatusId As Int64, YourLoadPermissionLocation As R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation, Optional YourTransportCompanyId As Int64 = Int64.MinValue) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select EnterExit.nEstelamID,EnterExit.nEnterExitId,EnterExit.strExitDate,EnterExit.strExitTime,EnterExit.strBarnameNo,EnterExit.nUserIdExit,EnterExit.LoadPermissionStatus,
                               TransportCompany.TCTitle,Product.strGoodName,City.strCityName,Elam.strDescription,Car.strCarNo+'-'+strCarSerialNo as Truck,Person.strPersonFullName,LoadPermissionStatus.LoadPermissionStatusTitle
                        from dbtransport.dbo.tbEnterExit as EnterExit 
                               Inner Join dbtransport.dbo.tbElam as Elam On EnterExit.nEstelamID=Elam.nEstelamID
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompany On Elam.nCompCode=TransportCompany.TCId
                               Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode
                               Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode
                               Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                               Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses as LoadPermissionStatus On EnterExit.LoadPermissionStatus=LoadPermissionStatus.LoadPermissionStatusId
                        Where EnterExit.strExitDate='" & _DateTime.GetCurrentDateShamsiFull() & "' and Elam.AHId=" & YourAHId & " and Elam.AHSGId=" & YourAHSGId & " and EnterExit.LoadPermissionStatus=" & YourLoadPermissionStatusId & " and EnterExit.strBarnameNo=" & YourLoadPermissionLocation & IIf(YourTransportCompanyId = Int64.MinValue, String.Empty, " and TransportCompany.TCId=" & YourTransportCompanyId & "") & " 
                        Order By EnterExit.StrExitDate Desc,EnterExit.StrExitTime Desc", 1, DS)
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure(DS.Tables(0).Rows(Loopx).Item("nEstelamID"), DS.Tables(0).Rows(Loopx).Item("nEnterExitId"), DS.Tables(0).Rows(Loopx).Item("strExitDate").trim, DS.Tables(0).Rows(Loopx).Item("strExitTime").trim, DS.Tables(0).Rows(Loopx).Item("strBarnameNo"), DS.Tables(0).Rows(Loopx).Item("nUserIdExit"), DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatus")), DS.Tables(0).Rows(Loopx).Item("TCTitle").trim, DS.Tables(0).Rows(Loopx).Item("strGoodName").trim, DS.Tables(0).Rows(Loopx).Item("strCityName").trim, DS.Tables(0).Rows(Loopx).Item("strDescription").trim, DS.Tables(0).Rows(Loopx).Item("Truck").trim, DS.Tables(0).Rows(Loopx).Item("strPersonFullName").trim, DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusTitle").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadPermissionStatuses() As List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses Order By LoadPermissionStatusId", 3600, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure(DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusId"), DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusTitle").trim, DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusColor").trim))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSFinalLoadPermission(YourAHId As Int64, YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                    "Select Top 1 LoadCapacitor.nEstelamID,Turns.nEnterExitId from dbtransport.dbo.tbElam as LoadCapacitor 
                         Inner Join dbtransport.dbo.tbEnterExit as Turns On LoadCapacitor.nEstelamID=Turns.nEstelamID 
                     Where LoadCapacitor.dDateElam='" & _DateTime.GetCurrentDateShamsiFull & "' and LoadCapacitor.AHId=" & YourAHId & " and LoadCapacitor.AHSGId=" & YourAHSGId & " and Turns.LoadPermissionStatus=1
                     Order By Turns.StrExitDate Desc,Turns.StrExitTime Desc", 1, Ds).GetRecordsCount() = 0 Then Return Nothing
                Return GetNSSLoadPermission(Ds.Tables(0).Rows(0).Item("nEstelamID"), Ds.Tables(0).Rows(0).Item("nEnterExitId"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace LoadPermissionPrinting

        Public Structure R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf
            Dim LoadAllocationId As Int64
            Dim nEstelamId As Int64
            Dim TurnId As Int64
            Dim LoadPermissionDate As String
            Dim LoadPermissionTime As String
            Dim TransportCompany As String
            Dim LoaderType As String
            Dim TruckLP As String
            Dim TruckLPSerial As String
            Dim TruckDriver As String
            Dim TruckDriverDrivingLicenseNo As String
            Dim GoodName As String
            Dim TargetCity As String
            Dim SourceCity As String
            Dim TransportPrice As String
            Dim LoadCapacitorLoadDescription As String
            Dim UserName As String
            Dim OtherNote As String
        End Structure

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement

            Private Shared WithEvents _PrintDocumentPermission As PrintDocument = New PrintDocument()
            Private Shared _PPDS As R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf

            Private Shared Function GetLoadPermissionPrintingInf(YourLoadAllocationId As Int64) As R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select LoadAllocation.LAId,LoadAllocation.nEstelamId,Cast(Substring(EnterExit.OtaghdarTurnNumber,7,20) as int) as TurnId,EnterExit.strExitDate,EnterExit.strExitTime
                                  ,TransportCompany.TCTitle,LoaderType.LoaderTypeTitle,Car.strCarNo as Truck,Car.strCarSerialNo as TruckSerial,Person.strPersonFullName
	                              ,Driver.strDrivingLicenceNo,Product.strGoodName,CityTarget.strCityName as TargetCity,CitySource.strCityName as SourceCity,Elam.strPriceSug,Elam.strDescription,Elam.StrAddress,Elam.strBarName,SoftwareUser.UserName,CityTarget.nDistance/25 as TravelLength
                           from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocation
                                Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                                Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                                Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompany On Elam.nCompCode=TransportCompany.TCId
                                Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar 
                                Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LoaderType On Car.snCarType=LoaderType.LoaderTypeId
								Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                Inner Join dbtransport.dbo.TbDriver as Driver On EnterExit.nDriverCode=Driver.nIDDriver
                                Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode
                                Inner Join dbtransport.dbo.tbCity as CityTarget On Elam.nCityCode=CityTarget.nCityCode
                                Inner Join dbtransport.dbo.tbCity as CitySource On Elam.nBarSource=CitySource.nCityCode
                                Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUser On LoadAllocation.UserId=SoftwareUser.UserId
                           Where LoadAllocation.LAId=" & YourLoadAllocationId & "", 1, DS)
                    Dim LoadPermissionPrintingInf As New R2CoreTransportationAndLoadNotificationLoadPermissionPrintingInf()
                    LoadPermissionPrintingInf.LoadAllocationId = DS.Tables(0).Rows(0).Item("LAId")
                    LoadPermissionPrintingInf.nEstelamId = DS.Tables(0).Rows(0).Item("nEstelamId")
                    LoadPermissionPrintingInf.TurnId = DS.Tables(0).Rows(0).Item("TurnId")
                    LoadPermissionPrintingInf.LoadPermissionDate = DS.Tables(0).Rows(0).Item("strExitDate").trim
                    LoadPermissionPrintingInf.LoadPermissionTime = DS.Tables(0).Rows(0).Item("strExitTime").trim
                    LoadPermissionPrintingInf.TransportCompany = DS.Tables(0).Rows(0).Item("TCTitle").trim
                    LoadPermissionPrintingInf.LoaderType = DS.Tables(0).Rows(0).Item("LoaderTypeTitle").trim
                    LoadPermissionPrintingInf.TruckLP = DS.Tables(0).Rows(0).Item("Truck").trim
                    LoadPermissionPrintingInf.TruckLPSerial = DS.Tables(0).Rows(0).Item("TruckSerial").trim
                    LoadPermissionPrintingInf.TruckDriver = DS.Tables(0).Rows(0).Item("strPersonFullName").trim
                    LoadPermissionPrintingInf.TruckDriverDrivingLicenseNo = DS.Tables(0).Rows(0).Item("strDrivingLicenceNo").trim
                    LoadPermissionPrintingInf.GoodName = DS.Tables(0).Rows(0).Item("strGoodName").trim
                    LoadPermissionPrintingInf.TargetCity = DS.Tables(0).Rows(0).Item("TargetCity").trim
                    LoadPermissionPrintingInf.SourceCity = DS.Tables(0).Rows(0).Item("SourceCity").trim
                    LoadPermissionPrintingInf.TransportPrice = DS.Tables(0).Rows(0).Item("strPriceSug").trim
                    LoadPermissionPrintingInf.LoadCapacitorLoadDescription = DS.Tables(0).Rows(0).Item("strDescription").trim & " " & DS.Tables(0).Rows(0).Item("StrAddress").trim & " " & DS.Tables(0).Rows(0).Item("StrBarName").trim
                    LoadPermissionPrintingInf.UserName = DS.Tables(0).Rows(0).Item("UserName").trim
                    LoadPermissionPrintingInf.OtherNote = DS.Tables(0).Rows(0).Item("TravelLength")
                    Return LoadPermissionPrintingInf
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub PrintLoadPermission(YourLoadAllocationId As Int64)
                Try
                    _PPDS = GetLoadPermissionPrintingInf(YourLoadAllocationId)
                    'چاپ مجوز
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId)
                    Dim ComposeSearchString As String = NSSLoadCapacitorLoad.AHSGId.ToString + "="
                    Dim AllAnnouncementHallPrinters As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 3), "-")
                    Dim AnnouncementHallSubGroupPrinter As String = Mid(AllAnnouncementHallPrinters.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnouncementHallPrinters.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length)
                    _PrintDocumentPermission.PrinterSettings.PrinterName = AnnouncementHallSubGroupPrinter.Trim
                    _PrintDocumentPermission.DefaultPageSettings.PaperSize = _PrintDocumentPermission.PrinterSettings.PaperSizes(4)
                    _PrintDocumentPermission.DefaultPageSettings.PaperSource = _PrintDocumentPermission.PrinterSettings.PaperSources(2)
                    _PrintDocumentPermission.Print()
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentPermission_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.BeginPrint
            End Sub

            Private Shared Sub _PrintDocumentPermission_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.EndPrint
            End Sub

            Private Shared Sub A4Printing(ByVal YourEventArgs As System.Drawing.Printing.PrintPageEventArgs, ByVal X As Int16, ByVal Y As Int16)
                Try
                    Dim myPaperSizeHalf As Integer = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
                    Dim myStrFontSuperMax As Font = New System.Drawing.Font("Badr", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                    'مرحله اول
                    YourEventArgs.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), X, Y, 700, 400)
                    YourEventArgs.Graphics.DrawImage(My.Resources.qrcode, X + 40, Y + 60, 120, 120)
                    YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y)
                    YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 280, Y + 50)
                    YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMax, Brushes.DarkBlue, X + 30, Y)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y)
                    YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 30)
                    YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMax, Brushes.DarkBlue, X + 30, Y + 30)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 60)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 130)
                    Dim a As Char()
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170)
                        a = _PPDS.TruckLP.ToCharArray()
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(2) + " به شماره پلاک ", myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170)
                    End If
                    YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMax, Brushes.DarkBlue, X + 400, Y + 170)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210)
                    YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 240)
                    YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 300, Y + 240)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 240)
                    YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMax, Brushes.DarkBlue, X + 450, Y + 270)
                    YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMax, Brushes.DarkBlue, X + 100, Y + 270)
                    YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 290)
                    'E.Graphics.DrawString("توجه : ", myStrFontMax, Brushes.DarkBlue, X + 650, Y + 310)
                    YourEventArgs.Graphics.DrawString(" توجه: مجوز فوق پس از صدور تعويض نخواهد شد - دريافت نوبت بعدی از پايانه به شرط انجام سفر امکان پذير است", myStrFontMax, Brushes.DarkBlue, X + 10, Y + 340)
                    YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 360)
                    YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMax, Brushes.DarkBlue, X + 300, Y + 360)
                    'مرحله دوم
                    Y = Y + 550
                    YourEventArgs.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), X, Y, 700, 400)
                    YourEventArgs.Graphics.DrawImage(My.Resources.qrcode, X + 40, Y + 60, 120, 120)
                    YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y)
                    YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 280, Y + 50)
                    YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMax, Brushes.DarkBlue, X + 30, Y)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y)
                    YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 30)
                    YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMax, Brushes.DarkBlue, X + 30, Y + 30)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 520, Y + 60)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 130)
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170)
                        YourEventArgs.Graphics.DrawString(a(2) + " به شماره پلاک ", myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170)
                    End If
                    YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMax, Brushes.DarkBlue, X + 400, Y + 170)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210)
                    YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 240)
                    YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 300, Y + 240)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 240)
                    YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMax, Brushes.DarkBlue, X + 450, Y + 270)
                    YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMax, Brushes.DarkBlue, X + 100, Y + 270)
                    YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 290)
                    'E.Graphics.DrawString("توجه : ", myStrFontMax, Brushes.DarkBlue, X + 650, Y + 310)
                    YourEventArgs.Graphics.DrawString(" توجه: مجوز فوق پس از صدور تعويض نخواهد شد - دريافت نوبت بعدی از پايانه به شرط انجام سفر امکان پذير است", myStrFontMax, Brushes.DarkBlue, X + 10, Y + 340)
                    YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 360)
                    YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMax, Brushes.DarkBlue, X + 300, Y + 360)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub A5Printing(ByVal YourEventArgs As System.Drawing.Printing.PrintPageEventArgs, ByVal X As Int16, ByVal Y As Int16)
                Try
                    Dim myPaperSizeHalf As Integer = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
                    Dim myStrFontSuperMax As Font = New System.Drawing.Font("Badr", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                    'مرحله اول
                    YourEventArgs.Graphics.DrawRectangle(New Pen(Brushes.Black, 1), X, Y, 520, 350)
                    YourEventArgs.Graphics.DrawImage(My.Resources.qrcode, X + 30, Y + 60, 75, 75)
                    YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y)
                    YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 195, Y + 30)
                    YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 20)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 20)
                    YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 40)
                    YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 40)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 60)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y + 100)
                    Dim a As Char()
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        a = _PPDS.TruckLP.ToCharArray()
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontSuperMax, Brushes.DarkBlue, X + 20, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontSuperMax, Brushes.DarkBlue, X + 60, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontSuperMax, Brushes.DarkBlue, X + 70, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontSuperMax, Brushes.DarkBlue, X + 80, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontSuperMax, Brushes.DarkBlue, X + 90, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontSuperMax, Brushes.DarkBlue, X + 100, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(2) + " پلاک ", myStrFontSuperMax, Brushes.DarkBlue, X + 110, Y + 140)
                    End If
                    YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMin, Brushes.DarkBlue, X + 300, Y + 150)
                    YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, X + 150, Y + 170)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMin, Brushes.DarkBlue, X + 20, Y + 200)
                    YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 220)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 220)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 330, Y + 250)
                    YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 280)
                    YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMin, Brushes.DarkBlue, X + 125, Y + 280)
                    YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 300)
                    YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMin, Brushes.DarkBlue, X + 50, Y + 320)
                    YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMin, Brushes.DarkBlue, X + 165, Y + 320)
                    'مرحله دوم
                    Y = Y + 400
                    YourEventArgs.Graphics.DrawRectangle(New Pen(Brushes.Black, 1), X, Y, 520, 350)
                    YourEventArgs.Graphics.DrawImage(My.Resources.qrcode, X + 30, Y + 60, 75, 75)
                    YourEventArgs.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y)
                    YourEventArgs.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 195, Y + 30)
                    YourEventArgs.Graphics.DrawString(" تاريخ صدور: " + _PPDS.LoadPermissionDate, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 20)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 20)
                    YourEventArgs.Graphics.DrawString(" شماره مجوز: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 40)
                    YourEventArgs.Graphics.DrawString(" ساعت صدور: " + _PPDS.LoadPermissionTime, myStrFontMin, Brushes.DarkBlue, X + 15, Y + 40)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 380, Y + 60)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y + 100)
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        a = _PPDS.TruckLP.ToCharArray()
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontSuperMax, Brushes.DarkBlue, X + 20, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontSuperMax, Brushes.DarkBlue, X + 60, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontSuperMax, Brushes.DarkBlue, X + 70, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontSuperMax, Brushes.DarkBlue, X + 80, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontSuperMax, Brushes.DarkBlue, X + 90, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontSuperMax, Brushes.DarkBlue, X + 100, Y + 140)
                        YourEventArgs.Graphics.DrawString(a(2) + " پلاک ", myStrFontSuperMax, Brushes.DarkBlue, X + 110, Y + 140)
                    End If
                    YourEventArgs.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.LoaderType, myStrFontMin, Brushes.DarkBlue, X + 300, Y + 150)
                    YourEventArgs.Graphics.DrawString(" به رانندگی آقای " + _PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, X + 150, Y + 170)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriverDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMin, Brushes.DarkBlue, X + 20, Y + 200)
                    YourEventArgs.Graphics.DrawString(" از " + _PPDS.SourceCity, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 220)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 220)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 330, Y + 250)
                    YourEventArgs.Graphics.DrawString(_PPDS.TransportPrice + " با نرخ ", myStrFontMin, Brushes.DarkBlue, X + 350, Y + 280)
                    YourEventArgs.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMin, Brushes.DarkBlue, X + 125, Y + 280)
                    YourEventArgs.Graphics.DrawString(_PPDS.LoadCapacitorLoadDescription, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 300)
                    YourEventArgs.Graphics.DrawString("نام کاربر : " + _PPDS.UserName, myStrFontMin, Brushes.DarkBlue, X + 50, Y + 320)
                    YourEventArgs.Graphics.DrawString(" طول سفر :" + _PPDS.OtherNote + " ساعت", myStrFontMin, Brushes.DarkBlue, X + 165, Y + 320)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentPermission_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
                Try
                    Dim ConfiguredPageType As String = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId).AHId, 0)
                    If [Enum].Parse(GetType(System.Drawing.Printing.PaperKind), ConfiguredPageType) = System.Drawing.Printing.PaperKind.A5 Then
                        A5Printing(E, 10, 20)
                    ElseIf [Enum].Parse(GetType(System.Drawing.Printing.PaperKind), ConfiguredPageType) = System.Drawing.Printing.PaperKind.A4 Then
                        A4Printing(E, 50, 80)
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentPermission_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentPermission.PrintPage
                Try
                    _PrintDocumentPermission_PrintPage_Printing(0, 0, e)
                Catch ex As Exception
                    MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

    End Namespace

    Namespace Exceptions
        Public Class LoadPermisionRegisteringFailedBecauseBlackListException
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

        Public Class LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان صدور مجوز به دلیل وضعیت نوبت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان صدور مجوز به دلیل وضعیت بار در مخزن بار وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadPermisionNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مجوز بارگیری با مشخصات مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class LoadPermissionStatusNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت مجوزبارگیری با کدشاخص مورد نظر وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت فعلی مجوز بارگیری مانع از اجرای این فرآیند شد"
                End Get
            End Property
        End Class


    End Namespace

End Namespace

Namespace LoadAllocation
    Public MustInherit Class R2CoreTransportationAndLoadNotificationLoadAllocationStatuses
        Public Shared ReadOnly Property None As Int64 = 0
        Public Shared ReadOnly Property Registered As Int64 = 1
        Public Shared ReadOnly Property Succeeded As Int64 = 2
        Public Shared ReadOnly Property Failed As Int64 = 3
        Public Shared ReadOnly Property CancelledUser As Int64 = 4
        Public Shared ReadOnly Property PermissionCancelled As Int64 = 5
        Public Shared ReadOnly Property CancelledSystem As Int64 = 6
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure

        Public Sub New()
            _LoadAllocationStatusId = Int64.MinValue
            _LoadAllocationStatusTitle = String.Empty
            _LoadAllocationStatusColor = String.Empty
            _ViewFlag = False
        End Sub

        Public Sub New(ByVal YourLoadAllocationStatusId As Int64, YourLoadAllocationStatusTitle As String, YourLoadAllocationStatusColor As String, YourViewFlag As Boolean)
            _LoadAllocationStatusId = YourLoadAllocationStatusId
            _LoadAllocationStatusTitle = YourLoadAllocationStatusTitle
            _LoadAllocationStatusColor = YourLoadAllocationStatusColor
            _ViewFlag = YourViewFlag
        End Sub

        Public Property LoadAllocationStatusId As Int64
        Public Property LoadAllocationStatusTitle As String
        Public Property LoadAllocationStatusColor As String
        Public Property ViewFlag As Boolean
    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure
        Public Sub New()
            MyBase.New()
            _LAId = Long.MinValue
            _nEstelamId = Long.MinValue
            _TurnId = Long.MinValue
            _LAStatusId = Long.MinValue
            _LANote = String.Empty
            _Priority = Int16.MinValue
            _DateTimeMilladi = Now
            _DateShamsi = String.Empty
            _Time = String.Empty
            _UserId = Long.MinValue
        End Sub

        Public Sub New(ByVal YourLoadAllocationId As Int64, ByVal YournEstelamId As Int64, ByVal YourTurnId As Int64, YourLAStatusId As Int64, YourLANote As String, YourPriority As Int16, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourTime As String, YourUserId As Int64)
            _LAId = YourLoadAllocationId
            _nEstelamId = YournEstelamId
            _TurnId = YourTurnId
            _LAStatusId = YourLAStatusId
            _LANote = YourLANote
            _Priority = YourPriority
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _Time = YourTime
            _UserId = YourUserId
        End Sub

        Public Property LAId As Int64
        Public Property nEstelamId As Int64
        Public Property TurnId As Int64
        Public Property LAStatusId As Int64
        Public Property LANote As String
        Public Property Priority As Int16
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property Time As String
        Public Property UserId As Int64

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure
        Inherits R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure

        Public Sub New()
            MyBase.New()
            _TransportCompanyTitle = String.Empty
            _GoodTitle = String.Empty
            _LoadTargetTitle = String.Empty
            _Truck = String.Empty
            _TruckDriver = String.Empty
            _LoadAllocationStatus = String.Empty
            _StrDescription = String.Empty
        End Sub

        Public Sub New(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure, YourTransportCompanyTitle As String, YourGoodTitle As String, YourLoadTargetTitle As String, YourTruck As String, YourTruckDriver As String, YourLoadAllocationStatus As String, YourStrDescription As String)
            MyBase.New(YourNSS.LAId, YourNSS.nEstelamId, YourNSS.TurnId, YourNSS.LAStatusId, YourNSS.LANote, YourNSS.Priority, YourNSS.DateTimeMilladi, YourNSS.DateShamsi, YourNSS.Time, YourNSS.UserId)
            _TransportCompanyTitle = YourTransportCompanyTitle
            _GoodTitle = YourGoodTitle
            _LoadTargetTitle = YourLoadTargetTitle
            _Truck = YourTruck
            _TruckDriver = YourTruckDriver
            _LoadAllocationStatus = YourLoadAllocationStatus
            _StrDescription = YourStrDescription
        End Sub

        Public Property TransportCompanyTitle As String
        Public Property GoodTitle As String
        Public Property LoadTargetTitle As String
        Public Property Truck As String
        Public Property TruckDriver As String
        Public Property LoadAllocationStatus As String
        Public Property StrDescription As String

    End Class

    Public Class R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedforTruckDriverStructure
        Public Sub New()
            MyBase.New()
            LoadCapacitorLoadnEstelamId = String.Empty
            LoadCapacitorLoadTargetTitle = String.Empty
            LoadCapacitorLoadGoodTitle = String.Empty
            LoadCapacitorLoadnCarNumKol = String.Empty
            LoadCapacitorLoadStrPriceSug = String.Empty
            LoadCapacitorLoadStrDescription = String.Empty
            LoadCapacitorLoadLoaderTypeTitle = String.Empty
            LoadCapacitorLoadStrAddress = String.Empty
            LoadCapacitorLoaddDateElam = String.Empty
            LoadCapacitorLoaddTimeElam = String.Empty
            LoadCapacitorLoadStatusTitle = String.Empty
            LoadCapacitorLoadAHTitle = String.Empty
            LoadCapacitorLoadAHSGTitle = String.Empty
            TransportCompanyTitle = String.Empty
            TransportCompanyTel = String.Empty
            TurnnEnterExitId = String.Empty
            TurnOtaghdarTurnNumber = String.Empty
            TurnEnterDate = String.Empty
            TurnEnterTime = String.Empty
            TurnStrDesc = String.Empty
            TurnStatusTitle = String.Empty
            TruckDriver = String.Empty
            TruckDriverSmartCardNo = String.Empty
            TruckDriverMobileNumber = String.Empty
            TruckLPString = String.Empty
            TruckSmartCardNo = String.Empty
            LoadPermissionDate = String.Empty
            LoadPermissionTime = String.Empty
            LoadPermissionRegisteringLocation = String.Empty
            LoadPermissionStatusTitle = String.Empty
            LoadAllocationId = String.Empty
            LoadAllocationStatusTitle = String.Empty
            LoadAllocationNote = String.Empty
            LoadAllocationDateShamsi = String.Empty
            LoadAllocationTime = String.Empty
            LoadAllocationStatusColor = Color.Red
            LoadAllocationPriority = String.Empty
        End Sub

        Public Sub New(YourLoadCapacitorLoadnEstelamId As String, YourLoadCapacitorLoadTargetTitle As String, YourLoadCapacitorLoadGoodTitle As String, YourLoadCapacitorLoadnCarNumKol As String, YourLoadCapacitorLoadStrPriceSug As String, YourLoadCapacitorLoadStrDescription As String, YourLoadCapacitorLoadLoaderTypeTitle As String, YourLoadCapacitorLoadStrAddress As String, YourLoadCapacitorLoaddDateElam As String, YourLoadCapacitorLoaddTimeElam As String, YourLoadCapacitorLoadStatusTitle As String, YourLoadCapacitorLoadAHTitle As String, YourLoadCapacitorLoadAHSGTitle As String, YourTransportCompanyTitle As String, YourTransportCompanyTel As String, YourTurnnEnterExitId As String, YourTurnOtaghdarTurnNumber As String, YourTurnEnterDate As String, YourTurnEnterTime As String, YourTurnStrDesc As String, YourTurnStatusTitle As String, YourTruckDriver As String, YourTruckDriverSmartCardNo As String, YourTruckDriverMobileNumber As String, YourTruckLPString As String, YourTruckSmartCardNo As String, YourLoadPermissionDate As String, YourLoadPermissionTime As String, YourLoadPermissionRegisteringLocation As String, YourLoadPermissionStatusTitle As String, YourLoadAllocationId As String, YourLoadAllocationStatusTitle As String, YourLoadAllocationNote As String, YourLoadAllocationDateShamsi As String, YourLoadAllocationTime As String, YourLoadAllocationStatusColor As Color, YourLoadAllocationPriority As String)
            LoadCapacitorLoadnEstelamId = YourLoadCapacitorLoadnEstelamId
            LoadCapacitorLoadTargetTitle = YourLoadCapacitorLoadTargetTitle
            LoadCapacitorLoadGoodTitle = YourLoadCapacitorLoadGoodTitle
            LoadCapacitorLoadnCarNumKol = YourLoadCapacitorLoadnCarNumKol
            LoadCapacitorLoadStrPriceSug = YourLoadCapacitorLoadStrPriceSug
            LoadCapacitorLoadStrDescription = YourLoadCapacitorLoadStrDescription
            LoadCapacitorLoadLoaderTypeTitle = YourLoadCapacitorLoadLoaderTypeTitle
            LoadCapacitorLoadStrAddress = YourLoadCapacitorLoadStrAddress
            LoadCapacitorLoaddDateElam = YourLoadCapacitorLoaddDateElam
            LoadCapacitorLoaddTimeElam = YourLoadCapacitorLoaddTimeElam
            LoadCapacitorLoadStatusTitle = YourLoadCapacitorLoadStatusTitle
            LoadCapacitorLoadAHTitle = YourLoadCapacitorLoadAHTitle
            LoadCapacitorLoadAHSGTitle = YourLoadCapacitorLoadAHSGTitle
            TransportCompanyTitle = YourTransportCompanyTitle
            TransportCompanyTel = YourTransportCompanyTel
            TurnnEnterExitId = YourTurnnEnterExitId
            TurnOtaghdarTurnNumber = YourTurnOtaghdarTurnNumber
            TurnEnterDate = YourTurnEnterDate
            TurnEnterTime = YourTurnEnterTime
            TurnStrDesc = YourTurnStrDesc
            TurnStatusTitle = YourTurnStatusTitle
            TruckDriver = YourTruckDriver
            TruckDriverSmartCardNo = YourTruckDriverSmartCardNo
            TruckDriverMobileNumber = YourTruckDriverMobileNumber
            TruckLPString = YourTruckLPString
            TruckSmartCardNo = YourTruckSmartCardNo
            LoadPermissionDate = YourLoadPermissionDate
            LoadPermissionTime = YourLoadPermissionTime
            LoadPermissionRegisteringLocation = YourLoadPermissionRegisteringLocation
            LoadPermissionStatusTitle = YourLoadPermissionStatusTitle
            LoadAllocationId = YourLoadAllocationId
            LoadAllocationStatusTitle = YourLoadAllocationStatusTitle
            LoadAllocationNote = YourLoadAllocationNote
            LoadAllocationDateShamsi = YourLoadAllocationDateShamsi
            LoadAllocationTime = YourLoadAllocationTime
            LoadAllocationStatusColor = YourLoadAllocationStatusColor
            LoadAllocationPriority = YourLoadAllocationPriority
        End Sub

        Public Property LoadCapacitorLoadnEstelamId As String
        Public Property LoadCapacitorLoadTargetTitle As String
        Public Property LoadCapacitorLoadGoodTitle As String
        Public Property LoadCapacitorLoadnCarNumKol As String
        Public Property LoadCapacitorLoadStrPriceSug As String
        Public Property LoadCapacitorLoadStrDescription As String
        Public Property LoadCapacitorLoadLoaderTypeTitle As String
        Public Property LoadCapacitorLoadStrAddress As String
        Public Property LoadCapacitorLoaddDateElam() As String
        Public Property LoadCapacitorLoaddTimeElam() As String
        Public Property LoadCapacitorLoadStatusTitle As String
        Public Property LoadCapacitorLoadAHTitle() As String
        Public Property LoadCapacitorLoadAHSGTitle() As String
        Public Property TransportCompanyTitle As String
        Public Property TransportCompanyTel As String
        Public Property TurnnEnterExitId As String
        Public Property TurnOtaghdarTurnNumber As String
        Public Property TurnEnterDate As String
        Public Property TurnEnterTime As String
        Public Property TurnStrDesc As String
        Public Property TurnStatusTitle As String
        Public Property TruckDriver As String
        Public Property TruckDriverSmartCardNo As String
        Public Property TruckDriverMobileNumber As String
        Public Property TruckLPString As String
        Public Property TruckSmartCardNo As String
        Public Property LoadPermissionDate As String
        Public Property LoadPermissionTime As String
        Public Property LoadPermissionRegisteringLocation As String
        Public Property LoadPermissionStatusTitle As String
        Public Property LoadAllocationId As String
        Public Property LoadAllocationStatusTitle As String
        Public Property LoadAllocationNote As String
        Public Property LoadAllocationDateShamsi As String
        Public Property LoadAllocationTime As String
        Public Property LoadAllocationStatusColor As Color
        Public Property LoadAllocationPriority As String
    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement
        Private Shared _DateTime As New R2DateTime

        Public Shared Function GetLoadAllocationsforTruckDriver(YourMobileUserId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedforTruckDriverStructure)
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
   "Declare @LastTurnId int
    Select Top 1 @LastTurnId=Turns.nEnterExitId from R2Primary.dbo.TblMobileUsers as MobileUsers
       Inner Join dbtransport.dbo.TbPerson as Persons On MobileUsers.MUMobileNumber Collate Arabic_CI_AI_WS=Persons.strIDNO Collate Arabic_CI_AI_WS
       Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Persons.nIDPerson=CarAndPersons.nIDPerson
       Inner Join dbtransport.dbo.TbCar as Cars On CarAndPersons.nIDCar=Cars.nIDCar 
       Inner Join dbtransport.dbo.tbEnterExit as Turns On Cars.nIDCar=Turns.strCardno 
    Where MobileUsers.MUId=" & YourMobileUserId & " and CarAndPersons.snRelation=2 Order By Turns.nEnterExitId Desc
    Select LoadCapacitor.nEstelamID as LoadCapacitorLoadnEstelamId,Targets.strCityName as LoadCapacitorLoadTargetTitle,Products.strGoodName as  LoadCapacitorLoadGoodTitle,LoadCapacitor.nCarNumKol as LoadCapacitorLoadnCarNumKol,LoadCapacitor.strPriceSug as LoadCapacitorLoadStrPriceSug,LoadCapacitor.strDescription as LoadCapacitorLoadStrDescription,LoaderTypes.LoaderTypeTitle as LoadCapacitorLoadLoaderTypeTitle,
	       LoadCapacitor.strAddress as LoadCapacitorLoadStrAddress,LoadCapacitor.dTimeElam as LoadCapacitorLoaddTimeElam,LoadCapacitor.dDateElam  as  LoadCapacitorLoaddDateElam,LoadCapacitorLoadStatuses.LoadStatusName as LoadCapacitorLoadStatusTitle,AHs.AHTitle as LoadCapacitorLoadAHTitle,AHSGs.AHSGTitle as LoadCapacitorLoadAHSGTitle,TransportCompanies.TCTitle as  TransportCompanyTitle,TransportCompanies.TCTel as  TransportCompanyTel,Turns.nEnterExitId as  TurnnEnterExitId,
	       Turns.OtaghdarTurnNumber as TurnOtaghdarTurnNumber,Turns.strEnterDate as TurnEnterDate,Turns.strEnterTime as TurnEnterTime,Turns.strDesc as TurnStrDesc,TurnStatuses.TurnStatusTitle as TurnStatusTitle,Persons.strPersonFullName as TruckDriver,Drivers.strSmartcardNo  as TruckDriverSmartCardNo,Persons.strIDNO as TruckDriverMobileNumber,Cars.strCarNo+'-'+Cars.strCarSerialNo as TruckLPString,Cars.strBodyNo as TruckSmartCardNo,Turns.strExitDate as LoadPermissionDate,
           Turns.strExitTime as LoadPermissionTime,LoadPermissionStatuses.LoadPermissionStatusTitle as LoadPermissionStatusTitle,Turns.strBarnameNo as LoadPermissionRegisteringLocation,LoadAllocations.LAId as  LoadAllocationId,LoadAllocationStatuses.LoadAllocationStatusTitle as  LoadAllocationStatusTitle,LoadAllocations.LANote as LoadAllocationNote,LoadAllocations.DateShamsi as LoadAllocationDateShamsi,LoadAllocations.Time as LoadAllocationTime,LoadAllocationStatuses.LoadAllocationStatusColor as LoadAllocationStatusColor,LoadAllocations.Priority as LoadAllocationPriority  
    from dbtransport.dbo.tbEnterExit as Turns
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTurnStatuses as TurnStatuses On Turns.TurnStatus=TurnStatuses.TurnStatusId 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations On Turns.nEnterExitId=LoadAllocations.TurnId
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses as LoadAllocationStatuses On LoadAllocations.LAStatusId=LoadAllocationStatuses.LoadAllocationStatusId 
       Inner Join dbtransport.dbo.tbElam as LoadCapacitor On LoadAllocations.nEstelamId=LoadCapacitor.nEstelamID 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AHs On LoadCapacitor.AHId=AHs.AHId 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSGs on LoadCapacitor.AHSGId=AHSGs.AHSGId 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadCapacitorLoadStatuses as LoadCapacitorLoadStatuses On LoadCapacitor.LoadStatus=LoadCapacitorLoadStatuses.LoadStatusId 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoaderTypes as LoaderTypes On LoadCapacitor.nTruckType=LoaderTypes.LoaderTypeId 
       Inner Join dbtransport.dbo.tbProducts as Products On LoadCapacitor.nBarcode=Products.strGoodCode 
       Inner Join dbtransport.dbo.tbCity as Targets On LoadCapacitor.nCityCode=Targets.nCityCode 
       Inner Join dbtransport.dbo.TbCar as Cars on Turns.strCardno=Cars.nIDCar 
       Inner Join dbtransport.dbo.TbCarAndPerson as CarAndPersons On Cars.nIDCar=CarAndPersons.nIDCar 
       Inner Join dbtransport.dbo.TbPerson as Persons On CarAndPersons.nIDPerson=Persons.nIDPerson 
       Inner Join dbtransport.dbo.TbDriver as Drivers On Persons.nIDPerson=Drivers.nIDDriver 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On LoadCapacitor.nCompCode=TransportCompanies.TCId 
       Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadPermissionStatuses as LoadPermissionStatuses On Turns.LoadPermissionStatus=LoadPermissionStatuses.LoadPermissionStatusId 
    Where Turns.nEnterExitId=@LastTurnId and (LoadAllocations.LAStatusId=1 or LoadAllocations.LAStatusId=2 or LoadAllocations.LAStatusId=3) and CarAndPersons.snRelation=2 and AHs.ViewFlag=1 and AHs.Deleted=0 and AHSGs.ViewFlag=1 and AHSGs.Deleted=0
    Order By LoadAllocations.Priority Asc", 1, DS).GetRecordsCount() = 0 Then Throw New LoadAllocationNotFoundException
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedforTruckDriverStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedforTruckDriverStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedforTruckDriverStructure
                    NSS.LoadCapacitorLoadnEstelamId = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadnEstelamId"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadnEstelamId"))
                    NSS.LoadCapacitorLoadTargetTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadTargetTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadTargetTitle"))
                    NSS.LoadCapacitorLoadGoodTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadGoodTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadGoodTitle"))
                    NSS.LoadCapacitorLoadnCarNumKol = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadnCarNumKol"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadnCarNumKol"))
                    NSS.LoadCapacitorLoadStrPriceSug = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrPriceSug"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrPriceSug"))
                    NSS.LoadCapacitorLoadStrDescription = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrDescription"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrDescription"))
                    NSS.LoadCapacitorLoadLoaderTypeTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadLoaderTypeTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadLoaderTypeTitle"))
                    NSS.LoadCapacitorLoadStrAddress = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrAddress"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStrAddress"))
                    NSS.LoadCapacitorLoaddDateElam = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoaddDateElam"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoaddDateElam"))
                    NSS.LoadCapacitorLoaddTimeElam = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoaddTimeElam"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoaddTimeElam"))
                    NSS.LoadCapacitorLoadStatusTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStatusTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadStatusTitle"))
                    NSS.LoadCapacitorLoadAHTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadAHTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadAHTitle"))
                    NSS.LoadCapacitorLoadAHSGTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadAHSGTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadCapacitorLoadAHSGTitle"))
                    NSS.TransportCompanyTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TransportCompanyTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TransportCompanyTitle"))
                    NSS.TransportCompanyTel = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TransportCompanyTel"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TransportCompanyTel"))
                    NSS.TurnnEnterExitId = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnnEnterExitId"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnnEnterExitId"))
                    NSS.TurnOtaghdarTurnNumber = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnOtaghdarTurnNumber"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnOtaghdarTurnNumber"))
                    NSS.TurnEnterDate = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnEnterDate"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnEnterDate"))
                    NSS.TurnEnterTime = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnEnterTime"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnEnterTime"))
                    NSS.TurnStrDesc = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnStrDesc"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnStrDesc"))
                    NSS.TurnStatusTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TurnStatusTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TurnStatusTitle"))
                    NSS.TruckDriver = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TruckDriver"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TruckDriver"))
                    NSS.TruckDriverSmartCardNo = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TruckDriverSmartCardNo"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TruckDriverSmartCardNo"))
                    NSS.TruckDriverMobileNumber = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TruckDriverMobileNumber"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TruckDriverMobileNumber"))
                    NSS.TruckLPString = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TruckLPString"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TruckLPString"))
                    NSS.TruckSmartCardNo = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("TruckSmartCardNo"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("TruckSmartCardNo"))
                    NSS.LoadPermissionDate = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadPermissionDate"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadPermissionDate"))
                    NSS.LoadPermissionTime = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadPermissionTime"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadPermissionTime"))
                    NSS.LoadPermissionRegisteringLocation = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadPermissionRegisteringLocation"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadPermissionRegisteringLocation"))
                    NSS.LoadPermissionStatusTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadPermissionStatusTitle"))
                    NSS.LoadAllocationId = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationId"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationId"))
                    NSS.LoadAllocationStatusTitle = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusTitle"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusTitle"))
                    NSS.LoadAllocationNote = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationNote"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationNote"))
                    NSS.LoadAllocationDateShamsi = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationDateShamsi"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationDateShamsi"))
                    NSS.LoadAllocationTime = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationTime"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationTime"))
                    NSS.LoadAllocationStatusColor = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusColor"), DBNull.Value), Color.Red, Color.FromName(DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusColor").TRIM))
                    NSS.LoadAllocationPriority = IIf(Object.Equals(DS.Tables(0).Rows(Loopx).Item("LoadAllocationPriority"), DBNull.Value), String.Empty, DS.Tables(0).Rows(Loopx).Item("LoadAllocationPriority"))
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoadAllocation(YourLoadAllocationId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                        "Select LoadAllocation.Priority,LoadAllocation.LAId,LoadAllocation.nEstelamId,LoadAllocation.TurnId,LoadAllocation.LAStatusId,LoadAllocation.LANote,LoadAllocation.DateTimeMilladi,LoadAllocation.DateShamsi,LoadAllocation.Time,LoadAllocation.UserId,TransportCompanies.TCTitle,Product.strGoodName,City.strCityName,Car.strCarNo+'-'+Car.strCarSerialNo as Truck,Person.strPersonFullName,LoadAllocationStatus.LoadAllocationStatusTitle,ELAM.strDescription
                                         From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations  as LoadAllocation 
                                           Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                                           Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Elam.nCompCode=TransportCompanies.TCId 
                                           Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode 
                                           Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode 
                                           Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                           Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses as LoadAllocationStatus On LoadAllocation.LAStatusId=LoadAllocationStatus.LoadAllocationStatusId
                                         Where LoadAllocation.LAId=" & YourLoadAllocationId & "", 1, DS).GetRecordsCount() = 0 Then Throw New LoadAllocationNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure(DS.Tables(0).Rows(0).Item("LAId"), DS.Tables(0).Rows(0).Item("nEstelamId"), DS.Tables(0).Rows(0).Item("TurnId"), DS.Tables(0).Rows(0).Item("LAStatusId"), DS.Tables(0).Rows(0).Item("LANote").trim, DS.Tables(0).Rows(0).Item("Priority"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("UserId")), DS.Tables(0).Rows(0).Item("TCTitle").trim, DS.Tables(0).Rows(0).Item("strGoodName").trim, DS.Tables(0).Rows(0).Item("strCityName").trim, DS.Tables(0).Rows(0).Item("Truck"), DS.Tables(0).Rows(0).Item("StrPersonFullName"), DS.Tables(0).Rows(0).Item("LoadAllocationStatusTitle"), DS.Tables(0).Rows(0).Item("StrDescription"))
            Catch exx As LoadAllocationNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoadAllocation(YournEstelamId As Int64, YourTurnId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                                                          "Select LoadAllocation.Priority,LoadAllocation.LAId,LoadAllocation.nEstelamId,LoadAllocation.TurnId,LoadAllocation.LAStatusId,LoadAllocation.LANote,LoadAllocation.DateTimeMilladi,LoadAllocation.DateShamsi,LoadAllocation.Time,LoadAllocation.UserId,TransportCompanies.TCTitle,Product.strGoodName,City.strCityName,Car.strCarNo+'-'+Car.strCarSerialNo as Truck,Person.strPersonFullName,LoadAllocationStatus.LoadAllocationStatusTitle,ELAM.strDescription
                                         From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations  as LoadAllocation 
                                           Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                                           Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Elam.nCompCode=TransportCompanies.TCId 
                                           Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode 
                                           Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode 
                                           Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                           Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses as LoadAllocationStatus On LoadAllocation.LAStatusId=LoadAllocationStatus.LoadAllocationStatusId
                                         Where LoadAllocation.nEstelamId=" & YournEstelamId & " and LoadAllocation.TurnId=" & YourTurnId & "", 1, DS).GetRecordsCount() = 0 Then Throw New LoadAllocationNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure(DS.Tables(0).Rows(0).Item("LAId"), DS.Tables(0).Rows(0).Item("nEstelamId"), DS.Tables(0).Rows(0).Item("TurnId"), DS.Tables(0).Rows(0).Item("LAStatusId"), DS.Tables(0).Rows(0).Item("LANote").trim, DS.Tables(0).Rows(0).Item("Priority"), DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("Time"), DS.Tables(0).Rows(0).Item("UserId")), DS.Tables(0).Rows(0).Item("TCTitle").trim, DS.Tables(0).Rows(0).Item("strGoodName").trim, DS.Tables(0).Rows(0).Item("strCityName").trim, DS.Tables(0).Rows(0).Item("Truck"), DS.Tables(0).Rows(0).Item("StrPersonFullName"), DS.Tables(0).Rows(0).Item("LoadAllocationStatusTitle"), DS.Tables(0).Rows(0).Item("StrDescription"))
            Catch exx As LoadAllocationNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSLoadAllocationStatus(YourLoadAllocationStatusId As Int64) As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure
            Try
                Dim DS As DataSet = Nothing
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses Where LoadAllocationStatusId=" & YourLoadAllocationStatusId & "", 3600, DS).GetRecordsCount = 0 Then Throw New LoadAllocationStatusNotFoundException
                Dim NSS As New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure
                NSS.LoadAllocationStatusId = YourLoadAllocationStatusId
                NSS.LoadAllocationStatusTitle = DS.Tables(0).Rows(0).Item("LoadAllocationStatustitle").TRIM
                NSS.LoadAllocationStatusColor = DS.Tables(0).Rows(0).Item("LoadAllocationStatusColor").TRIM
                NSS.ViewFlag = DS.Tables(0).Rows(0).Item("ViewFlag")
                Return NSS
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ExistRegisteredLoadAllocation(YournEstelamId As Int64, YourTurnId As Int64) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                      Where LoadAllocations.nEstelamId=" & YournEstelamId & " and LoadAllocations.TurnId=" & YourTurnId & " and (LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered & " or LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed & ")", 0, DS).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTotalNumberOfRegisteredLoadAllocations(YourTurnId As Int64) As Int64
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                     "Select count(*) As Counting from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                      Where LoadAllocations.TurnId=" & YourTurnId & " and (LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered & " or LoadAllocations.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed & ")", 0, DS)
                Return DS.Tables(0).Rows(0).Item("Counting")
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function LoadAllocationRegistering(YournEstelamId As Int64, YourTurnId As Int64) As Int64
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                Dim NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroup(NSSLoadCapacitorLoad.AHSGId)
                Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(NSSLoadCapacitorLoad.AHId)
                If NSSAnnouncementHallSubGroup.Active = 0 Then Throw New AnnouncementHallSubGroupUnActiveException
                Dim NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure = Turns.R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(YourTurnId)
                Dim NSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure = R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(NSSTurn)
                'آیا زمان تخصیص بار برای زیرگروه سالن مورد نظر فرارسیده است
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.IsTimingActive(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) Then
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.GetTiming(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InLoadAllocationTime Then
                        Throw New TimingNotReachedException
                    End If
                Else
                    'کنترل تایمینگ بار در مخزن بار
                    If Not R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.IsLoadCapacitorLoadTimingReadeyforLoadAllocationRegistering(NSSLoadCapacitorLoad, NSSAnnouncementHall, NSSAnnouncementHallSubGroup) Then Throw New LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException
                End If
                'کنترل وضعیت بار در مخزن بار
                If Not R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.IsLoadCapacitorLoadStatusReadeyforLoadAllocationRegistering(NSSLoadCapacitorLoad) Then Throw New LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException
                'کنترل تطابق تسلسل نوبت مربوط به نوبت انتخاب شده
                If IsLoadCapacitorLoadAHSGMatchWithSequentialTurnOfTurn(YournEstelamId, YourTurnId) = False Then Throw New LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException
                'کنترل تطابق ناوگان با بار انتخاب شده
                If R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetAnnouncementHallSubGroups(NSSTruck).Where(Function(x) x = NSSLoadCapacitorLoad.AHSGId).Count = 0 Then
                    Throw New LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException
                End If
                'کنترل وضعیت نوبت
                If Not R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTurnReadeyforLoadAllocationRegistering(NSSTurn) Then Throw New LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException
                'کنترل تکراری نبودن تخصیص بار - تخصیص فعال
                If ExistRegisteredLoadAllocation(YournEstelamId, YourTurnId) Then Throw New RegisteredLoadAllocationIsRepetitiousException
                'کنترل حداکثر تعداد مجاز تخصیص برای راننده - مثلا حداکثر می تواند 10 مورد تخصیص فعال داشته باشد
                'باید دقت کرد تخصیص ناموفق جزو این دسته نیست و سرویس خودکار صدور مجوز گروهی می تواند آن تخصیص را در صدور مجوز هنوز هم شرکت بدهد
                If GetTotalNumberOfRegisteredLoadAllocations(YourTurnId) = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting, NSSLoadCapacitorLoad.AHId, 0) Then Throw New LoadAllocationMaximumAllowedNumberReachedException
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Select Top 1 LAId From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations with (tablockx) Order By LAId Desc"
                CmdSql.ExecuteNonQuery()
                CmdSql.CommandText = "Select IDENT_CURRENT('R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations') "
                Dim LAIdNew As Int64 = CmdSql.ExecuteScalar() + 1
                CmdSql.CommandText = "Select Top 1 LoadAllocations.Priority from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                                      Where LoadAllocations.TurnId=" & YourTurnId & " and (LoadAllocations.LAStatusId=1 or LoadAllocations.LAStatusId=3)
                                      Order By LoadAllocations.Priority Asc"
                Dim Obj = CmdSql.ExecuteScalar
                Dim Priority As Int16 = IIf(Object.Equals(Obj, Nothing), 1, Convert.ToInt16(Obj) + 1)
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations(nEstelamId,TurnId,LAStatusId,LANote,Priority,DateTimeMilladi,DateShamsi,Time,UserId) Values(" & YournEstelamId & "," & YourTurnId & "," & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered & ",''," & Priority & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "','" & _DateTime.GetCurrentTime() & "'," & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & ")"
                CmdSql.ExecuteNonQuery()
                R2CoreTransportationAndLoadNotificationMClassTurnsManagement.LoadAllocationRegistering(NSSTurn)
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.LoadCapacitorLoadAllocating(NSSLoadCapacitorLoad)
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                RePrioritize(NSSTurn)
                Return LAIdNew
            Catch ex As Exception When TypeOf ex Is AnnouncementHallSubGroupUnActiveException _
                OrElse TypeOf ex Is TimingNotReachedException _
                OrElse TypeOf ex Is TurnNotFoundException _
                OrElse TypeOf ex Is LoadAllocationMaximumAllowedNumberReachedException _
                OrElse TypeOf ex Is RegisteredLoadAllocationIsRepetitiousException _
                OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException _
                OrElse TypeOf ex Is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException
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

        Public Shared Sub LoadAllocationLoadPermissionRegistering(YourLoadAllocationId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(YourLoadAllocationId)
                'کنترل وضعیت تخصیص بار
                If NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser Or NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Succeeded Or NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledSystem Or NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.PermissionCancelled Then Throw New LoadAllocationLoadPermissionRegisteringNotAllowedBecauseLoadAllocationStatusException
                Try
                    R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.LoadPermissionRegistering(NSSLoadAllocation)
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Succeeded & ",LANote='مجوز صادر شده'  Where LAId=" & YourLoadAllocationId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Catch ex As Exception When TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException OrElse TypeOf ex Is PresentNotRegisteredInLast30MinuteException OrElse TypeOf ex Is PresentsNotEnoughException OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseBlackListException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException OrElse TypeOf ex Is LoadCapacitorLoadReleaseTimeNotReachedException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException
                    'کنسلی خودکار تخصیص پس از گذشت زمان برنامه ریزی شده
                    If DateDiff(DateInterval.Minute, NSSLoadAllocation.DateTimeMilladi, _DateTime.GetCurrentDateTimeMilladi()) >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting, 1) Then
                        LoadAllocationCancelling(YourLoadAllocationId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledSystem)
                        Throw New LoadAllocationMaxDelayFailedReachedException
                    End If
                    'مارک تخصیص به حالت فی لد Falied
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed & ",LANote='" & ex.Message & "' Where LAId=" & YourLoadAllocationId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                    Throw ex
                End Try
            Catch ex As Exception When TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                                       OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                                       OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException _
                                       OrElse TypeOf ex Is PresentNotRegisteredInLast30MinuteException _
                                       OrElse TypeOf ex Is PresentsNotEnoughException _
                                       OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseBlackListException _
                                       OrElse TypeOf ex Is GetNSSException _
                                       OrElse TypeOf ex Is LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException _
                                       OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException _
                                       OrElse TypeOf ex Is LoadCapacitorLoadReleaseTimeNotReachedException _
                                       OrElse TypeOf ex Is LoadAllocationLoadPermissionRegisteringNotAllowedBecauseLoadAllocationStatusException _
                                       OrElse TypeOf ex Is LoadAllocationMaxDelayFailedReachedException _
                                       OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                                       OrElse TypeOf ex Is GetNSSException _
                                       OrElse TypeOf ex Is GetDataException _
                                       OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                                       OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                                       OrElse TypeOf ex Is TimingNotReachedException
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

        Public Shared Sub LoadAllocationCancelling(YourLoadAllocationId As Int64, YourCancellingStatus As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(YourLoadAllocationId)
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(NSSLoadAllocation.nEstelamId)
                'آیا زمان تخصیص بار برای زیرگروه سالن مورد نظر فرارسیده است
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.IsTimingActive(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) Then
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.GetTiming(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InLoadAllocationTime Then
                        Throw New TimingNotReachedException
                    End If
                End If
                Dim NSSLoadAllocationStatus As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure = GetNSSLoadAllocationStatus(YourCancellingStatus)
                'کنترل وضعیت تخصیص بار
                If Not (NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed Or NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered Or NSSLoadAllocation.LAStatusId = R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.PermissionCancelled) Then Throw New LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set LAStatusId=" & YourCancellingStatus & ",LANote='" & NSSLoadAllocationStatus.LoadAllocationStatusTitle & "'  Where LAId=" & YourLoadAllocationId & ""
                CmdSql.ExecuteNonQuery()
                R2CoreTransportationAndLoadNotificationMClassTurnsManagement.LoadAllocationCancelling(NSSLoadAllocation.TurnId)
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.LoadCapacitorLoadAllocationCancelling(NSSLoadAllocation.nEstelamId)
                CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                RePrioritize(R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(NSSLoadAllocation.TurnId))
            Catch ex As Exception When TypeOf ex Is TimingNotReachedException _
                OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                OrElse TypeOf ex Is LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException
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

        Public Shared Sub ChangeLoadAllocationStatus(YourLoadAllocationId As Int64, YourLoadAllocationStatusId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set LAStatusId=" & YourLoadAllocationStatusId & "Where LAId=" & YourLoadAllocationId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function GetTotalNumberOfLoadAllocationWhichBlindfold(YournEstelamId As Int64) As Int64 'تخصیص بلاتکلیف
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Count(*) as Count from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Where nEstelamId=" & YournEstelamId & " and (LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed & " or LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered & ") ", 1, DS).GetRecordsCount() = 0 Then Return 0
                Return DS.Tables(0).Rows(0).Item(("Count"))
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function IsLoadCapacitorLoadAHSGMatchWithSequentialTurnOfTurn(YournEstelamId As Int64, YournEnterExitId As Int64)
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select * from dbtransport.dbo.tbElam as LoadCapacitor
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSG On LoadCapacitor.AHSGId=AHSG.AHSGId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationAnnouncementHallSubGroups as AHRAHSG On AHSG.AHSGId=AHRAHSG.AHSGId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AH On AHRAHSG.AHId=AH.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallsRelationSequentialTurns as AHRSeqT oN AH.AHId=AHRSeqT.AHId
                            Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblSequentialTurns as SeqT On AHRSeqT.SeqTId=SeqT.SeqTId
                            Inner Join dbtransport.dbo.tbEnterExit as Turns On SeqT.SeqTKeyWord Collate Arabic_CI_AI_WS=Substring(Turns.OtaghdarTurnNumber,1,1) Collate Arabic_CI_AI_WS
                        Where AHRAHSG.RelationActive=1 and AHRSeqT.RelationActive=1 and Turns.nEnterExitId=" & YournEnterExitId & " and LoadCapacitor.nEstelamID=" & YournEstelamId & "", 1, DS).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadAllocations(YourAHId As Int64, YourAHSGId As Int64, YourLoadAllocationStatusId As Int64, Optional YourTransportCompanyId As Int64 = Int64.MinValue) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select LoadAllocation.Priority,LoadAllocation.LAId,LoadAllocation.nEstelamId,LoadAllocation.TurnId,LoadAllocation.LAStatusId,LoadAllocation.LANote,LoadAllocation.DateTimeMilladi,LoadAllocation.DateShamsi,LoadAllocation.Time,LoadAllocation.UserId,TransportCompanies.TCTitle,Product.strGoodName,City.strCityName,Car.strCarNo+'-'+Car.strCarSerialNo as Truck,Person.strPersonFullName,LoadAllocationStatus.LoadAllocationStatusTitle,ELAM.strDescription
                                         From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations  as LoadAllocation 
                                           Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                                           Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies On Elam.nCompCode=TransportCompanies.TCId 
                                           Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode 
                                           Inner Join dbtransport.dbo.tbCity as City On Elam.nCityCode=City.nCityCode 
                                           Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar
                                           Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                           Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses as LoadAllocationStatus On LoadAllocation.LAStatusId=LoadAllocationStatus.LoadAllocationStatusId
                                         Where LoadAllocation.DateShamsi='" & _DateTime.GetCurrentDateShamsiFull() & "' and LoadAllocation.LAStatusId=" & YourLoadAllocationStatusId & " and Elam.AHId=" & YourAHId & " and Elam.AHSGId=" & YourAHSGId & "" & IIf(YourTransportCompanyId = Int64.MinValue, String.Empty, " and TransportCompanies.TCId=" & YourTransportCompanyId & "") & " 
                                         Order By LoadAllocation.DateTimeMilladi Desc", 1, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure(DS.Tables(0).Rows(Loopx).Item("LAId"), DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("TurnId"), DS.Tables(0).Rows(Loopx).Item("LAStatusId"), DS.Tables(0).Rows(Loopx).Item("LANote").trim, DS.Tables(0).Rows(Loopx).Item("Priority"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("Time"), DS.Tables(0).Rows(Loopx).Item("UserId")), DS.Tables(0).Rows(Loopx).Item("TCTitle").trim, DS.Tables(0).Rows(Loopx).Item("strGoodName").trim, DS.Tables(0).Rows(Loopx).Item("strCityName").trim, DS.Tables(0).Rows(Loopx).Item("Truck"), DS.Tables(0).Rows(Loopx).Item("StrPersonFullName"), DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusTitle"), DS.Tables(0).Rows(Loopx).Item("StrDescription")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadAllocationsforLoadPermissionRegistering(YourAHId As Int64, YourAHSGId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "
                      Select LoadAllocation.Priority,LoadAllocation.LAId,LoadAllocation.nEstelamId,LoadAllocation.TurnId,LoadAllocation.LAStatusId,LoadAllocation.LANote,LoadAllocation.DateTimeMilladi,LoadAllocation.DateShamsi,LoadAllocation.Time,LoadAllocation.UserId
                             From R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations  as LoadAllocation 
                               Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                               Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHalls as AHs On Elam.AHId=AHs.AHId 
                               Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblAnnouncementHallSubGroups as AHSGs On Elam.AHSGId =AHSGs.AHSGId  
                             Where LoadAllocation.DateShamsi='" & _DateTime.GetCurrentDateShamsiFull() & "' and (LoadAllocation.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed & " or LoadAllocation.LAStatusId=" & R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Registered & ") and (AHs.AHId=" & YourAHId & ") and (AHSGs.AHSGId=" & YourAHSGId & ") 
                             Order By TurnId Asc,LoadAllocation.Priority Asc", 0, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure(DS.Tables(0).Rows(Loopx).Item("LAId"), DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("TurnId"), DS.Tables(0).Rows(Loopx).Item("LAStatusId"), DS.Tables(0).Rows(Loopx).Item("LANote").trim, DS.Tables(0).Rows(Loopx).Item("Priority"), DS.Tables(0).Rows(Loopx).Item("DateTimeMilladi"), DS.Tables(0).Rows(Loopx).Item("DateShamsi"), DS.Tables(0).Rows(Loopx).Item("Time"), DS.Tables(0).Rows(Loopx).Item("UserId")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function LoadAllocationsLoadPermissionRegistering() As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
            Try
                Dim AnnouncementHallsAnnouncementHallSubGroupsJOINT As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallAnnouncementHallSubGroupJOINTStructure) = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallsAnnouncementHallSubGroupsJOINT()
                Dim FailedResultLst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)()
                For LoopAnnouncementHallsAnnouncementHallSubGroupsJOINT As Int64 = 0 To AnnouncementHallsAnnouncementHallSubGroupsJOINT.Count - 1
                    Dim AHId As Int64 = AnnouncementHallsAnnouncementHallSubGroupsJOINT(LoopAnnouncementHallsAnnouncementHallSubGroupsJOINT).NSSAnnounementHall.AHId
                    Dim AHSGId As Int64 = AnnouncementHallsAnnouncementHallSubGroupsJOINT(LoopAnnouncementHallsAnnouncementHallSubGroupsJOINT).NSSAnnouncementHallSubGroup.AHSGId
                    'کنترل تایمینگ - آیا زمان صدور مجوز برای زیرگروه سالن مورد نظر فرارسیده است
                    'If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.IsTimingActive(AHId, AHSGId) Then
                    '    If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.GetTiming(AHId, AHSGId) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.StartLoadPermissionProcess Then
                    '        Continue For
                    '    End If
                    'End If
                    Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure) = GetLoadAllocationsforLoadPermissionRegistering(AHId, AHSGId)
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = Nothing
                    For Loopx As Int64 = 0 To Lst.Count - 1
                        Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = Lst(Loopx)
                        Try
                            NSSLoadCapacitorLoad = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(Lst(Loopx).nEstelamId)
                            LoadAllocationLoadPermissionRegistering(Lst(Loopx).LAId)
                            If R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 2) Then
                                LoadPermissionPrinting.R2CoreTransportationAndLoadNotificationMClassLoadPermissionPrintingManagement.PrintLoadPermission(Lst(Loopx).LAId)
                                Threading.Thread.Sleep(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting, 0))
                            End If
                        Catch ex As Exception When TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                                              OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                                              OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseTurnIsNotReadyException _
                                              OrElse TypeOf ex Is PresentNotRegisteredInLast30MinuteException _
                                              OrElse TypeOf ex Is PresentsNotEnoughException _
                                              OrElse TypeOf ex Is LoadPermisionRegisteringFailedBecauseBlackListException _
                                              OrElse TypeOf ex Is GetNSSException _
                                              OrElse TypeOf ex Is TimingNotReachedException _
                                              OrElse TypeOf ex Is LoadCapacitorLoadReleaseNotAllowedBecuasenCarNumException _
                                              OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException _
                                              OrElse TypeOf ex Is LoadCapacitorLoadReleaseTimeNotReachedException _
                                              OrElse TypeOf ex Is LoadAllocationLoadPermissionRegisteringNotAllowedBecauseLoadAllocationStatusException _
                                              OrElse TypeOf ex Is LoadAllocationMaxDelayFailedReachedException _
                                              OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                                              OrElse TypeOf ex Is GetNSSException _
                                              OrElse TypeOf ex Is GetDataException _
                                              OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                                              OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException
                            Try
                                If NSSLoadAllocation.LAStatusId <> R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.Failed Then
                                    If R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 2) Then
                                        FailedLoadAllocationPrinting.R2CoreTransportationAndLoadNotificationMClassFailedLoadAllocationAnnouncePrintingManagement.PrintFailedLoadAllocation(Lst(Loopx).LAId)
                                        Threading.Thread.Sleep(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting, 0))
                                    End If
                                End If
                                Lst(Loopx).LANote = ex.Message
                                FailedResultLst.Add(Lst(Loopx))
                            Catch exx As Exception When TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException
                            End Try
                        End Try
                    Next
                Next
                Return FailedResultLst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetLoadAllocationStatuses() As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure)
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocationStatuses Where ViewFlag=1 Order By LoadAllocationStatusId", 3600, DS)
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure(DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusId"), DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusTitle").trim, DS.Tables(0).Rows(Loopx).Item("LoadAllocationStatusColor").trim, DS.Tables(0).Rows(Loopx).Item("ViewFlag")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub IncreasePriority(YourLAId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Dim NSSThisLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(YourLAId)
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(NSSThisLoadAllocation.nEstelamId)
                'آیا زمان تخصیص بار برای زیرگروه سالن مورد نظر فرارسیده است
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.IsTimingActive(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) Then
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.GetTiming(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InLoadAllocationTime Then
                        Throw New TimingNotReachedException
                    End If
                End If
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select Top 1 LoadAllocations.LAId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                        Where LoadAllocations.TurnId=" & NSSThisLoadAllocation.TurnId & " and (LoadAllocations.LAStatusId=1 or LoadAllocations.LAStatusId=3) and LoadAllocations.Priority<" & NSSThisLoadAllocation.Priority & " Order By LoadAllocations.Priority Desc", 0, DS).GetRecordsCount = 0 Then
                    Exit Sub
                Else
                    Dim NSSTargetLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(DS.Tables(0).Rows(0).Item("LAId"))
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set Priority=" & NSSTargetLoadAllocation.Priority & " Where LAId=" & NSSThisLoadAllocation.LAId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set Priority=" & NSSThisLoadAllocation.Priority & " Where LAId=" & NSSTargetLoadAllocation.LAId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                End If
            Catch ex As TimingNotReachedException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub DecreasePriority(YourLAId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Dim NSSThisLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(YourLAId)
                Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(NSSThisLoadAllocation.nEstelamId)
                'آیا زمان تخصیص بار برای زیرگروه سالن مورد نظر فرارسیده است
                If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.IsTimingActive(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) Then
                    If R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement.GetTiming(NSSLoadCapacitorLoad.AHId, NSSLoadCapacitorLoad.AHSGId) <> R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InLoadAllocationTime Then
                        Throw New TimingNotReachedException
                    End If
                End If
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select Top 1 LoadAllocations.LAId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                        Where LoadAllocations.TurnId=" & NSSThisLoadAllocation.TurnId & " and (LoadAllocations.LAStatusId=1 or LoadAllocations.LAStatusId=3) and LoadAllocations.Priority>" & NSSThisLoadAllocation.Priority & " Order By LoadAllocations.Priority Asc", 0, DS).GetRecordsCount = 0 Then
                    Exit Sub
                Else
                    Dim NSSTargetLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = GetNSSLoadAllocation(DS.Tables(0).Rows(0).Item("LAId"))
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set Priority=" & NSSTargetLoadAllocation.Priority & " Where LAId=" & NSSThisLoadAllocation.LAId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set Priority=" & NSSThisLoadAllocation.Priority & " Where LAId=" & NSSTargetLoadAllocation.LAId & ""
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                End If
            Catch ex As TimingNotReachedException
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub RePrioritize(YourNSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                Dim DS As DataSet
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                       "Select LoadAllocations.LAId from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocations
                        Where LoadAllocations.TurnId=" & YourNSSTurn.nEnterExitId & " and (LoadAllocations.LAStatusId=1 or LoadAllocations.LAStatusId=3) Order By LoadAllocations.Priority Asc", 0, DS)
                CmdSql.Connection.Open()
                CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    CmdSql.CommandText = "Update R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations Set Priority=" & Loopx + 1 & " Where LAId=" & DS.Tables(0).Rows(Loopx).Item("LAId") & ""
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


    End Class

    Namespace FailedLoadAllocationPrinting

        Public Structure R2CoreTransportationAndLoadNotificationFailedLoadAllocationPrintingInf
            Dim LoadAllocationId As Int64
            Dim nEstelamId As Int64
            Dim TurnId As Int64
            Dim TransportCompany As String
            Dim TruckLP As String
            Dim TruckLPSerial As String
            Dim TruckDriver As String
            Dim GoodName As String
            Dim TargetCity As String
            Dim OtherNote As String
        End Structure

        Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassFailedLoadAllocationAnnouncePrintingManagement

            Private Shared WithEvents _PrintDocumentFailedLoadAllocation As PrintDocument = New PrintDocument()
            Private Shared _PPDS As R2CoreTransportationAndLoadNotificationFailedLoadAllocationPrintingInf

            Private Shared Function GetFailedLoadAllocationPrintingInf(YourLoadAllocationId As Int64) As R2CoreTransportationAndLoadNotificationFailedLoadAllocationPrintingInf
                Try
                    Dim DS As DataSet
                    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                          "Select LoadAllocation.LAId,LoadAllocation.nEstelamId,Cast(Substring(EnterExit.OtaghdarTurnNumber,7,20) as int) as TurnId,TransportCompany.TCTitle,Car.strCarNo as Truck,Car.strCarSerialNo as TruckSerial,Person.strPersonFullName,Product.strGoodName,CityTarget.strCityName as TargetCity,LoadAllocation.LANote
                           from R2PrimaryTransportationAndLoadNotification.dbo.TblLoadAllocations as LoadAllocation
                                Inner Join dbtransport.dbo.tbEnterExit as EnterExit On LoadAllocation.TurnId=EnterExit.nEnterExitId
                                Inner Join dbtransport.dbo.tbElam as Elam On LoadAllocation.nEstelamId=Elam.nEstelamID
                                Inner Join R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompany On Elam.nCompCode=TransportCompany.TCId
                                Inner Join dbtransport.dbo.TbCar as Car On EnterExit.strCardno=Car.nIDCar 
								Inner Join dbtransport.dbo.TbPerson as Person On EnterExit.nDriverCode=Person.nIDPerson
                                Inner Join dbtransport.dbo.tbProducts as Product On Elam.nBarcode=Product.strGoodCode
                                Inner Join dbtransport.dbo.tbCity as CityTarget On Elam.nCityCode=CityTarget.nCityCode
                           Where LoadAllocation.LAId=" & YourLoadAllocationId & "", 1, DS)
                    Dim FailedLoadAllocationPrintingInf As New R2CoreTransportationAndLoadNotificationFailedLoadAllocationPrintingInf()
                    FailedLoadAllocationPrintingInf.LoadAllocationId = DS.Tables(0).Rows(0).Item("LAId")
                    FailedLoadAllocationPrintingInf.nEstelamId = DS.Tables(0).Rows(0).Item("nEstelamId")
                    FailedLoadAllocationPrintingInf.TurnId = DS.Tables(0).Rows(0).Item("TurnId")
                    FailedLoadAllocationPrintingInf.TransportCompany = DS.Tables(0).Rows(0).Item("TCTitle").trim
                    FailedLoadAllocationPrintingInf.TruckLP = DS.Tables(0).Rows(0).Item("Truck").trim
                    FailedLoadAllocationPrintingInf.TruckLPSerial = DS.Tables(0).Rows(0).Item("TruckSerial").trim
                    FailedLoadAllocationPrintingInf.TruckDriver = DS.Tables(0).Rows(0).Item("strPersonFullName").trim
                    FailedLoadAllocationPrintingInf.GoodName = DS.Tables(0).Rows(0).Item("strGoodName").trim
                    FailedLoadAllocationPrintingInf.TargetCity = DS.Tables(0).Rows(0).Item("TargetCity").trim
                    FailedLoadAllocationPrintingInf.OtherNote = DS.Tables(0).Rows(0).Item("LANote").trim
                    Return FailedLoadAllocationPrintingInf
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Function

            Public Shared Sub PrintFailedLoadAllocation(YourLoadAllocationId As Int64)
                Try
                    _PPDS = GetFailedLoadAllocationPrintingInf(YourLoadAllocationId)
                    'چاپ مجوز
                    Dim NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId)
                    Dim ComposeSearchString As String = NSSLoadCapacitorLoad.AHSGId.ToString + "="
                    Dim AllAnnouncementHallPrinters As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, NSSLoadCapacitorLoad.AHId, 3), "-")
                    Dim AnnouncementHallSubGroupPrinter As String = Mid(AllAnnouncementHallPrinters.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllAnnouncementHallPrinters.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length)
                    _PrintDocumentFailedLoadAllocation.PrinterSettings.PrinterName = AnnouncementHallSubGroupPrinter.Trim
                    _PrintDocumentFailedLoadAllocation.DefaultPageSettings.PaperSize = _PrintDocumentFailedLoadAllocation.PrinterSettings.PaperSizes(4)
                    _PrintDocumentFailedLoadAllocation.DefaultPageSettings.PaperSource = _PrintDocumentFailedLoadAllocation.PrinterSettings.PaperSources(2)
                    _PrintDocumentFailedLoadAllocation.Print()
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentFailedLoadAllocation_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentFailedLoadAllocation.BeginPrint
            End Sub

            Private Shared Sub _PrintDocumentFailedLoadAllocation_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentFailedLoadAllocation.EndPrint
            End Sub

            Private Shared Sub A4Printing(ByVal YourEventArgs As System.Drawing.Printing.PrintPageEventArgs, ByVal X As Int16, ByVal Y As Int16)
                Try
                    Dim myPaperSizeHalf As Integer = _PrintDocumentFailedLoadAllocation.PrinterSettings.DefaultPageSettings.PaperSize.Width / 2
                    Dim myStrFontSuperMax As Font = New System.Drawing.Font("Badr", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                    YourEventArgs.Graphics.DrawString("گواهی عدم صدور مجوز بارگيری", myStrFontMax, Brushes.DarkBlue, myPaperSizeHalf - (New Size(TextRenderer.MeasureText("گواهی عدم صدور مجوز بارگيری", myStrFontMax))).Width / 2, Y)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, myPaperSizeHalf - (New Size(TextRenderer.MeasureText(_PPDS.TruckDriver, myStrFontSuperMax))).Width / 2, Y + 20)
                    Dim a As Char()
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 20, Y + 60)
                        a = _PPDS.TruckLP.ToCharArray()
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 50, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 60, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 70, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 80, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 90, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(2), myStrFontMax, Brushes.DarkBlue, X + 100, Y + 60)
                    End If
                    YourEventArgs.Graphics.DrawString(_PPDS.OtherNote, myStrFontMax, Brushes.DarkBlue, myPaperSizeHalf - (New Size(TextRenderer.MeasureText(_PPDS.OtherNote, myStrFontMax))).Width / 2, Y + 100)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 120)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 140)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 140)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 450, Y + 160)
                    YourEventArgs.Graphics.DrawString("کد مخزن بار: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 300, Y + 160)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 150, Y + 160)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub A5Printing(ByVal YourEventArgs As System.Drawing.Printing.PrintPageEventArgs, ByVal X As Int16, ByVal Y As Int16)
                Try
                    Dim myPaperSizeHalf As Integer = _PrintDocumentFailedLoadAllocation.PrinterSettings.DefaultPageSettings.PaperSize.Width / 2
                    Dim myStrFontSuperMax As Font = New System.Drawing.Font("Badr", 18, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                    Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
                    YourEventArgs.Graphics.DrawString("گواهی عدم صدور مجوز بارگيری", myStrFontMax, Brushes.DarkBlue, X + 160, Y)
                    YourEventArgs.Graphics.DrawString(_PPDS.TruckDriver, myStrFontSuperMax, Brushes.DarkBlue, X + 100, Y + 20)
                    Dim a As Char()
                    If _PPDS.TruckLP.Trim <> String.Empty Then
                        YourEventArgs.Graphics.DrawString(_PPDS.TruckLPSerial + "-", myStrFontMax, Brushes.DarkBlue, X + 20, Y + 60)
                        a = _PPDS.TruckLP.ToCharArray()
                        YourEventArgs.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 50, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 60, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 70, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 80, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 90, Y + 60)
                        YourEventArgs.Graphics.DrawString(a(2), myStrFontMax, Brushes.DarkBlue, X + 100, Y + 60)
                    End If
                    YourEventArgs.Graphics.DrawString(_PPDS.OtherNote, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 100)
                    YourEventArgs.Graphics.DrawString("شرکت/موسسه محترم: " + _PPDS.TransportCompany, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 120)
                    YourEventArgs.Graphics.DrawString(" جهت حمل " + _PPDS.GoodName, myStrFontMax, Brushes.DarkBlue, X + 250, Y + 140)
                    YourEventArgs.Graphics.DrawString(" به مقصد " + _PPDS.TargetCity, myStrFontMax, Brushes.DarkBlue, X + 20, Y + 140)
                    YourEventArgs.Graphics.DrawString(" شماره تخصيص: " + _PPDS.LoadAllocationId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 330, Y + 160)
                    YourEventArgs.Graphics.DrawString("کد مخزن بار: " + _PPDS.nEstelamId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 180, Y + 160)
                    YourEventArgs.Graphics.DrawString(" شماره نوبت: " + _PPDS.TurnId.ToString(), myStrFontMax, Brushes.DarkBlue, X + 30, Y + 160)
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentFailedLoadAllocation_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
                Try
                    Dim ConfiguredPageType As String = R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadPermissionsSetting, R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(_PPDS.nEstelamId).AHId, 0)
                    If [Enum].Parse(GetType(System.Drawing.Printing.PaperKind), ConfiguredPageType) = System.Drawing.Printing.PaperKind.A5 Then
                        A5Printing(E, 15, 20)
                    ElseIf [Enum].Parse(GetType(System.Drawing.Printing.PaperKind), ConfiguredPageType) = System.Drawing.Printing.PaperKind.A4 Then
                        A4Printing(E, 50, 80)
                    End If
                Catch ex As Exception
                    Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

            Private Shared Sub _PrintDocumentFailedLoadAllocation_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentFailedLoadAllocation.PrintPage
                Try
                    _PrintDocumentFailedLoadAllocation_PrintPage_Printing(0, 0, e)
                Catch ex As Exception
                    MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
                End Try
            End Sub

        End Class

    End Namespace

    Namespace Exceptions

        Public Class TimingNotReachedException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "انجام این فرآیند تا لحظاتی دیگر امکان پذیر نیست"
                End Get
            End Property
        End Class

        Public Class LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان تخصیص بار به دلیل وضعیت فعلی نوبت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان تخصیص بار به دلیل وضعیت فعلی بار وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadAllocationNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "سابقه تخصیص بار با مشخصات مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class LoadAllocationStatusNotFoundException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "وضعیت تخصیص بار با کدشاخص مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کنسلی تخصیص بار با توجه به وضعیت فعلی تخصیص امکان پذیر نیست"
                End Get
            End Property
        End Class

        Public Class LoadAllocationLoadPermissionRegisteringNotAllowedBecauseLoadAllocationStatusException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "صدور مجوز برای تخصیص بار با توجه به وضعیت فعلی تخصیص بارامکان پذیر نیست"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "امکان تخصیص بار به نوبت مورد نظر به دلیل عدم تطابق تسلسل نوبت وجود ندارد"
                End Get
            End Property
        End Class

        Public Class LoadAllocationMaxDelayFailedReachedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "زمان موردنظر برای صدورمجوز این تخصیص به پایان رسیده است"
                End Get
            End Property
        End Class

        Public Class LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "مشخصات ناوگان با بار انتخاب شده تطابق ندارد"
                End Get
            End Property
        End Class

        Public Class RegisteredLoadAllocationIsRepetitiousException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "تخصیص مورد نظر تکراری است"
                End Get
            End Property
        End Class

        Public Class LoadAllocationMaximumAllowedNumberReachedException
            Inherits ApplicationException

            Public Overrides ReadOnly Property Message As String
                Get
                    Return "سقف تعداد تخصیص کامل شده است"
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
        End Sub

        Public Sub New(ByVal YourGoodId As Int64, ByVal YourGoodName As String)
            MyBase.New(YourGoodId, YourGoodName)
            _GoodId = YourGoodId
            _GoodName = YourGoodName
        End Sub

        Public Property GoodId As Int64
        Public Property GoodName() As String
    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassGoodsManagement
        Public Shared Function GetNSSGood(YourGoodId As Int64) As R2CoreTransportationAndLoadNotificationStandardGoodStructure
            Try
                Dim Ds As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select Top 1 * from dbtransport.dbo.TbProducts Where StrGoodCode=" & YourGoodId & "", 3600, Ds).GetRecordsCount() = 0 Then Throw New GoodNotFoundException
                Dim NSS As R2CoreTransportationAndLoadNotificationStandardGoodStructure = New R2CoreTransportationAndLoadNotificationStandardGoodStructure(Ds.Tables(0).Rows(0).Item("StrGoodCode"), Ds.Tables(0).Rows(0).Item("StrGoodName").TRIM)
                Return NSS
            Catch exx As GoodNotFoundException
                Throw exx
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetGoods_SearchIntroCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select StrGoodCode,StrGoodName From DBTransport.dbo.TbProducts Where StrGoodName Like '%" & YourSearchString & "%' Order By StrGoodName", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardGoodStructure(DS.Tables(0).Rows(Loopx).Item("StrGoodCode"), DS.Tables(0).Rows(Loopx).Item("StrGoodName")))
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetGoods_SearchforLeftCharacters(YourSearchString As String) As List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
            Try
                Dim Lst As New List(Of R2CoreTransportationAndLoadNotificationStandardGoodStructure)
                Dim DS As DataSet = Nothing
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select StrGoodCode,StrGoodName From DBTransport.dbo.TbProducts Where Left(StrGoodName," & YourSearchString.Length & ")='" & YourSearchString & "' Order By StrGoodName", 3600, DS)
                For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                    Lst.Add(New R2CoreTransportationAndLoadNotificationStandardGoodStructure(DS.Tables(0).Rows(Loopx).Item("StrGoodCode"), DS.Tables(0).Rows(Loopx).Item("StrGoodName")))
                Next
                Return Lst
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
        Inherits R2CoreProcesses

        Public Shared ReadOnly FrmcLoadPermissions As Int64 = 24
        Public Shared ReadOnly FrmcLoadCapacitor As Int64 = 44
        Public Shared ReadOnly FrmcLoadAllocations As Int64 = 45


    End Class




End Namespace

Namespace LoadSedimentation

    Public Class R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure

        Public Sub New()
            MyBase.New()
            _SedimentingStartTime = Nothing
            _SedimentingEndTime = Nothing
            _SedimentingDelationMinutes = Long.MinValue
            _SedimentingActive = False
        End Sub

        Public Sub New(ByVal YourSedimentingStartTime As R2StandardDateAndTimeStructure, YourSedimentingEndTime As R2StandardDateAndTimeStructure, YourSedimentingDelationMinutes As Int64, YourSedimentingActive As Boolean)
            _SedimentingStartTime = YourSedimentingStartTime
            _SedimentingEndTime = YourSedimentingEndTime
            _SedimentingDelationMinutes = YourSedimentingDelationMinutes
            _SedimentingActive = YourSedimentingActive
        End Sub


        Public Property SedimentingStartTime As R2StandardDateAndTimeStructure
        Public Property SedimentingEndTime As R2StandardDateAndTimeStructure
        Public Property SedimentingDelationMinutes As Int64
        Public Property SedimentingActive As Boolean
    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassLoadSedimentationManagement
        Private Shared _DateTime As New R2DateTime

        Private Shared Function GetNSSLoadSedimentingConfigurations(YourAHId As Int64, YourAHSGId As Int64) As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure)
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllSedimentingTimesofAnnouncementHall As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadSedimentationSetting, YourAHId), "&")
                Dim AllSedimentingTimesofAnnouncementHallSubGroup = Split(Mid(AllSedimentingTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllSedimentingTimesofAnnouncementHall.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), "-")
                Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure) = New List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure)
                For Loopx As Int32 = 0 To AllSedimentingTimesofAnnouncementHallSubGroup.Count - 1
                    Dim AllSetting As String() = Split(AllSedimentingTimesofAnnouncementHallSubGroup(Loopx), ";")
                    Dim NSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure = New R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure
                    NSS.SedimentingStartTime = New R2StandardDateAndTimeStructure(Nothing, Nothing, AllSetting(0))
                    NSS.SedimentingEndTime = New R2StandardDateAndTimeStructure(Nothing, Nothing, AllSetting(1))
                    NSS.SedimentingDelationMinutes = AllSetting(2)
                    NSS.SedimentingActive = AllSetting(3)
                    Lst.Add(NSS)
                Next
                Return Lst
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Function GetNSSLastSedimentingConfiguration(YourAHId As Int64, YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure
            Try
                Dim CurrentTime As String = _DateTime.GetCurrentTime()
                Dim SedimentingConfigurations As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure) = GetNSSLoadSedimentingConfigurations(YourAHId, YourAHSGId)
                If CurrentTime < SedimentingConfigurations(0).SedimentingStartTime.Time Then Return Nothing
                If CurrentTime >= SedimentingConfigurations(SedimentingConfigurations.Count - 1).SedimentingStartTime.Time Then Return SedimentingConfigurations(SedimentingConfigurations.Count - 1)
                For Loopx As Int64 = 0 To SedimentingConfigurations.Count - 1
                    If Loopx < SedimentingConfigurations.Count - 1 Then
                        If CurrentTime >= SedimentingConfigurations(Loopx).SedimentingStartTime.Time And CurrentTime < SedimentingConfigurations(Loopx + 1).SedimentingStartTime.Time Then Return SedimentingConfigurations(Loopx)
                    Else
                        Throw New Exception("تنظیمات زمان رسوب بار را در پیکربندی سیستم کنترل نمایید")
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Sub SedimentingAllOfLoadCapacitorLoads(YourAHId As Int64, YourAHSGId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                'لیست کامل باری که باید رسوب گردد
                Dim Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLoadCapacitorLoads(YourAHId, YourAHSGId, AnnouncementHalls.AnnouncementHallAnnounceTimeTypes.LastAnnounceLoads, True, True, R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nEstelamId)
                'باری برای رسوب وجود ندارد
                If IsNothing(Lst) Or Lst.Count = 0 Then Return

                Dim LastAnnounceTime As String = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncemenetHallLastAnnounceTime(YourAHId, YourAHSGId).Time
                CmdSql.CommandText = "Update dbtransport.dbo.tbElam Set bFlag=1,LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " 
                                       Where (dDateElam='" & _DateTime.GetCurrentDateShamsiFull & "') and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & " and AHId=" & YourAHId & " and AHSGId=" & YourAHSGId & " and (dTimeElam<='" & LastAnnounceTime & "')"
                CmdSql.Connection.Open()
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()

                For Each LoadCapcitorLoad In Lst
                    R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(LoadCapcitorLoad.nEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Sedimenting, 1, Nothing, Nothing, Nothing, Nothing))
                Next
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Private Shared Sub SedimentingLoadCapacitorLoads(YourAHId As Int64, YourAHSGId As Int64)
            Try
                Dim CurrentTime As String = _DateTime.GetCurrentTime()
                Dim LastSedimentingConfiguration As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupSedimentingConfigurationStructure = GetNSSLastSedimentingConfiguration(YourAHId, YourAHSGId)
                If IsNothing(LastSedimentingConfiguration) Then Return
                If Not LastSedimentingConfiguration.SedimentingActive Then Return
                If CurrentTime >= LastSedimentingConfiguration.SedimentingEndTime.Time Then
                    SedimentingAllOfLoadCapacitorLoads(YourAHId, YourAHSGId)
                Else
                    If CurrentTime < LastSedimentingConfiguration.SedimentingStartTime.Time Then Return
                    Dim FinalLoadPermission = LoadPermission.R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.GetNSSFinalLoadPermission(YourAHId, YourAHSGId)
                    Dim DateTime2 As DateTime = Convert.ToDateTime(CurrentTime)
                    Dim DateTime1 As DateTime
                    If IsNothing(FinalLoadPermission) Then
                        DateTime1 = Convert.ToDateTime(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncemenetHallLastAnnounceTime(YourAHId, YourAHSGId).Time)
                    Else
                        DateTime1 = Convert.ToDateTime(FinalLoadPermission.LoadPermissionTime)
                    End If
                    If DateDiff(DateInterval.Minute, DateTime1, DateTime2) >= LastSedimentingConfiguration.SedimentingDelationMinutes Then SedimentingAllOfLoadCapacitorLoads(YourAHId, YourAHSGId)
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SedimentingProcess()
            Try
                Dim Lst = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallsAnnouncementHallSubGroupsJOINT()
                For Each C In Lst
                    Try
                        SedimentingLoadCapacitorLoads(C.NSSAnnounementHall.AHId, C.NSSAnnouncementHallSubGroup.AHSGId)
                    Catch ex As Exception
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(Nothing, R2CoreTransportationAndLoadNotification.Logging.R2CoreTransportationAndLoadNotificationLogType.LoadCapacitorSedimentingFailed, ex.Message, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, Nothing, Nothing, Nothing))
                    End Try
                Next
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Sub SedimentingLoadCapacitorLoad(YournEstelamId As Int64)
            Dim CmdSql As New SqlClient.SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
                CmdSql.CommandText = "Update dbtransport.dbo.tbElam Set bFlag=1,LoadStatus=" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " 
                                       Where (nEstelamId=" & YournEstelamId & ") and (LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Sedimented & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Deleted & " and LoadStatus<>" & R2CoreTransportationAndLoadNotificationLoadCapacitorLoadStatuses.Cancelled & ")"
                CmdSql.Connection.Open()
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.InsertAccounting(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure(YournEstelamId, R2CoreTransportationAndLoadNotificationLoadCapacitorAccountingTypes.Sedimenting, 1, Nothing, Nothing, Nothing, Nothing))
            Catch ex As LoadCapacitorLoadNotFoundException
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw ex
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub


    End Class


End Namespace

Namespace EntityRelations

    Public MustInherit Class R2CoreTransportationAndLoadNotificationEntityRelationTypes
        Inherits R2Core.EntityRelations.R2CoreEntityRelationTypes
        Public Shared ReadOnly Turn_TurnRegisterRequest As Int64 = 1
    End Class

End Namespace

Namespace AnnouncementTiming

    Public Enum R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming
        None = 0
        StartAutoProcess = 1
        InLoadAllocationTime = 2
        StartLoadPermissionProcess = 3
        IdleTime = 4
    End Enum

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassAnnouncementTimingManagement
        Private Shared _DateTime As New R2DateTime


        Public Shared Function IsTimingActive(YourAHId As Int64, YourAHSGId As Int64) As Boolean
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllAnnouncementHallsAutomaticProcessesTiming As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsAutomaticProcessesTiming, YourAHId), ";")
                Dim AllAnnouncementHallsAutomaticProcessesTimingSubGroup As String = AllAnnouncementHallsAutomaticProcessesTiming.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0)
                Return Split(AllAnnouncementHallsAutomaticProcessesTimingSubGroup, "=")(1).Split(":")(0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetTiming(YourAHId As Int64, YourAHSGId As Int64) As R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming
            Try
                Dim ComposeSearchString As String = YourAHSGId.ToString + "="
                Dim AllAnnouncementHallsAutomaticProcessesTiming As String() = Split(R2CoreTransportationAndLoadNotificationMClassConfigurationOfAnnouncementHallsManagement.GetConfigString(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsAutomaticProcessesTiming, YourAHId), ";")
                Dim AllAnnouncementHallsAutomaticProcessesTimingSubGroup As String = AllAnnouncementHallsAutomaticProcessesTiming.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0)
                Dim TruckDriverLoadAllocationTiming As Int64 = Split(AllAnnouncementHallsAutomaticProcessesTimingSubGroup, "=")(1).Split(":")(1)
                Dim LoadPermissionsAutomaticJobTiming As Int64 = Split(AllAnnouncementHallsAutomaticProcessesTimingSubGroup, "=")(1).Split(":")(2)
                Dim GetAnnouncemenetHallFirstAnnounceTime As String = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallFirstAnnounceTime(YourAHId, YourAHSGId).Time
                Dim O1 As TimeSpan = TimeSpan.Parse(_DateTime.GetCurrentTime())
                Dim O2 As TimeSpan = TimeSpan.Parse(GetAnnouncemenetHallFirstAnnounceTime)
                If O1.TotalSeconds < O2.TotalSeconds Then Return R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.None
                Dim O As TimeSpan = O1.Subtract(O2)

                Dim SliceComplete As Int64 = (TruckDriverLoadAllocationTiming + LoadPermissionsAutomaticJobTiming) * 60
                Dim SliceTruckDriverLoadAllocationTiming As Int64 = TruckDriverLoadAllocationTiming * 60

                Dim R As Int64 = O.TotalSeconds Mod SliceComplete
                If R >= 0 And R <= 5 Then Return R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.StartAutoProcess
                If R > 5 And R <= SliceTruckDriverLoadAllocationTiming Then Return R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.InLoadAllocationTime
                If R > SliceTruckDriverLoadAllocationTiming And R <= SliceTruckDriverLoadAllocationTiming + 5 Then Return R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.StartLoadPermissionProcess
                If R > SliceTruckDriverLoadAllocationTiming + 5 And R <= SliceComplete Then Return R2CoreTransportationAndLoadNotificationVirtualAnnouncementTiming.IdleTime

            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function
    End Class


End Namespace

Namespace MobileUsers

    Public Class R2CoreTransportationAndLoadNotificationStandardMobileUserStructure
        Inherits R2StandardStructure

        Public Sub New()
            MyBase.New()
            _MUId = Int64.MinValue
            _MUNameFamily = String.Empty
            _MUMobileNumber = String.Empty
            _MUStatus = Int16.MinValue
            _VerificationCode = String.Empty
            _DateTimeMilladi = Now.Date
            _DateShamsi = String.Empty
            _ViewFlag = Boolean.FalseString
            _Active = Boolean.FalseString
            _Deleted = Boolean.FalseString
        End Sub

        Public Sub New(YourMUId As Int64, YourMUNameFamily As String, YourMUMobileNumber As String, YourMUStatus As String, YourVerificationCode As String, YourDateTimeMilladi As DateTime, YourDateShamsi As String, YourViewFlag As Boolean, YourActive As Boolean, YourDeleted As Boolean)
            MyBase.New(YourMUId, YourMUNameFamily)
            _MUId = YourMUId
            _MUNameFamily = YourMUNameFamily
            _MUMobileNumber = YourMUMobileNumber
            _MUStatus = YourMUStatus
            _VerificationCode = YourVerificationCode
            _DateTimeMilladi = YourDateTimeMilladi
            _DateShamsi = YourDateShamsi
            _ViewFlag = YourViewFlag
            _Active = YourActive
            _Deleted = YourDeleted
        End Sub

        Public Property MUId As Int64
        Public Property MUNameFamily As String
        Public Property MUMobileNumber As String
        Public Property MUStatus As String
        Public Property VerificationCode As String
        Public Property DateTimeMilladi As DateTime
        Public Property DateShamsi As String
        Public Property ViewFlag As Boolean
        Public Property Active As Boolean
        Public Property Deleted As Boolean

    End Class

    Public NotInheritable Class R2CoreTransportationAndLoadNotificationMClassMobileUsersManagement
        Private Shared _DateTime As New R2DateTime

        Private Shared Function GetRandomVerificationCode() As Int64
            Try
                Dim RandGen As New Random
                Return RandGen.Next(10000, 100000)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function GetNSSMobileUser(YourMUId As Int64) As R2CoreTransportationAndLoadNotificationStandardMobileUserStructure
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMobileUsers as MUs Where MUs.MUId=" & YourMUId & "", 1, DS).GetRecordsCount() = 0 Then Throw New MobileUserNotFoundException
                Return New R2CoreTransportationAndLoadNotificationStandardMobileUserStructure(DS.Tables(0).Rows(0).Item("MUId"), DS.Tables(0).Rows(0).Item("MUNameFamily").trim, DS.Tables(0).Rows(0).Item("MUMobileNumber").trim, DS.Tables(0).Rows(0).Item("MUStatus").trim, DS.Tables(0).Rows(0).Item("VerificationCode").trim, DS.Tables(0).Rows(0).Item("DateTimeMilladi"), DS.Tables(0).Rows(0).Item("DateShamsi"), DS.Tables(0).Rows(0).Item("ViewFlag"), DS.Tables(0).Rows(0).Item("Active"), DS.Tables(0).Rows(0).Item("Deleted"))
            Catch ex As MobileUserNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function ExistMobileUser(YourMobileNumber As String) As Boolean
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMobileUsers as MUs Where MUs.MUMobileNumber='" & YourMobileNumber.Trim & "'", 1, DS).GetRecordsCount() = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Function MobileUserMatching(YourMobileNumber As String, YourVerificationCode As String) As Int64
            Try
                Dim DS As DataSet
                If R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblMobileUsers as MUs Where VerificationCode='" & YourVerificationCode & "' and MUMobileNumber='" & YourMobileNumber & "'", 1, DS).GetRecordsCount() = 0 Then Throw New MobileUserNotMatchException
                Return DS.Tables(0).Rows(0).Item("MUId")
            Catch ex As MobileUserNotMatchException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Private Shared Function InsertMobileUserFirstTime(YourMobileNumber As String, YourNameFamily As String) As String
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim VerificationCode = GetRandomVerificationCode()
                If ExistMobileUser(YourMobileNumber) Then
                    CmdSql.Connection.Open()
                    CmdSql.CommandText = "Update R2Primary.dbo.TblMobileUsers Set VerificationCode='" & VerificationCode.ToString & "' Where MUMobileNumber='" & YourMobileNumber & "'"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Connection.Close()
                Else
                    CmdSql.Connection.Open()
                    CmdSql.Transaction = CmdSql.Connection.BeginTransaction
                    CmdSql.CommandText = "Select top 1 MUId from R2Primary.dbo.TblMobileUsers with (tablockx) order by MUId desc"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.CommandText = "Select IDENT_CURRENT('R2Primary.dbo.TblMobileUsers')"
                    Dim myMUId As Int64 = CmdSql.ExecuteScalar + 1
                    CmdSql.CommandText = "Insert Into R2Primary.dbo.TblMobileUsers(MUNameFamily,MUMobileNumber,MUStatus,VerificationCode,DateTimeMilladi,DateShamsi,ViewFlag,Active,Deleted) Values('" & YourNameFamily & "','" & YourMobileNumber & "','logout','" & VerificationCode & "','" & _DateTime.GetCurrentDateTimeMilladiFormated() & "','" & _DateTime.GetCurrentDateShamsiFull() & "',1,0,0)"
                    CmdSql.ExecuteNonQuery()
                    CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
                End If
                Return VerificationCode
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then
                    CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
                End If
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Function RegisterMobileUser(YourMobileNumber As String, YourNameFamily As String) As String
            Try
                Dim VerificationCode As String
                If R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.IsExistTruckDriver(YourMobileNumber) Then
                    VerificationCode = InsertMobileUserFirstTime(YourMobileNumber, YourNameFamily)
                    Dim SMSSender As New R2CoreSMS.SMSSendAndRecieved.R2CoreSMSSendRecive
                    SMSSender.SendSms(New R2CoreSMS.SMSSendAndRecieved.R2CoreSMSStandardSmsStructure(Nothing, YourMobileNumber, VerificationCode, 1, Nothing, 1, Nothing, Nothing))
                    'Return VerificationCode
                Else
                    Throw New TruckDriverMobileNumberNotFoundException
                End If
            Catch ex As TruckDriverMobileNumberNotFoundException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

        Public Shared Sub UnRegisterMobileUser(YourMUId As Int64)
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblMobileUsers Set MUStatus='logout',VerificationCode='',Active=0 Where MUId=" & YourMUId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
            Catch ex As Exception
                If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Sub

        Public Shared Function ActiveMobileUser(YourMobileNumber As String, YourVerificationCode As String) As Int64
            Dim CmdSql As New SqlCommand
            CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
            Try
                Dim MUId = MobileUserMatching(YourMobileNumber, YourVerificationCode)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update R2Primary.dbo.TblMobileUsers Set MUStatus='login',Active=1 Where MUId=" & MUId & ""
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                Return MUId
            Catch ex As MobileUserNotMatchException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Function

    End Class

    Namespace Exeptions

        Public Class MobileUserNotMatchException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کد تبادل نادرست است"
                End Get
            End Property
        End Class

        Public Class MobileUserNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "کاربر با شماره موبایل مورد نظر یافت نشد"
                End Get
            End Property
        End Class

        Public Class TruckDriverMobileNumberNotFoundException
            Inherits ApplicationException
            Public Overrides ReadOnly Property Message As String
                Get
                    Return "شماره موبایل مورد نظر در سامانه موجود نیست"
                End Get
            End Property
        End Class

    End Namespace


End Namespace













