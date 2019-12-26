
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI

Imports TWSClassLibrary.LoggingManagement
Imports TWSClassLibrary.DateAndTimeManagement
Imports TWSClassLibrary.NobatsManagement

Public Class UcSingleLogHolder
    Inherits UCGeneral

    Private _DateTime As R2DateTime = New R2DateTime()
    Public Event UCClickedEvent(ByVal YourCurrentTruckTrace As StandardTruckTraceStructure)
    Private _CurrentTruckTrace As StandardTruckTraceStructure

#Region "General Properties"

    Private Sub LblsClicked_Handler(ByVal sender As Object, ByVal e As EventArgs) Handles LblShamsiDate.Click, LblStatus.Click, LblTerminal.Click, LblTime.Click, LblTraceWriter.Click, LblTravelTime.Click
        Try
            RaiseEvent UCClickedEvent(_CurrentTruckTrace)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name +vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage , Nothing, Me)
        End Try
    End Sub

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub ShowInf(ByVal YourTruckTrace As StandardTruckTraceStructure)
        Try
            _CurrentTruckTrace = YourTruckTrace
            Dim myStatus As NobatsStatus = YourTruckTrace.Status
            LblStatus.Text = TWSClassNobatsManagement.GetStatusNameByCode(myStatus)
            If (myStatus = NobatsStatus.Added) Or (myStatus = NobatsStatus.Sodoor) Then
                LblShamsiDate.Text = _DateTime.ConvertToShamsiDateFull(YourTruckTrace.SodoorTime)
                LblTime.Text = _DateTime.GetTimeOfDate(YourTruckTrace.SodoorTime)
            ElseIf myStatus = NobatsStatus.Deleted Then
                If YourTruckTrace.TraceWriter.Trim = "WebService" Then
                    LblShamsiDate.Text = _DateTime.ConvertToShamsiDateFull(YourTruckTrace.SodoorTime)
                    LblTime.Text = _DateTime.GetTimeOfDate(YourTruckTrace.SodoorTime)
                Else
                    LblShamsiDate.Text = TWSClassDateAndTimeManagement.ConvertToShamsiDate(YourTruckTrace.DateReal)
                    LblTime.Text = _DateTime.GetTimeOfDate(YourTruckTrace.DateReal)
                End If
            ElseIf (myStatus = NobatsStatus.DelNobatBarnamehOnline) Or (myStatus = NobatsStatus.DelNobatOverOne1) Or (myStatus = NobatsStatus.DelNobatUserRequest) Then
                LblShamsiDate.Text = TWSClassDateAndTimeManagement.ConvertToShamsiDate(YourTruckTrace.DateReal)
                LblTime.Text = _DateTime.GetTimeOfDate(YourTruckTrace.DateReal)
            End If
            LblTerminal.Text = YourTruckTrace.TerminalName
            LblTraceWriter.Text = YourTruckTrace.TraceWriter
            If myStatus = NobatsStatus.Added Then
                PnlMain.BackColor = Color.Green
                LblTravelTime.Text = ""
            ElseIf myStatus = NobatsStatus.Deleted Then
                PnlMain.BackColor = Color.Red
                LblTravelTime.Text = ""
            ElseIf myStatus = NobatsStatus.Sodoor Then
                PnlMain.BackColor = Color.Blue
                LblTravelTime.Text = YourTruckTrace.TravelTime
            ElseIf myStatus = NobatsStatus.DelNobatBarnamehOnline Then
                PnlMain.BackColor = Color.DodgerBlue
                LblTravelTime.Text = ""
            ElseIf myStatus = NobatsStatus.DelNobatOverOne1 Then
                PnlMain.BackColor = Color.DeepPink
                LblTravelTime.Text = ""
            ElseIf myStatus = NobatsStatus.DelNobatUserRequest Then
                PnlMain.BackColor = Color.Magenta
                LblTravelTime.Text = ""
            ElseIf myStatus = NobatsStatus.None Then
                PnlMain.BackColor = Color.White
                LblTravelTime.Text = ""
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region








End Class
