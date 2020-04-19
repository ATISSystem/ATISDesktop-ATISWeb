
Imports System.Reflection

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

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

        Catch exx As GetDataException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "اطلاعات مورد جستجو وجود ندارد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCRefresh()

    End Sub

    Private Sub UCViewInf()
        Try
            LstViewerAllOfnEnterExitId.Items.Clear()
            Dim Lst As List(Of String) = CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetListOfAllnEnterExitId(UcAnnouncementHallSelection1.UCNSSCurrentAnnouncementHall, UcAnnouncementHallSelection1.UCNSSCurrentAnnouncementHallSubGroup)
            For Each S As String In Lst
                LstViewerAllOfnEnterExitId.Items.Add(S)
            Next
        Catch exx As GetDataException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetSelectedValue() As Int64
        Try
            If LstViewerAllOfnEnterExitId.SelectedIndex >= 0 Then
                Return SPLIT(LstViewerAllOfnEnterExitId.Items(LstViewerAllOfnEnterExitId.SelectedIndex),"-")(0)
            Else
                Throw New Exception("شماره اعتبار را انتخاب نمایید")
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetSelectedAnnouncementHall() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure
        Try
            Return UcAnnouncementHallSelection1.UCNSSCurrentAnnouncementHall
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetSelectedAnnouncementHallSubGroup() As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure
        Try
            Return UcAnnouncementHallSelection1.UCNSSCurrentAnnouncementHallSubGroup
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

    Private Sub UcAnnouncementHallSelection_UCCurrentNSSAnnouncementHallSubGroupChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection1.UCCurrentNSSAnnouncementHallSubGroupChangedEvent
        Try
            UCViewInf()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcAnnouncementHallSelection1_UCCurrentNSSAnnouncementHallChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure) Handles UcAnnouncementHallSelection1.UCCurrentNSSAnnouncementHallChangedEvent
        LstViewerAllOfnEnterExitId.Items.Clear()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
