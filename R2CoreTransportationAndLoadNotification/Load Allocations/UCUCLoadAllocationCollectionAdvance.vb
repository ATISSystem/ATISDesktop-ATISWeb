
Imports System.Reflection
Imports R2Core.BaseStandardClass
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadAllocation

Public Class UCUCLoadAllocationCollectionAdvance
    Inherits UCGeneralExtended

    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCViewCollection()
        Try
            If UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall Is Nothing Or UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup Is Nothing Or (ChkTransportCompany.Checked = True And UcSearcherTransportCompanies.UCDoUserSelectedItem() = False) Then Exit Sub
            If ChkTransportCompany.Checked Then
                UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId, UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId, UcucLoadAllocationStatusCollection.UCCurrentNSS.LoadAllocationStatusId, UcSearcherTransportCompanies.UCGetSelectedNSS.OCode))
            Else
                UcucLoadAllocationCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetLoadAllocations(UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId, UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId, UcucLoadAllocationStatusCollection.UCCurrentNSS.LoadAllocationStatusId))
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
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationStatusCollection_UCCurrentNSSChangedEvent() Handles UcucLoadAllocationStatusCollection.UCCurrentNSSChangedEvent
        Try
            UCViewCollection()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure) Handles UcucLoadAllocationCollection.UCSelectedNSSChangedEvent
        Try
            RaiseEvent UCSelectedNSSChangedEvent(NSS)
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



#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
