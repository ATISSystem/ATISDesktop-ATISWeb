
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms



Imports R2CoreGUI
Imports R2Core.ExceptionManagement
Imports R2Core.HumanResourcesManagement.Personnel


Public Class UCPersonnel
    Inherits UCGeneral


    Public Event UCViewPersonnelInformationCompleted(PersonnelId As Int64)
    Public Event UCRefreshedEvent()
    Public Event UCRefreshedGeneralEvent()




#Region "General Properties"

    Private _UCViewButtons As Boolean = True
    <DefaultValue(True)>
    <Browsable(True)>
    Public Property UCViewButtons() As Boolean
        Get
            Return _UCViewButtons
        End Get
        Set(value As Boolean)
            _UCViewButtons = value
            If value = True Then
                UcButtonDel.Visible = True
                UcButtonNew.Visible = True
                UcButtonSabt.Visible = True
            Else
                UcButtonDel.Visible = False
                UcButtonNew.Visible = False
                UcButtonSabt.Visible = False
            End If
        End Set
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCRefresh()
        UcPersianTextBoxNameFamily.UCRefresh()
        UcPersianTextBoxFather.UCRefresh() : UcPersianTextBoxTel.UCRefresh() : UcPersianTextBoxAddress.UCRefresh()
        UcNumberPId.UCRefresh() : UcTextBoxNationalCode.UCRefresh() : UcPersianTextBoxPIdOther.UCRefresh()
        UcPersianTextBoxSearchName.Focus()
        RaiseEvent UCRefreshedEvent()
    End Sub

    Public Sub UCRefreshGeneral()
        UCRefresh()
        UcPersianTextBoxSearchName.UCRefresh()
        UcNumberNationalCodeSearch.UCRefresh()
        RaiseEvent UCRefreshedGeneralEvent()
    End Sub

    Public Sub UCViewPersonnelInformation(YourPersonnelId As Int64)
        Try
            Dim NSS As R2CoreStandardPersonnelStructure = R2CorePersonnelMClassManagement.GetNSSPersonnel(YourPersonnelId)
            UCRefresh()
            UcPersianTextBoxSearchName.UCValue = NSS.PNameFamily
            UcNumberNationalCodeSearch.UCValue = IIf(IsNumeric(NSS.NationalCode) = True, NSS.NationalCode, 0)
            UcNumberPId.UCValue = NSS.PId
            UcPersianTextBoxNameFamily.UCValue = NSS.PNameFamily
            UcPersianTextBoxFather.UCValue = NSS.PFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(NSS.NationalCode) = True, NSS.NationalCode, 0)
            UcPersianTextBoxTel.UCValue = NSS.Tel
            UcPersianTextBoxAddress.UCValue = NSS.Address
            UcPersianTextBoxPIdOther.UCValue = NSS.PIdOther
            RaiseEvent UCViewPersonnelInformationCompleted(NSS.PId)
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewPersonnelInformation(YourNSS As R2CoreStandardPersonnelStructure)
        Try
            UCRefresh()
            UcPersianTextBoxSearchName.UCValue = YourNSS.PNameFamily
            UcNumberNationalCodeSearch.UCValue = IIf(IsNumeric(YourNSS.NationalCode) = True, YourNSS.NationalCode, 0)
            UcNumberPId.UCValue = YourNSS.PId
            UcPersianTextBoxNameFamily.UCValue = YourNSS.PNameFamily
            UcPersianTextBoxFather.UCValue = YourNSS.PFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(YourNSS.NationalCode) = True, YourNSS.NationalCode, 0)
            UcPersianTextBoxTel.UCValue = YourNSS.Tel
            UcPersianTextBoxAddress.UCValue = YourNSS.Address
            UcPersianTextBoxPIdOther.UCValue = YourNSS.PIdOther
            ChkActive.Checked=YourNSS.Active
            RaiseEvent UCViewPersonnelInformationCompleted(YourNSS.PId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewPersonnelInformationDirty(YourNSS As R2CoreStandardPersonnelStructure)
        Try
            UcPersianTextBoxNameFamily.UCValue = YourNSS.PNameFamily
            UcPersianTextBoxFather.UCValue = YourNSS.PFatherName
            UcTextBoxNationalCode.UCValue = IIf(IsNumeric(YourNSS.NationalCode) = True, YourNSS.NationalCode, 0)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCSabtRoutin()
        Try
            'بررسی پارامترها
            If UcPersianTextBoxNameFamily.UCValue = "" Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "نام ونام خانوادگی را وارد کنید", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcTextBoxNationalCode.UCValue.ToString.Length <> 10 Then
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.Warning, "کد ملی نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
                Exit Sub
            End If
            If UcNumberPId.UCValue = 0 Then
                UcNumberPId.UCValue = R2CorePersonnelMClassManagement.InsertPersonnel(New R2CoreStandardPersonnelStructure(0, UcPersianTextBoxPIdOther.UCValue, UcPersianTextBoxNameFamily.UCValue, UcPersianTextBoxFather.UCValue, UcTextBoxNationalCode.UCValue, ChkActive.Checked, UcPersianTextBoxTel.UCValue, UcPersianTextBoxAddress.UCValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing),R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات پرسنل ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            Else
                R2CorePersonnelMClassManagement.UpdatePersonnel(New R2CoreStandardPersonnelStructure(UcNumberPId.UCValue, UcPersianTextBoxPIdOther.UCValue, UcPersianTextBoxNameFamily.UCValue, UcPersianTextBoxFather.UCValue, UcTextBoxNationalCode.UCValue, ChkActive.Checked, UcPersianTextBoxTel.UCValue, UcPersianTextBoxAddress.UCValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing),R2CoreGUIMClassGUIManagement.FrmMainMenu.UcUserImage.UCCurrentNSS)
                UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.SuccessProccess, "مشخصات پرسنل ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
            End If
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCDelRoutin()
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub UCViewFrmDrivers(YourSearchStr As String, YourViewType As FrmcPersonnels.ViewType, YourObjectSearcher As Control)
        Try
            Dim Frm As FrmcPersonnels = New FrmcPersonnels
            'Dim P As Point = YourObjectSearcher.PointToScreen(New Point(0, 0))
            'Frm.Location =New Point(P.X-Frm.Width/2,P.Y)
            Frm.ViewPersonnels(YourSearchStr, YourViewType)
            Frm.ShowDialog()
            Dim SelectedPersonnelId As Int64 = Frm.GetSelectedPersonnelId()
            If SelectedPersonnelId <> 0 Then UCViewPersonnelInformation(R2CorePersonnelMClassManagement.GetNSSPersonnel(SelectedPersonnelId))
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Function UCGetNSS() As R2CoreStandardPersonnelStructure
        Try
            If UcNumberPId.UCValue <> 0 Then
                Return R2CorePersonnelMClassManagement.GetNSSPersonnel(UcNumberPId.UCValue)
            Else
                Throw New GetNSSException
            End If
        Catch exx As GetNSSException
            Throw exx
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Function

#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcNumberNationalCodeSearch_UC13Pressed(UserNumber As String) Handles UcNumberNationalCodeSearch.UC13Pressed
        Try
            UCRefresh()
            UCViewFrmDrivers(UcNumberNationalCodeSearch.UCValue, FrmcPersonnels.ViewType.ByNationalCode, UcNumberNationalCodeSearch)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcPersianTextBoxSearchName_UC13PressedEvent(PersianText As String) Handles UcPersianTextBoxSearchName.UC13PressedEvent
        Try
            UCRefresh()
            UCViewFrmDrivers(UcPersianTextBoxSearchName.UCValue, FrmcPersonnels.ViewType.ByNameFamily, UcPersianTextBoxSearchName)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonNew_UCClickedEvent() Handles UcButtonNew.UCClickedEvent
        UCRefresh()
    End Sub

    Private Sub UcButtonSabt_UCClickedEvent() Handles UcButtonSabt.UCClickedEvent
        Try
            UCSabtRoutin()
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Private Sub UcButtonDel_UCClickedEvent() Handles UcButtonDel.UCClickedEvent
        Try
            UCDelRoutin()
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
