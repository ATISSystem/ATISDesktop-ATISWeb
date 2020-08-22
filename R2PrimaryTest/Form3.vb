Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports PayanehClassLibrary.Rmto
Imports R2Core.UserManagement
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadOtherThanManipulation

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            R2CoreMClassLoginManagement.SetCurrentUserByPinCode(R2CoreMClassLoginManagement.GetNSSSystemUser)
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
            R2CoreMClassLoginManagement.SetCurrentUserByPinCode(R2CoreMClassLoginManagement.GetNSSSystemUser)
            R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadOtherThanManipulationManagement.TransferringTommorowLoads()
            'PayanehClassLibrary.Rmto.RmtoWebService.GetInf(RmtoWebService.InfoType.GET_DRIVER_BY_SHC, "1222524")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class