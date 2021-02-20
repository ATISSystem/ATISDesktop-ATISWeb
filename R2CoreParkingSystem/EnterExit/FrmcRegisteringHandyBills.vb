
Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ProcessesManagement

Public Class FrmcRegisteringHandyBills
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefesh()
    End Sub

    Public sub FrmRefesh
        UcRegisteringHandyBills.UCRefresh()
    End sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess( R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcRegisteringHandyBills))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

 
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class