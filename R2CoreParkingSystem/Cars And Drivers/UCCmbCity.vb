
Imports System.Reflection

Imports PayanehClassLibrary.City
Imports R2CoreGUI
Imports R2Core.DatabaseManagement
Imports R2CoreParkingSystem.City


Public Class UCCmbCity
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

    Public sub UCRefresh
        CmbCity.Text = R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(R2CoreParkingSystemMClassCitys.IRANCityCode)
    End sub

    Public Sub UCViewinf()
        Try
            CmbCity.Items.Clear()
            Dim DataBox As DataSet = R2CoreParkingSystemMClassCitys.GetDSCity()
            For Loopx As Int64 = 0 To DataBox.Tables(0).Rows.Count  - 1
                CmbCity.Items.Add(DataBox.Tables(0).Rows(Loopx).Item("StrCityName"))
            Next
            CmbCity.Text = R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(R2CoreParkingSystemMClassCitys.IRANCityCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSetCityName(YourCityCode As String)
        Try
            CmbCity.Text = R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(YourCityCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetCurrentCityCode() As String
        Try
            If CmbCity.SelectedIndex >= 0 Then Return CmbCity.SelectedItem
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
