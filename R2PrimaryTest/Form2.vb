Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Da As New OleDb.OleDbDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New OleDb.OleDbCommand("Select * from Sheet1 Where  Field5='ذوب آهن اصفهان' Order By Field8,Field7")
            Da.SelectCommand.Connection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DataBox32.mdb")
            Da.Fill(Ds)
            TxtReport.Text += "Total Records:" + Ds.Tables(0).Rows.Count.ToString

            For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1

                Dim Pelak As String = Ds.Tables(0).Rows(Loopx).Item("Field8")
                Dim PelakSeriasl As String = Ds.Tables(0).Rows(Loopx).Item("Field7")
                Dim DateShamsi As String = Ds.Tables(0).Rows(Loopx).Item("Field31")
                Dim Timex As String = Ds.Tables(0).Rows(Loopx).Item("Field29")
                Dim BarnamehNo As String = Ds.Tables(0).Rows(Loopx).Item("Field37")

                Dim DaDBTransport As New SqlClient.SqlDataAdapter : Dim DsDBTransport As New DataSet
                DaDBTransport.SelectCommand = New SqlClient.SqlCommand("Select * from ")

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class