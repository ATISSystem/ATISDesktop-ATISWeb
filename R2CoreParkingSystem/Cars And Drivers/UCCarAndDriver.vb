
Imports System.Reflection
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.City

Public Class UCCarAndDriver
    Inherits UCGeneral

    Protected Event UCCarWasSetEvent(nIdCar As Int64)
    Public Event UCCarNotExistEvent


#Region "General Properties"

    Private _nIdCar As Int64 = 0
    Private _NSSCar As R2StandardCarStructure = Nothing
    Public ReadOnly Property UCGetnIdCar() As Int64
        Get
            Return _nIdCar
        End Get
    End Property

    Private WriteOnly Property UCnIdCar As Int64
        Set(value As Int64)
            _nIdCar = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCSetCar(YournIdCar As Int64)
        Try
            _NSSCar = R2CoreParkingSystemMClassCars.GetNSSCar(YournIdCar)
            UCnIdCar = YournIdCar
            RaiseEvent UCCarWasSetEvent(UCGetnIdCar)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public sub UCSetCar(YourLP As R2StandardLicensePlateStructure)
        Try
            UCSetCar(R2CoreParkingSystemMClassCars.GetnIdCar(YourLP))
        Catch exx As GetDataException
            RaiseEvent UCCarNotExistEvent()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End sub

    Public Function UCGetLPString() As String
        Try
            If Object.Equals(_NSSCar, Nothing) Then
                Throw New CarNotExistException
            Else
                Return _NSSCar.GetCarPelakSerialComposit()
            End If
        Catch exx As CarNotExistException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Public Function UCGetLP() As R2StandardLicensePlateStructure
        Try
            If Object.Equals(_NSSCar, Nothing) Then
                Throw New CarNotExistException
            Else
                Return New R2StandardLicensePlateStructure(_NSSCar.StrCarNo, _NSSCar.StrCarSerialNo, R2CoreParkingSystemMClassCitys.GetCityNameFromnCityCode(_NSSCar.nIdCity), _NSSCar.snCarType)
            End If
        Catch exx As CarNotExistException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function




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
