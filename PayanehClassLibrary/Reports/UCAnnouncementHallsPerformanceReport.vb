
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls
Imports R2CoreGUI
Imports PayanehClassLibrary.ReportsManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions


Public Class UCAnnouncementHallsPerformanceReport
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
            UcDateTimeHolder.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcDateTimeHolder_UCDoCommand() Handles UcDateTimeHolder.UCDoCommand
        Try
            Cursor.Current = Cursors.WaitCursor
            If UcucAnnouncementHallCollection.UCCurrentNSS Is Nothing Then Throw new AnnouncementHallNotSelectedException
            WS.WebMethodReportingInformationPrividerAnnouncementHallsPerformanceReport(UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time,UcucAnnouncementHallCollection.UCCurrentNSS.AHId)
            If UcucAnnouncementHallCollection.UCCurrentNSS.AHId = AnnouncementHalls.Anbari Then
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.AnbariAnnouncementHallPerformanceReport)
            ElseIf UcucAnnouncementHallCollection.UCCurrentNSS.AHId = AnnouncementHalls.Otaghdar Then
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.OtaghdarAnnouncementHallPerformanceReport)
            ElseIf UcucAnnouncementHallCollection.UCCurrentNSS.AHId = AnnouncementHalls.Zobi Then
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.ZobiAnnouncementHallPerformanceReport)
            ElseIf UcucAnnouncementHallCollection.UCCurrentNSS.AHId = AnnouncementHalls.Shahri Then
                R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.ShahriAnnouncementHallPerformanceReport)
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
