
Imports System.ComponentModel

Imports R2Core.ExceptionManagement
Imports R2Core.FileShareRawGroupsManagement

Public Class UCNumber
    Inherits UCGeneral

    Public Event UC13Pressed(ByVal UserNumber As String)
    Public Event UC27Pressed()



#Region "General Properties"


    <DefaultValue(0), Browsable(True)>
    Public Property UCValue As Int64
        Get
            Dim vValue As Int64 = 0
            Int64.TryParse(TxtNumber.Text.Trim(), vValue)
            If vValue >= UCAllowedMinNumber And vValue <= UCAllowedMaxNumber Then
                Return vValue
            Else
                Throw New InvalidEntryAmountException
            End If
        End Get
        Set(ByVal value As Int64)
            If IsNumeric(value) = True Then
                TxtNumber.Text = value
            Else
                Throw New Exception("مقدار کاراکتری برای فیلد عددی قابل قبول نیست")
            End If
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
            TxtNumber.Multiline = value
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

    Private _UCBackColor As Color = Color.White
    <Browsable(True)>
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            TxtNumber.BackColor = value
        End Set
    End Property

    <Browsable(True)>
    Public Property UCBackColorDisable As Color = Color.Gainsboro

    Private _UCBackColorInvalidEntryException As Color = Color.Gold
    <Browsable(True)>
    Public Property UCBackColorInvalidEntryException() As Color
        Get
            Return _UCBackColorInvalidEntryException
        End Get
        Set(value As Color)
            _UCBackColorInvalidEntryException = value
            TxtNumber.BackColor = value
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
            TxtNumber.ForeColor = value
        End Set
    End Property

    Private _UCEnable As Boolean = True
    <Browsable(True)>
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

    Private _UCFont As Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
    <Browsable(True)>
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            TxtNumber.Font = value
        End Set
    End Property

    Private _UCAllowedMinNumber As Int64 = Int64.MinValue
    Public Property UCAllowedMinNumber As Int64
        Get
            Return _UCAllowedMinNumber
        End Get
        Set(value As Int64)
            _UCAllowedMinNumber = value
        End Set
    End Property

    Private _UCAllowedMaxNumber As Int64 = Int64.MaxValue
    Public Property UCAllowedMaxNumber As Int64
        Get
            Return _UCAllowedMaxNumber
        End Get
        Set(value As Int64)
            _UCAllowedMaxNumber = value
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

    Private Sub TxtNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumber.KeyPress
        Try
            If (e.KeyChar >= "0" And e.KeyChar <= "9") Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Or Asc(e.KeyChar) = 8 Then
                If Asc(e.KeyChar) = 13 Then
                    Dim myNumber As Int64 = UCValue
                    RaiseEvent UC13Pressed(myNumber )
                End If
                If Asc(e.KeyChar) = 27 Then RaiseEvent UC27Pressed()
            Else
                e.Handled = True
            End If
        Catch ex As InvalidEntryAmountException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, String.Empty , FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "UCNumber.TxtNumber_KeyPress" + vbCrLf + ex.Message, "بروز خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCNumber_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtNumber.Focus()
    End Sub

    Private Sub UCNumber_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        TxtNumber.BackColor=UCBackColor
        TxtNumber.Focus()
    End Sub



#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class
