
Imports System.Reflection

Imports R2CoreWinFormRemoteApplications

Public Class FrmcRegisteringHandyBills
    Inherits FrmcGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeSpecial()
        FrmRefesh()
    End Sub

    Public sub FrmRefesh
        UcRegisteringHandyBills.UCRefresh()
    End sub


 
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub BtnRegisteringHandyBills_Click(sender As Object, e As EventArgs) Handles BtnRegisteringHandyBills.Click
        PnlRegisteringHandyBills.BringToFront()
        PnlRegisteringHandyBills.Focus()
    End Sub
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class