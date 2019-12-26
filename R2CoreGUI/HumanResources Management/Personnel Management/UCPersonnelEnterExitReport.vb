
Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Text
Imports Microsoft.Reporting.WinForms

Imports R2Core.ReportsManagement
Imports R2CoreGUI
Imports R2Core.R2PrimaryWS 


Public Class UCPersonnelEnterExitReport
    Inherits UCGeneral

    Private WS As R2PrimaryWebService = New R2PrimaryWebService()


#Region "General Properties"
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
            WS.WebMethodReportingInformationPrividerPersonnelEnterExitReport(UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time)
            R2CoreGUIMClassInformationManagement.PrintReport(R2CoreReports.PersonnelEnterExitReport)
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
