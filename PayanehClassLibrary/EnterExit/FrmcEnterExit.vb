
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Timers

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.RFIDCardsManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreLPR.LicensePlateRecognizer
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.AuthenticationManagement
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.DriverMonitor
Imports R2Core.ComputersManagement
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DriverTruckPresentManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns.Exceptions


Public Class FrmcEnterExit
    Inherits FrmcGeneral


    Private WithEvents _DateTime As R2DateTime = New R2DateTime
    Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
    Private WithEvents _TimerClearLastReadedTeraficCard As New System.Timers.Timer



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            NewEnterExitRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcEnterExit))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub NewEnterExitRefresh()
        Try
            UcCarPresenter.UCRefresh()
            UcTerafficCardPresenter.UCRefresh()
            UcCarAndTrafficCard.UCRefresh()
            UcMoneyWallet.UCRefresh()
            UcCarImage.UCRefresh()
            UcMoneyWalletCharge.UCRefresh()
            UcMoneyWalletCharge.SendToBack()
            UcCarImage.UCSetMarginColor(Color.White)
            UcBlackListCompositBlackListViewer.Visible = False
            _TimerClearLastReadedTeraficCard.Interval = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt64(R2CoreParkingSystemConfigurations.FrmcEnterExitSetting, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub FrmcEnterExit__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent
    End Sub

    Private _LastReadedCardNo As String = String.Empty
    Private Sub FrmcEnterExit__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            'کنترل این که کارت روی کارت خوان نماند
            If _LastReadedCardNo = CardNo Then
                Exit Try
            Else
                _LastReadedCardNo = CardNo
                _TimerClearLastReadedTeraficCard.Stop()
                _TimerClearLastReadedTeraficCard.Enabled = True
                _TimerClearLastReadedTeraficCard.Start()
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            'بروز رساني صفحه تردد
            NewEnterExitRefresh()
            _NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            UcTerafficCardPresenter.UCShowTrafficCard(_NSSTrafficCard)

            'وضعیت تردد در ابتدای فرآیند تنظیم می گردد
            Dim myEnterStatus = R2EnterStatus.NormalEnter
            Dim myExitStatus = R2ExitStatus.NormalExit

            'تردد از نوع خروج است يا ورود و شاخص آخرين تردد
            Dim myEnterExitId As Int64
            Dim myEnterExitRequest As R2EnterExitRequestType = R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(_NSSTrafficCard, myEnterExitId)

            'نمایش موجودی کیف پول مرتبط با کارت تردد و در صورت رایگان بودن نام شرکت مرتبط
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTrafficCard)
            If _NSSTrafficCard.NoMoney = True Then
                FrmcViewLocalMessage(_NSSTrafficCard.CompanyName + " - " + "تردد آزاد")
                If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then myEnterStatus = R2EnterStatus.EnterNoMoney
                If myEnterExitRequest = R2EnterExitRequestType.ExitRequest Then myExitStatus = R2ExitStatus.ExitNoMony
            End If

            '  فعال بودن يا نبودن كارت
            If _NSSTrafficCard.Active = False Then
                Dim myMessage As String = "كارت تردد غير فعال است "
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, myMessage, "استفاده از اين كارت ممنوع و غير مجاز است", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, Nothing, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "استفاده از اين كارت ممنوع و غير مجاز است", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Exit Try
            End If

            'کنترل نوع کارت هنگام تردد که مطابق نوع کارت معبر باشد
            If R2CoreParkingSystemMClassTrafficCardManagement.IsTrafficCardTypeSupported(CardNo) = False Then
                Dim CName As String = R2CoreParkingSystemMClassTrafficCardManagement.GetTrafficCardTypeName(CardNo)
                Dim myMessage As String = "نوع کارت" + " " + CName + " " + "پشتيبانی نمی شود"
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, myMessage, "یک کارت جدید روی دستگاه کارت خوان بکشید", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, Nothing, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, myMessage, _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Exit Try
            End If

            'کنترل تطابق نوع کارت و وضعیت ورود و خروج آن با شرایط تنظیم شده برای معبر
            If R2CoreParkingSystemMClassEnterExitManagement.IsTrafficCardEnterExitStatusWithMaabarMatch(myEnterExitRequest, _NSSTrafficCard) = False Then
                ''این قسمت به صورت موقت انجام می گردد و باید بعدا حذف گردد
                ''If _NSSTrafficCard.CardType = TerafficCardType.Tereili And R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId = 4 Then
                ''    Try
                ''        R2CoreParkingSystemMClassEnterExitManagement.ExitTempTerafficCard(_NSSTrafficCard, 0)
                ''        _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت را مجددا روی دستگاه بکشید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                ''        StartReading()
                ''        Return
                ''    Catch ex As Exception
                ''    End Try
                ''End If
                Dim myMessage As String = "وضعیت ورود یا خروج کارت با این معبر مطابقت ندارد"
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, myMessage + vbCrLf + "کارت  قبلا  " + R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestTypeName(myEnterExitRequest) + " نشده است  ", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, Nothing, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "وضعیت ورود یا خروج کارت با این معبر مطابقت ندارد", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Exit Try
            End If

            'کنترل ورود و خروج با نوع کارت خوان
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest And R2CoreRFIDCardReaderInterface.GetRFType() = R2CoreRFIDCardReader.RFType.RFType2 Then
                Dim myMessage As String = "ورود کارت با کارت خوان دوم امکان پذير نيست"
                R2CoreRFIDCardReaderInterface.ControlLeds(0, 1)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, myMessage, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, 0, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, Nothing, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "ورود کارت با کارت خوان دوم امکان پذير نيست", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                Exit Try
            ElseIf myEnterExitRequest = R2EnterExitRequestType.ExitRequest And R2CoreRFIDCardReaderInterface.GetRFType = R2CoreRFIDCardReader.RFType.RFType2 Then
                R2CoreRFIDCardReader.ControlLeds(1, 0)
            End If

            'عکس گرفتن و نمایش تصویر خودرو
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then
                    UcCarImage.UCTakeAndViewImage(R2TwoCamera.Camera1)
                Else
                    UcCarImage.UCViewDefaultCarImage(_NSSTrafficCard.CardType)
                End If
            Else
                UcCarImage.UCViewCarEnterExitImage(_NSSTrafficCard)
            End If

            '  احراز پلاک از طریق رابطه پلاک با کارت تردد و سپس در صورت عدم موفقیت از طریق پلاک خوانی
            Dim myLP As R2StandardLicensePlateStructure = New R2StandardLicensePlateStructure("", "", "", R2PelakType.None)
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                Try
                    UcCarAndTrafficCard.UCSetTerafficCard(_NSSTrafficCard)
                    myLP = UcCarAndTrafficCard.UCGetLP()
                Catch ex As Exception When TypeOf ex Is GetDataException OrElse TypeOf ex Is CarNotExistException OrElse TypeOf ex Is GetNSSException
                    'چون از رابطه کارت و پلاک چیزی بدست نیامد پس خطا هم نباید ایجاد شود
                    Dim LPTemp As R2StandardLicensePlateStructure = UcCarImage.UCGetLP()
                    If Object.Equals(LPTemp, Nothing) Then
                    Else
                        myLP = LPTemp
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            ElseIf myEnterExitRequest = R2EnterExitRequestType.ExitRequest Then
                Dim myLPLinked As R2StandardLicensePlateStructure = R2CoreParkingSystemMClassEnterExitManagement.GetLPfromEnterExit(_NSSTrafficCard)
                If myLPLinked IsNot Nothing Then
                    myLP = myLPLinked
                    Try
                        UcCarAndTrafficCard.UCSetCar(myLP)
                    Catch ex As Exception
                        FrmcViewLocalMessage("Location_1_FrmcEnterExit__RFIDCardReadedEvent:" + ex.Message)
                    End Try
                End If
            End If

            'نمایش مشخصات خودرو ائم از پلاک و سریال
            Try
                Dim nIDcar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCar(myLP)
                UcCarPresenter.UCViewCarInformation(R2CoreParkingSystemMClassCars.GetNSSCar(nIDcar))
            Catch exx As GetDataException
            Catch ex As Exception
                FrmcViewLocalMessage("Location_2_FrmcEnterExit__RFIDCardReadedEvent:" + ex.Message)
            End Try

            'بررسي ليست سياه
            Try
                Dim nIDcar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCar(myLP)
                Dim NSSCarforBlackList As R2StandardCarStructure = R2CoreParkingSystemMClassCars.GetNSSCar(nIDcar)
                If (Not (Object.Equals(NSSCarforBlackList, Nothing))) Then
                    UcBlackListCompositBlackListViewer.UCViewInformation(NSSCarforBlackList)
                    UcBlackListCompositBlackListViewer.UCForceToVisable()
                End If
            Catch ex As Exception
            Catch exx As GetDataException
            Catch exxx As GetNSSException
            End Try

            'محاسبه هزينه تردد
            Dim myMblgh As Int64 = 0
            Dim myTavaghof As Int16 = 0
            myMblgh = R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitMblgh(_NSSTrafficCard, myEnterExitRequest, myTavaghof)
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                UcMoneyWallet.UCViewMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.MinusMoney, myMblgh, R2CoreParkingSystemAccountings.EnterType)
            ElseIf myEnterExitRequest = R2EnterExitRequestType.ExitRequest Then
                UcMoneyWallet.UCViewMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.MinusMoney, myMblgh, R2CoreParkingSystemAccountings.ExitType)
            End If

            'كنترل شارژ موجود نسبت به هزينه تردد
            If (UcMoneyWallet.UCGetReminderCharge < 0) And (myEnterExitRequest = R2EnterExitRequestType.EnterRequest) Then
                Dim myMessage As String = "كارت تردد شما فاقد شارژ مورد نياز است" + vbCrLf + "به واحد شارژ مراجعه نماييد"
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, myMblgh, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, myLP, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "كارت تردد شما فاقد شارژ مورد نياز است - هنگام ورود", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            End If
            If (UcMoneyWallet.UCGetReminderCharge < 0) And (myEnterExitRequest = R2EnterExitRequestType.ExitRequest) Then
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "كارت تردد شما فاقد شارژ مورد نياز است - هنگام خروج", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                If (R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.ChargeActiveOnThisLocation, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True) And (R2CoreMClassLoginManagement.CurrentUserNSS.UserCanCharge = True) Then
                    ChangeMenuStatus("PnlMoneyWalletCharge", False)
                    ''PnlMoneyWalletCharge.Enabled = False
                    UcMoneyWalletCharge.UCPrepare(_NSSTrafficCard, Math.Abs(UcMoneyWallet.UCGetReminderCharge))
                    UcMoneyWalletCharge.BringToFront()
                    UcMoneyWalletCharge.Focus()
                    R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, myMblgh, UcMoneyWallet.UCGetReminderCharge, "كارت تردد شما فاقد شارژ مورد نياز است", 18, Color.Red, myLP, _DateTime.GetCurrentDateTimeMilladi))
                    Exit Try
                Else
                    Dim myMessage As String = "كارت تردد شما فاقد شارژ مورد نياز است" + vbCrLf + "به واحد شارژ مراجعه نماييد"
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, myMessage, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                    R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode(), _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, myMblgh, UcMoneyWallet.UCGetReminderCharge, myMessage, 18, Color.Red, myLP, _DateTime.GetCurrentDateTimeMilladi))
                    Exit Try
                End If
            End If

            'بررسی اینکه خودرو با کارتی تردد کرده است که خروج نشده باشد و با کارت حاضر متفاوت باشد
            'در شرایطی که کارت خروج نشده در ورودی می توان کارت جدید داد تا قبلی را بسوزاند و موجودی را به کارت جدید منتقل کند
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                If myLP.Pelak <> "" Or myLP.Serial <> "" Or myLP.City <> "" Or myLP.PelakType <> R2PelakType.None Then
                    Dim LastEnterExitId As Int64
                    Dim LastTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassEnterExitManagement.GetLastTrafficCardWhichNotExited(myLP, LastEnterExitId)
                    If LastTrafficCard IsNot Nothing Then
                        If _NSSTrafficCard.CardNo <> LastTrafficCard.CardNo Then
                            R2CoreParkingSystemMClassTrafficCardManagement.DisallowTerafficCard(LastTrafficCard)
                            R2CoreParkingSystemMClassEnterExitManagement.UpdateForExit(New R2StandardEnterExitStructure(LastEnterExitId, Now, "", "", R2CaptureType.None, R2CameraType.None, Nothing, "", 0, R2EnterStatus.None, 0, 0, Nothing, _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, R2CaptureType.None, R2CameraType.None, Nothing, LastTrafficCard.CardNo, R2CoreMClassLoginManagement.GetNSSSystemUser.UserId, R2ExitStatus.SystemExit, 0, R2CoreMClassConfigurationManagement.GetComputerCode, myLP, True))
                            Dim LastTrafficCardCharge As Int64 = R2CoreParkingSystemMClassMoneyWalletManagement.GetMoneyWalletAllMoney(LastTrafficCard, R2CoreParkingSystemAccountings.ExitSystem)
                            R2CoreParkingSystemMClassMoneyWalletManagement.ActMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.AddMoney, LastTrafficCardCharge, R2CoreParkingSystemAccountings.TransferallChargeToAnother)
                        End If
                    End If
                End If
            End If

            'تراكنش ثبت اطلاعات تردد و کیف پول
            Try
                If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                    Dim myEnterExitIDTemp As UInt64 = R2CoreParkingSystemMClassEnterExitManagement.InsertEnterExit(New R2StandardEnterExitStructure(0, _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, R2CaptureType.AniiCapture, R2CameraType.EnterCamera, Nothing, _NSSTrafficCard.CardNo, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, myEnterStatus, myMblgh, R2CoreMClassConfigurationManagement.GetComputerCode, myLP, _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, R2CaptureType.None, R2CameraType.None, Nothing, "", 0, R2ExitStatus.None, 0, 0, New R2StandardLicensePlateStructure, False))
                    'ذخیره سازی تصویر
                    If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then
                        If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.SaveCarPicture, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then
                            UcCarImage.UCSaveCarEnterExitImage(New R2StandardEnterExitStructure(myEnterExitIDTemp, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                        End If
                    End If
                    UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.MinusMoney, UcMoneyWallet.UCGetMblgh, R2CoreParkingSystemAccountings.EnterType)
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "ثبت موفقیت آمیز تردد - هنگام ورود", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                ElseIf myEnterExitRequest = R2EnterExitRequestType.ExitRequest Then
                    R2CoreParkingSystemMClassEnterExitManagement.UpdateForExit(New R2StandardEnterExitStructure(myEnterExitId, Now, "", "", R2CaptureType.None, R2CameraType.None, Nothing, "", 0, R2EnterStatus.None, 0, 0, Nothing, _DateTime.GetCurrentDateTimeMilladi, _DateTime.GetCurrentDateShamsiFull, _DateTime.GetCurrentTime, R2CaptureType.AniiCapture, R2CameraType.Bidirectional, Nothing, _NSSTrafficCard.CardNo, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, myExitStatus, UcMoneyWallet.UCGetMblgh, R2CoreMClassConfigurationManagement.GetComputerCode(), myLP, True))
                    UcMoneyWallet.UCViewandActMoneyWalletNextStatus(_NSSTrafficCard, BagPayType.MinusMoney, UcMoneyWallet.UCGetMblgh, R2CoreParkingSystemAccountings.ExitType)
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "ثبت موفقیت آمیز تردد - هنگام خروج", _NSSTrafficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + "تراکنش ثبت تردد" + vbCrLf + ex.Message)
            End Try

            'تراکنش موفق
            UcCarImage.UCDrawLP(myLP.GetLPString())
            If myEnterExitRequest = R2EnterExitRequestType.EnterRequest Then
                'ترسیم مستطیل محدوده
                If R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.Camera1, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) = True Then
                    UcCarImage.UCDrawRangeRectangle()
                End If
                Dim myMessage As String = "ورود امكان پذير است"
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode, _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, UcMoneyWallet.UCGetMblgh, UcMoneyWallet.UCGetReminderCharge, myMessage, 22, Color.Green, myLP, _DateTime.GetCurrentDateTimeMilladi))
                UcCarImage.UCSetMarginColor(Color.GreenYellow)
                'فرآیند صدور نوبت ناوگان باری
                If (UcTurnRegisterRequestConfirmation.UCChkTruckNobat = True) And R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTerraficCardTypeforTurnRegisteringActive(_NSSTrafficCard) Then
                    Dim TurnId As Int64 = Int64.MinValue
                    Dim TurnRegisterRequestId = TurnRegisterRequest.PayanehClassLibraryMClassTurnRegisterRequestManagement.RealTimeTurnRegisterRequest(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(_NSSTrafficCard.CardId)), False, False, TurnId)
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "نوبت صادر شد" & vbCrLf & "شماره درخواست : " + TurnRegisterRequestId.ToString & vbCrLf & "شماره نوبت :" + TurnId.ToString, String.Empty, FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                End If
                UcTurnRegisterRequestConfirmation.UCChkTruckNobat = True
                R2CoreRFIDCardReaderInterface.BeepRFIDCardReader(0)
            ElseIf myEnterExitRequest = R2EnterExitRequestType.ExitRequest Then
                Dim myMessage As String = "خروج امكان پذير است"
                R2CoreParkingSystemMClassDriverMonitor.UpdateDriverMonitorInfForMaabar(New R2CoreParkingSystemDriverMonitorStructure(R2CoreMClassConfigurationManagement.GetComputerCode, _NSSTrafficCard.CardId, UcMoneyWallet.UCGetMoneyWalletCurrentCharge, UcMoneyWallet.UCGetMblgh, UcMoneyWallet.UCGetReminderCharge, myMessage, 22, Color.Green, myLP, _DateTime.GetCurrentDateTimeMilladi))
                R2CoreParkingSystemMClassEnterExitManagement.OpenGate(myEnterExitRequest)
                If (R2CoreMClassConfigurationOfComputersManagement.GetConfigBoolean(R2CoreParkingSystemConfigurations.SepasSystem, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1) = True) And (UcMoneyWallet.UCGetReminderCharge > 10000) Then
                    UcMoneyWallet.UCPrintBillan(UcMoneyWallet.PrintType.Reminder)
                End If
                UcCarImage.UCSetMarginColor(Color.Red)
                'فرآیند خروج کارت در سپاس که در آینده باید حذف گردد
                If _NSSTrafficCard.CardType = TerafficCardType.Tereili Or _NSSTrafficCard.CardType = TerafficCardType.SixCharkh Or _NSSTrafficCard.CardType = TerafficCardType.TenCharkh Then
                    R2CoreParkingSystemMClassEnterExitManagement.SetFlagATOTrueIntbGhabz(_NSSTrafficCard)
                End If
                R2CoreRFIDCardReaderInterface.BeepRFIDCardReader(0)
                ''PnlMoneyWalletCharge.Enabled = True
                ChangeMenuStatus("PnlMoneyWalletCharge", True)
            End If
        Catch ex As Exception When TypeOf ex Is MoneyWalletCurrentChargeNotEnoughException OrElse TypeOf ex Is TurnRegisterRequestTypeNotFoundException OrElse TypeOf ex Is CarIsNotPresentInParkingException OrElse TypeOf ex Is SequentialTurnIsNotActiveException OrElse TypeOf ex Is TurnPrintingInfNotFoundException OrElse TypeOf ex Is GetNobatExceptionCarTruckIsTankTreiler OrElse TypeOf ex Is CarTruckTravelLengthNotOverYetException OrElse TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri OrElse TypeOf ex Is GetNobatException OrElse TypeOf ex Is GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception When TypeOf ex Is GetNobatExceptionCarTruckHasNobat OrElse TypeOf ex Is GetNobatExceptionCarTruckIsShahri
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Information, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Nothing, True)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "ثبت تردد در فرآیند اصلی با خطا مواجه شد", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, True)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub UcMoneyWalletCharge_UCMoneyWalletChargedEvent(Mblgh As Long) Handles UcMoneyWalletCharge.UCMoneyWalletChargedEvent
        Try
            Threading.Thread.Sleep(4000)
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTrafficCard)
            UcMoneyWalletCharge.SendToBack()
            FrmcEnterExit__RFIDCardReadedEvent(_NSSTrafficCard.CardNo)
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyWalletCharge_UCMoneyWalletChargeUserCanceledEvent() Handles UcMoneyWalletCharge.UCMoneyWalletChargeUserCanceledEvent
        Try
            Threading.Thread.Sleep(2000)
            UcMoneyWalletCharge.SendToBack()
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcEnterExit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UcMoneyWalletCharge.DisposeResources()
        UcCarImage.DisposeResources()
    End Sub

    Private Sub FrmcEnterExit__UCDisposeRequest() Handles Me._UCDisposeRequest
        Try
            _TimerClearLastReadedTeraficCard.Dispose()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _TimerClearLastReadedTeraficCard_Elapsed(sender As Object, e As ElapsedEventArgs) Handles _TimerClearLastReadedTeraficCard.Elapsed
        Try
            _TimerClearLastReadedTeraficCard.Enabled = False
            _TimerClearLastReadedTeraficCard.Stop()
            _LastReadedCardNo = String.Empty
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyWalletChargePnlMoneyWalletCharge_UCMoneyWalletChargeRFIDCardReadedEvent(CardNo As String) Handles UcMoneyWalletChargePnlMoneyWalletCharge.UCMoneyWalletChargeRFIDCardReadedEvent
        Try
            UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.UCRefresh()
            _NSSTrafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
        Catch exx As GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت تردد قابل شناسایی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMoneyWalletChargePnlMoneyWalletCharge_UCMoneyWalletChargedEvent(Mblgh As Long) Handles UcMoneyWalletChargePnlMoneyWalletCharge.UCMoneyWalletChargedEvent
        Try
            UcMoneyWalletChargeSavabeghCollectionPnlMoneyWalletCharge.UCViewChargeSavabegh(_NSSTrafficCard)
            UcMoneyWalletChargePnlMoneyWalletCharge.StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcEnterExit__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent

    End Sub

    Private Sub FrmcEnterExit__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlEnterExit" Then
                StartReading()
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletCharge" Then
                UcMoneyWalletChargePnlMoneyWalletCharge.StartReading()
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlAccounting" Then
                UcAccountingCollection.UCViewAccounting(_NSSTrafficCard)
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlMoneyWalletChargeSavabegh" Then
                UcTerafficCardPresenterPnlMoneyWalletChargeSavabegh.UCShowTrafficCard(_NSSTrafficCard)
                UcMoneyWalletChargeSavabeghCollection.UCViewChargeSavabegh(_NSSTrafficCard)
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlCameraViewTest" Then
                UcCarImage.UCTakeAndViewImage(R2TwoCamera.Camera1)
            End If
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