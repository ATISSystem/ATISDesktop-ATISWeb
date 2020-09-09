
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.DateAndTimeManagement
Imports R2Core.DatabaseManagement
Imports R2Core.LoggingManagement
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2CoreParkingSystem.BlackList
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.CarType
Imports R2CoreParkingSystem.MoneyWalletManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCUCBlackListCollection
    Inherits UCGeneral

    Private _NSSTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure
    Private _NSSCar As R2StandardCarStructure
    Public Event UCPardakhtRequestEvent(NSSBlackList As R2StandardBlackListStructure, Mblgh As Int64)
    Public Event UCViewInformationCompleted(CarId As String)
    Private ReadOnly _DateTime As R2DateTime = New R2DateTime()



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
        UcCar.UCRefreshGeneral()
        UcPersianTextBoxSharh.UCRefresh()
        UcMoney.UCValue = 0
        PnlUCs.Controls.Clear()
    End Sub

    Public Sub UCViewInformation(YourNSSCar As R2StandardCarStructure)
        Try
            _NSSCar = YourNSSCar
            Dim Lst As List(Of R2StandardBlackListStructure) = R2CoreParkingSystemMClassBlackList.GetBlackList(_NSSCar,R2CoreParkingSystemMClassBlackList.R2CoreParkingSystemBlackListType.AllBlackLists )
            PnlUCs.Controls.Clear()
            For Loopx As Int64 = 0 To Lst.Count - 1
                Dim UC As New UCBlackList
                UC.UCViewInformation(Lst(Loopx))
                UC.Dock = DockStyle.Top
                PnlUCs.Controls.Add(UC)
                AddHandler UC.UCPardakhtRequestEvent, AddressOf UCsUCPardakhtRequestEvent_Handler
            Next
            RaiseEvent UCViewInformationCompleted(_NSSCar.nIdCar)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcCar_UCViewCarInformationCompleted(CarId As String) Handles UcCar.UCViewCarInformationCompleted
        Try
            UCViewInformation(R2CoreParkingSystemMClassCars.GetNSSCar(CarId))
            UcDriver.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCsUCPardakhtRequestEvent_Handler(NSSBlackList As R2StandardBlackListStructure, Mblgh As Int64)
        Try
            RaiseEvent UCPardakhtRequestEvent(NSSBlackList, Mblgh)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonAdd_UCClickedEvent() Handles UcButtonAdd.UCClickedEvent
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New DataBaseManagement.R2ClassSqlConnectionSepas).GetConnection()
        Try
            If UcMoney.UCValueMoney = 0 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "مبلغ نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcPersianTextBoxSharh.UCValue = "" Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "شرح را وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            CmdSql.Connection.Open()
            CmdSql.CommandText = "Insert Into dbtransport.dbo.TbBlackList(nTruckNo,nPlakPlac,nPlakSerial,StrDesc,FlagA,nAmount,StrDate,nUser) Values('" & _NSSCar.StrCarNo & "'," & _NSSCar.nIdCity & ",'" & _NSSCar.StrCarSerialNo & "','" & UcPersianTextBoxSharh.UCValue & "',0," & UcMoney.UCValueMoney & ",'" & _DateTime.GetCurrentDateShamsiFull() & "'," & R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId & ")"
            CmdSql.ExecuteNonQuery()
            CmdSql.Connection.Close()
            UCViewInformation(_NSSCar)
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "شرح تخلف به لیست سیاه خودرو اضافه شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.Info, "شرح تخلف به لیست سیاه خودرو اضافه شد" + vbCrLf + UcPersianTextBoxSharh.UCValue, "", 0, 0, 0, 0, R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
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
