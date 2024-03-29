﻿
Imports System.Drawing
Imports System.Reflection

Imports R2Core.BaseStandardClass
Imports R2Core.ComputersManagement
Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.TransportCompanies

Public Class UCSearcherTransportCompanies
    Inherits UCSearcherAdvance



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.ExistComputerInTranportCompanies(R2CoreMClassComputersManagement.GetNSSCurrentComputer().MId) Then
                'در آینده در این قسمت باید بر اساس ارتباط کامپیوتر با شرکت فقط شرکت مورد نظر قابل رویت باشد و قفل شود
                Me.Enabled = False
            End If
            UCMaximizeHight = 200
            UCBackColor = Color.OrangeRed
            'UCRefreshInformation()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Shadows Sub UCRefreshInformation()
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetTransportCompanies_SearchforLeftCharacters(String.Empty).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UCSearcherTransportCompanies_UCIconClicked() Handles Me.UCIconRefreshRequestClicked
        Try
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcherTransportCompanies_UCSearchOptional1RequestEvent(SearchString As String) Handles Me.UCSearchOptional1RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetTransportCompanies_SearchforLeftCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UCSearcherTransportCompanies_UCSearchOptional2RequestEvent(SearchString As String) Handles Me.UCSearchOptional2RequestEvent
        Try
            UCFillListBox(R2CoreTransportationAndLoadNotificationMClassTransportCompaniesManagement.GetTransportCompanies_SearchIntroCharacters(SearchString).Select(Function(X) New R2StandardStructure(X.OCode, X.OName)).ToList())
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
