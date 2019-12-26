
Imports System.Reflection

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCCmbTerafficCardType
    Inherits UCGeneral

    Public Event UCSelectedIndexChanged

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewinf()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        CmbTerafficCardType.Text = CmbTerafficCardType.Items(1)
    End Sub

    Public Sub UCViewinf()
        Try
            CmbTerafficCardType.Items.Clear()
            Dim DataBox As DataSet = R2CoreParkingSystemMClassTrafficCardManagement.GetDSTerafficCardType()
            For Loopx As Int64 = 0 To DataBox.Tables(0).Rows.Count - 1
                CmbTerafficCardType.Items.Add(DataBox.Tables(0).Rows(Loopx).Item("TypeCode").ToString + " " + DataBox.Tables(0).Rows(Loopx).Item("TypeName").trim)
            Next
            CmbTerafficCardType.Text = CmbTerafficCardType.Items(1)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSetType(YourTerafficCardTypeCode As String)
        Try
            CmbTerafficCardType.Text =  YourTerafficCardTypeCode+" " +R2CoreParkingSystemMClassTrafficCardManagement.GetTerafficCardTypeNameFromTypeCode(YourTerafficCardTypeCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetCurrentTypeItem() As String
        Try
            If CmbTerafficCardType.SelectedIndex >= 0 Then
                Return CmbTerafficCardType.SelectedItem
            Else
                Throw New DataEntryException
            End If
        Catch exx As DataEntryException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetCurrentTypeCode() As String
        Try
            If CmbTerafficCardType.SelectedIndex >= 0 Then
                Return Split(CmbTerafficCardType.SelectedItem, " ")(0)
            Else
                Throw New DataEntryException
            End If
        Catch exx As DataEntryException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

  

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CmbTerafficCardType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTerafficCardType.SelectedIndexChanged
        Try
            RaiseEvent UCSelectedIndexChanged
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
