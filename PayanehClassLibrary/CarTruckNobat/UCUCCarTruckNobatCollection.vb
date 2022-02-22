
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports R2Core.DatabaseManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.CarType
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DataBaseManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports R2Core.RFIDCardsManagement
Imports R2CoreTransportationAndLoadNotification.Turns
Imports PayanehClassLibrary.CarTruckNobatManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks

Public Class UCUCCarTruckNobatCollection
    Inherits UCGeneral
    Implements R2CoreRFIDCardRequester

    Private _NSSTruck As R2StandardCarStructure
    Public Event _UCTerraficCardReadedEvent(NSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure)
    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
    Public Event UCViewCollectionCompeletedEvent()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        Try
            UcCarPresenter.UCRefresh()
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure)
    Private _Counting As Int64
    Private _Counter As Int64
    Private Sub UCViewCollection(YourCollection As List(Of R2CoreTransportationAndLoadNotificationStandardTurnExtendedStructure))
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

    Public Sub UCViewCollection(YourTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            Dim InstanceCars = New R2CoreParkingSystemInstanceCarsManager
            Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
            If Not R2CoreTransportationAndLoadNotificationMClassTurnsManagement.IsTerraficCardTypeforTurnRegistering(YourTerraficCard) Then
                Throw New ViewCarTruckTurnsTerraficCardNotSupportException
            End If
            Dim NSSTruck = InstanceTrucks.GetNSSTruck(InstanceCars.GetnIdCarFromCardId(YourTerraficCard.CardId))
            UCViewCollection(NSSTruck.NSSCar)
        Catch ex As ViewCarTruckTurnsTerraficCardNotSupportException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCollection(YourTruck As R2StandardCarStructure)
        Try
            Dim InstanceTurns = New R2CoreTransportationAndLoadNotificationInstanceTurnsManager
            Dim InstanceTrucks = New R2CoreTransportationAndLoadNotificationInstanceTrucksManager
            UCRefresh()
            _NSSTruck = YourTruck
            UcCarPresenter.UCViewCarInformation(_NSSTruck)
            UCViewCollection(InstanceTurns.GetTurns(InstanceTrucks.GetNSSTruck(_NSSTruck.nIdCar)))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub UCViewCollectionDelegate()
    Private Sub UCViewCollection()
        Try
            Dim UC As UCCarTruckNobat = New UCCarTruckNobat()
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

    Public Sub UCForceToReadTerraficCard()
        Try
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicRefresh_Click(sender As Object, e As EventArgs) Handles PicRefresh.Click
        Try
            UCViewCollection(_NSSTruck)
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

    Private Sub UCs_UCClickedEvent(UC As UCCarTruckNobat)
        Try
            RaiseEvent UCSelectedNSSChangedEvent(UC.UCGetNSS)
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

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            Dim NSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo)
            UCViewCollection(NSSTerraficCard)
            RaiseEvent _UCTerraficCardReadedEvent(NSSTerraficCard)
        Catch exx As ViewCarTruckTurnsTerraficCardNotSupportException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
    End Sub

#End Region




End Class
