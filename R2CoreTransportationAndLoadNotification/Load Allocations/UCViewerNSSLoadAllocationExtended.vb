
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ComputersManagement
Imports R2Core.ExceptionManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreGUI

Public Class UCViewerNSSLoadAllocationExtended
    Inherits UCLoadAllocation

    Public Event UCClickedEvent(UC As UCLoadAllocation)



    Private Const _MaxHight As Int64 = 139
    Private Const _MinHight As Int64 = 89

#Region "General Properties"



#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            LabelTransportCompanyTitle.Text = String.Empty
            LabelGoodTitle.Text = String.Empty
            LabelLoadTargetTitle.Text = String.Empty
            LabelTruck.Text = String.Empty
            LabelDriverTruck.Text = String.Empty
            LabelLoadAllocationStatus.Text = String.Empty
            LabelStrDescription.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefreshExtended()
        Try
            LabelUserName.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Labels_Click(sender As Object, e As EventArgs) Handles LabelTransportCompanyTitle.Click, LabelGoodTitle.Click, LabelLoadTargetTitle.Click, LabelTruck.Click, LabelDriverTruck.Click, LabelLoadAllocationStatus.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMaximizeRequestedEvent() Handles UcMinimizeMaximize.UCMaximizeRequestedEvent
        Try
            UCRefreshExtended()
            LabelUserName.Text = R2CoreMClassSoftwareUsersManagement.GetNSSUser(UCNSSCurrent.UserId).UserName
            Me.Size = New Size(Me.Width, _MaxHight)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMinimizeRequestedEvent() Handles UcMinimizeMaximize.UCMinimizeRequestedEvent
        Try
            Me.Size = New Size(Me.Width, _MinHight)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadAllocationExtended_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            Dim NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationExtendedStructure = UCNSSCurrent
            LabelTransportCompanyTitle.Text = NSS.TransportCompanyTitle
            LabelGoodTitle.Text = NSS.GoodTitle
            LabelLoadTargetTitle.Text = NSS.LoadTargetTitle
            LabelTruck.Text = NSS.Truck
            LabelDriverTruck.Text = NSS.TruckDriver
            LabelLoadAllocationStatus.Text = NSS.LoadAllocationStatus
            LabelStrDescription.Text = NSS.StrDescription
            LabelLoadPermissionResult.Text = NSS.LANote
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub PicBoxLoadAllocationCancellation_Click(sender As Object, e As EventArgs) Handles PicBoxLoadAllocationCancellation.Click
        Try
            R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationCancelling(UCNSSCurrent.LAId, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewNSS(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(UCNSSCurrent.LAId))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخصیص بار کنسل شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
