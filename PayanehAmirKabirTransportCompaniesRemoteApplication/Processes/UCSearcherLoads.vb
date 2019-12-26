
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class UCSearcherLoads
    Inherits UCSearcher

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            ''If Not DesignMode Then UCFillListBox(TransportCompaniesLoadCapacitorLoadsManipulation.GetLoads(""))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCSearcherLoads_UCIconClicked() Handles Me.UCIconClicked
        Try
            TransportCompaniesLoadCapacitorLoadsManipulation.FillLoads()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UCSearcherLoads_UCSearchRequestEvent(SearchString As String) Handles Me.UCSearchRequestEvent
        Try
            UCFillListBox(TransportCompaniesLoadCapacitorLoadsManipulation.GetLoads(SearchString))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
