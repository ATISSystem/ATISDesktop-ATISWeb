
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.SoftwareUserManagement

Public Class UCSoftwareUserManipulation
    Inherits UCSoftwareUser

    Public Event UCSoftwareUserRegisteredEditedEvent(NSS As R2CoreStandardSoftwareUserStructure)
    Public Event UCSoftwareUserDeletedEvent(NSS As R2CoreStandardSoftwareUserStructure)


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
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcPersianTextBoxSearchUserName.UCRefreshGeneral()
            UcPersianTextBoxSearchMobileNumber.UCRefreshGeneral()
            UcNumberUserId.UCRefreshGeneral()
            UcPersianTextBoxUserName.UCRefreshGeneral()
            UcPersianTextBoxMobileNumber.UCRefreshGeneral()
            UcTextBoxUserPinCode.UCRefreshGeneral()
            UcPersianTextBoxShamsiDate.UCRefreshGeneral()
            ChkDeleted.Checked = False
            ChkUserActive.Checked = False
            ChkUserCanChargeMoneywallet.Checked = False
            ChkUserStatus.Checked = False
            ChkViewFlag.Checked = False
            UcPersianShamsiDateAPIKeyExpiration.UCRefreshGeneral()
            UcPersianShamsiDateUserPasswordExpiration.UCRefreshGeneral()
            UcPersianTextBoxUserCreator.UCRefreshGeneral()
            CButtonUserShenasehPasswordSMS.Enabled = True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UCSoftwareUserManipulation_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        UcPersianTextBoxSearchUserName.UCFocus()
    End Sub

    Private Sub UCSoftwareUserManipulation_UCViewNSSRequested(NSSCurrent As R2CoreStandardSoftwareUserStructure) Handles Me.UCViewNSSRequested
        Try
            Dim InstanceSoftwareUsers = New R2CoreInstanseSoftwareUsersManager
            UCRefresh()
            UcPersianTextBoxSearchUserName.UCValue = NSSCurrent.UserName
            UcPersianTextBoxMobileNumber.UCValue = NSSCurrent.MobileNumber
            UcNumberUserId.UCValue = NSSCurrent.UserId
            'UcSearcherUserTypes.UCViewNSS(InstanceSoftwareUsers.)


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
