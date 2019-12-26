
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement

Public Class UCShamsiDate
    Inherits UCGeneral


    Public Event UC13Pressed(ByVal ShamsiDate As String)
    Public Event UC27Pressed()
    Private ReadOnly _DateTime As R2DateTime = New R2DateTime


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            TxtShamsiDate.Text = _DateTime.GetCurrentDateShamsiFull
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

    Private Sub TxtShamsiDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtShamsiDate.KeyPress
        Try
            If (e.KeyChar >= "0" And e.KeyChar <= "9") Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Or Asc(e.KeyChar) = 8 Or e.KeyChar = "/" Then
                If Asc(e.KeyChar) = 13 Then
                    If _DateTime.ChekDateShamsiFullSyntax (TxtShamsiDate.Text) = True Then
                        RaiseEvent UC13Pressed(TxtShamsiDate.Text.Trim)
                        e.Handled = True
                    Else
                        UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry,"تاریخ شمسی نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                        e.Handled = True
                    End If
                End If
                If Asc(e.KeyChar) = 27 Then RaiseEvent UC27Pressed()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,"UCShamsiDate.TxtShamsiDate_KeyPress" + vbCrLf + ex.Message, "بروز خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    'Private Sub TxtShamsiDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtShamsiDate.Validating
    '    If MClassDateAndTimeManagement.ChekDateSyntax(TxtShamsiDate.Text) = False Then
    '        FrmMessageDialog.ViewDialogMessage("تاریخ شمسی نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing,me)
    '    End If
    'End Sub

    Private _ShamsiDate As String = String.Empty
    <DefaultValue("")>
    Public Property UCStartUpValue As String
        Get
            Return _ShamsiDate
        End Get
        Set(ByVal value As String)
            _ShamsiDate = value
            TxtShamsiDate.Text = value
        End Set
    End Property

    Public Sub UCSetValue(ByVal YourValue As String)
        If _DateTime.ChekDateShamsiFullSyntax (YourValue) = True Then
            TxtShamsiDate.Text = YourValue
        Else
            Throw New Exception("تاریخ شمسی نادرست است" + vbCrLf + YourValue)
        End If
    End Sub

    Public Sub UCSetValueFirstDayOfYear()
        TxtShamsiDate.Text =_DateTime.GetCurrentSalShamsiFull + "/01/01"
    End Sub

    Public Function UCGetValue() As String
        If _DateTime.ChekDateShamsiFullSyntax(TxtShamsiDate.Text) = True Then
            Return TxtShamsiDate.Text.Trim
        Else
            Throw New Exception("تاریخ شمسی نادرست است" + vbCrLf + TxtShamsiDate.Text.Trim)
        End If
    End Function

    Public Sub UCRefresh()
        TxtShamsiDate.Clear()
    End Sub

    Private Sub UCShamsiDate_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtShamsiDate.Focus()
    End Sub
End Class
