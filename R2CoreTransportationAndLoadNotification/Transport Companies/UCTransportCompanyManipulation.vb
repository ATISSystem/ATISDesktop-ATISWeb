
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing

Imports R2CoreTransportationAndLoadNotification.TransportCompanies
Imports R2Core.BaseStandardClass
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.SoftwareUserManagement
Imports R2Core.SMSSendAndRecieved
Imports R2Core.ExceptionManagement
Imports R2CoreParkingSystem.City
Imports R2Core.SoftwareUserManagement
Imports R2CoreTransportationAndLoadNotification.SoftwareUserManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.TerraficCardsManagement
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2Core.ConfigurationManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreTransportationAndLoadNotification.TerraficCardsManagement.Exceptions
Imports R2Core.PermissionManagement

Public Class UCTransportCompanyManipulation
    Inherits UCTransportCompany


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcNumberTCId.UCRefresh()
            UcPersianTextBoxTCTitle.UCRefresh()
            UcPersianTextBoxTCOrganizationCode.UCRefresh()
            UcPersianTextBoxTCTel.UCRefresh()
            UcPersianTextBoxManagerNameFamily.UCRefresh()
            UcPersianTextBoxManagerMobileNumber.UCRefresh()
            ChkActive.Checked = True
            ChkViewFlag.Checked = True
            UcSearcherTransportCompanies.UCRefreshGeneral()
            UcSearcherCities.UCRefreshGeneral()
            CButtonSendSMSUserPassword.Enabled = True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcSearcherTransportCompanies_UC13PressedEvent() Handles UcSearcherTransportCompanies.UC13PressedEvent
        UcPersianTextBoxTCTitle.UCFocus()
    End Sub

    Private Sub UcSearcherTransportCompanies_UCItemSelectedEvent(SelectedItem As R2StandardStructure) Handles UcSearcherTransportCompanies.UCItemSelectedEvent
        Try
            UCViewNSS(SelectedItem.OCode)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonRegister_Click(sender As Object, e As EventArgs) Handles CButtonRegister.Click
        Try
            Dim InstanceTransportCompanies = New R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager
            If UCNSSCurrent IsNot Nothing Then Return
            UcNumberTCId.UCValue = R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.RegisteringTransportCompany(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(0, UcPersianTextBoxTCTitle.UCValue, UcPersianTextBoxTCOrganizationCode.UCValue, UcSearcherCities.UCGetSelectedNSS.OCode, Nothing, UcPersianTextBoxTCTel.UCValue, UcPersianTextBoxManagerNameFamily.UCValue, UcPersianTextBoxManagerMobileNumber.UCValue, ChkViewFlag.Checked, ChkActive.Checked, 0), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewNSS(InstanceTransportCompanies.GetNSSTransportCompany(UcNumberTCId.UCValue))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت اطلاعات شرکت حمل و نقل با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As DataEntryException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonEdit_Click(sender As Object, e As EventArgs) Handles CButtonEdit.Click
        Try
            Dim InstanceTransportCompanies = New R2CoreTransportationAndLoadNotificationInstanceTransportCompaniesManager
            If UCNSSCurrent Is Nothing Then Return
            R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.UpdatingTransportCompany(New R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure(UCNSSCurrent.TCId, UcPersianTextBoxTCTitle.UCValue, UcPersianTextBoxTCOrganizationCode.UCValue, UcSearcherCities.UCGetSelectedNSS.OCode, Nothing, UcPersianTextBoxTCTel.UCValue, UcPersianTextBoxManagerNameFamily.UCValue, UcPersianTextBoxManagerMobileNumber.UCValue, ChkViewFlag.Checked, ChkActive.Checked, False), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewNSS(InstanceTransportCompanies.GetNSSTransportCompany(UcNumberTCId.UCValue))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ویرایش اطلاعات شرکت حمل و نقل با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As DataEntryException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonDelete_Click(sender As Object, e As EventArgs) Handles CButtonDelete.Click
        Try
            Dim Result = MessageBox.Show("آیا می خواهید اطلاعات شرکت حمل و نقل را حذف کنید؟", "", MessageBoxButtons.YesNo)
            If Result = DialogResult.No Then Exit Sub
            If UCNSSCurrent Is Nothing Then Return
            R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.DeletingTransportCompany(UcNumberTCId.UCValue)
            UCNSSCurrent = Nothing
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف اطلاعات شرکت حمل و نقل با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonNew_Click(sender As Object, e As EventArgs) Handles CButtonNew.Click
        Try
            UCRefreshGeneral()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonSendSMSUserPassword_Click(sender As Object, e As EventArgs) Handles CButtonSendSMSUserPassword.Click
        Try
            Dim InstancePermissions = New R2CoreInstansePermissionsManager
            If Not InstancePermissions.ExistPermission(R2CorePermissionTypes.UserCanSendSoftwareUserShenasehPasswordViaSMS, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, 0) Then Throw New UserNotAllowedRunThisProccessException
            Dim InstanceSoftwareUser = New R2CoreTransportationAndLoadNotificationInstanceSoftwareUsersManager
            Dim InstanceConfiguration = New R2CoreInstanceConfigurationManager
            If UCNSSCurrent Is Nothing Then Throw New GetNSSException
            CButtonSendSMSUserPassword.Enabled = False
            Dim NSSSoftwareUser = InstanceSoftwareUser.GetNSSSoftwareUser(UCNSSCurrent.TCId)
            'کسر هزینه از بابت اس ام اس
            Dim InstanceTerraficCards = New R2CoreTransportationAndLoadNotificationInstanceTerraficCardsManager
            Dim InstanceMoneyWallets = New R2CoreParkingSystemInstanceMoneyWalletManager
            Dim NSSTrafficCard = InstanceTerraficCards.GetNSSTerafficCard(UCNSSCurrent)
            If (InstanceConfiguration.GetConfigBoolean(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 10)) Then
                If Not NSSTrafficCard.NoMoney Then
                    Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
                    InstanceMoneyWallets.ActMoneyWalletNextStatus(NSSTrafficCard, BagPayType.MinusMoney, InstanceConfiguration.GetConfigInt64(R2CoreConfigurations.DefaultConfigurationOfSoftwareUserSecurity, 11), R2CoreParkingSystemAccountings.SoftwareUserShenasehPasswordSMSCost, InstanceSoftwareUsers.GetNSSSystemUser())
                End If
            End If
            Dim SMSSender As New R2CoreSMSSendRecive
            Dim SMSMessage = "سامانه آتیس وب" + vbCrLf + "ATISMobile.ir" + vbCrLf + "شناسه کاربر:" + NSSSoftwareUser.UserShenaseh + vbCrLf + "رمز عبور کاربر:" + NSSSoftwareUser.UserPassword
            SMSSender.SendSms(New R2CoreSMSStandardSmsStructure(Nothing, NSSSoftwareUser.MobileNumber, SMSMessage, 1, Nothing, True, Nothing, Nothing))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "شناسه و رمز عبور کاربر ارسال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As UserNotAllowedRunThisProccessException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As SoftwareUserMoneyWalletNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As SoftwareUserRelatedThisTransportCompanyNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات مورد نیاز را به صورت کامل وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub CButtonViewUserPassword_Click(sender As Object, e As EventArgs) Handles CButtonViewUserPassword.Click
        Try
            Dim InstancePermissions = New R2CoreInstansePermissionsManager
            If Not InstancePermissions.ExistPermission(R2CorePermissionTypes.UserCanViewAndPrintUserShenasehPassword, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, 0) Then Throw New UserNotAllowedRunThisProccessException
            If UCNSSCurrent Is Nothing Then Throw New GetNSSException
            Dim InstanceSoftwareUser = New R2CoreTransportationAndLoadNotificationInstanceSoftwareUsersManager
            Dim NSSSoftwareUser = InstanceSoftwareUser.GetNSSSoftwareUser(UCNSSCurrent.TCId)
            MessageBox.Show("شناسه کاربر:" + NSSSoftwareUser.UserShenaseh + vbCrLf + "رمز عبور کاربر:" + NSSSoftwareUser.UserPassword)
            PrintDocument.Print()
        Catch ex As UserNotAllowedRunThisProccessException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات مورد نیاز را به صورت کامل وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private WithEvents PrintDocument As PrintDocument = New PrintDocument
    Private Sub PrintDocument_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument.BeginPrint
    End Sub

    Private Sub PrintDocument_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument.EndPrint
        Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDocument_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
        Try
            Dim InstanceSoftwareUser = New R2CoreTransportationAndLoadNotificationInstanceSoftwareUsersManager
            Dim NSSSoftwareUser = InstanceSoftwareUser.GetNSSSoftwareUser(UCNSSCurrent.TCId)
            Dim myPaperSizeHalf As Integer = PrintDocument.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
            Dim myStrFont As Drawing.Font = New System.Drawing.Font("B Homa", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim myDigFont As Drawing.Font = New System.Drawing.Font("Alborz Titr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
            E.Graphics.DrawString(NSSSoftwareUser.UserName, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - NSSSoftwareUser.UserName.Trim.Length, Y)
            E.Graphics.DrawString("شناسه کاربر : " + NSSSoftwareUser.UserShenaseh, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - ("شناسه کاربر : " + NSSSoftwareUser.UserShenaseh).Trim.Length, Y + 30)
            E.Graphics.DrawString("رمز عبور کاربر : " + NSSSoftwareUser.UserPassword, myStrFont, Brushes.DarkBlue, myPaperSizeHalf - ("رمز عبور کاربر : " + NSSSoftwareUser.UserPassword.Trim).Length, Y + 60)
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

    Private Sub UCTransportCompanyManipulation_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure) Handles Me.UCViewNSSRequested
        Try
            UCRefresh()
            UcNumberTCId.UCValue = NSSCurrent.TCId
            UcPersianTextBoxTCTitle.UCValue = NSSCurrent.TCTitle.Trim
            UcPersianTextBoxTCOrganizationCode.UCValue = NSSCurrent.TCOrganizationCode.Trim
            UcPersianTextBoxTCTel.UCValue = NSSCurrent.TCTel.Trim
            ChkViewFlag.Checked = NSSCurrent.ViewFlag
            UcSearcherCities.UCViewNSS(R2CoreParkingSystemMClassCitys.GetNSSCity(NSSCurrent.TCCityId))
            UcPersianTextBoxManagerNameFamily.UCValue = NSSCurrent.TCManagerNameFamily.Trim
            UcPersianTextBoxManagerMobileNumber.UCValue = NSSCurrent.TCManagerMobileNumber.Trim
            ChkActive.Checked = NSSCurrent.Active
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCTransportCompanyManipulation_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
        Try
            UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCTransportCompanyManipulation_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        UcPersianTextBoxTCTitle.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxTCTitle_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxTCTitle.UC13PressedEvent
        UcSearcherCities.UCFocus()
    End Sub

    Private Sub UcSearcherCities_UCItemSelectedEvent(SelectedItem As R2StandardStructure) Handles UcSearcherCities.UCItemSelectedEvent
        UcPersianTextBoxTCTel.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxTCTel_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxTCTel.UC13PressedEvent
        UcPersianTextBoxTCOrganizationCode.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxTCOrganizationCode_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxTCOrganizationCode.UC13PressedEvent
        UcPersianTextBoxManagerNameFamily.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxManagerNameFamily_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxManagerNameFamily.UC13PressedEvent
        UcPersianTextBoxManagerMobileNumber.UCFocus()
    End Sub

    Private Sub UcPersianTextBoxManagerMobileNumber_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxManagerMobileNumber.UC13PressedEvent
        CButtonRegister.ShowFocus = CButtonLib.CButton.eFocus.Dot
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
