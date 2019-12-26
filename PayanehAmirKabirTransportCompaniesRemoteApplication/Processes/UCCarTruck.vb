
Imports System.ComponentModel
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class UCCarTruck
    Inherits UCGeneral

#Region "General Properties"

    <Browsable(False)>
    Public ReadOnly Property UCGetSmartCarNo() As String
        Get
            Return UcPersianTextBoxSmartCardNo.UCValue
        End Get
    End Property
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabelCarTruckSerial.UCRefresh()
        UcLabelCarTruckPelak.UCRefresh()
    End Sub

    Public sub UCRefreshGeneral
        UcPersianTextBoxSmartCardNo.UCRefresh()
    End sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcButtonGetInfRMTO_UCClickedEvent() Handles UcButtonGetInfRMTO.UCClickedEvent
        Dim Pelak, Serial As String
        Try
            UCRefresh()
            If UcPersianTextBoxSmartCardNo.UCValue.Trim = String.Empty Then Exit Sub
            TransportCompaniesLoadCapacitorLoadsManipulation.GetNSSCarTruckBySmartCardNoRMTO(UcPersianTextBoxSmartCardNo.UCValue, Pelak, Serial)
            UcLabelCarTruckPelak.UCValue = Pelak
            UcLabelCarTruckSerial.UCValue = Serial
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
    End Sub

    Private Sub UcButtonGetInfLocalDataBase_UCClickedEvent() Handles UcButtonGetInfLocalDataBase.UCClickedEvent
        Dim Pelak, Serial As String
        Try
            UCRefresh()
            If UcPersianTextBoxSmartCardNo.UCValue.Trim = String.Empty Then Exit Sub
            TransportCompaniesLoadCapacitorLoadsManipulation.GetNSSCarTruckBySmartCardNoLocalDataBase(UcPersianTextBoxSmartCardNo.UCValue, Pelak, Serial)
            UcLabelCarTruckPelak.UCValue = Pelak
            UcLabelCarTruckSerial.UCValue = Serial
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
