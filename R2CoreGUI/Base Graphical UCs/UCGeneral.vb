
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core
Imports R2Core.DateAndTimeManagement
Imports R2Core.RFIDCardsManagement

Public Class UCGeneral
    Inherits UserControl
    Implements R2CoreRFIDCardRequester

    Protected Event _RFIDCardReadedEvent(CardNo As String)
    Protected Event _RFIDCardStartToReadEvent()
    Protected _DateTime As New R2DateTime

    ''Protected _FrmMessageDialog As new  FrmcMessageDialog
    Protected Event UCDisposeResourcesRequest()
    Protected Event UCGotFocusedEvent()


    Private _UCFrmMessageDialog As FrmcMessageDialog = New FrmcMessageDialog()
    <Browsable(False)>
    Protected ReadOnly Property UCFrmMessageDialog As FrmcMessageDialog
        Get
            If _UCFrmMessageDialog Is Nothing Then _UCFrmMessageDialog = New FrmcMessageDialog()
            Return _UCFrmMessageDialog
        End Get
    End Property

    Public Overridable Sub UCRefreshGeneral()
    End Sub

    Protected Overridable Sub UCRefreshInformation()
    End Sub

    Public Overridable Sub DisposeResources()
    End Sub


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCGeneral_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        DisposeResources()
    End Sub

    Public Sub UCFocus()
        RaiseEvent UCGotFocusedEvent()
    End Sub

    Public Sub StartReading()
        Try
            R2Core.RFIDCardsManagement.R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
        Try
            RaiseEvent _RFIDCardStartToReadEvent()
        Catch ex As Exception
            _UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name+ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            RaiseEvent _RFIDCardReadedEvent(CardNo)
        Catch ex As Exception
            _UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
        _UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + MessageWarning, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
    End Sub

End Class
