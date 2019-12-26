
Imports System.Reflection

Imports R2CoreWinFormRemoteApplications

Public Class UCPermissionViewer
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

    Public Sub UCViewNSS(YourPermissionEnterExit As TransportCompanyStandardPermissionStructure)
        Try
            UcLabelCarTruckLpString.UCValue = YourPermissionEnterExit.strCarNo.Trim + " - " + YourPermissionEnterExit.strCarSerialNo.Trim + vbCrLf + YourPermissionEnterExit.strCarName
           UcPersianTextBoxStrDriverName.UCValue = YourPermissionEnterExit.strPersonFullName.Trim
            UcLabelStrDrivingLicenseNo.UCValue = YourPermissionEnterExit.strDrivingLicenceNo.Trim
            UcLabelStrNationalCode.UCValue = YourPermissionEnterExit.strNationalCode.Trim
            UcLabelStrSmartCardNo.UCValue = YourPermissionEnterExit.strSmartcardNo.Trim
            UcLabelStrExitDateTime.UCValue = YourPermissionEnterExit.strExitDate.Trim + vbCrLf + YourPermissionEnterExit.strExitTime.Trim
            UcLabelLocation.UCValue = IIf(YourPermissionEnterExit.strBarnameNo.Trim = String.Empty, "سالن اعلام بار", "شرکت حمل ونقل")
            UcLabelStrAddress.UCValue = YourPermissionEnterExit.AddressMobile.Trim
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message )
        End Try
    End Sub

    Public Sub UCRefresh()
        UcLabelCarTruckLpString.UCRefresh()
        UcPersianTextBoxStrDriverName.UCRefresh()
        UcLabelStrDrivingLicenseNo.UCRefresh()
        UcLabelStrNationalCode.UCRefresh()
        UcLabelStrSmartCardNo.UCRefresh()
        UcLabelStrExitDateTime.UCRefresh()
        UcLabelLocation.UCRefresh()
        UcLabelStrAddress.UCRefresh()
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
