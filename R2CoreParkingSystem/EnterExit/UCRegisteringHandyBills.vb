
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.ConfigurationManagement
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCRegisteringHandyBills
    Inherits UCGeneral



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
            UcButton.UCEnable=false
      UcNumberTeadad.UCRefresh()
            UcLabelLastRegistered.UCValue= "تعداد ثبت شده : " 
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
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "تعداد نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcCmbTerafficCardType.UCGetCurrentTypeCode() = R2CoreParkingSystem.TrafficCardsManagement.TerafficCardType.None Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "نوع کارت تردد نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            Dim myTeadad As Int64 = UcNumberTeadad.UCValue
            R2CoreParkingSystemMClassEnterExitManagement.RegisteringHandyBills(myTeadad, New R2StandardDateAndTimeStructure(Nothing,UcPersianShamsiDate.UCGetDate.DateShamsiFull, Nothing), UcCmbTerafficCardType.UCGetCurrentTypeCode())
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت قبوض به تعداد مورد نظر انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            UcButton.UCEnable = False
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianShamsiDate_UCPersianShamsiDateChangedEvent() Handles UcPersianShamsiDate.UCPersianShamsiDateChangedEvent
        Try
            UcButton.UCEnable = True
            UCViewLastTotalRegistered(R2CoreParkingSystemMClassEnterExitManagement.GetTotalRegisteredHandyBills(UcPersianShamsiDate.UCGetDate(), UcCmbTerafficCardType.UCGetCurrentTypeCode()))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCmbTerafficCardType_UCSelectedIndexChanged() Handles UcCmbTerafficCardType.UCSelectedIndexChanged
        Try
            UcButton.UCEnable = True
            UCViewLastTotalRegistered(R2CoreParkingSystemMClassEnterExitManagement.GetTotalRegisteredHandyBills(UcPersianShamsiDate.UCGetDate(), UcCmbTerafficCardType.UCGetCurrentTypeCode()))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDelete_UCClickedEvent() Handles UcButtonDelete.UCClickedEvent
        Try
            R2CoreParkingSystemMClassEnterExitManagement.DeleteRegisteredHandyBills(UcPersianShamsiDate.UCGetDate(), UcCmbTerafficCardType.UCGetCurrentTypeCode())
            UCRefresh()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف قبوض برای تاریخ مورد نظر انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
