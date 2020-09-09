
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports R2Core.RFIDCardsManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcTerafficCardInitialRegister
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
        R2CoreRFIDCardReaderInterface.StartReading(me,R2CoreRFIDCardReaderInterface.InterfaceMode.NoTestForRFIDCardConfirm)
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcTerafficCardInitialRegister))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        UcrfidCardInitialRegistration.UCRefresh()
        UcCmbTerafficCardType.UCRefresh()
        UcCmbTerafficTempCardType.UCRefresh()
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcTerafficCardInitialRegister__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            UcrfidCardInitialRegistration.UCInitialRegister(CardNo)
            Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
            NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            NSSTerafficCard.CardType = UcCmbTerafficCardType.UCGetCurrentTypeCode()
            NSSTerafficCard.TempCardType = UcCmbTerafficTempCardType.UCGetCurrentTempTypeCode()
            R2CoreParkingSystemMClassTrafficCardManagement.TerafficCardInitialRegister(NSSTerafficCard,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            R2CoreMClassLoggingManagement.LogRegister(new R2CoreStandardLoggingStructure(0,R2CoreLogType.Info,"ثبت اولیه و فعال سازی کارت تردد انجام گرفت",NSSTerafficCard.CardNo,0,0,0,0,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId,_DateTime.GetCurrentDateTimeMilladiFormated(),_DateTime.GetCurrentDateShamsiFull))
        Catch exx As GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "برای ثبت کارت تردد باید ابتدا کارت در لیست کارت های آر اف ثبت شود", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            R2CoreRFIDCardReaderInterface.StartReading(me,R2CoreRFIDCardReaderInterface.InterfaceMode.NoTestForRFIDCardConfirm)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcTerafficCardInitialRegister__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class