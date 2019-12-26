
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class UCNumber
    Inherits UCGeneral

    Public Event UC13Pressed(ByVal UserNumber As String)
    Public Event UCClickedEvent()
    Public Event UC27Pressed()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TxtNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumber.KeyPress
        Try
            If (e.KeyChar >= "0" And e.KeyChar <= "9") Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Or Asc(e.KeyChar) = 8 Then
                If (e.KeyChar >= "0" And e.KeyChar <= "9") Then
                    UCValue = TxtNumber.Text + e.KeyChar
                    e.Handled = True
                End If
                If Asc(e.KeyChar) = 13 Then RaiseEvent UC13Pressed(UCValue)
                If Asc(e.KeyChar) = 27 Then RaiseEvent UC27Pressed()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "UCNumber.TxtNumber_KeyPress" + vbCrLf + ex.Message, "بروز خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    <DefaultValue(0)>
    Public Property UCValue As Int64
        Get
            Dim vValue As Int64 = 0
            Int64.TryParse(TxtNumber.Text.Trim(), vValue)
            Return vValue
        End Get
        Set(ByVal value As Int64)
            If IsNumeric(value) = True Then
                TxtNumber.Text = value
            Else
                Throw New Exception("مقدار کاراکتری برای فیلد عددی قابل قبول نیست")
            End If
        End Set
    End Property

    Public Sub UCRefresh()
        UCValue = 0
    End Sub

    Private Sub UCNumber_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtNumber.Focus()
    End Sub

    Private Sub TxtNumber_Click(sender As Object, e As EventArgs) Handles TxtNumber.Click
        RaiseEvent UCClickedEvent()
    End Sub

    Private _UCBorder As BorderStyle = BorderStyle.FixedSingle
    Public Property UCBorder As BorderStyle
        Get
            Return _UCBorder
        End Get
        Set(value As BorderStyle)
            _UCBorder = value
            TxtNumber.BorderStyle = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            TxtNumber.BackColor = value
        End Set
    End Property

    Private _UCBackColorDisable As Color = Color.Gainsboro
    Public Property UCBackColorDisable() As Color
        Get
            Return _UCBackColorDisable
        End Get
        Set(value As Color)
            _UCBackColorDisable = value
        End Set
    End Property


    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            TxtNumber.ForeColor = value
        End Set
    End Property

    Private _UCEnable As Boolean = True
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            If value = True Then
                TxtNumber.BackColor = UCBackColor
                TxtNumber.Enabled = True
            Else
                TxtNumber.BackColor = UCBackColorDisable
                TxtNumber.Enabled = False
            End If
        End Set
    End Property

    Private _UCReadOnly As Boolean = false
    Public Property UCReadOnly As Boolean
        Get
            Return _UCReadOnly
        End Get
        Set(value As Boolean)
            _UCReadOnly = value
            If value = True Then
                TxtNumber.BackColor = UCBackColorDisable
                TxtNumber.ReadOnly = True
                TxtNumber.Cursor=Cursors.Hand
            Else
                TxtNumber.BackColor = UCBackColor
                TxtNumber.ReadOnly = False
                TxtNumber.Cursor=Cursors.Default
            End If
        End Set
    End Property

    Private _UCHandCursorIcon As Boolean = False
    Public Property UCHandCursorIcon As Boolean
        Get
            Return _UCHandCursorIcon
        End Get
        Set(value As Boolean)
            _UCHandCursorIcon = value
            If value = True Then
                TxtNumber.Cursor = Cursors.Hand
            Else
                TxtNumber.Cursor = Cursors.Default
            End If
        End Set
    End Property


    Private _UCFont As Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            TxtNumber.Font = value
        End Set
    End Property


End Class
