
Imports System.ComponentModel
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCAnnouncementHallSelection
    Inherits UCGeneral

    Public Event UCCurrentNSSChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)


#Region "General Properties"

    Private _UCNSSCurrentAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(AnnouncementHalls.AnnouncementHalls.Zobi)
    <Browsable(False)>
    Public ReadOnly Property UCNSSCurrentAnnouncementHall() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
        Get
            Return _UCNSSCurrentAnnouncementHall
        End Get
    End Property

    Private _UCNSSCurrentAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = Nothing
    <Browsable(False)>
    Public ReadOnly Property UCNSSCurrentAnnouncementHallSubGroup() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
        Get
            Return _UCNSSCurrentAnnouncementHallSubGroup
        End Get
    End Property



#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UcucAnnouncementHallCollection.UCSimulateThisNSS(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(AnnouncementHalls.AnnouncementHalls.Zobi))
            _UCNSSCurrentAnnouncementHall = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(AnnouncementHalls.AnnouncementHalls.Zobi)
            UcucAnnouncementHallSubGroupCollection.UCViewCollection(R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Zobi)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        UcucAnnouncementHallCollection.UCRefresh()
        UcucAnnouncementHallSubGroupCollection.UCRefresh()
    End Sub

    Private Sub UCRaiseNSSChangedEvent()
        Try
            If UCNSSCurrentAnnouncementHallSubGroup Is Nothing Then Exit Sub
            RaiseEvent UCCurrentNSSChangedEvent(UcucAnnouncementHallCollection.UCCurrentNSS, UcucAnnouncementHallSubGroupCollection.UCCurrentNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcucAnnouncementHallCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallCollection.UCCurrentNSSChangedEvent
        Try
            UcucAnnouncementHallSubGroupCollection.UCRefresh()
            _UCNSSCurrentAnnouncementHall = UcucAnnouncementHallCollection.UCCurrentNSS
            _UCNSSCurrentAnnouncementHallSubGroup = Nothing
            UcucAnnouncementHallSubGroupCollection.UCViewCollection(UcucAnnouncementHallCollection.UCCurrentNSS.AHId)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAnnouncementHallSubGroupCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallSubGroupCollection.UCCurrentNSSChangedEvent
        Try
            _UCNSSCurrentAnnouncementHallSubGroup = UcucAnnouncementHallSubGroupCollection.UCCurrentNSS
            UCRaiseNSSChangedEvent()
        Catch ex As Exception
            UcucAnnouncementHallSubGroupCollection.UCViewCollection(UcucAnnouncementHallCollection.UCCurrentNSS.AHId)
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
