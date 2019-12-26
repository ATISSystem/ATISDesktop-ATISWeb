
Imports System.Reflection
Imports R2Core.ExceptionManagement

Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreGUI

Public Class UCCmbTerafficTempCardType
    Inherits UCGeneral



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
        CmbTerafficTempCardType.Text = CmbTerafficTempCardType.Items(1)
    End Sub

    Public Sub UCViewinf()
        Try
            CmbTerafficTempCardType.Items.Clear()
            Dim DataBox As DataSet = R2CoreParkingSystemMClassTrafficCardManagement.GetDSTerafficTempCardType()
            For Loopx As Int64 = 0 To DataBox.Tables(0).Rows.Count - 1
                CmbTerafficTempCardType.Items.Add(DataBox.Tables(0).Rows(Loopx).Item("TempTypeCode").ToString + " " + DataBox.Tables(0).Rows(Loopx).Item("TempTypeName").trim)
            Next
            CmbTerafficTempCardType.Text = CmbTerafficTempCardType.Items(1)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSetTempType(YourTerafficTempCardTypeCode As String)
        Try
            CmbTerafficTempCardType.Text = YourTerafficTempCardTypeCode+" "+R2CoreParkingSystemMClassTrafficCardManagement.GetTerafficTempCardTypeNameFromTempTypeCode(YourTerafficTempCardTypeCode) 
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetCurrentTempTypeItem() As String
        Try
            If CmbTerafficTempCardType.SelectedIndex >= 0 Then
                Return CmbTerafficTempCardType.SelectedItem
            Else
                Throw New DataEntryException
            End If
        Catch exx As DataEntryException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetCurrentTempTypeCode() As String
        Try
            If CmbTerafficTempCardType.SelectedIndex >= 0 Then
                Return Split(CmbTerafficTempCardType.SelectedItem, " ")(0)
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
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
