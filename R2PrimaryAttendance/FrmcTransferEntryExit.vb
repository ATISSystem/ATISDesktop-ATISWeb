
Imports System.Reflection

Public Class FrmcTransferEntryExit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CmdSqlClock4 As New OleDb.OleDbCommand
        Try
            'خواندن فایل ورود خروج انگشت پرسنل
            Dim FDOpen = New OpenFileDialog
            If FDOpen.ShowDialog = DialogResult.Cancel Then Exit Sub
            Dim Da As New OleDb.OleDbDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New OleDb.OleDbCommand("Select * from TblEntryExit")
            Da.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & FDOpen.FileName & "'")
            Da.Fill(Ds)

            'شروع تراکنش ثبت
            Dim myClockTableName As String = "C" + Mid(Ds.Tables(0).Rows(0).Item("ShamsiDate").Trim, 1, 7).Replace("/", "")
            Dim FDSave As New SaveFileDialog
            If FDSave.ShowDialog = DialogResult.Cancel Then Exit Sub
            CmdSqlClock4.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & FDSave.FileName & "'")
            CmdSqlClock4.Connection.Open()
            CmdSqlClock4.Transaction = CmdSqlClock4.Connection.BeginTransaction
            CmdSqlClock4.CommandText = "Delete from " + myClockTableName
            CmdSqlClock4.ExecuteNonQuery()
            For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim myPIdOther As String = Ds.Tables(0).Rows(Loopx).Item("PIdOther").trim
                Dim myDateShamsi As String = Ds.Tables(0).Rows(Loopx).Item("ShamsiDate").trim
                Dim myTime As Int64 = Ds.Tables(0).Rows(Loopx).Item("Time")
                CmdSqlClock4.CommandText = "Insert Into [" & myClockTableName & "] ([Clock_BarCode],[Clock_BDate],[Clock_BTime],[Clock_BRdrCode],[Clock_BRecState],[Clock_Date],[Clock_Time],[Clock_RdrCode],[Clock_Chg],[Clock_RecState],[Clock_User]) Values ('" & myPIdOther & "','" & myDateShamsi & "'," & myTime & ",1,0,'" & myDateShamsi & "'," & myTime & ",1,0,0,'Admin')"
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