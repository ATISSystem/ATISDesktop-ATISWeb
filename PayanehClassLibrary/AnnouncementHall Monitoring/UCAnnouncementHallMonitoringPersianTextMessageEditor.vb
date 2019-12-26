
Imports System.Reflection
Imports PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHallsMonitoring
Imports R2CoreGUI

Public Class UCAnnouncementHallMonitoringPersianTextMessageEditor
    Inherits UCGeneral

    Public Event UCUserSabtedPersianTextMesege

    
#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TRY
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        Try
            UcPersianTextBox.UCValue=PayanehClassLibraryMClassAnnouncementHallMonitoringManagement.GetMonitoringPersianTextMessage()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

  



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

  Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        try
            PayanehClassLibraryMClassAnnouncementHallMonitoringManagement.SabtMonitoringPersianTextMessage(UcPersianTextBox.UCValue)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "متن نمایشگر ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            RaiseEvent UCUserSabtedPersianTextMesege
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
