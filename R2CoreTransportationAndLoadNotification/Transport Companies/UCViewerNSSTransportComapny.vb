
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.TransportCompanies

Public Class UCViewerNSSTransportComapny
    Inherits UCTransportCompany

    Public Event UCClickedEvent(UC As UCViewerNSSTransportComapny)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public sub New

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
        Me.Size = New Size(TextRenderer.MeasureText(CButton.Text.trim, CButton.Font).Width + 20, Me.Height)
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            UCChangeColor(UCNSSCurrent.GetColorFromARGB(), UCActiveForeColor)
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSTransportComapny_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardTransportCompanyStructure) Handles Me.UCViewNSSRequested
        Try
            CButton.Text = UCNSSCurrent.TCTitle
            Me.Size = New Size(TextRenderer.MeasureText(CButton.Text.trim, CButton.Font).Width + 20, Me.Height)
            CButton.Visible = True
            UCChangeColor(UCNSSCurrent.GetColorFromARGB(), UCActiveForeColor)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub UCViewerNSSTransportComapny_UCChangeColorToActiveRequested() Handles Me.UCChangeColorToActiveRequested
        UCChangeColor(UCNSSCurrent.GetColorFromARGB(), UCActiveForeColor)
    End Sub

    Private Sub UCViewerNSSTransportComapny_UCChangeColorToUnActiveRequested() Handles Me.UCChangeColorToUnActiveRequested
        UCChangeColor(UCUnActiveBackColor, UCUnActiveForeColor)
    End Sub

    Private Sub UCViewerNSSTransportComapny_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
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
