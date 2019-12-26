
Imports System.Reflection

Imports R2CoreWinFormRemoteApplications

Public Class FrmcUserChargeReport
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub BtnPnlUserChargeReport_Click(sender As Object, e As EventArgs) Handles BtnPnlUserChargeReport.Click
        PnlUserChargeReport.BringToFront()
        PnlUserChargeReport.Focus()
    End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class