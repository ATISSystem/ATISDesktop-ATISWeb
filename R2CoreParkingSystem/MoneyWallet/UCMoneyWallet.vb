
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI
Imports R2Core.PublicProc
Imports R2Core.SoftwareUserManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.TrafficCardsManagement


Public Class UCMoneyWallet
    Inherits UCGeneral

    Private _DateTime As R2DateTime = New R2DateTime()


#Region "General Properties"

    Public ReadOnly Property UCGetMoneyWalletCurrentCharge As Int64
        Get
            Try
                Return R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletCharge(UCGetTrafficCard)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Get
    End Property

    Private _UCReminder As Int64
    Public ReadOnly Property UCGetReminderCharge As Int64
        Get
            Return _UCReminder
        End Get
    End Property

    Private _UCMblg As Int64 = 0
    Public ReadOnly Property UCGetMblgh As Int64
        Get
            Return _UCMblg
        End Get
    End Property

    Private _UCTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
    Public ReadOnly Property UCGetTrafficCard() As R2CoreParkingSystemStandardTrafficCardStructure
        Get
            Return _UCTrafficCard
        End Get
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcLabelCardNo.UCValue = ""
        UcLabelCurrentCharge.UCValue = ""
        UcLabelReminderCharge.UCValue = ""
        UcLabelMblgh.UCValue = ""
        UcLabelAccountName.UCValue = ""
        PnLBottom.Visible = False
    End Sub

    Private Sub UCSetTrafficCard(YourNSS As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            _UCTrafficCard = YourNSS
            UcLabelCardNo.UCValue = YourNSS.CardNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSetMoneyWalletCurrentCharge()
        Try
            UcLabelCurrentCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetMoneyWalletCurrentCharge)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSetMblgh(YourValue As Int64)
        Try
            _UCMblg = YourValue
            UcLabelMblgh.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourValue)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private _UCBagPayType As BagPayType = BagPayType.None
    Private Sub UCSetReminderCharge()
        Try
            If _UCBagPayType = BagPayType.AddMoney Then
                _UCReminder = UCGetMoneyWalletCurrentCharge + UCGetMblgh
                UcLabelReminderCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetMoneyWalletCurrentCharge + UCGetMblgh)
            ElseIf _UCBagPayType = BagPayType.MinusMoney Then
                _UCReminder = UCGetMoneyWalletCurrentCharge - UCGetMblgh
                UcLabelReminderCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetMoneyWalletCurrentCharge - UCGetMblgh)
            ElseIf _UCBagPayType = BagPayType.None Then
                _UCReminder = UCGetMoneyWalletCurrentCharge
                UcLabelReminderCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetMoneyWalletCurrentCharge)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewMoneyWalletNextStatus(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagPayType As BagPayType, YourMblgh As Int64, YourAccountCode As R2CoreParkingSystem.AccountingManagement.R2CoreParkingSystemAccountings)
        Try
            UCSetTrafficCard(YourNSSTrafficCard)
            UCSetMoneyWalletCurrentCharge()
            UCSetMblgh(YourMblgh)
            _UCBagPayType = YourBagPayType
            UCSetReminderCharge()
            UcLabelAccountName.UCValue = R2CoreParkingSystemMClassAccountingManagement.GetAccountingNamebyAccountingCode(YourAccountCode)
            PnLBottom.Visible = True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewandActMoneyWalletNextStatus(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourBagType As BagPayType, YourMblgh As Int64, YourAccountCode As R2CoreParkingSystemAccountings)
        Try
            UCViewMoneyWalletNextStatus(YourNSSTrafficCard, YourBagType, YourMblgh, YourAccountCode)
            R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(YourNSSTrafficCard, YourBagType, YourMblgh, YourAccountCode,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewMoneyWalletOnlyCharge(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UCViewMoneyWalletNextStatus(YourNSSTrafficCard, BagPayType.None, 0, R2CoreParkingSystemAccountings.NoneType)
            PnLBottom.Visible = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetAllMoney(YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure, YourAccountCode As R2CoreParkingSystemAccountings) As Int64
        Try
            Dim AllMoney As Int64 = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletAllMoney(YourNSSTrafficCard, YourAccountCode,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewMoneyWalletOnlyCharge(YourNSSTrafficCard)
            Return AllMoney
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private _PrintType As PrintType = PrintType.None
    Private WithEvents PrintDocument As PrintDocument = New PrintDocument
    Public Sub UCPrintBillan(YourPrintType As PrintType)
        Try
            _PrintType = YourPrintType
            PrintDocument.Print()
            'PrintDocument.Print()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Print Document Object Model Chop"
    Private Sub PrintDocument_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument.BeginPrint
    End Sub

    Private Sub PrintDocument_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument.EndPrint
        Try
        Catch ex As Exception
        End Try
    End Sub

    Public Enum PrintType
        None = 0
        Billan = 1
        Reminder = 2
    End Enum

    Private Sub PrintDocument_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
        Try
            Dim myPaperSizeHalf As Integer = PrintDocument.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
            Dim myStrFont As Drawing.Font = New System.Drawing.Font("B Homa", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim myDigFont As Drawing.Font = New System.Drawing.Font("Alborz Titr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
            If _PrintType = PrintType.Billan Then
                E.Graphics.DrawString("پايانه حمل و نقل اميرکبير", myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "پايانه حمل و نقل اميرکبير".Length, Y)
                E.Graphics.DrawString("صورتحساب کیف پول", myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "صورتحساب کیف پول".Length, Y + 30)
                E.Graphics.DrawString("ID:" + UCGetTrafficCard.CardNo, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "شناسه:".Length, Y + 50)
                E.Graphics.DrawString("تاريخ:" + _DateTime.GetCurrentDateShamsiFull, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "تاريخ:".Length, Y + 70)
                E.Graphics.DrawString("زمان:" + _DateTime.GetCurrentTime, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "زمان:".Length, Y + 90)
                E.Graphics.DrawString("مبلغ :" + R2CoreMClassPublicProcedures.ParseSignDigitToSignString(UCGetMblgh) + " ريال", myStrFont, Brushes.DarkBlue, myPaperSizeHalf - ("مبلغ :" + R2CoreMClassPublicProcedures.ParseSignDigitToSignString(UCGetMblgh) + " ريال").Length, Y + 110)
                E.Graphics.DrawString("موجودی :" + R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetReminderCharge) + " ريال", myStrFont, Brushes.DarkBlue, myPaperSizeHalf - ("موجودی :" + R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetReminderCharge) + " ريال ").Length, Y + 130)
                E.Graphics.DrawString("کاربر:" + R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserName, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "کاربر:".Length, Y + 150)
                E.Graphics.DrawString("----------------------", myStrFont, Brushes.DarkBlue, myPaperSizeHalf - "----------------------".Length, Y + 170)
            ElseIf _PrintType = PrintType.Reminder Then
                E.Graphics.DrawString("پايانه حمل و نقل اميرکبير", myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "پايانه حمل و نقل اميرکبير".Length, Y)
                E.Graphics.DrawString("موجودي کیف پول", myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "موجودي کیف پول".Length, Y + 30)
                E.Graphics.DrawString("ID:" + UCGetTrafficCard.CardNo, myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "شناسه:".Length, Y + 50)
                E.Graphics.DrawString("تاريخ:" + _DateTime.GetCurrentDateShamsiFull, myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "تاريخ:".Length, Y + 70)
                E.Graphics.DrawString("زمان:" + _DateTime.GetCurrentTime, myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "زمان:".Length, Y + 90)
                E.Graphics.DrawString("موجودي:" + R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetReminderCharge) + " ريال", myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - ("موجودي :" + R2CoreMClassPublicProcedures.ParseSignDigitToTashString(UCGetReminderCharge) + " ريال").Length, Y + 110)
                E.Graphics.DrawString("----------------------", myStrFont, Drawing.Brushes.DarkBlue, myPaperSizeHalf - "----------------------".Length, Y + 130)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Try
            PrintDocument_PrintPage_Printing(0, 0, e)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
