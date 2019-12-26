
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core
Imports R2Core.DateAndTimeManagement

Public Class UCGeneral
    Inherits  Windows.Forms.UserControl

    Protected _DateTime As New R2DateTime

    ''Protected _FrmMessageDialog As new  FrmcMessageDialog
    Protected Event _UCDisposeResourcesRequest()
    Protected Event UCGotFocusedEvent()


    Private _UCFrmMessageDialog As FrmcMessageDialog = New FrmcMessageDialog()
    <Browsable(False)>
    Public ReadOnly Property UCFrmMessageDialog As FrmcMessageDialog
        Get
            If _UCFrmMessageDialog Is Nothing Then _UCFrmMessageDialog = New FrmcMessageDialog()
            Return _UCFrmMessageDialog
        End Get
    End Property

    Protected Sub UCRefreshGeneral()

    End Sub

    Public Overridable Sub DisposeResources()
    End Sub


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCGeneral_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        DisposeResources()
    End Sub

    Public Sub UCFocus()
        RaiseEvent UCGotFocusedEvent()
    End Sub


End Class
