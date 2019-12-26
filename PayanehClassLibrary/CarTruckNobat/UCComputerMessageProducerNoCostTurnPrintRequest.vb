
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2CoreGUI

Public Class UCComputerMessageProducerNoCostTurnPrintRequest
    Inherits UCComputerMessageProducerTurnPrintRequest

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New ()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerNoCostTurnPrintRequest_UCRequestSend() Handles Me.UCRequestSend
        Try
            Dim NSSTurn = PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(UcCar.UCGetNSS())
            PayanehClassLibraryMClassCarTruckNobatManagement.NoCostTurnPrintRequest(NSSTurn, True)
            UCSuccessSendingNotification()
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
