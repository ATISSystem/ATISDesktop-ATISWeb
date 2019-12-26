
Imports System.Reflection

Imports PayanehAmirKabirRemoteApplication.R2PrimaryWS
Imports R2CoreWinFormRemoteApplications

Public Class FrmcFirst

    Private WS As R2PrimaryWS.R2PrimaryWebService = New R2PrimaryWebService()
    Private _FrmMessageDialog As New FrmcMessageDialog

    Dim WithEvents  FrmMain As FrmcMain
    Private Sub UcButtonSpecialSystemEntry_UCClickedEvent() Handles UcButtonSpecialSystemEntry.UCClickedEvent
        Try
            Me.Size = New Size(0, 0)
            Me.Location = New Point(-1000, -1000)
            FrmMain = New FrmcMain()
            FrmMainMenu = New FrmcMainMenu()
            FrmMain.Show()
            FrmMainMenu.FrmOwner = FrmMain
            FrmMainMenu.Show()
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UcButtonSpecialWebServiceConnectingTest_UCClickedEvent() Handles UcButtonSpecialWebServiceConnectingTest.UCClickedEvent
        Try
            WS.WebMethodGetCurrentDateTimeMilladi()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ارتباط با وب سرویس برقرار است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "ارتباط با وب سرویس برقرار نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,false)
        End Try
    End Sub

    Private sub ProgramEnding Handles  FrmMain.ExitIconPressed
        end
    End sub


End Class