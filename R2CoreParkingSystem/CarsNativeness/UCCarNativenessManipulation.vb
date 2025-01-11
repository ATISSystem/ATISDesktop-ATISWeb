
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.DateAndTimeManagement
Imports R2CoreParkingSystem.CarsNativeness
Imports R2CoreParkingSystem.CarsNativeness.Exceptions
Imports R2CoreParkingSystem.Cars

Public Class UCCarNativenessManipulation
    Inherits UCCarNativeness

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
            UcLabelCarLPR.UCRefreshGeneral()
            Dim InstanceCarNativeness = New R2CoreParkingSystemCarNativenessManager
            Dim NSS = InstanceCarNativeness.GetNSSCarNativenessType(CarNativenessTypes.None)
            CButtonCarNativeness.ColorFillBlend.iColor(1) = NSS.NColor
            CButtonCarNativeness.Text = NSS.NTitle
        Catch ex As CarNativenessTypeNotFoundException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewNSSCarNativeness_(YourNSSCar As R2StandardCarStructure, YourNSSCarNativeness As R2CoreParkingSystemCarNativenessStructure)
        Try
            UCRefresh()
            Dim InstanceCarNativeness = New R2CoreParkingSystemCarNativenessManager
            Dim NSSCarNativenessType = InstanceCarNativeness.GetNSSCarNativenessType(YourNSSCarNativeness.CarNativenessTypeId)
            UcLabelCarLPR.UCValue = YourNSSCar.GetCarPelakSerialComposit
            UcPersianShamsiDate.UCSetDate(YourNSSCarNativeness.CarNativenessExpireDate)
            CButtonCarNativeness.Text = NSSCarNativenessType.NTitle
            CButtonCarNativeness.ColorFillBlend.iColor(1) = NSSCarNativenessType.NColor
        Catch ex As CarNativenessTypeNotFoundException
            Throw ex
        Catch ex As CarNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Overloads Sub UCViewNSSCarNativeness(YourNSSCar As R2StandardCarStructure)
        Try
            Dim InstanceCarNativeness = New R2CoreParkingSystemCarNativenessManager
            Dim NSSTruckNativeness = InstanceCarNativeness.GetNSSCarNativeness(YourNSSCar, True)
            UCViewNSSCarNativeness_(YourNSSCar, NSSTruckNativeness)
        Catch ex As CarNativenessTypeNotFoundException
            Throw ex
        Catch ex As CarNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Overloads Sub UCViewNSSCarNativeness(YourNSSCar As R2StandardCarStructure, YourNSSCarNativeness As R2CoreParkingSystemCarNativenessStructure)
        Try
            UCViewNSSCarNativeness_(YourNSSCar, YourNSSCarNativeness)
        Catch ex As CarNativenessTypeNotFoundException
            Throw ex
        Catch ex As CarNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub UCCarNativenessManipulation_UCNSSCurrentChanged(NSSCurrent As R2StandardCarStructure) Handles Me.UCNSSCurrentChanged
        Try
            UCViewNSSCarNativeness(NSSCurrent)
        Catch ex As CarNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As CarNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub UCCarNativenessManipulation_UCViewNSSRequested(NSSCurrent As R2StandardCarStructure) Handles Me.UCViewNSSRequested
        Try
            UCViewNSSCarNativeness(NSSCurrent)
        Catch ex As CarNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As CarNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCCarNativenessManipulation_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
        Try
            UCRefresh()
        Catch ex As CarNativenessTypeNotFoundException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub CButtonCarNativeness_Click(sender As Object, e As EventArgs) Handles CButtonCarNativeness.Click
        Try
            Dim InstanceCarNativeness = New R2CoreParkingSystemCarNativenessManager
            Dim newCarNativeness = InstanceCarNativeness.ChangeCarNativeness(UCNSSCurrent, UcPersianShamsiDate.UCGetDate)
            UCViewNSSCarNativeness(UCNSSCurrent, newCarNativeness)
        Catch ex As ShamsiDateSyntaxNotValidException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As IndigenousCarChangeNativnessFailedException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As CarNotExistException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        Catch ex As CarNativenessTypeNotValidException
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
