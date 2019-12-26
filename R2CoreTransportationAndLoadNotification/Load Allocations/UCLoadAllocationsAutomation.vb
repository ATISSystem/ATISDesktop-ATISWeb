
Imports System.Reflection

Imports R2Core.ConfigurationManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.ConfigurationsManagement
Imports R2CoreTransportationAndLoadNotification.LoadAllocation


Public Class UCLoadAllocationsAutomation
    Inherits UCGeneralExtended

    Private WithEvents _AutomationTimer As System.Windows.Forms.Timer


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _AutomationTimer = New System.Windows.Forms.Timer()
            ''_AutomationTimer.Interval = R2CoreMClassConfigurationManagement.GetConfigInt64(, 0)

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"


    Private Sub UcButtonStart_UCClickedEvent() Handles UcButtonStart.UCClickedEvent
        Try
            UcButtonStart.UCEnable = False
            UcButtonStop.UCEnable = True
            _AutomationTimer.Enabled = True
            _AutomationTimer.Start()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonStop_UCClickedEvent() Handles UcButtonStop.UCClickedEvent
        Try
            UcButtonStart.UCEnable = True
            UcButtonStop.UCEnable = False
            _AutomationTimer.Enabled = False
            _AutomationTimer.Stop()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcucLoadAllocationCollection_UCViewCollectionCompeletedEvent() Handles UcucLoadAllocationCollection.UCViewCollectionCompeletedEvent
        Try
            _AutomationTimer.Enabled = True
            _AutomationTimer.Start()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _AutomationTimer_Tick(sender As Object, e As EventArgs) Handles _AutomationTimer.Tick
        Try
            _AutomationTimer.Enabled = False
            _AutomationTimer.Stop()
            Dim ResultList As List(Of R2CoreTransportationAndLoadNotificationStandardLoadAllocationStructure) = R2CoreTransportationAndLoadNotificationMClassLoadAllocationManagement.LoadAllocationsLoadPermissionRegistering()
            UcucLoadAllocationCollection.UCViewCollection(ResultList)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
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
