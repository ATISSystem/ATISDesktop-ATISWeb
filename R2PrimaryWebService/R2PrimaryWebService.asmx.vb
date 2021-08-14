

Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Reflection

Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2Core.HumanResourcesManagement.Personnel
Imports R2Core.SecurityAlgorithmsManagement
Imports R2Core.SecurityAlgorithmsManagement.Exceptions
Imports R2Core.SoftwareUserManagement
Imports R2Core.SoftwareUserManagement.Exceptions
Imports R2Core.MoneyWallet.MoneyWalletCharging
Imports R2Core.MoneyWallet.PaymentRequests
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.MoneyWalletChargeManagement
Imports R2CoreParkingSystem.ReportsManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreTransportationAndLoadNotification.ReportManagement


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class R2PrimaryWebService
    Inherits System.Web.Services.WebService

    Private _DateTime As R2DateTime = New R2DateTime()
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
    Public Sub WebMethodReportingInformationPrividerMoneyWalletsCurrentChargeReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderMoneyWalletsCurrentChargeReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerUsersChargeReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderUsersChargeReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerSoldRFIDCardsReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderSoldRFIDCardsReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerParkingTotalEnteranceSeparationByTerraficCardReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderParkingTotalEnteranceSeparationByTerraficCardReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerPresentCarsInParkingReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourTerraficCardType As Int16, YourViewCarImages As Boolean, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderPresentCarsInParkingReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), YourTerraficCardType, YourViewCarImages)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerBlackListFinancialReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderBlackListFinancialReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerCarEntranceReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourTerraficCard As String, YourPelak As String, YourSerial As String, YourEntranceDateTimeSupport As Int16, YourViewCarImages As Boolean, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim NSSTerraficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing
            If YourTerraficCard.Trim <> String.Empty Then
                NSSTerraficCard = IIf(YourTerraficCard.Trim = String.Empty, Nothing, R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourTerraficCard))
            End If
            Dim NSSCar As R2StandardCarStructure = Nothing
            If YourPelak.Trim <> String.Empty Then
                NSSCar = IIf(YourPelak.Trim = String.Empty, Nothing, New R2StandardCarStructure(0, 0, YourPelak, YourSerial, 0))
            End If
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderCarEntranceReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), NSSTerraficCard, NSSCar, YourEntranceDateTimeSupport, YourViewCarImages)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerTerraficCardsIdentityReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderTerraficCardsIdentityReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerBlackListReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourBlackListType As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassReportsManagement.ReportingInformationProviderBlackListReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2), YourBlackListType)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodGetCurrentDateTimeMilladi(YourExchangeKey As Int64) As DateTime
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Return _DateTime.GetCurrentDateTimeMilladiFormated()
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodRegisteringHandyBills(YourTeadad As Int64, YourShamsiDate As String, YourTerafficCardType As Int64, YourExchangeKey As Int64)
        Try
            Dim NSS = _ExchangeKeyManager.GetNSSUser(YourExchangeKey)
            R2CoreParkingSystemMClassEnterExitManagement.RegisteringHandyBills(YourTeadad, New R2StandardDateAndTimeStructure(Nothing, YourShamsiDate, Nothing), YourTerafficCardType, NSS)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodGetTotalRegisteredHandyBills(YourShamsiDate As String, YourTerafficCardType As Int64, YourExchangeKey As Int64) As Int64
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Return R2CoreParkingSystemMClassEnterExitManagement.GetTotalRegisteredHandyBills(New R2StandardDateAndTimeStructure(Nothing, YourShamsiDate, Nothing), YourTerafficCardType)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodDeleteRegisteredHandyBills(YourShamsiDate As String, YourTerafficCardType As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassEnterExitManagement.DeleteRegisteredHandyBills(New R2StandardDateAndTimeStructure(Nothing, YourShamsiDate, Nothing), YourTerafficCardType)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationPrividerPersonnelEnterExitReport(YourDateTimeMilladi1 As DateTime, YourDateShamsiFull1 As String, YourTime1 As String, YourDateTimeMilladi2 As DateTime, YourDateShamsiFull2 As String, YourTime2 As String, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CorePersonnelMClassManagement.ReportingInformationProviderPersonnelEnterExitReport(New R2StandardDateAndTimeStructure(YourDateTimeMilladi1, YourDateShamsiFull1, YourTime1), New R2StandardDateAndTimeStructure(YourDateTimeMilladi2, YourDateShamsiFull2, YourTime2))
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodExistCar(YourPelak As String, YourSerial As String, YourExchangeKey As Int64) As Boolean
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreParkingSystemMClassCars.GetnIdCar(New R2StandardLicensePlateStructure(YourPelak, YourSerial, R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(R2CoreParkingSystemMClassCitys.IRANCityCode), Nothing))
            Return True
        Catch exx As GetDataException
            Return False
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderBillOfLadingControlReport(YourBLCId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreTransportationAndLoadNotificationReportsManagement.ReportingInformationProviderBillOfLadingControlReport(YourBLCId)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub WebMethodReportingInformationProviderBillOfLadingControlInfractionsReport(YourBLCIId As Int64, YourExchangeKey As Int64)
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            R2CoreTransportationAndLoadNotificationReportsManagemenT.ReportingInformationProviderBillOfLadingControlInfractionReport(YourBLCIId)
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function WebMethodPaymentRequest(YourMCSSId As Int64, YourAmount As Int64, YourSoftwareUserId As Int64, YourExchangeKey As Int64) As Int64
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim InstancePaymentRequests = New R2CoreInstansePaymentRequestsManager
            Dim PayId = InstancePaymentRequests.PaymentRequest(YourMCSSId, YourAmount, YourSoftwareUserId)
            Return PayId
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function WebMethodVerificationRequest(YourMCSSId As Int64, YourAuthority As String, YourExchangeKey As Int64) As Int64
        Try
            _ExchangeKeyManager.AuthenticationExchangeKey(YourExchangeKey)
            Dim InstancePaymentRequests = New R2CoreInstansePaymentRequestsManager
            Dim PayId = InstancePaymentRequests.VerificationRequest(YourMCSSId, YourAuthority)
            Return PayId
        Catch ex As ExchangeKeyTimeRangePassedException
            Throw ex
        Catch ex As ExchangeKeyNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function



End Class