
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2Core
Imports R2Core.PublicProc
Imports R2Core.UserManagement
Imports R2CoreGUI
Imports R2CoreParkingSystem.EnterExitManagement
Imports R2Core.ComputersManagement
Imports R2CoreParkingSystem.TrafficCardsManagement

Public Class UCEnterExit
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCEnterExit)


#Region "General Properties"

    <Browsable(False)>
    Public Property UCCurrentNSS As R2StandardEnterExitStructure = Nothing

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

        Catch ex As Exception

            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefresh()
        For Each UC As Label In PnlLabels.Controls
            UC.Text = String.Empty
        Next
    End Sub

    Public Sub UCViewEnterExit(YourNSSEnterExit As R2StandardEnterExitExtendedStructure)
        Try
            UCRefresh()
            LblDateShamsiEnter.Text = YourNSSEnterExit.DateShamsiEnter
            LblTimeEnter.Text = YourNSSEnterExit.TimeEnter
            LblCardNoEnter.Text = YourNSSEnterExit.CardNoEnter
            LblUserEnter.Text = YourNSSEnterExit.UserNameEnter
            LblMblghEnter.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourNSSEnterExit.MblghEnter)
            LblMaabarNameEnter.Text = YourNSSEnterExit.GateEnterName
            LblLPEnter.Text = YourNSSEnterExit.LPEnter.GetLPString()
            LblDateShamsiExit.Text = YourNSSEnterExit.DateShamsiExit
            LblTimeExit.Text = YourNSSEnterExit.TimeExit
            LblCardNoExit.Text = YourNSSEnterExit.CardNoExit
            LblUserExit.Text = YourNSSEnterExit.UserNameExit
            LblMblghExit.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourNSSEnterExit.MblghExit)
            LblMaabarNameExit.Text = YourNSSEnterExit.GateExitName
            LblLpExit.Text = YourNSSEnterExit.LPExit.GetLPString()
            UcCarImage.UCViewCarEnterExitImage(YourNSSEnterExit)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcLabels_UCClickedEventHandler() Handles LblMblghExit.Click, LblTimeExit.Click, LblUserExit.Click, LblCardNoExit.Click, LblMaabarNameExit.Click, LblDateShamsiExit.Click, LblLpExit.Click, LblDateShamsiEnter.Click, LblTimeEnter.Click, LblLPEnter.Click, LblMaabarNameEnter.Click, LblMblghEnter.Click, LblCardNoEnter.Click, LblUserEnter.Click
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
