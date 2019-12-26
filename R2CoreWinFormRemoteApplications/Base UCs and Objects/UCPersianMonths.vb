

Public Class UCPersianMonths
    Inherits UCGeneral

#Region "General Properties"

    Public ReadOnly Property UCGetSelectedMonthName() As String
        Get
            If LstMonths.SelectedIndex >= 0 Then
                Return LstMonths.SelectedItem
            Else
                Throw New Exception("ابتدا ماه را انتخاب کنید")
            End If
        End Get
    End Property

    Public ReadOnly Property UCGetSelectedMonthCode As String
        Get
            If LstMonths.SelectedIndex < 0 Then Throw New Exception("ابتدا ماه را انتخاب کنید")
            Select Case LstMonths.SelectedItem
                Case "فروردین"
                    Return "01"
                Case "اردیبهشت"
                    Return "02"
                Case "خرداد"
                    Return "03"
                Case "تیر"
                    Return "04"
                Case "مرداد"
                    Return "05"
                Case "شهریور"
                    Return "06"
                Case "مهر"
                    Return "07"
                Case "آبان"
                    Return "08"
                Case "آذر"
                    Return "09"
                Case "دی"
                    Return "10"
                Case "بهمن"
                    Return "11"
                Case "اسفند"
                    Return "12"
            End Select
        End Get
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
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
