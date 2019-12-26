
Imports System.Reflection
Imports System.Windows.Forms




Public Class UCShutDown
    Inherits UCGeneral



#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
    End Sub








#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicShutDown_Click(sender As Object, e As EventArgs) Handles PicShutDown.Click
        Try
            System.Diagnostics.Process.Start("shutdown", "-s -t 00")
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
