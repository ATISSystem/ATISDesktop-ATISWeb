

Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.Rmto


Public Class UCCarTruckUpdateInf
    Inherits UCGeneral

    Public Event UCViewCarTruckInformationCompletedEvent(CarId As String)
    Public Event UCUserCanceledEvent



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
            UcCartruck.UCRefreshGeneral()
            UcButtonSpecialConfirm.UCEnable=False
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

    Private Sub UcCarTruck_UCViewCarTruckInformationCompleted(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompleted
        Try
            UcButtonSpecialConfirm.UCEnable = True
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSpecialConfirm_UCClickedEvent() Handles UcButtonSpecialConfirm.UCClickedEvent
        Try
            UcButtonSpecialConfirm.UCEnable=False
            RaiseEvent UCViewCarTruckInformationCompletedevent(UcCarTruck.UCGetNSS.NSSCar.nIdCar)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub UcButtonSpecialCancel_UCClickedEvent() Handles UcButtonSpecialCancel.UCClickedEvent
        Try
            RaiseEvent UCUserCanceledEvent
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
