
Imports System.Reflection

Imports R2Core
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.ProcessesManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreGUI.ProcessesManagement

Public Class UCUCProcessGroupCollection
    Inherits UCGeneral


#Region "General Properties"
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

    'Public Sub UCViewProcessGroups()
    '    Try
    '        'محاسبات ابتدایی
    '        Dim TotalNumberofUCProcessGroupsCanViewInRow As Int64 = Int(PnlUCProcessGroupCollection.Size.Width / R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1))
    '        Dim StartXPosition As Int64 = (PnlUCProcessGroupCollection.Size.Width - (TotalNumberofUCProcessGroupsCanViewInRow * R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1))) / 2
    '        'نمایش زیرمنوهای گروه انتخاب شده
    '        Dim X As Int64 = StartXPosition
    '        Dim Y As Int64 = 0
    '        Dim RowCount As Int16 = 0
    '        Dim Lst As List(Of R2StandardProcessGroupStructure) = R2CoreMClassProcessesManagement.GetListOfProcessGroupsHaveUser(R2CoreMClassLoginManagement.CurrentUserNSS)
    '        For Loopx As Int16 = 0 To Lst.Count - 1
    '            Dim UC As UCProcessGroup = New UCProcessGroup(Lst(Loopx))
    '            AddHandler UC.UCClickedEvent, AddressOf UCProcessGroups_UCClickedEventHandler
    '            UC.Location = New Point(X, Y)
    '            PnlUCProcessGroupCollection.Controls.Add(UC)
    '            RowCount = RowCount + 1
    '            If RowCount > TotalNumberofUCProcessGroupsCanViewInRow - 1 Then
    '                RowCount = 0 : X = StartXPosition : Y = Y + UC.Size.Height
    '            Else
    '                X = X + R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1)
    '            End If
    '        Next
    '        Dim PnlUCProcessGroupCollectionCalcHight As Int64 = Int(Lst.Count / TotalNumberofUCProcessGroupsCanViewInRow) * R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 2)
    '        PnlUCProcessGroupCollection.Size = New Size(PnlUCProcessGroupCollection.Size.Width, PnlUCProcessGroupCollectionCalcHight)
    '        PnlUCProcessCollection.Location = New Point(PnlUCProcessCollection.Location.X, PnlUCProcessGroupCollection.Bottom + 10)
    '        PnlUCProcessCollection.Size = New Size(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1), Me.Size.Height - PnlUCProcessGroupCollection.Size.Height-20)
    '    Catch ex As Exception
    '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
    '    End Try
    'End Sub

    Public Sub UCViewProcessGroups()
        Try
            PnlUCProcessGroupCollection.SuspendLayout()
            PnlUCProcessGroupCollection.Controls.Clear()
            Dim Lst As List(Of R2StandardProcessGroupStructure) = R2CoreMClassProcessesManagement.GetListOfProcessGroupsHaveUser(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
            For Loopx As Int16 = Lst.Count - 1 To 0 Step -1
                Dim UC As UCProcessGroup = New UCProcessGroup(Lst(Loopx))
                UC.Dock = DockStyle.Top
                AddHandler UC.UCClickedEvent, AddressOf UCProcessGroups_UCClickedEventHandler
                PnlUCProcessGroupCollection.Controls.Add(UC)
            Next
            PnlUCProcessGroupCollection.Size = New Size(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1), PnlUCProcessGroupCollection.Height)
            PnlUCProcessCollection.Size = New Size(Me.Size.Width - PnlUCProcessGroupCollection.Size.Width - 20, PnlUCProcessCollection.Size.Height)
            'GLabelTitle.Size = New Size(Me.Size.Width - PnlUCProcessGroupCollection.Size.Width - 20, GLabelTitle.Size.Height)
            'PnlUCs.Size = New Size(Me.Size.Width - PnlUCProcessGroupCollection.Size.Width - 20, PnlUCs.Size.Height)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        PnlUCProcessGroupCollection.ResumeLayout()
    End Sub

    Private Sub UCViewProcesses(UC As UCProcessGroup)
        Try
            'نمایش زیرمنوهای گروه انتخاب شده
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            Dim DS As DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblProcessGroupsRelationProcesses Where PGId=" & UC.UCGetNSS.PGId & " Order by PGId", 3600, DS)
            For Loopx As Int16 = DS.Tables(0).Rows.Count - 1 To 0 Step -1
                Dim NSSProcess As R2StandardProcessStructure = R2Core.ProcessesManagement.R2CoreMClassProcessesManagement.GetNSSProcess(DS.Tables(0).Rows(Loopx).Item("PId"))
                Dim UCP As UCProcess = New UCProcess(NSSProcess, UC.UCGetNSS.PGBackColor)
                UCP.Dock = DockStyle.Top
                PnlUCs.Controls.Add(UCP)
            Next
            'PnlUCProcessCollection.Location = New Point(UC.Location.X, UC.Location.Y )
            'PnlUCProcessCollection.BringToFront 
            'PnlUCProcessCollection.Location = New Point(UC.Location.X, PnlUCProcessCollection.Location.Y)
            'PnlUCProcessCollection.Location = New Point(PnlUCProcessCollection.Location.x, PnlUCProcessCollection.Location.Y)
            'PnlUCProcessCollection.Colors(0).Color = UC.UCGetNSS.PGBackColor
            'PnlUCProcessCollection.Colors(0).Color = YourNSS.PGBackColor
            ''PnlUCProcessCollection.Colors(1).Color = UC.UCGetNSS.PGBackColor
            'PnlUCProcessCollection.Colors(0).Color = UC.UCGetNSS.PGBackColor
            'PnlUCProcessCollection.Colors(1).Color = UC.UCGetNSS.PGBackColor
            GLabelTitle.Text = UC.UCGetNSS.PGDisplayTitle
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        PnlUCs.ResumeLayout()
    End Sub

    Private Sub UCProcessGroups_UCClickedEventHandler(UC As UCProcessGroup)
        Try
            UCViewProcesses(UC)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
