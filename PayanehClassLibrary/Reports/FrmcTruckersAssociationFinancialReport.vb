
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ProcessesManagement
Imports R2Core.RFIDCardsManagement
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreGUI
Imports PayanehClassLibrary.ProcessesManagement

Public Class FrmcTruckersAssociationFinancialReport
    Inherits FrmcGeneral



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(   R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcTruckersAssociationFinancialReport))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
        UcTruckersAssociationFinacialReport.UCRefresh()
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