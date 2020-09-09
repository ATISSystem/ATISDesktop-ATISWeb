
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement

Public Class UCComputerMessageProducerReplicaTurnPrintRequest
    Inherits UCComputerMessageProducerTurnPrintRequest

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

    Private Sub UCComputerMessageProducerReplicaTurnPrintRequest_UCRequestSend() Handles Me.UCRequestSend
        Try
            Dim NSSTurn = PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(UcCar.UCGetNSS())
            PayanehClassLibraryMClassCarTruckNobatManagement.ReplicaTurnPrintRequest(NSSTurn, True,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCSuccessSendingNotification()
        Catch ex As Exception When TypeOf ex Is GetNobatException OrElse TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException OrElse TypeOf ex Is MoneyWalletNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
