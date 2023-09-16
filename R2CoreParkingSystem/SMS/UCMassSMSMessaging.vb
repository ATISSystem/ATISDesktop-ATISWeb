

Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.SMS.SMSHandling
Imports R2Core.SMS.SMSResultLogging
Imports R2Core.SMS.SMSTypes
Imports R2CoreGUI

Public Class UCMassSMSMessaging
    Inherits UCGeneral

    Public Event UCSendSMSCompletedEvent(SMSResult As List(Of KeyValuePair(Of Int64, String)))


#Region "General Properties"
    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcSearcherSMSTypes_UCItemSelectedEvent(SelectedItem As R2StandardStructure) Handles UcSearcherSMSTypes.UCItemSelectedEvent
        Try
            Dim InstanceSMSTypes = New R2CoreMClassSMSTypesManager
            Dim NSSSMSType = InstanceSMSTypes.GetNSSSMSType(UcSearcherSMSTypes.UCGetSelectedNSS().OCode)
            UcPersianTextBox.UCValue = NSSSMSType.SMSTypeContent
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcEntrySMSData_UCSubmitEvent() Handles UcEntrySMSData.UCSubmitEvent
        Try
            Dim InstanceSMSTypes = New R2CoreMClassSMSTypesManager
            Dim NSSSMSType = InstanceSMSTypes.GetNSSSMSType(UcSearcherSMSTypes.UCGetSelectedNSS().OCode)
            Dim InstanceSMSHandling = New R2CoreSMSHandlingManager
            UcPersianTextBox.UCValue = InstanceSMSHandling.GetCompositedSMSCreationData(NSSSMSType, UcEntrySMSData.UCGetParams)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSpecial_UCClickedEvent() Handles UcButtonSpecial.UCClickedEvent
        Try
            Dim InstanceSMSHandling = New R2CoreSMSHandlingManager
            Dim SMSResult = InstanceSMSHandling.SendSMS(UcSearcherSMSTypes.UCGetSelectedNSS.OCode, UcSearcherUserTypes.UCGetSelectedNSS.OCode, UcEntrySMSData.UCGetParams)
            Dim SMSResultAnalyze = InstanceSMSHandling.GetSMSResultAnalyze(SMSResult)
            If Not (SMSResultAnalyze = String.Empty) Then
                Dim InstanceLoggingSMSResult = New R2CoreLoggingSMSResultManager
                InstanceLoggingSMSResult.Logging(SMSResult, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            End If
            RaiseEvent UCSendSMSCompletedEvent(SMSResult)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCMassSMSMessaging_UCSendSMSCompletedEvent(SMSResult As List(Of KeyValuePair(Of Long, String))) Handles Me.UCSendSMSCompletedEvent
        Try
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "درخواست شما با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
