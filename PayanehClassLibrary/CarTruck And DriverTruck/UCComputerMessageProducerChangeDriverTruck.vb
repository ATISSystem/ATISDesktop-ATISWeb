
Imports System.Drawing
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.ExceptionManagement
Imports R2Core.RFIDCardsManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCComputerMessageProducerChangeDriverTruck
    Inherits UCComputerMessageProducer
    Implements R2CoreRFIDCardRequester



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageProducerChangeDriverTruck_UCRequestSend() Handles Me.UCRequestSend
        Try
            If UcPersianTextBox.UCValue.Trim = String.Empty Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "پلاک و سریال ناوگان وارد نشده است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            Dim SherkatHazinehChangeDriverTruck As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 7)
            Dim AnjomanHazinehChangeDriverTruck As Int64 = R2CoreMClassConfigurationManagement.GetConfigInt64(PayanehClassLibraryConfigurations.TarrifsPayaneh, 9)
            Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = UcMoneyWallet.UCGetTrafficCard()
            'کنترل موجودی کیف پول
            If R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(NSSTerafficCard) < SherkatHazinehChangeDriverTruck + AnjomanHazinehChangeDriverTruck Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "موجودی کافی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            Else
                UcMoneyWallet.UCViewandActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, SherkatHazinehChangeDriverTruck, R2CoreParkingSystemAccountings.SherkatChangeDriverTruck)
                UcMoneyWallet.UCViewandActMoneyWalletNextStatus(NSSTerafficCard, BagPayType.MinusMoney, AnjomanHazinehChangeDriverTruck, R2CoreParkingSystemAccountings.AnjomanChangeDriverTruck)
            End If
            R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, UcPersianTextBox.UCValue.Trim(), PayanehClassLibrary.ComputerMessages.PayanehClassLibraryComputerMessageTypes.ChangeDriverTruck , Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, New DataStruct()))
            UCSuccessSendingNotification()
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exxx As GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, exxx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBox_UCGotFocusEvent() Handles UcPersianTextBox.UCGotFocusEvent
        Try
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
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
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo))
            UCSendIsActive = True
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
    End Sub



#End Region

End Class
