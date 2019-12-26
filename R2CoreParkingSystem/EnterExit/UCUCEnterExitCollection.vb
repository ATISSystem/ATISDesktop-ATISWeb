
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2Core.UserManagement
Imports R2Core.DatabaseManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.CamerasManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2Core.ComputersManagement
Imports R2Core.ExceptionManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCUCEnterExitCollection
    Inherits UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2StandardEnterExitStructure)
    Public Event UCViewCollectionCompeletedEvent()


#Region "General Properties"

    Private Property UCTotalNumberOfRecordstoView As Int32 = 20

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

    Private Sub UCRefresh()
        Try
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2StandardEnterExitExtendedStructure)
    Private _Counting As Int64
    Private _Counter As Int64

    Private Sub UCViewCollection(YourCollection As List(Of R2StandardEnterExitExtendedStructure))
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
            Dim UC As UCEnterExit = New UCEnterExit
            UC.UCViewEnterExit(Lst(_Counter))
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

    Public Sub UCViewEnterExitbyTrafficCard(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UCViewCollection(R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitCollection(YourNSSTerafficCard, UCTotalNumberOfRecordstoView))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewEnterExitbyCarId(YourNSSCar As R2StandardCarStructure, YourNumberOfRecords As Int64)
        Try
            UCViewCollection(R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitCollection(YourNSSCar, UCTotalNumberOfRecordstoView))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
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

    Private Sub UCs_UCClickedEvent(UC As UCEnterExit)
        Try
            RaiseEvent UCSelectedNSSChangedEvent(UC.UCCurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            Try
                UcDriver.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
                UcCarImage.UCViewCarEnterExitImage(UcCar.UCGetNSS())
            Catch ex As Exception
            End Try
            UcCarEnterExitStatus.UCViewStatus(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(R2CoreParkingSystemMClassCars.GetCardIdFromnIdCar(CarId)))
            UCViewEnterExitbyCarId(UcCar.UCGetNSS(), 10)
        Catch ex As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As CarHasNoEnterExitRecordException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
