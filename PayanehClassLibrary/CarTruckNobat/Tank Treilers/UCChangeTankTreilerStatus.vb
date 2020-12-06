
Imports System.Reflection

Imports PayanehClassLibrary.CarTrucksManagement
Imports R2CoreGUI

Public Class UCChangeTankTreilerStatus
    Inherits UCGeneral

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public Sub New ()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcCarTruck_UCViewCarTruckInformationCompletedEvent(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompletedEvent
        Try
            UcTankTreilerManipulation.UCViewStatus(PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyCarId(carid))
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
