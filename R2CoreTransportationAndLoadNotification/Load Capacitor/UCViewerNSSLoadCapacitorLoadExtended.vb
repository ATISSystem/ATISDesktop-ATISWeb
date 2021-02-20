
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core.SoftwareUserManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadAllocation
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad
Imports R2CoreTransportationAndLoadNotification.LoadSources

Public Class UCViewerNSSLoadCapacitorLoadExtended
    Inherits UCLoadCapacitorLoad

    Public Event UCClickedEvent(UC As UCLoadCapacitorLoad)



    Private Const _MaxHight As Int64 = 407
    Private Const _MinHight As Int64 = 83

#Region "General Properties"



#End Region

#Region "Subroutins And Functions"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overloads Sub UCRefreshGeneral()
        Try
            MyBase.UCRefreshGeneral()
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefresh()
        Try
            LabelnEstelamId.Text = String.Empty
            LabelTransportCompanyTitle.Text = String.Empty
            LabelGoodTitle.Text = String.Empty
            LabelLoadTargetTitle.Text = String.Empty
            LabelnCarNumKol.Text = String.Empty
            LabelTransportPrice.Text = String.Empty
            LabelLoaderTypeTitle.Text = String.Empty
            LabelnCarNum.Text = String.Empty
            LabelStrDescription.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCRefreshExtended()
        Try
            LabelLoadStatusTitle.Text = String.Empty
            LabelDateTimeComposite.Text = String.Empty
            LabelLoadSourceTitle.Text = String.Empty
            LabelStrBarName.Text = String.Empty
            LabelStrAddress.Text = String.Empty
            LabelLoadAllocationNotOK.Text = String.Empty
            LabelUserName.Text = String.Empty
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub OrderingOptionLabels_Click(sender As Object, e As EventArgs) Handles OrderingOptionAddress.Click, OrderingOptionLoadStatus.Click, OrderingOptionLoaderType.Click, OrderingOptionProduct.Click, OrderingOptionProductReciever.Click, OrderingOptionTargetCity.Click, OrderingOptionTransportCompany.Click, OrderingOptionTransportPrice.Click, OrderingOptionUser.Click, OrderingOptiondTimeElam.Click, OrderingOptionnCarNumKol.Click, OrderingOptionnEstelamId.Click
        Try
            If sender Is OrderingOptionnEstelamId Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nEstelamId)
            ElseIf sender Is OrderingOptionTransportCompany Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TransportCompany)
            ElseIf sender Is OrderingOptionProduct Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.Product)
            ElseIf sender Is OrderingOptionTargetCity Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TargetCity)
            ElseIf sender Is OrderingOptionnCarNumKol Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.nCarNumKol)
            ElseIf sender Is OrderingOptionTransportPrice Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TransportPrice)
            ElseIf sender Is OrderingOptionLoaderType Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.LoaderType)
            ElseIf sender Is OrderingOptionLoadStatus Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.LoadStatus)
            ElseIf sender Is OrderingOptiondTimeElam Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.TimeElam)
            ElseIf sender Is OrderingOptionProductReciever Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.ProductReciever)
            ElseIf sender Is OrderingOptionAddress Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.Address)
            ElseIf sender Is OrderingOptionUser Then
                UCOrderingOptionChangedApply(R2CoreTransportationAndLoadNotificationLoadCapacitorLoadOrderingOptions.User)
            End If
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub Labels_Click(sender As Object, e As EventArgs) Handles LabelnEstelamId.Click, LabelTransportCompanyTitle.Click, LabelGoodTitle.Click, LabelLoadTargetTitle.Click, LabelnCarNumKol.Click, LabelTransportPrice.Click, LabelLoaderTypeTitle.Click, LabelnCarNum.Click, LabelStrDescription.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMaximizeRequestedEvent() Handles UcMinimizeMaximize.UCMaximizeRequestedEvent
        Try
            UCRefreshExtended()
            LabelLoadStatusTitle.Text = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetNSSLoadCapacitorLoadStatus(UCNSSCurrent.LoadStatus).LoadStatusName
            LabelDateTimeComposite.Text = UCNSSCurrent.dTimeElam + " - " + UCNSSCurrent.dDateElam
            LabelLoadSourceTitle.Text = R2CoreTransportationAndLoadNotificationMclassLoadSourcesManagement.GetNSSLoadSource(UCNSSCurrent.nBarSource).NSSCity.StrCityName
            LabelStrBarName.Text = UCNSSCurrent.StrBarName
            LabelStrAddress.Text = UCNSSCurrent.StrAddress
            LabelLoadAllocationNotOK.Text = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.GetTotalNumberOfLoadAllocationWhichBlindfold(UCNSSCurrent.nEstelamId)
            LabelUserName.Text = R2CoreMClassSoftwareUsersManagement.GetNSSUser(UCNSSCurrent.nUserId).UserName
            Dim UCAccounting As UCUCLoadCapacitorAccountingCollection = New UCUCLoadCapacitorAccountingCollection
            UCAccounting.UCViewAccounting(UCNSSCurrent.nEstelamId)
            UCAccounting.Dock = DockStyle.Fill
            UCAccounting.UCViewUCPictureExit = False
            PnlAccounting.Controls.Add(UCAccounting)
            Me.Size = New Size(Me.Width, _MaxHight)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UcMinimizeMaximize_UCMinimizeRequestedEvent() Handles UcMinimizeMaximize.UCMinimizeRequestedEvent
        Try
            Me.Size = New Size(Me.Width, _MinHight)
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewerNSSLoadCapacitorLoadExtended_UCViewNSSRequested() Handles Me.UCViewNSSRequested
        Try
            Dim NSS As R2CoreTransportationAndLoadNotificationStandardLoadCapacitorLoadExtendedStructure = UCNSSCurrent
            LabelnEstelamId.Text = NSS.nEstelamId
            LabelTransportCompanyTitle.Text = NSS.TransportCompanyTitle
            LabelGoodTitle.Text = NSS.GoodTitle
            LabelLoadTargetTitle.Text = NSS.LoadTargetTitle
            LabelnCarNumKol.Text = NSS.nCarNumKol
            LabelTransportPrice.Text = NSS.StrPriceSug
            LabelLoaderTypeTitle.Text = NSS.LoaderTypeTitle
            LabelnCarNum.Text = NSS.nCarNum
            LabelStrDescription.Text = NSS.StrDescription
        Catch ex As Exception
            MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub





#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region



End Class
