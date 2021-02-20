
Imports System.Reflection

Imports R2Core.DesktopProcessesManagement
Imports R2Core.AuthenticationManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI.ProcessesManagement

Public Class UCProcess
    Inherits UCGeneral

    Private _NSS As R2StandardDesktopProcessStructure = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(YourNSS As R2StandardDesktopProcessStructure, YourColor As Color)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _NSS = YourNSS
            GLabel.Text = YourNSS.PDisplayTitle.Trim 
            'GLabel.ForeColor  = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            GLabel.ForeColor = Color.Black 
            GLabel.GlowColor=YourColor
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub GLabel_Click(sender As Object, e As EventArgs) Handles GLabel.Click
        Try
            R2CoreGUIMClassProcessesManagement.OpenProccess(_NSS,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub
End Class
