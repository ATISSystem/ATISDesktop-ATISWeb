
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadPermission


Public Class UCViewerNSSLoadPermissionExtended
    Inherits UCLoadPermission

    Public Event UCClickedEvent(UC As UCLoadPermission)



    Private Const _MaxHight As Int64 = 407
    Private Const _MinHight As Int64 = 89


#Region "General Properties"



#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            LabelTransportCompanyTitle.Text = String.Empty
            LabelGoodTitle.Text = String.Empty
            LabelLoadTargetTitle.Text = String.Empty
            LabelTruck.Text = String.Empty
            LabelTruckDriver.Text = String.Empty
            LabelLoadPermissionStatus.Text = String.Empty
            LabelStrDescription.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefreshExtended()
        Try
            LabelUserName.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Labels_Click(sender As Object, e As EventArgs) Handles LabelTransportCompanyTitle.Click, LabelGoodTitle.Click, LabelLoadTargetTitle.Click, LabelTruck.Click, LabelTruckDriver.Click, LabelLoadPermissionStatus.Click, LabelStrDescription.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMaximizeRequestedEvent() Handles UcMinimizeMaximize.UCMaximizeRequestedEvent
        Try
            UCRefreshExtended()
            LabelUserName.Text = R2CoreMClassSoftwareUsersManagement.GetNSSUser(UCNSSCurrent.UserId).UserName
            Me.Size = New Size(Me.Width, _MaxHight)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMinimizeRequestedEvent() Handles UcMinimizeMaximize.UCMinimizeRequestedEvent
        Try
            Me.Size = New Size(Me.Width, _MinHight)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadPermissionExtended_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            Dim NSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionExtendedStructure = UCNSSCurrent
            LabelTransportCompanyTitle.Text = NSS.TransportCompanyTitle
            LabelGoodTitle.Text = NSS.GoodTitle
            LabelLoadTargetTitle.Text = NSS.LoadTargetTitle
            LabelTruck.Text = NSS.Truck
            LabelTruckDriver.Text = NSS.TruckDriver
            LabelLoadPermissionStatus.Text = NSS.LoadPermissionStatusTitle
            LabelStrDescription.Text = NSS.StrDescription
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PicDoPrintLoadPermission_Click(sender As Object, e As EventArgs) Handles PicDoPrintLoadPermission.Click
        Try
            UCDoPrintLoadPermission 
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
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
