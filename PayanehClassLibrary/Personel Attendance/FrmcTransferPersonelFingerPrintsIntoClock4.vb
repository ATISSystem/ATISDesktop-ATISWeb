
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI

Public Class FrmcTransferPersonelFingerPrintsIntoClock4
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime = New R2DateTime()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            UcPersianTextBoxSal.UCValue = _DateTime.GetCurrentSalShamsiFull()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcTransferPersonelFingerPrintsIntoClock4))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            HumanManagement.Personnel.PayanehClassLibraryMClassPersonnelAttendanceManagement.TransferPersonelFingerPrintsIntoClock4(UcPersianTextBoxSal.UCValue.Trim, UcPersianMonths.UCGetSelectedMonthCode)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "انتقال اطلاعات تردد پرسنل از سیستم اثرانگشت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class