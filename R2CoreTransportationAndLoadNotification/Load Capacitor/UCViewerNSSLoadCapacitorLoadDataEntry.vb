
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad

Public Class UCViewerNSSLoadCapacitorLoadDataEntry
    Inherits UCLoadCapacitorLoad

    Public Event UC13PressedEvent()
    Private _FrmMessageDialog As FrmcMessageDialog


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _FrmMessageDialog = New FrmcMessageDialog()
            UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewInformation()
        Try
            Dim NSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure = UCNSSCurrent
            UcNumbernEstelamId.UCValue = NSS.nEstelamId
            UcLabelTransportCompany.UCValue = NSS.TransportCompanyTitle
            UcLabelGood.UCValue = NSS.GoodTitle
            UcLabelLoadTarget.UCValue = NSS.LoadTargetTitle
            UcLabelStrDescription.UCValue = NSS.StrDescription
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub UCRefreshInformation()
        Try
            UcNumbernEstelamId.UCRefreshGeneral()
            UcLabelTransportCompany.UCRefreshGeneral()
            UcLabelGood.UCRefreshGeneral()
            UcLabelLoadTarget.UCRefreshGeneral()
            UcLabelStrDescription.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcNumbernEstelamId_UC13Pressed(UserNumber As String) Handles UcNumbernEstelamId.UC13Pressed
        Try
            UCNSSCurrent = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(UcNumbernEstelamId.UCValue)
            UCViewInformation()
            RaiseEvent UC13PressedEvent()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadCapacitorLoadDataEntry_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewInformation()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadCapacitorLoadDataEntry_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        UcNumbernEstelamId.UCFocus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
