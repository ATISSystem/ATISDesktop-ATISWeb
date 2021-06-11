Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.SecurityAlgorithmsManagement.AESAlgorithms
Imports R2Core.SecurityAlgorithmsManagement.Hashing
Imports R2Core.SoftwareUserManagement

Public Class TestforAES
    Private Sub TestforAES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim aesa = New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
            Dim InstanceAES = New AESAlgorithmsManager()
            Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
            Dim InstanceSoftwareusers = New R2CoreInstanseSoftwareUsersManager()
            Dim InstanceHash = New SHAHasher()
            Dim NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(New R2CoreSoftwareUserMobile("09130843148"))
            TxtResult.Text = InstanceAES.Encrypt(NSSSoftwareuser.ApiKey, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim aesa = New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
            Dim InstanceAES = New AESAlgorithmsManager()
            Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
            Dim InstanceSoftwareusers = New R2CoreInstanseSoftwareUsersManager()
            Dim InstanceHash = New SHAHasher()
            Dim NSSSoftwareuser = InstanceSoftwareusers.GetNSSUser(New R2CoreSoftwareUserMobile("09130843148"))
            TxtResult.Text = InstanceAES.Encrypt(NSSSoftwareuser.MobileNumber, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim AES As New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
            Dim Hasher As New R2Core.SecurityAlgorithmsManagement.Hashing.SHAHasher()
            Dim Ds As DataSet
            R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Order By UserId", 0, Ds)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim UserId As Int64 = Ds.Tables(0).Rows(loopx).Item("UserId")
                Dim UIdSalt As String = AES.GetSalt(64)
                Dim APIKey = Hasher.GenerateSHA256String(UserId.ToString + UIdSalt)
                Cmdsql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set APIKey='" & APIKey & "' Where UserId=" & UserId & ""
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Cmdsql As New SqlClient.SqlCommand
        Cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
        Try
            Dim AES As New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
            Dim Ds As DataSet
            R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblSoftwareUsers Where UserTypeId=3 Order By UserId", 0, Ds)
            Cmdsql.Connection.Open()
            Cmdsql.Transaction = Cmdsql.Connection.BeginTransaction
            For loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                Dim UserId As Int64 = Ds.Tables(0).Rows(loopx).Item("UserId")
                Dim UserShenaseh As String = AES.GetRandomNumericCode(10000, 99999)
                Dim UserPassword As String = AES.GetRandomNumericCode(10000000, 99999999)
                Cmdsql.CommandText = "Update R2Primary.dbo.TblSoftwareUsers Set UserShenaseh='" & UserShenaseh & "',UserPassword='" & UserPassword & "' Where UserId=" & UserId & ""
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aesa = New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
        Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
        TxtResult.Text = aesa.Encrypt(TxtInput.Text, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim aesa = New R2Core.SecurityAlgorithmsManagement.AESAlgorithms.AESAlgorithmsManager
        Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager()
        TxtResult.Text = aesa.Decrypt(TxtInput.Text, InstanceConfiguration.GetConfigString(R2CoreConfigurations.PublicSecurityConfiguration, 3))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TxtResult.Text = Int64.MinValue
    End Sub
End Class