
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.RFIDCardsManagement
Imports R2CoreGUI
Imports R2Core.R2PrimaryWS
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.ReportsManagement

Public Class UCCarEntranceReport
    Inherits UCGeneral
    Implements R2CoreRFIDCardRequester

    Private _WS As R2PrimaryWebService = New R2PrimaryWebService()


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

    Private Sub RadioButtonCar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCar.CheckedChanged
        If RadioButtonCar.Checked = True Then
            UcrfidCardTextMaintainer.UCEnable = False
            UcCar.Enabled = True
        ElseIf RadioButtonCar.Checked = False Then
            UcrfidCardTextMaintainer.UCEnable = True
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
            UcCar.Enabled = False
        End If
    End Sub

    Private Sub UcDateTimeHolder_UCDoCommand() Handles UcDateTimeHolder.UCDoCommand
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Pelak As String = String.Empty
            Dim Serial As String = String.Empty
            If RadioButtonCar.Checked Then
                Pelak = IIf(RadioButtonCar.Checked = True, UcCar.UCGetNSS.StrCarNo, String.Empty)
                Serial = IIf(RadioButtonCar.Checked = True, UcCar.UCGetNSS.StrCarSerialNo, String.Empty)
            End If
            Dim EntranceDateTimeSupport As EnterExitManagement.R2EnterExitRequestType = IIf(RadioButtonEntranceDateTimeSupportEnter.Checked = True, R2EnterExitRequestType.EnterRequest, R2EnterExitRequestType.ExitRequest)
            Dim TerraficCard As String = IIf(RadioButtonTerraficCard.Checked = True, UcrfidCardTextMaintainer.UCValue, String.Empty)
            _WS.WebMethodReportingInformationPrividerCarEntranceReport(UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, TerraficCard, Pelak, Serial, EntranceDateTimeSupport, ChkViewCarImage.Checked)
            R2CoreGUIMClassInformationManagement.PrintReport(R2CoreParkingSystemReports.CarEntranceReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead

    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        UcrfidCardTextMaintainer.UCValue = CardNo
    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning

    End Sub

#End Region





End Class
