
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.ReportsManagement
Imports R2CoreGUI

Public Class UCDriverTruckLoadReport
    Inherits UCGeneral

    Private WS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService()


#Region "General Properties"


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

    Private Sub UcDateTimeHolder_UCDoCommand() Handles UcDateTimeHolder.UCDoCommand
        Try
            Cursor.Current = Cursors.WaitCursor
            WS.WebMethodReportingInformationPrividerDriverTruckLoadsReport(UcDriver.UCGetNSS().nIdPerson, UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time,WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword))
            R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.DriverTruckLoadsReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UcDriver_UCViewDriverInformationCompleted(DriverId As String) Handles UcDriver.UCViewDriverInformationCompleted
        Try
            UcDriverImage.UCViewDriverImage(PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(DriverId).NSSDriver)
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
