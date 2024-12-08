

Imports System.ComponentModel
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces
Imports R2CoreTransportationAndLoadNotification.LoadingAndDischargingPlaces.Exceptions
Imports R2CoreTransportationAndLoadNotification.Turns


Public Class UCLoadingAndDischargingPlaceDataEntry
    Inherits UCLoadingAndDischargingPlace

#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Shadows Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"


#End Region

#Region "Event Handlers"
    Private Sub UCLoadingAndDischargingPlaceDataEntry_UCNSSCurrentChangedtoNull() Handles Me.UCNSSCurrentChangedtoNull
        UcLabelLADPlaceId.UCRefreshGeneral()
        UcPersianTextBoxLADPlaceTilte.UCRefreshGeneral()
        UcLabelLoadingActiveStatus.UCRefreshGeneral()
        UcLabelDischargingActiveStatus.UCRefreshGeneral()
    End Sub

    Private Sub UCLoadingAndDischargingPlaceDataEntry_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure) Handles Me.UCViewNSSRequested
        Try
            UcLabelLADPlaceId.UCValue = NSSCurrent.LADPlaceId
            UcPersianTextBoxLADPlaceTilte.UCValue = UCNSSCurrent.LADPlaceTitle
            UcLabelLoadingActiveStatus.UCValue = IIf(NSSCurrent.LoadingActive, "فعال", "غیرفعال")
            UcLabelDischargingActiveStatus.UCValue = IIf(NSSCurrent.DischargingActive, "فعال", "غیرفعال")
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCLoadingAndDischargingPlaceDataEntry_UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure) Handles Me.UCNSSCurrentChanged
        Try
            UcLabelLADPlaceId.UCValue = NSSCurrent.LADPlaceId
            UcPersianTextBoxLADPlaceTilte.UCValue = NSSCurrent.LADPlaceTitle
            UcLabelLoadingActiveStatus.UCValue = IIf(NSSCurrent.LoadingActive, "فعال", "غیرفعال")
            UcLabelDischargingActiveStatus.UCValue = IIf(NSSCurrent.DischargingActive, "فعال", "غیرفعال")
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonNew_Click() Handles CButtonNew.Click
        Try
            UCNSSCurrent = Nothing
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonDelete_Click() Handles CButtonDelete.Click
        Try
            Dim InstanceLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager

            If UcLabelLADPlaceId.UCValue.Trim = String.Empty Then Return
            InstanceLoadingAndDischargingPlaces.LoadingAndDischargingPlaceDelete(New R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure(UcLabelLADPlaceId.UCValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            UCNSSCurrent = Nothing
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فرآیند با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonRegister_Click() Handles CButtonRegister.Click
        Try
            Dim InstanceLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager

            Dim LADPlaceId As Int64 = 0
            If UcLabelLADPlaceId.UCValue = String.Empty Then
                LADPlaceId = InstanceLoadingAndDischargingPlaces.LoadingAndDischargingPlaceRegister(New R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure(0, UcPersianTextBoxLADPlaceTilte.UCValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            Else
                LADPlaceId = InstanceLoadingAndDischargingPlaces.LoadingAndDischargingPlaceRegister(New R2CoreTransportationAndLoadNotificationStandardLoadingAndDischargingPlacesStructure(UcLabelLADPlaceId.UCValue, UcPersianTextBoxLADPlaceTilte.UCValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing), R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            End If
            If LADPlaceId <> 0 Then
                UCViewNSS(LADPlaceId)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فرآیند با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonNew_Click(sender As Object, e As EventArgs) Handles CButtonNew.Click

    End Sub

    Private Sub CButtonLoadingPlaceChangeStatus_Click(sender As Object, e As EventArgs) Handles CButtonLoadingPlaceChangeStatus.Click
        Try
            Dim InstanceLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager

            If UcLabelLADPlaceId.UCValue.Trim = String.Empty Then Return
            InstanceLoadingAndDischargingPlaces.LoadingPlaceChangeActiveStatus(InstanceLoadingAndDischargingPlaces.GetNSSLoadingAndDischargingPlace(UcLabelLADPlaceId.UCValue, True))
            UCViewNSS(UcLabelLADPlaceId.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فرآیند با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As LoadingAndDischargingSendSMSFailedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonDischargingPlaceChangeStatus_Click(sender As Object, e As EventArgs) Handles CButtonDischargingPlaceChangeStatus.Click
        Try
            Dim InstanceLoadingAndDischargingPlaces = New R2CoreTransportationAndLoadNotificationMClassLoadingAndDischargingPlacesManager

            If UcLabelLADPlaceId.UCValue.Trim = String.Empty Then Return
            InstanceLoadingAndDischargingPlaces.DischargingPlaceChangeActiveStatus(InstanceLoadingAndDischargingPlaces.GetNSSLoadingAndDischargingPlace(UcLabelLADPlaceId.UCValue, True))
            UCViewNSS(UcLabelLADPlaceId.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "فرآیند با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As LoadingAndDischargingSendSMSFailedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
