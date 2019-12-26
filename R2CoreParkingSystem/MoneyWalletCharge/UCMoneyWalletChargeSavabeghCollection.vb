

Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2Core.DatabaseManagement
Imports R2Core.PublicProc
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.MoneyWalletChargeManagement
Imports R2CoreParkingSystem.TrafficCardsManagement


Public Class UCMoneyWalletChargeSavabeghCollection
    Inherits UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2StandardMoneyWalletChargeExtendedStructure)
    Public Event UCViewCollectionCompeletedEvent()
    Public Event UCSavabeghViewedSuccessEvent()


#Region "General Properties"

    Private Property UCTotalNumberOfRecordstoView As Int32 = 10

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2StandardMoneyWalletChargeExtendedStructure)
    Private _Counting As Int64
    Private _Counter As Int64

    Private Sub UCViewCollection(YourCollection As List(Of R2StandardMoneyWalletChargeExtendedStructure))
        Try
            UCRefresh()
            Lst = YourCollection
            If Lst.Count < 1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If
            _Counting = Lst.Count
            _Counter = Lst.Count - 1

            _TTimer = New Timer()
            _TTimer.Interval = 1
            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub UCViewCollectionDelegate()
    Private Sub UCViewCollection()
        Try
            Dim UC As UCMoneyWalletChargeSabegheh = New UCMoneyWalletChargeSabegheh()
            UC.UCViewInf(Lst(_Counter))
            UC.Dock = DockStyle.Top
            AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
            If PnlUCs.InvokeRequired Then
                PnlUCs.Invoke(New UCViewCollectionDelegate(AddressOf UCViewCollection))
            Else
                PnlUCs.Controls.Add(UC)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewChargeSavabegh(ByVal YourNSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            If YourNSSTrafficCard Is Nothing Then Exit Sub
            UCViewCollection(R2CoreParkingSystemMClassMoneyWalletChargeManagement.GetMoneyWalletChargeCollection(YourNSSTrafficCard, UCTotalNumberOfRecordstoView))
            RaiseEvent UCSavabeghViewedSuccessEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod.DeclaringType.FullName + vbCrLf + MethodBase.GetCurrentMethod.Name + vbCrLf + ex.Message.ToString)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _TTimer_Tick(sender As Object, e As EventArgs) Handles _TTimer.Tick
        Try
            _TTimer.Enabled = False
            _TTimer.Stop()

            UCViewCollection()

            _Counter = _Counter - 1
            If _Counter = -1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If

            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCs_UCClickedEvent(UC As UCMoneyWalletChargeSabegheh)
        Try
            RaiseEvent UCSelectedNSSChangedEvent(UC.UCCurrentNSS)
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
