
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.UserChargeProcessManagement

Public Class UCUserChargeSavabeghCollection
    Inherits UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2StandardUserChargeProcessStructure)
    Public Event UCViewCollectionCompeletedEvent()


#Region "General Properties"

    Private Property UCTotalNumberOfRecordstoView As Int32 = 1000


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
            UcLabelDaramad.UCValue = 0
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
            'UcTimeEntry1.UCSetCurrentTime()
            'UcTimeEntry2.UCSetCurrentTime()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2StandardUserChargeProcessStructure)
    Private _Counting As Int64
    Private _Counter As Int64
    Private Sub UCViewCollection(YourCollection As List(Of R2StandardUserChargeProcessStructure))
        Try
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
            Dim UC As UCUserChargeSabegheh = New UCUserChargeSabegheh()
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

    Public Sub UCViewSavabegh(YourNSSUser As R2CoreStandardUserStructure)
        Try
            PnlUCs.Controls.Clear()
            UcLabelDaramad.UCValue = R2Core.PublicProc.R2CoreMClassPublicProcedures.ParseSignDigitToSignString(R2CoreParkingSystemMClassUserChargeProcessManagement.GetTotalAmountofUserChargeProcess(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS, UcPersianShamsiDate1.UCGetDate.DateShamsiFull, UcPersianShamsiDate2.UCGetDate().DateShamsiFull, UcTimeEntry1.UCGetTime().Time, UcTimeEntry2.UCGetTime.Time))
            UCViewCollection(R2CoreParkingSystemMClassUserChargeProcessManagement.GetUserChargeProcessCollection(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS, UcPersianShamsiDate1.UCGetDate.DateShamsiFull, UcPersianShamsiDate2.UCGetDate().DateShamsiFull, UcTimeEntry1.UCGetTime().Time, UcTimeEntry2.UCGetTime.Time, UCTotalNumberOfRecordstoView))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            UCViewSavabegh(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

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

    Private Sub UCs_UCClickedEvent(UC As UCUserChargeSabegheh)
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
