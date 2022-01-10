
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.DateAndTimeManagement


Public Class UCPersianDateTimeEntry
    Inherits UCGeneral

    Public Event UCDateTimeChangedEvent()

#Region "General Properties"

    Public ReadOnly Property GetPersianDate As R2StandardDateAndTimeStructure
        Get
            Return UcPersianShamsiDate.UCGetDate
        End Get
    End Property

    Public ReadOnly Property GetTime As R2StandardDateAndTimeStructure
        Get
            Return UcTimeEntry.UCGetTime
        End Get
    End Property

    Public ReadOnly Property GetPersianDateTime As R2StandardDateAndTimeStructure
        Get
            Return New R2StandardDateAndTimeStructure(Nothing, UcPersianShamsiDate.UCGetDate.DateShamsiFull, UcTimeEntry.UCGetTime.Time)
        End Get
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            UcPersianShamsiDate.UCRefreshGeneral()
            UcTimeEntry.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        UcTimeEntry.UCUserTime = _DateTime.GetCurrentTime
    End Sub






#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianShamsiDate_UCPersianShamsiDateChangedEvent() Handles UcPersianShamsiDate.UCPersianShamsiDateChangedEvent
        RaiseEvent UCDateTimeChangedEvent()
    End Sub

    Private Sub UcTimeEntry_UCTimeChangedEvent() Handles UcTimeEntry.UCTimeChangedEvent
        RaiseEvent UCDateTimeChangedEvent()
    End Sub
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
