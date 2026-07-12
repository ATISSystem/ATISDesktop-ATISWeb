Imports R2CoreGUI
Imports System.Reflection
Imports R2CoreTransportationAndLoadNotification.TransportTarrifs

Public Class UCTransportPriceTariff
    Inherits UCGeneral

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UcButtonCButtonRegistering_UCClickedEvent() Handles UcButtonCButtonRegistering.UCClickedEvent
        Try
            Dim targetcityid = UcSearcherLoadTargets.UCGetSelectedNSS.OCode
            Dim sourcecityid = UcSearcherLoadSources.UCGetSelectedNSS.OCode
            Dim AHId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId
            Dim AHSGId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId
            Dim Tarrif = UcMoney.UCValueMoney
            Dim InstanceTransportTarrifs = New R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsManager
            InstanceTransportTarrifs.TransportTarrifRegistering(targetcityid, sourcecityid, AHId, AHSGId, Tarrif)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت اطلاعات با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UcButtonCButtonDeleting_UCClickedEvent() Handles UcButtonCButtonDeleting.UCClickedEvent
        Try
            Dim targetcityid = UcSearcherLoadTargets.UCGetSelectedNSS.OCode
            Dim sourcecityid = UcSearcherLoadSources.UCGetSelectedNSS.OCode
            Dim AHId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHall.AHId
            Dim AHSGId = UcAnnouncementHallSelection.UCNSSCurrentAnnouncementHallSubGroup.AHSGId
            Dim Tarrif = UcMoney.UCValueMoney
            Dim InstanceTransportTarrifs = New R2CoreTransportationAndLoadNotificationInstanceTransportTarrifsManager
            InstanceTransportTarrifs.TransportTarrifDeleting(targetcityid, sourcecityid, AHId, AHSGId)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت اطلاعات با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub
End Class
