


Imports System.Reflection

Public Class FrmcImageViewer

    Public Sub ViewImage(YourImage As Bitmap)
        Try
            PictureBox.Image = YourImage
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

End Class