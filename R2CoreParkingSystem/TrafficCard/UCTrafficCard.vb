
Imports System.Reflection

Imports R2Core.RFIDCardsManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCTrafficCard
    Inherits UCGeneral


    public Event UCViewTrafficCardCompeleted(NSSRFIdCard As R2CoreParkingSystemStandardTrafficCardStructure)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public sub New

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCShowTrafficCard(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UcrfidCard.UCShowRFIDCard(YourTrafficCard.CardNo)
            LblCardTypeName.Text = R2CoreParkingSystemMClassTrafficCardManagement.GetTrafficCardTempTypeName(YourTrafficCard.CardNo) + " " + R2CoreParkingSystemMClassTrafficCardManagement.GetTrafficCardTypeName(YourTrafficCard.CardNo)
            RaiseEvent UCViewTrafficCardCompeleted(YourTrafficCard)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public  sub UCRefresh
        UcrfidCard.UCRefresh()
        LblCardTypeName.Text=""
    End sub

    Public Function UCGetNSS() As R2CoreParkingSystemStandardTrafficCardStructure
        Try
            Dim myNSS As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(UcrfidCard.UCGetNSS().CardNo)
            Return myNSS
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcrfidCard_UCViewRFIDCardCompeleted(NSS As R2Core.RFIDCardsManagement.R2CoreStandardRFIDCardStructure) Handles UcrfidCard.UCViewRFIDCardCompeleted
        RaiseEvent UCViewTrafficCardCompeleted(R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(NSS.CardNo))
    End Sub

    Private Sub UcrfidCard_UCRFIDCardReadedEvent(NSSRFIdCard As R2CoreStandardRFIDCardStructure) Handles UcrfidCard.UCRFIDCardReadedEvent

    End Sub

    Private Sub UcrfidCard_UCRFIDCardReaderStartToReadEvent() Handles UcrfidCard.UCRFIDCardReaderStartToReadEvent

    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
