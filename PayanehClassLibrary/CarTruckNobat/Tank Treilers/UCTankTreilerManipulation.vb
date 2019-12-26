
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports R2CoreGUI

Public Class UCTankTreilerManipulation
    Inherits UCGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public Sub New ()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcViewerTankTreiler.UCRefresh()
    End Sub

    Public Sub UCViewStatus(YourNSS As R2StandardCarTruckStructure)
        Try
            UcViewerTankTreiler.UCViewTankTreilerStatus(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

  

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonChangeStatus_UCClickedEvent() Handles UcButtonChangeStatus.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckNobatManagement.ChangeCarTruckTankTreilerStatus(UcViewerTankTreiler.UCNSSCurrentCarTruck)
            UcViewerTankTreiler.UCViewTankTreilerStatus(UcViewerTankTreiler.UCNSSCurrentCarTruck)
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
