
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCUCAnnouncementHallCollection
    Inherits UCGeneral

    Public Event UCCurrentNSSChangedEvent()
    Private _UCIsFirstUse As Boolean = True

#Region "General Properties"

    Private _UCCurrentNSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = Nothing
    <Browsable(False)>
    Public Property UCCurrentNSS() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure)
            _UCCurrentNSS = value
            If value IsNot Nothing Then If Not _UCIsFirstUse Then RaiseEvent UCCurrentNSSChangedEvent()
        End Set
    End Property

    Private _UCViewBorder As Boolean = True
    Public Property UCViewBorder() As Boolean
        Get
            Return _UCViewBorder
        End Get
        Set(value As Boolean)
            _UCViewBorder = value
            If value = True Then
                PnlMain.Padding = New Padding(2)
            Else
                PnlMain.Padding = New Padding(0)
            End If
        End Set
    End Property

    Private _UCDefaultAHId As Int64 = R2CoreTransportationAndLoadNotification.AnnouncementHalls.AnnouncementHalls.Zobi
    Public Property UCDefaultAHId() As Int64
        Get
            Return _UCDefaultAHId
        End Get
        Set(value As Int64)
            _UCDefaultAHId = value
            UCActiveThisNSS(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(value))
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewCollection()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        UCCurrentNSS = Nothing
    End Sub

    Public Sub UCViewCollection()
        Try
            Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure) = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHalls()
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim UC As New UCViewerNSSAnnouncementHall
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Right
                AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCActiveThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure)
        Try
            Dim OUC As UCViewerNSSAnnouncementHall = Nothing
            For Each UC As UCViewerNSSAnnouncementHall In PnlUCs.Controls
                If UC.UCNSSCurrent.AHId <> YourNSS.AHId Then
                    UC.UCShowUnActive()
                Else
                    OUC = UC
                End If
            Next
            UCCurrentNSS = YourNSS
            OUC.UCShowActive()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSimulateThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure)
        Try
            UCActiveThisNSS(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCs_UCClickedEvent(SenderUC As UCAnnouncementHall)
        Try
            _UCIsFirstUse = False
            UCActiveThisNSS(SenderUC.UCNSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
