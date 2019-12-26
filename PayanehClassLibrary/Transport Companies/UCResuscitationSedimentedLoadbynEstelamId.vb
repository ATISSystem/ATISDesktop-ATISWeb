
Imports System.Reflection

Imports R2CoreGUI

Public Class UCResuscitationSedimentedLoadbynEstelamId
    Inherits UCGeneral




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


    Private Sub UcButtonResuscitation_UCClickedEvent() Handles UcButtonResuscitation.UCClickedEvent
        Try
            PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.ResuscitationSedimentedLoadbynEstelamId(UcNumbernEstelamId.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "احیاء بار رسوب شده انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch exx As PayanehClassLibrary.LoadNotification.LoadPermission.ResuscitationSedimentedLoadException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, exx.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumbernEstelamId_UC13Pressed(UserNumber As String) Handles UcNumbernEstelamId.UC13Pressed
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
