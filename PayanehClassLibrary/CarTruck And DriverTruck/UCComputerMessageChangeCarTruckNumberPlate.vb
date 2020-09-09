
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.ProcessesManagement
Imports R2CoreGUI
Imports R2CoreGUI.ProcessesManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.Drivers

Public Class UCComputerMessageChangeCarTruckNumberPlate
    Inherits UCComputerMessage

    'Note Data1=PlateNumerString Note

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private WithEvents _Refrence As FrmcCarAndDriversInformation = Nothing
    Private Sub UcButtonChangeCarTruckNumberPlate_UCClickedEvent() Handles UcButtonChangeCarTruckNumberPlate.UCClickedEvent
        Try
            _Refrence = CType(R2CoreGUIMClassProcessesManagement.OpenProccess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcCarAndDriversInformation),R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS), FrmcCarAndDriversInformation)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _Refrence__RelationCompleted() Handles _Refrence._RelationCompleted
        Try
            UCDeactiveComputerMessage()
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
