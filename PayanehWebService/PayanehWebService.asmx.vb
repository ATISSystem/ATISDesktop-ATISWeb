
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.ComputerMessagesManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.SoftwareUserManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports PayanehClassLibrary.ReportsManagement
Imports PayanehClassLibrary.TransportCompanies
Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports PayanehClassLibrary.DriverTrucksManagement
Imports R2Core.ExceptionManagement
Imports R2Core.SecurityAlgorithmsManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2Core.SoftwareUserManagement.Exceptions
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

    Private Shared _ExchangeKeyManager As New ExchangeKeyManager


    <WebMethod()>
    Public Function WebMethodLogin(YourUserShenaseh As String, YourUserPassword As String) As Int64
        Try
            Return _ExchangeKeyManager.Login(YourUserShenaseh, YourUserPassword)
        Catch ex As Exception When TypeOf (ex) Is UserIsNotActiveException OrElse TypeOf (ex) Is UserNotExistException OrElse TypeOf (ex) Is GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodGetDSPersonnelFingerPrints(YourSalFull As String, YourMonthCodeFull As String, YourExchangeKey As Int64) As DataSet
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Return PayanehClassLibrary.HumanManagement.Personnel.PayanehClassLibraryMClassPersonnelAttendanceManagement.GetDSPersonelFingerPrints(YourSalFull, YourMonthCodeFull)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerLoadPermissionsIssuedOrderByPriorityReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourSequentialTurnKeyWord As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderLoadPermissionIssuedOrderByPriorityReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourSequentialTurnKeyWord)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerSedimentedLoadsReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAnnouncementHallId As Int64, YourSedimentedLoadsReportType As Int32, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderSedimentedLoadsReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourAnnouncementHallId, CType(YourSedimentedLoadsReportType, PayanehClassLibraryMClassReportsManagement.SedimentedLoadsReportType))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTruckersAssociationFinancialReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTruckersAssociationFinancialReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerContractorCompanyFinancialReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourVatStatus As Boolean, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderContractorCompanyFinancialReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourVatStatus)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerDriverTruckLoadsReport(YourDriverId As Int64, YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderDriverTruckLoadsReport(YourDriverId, New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerCapacitorLoadsforAnnounceReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderCapacitorLoadsforAnnounceReport(YourAnnouncementHallId, YourAnnouncementHallSubGroupId)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerCapacitorLoadsTransportCompaniesRegisteredLoadsReport(YourAnnouncementHallId As Int64, YourCompanyCode As Int64, YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourTargetCityId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderCapacitorLoadsCompanyRegisteredLoadsReport(YourAnnouncementHallId, YourCompanyCode, New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourTargetCityId)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerAnnouncementHallsPerformanceReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAHId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderAnnouncementHallPerformanceReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), PayanehClassLibrary.AnnouncementHallsManagement.AnnouncementHalls.PayanehClassLibraryAnnouncementHallsManagement.GetNSSAnnouncementHall(YourAHId))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerAnnouncementHallsPerformanceGeneralStatisticsReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderAnnouncementHallPerformanceGeneralStatisticsReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTruckDriversWaitingToGetLoadPermissionReport(YourAnnouncementHallSubGroupId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTruckDriversWaitingToGetLoadPermissionReport(R2CoreTransportationAndLoadNotificationMClassAnnouncementHallsManagement.GetNSSAnnouncementHallSubGroup(YourAnnouncementHallSubGroupId))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTrucksAverageOfSleepDaysToGetLoadPermissionReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourAnnouncementHallId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTrucksAverageOfSleepDaysToGetLoadPermissionReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourAnnouncementHallId)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTravelLengthOfLoadTargetsReport(YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTravelLengthOfLoadTargetsReport()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderTransportPriceTarrifsReport(YourAnnouncementHallId As Int64, YourAnnouncementHallSubGroupId As Int64, YourOActiveStatus As Boolean, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderTransportPriceTarrifsReport(YourAnnouncementHallId, YourAnnouncementHallSubGroupId, YourOActiveStatus)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderIndigenousTrucksWithUNNativeLPReport(YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            PayanehClassLibraryMClassReportsManagement.ReportingInformationProviderIndigenousTrucksWithUNNativeLPReport()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodCarTruckHasTurn(YourPelak As String, YourSerial As String, YourExchangeKey As Int64) As Boolean
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim myTruck
            Dim mySeqT
            Return R2CoreTransportationAndLoadNotificationMClassTurnsManagement.ExistActiveTurn(myTruck, mySeqT)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodGetnIdCarTruckBySmartCarNo(YourSmartCardNo As String, YourExchangeKey As Int64) As Int64
        Try
            Dim NSS = _ExchangeKeyManager.GetNSSUser(YourExchangeKey)
            Return PayanehClassLibraryMClassCarTrucksManagement.GetNSSCarTruckBySmartCardNoWithUpdating(YourSmartCardNo, NSS).NSSCar.nIdCar
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As GetNSSException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodISCompanyActive(YourCompanyCode As Int64, YourExchangeKey As Int64) As Boolean
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Return TransportCompaniesLoadCapacitorLoadManipulation.ISCompanyActive(YourCompanyCode)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


End Class

