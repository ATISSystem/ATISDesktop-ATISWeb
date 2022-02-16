
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI



Public Class UCSoftwareUser
    Inherits UCGeneralExtended

    Public Event UCNSSCurrentChanged(NSSCurrent As R2CoreStandardSoftwareUserStructure)
    Protected Event UCViewNSSRequested(NSSCurrent As R2CoreStandardSoftwareUserStructure)
    Public Event UCOrderingOptionChanged(OrderingOption As R2CoreSoftwareUsersOrderingOptions)

#Region "General Properties"
    Private _UCNSSCurrent As R2CoreStandardSoftwareUserStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2CoreStandardSoftwareUserStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2CoreStandardSoftwareUserStructure)
            _UCNSSCurrent = value
            RaiseEvent UCNSSCurrentChanged(_UCNSSCurrent)
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overridable Sub UCRefreshGeneral()
        Try
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overridable Sub UCRefreshInformation()
        Try
            UCNSSCurrent = Nothing
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreStandardSoftwareUserStructure)
        Try
            UCNSSCurrent = YourNSS
            RaiseEvent UCViewNSSRequested(UCNSSCurrent)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Sub UCOrderingOptionChangedApply(YourOrderingOption As R2CoreSoftwareUsersOrderingOptions)
        Try
            RaiseEvent UCOrderingOptionChanged(YourOrderingOption)
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
