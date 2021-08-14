

Imports System.Reflection

Imports R2Core.MonetaryCreditSupplySources
Imports R2Core.MonetarySupply




Public Class UCMonetarySupply
    Inherits UCGeneral


    Public Event UCMonetarySupplySuccessEvent(TransactionId As Int64, Amount As Int64, SupplyReport As String)
    Public Event UCMonetarySupplyUnSuccessEvent(TransactionId As Int64, Amount As Int64, SupplyReport As String)
    Public WithEvents _MonetarySupply As R2CoreMonetarySupply = Nothing



#Region "General Properties"

    ' On All of Location of Code Where UCMonetarySupply Used so ConfigurationIndex must be set to UCConfigurationIndex Property
    ' For Example UCMoneyWalletCharge has ConfigurationIndex Property so send it to UCMonetarySupply
    Private _UCConfigurationIndex As Int64 = 0
    Public Property UCConfigurationIndex() As Int64
        Get
            Return _UCConfigurationIndex
        End Get
        Set(value As Int64)
            Try
                _UCConfigurationIndex = value
                UCInternalPrepare(0)
            Catch ex As Exception
                Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
            End Try
        End Set
    End Property

    Private _UCEnable As Boolean = True
    Public Property UCEnable As Boolean
        Get
            Return _UCEnable
        End Get
        Set(value As Boolean)
            _UCEnable = value
            Me.Enabled = value
        End Set
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Overrides Sub DisposeResources()
    End Sub

    Private Sub UCInternalPrepare(YourAmount As Int64)
        Try
            UcucMonetaryCreditSupplySourceCollection.UCPrepare(UCConfigurationIndex)
            UcMonetarySettingToolInstrumentCollection.UCPrepare(UCConfigurationIndex, YourAmount)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCPrepare(YourAmount As Int64)
        Try
            UCInternalPrepare(YourAmount)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcMonetarySettingToolInstrumentCollection_UCAmountChanged(Amount As Long) Handles UcMonetarySettingToolInstrumentCollection.UCAmountChanged
        Try
            _MonetarySupply = New R2CoreMonetarySupply(UcucMonetaryCreditSupplySourceCollection.UCCurrentNSS, Amount)
            _MonetarySupply.StartSupply()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _MonetarySupply_MonetarySupplySuccessEvent(TransactionId As Long, Amount As Int64, SupplyReport As String) Handles _MonetarySupply.MonetarySupplySuccessEvent
        Try
            RaiseEvent UCMonetarySupplySuccessEvent(TransactionId, Amount, SupplyReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _MonetarySupply_MonetarySupplyUnSuccessEvent(TransactionId As Long, Amount As Int64, SupplyReport As String) Handles _MonetarySupply.MonetarySupplyUnSuccessEvent
        Try
            RaiseEvent UCMonetarySupplyUnSuccessEvent(TransactionId, Amount, SupplyReport)
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
