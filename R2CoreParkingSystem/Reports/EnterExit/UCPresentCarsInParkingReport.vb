
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Imports R2CoreGUI
Imports R2Core.R2PrimaryWS
Imports R2CoreParkingSystem.ReportsManagement

Public Class UCPresentCarsInParkingReport
    Inherits UCGeneral

    Private _WS As R2PrimaryWebService=new R2PrimaryWebService()

#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New ()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

   
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Sub UcButtonSpecial_UCClickedEvent() Handles UcButtonSpecial.UCClickedEvent
        Try
            Cursor.Current = Cursors.WaitCursor
            _WS.WebMethodReportingInformationPrividerPresentCarsInParkingReport(Nothing, UcPersianShamsiDate.UCGetDate().DateShamsiFull, Nothing, UcCmbTerafficCardType.UCGetCurrentTypeCode(), ChkViewCarImage.Checked,_WS.WebMethodLogin(R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserShenaseh,R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS.UserPassword))
            R2CoreGUIMClassInformationManagement.PrintReport(R2CoreParkingSystemReports.PresentCarsInParkingReport)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

  
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region




End Class
