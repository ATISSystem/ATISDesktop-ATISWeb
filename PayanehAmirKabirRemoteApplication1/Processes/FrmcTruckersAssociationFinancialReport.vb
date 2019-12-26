
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreWinFormRemoteApplications

Public Class FrmcTruckersAssociationFinancialReport
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
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


    Public Sub FrmRefresh()
        UcTruckersAssociationFinacialReport.UCRefresh()
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"



    Private Sub BtnPnlTruckersAssociationFinancialReport_Click(sender As Object, e As EventArgs) Handles BtnPnlTruckersAssociationFinancialReport.Click
        PnlTruckersAssiciationFinanceReport.BringToFront()
        PnlTruckersAssiciationFinanceReport.Focus()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class