
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.LoggingManagement
Imports R2Core.PublicProc
Imports R2Core.RFIDCardsManagement
Imports R2Core.SoftwareUserManagement
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
    Public Event UCMoneyWalletChargedEvent(Amount As Int64)
    Public Event UCMoneyWalletChargeUserCanceledEvent()
    Public Event UCMoneyWalletChargeRFIDCardReadedEvent(CardNo As String)
    Private _NSS As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
    Private _Amount As Int64


#Region "General Properties"

    Public Property UCLocalPrintFlagforUCPrintBillan() As Boolean = False

    Private _UCMonetarySupplyConfigurationIndex As Int64 = 1
    Public Property UCConfigurationIndex() As Int64
        Get
            Return _UCMonetarySupplyConfigurationIndex
        End Get
        Set(value As Int64)
            Try
                _UCMonetarySupplyConfigurationIndex = value
                UcMonetarySupply.UCConfigurationIndex = value
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If Not ((R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True) And (R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserCanCharge = True)) Then Me.Enabled = False
            _Timer.Interval = 50000
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub DisposeResources()
        _Timer = Nothing
    End Sub

    Public Sub UCRefresh()
        UcMonetarySupply.UCEnable = True
    End Sub

    Public Sub UCPrepare(YourNSS As R2CoreParkingSystemStandardTrafficCardStructure, YourAmount As Int64)
        Try
            UCRefresh()
            _NSS = YourNSS
            _Amount = YourAmount
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSS)
            UcMonetarySupply.UCPrepare(YourAmount)
            _Timer.Enabled = True : _Timer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub StartReading()
        Try
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _Timer_Tick(sender As Object, e As EventArgs) Handles _Timer.Tick
        UcMonetarySupply.UCEnable = False
    End Sub

    Private Sub PicPreapring_Click(sender As Object, e As EventArgs) Handles PicPreapring.Click
        Try
            UCPrepare(_NSS, _Amount)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        RaiseEvent UCMoneyWalletChargeUserCanceledEvent()
    End Sub

    Private Delegate Sub _UcMonetarySupply_UCMonetarySupplySuccessEventDelegate(TransactionId As Long, Amount As Long, SupplyReport As String)
    Private Sub UcMonetarySupply_UCMonetarySupplySuccessEvent(TransactionId As Long, Amount As Long, SupplyReport As String) Handles UcMonetarySupply.UCMonetarySupplySuccessEvent
        Try
            If (UcMonetarySupply.InvokeRequired) Then
                Dim myDelegate As _UcMonetarySupply_UCMonetarySupplySuccessEventDelegate = New _UcMonetarySupply_UCMonetarySupplySuccessEventDelegate(AddressOf UcMonetarySupply_UCMonetarySupplySuccessEvent)
                Dim params() As Object = New Object() {TransactionId, Amount, SupplyReport}
                BeginInvoke(myDelegate, params)
            Else
                UcMonetarySupply.UCEnable = False
                _Timer.Enabled = False : _Timer.Stop()
                If Amount <> 0 Then
                    UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSS, BagPayType.AddMoney, Amount, R2CoreParkingSystemAccountings.ChargeType)
                    R2CoreParkingSystemMClassMoneyWalletChargeManagement.SabtCharge(New R2StandardMoneyWalletChargeStructure(_NSS, UcMoneyWallet.UCGetMblgh, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, "", _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, _DateTime.GetCurrentTime))
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "شارژ کیف پول انجام گرفت" + vbCrLf + Amount.ToString, _NSS.CardNo, IIf(Object.Equals(TransactionId, Nothing), String.Empty, TransactionId), 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    'چاپ رسید شارژ ابتدا برای کل کامپیوتر مطابق کانفیگ بررسی می شود
                    'سپس به صورت محلی نیز بررسی می شود
                    If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.MoneyWalletCharge, R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId, 0) = True Then
                        If UCLocalPrintFlagforUCPrintBillan = True Then
                            UcMoneyWallet.UCPrintBillan(UCMoneyWallet.PrintType.Billan)
                            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Note, "چاپ قبض شارژ کیف پول انجام گرفت" + vbCrLf + Amount.ToString, _NSS.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                        End If
                    End If
                    RaiseEvent UCMoneyWalletChargedEvent(UcMoneyWallet.UCGetMblgh)
                Else
                    UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "مبلغ شارژ نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                End If
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub UcMonetarySupply_UCMonetarySupplyUnSuccessEvent(TransactionId As Long, Amount As Long, SupplyReport As String) Handles UcMonetarySupply.UCMonetarySupplyUnSuccessEvent
        Try
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "عدم موفقیت شارژ کیف پول" + vbCrLf + SupplyReport, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub



#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
        'Throw New NotImplementedException()
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            UCPrepare(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo), 0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region


End Class
