Imports PayanehClassLibrary.Rmto

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PayanehClassLibrary.Rmto.RmtoWebService.GetInf(RmtoWebService.InfoType.GET_DRIVER_BY_SHC, "1222524")
        Catch ex As Exception

        End Try
    End Sub
End Class