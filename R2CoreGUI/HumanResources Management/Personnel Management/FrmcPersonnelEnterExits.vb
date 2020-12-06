
Imports System.Reflection

Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.ProcessesManagement

Public Class FrmcPersonnelEnterExits
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
            UcucPersonnelCollection.UCViewPersonnelsByUCPersonnelPresenter(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(R2CoreProcesses.FrmcPersonnelEnterExits))
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

    Private Sub UcucPersonnelCollection_UCSelected(NSSPersonnel As R2CoreStandardPersonnelStructure) Handles UcucPersonnelCollection.UCSelected
        Try
            UcPersonnelImage.UCViewPersonnelImage(NSSPersonnel,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            UcListBoxPersonnelEnterExit.UCViewPersonnelEnterExit(NSSPersonnel)
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