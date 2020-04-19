
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.PayanehWS
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.ReportsManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCTruckDriversWaitingToGetLoadPermissionReport
    Inherits UCGeneral

    Private _WS As PayanehClassLibrary.PayanehWS.PayanehWebService = New PayanehWebService()

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

    End Sub

    Private sub UCRefresh
        Try

        Catch ex As Exception

        End Try
    End sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonSpecialViewReport_UCClickedEvent() Handles UcButtonSpecialViewReport.UCClickedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            _WS.WebMethodReportingInformationPrividerTruckDriversWaitingToGetLoadPermissionReport(UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId)
            R2CoreGUIMClassInformationManagement.PrintReport(PayanehClassLibrary.ReportsManagement.PayanehReports.TruckDriversWaitingToGetLoadPermissionReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UcAnnouncementHallSelection_UCCurrentNSSAnnouncementHallSubGroupChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection.UCCurrentNSSAnnouncementHallSubGroupChangedEvent
        Try
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
