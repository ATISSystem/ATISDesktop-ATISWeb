
Imports System.Drawing
Imports System.Reflection

Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorAccounting

Public Class UCLoadCapacitorLoadAccounting
    Inherits UCGeneral


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefreshGeneral()
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            UcLabelAccountTitle.UCRefreshGeneral()
            UcLabelDateTimeComposite.UCRefreshGeneral()
            UcLabelAmount.UCRefreshGeneral()
            UcLabelUserName.UCRefreshGeneral()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewNSS(YourNSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingStructure)
        Try
            Dim NSSAccountingType As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorAccountingTypeStructure = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorAccountingManagement.GetNSSLoadCapacitorLoadAccountingType(YourNSS.AccountType)
            UcLabelAccountTitle.UCValue = NSSAccountingType.ATitle
            UcLabelDateTimeComposite.UCValue = YourNSS.DateShamsi + " - " + YourNSS.Time
            UcLabelAmount.UCValue = YourNSS.Amount
            UcLabelUserName.UCValue = R2CoreMClassLoginManagement.GetNSSUser(YourNSS.UserId).UserName
            PnlMain.BackColor = Color.FromName(NSSAccountingType.Color)
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
