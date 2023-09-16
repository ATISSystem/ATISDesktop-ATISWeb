
Imports System.Windows.Forms 

Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDriver
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.CButtonDelete = New CButtonLib.CButton()
        Me.UcActivateUnActivateSMSOwner = New R2CoreParkingSystem.UCActivateUnActivateSMSOwner()
        Me.CButtonNew = New CButtonLib.CButton()
        Me.CButtonSabt = New CButtonLib.CButton()
        Me.UcTextBoxDriverNationalCode = New R2CoreGUI.UCTextBox()
        Me.UcNumberDrivernIdPerson = New R2CoreGUI.UCNumber()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcPersianTextBoxDriverName = New R2CoreGUI.UCPersianTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CButtonSendSmsUserShenasehPassword = New CButtonLib.CButton()
        Me.CButtonSoftwareUserVerificationCodeInjection = New CButtonLib.CButton()
        Me.CButtonViewPrintUserShenasehPassword = New CButtonLib.CButton()
        Me.UcTextBoxNationalCode = New R2CoreGUI.UCTextBox()
        Me.UcNumberLicenseNo = New R2CoreGUI.UCNumber()
        Me.UcPersianTextBoxNameFamily = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxFather = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxTel = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxAddress = New R2CoreGUI.UCPersianTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.CButtonDelete)
        Me.PnlMain.Controls.Add(Me.UcActivateUnActivateSMSOwner)
        Me.PnlMain.Controls.Add(Me.CButtonNew)
        Me.PnlMain.Controls.Add(Me.CButtonSabt)
        Me.PnlMain.Controls.Add(Me.UcTextBoxDriverNationalCode)
        Me.PnlMain.Controls.Add(Me.UcNumberDrivernIdPerson)
        Me.PnlMain.Controls.Add(Me.Label9)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxDriverName)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(981, 95)
        Me.PnlMain.TabIndex = 0
        '
        'CButtonDelete
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonDelete.ColorFillBlend = CBlendItems1
        Me.CButtonDelete.Corners.LowerRight = 10
        Me.CButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonDelete.DesignerSelected = False
        Me.CButtonDelete.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonDelete.ImageIndex = 0
        Me.CButtonDelete.Location = New System.Drawing.Point(122, 6)
        Me.CButtonDelete.Name = "CButtonDelete"
        Me.CButtonDelete.Size = New System.Drawing.Size(48, 22)
        Me.CButtonDelete.TabIndex = 28
        Me.CButtonDelete.Text = "حذف"
        '
        'UcActivateUnActivateSMSOwner
        '
        Me.UcActivateUnActivateSMSOwner.BackColor = System.Drawing.Color.Transparent
        Me.UcActivateUnActivateSMSOwner.Location = New System.Drawing.Point(176, 5)
        Me.UcActivateUnActivateSMSOwner.Name = "UcActivateUnActivateSMSOwner"
        Me.UcActivateUnActivateSMSOwner.Size = New System.Drawing.Size(178, 23)
        Me.UcActivateUnActivateSMSOwner.TabIndex = 24
        Me.UcActivateUnActivateSMSOwner.UCNSSCurrent = Nothing
        '
        'CButtonNew
        '
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonNew.ColorFillBlend = CBlendItems2
        Me.CButtonNew.Corners.LowerRight = 10
        Me.CButtonNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonNew.DesignerSelected = False
        Me.CButtonNew.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonNew.ImageIndex = 0
        Me.CButtonNew.Location = New System.Drawing.Point(68, 6)
        Me.CButtonNew.Name = "CButtonNew"
        Me.CButtonNew.Size = New System.Drawing.Size(48, 22)
        Me.CButtonNew.TabIndex = 27
        Me.CButtonNew.Text = "جدید"
        '
        'CButtonSabt
        '
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems3.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSabt.ColorFillBlend = CBlendItems3
        Me.CButtonSabt.Corners.LowerRight = 10
        Me.CButtonSabt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSabt.DesignerSelected = False
        Me.CButtonSabt.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSabt.ImageIndex = 0
        Me.CButtonSabt.Location = New System.Drawing.Point(14, 6)
        Me.CButtonSabt.Name = "CButtonSabt"
        Me.CButtonSabt.Size = New System.Drawing.Size(48, 22)
        Me.CButtonSabt.TabIndex = 26
        Me.CButtonSabt.Text = "ثبت"
        '
        'UcTextBoxDriverNationalCode
        '
        Me.UcTextBoxDriverNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxDriverNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxDriverNationalCode.Location = New System.Drawing.Point(627, 4)
        Me.UcTextBoxDriverNationalCode.Name = "UcTextBoxDriverNationalCode"
        Me.UcTextBoxDriverNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxDriverNationalCode.Size = New System.Drawing.Size(89, 26)
        Me.UcTextBoxDriverNationalCode.TabIndex = 24
        Me.UcTextBoxDriverNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxDriverNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxDriverNationalCode.UCBorder = True
        Me.UcTextBoxDriverNationalCode.UCBorderColor = System.Drawing.Color.Black
        Me.UcTextBoxDriverNationalCode.UCBorderCornerRedius = 5
        Me.UcTextBoxDriverNationalCode.UCEnable = True
        Me.UcTextBoxDriverNationalCode.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcTextBoxDriverNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxDriverNationalCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxDriverNationalCode.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxDriverNationalCode.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxDriverNationalCode.UCMultiLine = False
        Me.UcTextBoxDriverNationalCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxDriverNationalCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxDriverNationalCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxDriverNationalCode.UCValue = ""
        '
        'UcNumberDrivernIdPerson
        '
        Me.UcNumberDrivernIdPerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberDrivernIdPerson.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberDrivernIdPerson.Location = New System.Drawing.Point(519, 5)
        Me.UcNumberDrivernIdPerson.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberDrivernIdPerson.Name = "UcNumberDrivernIdPerson"
        Me.UcNumberDrivernIdPerson.Size = New System.Drawing.Size(77, 25)
        Me.UcNumberDrivernIdPerson.TabIndex = 20
        Me.UcNumberDrivernIdPerson.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberDrivernIdPerson.UCAllowedMinNumber = CType(-9223372036854775, Long)
        Me.UcNumberDrivernIdPerson.UCBackColor = System.Drawing.Color.White
        Me.UcNumberDrivernIdPerson.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberDrivernIdPerson.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberDrivernIdPerson.UCBorder = True
        Me.UcNumberDrivernIdPerson.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberDrivernIdPerson.UCEnable = False
        Me.UcNumberDrivernIdPerson.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberDrivernIdPerson.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberDrivernIdPerson.UCMultiLine = False
        Me.UcNumberDrivernIdPerson.UCValue = CType(0, Long)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(600, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "کد"
        '
        'UcPersianTextBoxDriverName
        '
        Me.UcPersianTextBoxDriverName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxDriverName.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxDriverName.Location = New System.Drawing.Point(763, 5)
        Me.UcPersianTextBoxDriverName.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxDriverName.Name = "UcPersianTextBoxDriverName"
        Me.UcPersianTextBoxDriverName.Size = New System.Drawing.Size(106, 24)
        Me.UcPersianTextBoxDriverName.TabIndex = 2
        Me.UcPersianTextBoxDriverName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDriverName.UCBorder = True
        Me.UcPersianTextBoxDriverName.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDriverName.UCEnable = True
        Me.UcPersianTextBoxDriverName.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxDriverName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDriverName.UCMultiLine = False
        Me.UcPersianTextBoxDriverName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxDriverName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxDriverName.UCValue = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(719, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کد ملی"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(872, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام و نام خانوادگی"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CButtonSendSmsUserShenasehPassword)
        Me.Panel1.Controls.Add(Me.CButtonSoftwareUserVerificationCodeInjection)
        Me.Panel1.Controls.Add(Me.CButtonViewPrintUserShenasehPassword)
        Me.Panel1.Controls.Add(Me.UcTextBoxNationalCode)
        Me.Panel1.Controls.Add(Me.UcNumberLicenseNo)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxNameFamily)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxFather)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxTel)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxAddress)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(6, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 73)
        Me.Panel1.TabIndex = 0
        '
        'CButtonSendSmsUserShenasehPassword
        '
        Me.CButtonSendSmsUserShenasehPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems4.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSendSmsUserShenasehPassword.ColorFillBlend = CBlendItems4
        Me.CButtonSendSmsUserShenasehPassword.Corners.LowerRight = 10
        Me.CButtonSendSmsUserShenasehPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSendSmsUserShenasehPassword.DesignerSelected = False
        Me.CButtonSendSmsUserShenasehPassword.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSendSmsUserShenasehPassword.ImageIndex = 0
        Me.CButtonSendSmsUserShenasehPassword.Location = New System.Drawing.Point(12, 44)
        Me.CButtonSendSmsUserShenasehPassword.Name = "CButtonSendSmsUserShenasehPassword"
        Me.CButtonSendSmsUserShenasehPassword.Size = New System.Drawing.Size(147, 22)
        Me.CButtonSendSmsUserShenasehPassword.TabIndex = 23
        Me.CButtonSendSmsUserShenasehPassword.Text = "ارسال اس ام اس رمز شخصی"
        '
        'CButtonSoftwareUserVerificationCodeInjection
        '
        Me.CButtonSoftwareUserVerificationCodeInjection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.DeepPink, System.Drawing.Color.Purple, System.Drawing.Color.Black}
        CBlendItems5.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSoftwareUserVerificationCodeInjection.ColorFillBlend = CBlendItems5
        Me.CButtonSoftwareUserVerificationCodeInjection.ColorFillSolid = System.Drawing.SystemColors.ActiveCaption
        Me.CButtonSoftwareUserVerificationCodeInjection.Corners.LowerRight = 10
        Me.CButtonSoftwareUserVerificationCodeInjection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSoftwareUserVerificationCodeInjection.DesignerSelected = False
        Me.CButtonSoftwareUserVerificationCodeInjection.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSoftwareUserVerificationCodeInjection.ImageIndex = 0
        Me.CButtonSoftwareUserVerificationCodeInjection.Location = New System.Drawing.Point(269, 45)
        Me.CButtonSoftwareUserVerificationCodeInjection.Name = "CButtonSoftwareUserVerificationCodeInjection"
        Me.CButtonSoftwareUserVerificationCodeInjection.Size = New System.Drawing.Size(113, 22)
        Me.CButtonSoftwareUserVerificationCodeInjection.TabIndex = 22
        Me.CButtonSoftwareUserVerificationCodeInjection.Text = "تزریق کد فعال سازی"
        '
        'CButtonViewPrintUserShenasehPassword
        '
        Me.CButtonViewPrintUserShenasehPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems6.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonViewPrintUserShenasehPassword.ColorFillBlend = CBlendItems6
        Me.CButtonViewPrintUserShenasehPassword.Corners.LowerRight = 10
        Me.CButtonViewPrintUserShenasehPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonViewPrintUserShenasehPassword.DesignerSelected = False
        Me.CButtonViewPrintUserShenasehPassword.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonViewPrintUserShenasehPassword.ImageIndex = 0
        Me.CButtonViewPrintUserShenasehPassword.Location = New System.Drawing.Point(163, 45)
        Me.CButtonViewPrintUserShenasehPassword.Name = "CButtonViewPrintUserShenasehPassword"
        Me.CButtonViewPrintUserShenasehPassword.Size = New System.Drawing.Size(100, 22)
        Me.CButtonViewPrintUserShenasehPassword.TabIndex = 21
        Me.CButtonViewPrintUserShenasehPassword.Text = "نمایش رمز شخصی"
        '
        'UcTextBoxNationalCode
        '
        Me.UcTextBoxNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxNationalCode.Location = New System.Drawing.Point(424, 16)
        Me.UcTextBoxNationalCode.Name = "UcTextBoxNationalCode"
        Me.UcTextBoxNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxNationalCode.Size = New System.Drawing.Size(113, 24)
        Me.UcTextBoxNationalCode.TabIndex = 20
        Me.UcTextBoxNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxNationalCode.UCBorder = False
        Me.UcTextBoxNationalCode.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxNationalCode.UCBorderCornerRedius = 0
        Me.UcTextBoxNationalCode.UCEnable = True
        Me.UcTextBoxNationalCode.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcTextBoxNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxNationalCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxNationalCode.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxNationalCode.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxNationalCode.UCMultiLine = False
        Me.UcTextBoxNationalCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxNationalCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxNationalCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxNationalCode.UCValue = ""
        '
        'UcNumberLicenseNo
        '
        Me.UcNumberLicenseNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberLicenseNo.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLicenseNo.Location = New System.Drawing.Point(12, 16)
        Me.UcNumberLicenseNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberLicenseNo.Name = "UcNumberLicenseNo"
        Me.UcNumberLicenseNo.Size = New System.Drawing.Size(186, 25)
        Me.UcNumberLicenseNo.TabIndex = 19
        Me.UcNumberLicenseNo.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberLicenseNo.UCAllowedMinNumber = CType(-9223372036854775, Long)
        Me.UcNumberLicenseNo.UCBackColor = System.Drawing.Color.White
        Me.UcNumberLicenseNo.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberLicenseNo.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberLicenseNo.UCBorder = True
        Me.UcNumberLicenseNo.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberLicenseNo.UCEnable = True
        Me.UcNumberLicenseNo.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberLicenseNo.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberLicenseNo.UCMultiLine = False
        Me.UcNumberLicenseNo.UCValue = CType(0, Long)
        '
        'UcPersianTextBoxNameFamily
        '
        Me.UcPersianTextBoxNameFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxNameFamily.Location = New System.Drawing.Point(727, 16)
        Me.UcPersianTextBoxNameFamily.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxNameFamily.Name = "UcPersianTextBoxNameFamily"
        Me.UcPersianTextBoxNameFamily.Size = New System.Drawing.Size(135, 24)
        Me.UcPersianTextBoxNameFamily.TabIndex = 17
        Me.UcPersianTextBoxNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNameFamily.UCBorder = True
        Me.UcPersianTextBoxNameFamily.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxNameFamily.UCEnable = True
        Me.UcPersianTextBoxNameFamily.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNameFamily.UCMultiLine = False
        Me.UcPersianTextBoxNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNameFamily.UCValue = ""
        '
        'UcPersianTextBoxFather
        '
        Me.UcPersianTextBoxFather.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxFather.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxFather.Location = New System.Drawing.Point(594, 16)
        Me.UcPersianTextBoxFather.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxFather.Name = "UcPersianTextBoxFather"
        Me.UcPersianTextBoxFather.Size = New System.Drawing.Size(75, 24)
        Me.UcPersianTextBoxFather.TabIndex = 16
        Me.UcPersianTextBoxFather.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxFather.UCBorder = True
        Me.UcPersianTextBoxFather.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxFather.UCEnable = True
        Me.UcPersianTextBoxFather.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxFather.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxFather.UCMultiLine = False
        Me.UcPersianTextBoxFather.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxFather.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxFather.UCValue = ""
        '
        'UcPersianTextBoxTel
        '
        Me.UcPersianTextBoxTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTel.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTel.Location = New System.Drawing.Point(259, 16)
        Me.UcPersianTextBoxTel.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTel.Name = "UcPersianTextBoxTel"
        Me.UcPersianTextBoxTel.Size = New System.Drawing.Size(121, 24)
        Me.UcPersianTextBoxTel.TabIndex = 14
        Me.UcPersianTextBoxTel.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTel.UCBorder = True
        Me.UcPersianTextBoxTel.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTel.UCEnable = True
        Me.UcPersianTextBoxTel.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTel.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTel.UCMultiLine = False
        Me.UcPersianTextBoxTel.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTel.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTel.UCValue = ""
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(388, 43)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(474, 24)
        Me.UcPersianTextBoxAddress.TabIndex = 7
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCBorder = True
        Me.UcPersianTextBoxAddress.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxAddress.UCEnable = True
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCMultiLine = False
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(863, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(42, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "آدرس :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(37, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "تلفن :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(543, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(45, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "کدملی :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(667, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "نام پدر :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(863, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "نام و نام خانوادگی :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "گواهینامه :"
        '
        'UCDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDriver"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(987, 101)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcPersianTextBoxDriverName As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UcPersianTextBoxNameFamily As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxFather As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxTel As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxAddress As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UcNumberLicenseNo As R2CoreGUI.UCNumber
    Friend WithEvents Label8 As Label
    Friend WithEvents UcNumberDrivernIdPerson As R2CoreGUI.UCNumber
    Friend WithEvents Label9 As Label
    Friend WithEvents UcTextBoxNationalCode As UCTextBox
    Friend WithEvents CButtonViewPrintUserShenasehPassword As CButtonLib.CButton
    Friend WithEvents CButtonSoftwareUserVerificationCodeInjection As CButtonLib.CButton
    Friend WithEvents CButtonSendSmsUserShenasehPassword As CButtonLib.CButton
    Friend WithEvents UcTextBoxDriverNationalCode As UCTextBox
    Friend WithEvents UcActivateUnActivateSMSOwner As UCActivateUnActivateSMSOwner
    Friend WithEvents CButtonSabt As CButtonLib.CButton
    Friend WithEvents CButtonDelete As CButtonLib.CButton
    Friend WithEvents CButtonNew As CButtonLib.CButton
End Class
