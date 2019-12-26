

Imports System.ComponentModel
Imports System.Net.Mime
Imports System.Reflection

Imports R2Core
Imports R2Core.PublicProc
Imports R2CoreGUI

Public Class UCTextBox
    Inherits UCGeneral


    Public Event UC13PressedEvent(ByVal CurrentText As String)
    Public Event UC27PressedEvent()
    Public Event UCRightArrowKeyPressedEvent(CursorPosition As Int64)
    Public Event UCLeftArrowKeyPressedEvent(CursorPosition As Int64)
    Public Event UCGotFocusEvent()
    Public Event UCControlKeyPressedEvent(ByVal CurrentText As String)
    Public Event UCTextChangedEvent(ByVal CurrentText As String)
    Public Event UCDownArrowKeyPressedEvent()
    Public Event UCMaxCharacterReachedEvent(CursorPosition As Int64)



#Region "General Properties"

    <Browsable(True)>
    Public Property UCInputLanguageType As R2Enums.InputLanguageType = R2Enums.InputLanguageType.None

    <Browsable(True)>
    Public Property UCMaxCharacterReached As Int16 = 50

    <Browsable(True)>
    Public Property UCValue As String
        Get
            Return TextBox.Text.Trim
        End Get
        Set(ByVal value As String)
            TextBox.Text = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            TextBox.Font = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    <Browsable(True)>
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            TextBox.BackColor = value
        End Set
    End Property

    Private _UCBackColorDisable As Color = Color.Gainsboro
    <Browsable(True)>
    Public Property UCBackColorDisable() As Color
        Get
            Return _UCBackColorDisable
        End Get
        Set(value As Color)
            _UCBackColorDisable = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    <Browsable(True)>
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            TextBox.ForeColor = value
        End Set
    End Property

    <Browsable(True)>
    Public Property UCOnlyDigit As R2Enums.OnlyDigit = R2Enums.OnlyDigit.Any

    Private _UCEnable As Boolean = True
    <Browsable(True)>
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            If value = True Then
                TextBox.BackColor = UCBackColor
                TextBox.Enabled = True
            Else
                TextBox.BackColor = UCBackColorDisable
                TextBox.Enabled = False
            End If
        End Set
    End Property

    Private _UCPasswordChar As Char = ""
    <Browsable(True)>
    Public Property UCPasswordChar As Char
        Get
            Return _UCPasswordChar
        End Get
        Set(value As Char)
            _UCPasswordChar = value
            TextBox.PasswordChar = value
        End Set
    End Property

    Private _UCTextAlign As HorizontalAlignment = HorizontalAlignment.Center
    <Browsable(True)>
    Public Property UCTextAlign() As HorizontalAlignment
        Get
            Return _UCTextAlign
        End Get
        Set(value As HorizontalAlignment)
            _UCTextAlign = value
            TextBox.TextAlign = value
        End Set
    End Property

    Private _UCMultiLine As Boolean = False
    <Browsable(True)>
    Public Property UCMultiLine() As Boolean
        Get
            Return _UCMultiLine
        End Get
        Set(value As Boolean)
            _UCMultiLine = value
            TextBox.Multiline = value
        End Set
    End Property

    Private _UCBorder As Boolean = True
    <Browsable(True)>
    Public Property UCBorder() As Boolean
        Get
            Return _UCBorder
        End Get
        Set(value As Boolean)
            _UCBorder = value
            PnlMain.Border = value
        End Set
    End Property

    Private _UCBorderColor As Color = Color.DarkGray
    <Browsable(True)>
    Public Property UCBorderColor() As Color
        Get
            Return _UCBorderColor
        End Get
        Set(value As Color)
            _UCBorderColor = value
            PnlMain.BorderColor = value
        End Set
    End Property

    <Browsable(True)>
    Public Property UCMaxNumber As Int64 = 99999


#End Region

#Region "Event Handlers"
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                RaiseEvent UC13PressedEvent(TextBox.Text.Trim)
                e.Handled = True
                Exit Sub
            End If

            If Asc(e.KeyChar) = 27 Then
                RaiseEvent UC27PressedEvent()
                e.Handled = True
                Exit Sub
            End If

            If Asc(e.KeyChar) = 8 Then Exit Sub

            If UCOnlyDigit = R2Enums.OnlyDigit.OnlyDigit Then
                If e.KeyChar >= "0" And e.KeyChar <= "9" Then
                Else
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If TextBox.TextLength >= UCMaxCharacterReached Then
                If TextBox.SelectedText.Trim = String.Empty Then
                    e.Handled = True
                    Exit Sub
                Else
                End If
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox.TextChanged
        RaiseEvent UCTextChangedEvent(TextBox.Text.Trim)
        If TextBox.TextLength = UCMaxCharacterReached Then
            RaiseEvent UCMaxCharacterReachedEvent(TextBox.SelectionStart)
        End If
        UCValue = TextBox.Text
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox.GotFocus
        Try
            R2CoreMClassPublicProcedures.Setkeyboardlayout(UCInputLanguageType)
            RaiseEvent UCGotFocusEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox.KeyUp
        If e.KeyData = Keys.Down Then RaiseEvent UCDownArrowKeyPressedEvent()
        If e.KeyData = Keys.ControlKey Then RaiseEvent UCControlKeyPressedEvent(TextBox.Text.Trim)
    End Sub

    Private Sub UCTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TextBox.Focus()
    End Sub

    Private Sub UCTextBox_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        TextBox.Focus()
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox.KeyDown
        If e.KeyCode = 39 Then RaiseEvent UCRightArrowKeyPressedEvent(TextBox.SelectionStart)
        If e.KeyCode = 37 Then RaiseEvent UCLeftArrowKeyPressedEvent(TextBox.SelectionStart)
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox.Enter
        'Dim position As Integer = textBox.Text.Length
        'textBox.Select(0,0)
        'TextBox.DeselectAll()
    End Sub

    Private Sub TextBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles TextBox.MouseWheel
        Dim NextValue As Int64
        If IsNumeric(TextBox.Text) Then
            If e.Delta > 0 Then
                NextValue = TextBox.Text + 1
                If NextValue > UCMaxNumber Then NextValue = 0
            Else
                NextValue = TextBox.Text - 1
                If NextValue < 0 Then NextValue = UCMaxNumber
            End If
            TextBox.Text = R2Core.PublicProc.R2CoreMClassPublicProcedures.RepeatStr("0", UCMaxCharacterReached - NextValue.ToString.Trim.Length) + NextValue.ToString.Trim()
        End If
    End Sub

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UCValue = ""
        TextBox.Clear()
    End Sub








#End Region

End Class
