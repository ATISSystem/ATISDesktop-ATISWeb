
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2Core.HumanResourcesManagement.Personnel

Public Class UCTimeEntry
    Inherits UCGeneral

    Private Shadows ReadOnly _DateTime As New R2DateTime

#Region "General Properties"


    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            UcTextBoxHour.UCBackColor = value
            UcTextBoxMinute.UCBackColor = value
            UcTextBoxSecond.UCBackColor = value
        End Set
    End Property

    Private _UCBackColorDisable As Color = Color.Gainsboro
    Public Property UCBackColorDisable() As Color
        Get
            Return _UCBackColorDisable
        End Get
        Set(value As Color)
            _UCBackColorDisable = value
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
                UcTextBoxHour.BackColor = UCBackColor
                UcTextBoxHour.UCEnable = True
                UcTextBoxMinute.BackColor = UCBackColor
                UcTextBoxMinute.UCEnable = True
                UcTextBoxSecond.BackColor = UCBackColor
                UcTextBoxSecond.UCEnable = True
            Else
                UcTextBoxHour.UCBackColor = UCBackColorDisable
                UcTextBoxHour.UCEnable = False
                UcTextBoxMinute.UCBackColor = UCBackColorDisable
                UcTextBoxMinute.UCEnable = False
                UcTextBoxSecond.UCBackColor = UCBackColorDisable
                UcTextBoxSecond.UCEnable = False
            End If
        End Set
    End Property

    <Browsable(True)>
    Public Property UCUserTime() As String
        Get
            Return UCGetTime().Time
        End Get
        Set(value As String)
            UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, value))
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            UcTextBoxHour.UCFont = value
            UcTextBoxMinute.UCFont = value
            UcTextBoxSecond.UCFont = value
        End Set
    End Property




#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Dim CurrentDateTime As R2StandardDateAndTimeStructure = New R2StandardDateAndTimeStructure(_DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull(), _DateTime.GetCurrentTime)
            UcTextBoxHour.UCValue = CurrentDateTime.GetHour
            UcTextBoxMinute.UCValue = CurrentDateTime.GetMinute
            UcTextBoxSecond.UCValue = CurrentDateTime.GetSecond
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetDirtTime() As String
        Return UcTextBoxHour.UCValue.Trim + ":" + UcTextBoxMinute.UCValue.Trim + ":" + UcTextBoxSecond.UCValue.Trim
    End Function

    Public Function UCGetTime() As R2StandardDateAndTimeStructure

        Dim DirtTime As String = GetDirtTime()
        If _DateTime.ChekTimeSyntax(DirtTime) Then
            Return New R2StandardDateAndTimeStructure(Nothing, Nothing, DirtTime)
        Else
            Throw New TimeSyntaxNotValidException
        End If
    End Function

    Public Sub UCSetTime(YourTime As R2StandardDateAndTimeStructure)
        Try
            UcTextBoxHour.UCValue = YourTime.GetHour
            UcTextBoxMinute.UCValue = YourTime.GetMinute
            UcTextBoxSecond.UCValue = YourTime.GetSecond
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSetCurrentTime()
        Try
            UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, _DateTime.GetCurrentTime()))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcTextBoxHour_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxHour.UCMaxCharacterReachedEvent
        If CursorPosition = UcTextBoxHour.UCMaxCharacterReached Then UcTextBoxMinute.UCFocus()
    End Sub

    Private Sub UcTextBoxMinute_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxMinute.UCMaxCharacterReachedEvent
        If CursorPosition = UcTextBoxSecond.UCMaxCharacterReached Then UcTextBoxSecond.UCFocus()
    End Sub

    Private Sub UcTextBoxSecond_UCMaxCharacterReachedEvent(CursorPosition As Int64) Handles UcTextBoxSecond.UCMaxCharacterReachedEvent
    End Sub

    Private Sub UcTextBoxHour_UC13PressedEvent(CurrentText As String) Handles UcTextBoxHour.UC13PressedEvent
        UcTextBoxMinute.UCFocus()
    End Sub

    Private Sub UcTextBoxMinute_UC13PressedEvent(CurrentText As String) Handles UcTextBoxMinute.UC13PressedEvent
        UcTextBoxSecond.UCFocus()
    End Sub

    Private Sub UcTextBoxHour_UCRightArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxHour.UCRightArrowKeyPressedEvent
        If CursorPosition = UcTextBoxHour.UCMaxCharacterReached Then UcTextBoxMinute.UCFocus()
    End Sub

    Private Sub UcTextBoxMinute_UCRightArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxMinute.UCRightArrowKeyPressedEvent
        If CursorPosition = UcTextBoxMinute.UCMaxCharacterReached Then UcTextBoxSecond.UCFocus()
    End Sub

    Private Sub UcTextBoxSecond_UCLeftArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxSecond.UCLeftArrowKeyPressedEvent
        If CursorPosition = 0 Then UcTextBoxMinute.UCFocus()
    End Sub

    Private Sub UcTextBoxMinute_UCLeftArrowKeyPressedEvent(CursorPosition As Long) Handles UcTextBoxMinute.UCLeftArrowKeyPressedEvent
        If CursorPosition = 0 Then UcTextBoxHour.UCFocus()
    End Sub






#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
