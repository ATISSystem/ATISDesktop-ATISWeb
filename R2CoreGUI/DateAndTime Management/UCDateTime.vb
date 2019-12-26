

Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement

Public Class UCDateTime
    Inherits R2CoreGUI.UCGeneral

    Private ReadOnly _DateTime As R2DateTime = New R2DateTime
    Private WithEvents _TimerDateTime As New System.Windows.Forms.Timer





#Region "General Properties"


    Private _UCClockIconAppierance As Boolean = True
    Public Property UCClockIconAppierance() As Boolean
        Get
            Return _UCClockIconAppierance
        End Get
        Set(value As Boolean)
            _UCClockIconAppierance = value
            PicClockIcon.Visible = value
            If value = True Then
                UcLabelDateTime.Dock = DockStyle.Left
            Else
                UcLabelDateTime.Dock = DockStyle.Fill
            End If

        End Set
    End Property




    Private _UCBackColor As Color = Color.Transparent
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            PnlMain.BackColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            UcLabelDateTime.UCForeColor = value
        End Set
    End Property

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            UcLabelDateTime.UCFont = value
        End Set
    End Property

    Private _UCEnable As Boolean = True
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            Me.Enabled = value
            If value = True Then
                _TimerDateTime.Enabled = True
                _TimerDateTime.Start()
            Else
                _TimerDateTime.Enabled = False
                _TimerDateTime.Stop()
            End If
        End Set
    End Property
#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        MyBase.New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _TimerDateTime.Interval = 60000
            _TimerDateTime.Enabled = True
            _TimerDateTime.Start()
            SetCurrentDateTime()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub SetCurrentDateTime()
        Try
            UcLabelDateTime.UCValue = _DateTime.GetCurrentDateShamsiFull + "     " + Mid(_DateTime.GetCurrentTime(), 1, 5)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Overrides Sub DisposeResources()
        _TimerDateTime.Stop()
        _TimerDateTime.Enabled = False
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _TimerDateTime_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _TimerDateTime.Tick
        Try
            SetCurrentDateTime()
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
