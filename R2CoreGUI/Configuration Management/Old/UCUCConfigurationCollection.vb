

Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2Core.DatabaseManagement
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.UserManagement
Imports R2CoreGUI

Public Class UCUCConfigurationCollection
    Inherits R2CoreGUI.UCGeneral

    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreStandardConfigurationStructure)
    Public Event UCViewCollectionCompeletedEvent()


#Region "General Properties"

    Private Property UCTotalNumberOfRecordstoView As Int32 = 500

    Private _UCTitle As String = String.Empty
    Public Property UCTitle As String
        Get
            Return _UCTitle
        End Get
        Set(value As String)
            _UCTitle = value
            UcLabelTop.UCValue = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        Try
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2CoreStandardConfigurationStructure)
    Private _Counting As Int64
    Private _Counter As Int64
    Private Sub UCViewCollection(YourCollection As List(Of R2CoreStandardConfigurationStructure))
        Try
            UCRefresh()
            Lst = YourCollection
            If Lst.Count < 1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If
            _Counting = Lst.Count
            _Counter = Lst.Count - 1

            _TTimer = New Timer()
            _TTimer.Interval = 1
            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Delegate Sub UCViewCollectionDelegate()
    Private Sub UCViewCollection()
        Try
            Dim UC As UCConfigurationSetting = New UCConfigurationSetting(Lst(_Counter))
            UC.Dock = DockStyle.Top
            AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
            If PnlUCs.InvokeRequired Then
                PnlUCs.Invoke(New UCViewCollectionDelegate(AddressOf UCViewCollection))
            Else
                PnlUCs.Controls.Add(UC)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewConfigurations()
        Try
            UCViewCollection(R2CoreMClassConfigurationManagement.GetConfigurations())
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _TTimer_Tick(sender As Object, e As EventArgs) Handles _TTimer.Tick
        Try
            _TTimer.Enabled = False
            _TTimer.Stop()

            UCViewCollection()

            _Counter = _Counter - 1
            If _Counter = -1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If

            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCs_UCClickedEvent(UC As UCConfigurationSetting)
        Try
            RaiseEvent UCSelectedNSSChangedEvent(UC.UCCurrentNSS)
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
