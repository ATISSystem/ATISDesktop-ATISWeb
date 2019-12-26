
Imports System.Reflection
Imports R2Core

Public Class UCMinimizeMaximize
    Inherits UCGeneral

    Public Event UCMinimizeRequestedEvent()
    Public Event UCMaximizeRequestedEvent()


#Region "General Properties"

    Private _UCCurrentMaxMinStatus As R2Core.R2Enums.MaxMin = R2Enums.MaxMin.None
    Public Property UCCurrentMaxMinStatus() As R2Enums.MaxMin
        Get
            Return _UCCurrentMaxMinStatus
        End Get
        Set(value As R2Enums.MaxMin)
            _UCCurrentMaxMinStatus = value
            If value = R2Enums.MaxMin.Max Then
                RaiseEvent UCMaximizeRequestedEvent()
            ElseIf value = R2Enums.MaxMin.Min Then
                RaiseEvent UCMinimizeRequestedEvent()
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

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub PictureBox_Click(sender As Object, e As MouseEventArgs) Handles PictureBox.Click
        Try
            If UCCurrentMaxMinStatus = R2Enums.MaxMin.Min Then
                UCCurrentMaxMinStatus = R2Enums.MaxMin.Max
            ElseIf UCCurrentMaxMinStatus = R2Enums.MaxMin.Max Then
                UCCurrentMaxMinStatus = R2Enums.MaxMin.Min
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
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
