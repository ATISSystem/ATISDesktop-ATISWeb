

Imports System.Reflection


Public Class UCMonetarySettingToolInstrumentCollection
    Inherits UCGeneral

    Public Event UCAmountChanged(Amount As Int64)

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
        End Try
    End Sub

    Public Sub UCPrepare(YourConfigurationIndex As Int64, YourAmount As Int64)
        Try
            UcucMonetarySettingToolCollection.UCPrepare(YourConfigurationIndex)
            UcButtonSpecial.UCEnable = True
            UcAmount.UCValue = YourAmount
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private WithEvents _Instrument As UCMonetarySettingToolInstrument = Nothing
    Sub UcucMonetarySettingToolCollection_UCCurrentNSSChangedEvent() Handles UcucMonetarySettingToolCollection.UCCurrentNSSChangedEvent
        Try
            PnlMonetarySettingToolInstrumentHolder.Controls.Clear()
            _Instrument = R2Core.MonetarySettingTools.R2CoreMonetarySettingToolsManagement.GetMonetarySettingToolInstrumentInstance(UcucMonetarySettingToolCollection.UCCurrentNSS)
            _Instrument.Dock = DockStyle.Fill
            AddHandler _Instrument.UCAmountChangedEvent, AddressOf _Instrument_UCAmountChangedEvent
            PnlMonetarySettingToolInstrumentHolder.Controls.Add(_Instrument)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub _Instrument_UCAmountChangedEvent(Amount As Int64)
        Try
            UcAmount.UCValue = Amount
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSpecial_UCClickedEvent() Handles UcButtonSpecial.UCClickedEvent
        Try
            UcButtonSpecial.UCEnable = False
            If UcAmount.UCValueMoney > 0 Then RaiseEvent UCAmountChanged(UcAmount.UCValueMoney)
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
