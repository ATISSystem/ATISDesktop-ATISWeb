
Imports System.Reflection

Imports R2CoreWinFormRemoteApplications

Public Class FrmcMainMenuLocal
    Inherits R2CoreWinFormRemoteApplications.FrmcMainMenu

    Private _FrmMessageDialog As New FrmcMessageDialog


#Region "General Properties"

    Private _FrmOwner As Form = Nothing
    Public Property FrmOwner() As Form
        Get
            Return _FrmOwner
        End Get
        Set(value As Form)
            _FrmOwner = value
            Owner = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Location = New Point(5, 121)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
            Me.Height = My.Computer.Screen.WorkingArea.Height - (New FrmcMain).Size.Height - 12
            ViewFirstPageMessages()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ViewFirstPageMessages()
        Try
            UcLabelDailyMessage.UCRefresh()
            UcLabelFixMessage1.UCRefresh()
            UcLabelFixMessage2.UCRefresh()
            UcLabelFixMessage3.UCRefresh()
            Dim DailyMessageColor As String = String.Empty
            UcLabelDailyMessage.UCValue = TransportCompaniesLoadCapacitorLoadsManipulation.GetTransportCompaniesDailyMessage(DailyMessageColor)
            UcLabelDailyMessage.UCForeColor = Color.FromName(DailyMessageColor)
            Dim FirstPageMessages As String = TransportCompaniesLoadCapacitorLoadsManipulation.GetTransportCompaniesFirstPageMessages()
            UcLabelFixMessage1.UCValue = Split(FirstPageMessages, "-")(0).Trim
            UcLabelFixMessage2.UCValue = Split(FirstPageMessages, "-")(1).Trim
            UcLabelFixMessage3.UCValue = Split(FirstPageMessages, "-")(2).Trim
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Owner = _FrmOwner
    End Sub

    Private Sub UcButtonSpecialUserTransportCompanyLoadCapacitorLoadManipulation_UCClickedEvent() Handles UcButtonSpecialUserTransportCompanyLoadCapacitorLoadManipulation.UCClickedEvent
        Try
            Dim Frm As New FrmcTransportCompanyLoadCapacitorLoadsManipulation
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UcButtonSpecialTransportCompanyLoadCapacitorSedimentLoadAllocation_UCClickedEvent() Handles UcButtonSpecialTransportCompanyLoadCapacitorSedimentLoadAllocation.UCClickedEvent
        Try
            Dim Frm As New FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UcButtonSpecialTruckDriverMobileNumberRegistering_UCClickedEvent() Handles UcButtonSpecialTruckDriverMobileNumberRegistering.UCClickedEvent
        Try
            Dim Frm As New FrmcMobileUserMobileNumberRegistering
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
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
