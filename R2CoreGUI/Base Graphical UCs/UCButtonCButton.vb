
Imports System.Reflection
Imports System.ComponentModel
Imports System.Windows.Forms

Imports R2Core.ConfigurationManagement
Imports R2Core.ProcessesManagement

Public Class UCButtonCButton
    Inherits UCGeneral

    Public Event UCClickedEvent()

#Region "General Properties"

    Private _UCText As String = String.Empty
    <Browsable(True)>
    Public Property UCText As String
        Get
            Return _UCText
        End Get
        Set(value As String)
            _UCText = value
            CButton.Text = value
        End Set
    End Property

    Private _UCBorderColor As Color = Color.Blue
    <Browsable(True)>
    Public Property UCBorderColor As Color
        Get
            Return _UCBorderColor
        End Get
        Set(value As Color)
            _UCBorderColor = value
            CButton.BorderColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.White
    <Browsable(True)>
    Public Property UCForeColor As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            CButton.ForeColor = value
        End Set
    End Property

    Private _UCCorners As CButtonLib.CornersProperty = New CButtonLib.CornersProperty(16)
    <Browsable(True)>
    Public Property UCCorners As CButtonLib.CornersProperty
        Get
            Return _UCCorners
        End Get
        Set(value As CButtonLib.CornersProperty)
            _UCCorners = value
            CButton.Corners = value
        End Set
    End Property

    Private _UCColorFillBlend As CButtonLib.cBlendItems = New CButtonLib.cBlendItems(New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black}, New Single() {0!, 1.0!})
    <Browsable(True)>
    Public Property UCColorFillBlend As CButtonLib.cBlendItems
        Get
            Return _UCColorFillBlend
        End Get
        Set(value As CButtonLib.cBlendItems)
            _UCColorFillBlend = value
            CButton.ColorFillBlend = _UCColorFillBlend
        End Set
    End Property

    Private _UCColorFillSolid As Color = Color.Transparent
    <Browsable(True)>
    Public Property UCColorFillSolid As Color
        Get
            Return _UCColorFillSolid
        End Get
        Set(value As Color)
            _UCColorFillSolid = value
            CButton.ColorFillSolid = value
        End Set
    End Property

    Private _UCCursor As Cursor = System.Windows.Forms.Cursors.Hand
    <Browsable(True)>
    Public Property UCCursor As Cursor
        Get
            Return _UCCursor
        End Get
        Set(value As Cursor)
            _UCCursor = value
            CButton.Cursor = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            CButton.Font = value
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
    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            RaiseEvent UCClickedEvent()
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
