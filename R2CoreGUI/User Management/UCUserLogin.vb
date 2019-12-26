
Imports System.Reflection

Imports R2Core.UserManagement
Imports R2Core.AuthenticationManagement
Imports R2Core.ComputersManagement
Imports R2Core.PublicProc
Imports R2Core.RFIDCardsManagement


Public Class UCUserLogin
    Inherits UCGeneral
    Implements R2CoreRFIDCardRequester


    Public Event UCUserAuthenticationSuccessEvent(NSSUser As R2CoreStandardUserStructure)


#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime) Then
            Else
                StartReading()
            End If
            UcLabelUserPassword.UCForeColor = R2CoreMClassPublicProcedures.GetInvertColor(Me.BackColor)
            UcLabelUserShenaseh.UCForeColor = R2CoreMClassPublicProcedures.GetInvertColor(Me.BackColor)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub StartReading()
        Try
            R2CoreRFIDCardReaderInterface.StartReading(Me, R2CoreRFIDCardReaderInterface.InterfaceMode.TestForRFIDCardConfirm)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Function GetUserComputerPermission(YourUserNSS As R2CoreStandardUserStructure)
        Try
            If R2MClassAuthenticationManagement.UserHaveComputerPermission(YourUserNSS, R2CoreMClassComputersManagement.GetNSSCurrentComputer()) = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

    Private Sub SetCurrentUserByShenasehPassword()
        Try
            Dim NSS As R2CoreStandardUserStructure = R2CoreMClassLoginManagement.GetNSSUser(UcTextBoxUserShenaseh.UCValue, UcTextBoxUserPassword.UCValue)
            'بررسی مجوز کاربر برای دسترسی به کامپیوتر
            If GetUserComputerPermission(NSS) = False Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کاربر مجوز لازم برای دسترسی به این کامپیوتر را ندارد", R2CoreMClassComputersManagement.GetNSSCurrentComputer().MName, FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Try
            End If
            R2CoreMClassLoginManagement.SetCurrentUserbyShenasehPassword(New R2CoreStandardUserStructure(0, "", UcTextBoxUserShenaseh.UCValue, UcTextBoxUserPassword.UCValue, "", False, False))
            RaiseEvent UCUserAuthenticationSuccessEvent(NSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub

    Private Sub SetCurrentUserByPinCode(YourPinCode As String)
        Try
            Dim NSS As R2CoreStandardUserStructure = R2CoreMClassLoginManagement.GetNSSUser(YourPinCode)
            'بررسی مجوز کاربر برای دسترسی به کامپیوتر
            If GetUserComputerPermission(NSS) = False Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کاربر مجوز لازم برای دسترسی به این کامپیوتر را ندارد", R2CoreMClassComputersManagement.GetNSSCurrentComputer().MName, FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Try
            End If
            R2CoreMClassLoginManagement.SetCurrentUserByPinCode(NSS)
            RaiseEvent UCUserAuthenticationSuccessEvent(NSS)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcButtonSpecial_UCClickedEvent() Handles UcButtonSpecial.UCClickedEvent
        Try
            SetCurrentUserByShenasehPassword()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonSpecial_UC13PressedEvent() Handles UcButtonSpecial.UC13PressedEvent
        Try
            SetCurrentUserByShenasehPassword()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcTextBoxUserShenaseh_UC13PressedEvent(CurrentText As String) Handles UcTextBoxUserShenaseh.UC13PressedEvent
        UcTextBoxUserPassword.Focus()
    End Sub

    Private Sub UcTextBoxUserPassword_UC13PressedEvent(CurrentText As String) Handles UcTextBoxUserPassword.UC13PressedEvent
        UcButtonSpecial.UCFocus()
    End Sub

    Private Sub UcTextBoxUserShenaseh_UCGotFocusEvent() Handles UcTextBoxUserShenaseh.UCGotFocusEvent, UcTextBoxUserPassword.UCGotFocusEvent
        Try
            StartReading()
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

    Public Sub R2RFIDCardReaderStartToRead() Implements R2CoreRFIDCardRequester.R2RFIDCardReaderStartToRead
        'Throw New NotImplementedException
    End Sub

    Public Sub R2RFIDCardReaded(CardNo As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaded
        Try
            SetCurrentUserByPinCode(CardNo)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

        Try
            StartReading()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "خطا در عملکرد دستگاه کارت خوان", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try

    End Sub

    Public Sub R2RFIDCardReaderWarning(MessageWarning As String) Implements R2CoreRFIDCardRequester.R2RFIDCardReaderWarning
        MessageBox.Show(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + MessageWarning)
    End Sub

  














#End Region



End Class
