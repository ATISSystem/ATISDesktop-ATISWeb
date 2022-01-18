
Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2Core.LoggingManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Logging
Imports R2CoreParkingSystem.ProcessesManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class FrmcCarEntryExitLogViewer
    Inherits FrmcLogsViewer


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(R2CoreParkingSystemProcesses.FrmcCarEntryExitLogViewer))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcCarEntryExitLogViewer__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            Dim InstanceTrafficCards = New R2CoreParkingSystemInstanceTrafficCardsManager
            Dim InstanceLog = New R2CoreParkingSystemLogManager
            ViewLogs(InstanceLog.GetEntryExitLogsWithTrafficCard(InstanceTrafficCards.GetNSSTrafficCard(CardNo)).Cast(Of R2CoreStandardLoggingStructure)().ToList())
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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