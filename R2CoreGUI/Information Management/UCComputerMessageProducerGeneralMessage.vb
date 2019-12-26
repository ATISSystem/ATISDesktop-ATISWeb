
Imports System.Reflection
Imports R2Core.ComputerMessagesManagement

Public Class UCComputerMessageProducerGeneralMessage
    Inherits UCComputerMessageProducer

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

  
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerGeneralMessage_UCRequestSend() Handles Me.UCRequestSend
        Try
            R2CoreMClassComputerMessagesManagement.SendComputerMessage(new R2StandardComputerMessageStructure(Nothing,UCCMNote,R2Core.ComputerMessagesManagement.R2CoreComputerMessageTypes.GeneralMessage ,Nothing,Nothing,Nothing,Nothing,Nothing,Nothing,Nothing,Nothing))
            UCSuccessSendingNotification()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCGotFocusEvent() Handles UcPersianTextBox.UCGotFocusEvent
        UcPersianTextBox.UCRefresh()
        UcPersianTextBox.UCForeColor=Color.Black
    End Sub

    Private Sub UcPersianTextBox_UCTextChangedEvent(PersianText As String) Handles UcPersianTextBox.UCTextChangedEvent
        UCCMNote=UcPersianTextBox.UCValue
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
