
Imports System.Reflection

Imports PAKTCRemoteApplication.PayanehWS
Imports R2CoreWinFormRemoteApplications
Imports R2CoreWinFormRemoteApplications.R2PrimaryWS


Public Class FrmcFirst

    Private PWS As PayanehWS.PayanehWebService = New PayanehWebService()
    Private WS As R2PrimaryWS.R2PrimaryWebService = New R2PrimaryWebService()
    Private _FrmMessageDialog As New FrmcMessageDialog
    Public WithEvents FrmMain As FrmcMainLocal = New FrmcMainLocal
    Public WithEvents FrmMainMenu As FrmcMainMenuLocal = New FrmcMainMenuLocal()

    Private Sub UcButtonSpecialSystemEntry_UCClickedEvent() Handles UcButtonSpecialSystemEntry.UCClickedEvent
        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            TransportCompaniesLoadCapacitorLoadsManipulation.FillLoads()
            TransportCompaniesLoadCapacitorLoadsManipulation.FillCities()
            TransportCompaniesLoadCapacitorLoadsManipulation.FillCarTypes()
            Me.Size = New Size(0, 0)
            Me.Location = New Point(-1000, -1000)
            FrmMain = New FrmcMainLocal
            FrmMainMenu = New FrmcMainMenuLocal()
            FrmMain.Show()
            FrmMainMenu.FrmOwner = FrmMain
            FrmMainMenu.Show()
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MessageBox.Show("اتصال به اینترنت را بررسی کنید" + vbCrLf + MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub UcButtonSpecialWebServiceConnectingTest_UCClickedEvent() Handles UcButtonSpecialWebServiceConnectingTest.UCClickedEvent
        Try
            WS.WebMethodGetCurrentDateTimeMilladi()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ارتباط با وب سرویس برقرار است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "ارتباط با وب سرویس برقرار نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub ProgramEnding() Handles FrmMain.ExitIconPressed
        End
    End Sub

    Private Sub UcButtonSpecialUserCancellation_UCClickedEvent() Handles UcButtonSpecialUserCancellation.UCClickedEvent
        End
    End Sub
End Class