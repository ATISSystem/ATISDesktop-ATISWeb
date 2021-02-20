
Imports System.Reflection

Imports R2Core
Imports R2Core.ConfigurationManagement
Imports R2Core.DatabaseManagement
Imports R2Core.DesktopProcessesManagement
Imports R2CoreGUI

Public Class UCProcessGroup
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCProcessGroup)
    Private _NSS As R2StandardDesktopProcessGroupStructure = Nothing
    Private _MaxHight As Int64 = 0


#Region "General Properties"

    Private _UCMaxMinStatus As R2Core.R2Enums.MaxMin = R2Enums.MaxMin.Min
    Public Property UCMaxMinStatus() As R2Enums.MaxMin
        Get
            Return _UCMaxMinStatus
        End Get
        Set(value As R2Enums.MaxMin)
            _UCMaxMinStatus = value
            If value = R2Enums.MaxMin.Max Then
                Me.Size = New Size(Me.Width, _MaxHight)
            ElseIf value = R2Enums.MaxMin.Min Then
                Me.Size = New Size(Me.Width, CButton.Size.Height + Me.Padding.Top + Me.Padding.Bottom)
            End If
        End Set
    End Property

    Public ReadOnly Property UCGetNSS() As R2StandardDesktopProcessGroupStructure
        Get
            Return _NSS
        End Get
    End Property


#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(YourNSS As R2StandardDesktopProcessGroupStructure)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            _NSS = YourNSS
            CButton.Text = YourNSS.PGDisplayTitle
            ''LblProcessGroupDisplayTitle.BackColor = YourNSS.PGBackColor
            ''LblProcessGroupDisplayTitle.ForeColor = YourNSS.PGForeColor

            ''PnlTop.Colors(0).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 0))
            ''PnlTop.Colors(1).Color = Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))

            CButton.ColorFillBlend.iColor(1) = YourNSS.PGBackColor
            CButton.ColorFillBlend.iColor(0) = YourNSS.PGBackColor
            'CButton.ColorFillBlend.iColor(1)=    Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            CButton.ForeColor=Color.FromName(R2CoreMClassConfigurationManagement.GetConfigstring(R2CoreConfigurations.UCProcessGroup, 3))
            Me.Size = New Size(R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 1), R2CoreMClassConfigurationManagement.GetConfigInt64(R2CoreConfigurations.UCProcessGroup, 2))
            CButton.BorderColor=Color.FromName(R2CoreMClassConfigurationManagement.GetConfigString(R2CoreConfigurations.FirstPageColor, 1))
            ''UCViewProcesses
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

    'Private Sub UCViewProcesses()
    '    Try
    '        'نمایش زیرمنوهای گروه انتخاب شده
    '        PnlUCProcessCollection.SuspendLayout()
    '        PnlUCProcessCollection.Controls.Clear()
    '        Dim DS As DataSet
    '        R2ClassSqlDataBOXManagement.GetDataBOX(New R2PrimarySqlConnection, "Select * from R2Primary.dbo.TblProcessGroupsRelationProcesses Where PGId=" & _NSS.PGId & " Order by PGId", 3600, DS)
    '        For Loopx As Int16 = DS.Tables(0).Rows.Count - 1 To 0 Step -1
    '            Dim NSSProcess As R2StandardDesktopProcessStructure = R2Core.DesktopProcessesManagement.R2CoreMClassDesktopProcessesManagement.GetNSSProcess(DS.Tables(0).Rows(Loopx).Item("PId"))
    '            Dim UC As UCProcess = New UCProcess(NSSProcess,_NSS.PGBackColor)
    '            UC.Dock = DockStyle.Top
    '            PnlUCProcessCollection.Controls.Add(UC)
    '        Next
    '        _MaxHight = DS.Tables(0).Rows.Count* 30 + Me.Height
    '    Catch ex As Exception
    '        Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
    '    End Try
    '    PnlUCProcessCollection.ResumeLayout()
    'End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click 
        Try
            RaiseEvent UCClickedEvent(Me)
            'If UCMaxMinStatus = R2Enums.MaxMin.Max Then
            '    UCMaxMinStatus = R2Enums.MaxMin.Min
            'Else
            '    UCMaxMinStatus = R2Enums.MaxMin.Max 
            'End If
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    ''Private Sub LblGroupDisplayTitle_Click(sender As Object, e As EventArgs) 
    ''    Try
    ''        If UCMaxMinStatus = R2Enums.MaxMin.Max Then
    ''            UCMaxMinStatus = R2Enums.MaxMin.Min
    ''        ElseIf UCMaxMinStatus = R2Enums.MaxMin.Min Then
    ''            UCMaxMinStatus = R2Enums.MaxMin.Max
    ''        End If
    ''    Catch ex As Exception
    ''        UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
    ''    End Try
    ''End Sub


#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region







End Class
