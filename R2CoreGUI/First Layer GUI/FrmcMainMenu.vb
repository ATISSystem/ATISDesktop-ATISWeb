
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.UserManagement


Public Class FrmcMainMenu

    Private ReadOnly _FrmMessageDialog As New FrmcMessageDialog
    Public Event ExitIconPressed()



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Location = New Point(5, 5)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
            Me.Height = My.Computer.Screen.WorkingArea.Height - 10
            LblTopApplicationDomainPersianTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 1)
            LblTopApplicationDomainEnglishTiltle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 2)
            LblMiddleInnerApplicationDomainTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0)
            LblMiddleOuterApplicationDomainTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0)
            LblBottom0ApplicationDomainTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 0)
            LblBottom1ApplicationDomainTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 1)
            LblBottomSystemTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SystemDisplayTitle, 0)
            LblBottomSystemPersianTitle.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.SystemDisplayTitle, 1)
            PnlTop.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            PnlTop.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlMiddle.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlMiddle1.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlMiddle2.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlMiddle3.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlMiddle4.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 6))
            PnlR2.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            PnlR2.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlBottom.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            PnlBottom.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))

            PnlToolBoxBig.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlToolBoxBig.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlToolBoxSmall.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            PnlToolBoxSmall.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))

            LblApplicationDomainAbbreviationInner.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 3)
            LblApplicationDomainAbbreviationOuter.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 3)
            LblApplicationDomainAbbreviationOuter.ForeColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            Me.Text = R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.ApplicationDomainDisplayTitle, 3)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub UcUserLogin_UCUserAuthenticationSuccessEvent(NSSUser As R2CoreStandardUserStructure) Handles UcUserLogin.UCUserAuthenticationSuccessEvent
        Try
            UcUserImage.UCSetUserImage(NSSUser)
            PnlUserLogin.Visible = False
            UcUserLogin.Visible = False
            UcucProcessGroupCollection.UCViewProcessGroups()
            UcucProcessGroupCollection.Visible = True
            UcCollectionofUCActiveForm.Visible = True
            PnlToolBoxBig.Visible = True
            PnlToolBoxSmall.Visible = True
            UcUserImage.Visible = True
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub picexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picexit.Click
        RaiseEvent ExitIconPressed()
    End Sub

    Private Sub PicMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    









#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class