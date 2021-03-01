

Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadAllocation.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.ProcessesManagement
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.Exceptions

Public Class FrmcTruckDriverLoadAllocationsPriorityApplied
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreTransportationAndLoadNotificationProcesses.FrmcTruckDriverLoadAllocationsPriorityApplied))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        Try

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcucLoadCapacitorLoadCollectionAdvance_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) Handles UcucLoadCapacitorLoadCollectionAdvance.UCSelectedNSSChangedEvent
        Try
            R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationRegistering(NSS.nEstelamId, UcViewerNSSTurnDataEntry.UCNSSCurrent.nEnterExitId, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UcucLoadAllocationCollection.UCRefreshGeneral()
            UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcViewerNSSTurnDataEntry.UCNSSCurrent))
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تخصیص بارانجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception When TypeOf ex Is AnnouncementHallSubGroupUnActiveException _
         OrElse TypeOf ex Is TimingNotReachedException _
         OrElse TypeOf ex Is TurnNotFoundException _
         OrElse TypeOf ex Is LoadAllocationMaximumAllowedNumberReachedException _
         OrElse TypeOf ex Is RegisteredLoadAllocationIsRepetitiousException _
         OrElse TypeOf ex Is LoadCapacitorLoadAHSGIdViaTruckAHSGIdNotAllowedException _
         OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseLoadCapacitorLoadIsNotReadyException _
         OrElse TypeOf ex Is LoadAllocationRegisteringFailedBecauseTurnIsNotReadyException _
         OrElse TypeOf ex Is LoadCapacitorLoadLoaderTypeViaSequentialTurnOfTurnNotAllowedException _
         OrElse TypeOf ex Is LoadAllocationNotAllowedBecuaseAHSGLoadAllocationIsUnactiveException _
         OrElse TypeOf ex Is LoadAllocationNotFoundException
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcViewerNSSTurnDataEntry_UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTurnStructure) Handles UcViewerNSSTurnDataEntry.UCNSSCurrentChanged
        Try
            If IsNothing(NSSCurrent) Then Return
            UcucLoadAllocationCollection.UCRefreshGeneral()
            UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcViewerNSSTurnDataEntry.UCNSSCurrent))
        Catch ex As LoadAllocationNotFoundException
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCDecreasedPriorityEvent() Handles UcucLoadAllocationCollection.UCDecreasedPriorityEvent
        Try
            UcucLoadAllocationCollection.UCRefreshGeneral()
            UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcViewerNSSTurnDataEntry.UCNSSCurrent))
        Catch ex As LoadAllocationNotFoundException
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCIncreasedPriorityEvent() Handles UcucLoadAllocationCollection.UCIncreasedPriorityEvent
        Try
            UcucLoadAllocationCollection.UCRefreshGeneral()
            UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcViewerNSSTurnDataEntry.UCNSSCurrent))
        Catch ex As LoadAllocationNotFoundException
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCLoadAllocationCancelationEvent() Handles UcucLoadAllocationCollection.UCLoadAllocationCancelationEvent
        Try
            UcucLoadAllocationCollection.UCRefreshGeneral()
            UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcViewerNSSTurnDataEntry.UCNSSCurrent))
        Catch ex As LoadAllocationNotFoundException
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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