
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications

Public Class UCUCTransportCompanyLoadCapacitorLoadManipulationCollection
    Inherits UCGeneral



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

    Private Sub UcButtonSpecialAdd_UCClickedEvent() Handles UcButtonSpecialAdd.UCClickedEvent
        Try
            Dim UC As New UCTransportCompanyLoadCapacitorLoadManipulation
            UC.Dock = DockStyle.Top
            AddHandler UC.UCLoadCapacitorLoadDeletedEvent, AddressOf UCs_UCLoadCapacitorLoadDeletedEventHandler
            PnlUCs.Controls.Add(UC)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try

    End Sub

    Private Sub UcButtonSpecialRefresh_UCClickedEvent() Handles UcButtonSpecialRefresh.UCClickedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            Dim Lst As List(Of TransportCompaniesStandardLoadCapacitorLoadStructure) = TransportCompaniesLoadCapacitorLoadsManipulation.GetTransportCompanyLoadCapacitorLoads()
            For Loopx As Int64 = 0 To Lst.Count - 1
                Dim UC As New UCTransportCompanyLoadCapacitorLoadManipulation
                UC.UCViewNSS(Lst(Loopx))
                UC.Dock = DockStyle.Top
                AddHandler UC.UCLoadCapacitorLoadDeletedEvent, AddressOf UCs_UCLoadCapacitorLoadDeletedEventHandler
                PnlUCs.Controls.Add(UC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub UCs_UCLoadCapacitorLoadDeletedEventHandler(UC As UCGeneral)
        Try
            PnlUCs.Controls.Remove(UC)
            UC = Nothing
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
