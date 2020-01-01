

Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.MonetarySettingTools


Public Class UCMonetarySettingTool
    Inherits UCGeneral

    Public Event UCNSSCurrentChanged(NSSCurrent As R2CoreStandardMonetarySettingToolStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2CoreStandardMonetarySettingToolStructure)
    Protected Event UCChangeColorToActiveRequested()
    Protected Event UCChangeColorToUnActiveRequested()
    Protected Event UCViewNSSNothingRequested()

    Protected Property UCActiveForeColor As Color = Color.White
    Protected Property UCUnActiveForeColor As Color = Color.Black
    Protected Property UCUnActiveBackColor As Color = Color.LightGray



#Region "General Properties"

    Private _UCNSSCurrent As R2CoreStandardMonetarySettingToolStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2CoreStandardMonetarySettingToolStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreStandardMonetarySettingToolStructure)
            _UCNSSCurrent = value
            If value Is Nothing Then
                RaiseEvent UCViewNSSNothingRequested()
            Else
                RaiseEvent UCNSSCurrentChanged(_UCNSSCurrent)
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

    Public Overloads Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreStandardMonetarySettingToolStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourMSTId As Int64)
        Try
            UCNSSCurrent = R2CoreMonetarySettingToolsManagement.GetNSSMonetarySettingTool(YourMSTId)
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCShowUnActive()
        RaiseEvent UCChangeColorToUnActiveRequested()
    End Sub

    Public Sub UCShowActive()
        RaiseEvent UCChangeColorToActiveRequested()
    End Sub

    Public Sub UCActivationToken(YourNSS As R2CoreStandardMonetarySettingToolStructure)
        Try
            If YourNSS.MSTId = UCNSSCurrent.MSTId Then Me.Enabled = YourNSS.Active
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
