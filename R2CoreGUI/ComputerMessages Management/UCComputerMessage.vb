
Imports System.Reflection

Imports R2Core.ComputerMessagesManagement
Imports R2Core.ComputersManagement
Imports R2Core.ExceptionManagement
Imports R2Core.UserManagement

Public Class UCComputerMessage
    Inherits UCGeneral

    Protected _NSS As R2StandardComputerMessageStructure
    Public Event UCViewNSSCompleted()

#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcLabelCMTypeTitle.UCRefresh()
        UcLabelCMNote.UCRefresh()
        UcLabelUserName.UCRefresh()
        UcLabelComputerName.UCRefresh()
        UcLabelDateTime.UCRefresh()
    End Sub

    Public Sub UCViewNSS(YourNSS As R2StandardComputerMessageStructure)
        Try
            _NSS = YourNSS
            UCRefresh()
            PnlMain.BackColor =  R2CoreMClassComputerMessagesManagement.GetNSSComputerMessageType(YourNSS.CMType).SpecialColor
            UcLabelCMTypeTitle.UCValue = R2CoreMClassComputerMessagesManagement.GetNSSComputerMessageType(YourNSS.CMType).CMTypeTiltle
            UcLabelUserName.UCValue = R2CoreMClassLoginManagement.GetNSSUser(YourNSS.UserId).UserName
            UcLabelComputerName.UCValue = R2CoreMClassComputersManagement.GetNSSComputer(YourNSS.ComputerId).MName
            UcLabelDateTime.UCValue = YourNSS.DateShamsi & " " & YourNSS.Time
            UcLabelCMNote.UCValue = YourNSS.CMNote
            RaiseEvent UCViewNSSCompleted()
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected Sub UCDeactiveComputerMessage()
        Try
            R2CoreMClassComputerMessagesManagement.DeactiveComputerMessage(_NSS)
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

