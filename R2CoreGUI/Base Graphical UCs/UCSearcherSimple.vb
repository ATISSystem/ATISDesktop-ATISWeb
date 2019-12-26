
Imports System.Reflection

Public Class UCSearcherSimple
    Inherits UCGeneral

    Public Event UC13PressedEvent(SearchString As String)


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

    Private Sub UcPersianTextBox_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox.UC13PressedEvent
        Try
            RaiseEvent UC13PressedEvent(UcPersianTextBox.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
       End Try
    End Sub

    Private Sub PicReturn_Click(sender As Object, e As EventArgs) Handles PicReturn.Click
        Try
            RaiseEvent UC13PressedEvent(UcPersianTextBox.UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcher_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        UcPersianTextBox.Focus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
