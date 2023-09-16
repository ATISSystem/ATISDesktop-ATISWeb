

Imports R2Core.SMS.SMSHandling
Imports R2CoreGUI

Public Class UCEntrySMSData
    Inherits UCGeneral


    Public Event UCSubmitEvent()

#Region "General Properties"

    Public ReadOnly Property UCGetParams As SMSCreationData
        Get
            Dim SMSData = New SMSCreationData()
            SMSData.Data1 = GetParam1
            SMSData.Data2 = GetParam2
            SMSData.Data3 = GetParam3
            SMSData.Data4 = GetParam4
            SMSData.Data5 = GetParam5
            SMSData.Data6 = GetParam6
            SMSData.Data7 = GetParam7
            SMSData.Data8 = GetParam8
            SMSData.Data9 = GetParam9
            SMSData.Data10 = GetParam10
            Return SMSData
        End Get
    End Property

    Public ReadOnly Property GetParam1 As String
        Get
            Return UcPersianTextBox1.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam2 As String
        Get
            Return UcPersianTextBox2.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam3 As String
        Get
            Return UcPersianTextBox3.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam4 As String
        Get
            Return UcPersianTextBox4.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam5 As String
        Get
            Return UcPersianTextBox5.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam6 As String
        Get
            Return UcPersianTextBox6.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam7 As String
        Get
            Return UcPersianTextBox7.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam8 As String
        Get
            Return UcPersianTextBox8.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam9 As String
        Get
            Return UcPersianTextBox9.UCValue
        End Get
    End Property

    Public ReadOnly Property GetParam10 As String
        Get
            Return UcPersianTextBox10.UCValue
        End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcPersianTextBox1_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox1.UC13PressedEvent
        UcPersianTextBox2.UCFocus()
    End Sub

    Private Sub UcPersianTextBox2_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox2.UC13PressedEvent
        UcPersianTextBox3.UCFocus()
    End Sub

    Private Sub UcPersianTextBox3_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox3.UC13PressedEvent
        UcPersianTextBox4.UCFocus()
    End Sub

    Private Sub UcPersianTextBox4_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox4.UC13PressedEvent
        UcPersianTextBox5.UCFocus()
    End Sub

    Private Sub UcPersianTextBox5_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox5.UC13PressedEvent
        UcPersianTextBox6.UCFocus()
    End Sub

    Private Sub UcPersianTextBox6_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox6.UC13PressedEvent
        UcPersianTextBox7.UCFocus()
    End Sub

    Private Sub UcPersianTextBox7_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox7.UC13PressedEvent
        UcPersianTextBox8.UCFocus()
    End Sub

    Private Sub UcPersianTextBox8_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox8.UC13PressedEvent
        UcPersianTextBox9.UCFocus()
    End Sub

    Private Sub UcPersianTextBox9_UC13PressedEvent(PersianText As String) Handles UcPersianTextBox9.UC13PressedEvent
        UcPersianTextBox10.UCFocus()
    End Sub

    Private Sub CButtonSubmit_Click(sender As Object, e As EventArgs) Handles CButtonSubmit.Click
        RaiseEvent UCSubmitEvent()
    End Sub

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region


End Class
