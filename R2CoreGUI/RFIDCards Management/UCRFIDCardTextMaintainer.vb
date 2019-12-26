
Imports System.Reflection

Imports R2Core.RFIDCardsManagement
Imports R2Core.ConfigurationManagement

Public Class UCRFIDCardTextMaintainer
    Inherits UCGeneral

    Public Event UC13PressedEvent(YourText As String)


#Region "General Properties"

    Public Property UCValue() As String
        Get
            Return UcTextBoxRFIDCardNO.UCValue
        End Get
        Set(value As String)
            UcTextBoxRFIDCardNO.UCValue = value
        End Set
    End Property

    Private _UCEnable As Boolean = True
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            If value = True Then
                UcTextBoxRFIDCardNO.UCEnable = True
                PicReturn.Visible = True
            Else
                UcTextBoxRFIDCardNO.UCEnable = False
                PicReturn.Visible = False
            End If
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcTextBoxRFIDCardNO.UCRefresh()
    End Sub

    Private Sub UCFillUCTextBoxRFIDCardId()
        Try
            UcTextBoxRFIDCardId.UCValue = R2CoreMClassRFIDCardManagement.GetNSSRFIDCard(UcTextBoxRFIDCardNO.UCValue).CardId
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcTextBox_UC13PressedEvent(CurrentText As String) Handles UcTextBoxRFIDCardNO.UC13PressedEvent
        Try
            UCFillUCTextBoxRFIDCardId
            RaiseEvent UC13PressedEvent(UCValue)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicReturn_Click(sender As Object, e As EventArgs) Handles PicReturn.Click
        Try
            UCFillUCTextBoxRFIDCardId
            RaiseEvent UC13PressedEvent(UCValue)
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
