
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2Core.MonetaryCreditSupplySources


Public Class UCUCMonetaryCreditSupplySourceCollection
    Inherits UCGeneral

    Public Event UCCurrentNSSChangedEvent()
    Private _UCIsFirstUse As Boolean = True

#Region "General Properties"

    Private _UCCurrentNSS As R2CoreStandardMonetaryCreditSupplySourceStructure = Nothing
    <Browsable(False)>
    Public Property UCCurrentNSS() As R2CoreStandardMonetaryCreditSupplySourceStructure
        Get
            Return _UCCurrentNSS
        End Get
        Set(value As R2CoreStandardMonetaryCreditSupplySourceStructure)
            _UCCurrentNSS = value
            If value IsNot Nothing Then If Not _UCIsFirstUse Then RaiseEvent UCCurrentNSSChangedEvent()
        End Set
    End Property

    Private _UCViewBorder As Boolean = True
    Public Property UCViewBorder() As Boolean
        Get
            Return _UCViewBorder
        End Get
        Set(value As Boolean)
            _UCViewBorder = value
            If value = True Then
                PnlMain.Padding = New Padding(2)
            Else
                PnlMain.Padding = New Padding(0)
            End If
        End Set
    End Property

    Private _UCDefaultMCSSId As Int64 = R2CoreMonetaryCreditSupplySourcesManagement.GetThisComputerDefaultNSS(0).MCSSId
    Public Property UCDefaultMCSSId() As Int64
        Get
            Return _UCDefaultMCSSId
        End Get
        Set(value As Int64)
            _UCDefaultMCSSId = value
            UCActiveThisNSS(R2CoreMonetaryCreditSupplySourcesManagement.GetNSSMonetaryCreditSupplySource(value))
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCViewCollection()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        UCCurrentNSS = Nothing
    End Sub

    Public Sub UCViewCollection()
        Try
            Dim Lst As List(Of R2CoreStandardMonetaryCreditSupplySourceStructure) = R2CoreMonetaryCreditSupplySourcesManagement.GetMonetaryCreditSupplySources()
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = Lst.Count - 1 To 0 Step -1
                Dim UC As New UCViewerNSSMonetaryCreditSupplySource
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Right
                AddHandler UC.UCClickedEvent, AddressOf UCs_UCClickedEvent
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCActiveThisNSS(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure)
        Try
            Dim OUC As UCViewerNSSMonetaryCreditSupplySource = Nothing
            For Each UC As UCViewerNSSMonetaryCreditSupplySource In PnlUCs.Controls
                If UC.UCNSSCurrent.MCSSId <> YourNSS.MCSSId Then
                    UC.UCShowUnActive()
                Else
                    OUC = UC
                End If
            Next
            UCCurrentNSS = YourNSS
            OUC.UCShowActive()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSimulateThisNSS(YourNSS As R2CoreStandardMonetaryCreditSupplySourceStructure)
        Try
            UCActiveThisNSS(YourNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCs_UCClickedEvent(SenderUC As UCMonetaryCreditSupplySource)
        Try
            _UCIsFirstUse = False
            UCActiveThisNSS(SenderUC.UCNSSCurrent)
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
