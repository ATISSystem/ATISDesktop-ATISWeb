

Imports System.Reflection

Imports PayanehClassLibrary.TurnRegisterRequest
Imports PayanehClassLibrary.TurnRegisterRequest.Exceptions
Imports R2Core.ComputersManagement
Imports R2Core.ExceptionManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions

Public Class UCReserveTurnRegisterRequest
    Inherits UCGeneral

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

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            Dim InstanceComputers = New R2CoreMClassComputersManager
            Dim TurnRegisterRequestId = PayanehClassLibraryMClassTurnRegisterRequestManagement.ReserveTurnRegisterRequest(InstanceComputers.GetNSSCurrentComputer().MId, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "درخواست صدور نوبت رزرو با موفقیت صادر شد" + vbCrLf + "شماره درخواست" + vbCrLf + TurnRegisterRequestId.ToString(), "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception When TypeOf ex Is TurnRegisterRequestTypeNotFoundException _
                                OrElse TypeOf ex Is UserCanNotRequestReserveTurnRegisteringException _
                                OrElse TypeOf ex Is ComputerCanNotRequestReserveTurnRegisteringException _
                                OrElse TypeOf ex Is TruckNotFoundException _
                                OrElse TypeOf ex Is SequentialTurnNotFoundException _
                                OrElse TypeOf ex Is TruckDriverNotFoundException _
                                OrElse TypeOf ex Is TurnRegisterRequestNotFoundException _
                                OrElse TypeOf ex Is GetNSSException _
                                OrElse TypeOf ex Is GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
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
