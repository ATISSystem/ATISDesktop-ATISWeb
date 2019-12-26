

Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreWinFormRemoteApplications.PublicProc


Public Class UCPersianTextBox
    Inherits UCGeneral

    Public Event UC13PressedEvent(ByVal PersianText As String)
    Public Event UC27PressedEvent()
    Public Event UCGotFocusEvent()
    Public Event UCControlKeyPressedEvent(ByVal PersianText As String)
    Public Event UCTextChangedEvent(ByVal PersianText As String)
    Public Event UCDownArrowKeyPressedEvent()
    Public Event UCMaxCharacterReachedEvent()



#Region "General Properties"
    Private _MaxCharacterReached As Int16 = 50
    Public Property MaxCharacterReached As Int16
        Get
            Return _MaxCharacterReached
        End Get
        Set(value As Int16)
            _MaxCharacterReached = value
        End Set
    End Property

    Public Property UCValue As String
        Get
            Return TxtPersianText.Text.Trim
        End Get
        Set(ByVal value As String)
            TxtPersianText.Text = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
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
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            TxtPersianText.ForeColor = value
        End Set
    End Property

    Private _UCOnlyDigit As R2CoreWinFormRemoteApplicationsEnums.OnlyDigit = R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
    Public Property UCOnlyDigit() As R2CoreWinFormRemoteApplicationsEnums.OnlyDigit
        Get
            Return _UCOnlyDigit
        End Get
        Set(value As R2CoreWinFormRemoteApplicationsEnums.OnlyDigit)
            _UCOnlyDigit = value
        End Set
    End Property

    Private _UCEnable As Boolean = TRUE
    Public Property UCEnable() As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
         TxtPersianText .Enabled = value
        End Set
    End Property

    Private _UCTextAlign As HorizontalAlignment = HorizontalAlignment.Center
    Public Property UCTextAlign() As HorizontalAlignment
        Get
            Return _UCTextAlign
        End Get
        Set(value As HorizontalAlignment)
            _UCTextAlign = value
          TxtPersianText.TextAlign = value
        End Set
    End Property

    Private _UCBorder As BorderStyle = BorderStyle.FixedSingle
    Public Property UCBorder() As BorderStyle
        Get
            Return _UCBorder
        End Get
        Set(value As BorderStyle)
            _UCBorder = value
            TxtPersianText.BorderStyle = value
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
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
           R2CoreWinFormRemoteApplicationsMclassPublicProcManagement.Setkeyboardlayout("Persian")
            RaiseEvent UCGotFocusEvent()
            TxtPersianText.Focus()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub TxtPersianText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPersianText.KeyUp
        If e.KeyData = Keys.Down Then RaiseEvent UCDownArrowKeyPressedEvent()
        If e.KeyData = Keys.ControlKey Then RaiseEvent UCControlKeyPressedEvent(TxtPersianText.Text.Trim)
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
        TxtPersianText.Clear()
    End Sub

   


#End Region









End Class
