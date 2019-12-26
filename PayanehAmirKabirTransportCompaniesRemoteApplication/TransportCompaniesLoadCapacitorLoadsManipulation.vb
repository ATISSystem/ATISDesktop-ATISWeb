
Imports System.Drawing.Printing
Imports System.Reflection

Imports PAKTCRemoteApplication.PayanehWS
Imports R2CoreWinFormRemoteApplications
Imports R2CoreWinFormRemoteApplications.BaseStandardClasses
Imports R2CoreWinFormRemoteApplications.ConfigurationManagement

Public Class TransportCompaniesStandardLoadCapacitorLoadStructure


#Region "Constructing Management"

    Public Sub New()
        MyBase.New()
        _nEstelamId = 0
        _StrBarName = String.Empty
        _nCityCode = 0
        _nBarCode = 0
        _nCompCode = 0
        _nTruckType = 0
        _StrAddress = String.Empty
        _nCarNumKol = 0
        _StrPriceSug = String.Empty
        _StrDescription = String.Empty
        _dDateElam = String.Empty
        _dTimeElam = String.Empty
        _nCarNum = 0

    End Sub

    Public Sub New(ByVal YournEstelamId As Int64, YourStrBarName As String, YournCityCode As Int64, YournBarCode As Int64, YournCompCode As Int64, YournTruckType As Int64, YourStrAddress As String, YournCarNumKol As Int64, YourStrPriceSug As String, YourStrDescription As String, YourdDateElam As String, YourdTimeElam As String, YournCarNum As Int64)
        _nEstelamId = YournEstelamId
        _StrBarName = YourStrBarName
        _nCityCode = YournCityCode
        _nBarCode = YournBarCode
        _nCompCode = YournCompCode
        _nTruckType = YournTruckType
        _StrAddress = YourStrAddress
        _nCarNumKol = YournCarNumKol
        _StrPriceSug = YourStrPriceSug
        _StrDescription = YourStrDescription
        _dDateElam = YourdDateElam
        _dTimeElam = YourdTimeElam
        _nCarNum = YournCarNum
    End Sub

#End Region

#Region "Properting Management"

    Public Property nEstelamId As Int64
    Public Property StrBarName As String
    Public Property nCityCode As Int64
    Public Property nBarCode As Int64
    Public Property nCompCode As Int64
    Public Property nTruckType As Int64
    Public Property StrAddress As String
    Public Property nCarNumKol As Int64
    Public Property StrPriceSug As String
    Public Property StrDescription As String
    Public Property dDateElam() As String
    Public Property dTimeElam() As String
    Public Property nCarNum As Int64

#End Region
End Class

Public Class TransportCompaniesLoadCapacitorLoadsManipulation

    Public Shared WS As PayanehWS.PayanehWebService = New PayanehWebService()
    Public Shared Property Loads() As DataSet = Nothing
    Public Shared Property Cities() As DataSet = Nothing
    Public Shared Property CarTypes() As DataSet = Nothing

    Public Shared Sub FillCarTypes()
        Try
            Cursor.Current = Cursors.WaitCursor
            CarTypes = WS.WebMethodTransportCompanyCarTypes()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Shared Sub FillCities()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cities = WS.WebMethodTransportCompanyCities()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Shared Sub FillLoads()
        Try
            Cursor.Current = Cursors.WaitCursor
            Loads = WS.WebMethodTransportCompanyLoads()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Shared Function GetLoads(YourSearchString As String) As List(Of R2StandardStructure)
        Try
            Dim DR As DataRow() = Loads.Tables(0).Select("StrGoodName Like '%" & YourSearchString.Replace("ی", "ي").Replace("ک", "ك") & "%'")
            Dim Lst As List(Of R2StandardStructure) = New List(Of R2StandardStructure)()
            For Loopx As Int64 = 0 To DR.Count - 1
                Lst.Add(New R2StandardStructure(DR(Loopx).Item("StrGoodCode"), DR(Loopx).Item("StrGoodName")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetLoad(YourStrGoodCode As Int64) As R2StandardStructure
        Try
            Dim DR As DataRow() = Loads.Tables(0).Select("StrGoodCode=" & YourStrGoodCode & "")
            Return New R2StandardStructure(DR(0).Item("StrGoodCode"), DR(0).Item("StrGoodName"))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetCities(YourSearchString As String) As List(Of R2StandardStructure)
        Try
            Dim DR As DataRow() = Cities.Tables(0).Select("StrCityName Like '%" & YourSearchString.Replace("ی", "ي").Replace("ک", "ك") & "%'")
            Dim Lst As List(Of R2StandardStructure) = New List(Of R2StandardStructure)()
            For Loopx As Int64 = 0 To DR.Count - 1
                Lst.Add(New R2StandardStructure(DR(Loopx).Item("nCityCode"), DR(Loopx).Item("StrCityName")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetCity(YournCityCode As Int64) As R2StandardStructure
        Try
            Dim DR As DataRow() = Cities.Tables(0).Select("nCityCode=" & YournCityCode & "")
            Return New R2StandardStructure(DR(0).Item("nCityCode"), DR(0).Item("StrCityName"))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetCarTypes(YourSearchString As String) As List(Of R2StandardStructure)
        Try
            Dim DR As DataRow() = CarTypes.Tables(0).Select("StrCarName Like '%" & YourSearchString.Replace("ی", "ي").Replace("ک", "ك") & "%'")
            Dim Lst As List(Of R2StandardStructure) = New List(Of R2StandardStructure)()
            For Loopx As Int64 = 0 To DR.Count - 1
                Lst.Add(New R2StandardStructure(DR(Loopx).Item("snCarType"), DR(Loopx).Item("StrCarName")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetCarType(YoursnCarType As Int64) As R2StandardStructure
        Try
            Dim DR As DataRow() = CarTypes.Tables(0).Select("snCartype=" & YoursnCarType & "")
            Return New R2StandardStructure(DR(0).Item("snCarType"), DR(0).Item("StrCarName"))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function LoadCapacitorLoadRegister(YourNSS As TransportCompaniesStandardLoadCapacitorLoadStructure) As Int64
        Try
            Return WS.WebMethodTransportCompanyLoadCapacitorLoadRegister(YourNSS.StrBarName, YourNSS.nCityCode, YourNSS.nBarCode, YourNSS.nCompCode, YourNSS.nTruckType, YourNSS.StrAddress, YourNSS.nCarNumKol, YourNSS.StrPriceSug, YourNSS.StrDescription)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Sub LoadCapacitorLoadEdit(YourNSS As TransportCompaniesStandardLoadCapacitorLoadStructure)
        Try
            WS.WebMethodTransportCompanyLoadCapacitorLoadEdit(YourNSS.nEstelamId, YourNSS.StrBarName, YourNSS.nCityCode, YourNSS.nBarCode, YourNSS.nCompCode, YourNSS.nTruckType, YourNSS.StrAddress, YourNSS.nCarNumKol, YourNSS.StrPriceSug, YourNSS.StrDescription)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub LoadCapacitorLoadDelete(YournEstelamId As Int64)
        Try
            WS.WebMethodTransportCompanyLoadCapacitorLoadDelete(YournEstelamId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Function GetTransportCompanyLoadCapacitorLoads() As List(Of TransportCompaniesStandardLoadCapacitorLoadStructure)
        Try
            Dim DS As DataSet = WS.WebMethodTransportCompanyLoadCapacitorLoads(GetCompanyCode())
            Dim Lst As List(Of TransportCompaniesStandardLoadCapacitorLoadStructure) = New List(Of TransportCompaniesStandardLoadCapacitorLoadStructure)
            For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                Lst.Add(New TransportCompaniesStandardLoadCapacitorLoadStructure(DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("StrBarName"), DS.Tables(0).Rows(Loopx).Item("nCityCode"), DS.Tables(0).Rows(Loopx).Item("nBarCode"), GetCompanyCode(), DS.Tables(0).Rows(Loopx).Item("nTruckType"), DS.Tables(0).Rows(Loopx).Item("StrAddress"), DS.Tables(0).Rows(Loopx).Item("nCarNumKol"), DS.Tables(0).Rows(Loopx).Item("StrPriceSug"), DS.Tables(0).Rows(Loopx).Item("StrDescription"), DS.Tables(0).Rows(Loopx).Item("dDateElam"), DS.Tables(0).Rows(Loopx).Item("dTimeElam"), DS.Tables(0).Rows(Loopx).Item("nCarNum")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetTransportCompanyLoadCapacitorSedimentedLoads() As List(Of TransportCompaniesStandardLoadCapacitorLoadStructure)
        Try
            Dim DS As DataSet = WS.WebMethodTransportCompanyLoadCapacitorSedimentedLoads(GetCompanyCode())
            Dim Lst As List(Of TransportCompaniesStandardLoadCapacitorLoadStructure) = New List(Of TransportCompaniesStandardLoadCapacitorLoadStructure)
            For Loopx As Int64 = 0 To DS.Tables(0).Rows.Count - 1
                Lst.Add(New TransportCompaniesStandardLoadCapacitorLoadStructure(DS.Tables(0).Rows(Loopx).Item("nEstelamId"), DS.Tables(0).Rows(Loopx).Item("StrBarName"), DS.Tables(0).Rows(Loopx).Item("nCityCode"), DS.Tables(0).Rows(Loopx).Item("nBarCode"), GetCompanyCode(), DS.Tables(0).Rows(Loopx).Item("nTruckType"), DS.Tables(0).Rows(Loopx).Item("StrAddress"), DS.Tables(0).Rows(Loopx).Item("nCarNumKol"), DS.Tables(0).Rows(Loopx).Item("StrPriceSug"), DS.Tables(0).Rows(Loopx).Item("StrDescription"), DS.Tables(0).Rows(Loopx).Item("dDateElam"), DS.Tables(0).Rows(Loopx).Item("dTimeElam"), DS.Tables(0).Rows(Loopx).Item("nCarNum")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetCompanyCode() As Int64
        Try
            Return R2CoreWinFormRemoteApplicationsMClassConfigurationManagement.GetAppConfigValue("CompanyCode", "CompanyCode")
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function ExistLoadId(YourLoadId As Int64) As Boolean
        Try
            Dim DR As DataRow() = Nothing
            DR = Loads.Tables(0).Select("StrGoodCode=" & YourLoadId & "")
            If DR Is Nothing Then Return False Else Return True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function ExistCityId(YourCityId As Int64) As Boolean
        Try
            Dim DR As DataRow() = Nothing
            DR = Cities.Tables(0).Select("nCityCode=" & YourCityId & "")
            If DR Is Nothing Then Return False Else Return True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function ExistCarTypeId(YoursnCarType As Int64) As Boolean
        Try
            Dim DR As DataRow() = Nothing
            DR = CarTypes.Tables(0).Select("snCarType=" & YoursnCarType & "")
            If DR Is Nothing Then Return False Else Return True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Sub GetNSSCarTruckBySmartCardNoRMTO(YourSmartCardNo As String, ByRef Pelak As String, ByRef Serial As String)
        Try
            WS.WebMethodGetNSSCarTruckBySmartCarNofromRmto(YourSmartCardNo, Pelak, Serial)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub GetNSSCarTruckBySmartCardNoLocalDataBase(YourSmartCardNo As String, ByRef Pelak As String, ByRef Serial As String)
        Try
            WS.WebMethodGetNSSCarTruckBySmartCarNofromLocalDataBase(YourSmartCardNo, Pelak, Serial)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub GetNSSDriverTruckBySmartCardNoRMTO(YourSmartCardNo As String, ByRef PersonFullName As String, ByRef NationalCode As String, ByRef DrivingLicenceNo As String)
        Try
            WS.WebMethodGetNSSDriverTruckBySmartCarNofromRmto(YourSmartCardNo, PersonFullName, NationalCode, DrivingLicenceNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub GetNSSDriverTruckBySmartCardNoLocalDataBase(YourSmartCardNo As String, ByRef PersonFullName As String, ByRef NationalCode As String, ByRef DrivingLicenceNo As String)
        Try
            WS.WebMethodGetNSSDriverTruckBySmartCarNofromLocalDataBase(YourSmartCardNo, PersonFullName, NationalCode, DrivingLicenceNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub AllocateSedimentLoadMessegeSend(YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String)
        Try
            WS.WebMethodTransportCompanyLoadCapacitorSedimentLoadAllocationMessageProduce(GetCompanyCode(), YournEstelamId, YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Function AllocateSedimentLoadAndPermission(YournEstelamId As Int64, YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String) As Int64
        Try
            Dim TurnId As Int64 = WS.WebMethodTransportCompanyLoadCapacitorSedimentLoadAllocationAndPermisiion(GetCompanyCode(), YournEstelamId, YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo)
            Dim PPDS As PermissionPrinting.PermissionPrintingDataStructure = New PermissionPrinting.PermissionPrintingDataStructure()
            WS.WebMethodTransportCompanyGetLoadCapacitorSedimentLoadPermisiionPrintingInf(YournEstelamId, TurnId, PPDS.StrExitDate, PPDS.StrExitTime, Nothing, Nothing, PPDS.CompanyName, PPDS.CarTruckLoaderTypeName, PPDS.pelak, PPDS.Serial, PPDS.DriverTruckFullNameFamily, PPDS.DriverTruckDrivingLicenseNo, PPDS.ProductName, PPDS.TargetCityName, PPDS.StrPriceSug, PPDS.StrDescription, PPDS.PermissionUserName, PPDS.OtherNote)
            PPDS.TurnId = TurnId
            PPDS.NEstelamId = YournEstelamId
            PermissionPrinting.PrintPermission(PPDS)
            PermissionPrinting.PrintPermission(PPDS)
            Return TurnId
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Sub RepeatePermissionPrint(YournEstelamId As Int64, YourTurnId As Int64)
        Try
            Dim PPDS As PermissionPrinting.PermissionPrintingDataStructure = New PermissionPrinting.PermissionPrintingDataStructure()
            WS.WebMethodTransportCompanyGetLoadCapacitorSedimentLoadPermisiionPrintingInf(YournEstelamId, YourTurnId, PPDS.StrExitDate, PPDS.StrExitTime, Nothing, Nothing, PPDS.CompanyName, PPDS.CarTruckLoaderTypeName, PPDS.pelak, PPDS.Serial, PPDS.DriverTruckFullNameFamily, PPDS.DriverTruckDrivingLicenseNo, PPDS.ProductName, PPDS.TargetCityName, PPDS.StrPriceSug, PPDS.StrDescription, PPDS.PermissionUserName, PPDS.OtherNote)
            PPDS.TurnId = YourTurnId
            PPDS.NEstelamId = YournEstelamId
            PermissionPrinting.PrintPermission(PPDS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Sub CreateCarTruckRelationDriverTruck(YourCarTruckSmartCardNo As String, YourDriverTruckSmartCardNo As String)
        Try
            WS.WebMethodCreateRelationBetweenCarTruckAndDriverTruck(YourCarTruckSmartCardNo, YourDriverTruckSmartCardNo)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shared Function GetAllPermissionEnterExits(YournEstelamId As Int64) As List(Of TransportCompanyStandardPermissionStructure)
        Try
            Dim AllPermissionEnterExits As DataSet = WS.WebMethodGetAllPermissionEnterExits(YournEstelamId)
            Dim Lst As List(Of TransportCompanyStandardPermissionStructure) = New List(Of TransportCompanyStandardPermissionStructure)
            For Loopx As Int64 = 0 To AllPermissionEnterExits.Tables(0).Rows.Count - 1
                Lst.Add(New TransportCompanyStandardPermissionStructure(AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strCarNo"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strCarSerialNo"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strCarName"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strPersonFullName"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strDrivingLicenceNo"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strNationalCode"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strSmartcardNo"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strExitDate"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strExitTime"), IIf(AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("strbarnameno").Equals(System.DBNull.Value), "", 1), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("AddressMobile"), AllPermissionEnterExits.Tables(0).Rows(Loopx).Item("OtherNote")))
            Next
            Return Lst
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetTransportCompanyMoneyWalletInventory() As Int64
        Try
            Return WS.WebMethodTransportCompanyGetMoneyWalletInventory(GetCompanyCode())
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetTransportCompaniesDailyMessage(ByRef YourDailyMessageColorHolder As String) As String
        Try
            Return WS.WebMethodGetTransportCompaniesDailyMessage(YourDailyMessageColorHolder)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Shared Function GetTransportCompaniesFirstPageMessages() As String
        Try
            Return WS.WebMethodGetTransportCompaniesFirstPageMessages()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function


End Class

Public Class TransportCompanyStandardPermissionStructure

#Region "Constructing Management"

    Public Sub New()
        MyBase.New()
        _strCarNo = String.Empty
        _strCarSerialNo = String.Empty
        _strCarName = String.Empty
        _strPersonFullName = String.Empty
        _strDrivingLicenceNo = String.Empty
        _strNationalCode = String.Empty
        _strSmartcardNo = String.Empty
        _strExitDate = String.Empty
        _strExitTime = String.Empty
        _strBarnameNo = String.Empty
        _AddressMobile = String.Empty
        _OtherNote = String.Empty
    End Sub

    Public Sub New(ByVal YourstrCarNo As String, YourstrCarSerialNo As String, YourstrCarName As String, YourstrPersonFullName As String, YourstrDrivingLicenceNo As String, YourstrNationalCode As String, YourstrSmartcardNo As String, YourstrExitDate As String, YourstrExitTime As String, YourstrBarnameNo As String, YourAddressMobile As String, YourOtherNote As String)
        _strCarNo = YourstrCarNo
        _strCarSerialNo = YourstrCarSerialNo
        _strCarName = YourstrCarName
        _strPersonFullName = YourstrPersonFullName
        _strDrivingLicenceNo = YourstrDrivingLicenceNo
        _strNationalCode = YourstrNationalCode
        _strSmartcardNo = YourstrSmartcardNo
        _strExitDate = YourstrExitDate
        _strExitTime = YourstrExitTime
        _strBarnameNo = YourstrBarnameNo
        _AddressMobile = YourAddressMobile
        _OtherNote = YourOtherNote
    End Sub

#End Region

#Region "Properting Management"

    Public Property strCarNo As String
    Public Property strCarSerialNo As String
    Public Property strCarName As String
    Public Property strPersonFullName As String
    Public Property strDrivingLicenceNo As String
    Public Property strNationalCode As String
    Public Property strSmartcardNo As String
    Public Property strExitDate As String
    Public Property strExitTime As String
    Public Property strBarnameNo As String
    Public Property AddressMobile() As String
    Public Property OtherNote As String

#End Region

End Class

Public Class PermissionPrinting

    Private Shared WithEvents _PrintDocumentPermission As PrintDocument = New PrintDocument()
    Private Shared _PPDS As PermissionPrintingDataStructure
    Private Shared _FrmMessageDialog As FrmcMessageDialog

    Public Structure PermissionPrintingDataStructure
        Dim TurnId As Int64
        Dim NEstelamId As Int64
        Dim StrExitDate As String
        Dim StrExitTime As String
        Dim CompanyName As String
        Dim CarTruckLoaderTypeName As String
        Dim pelak As String
        Dim Serial As String
        Dim DriverTruckFullNameFamily As String
        Dim DriverTruckDrivingLicenseNo As String
        Dim ProductName As String
        Dim TargetCityName As String
        Dim StrPriceSug As String
        Dim StrDescription As String
        Dim PermissionUserName As String
        Dim OtherNote As String
    End Structure

    Public Shared Sub PrintPermission(YourPPDS As PermissionPrintingDataStructure)
        Try
            _PPDS = YourPPDS
            'چاپ مجوز
            _PrintDocumentPermission.Print()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Shared Sub _PrintDocumentPermission_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.BeginPrint
    End Sub

    Private Shared Sub _PrintDocumentPermission_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _PrintDocumentPermission.EndPrint
    End Sub

    Private Shared Sub _PrintDocumentPermission_PrintPage_Printing(ByVal X As Int16, ByVal Y As Int16, ByVal E As System.Drawing.Printing.PrintPageEventArgs)
        Try
            Dim myPaperSizeHalf As Integer = _PrintDocumentPermission.PrinterSettings.DefaultPageSettings.PaperSize.Width / 4
            Dim myStrFontSuperMax As Font = New System.Drawing.Font("Badr", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim myStrFontMax As Font = New System.Drawing.Font("Badr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim myStrFontMin As Font = New System.Drawing.Font("Badr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Dim myDigFont As Font = New System.Drawing.Font("Alborz Titr", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
            E.Graphics.DrawString(_PPDS.StrExitDate + " تاريخ صدور ", myStrFontMax, Brushes.DarkBlue, X + 30, Y)
            E.Graphics.DrawString(_PPDS.NEstelamId.ToString() + " شماره مجوز ", myStrFontMax, Brushes.DarkBlue, X + 520, Y)
            E.Graphics.DrawString(_PPDS.StrExitTime + " ساعت صدور ", myStrFontMax, Brushes.DarkBlue, X + 30, Y + 30)
            E.Graphics.DrawString(_PPDS.TurnId.ToString() + " شماره نوبت ", myStrFontMax, Brushes.DarkBlue, X + 520, Y + 30)
            E.Graphics.DrawString("شرکت/موسسه محترم " + _PPDS.CompanyName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 130)
            E.Graphics.DrawString(_PPDS.Serial + "-", myStrFontMax, Brushes.DarkBlue, X + 120, Y + 170)
            Dim a As Char() = _PPDS.pelak.Trim.ToCharArray()
            E.Graphics.DrawString(a(4), myStrFontMax, Brushes.DarkBlue, X + 150, Y + 170)
            E.Graphics.DrawString(a(5), myStrFontMax, Brushes.DarkBlue, X + 160, Y + 170)
            E.Graphics.DrawString(a(3), myStrFontMax, Brushes.DarkBlue, X + 170, Y + 170)
            E.Graphics.DrawString(a(0), myStrFontMax, Brushes.DarkBlue, X + 180, Y + 170)
            E.Graphics.DrawString(a(1), myStrFontMax, Brushes.DarkBlue, X + 190, Y + 170)
            E.Graphics.DrawString(a(2) + " به شماره پلاک ", myStrFontMax, Brushes.DarkBlue, X + 200, Y + 170)
            E.Graphics.DrawString(" بدين وسيله يک دستگاه " + _PPDS.CarTruckLoaderTypeName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 170)
            E.Graphics.DrawString(_PPDS.DriverTruckDrivingLicenseNo + " دارای گواهينامه به شماره ", myStrFontMax, Brushes.DarkBlue, X + 50, Y + 210)
            E.Graphics.DrawString(" به رانندگی آقای " + _PPDS.DriverTruckFullNameFamily, myStrFontMax, Brushes.DarkBlue, X + 350, Y + 210)
            E.Graphics.DrawString(" جهت حمل " + _PPDS.ProductName, myStrFontMax, Brushes.DarkBlue, X + 450, Y + 240)
            E.Graphics.DrawString(" از ", myStrFontMax, Brushes.DarkBlue, X + 300, Y + 240)
            E.Graphics.DrawString(" به مقصد " + _PPDS.TargetCityName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 240)
            E.Graphics.DrawString(_PPDS.StrPriceSug + " با نرخ ", myStrFontMax, Brushes.DarkBlue, X + 550, Y + 270)
            E.Graphics.DrawString(" ريال با مسئوليت آن شرکت/موسسه معرفی می گردد ", myStrFontMax, Brushes.DarkBlue, X + 100, Y + 270)
            E.Graphics.DrawString(_PPDS.StrDescription, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 290)
            E.Graphics.DrawString("توجه", myStrFontMax, Brushes.DarkBlue, X + 650, Y + 310)
            E.Graphics.DrawString(" مجوز فوق پس از صدور تعويض نخواهد شد - دريافت نوبت بعدی از پايانه به شرط انجام سفر امکان پذير است", myStrFontMax, Brushes.DarkBlue, X + 30, Y + 340)
            E.Graphics.DrawString("نام کاربر : " + _PPDS.PermissionUserName, myStrFontMax, Brushes.DarkBlue, X + 100, Y + 360)
            E.Graphics.DrawString(_PPDS.OtherNote, myStrFontMax, Brushes.DarkBlue, X + 300, Y + 360)
            E.Graphics.DrawString(" پايانه اميرکبير اصفهان ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y)
            E.Graphics.DrawString("سيستم هوشمند صدور مجوز بارگيری ", myStrFontSuperMax, Brushes.DarkBlue, X + 180, Y + 50)
            E.Graphics.DrawString(" ((مجوز بارگيری)) ", myStrFontSuperMax, Brushes.DarkBlue, X + 250, Y + 100)

            E.Graphics.DrawRectangle(New Pen(Brushes.Black, 5), X, Y, 700, 400)

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Shared Sub _PrintDocumentPermission_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _PrintDocumentPermission.PrintPage
        Try
            _PrintDocumentPermission_PrintPage_Printing(50, 80, e)
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Nothing, False)
        End Try
    End Sub

End Class



