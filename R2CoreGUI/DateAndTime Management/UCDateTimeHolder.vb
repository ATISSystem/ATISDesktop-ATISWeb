
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI


Public Class UCDateTimeHolder
    Inherits UCGeneral



    Private _DateTime As R2DateTime = New R2DateTime()
    Public Event UCDoCommand()


#Region "General Properties"

    Private _DisableTimeSetting As Boolean = False
    <Browsable(True)>
    Public Property UCDisableTimeSetting As Boolean
        Get
            Return _DisableTimeSetting
        End Get
        Set(value As Boolean)
            _DisableTimeSetting = value
            If value = True Then
                UcTimeEntry1.UCEnable = False
                UcTimeEntry2.UCEnable = False
            Else
                UcTimeEntry1.UCEnable = True
                UcTimeEntry2.UCEnable = True
            End If
        End Set
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetConcat1 As String
        Get
            Return UcPersianShamsiDate1.UCGetDate.DateShamsiFull.Replace("/", "") + UcTimeEntry1.UCGetTime.Time.Replace(":", "")
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetConcat2 As String
        Get
            Return UcPersianShamsiDate2.UCGetDate.DateShamsiFull.Replace("/", "") + UcTimeEntry2.UCGetTime.Time.Replace(":", "")
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetDate1() As String
        Get
            Return UcPersianShamsiDate1.UCGetDate.DateShamsiFull
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetDate2() As String
        Get
            Return UcPersianShamsiDate2.UCGetDate.DateShamsiFull
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetTime1() As String
        Get
            Return UcTimeEntry1.UCGetTime.Time
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetTime2() As String
        Get
            Return UcTimeEntry2.UCGetTime.Time
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetDateTime1() As R2StandardDateAndTimeStructure
        Get
            Return New R2StandardDateAndTimeStructure(_DateTime.GetMilladiDateTimeFromDateShamsiFull(UCGetDate1, UCGetTime1), UCGetDate1, UCGetTime1)
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property UCGetDateTime2() As R2StandardDateAndTimeStructure
        Get
            Return New R2StandardDateAndTimeStructure(_DateTime.GetMilladiDateTimeFromDateShamsiFull(UCGetDate2, UCGetTime2), UCGetDate2, UCGetTime2)
        End Get
    End Property

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

    Public Property UCTime1 As String
        Get
            Return UCGetTime1
        End Get
        Set(value As String)
            UcTimeEntry1.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, value))
        End Set
    End Property

    Public Property UCTime2 As String
        Get
            Return UCGetTime2
        End Get
        Set(value As String)
            UcTimeEntry2.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, value))
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            'UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCReset()
        Try
            UcPersianShamsiDate1.UCSetDate(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing))
            UcPersianShamsiDate2.UCSetDate(New R2StandardDateAndTimeStructure(Nothing, _DateTime.GetCurrentDateShamsiFull(), Nothing))
            UcTimeEntry1.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, _DateTime.GetCurrentTime()))
            UcTimeEntry2.UCSetTime(New R2StandardDateAndTimeStructure(Nothing, Nothing, _DateTime.GetCurrentTime()))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonSpecial_UCClickedEvent() Handles UcButtonSpecial.UCClickedEvent
        Try
            RaiseEvent UCDoCommand()
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
