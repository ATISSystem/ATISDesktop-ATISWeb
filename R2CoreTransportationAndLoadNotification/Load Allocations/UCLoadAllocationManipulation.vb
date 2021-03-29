
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class UCLoadAllocationManipulation
    Inherits UCLoadAllocation

    Public Event UCLoadAllocationRegisteredEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
    Public Event UCLoadAllocationCancelledEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
    Public Event UCTurnIdEnteredEvent(NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure)



#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonLoadAllocationCancelling.Visible = True
                UcButtonLoadAllocationRegistering.Visible = True
                UcButtonNewnEstelamIdRemain.Visible = True
                UcButtonNew.Visible = True
            Else
                UcButtonLoadAllocationCancelling.Visible = False
                UcButtonLoadAllocationRegistering.Visible = False
                UcButtonNewnEstelamIdRemain.Visible = False
                UcButtonNew.Visible = False
            End If
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshGeneral(True)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefreshGeneral(RefreshUcViewerNSSLoadCapacitorLoadDataEntry As Boolean)
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
            If RefreshUcViewerNSSLoadCapacitorLoadDataEntry Then
                UcViewerNSSLoadCapacitorLoadDataEntry.UCRefreshGeneral()
                UcViewerNSSLoadCapacitorLoadDataEntry.UCFocus()
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcNumberLoadAllocationId.UCRefresh()
            UcPersianTextBoxLoadAllocationDateTimeComposite.UCRefresh()
            UcPersianTextBoxLoadAllocationStatus.UCRefresh()
            UcPersianTextBoxLoadAllocationStatus.UCBackColor = Color.FromName(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocationStatus(R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.None).LoadAllocationStatusColor)
            UcButtonLoadAllocationRegistering.UCEnable = True
            UcViewerNSSTurnDataEntry.UCRefreshGeneral()
            UcViewerNSSTurnDataEntry.UCFocus()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcViewerNSSLoadCapacitorLoadDataEntry_UC13PressedEvent() Handles UcViewerNSSLoadCapacitorLoadDataEntry.UC13PressedEvent
        Try
            UcViewerNSSTurnDataEntry.UCFocus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonLoadAllocationRegistering_UCClickedEvent() Handles UcButtonLoadAllocationRegistering.UCClickedEvent
        Try
            UcButtonLoadAllocationRegistering.UCEnable = False
            UcButtonNew.UCEnable = True
            UcButtonNewnEstelamIdRemain.UCEnable = True
            UcNumberLoadAllocationId.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationRegistering(UcViewerNSSLoadCapacitorLoadDataEntry.UCNSSCurrent.nEstelamId, UcViewerNSSTurnDataEntry.UCNSSCurrent.nEnterExitId, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS, R2CoreTransportationAndLoadNotification.RequesterManagement.R2CoreTransportationAndLoadNotificationRequesters.UCLoadAllocationManipulation)
            UCViewNSS(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(UcNumberLoadAllocationId.UCValue))
            RaiseEvent UCLoadAllocationRegisteredEvent(UCNSSCurrent)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخصیص بارانجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As LoadAllocationRegisteringReachedEndTimeException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As RequesterHasNotPermissionforLoadAllocationRegisteringException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonLoadAllocationCancelling_UCClickedEvent() Handles UcButtonLoadAllocationCancelling.UCClickedEvent
        Try
            R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationCancelling(UcNumberLoadAllocationId.UCValue, R2CoreTransportationAndLoadNotificationLoadAllocationStatuses.CancelledUser, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewNSS(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(UcNumberLoadAllocationId.UCValue))
            RaiseEvent UCLoadAllocationCancelledEvent(UCNSSCurrent)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخصیص بار کنسل شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As LoadAllocationCancellingNotAllowedBecauseLoadAllocationStatusException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonNew_UCClickedEvent() Handles UcButtonNew.UCClickedEvent
        Try
            UCRefreshGeneral(True)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonNewnEstelamIdRemain_UCClickedEvent() Handles UcButtonNewnEstelamIdRemain.UCClickedEvent
        Try
            UCRefreshGeneral(False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcViewerNSSTurnDataEntry_UC13PressedEvent() Handles UcViewerNSSTurnDataEntry.UC13PressedEvent
        Try
            UcButtonLoadAllocationRegistering.UCFocus()
            RaiseEvent UCTurnIdEnteredEvent(UcViewerNSSTurnDataEntry.UCNSSCurrent)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLoadAllocationManipulation_UCViewNSSTurnRequestedEvent(NSSTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure) Handles Me.UCViewNSSTurnRequestedEvent
        Try
            UcViewerNSSTurnDataEntry.UCViewNSS(NSSTurn)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLoadAllocationManipulation_UCViewNSSLoadCapacitorLoadRequestedEvent(NSSLoadCapacitorLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) Handles Me.UCViewNSSLoadCapacitorLoadRequestedEvent
        Try
            UcViewerNSSLoadCapacitorLoadDataEntry.UCViewNSS(NSSLoadCapacitorLoad)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLoadAllocationManipulation_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure) Handles Me.UCViewNSSRequested
        Try
            UcNumberLoadAllocationId.UCValue = UCNSSCurrent.LAId
            UcPersianTextBoxLoadAllocationDateTimeComposite.UCValue = UCNSSCurrent.Time & " - " & UCNSSCurrent.DateShamsi
            UcPersianTextBoxLoadAllocationStatus.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocationStatus(NSSCurrent.LAStatusId).LoadAllocationStatusTitle
            UcPersianTextBoxLoadAllocationStatus.UCBackColor = Color.FromName(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocationStatus(NSSCurrent.LAStatusId).LoadAllocationStatusColor)
            UcViewerNSSLoadCapacitorLoadDataEntry.UCViewNSS(NSSCurrent.nEstelamId)
            UcViewerNSSTurnDataEntry.UCViewNSS(UCNSSCurrent.TurnId)
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
