

Imports System.Drawing
Imports System.Reflection

Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadTargets


Public Class UCSearcherLoadTargets
    Inherits UCSearcherAdvance

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
           
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCSearcherLoadTargets_UCIconClicked() Handles Me.UCIconRefreshRequestClicked
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UCSearcherLoadTargets_UCSearchOptional1RequestEvent(SearchString As String) Handles Me.UCSearchOptional1RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetLoadTargets_SearchforLeftCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.NSSCity.nCityCode,X.NSSCity.StrCityName)).ToList())
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UCSearcherLoadTargets_UCSearchOptional2RequestEvent(SearchString As String) Handles Me.UCSearchOptional2RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMclassLoadTargetsManagement.GetLoadTargets_SearchIntroCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.NSSCity.nCityCode,X.NSSCity.StrCityName)).ToList())
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
