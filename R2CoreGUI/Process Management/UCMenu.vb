
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DesktopProcessesManagement

Public Class UCMenu
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCMenu)

#Region "General Properties"

    Public ReadOnly Property UCNSSMenu As R2StandardMenuStructure = Nothing


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(YourNSSMenu As R2StandardMenuStructure)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCNSSMenu = YourNSSMenu
            CButton.Text = YourNSSMenu.MenuTitle
            CButton.BorderColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 5))
            CButton.ForeColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 5))
            Me.Size = New Size(TextRenderer.MeasureText(YourNSSMenu.MenuTitle.Trim, CButton.Font).Width + 20, Me.Height)
            CButton.ColorFillBlend.iColor(0) = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
            CButton.ColorFillBlend.iColor(1) = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
            PnlInner.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 4))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            RaiseEvent UCClickedEvent(Me)
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
