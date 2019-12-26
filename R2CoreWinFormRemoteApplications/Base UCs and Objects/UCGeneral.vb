
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreWinFormRemoteApplications.DateTimeManagement


Public Class UCGeneral
    Inherits System.Windows.Forms.UserControl

    Protected _DateTime As R2DateTime = New R2DateTime()

    Protected _FrmMessageDialog As New FrmcMessageDialog
    Protected Event _UCDisposeResourcesRequest()
    Protected Event UCGotFocusedEvent


    Protected Sub UCRefreshGeneral()

    End Sub

    Public Overridable Sub DisposeResources()
    End Sub


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCGeneral_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        DisposeResources()
    End Sub

    Public sub UCFocus
        RaiseEvent UCGotFocusedEvent
    End sub
End Class
