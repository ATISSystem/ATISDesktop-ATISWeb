

Imports System.Reflection

Imports R2CoreWinFormRemoteApplications


Public Class UCUCPermissionViewerCollection
    Inherits UCGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCViewInf(YournEstelamId As Int64)
        Try
            Cursor.Current = Cursors.WaitCursor
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            Dim Lst As List(Of TransportCompanyStandardPermissionStructure) = TransportCompaniesLoadCapacitorLoadsManipulation.GetAllPermissionEnterExits(YournEstelamId)
            For Loopx As Int64 = 0 To Lst.Count - 1
                Dim UC As New UCPermissionViewer
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Top
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

 

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub picexit_Click(sender As Object, e As EventArgs) Handles picexit.Click
        Me.SendToBack()
    End Sub
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region






End Class
