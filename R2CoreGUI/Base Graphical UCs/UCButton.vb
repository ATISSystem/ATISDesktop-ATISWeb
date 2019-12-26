
Imports System.Reflection

Public Class UCButton
    Inherits UCGeneral


    Public Event UC13PressedEvent()
    Public Event UC27PressedEvent()
    Public Event UCClickedEvent()

#Region "General Properties"

    Public Property UCValue As String
        Get
            Return Button.Text.Trim
        End Get
        Set(ByVal value As String)
            Button.Text = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.OrangeRed
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            Button.BackColor = value
        End Set
    End Property

    Private _UCBackColorDisable As Color = Color.Gray
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
            Button.ForeColor = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            Button.Font = value
        End Set
    End Property

    Private _UCEnable As Boolean = True
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            Me.Enabled = value
            If value = True Then
                Button.BackColor = UCBackColor
            Else
                Button.BackColor = UCBackColorDisable
            End If
        End Set
    End Property


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
    Private Sub Button_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then RaiseEvent UC13PressedEvent()
            If Asc(e.KeyChar) = 27 Then RaiseEvent UC27PressedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        RaiseEvent UCClickedEvent()
    End Sub

    Private Sub Button_GotFocus(sender As Object, e As EventArgs) Handles Button.GotFocus
        Button.Focus()
    End Sub

    Private Sub UCButton_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Button.Focus()
    End Sub

    Private Sub UCButton_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        Button.Focus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
