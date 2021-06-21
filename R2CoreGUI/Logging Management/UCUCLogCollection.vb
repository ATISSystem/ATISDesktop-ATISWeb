
Imports System.Reflection

Imports R2Core.DatabaseManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement

Public Class UCUCLogCollection
    Inherits UCGeneral



#Region "General Properties"

    Private _RecordCounttoView As Int16 = 10
    Public Property RecordCounttoView As Int16
        Get
            Return _RecordCounttoView
        End Get
        Set(value As Int16)
            _RecordCounttoView = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        PnlMain.Controls.Clear()
        'PnlMain.Visible = False
        'Do While PnlMain.Controls.Count <> 0
        '    For Each C As Windows.Forms.Control In PnlMain.Controls
        '        PnlMain.Controls.Remove(C)
        '        C.Dispose()
        '    Next
        'Loop
    End Sub

    Public Sub UCViewLoggOptional1(YourOptional1 As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            UCRefresh()
            PnlMain.SuspendLayout()
            Dim Ds As New DataSet
            R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select top " & RecordCounttoView & " * from R2PrimaryLogging.dbo.TblLogging Where Optional1 Like '%" & YourOptional1 & "%' order by DateTimeMilladi desc", 1, Ds)
            For Loopx As Int64 = Ds.Tables(0).Rows.Count - 1 To 0 Step -1
                Dim UC As UCLog = New UCLog(New R2CoreStandardLoggingStructure(Ds.Tables(0).Rows(Loopx).Item("logid"), Ds.Tables(0).Rows(Loopx).Item("LogType"), Ds.Tables(0).Rows(Loopx).Item("sharh").trim, Ds.Tables(0).Rows(Loopx).Item("optional1").trim, Ds.Tables(0).Rows(Loopx).Item("optional2").trim, Ds.Tables(0).Rows(Loopx).Item("optional3").trim, Ds.Tables(0).Rows(Loopx).Item("optional4").trim, Ds.Tables(0).Rows(Loopx).Item("optional5").trim, Ds.Tables(0).Rows(Loopx).Item("userid"), Ds.Tables(0).Rows(Loopx).Item("datetimemilladi"), Ds.Tables(0).Rows(Loopx).Item("dateshamsi").trim))
                UC.Dock = DockStyle.Top
                PnlMain.Controls.Add(UC)
            Next
            PnlMain.ResumeLayout()
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
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
