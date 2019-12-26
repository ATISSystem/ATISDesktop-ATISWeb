
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadPermission


Public Class UCViewerNSSLoadPermissionStatus
    Inherits UCLoadPermissionStatus

    Public Event UCClickedEvent(UC As UCViewerNSSLoadPermissionStatus)

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
    Private Sub UcLabel_TextChanged(sender As Object, e As EventArgs) Handles UcLabel.TextChanged
        Me.Size = New Size(TextRenderer.MeasureText(UcLabel.Text, UcLabel.UCFont).Width + 20, Me.Height)
    End Sub

    Private Sub UcLabel_UCClickedEvent() Handles UcLabel.UCClickedEvent
        Try
            UCChangeBackColor(Color.FromName(UCNSSCurrent.LoadPermissionStatusColor))
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadPermissionStatus_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure) Handles Me.UCViewNSSRequested
        Try
            UcLabel.UCValue = UCNSSCurrent.LoadPermissionStatusTitle
            UCChangeBackColor(Color.FromName(UCNSSCurrent.LoadPermissionStatusColor))
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
