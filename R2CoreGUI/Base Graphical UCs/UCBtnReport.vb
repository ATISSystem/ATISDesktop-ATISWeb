

Public Class UCBtnReport


    Public Event UCViewReportEvent()
    Public Event UCViewChopEvent()


    Private Sub BtnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewReport.Click
        RaiseEvent UCViewReportEvent()
    End Sub

    Private Sub BtnViewChop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewChop.Click
        RaiseEvent UCViewChopEvent()
    End Sub
End Class
