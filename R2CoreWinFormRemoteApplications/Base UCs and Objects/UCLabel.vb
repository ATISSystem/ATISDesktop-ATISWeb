
Imports System.Drawing

Public Class UCLabel
    Inherits UCGeneral

    PUBLIC Event UCClicked


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

    Public Sub UCRefresh()
        UCValue = ""
        Label.Text = ""
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
        RaiseEvent UCClicked
    End Sub
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
