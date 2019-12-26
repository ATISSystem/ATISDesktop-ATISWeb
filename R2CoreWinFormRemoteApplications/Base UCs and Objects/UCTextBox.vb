

Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports R2CoreWinFormRemoteApplications.PublicProc


Public Class UCTextBox
    Inherits UCGeneral


    Public Event UC13PressedEvent(ByVal CurrentText As String)
    Public Event UC27PressedEvent()
    Public Event UCGotFocusEvent()
    Public Event UCControlKeyPressedEvent(ByVal CurrentText As String)
    Public Event UCTextChangedEvent(ByVal CurrentText As String)
    Public Event UCDownArrowKeyPressedEvent()
    Public Event UCMaxCharacterReachedEvent()



#Region "General Properties"

    Private _UCInputLanguageType As R2CoreWinFormRemoteApplicationsEnums.InputLanguageType = R2CoreWinFormRemoteApplicationsEnums.InputLanguageType.None
    Public Property UCInputLanguageType As R2CoreWinFormRemoteApplicationsEnums.InputLanguageType
        Get
            Return _UCInputLanguageType
        End Get
        Set(value As R2CoreWinFormRemoteApplicationsEnums.InputLanguageType)
            _UCInputLanguageType=value
        End Set
    End Property

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
            Return TextBox.Text.Trim
        End Get
        Set(ByVal value As String)
            TextBox.Text = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
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
            TextBox.ForeColor = value
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

    Private _UCEnable As Boolean = True
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
    Public Property UCTextAlign() As HorizontalAlignment
        Get
            Return _UCTextAlign
        End Get
        Set(value As HorizontalAlignment)
            _UCTextAlign = value
            TextBox.TextAlign = value
        End Set
    End Property


#End Region

#Region "Event Handlers"
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox.KeyPress
        Try

            If Asc(e.KeyChar) = 13 Then
                RaiseEvent UC13PressedEvent(TextBox.Text.Trim)
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 27 Then RaiseEvent UC27PressedEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox.TextChanged
        RaiseEvent UCTextChangedEvent(TextBox.Text.Trim)
        If TextBox.TextLength = MaxCharacterReached Then RaiseEvent UCMaxCharacterReachedEvent()
        UCValue = TextBox.Text
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox.GotFocus
        Try
            TextBox.Focus()
            R2CoreWinFormRemoteApplicationsMclassPublicProcManagement.Setkeyboardlayout(UCInputLanguageType)
            RaiseEvent UCGotFocusEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox.KeyUp
        If e.KeyData = Keys.Down Then RaiseEvent UCDownArrowKeyPressedEvent()
        If e.KeyData = Keys.ControlKey Then RaiseEvent UCControlKeyPressedEvent(TextBox.Text.Trim)
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
