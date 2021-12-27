
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns

Public Class UCLstViewerAllOfnEnterExitId
    Inherits UCGeneral

    Public Event UCSelectedValueChanged(Value As String)


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

    Private Sub UCRefresh()

    End Sub

    Private Sub UCViewInf()
        Try
            LstViewerAllOfnEnterExitId.Items.Clear()
            Dim Lst As List(Of String) = PayanehClassLibraryMClassCarTruckNobatManagement.GetListOfAllnEnterExitId(UcucSequentialTurnCollection.UCCurrentNSS)
            For Each S As String In Lst
                LstViewerAllOfnEnterExitId.Items.Add(S)
            Next
        Catch exx As GetDataException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetSelectedSequentialTurnNumber() As String
        Try
            If LstViewerAllOfnEnterExitId.SelectedIndex >= 0 Then
                Return Split(LstViewerAllOfnEnterExitId.Items(LstViewerAllOfnEnterExitId.SelectedIndex), "-")(0).Trim
            Else
                Throw New Exception("شماره اعتبار را انتخاب نمایید")
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetSelectedTargetYear() As String
        Try
            If LstViewerAllOfnEnterExitId.SelectedIndex >= 0 Then
                Return Mid(Split(LstViewerAllOfnEnterExitId.Items(LstViewerAllOfnEnterExitId.SelectedIndex), "-")(1).Trim, 1, 4)
            Else
                Throw New Exception("شماره اعتبار را انتخاب نمایید")
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetCurrentNSSSequentialTurn() As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure
        Try
            Return UcucSequentialTurnCollection.UCCurrentNSS
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub LstViewerAllOfnEnterExitId_SelectedValueChanged(sender As Object, e As EventArgs) Handles LstViewerAllOfnEnterExitId.SelectedValueChanged
        RaiseEvent UCSelectedValueChanged(LstViewerAllOfnEnterExitId.Items(LstViewerAllOfnEnterExitId.SelectedIndex))
    End Sub

    Private Sub UcucSequentialTurnCollection_UCCurrentNSSChangedEvent() Handles UcucSequentialTurnCollection.UCCurrentNSSChangedEvent
        Try
            UCViewInf()
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
