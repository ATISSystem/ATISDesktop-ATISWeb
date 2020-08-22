
Imports System.Reflection
Imports PAKTCRemoteApplication
Imports R2CoreWinFormRemoteApplications


Public Class FrmcTransportCompanyLoadCapacitorSedimentLoadsAllocation
    Inherits FrmcGeneral

    Private _CurrentTurnId As Int64 = 0

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            Me.Owner = FrmcFirst.FrmMain
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
    End Sub






#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection_UCsClickedEvent(UC As UCTransportCompanyLoadCapacitorSedimentLoadViewer) Handles UcucTransportCompanyLoadCapacitorSedimentLoadViewerCollection.UCsClickedEvent
        Try
            UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.UCViewNSS(UC.UCGetCurrentNSS)
            UcButtonSpecialAllocateSedimentLoadAndPermission.UCEnable = True
            UcCarTruck.UCRefreshGeneral() : UcDriverTruck.UCRefreshGeneral()
            PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.BringToFront()
            PnlTransportCompanyLoadCapacitorSedimentLoadAllocation.Focus()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub BtnPnlTransportCompanyLoadCapacitorSedimentedLoads_Click(sender As Object, e As EventArgs) Handles BtnPnlTransportCompanyLoadCapacitorSedimentedLoads.Click
        PnlTransportCompanyLoadCapacitorSedimentedLoads.BringToFront()
        PnlTransportCompanyLoadCapacitorSedimentedLoads.Focus()
    End Sub


    Private Sub UcButtonSpecialAllocateSedimentLoadAndPermission_UCClickedEvent() Handles UcButtonSpecialAllocateSedimentLoadAndPermission.UCClickedEvent
        Try
            _CurrentTurnId = 0
            Try
                TransportCompaniesLoadCapacitorLoadsManipulation.CreateCarTruckRelationDriverTruck(UcCarTruck.UCGetSmartCarNo, UcDriverTruck.UCGetSmartCarNo)
            Catch ex As Exception
            End Try

            ''TransportCompaniesLoadCapacitorLoadsManipulation.AllocateSedimentLoadMessegeSend(UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.UCGetCurrentNSS.nEstelamId, UcCarTruck.UCGetSmartCarNo, UcDriverTruck.UCGetSmartCarNo)
            _CurrentTurnId = TransportCompaniesLoadCapacitorLoadsManipulation.AllocateSedimentLoadAndPermission(UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.UCGetCurrentNSS.nEstelamId, UcCarTruck.UCGetSmartCarNo, UcDriverTruck.UCGetSmartCarNo)
            UcButtonSpecialAllocateSedimentLoadAndPermission.UCEnable = False
            Dim TransportCompanyMoneyWalletInventory As String = R2CoreWinFormRemoteApplications.PublicProc.R2CoreWinFormRemoteApplicationsMclassPublicProcManagement.ParseSignDigitToTashString(TransportCompaniesLoadCapacitorLoadsManipulation.GetTransportCompanyMoneyWalletInventory())
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مجوز بارگیری با موفقیت صادر شد" + vbCrLf + "موجودی کیف پول" + vbCrLf + TransportCompanyMoneyWalletInventory, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,false)
            ''_FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "پیام درخواست صدور مجوز بارگیری با موفقیت ارسال شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonSpecialRepeatPermissionPrint_UCClickedEvent() Handles UcButtonSpecialRepeatPermissionPrint.UCClickedEvent
        Try
            TransportCompaniesLoadCapacitorLoadsManipulation.RepeatePermissionPrint(UcTransportCompanyLoadCapacitorSedimentLoadViewerPnlAllocation.UCGetCurrentNSS.nEstelamId, _CurrentTurnId)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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