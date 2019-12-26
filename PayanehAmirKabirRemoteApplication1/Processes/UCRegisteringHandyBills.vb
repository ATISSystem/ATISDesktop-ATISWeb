
Imports System.Reflection

Imports PayanehAmirKabirRemoteApplication.R2PrimaryWS
Imports R2CoreWinFormRemoteApplications

Public Class UCRegisteringHandyBills
    Inherits UCGeneral

    Private WS As R2PrimaryWS.R2PrimaryWebService = New R2PrimaryWebService()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            UcButton.UCEnable = False
            UcTextBoxDate.UCRefresh()
            UcNumberTeadad.UCRefresh()
            UcLabelLastRegistered.UCValue = "تعداد ثبت شده : "
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewLastTotalRegistered(YourAmount As Int64)
        Try
            UcLabelLastRegistered.UCValue = "تعداد ثبت شده : " + YourAmount.ToString()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            If UcNumberTeadad.UCValue = 0 Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "تعداد نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
                'UcNumberTeadad.Focus()
                Exit Sub
            End If
            If _DateTime.ChekDateShamsiFullSyntax(UcTextBoxDate.UCValue) = False Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "تاریخ نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
                'UcTextBoxDate.Focus()
                Exit Sub
            End If
            Dim myTeadad As Int64 = UcNumberTeadad.UCValue
            Dim myDate As String = UcTextBoxDate.UCValue
            WS.WebMethodRegisteringHandyBills(myTeadad, myDate, UcCmbTerafficCardType.UCGetCurrentTypeCode())
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت قبوض به تعداد مورد نظر انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
            UcButton.UCEnable = False
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try

    End Sub

    Private Sub UcTextBoxDate_UCTextChangedEvent(CurrentText As String) Handles UcTextBoxDate.UCTextChangedEvent
        Try
            UcButton.UCEnable = True
            If _DateTime.ChekDateShamsiFullSyntax(CurrentText) = True Then UCViewLastTotalRegistered(WS.WebMethodGetTotalRegisteredHandyBills(UcTextBoxDate.UCValue, UcCmbTerafficCardType.UCGetCurrentTypeCode()))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UcCmbTerafficCardType_UCSelectedIndexChanged() Handles UcCmbTerafficCardType.UCSelectedIndexChanged
        Try
            UcButton.UCEnable = True
            UCViewLastTotalRegistered(WS.WebMethodGetTotalRegisteredHandyBills(UcTextBoxDate.UCValue, UcCmbTerafficCardType.UCGetCurrentTypeCode()))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
        End Try
    End Sub

    Private Sub UcButtonDelete_UCClickedEvent() Handles UcButtonDelete.UCClickedEvent
        Try
            WS.WebMethodDeleteRegisteredHandyBills(UcTextBoxDate.UCValue, UcCmbTerafficCardType.UCGetCurrentTypeCode())
            UCRefresh()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف قبوض برای تاریخ مورد نظر انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, True)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me, False)
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
