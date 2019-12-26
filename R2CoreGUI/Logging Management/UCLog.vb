
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2Core.UserManagement
Imports R2Core.PublicProc


Public Class UCLog
    Inherits UCGeneral

    Private _DateTime As New R2DateTime


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

    Public Sub UCRefresh()
        UcLabelSharh.UCValue = "" : UcLabelDateShamsi.UCValue = "" : UcLabelUserName.UCValue = "" : UcLabelOptional1.UCValue = ""
    End Sub

    Private Sub UCViewLog(YourLog As R2CoreStandardLoggingStructure)
        Try
            UCRefresh()
            UcLabelSharh.UCValue = YourLog.Sharh
            UcLabelDateShamsi.UCValue = YourLog.DateShamsi
            UcLabelTime.UCValue = _DateTime.GetTimeOfDate(YourLog.DateTimeMilladi)
            UcLabelUserName.UCValue = R2CoreMClassLoginManagement.GetNSSUser(YourLog.UserId).UserName.Trim
            UcLabelOptional1.UCValue = YourLog.Optional1
            PnlMain.BackColor = R2CoreMClassLoggingManagement.GetNSSLogtype(YourLog.Logtype).LogColor
            Dim InvertColor As Color = R2CoreMClassPublicProcedures.GetInvertColor(PnlMain.BackColor)
            UcLabelDateShamsi.UCForeColor = InvertColor
            UcLabelTime.UCForeColor = InvertColor
            UcLabelOptional1.UCForeColor = InvertColor
            UcLabelSharh.UCForeColor = InvertColor
            UcLabelUserName.UCForeColor = InvertColor
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
