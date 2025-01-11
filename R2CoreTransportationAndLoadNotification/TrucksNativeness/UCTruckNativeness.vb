

Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.TransportCompanies
Imports R2CoreTransportationAndLoadNotification.Trucks

Public Class UCTruckNativeness
    Inherits UCGeneral

    Public Event UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
    Protected Event UCViewNSSNothingRequested()


#Region "General Properties"

    Private _UCNSSCurrent As R2CoreTransportationAndLoadNotificationStandardTruckStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2CoreTransportationAndLoadNotificationStandardTruckStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
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

    Public Sub UCViewNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourTruckId As Int64)
        Try
            Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
            UCNSSCurrent = InstanceTrucks.GetNSSTruck(YourTruckId)
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
