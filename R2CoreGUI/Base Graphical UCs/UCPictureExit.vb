

Public Class UCPictureExit
    Inherits UCGeneral

    Public Event UCClickedEvent()

#Region "General Properties"

    Private _UCImage As Image = Nothing
    Public Property UCImage() As Image
        Get
            Return _UCImage
        End Get
        Set(value As Image)
            _UCImage = value
            PictureBox.Image = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.Transparent
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            PnlMain.BackColor = value
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

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        RaiseEvent UCClickedEvent()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class
