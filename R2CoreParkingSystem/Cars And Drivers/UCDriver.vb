
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports R2Core.ConfigurationManagement
Imports R2Core.EntityRelationManagement
Imports R2Core.EntityRelationManagement.Exceptions
Imports R2Core.ExceptionManagement
Imports R2Core.SMSSendAndRecieved
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.SoftwareUsersManagement

Public Class UCDriver
    Inherits UCGeneral


    Public Event UCViewDriverInformationCompleted(DriverId As String)
    Public Event UCRefreshedEvent()
    Public Event UCRefreshedGeneralEvent()
    'Public Event UCDriverInfByNationalCodeRequestedEvent(NationalCode As String)




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
                CButtonSendSmsLast5Digit.Visible = True
                CButtonSoftwareUserVerificationCodeInjection.Visible = True
            Else
                UcButtonDel.Visible = False
                UcButtonNew.Visible = False
                UcButtonSabt.Visible = False
                CButtonSendSmsLast5Digit.Visible = False
                CButtonSoftwareUserVerificationCodeInjection.Visible = False
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
        UcPersianTextBoxNameFamily.UCRefresh()
        UcPersianTextBoxFather.UCRefresh() : UcPersianTextBoxTel.UCRefresh() : UcPersianTextBoxAddress.UCRefresh()
        UcNumberDrivernIdPerson.UCRefresh() : UcTextBoxNationalCode.UCRefresh() : UcNumberLicenseNo.UCRefresh()
        UcPersianTextBoxDriverName.Focus()
        CButtonSendSmsLast5Digit.Enabled = True
        CButtonSoftwareUserVerificationCodeInjection.Enabled = True
        RaiseEvent UCRefreshedEvent()
    End Sub

    Public Sub UCRefreshGeneral()
        UCRefresh()
        UcPersianTextBoxDriverName.UCRefresh()
        UcNumberDriverNationalCode.UCRefresh()
        RaiseEvent UCRefreshedGeneralEvent()
    End Sub

    Public Sub UCViewDriverInformation(YournIdPerson As String)
        Try
            Dim myNSS As R2StandardDriverStructure = R2CoreParkingSystemMClassDrivers.GetNSSDriver(YournIdPerson)
            UCRefresh()
            UcNumberDrivernIdPerson.UCValue = myNSS.nIdPerson
            UcPersianTextBoxDriverName.UCValue = myNSS.StrPersonFullName
            UcNumberDriverNationalCode.UCValue = IIf(IsNumeric(myNSS.StrNationalCode) = True, myNSS.StrNationalCode, 0)
            UcPersianTextBoxNameFamily.UCValue = myNSS.StrPersonFullName
            UcPersianTextBoxFather.UCValue = myNSS.StrFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(myNSS.StrNationalCode) = True, myNSS.StrNationalCode, 0)
            UcPersianTextBoxTel.UCValue = myNSS.StrIdNo
            UcNumberLicenseNo.UCValue = IIf(IsNumeric(myNSS.strDrivingLicenceNo) = True, myNSS.strDrivingLicenceNo, 0)
            UcPersianTextBoxAddress.UCValue = myNSS.StrAddress
            RaiseEvent UCViewDriverInformationCompleted(myNSS.nIdPerson)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewDriverInformation(YourNSS As R2StandardDriverStructure)
        Try
            UCRefresh()
            UcNumberDrivernIdPerson.UCValue = YourNSS.nIdPerson
            UcPersianTextBoxDriverName.UCValue = YourNSS.StrPersonFullName
            UcNumberDriverNationalCode.UCValue = IIf(IsNumeric(YourNSS.StrNationalCode) = True, YourNSS.StrNationalCode, 0)
            UcPersianTextBoxNameFamily.UCValue = YourNSS.StrPersonFullName
            UcPersianTextBoxFather.UCValue = YourNSS.StrFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(YourNSS.StrNationalCode) = True, YourNSS.StrNationalCode, 0)
            UcPersianTextBoxTel.UCValue = YourNSS.StrIdNo
            UcNumberLicenseNo.UCValue = IIf(IsNumeric(YourNSS.strDrivingLicenceNo) = True, YourNSS.strDrivingLicenceNo, 0)
            UcPersianTextBoxAddress.UCValue = YourNSS.StrAddress
            RaiseEvent UCViewDriverInformationCompleted(YourNSS.nIdPerson)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewDriverInformationDirty(YourNSS As R2StandardDriverStructure)
        Try
            UcPersianTextBoxNameFamily.UCValue = YourNSS.StrPersonFullName
            UcPersianTextBoxFather.UCValue = YourNSS.StrFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(YourNSS.StrNationalCode) = True, YourNSS.StrNationalCode, 0)
            UcNumberLicenseNo.UCValue = IIf(IsNumeric(YourNSS.strDrivingLicenceNo) = True, YourNSS.strDrivingLicenceNo, 0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSabtRoutin()
        Try
            'بررسی پارامترها
            If UcPersianTextBoxNameFamily.UCValue = "" Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "نام ونام خانوادگی راننده را وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcTextBoxNationalCode.UCValue.ToString.Length <> 10 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کد ملی نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcNumberLicenseNo.UCValue.ToString().Length <> 10 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "شماره گواهینامه نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcPersianTextBoxTel.UCValue.Trim = String.Empty Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "ورود شماره موبایل الزامی است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcNumberDrivernIdPerson.UCValue = 0 Then
                If R2CoreParkingSystemMClassDrivers.ExistDriver(New R2CoreParkingSystemDriverNationalCode(UcTextBoxNationalCode.UCValue)) Then
                    UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "راننده با کد ملی وارد شده قبلا ثبت شده است" + vbCrLf + "کد ملی راننده را برای جستجو وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                    Exit Sub
                End If
                UcNumberDrivernIdPerson.UCValue = R2CoreParkingSystemMClassDrivers.InsertDriver(New R2StandardDriverStructure("", UcPersianTextBoxNameFamily.UCValue, UcTextBoxNationalCode.UCValue, UcPersianTextBoxFather.UCValue, UcPersianTextBoxAddress.UCValue, UcPersianTextBoxTel.UCValue, UcNumberLicenseNo.UCValue), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات راننده ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                R2CoreParkingSystemMClassDrivers.UpdateDriver(New R2StandardDriverStructure(UcNumberDrivernIdPerson.UCValue, UcPersianTextBoxNameFamily.UCValue, UcTextBoxNationalCode.UCValue, UcPersianTextBoxFather.UCValue, UcPersianTextBoxAddress.UCValue, UcPersianTextBoxTel.UCValue, UcNumberLicenseNo.UCValue), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات راننده ویرایش شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDelRoutin()
        Try
            If UcNumberDrivernIdPerson.UCValue <> "" Then
                R2CoreParkingSystemMClassDrivers.DeleteDriver(New R2StandardDriverStructure(UcNumberDrivernIdPerson.UCValue, UcPersianTextBoxDriverName.UCValue, UcTextBoxNationalCode.UCValue, UcPersianTextBoxFather.UCValue, UcPersianTextBoxAddress.UCValue, UcPersianTextBoxTel.UCValue, UcNumberLicenseNo.UCValue))
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewFrmDrivers(YourSearchStr As String, YourViewType As FrmcDrivers.ViewType, YourObjectSearcher As Control)
        Try
            Dim Frm As FrmcDrivers = New FrmcDrivers
            'Dim P As Point = YourObjectSearcher.PointToScreen(New Point(0, 0))
            'Frm.Location =New Point(P.X-Frm.Width/2,P.Y)
            Frm.ViewDrivers(YourSearchStr, YourViewType)
            Frm.ShowDialog()
            Dim SelectedDriverId As String = Frm.GetSelectedDriverId
            If SelectedDriverId <> "" Then UCViewDriverInformation(R2CoreParkingSystemMClassDrivers.GetNSSDriver(SelectedDriverId))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2StandardDriverStructure
        Try
            If UcNumberDrivernIdPerson.UCValue <> 0 Then
                Return R2CoreParkingSystemMClassDrivers.GetNSSDriver(UcNumberDrivernIdPerson.UCValue)
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

    Private Sub UcNumberDriverNationalCode_UC13Pressed(UserNumber As String) Handles UcNumberDriverNationalCode.UC13Pressed
        Try
            UCRefresh()
            'RaiseEvent UCDriverInfByNationalCodeRequestedEvent(UserNumber)
            UCViewFrmDrivers(UcNumberDriverNationalCode.UCValue, FrmcDrivers.ViewType.ByNationalCode, UcNumberDriverNationalCode)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxDriverName_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxDriverName.UC13PressedEvent
        Try
            UCRefresh()
            UCViewFrmDrivers(UcPersianTextBoxDriverName.UCValue, FrmcDrivers.ViewType.ByNameFamily, UcPersianTextBoxDriverName)
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

    Private Sub UcPersianTextBoxNameFamily_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxNameFamily.UC13PressedEvent
        UcPersianTextBoxFather.Focus()
    End Sub

    Private Sub UcPersianTextBoxFather_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxFather.UC13PressedEvent
        UcTextBoxNationalCode.Focus()
    End Sub

    Private Sub UcTextBoxNationalCode_UC13PressedEvent(CurrentText As String) Handles UcTextBoxNationalCode.UC13PressedEvent
        UcPersianTextBoxTel.Focus()
    End Sub

    Private Sub UcPersianTextBoxTel_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxTel.UC13PressedEvent
        UcPersianTextBoxAddress.Focus()
    End Sub

    Private Sub UcPersianTextBoxAddress_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxAddress.UC13PressedEvent
        UcNumberLicenseNo.Focus()
    End Sub

    Private Sub UcNumberLicenseNo_UC13Pressed(UserNumber As String) Handles UcNumberLicenseNo.UC13Pressed
        UcButtonSabt.Focus()
    End Sub

    Private Sub UcButtonSabt_UC13PressedEvent() Handles UcButtonSabt.UC13PressedEvent
        Try
            UCSabtRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonSendSmsLast5Digit_Click(sender As Object, e As EventArgs) Handles CButtonSendSmsLast5Digit.Click
        Dim InstanceSoftwareUser = New R2CoreParkingSystemInstanceSoftwareUsersManager
        Try
            'CButtonSendSmsLast5Digit.Enabled=False
            Dim NSSSoftwareUser = InstanceSoftwareUser.GetNSSSoftwareUser(UCGetNSS.nIdPerson)
            MessageBox.Show("شناسه شخصی:" + NSSSoftwareUser.UserShenaseh + vbCrLf + "رمز شخصی:" + NSSSoftwareUser.UserPassword)
            'Dim SMSSender As New R2CoreSMSSendRecive
            'Dim SMSMessage = "شناسه شخصی:" + NSSSoftwareUser.UserShenaseh + vbCrLf + "رمز شخصی:" + NSSSoftwareUser.UserPassword
            'SMSSender.SendSms(New R2CoreSMSStandardSmsStructure(Nothing, NSSSoftwareUser.MobileNumber, SMSMessage, 1, Nothing, 1, Nothing, Nothing))
            'UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "رمز شخصی ارسال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات مورد نیاز را به صورت کامل وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonSoftwareUserVerificationCodeInjection_Click(sender As Object, e As EventArgs) Handles CButtonSoftwareUserVerificationCodeInjection.Click
        Try
            Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
            Dim InstanceR2CoreParkingSystemSoftwareUser = New R2CoreParkingSystemInstanceSoftwareUsersManager
            Dim NSSSoftwareUser = InstanceR2CoreParkingSystemSoftwareUser.GetNSSSoftwareUser(UCGetNSS.nIdPerson)
            Dim InstanceR2CoreSoftwareUser = New R2CoreInstanseSoftwareUsersManager
            InstanceR2CoreSoftwareUser.SoftwareUserVerificationCodeInjection(NSSSoftwareUser)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تزریق کد فعال سازی با موفقیت انجام شد" + vbCrLf + "InjectedVerificationCode=" + InstanceConfiguration.GetConfigString(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 12), "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            CButtonSoftwareUserVerificationCodeInjection.Enabled = False
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات مورد نیاز را به صورت کامل وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
