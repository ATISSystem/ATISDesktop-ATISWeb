
Imports System.Reflection
Imports R2Core.DateAndTimeManagement
Imports R2Core.LoggingManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.BlackList
Imports R2Core.SoftwareUserManagement

Public Class UCBlackList
    Inherits UCGeneral

    Private _NSSBlackList As R2StandardBlackListStructure
    Public Event UCPardakhtRequestEvent(NSSBlackList As R2StandardBlackListStructure, Mblgh As Int64)
    Private _DateTime As R2DateTime = New R2DateTime()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabelStrDesc.UCValue = "" : UcLabelStrDate.UCValue = "" : UcLabelUser.UCValue = "" : UcLabelFlagA.UCValue = "" : UcMoneynAmount.UCValue = 0
    End Sub

    Public Sub UCViewInformation(YourNSSBlackList As R2StandardBlackListStructure)
        Try
            _NSSBlackList = YourNSSBlackList
            UCRefresh()
            UcLabelStrDesc.UCValue = YourNSSBlackList.StrDesc.Trim
            UcLabelStrDate.UCValue = YourNSSBlackList.StrDate
            UcMoneynAmount.UCValue = YourNSSBlackList.nAmount
            UcLabelUser.UCValue = R2CoreMClassSoftwareUsersManagement.GetNSSUser(YourNSSBlackList.nUser).UserName
            UcLabelFlagA.UCValue = IIf(YourNSSBlackList.FlagA = True, "غیرفعال", "فعال")
            UcButtonPardakht.UCEnable = Not YourNSSBlackList.FlagA
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonChangeFlagA_UCClickedEvent() Handles UcButtonChangeFlagA.UCClickedEvent
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
        Try
            Dim NextFlag As Boolean = _NSSBlackList.FlagA <> True
            CmdSql.Connection.Open()
            CmdSql.CommandText = "Update dbtransport.dbo.TbBlackList Set FlagA=" & IIf(NextFlag, 1, 0) & " Where nId=" & _NSSBlackList.nId & ""
            CmdSql.ExecuteNonQuery()
            CmdSql.Connection.Close()
            _NSSBlackList.FlagA = NextFlag
            UCViewInformation(_NSSBlackList)
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "تغییر وضعیت تخلف یا لیست سیاه خودرو انجام گرفت" + vbCrLf + _NSSBlackList.nId.ToString(), String.Empty, 0, 0, 0, 0, Nothing, Nothing, Nothing))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
        End Try
    End Sub

    Private Sub UcButtonPardakht_UCClickedEvent() Handles UcButtonPardakht.UCClickedEvent
        Try
            If UcMoneynAmount.UCValueMoney <> 0 Then
                UcButtonPardakht.UCEnable = False
                R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "پرداخت وجه تخلف یا لیست سیاه خودرو انجام گرفت" + vbCrLf + _NSSBlackList.nId.ToString(), "", 0, 0, 0, 0,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId , _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
                RaiseEvent UCPardakhtRequestEvent(_NSSBlackList, UcMoneynAmount.UCValueMoney)
            End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
