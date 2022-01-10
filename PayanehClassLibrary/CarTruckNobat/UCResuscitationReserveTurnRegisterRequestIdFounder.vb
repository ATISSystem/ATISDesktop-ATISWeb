

Imports System.ComponentModel
Imports System.Reflection
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns
Imports R2CoreTransportationAndLoadNotification.Turns.TurnRegisterRequest

Public Class UCResuscitationReserveTurnRegisterRequestIdFounder
    Inherits UCGeneral

#Region "General Properties"

    <Browsable(False)>
    Private _UCCurrentNSS As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure = Nothing
    Public ReadOnly Property UCGetCurrentNSS As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure
        Get
            Try
                If _UCCurrentNSS Is Nothing Then Throw New DataEntryException
                Return _UCCurrentNSS
            Catch ex As DataEntryException
                Throw ex
            End Try
        End Get
    End Property

    Private Sub UCSetCurrentNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardTurnRegisterRequestStructure)
        _UCCurrentNSS = YourNSS
        If YourNSS IsNot Nothing Then
            UcLabelTurnRegisteringRequestId.UCValue = _UCCurrentNSS.TRRId
            CButtonTurnPrintRequestIdFound.Enabled = False
        Else
            UcLabelTurnRegisteringRequestId.UCValue = 0
            CButtonTurnPrintRequestIdFound.Enabled = True
        End If
    End Sub

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

    Private Sub CButtonTurnPrintRequestIdFound_Click(sender As Object, e As EventArgs) Handles CButtonTurnPrintRequestIdFound.Click
        Try
            Dim InstanceTurnRegisterRequest = New R2CoreTransportationAndLoadNotificationMClassTurnRegisterRequestManager
            UCSetCurrentNSS(InstanceTurnRegisterRequest.GetNSSTurnRegisteringRequestWithReservedDateTime(UcPersianDateTimeEntry.GetPersianDateTime()))
            CButtonTurnPrintRequestIdFound.Enabled = False
        Catch ex As TurnRegisterRequestNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianDateTimeEntry_UCDateTimeChangedEvent() Handles UcPersianDateTimeEntry.UCDateTimeChangedEvent
        UCSetCurrentNSS(Nothing)
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
