
Imports System.Drawing
Imports System.Reflection

Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.ConfigurationManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.LoadSources

Public Class UCSearcherLoadSources
    Inherits UCSearcherAdvance

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.UCViewNSS(R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement.GetNSSLoadSource(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreTransportationAndLoadNotificationConfigurations.DefaultTransportationAndLoadNotificationConfigs, 0)))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCSearcherLoadSources_UCIconClicked() Handles Me.UCIconRefreshRequestClicked
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UCSearcherLoadSources_UCSearchOptional1RequestEvent(SearchString As String) Handles Me.UCSearchOptional1RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement.GetLoadSources_SearchforLeftCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.NSSCity.nCityCode, X.NSSCity.StrCityName)).ToList())
        Catch ex As SqlInjectionException
            Throw ex
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UCSearcherLoadSources_UCSearchOptional2RequestEvent(SearchString As String) Handles Me.UCSearchOptional2RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement.GetLoadSources_SearchIntroCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.NSSCity.nCityCode, X.NSSCity.StrCityName)).ToList())
        Catch ex As SqlInjectionException
            Throw ex
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
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
