
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI

Public Class FrmcPersonnels

    Private _FrmMessageDialog As New FrmcMessageDialog

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"


    Public enum ViewType
        None=0
        ByNameFamily=1
        ByNationalCode=2
    End enum

    Public Sub ViewPersonnels(YourSerachStr As String,YourViewType As ViewType)
        Try
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            If YourViewType = YourViewType.ByNameFamily Then Da.SelectCommand = New SqlCommand("Select PId,PNameFamily,NationalCode from R2Primary.dbo.TblPersonelInf Where PNameFamily Like '%" & YourSerachStr & "%' Order by PNameFamily")
            If YourViewType = YourViewType.ByNationalCode Then Da.SelectCommand = New SqlCommand("Select PId,PNameFamily,NationalCode from R2Primary.dbo.TblPersonelInf Where PNameFamily Like '%" & YourSerachStr & "%' Order by NationalCode")
            Da.SelectCommand.Connection =  (new R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
            Ds.Tables.Clear()
            Da.Fill(Ds)
            ListBoxPersonnels.Items.Clear()
            For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                ListBoxPersonnels.Items.Add(Ds.Tables(0).Rows(Loopx).Item("PId") & vbTab & Ds.Tables(0).Rows(Loopx).Item("PNameFamily").trim+" "+vbTab & Ds.Tables(0).Rows(Loopx).Item("NationalCode").trim )
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf+ ex.Message)
        End Try
    End Sub

    Public Function GetSelectedPersonnelId() As Int64
        Try
            If ListBoxPersonnels.SelectedIndex<0 Then Return 0
            Dim Selected As String = ListBoxPersonnels.SelectedItem
            Dim SelectedArray As String() = Split(Selected, vbTab)
            Return SelectedArray(0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf+ ex.Message)
        End Try
    End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub ListBoxPersonnels_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxPersonnels.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Then Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxPersonnelNameFamily_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxPersonnelNameFamily.UC13PressedEvent
        Try
            ViewPersonnels(UcPersianTextBoxPersonnelNameFamily.UCValue,ViewType.ByNameFamily)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBoxDPersonnels_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxPersonnels.DoubleClick
        Try
          Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxPersonnelNameFamily_UCDownArrowKeyPressedEvent() Handles UcPersianTextBoxPersonnelNameFamily.UCDownArrowKeyPressedEvent
        ListBoxPersonnels.Focus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class