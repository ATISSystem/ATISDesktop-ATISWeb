
Imports System.Reflection
Imports System.Timers

Imports R2Core.BaseStandardClass
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad

Public Class UCUCLoadCapacitorLoadCollectionAdvance
    Inherits UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
    Private _CurrentOrderingOption As R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions = R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nEstelamId
    Public Event UCViewInformationCompletedEvent()


#Region "General Properties"

    Private _UCTimerInterval As Int64 = 1
    Public Property UCTimerInterval() As Int64
        Get
            Return _UCTimerInterval
        End Get
        Set(value As Int64)
            _UCTimerInterval = value
            UcucLoadCapacitorLoadCollection.UCTimerInterval = value
        End Set
    End Property

    Private _UCViewnCarNumZero As Boolean = True
    Public Property UCViewnCarNumZero() As Boolean
        Get
            Return _UCViewnCarNumZero
        End Get
        Set(value As Boolean)
            _UCViewnCarNumZero = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UcViewerCurrentLoadsStatisticsSummary.UCRefreshGeneral()

    End Sub

    Private Sub UCViewCollection()
        Try
            If UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall Is Nothing Or UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup Is Nothing Or UcucAnnouncementHallAnnounceTimeTypeCollection.UCCurrentNSS Is Nothing Or (ChkTransportCompany.Checked = True And UcSearcherTransportCompanies.UCDoUserSelectedItem() = False) Then Exit Sub
            If ChkTransportCompany.Checked Then
                UcucLoadCapacitorLoadCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLoadCapacitorLoads(UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId, UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId, UcucAnnouncementHallAnnounceTimeTypeCollection.UCCurrentNSS.AHATTypeId, UCViewnCarNumZero, True, _CurrentOrderingOption, UcSearcherTransportCompanies.UCGetSelectedNSS.OCode))
            Else
                UcucLoadCapacitorLoadCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetLoadCapacitorLoads(UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId, UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId, UcucAnnouncementHallAnnounceTimeTypeCollection.UCCurrentNSS.AHATTypeId, UCViewnCarNumZero, True, _CurrentOrderingOption))
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub






#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub UcAnnouncementHallSelection_UCCurrentNSSAnnouncementHallSubGroupChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection.UCCurrentNSSAnnouncementHallSubGroupChangedEvent
        Try
            UcViewerCurrentLoadsStatisticsSummary.UCViewInformation(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId)
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucAnnouncementHallAnnounceTimeTypeCollection_UCCurrentNSSChangedEvent() Handles UcucAnnouncementHallAnnounceTimeTypeCollection.UCCurrentNSSChangedEvent
        Try
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadCapacitorLoadCollection_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) Handles UcucLoadCapacitorLoadCollection.UCSelectedNSSChangedEvent
        Try
            RaiseEvent UCSelectedNSSChangedEvent(NSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadCapacitorLoadCollection_UCOrderingOptionChangedEvent(OrderingOption As R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions) Handles UcucLoadCapacitorLoadCollection.UCOrderingOptionChangedEvent
        Try
            _CurrentOrderingOption = OrderingOption
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcSearcherTransportCompanies_UCItemSelectedEvent(SelectedItem As R2StandardStructure) Handles UcSearcherTransportCompanies.UCItemSelectedEvent
        Try
            ChkTransportCompany.Checked = True
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadCapacitorLoadCollection_UCViewInformationCompletedEvent() Handles UcucLoadCapacitorLoadCollection.UCViewInformationCompletedEvent
        Try
            RaiseEvent UCViewInformationCompletedEvent 
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
