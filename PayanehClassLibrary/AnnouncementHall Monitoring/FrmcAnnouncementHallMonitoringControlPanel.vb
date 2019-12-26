
Imports System.Reflection
Imports System.Windows.Forms
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.ExceptionManagement
Imports R2Core.ProcessesManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class FrmcAnnouncementHallMonitoringControlPanel
    Inherits FrmcGeneral



    

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefresh()
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcAnnouncementHallMonitoringControlPanel))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        
    End Sub

 


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
   Private Sub BtnPersianTextMessageSetting_Click(sender As Object, e As EventArgs) Handles BtnPersianTextMessageSetting.Click
        PnlPersianTextMessageSetting.BringToFront()
        PnlPersianTextMessageSetting.Focus()
    End Sub






#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class