


Imports System.Reflection
Imports R2Core.ExceptionManagement
Imports R2Core.MoneyWallet.Exceptions
Imports R2Core.PermissionManagement
Imports R2Core.SMS.Exceptions
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.SMS

Public Class UCUnActivateSMSOwner
    Inherits UCGeneral

#Region "General Properties"

    Private _UCNSSCurrent As R2CoreStandardSoftwareUserStructure = Nothing
    Public Property UCNSSCurrent As R2CoreStandardSoftwareUserStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreStandardSoftwareUserStructure)
            _UCNSSCurrent = value
            If value IsNot Nothing Then CButtonUnActivateSMSOwner.Enabled = True
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CButtonUnActivateSMSOwner_Click(sender As Object, e As EventArgs) Handles CButtonUnActivateSMSOwner.Click
        Try
            CButtonUnActivateSMSOwner.Enabled = False
            Dim InstancePermissions = New R2CoreInstansePermissionsManager
            If Not InstancePermissions.ExistPermission(R2CorePermissionTypes.SoftwareUserCanActivateUnactivateSMSOwner, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, 0) Then Throw New UserNotAllowedRunThisProccessException
            Dim InstanceSMS = New R2Core.SMS.R2CoreMClassSMSManager
            InstanceSMS.UnactivateSMSOwner(UCNSSCurrent, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "سرویس اس ام اس کاربر غیر فعال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As UserNotAllowedRunThisProccessException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
