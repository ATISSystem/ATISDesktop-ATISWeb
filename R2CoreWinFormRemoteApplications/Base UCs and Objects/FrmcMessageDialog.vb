

Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreWinFormRemoteApplications.ConfigurationManagement
Imports R2CoreWinFormRemoteApplications.PublicProc
Imports R2CoreWinFormRemoteApplications.DateTimeManagement

Public Class FrmcMessageDialog

    Private WithEvents FrmTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer


#Region "General Properties"
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
            FrmTimer.Interval = R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(0)
            Me.Visible = False
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub ViewDialogMessage(YourDialogColorType As DialogColorType, ByVal YourMessage As String, ByVal YourHint As String, ByVal YourMessageType As MessageType, ByRef YourMessageImage As Bitmap, ByVal Sender As Object, ForceToDisappearMessage As Boolean)
        Try
            'MessageBox.Show(Sender.ToString)
            LblMessage.Text = YourMessage
            If Not (YourMessageImage Is Nothing) Then
                PicMessageImage.Image = YourMessageImage
            Else
                PicMessageImage.Image = My.Resources.CatchAllTheErrors
                '    PicMessageImage.BackColor = Color.DarkOrange
            End If

            LblHint.Text = YourHint
            If YourMessageType = MessageType.PersianMessage Then
                LblMessage.Font = New System.Drawing.Font("B Homa", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                LblHint.Font = New System.Drawing.Font("B Homa", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            ElseIf YourMessageType = MessageType.ErrorMessage Then
                LblMessage.Font = New System.Drawing.Font("B Homa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
                LblHint.Font = New System.Drawing.Font("B Homa", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            End If

            If ForceToDisappearMessage Then
                FrmTimer.Enabled = True
                FrmTimer.Start()
            End If

            LblMessage.BackColor = GetColor(YourDialogColorType)
            LblHint.BackColor = GetColor(YourDialogColorType)
            LblHint.ForeColor = R2CoreWinFormRemoteApplicationsMclassPublicProcManagement.GetInvertColor(LblHint.BackColor)
            LblMessage.ForeColor = R2CoreWinFormRemoteApplicationsMclassPublicProcManagement.GetInvertColor(LblMessage.BackColor)
            Me.Visible = True
            Me.BringToFront()
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(Me, "FrmcMessageDialog.ViewDialogMessage" + vbCrLf + ex.Message, "بروز خطا در واسط اعلام و اطلاع رسانی ")
        End Try
    End Sub

    Private Function GetColor(YourDialogColorType As DialogColorType) As Color
        Try
            Select Case YourDialogColorType
                Case DialogColorType.ErrorType
                    Return Color.FromName(R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(1))
                Case DialogColorType.ErrorInDataEntry
                    Return Color.FromName(R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(2))
                Case DialogColorType.Warning
                    Return Color.FromName(R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(3))
                Case DialogColorType.SuccessProccess
                    Return Color.FromName(R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(4))
                Case DialogColorType.Information
                    Return Color.FromName(R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetFrmcDialogMessageConfigValue(5))
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

    Private Sub PicMessageImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMessageImage.Click
        Me.Visible = False
        Me.Hide()
    End Sub

    Private _ContinueStop As Boolean = True
    Private Sub LblContinueStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblContinueStop.Click
        If _ContinueStop = True Then
            _ContinueStop = False
            FrmTimer.Stop()
        Else
            _ContinueStop = True
            FrmTimer.Start()
        End If

    End Sub

    Private Sub FrmcMessageDialog_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.BringToFront()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class