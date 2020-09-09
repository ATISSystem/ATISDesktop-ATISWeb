
Imports System.Reflection

Imports PayanehClassLibrary.PayanehWS
Imports PayanehClassLibrary.TransportCompanies
Imports R2Core.ExceptionManagement
Imports R2CoreGUI

Public Class UCComputerMessageSedimentedLoadAllocationAndPermssion
    Inherits UCComputerMessage

    'Note Data1=CompanyId   Data2=nEstelamId   Data3=CarTruckSmartCardNo   Data4=DriverTruckSmartCardNo

    Private WS As PayanehWebService = New PayanehWebService


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
        UcLabelProductName.UCRefreshGeneral()
        UcLabelTransportCompany.UCRefreshGeneral()
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCComputerMessageSodoorNobat_UCViewNSSCompleted() Handles Me.UCViewNSSCompleted
        Try
            Dim NSS As TransportCompaniesStandardLoadCapacitorLoadStructure = TransportCompaniesLoadCapacitorLoadManipulation.GetNSSTransportCompanyLoadCapacitorLoad(_NSS.DataStruct.Data2)
            UcLabelProductName.UCValue = TransportCompaniesLoadCapacitorLoadManipulation.GetProductName(NSS.nBarCode)
            UcLabelTransportCompany.UCValue = TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyName(NSS.nCompCode)
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "اطلاعات مرتبط با کالا و یا شرکت حمل و نقل یافت نشد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonLoadAllocateAndPermission_UCClickedEvent() Handles UcButtonLoadAllocateAndPermission.UCClickedEvent
        Try
            Dim TurnId As Int64 = PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(_NSS.DataStruct.Data1, _NSS.DataStruct.Data2, _NSS.DataStruct.Data3, _NSS.DataStruct.Data4,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            ''Dim TurnId As Int64 = WS.WebMethodTransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(_NSS.DataStruct.Data1,_NSS.DataStruct.Data2,_NSS.DataStruct.Data3,_NSS.DataStruct.Data4)
            PayanehClassLibrary.LoadNotification.LoadPermission.PermissionPrinting.PrintPermission(_NSS.DataStruct.Data2, TurnId)
            PayanehClassLibrary.LoadNotification.LoadPermission.PermissionPrinting.PrintPermission(_NSS.DataStruct.Data2, TurnId)
            UCDeactiveComputerMessage()
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مجوز بارگیری با موفقیت صادر شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
