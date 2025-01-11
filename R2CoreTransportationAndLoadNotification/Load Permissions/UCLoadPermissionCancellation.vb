
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Drivers
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions
Imports R2CoreTransportationAndLoadNotification.DriverSelfDeclaration.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadPermission
Imports R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions
Imports R2CoreTransportationAndLoadNotification.RequesterManagement
Imports R2CoreTransportationAndLoadNotification.TruckDrivers
Imports R2CoreTransportationAndLoadNotification.TruckDrivers.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions

Public Class UCLoadPermissionCancellation
    Inherits UCLoadPermission

    Public Event UCCancellationCompleteEvent()

#Region "General Properties"
    Private _UCBackColor As Color = Color.SkyBlue
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            PnlMain.BackColor = value
        End Set
    End Property

    Private _UCBackColorDisable As Color = Color.Gray
    Public Property UCBackColorDisable() As Color
        Get
            Return _UCBackColorDisable
        End Get
        Set(value As Color)
            _UCBackColorDisable = value
        End Set
    End Property

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

    Public Shadows Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcViewerNSSLoadPermissionExtended.UCRefreshGeneral()
            CheckBoxTurn.Checked = True
            CheckBoxLoadCapacitorLoad.Checked = True
            UcCar.UCRefreshGeneral()
            UcDriver.UCRefreshGeneral()
            UcViewerNSSSequentialTurnNumber.UCRefreshGeneral()
            UcPersianTextBoxDescription.UCValue = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCLoadAllocateToOther()
        Try
            'تخصیص به راننده دیگر
            Dim PrimaryTurn As R2CoreTransportationAndLoadNotificationStandardTurnStructure
            PrimaryTurn = R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.GetNSSPrimaryTurn(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId)
            Dim InstanceLoadAllocation = New R2CoreTransportationAndLoadNotificationInstanceLoadAllocationManager
            InstanceLoadAllocation.LoadAllocationRegistering(UCNSSCurrent.nEstelamId, PrimaryTurn, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS, R2CoreTransportationAndLoadNotificationRequesters.UCLoadPermissionCancellation, False, True)
            Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
            Dim NSSTruck = InstanceTurns.GetNSSTruck(PrimaryTurn.nEnterExitId)
            UcCar.UCViewCarInformation(NSSTruck.NSSCar.nIdCar)
            Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
            UcDriver.UCViewDriverInformation(InstanceTruckDrivers.GetNSSTruckDriverWithTruckId(NSSTruck.NSSCar.nIdCar).NSSDriver.nIdPerson)
            UcViewerNSSSequentialTurnNumber.UCViewNSS(PrimaryTurn)
        Catch ex As Exception When TypeOf ex Is AnnouncementHallSubGroupUnActiveException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                OrElse TypeOf ex Is LoadAllocationRegisteringReachedEndTimeException _
                OrElse TypeOf ex Is LoadAllocationMaximumAllowedNumberReachedException _
                OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException _
                OrElse TypeOf ex Is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException _
                OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException _
                OrElse TypeOf ex Is RegisteredLoadAllocationIsRepetitiousException _
                OrElse TypeOf ex Is RequesterHasNotPermissionforLoadAllocationRegisteringException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecauseCarHasBlackListException _
                OrElse TypeOf ex Is TimingNotReachedException _
                OrElse TypeOf ex Is TurnNotFoundException _
                OrElse TypeOf ex Is TruckNotFoundException _
                OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                OrElse TypeOf ex Is UnableAllocatingTommorowLoadException _
                OrElse TypeOf ex Is LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException _
                OrElse TypeOf ex Is TruckTotalLoadPermissionReachedException _
                OrElse TypeOf ex Is LastLoadPermissionIssuedforThisTurnException _
                OrElse TypeOf ex Is RequesterCanNotAllocateSedimentedLoadInTimeRangeException _
                OrElse TypeOf ex Is LoadAllocationTimeNotReachedException _
                OrElse TypeOf ex Is DSDsNotFoundException _
                OrElse TypeOf ex Is PrimaryTurnNotFoundException _
                OrElse TypeOf ex Is UnableResucitationTemporayTurnException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCLoadPermissionCancellation_UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure) Handles Me.UCNSSCurrentChanged
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLoadPermissionCancellation_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure) Handles Me.UCViewNSSRequested
        Try
            UcViewerNSSLoadPermissionExtended.UCViewNSS(NSSCurrent)
            Dim NSSLoadAllocation = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(NSSCurrent.nEstelamId, NSSCurrent.TurnId)
            UcNumberLoadAllocationId.UCValue = NSSLoadAllocation.LAId
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumberLoadAllocationId_UC13Pressed(UserNumber As String) Handles UcNumberLoadAllocationId.UC13Pressed
        Try
            UCRefresh()
            Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(UserNumber)
            UCViewNSS(NSSLoadAllocation.nEstelamId, NSSLoadAllocation.TurnId)
            Dim NSSLoad = (New R2CoreTransportationAndLoadNotificationInstanceLoadCapacitorLoadManager).GetNSSLoadCapacitorLoad(NSSLoadAllocation.nEstelamId, True)
            'UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(Nothing, Nothing, Nothing, Nothing, NSSLoadAllocation.nEstelamId))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonLoadPermissionCancelling_UCClickedEvent() Handles UcButtonLoadPermissionCancelling.UCClickedEvent
        Try
            UcCar.UCRefreshGeneral()
            UcDriver.UCRefreshGeneral()
            UcViewerNSSSequentialTurnNumber.UCRefreshGeneral()
            If UcPersianTextBoxDescription.UCValue.Trim = String.Empty Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "شرح کنسلی مجوز بارگیری را وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.LoadPermissionCancelling(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId, CheckBoxTurn.Checked, CheckBoxLoadCapacitorLoad.Checked, UcPersianTextBoxDescription.UCValue.Trim, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCViewNSS(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "کنسلی مجوز بارگیری با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            RaiseEvent UCCancellationCompleteEvent()
        Catch ex As Exception When TypeOf ex Is AnnouncementHallSubGroupUnActiveException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                OrElse TypeOf ex Is LoadAllocationRegisteringReachedEndTimeException _
                OrElse TypeOf ex Is LoadAllocationMaximumAllowedNumberReachedException _
                OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException _
                OrElse TypeOf ex Is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException _
                OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException _
                OrElse TypeOf ex Is RegisteredLoadAllocationIsRepetitiousException _
                OrElse TypeOf ex Is RequesterHasNotPermissionforLoadAllocationRegisteringException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecauseCarHasBlackListException _
                OrElse TypeOf ex Is TimingNotReachedException _
                OrElse TypeOf ex Is TurnNotFoundException _
                OrElse TypeOf ex Is TruckNotFoundException _
                OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                OrElse TypeOf ex Is UnableAllocatingTommorowLoadException _
                OrElse TypeOf ex Is LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException _
                OrElse TypeOf ex Is TruckTotalLoadPermissionReachedException _
                OrElse TypeOf ex Is LastLoadPermissionIssuedforThisTurnException _
                OrElse TypeOf ex Is RequesterCanNotAllocateSedimentedLoadInTimeRangeException _
                OrElse TypeOf ex Is LoadAllocationTimeNotReachedException _
                OrElse TypeOf ex Is DSDsNotFoundException _
                OrElse TypeOf ex Is UnableResucitationTemporayTurnException _
                OrElse TypeOf ex Is PrimaryTurnNotFoundException _
                OrElse TypeOf ex Is LoadPermisionCancellationTimePassedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonLoadAllocationToOther_UCClickedEvent() Handles UcButtonLoadAllocationToOther.UCClickedEvent
        Try
            UCLoadAllocateToOther()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخصیص بار به راننده دیگر انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception When TypeOf ex Is AnnouncementHallSubGroupUnActiveException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupRelationTruckNotExistException _
                OrElse TypeOf ex Is AnnouncementHallSubGroupNotFoundException _
                OrElse TypeOf ex Is LoadAllocationRegisteringReachedEndTimeException _
                OrElse TypeOf ex Is LoadAllocationMaximumAllowedNumberReachedException _
                OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
                OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException _
                OrElse TypeOf ex Is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException _
                OrElse TypeOf ex Is LoadCapacitorLoadHandlingNotAllowedBecuaseLoadStatusException _
                OrElse TypeOf ex Is RegisteredLoadAllocationIsRepetitiousException _
                OrElse TypeOf ex Is RequesterHasNotPermissionforLoadAllocationRegisteringException _
                OrElse TypeOf ex Is LoadAllocationNotAllowedBecauseCarHasBlackListException _
                OrElse TypeOf ex Is TimingNotReachedException _
                OrElse TypeOf ex Is TurnNotFoundException _
                OrElse TypeOf ex Is TruckNotFoundException _
                OrElse TypeOf ex Is TurnHandlingNotAllowedBecuaseTurnStatusException _
                OrElse TypeOf ex Is UnableAllocatingTommorowLoadException _
                OrElse TypeOf ex Is LoadPermissionCancellingNotAllowedBecuaseLoadPermissionStatusException _
                OrElse TypeOf ex Is TruckTotalLoadPermissionReachedException _
                OrElse TypeOf ex Is LastLoadPermissionIssuedforThisTurnException _
                OrElse TypeOf ex Is RequesterCanNotAllocateSedimentedLoadInTimeRangeException _
                OrElse TypeOf ex Is LoadAllocationTimeNotReachedException _
                OrElse TypeOf ex Is DSDsNotFoundException _
                OrElse TypeOf ex Is PrimaryTurnNotFoundException _
                OrElse TypeOf ex Is UnableResucitationTemporayTurnException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As PrimaryTurnNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)
        Try
            Dim NSSLoadAllocation = NSS
            Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
            Dim PrimaryTurn = InstanceTurns.GetNSSTurn(NSSLoadAllocation.TurnId)
            Dim NSSTruck = InstanceTurns.GetNSSTruck(PrimaryTurn.nEnterExitId)
            UcCar.UCViewCarInformation(NSSTruck.NSSCar.nIdCar)
            Dim InstanceTruckDrivers = New R2CoreTransportationAndLoadNotificationInstanceTruckDriversManager
            UcDriver.UCViewDriverInformation(InstanceTruckDrivers.GetNSSTruckDriverWithTruckId(NSSTruck.NSSCar.nIdCar).NSSDriver.nIdPerson)
            UcViewerNSSSequentialTurnNumber.UCViewNSS(PrimaryTurn)
        Catch ex As TurnNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As RelationBetweenTurnAndTruckNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As DriverNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As TruckDriverNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CheckBoxLoadCapacitorLoad_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLoadCapacitorLoad.CheckedChanged
        UcButtonLoadAllocationToOther.Enabled = CheckBoxLoadCapacitorLoad.Checked
    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class
