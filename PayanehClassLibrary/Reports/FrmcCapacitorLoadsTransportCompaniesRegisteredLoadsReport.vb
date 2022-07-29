
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.ProcessesManagement
Imports PayanehClassLibrary.ReportsManagement
Imports R2Core.DesktopProcessesManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
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
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcCapacitorLoadsTransportCompaniesRegisteredLoadsReport))
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

            Dim AHId = AnnouncementHalls.None
            Dim AHSGId = AnnouncementHallSubGroups.None
            If RBAllAnnouncementHall.Checked = True Then
                If UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall Is Nothing Then Throw New R2Core.ExceptionManagement.DataEntryException
                AHId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId
                AHSGId = AnnouncementHallSubGroups.None
            Else
                If UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup Is Nothing Then Throw New R2Core.ExceptionManagement.DataEntryException
                AHId = AnnouncementHalls.None
                AHSGId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId
            End If

            Dim TargetCityId As Int64
            If ChkLoadTargetCity.Checked Then TargetCityId = UcSearcherLoadTargets.UCGetSelectedNSS.OCode Else TargetCityId = Int64.MinValue

            If RBAllCompany.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(AHId, AHSGId, Int64.MinValue, UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, TargetCityId, WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword))
            ElseIf RBSpecialCompany.Checked = True Then
                WS.WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(AHId, AHSGId, UcSearcherTransportCompanies.UCGetSelectedNSS.OCode, UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, TargetCityId, WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword))
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