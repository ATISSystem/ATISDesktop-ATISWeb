
Imports System.ComponentModel
Imports System.Reflection

Imports PayanehClassLibrary.CarTruckNobatManagement
Imports PayanehClassLibrary.CarTrucksManagement
Imports R2CoreGUI

Public Class UCViewerTankTreiler
    Inherits UCGeneral

#Region "General Properties"

    <Browsable(False)>
    Public Property UCNSSCurrentCarTruck() As R2StandardCarTruckStructure = Nothing

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabel.UCRefresh()
    End Sub

    Public Sub UCViewTankTreilerStatus(YourNSS As R2StandardCarTruckStructure)
        Try
            UCNSSCurrentCarTruck = YourNSS
            UCRefresh()
            If PayanehClassLibraryMClassCarTruckNobatManagement.IsCarTruckTankTreiler(YourNSS) Then
                UcLabel.UCValue = "تانکر مخزندار"
            Else
                UcLabel.UCRefresh()
            End If
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
