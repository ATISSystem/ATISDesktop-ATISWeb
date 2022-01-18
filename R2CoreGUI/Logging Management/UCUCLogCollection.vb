
Imports System.Reflection

Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement

Public Class UCUCLogCollection
    Inherits UCGeneral


    Public Event UCViewCollectionCompeletedEvent()

#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        PnlUCs.SuspendLayout()
        PnlUCs.Controls.Clear()
        PnlUCs.ResumeLayout()
    End Sub

    Private Function UCCreateUCLog(YourNSSLog As R2CoreStandardLoggingStructure) As UCLog
        Try
            Dim InstanceLogging = New R2CoreInstanceLoggingManager
            Dim NSSLogType = InstanceLogging.GetNSSLogType(YourNSSLog.LogType)
            Dim Assembly_ As Assembly = Assembly.LoadFrom(NSSLogType.AssemblyDll)
            Dim ObjectInstanceType = Assembly_.GetType(NSSLogType.AssemblyPath)
            Dim objUC As UCLog = CType(Activator.CreateInstance(ObjectInstanceType), UCLog)
            objUC.UCViewLog(YourNSSLog)
            Return objUC
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private Lst As List(Of R2CoreStandardLoggingStructure)
    Private _Counting As Int64
    Private _Counter As Int64
    Private Sub UCViewCollection(YourCollection As List(Of R2CoreStandardLoggingStructure))
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
            Dim UC As UCLog = UCCreateUCLog(Lst(_Counter))
            UC.Dock = DockStyle.Top
            If PnlUCs.InvokeRequired Then
                PnlUCs.Invoke(New UCViewCollectionDelegate(AddressOf UCViewCollection))
            Else
                PnlUCs.Controls.Add(UC)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewLogs(YourLogs As List(Of R2CoreStandardLoggingStructure))
        Try
            If YourLogs Is Nothing Then Exit Sub
            UCViewCollection(YourLogs)
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

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
