
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadPermission

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

    Public Sub UCRefreshGeneral()
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
            Dim NSSLoadAllocation As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetNSSLoadAllocation(NSSCurrent.nEstelamId, NSSCurrent.TurnId)
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
            R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.LoadPermissionCancelling(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId, CheckBoxTurn.Checked, CheckBoxLoadCapacitorLoad.Checked,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            Threading.Thread.Sleep(1500)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "کنسلی مجوز بارگیری انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            UCViewNSS(UCNSSCurrent.nEstelamId, UCNSSCurrent.TurnId)
            RaiseEvent UCCancellationCompleteEvent()
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
