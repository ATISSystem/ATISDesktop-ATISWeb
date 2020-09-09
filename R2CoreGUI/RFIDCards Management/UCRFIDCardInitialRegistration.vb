
Imports System.Reflection

Imports R2Core.RFIDCardsManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.PublicProc


Public Class UCRFIDCardInitialRegistration
    Inherits UCGeneral

    Public Event UCRFIDCardInitialRegistered(CardNo As String)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcrfidCardTextMaintainer.UCRefresh()
        TxtBuffer.Clear()
    End Sub

    Public Sub UCInitialRegister(YourCardNo As String)
        Try
            UCRefresh()
            UcrfidCardTextMaintainer.UCValue = YourCardNo
            R2CoreMClassRFIDCardManagement.RFIDCardInitialRegister(YourCardNo,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            RaiseEvent UCRFIDCardInitialRegistered(YourCardNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

  


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonReadBuffer_UCClickedEvent() Handles UcButtonReadBuffer.UCClickedEvent
        Try
            TxtBuffer.Clear()
            Dim myBuffer As String = String.Empty
            If R2CoreRFIDCardReaderInterface.StartReadBuffer(myBuffer) = 0 Then
                TxtBuffer.Text = myBuffer
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess,"بافر کارت مورد نظر با موفقیت خوانده شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning,"عدم موفقیت هنگام خواندن بافر کارت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonWriteBuffer_UCClickedEvent() Handles UcButtonWriteBuffer.UCClickedEvent
        Try
            R2CoreRFIDCardReaderInterface.StartWriteBuffer(TxtBuffer.Text)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub LblDefualtText_Click(sender As Object, e As EventArgs) Handles LblDefualtText.Click
        TxtBuffer.Text = R2coreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.RFIDCardDefultBuffer,0)
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
