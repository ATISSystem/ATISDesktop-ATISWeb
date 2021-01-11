
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms


Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.CarType
Imports R2CoreParkingSystem.City


Public Class UCCar
    Inherits UCGeneral

    Public Event UCViewCarInformationCompleted(CarId As String)
    Public Event UCRefreshedEvent()
    Public Event UCRefreshedGeneralEvent()

#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonDel.Visible = True
                UcButtonNew.Visible = True
                UcButtonSabt.Visible = True
            Else
                UcButtonDel.Visible = False
                UcButtonNew.Visible = False
                UcButtonSabt.Visible = False
            End If
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRefresh()
        UcPersianTextBoxStrCarNo.UCRefresh() : UcPersianTextBoxStrCarSerialNo.UCRefresh() 
        UcNumbernIdCar.UCRefresh() : UcCmbCity.UCRefresh() : UcCmbCarType.UCRefresh()
        UcPersianTextBoxStrCarNo.Focus()
        RaiseEvent UCRefreshedEvent()
    End Sub

    Public Sub UCRefreshGeneral()
        UCRefresh()
        UcNumbernIdCar.UCRefresh()
        RaiseEvent UCRefreshedGeneralEvent()
    End Sub



    Public Sub UCViewCarInformation(YournIdCar As String)
        Try
            Dim myNSS As R2StandardCarStructure = R2CoreParkingSystemMClassCars.GetNSSCar(YournIdCar)
            UCRefresh()
            UcNumbernIdCar.UCValue = myNSS.nIdCar
            UcPersianTextBoxCarNo.UCValue = myNSS.StrCarNo
            UcPersianTextBoxStrCarNo.UCValue = myNSS.StrCarNo
            UcPersianTextBoxStrCarSerialNo.UCValue = myNSS.StrCarSerialNo
            UcCmbCity.UCSetCityName(myNSS.nIdCity)
            UcCmbCarType.UCSetCarTypeName(myNSS.snCarType)
            RaiseEvent UCViewCarInformationCompleted(myNSS.nIdCar)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarInformation(YourNSS As R2StandardCarStructure)
        Try
            UCRefresh()
            UcNumbernIdCar.UCValue = YourNSS.nIdCar
            UcPersianTextBoxCarNo.UCValue = YourNSS.StrCarNo
            UcPersianTextBoxStrCarNo.UCValue = YourNSS.StrCarNo
            UcPersianTextBoxStrCarSerialNo.UCValue = YourNSS.StrCarSerialNo
            UcCmbCity.UCSetCityName(YourNSS.nIdCity)
            UcCmbCarType.UCSetCarTypeName(YourNSS.snCarType)
            RaiseEvent UCViewCarInformationCompleted(YourNSS.nIdCar)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarInformationDirty(YourNSS As R2StandardCarStructure)
        Try
            UCRefresh()
            UcPersianTextBoxStrCarNo.UCValue = YourNSS.StrCarNo
            UcPersianTextBoxStrCarSerialNo.UCValue = YourNSS.StrCarSerialNo
            UcCmbCity.UCSetCityName(YourNSS.nIdCity)
            UcCmbCarType.UCSetCarTypeName(YourNSS.snCarType)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSabtRoutin()
        Try
            'بررسی پارامترها
            'if UcPersianTextBoxCarNo.UCValue.Length <>6 then
            '    _FrmMessageDialog.ViewDialogMessage("پلاک خودرو نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            '    Exit Sub
            'End If
            If UcPersianTextBoxStrCarNo.UCValue = "" Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "پلاک خودرو را وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcPersianTextBoxStrCarSerialNo.UCValue = "" Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "سریال پلاک را وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcNumbernIdCar.UCValue = 0 Then
                Dim NSSCar As R2StandardCarStructure = New R2StandardCarStructure("", R2CoreParkingSystemMClassCarType.GetsnCarTypeFromStrCarName(UcCmbCarType.UCGetCurrentCarType()), UcPersianTextBoxStrCarNo.UCValue, UcPersianTextBoxStrCarSerialNo.UCValue, R2CoreParkingSystemMClassCitys.GetnCityCodeFromStrCityName(UcCmbCity.UCGetCurrentCityCode()))
                If R2CoreParkingSystemMClassCars.IsExistCar(NSSCar) Then Throw New DuplicateCarExistException
                UcNumbernIdCar.UCValue = R2CoreParkingSystemMClassCars.InsertCar(NSSCar, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات خودرو ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                R2CoreParkingSystemMClassCars.UpdateCar(New R2StandardCarStructure(UcNumbernIdCar.UCValue, R2CoreParkingSystemMClassCarType.GetsnCarTypeFromStrCarName(UcCmbCarType.UCGetCurrentCarType()), UcPersianTextBoxStrCarNo.UCValue, UcPersianTextBoxStrCarSerialNo.UCValue, R2CoreParkingSystemMClassCitys.GetnCityCodeFromStrCityName(UcCmbCity.UCGetCurrentCityCode())))
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات خودرو ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As DuplicateCarExistException
            Throw ex
        Catch ex As DataEntryException
            Throw ex
        Catch ex As GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDelRoutin()
        Try
            If UcNumbernIdCar.UCValue <> 0 Then
                R2CoreParkingSystemMClassCars.DeleteCar(New R2StandardCarStructure(UcNumbernIdCar.UCValue, UcCmbCarType.UCGetCurrentCarType(), UcPersianTextBoxStrCarNo.UCValue, UcPersianTextBoxStrCarSerialNo.UCValue, UcCmbCity.UCGetCurrentCityCode()))
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف خودرو انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewFrmCars(YourSearchStr As String, YourObjectSearcher As Control)
        Try
            Dim Frm As FrmcCars = New FrmcCars
            'Dim P As Point = YourObjectSearcher.PointToScreen(New Point(0, 0))
            'Frm.Location = P
            Frm.ViewCars(YourSearchStr)
            Frm.ShowDialog()
            Dim SelectedCarId As String = Frm.GetSelectedCarId()
            If SelectedCarId <> "" Then UCViewCarInformation(R2CoreParkingSystemMClassCars.GetNSSCar(SelectedCarId))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2StandardCarStructure
        Try
            If UcNumbernIdCar.UCValue <> 0 Then
                Return R2CoreParkingSystemMClassCars.GetNSSCar(UcNumbernIdCar.UCValue)
            Else
                Throw New GetNSSException
            End If
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianTextBoxCarNo_UCMaxCharacterReachedEvent() Handles UcPersianTextBoxCarNo.UCMaxCharacterReachedEvent
    End Sub

    Private Sub UcPersianTextBoxCarNo_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxCarNo.UC13PressedEvent
        Try
            UCRefresh()
            UCViewFrmCars(UcPersianTextBoxCarNo.UCValue, UcPersianTextBoxCarNo)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonNew_UCClickedEvent() Handles UcButtonNew.UCClickedEvent
        UCRefresh()
    End Sub

    Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        Try
            UCSabtRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDel_UCClickedEvent() Handles UcButtonDel.UCClickedEvent
        Try
            UCDelRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxStrCarSerialNo_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxStrCarSerialNo.UC13PressedEvent
        UcCmbCarType.Focus()
    End Sub

    Private Sub UcPersianTextBoxStrCarNo_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxStrCarNo.UC13PressedEvent
        Try
            UcPersianTextBoxStrCarSerialNo.Focus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCmbCarType_UC13PressedEvent() Handles UcCmbCarType.UC13PressedEvent
        UcButtonSabt.Focus()
    End Sub

    Private Sub UcButtonSabt_UC13PressedEvent() Handles UcButtonSabt.UC13PressedEvent
        Try
            UCSabtRoutin()
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
#End Region


End Class
