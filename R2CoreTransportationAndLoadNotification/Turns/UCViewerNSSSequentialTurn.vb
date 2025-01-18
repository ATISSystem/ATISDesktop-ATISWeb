
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns

Public Class UCViewerNSSSequentialTurn
    Inherits UCSequentialTurn

    Public Event UCClickedEvent(UC As UCViewerNSSSequentialTurn)

#Region "General Properties"

    Private _UCFont As Font = New System.Drawing.Font("B Homa", 9.0!)
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            CButton.Font = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub CButton_TextChanged(sender As Object, e As EventArgs) Handles CButton.TextChanged
        Me.Size = New Size(TextRenderer.MeasureText(CButton.Text, CButton.Font).Width + 40, Me.Height)
    End Sub

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        Try
            CButton.ColorFillBlend.iColor(1) = Color.FromName(UCNSSCurrent.SequentialTurnColor)
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSSequentialTurn_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardSequentialTurnStructure) Handles Me.UCViewNSSRequested
        Try
            CButton.Text = UCNSSCurrent.SequentialTurnTitle
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
