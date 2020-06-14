
Imports System.Reflection
Imports R2CoreGUI
Imports R2CoreParkingSystem.City

Public Class UCCity
    Inherits UCGeneral

    Private _NSS As R2CoreParkingSystemMClassCitys.R2StandardCityStructure = Nothing

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabelnCityCode.UCRefreshGeneral()
        UcLabelStrCityName.UCRefreshGeneral()
        UcNumbernDistance.UCRefresh()
        UcNumbernProvince.UCRefresh()
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreParkingSystemMClassCitys.R2StandardCityStructure)
        Try
            _NSS = YourNSS
            UcLabelnCityCode.UCValue = YourNSS.nCityCode
            UcLabelStrCityName.UCValue = YourNSS.StrCityName
            UcNumbernDistance.UCValue = YourNSS.nDistance
            UcNumbernProvince.UCValue = YourNSS.nProvince
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcNumbernDistance_UC13Pressed(UserNumber As String) Handles UcNumbernDistance.UC13Pressed
        Try
            R2CoreParkingSystemMClassCitys.ChangeCityDistance(_NSS, UcNumbernDistance.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مقدار جدید برای فاصله ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcNumbernProvince_UC13Pressed(UserNumber As String) Handles UcNumbernProvince.UC13Pressed
        Try
            R2CoreParkingSystemMClassCitys.ChangeCityProvince(_NSS,UcNumbernProvince.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مقدار جدید برای کد ویژه ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
