

Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Public Class FrmcGeneral



    Protected _FrmMessageDialog As New FrmcMessageDialog
    Protected Event _UCDisposeRequest()
    Private WithEvents _LocalMessageCleanTimer As System.Windows.Forms.Timer = New Timer
    Public Event _ExitRequest()

#Region "General Properties"

    Private _FrmPersianName As String = String.Empty
    Public Property FrmPersianName() As String
        Get
            Return _FrmPersianName
        End Get
        Set(value As String)
            _FrmPersianName = value
            LblformPersianName.Text = value
        End Set
    End Property


    Private _FrmEnglishName As String = String.Empty
    Public Property FrmEnglishName() As String
        Get
            Return _FrmEnglishName
        End Get
        Set(value As String)
            _FrmEnglishName = value
            LblformEnglishName.Text = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _LocalMessageCleanTimer.Interval = 10000
            _LocalMessageCleanTimer.Enabled = True
            _LocalMessageCleanTimer.Start()
            'If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
            'Else
            '    InitializeSpecial()
            'End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Protected Sub InitializeSpecial()
        Try
            Me.Location = New Point(5, 121)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
            Me.Height = My.Computer.Screen.WorkingArea.Height - (New FrmcMain).Size.Height - 12
            TxtLocalMessage.BackColor = Color.FromName("LightSlateGray")
            ''Me.Owner = FrmMain
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ExitForm()
        Me.Hide()
        Me.Close()
        RaiseEvent _ExitRequest()
    End Sub

    Protected Sub FrmcViewLocalMessage(ByVal YourMessage As String)
        TxtLocalMessage.Text = YourMessage
    End Sub

    Protected Sub FrmcClearLocalMessage()
        TxtLocalMessage.Clear()
    End Sub

    Public Sub DisposeResources()
        Try
            For Each C As Control In Me.Controls
                If TypeOf C Is UCGeneral Then
                    DirectCast(C, UCGeneral).DisposeResources()
                End If
            Next
            RaiseEvent _UCDisposeRequest()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcGeneral_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
        Else
        End If
    End Sub
    Private Sub PicExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicExit.Click
        ExitForm()
    End Sub

    Private Sub FrmcGeneral_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _LocalMessageCleanTimer.Enabled = False
        _LocalMessageCleanTimer.Stop()
        _LocalMessageCleanTimer = Nothing
    End Sub

    Private Sub _LocalMessageCleanTimer_Tick(sender As Object, e As EventArgs) Handles _LocalMessageCleanTimer.Tick
        FrmcClearLocalMessage()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"

#End Region

#Region "Implemented Members"







#End Region















End Class
