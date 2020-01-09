

Imports System.Reflection
Imports System.ComponentModel

Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.PublicProc

Public Class FrmcMessageDialog

    Private WithEvents _BackGroundWorker As BackgroundWorker

#Region "General Properties"

    Private Property _DialogColorType As DialogColorType = DialogColorType.None
    Private Property _Message As String = String.Empty
    Private Property _Hint As String = String.Empty
    Private Property _MessageType As MessageType = MessageType.ErrorMessage
    Private Property _MessageImage As R2CoreImage = Nothing
    Private Property _Sender As Object = Nothing
    Private Property _ForceToDisappearMessage As Boolean = True

    Public Shared ReadOnly Property GetTimerInterval As Int64
        Get
            Try
                Return R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreConfigurations.FrmcDialogMessage, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) * 1000
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Enum MessageType
        PersianMessage = 1
        ErrorMessage = 2
    End Enum

    Public Enum DialogColorType
        None = 0
        ErrorType = 1
        ErrorInDataEntry = 2
        Warning = 3
        SuccessProccess = 4
        Information = 5
    End Enum

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
            _BackGroundWorker = New BackgroundWorker()
            '_BackGroundWorker.WorkerSupportsCancellation = True
            _BackGroundWorker.WorkerReportsProgress = True

            'FrmTimer.Interval = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreConfigurations.FrmcDialogMessage, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) * 1000
            If Me.DesignMode Then Me.TopMost = False Else Me.TopMost = True
            'Me.Visible = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub ViewDialogMessage(YourDialogColorType As DialogColorType, ByVal YourMessage As String, ByVal YourHint As String, ByVal YourMessageType As MessageType, ByRef YourMessageImage As R2CoreImage, ByVal YourSender As Object, Optional YourForceToDisappearMessage As Boolean = True)
        Try
            _DialogColorType = YourDialogColorType
            _Message = YourMessage
            _Hint = YourHint
            _MessageType = YourMessageType
            _MessageImage = YourMessageImage
            _Sender = YourSender
            _ForceToDisappearMessage = YourForceToDisappearMessage
            Visible = True
            Show()

            _BackGroundWorker.RunWorkerAsync()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetColor(YourDialogColorType As DialogColorType) As Color
        Try
            Select Case YourDialogColorType
                Case DialogColorType.ErrorType
                    Return Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, 1))
                Case DialogColorType.ErrorInDataEntry
                    Return Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, 2))
                Case DialogColorType.Warning
                    Return Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, 3))
                Case DialogColorType.SuccessProccess
                    Return Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, 4))
                Case DialogColorType.Information
                    Return Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FrmcDialogMessage, 5))
            End Select
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcMessageDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        _BackGroundWorker.Dispose()
    End Sub

    Private Sub LblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMessage.Click
        _ForceToDisappearMessage = False
    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub _BackGroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _BackGroundWorker.DoWork
        Try
            For i As Integer = 1 To 10
                If (_BackGroundWorker.CancellationPending) Then
                    e.Cancel = True
                    Exit For
                End If

                System.Threading.Thread.Sleep(1000)

                _BackGroundWorker.ReportProgress(i * 10)
            Next i


        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub _BackGroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _BackGroundWorker.ProgressChanged

    End Sub

    Private Sub _BackGroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _BackGroundWorker.RunWorkerCompleted
        Try

            'If Me.DesignMode Then _BackGroundWorker.CancelAsync()
            LblMessage.Text = _Message
            'If Not (_MessageImage Is Nothing) Then
            '    PictureBoxMessage.Image = _MessageImage.GetImage()
            'Else
            '    PictureBoxMessage.Image = Nothing
            'End If
            'Dim MasterColor As Color = GetColor(_DialogColorType)
            'PnlMain.Colors(1).Color = MasterColor
            'LblHint.Text = _Hint
            'If _MessageType = MessageType.PersianMessage Then
            '    LblMessage.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 6), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            '    LblHint.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 7), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            'ElseIf _MessageType = MessageType.ErrorMessage Then
            '    LblMessage.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 8), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            '    LblHint.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 9), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            'End If
            Visible = True
            Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Visible = True
        'Show()

        'Threading.Thread.Sleep(GetTimerInterval)
        'If _ForceToDisappearMessage Then
        '    Me.Visible = False
        '    Me.Hide()
        'End If

    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class