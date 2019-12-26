
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns

Public Class UCSequentialTurn
    Inherits UCGeneral


    Public Event UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)


#Region "General Properties"
    Private _UCNSSCurrent As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
            _UCNSSCurrent = value
            RaiseEvent UCNSSCurrentChanged(_UCNSSCurrent)
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourSeqTId As Int64)
        Try
            UCNSSCurrent = R2CoreTransportationAndLoadNotificationMClassSequentialTurnsManagement.GetNSSSequentialTurn(YourSeqTId)
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCShowUnActive()
        UCChangeBackColor(Color.Gray)
    End Sub

    Public Sub UCShowActive()
        UCChangeBackColor(Color.FromName(UCNSSCurrent.SequentialTurnColor))
    End Sub

    Protected Sub UCChangeBackColor(YourColor As Color)
        Me.BackColor = YourColor
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
