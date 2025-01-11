
Imports System.ComponentModel
Imports System.Reflection
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars

Public Class UCCarNativeness
    Inherits UCGeneral

    Public Event UCNSSCurrentChanged(NSSCurrent As R2StandardCarStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2StandardCarStructure)
    Protected Event UCViewNSSNothingRequested()



#Region "General Properties"

    Private _UCNSSCurrent As R2StandardCarStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2StandardCarStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2StandardCarStructure)
            _UCNSSCurrent = value
            If value Is Nothing Then
                RaiseEvent UCViewNSSNothingRequested()
            Else
                RaiseEvent UCNSSCurrentChanged(_UCNSSCurrent)
            End If
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardCarStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourCarId As Int64)
        Try
            Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
            UCNSSCurrent = InstanceCars.GetNSSCar(YourCarId)
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

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
