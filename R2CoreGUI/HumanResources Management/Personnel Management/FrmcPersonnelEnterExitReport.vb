
Imports System.Reflection

Imports R2Core.DesktopProcessesManagement

Public Class FrmcPersonnelEnterExitReport
    Inherits FrmcGeneral



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public Sub New ()

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
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreDesktopProcesses.FrmcPersonnelEnterExitReport))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmRefresh()
        Try
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