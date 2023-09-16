

Imports System.Drawing
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.ExceptionManagement
Imports R2Core.MoneyWallet.Exceptions
Imports R2Core.PermissionManagement
Imports R2Core.SMS.Exceptions
Imports R2Core.SMS.SMSOwners
Imports R2Core.SMS.SMSOwners.Exceptions
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.SMS
Imports R2CoreParkingSystem.SMS.SMSOwners

Public Class UCActivateUnActivateSMSOwner
    Inherits UCGeneral


#Region "General Properties"

    Private _UCNSSCurrent As R2CoreStandardSoftwareUserStructure = Nothing
    Public Property UCNSSCurrent As R2CoreStandardSoftwareUserStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreStandardSoftwareUserStructure)
            Try
                If value Is Nothing Then Exit Property
                _UCNSSCurrent = value
                UCRefreshInformation()
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub UCRefreshInformation()
        Try
            Dim InstanceSMSOwners = New R2CoreMClassSMSOwnersManager
            Dim SMSOwnerCurrentState = InstanceSMSOwners.GetNSSSMSOwnerCurrentState(UCNSSCurrent)
            CButtonActivateUnActivateSMSOwner.ColorFillSolid = Color.FromName(SMSOwnerCurrentState.TextToViewColor)
            CButtonActivateUnActivateSMSOwner.Text = SMSOwnerCurrentState.TextToView
            CButtonActivateUnActivateSMSOwner.Enabled = True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CButtonActivateUnActivateSMSOwner_Click(sender As Object, e As EventArgs) Handles CButtonActivateUnActivateSMSOwner.Click
        Try
            CButtonActivateUnActivateSMSOwner.Enabled = False
            Dim InstanceSMSOwners = New R2CoreParkingSystemMClassSMSOwnersManager
            InstanceSMSOwners.ChangeSMSOwnerCurrentState(UCNSSCurrent, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "درخواست فعال سازی یا غیرفعال سازی ارسال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            UCRefreshInformation()
        Catch ex As SMSOwnerForSoftwareUserDoNotRegisteredException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As MoneyWalletCurrentChargeNotEnoughException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As SoftwareUserMoneyWalletNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As SMSOwnerTypeBySoftwareUserNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As SMSOwnerHasCreditYetException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As UserNotAllowedRunThisProccessException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        CButtonActivateUnActivateSMSOwner.Enabled = True
    End Sub

    Private Sub PicRefresh_Click(sender As Object, e As EventArgs) Handles PicRefresh.Click
        Try
            UCRefreshInformation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
