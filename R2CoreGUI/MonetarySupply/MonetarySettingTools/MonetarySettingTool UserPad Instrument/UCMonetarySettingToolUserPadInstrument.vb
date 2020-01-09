

Imports System.Reflection

Imports R2Core.PublicProc




Public Class UCMonetarySettingToolUserPadInstrument
    Inherits UCMonetarySettingToolInstrument

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

    Private Sub UCAddMblgh(YourMblgh As Int64)
        Try
            Dim myCurrentMblgh As Int64 = IIf(UcLabelAmount.UCValue.Trim <> "", UcLabelAmount.UCValue.Replace(",", ""), 0)
            UcLabelAmount.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourMblgh + myCurrentMblgh)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            UcLabelAmount.UCValue = 0
            OnAmountChanged(0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCToChangeAmount(YourAmount As Int64)
        Try
            UCAddMblgh(YourAmount)
            OnAmountChanged(UcLabelAmount.UCValue)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub PicMblghZero_Click(sender As Object, e As EventArgs) Handles PicMblghZero.Click
        Try
            UCRefresh()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector1000_UCClickedEvent() Handles UcMblghSelector1000.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector1000.UCMblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector10000_UCClickedEvent() Handles UcMblghSelector10000.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector10000.UCMblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector3000_UCClickedEvent() Handles UcMblghSelector3000.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector3000.UCMblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector500_UCClickedEvent() Handles UcMblghSelector500.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector500.UCMblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector5000_UCClickedEvent() Handles UcMblghSelector5000.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector5000.UCMblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcMblghSelector6000_UCClickedEvent() Handles UcMblghSelector6000.UCClickedEvent
        Try
            UCToChangeAmount(UcMblghSelector6000.UCMblgh)
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
