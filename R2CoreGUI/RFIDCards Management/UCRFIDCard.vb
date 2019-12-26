

Imports System.Reflection

Imports R2Core.RFIDCardsManagement
Imports R2Core.ExceptionManagement


Public Class UCRFIDCard
    Inherits UCGeneral
    Implements R2CoreRFIDCardRequester

    Public Event UCRFIDCardReadedEvent(NSSRFIdCard As R2CoreStandardRFIDCardStructure)
    Public Event UCRFIDCardReaderStartToReadEvent()
    Public Event UCViewRFIDCardCompeleted(NSSRFIdCard As R2CoreStandardRFIDCardStructure)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCShowRFIDCard(CardNo As String)
        Try
            UcPersianTextBoxCardNo.UCValue = CardNo
            UcPersianTextBoxCardId.UCValue = R2CoreMClassRFIDCardManagement.GetNSSRFIDCard(CardNo).CardId
            RaiseEvent UCViewRFIDCardCompeleted(R2CoreMClassRFIDCardManagement.GetNSSRFIDCard(CardNo))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public  sub UCRefresh
        UcPersianTextBoxCardId.UCRefresh()
        UcPersianTextBoxCardNo.UCRefresh()
    End sub

    Public Function UCGetNSS() As R2CoreStandardRFIDCardStructure
        Try
            If UcPersianTextBoxCardId .UCValue <> ""  Then
                Return R2CoreMClassRFIDCardManagement.GetNSSRFIDCard(UcPersianTextBoxCardNo.UCValue )
            Else
                Throw New GetNSSException
            End If
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PicStopReading_Click(sender As Object, e As EventArgs) Handles PicStopReading.Click
        R2CoreRFIDCardReaderInterface.StopReading()
    End Sub

    Private Sub PicStartReading_Click(sender As Object, e As EventArgs) Handles PicStartReading.Click
        R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
    End Sub



#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
        RaiseEvent UCRFIDCardReaderStartToReadEvent()
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            UCShowRFIDCard(CardNo)
            RaiseEvent UCRFIDCardReadedEvent(R2CoreMClassRFIDCardManagement.GetNSSRFIDCard(CardNo))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf+ ex.Message)
        End Try
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
        UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + MessageWarning, "", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
    End Sub

#End Region



End Class
