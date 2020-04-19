
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.PayanehWS
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCTransportPriceTarrifsReport
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
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcAnnouncementHallSelection_UCCurrentNSSAnnouncementHallSubGroupChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection.UCCurrentNSSAnnouncementHallSubGroupChangedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            _WS.WebMethodReportingInformationProviderTransportPriceTarrifsReport(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId, RBAll.Checked <> True)
            R2CoreGUIMClassInformationManagement.PrintReport(ReportsManagement.PayanehReports.TransportPriceTarrifsReport)
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
