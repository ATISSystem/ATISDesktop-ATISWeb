
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms


Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.LoggingManagement
Imports R2Core.ProcessesManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports PayanehClassLibrary.DriverTruckPresentManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.ProcessesManagement


Public Class FrmcDriverTruckFingerPrintRegister
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime = New R2DateTime()
    Private _NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing

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

    Public Sub FrmRefresh()
        Try
            UcCarTruck.UCRefreshGeneral()
            UcDriverTruckFirst.UCRefreshGeneral()
            UcDriverTruckSecond.UCRefreshGeneral()
            UcDriverImageFirst.UCRefresh()
            UcDriverImageSecond.UCRefresh()
            UcButtonSaveFPsDriverTruckFirst.UCEnable = False
            UcButtonSaveFPsDriverTruckSecond.UCEnable = False
            UcButtonSavePictureDriverTruckFirst.UCEnable = False
            UcButtonSavePictureDriverTruckSecond.UCEnable = False
            UcButtonDeleteFPsDriverTruckFirst.UCEnable = False
            UcButtonDeleteFPsDriverTruckSecond.UCEnable = False
            UcDriverImagePnlRegister.UCRefresh()
            UcFingerPrintCapturerDermalog.UCRefresh()
            UcFingerPrintCapturerDermalog.UCLifenessScore = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt64(R2CoreConfigurations.Dermalog, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 3)
            UcFingerPrintCapturerDermalog.UCInitialize()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcDriverTruckFingerPrintRegister))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonDriverTruckInformationControl_UCClickedEvent() Handles UcButtonDriverTruckInformationControl.UCClickedEvent
        PnlDriverTruckFingerPrintRegister.BringToFront()
        PnlDriverTruckFingerPrintRegister.Focus()
    End Sub

    Private Sub FrmcDriverTruckFingerPrintRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            UcFingerPrintCapturerDermalog.UCDisposeResources()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonGetDriverPicture_UCClickedEvent() Handles UcButtonGetDriverPicture.UCClickedEvent
        Try
            UcDriverImagePnlRegister.UCTakeAndViewImageFromStream(R2TwoCamera.Camera1)
        Catch exx As R2CoreParkingSystemCameraFailException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSaveFPsDriverTruckFirst_UCClickedEvent() Handles UcButtonSaveFPsDriverTruckFirst.UCClickedEvent
        Try
            PayanehClassLibraryMClassDriverTruckSalonPresentManagement.SaveDriverTruckFPs(UcDriverTruckFirst.UCGetNSS, UcFingerPrintCapturerDermalog.GetlISTfPS, UcDriverImagePnlRegister.UCGetImage,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اثرانگشت راننده باری ثبت شد", "تعداد اثر ثبت شده : " + PayanehClassLibraryMClassDriverTruckSalonPresentManagement.GetCountOfFPSSabted().ToString(), FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده اول مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exxx As DriverTruckFPsExistException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exxx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSaveFPsDriverTruckSecond_UCClickedEvent() Handles UcButtonSaveFPsDriverTruckSecond.UCClickedEvent
        Try
            PayanehClassLibraryMClassDriverTruckSalonPresentManagement.SaveDriverTruckFPs(UcDriverTruckSecond.UCGetNSS, UcFingerPrintCapturerDermalog.GetlISTfPS, UcDriverImagePnlRegister.UCGetImage,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اثرانگشت راننده باری ثبت شد", "تعداد اثر ثبت شده : " + PayanehClassLibraryMClassDriverTruckSalonPresentManagement.GetCountOfFPSSabted().ToString(), FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده دوم مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exxx As DriverTruckFPsExistException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exxx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSavePictureDriverTruckFirst_UCClickedEvent() Handles UcButtonSavePictureDriverTruckFirst.UCClickedEvent
        Try
            If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.HaveFirstDriverFingerPrintSabted(UcCarTruck.UCGetNSS().NSSCar) Then
                R2CoreParkingSystemMClassDrivers.SaveDriverImage(UcDriverTruckFirst.UCGetNSS().NSSDriver, UcDriverImagePnlRegister.UCGetImage)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تصویر راننده باری ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اثر انگشت راننده ثبت نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده اول مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As DriverImageCaptureException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSavePictureDriverTrucksecond_UCClickedEvent() Handles UcButtonSavePictureDriverTruckSecond.UCClickedEvent
        Try
            If PayanehClassLibraryMClassDriverTruckSalonPresentManagement.HaveSecondDriverFingerPrintSabted(UcCarTruck.UCGetNSS().NSSCar) Then
                R2CoreParkingSystemMClassDrivers.SaveDriverImage(UcDriverTruckSecond.UCGetNSS().NSSDriver, UcDriverImagePnlRegister.UCGetImage)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تصویر راننده باری ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اثر انگشت راننده ثبت نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده دوم مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As DriverImageCaptureException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDeleteFPsDriverTruckFirst_UCClickedEvent() Handles UcButtonDeleteFPsDriverTruckFirst.UCClickedEvent
        Try
            PayanehClassLibraryMClassDriverTruckSalonPresentManagement.DeleteDriverTruckFPs(UcDriverTruckFirst.UCGetNSS())
            R2CoreParkingSystemMClassDrivers.DeleteDriverImage(UcDriverTruckFirst.UCGetNSS().NSSDriver)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اثرانگشت راننده باری حذف شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده اول مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDeleteFPsDriverTrucksecond_UCClickedEvent() Handles UcButtonDeleteFPsDriverTruckSecond.UCClickedEvent
        Try
            PayanehClassLibraryMClassDriverTruckSalonPresentManagement.DeleteDriverTruckFPs(UcDriverTruckSecond.UCGetNSS())
            R2CoreParkingSystemMClassDrivers.DeleteDriverImage(UcDriverTruckSecond.UCGetNSS().NSSDriver)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "اثرانگشت راننده باری حذف شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As GetNSSException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده دوم مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده مشخص نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcTraficCard_UCViewTrafficCardCompeleted(NSS As R2CoreParkingSystemStandardTrafficCardStructure) Handles UcTrafficCard.UCViewTrafficCardCompeleted
        Try
            Dim nIdCar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(NSS.CardId)
            UcCarTruck.UCViewCarInformation(nIdCar)
        Catch exx As GetDataException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات پایه کارت تردد و خودرو و روابط آن ها تکمیل نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اطلاعات پایه کارت تردد و خودرو و روابط آن ها تکمیل نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCarTruck_UCViewCarTruckInformationCompleted(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompleted
        'راننده اول
        Try
            UcDriverTruckFirst.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
        Catch exx As Exception When TypeOf exx Is GetNSSException OrElse TypeOf exx Is GetDataException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات راننده اول مشخص نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            Exit Sub
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            Exit Sub
        End Try

        Try
            UcDriverImageFirst.UCViewDriverImage(PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId)).NSSDriver)
            UcButtonSaveFPsDriverTruckFirst.UCEnable = False
            UcButtonSavePictureDriverTruckFirst.UCEnable = True
            UcButtonDeleteFPsDriverTruckFirst.UCEnable = True
        Catch exx As DriverImageNotExistException
            UcButtonSaveFPsDriverTruckFirst.UCEnable = True
            UcButtonSavePictureDriverTruckFirst.UCEnable = True
            UcButtonDeleteFPsDriverTruckFirst.UCEnable = False
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            Exit Sub
        End Try

        'راننده دوم
        Try
            UcDriverTruckSecond.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonSecond(CarId))
        Catch exx As Exception When TypeOf exx Is GetNSSException OrElse TypeOf exx Is GetDataException
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Warn, "اثر انگشت رانند ه باری" + vbCrLf + "اطلاعات پایه راننده دوم تکمیل نیست", _NSSTerafficCard.CardNo, 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            Exit Sub
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            Exit Sub
        End Try

        Try
            UcDriverImageSecond.UCViewDriverImage(PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(R2CoreParkingSystemMClassCars.GetnIdPersonSecond(CarId)).NSSDriver)
            UcButtonSaveFPsDriverTruckSecond.UCEnable = False
            UcButtonSavePictureDriverTruckSecond.UCEnable = True
            UcButtonDeleteFPsDriverTruckSecond.UCEnable = True
        Catch exx As DriverImageNotExistException
            UcButtonSaveFPsDriverTruckSecond.UCEnable = True
            UcButtonSavePictureDriverTruckSecond.UCEnable = True
            UcButtonDeleteFPsDriverTruckSecond.UCEnable = False
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmcDriverTruckFingerPrintRegister__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            FrmRefresh()
            Cursor.Current = Cursors.WaitCursor
            _NSSTerafficCard = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            UcTrafficCard.UCShowTrafficCard(_NSSTerafficCard)
            UcFingerPrintCapturerDermalog.UCStartCapturing()
        Catch exx As GetNSSException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کارت تردد قابل شناسایی نیست", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub FrmcDriverTruckFingerPrintRegister__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent

    End Sub

    Private Sub FrmcDriverTruckFingerPrintRegister__UCDisposeRequest() Handles Me._UCDisposeRequest

    End Sub

    Private Sub UcFingerPrintCapturerDermalog_UCDetectError(ErrorMessage As String) Handles UcFingerPrintCapturerDermalog.UCDetectError
        Try
            'بررسی شود بخاطر صدیقی غیرفعال شده است 
            'FrmcViewLocalMessage(ErrorMessage)
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