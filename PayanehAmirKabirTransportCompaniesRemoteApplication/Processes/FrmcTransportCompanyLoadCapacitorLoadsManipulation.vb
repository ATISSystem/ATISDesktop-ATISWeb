
Imports System.Reflection

Imports R2CoreWinFormRemoteApplications

Public Class FrmcTransportCompanyLoadCapacitorLoadsManipulation
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            Me.Owner=FrmcFirst.FrmMain
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub FrmRefresh()
    End Sub

    

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub BtnPnlContractorCompanyFinancialReport_Click(sender As Object, e As EventArgs) Handles BtnPnlTransportCompanyLoadCapacitorLoadsManipulation.Click
        PnlTransportCompanyLoadCapacitorLoadsManipulation.BringToFront()
        PnlTransportCompanyLoadCapacitorLoadsManipulation.Focus()
    End Sub
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class