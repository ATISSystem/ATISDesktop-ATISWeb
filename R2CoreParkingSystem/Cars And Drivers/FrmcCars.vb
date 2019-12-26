
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI


Public Class FrmcCars

    Private _FrmMessageDialog As New FrmcMessageDialog


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub ViewCars(YourSerachStr As String)
        Try
            Dim Da As New SqlClient.SqlDataAdapter : Dim Ds As New DataSet
            Da.SelectCommand = New SqlCommand("Select C.nIdCar,C.StrCarNo,T.StrCityName,C.StrCarSerialNo from dbtransport.dbo.tbcar as C inner join dbtransport.dbo.tbCity as T on C.nIDCity=T.nCityCode Where C.StrCarNo Like '%" & YourSerachStr & "%' and isnull(C.ViewFlag,1)=1 Order by C.nIDCar Desc")
            Da.SelectCommand.Connection = (new DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
            Ds.Tables.Clear()
            Da.Fill(Ds)
            ListBoxCars.Items.Clear()
            For Loopx As Int64 = 0 To Ds.Tables(0).Rows.Count - 1
                ListBoxCars.Items.Add(Ds.Tables(0).Rows(Loopx).Item("nIdCar") & vbTab & Ds.Tables(0).Rows(Loopx).Item("StrCarNo").trim & vbTab & Ds.Tables(0).Rows(Loopx).Item("StrCityName").trim + " " + vbTab & Ds.Tables(0).Rows(Loopx).Item("StrCarSerialNo").trim)
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function GetSelectedCarId() As String
        Try
            If ListBoxCars.SelectedIndex < 0 Then Return ""
            Dim Selected As String = ListBoxCars.SelectedItem
            Dim SelectedArray As String() = Split(Selected, vbTab)
            Return SelectedArray(0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub ListBoxCars_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBoxCars.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Then Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxCarNo_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxCarNo.UC13PressedEvent
        Try
            ViewCars(UcPersianTextBoxCarNo.UCValue)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub ListBoxCars_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxCars.DoubleClick
        Try
            Me.Hide()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxCarNo_UCDownArrowKeyPressedEvent() Handles UcPersianTextBoxCarNo.UCDownArrowKeyPressedEvent
        ListBoxCars.Focus()
    End Sub

    Private Sub UcPersianTextBoxCarNo_UC27PressedEvent() Handles UcPersianTextBoxCarNo.UC27PressedEvent
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