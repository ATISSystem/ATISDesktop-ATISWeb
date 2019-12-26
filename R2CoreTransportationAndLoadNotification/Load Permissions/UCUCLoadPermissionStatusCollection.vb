
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadPermission


Public Class UCUCLoadPermissionStatusCollection
    Inherits UCGeneral

    Public Event UCCurrentNSSChangedEvent()

#Region "General Properties"

    Private _UCCurrentNSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure = Nothing
    <Browsable(False)>
    Public Property UCCurrentNSS() As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(value As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure)
            _UCCurrentNSS = value
            If value IsNot Nothing Then RaiseEvent UCCurrentNSSChangedEvent()
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewCollection()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCViewCollection()
        Try
            Dim Lst As List(Of R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure) = R2CoreTransportationAndLoadNotificationMClassLoadPermissionManagement.GetLoadPermissionStatuses()
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim UC As New UCViewerNSSLoadPermissionStatus
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Right
                AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCActiveThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure)
        Try
            UCCurrentNSS = YourNSS
            For Each UC As UCViewerNSSLoadPermissionStatus In PnlUCs.Controls
                If UC.UCNSSCurrent.LoadPermissionStatusId <> YourNSS.LoadPermissionStatusId Then
                    UC.UCShowUnActive()
                Else
                    UC.UCShowActive()
                End If
            Next
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSimulateThisNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadPermissionStatusStructure)
        Try
            UCActiveThisNSS(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCs_UCClickedEvent(SenderUC As UCLoadPermissionStatus)
        Try
            UCActiveThisNSS(SenderUC.UCNSSCurrent)
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
