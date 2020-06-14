
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCCarEnterExitStatus
    Inherits UCGeneral


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabelCarEnterExitStatus.UCRefreshGeneral()
    End Sub

    Public Sub UCViewStatus(YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            UCRefresh()
            Dim EEId As Long
            If R2CoreParkingSystem.EnterExitManagement.R2CoreParkingSystemMClassEnterExitManagement.GetEnterExitRequestType(YourNSSTerafficCard, EEId) = R2EnterExitRequestType.EnterRequest Then
                UcLabelCarEnterExitStatus.UCValue = "خودرو در پایانه نیست"
            Else
                UcLabelCarEnterExitStatus.UCValue = "خودرو در پایانه است "
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

End Class
