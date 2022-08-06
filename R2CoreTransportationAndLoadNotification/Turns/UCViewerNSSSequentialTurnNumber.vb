

Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.Turns

Public Class UCViewerNSSSequentialTurnNumber
    Inherits UCTurn

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shadows Sub UCRefreshGeneral()
        UcPersianTextBoxSequentialTurnNumber.UCRefreshGeneral()
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCViewerNSSSequentialTurnNumber_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTurnStructure) Handles Me.UCViewNSSRequested
        Try
            UcPersianTextBoxSequentialTurnNumber.UCValue = NSSCurrent.OtaghdarTurnNumber.Trim
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
