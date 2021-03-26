Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.PayanehWS
Imports PayanehClassLibrary.Rmto
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.EntityRelationManagement
Imports R2Core.PermissionManagement
Imports R2Core.SecurityAlgorithmsManagement.Hashing
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.EntityRelations
Imports R2CoreParkingSystem.SoftwareUsersManagement
Imports R2CoreTransportationAndLoadNotification
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControl
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadOtherThanManipulation
Imports R2CoreTransportationAndLoadNotification.LoadSedimentation
Imports R2CoreTransportationAndLoadNotification.RequesterManagement
Imports R2CoreTransportationAndLoadNotification.Rmto
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class Form3
    Private _DateTime As R2DateTime = New R2DateTime

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'R2CoreMClassSoftwareUsersManagement.SetCurrentUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
            R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.TransferringTommorowLoads()
            'PayanehClassLibrary.Rmto.RmtoWebService.GetInf(RmtoWebService.InfoType.GET_DRIVER_BY_SHC, "1222524")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
        Try
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New SqlClient.SqlCommand("Select * from  R2PrimaryParkingSystem.dbo.TblEntryExit as EntryExit
                                                            Inner Join (Select Distinct CardNo from R2Primary.dbo.TblRFIDCards  Where CardType=2 or CardType=3) as RFIDCards On EntryExit.CardNoEnter=RFIDCards.CardNo
                                                         Where EntryExit.DateShamsiExit>='1398/03/01' and EntryExit.DateShamsiExit<='1398/03/02'
                                                         Order By CardNoEnter,DateTimeMilladiEnter")
            Da.SelectCommand.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
            Da.Fill(Ds)

            Dim myIndex As Int64 = 0
            CmdSql.Connection.Open()
            CmdSql.Transaction = CmdSql.Connection.BeginTransaction
            Do While myIndex <= Ds.Tables(0).Rows.Count - 1
                Dim myMainDataRow As DataRow = Ds.Tables(0).Rows(myIndex)
                Dim myIndex2 As Int64 = myIndex + 1 : If myIndex2 > Ds.Tables(0).Rows.Count - 1 Then Exit Do
                Do While 3 = 3
                    Dim myIndex2DataRow As DataRow = Ds.Tables(0).Rows(myIndex2)
                    If (myIndex2DataRow.Item("CardNoEnter") <> myMainDataRow.Item("CardNoEnter")) Or (myIndex2DataRow.Item("MblghEnter") <> 0) Then
                        CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblEnterExits(CardEnter,DEnter,DExit,Mblgh) Values('" & myMainDataRow.Item("CardNoEnter") & "','" & Convert.ToDateTime(myMainDataRow.Item("DateTimeMilladiEnter")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & Convert.ToDateTime(Ds.Tables(0).Rows(myIndex2 - 1).Item("DateTimeMilladiExit")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "'," & Convert.ToInt64(Ds.Tables(0).Rows(myIndex2 - 1).Item("MblghExit")) & ")"
                        CmdSql.ExecuteNonQuery()
                        myIndex = myIndex2
                        Exit Do
                    End If
                    myIndex2 += 1
                    If myIndex2 > Ds.Tables(0).Rows.Count - 1 Then
                        myIndex = myIndex2
                        Exit Do
                    End If
                Loop
            Loop
            CmdSql.Transaction.Commit() : CmdSql.Connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
            If CmdSql.Connection.State <> ConnectionState.Closed Then
                CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
        Try
            Dim myReport As StringBuilder = New StringBuilder
            'به دست آوردن لیست تمام کارت هایی که در رنج مورد نظر خروج شده اند
            Dim DaRFIDCards As New SqlClient.SqlDataAdapter : Dim DsRFIDCards As New DataSet
            DaRFIDCards.SelectCommand = New SqlCommand(
                       "Select Distinct Accounting.CardId from R2Primary.dbo.TblAccounting as Accounting 
                              Inner Join (Select CardId from R2Primary.dbo.TblRFIDCards Where " & TextBoxTerraficCardTypeSqlString.Text.Trim() & ") as RFIDCards On Accounting.CardId=RFIDCards.CardId 
                              Where Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','') >= '" & TextBoxConcat1.Text & "'  and   Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','') <= '" & TextBoxConcat2.Text & "' and Accounting.EEAccountingProcessType=2 Order By Accounting.CardId")
            DaRFIDCards.SelectCommand.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
            DsRFIDCards.Tables.Clear()
            DaRFIDCards.Fill(DsRFIDCards)

            'به دست آوردن لیست اکانتینگ تردد برای هر کارت و ذخیره آن در جدول
            CmdSql.Connection.Open()
            CmdSql.Transaction = CmdSql.Connection.BeginTransaction
            CmdSql.CommandText = "Delete R2PrimarySMSSystem.dbo.TblEnterExits" : CmdSql.ExecuteNonQuery()
            Dim DaCalc As New SqlDataAdapter : Dim DsCalc As New DataSet
            DaCalc.SelectCommand = New SqlCommand(String.Empty, (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection)
            For LoopRFIDCards As Int64 = 0 To DsRFIDCards.Tables(0).Rows.Count - 1
                Dim myCardId As Int64 = DsRFIDCards.Tables(0).Rows(LoopRFIDCards).Item("CardId")
                'آخرین خروج ماه
                Dim myLeastExit As String
                Try
                    DaCalc.SelectCommand.CommandText =
                        "Select Top 1 Accounting.DateShamsiA,Accounting.TimeA from R2Primary.dbo.TblAccounting as Accounting 
                         Where Accounting.CardId=" & myCardId & " and Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')>='" & TextBoxConcat1.Text.Trim & "' and Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')<='" & TextBoxConcat2.Text.Trim & "'
                               and Accounting.EEAccountingProcessType=2
                         Order By Accounting.DateMilladiA Desc"
                    DsCalc.Tables.Clear()
                    DaCalc.Fill(DsCalc)
                    myLeastExit = Replace(DsCalc.Tables(0).Rows(0).Item("DateShamsiA"), "/", "") + Replace(DsCalc.Tables(0).Rows(0).Item("TimeA"), ":", "")
                Catch ex As Exception
                    myReport.AppendLine("myLeastExit : " + myCardId.ToString + vbCrLf + ex.Message)
                    Continue For
                End Try
                'اولین خروج ماه
                Try
                    DaCalc.SelectCommand.CommandText =
                        "Select Top 1 Accounting.DateShamsiA,Accounting.TimeA from R2Primary.dbo.TblAccounting as Accounting 
                     Where Accounting.CardId=" & myCardId & " and Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')>='" & TextBoxConcat1.Text.Trim & "' and Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')<='" & TextBoxConcat2.Text.Trim & "'
                           and Accounting.EEAccountingProcessType=2
                     Order By Accounting.DateMilladiA Asc"
                    DsCalc.Tables.Clear()
                    DaCalc.Fill(DsCalc)
                Catch ex As Exception
                    MessageBox.Show("myFirstExit : " + myCardId.ToString + vbCrLf + ex.Message)
                    Continue For
                End Try
                'ورود دوره معادل اولین خروج ماه
                Dim myFirstEnter As String
                Try
                    Dim myFirstExitDateShamsiTime As String = Replace(DsCalc.Tables(0).Rows(0).Item("DateShamsiA"), "/", "") + Replace(DsCalc.Tables(0).Rows(0).Item("TimeA"), ":", "")
                    DaCalc.SelectCommand.CommandText =
                        "Select Top 1 Accounting.DateShamsiA,Accounting.TimeA from R2Primary.dbo.TblAccounting as Accounting 
                         Where Accounting.CardId=" & myCardId & " and Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')<='" & myFirstExitDateShamsiTime & "' and (Accounting.EEAccountingProcessType=1 or Accounting.EEAccountingProcessType=11) and MblghA<>0
                         Order By Accounting.DateMilladiA Desc"
                    DsCalc.Tables.Clear()
                    DaCalc.Fill(DsCalc)
                    myFirstEnter = Replace(DsCalc.Tables(0).Rows(0).Item("DateShamsiA"), "/", "") + Replace(DsCalc.Tables(0).Rows(0).Item("TimeA"), ":", "")
                Catch ex As Exception
                    myReport.AppendLine("myFirstEnter : " + myCardId.ToString + vbCrLf + ex.Message)
                    Continue For
                End Try
                'خواندن تمام رکوردهای اکانتینگ تردد مرتبط با کارت مورد نظر
                Try
                    DaCalc.SelectCommand.CommandText =
                        "Select * from R2Primary.dbo.TblAccounting as Accounting
                     Where Accounting.CardId=" & myCardId & "  and (Accounting.EEAccountingProcessType=1 or Accounting.EEAccountingProcessType=2  or Accounting.EEAccountingProcessType=11) and 
                           Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')>='" & myFirstEnter & "' and
	                       Replace(Accounting.DateShamsiA,'/','')+Replace(Accounting.TimeA,':','')<='" & myLeastExit & "'
                     Order By Accounting.DateMilladiA"
                    DsCalc.Tables.Clear()
                    DaCalc.Fill(DsCalc)
                Catch ex As Exception
                    MessageBox.Show("ReadAllEntryExitForTerraficCard : " + myCardId.ToString + vbCrLf + ex.Message)
                End Try
                'محاسبه دوره های تردد کارت
                Dim myIndex As Int64 = DsCalc.Tables(0).Rows.Count - 1
                Do While myIndex >= 0
                    Dim myMainDataRow As DataRow
                    Try
                        'پیدا کردن اکانت خروج
                        For LoopTemp2 As Integer = myIndex To 0 Step -1
                            If DsCalc.Tables(0).Rows(LoopTemp2).Item("EEAccountingProcessType") = 2 Then
                                myMainDataRow = DsCalc.Tables(0).Rows(LoopTemp2)
                                myIndex = LoopTemp2
                                Exit For
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("myMainDataRow : " + myCardId + vbCrLf + ex.Message)
                    End Try
                    Dim myIndex2 As Int64 = myIndex - 1 : If myIndex2 < 0 Then Exit Do
                    Do While 3 = 3
                        Dim myIndex2DataRow As DataRow
                        Try
                            myIndex2DataRow = DsCalc.Tables(0).Rows(myIndex2)
                        Catch ex As Exception
                            MessageBox.Show("myIndex2DataRow : " + myCardId + vbCrLf + ex.Message)
                        End Try
                        Try
                            If ((myIndex2DataRow.Item("MblghA") <> 0) And (myIndex2DataRow.Item("EEAccountingProcessType") = 1)) Then
                                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblEnterExits(CardEnter,DEnter,DExit,Mblgh) Values('" & myMainDataRow.Item("CardId") & "','" & Convert.ToDateTime(DsCalc.Tables(0).Rows(myIndex2).Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & Convert.ToDateTime(myMainDataRow.Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "'," & Convert.ToInt64(myMainDataRow.Item("MblghA")) & ")"
                                CmdSql.ExecuteNonQuery()
                                myIndex = myIndex2
                                Exit Do
                            ElseIf ((myIndex2DataRow.Item("MblghA") <> 0) And (myIndex2DataRow.Item("EEAccountingProcessType") = 11)) Then
                                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblEnterExits(CardEnter,DEnter,DExit,Mblgh) Values('" & myMainDataRow.Item("CardId") & "','" & Convert.ToDateTime(DsCalc.Tables(0).Rows(myIndex2).Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & Convert.ToDateTime(myMainDataRow.Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "'," & Convert.ToInt64(myMainDataRow.Item("MblghA")) & ")"
                                CmdSql.ExecuteNonQuery()
                                myIndex = myIndex2
                                Exit Do
                            ElseIf ((myIndex2DataRow.Item("EEAccountingProcessType") = 1) And myIndex2 = 0) Then
                                CmdSql.CommandText = "Insert Into R2PrimarySMSSystem.dbo.TblEnterExits(CardEnter,DEnter,DExit,Mblgh) Values('" & myMainDataRow.Item("CardId") & "','" & Convert.ToDateTime(DsCalc.Tables(0).Rows(myIndex2).Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & Convert.ToDateTime(myMainDataRow.Item("DateMilladiA")).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "'," & Convert.ToInt64(myMainDataRow.Item("MblghA")) & ")"
                                CmdSql.ExecuteNonQuery()
                                myIndex = myIndex2
                                Exit Do
                            End If
                            myIndex2 -= 1
                            If myIndex2 < 0 Then
                                myIndex = myIndex2
                                Exit Do
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Insert Into : " + myCardId.ToString() + vbCrLf + ex.Message)
                        End Try
                    Loop
                Loop
            Next
            CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            Dim DaResult As New SqlClient.SqlDataAdapter : Dim DsResult As New DataSet
            DaResult.SelectCommand = New SqlCommand("Select * from R2PrimarySMSSystem.dbo.TblEnterExits  AS EnterExits Order By Mblgh")
            DaResult.SelectCommand.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
            DaResult.Fill(DsResult)
            Dim mySum24, mySum48, mySum72 As Single
            mySum24 = 0 : mySum48 = 0 : mySum72 = 0
            For LoopResult As Integer = 0 To DsResult.Tables(0).Rows.Count - 1
                Dim myDateDiff As Int64 = DateDiff(DateInterval.Minute, DsResult.Tables(0).Rows(LoopResult).Item("DEnter"), DsResult.Tables(0).Rows(LoopResult).Item("DExit"))
                If myDateDiff > 1440 Then
                    mySum24 += ((myDateDiff - 1440) \ 1440) + 1
                End If
                If myDateDiff > 2880 Then
                    mySum48 += ((myDateDiff - 2880) \ 1440) + 1
                End If
                If myDateDiff > 4320 Then
                    mySum72 += ((myDateDiff - 4320) \ 1440) + 1
                End If
            Next
            TextBoxResult.Text = "Sum24: " + mySum24.ToString() + vbCrLf + "Sum48: " + mySum48.ToString() + vbCrLf + "Sum72: " + mySum72.ToString()
            TextBoxReport.Text = myReport.ToString()
            MessageBox.Show("Finished ...")
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then
                CmdSql.Transaction.Rollback() : CmdSql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim InstanceBlackList = New R2CoreParkingSystemInstanceBlackListManager
            Dim InstanceTruck = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
            Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
            Dim NSSTurn = InstanceTurns.GetNSSTurn(421803)
            Dim NSSTruck = InstanceTruck.GetNSSTruck(NSSTurn)

            'کنترل لیست سیاه
            Dim NSSBlackList As R2StandardBlackListStructure = Nothing
            Dim HasBlackList = InstanceBlackList.HasCarBlackList(NSSTruck.NSSCar, NSSBlackList)
            If HasBlackList Then Throw New LoadAllocationNotAllowedBecauseCarHasBlackListException(NSSBlackList.StrDesc)


            'Dim X As ATISMobileRestful.ATISMobileWebApi
            'X.AuthenticateClient("8de86f1ac66204ac60bafb945479878a", "05bfadf5ce2f37098f0ba1c264553227")
            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationRegistering(TextBoxConcat1.Text, 943601, R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser, R2CoreTransportationAndLoadNotificationRequesters.ATISRestfullLoadAllocationRegisteringAgent)
            'R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.RegisteringMobileNumber("09132043148")
            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocationsforTruckDriver(7025)
            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(R2CoreTransportationAndLoadNotification.Turns.R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetNSSTurn(943601))
            'Dim NSSLoadAllocation = R2CoreTransportationAndLoadNotification.LoadAllocation.R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(10725)

            'If DateDiff(DateInterval.Minute, NSSLoadAllocation.DateTimeMilladi, _DateTime.GetCurrentDateTimeMilladi()) >= R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.AnnouncementHallsLoadAllocationsLoadPermissionRegisteringSetting, 1) Then
            '    R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationCancelling(NSSLoadAllocation.LAId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledSystem, R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
            '    Throw New LoadAllocationMaxDelayFailedReachedException
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Try
        '    Dim Ds As DataSet
        '    R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
        '           "Select Distinct strPersonFullName,strIDNO from dbtransport.dbo.TbPerson as Persons
        '            Where Persons.strIDNO collate Arabic_CI_AI_WS not in (Select Distinct MobileNumber collate Arabic_CI_AI_WS 
        '                                                                  from R2Primary.dbo.TblSoftwareUsers 
        '						                  Where ltrim(rtrim(mobilenumber))<>'' and UserTypeId=3) 
        '              and ltrim(rtrim(Persons.strIDNO))<>'' and len(Persons.strIDNO)=11", 0, Ds)
        '    Dim NSSUserCreator = R2CoreMClassSoftwareUsersManagement.GetNSSUser(21)
        '    For loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
        '        Dim NSSUser = New R2CoreStandardSoftwareUserStructure(Nothing, Ds.Tables(0).Rows(loopx).Item("strPersonFullName").trim, String.Empty, String.Empty, String.Empty, False, True, 3, Ds.Tables(0).Rows(loopx).Item("strIDNO").trim, "logout", String.Empty, 21, Nothing, Nothing, True, False)
        '        Dim UserId As Int64 = R2CoreMClassSoftwareUsersManagement.RegisteringSoftwareUser(NSSUser, NSSUserCreator)
        '        Dim NSSEn = New R2StandardEntityRelationStructure(Nothing, R2CoreParkingSystemEntityRelationTypes.SoftwareUser_Driver, UserId, Ds.Tables(0).Rows(loopx).Item("nIdPerson"), True)
        '        R2CoreMClassEntityRelationManagement.RegisteringEntityRelation(NSSEn, RelationDeactiveTypes.BothDeactive)
        '        'به دست آوردن لیست فرآیندهای موبایلی قابل دسترسی برای نوع کاربر راننده و ارسال به مدیریت مجوز
        '        Dim ComposeSearchString As String = R2CoreParkingSystemSoftwareUserTypes.Driver.ToString + ":"
        '        Dim AllofSoftwareUserTypes1 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesAccessMobileProcesses), ";")
        '        Dim AllofMobileProcessesIds As String() = Split(Mid(AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes1.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
        '        R2CoreMClassPermissionsManagement.RegisteringPermissions(R2CorePermissionTypes.SoftwareUsersAccessMobileProcesses, UserId, AllofMobileProcessesIds)
        '        'به دست آوردن لیست گروههای فرآیند موبایلی برای نوع کاربر راننده و ارسال آن به مدیریت روابط نهادی
        '        Dim AllofSoftwareUserTypes2 As String() = Split(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SoftwareUserTypesRelationMobileProcessGroups), ";")
        '        Dim AllofMobileProcessGroupsIds As String() = Split(Mid(AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0), ComposeSearchString.Length + 1, AllofSoftwareUserTypes2.Where(Function(x) Mid(x, 1, ComposeSearchString.Length) = ComposeSearchString)(0).Length), ",")
        '        R2CoreMClassEntityRelationManagement.RegisteringEntityRelations(R2CoreEntityRelationTypes.SoftwareUser_MobileProcessGroup, UserId, AllofMobileProcessGroupsIds)
        '    Next
        '    MessageBox.Show("Count : "+Ds.Tables(0).Rows.Count.ToString())

        '    'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.CancellingFailedLoadAllocations()
        '    'R2CoreMClassSoftwareUsersManagement.SetCurrentUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)
        '    'R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.TransferringTommorowLoads()
        '    'PayanehClassLibrary.Rmto.RmtoWebService.GetInf(RmtoWebService.InfoType.GET_DRIVER_BY_SHC, "1222524")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocationsforLoadPermissionRegistering(2, 7)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim NSS = R2CoreParkingSystemMClassDrivers.GetNSSDriver(78616)
            NSS.StrIdNo = "09130843148"
            R2CoreParkingSystemMClassDrivers.UpdateDriver(NSS, R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())

            'R2CoreTransportationAndLoadNotification.LoadTargets.R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetProvinces(2,7,1,1)
            'Dim NSS As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetCarTruckfromRMTOAndInsertUpdateLocalDataBase("2218230",R2Core.UserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
            'Dim _WS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService()
            'Dim ExchangeKey = _WS.WebMethodLogin("123", "1234")
            '_WS.WebMethodGetnIdCarTruckBySmartCarNo("2063514", "74094")
            'PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating("1775507", R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        R2CoreMClassSoftwareUsersManagement.AuthenticationUserByPinCode(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser)

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cmdsql As New SqlCommand
        cmdsql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
        Try
            Dim da As New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = New OleDbCommand("Select Field8,Field10 from  TransportPriceTarrifsReport")
            da.SelectCommand.Connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\4.mdb")
            da.Fill(ds)
            cmdsql.Connection.Open()
            cmdsql.Transaction = cmdsql.Connection.BeginTransaction()
            For loopx As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim TargetCityId As Int64 = ds.Tables(0).Rows(loopx).Item("Field8")
                Dim Tarrif As Int64 = ds.Tables(0).Rows(loopx).Item("Field10")
                cmdsql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs(AHId,AHSGId,TargetCityId,Tarrif,DateTimeMilladi,DateShamsi,Time,OActive) values(2,7," & TargetCityId & "," & Tarrif & ",'2020-12-27 10:00:00','1399/10/07','10:00:00',0)"
                cmdsql.ExecuteNonQuery()
                cmdsql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs(AHId,AHSGId,TargetCityId,Tarrif,DateTimeMilladi,DateShamsi,Time,OActive) values(2,8," & TargetCityId & "," & Tarrif & ",'2020-12-27 10:00:00','1399/10/07','10:00:00',0)"
                cmdsql.ExecuteNonQuery()
                cmdsql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTransportPriceTarrifs(AHId,AHSGId,TargetCityId,Tarrif,DateTimeMilladi,DateShamsi,Time,OActive) values(2,9," & TargetCityId & "," & Tarrif & ",'2020-12-27 10:00:00','1399/10/07','10:00:00',0)"
                cmdsql.ExecuteNonQuery()
            Next
            cmdsql.Transaction.Commit() : cmdsql.Connection.Close()
            MessageBox.Show("Finished...")
        Catch ex As Exception
            If cmdsql.Connection.State <> ConnectionState.Closed Then
                cmdsql.Transaction.Rollback()
                cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            RmtoWebService.GetNSSTruckDriver("3012237")
            RmtoWebService.GetNSSTruck("2312401")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim uc As New UCBillOfLadingControl : uc.UCViewNSS(2)
            Dim NSSExtended As R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlExtendedStructure = uc.UCNSSCurrent

            MessageBox.Show(NSSExtended.BLCTitle)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            R2CoreTransportationAndLoadNotification.ReportManagement.R2CoreTransportationAndLoadNotificationReportsManagement.ReportingInformationProviderBillOfLadingControlReport(10002)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim Ds As DataSet
            R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where MobileNumber<>'' Order By UserId", 0, Ds)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim UserId As Int64 = Ds.Tables(0).Rows(loopx).Item("UserId")
                Dim Randoom As Random = New Random()
                Randomize()
                Dim Pass As String = String.Empty
                Try
                    Pass = (Randoom.Next(1000, 4543432) + Convert.ToInt64(Mid(Ds.Tables(0).Rows(loopx).Item("MobileNumber").ToString(), 4, 7))).ToString()
                Catch ex As Exception
                    Pass = UserId
                End Try

                Cmdsql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set UserPassword='" & Pass & "' Where UserId=" & UserId & ""
                Cmdsql.ExecuteNonQuery()
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished Success ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim DsSoftwareusers As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select UserId from R2Primary.dbo.TblSoftwareUsers where UserTypeId = 3", 0, DsSoftwareusers)
            Dim DsMobileProcess As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select PId from R2Primary.dbo.TblMobileProcesses where active=1", 0, DsMobileProcess)

            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int64 = 0 To DsSoftwareusers.Tables(0).Rows.Count - 1
                For loopY As Int64 = 0 To DsMobileProcess.Tables(0).Rows.Count - 1
                    Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive)
                                      values(" & DsSoftwareusers.Tables(0).Rows(loopx).Item("UserId") & "," & DsMobileProcess.Tables(0).Rows(loopY).Item("PId") & ",1,1)"
                    Cmdsql.ExecuteNonQuery()
                Next
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished Success ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim DsSoftwareusers As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select UserId from R2Primary.dbo.TblSoftwareUsers where UserTypeId = 3", 0, DsSoftwareusers)
            Dim DsMobileProcessGroups As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "select pgid from R2Primary.dbo.TblMobileProcessGroups where Active=1", 0, DsMobileProcessGroups)

            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int64 = 0 To DsSoftwareusers.Tables(0).Rows.Count - 1
                For loopY As Int64 = 0 To DsMobileProcessGroups.Tables(0).Rows.Count - 1
                    Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                          values(3," & DsSoftwareusers.Tables(0).Rows(loopx).Item("UserId") & "," & DsMobileProcessGroups.Tables(0).Rows(loopY).Item("pgid") & ",1)"
                    Cmdsql.ExecuteNonQuery()
                Next
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished Success ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            Dim Instance = New R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager
            Instance.LoadAllocationsLoadPermissionRegistering(R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())

            'MessageBox.Show(R2CoreMclassDateAndTimeManagement.GetPersianDaysDiffDate(_DateTime.GetCurrentDateShamsiFull(), "1399/12/07"))
            'R2CoreTransportationAndLoadNotificationMClassLoadSedimentationManagement.SedimentingProcess()
            'For loopx As Int64 = 0 To 2000
            '    Try
            '        R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationRegistering(462299, 943601, R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser())
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)
            '    End Try

            'Next

            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationCancelling(715,R2CoreTransportationAndLoadNotification.LoadAllocation.R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser   ,R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser )
            'R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationLoadPermissionRegistering(713,R2CoreMClassSoftwareUsersManagement.GetNSSSystemUser )
            'R2CoreTransportationAndLoadNotification.Turns.R2CoreTransportationAndLoadNotificationMClassTurnsManagement.GetTurns(R2Core.SoftwareUserManagement.R2CoreMClassSoftwareUsersManagement.GetNSSUser(7025))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UcDriverTruck1_UCViewDriverTruckInformationCompleted(DriverId As String)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim DsCoUsers As New DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                    "Select SoftwareUsers.UserId from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies
                       Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On TransportCompanies.TCId=SoftwareUsers.UserShenaseh", 0, DsCoUsers)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For Loopx As Int64 = 0 To DsCoUsers.Tables(0).Rows.Count - 1
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive)
                                      values(" & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",1,2,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive)
                                      values(" & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",2,2,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive)
                                      values(" & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",3,2,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblPermissions(EntityIdFirst,EntityIdSecond,PermissionTypeId,RelationActive)
                                      values(" & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",4,2,1)"
                Cmdsql.ExecuteNonQuery()
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim DsCoUsers As New DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                    "Select SoftwareUsers.UserId from R2PrimaryTransportationAndLoadNotification.dbo.TblTransportCompanies as TransportCompanies
                       Inner Join R2Primary.dbo.TblSoftwareUsers as SoftwareUsers On TransportCompanies.TCId=SoftwareUsers.UserShenaseh", 0, DsCoUsers)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For Loopx As Int64 = 0 To DsCoUsers.Tables(0).Rows.Count - 1
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                      Values(6," & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",1,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                      Values(6," & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",2,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                      Values(6," & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",3,1)"
                Cmdsql.ExecuteNonQuery()
                Cmdsql.CommandText = "Insert Into R2Primary.dbo.TblEntityRelations(ERTypeId,E1,E2,RelationActive)
                                      Values(6," & DsCoUsers.Tables(0).Rows(Loopx).Item("UserId") & ",4,1)"
                Cmdsql.ExecuteNonQuery()
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            R2Core.SMSSendAndRecieved.R2CoreSMSMClassSMSDomainManagement.SMSDomainSendRecieved()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
        Try
            Dim Hasher = New MD5Hasher
            Dim Ds As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select UserId from R2primary.dbo.tblsoftwareusers", 0, Ds)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int16 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim UserId As Int64 = Ds.Tables(0).Rows(loopx).Item("UserId")
                Cmdsql.CommandText = "Update r2primary.dbo.tblsoftwareusers set apikey='" & Hasher.GenerateMD5String(UserId) & "'
                                      Where Userid=" & UserId & ""
                Cmdsql.ExecuteNonQuery()
            Next
            Cmdsql.Transaction.Commit() : Cmdsql.Connection.Close()
            MessageBox.Show("Finished ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Transaction.Rollback() : Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
        Try
            Dim Hasher = New MD5Hasher
            Dim Ds As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select nEstelamId from dbtransport.dbo.tbelam order by nEstelamId asc", 0, Ds)
            Cmdsql.Connection.Open()
            For loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim nEstelamId As Int64 = Ds.Tables(0).Rows(loopx).Item("nEstelamId")
                Cmdsql.CommandText = "Update dbtransport.dbo.tbelam set nEstelamkey='" & Hasher.GenerateMD5String(nEstelamId) & "'
                                      Where nEstelamId=" & nEstelamId & ""
                Cmdsql.ExecuteNonQuery()
            Next
            Cmdsql.Connection.Close()
            MessageBox.Show("Finished ...")
        Catch ex As Exception
            If Cmdsql.Connection.State <> ConnectionState.Closed Then
                Cmdsql.Connection.Close()
            End If
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class