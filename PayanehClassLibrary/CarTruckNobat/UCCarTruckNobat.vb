
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.TurnPrinting
Imports PayanehClassLibrary.CarTruckNobatManagement.Exceptions

Public Class UCCarTruckNobat
    Inherits UCGeneral

    Private _NSSCarTruckNobat As R2StandardCarTruckNobatStructure
    Public Event UCClickedEvent(UC As UCCarTruckNobat)

#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonChop.Visible = True
                UcButtonEbtalNobat.Visible = True
                UcButtonResuscitationNobat.Visible = True
            Else
                UcButtonChop.Visible = False
                UcButtonEbtalNobat.Visible = False
                UcButtonResuscitationNobat.Visible = False
            End If
        End Set
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetNSS() As R2StandardCarTruckNobatStructure
        Get
            Return _NSSCarTruckNobat
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
        LblnEnterExitId.Text = "" : LblEnterDate.Text = "" : LblEnterTime.Text = "" : LblDriver.Text = "" : LblStatus.Text = ""
    End Sub

    Public Sub UCViewInf(YourNSSNobat As R2StandardCarTruckNobatStructure)
        Try
            UCRefresh()
            _NSSCarTruckNobat = YourNSSNobat
            ''UcLabelnEnterExitId.UCValue = YourNSSNobat.nEnterExitId
            ''UcLabelEnterDate.UCValue = YourNSSNobat.EnterDate
            ''UcLabelEnterTime.UCValue = YourNSSNobat.EnterTime
            ''UcLabelDriver.UCValue = YourNSSNobat.NSSDriverTruck.NSSDriver.StrPersonFullName
            ''UcLabelStatus.UCValue = IIf(YourNSSNobat.bFlagDriver = True, "غیرفعال", "فعال")

            LblnEnterExitId.Text = YourNSSNobat.nEnterExitId
            LblSequentialNumber.Text = Mid(YourNSSNobat.OtaghdarTurnNumber, 7, 20).Trim
            LblEnterDate.Text = YourNSSNobat.EnterDate
            LblEnterTime.Text = YourNSSNobat.EnterTime
            LblDriver.Text = YourNSSNobat.NSSDriverTruck.NSSDriver.StrPersonFullName
            LblStatus.Text = IIf(YourNSSNobat.bFlagDriver = True, "غیرفعال", "فعال")

            UcButtonChop.UCEnable = Not YourNSSNobat.bFlagDriver
            UcButtonEbtalNobat.UCEnable = Not YourNSSNobat.bFlagDriver
            UcButtonResuscitationNobat.UCEnable = YourNSSNobat.bFlagDriver
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewInf(YourNSSCar As R2StandardCarStructure)
        Try
            UCRefresh()
            UCViewInf(PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(YourNSSCar))
        Catch exx As GetNobatException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonChop_UCClickedEvent() Handles UcButtonChop.UCClickedEvent
        Try
            Dim InstanceTurnPrinting = New R2CoreTransportationAndLoadNotificationMClassTurnPrintingManager
            InstanceTurnPrinting.TurnPrint(_NSSCarTruckNobat.nEnterExitId)
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + exx.Message, "اطلاعات پایه برای چاپ نوبت ناوگان باری تکمیل نیست", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonEbtalNobat_UCClickedEvent() Handles UcButtonEbtalNobat.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckNobatManagement.SetbFlagDriverToTrue(_NSSCarTruckNobat.nEnterExitId, True)
            _NSSCarTruckNobat.bFlagDriver = True
            UCViewInf(_NSSCarTruckNobat)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "نوبت باطل شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonResuscitationNobat_UCClickedEvent() Handles UcButtonResuscitationNobat.UCClickedEvent
        Try
            PayanehClassLibraryMClassCarTruckNobatManagement.SetbFlagDriverToFalse(_NSSCarTruckNobat.nEnterExitId)
            _NSSCarTruckNobat.bFlagDriver = False
            UCViewInf(_NSSCarTruckNobat)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "نوبت احیاء شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub Lbls_ClickHandler(sender As Object, e As EventArgs) Handles LblEnterDate.Click, LblDriver.Click, LblEnterTime.Click, LblStatus.Click, LblnEnterExitId.Click
        Try
            RaiseEvent UCClickedEvent(Me)
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
