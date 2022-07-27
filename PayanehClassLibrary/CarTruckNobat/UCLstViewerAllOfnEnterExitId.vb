
Imports System.Reflection
Imports System.Windows.Forms

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns

Public Class UCLstViewerAllOfnEnterExitId
    Inherits UCGeneral

    Public Event UCSelectedValueChanged()


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
            Dim InstanceCarTruckNobat = New PayanehClassLibraryMClassCarTruckNobatManager
            LstViewerAllOfnEnterExitId.Items.Clear()
            Dim Lst = InstanceCarTruckNobat.GetAllofActiveTurns(UcucSequentialTurnCollection.UCCurrentNSS)
            For Each TurnDetails As PayanehClassLibraryTurnDetails In Lst
                Dim TurnItem = New TurnItem(TurnDetails)
                LstViewerAllOfnEnterExitId.Items.Add(TurnItem)
            Next
        Catch exx As GetDataException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetSelectedTurnId() As Int64
        Try
            If LstViewerAllOfnEnterExitId.SelectedItems IsNot Nothing Then
                Return DirectCast(LstViewerAllOfnEnterExitId.SelectedItems(0), TurnItem).TurnDetails.nEnterExitId
            Else
                Throw New Exception("شماره نوبت انتخاب نشده است")
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

    Private Sub LstViewerAllOfnEnterExitId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstViewerAllOfnEnterExitId.SelectedIndexChanged
        RaiseEvent UCSelectedValueChanged()
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

Public Class TurnItem
    Inherits ListViewItem

    Public TurnDetails As PayanehClassLibraryTurnDetails = Nothing

    Public Sub New(ByVal YourTurnDetails As PayanehClassLibraryTurnDetails)
        TurnDetails = YourTurnDetails
        Me.Text = YourTurnDetails.nEnterExitId.ToString + " - " + YourTurnDetails.OtaghdarSeqTurnNumber + "   -   " + YourTurnDetails.StrEnterDate + " - " + YourTurnDetails.StrEnterTime + " - " + YourTurnDetails.TruckLPString + " - " + YourTurnDetails.TurnStatusTitle + " - " + YourTurnDetails.TruckDriver
    End Sub

End Class

