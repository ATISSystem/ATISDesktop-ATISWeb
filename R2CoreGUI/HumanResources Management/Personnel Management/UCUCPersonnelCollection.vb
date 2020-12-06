
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2Core.DatabaseManagement
Imports R2Core.ComputersManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.UserManagement

Public Class UCUCPersonnelCollection
    Inherits R2CoreGUI.UCGeneral

    Public Event UCSelected(NSSPersonnel As R2CoreStandardPersonnelStructure)



#Region "General Properties"

    Private _UCNumberOfRecordstoView As Int32 = 100
    <DefaultValue(100)>
    <Browsable(True)>
    Public Property UCNumberOfRecordstoView As Int32
        Get
            Return _UCNumberOfRecordstoView
        End Get
        Set(value As Int32)
            _UCNumberOfRecordstoView = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewPersonnelsByUCPersonnel()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Lst As List(Of R2CoreStandardPersonnelStructure) = R2CorePersonnelMClassManagement.CreateListOfPersonnel(True)
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int16 = Lst.Count - 1 To 0 Step -1
                Dim myUC As UCPersonnel = New UCPersonnel()
                myUC.UCViewPersonnelInformation(Lst(Loopx))
                myUC.UCViewButtons = False
                myUC.Dock = DockStyle.Top
                PnlUCs.Controls.Add(myUC)
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Sub UCViewPersonnelsByUCPersonnelPresenter(YourNSSUser As R2CoreStandardUserStructure)
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Lst As List(Of R2CoreStandardPersonnelStructure) = R2CorePersonnelMClassManagement.CreateListOfPersonnel(True)
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int16 = Lst.Count - 1 To 0 Step -1
                Dim myUC As UCPersonnelPresenter = New UCPersonnelPresenter()
                myUC.UCViewPersonnel(Lst(Loopx),YourNSSUser)
                myUC.Dock = DockStyle.Top
                PnlUCs.Controls.Add(myUC)
                AddHandler myUC.UCClickedEvent, AddressOf UCs_UCClickedEvent
            Next
            PnlUCs.ResumeLayout()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UCs_UCClickedEvent(NSSPersonnel As R2CoreStandardPersonnelStructure)
        Try
            RaiseEvent UCSelected(NSSPersonnel)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region


End Class
