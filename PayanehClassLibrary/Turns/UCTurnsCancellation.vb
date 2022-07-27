

Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection

Imports R2CoreGUI
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2CoreTransportationAndLoadNotification.Turns.TurnExpiration
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class UCTurnsCancellation
    Inherits UCGeneral

#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try

    End Sub

    Public Sub USRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CButtonTurnsCancellation_Click(sender As Object, e As EventArgs) Handles CButtonTurnsCancellation.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim InstanceTurns = New PayanehClassLibraryMClassCarTruckNobatManager
            InstanceTurns.TurnsCancellation(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ابطال گروهی نوبت ها انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UcLstViewerAllOfnEnterExitId_UCSelectedValueChanged() Handles UcLstViewerAllOfnEnterExitId.UCSelectedValueChanged
        Try
            Dim InstanceTurnExpiration = New R2CoreTransportationAndLoadNotificationMClassTurnExpirationManager
            Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
            InstanceTurnExpiration.TurnCreditRegistering(UcLstViewerAllOfnEnterExitId.UCGetCurrentNSSSequentialTurn, InstanceTurns.GetNSSTurn(UcLstViewerAllOfnEnterExitId.UCGetSelectedTurnId), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "شماره اعتبار مورد نظر ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
