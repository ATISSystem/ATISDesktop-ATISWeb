
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports R2Core.DateAndTimeManagement

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.TransportCompanies
Imports R2CoreTransportationAndLoadNotification.TransportCompanies.Exceptions


Public Class UCUCTransportCompanyCollection
    Inherits UCGeneral

    Public Event UCCurrentNSSChangedEvent()
    Private _UCIsFirstUse As Boolean = True


#Region "General Properties"

    Private _UCCurrentNSS As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure = Nothing
    <Browsable(False)>
    Public Property UCCurrentNSS() As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
            _UCCurrentNSS = value
            If value IsNot Nothing Then If Not _UCIsFirstUse Then RaiseEvent UCCurrentNSSChangedEvent()
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

    Private _UCDefaultTransportComapnyId As Int64 = Int64.MinValue
    <Browsable(False), Localizable(True)>
    Public Property UCDefaultTransportComapnyId() As Int64
        Get
            Return _UCDefaultTransportComapnyId
        End Get
        Set(value As Int64)
            _UCDefaultTransportComapnyId = value
            UCActiveThisNSS(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompany(value))
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewCollection(AnnouncementHalls.AnnouncementHalls.Zobi, AnnouncementHalls.AnnouncementHallSubGroups.Zobi)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        UCCurrentNSS = Nothing
    End Sub

    Public Sub UCViewCollection(YourAHId As Int64, YourAHSGId As Int64)
        Try
            Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure) = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetTransportCompaniesFullOfWork(True, True, New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing), New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing), YourAHId, YourAHSGId)
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim UC As New UCViewerNSSTransportComapny
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Right
                AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
            Try
                UCActiveThisNSS(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompany(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetNSSTransportCompanyFullOfWorkCompany(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing), New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing), YourAHId, YourAHSGId).TCId))
            Catch ex As TransportCompanyNotFoundException
            End Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCActiveThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
        Try
            Dim OUC As UCViewerNSSTransportComapny = Nothing
            For Each UC As UCViewerNSSTransportComapny In PnlUCs.Controls
                If UC.UCNSSCurrent.TCId <> YourNSS.TCId Then
                    UC.UCShowUnActive()
                Else
                    OUC = UC
                End If
            Next
            UCCurrentNSS = YourNSS
            OUC.UCShowActive()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSimulateThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure)
        Try
            UCActiveThisNSS(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCs_UCClickedEvent(SenderUC As UCTransportCompany)
        Try
            _UCIsFirstUse = False
            UCActiveThisNSS(SenderUC.UCNSSCurrent)
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
