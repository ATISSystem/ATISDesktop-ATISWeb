
Imports System.Reflection
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCTerafficCardPresenter
    Inherits UCGeneral

    Private _NSS As R2CoreParkingSystemStandardTrafficCardStructure = Nothing


#Region "General Properties"

    Public ReadOnly Property UCGetCardTypeName() As String
        Get
            Dim TypeName As String = R2CoreParkingSystemMClassTrafficCardManagement.GetTerafficCardTypeNameFromTypeCode(_NSS.CardType) + "-" + R2CoreParkingSystemMClassTrafficCardManagement.GetTerafficTempCardTypeNameFromTempTypeCode(_NSS.TempCardType)
            If _NSS.NoMoney = True Then
                Return TypeName + "-" + "رایگان"
            Else
                Return TypeName
            End If
        End Get
    End Property
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub


    Public Sub UCShowTrafficCard(YourTrafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            If YourTrafficCard Is Nothing Then Exit Sub
            UCRefresh()
            _NSS = YourTrafficCard
            UcLabelCardNo.UCValue = YourTrafficCard.CardNo
            UcLabelCardId.UCValue = YourTrafficCard.CardId
            UcLabelCardTypeName.UCValue = UCGetCardTypeName

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        UcLabelCardNo.UCRefreshGeneral()
        UcLabelCardId.UCRefreshGeneral()
        UcLabelCardTypeName.UCRefreshGeneral()
    End Sub

    Public Function UCGetNSS() As R2CoreParkingSystemStandardTrafficCardStructure
        Try
            Return _NSS
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
