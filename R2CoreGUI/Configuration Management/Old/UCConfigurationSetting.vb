
Imports System.Reflection

Imports R2Core.ConfigurationManagement


Public Class UCConfigurationSetting
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCConfigurationSetting)
    Public Event UCUserConfigChangeRequestedEvent(Config As String)

#Region "General Properties"

    Public ReadOnly Property UCCurrentNSS As R2CoreStandardConfigurationStructure = Nothing


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(YourNSS As R2CoreStandardConfigurationStructure)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCCurrentNSS = YourNSS
            UCViewInf(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Sub UCViewInf(YourNSS As R2CoreStandardConfigurationStructure)
        Try
            LabelCId.Text = YourNSS.CId
            LabelCName.Text = YourNSS.CName
            TextBoxCValue.Text = YourNSS.CValue
            LabelOrientation.Text = YourNSS.Orientation
            LabelDescription.Text = YourNSS.Description
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

    Protected Sub Ucs_UCClickedEvent(sender As Object, e As EventArgs) Handles LabelCId.Click, LabelCName.Click, LabelDescription.Click, LabelOrientation.Click
        Dim SenderLabel As Label = sender
        MessageBox.Show(SenderLabel.Text)
        RaiseEvent UCClickedEvent(Me)
    End Sub

    Private Sub TextBoxCValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCValue.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                e.Handled = True
                If Not (UCCurrentNSS Is Nothing) Then
                    UCCurrentNSS.CValue = TextBoxCValue.Text.Trim
                    R2CoreMClassConfigurationManagement.SetConfiguration(UCCurrentNSS)
                    UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تغییرات با موفقیت در فایل پیکربندی ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Else
                    RaiseEvent UCUserConfigChangeRequestedEvent(TextBoxCValue.Text.Trim)
                End If
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
