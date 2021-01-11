Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControlInfraction


Public Class UCUCBillOfLadingControlInfractionCollectionAdvance
    Inherits UCGeneralExtended

    Public Event UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlInfractionStructure)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewCollection()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCViewCollection(YourSearchString As String)
        Try
            UcucBillOfLadingControlInfractionCollection.UCViewCollection(R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlInfractionManagement.GetBillOfLadingControlInfractionHeaders(YourSearchString))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewCollection()
        Try
            UCViewCollection(String.Empty)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcSearcherSimple_UC13PressedEvent(SearchString As String) Handles UcSearcherSimple.UC13PressedEvent
        Try
            UCViewCollection(SearchString)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucBillOfLadingControlInfractionCollection_UCSelectedNSSChangedEvent(NSS As R2CoreTransportationAndLoadNotificationStandardBillOfLadingControlInfractionStructure) Handles UcucBillOfLadingControlInfractionCollection.UCSelectedNSSChangedEvent
        Try
            RaiseEvent UCSelectedNSSChangedEvent(NSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcSearcherSimple_UCEmptyStringRefreshRequestedEvent() Handles UcSearcherSimple.UCEmptyStringRefreshRequestedEvent
        Try
            UCViewCollection()
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
