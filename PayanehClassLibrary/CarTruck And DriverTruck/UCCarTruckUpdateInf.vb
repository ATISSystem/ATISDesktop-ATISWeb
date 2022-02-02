

Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports PayanehClassLibrary.CarTrucksManagement
Imports R2CoreTransportationAndLoadNotification.Rmto


Public Class UCCarTruckUpdateInf
    Inherits UCGeneral

    Public Event UCViewCarTruckInformationCompletedEvent(CarId As String)
    Public Event UCViewCarTruckInformationNotCompletedEvent(Message As String)



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRefresh()
        Try
            UcCarTruck.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcCarTruck_UCViewCarTruckInformationCompletedEvent(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompletedEvent
        Try
            RaiseEvent UCViewCarTruckInformationCompletedEvent(CarId)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCCarTruckUpdateInf_UCGotFocusedEvent() Handles Me.UCGotFocusedEvent
        Try
            UcCarTruck.UCFocus()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCarTruck_UCViewCarTruckInformationNotCompletedEvent(Message As String) Handles UcCarTruck.UCViewCarTruckInformationNotCompletedEvent
        Try
            RaiseEvent UCViewCarTruckInformationNotCompletedEvent(Message)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub







#End Region

#Region "Override Methods"

#End Region

#Region "Abstract Methods"
#End Region


End Class
