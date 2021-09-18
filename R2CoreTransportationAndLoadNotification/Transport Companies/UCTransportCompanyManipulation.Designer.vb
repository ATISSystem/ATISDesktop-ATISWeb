<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTransportCompanyManipulation
    Inherits UCTransportCompany

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCTransportCompanyManipulation))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CButtonViewUserPassword = New CButtonLib.CButton()
        Me.CButtonSendSMSUserPassword = New CButtonLib.CButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CButtonNew = New CButtonLib.CButton()
        Me.CButtonDelete = New CButtonLib.CButton()
        Me.CButtonEdit = New CButtonLib.CButton()
        Me.CButtonRegister = New CButtonLib.CButton()
        Me.UcNumberTCId = New R2CoreGUI.UCNumber()
        Me.UcSearcherTransportCompanies = New R2CoreTransportationAndLoadNotification.UCSearcherTransportCompanies()
        Me.Panel1 = New UI.Glass.Panel()
        Me.UcLabelSherkatHamloNaghl1 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.UcPersianTextBoxTCOrganizationCode = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabelSherkatHamloNaghl2 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.UcPersianTextBoxTCTitle = New R2CoreGUI.UCPersianTextBox()
        Me.UcLabelMaghsadeBar1 = New R2CoreTransportationAndLoadNotification.UCLabelMaghsadeBar()
        Me.UcPersianTextBoxTCTel = New R2CoreGUI.UCPersianTextBox()
        Me.ChkViewFlag = New System.Windows.Forms.CheckBox()
        Me.UcLabelSherkatHamloNaghl3 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.UcPersianTextBoxManagerNameFamily = New R2CoreGUI.UCPersianTextBox()
        Me.ChkActive = New System.Windows.Forms.CheckBox()
        Me.UcLabelSherkatHamloNaghl4 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.UcPersianTextBoxManagerMobileNumber = New R2CoreGUI.UCPersianTextBox()
        Me.UcSearcherCities = New R2CoreTransportationAndLoadNotification.UCSearcherLoadTargets()
        Me.UcLabelSherkatHamloNaghl5 = New R2CoreTransportationAndLoadNotification.UCLabelSherkatHamloNaghl()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(814, 159)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOutter.Size = New System.Drawing.Size(814, 159)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.CButtonViewUserPassword)
        Me.PnlInner.Controls.Add(Me.CButtonSendSMSUserPassword)
        Me.PnlInner.Controls.Add(Me.Label2)
        Me.PnlInner.Controls.Add(Me.Label1)
        Me.PnlInner.Controls.Add(Me.CButtonNew)
        Me.PnlInner.Controls.Add(Me.CButtonDelete)
        Me.PnlInner.Controls.Add(Me.CButtonEdit)
        Me.PnlInner.Controls.Add(Me.CButtonRegister)
        Me.PnlInner.Controls.Add(Me.UcNumberTCId)
        Me.PnlInner.Controls.Add(Me.UcSearcherTransportCompanies)
        Me.PnlInner.Controls.Add(Me.Panel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(3, 3)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(808, 153)
        Me.PnlInner.TabIndex = 0
        '
        'CButtonViewUserPassword
        '
        Me.CButtonViewUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonViewUserPassword.ColorFillBlend = CBlendItems1
        Me.CButtonViewUserPassword.Corners.LowerRight = 10
        Me.CButtonViewUserPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonViewUserPassword.DesignerSelected = False
        Me.CButtonViewUserPassword.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonViewUserPassword.ImageIndex = 0
        Me.CButtonViewUserPassword.Location = New System.Drawing.Point(216, 123)
        Me.CButtonViewUserPassword.Name = "CButtonViewUserPassword"
        Me.CButtonViewUserPassword.Size = New System.Drawing.Size(153, 22)
        Me.CButtonViewUserPassword.TabIndex = 30
        Me.CButtonViewUserPassword.Text = "مشاهده شناسه و رمز عبور"
        '
        'CButtonSendSMSUserPassword
        '
        Me.CButtonSendSMSUserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonSendSMSUserPassword.ColorFillBlend = CBlendItems2
        Me.CButtonSendSMSUserPassword.Corners.LowerRight = 10
        Me.CButtonSendSMSUserPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonSendSMSUserPassword.DesignerSelected = False
        Me.CButtonSendSMSUserPassword.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonSendSMSUserPassword.ImageIndex = 0
        Me.CButtonSendSMSUserPassword.Location = New System.Drawing.Point(18, 123)
        Me.CButtonSendSMSUserPassword.Name = "CButtonSendSMSUserPassword"
        Me.CButtonSendSMSUserPassword.Size = New System.Drawing.Size(193, 22)
        Me.CButtonSendSMSUserPassword.TabIndex = 26
        Me.CButtonSendSMSUserPassword.Text = "ارسال اس ام اس شناسه و رمز عبور"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(327, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "کد شرکت حمل و نقل"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(674, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "شرکت حمل و نقل"
        '
        'CButtonNew
        '
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.DarkGray, System.Drawing.Color.Black, System.Drawing.Color.DimGray}
        CBlendItems3.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonNew.ColorFillBlend = CBlendItems3
        Me.CButtonNew.Corners.LowerRight = 10
        Me.CButtonNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonNew.DesignerSelected = False
        Me.CButtonNew.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonNew.ImageIndex = 0
        Me.CButtonNew.Location = New System.Drawing.Point(202, 12)
        Me.CButtonNew.Name = "CButtonNew"
        Me.CButtonNew.Size = New System.Drawing.Size(48, 22)
        Me.CButtonNew.TabIndex = 35
        Me.CButtonNew.Text = "جدید"
        '
        'CButtonDelete
        '
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.Maroon, System.Drawing.Color.Red, System.Drawing.Color.OrangeRed}
        CBlendItems4.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonDelete.ColorFillBlend = CBlendItems4
        Me.CButtonDelete.Corners.LowerRight = 10
        Me.CButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonDelete.DesignerSelected = False
        Me.CButtonDelete.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonDelete.ImageIndex = 0
        Me.CButtonDelete.Location = New System.Drawing.Point(151, 12)
        Me.CButtonDelete.Name = "CButtonDelete"
        Me.CButtonDelete.Size = New System.Drawing.Size(48, 22)
        Me.CButtonDelete.TabIndex = 34
        Me.CButtonDelete.Text = "حذف"
        '
        'CButtonEdit
        '
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.DarkSlateBlue, System.Drawing.Color.DarkBlue, System.Drawing.Color.MediumBlue}
        CBlendItems5.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonEdit.ColorFillBlend = CBlendItems5
        Me.CButtonEdit.Corners.LowerRight = 10
        Me.CButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonEdit.DesignerSelected = False
        Me.CButtonEdit.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonEdit.ImageIndex = 0
        Me.CButtonEdit.Location = New System.Drawing.Point(69, 12)
        Me.CButtonEdit.Name = "CButtonEdit"
        Me.CButtonEdit.Size = New System.Drawing.Size(79, 22)
        Me.CButtonEdit.TabIndex = 33
        Me.CButtonEdit.Text = "ویرایش"
        '
        'CButtonRegister
        '
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.ForestGreen, System.Drawing.Color.DarkGreen, System.Drawing.Color.Olive}
        CBlendItems6.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonRegister.ColorFillBlend = CBlendItems6
        Me.CButtonRegister.Corners.LowerRight = 10
        Me.CButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonRegister.DesignerSelected = False
        Me.CButtonRegister.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonRegister.ImageIndex = 0
        Me.CButtonRegister.Location = New System.Drawing.Point(18, 12)
        Me.CButtonRegister.Name = "CButtonRegister"
        Me.CButtonRegister.Size = New System.Drawing.Size(48, 22)
        Me.CButtonRegister.TabIndex = 32
        Me.CButtonRegister.Text = "ثبت"
        '
        'UcNumberTCId
        '
        Me.UcNumberTCId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcNumberTCId.BackColor = System.Drawing.Color.Transparent
        Me.UcNumberTCId.Font = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTCId.Location = New System.Drawing.Point(256, 13)
        Me.UcNumberTCId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberTCId.Name = "UcNumberTCId"
        Me.UcNumberTCId.Size = New System.Drawing.Size(65, 19)
        Me.UcNumberTCId.TabIndex = 5
        Me.UcNumberTCId.UCAllowedMaxNumber = CType(9223372036854775807, Long)
        Me.UcNumberTCId.UCAllowedMinNumber = CType(-922337203685477580, Long)
        Me.UcNumberTCId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberTCId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberTCId.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberTCId.UCBorder = True
        Me.UcNumberTCId.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberTCId.UCEnable = False
        Me.UcNumberTCId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcNumberTCId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberTCId.UCMultiLine = False
        Me.UcNumberTCId.UCValue = CType(0, Long)
        '
        'UcSearcherTransportCompanies
        '
        Me.UcSearcherTransportCompanies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcSearcherTransportCompanies.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherTransportCompanies.Location = New System.Drawing.Point(469, 7)
        Me.UcSearcherTransportCompanies.Name = "UcSearcherTransportCompanies"
        Me.UcSearcherTransportCompanies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherTransportCompanies.Size = New System.Drawing.Size(203, 31)
        Me.UcSearcherTransportCompanies.TabIndex = 3
        Me.UcSearcherTransportCompanies.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherTransportCompanies.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherTransportCompanies.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherTransportCompanies.UCIcon = CType(resources.GetObject("UcSearcherTransportCompanies.UCIcon"), System.Drawing.Image)
        Me.UcSearcherTransportCompanies.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherTransportCompanies.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherTransportCompanies.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherTransportCompanies.UCShowDomainIcon = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.UcLabelSherkatHamloNaghl1)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxTCOrganizationCode)
        Me.Panel1.Controls.Add(Me.UcLabelSherkatHamloNaghl2)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxTCTitle)
        Me.Panel1.Controls.Add(Me.UcLabelMaghsadeBar1)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxTCTel)
        Me.Panel1.Controls.Add(Me.ChkViewFlag)
        Me.Panel1.Controls.Add(Me.UcLabelSherkatHamloNaghl3)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxManagerNameFamily)
        Me.Panel1.Controls.Add(Me.ChkActive)
        Me.Panel1.Controls.Add(Me.UcLabelSherkatHamloNaghl4)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxManagerMobileNumber)
        Me.Panel1.Controls.Add(Me.UcSearcherCities)
        Me.Panel1.Controls.Add(Me.UcLabelSherkatHamloNaghl5)
        Me.Panel1.GlassColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.MouseReflection = True
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Opacity = 25
        Me.Panel1.Radius = 5.0!
        Me.Panel1.Size = New System.Drawing.Size(802, 116)
        Me.Panel1.TabIndex = 31
        '
        'UcLabelSherkatHamloNaghl1
        '
        Me.UcLabelSherkatHamloNaghl1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1.Location = New System.Drawing.Point(698, 18)
        Me.UcLabelSherkatHamloNaghl1.Name = "UcLabelSherkatHamloNaghl1"
        Me.UcLabelSherkatHamloNaghl1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl1.Size = New System.Drawing.Size(97, 33)
        Me.UcLabelSherkatHamloNaghl1.TabIndex = 17
        Me.UcLabelSherkatHamloNaghl1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl1.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl1.UCValue = "شرکت حمل و نقل"
        '
        'UcPersianTextBoxTCOrganizationCode
        '
        Me.UcPersianTextBoxTCOrganizationCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTCOrganizationCode.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTCOrganizationCode.Location = New System.Drawing.Point(490, 55)
        Me.UcPersianTextBoxTCOrganizationCode.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTCOrganizationCode.Name = "UcPersianTextBoxTCOrganizationCode"
        Me.UcPersianTextBoxTCOrganizationCode.Size = New System.Drawing.Size(91, 28)
        Me.UcPersianTextBoxTCOrganizationCode.TabIndex = 18
        Me.UcPersianTextBoxTCOrganizationCode.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTCOrganizationCode.UCBorder = True
        Me.UcPersianTextBoxTCOrganizationCode.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTCOrganizationCode.UCEnable = True
        Me.UcPersianTextBoxTCOrganizationCode.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTCOrganizationCode.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTCOrganizationCode.UCMultiLine = False
        Me.UcPersianTextBoxTCOrganizationCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTCOrganizationCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTCOrganizationCode.UCValue = ""
        '
        'UcLabelSherkatHamloNaghl2
        '
        Me.UcLabelSherkatHamloNaghl2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl2.Location = New System.Drawing.Point(579, 51)
        Me.UcLabelSherkatHamloNaghl2.Name = "UcLabelSherkatHamloNaghl2"
        Me.UcLabelSherkatHamloNaghl2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl2.Size = New System.Drawing.Size(63, 33)
        Me.UcLabelSherkatHamloNaghl2.TabIndex = 19
        Me.UcLabelSherkatHamloNaghl2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl2.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl2.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl2.UCValue = "کد سازمانی"
        '
        'UcPersianTextBoxTCTitle
        '
        Me.UcPersianTextBoxTCTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTCTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTCTitle.Location = New System.Drawing.Point(482, 22)
        Me.UcPersianTextBoxTCTitle.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTCTitle.Name = "UcPersianTextBoxTCTitle"
        Me.UcPersianTextBoxTCTitle.Size = New System.Drawing.Size(212, 28)
        Me.UcPersianTextBoxTCTitle.TabIndex = 16
        Me.UcPersianTextBoxTCTitle.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTCTitle.UCBorder = True
        Me.UcPersianTextBoxTCTitle.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTCTitle.UCEnable = True
        Me.UcPersianTextBoxTCTitle.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTCTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTCTitle.UCMultiLine = False
        Me.UcPersianTextBoxTCTitle.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTCTitle.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTCTitle.UCValue = ""
        '
        'UcLabelMaghsadeBar1
        '
        Me.UcLabelMaghsadeBar1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelMaghsadeBar1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1.Location = New System.Drawing.Point(380, 17)
        Me.UcLabelMaghsadeBar1.Name = "UcLabelMaghsadeBar1"
        Me.UcLabelMaghsadeBar1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMaghsadeBar1.Size = New System.Drawing.Size(90, 36)
        Me.UcLabelMaghsadeBar1.TabIndex = 20
        Me.UcLabelMaghsadeBar1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelMaghsadeBar1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelMaghsadeBar1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelMaghsadeBar1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelMaghsadeBar1.UCValue = "شهر محل استقرار"
        '
        'UcPersianTextBoxTCTel
        '
        Me.UcPersianTextBoxTCTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTCTel.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTCTel.Location = New System.Drawing.Point(648, 55)
        Me.UcPersianTextBoxTCTel.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTCTel.Name = "UcPersianTextBoxTCTel"
        Me.UcPersianTextBoxTCTel.Size = New System.Drawing.Size(111, 28)
        Me.UcPersianTextBoxTCTel.TabIndex = 22
        Me.UcPersianTextBoxTCTel.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTCTel.UCBorder = True
        Me.UcPersianTextBoxTCTel.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTCTel.UCEnable = True
        Me.UcPersianTextBoxTCTel.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTCTel.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTCTel.UCMultiLine = False
        Me.UcPersianTextBoxTCTel.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTCTel.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTCTel.UCValue = ""
        '
        'ChkViewFlag
        '
        Me.ChkViewFlag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkViewFlag.AutoSize = True
        Me.ChkViewFlag.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkViewFlag.Location = New System.Drawing.Point(616, 87)
        Me.ChkViewFlag.Name = "ChkViewFlag"
        Me.ChkViewFlag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkViewFlag.Size = New System.Drawing.Size(169, 25)
        Me.ChkViewFlag.TabIndex = 29
        Me.ChkViewFlag.Text = "قابل مشاهده / غیرقابل مشاهده"
        Me.ChkViewFlag.UseVisualStyleBackColor = True
        '
        'UcLabelSherkatHamloNaghl3
        '
        Me.UcLabelSherkatHamloNaghl3._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl3._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl3.Location = New System.Drawing.Point(760, 51)
        Me.UcLabelSherkatHamloNaghl3.Name = "UcLabelSherkatHamloNaghl3"
        Me.UcLabelSherkatHamloNaghl3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl3.Size = New System.Drawing.Size(41, 33)
        Me.UcLabelSherkatHamloNaghl3.TabIndex = 23
        Me.UcLabelSherkatHamloNaghl3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl3.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl3.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl3.UCValue = "تلفن"
        '
        'UcPersianTextBoxManagerNameFamily
        '
        Me.UcPersianTextBoxManagerNameFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxManagerNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxManagerNameFamily.Location = New System.Drawing.Point(243, 55)
        Me.UcPersianTextBoxManagerNameFamily.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxManagerNameFamily.Name = "UcPersianTextBoxManagerNameFamily"
        Me.UcPersianTextBoxManagerNameFamily.Size = New System.Drawing.Size(153, 28)
        Me.UcPersianTextBoxManagerNameFamily.TabIndex = 24
        Me.UcPersianTextBoxManagerNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxManagerNameFamily.UCBorder = True
        Me.UcPersianTextBoxManagerNameFamily.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxManagerNameFamily.UCEnable = True
        Me.UcPersianTextBoxManagerNameFamily.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxManagerNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxManagerNameFamily.UCMultiLine = False
        Me.UcPersianTextBoxManagerNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxManagerNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxManagerNameFamily.UCValue = ""
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkActive.Location = New System.Drawing.Point(12, 22)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActive.Size = New System.Drawing.Size(103, 28)
        Me.ChkActive.TabIndex = 28
        Me.ChkActive.Text = "فعال/ غیرفعال"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'UcLabelSherkatHamloNaghl4
        '
        Me.UcLabelSherkatHamloNaghl4._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl4._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl4.Location = New System.Drawing.Point(402, 51)
        Me.UcLabelSherkatHamloNaghl4.Name = "UcLabelSherkatHamloNaghl4"
        Me.UcLabelSherkatHamloNaghl4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl4.Size = New System.Drawing.Size(76, 33)
        Me.UcLabelSherkatHamloNaghl4.TabIndex = 25
        Me.UcLabelSherkatHamloNaghl4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl4.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl4.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl4.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl4.UCValue = "نام مدیرعامل"
        '
        'UcPersianTextBoxManagerMobileNumber
        '
        Me.UcPersianTextBoxManagerMobileNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxManagerMobileNumber.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxManagerMobileNumber.Location = New System.Drawing.Point(7, 55)
        Me.UcPersianTextBoxManagerMobileNumber.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxManagerMobileNumber.Name = "UcPersianTextBoxManagerMobileNumber"
        Me.UcPersianTextBoxManagerMobileNumber.Size = New System.Drawing.Size(102, 28)
        Me.UcPersianTextBoxManagerMobileNumber.TabIndex = 26
        Me.UcPersianTextBoxManagerMobileNumber.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxManagerMobileNumber.UCBorder = True
        Me.UcPersianTextBoxManagerMobileNumber.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxManagerMobileNumber.UCEnable = True
        Me.UcPersianTextBoxManagerMobileNumber.UCFont = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxManagerMobileNumber.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxManagerMobileNumber.UCMultiLine = False
        Me.UcPersianTextBoxManagerMobileNumber.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxManagerMobileNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxManagerMobileNumber.UCValue = ""
        '
        'UcSearcherCities
        '
        Me.UcSearcherCities.BackColor = System.Drawing.Color.Transparent
        Me.UcSearcherCities.Location = New System.Drawing.Point(142, 20)
        Me.UcSearcherCities.Name = "UcSearcherCities"
        Me.UcSearcherCities.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcSearcherCities.Size = New System.Drawing.Size(237, 31)
        Me.UcSearcherCities.TabIndex = 21
        Me.UcSearcherCities.UCBackColor = System.Drawing.Color.White
        Me.UcSearcherCities.UCFontList = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherCities.UCFontSearch = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcSearcherCities.UCForeColor = System.Drawing.Color.Black
        Me.UcSearcherCities.UCIcon = Nothing
        Me.UcSearcherCities.UCMaximizeHight = CType(120, Long)
        Me.UcSearcherCities.UCMinimizeHight = CType(31, Long)
        Me.UcSearcherCities.UCMode = R2CoreGUI.UCSearcherAdvance.UCModeType.DropDown
        Me.UcSearcherCities.UCShowDomainIcon = False
        '
        'UcLabelSherkatHamloNaghl5
        '
        Me.UcLabelSherkatHamloNaghl5._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl5._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSherkatHamloNaghl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelSherkatHamloNaghl5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl5.Location = New System.Drawing.Point(115, 51)
        Me.UcLabelSherkatHamloNaghl5.Name = "UcLabelSherkatHamloNaghl5"
        Me.UcLabelSherkatHamloNaghl5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSherkatHamloNaghl5.Size = New System.Drawing.Size(131, 33)
        Me.UcLabelSherkatHamloNaghl5.TabIndex = 27
        Me.UcLabelSherkatHamloNaghl5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSherkatHamloNaghl5.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelSherkatHamloNaghl5.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelSherkatHamloNaghl5.UCTextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UcLabelSherkatHamloNaghl5.UCValue = "شماره موبایل مدیر عامل"
        '
        'UCTransportCompanyManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTransportCompanyManipulation"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(824, 169)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlOutter.ResumeLayout(False)
        Me.PnlInner.ResumeLayout(False)
        Me.PnlInner.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents UcSearcherTransportCompanies As UCSearcherTransportCompanies
    Friend WithEvents UcNumberTCId As R2CoreGUI.UCNumber
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents UcPersianTextBoxTCTitle As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelSherkatHamloNaghl2 As UCLabelSherkatHamloNaghl
    Friend WithEvents UcPersianTextBoxTCOrganizationCode As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelSherkatHamloNaghl1 As UCLabelSherkatHamloNaghl
    Friend WithEvents CButtonViewUserPassword As CButtonLib.CButton
    Friend WithEvents CButtonSendSMSUserPassword As CButtonLib.CButton
    Friend WithEvents ChkViewFlag As Windows.Forms.CheckBox
    Friend WithEvents ChkActive As Windows.Forms.CheckBox
    Friend WithEvents UcLabelSherkatHamloNaghl5 As UCLabelSherkatHamloNaghl
    Friend WithEvents UcPersianTextBoxManagerMobileNumber As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelSherkatHamloNaghl4 As UCLabelSherkatHamloNaghl
    Friend WithEvents UcPersianTextBoxManagerNameFamily As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcLabelSherkatHamloNaghl3 As UCLabelSherkatHamloNaghl
    Friend WithEvents UcPersianTextBoxTCTel As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcSearcherCities As UCSearcherLoadTargets
    Friend WithEvents UcLabelMaghsadeBar1 As UCLabelMaghsadeBar
    Friend WithEvents Panel1 As UI.Glass.Panel
    Friend WithEvents CButtonNew As CButtonLib.CButton
    Friend WithEvents CButtonDelete As CButtonLib.CButton
    Friend WithEvents CButtonEdit As CButtonLib.CButton
    Friend WithEvents CButtonRegister As CButtonLib.CButton
End Class
