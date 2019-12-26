
Imports System.Reflection
Imports R2Core.HumanResourcesManagement.Personnel

Public Class UCPersonnelPresenter
    Inherits UCGeneral

    Private _CurrentNSS As R2CoreStandardPersonnelStructure = Nothing
    Public Event UCClickedEvent(NSSPersonnel As R2CoreStandardPersonnelStructure)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub UCRefresh()
        UcLabelNameFamily.UCRefresh()
        UcPersonnelImage.UCRefresh()
    End Sub

    Public Sub UCViewPersonnel(YourNSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            _CurrentNSS = YourNSSPersonnel
            UcLabelNameFamily.UCValue = YourNSSPersonnel.PNameFamily.Trim()
            UcPersonnelImage.UCViewPersonnelImage(YourNSSPersonnel)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersonnelImage_UCClickedEvent(PersonnelNSS As R2CoreStandardPersonnelStructure) Handles UcPersonnelImage.UCClickedEvent
        Try
            RaiseEvent UCClickedEvent(_CurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcLabelNameFamily_UCClickedEvent() Handles UcLabelNameFamily.UCClickedEvent
        Try
            RaiseEvent UCClickedEvent(_CurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
