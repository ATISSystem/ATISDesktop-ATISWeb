
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls
Imports PayanehClassLibrary.ProcessesManagement
Imports PayanehClassLibrary.ReportsManagement
Imports R2Core.ProcessesManagement
Imports R2CoreGUI

Public Class FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport
    Inherits FrmcGeneral



    Private WS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService()


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefesh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefesh()
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcDateTimeHolder_UCDoCommand() Handles UcDateTimeHolder.UCDoCommand
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim AnnouncemenetHall As Int64
            If RBAllAnnouncementHall.Checked = True Then
                AnnouncemenetHall = AnnouncementHalls.General
            Else
                If UcucAnnouncementHallCollection.UCCurrentNSS Is Nothing Then
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "سالن اعلام بار مورد نظر را انتخاب نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                    Exit Try
                End If
                AnnouncemenetHall = UcucAnnouncementHallCollection.UCCurrentNSS.AHId
            End If

            Dim TargetCityId As Int64 = IIf(ChkLoadTargetCity.Checked, UcSearcherLoadTargets.UCGetSelectedNSS.OCode, Int64.MinValue)

            If RBAllCompany.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(AnnouncemenetHall, Int64.MinValue, UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, TargetCityId)
            ElseIf RBSpecialCompany.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(AnnouncemenetHall, UcSearcherTransportCompanies.UCGetSelectedNSS.OCode, UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, TargetCityId)
            End If

            R2CoreGUIMClassInformationManagement.PrintReport(PayanehReports.CapacitorLoadsTransportCompaniesRegisteredLoadsReport)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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