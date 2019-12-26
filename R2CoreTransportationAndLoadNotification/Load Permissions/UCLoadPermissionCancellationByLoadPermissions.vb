
Imports System.Reflection
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadPermission

Public Class UCLoadPermissionCancellationByLoadPermissions
    Inherits UCGeneralExtended


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

    Private Sub UcucLoadPermissionCollectionAdvance_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStructure) Handles UcucLoadPermissionCollectionAdvance.UCSelectedNSSChangedEvent
        Try
            UcLoadPermissionCancellation.UCViewNSS(NSS)
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
