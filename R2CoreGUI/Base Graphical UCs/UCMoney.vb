

Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.PublicProc

Public Class UCMoney
    Inherits UCGeneral


    Public Event UC13Pressed(ByVal Money As String)
    Public Event UC27Pressed()
    Public Event UCValidatedEvent()


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

    Private _UCValue As String = "0"
    <DefaultValue("0"), Browsable(True)>
    Public Property UCValue As String
        Get
            Return TxtMoney.Text.Replace(",", "")
        End Get
        Set(ByVal value As String)
            Dim Value_ As String = "0"
            If value.Replace(",", "") = String.Empty Then
                Value_ = "0"
            Else
                Value_ = value
            End If
            If IsNumeric(Value_.Replace(",", "")) = True Then
                Dim Temp As String = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Value_.Replace(",", ""))
                _UCValue = Temp
                TxtMoney.Text = Temp
            Else
                Throw New Exception("Value IsNot Numeric")
            End If
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
            TxtMoney.BackColor = value
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
            TxtMoney.ForeColor = value
        End Set
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCValueWithComa As String
        Get
            Return UCValue
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCValueWithoutComa As String
        Get
            Return UCValue
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCValueMoney() As Int64
        Get
            Return Convert.ToInt64(UCValue)
        End Get
    End Property

    Private _UCFont As Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
    <Browsable(True)>
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            TxtMoney.Font = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UCValue = 0
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub TxtMoney_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoney.KeyPress
        Try
            If (e.KeyChar >= "0" And e.KeyChar <= "9") Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Or Asc(e.KeyChar) = 8 Then
                'If e.KeyChar >= "0" And e.KeyChar <= "9" Then
                '    UCValue = TxtMoney.Text + e.KeyChar
                '    e.Handled = True
                '    Exit Sub
                'End If
                If Asc(e.KeyChar) = 13 Then RaiseEvent UC13Pressed(TxtMoney.Text)
                If Asc(e.KeyChar) = 27 Then RaiseEvent UC27Pressed()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCMoney_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtMoney.Focus()
    End Sub

    Private Sub TxtMoney_TextChanged(sender As Object, e As EventArgs) Handles TxtMoney.TextChanged
        Try

        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub TxtMoney_Validated(sender As Object, e As EventArgs) Handles TxtMoney.Validated
        Try
            If TxtMoney.Text.Trim <> String.Empty Then UCValue = TxtMoney.Text
            RaiseEvent UCValidatedEvent()
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
