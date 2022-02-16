<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSoftwareUserManipulation
    Inherits UCSoftwareUser

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSoftwareUserManipulation))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CButtonUserShenasehPasswordSMS = New CButtonLib.CButton()
        Me.CButtonNewSoftwareUser = New CButtonLib.CButton()
        Me.CButtonSoftwareUserDeleting = New CButtonLib.CButton()
        Me.CButtonSoftwareUserRegistering = New CButtonLib.CButton()
        Me.UcPersianTextBoxSearchMobileNumber = New R2CoreGUI.UCPersianTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcNumberUserId = New R2CoreGUI.UCNumber()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UcPersianTextBoxSearchUserName = New R2CoreGUI.UCPersianTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcTextBoxUserPinCode = New R2CoreGUI.UCTextBox()
        Me.UcPersianTextBoxUserCreator = New R2CoreGUI.UCPersianTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UcPersianTextBoxShamsiDate = New R2CoreGUI.UCPersianTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkDeleted = New System.Windows.Forms.CheckBox()
        Me.ChkViewFlag = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UcPersianShamsiDateUserPasswordExpiration = New R2CoreGUI.UCPersianShamsiDate()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcPersianShamsiDateAPIKeyExpiration = New R2CoreGUI.UCPersianShamsiDate()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkUserStatus = New System.Windows.Forms.CheckBox()
        Me.ChkUserCanChargeMoneywallet = New System.Windows.Forms.CheckBox()
        Me.ChkUserActive = New System.Windows.Forms.CheckBox()
        Me.UcPersianTextBoxMobileNumber = New R2CoreGUI.UCPersianTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UcSearcherUserTypes = New R2CoreGUI.UCSearcherUserTypes()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UcPersianTextBoxUserName = New R2CoreGUI.UCPersianTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(971, 216)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(971, 216)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.CButtonUserShenasehPasswordSMS)
        Me.PnlInner.Controls.Add(Me.CButtonNewSoftwareUser)
        Me.PnlInner.Controls.Add(Me.CButtonSoftwareUserDeleting)
        Me.PnlInner.Controls.Add(Me.CButtonSoftwareUserRegistering)
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxSearchMobileNumber)
        Me.PnlInner.Controls.Add(Me.Label4)
        Me.PnlInner.Controls.Add(Me.UcNumberUserId)
        Me.PnlInner.Controls.Add(Me.Label3)
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxSearchUserName)
        Me.PnlInner.Controls.Add(Me.Label2)
        Me.PnlInner.Controls.Add(Me.Label1)
        Me.PnlInner.Controls.Add(Me.Panel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(967, 212)
        Me.PnlInner.TabIndex = 0
        '
        'CButtonUserShenasehPasswordSMS
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 0.4969136!, 1.0!}
        Me.CButtonUserShenasehPasswordSMS.ColorFillBlend = CBlendItems1
        Me.CButtonUserShenasehPasswordSMS.Corners.LowerRight = 10
        Me.CButtonUserShenasehPasswordSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonUserShenasehPasswordSMS.DesignerSelected = False
        Me.CButtonUserShenasehPasswordSMS.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonUserShenasehPasswordSMS.ForeColor = System.Drawing.Color.Black
        Me.CButtonUserShenasehPasswordSMS.ImageIndex = 0
        Me.CButtonUserShenasehPasswordSMS.Location = New System.Drawing.Point(27, 180)
        Me.CButtonUserShenasehPasswordSMS.Name = "CButtonUserShenasehPasswordSMS"
        Me.CButtonUserShenasehPasswordSMS.Size = New System.Drawing.Size(169, 22)
        Me.CButtonUserShenasehPasswordSMS.TabIndex = 27
        Me.CButtonUserShenasehPasswordSMS.Text = "بروز رسانی و ارسال رمز عبور کاربر"
        Me.CButtonUserShenasehPasswordSMS.TextShadowShow = False
        '
        'CButtonNewSoftwareUser
        '
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonNewSoftwareUser.ColorFillBlend = CBlendItems2
        Me.CButtonNewSoftwareUser.Corners.LowerRight = 10
        Me.CButtonNewSoftwareUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonNewSoftwareUser.DesignerSelected = False
        Me.CButtonNewSoftwareUser.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonNewSoftwareUser.ImageIndex = 0
        Me.CButtonNewSoftwareUser.Location = New System.Drawing.Point(192, 13)
        Me.CButtonNewSoftwareUser.Name = "CButtonNewSoftwareUser"
        Me.CButtonNewSoftwareUser.Size = New System.Drawing.Size(65, 22)
        Me.CButtonNewSoftwareUser.TabIndex = 26
        Me.CButtonNewSoftwareUser.Text = "کاربر جدید"
        '
        'CButtonSoftwareUserDeleting
        '
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSoftwareUserDeleting.ColorFillBlend = CBlendItems3
        Me.CButtonSoftwareUserDeleting.Corners.LowerRight = 10
        Me.CButtonSoftwareUserDeleting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSoftwareUserDeleting.DesignerSelected = False
        Me.CButtonSoftwareUserDeleting.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSoftwareUserDeleting.ImageIndex = 0
        Me.CButtonSoftwareUserDeleting.Location = New System.Drawing.Point(124, 13)
        Me.CButtonSoftwareUserDeleting.Name = "CButtonSoftwareUserDeleting"
        Me.CButtonSoftwareUserDeleting.Size = New System.Drawing.Size(62, 22)
        Me.CButtonSoftwareUserDeleting.TabIndex = 25
        Me.CButtonSoftwareUserDeleting.Text = "حذف کاربر"
        '
        'CButtonSoftwareUserRegistering
        '
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSoftwareUserRegistering.ColorFillBlend = CBlendItems4
        Me.CButtonSoftwareUserRegistering.Corners.LowerRight = 10
        Me.CButtonSoftwareUserRegistering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSoftwareUserRegistering.DesignerSelected = False
        Me.CButtonSoftwareUserRegistering.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSoftwareUserRegistering.ImageIndex = 0
        Me.CButtonSoftwareUserRegistering.Location = New System.Drawing.Point(23, 13)
        Me.CButtonSoftwareUserRegistering.Name = "CButtonSoftwareUserRegistering"
        Me.CButtonSoftwareUserRegistering.Size = New System.Drawing.Size(96, 22)
        Me.CButtonSoftwareUserRegistering.TabIndex = 24
        Me.CButtonSoftwareUserRegistering.Text = "ثبت مشخصات"
        '
        'UcPersianTextBoxSearchMobileNumber
        '
        Me.UcPersianTextBoxSearchMobileNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSearchMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxSearchMobileNumber.Location = New System.Drawing.Point(535, 11)
        Me.UcPersianTextBoxSearchMobileNumber.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxSearchMobileNumber.Name = "UcPersianTextBoxSearchMobileNumber"
        Me.UcPersianTextBoxSearchMobileNumber.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxSearchMobileNumber.TabIndex = 23
        Me.UcPersianTextBoxSearchMobileNumber.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSearchMobileNumber.UCBorder = True
        Me.UcPersianTextBoxSearchMobileNumber.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSearchMobileNumber.UCEnable = True
        Me.UcPersianTextBoxSearchMobileNumber.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxSearchMobileNumber.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSearchMobileNumber.UCMultiLine = False
        Me.UcPersianTextBoxSearchMobileNumber.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSearchMobileNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSearchMobileNumber.UCValue = ""
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(637, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "موبایل"
        '
        'UcNumberUserId
        '
        Me.UcNumberUserId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberUserId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberUserId.Location = New System.Drawing.Point(399, 11)
        Me.UcNumberUserId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberUserId.Name = "UcNumberUserId"
        Me.UcNumberUserId.Size = New System.Drawing.Size(77, 25)
        Me.UcNumberUserId.TabIndex = 21
        Me.UcNumberUserId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberUserId.UCAllowedMinNumber = CType(-9223372036854775, Long)
        Me.UcNumberUserId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberUserId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberUserId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberUserId.UCBorder = True
        Me.UcNumberUserId.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberUserId.UCEnable = False
        Me.UcNumberUserId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberUserId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberUserId.UCMultiLine = False
        Me.UcNumberUserId.UCValue = CType(0, Long)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(475, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "کد کاربر"
        '
        'UcPersianTextBoxSearchUserName
        '
        Me.UcPersianTextBoxSearchUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSearchUserName.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxSearchUserName.Location = New System.Drawing.Point(697, 12)
        Me.UcPersianTextBoxSearchUserName.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxSearchUserName.Name = "UcPersianTextBoxSearchUserName"
        Me.UcPersianTextBoxSearchUserName.Size = New System.Drawing.Size(135, 24)
        Me.UcPersianTextBoxSearchUserName.TabIndex = 3
        Me.UcPersianTextBoxSearchUserName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSearchUserName.UCBorder = True
        Me.UcPersianTextBoxSearchUserName.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSearchUserName.UCEnable = True
        Me.UcPersianTextBoxSearchUserName.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxSearchUserName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSearchUserName.UCMultiLine = False
        Me.UcPersianTextBoxSearchUserName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSearchUserName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSearchUserName.UCValue = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(832, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "نام کاربر"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(904, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کاربر"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcTextBoxUserPinCode)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxUserCreator)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxShamsiDate)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ChkDeleted)
        Me.Panel1.Controls.Add(Me.ChkViewFlag)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.UcPersianShamsiDateUserPasswordExpiration)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.UcPersianShamsiDateAPIKeyExpiration)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ChkUserStatus)
        Me.Panel1.Controls.Add(Me.ChkUserCanChargeMoneywallet)
        Me.Panel1.Controls.Add(Me.ChkUserActive)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxMobileNumber)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.UcSearcherUserTypes)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxUserName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 168)
        Me.Panel1.TabIndex = 0
        '
        'UcTextBoxUserPinCode
        '
        Me.UcTextBoxUserPinCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxUserPinCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxUserPinCode.Location = New System.Drawing.Point(164, 19)
        Me.UcTextBoxUserPinCode.Name = "UcTextBoxUserPinCode"
        Me.UcTextBoxUserPinCode.Size = New System.Drawing.Size(106, 24)
        Me.UcTextBoxUserPinCode.TabIndex = 41
        Me.UcTextBoxUserPinCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxUserPinCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxUserPinCode.UCBorder = True
        Me.UcTextBoxUserPinCode.UCBorderColor = System.Drawing.Color.Black
        Me.UcTextBoxUserPinCode.UCBorderCornerRedius = 6
        Me.UcTextBoxUserPinCode.UCEnable = True
        Me.UcTextBoxUserPinCode.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcTextBoxUserPinCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxUserPinCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxUserPinCode.UCMaxCharacterReached = CType(50, Short)
        Me.UcTextBoxUserPinCode.UCMaxNumber = CType(99999, Long)
        Me.UcTextBoxUserPinCode.UCMultiLine = False
        Me.UcTextBoxUserPinCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxUserPinCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxUserPinCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxUserPinCode.UCValue = ""
        '
        'UcPersianTextBoxUserCreator
        '
        Me.UcPersianTextBoxUserCreator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxUserCreator.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxUserCreator.Enabled = False
        Me.UcPersianTextBoxUserCreator.Location = New System.Drawing.Point(780, 130)
        Me.UcPersianTextBoxUserCreator.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxUserCreator.Name = "UcPersianTextBoxUserCreator"
        Me.UcPersianTextBoxUserCreator.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxUserCreator.TabIndex = 47
        Me.UcPersianTextBoxUserCreator.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxUserCreator.UCBorder = True
        Me.UcPersianTextBoxUserCreator.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxUserCreator.UCEnable = True
        Me.UcPersianTextBoxUserCreator.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxUserCreator.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxUserCreator.UCMultiLine = False
        Me.UcPersianTextBoxUserCreator.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxUserCreator.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxUserCreator.UCValue = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label12.Location = New System.Drawing.Point(883, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(52, 23)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "کاربر ثبت"
        '
        'UcPersianTextBoxShamsiDate
        '
        Me.UcPersianTextBoxShamsiDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxShamsiDate.Enabled = False
        Me.UcPersianTextBoxShamsiDate.Location = New System.Drawing.Point(597, 130)
        Me.UcPersianTextBoxShamsiDate.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxShamsiDate.Name = "UcPersianTextBoxShamsiDate"
        Me.UcPersianTextBoxShamsiDate.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxShamsiDate.TabIndex = 45
        Me.UcPersianTextBoxShamsiDate.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxShamsiDate.UCBorder = True
        Me.UcPersianTextBoxShamsiDate.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxShamsiDate.UCEnable = True
        Me.UcPersianTextBoxShamsiDate.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxShamsiDate.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxShamsiDate.UCMultiLine = False
        Me.UcPersianTextBoxShamsiDate.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxShamsiDate.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxShamsiDate.UCValue = ""
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label11.Location = New System.Drawing.Point(700, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(55, 23)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "تاریخ ثبت"
        '
        'ChkDeleted
        '
        Me.ChkDeleted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDeleted.AutoSize = True
        Me.ChkDeleted.Checked = True
        Me.ChkDeleted.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDeleted.Enabled = False
        Me.ChkDeleted.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkDeleted.Location = New System.Drawing.Point(809, 75)
        Me.ChkDeleted.Name = "ChkDeleted"
        Me.ChkDeleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkDeleted.Size = New System.Drawing.Size(129, 27)
        Me.ChkDeleted.TabIndex = 43
        Me.ChkDeleted.Text = "حذف شده/حذف نشده"
        Me.ChkDeleted.UseVisualStyleBackColor = True
        '
        'ChkViewFlag
        '
        Me.ChkViewFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkViewFlag.AutoSize = True
        Me.ChkViewFlag.Checked = True
        Me.ChkViewFlag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkViewFlag.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkViewFlag.Location = New System.Drawing.Point(399, 53)
        Me.ChkViewFlag.Name = "ChkViewFlag"
        Me.ChkViewFlag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkViewFlag.Size = New System.Drawing.Size(264, 27)
        Me.ChkViewFlag.TabIndex = 42
        Me.ChkViewFlag.Text = "قابل مشاهده در سیستم/غیرقابل مشاهده در سیستم"
        Me.ChkViewFlag.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(272, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 23)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "پین کد"
        '
        'UcPersianShamsiDateUserPasswordExpiration
        '
        Me.UcPersianShamsiDateUserPasswordExpiration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianShamsiDateUserPasswordExpiration.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDateUserPasswordExpiration.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDateUserPasswordExpiration.Location = New System.Drawing.Point(406, 95)
        Me.UcPersianShamsiDateUserPasswordExpiration.Name = "UcPersianShamsiDateUserPasswordExpiration"
        Me.UcPersianShamsiDateUserPasswordExpiration.Size = New System.Drawing.Size(145, 23)
        Me.UcPersianShamsiDateUserPasswordExpiration.TabIndex = 38
        Me.UcPersianShamsiDateUserPasswordExpiration.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(551, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "تاریخ انقضاء رمز عبور"
        '
        'UcPersianShamsiDateAPIKeyExpiration
        '
        Me.UcPersianShamsiDateAPIKeyExpiration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianShamsiDateAPIKeyExpiration.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDateAPIKeyExpiration.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDateAPIKeyExpiration.Location = New System.Drawing.Point(667, 95)
        Me.UcPersianShamsiDateAPIKeyExpiration.Name = "UcPersianShamsiDateAPIKeyExpiration"
        Me.UcPersianShamsiDateAPIKeyExpiration.Size = New System.Drawing.Size(145, 23)
        Me.UcPersianShamsiDateAPIKeyExpiration.TabIndex = 36
        Me.UcPersianShamsiDateAPIKeyExpiration.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(812, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "تاریخ انقضاء کلید خصوصی"
        '
        'ChkUserStatus
        '
        Me.ChkUserStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkUserStatus.AutoSize = True
        Me.ChkUserStatus.Enabled = False
        Me.ChkUserStatus.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkUserStatus.Location = New System.Drawing.Point(628, 75)
        Me.ChkUserStatus.Name = "ChkUserStatus"
        Me.ChkUserStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUserStatus.Size = New System.Drawing.Size(157, 27)
        Me.ChkUserStatus.TabIndex = 34
        Me.ChkUserStatus.Text = "ثبت نام شده/ثبت نام نشده"
        Me.ChkUserStatus.UseVisualStyleBackColor = True
        '
        'ChkUserCanChargeMoneywallet
        '
        Me.ChkUserCanChargeMoneywallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkUserCanChargeMoneywallet.AutoSize = True
        Me.ChkUserCanChargeMoneywallet.Checked = True
        Me.ChkUserCanChargeMoneywallet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUserCanChargeMoneywallet.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkUserCanChargeMoneywallet.Location = New System.Drawing.Point(705, 53)
        Me.ChkUserCanChargeMoneywallet.Name = "ChkUserCanChargeMoneywallet"
        Me.ChkUserCanChargeMoneywallet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUserCanChargeMoneywallet.Size = New System.Drawing.Size(117, 27)
        Me.ChkUserCanChargeMoneywallet.TabIndex = 33
        Me.ChkUserCanChargeMoneywallet.Text = "مجوز شارژ کیف پول"
        Me.ChkUserCanChargeMoneywallet.UseVisualStyleBackColor = True
        '
        'ChkUserActive
        '
        Me.ChkUserActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkUserActive.AutoSize = True
        Me.ChkUserActive.Checked = True
        Me.ChkUserActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUserActive.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkUserActive.Location = New System.Drawing.Point(842, 53)
        Me.ChkUserActive.Name = "ChkUserActive"
        Me.ChkUserActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUserActive.Size = New System.Drawing.Size(96, 27)
        Me.ChkUserActive.TabIndex = 32
        Me.ChkUserActive.Text = "فعال/غیرفعال"
        Me.ChkUserActive.UseVisualStyleBackColor = True
        '
        'UcPersianTextBoxMobileNumber
        '
        Me.UcPersianTextBoxMobileNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxMobileNumber.Location = New System.Drawing.Point(322, 19)
        Me.UcPersianTextBoxMobileNumber.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxMobileNumber.Name = "UcPersianTextBoxMobileNumber"
        Me.UcPersianTextBoxMobileNumber.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxMobileNumber.TabIndex = 31
        Me.UcPersianTextBoxMobileNumber.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxMobileNumber.UCBorder = True
        Me.UcPersianTextBoxMobileNumber.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxMobileNumber.UCEnable = True
        Me.UcPersianTextBoxMobileNumber.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxMobileNumber.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxMobileNumber.UCMultiLine = False
        Me.UcPersianTextBoxMobileNumber.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxMobileNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxMobileNumber.UCValue = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(424, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 23)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "موبایل"
        '
        'UcSearcherUserTypes
        '
        Me.UcSearcherUserTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherUserTypes.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherUserTypes.Location = New System.Drawing.Point(670, 16)
        Me.UcSearcherUserTypes.Name = "UcSearcherUserTypes"
        Me.UcSearcherUserTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherUserTypes.Size = New System.Drawing.Size(215, 31)
        Me.UcSearcherUserTypes.TabIndex = 29
        Me.UcSearcherUserTypes.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherUserTypes.UCFontList = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherUserTypes.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherUserTypes.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherUserTypes.UCIcon = CType(resources.GetObject("UcSearcherUserTypes.UCIcon"), System.Drawing.Image)
        Me.UcSearcherUserTypes.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherUserTypes.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherUserTypes.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.Simple
        Me.UcSearcherUserTypes.UCShowDomainIcon = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(890, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "نوع کاربر"
        '
        'UcPersianTextBoxUserName
        '
        Me.UcPersianTextBoxUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxUserName.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxUserName.Location = New System.Drawing.Point(477, 19)
        Me.UcPersianTextBoxUserName.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxUserName.Name = "UcPersianTextBoxUserName"
        Me.UcPersianTextBoxUserName.Size = New System.Drawing.Size(135, 24)
        Me.UcPersianTextBoxUserName.TabIndex = 27
        Me.UcPersianTextBoxUserName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxUserName.UCBorder = True
        Me.UcPersianTextBoxUserName.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxUserName.UCEnable = True
        Me.UcPersianTextBoxUserName.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxUserName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxUserName.UCMultiLine = False
        Me.UcPersianTextBoxUserName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxUserName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxUserName.UCValue = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(611, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "نام کاربر"
        '
        'UCSoftwareUserManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCSoftwareUserManipulation"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(981, 226)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlOutter.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlInner.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlOutter As Panel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UcPersianTextBoxSearchUserName As UCPersianTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UcNumberUserId As UCNumber
    Friend WithEvents UcPersianTextBoxSearchMobileNumber As UCPersianTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CButtonNewSoftwareUser As CButtonLib.CButton
    Friend WithEvents CButtonSoftwareUserDeleting As CButtonLib.CButton
    Friend WithEvents CButtonSoftwareUserRegistering As CButtonLib.CButton
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkUserStatus As CheckBox
    Friend WithEvents ChkUserCanChargeMoneywallet As CheckBox
    Friend WithEvents ChkUserActive As CheckBox
    Friend WithEvents UcPersianTextBoxMobileNumber As UCPersianTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UcSearcherUserTypes As UCSearcherUserTypes
    Friend WithEvents Label6 As Label
    Friend WithEvents UcPersianTextBoxUserName As UCPersianTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UcPersianTextBoxUserCreator As UCPersianTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents UcPersianTextBoxShamsiDate As UCPersianTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ChkDeleted As CheckBox
    Friend WithEvents ChkViewFlag As CheckBox
    Friend WithEvents UcTextBoxUserPinCode As UCTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UcPersianShamsiDateUserPasswordExpiration As UCPersianShamsiDate
    Friend WithEvents Label9 As Label
    Friend WithEvents UcPersianShamsiDateAPIKeyExpiration As UCPersianShamsiDate
    Friend WithEvents CButtonUserShenasehPasswordSMS As CButtonLib.CButton
End Class
