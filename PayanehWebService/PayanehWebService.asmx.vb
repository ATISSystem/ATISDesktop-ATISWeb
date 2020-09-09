
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Reflection
 
Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.UserManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports PayanehClassLibrary.ReportsManagement
Imports PayanehClassLibrary.TransportCompanies
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports PayanehClassLibrary.Rmto
Imports R2Core.ExceptionManagement
Imports R2Core.UserManagement.Exceptions
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoadManipulation
Imports R2CoreTransportationAndLoadNotification.Turns
Imports R2CoreTransportationAndLoadNotification.Turns.SequentialTurns


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class PayanehWebService
    Inherits System.Web.Services.WebService


    Private _CurrentUserNSS As R2CoreStandardUserStructure = Nothing

    <WebMethod()>
    Private Sub WebMethodSetUserByShenasehPassword(YourUserShenaseh As String,YourUserPassword As String)
        Try
           if R2CoreMClassLoginManagement.AuthenticationUserbyShenasehPassword(New R2CoreStandardUserStructure(Int64.MinValue,String.Empty,YourUserShenaseh,YourUserPassword,String.Empty,Boolean.FalseString,Boolean.FalseString))
               _CurrentUserNSS = R2CoreMClassLoginManagement.GetNSSUser(YourUserShenaseh, YourUserPassword)
           End If
        Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerSedimentedLoadsReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAnnouncementHallId As Int64, YourSedimentedLoadsReportType As Int32)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderSedimentedLoadsReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourAnnouncementHallId, CType(YourSedimentedLoadsReportType, PayanehClassLibraryMClassReportsManagement.SedimentedLoadsReportType))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTruckersAssociationFinancialReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTruckersAssociationFinancialReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerContractorCompanyFinancialReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourVatStatus As Boolean)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderContractorCompanyFinancialReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourVatStatus)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerDriverTruckLoadsReport(YourDriverId As Int64, YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderDriverTruckLoadsReport(YourDriverId, New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerCapacitorLoadsforAnnounceReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderCapacitorLoadsforAnnounceReport(YourAnnouncementHallId, YourAnnouncementHallSubGroupId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(YourAnnouncementHallId As Int64, YourCompanyCode As Int64, YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourTargetCityId As Int64)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderCapacitorLoadsCompanyRegisteredLoadsReport(YourAnnouncementHallId, YourCompanyCode, New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourTargetCityId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerAnnouncementHallsPerformanceReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAHId As Int64)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderAnnouncementHallPerformanceReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls.PayanehClassLibraryAnnouncementHallsManagement.GetNSSAnnouncementHall(YourAHId))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerAnnouncementHallsPerformanceGeneralStatisticsReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderAnnouncementHallPerformanceGeneralStatisticsReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTruckDriversWaitingToGetLoadPermissionReport(YourAnnouncementHallSubGroupId As Int64)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTruckDriversWaitingToGetLoadPermissionReport(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroup(YourAnnouncementHallSubGroupId))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTrucksAverageOfSleepDaysToGetLoadPermissionReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAnnouncementHallId As Int64)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTrucksAverageOfSleepDaysToGetLoadPermissionReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourAnnouncementHallId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTravelLengthOfLoadTargetsReport()
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTravelLengthOfLoadTargetsReport()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderTransportPriceTarrifsReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64, YourOActiveStatus As Boolean)
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTransportPriceTarrifsReport(YourAnnouncementHallId, YourAnnouncementHallSubGroupId, YourOActiveStatus)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderIndigenousTrucksWithUNNativeLPReport()
        Try
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderIndigenousTrucksWithUNNativeLPReport()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodGetDSPersonnelFingerPrints(YourSalFull As String, YourMonthCodeFull As String) As DataSet
        Try
            Return PayanehClassLibrary.HumanManagement.Personnel.PayanehClassLibraryMClassPersonnelAttendanceManagement.GetDSPersonelFingerPrints(YourSalFull, YourMonthCodeFull)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodComputerMessageProduceCopyOfTurn(YourPelak As String, YourSerial As String)
        Try
            Dim DataStruct As DataStruct = New DataStruct()
            Dim NSSCar As R2StandardCarStructure = R2CoreParkingSystemMClassCars.GetNSSCar(R2CoreParkingSystemMClassCars.GetnIdCar(New R2CoreLPR.LicensePlateManagement.R2StandardLicensePlateStructure(YourPelak, YourSerial, R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(R2CoreParkingSystemMClassCitys.IRANCityCode), Nothing)))
            DataStruct.Data1 = PayanehClassLibrary.CarTruckNobatManagement.PayanehClassLibraryMClassCarTruckNobatManagement.GetLastActiveNSSNobat(NSSCar).nEnterExitId
            R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, NSSCar.GetCarPelakSerialComposit(), 3, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
        Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodComputerMessageProduceSodoorNobat(YourPelak As String, YourSerial As String)
        Try
            Dim DataStruct As DataStruct = New DataStruct()
            Dim NSSCar As R2StandardCarStructure = R2CoreParkingSystemMClassCars.GetNSSCar(R2CoreParkingSystemMClassCars.GetnIdCar(New R2CoreLPR.LicensePlateManagement.R2StandardLicensePlateStructure(YourPelak, YourSerial, R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(R2CoreParkingSystemMClassCitys.IRANCityCode), Nothing)))
            DataStruct.Data1 = NSSCar.nIdCar
            R2CoreMClassComputerMessagesManagement.SendComputerMessage(New R2StandardComputerMessageStructure(Nothing, NSSCar.GetCarPelakSerialComposit(), 2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DataStruct))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodCarTruckHasTurn(YourPelak As String, YourSerial As String) As Boolean
        Try
            Dim myTruck
            Dim mySeqT
            Return R2CoreTransportationAndLoadNotificationMClassTurnsManagement.ExistActiveTurn(myTruck, mySeqT)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoadCapacitorLoadRegister(YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournCarNumKol As Int64, YourStrPriceSug As String, YourStrDescription As String) As Int64
        Try
            Return R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadRegistering(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, YourStrBarName, YournCityCode, YournBarCode, YournCompCode, YournTruckType, YourStrAddress, _CurrentUserNSS.UserId, YournCarNumKol, YourStrPriceSug, YourStrDescription, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoadCapacitorLoadRegisterWithTTPTId(YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournCarNumKol As Int64, YourStrPriceSug As String, YourStrDescription As String, ByVal YourTarrifTransportPriceTypeId As Int64) As Int64
        Try
            Return R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadRegistering(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(0, YourStrBarName, YournCityCode, YournBarCode, YournCompCode, YournTruckType, YourStrAddress, _CurrentUserNSS.UserId, YournCarNumKol, YourStrPriceSug, YourStrDescription, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodTransportCompanyLoadCapacitorLoadEdit(YournEstelamId As Int64, YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournCarNumKol As Int64, YourStrPriceSug As String, YourStrDescription As String, YourUserNSS As R2CoreStandardUserStructure)
        Try
            R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadEditing(New R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure(YournEstelamId, YourStrBarName, YournCityCode, YournBarCode, YournCompCode, YournTruckType, YourStrAddress, Nothing, YournCarNumKol, YourStrPriceSug, YourStrDescription, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing),_CurrentUserNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodTransportCompanyLoadCapacitorLoadDelete(YournEstelamId As Int64)
        Try
            Dim NSS = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoad(YournEstelamId)
            R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManipulationManagement.LoadCapacitorLoadDeleting(NSS,_CurrentUserNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoads() As DataSet
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetLoads()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyCities() As DataSet
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetCities()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyCarTypes() As DataSet
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetCarTypes()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoadCapacitorLoads(YourCompanyCode As Int64) As DataSet
        Try
            'Return R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNotSedimentedLoadCapacitorLoads(YourCompanyCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoadCapacitorSedimentedLoads(YourCompanyCode As Int64) As DataSet
        Try
            'Return R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetSedimentedLoadCapacitorLoads(YourCompanyCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodGetNSSCarTruckBySmartCarNofromRmto(YourSmartCardNo As String, ByRef Pelak As String, ByRef Serial As String)
        Try
            Dim NSS As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetCarTruckfromRMTOAndInsertUpdateLocalDataBase(YourSmartCardNo,_CurrentUserNSS)
            Pelak = NSS.NSSCar.StrCarNo : Serial = NSS.NSSCar.StrCarSerialNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodGetNSSCarTruckBySmartCarNofromLocalDataBase(YourSmartCardNo As String, ByRef Pelak As String, ByRef Serial As String)
        Try
            Dim NSS As R2StandardCarTruckStructure = PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckbyBodyNo(YourSmartCardNo)
            Pelak = NSS.NSSCar.StrCarNo : Serial = NSS.NSSCar.StrCarSerialNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodGetNSSDriverTruckBySmartCarNofromRmto(YourSmartCardNo As String, ByRef PersonFullName As String, ByRef NationalCode As String, ByRef DrivingLicenceNo As String)
        Try
            Dim NSS As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetDriverTruckfromRMTOAndInsertUpdateLocalDataBase(YourSmartCardNo)
            PersonFullName = NSS.NSSDriver.StrPersonFullName : NationalCode = NSS.NSSDriver.StrNationalCode : DrivingLicenceNo = NSS.NSSDriver.strDrivingLicenceNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodGetNSSDriverTruckBySmartCarNofromLocalDataBase(YourSmartCardNo As String, ByRef PersonFullName As String, ByRef NationalCode As String, ByRef DrivingLicenceNo As String)
        Try
            Dim NSS As R2StandardDriverTruckStructure = PayanehClassLibraryMClassDriverTrucksManagement.GetNSSDriverTruckbySmartCardNo(YourSmartCardNo)
            PersonFullName = NSS.NSSDriver.StrPersonFullName : NationalCode = NSS.NSSDriver.StrNationalCode : DrivingLicenceNo = NSS.NSSDriver.strDrivingLicenceNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodMobileUserMobileNumberRegistering(YourSmartCardNo As String, YourMobileNumber As String)
        Try
            R2CoreTransportationAndLoadNotification.TruckDrivers.R2CoreTransportationAndLoadNotificationMClassTruckDriversManagement.TruckDriverMobileEditing(YourSmartCardNo, YourMobileNumber)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodCreateRelationBetweenCarTruckAndDriverTruck(YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String)
        Try
            PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.CarTruckRelationDriverTruck(YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodTransportCompanyLoadCapacitorSedimentLoadAllocationMessageProduce(YourComapnyCode As Int64, YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String, YourUserNSS As R2CoreStandardUserStructure)
        Try
            PayanehClassLibrary.LoadNotification.LoadAllocation.LoadNotificationLoadAllocationManagement.TransportCompanyLoadCapacitorSedimentLoadAllocationMessageProduce(YourComapnyCode, YournEstelamId, YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodTransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(YourComapnyCode As Int64, YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String) As Int64
        Try
            Return PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.TransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(YourComapnyCode, YournEstelamId, YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo,_CurrentUserNSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodTransportCompanyGetLoadCapacitorSedimentLoadPermisiionPrintingInf(YournEstelamId As Int64, YourTurnId As Int64, ByRef StrExitDate As String, ByRef StrExitTime As String, ByRef nEstelamId As String, ByRef TurnId As String, ByRef CompanyName As String, ByRef CarTruckLoaderTypeName As String, ByRef Pelak As String, ByRef Serial As String, ByRef DriverTruckFullNameFamily As String, ByRef DriverTruckDrivingLicenseNo As String, ByRef ProductName As String, ByRef TargetCityName As String, ByRef StrPriceSug As String, ByRef StrDescription As String, ByRef PermissionUserName As String, ByRef OtherNote As String)
        Try
            PayanehClassLibrary.LoadNotification.LoadPermission.PermissionPrinting.GetInformationforRemotePermissionPrinting(YournEstelamId, YourTurnId, StrExitDate, StrExitTime, nEstelamId, TurnId, CompanyName, CarTruckLoaderTypeName, Pelak, Serial, DriverTruckFullNameFamily, DriverTruckDrivingLicenseNo, ProductName, TargetCityName, StrPriceSug, StrDescription, PermissionUserName, OtherNote)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodTransportCompanyGetMoneyWalletInventory(YourComapnyCode As Int64) As Int64
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompanyMoneyWalletInventory(YourComapnyCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodGetAllPermissionEnterExits(YournEstelamId As Int64) As DataSet
        Try
            'Return PayanehClassLibrary.LoadNotification.LoadPermission.LoadNotificationLoadPermissionManagement.GetAllPermissionEnterExits(YournEstelamId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodGetTransportCompaniesDailyMessage(ByRef YourDailyMessageColorHolder As String) As String
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesDailyMessage(YourDailyMessageColorHolder)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodGetTransportCompaniesFirstPageMessages() As String
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.GetTransportCompaniesFirstPageMessages()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodISCompanyActive(YourCompanyCode As Int64) As Boolean
        Try
            Return TransportCompaniesLoadCapacitorLoadManipulation.ISCompanyActive(YourCompanyCode)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


End Class