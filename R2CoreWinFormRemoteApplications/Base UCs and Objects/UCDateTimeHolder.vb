
Imports System.Reflection
Imports R2CoreWinFormRemoteApplications.DateTimeManagement

Public Class UCDateTimeHolder
    Inherits UCGeneral



    Private _DateTime As R2DateTime = New R2DateTime()
    Public Event UCDoCommand()


#Region "General Properties"

    Private _DisableTimeSetting As Boolean = False
    Public Property UCDisableTimeSetting As Boolean
        Get
            Return _DisableTimeSetting
        End Get
        Set(value As Boolean)
            _DisableTimeSetting = value
            If value = True Then
                UcPersianTextBoxTime1.UCEnable = False
                UcPersianTextBoxTime2.UCEnable = False
            Else
                UcPersianTextBoxTime1.UCEnable = True
                UcPersianTextBoxTime2.UCEnable = True
            End If
        End Set
    End Property

    Public ReadOnly Property UCGetConcat1 As String
        Get
            Return UcPersianTextBoxDate1.UCValue.Replace("/", "") + UcPersianTextBoxTime1.UCValue.Replace(":", "")
        End Get
    End Property

    Public ReadOnly Property UCGetConcat2 As String
        Get
            Return UcPersianTextBoxDate2.UCValue.Replace("/", "") + UcPersianTextBoxTime2.UCValue.Replace(":", "")
        End Get
    End Property

    Public ReadOnly Property UCGetDate1() As String
    get
            Return UcPersianTextBoxDate1.UCValue
    End Get
    End Property

    Public ReadOnly Property UCGetDate2() As String
        get
            Return UcPersianTextBoxDate2.UCValue
        End Get
    End Property

    Public ReadOnly Property UCGetTime1() As String
        get
            Return UcPersianTextBoxTime1.UCValue
        End Get
    End Property

    Public ReadOnly Property UCGetTime2() As String
        get
            Return UcPersianTextBoxTime2.UCValue
        End Get
    End Property

    Public ReadOnly Property UCGetDateTime1() As R2CoreWinFormRemoteApplicationsStandardDateAndTimeStructure
    get
            Return New R2CoreWinFormRemoteApplicationsStandardDateAndTimeStructure(_DateTime.GetMilladiDateTimeFromDateShamsiFull(UCGetDate1,UCGetTime1),UCGetDate1,UCGetTime1)
    End Get
    End Property

    Public ReadOnly Property UCGetDateTime2() As R2CoreWinFormRemoteApplicationsStandardDateAndTimeStructure
        get
            Return New R2CoreWinFormRemoteApplicationsStandardDateAndTimeStructure(_DateTime.GetMilladiDateTimeFromDateShamsiFull(UCGetDate2,UCGetTime2),UCGetDate2,UCGetTime2)
        End Get
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try

    End Sub

    Public Sub UCRefresh()
        Try
            UcPersianTextBoxDate1.UCValue = _DateTime.GetCurrentDateShamsiFull()
            UcPersianTextBoxDate2.UCValue = _DateTime.GetCurrentDateShamsiFull()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButton_UCClickedEvent() Handles UcButton.UCClickedEvent
        Try
            If _DateTime.ChekDateShamsiFullSyntax(UcPersianTextBoxDate1.UCValue) = False Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry,"تاریخ را به صورت صحیح وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
                UcPersianTextBoxDate1.Focus()
                Exit Sub
            End If
            If _DateTime.ChekDateShamsiFullSyntax(UcPersianTextBoxDate2.UCValue) = False Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry,"تاریخ را به صورت صحیح وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
                UcPersianTextBoxDate2.Focus()
                Exit Sub
            End If
            If _DateTime.ChekTimeSyntax(UcPersianTextBoxTime1.UCValue) = False Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry,"ساعت را به صورت صحیح وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
                UcPersianTextBoxTime1.Focus()
                Exit Sub
            End If
            If _DateTime.ChekTimeSyntax(UcPersianTextBoxTime2.UCValue) = False Then
                _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry,"ساعت را به صورت صحیح وارد نمایید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me,true)
                UcPersianTextBoxTime2.Focus()
                Exit Sub
            End If
            RaiseEvent UCDoCommand()
        Catch ex As Exception
            _FrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType,MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me,false)
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
