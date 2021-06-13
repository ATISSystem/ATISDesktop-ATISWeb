
Imports System.Reflection

Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI

Public Class FrmcAnnouncedClearanceLoadsReport
    Inherits FrmcGeneral



#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefesh()

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassDesktopProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcClearanceLoadsReport))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


    Public Sub FrmRefesh()

    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcEnterExit__MenuRunRequestedEvent(UC As UCMenu) Handles Me._MenuRunRequestedEvent
        Try
            If UC.UCNSSMenu.MenuPanel = "PnlAnnouncedLoadsReport" Then
                PnlAnnouncedLoadsReport.BringToFront()
            ElseIf UC.UCNSSMenu.MenuPanel = "PnlClearanceLoadsReport" Then
                PnlClearanceLoadsReport.BringToFront()
            End If
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