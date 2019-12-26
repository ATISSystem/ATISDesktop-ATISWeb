
Imports System.Reflection

Imports R2Core.ComputersManagement

Public Class UCConfigurationOfComputer
    Inherits UCConfigurationSetting

#Region "General Properties"

    Public ReadOnly Property UCCurrentNSS As R2CoreStandardConfigurationOfComputerStructure = Nothing

#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(YourNSS As R2CoreStandardConfigurationOfComputerStructure)

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


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub UCConfigurationOfComputers_UCUserConfigChangeRequestedEvent(Config As String) Handles Me.UCUserConfigChangeRequestedEvent
        Try
            UCCurrentNSS.CValue = Config
            R2CoreMClassConfigurationOfComputersManagement.SetConfigurationOfComputer(UCCurrentNSS)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "تغییرات با موفقیت در فایل پیکربندی ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
