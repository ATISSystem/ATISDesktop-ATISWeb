
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.ComputersManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement

Public Class UCTurnRegisterRequestConfirmation
    Inherits UCGeneral

    Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure

#Region "General Properties"

    <Browsable(False)>
    Public Property UCChkTruckNobat() As Boolean
        Get
            Return ChkNobatTruck.Checked
        End Get
        Set(value As Boolean)
            ChkNobatTruck.Checked = value
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
            If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreTransportationAndLoadNotificationConfigurations.TurnControlling, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1) = False Then
                Me.Visible = False
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        ChkNobatTruck.Checked = True
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
