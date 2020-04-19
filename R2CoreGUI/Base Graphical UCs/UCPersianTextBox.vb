

Imports System.ComponentModel
Imports System.Reflection

Imports R2Core
Imports R2Core.PublicProc


Public Class UCPersianTextBox
    Inherits UCGeneral

    Public Event UC13PressedEvent(ByVal PersianText As String)
    Public Event UCEnterControlPressedEvent(ByVal PersianText As String)
    Public Event UC27PressedEvent()
    Public Event UCGotFocusEvent()
    Public Event UCControlKeyPressedEvent(ByVal PersianText As String)
    Public Event UCTextChangedEvent(ByVal PersianText As String)
    Public Event UCDownArrowKeyPressedEvent()
    Public Event UCMaxCharacterReachedEvent()
    Public Event UCDoubleClickedEvent()



#Region "General Properties"

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

    Public Property MaxCharacterReached As Int16 = 50

    <Browsable(True)>
    Public Property UCValue As String
        Get
            Return TxtPersianText.Text.Trim
        End Get
        Set(ByVal value As String)
            TxtPersianText.Text = value
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
            TxtPersianText.Font = value
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
            TxtPersianText.BackColor = value
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
            TxtPersianText.ForeColor = value
        End Set
    End Property

    <Browsable(True)>
    Public Property UCOnlyDigit As R2Enums.OnlyDigit = R2Enums.OnlyDigit.Any

    Private _UCEnable As Boolean = True
    <Browsable(True)>
    Public Property UCEnable() As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            TxtPersianText.Enabled = value
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
            TxtPersianText.TextAlign = value
        End Set
    End Property

    Private _UCMultiLine As Boolean =false
    <Browsable(True)>
    Public Property UCMultiLine() As Boolean
        Get
            Return _UCMultiLine
        End Get
        Set(value As Boolean)
            _UCMultiLine = value
            TxtPersianText.Multiline = value
        End Set
    End Property


#End Region

#Region "Event Handlers"
    Private Sub TxtPersianText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPersianText.KeyPress
        Try

            If Asc(e.KeyChar) = 13 Then
                RaiseEvent UC13PressedEvent(TxtPersianText.Text.Trim)
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 27 Then RaiseEvent UC27PressedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub TxtPersianText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPersianText.TextChanged
        RaiseEvent UCTextChangedEvent(TxtPersianText.Text.Trim)
        If TxtPersianText.TextLength = MaxCharacterReached Then
            RaiseEvent UCMaxCharacterReachedEvent()
        End If
        'UCValue=TxtPersianText.Text
    End Sub

    Private Sub TxtPersianText_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPersianText.GotFocus
        Try
            R2CoreMClassPublicProcedures.Setkeyboardlayout("Persian")
            RaiseEvent UCGotFocusEvent()
            TxtPersianText.Focus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub TxtPersianText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPersianText.KeyUp
        ''If e.KeyData = Keys.Down Then RaiseEvent UCDownArrowKeyPressedEvent()
        ''If e.KeyData = Keys.ControlKey Then RaiseEvent UCControlKeyPressedEvent(TxtPersianText.Text.Trim)
    End Sub

    Private Sub TxtPersianText_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPersianText.KeyDown
        Try
            If e.KeyData = Keys.Down Or e.KeyCode = Keys.ControlKey Or (e.KeyCode = Keys.Enter AndAlso e.Control) Then
                If e.KeyData = Keys.Down Then RaiseEvent UCDownArrowKeyPressedEvent()
                If e.KeyCode = Keys.ControlKey Then RaiseEvent UCControlKeyPressedEvent(TxtPersianText.Text.Trim)
                If e.KeyCode = Keys.Enter AndAlso e.Control Then
                    RaiseEvent UCEnterControlPressedEvent(TxtPersianText.Text.Trim)
                End If
                e.Handled = True
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCPersianTextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtPersianText.Focus()
    End Sub

    Private Sub TxtPersianText_DoubleClick(sender As Object, e As EventArgs) Handles TxtPersianText.DoubleClick
        Try
            RaiseEvent UCDoubleClickedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overrides Sub UCRefreshGeneral()
        MyBase.UCRefreshGeneral()
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UCValue = ""
        TxtPersianText.Clear()
    End Sub

    Private Sub UCPersianTextBox_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        TxtPersianText.Focus()
    End Sub

#End Region









End Class
