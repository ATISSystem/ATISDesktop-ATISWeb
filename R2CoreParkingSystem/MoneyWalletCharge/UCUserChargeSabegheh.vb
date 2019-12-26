

Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection

Imports R2Core.PublicProc
Imports R2CoreGUI
Imports R2CoreParkingSystem.TrafficCardsManagement
Imports R2CoreParkingSystem.UserChargeProcessManagement


Public Class UCUserChargeSabegheh
    Inherits UCGeneral

    Public Event UCClickedEvent(UC As UCUserChargeSabegheh)



#Region "General Properties"

    Private _UCFont As Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    Public Property UCFont() As Font
        Get
            Return _UCFont
        End Get
        Set(value As Font)
            _UCFont = value
            LblDate.Font = value
            LblTime.Font = value
            LblMblgh.Font = value
            LblTrafficCardNo.Font = value
        End Set
    End Property

    Private _UCBackColor As Color = Color.White
    Public Property UCBackColor() As Color
        Get
            Return _UCBackColor
        End Get
        Set(value As Color)
            _UCBackColor = value
            PnlMain.BackColor = value
        End Set
    End Property

    Private _UCForeColor As Color = Color.Black
    Public Property UCForeColor() As Color
        Get
            Return _UCForeColor
        End Get
        Set(value As Color)
            _UCForeColor = value
            LblDate.ForeColor = value
            LblTime.ForeColor = value
            LblMblgh.ForeColor = value
            LblTrafficCardNo.ForeColor = value
        End Set
    End Property

    <Browsable(False)>
    Public Property UCCurrentNSS As R2StandardUserChargeProcessStructure = Nothing

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UCRefresh()
        LblDate.Text = ""
        LblTime.Text = ""
        LblMblgh.Text = ""
        LblTrafficCardNo.Text = ""
    End Sub

    Public Sub UCViewInf(YourNSS As R2StandardUserChargeProcessStructure)
        Try
            UCCurrentNSS = YourNSS
            UCRefresh()
            LblDate.Text = YourNSS.DateShamsi
            LblMblgh.Text = R2CoreMClassPublicProcedures.ParseSignDigitToSignString(YourNSS.Mblgh)
            LblTime.Text = YourNSS.TimeCharge
            LblTrafficCardNo.Text = YourNSS.TrafficCardNo
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod.DeclaringType.FullName + vbCrLf + MethodBase.GetCurrentMethod.Name + vbCrLf + ex.Message.ToString)
        End Try
    End Sub

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub Labels_ClickHandler(sender As Object, e As EventArgs) Handles LblDate.Click, LblMblgh.Click,LblTime.Click,LblTrafficCardNo.Click
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
