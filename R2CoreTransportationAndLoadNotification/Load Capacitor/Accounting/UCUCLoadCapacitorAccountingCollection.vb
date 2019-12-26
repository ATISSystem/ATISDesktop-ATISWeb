
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorAccounting

Public Class UCUCLoadCapacitorAccountingCollection
    Inherits UCGeneral

    Public Event UCPictureExitClickedEvent()


#Region "General Properties"
    Private _UCViewUCPictureExit As Boolean = False
    Public Property UCViewUCPictureExit() As Boolean
        Get
            Return _UCViewUCPictureExit
        End Get
        Set(value As Boolean)
            _UCViewUCPictureExit = value
            UcPictureExit.Visible = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure)
    Private _Counting As Int64
    Private _Counter As Int64
    Public Sub UCViewAccounting(YournEstelamId As Int64)
        Try
            UCRefresh()
            Lst = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.GetAccountings(YournEstelamId)
            If Lst.Count < 1 Then Exit Sub
            _Counting = Lst.Count
            _Counter = Lst.Count-1

            _TTimer = New Timer()
            _TTimer.Interval = 1
            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewAccounting()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim UC As UCLoadCapacitorLoadAccounting = New UCLoadCapacitorLoadAccounting
            UC.UCViewNSS(Lst(_Counter))
            UC.Dock = DockStyle.Top
            PnlUCs.Controls.Add(UC)
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Sub UCRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPictureExit_UCClickedEvent() Handles UcPictureExit.UCClickedEvent
        RaiseEvent UCPictureExitClickedEvent()
    End Sub

    Private Sub _TTimer_Tick(sender As Object, e As EventArgs) Handles _TTimer.Tick
        Try
            _TTimer.Enabled = False
            _TTimer.Stop()
            UCViewAccounting()
            _Counter = _Counter - 1
            If _Counter = -1 Then Exit Sub
            _TTimer.Enabled = True
            _TTimer.Start()
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
