
Imports System.Reflection
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.Cars


Public Class UCBlackListCompositBlackListViewer
    Inherits UCGeneral

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabel.UCValue = String.Empty
    End Sub

    Private CompositBlackList As String = String.Empty

    Public Sub UCViewInformation(YourNSSCar As R2StandardCarStructure)
        Try
            UCRefresh()
            UcLabel.UCValue = R2CoreParkingSystem.BlackList.R2CoreParkingSystemMClassBlackList.GetCompositBlackList(YourNSSCar)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCForceToVisable()
        Try
            If UcLabel.UCValue.Trim <> String.Empty Then Me.Visible = True
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
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
