
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadAllocation


Public Class UCViewerNSSLoadAllocationStatus
    Inherits UCLoadAllocationStatus

    Public Event UCClickedEvent(UC As UCViewerNSSLoadAllocationStatus)

#Region "General Properties"
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

    Private Sub UcLabel_UCClickedEvent() Handles UcLabel.UCClickedEvent
        Try
            UCChangeBackColor(Color.FromName(UCNSSCurrent.LoadAllocationStatusColor))
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadAllocationStatus_UCViewNSSRequested(NSSCurrent As R2CoreTransportationAndLoadNotificationStandardLoadAllocationStatusStructure) Handles Me.UCViewNSSRequested
        Try
            UcLabel.UCValue = UCNSSCurrent.LoadAllocationStatusTitle
            UCChangeBackColor(Color.FromName(UCNSSCurrent.LoadAllocationStatusColor))
            Dim x As Color = color.Crimson
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcLabel_UCTextChanged(NewText As String) Handles UcLabel.UCTextChanged
        Try
            Me.Size = New Size(TextRenderer.MeasureText(UcLabel.UCValue, UcLabel.UCFont).Width + 20, Me.Height)
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
