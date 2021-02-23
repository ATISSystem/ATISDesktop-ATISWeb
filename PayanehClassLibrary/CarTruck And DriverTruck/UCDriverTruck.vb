
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Drivers
Imports PayanehClassLibrary.DriverTrucksManagement
Imports R2Core.NetworkInternetManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.Rmto
Imports R2Core.SoftwareUserManagement
Imports R2Core.EntityRelationManagement
Imports R2CoreTransportationAndLoadNotification.SoftwareUserManagement
Imports R2CoreTransportationAndLoadNotification.EntityRelations
Imports R2Core.EntityRelationManagement.Exceptions
Imports R2Core.ConfigurationManagement
Imports R2Core.PermissionManagement
Imports PayanehClassLibrary.DriverTrucksManagement.Exceptions

Public Class UCDriverTruck
    Inherits UCGeneral

    Public Event UCViewDriverTruckInformationCompleted(DriverId As String)
    Public Event UCRefreshedGeneralEvent()
    Private _CurrentNSS As R2StandardDriverTruckStructure = Nothing


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
                UcDriver.UCViewButtons = True
            Else
                UcButtonNew.Visible = False
                UcButtonSabt.Visible = False
                UcDriver.UCViewButtons = False
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
        Try
            UcDriver.UCRefreshGeneral()
            UcNumberStrSmartCardNo.UCRefresh()
            _CurrentNSS = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshGeneral()
        Try
            UCRefresh()
            UcNumberStrSmartCardNoSearch.UCRefresh()
            RaiseEvent UCRefreshedGeneralEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewDriverInformation(YournIdPerson As String)
        Try
            UCRefresh()
            UcDriver.UCViewDriverInformation(YournIdPerson)
            _CurrentNSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(YournIdPerson)
            UcNumberStrSmartCardNo.UCValue = _CurrentNSS.StrSmartCardNo
            RaiseEvent UCViewDriverTruckInformationCompleted(_CurrentNSS.NSSDriver.nIdPerson)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewDriverInformation(YourNSS As R2StandardDriverTruckStructure)
        Try
            UCRefresh()
            _CurrentNSS = YourNSS
            UcDriver.UCViewDriverInformation(YourNSS.NSSDriver)
            UcNumberStrSmartCardNo.UCValue = YourNSS.StrSmartCardNo
            RaiseEvent UCViewDriverTruckInformationCompleted(YourNSS.NSSDriver.nIdPerson)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSabtRoutin()
        Try
            'بررسی پارامترها
            If UcNumberStrSmartCardNo.UCValue.ToString().Length <> 7 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "شماره هوشمند نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            Dim NSSDriver As R2StandardDriverStructure = UcDriver.UCGetNSS()
            PayanehClassLibraryMClassDriverTrucksManagement.UpdateDriverTruck(New R2StandardDriverTruckStructure(NSSDriver, UcNumberStrSmartCardNo.UCValue))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات راننده ناوگان باری ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As DriverTruckSmartCardNoAlreadyAvailabletException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2StandardDriverTruckStructure
        Try
            Dim myNSS As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(UcDriver.UCGetNSS().nIdPerson)
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

    Private Sub UcDriver_UCViewDriverInformationCompleted(DriverId As String) Handles UcDriver.UCViewDriverInformationCompleted
        Try
            _CurrentNSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbyDriverId(DriverId)
            UcNumberStrSmartCardNo.UCValue = _CurrentNSS.StrSmartCardNo
            RaiseEvent UCViewDriverTruckInformationCompleted(DriverId)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumberStrSmartCardNoSearch_UC13Pressed(UserNumber As String) Handles UcNumberStrSmartCardNoSearch.UC13Pressed
        Try
            Try
                UcDriver.UCRefreshGeneral()
                _CurrentNSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(UserNumber)
                UcDriver.UCViewDriverInformation(_CurrentNSS.NSSDriver)
            Catch ex As DriverTruckInformationNotExistException
                If MessageBox.Show(Nothing, "اطلاعات راننده در سیستم قبلا ثبت نشده است" + vbCrLf + "اطلاعات مورد نظر را از سرویس اینترنتی دریافت میکنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.Yes Then
                    Try
                        _CurrentNSS = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSTruckDriver(RmtoWebService.GetNSSTruckDriver(UserNumber))
                        UcDriver.UCViewDriverInformationDirty(_CurrentNSS.NSSDriver)
                        UcNumberStrSmartCardNo.UCValue = _CurrentNSS.StrSmartCardNo
                    Catch exx As Exception When TypeOf exx Is InternetIsnotAvailableException OrElse TypeOf exx Is RMTOWebServiceSmartCardInvalidException
                        UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                    End Try
                Else
                End If
            End Try
        Catch ex As InternetIsnotAvailableException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As ConnectionIsNotAvailableException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSabt_UC13PressedEvent() Handles UcButtonSabt.UC13PressedEvent
        Try
            UCSabtRoutin()
        Catch ex As DriverTruckSmartCardNoAlreadyAvailabletException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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

    Private Sub UcDriver_UCRefreshedEvent() Handles UcDriver.UCRefreshedEvent
        Try
            UcNumberStrSmartCardNo.UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        Try
            UCSabtRoutin()
        Catch ex As DriverTruckSmartCardNoAlreadyAvailabletException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumberStrSmartCardNo_UC13Pressed(UserNumber As String) Handles UcNumberStrSmartCardNo.UC13Pressed
        UcButtonSabt.Focus()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
