Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.BillOfLadingControl.BillOfLadingControlInfraction


Public Class UCViewerNSSBillOfLadingControlInfractionExtended
    Inherits UCBillOfLadingControlInfraction

    Public Event UCClickedEvent(UC As UCBillOfLadingControlInfraction)



#Region "General Properties"



#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            LblBLCTitle.Text = String.Empty
            LblDateTime.Text = String.Empty
            LblUserName.Text = String.Empty
            LblStatus.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Labels_Click(sender As Object, e As EventArgs) Handles LblBLCTitle.Click, LblDateTime.Click, LblUserName.Click, LblStatus.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSBillOfLadingControlInfractionExtended_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            PnlInner.BackColor=UCBackColor
            Dim NSSExtended =R2CoreTransportationAndLoadNotificationMClassBillOfLadingControlInfractionManagement.GetNSSBillOfLadingControlInfraction( UCNSSCurrent.BLCIId)
            LblBLCTitle.Text = NSSExtended.BLCTitle
            LblDateTime.Text = NSSExtended.DateTimeComposite
            LblUserName.Text = NSSExtended.UserName.Trim
            LblStatus.Text = NSSExtended.Status
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
