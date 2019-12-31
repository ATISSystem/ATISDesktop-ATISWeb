
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2Core.MonetaryCreditSupplySources


Public Class UCViewerNSSMonetaryCreditSupplySource
    Inherits UCMonetaryCreditSupplySource

    Public Event UCClickedEvent(UC As UCViewerNSSMonetaryCreditSupplySource)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCChangeColor(YourBackColor As Color, YourForeColor As Color)
        CButton.ColorFillSolid = YourBackColor
        CButton.ForeColor = YourForeColor
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub CButton_TextChanged(sender As Object, e As EventArgs) Handles CButton.TextChanged
        Me.Size = New Size(TextRenderer.MeasureText(CButton.Text, CButton.Font).Width + 20, Me.Height)
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            UCChangeColor(UCNSSCurrent.MCSSColor, UCActiveForeColor)
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSMonetaryCreditSupplySource_UCViewNSSRequested(NSSCurrent As R2CoreStandardMonetaryCreditSupplySourceStructure) Handles Me.UCViewNSSRequested
        Try
            CButton.Text = UCNSSCurrent.MCSSTitle
            CButton.Visible = True
            UCChangeColor(UCNSSCurrent.MCSSColor, UCActiveForeColor)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSMonetaryCreditSupplySource_UCChangeColorToActiveRequested() Handles Me.UCChangeColorToActiveRequested
        UCChangeColor(UCNSSCurrent.MCSSColor, UCActiveForeColor)
    End Sub

    Private Sub UCViewerNSSMonetaryCreditSupplySource_UCChangeColorToUnActiveRequested() Handles Me.UCChangeColorToUnActiveRequested
        UCChangeColor(UCUnActiveBackColor, UCUnActiveForeColor)
    End Sub

    Private Sub UCViewerNSSMonetaryCreditSupplySource_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
        CButton.Visible = False
    End Sub






#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
