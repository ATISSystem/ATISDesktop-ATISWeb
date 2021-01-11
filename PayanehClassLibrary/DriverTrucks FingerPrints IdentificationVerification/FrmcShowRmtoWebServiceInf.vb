
Imports System.Drawing
Imports System.Net.NetworkInformation
Imports System.Windows.Forms

Imports R2CoreTransportationAndLoadNotification.Rmto

Public Class FrmcShowRmtoWebServiceInf

    Private Sub BtnViewInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewInf.Click
        Try
            TxtInf.Clear()
            Dim myInf As String()
            If OpbDriver.Checked = True Then
                myInf = RmtoWebService.GetInf(RmtoWebService.InfoType.GET_DRIVER_BY_SHC, TxtSmartCardNo.Text)
            ElseIf OpbTruck.Checked = True Then
                myInf = RmtoWebService.GetInf(RmtoWebService.InfoType.GET_FREIGHTER_BY_SHC, TxtSmartCardNo.Text)
            End If
            For loopx As UInt16 = 0 To myInf.Length - 1
                TxtInf.Text += myInf(loopx) + vbCrLf
            Next
        Catch ex As PingException
            MessageBox.Show("FrmcShowRmtoWebServiceInf" + vbCrLf + ex.Message)
        Catch ex As InvalidOperationException
            MessageBox.Show("FrmcShowRmtoWebServiceInf" + vbCrLf + ex.Message)
        Catch ex As Exception
            MessageBox.Show("FrmcShowRmtoWebServiceInf" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub TxtSmartCardNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSmartCardNo.GotFocus
        TxtSmartCardNo.Clear()
        TxtSmartCardNo.ForeColor = Color.SteelBlue
    End Sub

    Private Sub TxtSmartCardNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSmartCardNo.LostFocus
        TxtSmartCardNo.ForeColor = Color.Silver
    End Sub


End Class