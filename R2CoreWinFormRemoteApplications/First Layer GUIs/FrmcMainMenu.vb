
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Public Class FrmcMainMenu

    Private _FrmMessageDialog As New FrmcMessageDialog


#Region "General Properties"

    Private _FrmOwner As Form = Nothing
    Public Property FrmOwner() As Form
        Get
            Return _FrmOwner
        End Get
        Set(value As Form)
            _FrmOwner = value
            Owner=value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Location = New Point(5, 121)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
            Me.Height = My.Computer.Screen.WorkingArea.Height - (New FrmcMain).Size.Height - 12
        Catch ex As Exception

        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Owner = _FrmOwner
    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region








End Class
