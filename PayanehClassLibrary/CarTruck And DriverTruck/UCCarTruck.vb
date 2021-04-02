
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports PayanehClassLibrary.CarTrucksManagement


Public Class UCCarTruck
    Inherits UCGeneral


    Public Event UCViewCarTruckInformationCompletedEvent(CarId As String)
    Public Event UCViewCarTruckInformationNotCompletedEvent()
    Public Event UCRefreshedGeneralEvent()
    Private _CurrentNSS As R2StandardCarTruckStructure = Nothing
    Private _WS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService()




#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonNew.Visible = True
                UcButtonSabt.Visible = True
                UcCar.UCViewButtons = True
            Else
                UcButtonNew.Visible = False
                UcButtonSabt.Visible = False
                UcCar.UCViewButtons = False
            End If
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UcNumberStrBodyNoSearch.UCAllowedMinNumber = 1000000
        UcNumberStrBodyNoSearch.UCAllowedMaxNumber = 9999999
    End Sub

    Private Sub UCRefresh()
        Try
            UcCar.UCRefreshGeneral()
            UcNumberStrBodyNo.UCRefresh()
            _CurrentNSS = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshGeneral()
        Try
            UCRefresh()
            UcNumberStrBodyNoSearch.UCRefresh()
            RaiseEvent UCRefreshedGeneralEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarInformation(YournIdCar As String)
        Try
            UCRefresh()
            UcCar.UCViewCarInformation(YournIdCar)
            _CurrentNSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(YournIdCar)
            UcNumberStrBodyNo.UCValue = _CurrentNSS.StrBodyNo
            RaiseEvent UCViewCarTruckInformationCompletedEvent(_CurrentNSS.NSSCar.nIdCar)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCarInformation(YourNSS As R2StandardCarTruckStructure)
        Try
            UCRefresh()
            _CurrentNSS = YourNSS
            UcCar.UCViewCarInformation(YourNSS.NSSCar)
            UcNumberStrBodyNo.UCValue = YourNSS.StrBodyNo
            RaiseEvent UCViewCarTruckInformationCompletedEvent(YourNSS.NSSCar.nIdCar)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSabtRoutin()
        Try
            'بررسی پارامترها
            If UcNumberStrBodyNo.UCValue.ToString().Length <> 7 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "شماره هوشمند نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            Dim NSSCar As R2StandardCarStructure = UcCar.UCGetNSS()
            PayanehClassLibraryMClassCarTrucksManagement.UpdateCarTruck(New R2StandardCarTruckStructure(NSSCar, UcNumberStrBodyNo.UCValue))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات خودروی باری ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As GetNSSException
            Throw New Exception("اطلاعات پایه خودرو را ثبت کنید")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2StandardCarTruckStructure
        Try
            Dim myNSS As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(UcCar.UCGetNSS().nIdCar)
            Return myNSS
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

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            _CurrentNSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(CarId)
            UcNumberStrBodyNo.UCValue = _CurrentNSS.StrBodyNo
            RaiseEvent UCViewCarTruckInformationCompletedEvent(CarId)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumberStrBodyNoSearch_UC13Pressed(UserNumber As String) Handles UcNumberStrBodyNoSearch.UC13Pressed
        Try
            UcCar.UCRefreshGeneral()
            Dim ExchangeKey = _WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword)
            Dim nIdCar = _WS.WebMethodGetnIdCarTruckBySmartCarNo(UserNumber, ExchangeKey)
            _CurrentNSS = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckByCarId(nIdCar)
            UcCar.UCViewCarInformation(_CurrentNSS.NSSCar)
        Catch ex As System.Web.Services.Protocols.SoapException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            RaiseEvent UCViewCarTruckInformationNotCompletedEvent()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            RaiseEvent UCViewCarTruckInformationNotCompletedEvent()
        End Try
    End Sub

    Private Sub UcButtonSabt_UC13PressedEvent() Handles UcButtonSabt.UC13PressedEvent
        Try
            UCSabtRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonNew_UCClickedEvent() Handles UcButtonNew.UCClickedEvent
        Try
            UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCar_UCRefreshedEvent() Handles UcCar.UCRefreshedEvent
        Try
            UcNumberStrBodyNo.UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        Try
            UCSabtRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumberStrBodyNo_UC13PressedEvent(CurrentText As String) Handles UcNumberStrBodyNo.UC13PressedEvent
        UcButtonSabt.Focus()
    End Sub

    Private Sub UCCarTruck_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        UcNumberStrBodyNoSearch.UCFocus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
