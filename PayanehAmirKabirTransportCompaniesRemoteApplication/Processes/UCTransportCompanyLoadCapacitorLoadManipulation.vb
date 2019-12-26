
Imports System.ComponentModel
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class UCTransportCompanyLoadCapacitorLoadManipulation
    Inherits UCGeneral

    Public Event UCLoadCapacitorLoadDeletedEvent(UC As UCGeneral)
    Protected Event UCViewNSSCompleted()
    Public Event UCClickedEvent(UC As UCTransportCompanyLoadCapacitorLoadManipulation)
    Private _CurrentNSS As TransportCompaniesStandardLoadCapacitorLoadStructure = Nothing

#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonRegister.Visible = True
                UcButtonDelete.Visible = True
            Else
                UcButtonRegister.Visible = False
                UcButtonDelete.Visible = False
            End If
        End Set
    End Property

    Private _UCCurrentNSS As TransportCompaniesStandardLoadCapacitorLoadStructure = Nothing
    <Browsable(False)>
    Public ReadOnly Property UCGetCurrentNSS() As TransportCompaniesStandardLoadCapacitorLoadStructure
        Get
            Return _UCCurrentNSS
        End Get
    End Property

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
            UcNumbernCarNumKol.UCRefresh()
            UcNumberStrPriceSug.UCRefresh()
            UcPersianTextBoxStrBarName.UCRefresh()
            UcPersianTextBoxStrDescription.UCRefresh()
            UcPersianTextBoxAddress.UCRefresh()
            UcPersianTextBoxdDateElam.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As TransportCompaniesStandardLoadCapacitorLoadStructure)
        Try
            _UCCurrentNSS = YourNSS
            UcNumbernEstelamId.UCValue = YourNSS.nEstelamId
            UcSearcherLoads.UCViewNSS(TransportCompaniesLoadCapacitorLoadsManipulation.GetLoad(YourNSS.nBarCode))
            UcSearcherCarTypes.UCViewNSS(TransportCompaniesLoadCapacitorLoadsManipulation.GetCarType(YourNSS.nTruckType))
            UcSearcherCities.UCViewNSS(TransportCompaniesLoadCapacitorLoadsManipulation.GetCity(YourNSS.nCityCode))
            UcNumbernCarNumKol.UCValue = YourNSS.nCarNumKol
            UcPersianTextBoxStrBarName.UCValue = YourNSS.StrBarName
            UcPersianTextBoxStrDescription.UCValue = YourNSS.StrDescription
            UcNumberStrPriceSug.UCValue = YourNSS.StrPriceSug
            UcPersianTextBoxAddress.UCValue = YourNSS.StrAddress
            UcPersianTextBoxdDateElam.UCValue = YourNSS.dDateElam.Trim + " - " + YourNSS.dTimeElam.Trim
            RaiseEvent UCViewNSSCompleted()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCLoadRegister()
        Try
            'تست پارامترها
            Try
                UcSearcherLoads.UCGetSelectedNSS()
                UcSearcherCarTypes.UCGetSelectedNSS()
                UcSearcherCities.UCGetSelectedNSS()
                If UcNumbernCarNumKol.UCValue <= 0 Then
                    Throw New Exception("تعداد بار نادرست است")
                End If
            Catch ex As Exception
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات را به طور کامل وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,false)
                Exit Sub
            End Try
            'تراکنش ثبت
            Dim NSS As New TransportCompaniesStandardLoadCapacitorLoadStructure
            NSS.nEstelamId = UcNumbernEstelamId.UCValue
            NSS.StrBarName = UcPersianTextBoxStrBarName.UCValue
            NSS.nCityCode = UcSearcherCities.UCGetSelectedNSS.OCode
            NSS.nBarCode = UcSearcherLoads.UCGetSelectedNSS.OCode
            NSS.nCompCode = TransportCompaniesLoadCapacitorLoadsManipulation.GetCompanyCode()
            NSS.nTruckType = UcSearcherCarTypes.UCGetSelectedNSS.OCode
            NSS.StrAddress = UcPersianTextBoxAddress.UCValue
            NSS.nCarNumKol = UcNumbernCarNumKol.UCValue
            NSS.StrDescription = UcPersianTextBoxStrDescription.UCValue
            NSS.StrPriceSug = UcNumberStrPriceSug.UCValue
            If UcNumbernEstelamId.UCValue <> 0 Then
                TransportCompaniesLoadCapacitorLoadsManipulation.LoadCapacitorLoadEdit(NSS)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت بار انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)

            Else
                UcNumbernEstelamId.UCValue = TransportCompaniesLoadCapacitorLoadsManipulation.LoadCapacitorLoadRegister(NSS)
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ثبت بار انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)

            End If
            _CurrentNSS = NSS
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCLoadDelete()
        Try
            If UcNumbernEstelamId.UCValue <> 0 Then
                TransportCompaniesLoadCapacitorLoadsManipulation.LoadCapacitorLoadDelete(UcNumbernEstelamId.UCValue)
                _CurrentNSS = Nothing
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "حذف بار انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
                RaiseEvent UCLoadCapacitorLoadDeletedEvent(Me)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCTransportCompanyLoadCapacitorLoadManipulation_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        UcSearcherLoads.Focus()
    End Sub

    Private Sub UcNumbernCarNumKol_UC13Pressed(UserNumber As String) Handles UcNumbernCarNumKol.UC13Pressed
        UcPersianTextBoxStrDescription.Focus()
    End Sub

    Private Sub UcNumberStrPriceSug_UC13Pressed(UserNumber As String) Handles UcNumberStrPriceSug.UC13Pressed
        UcPersianTextBoxStrBarName.Focus()
    End Sub

    Private Sub UcPersianTextBoxAddress_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxAddress.UC13PressedEvent
        UcButtonRegister.Focus()
    End Sub

    Private Sub UcPersianTextBoxStrBarName_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxStrBarName.UC13PressedEvent
        UcPersianTextBoxAddress.Focus()
    End Sub

    Private Sub UcPersianTextBoxStrDescription_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxStrDescription.UC13PressedEvent
        UcNumberStrPriceSug.Focus()
    End Sub

    Private Sub UcSearcherCarTypes_UC13PressedEvent() Handles UcSearcherCarTypes.UC13PressedEvent
        UcNumbernCarNumKol.Focus()
    End Sub

    Private Sub UcSearcherCities_UC13PressedEvent() Handles UcSearcherCities.UC13PressedEvent
        UcSearcherCarTypes.UCFocus()
    End Sub

    Private Sub UcSearcherLoads_UC13PressedEvent() Handles UcSearcherLoads.UC13PressedEvent
        UcSearcherCities.UCFocus()
    End Sub

    Private Sub UcButtonDelete_UC13PressedEvent() Handles UcButtonDelete.UC13PressedEvent
        Try
            UCLoadDelete()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonDelete_UCClickedEvent() Handles UcButtonDelete.UCClickedEvent
        Try
            UCLoadDelete()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonRegister_UC13PressedEvent() Handles UcButtonRegister.UC13PressedEvent
        Try
            UCLoadRegister()
            ''UcSearcherLoads.Focus()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonRegister_UCClickedEvent() Handles UcButtonRegister.UCClickedEvent
        Try
            UCLoadRegister()
            ''UcSearcherLoads.Focus()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcNumbernEstelamId_UCClickedEvent() Handles UcNumbernEstelamId.UCClickedEvent
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonPermissionEnterExits_UCClickedEvent() Handles UcButtonPermissionEnterExits.UCClickedEvent
        Try
            If UcNumbernEstelamId.UCValue <> 0 Then
                UcucPermissionViewerCollection.UCViewInf(UcNumbernEstelamId.UCValue)
                UcucPermissionViewerCollection.BringToFront()
            End If
      
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
