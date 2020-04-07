

Imports System.Reflection
Imports PAKTCRemoteApplication
Imports R2CoreWinFormRemoteApplications


Public Class FrmcMobileUserMobileNumberRegistering

    Inherits FrmcGeneral

    Private _PayanehWS As PayanehWS.PayanehWebService = New PayanehWS.PayanehWebService




#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            Me.Owner = FrmcFirst.FrmMain
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefresh()
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonSpecialTruckDriverMobileNumberRegistering_UCClickedEvent() Handles UcButtonSpecialTruckDriverMobileNumberRegistering.UCClickedEvent
        Try
            If UcPersianTextBoxTruckDriverMobileNumber.UCValue.Trim = String.Empty Or UcPersianTextBoxTruckDriverMobileNumber.UCValue.Length <> 11 Then Throw New Exception("شماره موبایل نادرست است")
            _PayanehWS.WebMethodMobileUserMobileNumberRegistering(UcDriverTruck.UCGetSmartCarNo, UcPersianTextBoxTruckDriverMobileNumber.UCValue)
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "شماره موبایل راننده در سامانه ثبت گردید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me, False)
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