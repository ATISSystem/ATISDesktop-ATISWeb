
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class UCTransportCompanyLoadCapacitorSedimentLoadViewer
    Inherits UCTransportCompanyLoadCapacitorLoadManipulation


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

    Private Sub UCTransportCompanyLoadCapacitorSedimentLoadViewer_UCViewNSSCompleted() Handles Me.UCViewNSSCompleted
        Try
            UcNumberSedimentedLoad.UCValue=UCGetCurrentNSS.nCarNum
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message,"", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
