

Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.PublicProc

Public Class FrmcMessageDialog

    Private WithEvents FrmTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer


#Region "General Properties"

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
            FrmTimer.Interval = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt32(R2CoreConfigurations.FrmcDialogMessage, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) * 1000
            If Me.DesignMode Then Me.TopMost = True Else Me.TopMost = False
            Me.Visible = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub ViewDialogMessage(YourDialogColorType As DialogColorType, ByVal YourMessage As String, ByVal YourHint As String, ByVal YourMessageType As MessageType, ByRef YourMessageImage As R2CoreImage, ByVal Sender As Object, Optional ForceToDisappearMessage As Boolean = True)
        Try
            If Me.DesignMode Then Exit Sub
            Dim MasterColor As Color = GetColor(YourDialogColorType)
            ''LblMessage.Text = Split(YourMessage, vbCrLf)(Split(YourMessage, vbCrLf).Length - 1)
            ''LblMessage.Text = Split(YourMessage, ControlChars.CrLf)(Split(YourMessage, ControlChars.CrLf).Length - 1)
            LblMessage.Text = YourMessage
            If Not (YourMessageImage Is Nothing) Then
                PictureBoxMessage.Image = YourMessageImage.GetImage()
            Else
                PictureBoxMessage.Image = Nothing
            End If

            PnlMain.Colors(1).Color = MasterColor

            LblHint.Text = YourHint
            If YourMessageType = MessageType.PersianMessage Then
                LblMessage.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 6), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                LblHint.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 7), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            ElseIf YourMessageType = MessageType.ErrorMessage Then
                LblMessage.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 8), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                LblHint.Font = New System.Drawing.Font("B Homa", R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.FrmcDialogMessage, 9), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            End If
            If ForceToDisappearMessage Then
                FrmTimer.Enabled = True
                FrmTimer.Start()
            End If
            Me.Visible = True
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(Me, "FrmcMessageDialog.ViewDialogMessage" + vbCrLf + ex.Message, "بروز خطا در واسط اعلان و اطلاع رسانی - فضا نام اطلاع رسانی")
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

    Private Sub FrmTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FrmTimer.Tick
        FrmTimer.Stop()
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub FrmcMessageDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FrmTimer.Dispose()
    End Sub

    Private Sub LblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMessage.Click
        FrmTimer.Stop()
    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        Me.Visible = False
        Me.Hide()
    End Sub















#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class