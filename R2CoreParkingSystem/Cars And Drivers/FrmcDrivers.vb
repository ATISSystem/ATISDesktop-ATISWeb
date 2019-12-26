
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI

Public Class FrmcDrivers

    Private _FrmMessageDialog As New FrmcMessageDialog

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public enum ViewType
        None=0
        ByNameFamily=1
        ByNationalCode=2
    End enum
    Public Sub ViewDrivers(YourSerachStr As String,YourViewType As ViewType)
        Try
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            If YourViewType = YourViewType.ByNameFamily Then Da.SelectCommand = New SqlCommand("Select P.nIdPerson,P.strPersonName,P.strPersonFamily,P.StrNationalCode from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIdPerson=D.nIdDriver Where P.strPersonFullName Like '%" & YourSerachStr & "%' Order by P.StrPersonFullName")
            If YourViewType = YourViewType.ByNationalCode Then Da.SelectCommand = New SqlCommand("Select P.nIdPerson,P.strPersonName,P.strPersonFamily,P.StrNationalCode from dbtransport.dbo.TbPerson as P inner join dbtransport.dbo.TbDriver as D On P.nIdPerson=D.nIdDriver Where P.strNationalCode='" & YourSerachStr & "' Order by P.StrPersonFullName")
            Da.SelectCommand.Connection =  (new DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Ds.Tables.Clear()
            Da.Fill(Ds)
            ListBoxDrivers.Items.Clear()
            For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                ListBoxDrivers.Items.Add(Ds.Tables(0).Rows(Loopx).Item("nIdPerson") & vbTab & Ds.Tables(0).Rows(Loopx).Item("StrPersonName").trim+" "+vbTab & Ds.Tables(0).Rows(Loopx).Item("StrPersonFamily").trim & vbTab & Ds.Tables(0).Rows(Loopx).Item("StrNationalCode").trim)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf+ ex.Message)
        End Try
    End Sub

    Public Function GetSelectedDriverId() As String
        Try
            If ListBoxDrivers.SelectedIndex<0 Then Return ""
            Dim Selected As String = ListBoxDrivers.SelectedItem
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
    Private Sub ListBoxDrivers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxDrivers.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Then Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxDriverName_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxDriverName.UC13PressedEvent
        Try
            ViewDrivers(UcPersianTextBoxDriverName.UCValue,ViewType.ByNameFamily)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBoxDrivers_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxDrivers.DoubleClick
        Try
          Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxDriverName_UCDownArrowKeyPressedEvent() Handles UcPersianTextBoxDriverName.UCDownArrowKeyPressedEvent
        ListBoxDrivers.Focus()
    End Sub

    Private Sub UcPersianTextBoxDriverName_UC27PressedEvent() Handles UcPersianTextBoxDriverName.UC27PressedEvent
        Me.Hide()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class