
Imports System.ComponentModel
Imports System.Reflection


Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement


Public Class UCComputerMessageProducer
    Inherits UCGeneral

    Protected Event UCCMNoteChanged()
    Protected Event UCRequestSend()

#Region "General Properties"

    Private _UCSendIsActive As Boolean = False
    Public Property UCSendIsActive() As Boolean
        Get
            Return _UCSendIsActive
        End Get
        Set(value As Boolean)
            _UCSendIsActive = value
            UcComputerMessageSender.UCEnable = value
        End Set
    End Property

    Private _UCCMNote As String = String.Empty
    Public Property UCCMNote() As String
        Get
            Return _UCCMNote
        End Get
        Set(value As String)
            _UCCMNote = value
            RaiseEvent UCCMNoteChanged()
        End Set
    End Property


    Private _UCTitle As String = String.Empty
    Public Property UCTitle() As String
        Get
            Return _UCTitle
        End Get
        Set(value As String)
            _UCTitle = value
            UcLabelCMTypeTitle.UCValue = value
        End Set
    End Property

    Private _UCData As DataStruct = Nothing
    <Browsable(False)>
    Public Property UCData() As DataStruct
        Get
            Return _UCData
        End Get
        Set(value As DataStruct)
            _UCData = value
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Sub UCSuccessSendingNotification()
        Try
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "پیام ارسال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcComputerMessageSender_UCClickedEvent() Handles UcComputerMessageSender.UCClickedEvent
        Try
            UCSendIsActive = False
            RaiseEvent UCRequestSend()
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
