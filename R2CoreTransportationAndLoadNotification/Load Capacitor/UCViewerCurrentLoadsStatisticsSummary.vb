
Imports System.ComponentModel
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad


Public Class UCViewerCurrentLoadsStatisticsSummary
    Inherits UCGeneral


#Region "General Properties"




#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


    Public Overloads Sub UCRefreshGeneral()
        Try
            UcLabelAnnounced.UCRefresh()
            UcLabelReleased.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshInformation(YourAHId As Int64, YourAHSGId As Int64)
        Try
            UCRefreshGeneral()
            UcLabelAnnounced.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfAnnouncedLoads(YourAHId, YourAHSGId)
            UcLabelReleased.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfReleasedLoads(YourAHId, YourAHSGId)
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
