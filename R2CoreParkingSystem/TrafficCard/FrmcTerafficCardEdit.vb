
Imports System.Reflection
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement

Imports R2Core.ProcessesManagement
Imports R2Core.RFIDCardsManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcTerafficCardEdit
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime=New R2DateTime()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefresh()
 End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcTerafficCardEdit))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        UcTerafficCardViewerEditor.UCRefresh()
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcTerafficCardEdit__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            UcTerafficCardViewerEditor.UCViewTerafficCardInformation(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcTerafficCardEdit__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            UcTerafficCardViewerEditor.UCEditTerafficCard()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess,"مشخصات ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(0,R2CoreLogType.Info,"ویرایش مشخصات کارت تردد انجام گرفت",UcTerafficCardViewerEditor.UCGetNSSTerafficCard.CardNo,0,0,0,0,R2CoreMClassLoginManagement.CurrentUserNSS.UserId,_DateTime.GetCurrentDateTimeMilladiFormated(),_DateTime.GetCurrentDateShamsiFull))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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