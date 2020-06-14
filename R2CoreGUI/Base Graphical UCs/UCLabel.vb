
Imports System.Reflection

Public Class UCLabel
    Inherits UCGeneral

    Public Event UCClickedEvent()
    Public Event UCMouseEnteredEvent()
    Public Event UCMouseLeavedEvent()
    Public Event UCTextChanged(NewText As String)

#Region "General Properties"

    Private _UCValue As String = ""
    Public Property UCValue As String
        Get
            Return _UCValue
        End Get
        Set(ByVal value As String)
            _UCValue = value
            Label.Text = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            Label.Font = value
        End Set
    End Property

    Public Property _UCBackColorPopup As Color = Color.Transparent
    Private _UCBackColor As Color = Color.Transparent
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            Label.BackColor = value
        End Set
    End Property

    Public Property _UCForeColorPopuped As Color = Color.Red
    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            Label.ForeColor = value
        End Set
    End Property

    Private _UCTextAlign As ContentAlignment = ContentAlignment.MiddleCenter
    Public Property UCTextAlign() As ContentAlignment
        Get
            Return _UCTextAlign
        End Get
        Set(value As ContentAlignment)
            _UCTextAlign = value
            Label.TextAlign = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub UCRefreshInformation()
        Try
            UCValue = ""
            Label.Text = ""
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
        Try
            RaiseEvent UCClickedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLabel_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Label.Focus()
    End Sub

    Private Sub Label_MouseEnter(sender As Object, e As EventArgs) Handles Label.MouseEnter
        RaiseEvent UCMouseEnteredEvent()

    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles Label.MouseLeave
        RaiseEvent UCMouseLeavedEvent()
    End Sub

    Private Sub Label_TextChanged(sender As Object, e As EventArgs) Handles Label.TextChanged
        RaiseEvent UCTextChanged(Label.Text)
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
