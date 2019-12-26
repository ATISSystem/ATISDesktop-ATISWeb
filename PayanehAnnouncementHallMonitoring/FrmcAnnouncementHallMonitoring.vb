
Imports System.Reflection
Imports PayanehClassLibrary.ConfigurationManagement
Imports R2Core.ConfigurationManagement
Imports R2Core.DateAndTimeManagement
Imports R2CoreGUI

Public Class FrmcAnnouncementHallMonitoring

    Private _FrmMessageDialog As New FrmcMessageDialog

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Me.Location = New System.Drawing.Point(5, 5)
            Me.Width = Screen.AllScreens(0).WorkingArea.Width - 10
            Me.Height = Screen.AllScreens(0).WorkingArea.Height - 10
            Me.BackColor = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(PayanehClassLibraryConfigurations.AnnouncementHallMonitoring, 0))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub RefreshToZero()
        UcDriverImage.UCRefresh()
        UcLabelDriverNameFamily.UCRefresh() : UcLabelTurnNumber.UCRefresh() : UcLabelCarTruckPlateString.UCRefresh()
        UcLabelLoadTitle.UCRefresh() : UcLabelShippingCompany.UCRefresh() : UcLabelLoadTarget.UCRefresh()
        UcLabelDescription.UCRefresh()
    End Sub

    Private Sub FrmRefresh()
        Try
            RefreshToZero()
            'بدست آوردن شاخص مانیتورینگ
            myPSFPClassLibrary.SetLastMId()
            DaSweep.SelectCommand = New SqlClient.SqlCommand("select * from TblElamBarMonitoring where readflag=0 and mid>" & myPSFPClassLibrary.LastMId & " order by mid asc")
            DaSweep.SelectCommand.Connection = (New R2Core.DepartementDoreManagement.R2StandardDepartementDoreStructure).GetSqlConnectionDepartementsSharing.GetConnection
            'تایمر کنترل کننده
            ControlerTimer.Interval = R2Core.ConfigurationManagement.R2MClassConfigurationManagement.GetAppConfigValue(R2Core.ConfigurationManagement.ApplicationRegistryType.Special, "ElamBarMonitoringInterval", "ElamBarMonitoringInterval") : ControlerTimer.Enabled = True : ControlerTimer.Start()
            RefreshToZeroTimer.Interval = ControlerTimer.Interval * 2 'اگر اطلاعانی برای نمایش موجود نبود تصویر آخرین رکورد حداکثر 5 برابر عادی می ماند
            'بروز رسانی شماره اعتبار نوبت
            myPSFPClassLibrary.SetEtebarNobat()
            TxtEtebar.Text = myPSFPClassLibrary.EtebarNobat
            'R2Core.DatabaseManagement.R2ClassSqlDataBOXManagement.GetDataBOX((New R2Core.DepartementDoreManagement.R2StandardDepartementDoreStructure).GetSqlConnectionDepartementsSharing, "Select Top 1 TMessage from TblSalonTablighOnLed Order by DateTimeMilladi Desc", 1, DSTabligh)
            'TablighString = Split(DSTabligh.Tables(0).Rows(0).Item("Tmessage"), Microsoft.VisualBasic.ChrW(13))
        Catch ex As Exception
            ViewError("FrmRefresh" + vbCrLf + ex.Message.ToString)
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
