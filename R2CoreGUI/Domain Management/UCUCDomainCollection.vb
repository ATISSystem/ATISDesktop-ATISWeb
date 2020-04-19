

Imports System.Reflection
Imports System.Windows.Forms
Imports System.ComponentModel


Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.DatabaseManagement
Imports R2Core.ComputersManagement
Imports R2Core.UserManagement
Imports R2CoreGUI


Public Class UCUCDomainCollection
    Inherits UCGeneral

    Public Event UCSelectedItemChangedEvent(Item As UCDomain)
    Public Event UCViewCollectionCompeletedEvent()
    Public Event UCRefreshInformationRequestedEvent()


#Region "General Properties"

    <Browsable(True)>
    Public Property UCTotalNumberOfItemsToView As Int64 = Int64.MaxValue

    Private _UCTitleVisable As Boolean = True
    <Browsable(True)>
    Public Property UCTitleVisable As Boolean
        Get
            Return _UCTitleVisable
        End Get
        Set(value As Boolean)
            _UCTitleVisable = value
            UcLabelTop.Visible = value
        End Set
    End Property

    Private _UCTitle As String = String.Empty
    <Browsable(True)>
    Public Property UCTitle As String
        Get
            Return _UCTitle
        End Get
        Set(value As String)
            _UCTitle = value
            UcLabelTop.UCValue = value
        End Set
    End Property

    Private _UCTitleHight As Int64 = 53
    <Browsable(True)>
    Public Property UCTitleHight As Int64
        Get
            Return _UCTitleHight
        End Get
        Set(value As Int64)
            _UCTitleHight = value
            UcLabelTop.Size = New System.Drawing.Size(UcLabelTop.Size.Width, value)
        End Set
    End Property

    Private _UCTitleBackColor As Color = Color.DodgerBlue
    Public Property UCTitleBackColor As Color
        Get
            Return _UCTitleBackColor
        End Get
        Set(value As Color)
            _UCTitleBackColor = value
            UcLabelTop.UCBackColor = value
        End Set
    End Property

    Private _UCTitleForeColor As Color = Color.White
    Public Property UCTitleForeColor As Color
        Get
            Return _UCTitleForeColor
        End Get
        Set(value As Color)
            _UCTitleForeColor = value
            UcLabelTop.UCForeColor = value
        End Set
    End Property

    Private _UCTitleFont As Font = New System.Drawing.Font("B Homa", 20.25!)
    Public Property UCTitleFont As Font
        Get
            Return _UCTitleFont
        End Get
        Set(value As Font)
            _UCTitleFont = value
            UcLabelTop.UCFont = value
        End Set
    End Property






#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub UCRefreshInformation()
        PnlUCs.SuspendLayout()
        PnlUCs.Controls.Clear()
        PnlUCs.ResumeLayout()
    End Sub

    Public Overrides Sub UCRefreshGeneral()
        Try
            UCRefreshInformation()
            RaiseEvent UCRefreshInformationRequestedEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private WithEvents _TTimer As System.Windows.Forms.Timer
    Private _Lst As List(Of R2StandardStructure)
    Private _Counter As Int64
    Private _Type As System.Type
    Protected Sub UCViewCollection(YourCollection As List(Of R2StandardStructure), YourTypeofUCDomain As System.Type)
        Try
            UCRefreshInformation()
            _Lst = YourCollection
            _Type = YourTypeofUCDomain
            If _Lst.Count <1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If
            '_Counting = _Lst.Count
            _Counter = _Lst.Count - 1

            _TTimer = New Timer()
            _TTimer.Interval = 1
            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetInstance(ByVal t As System.Type) As UCDomain
        Return t.GetConstructor(New System.Type() {}).Invoke(New UCDomain() {})
    End Function

    Private Delegate Sub UCViewCollectionDelegate()
    Private Sub UCViewCollection()
        Try
            Dim UC As UCDomain = GetInstance(_Type)
            UC.UCViewNSS(_Lst(_Counter))
            UC.Dock = DockStyle.Top
            AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
            If PnlUCs.InvokeRequired Then
                PnlUCs.Invoke(New UCViewCollectionDelegate(AddressOf UCViewCollection))
            Else
                PnlUCs.Controls.Add(UC)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub




#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub _TTimer_Tick(sender As Object, e As EventArgs) Handles _TTimer.Tick
        Try
            _TTimer.Enabled = False
            _TTimer.Stop()
            UCViewCollection()
            _Counter = _Counter - 1
            If _Counter = -1 Then
                RaiseEvent UCViewCollectionCompeletedEvent()
                Exit Sub
            End If
            _TTimer.Enabled = True
            _TTimer.Start()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCs_UCClickedEvent(UC As UCDomain)
        Try
            RaiseEvent UCSelectedItemChangedEvent(UC)
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
