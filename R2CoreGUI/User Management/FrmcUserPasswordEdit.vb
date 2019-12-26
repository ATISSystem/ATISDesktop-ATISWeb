
Imports System.Reflection
Imports R2Core.ProcessesManagement
Imports R2Core.UserManagement

Public Class FrmcUserPasswordEdit
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(      R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreProcesses.FrmcUserPasswordEdit))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub Sabtroutin()
        Dim cmdsql As New SqlClient.SqlCommand
        cmdsql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection
        Try
            cmdsql.Connection.Open()
            cmdsql.CommandText = "update R2Primary.dbo.TblSoftwareUsers Set UserPassword='" & UcTextBoxNewUserPassword.UCValue & "'   where UserId=" & R2CoreMClassLoginManagement.CurrentUserNSS.UserId & ""
            cmdsql.ExecuteNonQuery()
            cmdsql.Connection.Close()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess,"رمز عبور کاربر تغییر یافت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            If cmdsql.Connection.State <> ConnectionState.Closed Then cmdsql.Connection.Close()
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            Sabtroutin()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class