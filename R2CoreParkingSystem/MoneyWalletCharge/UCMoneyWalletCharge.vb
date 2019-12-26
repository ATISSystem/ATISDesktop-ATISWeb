
Imports System.Reflection
Imports System.Windows.Forms
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.LoggingManagement
Imports R2Core.PublicProc
Imports R2Core.RFIDCardsManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.MoneyWalletChargeManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCMoneyWalletCharge
    Inherits UCGeneral
    Implements R2CoreRFIDCardRequester

    Private WithEvents _Timer As System.Windows.Forms.Timer = New Timer()
    Public Event UCMoneyWalletChargedEvent(Mblgh As Int64)
    Public Event UCMoneyWalletChargeUserCanceledEvent()
    Public Event UCMoneyWalletChargeRFIDCardReadedEvent(CardNo As String)
    Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
    Private ReadOnly _DateTime As R2DateTime = New R2DateTime()


#Region "General Properties"

    Private _UCLocalPrintFlagforUCPrintBillan As Boolean = False
    Public Property UCLocalPrintFlagforUCPrintBillan() As Boolean
        Get
            Return _UCLocalPrintFlagforUCPrintBillan
        End Get
        Set(value As Boolean)
            _UCLocalPrintFlagforUCPrintBillan = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If Not ((R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True) And (R2CoreMClassLoginManagement.CurrentUserNSS.UserCanCharge = True)) Then Me.Enabled = False
            _Timer.Interval = 10000
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub DisposeResources()
        _Timer = Nothing
    End Sub

    Public Sub UCRefresh()
        UcButtonCharge.UCEnable = True
        UcLabelMblgh.UCValue = 0
    End Sub

    Private Sub UCAddMblgh(YourMblgh As Int64)
        Try
            Dim myCurrentMblgh As Int64 = IIf(UcLabelMblgh.UCValue.Trim <> "", UcLabelMblgh.UCValue.Replace(",", ""), 0)
            UcLabelMblgh.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourMblgh + myCurrentMblgh)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCPrepare(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UCRefresh()
            _NSSTrafficCard = YourTrafficCard
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTrafficCard)
            _Timer.Enabled = True : _Timer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub StartReading()
        Try
            R2Core.RFIDCardsManagement.R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _Timer_Tick(sender As Object, e As EventArgs) Handles _Timer.Tick
        UcButtonCharge.UCEnable = False
    End Sub

    Private Sub UcButtonCharge_UCClickedEvent() Handles UcButtonCharge.UCClickedEvent
        Try
            UcButtonCharge.UCEnable = False
            _Timer.Enabled = False : _Timer.Stop()
            If UcLabelMblgh.UCValue <> "" And UcLabelMblgh.UCValue <> "0" Then
                UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.AddMoney, UcLabelMblgh.UCValue.Replace(",", ""), R2CoreParkingSystemAccountings.ChargeType)
                R2CoreParkingSystemMClassMoneyWalletChargeManagement.SabtCharge(New R2StandardMoneyWalletChargeStructure(_NSSTrafficCard, UcMoneyWallet.UCGetMblgh, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, "", _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, _DateTime.GetCurrentTime))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "شارژ کیف پول انجاک گرفت" + vbCrLf + UcLabelMblgh.UCValue, _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                'چاپ رسید شارژ ابتدا برای کل کامپیوتر مطابق کانفیگ بررسی می شود
                'سپس به صورت محلی نیز بررسی می شود
                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.MoneyWalletCharge, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 0) = True Then
                    If UCLocalPrintFlagforUCPrintBillan = True Then
                        UcMoneyWallet.UCPrintBillan(UCMoneyWallet.PrintType.Billan)
                        R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "چاپ قبض شارژ کیف پول انجاک گرفت" + vbCrLf + UcLabelMblgh.UCValue, _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    End If
                End If

                RaiseEvent UCMoneyWalletChargedEvent(UcMoneyWallet.UCGetMblgh)
            Else
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "مبلغ شارژ نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector1000_UCClickedEvent() Handles UcMblghSelector1000.UCClickedEvent
        Try
            UCAddMblgh(10000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector10000_UCClickedEvent() Handles UcMblghSelector10000.UCClickedEvent
        Try
            UCAddMblgh(100000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector3000_UCClickedEvent() Handles UcMblghSelector3000.UCClickedEvent
        Try
            UCAddMblgh(30000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector500_UCClickedEvent() Handles UcMblghSelector500.UCClickedEvent
        Try
            UCAddMblgh(5000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector5000_UCClickedEvent() Handles UcMblghSelector5000.UCClickedEvent
        Try
            UCAddMblgh(50000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector6000_UCClickedEvent() Handles UcMblghSelector6000.UCClickedEvent
        Try
            UCAddMblgh(60000)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicMblghZero_Click(sender As Object, e As EventArgs) Handles PicMblghZero.Click
        UcLabelMblgh.UCValue = 0
    End Sub

    Private Sub PicBeggar_Click(sender As Object, e As EventArgs) Handles PicBeggar.Click
        Try
            Dim OKM As UInt64 = Math.Abs(UcMoneyWallet.UCGetReminderCharge)
            If Strings.Right(Math.Abs(UcMoneyWallet.UCGetReminderCharge).ToString, 4) <> "0000" Then
                OKM = 10000 - Strings.Right(Math.Abs(UcMoneyWallet.UCGetReminderCharge).ToString, 4)
            End If
            UcLabelMblgh.UCValue = R2Core.PublicProc.R2CoreMClassPublicProcedures.ParseSignDigitToSignString(OKM)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicPreapring_Click(sender As Object, e As EventArgs) Handles PicPreapring.Click
        Try
            UCPrepare(_NSSTrafficCard)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        RaiseEvent UCMoneyWalletChargeUserCanceledEvent()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            UCPrepare(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo))
            RaiseEvent UCMoneyWalletChargeRFIDCardReadedEvent(CardNo)
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت تردد قابل شناسایی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
    End Sub

#End Region


End Class
