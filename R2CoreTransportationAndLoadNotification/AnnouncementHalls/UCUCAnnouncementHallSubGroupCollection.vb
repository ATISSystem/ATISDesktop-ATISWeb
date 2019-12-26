
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCUCAnnouncementHallSubGroupCollection
    Inherits UCGeneral


    Public Event UCCurrentNSSChangedEvent()

#Region "General Properties"

    Private _UCCurrentNSS As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure = Nothing
    <Browsable(False)>
    Public Property UCCurrentNSS() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure)
            _UCCurrentNSS = value
            If value IsNot Nothing Then RaiseEvent UCCurrentNSSChangedEvent()
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

    Public sub UCRefresh
        UCCurrentNSS=Nothing
    End sub

    Public Sub UCViewCollection(YourAHId As Int64)
        Try
            Dim NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHall(YourAHId)
            Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) = R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetAnnouncementHallSubGroups(YourAHId)
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim UC As New UCViewerNSSAnnouncementHallSubGroup
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




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UCs_UCClickedEvent(SenderUC As UCAnnouncementHallSubGroup)
        Try
            UCCurrentNSS = SenderUC.UCNSSCurrent
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
