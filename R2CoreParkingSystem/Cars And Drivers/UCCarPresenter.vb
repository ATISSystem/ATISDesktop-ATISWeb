
Imports System.Reflection
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars

Public Class UCCarPresenter
    Inherits UCGeneral

    Private _NSSCar As R2StandardCarStructure = Nothing

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcLabelStrCarNo.UCRefreshGeneral() : UcLabelStrCarSerialNo.UCRefreshGeneral()
        UcCmbCity.UCRefresh() : UcCmbCarType.UCRefresh()
        UcLabelStrCarNo.Focus()
    End Sub

    Public Sub UCViewCarInformation(YourNSSCar As R2StandardCarStructure)
        Try
            _NSSCar = YourNSSCar
            UCRefresh()
            UcLabelStrCarNo.UCValue = YourNSSCar.StrCarNo
            UcLabelStrCarSerialNo.UCValue = YourNSSCar.StrCarSerialNo
            UcCmbCity.UCSetCityName(YourNSSCar.nIdCity)
            UcCmbCarType.UCSetCarTypeName(YourNSSCar.snCarType)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2StandardCarStructure
        Try
            Return _NSSCar
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
