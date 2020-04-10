
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.BaseStandardClass


Public Class UCDomain
    Inherits UCGeneral

    Public Event UCNSSCurrentChangedEvent(UC As UCDomain)
    Public Event UCClickedEvent(UC As UCDomain)
    Public Event UCSelectEvent(UC As UCDomain)
    Public Event UCUnSelectEvent(UC As UCDomain)
    Protected Event UCViewNSSRequestedEvent()
    Protected Event UCChangeColorToActiveRequestedEvent()
    Protected Event UCChangeColorToUnActiveRequestedEvent()
    Protected Event UCViewNSSNothingRequestedEvent()
    Protected Event UCFontChangeRequestEvent()
    Protected Event UCRefreshInformationRequestedEvent()
    Protected Event UCSwitchedMaxMinHightRequestedEvent()
    Protected Event UCNSSCurrentChangedToNothingEvent()

    Protected Property UCActiveForeColor As Color = Color.White
    Protected Property UCUnActiveForeColor As Color = Color.Black
    Protected Property UCUnActiveBackColor As Color = Color.LightGray


#Region "General Properties"

    Private _UCNSSCurrent As R2StandardStructure = Nothing
    <Browsable(False)>
    Public Property UCNSSCurrent() As R2StandardStructure
        Get
            Return _UCNSSCurrent
        End Get
        Set(value As R2StandardStructure)
            _UCNSSCurrent = value
            If value Is Nothing Then
                RaiseEvent UCNSSCurrentChangedToNothingEvent()
            Else
                RaiseEvent UCNSSCurrentChangedEvent(Me)
            End If
        End Set
    End Property

    Private _UCPadding As Padding = New Padding(5)
    <Browsable(True)>
    Public Property UCPadding As Padding
        Get
            Return _UCPadding
        End Get
        Set(value As Padding)
            _UCPadding = value
            Me.Padding = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    <Browsable(True)>
    Public Property UCFont As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            RaiseEvent UCFontChangeRequestEvent()
        End Set
    End Property

    <Browsable(True)>
    Public Property UCMaxMinHeightDifference As Int64 = Int64.MaxValue

    Private _UCCurrentMaxMinStatus As R2Core.R2Enums.MaxMin = R2Core.R2Enums.MaxMin.Min
    <Browsable(True)>
    Public Property UCCurrentMaxMinStatus As R2Core.R2Enums.MaxMin
        Get
            Return _UCCurrentMaxMinStatus
        End Get
        Set(value As R2Core.R2Enums.MaxMin)
            Try
                If _UCCurrentMaxMinStatus = R2Core.R2Enums.MaxMin.Max Then
                    Me.Size = New Size(Me.Width, Me.Height - UCMaxMinHeightDifference)
                    _UCCurrentMaxMinStatus = R2Core.R2Enums.MaxMin.Min
                    RaiseEvent UCSwitchedMaxMinHightRequestedEvent()
                Else
                    Me.Size = New Size(Me.Width, Me.Height + UCMaxMinHeightDifference)
                    _UCCurrentMaxMinStatus = R2Core.R2Enums.MaxMin.Max
                    RaiseEvent UCSwitchedMaxMinHightRequestedEvent()
                End If
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Overridable Sub UCRefreshInformation()
        Try
            RaiseEvent UCRefreshInformationRequestedEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            UCNSSCurrent = Nothing
            UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardStructure)
        Try
            UCNSSCurrent = YourNSS
            If YourNSS Is Nothing Then RaiseEvent UCViewNSSNothingRequestedEvent()
            RaiseEvent UCViewNSSRequestedEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCShowUnActive()
        RaiseEvent UCChangeColorToUnActiveRequestedEvent()
    End Sub

    Public Sub UCShowActive()
        RaiseEvent UCChangeColorToActiveRequestedEvent()
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
