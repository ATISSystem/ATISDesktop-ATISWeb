
Imports System.Drawing
Imports System.Reflection

Imports R2Core.LoggingManagement
Imports R2Core.PublicProc
Imports R2CoreGUI


Public Class UCEntryExitLogsViewer
    Inherits UCLog

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        UcLabelSharh.UCValue = String.Empty : UcPersianTextBoxDateShamsi.UCValue = String.Empty : UcPersianTextBoxTime.UCValue = String.Empty
        UcPersianTextBoxUserName.UCValue = String.Empty : UcPersianTextBoxTrafficCard.UCValue = String.Empty : UcPersianTextBoxLPString.UCValue = String.Empty
        UcPersianTextBoxEntryExitTitle.UCValue = String.Empty
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCEntryExitLogsViewer_UCViewLogRequested(NSSLog As R2CoreStandardLoggingStructure) Handles Me.UCViewLogRequested
        Try
            UCRefresh()
            Dim NSS = DirectCast(NSSLog, R2CoreStandardLoggingExtendedStructure)
            UcLabelSharh.UCValue = NSS.Sharh
            UcPersianTextBoxDateShamsi.UCValue = NSS.DateShamsi
            UcPersianTextBoxTime.UCValue = _DateTime.GetTimeOfDate(NSS.DateTimeMilladi)
            UcPersianTextBoxUserName.UCValue = NSS.UserName
            UcPersianTextBoxLPString.UCValue = NSS.Optional3
            UcPersianTextBoxTrafficCard.UCValue = NSS.Optional1
            UcPersianTextBoxEntryExitTitle.UCValue = NSS.Optional4
            UcPersianTextBoxMessage.UCValue = NSS.Optional2
            PnlMain.BackColor = NSS.LogTypeColor
            Dim InvertColor As Color = R2CoreMClassPublicProcedures.GetInvertColor(PnlMain.BackColor)
            UcPersianTextBoxDateShamsi.UCForeColor = InvertColor
            UcPersianTextBoxTime.UCForeColor = InvertColor
            UcPersianTextBoxTrafficCard.UCForeColor = InvertColor
            UcPersianTextBoxLPString.UCForeColor = InvertColor
            UcPersianTextBoxEntryExitTitle.UCForeColor = InvertColor
            UcPersianTextBoxUserName.UCForeColor = InvertColor
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
