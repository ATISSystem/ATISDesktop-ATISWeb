

Public Class FrmcViewCarImage

    Private myMessage As String
    Public Sub New(ByRef YourCarImage As Drawing.Bitmap, ByVal YourMessage As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PicCarImage.Image = YourCarImage.Clone
        myMessage = YourMessage
    End Sub

    Public Sub ViewCarImage(ByRef YourCarImage As Drawing.Bitmap, ByVal YourMessage As String)
        PicCarImage.Image = YourCarImage.Clone
        myMessage = YourMessage
    End Sub

    Private Sub PicCarImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicCarImage.Click
        Windows.Forms.MessageBox.Show(myMessage)
    End Sub
End Class