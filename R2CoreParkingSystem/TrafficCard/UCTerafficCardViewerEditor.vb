

Imports System.ComponentModel
Imports System.Reflection

Imports R2Core
Imports R2Core.UserManagement
Imports R2Core.DateAndTimeManagement
Imports R2Core.ExceptionManagement
Imports R2CoreGUI
Imports R2CoreLPR.LicensePlateManagement
Imports R2CoreParkingSystem.TrafficCardsManagement


Public Class UCTerafficCardViewerEditor
    Inherits R2CoreGUI.UCGeneral

    Public Event UCTerafficCardEditSuccess()
    Private _DateTime As R2DateTime = New R2DateTime
    Private _NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = Nothing


#Region "General Properties"

    Private _UCCanEdit As Boolean = False
    Public Property UCCanEdit As Boolean
        Get
            Return _UCCanEdit
        End Get
        Set(ByVal value As Boolean)
            _UCCanEdit = value
        End Set
    End Property

    Private _UCEditLevel As Byte = R2Enums.EditLevel.LowLevel
    Public Property UCEditLevel As R2Enums.EditLevel
        Get
            Return _UCEditLevel
        End Get
        Set(ByVal value As R2Enums.EditLevel)
            _UCEditLevel = value
            If value = R2Enums.EditLevel.LowLevel Then
                PnlActive.Enabled = False
                PnlNoMoney.Enabled = False
            ElseIf value = R2Enums.EditLevel.HighLevel Then
                PnlActive.Enabled = True
                PnlNoMoney.Enabled = True
            End If
        End Set
    End Property

    <Browsable(false)>
    Public ReadOnly Property UCGetNSSTerafficCard() As R2CoreParkingSystemStandardTrafficCardStructure
    get
            Return _NSSTerafficCard
    End Get
    End Property

#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        UCRefresh()
    End Sub

    Public Sub UCRefresh()
        UcrfidCardTextMaintainer.UCRefresh() : UcMoneyWallet.UCRefresh()
        UcCmbTerafficCardType.UCRefresh() : UcCmbTerafficTempCardType.UCRefresh()
        OpbActive1.Checked = True : OpbNoMoney1.Checked = True
        LblDateEdit.Text = "" : LblDateSabt.Text = "" : LblUserEdit.Text = "" : LblUserSabt.Text = ""
        UcPersianTextBoxMobile.UCRefresh() :UcPersianTextBoxTel.UCRefresh() : UcPersianTextBoxTahvilg.UCRefresh() : UcPersianTextBoxNameFamily.UCRefresh() : UcPersianTextBoxAddress.UCRefresh()
        UcPersianTextBoxPelak.UCRefresh() : UcPersianTextBoxSerial.UCRefresh() : UcPersianTextBoxCompany.UCRefresh()
    End Sub

    Public Sub UCEditTerafficCard()
        Try
            If _UCCanEdit = False Then
                Throw New Exception("طبق تنظیمات توسعه دهنده امکان ویرایش وجود ندارد")
            End If
            If (UcPersianTextBoxMobile.UCValue = "") Or (UcPersianTextBoxMobile.UCValue.Length < 11) Then
                Throw New Exception("شماره موبایل صحیح نیست")
            End If
            Dim myCardType As TerafficCardType = UcCmbTerafficCardType.UCGetCurrentTypeCode()
            Dim myTempCardType As TerafficTempCardType = UcCmbTerafficTempCardType.UCGetCurrentTempTypeCode()
            R2CoreParkingSystemMClassTrafficCardManagement.TerafficCardEdit(New R2CoreParkingSystemStandardTrafficCardStructure(_NSSTerafficCard.CardId, _NSSTerafficCard.CardNo, 0, 0, R2CoreMClassLoginManagement.CurrentUserNSS.UserId, R2PelakType.None, UcPersianTextBoxPelak.UCValue, UcPersianTextBoxSerial.UCValue, OpbNoMoney1.Checked, OpbActive1.Checked, UcPersianTextBoxCompany.UCValue, UcPersianTextBoxNameFamily.UCValue,UcPersianTextBoxMobile.UCValue, UcPersianTextBoxAddress.UCValue,UcPersianTextBoxTel.UCValue, UcPersianTextBoxTahvilg.UCValue, Nothing, _DateTime.GetCurrentDateTimeMilladiFormated(), Nothing, _DateTime.GetCurrentDateShamsiFull(), myCardType, myTempCardType),UCEditLevel)
            RaiseEvent UCTerafficCardEditSuccess()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCViewTerafficCardInformation(ByVal YourNSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure)
        Try
            _NSSTerafficCard = YourNSSTerafficCard
            UCRefresh()
            UcrfidCardTextMaintainer.UCValue = YourNSSTerafficCard.CardNo
            UcMoneyWallet.UCViewMoneyWalletOnlyCharge(_NSSTerafficCard)
            OpbActive1.Checked = YourNSSTerafficCard.Active
            OpbActive2.Checked = Not YourNSSTerafficCard.Active
            OpbNoMoney1.Checked = YourNSSTerafficCard.NoMoney
            OpbNoMoney2.Checked = Not YourNSSTerafficCard.NoMoney
            LblUserEdit.Text = R2CoreMClassLoginManagement.GetNSSUser(YourNSSTerafficCard.UserIdEdit).UserName
            LblUserSabt.Text = R2CoreMClassLoginManagement.GetNSSUser(YourNSSTerafficCard.UserIdSabt).UserName
            LblDateEdit.Text = YourNSSTerafficCard.DateShamsiEdit
            LblDateSabt.Text = YourNSSTerafficCard.DateShamsiSabt
            UcPersianTextBoxMobile.UCValue = YourNSSTerafficCard.Mobile
            UcPersianTextBoxTel.UCValue = YourNSSTerafficCard.Tel
            UcPersianTextBoxTahvilg.UCValue = YourNSSTerafficCard.Tahvilg
            UcPersianTextBoxNameFamily.UCValue = YourNSSTerafficCard.NameFamily
            UcPersianTextBoxAddress.UCValue = YourNSSTerafficCard.Address
            UcPersianTextBoxPelak.UCValue = YourNSSTerafficCard.Pelak
            UcPersianTextBoxSerial.UCValue = YourNSSTerafficCard.Serial
            UcPersianTextBoxCompany.UCValue = YourNSSTerafficCard.CompanyName
            UcCmbTerafficTempCardType.UCSetTempType(YourNSSTerafficCard.TempCardType)
            UcCmbTerafficCardType.UCSetType(YourNSSTerafficCard.CardType)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcrfidCardTextMaintainer_UC13PressedEvent(YourText As String) Handles UcrfidCardTextMaintainer.UC13PressedEvent
        Try
            Dim NSSTerafficCard As R2CoreParkingSystemStandardTrafficCardStructure = R2CoreParkingSystemMClassTrafficCardManagement.GetNSSTrafficCard(YourText)
            UCViewTerafficCardInformation(NSSTerafficCard)
        Catch exx As GetNSSException
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorInDataEntry, "شماره کارت نادرست است", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing, Me)
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
