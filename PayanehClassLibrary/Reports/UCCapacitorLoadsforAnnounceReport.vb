
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls
Imports PayanehClassLibrary.ReportsManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCCapacitorLoadsforAnnounceReport
    Inherits UCGeneral

    Private WS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService()


#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
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
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub RBs_CheckedChanged(sender As Object, e As EventArgs) Handles RBAll.CheckedChanged, RBSubGroup.CheckedChanged
        UCRefresh()
    End Sub

    Private Sub UcucAnnouncementHallCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallCollection.UCCurrentNSSChangedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            UcucAnnouncementHallSubGroupCollection.UCViewCollection(UcucAnnouncementHallCollection.UCCurrentNSS.AHId)
            If RBAll.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsforAnnounceReport(UcucAnnouncementHallCollection.UCCurrentNSS.AHId, AnnouncementHallsManagement.AnnouncementHalls.AnnouncementHalls.None)
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.CapacitorLoadsforAnnounceReport)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UcucAnnouncementHallSubGroupCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallSubGroupCollection.UCCurrentNSSChangedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            If RBSubGroup.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsforAnnounceReport(UcucAnnouncementHallCollection.UCCurrentNSS.AHId, UcucAnnouncementHallSubGroupCollection.UCCurrentNSS.AHSGId)
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.CapacitorLoadsforAnnounceReport)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
