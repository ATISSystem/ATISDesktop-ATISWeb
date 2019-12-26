
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class FrmcMainMenu
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


    Private Sub UcButtonSpecialRegisteringHandyBills_UCClickedEvent() Handles  UcButtonSpecialRegisteringHandyBills.UCClickedEvent
        Try
            Dim Frm As New FrmcRegisteringHandyBills
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialContractorCompanyFinancialReport_UCClickedEvent() Handles  UcButtonSpecialContractorCompanyFinancialReport.UCClickedEvent
        Try
            Dim Frm As New FrmcContractorCompanyFinancialReport
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialUserChargeReport_UCClickedEvent() Handles UcButtonSpecialUserChargeReport.UCClickedEvent
        Try
            Dim Frm As New FrmcUserChargeReport
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialTruckersAssociationFinancialReport_UCClickedEvent() Handles UcButtonSpecialTruckersAssociationFinancialReport.UCClickedEvent
        Try
            Dim Frm As New FrmcTruckersAssociationFinancialReport
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialTransferPersonelFingerPrintsIntoClock4_UCClickedEvent() Handles UcButtonSpecialTransferPersonelFingerPrintsIntoClock4.UCClickedEvent
        Try
            Dim Frm As New FrmcTransferPersonelFingerPrintsIntoClock4
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialPersonnelEnterExitReport_UCClickedEvent() Handles UcButtonSpecialPersonnelEnterExitReport.UCClickedEvent
        Try
            Dim Frm As New FrmcPersonnelEnterExitReport
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialSoldRFIDCardsReport_UCClickedEvent() Handles UcButtonSpecialSoldRFIDCardsReport.UCClickedEvent
        Try
            Dim Frm As New FrmcSoldRFIDCardsReport
            Frm.Show()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
