
Imports System.Reflection
Imports R2Core.ExceptionManagement
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.Cars
Imports R2CoreParkingSystem.TrafficCardsManagement.ExceptionManagement

Public Class UCCarAndTerafficCard
    Inherits UCCarAndDriverPresenter

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCSetTerafficCard(YourTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            Dim mynIdCar As Int64 = 0
            mynIdCar = R2CoreParkingSystemMClassCars.GetnIdCarFromCardId(YourTerafficCard.CardId)
            UCSetCar(mynIdCar)
        Catch ex As R2CoreParkingSystemRelatedCarNotExistException
            Throw ex
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCCarAndTerafficCard_UCCarNotExistEvent() Handles Me.UCCarNotExistEvent

    End Sub

    Private Sub UCCarAndTerafficCard_UCCarWasSetEvent(nIdCar As Long) Handles Me.UCCarWasSetEvent

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
