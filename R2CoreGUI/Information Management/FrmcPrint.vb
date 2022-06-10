
Imports System.Reflection
Imports Microsoft.Reporting.WinForms
Imports System.Drawing

Imports R2Core.ConfigurationManagement
Imports R2Core.DesktopProcessesManagement
Imports R2Core.ReportsManagement


Public Class FrmcPrint
    Inherits FrmcGeneral



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            LblformPersianName.Text = "پیش نمایش"
            LblformEnglishName.Text = "FrmcPrint"
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub ViewChopRdlc(ByVal ReportPath As String, ByVal RSource As Microsoft.Reporting.WinForms.ReportDataSource)
        Try
            Dim RV As Microsoft.Reporting.WinForms.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
            Me.PnlPrint.Controls.Add(RV)
            RV.Dock = DockStyle.Fill
            RV.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

            'RV.PageSetupDialog()
            'RV.PrintDialog()
            'Dim PageS As System.Drawing.Printing.PageSettings = New System.Drawing.Printing.PageSettings()
            'PageS.Margins = New Printing.Margins(0, 0, 0, 0)
            'PageS.PaperSize = New Printing.PaperSize()
            'PageS.PaperSize.RawKind = Printing.PaperKind.A4
            'Dim PrinterS As Printing.PrinterSettings = New Printing.PrinterSettings()
            'RV.SetPageSettings(PageS)

            RV.LocalReport.DataSources.Add(RSource)
            RV.LocalReport.ReportPath = ReportPath
            'RV.LocalReport.ReportEmbeddedResource = ReportEmbeddedResource
            RV.RefreshReport()
          
        Catch ex As Exception
            Throw New Exception("FrmcChop.ViewChopRdlc()." + ex.Message.ToString)
        End Try
    End Sub

    Public Sub ViewChopRdl(ByVal YourReportId As Int64)
        Try
            Dim NSS As R2StandardReportStructure =R2CoreMClassReportsManagement.GetNSSReport(YourReportId)
            ReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
            ReportViewer.ZoomMode=ZoomMode.PageWidth
            ReportViewer.ServerReport.ReportPath =NSS.ReportServerPath +NSS.RFullName
            ReportViewer.ServerReport.ReportServerUrl = New System.Uri(NSS.ReportServerURL, System.UriKind.Absolute)
            Dim ReportServerCredentialUserName As String = Split(NSS.ReportServerCredential, ";")(0)
            Dim ReportServerCredentialPassword As String =Split(NSS.ReportServerCredential,";")(1)
            ReportViewer.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential(ReportServerCredentialUserName, ReportServerCredentialPassword)
            ReportViewer.RefreshReport()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub ViewChopRpt(ByVal ReportName As String)
        Try
            'Dim CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
            'CrystalReportViewer.DisplayGroupTree = False
            'Me.PnlChop.Controls.Add(CrystalReportViewer)
            'CrystalReportViewer.Dock = DockStyle.Fill
            'CrystalReportViewer.ReportSource = R2Core.DatabaseManagement.R2MClassDatabaseManagement.RptPaths(R2DepartementDore) + ReportName
            'CrystalReportViewer.RefreshReport()
        Catch ex As Exception
            Throw New Exception("FrmcChop.ViewChopRpt()." + ex.Message.ToString)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

   

    Private Sub FrmcPrint__ExitRequest() Handles Me._ExitRequest
        Me.Close()
        Me.Dispose()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class