

Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.TrucksNativeness
Imports R2CoreTransportationAndLoadNotification.TrucksNativeness.Exceptions

Public Class UCTruckNativenessManipulation
    Inherits UCTruckNativeness


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcPersianShamsiDate.UCRefreshGeneral()
            UcLabelTruckLPR.UCRefreshGeneral()
            Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
            Dim NSS = InstanceTruckNativeness.GetNSSTruckNativenessType(TruckNativenessTypes.None)
            CButtonTruckNativeness.ColorFillBlend.iColor(1) = NSS.NColor
            CButtonTruckNativeness.Text = NSS.NTitle
        Catch ex As TruckNativenessTypeNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewNSSTruckNativeness_(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNSSTruckNativeness As R2CoreTransportationAndLoadNotificationsTruckNativenessStructure)
        Try
            UCRefresh()
            Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
            Dim NSSTruckNativenessType = InstanceTruckNativeness.GetNSSTruckNativenessType(YourNSSTruckNativeness.TruckNativenessTypeId)
            UcLabelTruckLPR.UCValue = YourNSSTruck.NSSCar.GetCarPelakSerialComposit
            UcPersianShamsiDate.UCSetDate(YourNSSTruckNativeness.TruckNativenessExpireDate)
            CButtonTruckNativeness.Text = NSSTruckNativenessType.NTitle
            CButtonTruckNativeness.ColorFillBlend.iColor(1) = NSSTruckNativenessType.NColor
        Catch ex As TruckNativenessTypeNotFoundException
            Throw ex
        Catch ex As TruckNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Overloads Sub UCViewNSSTruckNativeness(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure)
        Try
            Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
            Dim NSSTruckNativeness = InstanceTruckNativeness.GetNSSTruckNativeness(YourNSSTruck, True)
            UCViewNSSTruckNativeness_(YourNSSTruck, NSSTruckNativeness)
        Catch ex As TruckNativenessTypeNotFoundException
            Throw ex
        Catch ex As TruckNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Overloads Sub UCViewNSSTruckNativeness(YourNSSTruck As R2CoreTransportationAndLoadNotificationStandardTruckStructure, YourNSSTruckNativenessType As R2CoreTransportationAndLoadNotificationsTruckNativenessStructure)
        Try
            UCViewNSSTruckNativeness_(YourNSSTruck, YourNSSTruckNativenessType)
        Catch ex As TruckNativenessTypeNotFoundException
            Throw ex
        Catch ex As TruckNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub UCTruckNativenessManipulation_UCNSSCurrentChanged(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTruckStructure) Handles Me.UCNSSCurrentChanged
        Try
            UCViewNSSTruckNativeness(NSSCurrent)
        Catch ex As TruckNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As TruckNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub UCTruckNativenessManipulation_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTruckStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewNSSTruckNativeness(NSSCurrent)
        Catch ex As TruckNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As TruckNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCTruckNativenessManipulation_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
        Try
            UCRefresh()
        Catch ex As TruckNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonTruckNativeness_Click(sender As Object, e As EventArgs) Handles CButtonTruckNativeness.Click
        Try
            Dim InstanceTruckNativeness = New R2CoreTransportationAndLoadNotificationsTruckNativenessManager
            Dim newTruckNativeness = InstanceTruckNativeness.ChangeTruckNativeness(UCNSSCurrent, UcPersianShamsiDate.UCGetDate)
            UCViewNSSTruckNativeness(UCNSSCurrent, newTruckNativeness)
        Catch ex As ShamsiDateSyntaxNotValidException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As IndigenousTruckChangeNativnessFailedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As TruckNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As TruckNativenessTypeNotValidException
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
