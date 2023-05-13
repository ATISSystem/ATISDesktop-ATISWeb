
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadPermission
Imports R2CoreTransportationAndLoadNotification.LoadPermission.Exceptions
Imports R2CoreTransportationAndLoadNotification.RequesterManagement
Imports R2CoreTransportationAndLoadNotification.TruckDrivers
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

            'تخصیص به راننده دیگر
            If CheckBoxLoadAllocation.Checked Then
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
            End If

            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "کنسلی مجوز بارگیری انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            UCViewNSS(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId)
            RaiseEvent UCCancellationCompleteEvent()
        Catch ex As UnableResucitationTemporayTurnException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
                OrElse TypeOf ex Is LastLoadPermissionIssuedforThisTurnException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As PrimaryTurnNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CheckBoxLoadCapacitorLoad_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxLoadCapacitorLoad.CheckStateChanged
        CheckBoxLoadAllocation.Checked = CheckBoxLoadCapacitorLoad.Checked
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class
