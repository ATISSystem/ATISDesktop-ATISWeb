
Imports System.Reflection
Imports System.Windows.Forms

Public Class FrmcMain

    Public Event ExitIconPressed()



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Location = New System.Drawing.Point(5, 5)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub picexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picexit.Click
        RaiseEvent ExitIconPressed()
    End Sub

    Private Sub PicMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class