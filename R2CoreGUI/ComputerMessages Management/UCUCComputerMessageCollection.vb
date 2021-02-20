
Imports System.Reflection
Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.ComputersManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.SoftwareUserManagement

Public Class UCUCComputerMessageCollection
    Inherits UCGeneral

    Private WithEvents _SweepTimer As Windows.Forms.Timer = New Timer()


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _SweepTimer.Interval = R2CoreMClassConfigurationOfComputersManagement.GetConfigInt64(R2CoreConfigurations.UCUCComputerMessageCollection, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 1) * 1000
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
    End Sub

    Public Overrides Sub DisposeResources()
        UCStopSweeping()
        _SweepTimer.Dispose()
    End Sub

    Public Sub UCStopSweeping()
        Try
            _SweepTimer.Enabled = False
            _SweepTimer.Stop()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCStartSweeping()
        Try
            _SweepTimer.Enabled = True
            _SweepTimer.Start()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCSweepInformation()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim Ds As DataSet = New DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection,
                  "Select Top " & R2CoreMClassConfigurationOfComputersManagement.GetConfigInt64(R2CoreConfigurations.UCUCComputerMessageCollection, R2CoreMClassComputersManagement.GetNSSCurrentComputer.MId, 0) & " * From R2Primary.dbo.TblComputerMessages as CM 
                    Where CM.CMType in 
                      (Select Distinct CMTypeId From R2Primary.dbo.TblComputerMessageTypes
                        inner join R2Primary.dbo.TblSoftwareUserWorkingGroupsRelationSoftwareUsers on R2Primary.dbo.TblComputerMessageTypes.WorkingGroup=R2Primary.dbo.TblSoftwareUserWorkingGroupsRelationSoftwareUsers.WGId 
                       Where R2Primary.dbo.TblSoftwareUserWorkingGroupsRelationSoftwareUsers.UserId=" & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ") 
                             and (CMActive=1) and (DateShamsi=('" & _DateTime.GetCurrentDateShamsiFull() & "'))
                       Order By DateTimeMilladi Desc", 1, Ds)
            PnlUCs.SuspendLayout()
            PnlUCs.Controls.Clear()
            For Loopx As Int16 = Ds.Tables(0).Rows.Count - 1 To 0 Step -1
                Dim NSS As New R2StandardComputerMessageStructure
                NSS.UserId = Ds.Tables(0).Rows(Loopx).Item("UserId")
                NSS.CMAccessed = CType(Ds.Tables(0).Rows(Loopx).Item("CMAccessed"), Boolean)
                NSS.CMActive = CType(Ds.Tables(0).Rows(Loopx).Item("CMActive"), Boolean)
                NSS.CMNote = Ds.Tables(0).Rows(Loopx).Item("CMNote")
                NSS.CMType = Ds.Tables(0).Rows(Loopx).Item("CMType")
                NSS.ComputerId = Ds.Tables(0).Rows(Loopx).Item("ComputerId")
                Dim DataStruct As New DataStruct
                DataStruct.Data1 = Ds.Tables(0).Rows(Loopx).Item("Data1")
                DataStruct.Data2 = Ds.Tables(0).Rows(Loopx).Item("Data2")
                DataStruct.Data3 = Ds.Tables(0).Rows(Loopx).Item("Data3")
                DataStruct.Data4 = Ds.Tables(0).Rows(Loopx).Item("Data4")
                DataStruct.Data5 = Ds.Tables(0).Rows(Loopx).Item("Data5")
                NSS.DataStruct = DataStruct
                NSS.DateShamsi = Ds.Tables(0).Rows(Loopx).Item("DateShamsi")
                NSS.DateTimeMilladi = Ds.Tables(0).Rows(Loopx).Item("DateTimeMilladi")
                NSS.PrimaryId = Ds.Tables(0).Rows(Loopx).Item("PrimaryId")
                NSS.Time = Ds.Tables(0).Rows(Loopx).Item("Time")
                Dim myUC As UCComputerMessage = R2CoreGUIMClassComputerMessagesManagement.CreateUCComputerMessage(NSS)
                myUC.Dock = DockStyle.Top
                PnlUCs.Controls.Add(myUC)
            Next
            PnlUCs.AutoScrollPosition = New Point(0, 0)
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

    Private Sub _SweepTimer_Tick(sender As Object, e As EventArgs) Handles _SweepTimer.Tick
        Try
            _SweepTimer.Stop()
            UCSweepInformation()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, "بروز خطا در پانل پیام های دریافتی کاربر", ex.Message, FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
        _SweepTimer.Start()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
