
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2Core.HumanResourcesManagement.Personnel

Public Class UCPersianShamsiDate
    Inherits UCGeneral

    Private Shadows ReadOnly _DateTime As New R2DateTime
    Private WithEvents _PersianDateTimePicker As FrmcPersianDateTimePicker = New FrmcPersianDateTimePicker()
    Public Event UCPersianShamsiDateChangedEvent()

#Region "General Properties"

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            UcTextBoxYear.UCFont = value
            UcTextBoxMonth.UCFont = value
            UcTextBoxDay.UCFont = value
        End Set
    End Property



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
            Dim CurrentDateTime As R2StandardDateAndTimeStructure = New R2StandardDateAndTimeStructure(_DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime)
            UcTextBoxYear.UCValue = CurrentDateTime.GetShamsiYear
            UcTextBoxMonth.UCValue = CurrentDateTime.GetShamsiMonth
            UcTextBoxDay.UCValue = CurrentDateTime.GetShamsiDay
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetDirtDate() As String
        Return UcTextBoxYear.UCValue.Trim + "/" + UcTextBoxMonth.UCValue.Trim + "/" + UcTextBoxDay.UCValue.Trim
    End Function

    Public Function UCGetDate() As R2StandardDateAndTimeStructure
        Try
            Dim DirtDate As String = GetDirtDate()
            If _DateTime.ChekDateShamsiFullSyntax(DirtDate) Then
                Return New R2StandardDateAndTimeStructure(Nothing, DirtDate, Nothing)
            Else
                Throw New ShamsiDateSyntaxNotValidException
            End If

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Sub UCSetDate(YourShamsiDate As R2StandardDateAndTimeStructure)
        Try
            UcTextBoxYear.UCValue = YourShamsiDate.GetShamsiYear
            UcTextBoxMonth.UCValue = YourShamsiDate.GetShamsiMonth
            UcTextBoxDay.UCValue = YourShamsiDate.GetShamsiDay
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcTextBoxYear_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxYear.UCMaxCharacterReachedEvent
        If CursorPosition = UcTextBoxYear.UCMaxCharacterReached Then UcTextBoxMonth.UCFocus()
    End Sub

    Private Sub UcTextBoxMonth_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxMonth.UCMaxCharacterReachedEvent
        If CursorPosition = UcTextBoxMonth.UCMaxCharacterReached Then UcTextBoxDay.UCFocus()
    End Sub

    Private Sub UcTextBoxDay_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxDay.UCMaxCharacterReachedEvent
    End Sub

    Private Sub UcTextBoxYear_UC13PressedEvent(CurrentText As String) Handles UcTextBoxYear.UC13PressedEvent
        UcTextBoxMonth.UCFocus()
    End Sub

    Private Sub UcTextBoxMonth_UC13PressedEvent(CurrentText As String) Handles UcTextBoxMonth.UC13PressedEvent
        UcTextBoxDay.UCFocus()
    End Sub

    Private Sub UcTextBoxYear_UCRightArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxYear.UCRightArrowKeyPressedEvent
        If CursorPosition = UcTextBoxYear.UCMaxCharacterReached Then UcTextBoxMonth.UCFocus()
    End Sub

    Private Sub UcTextBoxMonth_UCRightArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxMonth.UCRightArrowKeyPressedEvent
        If CursorPosition = UcTextBoxMonth.UCMaxCharacterReached Then UcTextBoxDay.UCFocus()
    End Sub

    Private Sub UcTextBoxDay_UCLeftArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxDay.UCLeftArrowKeyPressedEvent
        If CursorPosition = 0 Then UcTextBoxMonth.UCFocus()
    End Sub

    Private Sub UcTextBoxMonth_UCLeftArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxMonth.UCLeftArrowKeyPressedEvent
        If CursorPosition = 0 Then UcTextBoxYear.UCFocus()
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        '_PersianDateTimePicker.Location =PointToScreen(new Point(me.Left+20,Me.Bottom-20))
        _PersianDateTimePicker.ShowDialog()
    End Sub

    Private Sub _PersianDateTimePicker_PersianDateTimeChangedEvent(DateTime As R2StandardDateAndTimeStructure) Handles _PersianDateTimePicker.PersianDateTimeChangedEvent
        Try
            UCSetDate(New R2StandardDateAndTimeStructure(Nothing, DateTime.DateShamsiFull, Nothing))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcTextBoxs_UCTextChangedEvent(CurrentText As String) Handles UcTextBoxYear.UCTextChangedEvent, UcTextBoxMonth.UCTextChangedEvent, UcTextBoxDay.UCTextChangedEvent
        Try
            RaiseEvent UCPersianShamsiDateChangedEvent()
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
