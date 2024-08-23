
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class UCLoadingAndDischargingPlace
    Inherits UCGeneralExtended


    Public Event UCNSSCurrentChangedtoNull()
    Public Event UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure)
    Public Event UCClickedEvent(UC As UCLoadingAndDischargingPlace)


#Region "General Properties"

    Private _UCNSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure)
            _UCNSSCurrent = value
            If value Is Nothing Then
                RaiseEvent UCNSSCurrentChangedtoNull()
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

    Public Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourLADPId As Int64)
        Try
            Dim InstanceLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager
            UCNSSCurrent = InstanceLoadingAndDischargingPlaces.GetNSSLoadingAndDischargingPlace(YourLADPId, True)
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"

    Protected Sub UCOnClickedEvent(YourUC As UCLoadingAndDischargingPlace)
        RaiseEvent UCClickedEvent(YourUC)
    End Sub

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
