
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class UCViewerNSSAnnouncementHall
    Inherits UCAnnouncementHall

    Public Event UCClickedEvent(UC As UCViewerNSSAnnouncementHall)

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
            UCChangeColor(Color.FromName(UCNSSCurrent.AHColor), UCActiveForeColor)
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSAnnouncementHall_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure) Handles Me.UCViewNSSRequested
        Try
            CButton.Text = UCNSSCurrent.AHTitle
            CButton.Visible = True
            UCChangeColor(Color.FromName(UCNSSCurrent.AHColor), UCActiveForeColor)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSAnnouncementHall_UCChangeColorToActiveRequested() Handles Me.UCChangeColorToActiveRequested
        UCChangeColor(Color.FromName(UCNSSCurrent.AHColor), UCActiveForeColor)
    End Sub

    Private Sub UCViewerNSSAnnouncementHall_UCChangeColorToUnActiveRequested() Handles Me.UCChangeColorToUnActiveRequested
        UCChangeColor(UCUnActiveBackColor, UCUnActiveForeColor)
    End Sub

    Private Sub UCViewerNSSAnnouncementHall_UCViewNSSNothingRequested() Handles Me.UCViewNSSNothingRequested
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
