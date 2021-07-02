
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2CoreGUI

Public Class FrmcFirst

    Private WithEvents _Timer As System.Windows.Forms.Timer = New Timer()



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _Timer.Interval = 5000

            _Timer.Enabled = True
            _Timer.Start()
            LblApplicationDomainTitle0.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0)
            LblApplicationDomainTitle1.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 1)
            LblSystemTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SystemDisplayTitle, 0)
            PnlMain.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub ProgramEnding()
        End
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _Timer_Tick(sender As Object, e As EventArgs) Handles _Timer.Tick
        Dim ControlingCounter As String
        Try
            _Timer.Stop()
            Dim cmdsqlcount As New SqlClient.SqlCommand
            cmdsqlcount.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                cmdsqlcount.Connection.Open()
                cmdsqlcount.CommandText = "select univnulls from sysindexpermissions"
                ControlingCounter = Trim(cmdsqlcount.ExecuteScalar())
                cmdsqlcount.Connection.Close()
            Catch ex As Exception
                If cmdsqlcount.Connection.State <> ConnectionState.Closed Then cmdsqlcount.Connection.Close()
                Throw New Exception("200  " + ex.Message.ToString)
            End Try

            Dim cmdsql As New SqlClient.SqlCommand
            cmdsql.Connection = (New R2PrimarySqlConnection).GetConnection
            Try
                If ControlingCounter <> "-0" Then
                    If System.Convert.ToInt64(ControlingCounter) <= 0 Then Throw New Exception("201")
                    cmdsql.Connection.Open()
                    cmdsql.CommandText = "update sysindexpermissions set univnulls=univnulls-1"
                    cmdsql.ExecuteNonQuery()
                    cmdsql.Connection.Close()
                End If
            Catch ex As Exception
                If cmdsql.Connection.State <> ConnectionState.Closed Then cmdsql.Connection.Close()
                Throw New Exception("Pvcontrolingcounter." + ex.Message.ToString)
            End Try
            R2CoreGUI.R2CoreGUIMClassGUIManagement.FrmMainMenu.Show()
            AddHandler R2CoreGUIMClassGUIManagement.FrmMainMenu.ExitIconPressed, AddressOf ProgramEnding
            Me.Size = New Size(0, 0)
            Me.Location = New Point(-1000, -1000)
            Me.Size = New Size(0, 0)
            Me.Location = New Point(-1000, -1000)
        Catch ex As Exception
            UcLabelMessage.UCValue = "Error : Timer1_Tick()." + ex.InnerException.Message.ToString
        End Try

    End Sub

    Private Sub PicEnd_Click(sender As Object, e As EventArgs) Handles PicEnd.Click
        End
    End Sub

    Private Sub UcLabelMessage_UCClickedEvent() Handles UcLabelMessage.UCClickedEvent
        MessageBox.Show(UcLabelMessage.UCValue)
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
