
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection

Imports R2CoreGUI
Imports R2Core.ExceptionManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ProcessesManagement
Imports R2CoreParkingSystem.Drivers
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports PayanehClassLibrary.ProcessesManagement
Imports R2Core.LoggingManagement
Imports R2Core.UserManagement
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls.Exceptions
Imports R2CoreTransportationAndLoadNotification.Trucks
Imports R2CoreTransportationAndLoadNotification.Trucks.Exceptions
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls

Public Class FrmcCarAndDriversInformation
    Inherits FrmcGeneral

    Private _DateTime As R2DateTime = New R2DateTime
    Public Event _RelationCompleted()

#Region "General Properties"


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            InitializeSpecial()
            FrmRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Overrides Sub SetNSSProcess()
        Try
            SetProcess(R2CoreMClassProcessesManagement.GetNSSProcess(PayanehClassLibraryProcesses.FrmcCarAndDriversInformation))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub FrmRefresh()
        Try
            FrmcClearLocalMessage()
            UcNumbernIDCar.UCRefresh()
            UcCarTruck.UCRefreshGeneral()
            UcDriverTruckFirst.UCRefreshGeneral()
            UcDriverTruckSecond.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub FrmRefreshGeneral()
        FrmRefresh()
    End Sub

    Private Sub SabtRoutin()
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = (New R2Core.DatabaseManagement.R2PrimarySqlConnection).GetConnection()
        Try
            Dim myNSSTraficCard As R2CoreParkingSystemStandardTrafficCardStructure = UcTraficCard.UCGetNSS()
            Dim myNSSCarTruck As R2StandardCarTruckStructure = UcCarTruck.UCGetNSS()
            Dim myNSSDriverTruckFirst As R2StandardDriverTruckStructure = UcDriverTruckFirst.UCGetNSS()
            Dim myNSSDriverTruckSecond As R2StandardDriverTruckStructure = Nothing
            Try
                myNSSDriverTruckSecond = UcDriverTruckSecond.UCGetNSS()
            Catch ex As Exception
                FrmcViewLocalMessage("راننده دوم نامشخص است - " + ex.Message)
            End Try
            Dim myNSSCarTruckReserved As R2StandardCarTruckStructure = Nothing
            If UcNumbernIDCar.UCValue <> 0 Then
                Try
                    myNSSCarTruckReserved = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyCarId(UcNumbernIDCar.UCValue)
                Catch exx As GetNSSException
                Catch ex As Exception
                    Throw ex
                End Try
            End If
            CmdSql.Connection.Open()
            CmdSql.Transaction = CmdSql.Connection.BeginTransaction()
            ' حذف روابط قبلی کارت تردد با پلاک های دیگر
            CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Set RelationActive=0 Where CardId=" & myNSSTraficCard.CardId & ""
            CmdSql.ExecuteNonQuery()
            'حذف روابط قبلی پلاک با کارت های تردد دیگر
            CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Set RelationActive=0 Where nCarId=" & myNSSCarTruck.NSSCar.nIdCar & ""
            CmdSql.ExecuteNonQuery()
            'حذف روابط قبلی پلاک ابتدایی با کارت های تردد دیگر
            If myNSSCarTruckReserved IsNot Nothing Then
                CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars Set RelationActive=0 Where nCarId=" & myNSSCarTruckReserved.NSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
            End If
            'ایجاد رابطه جدید کارت و پلاک
            CmdSql.CommandText = "Insert into R2PrimaryParkingSystem.dbo.TblTrafficCardsRelationCars(CardId,nCarId,RelationActive) Values(" & myNSSTraficCard.CardId & "," & myNSSCarTruck.NSSCar.nIdCar & ",1)"
            CmdSql.ExecuteNonQuery()
            If myNSSCarTruckReserved IsNot Nothing Then
                'تعویض پلاک قبلی با پلاک چدید در بانک پارکینگ سیستم
                CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblEntryExit Set PelakEnter='" & myNSSCarTruck.NSSCar.StrCarNo & "',SerialEnter='" & myNSSCarTruck.NSSCar.StrCarSerialNo & "',CityEnter='" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(myNSSCarTruck.NSSCar.nIdCity) & "' Where PelakEnter='" & myNSSCarTruckReserved.NSSCar.StrCarNo & "' and SerialEnter='" & myNSSCarTruckReserved.NSSCar.StrCarSerialNo & "' and CityEnter='" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(myNSSCarTruckReserved.NSSCar.nIdCity) & "' and FlagA=0"
                CmdSql.ExecuteNonQuery()
            End If
            '  تعویض پلاک بر اساس کارت در بانک پارکینگ سیستم
            CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblEntryExit Set PelakEnter='" & myNSSCarTruck.NSSCar.StrCarNo & "',SerialEnter='" & myNSSCarTruck.NSSCar.StrCarSerialNo & "',CityEnter='" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(myNSSCarTruck.NSSCar.nIdCity) & "' Where CardNoEnter='" & myNSSTraficCard.CardNo & "' and FlagA=0"
            CmdSql.ExecuteNonQuery()
            ' تعویض کارت تردد بر اساس پلاک در بانک پارکینگ سیستم
            CmdSql.CommandText = "Update R2PrimaryParkingSystem.dbo.TblEntryExit Set CardNoEnter='" & myNSSTraficCard.CardNo & "' Where PelakEnter='" & myNSSCarTruck.NSSCar.StrCarNo & "' and SerialEnter='" & myNSSCarTruck.NSSCar.StrCarSerialNo & "' and CityEnter='" & R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(myNSSCarTruck.NSSCar.nIdCity) & "' and FlagA=0"
            CmdSql.ExecuteNonQuery()
            'تغییر کد ونام راننده به راننده موقت
            CmdSql.CommandText = "Update Dbtransport.dbo.TbEnterExit Set StrDriverName='" & R2CoreParkingSystemMClassDrivers.GetNSSTempDriver().StrPersonFullName & "',nDriverCode=" & R2CoreParkingSystemMClassDrivers.GetNSSTempDriver().nIdPerson & " Where nDriverCode=" & myNSSDriverTruckFirst.NSSDriver.nIdPerson & " and bflagDriver=0"
            CmdSql.ExecuteNonQuery()
            If myNSSCarTruckReserved IsNot Nothing Then
                'تغییر پلاک در جدول نوبت سپاس بر اساس پلاک جدید
                CmdSql.CommandText = "Update Dbtransport.dbo.TbEnterExit Set StrCardNo='" & myNSSCarTruck.NSSCar.nIdCar & "' Where StrCardNo='" & myNSSCarTruckReserved.NSSCar.nIdCar & "' and bFlagDriver=0"
                CmdSql.ExecuteNonQuery()
            End If
            'تغییر راننده در جدول نوبت سپاس
            CmdSql.CommandText = "Update Dbtransport.dbo.TbEnterExit Set StrDriverName='" & myNSSDriverTruckFirst.NSSDriver.StrPersonFullName & "',nDriverCode=" & myNSSDriverTruckFirst.NSSDriver.nIdPerson & " Where StrCardNo='" & myNSSCarTruck.NSSCar.nIdCar & "' and bFlagDriver=0"
            CmdSql.ExecuteNonQuery()
            If myNSSCarTruckReserved IsNot Nothing Then
                'تغییر پلاک قبلی با پلاک جدید در بانک سپاس
                CmdSql.CommandText = "Update Dbtransport.dbo.TbGhabz Set nIdCar=" & myNSSCarTruck.NSSCar.nIdCar & " Where nIdCar=" & myNSSCarTruckReserved.NSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
            End If
            'تغییر پلاک بر اساس کارت تردد در بانک سپاس
            CmdSql.CommandText = "Update Dbtransport.dbo.TbGhabz Set nIdCar=" & myNSSCarTruck.NSSCar.nIdCar & " Where StrBarCodeNo='" & myNSSTraficCard.CardNo & "'"
            CmdSql.ExecuteNonQuery()
            'تغییر کارت تردد بر اساس پلاک در بانک سپاس
            CmdSql.CommandText = "Update Dbtransport.dbo.TbGhabz Set StrBarCodeNo='" & myNSSTraficCard.CardNo & "' Where nIdCar=" & myNSSCarTruck.NSSCar.nIdCar & ""
            CmdSql.ExecuteNonQuery()
            'حذف ارتباط راننده اول و دوم در صورت وجود با ناوگان
            If myNSSDriverTruckFirst IsNot Nothing Then
                If MessageBox.Show("ارتباط راننده اول با ناوگان دیگر حذف شود؟", "R2PrimarySystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    CmdSql.CommandText = "Delete Dbtransport.dbo.TbCarAndPerson Where nIdPerson=" & myNSSDriverTruckFirst.NSSDriver.nIdPerson & ""
                    CmdSql.ExecuteNonQuery()
                End If
            End If
            If myNSSDriverTruckSecond IsNot Nothing Then
                If MessageBox.Show("ارتباط راننده دوم با ناوگان دیگر حذف شود؟", "R2PrimarySystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    CmdSql.CommandText = "Delete Dbtransport.dbo.TbCarAndPerson Where nIdPerson=" & myNSSDriverTruckSecond.NSSDriver.nIdPerson & ""
                    CmdSql.ExecuteNonQuery()
                End If
            End If
            'حذف ارتباط پلاک قبلی با راننده ها
            If myNSSCarTruckReserved IsNot Nothing Then
                CmdSql.CommandText = "Delete Dbtransport.dbo.TbCarAndPerson Where nIdCar=" & myNSSCarTruckReserved.NSSCar.nIdCar & ""
                CmdSql.ExecuteNonQuery()
            End If
            'حذف ارتباط پلاک جدید با راننده ها
            CmdSql.CommandText = "Delete Dbtransport.dbo.TbCarAndPerson Where nIdCar=" & myNSSCarTruck.NSSCar.nIdCar & ""
            CmdSql.ExecuteNonQuery()
            'ایجاد رابطه جدید راننده اول با پلاک
            CmdSql.CommandText = "Insert into Dbtransport.dbo.TbCarAndPerson(nIdCar,nIdPerson,snRelation,dDate) Values(" & myNSSCarTruck.NSSCar.nIdCar & "," & myNSSDriverTruckFirst.NSSDriver.nIdPerson & ",2,'" & _DateTime.GetCurrentDateShamsiFull() & "')"
            CmdSql.ExecuteNonQuery()
            'ایجاد رابطه جدید راننده دوم با پلاک در صورت موجود بودن راننده دوم
            If myNSSDriverTruckSecond IsNot Nothing Then
                CmdSql.CommandText = "Insert into Dbtransport.dbo.TbCarAndPerson(nIdCar,nIdPerson,snRelation,dDate) Values(" & myNSSCarTruck.NSSCar.nIdCar & "," & myNSSDriverTruckSecond.NSSDriver.nIdPerson & ",3,'" & _DateTime.GetCurrentDateShamsiFull() & "')"
                CmdSql.ExecuteNonQuery()
            End If
            CmdSql.Transaction.Commit() : CmdSql.Connection.Close()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "ارتباط کارت تردد ، خودرو و راننده ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.RegisterRecords, "ثبت روابط اطلاعاتی کارت و پلاک و راننده", myNSSTraficCard.CardNo, 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
        Catch exx As GetNSSException
            If CmdSql.Connection.State <> ConnectionState.Closed Then
                CmdSql.Transaction.Rollback()
                CmdSql.Connection.Close()
            End If
            Throw New Exception("مشخصات و اطلاعات کارت تردد ، پلاک و راننده به طور کامل مشخص نیست")
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then
                CmdSql.Transaction.Rollback()
                CmdSql.Connection.Close()
            End If
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub FrmcCarAndDriversInformation__RFIDCardReadedEvent(CardNo As String) Handles Me._RFIDCardReadedEvent
        Try
            UcTraficCard.UCShowTrafficCard(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(CardNo))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Private Sub FrmcCarAndDriversInformation__RFIDCardStartToReadEvent() Handles Me._RFIDCardStartToReadEvent
    End Sub

    Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        Try
            SabtRoutin()
            RaiseEvent _RelationCompleted()

        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcTraficCard_UCViewTrafficCardCompeleted(NSS As R2CoreParkingSystemStandardTrafficCardStructure) Handles UcTraficCard.UCViewTrafficCardCompeleted
        Try
            FrmRefresh()
            Dim nIdCar As Int64 = R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(NSS.CardId)
            UcCarTruck.UCViewCarInformation(nIdCar)
            UcNumbernIDCar.UCValue = nIdCar
        Catch exx As GetDataException
            FrmcViewLocalMessage(exx.Message)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCarTruck_UCViewCarTruckInformationCompleted(CarId As String) Handles UcCarTruck.UCViewCarTruckInformationCompleted
        Try
            UcDriverTruckFirst.UCRefreshGeneral()
            UcDriverTruckSecond.UCRefreshGeneral()
            UcDriverTruckFirst.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonFirst(CarId))
            UcDriverTruckSecond.UCViewDriverInformation(R2CoreParkingSystemMClassCars.GetnIdPersonSecond(CarId))
        Catch exx As GetDataException
            FrmcViewLocalMessage(exx.Message)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcCarTruck_UCRefreshedGeneralEvent() Handles UcCarTruck.UCRefreshedGeneralEvent
        UcDriverTruckFirst.UCRefreshGeneral()
        UcDriverTruckSecond.UCRefreshGeneral()
    End Sub

    Private Sub UcCarTruckPnlTrucksRelationAnnouncementHalls_UCViewCarTruckInformationCompleted(CarId As String) Handles UcCarTruckPnlTrucksRelationAnnouncementHalls.UCViewCarTruckInformationCompleted
        Try
            UcViewerNSSAnnouncementHallSubGroup.UCViewNSS(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSAnnouncementHallSubGroup(CarId))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcAnnouncementHallSelection_UCCurrentNSSChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection.UCCurrentNSSChangedEvent
        Try
            If NSSAnnouncementHallSubGroup Is Nothing Then Exit Sub
            R2CoreTransportationAndLoadNotificationMClassTrucksManagement.SetTruckRelationAnnouncementHallSubGroup(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(UcCarTruckPnlTrucksRelationAnnouncementHalls.UCGetNSS().NSSCar.nIdCar), NSSAnnouncementHallSubGroup)
            UcViewerNSSAnnouncementHallSubGroup.UCViewNSS(NSSAnnouncementHallSubGroup)
            FrmcViewLocalMessage("ارتباط ناوگان باری و سالن اعلام بار برقرار شد")
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.RegisterRecords, "ثبت رابطه ناوگان باری و سالن اعلام بار", UcCarTruckPnlTrucksRelationAnnouncementHalls.UCGetNSS().NSSCar.GetCarPelakSerialComposit(), 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
            UcAnnouncementHallSelection.UCRefresh()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups_UCClickedEvent() Handles UcButtonDeleteAllofTruckRellationAnnouncementHallSubGroups.UCClickedEvent
        Try
            R2CoreTransportationAndLoadNotificationMClassTrucksManagement.DisabledAllTruckRelationAnnouncementHallSubGroups(R2CoreTransportationAndLoadNotificationMClassTrucksManagement.GetNSSTruck(UcCarTruckPnlTrucksRelationAnnouncementHalls.UCGetNSS().NSSCar.nIdCar))
            UcViewerNSSAnnouncementHallSubGroup.UCViewNSSNothing()
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "کلیه روابط ناوگان باری با زیرگروه های اعلام بار حذف شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            R2CoreMClassLoggingManagement.LogRegister(New R2CoreStandardLoggingStructure(0, R2CoreLogType.RegisterRecords, "حذف کلیه روابط ناوگان باری و زیرگروه های اعلام بار", UcCarTruckPnlTrucksRelationAnnouncementHalls.UCGetNSS().NSSCar.GetCarPelakSerialComposit(), 0, 0, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, _DateTime.GetCurrentDateTimeMilladiFormated(), _DateTime.GetCurrentDateShamsiFull))
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)

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