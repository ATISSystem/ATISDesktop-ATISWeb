
Imports System.IO
Imports System.Reflection

Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports R2Core.PublicProc
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DriverTruckPresentManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.FingerPrintsManagement.DermalogSystem


Public Class FrmcDriverTruckPresentDermalog
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime = New R2DateTime
    Private _NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure
    Private _NSSCar As R2StandardCarStructure
    Private _NSSDriverTruck As R2StandardDriverTruckStructure
    Private WithEvents DermalogControlTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcDriverTruckPresentDermalog))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        Try
            UcFingerPrintCapturerDermalog.UCRefresh()
            UcFingerPrintCapturerDermalog.UCLifenessScore = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt64(R2CoreConfigurations.Dermalog, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0)
            UcFingerPrintCapturerDermalog.UCInitialize()
            UcCarEnterExitStatus.UCRefresh()
            UcTerafficCardPresenter.UCRefresh()
            UcCarPresenter.UCRefresh()
            UcCarAndTerafficCard.UCRefresh()
            UcMoneyWallet.UCRefresh()
            UcDriverTruckPresentCollection.UCRefresh()
            UcDriverImage.UCRefresh()
            UcCarTruckNobat.UCRefresh()
            DermalogControlTimer.Interval = 200
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub VerificationProcess(ByVal VerificationFlag As Boolean)
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2PrimarySqlConnection).GetConnection()
        Try
            'دریافت اثرانگشت ثبت شده راننده یا راننده های ناوگان
            Dim CountOfDrivers As Int64 = R2CoreParkingSystemMClassDrivers.GetCountOfDriversAttachedCar(_NSSCar)
            Dim DS As DataSet = New DataSet()
            If CountOfDrivers = 0 Then
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننذه باری" + vbCrLf + "تعداد راننده متصل به ناوگان نامتعارف است", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "تعداد راننده متصل به ناوگان نامتعارف است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Try
            ElseIf CountOfDrivers = 1 Then
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints where DriverId=" & R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar) & "", 1, DS)
            ElseIf CountOfDrivers = 2 Then
                R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * From R2PrimaryTransportationAndLoadNotification.dbo.TblFingerPrints where (DriverId=" & R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar) & ") or (DriverId=" & R2CoreParkingSystemMClassCars.GetnIdPersonSecond(_NSSCar.nIdCar) & ")", 1, DS)
            End If

            If VerificationFlag = False Then
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent(NobatId,CardId,CarId,DriverId,CardNo,PelakSerial,DriverNameFamily,PresentType,DateTimeMilladi,DateShamsi,UserId) values(" & UcCarTruckNobat.UCGetNSS.nEnterExitId & "," & _NSSTerafficCard.CardId & "," & _NSSCar.nIdCar & "," & _NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _NSSTerafficCard.CardNo & "','" & _NSSCar.GetCarPelakSerialComposit() & "','" & R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar)).StrPersonFullName & "'," & PresentType.Salon & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "'," & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                ViewPresent()
                Exit Try
            End If

            'اثرانگشت راننده غیرفعال است
            If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.IsDriverTruckFingerPrintActive(_NSSDriverTruck) = False Then
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent(NobatId,CardId,CarId,DriverId,CardNo,PelakSerial,DriverNameFamily,PresentType,DateTimeMilladi,DateShamsi,UserId) values(" & UcCarTruckNobat.UCGetNSS.nEnterExitId & "," & _NSSTerafficCard.CardId & "," & _NSSCar.nIdCar & "," & _NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _NSSTerafficCard.CardNo & "','" & _NSSCar.GetCarPelakSerialComposit() & "','" & R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar)).StrPersonFullName & "'," & PresentType.Salon & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "'," & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                ViewPresent()
                Exit Try
            End If

            'تجمیع اثرهای انگشت رانندگان
            Dim TemplateArray As Byte()() = New Byte(20)() {}
            Dim TemplateArraySize As Integer() = New Integer(20) {}
            Dim TemplateNumber As Integer = 0
            Dim ControlerIndex As Integer = 0
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag1") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate1")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag2") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate2")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag3") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate3")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag4") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate4")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag5") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate5")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag6") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate6")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag7") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate7")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag8") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate8")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag9") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate9")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If DS.Tables(0).Rows(0).Item("FPTemplateFlag10") = True Then
                TemplateArray(ControlerIndex) = DS.Tables(0).Rows(0).Item("FPTemplate10")
                TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                TemplateNumber += 1
                ControlerIndex += 1
            End If
            If CountOfDrivers = 2 Then
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag1") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate1")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag2") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate2")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag3") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate3")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag4") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate4")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag5") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate5")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag6") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate6")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag7") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate7")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag8") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate8")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag9") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate9")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
                If DS.Tables(0).Rows(1).Item("FPTemplateFlag10") = True Then
                    TemplateArray(ControlerIndex) = DS.Tables(0).Rows(1).Item("FPTemplate10")
                    TemplateArraySize(ControlerIndex) = TemplateArray(ControlerIndex).Length
                    TemplateNumber += 1
                    ControlerIndex += 1
                End If
            End If

            'اجرای فرآیند اصلی تایید هویت
            Dim myScore As Double
            If R2CoreFingerPrintMClassDermalogManagemet.Verification(UcFingerPrintCapturerDermalog.GetlISTfPS, TemplateArray, TemplateNumber, myScore) = True Then
                UcFingerPrintCapturerDermalog.UCViewOtherMessage("Score:" + myScore.ToString)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into R2PrimaryTransportationAndLoadNotification.dbo.TblTruckDriverPresent(NobatId,CardId,CarId,DriverId,CardNo,PelakSerial,DriverNameFamily,PresentType,DateTimeMilladi,DateShamsi,UserId) values(" & UcCarTruckNobat.UCGetNSS.nEnterExitId & "," & _NSSTerafficCard.CardId & "," & _NSSCar.nIdCar & "," & _NSSDriverTruck.NSSDriver.nIdPerson & ",'" & _NSSTerafficCard.CardNo & "','" & _NSSCar.GetCarPelakSerialComposit() & "','" & R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar)).StrPersonFullName & "'," & PresentType.Salon & ",'" & _DateTime.GetCurrentDateTimeMilladiFormated & "','" & _DateTime.GetCurrentDateShamsiFull & "'," & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ")"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                ViewPresent()
            Else
                Dim UCDImage As UCDriverImage = New UCDriverImage()
                UCDImage.UCViewDriverImage(_NSSDriverTruck.NSSDriver)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مورد تاييد نيست", "", FrmcMessageDialog.MessageType.PersianMessage, UCDImage.UCGetImage, Nothing)
            End If

        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ViewPresent()
        Try
            UcDriverImage.BringToFront()
            UcDriverImage.UCViewDriverImage(PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar)).NSSDriver)
            UcDriverTruckPresentCollection.UCViewPresent(UcCarTruckNobat.UCGetNSS.nEnterExitId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private _LastReadedCardNo As String = String.Empty
    Private Sub FrmcDriverTruckPresentDermalog__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            ''کنترل ماندن کارت روی کارت خوان
            ''If _LastReadedCardNo.Trim = CardNo Then Exit Try

            FrmRefresh()

            'نمایش مشخصات کارت تردد
            Try
                _NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
                UcTerafficCardPresenter.UCShowTrafficCard(_NSSTerafficCard)
                Dim nIdCar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(_NSSTerafficCard.CardId)
                _NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(nIdCar)
            Catch exx As GetNSSException
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "کارت تردد قابل قبول نیست" + vbCrLf + "و یااطلاعات ناوگان باری موجود نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت تردد قابل قبول نیست" + vbCrLf + "و یااطلاعات ناوگان باری موجود نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                StartReading()
                Return
            Catch exxx As GetDataException
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "اطلاعات پایه کارت تردد و خودرو و روابط آن ها تکمیل نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اطلاعات پایه کارت تردد و خودرو و روابط آن ها تکمیل نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                StartReading()
                Return
            End Try

            'نمایش وضعیت حضور ناوگان در پایانه 
            UcCarEnterExitStatus.UCViewStatus(_NSSTerafficCard)

            'نمایش موجودی کیف پول
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTerafficCard)

            'نمایش مشخصات خودرو و راننده
            Try
                UcCarAndTerafficCard.UCSetTerafficCard(_NSSTerafficCard)
                UcCarPresenter.UCViewCarInformation(_NSSCar)
                _NSSDriverTruck = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(_NSSCar.nIdCar))
            Catch ex As Exception When TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "اطلاعات مرتبط با راننده ، ناوگان و یا کارت تردد یافت نشد", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اطلاعات مرتبط با راننده ، ناوگان و یا کارت تردد یافت نشد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                StartReading()
                Return
            End Try

            'نمایش مشخصات آخرین نوبت فعال
            Try
                UcCarTruckNobat.UCViewInf(_NSSCar)
            Catch exx As GetNobatException
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + exx.Message, _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                StartReading()
                Return
            End Try

            'نمایش لیست حاضری ها
            UcDriverTruckPresentCollection.UCViewPresent(UcCarTruckNobat.UCGetNSS.nEnterExitId)

            'کنترل مجموع بدهی موجودی کیف پول و مبلغ سالنی 
            Dim BedehyJam As Int64 = PayanehClassLibraryMClassDriverTruckSalonPresentManagement.GetBedehyJamForDriverTruckSalonPresentSystem(_NSSTerafficCard)
            If BedehyJam < 0 Then
                Dim BedString As String = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(Math.Abs(BedehyJam) - (Math.Abs(BedehyJam) Mod 10000) + 10000)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کسری موجودی شارژ" + vbCrLf + BedString + vbCrLf + "ریال", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Nothing)
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "کسری موجودی شارژ" + " " + BedString + " " + "ریال", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                StartReading()
                Return
            End If

            'ناوگان غير بومي اگر حتي يک روز هم حاضري نداشته باشد نمي تواند به حاضري زدن ادامه بدهد
            If _NSSCar.StrCarSerialNo <> "13" And _NSSCar.StrCarSerialNo <> "23" And _NSSCar.StrCarSerialNo <> "43" Then
                If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.ExistIndigenousTrucksWithUNNativeLP(_NSSCar.StrCarNo, _NSSCar.StrCarSerialNo) = False Then
                    If PayanehClassLibraryMClassCarTruckNobatManagement.GetNobatDateShamsi(UcCarTruckNobat.UCGetNSS.nEnterExitId) >= R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.SalonFingerPrint, 6) Then
                        If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.IsDriverTruckPresentsContinuous(UcCarTruckNobat.UCGetNSS.nEnterExitId) = False Then
                            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "ناوگان غير بومي.حاضري هاي قبلي کامل نيست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "ناوگان غير بومي" + vbCrLf + "حاضري هاي قبلي کامل نيست.امکان ثبت حاضري وجود ندارد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Nothing)
                            StartReading()
                            Return
                        End If
                    End If
                End If
            End If

            'کنترل این که راننده دوم روی بیش از دو ناوگان نباشد برای تقلب
            Try
                If R2CoreParkingSystemMClassDrivers.GetCountOfCarsSecondDriverAttached(R2CoreParkingSystemMClassDrivers.GetNSSDriver(R2CoreParkingSystemMClassCars.GetnIdPersonSecond(_NSSCar.nIdCar))) > 2 Then
                    R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "نام راننده دوم ناوگان بيش از دو مرتبه ثبت شده است و غير مجاز است", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                    _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "نام راننده دوم ناوگان بيش از دو مرتبه ثبت شده است و غير مجاز است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Nothing)
                    StartReading()
                    Return
                End If
            Catch ex As Exception When TypeOf ex Is GetNSSException OrElse TypeOf ex Is GetDataException
            End Try

            'کنترل ثبت اوليه اثر انگشت 
            If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.HaveDriversFingerPrintSabted(_NSSCar) = False Then
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت راننده باری" + vbCrLf + "اثرانگشت و تصوير راننده اول یا دوم ثبت نشده است", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اثرانگشت و تصوير راننده اول یا دوم ثبت نشده است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Nothing)
                StartReading()
                Return
            End If

            'آيا متابق كانفيگ درمالوگ سالن سالم است يا خراب و اثر بايد دريافت شود يا نه
            If R2CoreMClassConfigurationManagement.GetConfigBoolean(PayanehClassLibraryConfigurations.SalonFingerPrint, 4) = False Then
                VerificationProcess(False)
                StartReading()
                Return
            End If

            ''کنترل خواندن بیش از یک مرتبه کارت که روی کارت خوان مانده  باشد
            ''_LastReadedCardNo = UcTerafficCardPresenter.UCGetNSS.CardNo

            UcFingerPrintCapturerDermalog.BringToFront()
            DermalogControlTimer.Enabled = True
            DermalogControlTimer.Start()
            UcFingerPrintCapturerDermalog.UCStartCapturing()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcDriverTruckPresentDermalog__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    Private Sub FrmcDriverTruckPresentDermalog__UCDisposeRequest() Handles Me._UCDisposeRequest

    End Sub

    Private Sub DermalogControlTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DermalogControlTimer.Tick
        Try
            If UcFingerPrintCapturerDermalog.CapturingStatus = True Then
                DermalogControlTimer.Stop()
                UcFingerPrintCapturerDermalog.UCStopCapturing()
                VerificationProcess(True)
            End If
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCarTruck_UCViewCarTruckInformationCompletedEvent(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompletedEvent
        Try
            UcDriverTruckFirst.UCViewDriverInformation(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
            UcDriverTruckSecond.UCViewDriverInformation(R2CoreParkingSystem.Cars.R2CoreParkingSystemMClassCars.GetnIdPersonSecond(CarId))
        Catch ex As GetDataException
            FrmcViewLocalMessage(ex.Message)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try


    End Sub

    Private Sub UcFingerPrintCapturerDermalog_UCDetectError(ErrorMessage As String) Handles UcFingerPrintCapturerDermalog.UCDetectError
        Try
            'بررسی شود بخاطر صدیقی غیرفعال شده است 
            'FrmcViewLocalMessage(ErrorMessage)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub FrmcDriverTruckPresentDermalog__MenuRunCompletedEvent(UC As UCMenu) Handles Me._MenuRunCompletedEvent

    End Sub

    Private Sub FrmcDriverTruckPresentDermalog__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlTerafficCardAccounting" Then
                UcAccountingCollection.UCViewAccounting(_NSSTerafficCard)
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