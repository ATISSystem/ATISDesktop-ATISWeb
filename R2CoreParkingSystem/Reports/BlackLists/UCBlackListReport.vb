
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DatabaseManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2Core.R2PrimaryWS
Imports R2CoreParkingSystem.BlackList


Public Class UCBlackListReport
    Inherits UCGeneral

    Private _WS As R2PrimaryWebService = New R2PrimaryWebService()

#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcDateTimeHolder_UCDoCommand() Handles UcDateTimeHolder.UCDoCommand
        Try
            Cursor.Current = Cursors.WaitCursor
            _WS.WebMethodReportingInformationPrividerBlackListReport(UcDateTimeHolder.UCGetDateTime1.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime1.DateShamsiFull, UcDateTimeHolder.UCGetDateTime1.Time, UcDateTimeHolder.UCGetDateTime2.DateTimeMilladi, UcDateTimeHolder.UCGetDateTime2.DateShamsiFull, UcDateTimeHolder.UCGetDateTime2.Time, IIf(RBActiveBlackList.Checked, R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.ActiveBlackLists, R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.AllBlackLists))
            R2CoreGUIMClassInformationManagement.PrintReport(ReportsManagement.R2CoreParkingSystemReports.BlackListReport )
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub




#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region

End Class
