
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.ConfigurationManagement

Public Class UCConfigurationsOfCore
    Inherits UCConfiguration

#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            FillConfigurationObjects()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub FillConfigurationObjects()
        Try
            UcPersianTextBoxRFIDCardNotConfirmMessage.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.RFIDCardNotConfirmMessage, 0)
            UcTextBoxInvalidRFIDCards.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.InvalidRFIDCards, 0)
            PnlFirstPageC1.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            PnlFirstPageC0.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlFirstPageForeColor.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 2))
            PnlFrmcGeneralC1.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 3))
            PnlFrmcGeneralC0.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
            PnlFrmcGeneralForeColor.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 5))
            PnlMiddlesBackColor.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlMiddlesForeColor.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 7))
            UcPersianTextBoxApplicationDomainTitlePersian.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 1)
            UcTextBoxApplicationDomainTitleEnglish.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 2)
            UcPersianTextBoxApplicationDomainLocationTitle.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0)
            UcTextBoxUCProcessGroupWidth.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.UCProcessGroup, 1)
            UcTextBoxUCProcessGroupHigth.UCValue = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.UCProcessGroup, 2)
            PnlUCProcessGroupForeColor.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.UCProcessGroup, 3))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCConfigurationsOfCore_UCChangeRegisteringRequestedEvent() Handles Me.UCChangeRegisteringRequestedEvent
        Try
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.RFIDCardNotConfirmMessage, 0, UcPersianTextBoxRFIDCardNotConfirmMessage.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.InvalidRFIDCards, 0, UcTextBoxInvalidRFIDCards.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 0, PnlFirstPageC1.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 1, PnlFirstPageC0.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 2, PnlFirstPageForeColor.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 3, PnlFrmcGeneralC1.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 4, PnlFrmcGeneralC0.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 5, PnlFrmcGeneralForeColor.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 6, PnlMiddlesBackColor.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.FirstPageColor, 7, PnlMiddlesForeColor.BackColor.Name)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0, UcPersianTextBoxApplicationDomainLocationTitle.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.ApplicationDomainDisplayTitle, 1, UcPersianTextBoxApplicationDomainTitlePersian.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.ApplicationDomainDisplayTitle, 2, UcTextBoxApplicationDomainTitleEnglish.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.UCProcessGroup, 1, UcTextBoxUCProcessGroupWidth.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.UCProcessGroup, 2, UcTextBoxUCProcessGroupHigth.UCValue)
            R2CoreMClassConfigurationManagement.SetConfiguration(R2CoreConfigurations.UCProcessGroup, 3, PnlUCProcessGroupForeColor.BackColor.Name)
            UCRaiseChangeConfigurationCompletedMessage()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private ReadOnly ColorD As New ColorDialog
    Private Sub PnlFirstPageC1_Click(sender As Object, e As EventArgs) Handles PnlFirstPageC1.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFirstPageC1.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlFirstPageC0_Click(sender As Object, e As EventArgs) Handles PnlFirstPageC0.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFirstPageC0.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlFirstPageForeColor_Click(sender As Object, e As EventArgs) Handles PnlFirstPageForeColor.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFirstPageForeColor.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlFrmcGeneralC0_Click(sender As Object, e As EventArgs) Handles PnlFrmcGeneralC0.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFrmcGeneralC0.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlFrmcGeneralC1_Click(sender As Object, e As EventArgs) Handles PnlFrmcGeneralC1.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFrmcGeneralC1.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlFrmcGeneralForeColor_Click(sender As Object, e As EventArgs) Handles PnlFrmcGeneralForeColor.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlFrmcGeneralForeColor.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlMiddlesBackColor_Click(sender As Object, e As EventArgs) Handles PnlMiddlesBackColor.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlMiddlesBackColor.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlMiddlesForeColor_Click(sender As Object, e As EventArgs) Handles PnlMiddlesForeColor.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlMiddlesForeColor.BackColor = ColorD.Color
        End If
    End Sub

    Private Sub PnlUCProcessGroupForeColor_Click(sender As Object, e As EventArgs) Handles PnlUCProcessGroupForeColor.Click
        If ColorD.ShowDialog() = DialogResult.OK Then
            PnlUCProcessGroupForeColor.BackColor = ColorD.Color
        End If
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
