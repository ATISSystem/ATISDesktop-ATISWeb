

Imports System.Reflection
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.Exceptions
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad

Public Class UCSpecialLoadSelector
    Inherits UCGeneralExtended

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefreshGeneral()
        UCRefresh()
    End Sub

    Private Sub UCRefresh()
        RBIsSpecialLoad1.Checked = False
        RBIsSpecialLoad2.Checked = False
    End Sub

    Public ReadOnly Property UCIsSpecialLoad As Boolean
        Get
            Try
                If RBIsSpecialLoad1.Checked = False And RBIsSpecialLoad2.Checked = False Then Throw New PleaseSelectSpecialLoadRadioButtonException
                If RBIsSpecialLoad1.Checked Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As PleaseSelectSpecialLoadRadioButtonException
                Throw ex
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + "." + ex.Message) 
            End Try
        End Get
    End Property

    Public Sub UCViewInformation(YourNSSLoad As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadStructure)
        RBIsSpecialLoad1.Checked = YourNSSLoad.IsSpecialLoad
        RBIsSpecialLoad2.Checked = Not YourNSSLoad.IsSpecialLoad
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
