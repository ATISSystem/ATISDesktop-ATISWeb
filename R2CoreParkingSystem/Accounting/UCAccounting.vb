
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.PublicProc
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.AccountingManagement
Imports R2Core.ComputersManagement

Public Class UCAccounting
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCAccounting)






#Region "General Properties"

    <Browsable(False)>
    Public Property UCCurrentNSS As R2StandardEnterExitAccountingStructure = Nothing

#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        LblProcessName.Text = ""
        LblDateShamsi.Text = ""
        LblTime.Text = ""
        LblCurrentCharge.Text = ""
        LblMblgh.Text = ""
        LblReminderCharge.Text = ""
        LblMaabarName.Text = ""
        LblUserName.Text = ""
    End Sub

    ''Public Sub New(ByVal YourEEAccountingStructure As R2StandardEnterExitAccountingStructure)
    ''    MyBase.New()
    ''    InitializeComponent()
    ''    Try
    ''        UCCurrentNSS = YourEEAccountingStructure
    ''        UCRefresh()
    ''        PnlMain.BackColor = Color.FromName(R2CoreParkingSystemMClassAccountingManagement.GetAccountingColorbyAccountingCode(YourEEAccountingStructure.EEAccountingProcessType))
    ''        UcLabelProcessName.UCValue = R2CoreParkingSystemMClassAccountingManagement.GetAccountingNamebyAccountingCode(YourEEAccountingStructure.EEAccountingProcessType)
    ''        UcLabelDateShamsi.UCValue = YourEEAccountingStructure.DateShamsiA
    ''        UcLabelTime.UCValue = YourEEAccountingStructure.TimeA
    ''        UcLabelCurrentCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.CurrentChargeA)
    ''        UcLabelMblgh.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.MblghA)
    ''        UcLabelReminderCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.ReminderChargeA)
    ''        UcLabelMaabarName.UCValue = R2CoreMClassComputersManagement.GetNSSComputer(YourEEAccountingStructure.MaabarCode).MName
    ''        UcLabelUserName.UCValue = R2Core.UserManagement.R2CoreMClassLoginManagement.GetNSSUser(YourEEAccountingStructure.UserIdA).UserName
    ''    Catch ex As Exception
    ''        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
    ''    End Try
    ''End Sub

    Public Sub New(ByVal YourEEAccountingStructure As R2StandardEnterExitAccountingExtendedStructure)
        MyBase.New()
        InitializeComponent()
        Try
            UCCurrentNSS = YourEEAccountingStructure
            UCRefresh()
            PnlMain.BackColor = Color.FromName(YourEEAccountingStructure.ColorName)
            ''UcLabelProcessName.UCValue = YourEEAccountingStructure.AccountName
            ''UcLabelDateShamsi.UCValue = YourEEAccountingStructure.DateShamsiA
            ''UcLabelTime.UCValue = YourEEAccountingStructure.TimeA
            ''UcLabelCurrentCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.CurrentChargeA)
            ''UcLabelMblgh.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.MblghA)
            ''UcLabelReminderCharge.UCValue = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.ReminderChargeA)
            ''UcLabelMaabarName.UCValue = YourEEAccountingStructure.ComputerName
            ''UcLabelUserName.UCValue = YourEEAccountingStructure.UserName

            LblProcessName.Text = YourEEAccountingStructure.AccountName
            LblDateShamsi.Text = YourEEAccountingStructure.DateShamsiA
            LblTime.Text = YourEEAccountingStructure.TimeA
            LblCurrentCharge.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.CurrentChargeA)
            LblMblgh.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.MblghA)
            LblReminderCharge.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourEEAccountingStructure.ReminderChargeA)
            LblMaabarName.Text = YourEEAccountingStructure.ComputerName
            LblUserName.Text = YourEEAccountingStructure.UserName

        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region

#Region "Events"

#End Region

#Region "Event Handlers"

    Private Sub Labels_ClickHandler(sender As Object, e As EventArgs) Handles LblCurrentCharge.Click, LblDateShamsi.Click, LblMaabarName.Click, LblMblgh.Click, LblProcessName.Click, LblReminderCharge.Click, LblTime.Click, LblUserName.Click
        Try
            RaiseEvent UCClickedEvent(Me)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
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
