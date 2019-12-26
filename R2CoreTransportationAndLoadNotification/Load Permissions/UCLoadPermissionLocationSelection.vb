
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadPermission

Public Class UCLoadPermissionLocationSelection
    Inherits UCGeneral

    Public Event UCSelectionChangedEvent(SelectedLoadPermissionLocation As R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function UCCurrentSelection() As R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation
        Try
            If RBAnnouncementHall.Checked = True Then
                Return R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall
            ElseIf RBTransportCompany.Checked = True Then
                Return R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Function



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub RBs_CheckedChanged(sender As Object, e As EventArgs) Handles RBAnnouncementHall.CheckedChanged, RBTransportCompany.CheckedChanged
        Try
            If RBAnnouncementHall.Checked = True Then
                RaiseEvent UCSelectionChangedEvent(R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.AnnouncementHall)
            ElseIf RBTransportCompany.Checked = True Then
                RaiseEvent UCSelectionChangedEvent(R2CoreTransportationAndLoadNotificationLoadPermissionRegisteringLocation.TransportCompany)
            End If
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
