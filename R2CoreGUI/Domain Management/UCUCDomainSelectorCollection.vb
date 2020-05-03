
Imports System.Reflection
Imports System.Windows.Forms
Imports System.ComponentModel


Imports R2Core
Imports R2Core.BaseStandardClass
Imports R2Core.DatabaseManagement
Imports R2Core.ComputersManagement
Imports R2Core.UserManagement
Imports R2CoreGUI



Public Class UCUCDomainSelectorCollection
    Inherits UCGeneral

    Protected Event UCUPItemRequestedEvent(NSS As R2StandardStructure)
    Protected Event UCDownItemRequestedEvent(NSS As R2StandardStructure)
    Public Event UCSelectedItemChangedEvent(NSS As R2StandardStructure)
    Public Event UCViewNSSRequestedEvent(NSS As R2StandardStructure)


#Region "General Properties"

    Private _UCTitleVisable As Boolean = True
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
    Public Property UCTitle As String
        Get
            Return _UCTitle
        End Get
        Set(value As String)
            _UCTitle = value
            UcLabelTop.UCValue = value
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

    Private _UCTitleFont As Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
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
        UCRefreshGeneral()
    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private _NSS As R2StandardStructure = Nothing
    Protected Sub UCViewNSS(YourNSS As R2StandardStructure, YourTypeofUCDomain As System.Type)
        Try
            _NSS = YourNSS
            Dim UC As UCDomain = GetInstance(YourTypeofUCDomain)
            UC.UCViewNSS(YourNSS)
            UC.Dock = DockStyle.Fill
            PnlUCDomain.Controls.Clear()
            PnlUCDomain.Controls.Add(UC)
            RaiseEvent UCSelectedItemChangedEvent(_NSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardStructure)
        Try
            RaiseEvent UCViewNSSRequestedEvent(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetInstance(ByVal t As System.Type) As UCDomain
        Return t.GetConstructor(New System.Type() {}).Invoke(New UCDomain() {})
    End Function

    Private Sub PicUP_Click(sender As Object, e As EventArgs) Handles PicUP.Click
        Try
            RaiseEvent UCUPItemRequestedEvent(_NSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub PicDown_Click(sender As Object, e As EventArgs) Handles PicDown.Click
        Try
            RaiseEvent UCDownItemRequestedEvent(_NSS)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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



