
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.SoftwareUserManagement
Imports R2Core.PublicProc


Public Class UCLog
    Inherits UCGeneral

    Public Event UCViewLogRequested(NSSLog As R2CoreStandardLoggingStructure)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(YourNSSLog As R2CoreStandardLoggingStructure)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewLog(YourNSSLog)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCViewLog(YourLog As R2CoreStandardLoggingStructure)
        Try
            RaiseEvent UCViewLogRequested(YourLog)
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
