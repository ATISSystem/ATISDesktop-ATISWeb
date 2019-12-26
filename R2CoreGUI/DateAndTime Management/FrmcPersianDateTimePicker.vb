
Imports FreeControls

Imports R2Core.DateAndTimeManagement

Public Class FrmcPersianDateTimePicker

    Public Event PersianDateTimeChangedEvent(DateTime As R2StandardDateAndTimeStructure)

#Region "General Properties"


#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Owner = R2CoreGUIMClassGUIManagement.FrmMainMenu
        PersianMonthCalendar.Value = Now
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PersianMonthCalendar_ValueChanged(sender As Object, e As PersianMonthCalendarEventArgs) Handles PersianMonthCalendar.ValueChanged
        Try
            Dim Year As String = e.CurrentValue.Year.ToString()
            Dim Month As String = R2Core.PublicProc.R2CoreMClassPublicProcedures.RepeatStr("0", 2 - e.CurrentValue.Month.ToString().Length) + e.CurrentValue.Month.ToString()
            Dim Day As String = R2Core.PublicProc.R2CoreMClassPublicProcedures.RepeatStr("0", 2 - e.CurrentValue.Day.ToString().Length) + e.CurrentValue.Day.ToString()
            RaiseEvent PersianDateTimeChangedEvent(New R2StandardDateAndTimeStructure(Nothing, Year + "/" + Month + "/" + Day, Nothing))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Me.Hide()
        Me.Close()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class