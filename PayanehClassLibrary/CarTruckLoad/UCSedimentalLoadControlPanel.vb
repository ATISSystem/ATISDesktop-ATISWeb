
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckLoad
Imports PayanehClassLibrary.ConfigurationManagement
Imports PayanehClassLibrary.DataBaseManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI

Public Class UCSedimentalLoadControlPanel
    Inherits UCGeneral

    Private _DateTime As New R2DateTime

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCFillInf()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Private Sub UCFillInf()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonActivateZobi_UCClickedEvent() Handles UcButtonActivateZobi.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckLoadManagement.ActivateSedimentalZobi()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فعال سازی سرویس رسوب بار سالن اعلام بار ذوبی انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonChangeSedimentalTimeZobi_UCClickedEvent() Handles UcButtonChangeSedimentalTimeZobi.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckLoadManagement.ChangeSedimentalTimeZobi(New R2StandardDateAndTimeStructure(Nothing, Nothing, UcTextBoxSedimentTimeZobi.UCValue))
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "زمان رسوب بار در سالن اعلام بار ذوبی تغییر یافت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDeactivateZobi_UCClickedEvent() Handles UcButtonDeactivateZobi.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckLoadManagement.DeActivateSedimentalZobi()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "غیر فعال سازی سرویس رسوب بار سالن اعلام بار ذوبی انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonActivateAnbari_Otaghdar_UCClickedEvent() Handles UcButtonActivateAnbari_Otaghdar.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckLoadManagement.ActivateSedimentalAnbari_Otaghdar()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فعال سازی سرویس رسوب بار سالن اعلام بار انباری-اطاقدار انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDeactivateAnbari_Otaghdar_UCClickedEvent() Handles UcButtonDeactivateAnbari_Otaghdar.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckLoadManagement.DeActivateSedimentalAnbari_Otaghdar()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "غیر فعال سازی سرویس رسوب بار سالن اعلام بار انباری-اطاقدار انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
