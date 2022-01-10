
Imports R2Core.DepartementDoreManagement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTerafficCardViewerEditor
    Inherits R2CoreGUI.UCGeneral
    'Inherits UserControl


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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxTel = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxMobile = New R2CoreGUI.UCPersianTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcCmbTerafficTempCardType = New R2CoreParkingSystem.UCCmbTerafficTempCardType()
        Me.UcCmbTerafficCardType = New R2CoreParkingSystem.UCCmbTerafficCardType()
        Me.UcPersianTextBoxNameFamily = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxAddress = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxTahvilg = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxCompany = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxSerial = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxPelak = New R2CoreGUI.UCPersianTextBox()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlActive = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.OpbActive1 = New System.Windows.Forms.RadioButton()
        Me.OpbActive2 = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PnlNoMoney = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.OpbNoMoney1 = New System.Windows.Forms.RadioButton()
        Me.OpbNoMoney2 = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblDateEdit = New System.Windows.Forms.Label()
        Me.LblDateSabt = New System.Windows.Forms.Label()
        Me.LblUserEdit = New System.Windows.Forms.Label()
        Me.LblUserSabt = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.PnlMain.SuspendLayout()
        Me.PnlActive.SuspendLayout()
        Me.PnlNoMoney.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxTel)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxMobile)
        Me.PnlMain.Controls.Add(Me.Label4)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.UcCmbTerafficTempCardType)
        Me.PnlMain.Controls.Add(Me.UcCmbTerafficCardType)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxNameFamily)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxAddress)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxTahvilg)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxCompany)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxSerial)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxPelak)
        Me.PnlMain.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.PnlActive)
        Me.PnlMain.Controls.Add(Me.PnlNoMoney)
        Me.PnlMain.Controls.Add(Me.LblDateEdit)
        Me.PnlMain.Controls.Add(Me.LblDateSabt)
        Me.PnlMain.Controls.Add(Me.LblUserEdit)
        Me.PnlMain.Controls.Add(Me.LblUserSabt)
        Me.PnlMain.Controls.Add(Me.Label16)
        Me.PnlMain.Controls.Add(Me.Label15)
        Me.PnlMain.Controls.Add(Me.Label14)
        Me.PnlMain.Controls.Add(Me.Label13)
        Me.PnlMain.Controls.Add(Me.Label12)
        Me.PnlMain.Controls.Add(Me.Label11)
        Me.PnlMain.Controls.Add(Me.Label10)
        Me.PnlMain.Controls.Add(Me.Label9)
        Me.PnlMain.Controls.Add(Me.Label8)
        Me.PnlMain.Controls.Add(Me.Label7)
        Me.PnlMain.Controls.Add(Me.Label6)
        Me.PnlMain.Controls.Add(Me.Label5)
        Me.PnlMain.Controls.Add(Me.Label3)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.UcMoneyWallet)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(798, 439)
        Me.PnlMain.TabIndex = 62
        '
        'UcPersianTextBoxTel
        '
        Me.UcPersianTextBoxTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTel.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTel.Location = New System.Drawing.Point(295, 299)
        Me.UcPersianTextBoxTel.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTel.Name = "UcPersianTextBoxTel"
        Me.UcPersianTextBoxTel.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxTel.TabIndex = 366
        Me.UcPersianTextBoxTel.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTel.UCBorder = True
        Me.UcPersianTextBoxTel.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTel.UCEnable = True
        Me.UcPersianTextBoxTel.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTel.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTel.UCMultiLine = False
        Me.UcPersianTextBoxTel.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTel.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTel.UCValue = "813ی48"
        '
        'UcPersianTextBoxMobile
        '
        Me.UcPersianTextBoxMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxMobile.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxMobile.Location = New System.Drawing.Point(296, 270)
        Me.UcPersianTextBoxMobile.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxMobile.Name = "UcPersianTextBoxMobile"
        Me.UcPersianTextBoxMobile.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxMobile.TabIndex = 365
        Me.UcPersianTextBoxMobile.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxMobile.UCBorder = True
        Me.UcPersianTextBoxMobile.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxMobile.UCEnable = True
        Me.UcPersianTextBoxMobile.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxMobile.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxMobile.UCMultiLine = False
        Me.UcPersianTextBoxMobile.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxMobile.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxMobile.UCValue = "813ی48"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(163, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(77, 29)
        Me.Label4.TabIndex = 364
        Me.Label4.Text = "هزینه کارت"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(163, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 363
        Me.Label1.Text = "نوع کارت"
        '
        'UcCmbTerafficTempCardType
        '
        Me.UcCmbTerafficTempCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficTempCardType.Location = New System.Drawing.Point(16, 258)
        Me.UcCmbTerafficTempCardType.Name = "UcCmbTerafficTempCardType"
        Me.UcCmbTerafficTempCardType.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCmbTerafficTempCardType.Size = New System.Drawing.Size(143, 39)
        Me.UcCmbTerafficTempCardType.TabIndex = 362
        '
        'UcCmbTerafficCardType
        '
        Me.UcCmbTerafficCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficCardType.Location = New System.Drawing.Point(16, 209)
        Me.UcCmbTerafficCardType.Name = "UcCmbTerafficCardType"
        Me.UcCmbTerafficCardType.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCmbTerafficCardType.Size = New System.Drawing.Size(143, 42)
        Me.UcCmbTerafficCardType.TabIndex = 361
        '
        'UcPersianTextBoxNameFamily
        '
        Me.UcPersianTextBoxNameFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxNameFamily.Location = New System.Drawing.Point(295, 361)
        Me.UcPersianTextBoxNameFamily.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxNameFamily.Name = "UcPersianTextBoxNameFamily"
        Me.UcPersianTextBoxNameFamily.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxNameFamily.TabIndex = 358
        Me.UcPersianTextBoxNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNameFamily.UCBorder = True
        Me.UcPersianTextBoxNameFamily.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxNameFamily.UCEnable = True
        Me.UcPersianTextBoxNameFamily.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNameFamily.UCMultiLine = False
        Me.UcPersianTextBoxNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNameFamily.UCValue = "813ی48"
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(16, 393)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(422, 27)
        Me.UcPersianTextBoxAddress.TabIndex = 357
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCBorder = True
        Me.UcPersianTextBoxAddress.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxAddress.UCEnable = True
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCMultiLine = False
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = "813ی48"
        '
        'UcPersianTextBoxTahvilg
        '
        Me.UcPersianTextBoxTahvilg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTahvilg.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTahvilg.Location = New System.Drawing.Point(295, 330)
        Me.UcPersianTextBoxTahvilg.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTahvilg.Name = "UcPersianTextBoxTahvilg"
        Me.UcPersianTextBoxTahvilg.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxTahvilg.TabIndex = 356
        Me.UcPersianTextBoxTahvilg.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTahvilg.UCBorder = True
        Me.UcPersianTextBoxTahvilg.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTahvilg.UCEnable = True
        Me.UcPersianTextBoxTahvilg.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTahvilg.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTahvilg.UCMultiLine = False
        Me.UcPersianTextBoxTahvilg.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTahvilg.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTahvilg.UCValue = "813ی48"
        '
        'UcPersianTextBoxCompany
        '
        Me.UcPersianTextBoxCompany.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxCompany.Location = New System.Drawing.Point(16, 144)
        Me.UcPersianTextBoxCompany.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxCompany.Name = "UcPersianTextBoxCompany"
        Me.UcPersianTextBoxCompany.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxCompany.TabIndex = 353
        Me.UcPersianTextBoxCompany.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxCompany.UCBorder = True
        Me.UcPersianTextBoxCompany.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxCompany.UCEnable = True
        Me.UcPersianTextBoxCompany.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxCompany.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxCompany.UCMultiLine = False
        Me.UcPersianTextBoxCompany.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxCompany.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxCompany.UCValue = "13"
        '
        'UcPersianTextBoxSerial
        '
        Me.UcPersianTextBoxSerial.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxSerial.Location = New System.Drawing.Point(16, 113)
        Me.UcPersianTextBoxSerial.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxSerial.Name = "UcPersianTextBoxSerial"
        Me.UcPersianTextBoxSerial.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxSerial.TabIndex = 352
        Me.UcPersianTextBoxSerial.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSerial.UCBorder = True
        Me.UcPersianTextBoxSerial.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxSerial.UCEnable = True
        Me.UcPersianTextBoxSerial.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxSerial.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSerial.UCMultiLine = False
        Me.UcPersianTextBoxSerial.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSerial.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSerial.UCValue = "13"
        '
        'UcPersianTextBoxPelak
        '
        Me.UcPersianTextBoxPelak.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxPelak.Location = New System.Drawing.Point(16, 83)
        Me.UcPersianTextBoxPelak.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxPelak.Name = "UcPersianTextBoxPelak"
        Me.UcPersianTextBoxPelak.Size = New System.Drawing.Size(143, 27)
        Me.UcPersianTextBoxPelak.TabIndex = 351
        Me.UcPersianTextBoxPelak.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxPelak.UCBorder = True
        Me.UcPersianTextBoxPelak.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxPelak.UCEnable = True
        Me.UcPersianTextBoxPelak.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxPelak.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxPelak.UCMultiLine = False
        Me.UcPersianTextBoxPelak.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxPelak.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxPelak.UCValue = "813ی48"
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(584, 66)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(197, 34)
        Me.UcrfidCardTextMaintainer.TabIndex = 349
        Me.UcrfidCardTextMaintainer.UCEnable = True
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(798, 52)
        Me.UcLabel1.TabIndex = 348
        Me.UcLabel1.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مشخصات کارت تردد"
        '
        'PnlActive
        '
        Me.PnlActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActive.Controls.Add(Me.Label19)
        Me.PnlActive.Controls.Add(Me.OpbActive1)
        Me.PnlActive.Controls.Add(Me.OpbActive2)
        Me.PnlActive.Controls.Add(Me.Label20)
        Me.PnlActive.Location = New System.Drawing.Point(338, 112)
        Me.PnlActive.Name = "PnlActive"
        Me.PnlActive.Size = New System.Drawing.Size(100, 25)
        Me.PnlActive.TabIndex = 93
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(29, 27)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "خیر"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpbActive1
        '
        Me.OpbActive1.Checked = True
        Me.OpbActive1.Location = New System.Drawing.Point(75, 2)
        Me.OpbActive1.Name = "OpbActive1"
        Me.OpbActive1.Size = New System.Drawing.Size(15, 24)
        Me.OpbActive1.TabIndex = 44
        Me.OpbActive1.TabStop = True
        Me.OpbActive1.Text = " "
        Me.OpbActive1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OpbActive1.UseVisualStyleBackColor = True
        '
        'OpbActive2
        '
        Me.OpbActive2.Location = New System.Drawing.Point(32, 2)
        Me.OpbActive2.Name = "OpbActive2"
        Me.OpbActive2.Size = New System.Drawing.Size(15, 24)
        Me.OpbActive2.TabIndex = 45
        Me.OpbActive2.Text = " "
        Me.OpbActive2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OpbActive2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(47, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(24, 27)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "بله"
        '
        'PnlNoMoney
        '
        Me.PnlNoMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlNoMoney.Controls.Add(Me.Label18)
        Me.PnlNoMoney.Controls.Add(Me.OpbNoMoney1)
        Me.PnlNoMoney.Controls.Add(Me.OpbNoMoney2)
        Me.PnlNoMoney.Controls.Add(Me.Label17)
        Me.PnlNoMoney.Location = New System.Drawing.Point(338, 85)
        Me.PnlNoMoney.Name = "PnlNoMoney"
        Me.PnlNoMoney.Size = New System.Drawing.Size(100, 25)
        Me.PnlNoMoney.TabIndex = 92
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(29, 27)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "خیر"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpbNoMoney1
        '
        Me.OpbNoMoney1.Checked = True
        Me.OpbNoMoney1.Location = New System.Drawing.Point(75, 2)
        Me.OpbNoMoney1.Name = "OpbNoMoney1"
        Me.OpbNoMoney1.Size = New System.Drawing.Size(15, 24)
        Me.OpbNoMoney1.TabIndex = 44
        Me.OpbNoMoney1.TabStop = True
        Me.OpbNoMoney1.Text = " "
        Me.OpbNoMoney1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OpbNoMoney1.UseVisualStyleBackColor = True
        '
        'OpbNoMoney2
        '
        Me.OpbNoMoney2.Location = New System.Drawing.Point(32, 2)
        Me.OpbNoMoney2.Name = "OpbNoMoney2"
        Me.OpbNoMoney2.Size = New System.Drawing.Size(15, 24)
        Me.OpbNoMoney2.TabIndex = 45
        Me.OpbNoMoney2.Text = " "
        Me.OpbNoMoney2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OpbNoMoney2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(47, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(24, 27)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "بله"
        '
        'LblDateEdit
        '
        Me.LblDateEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDateEdit.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDateEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDateEdit.Location = New System.Drawing.Point(345, 240)
        Me.LblDateEdit.Name = "LblDateEdit"
        Me.LblDateEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDateEdit.Size = New System.Drawing.Size(93, 27)
        Me.LblDateEdit.TabIndex = 82
        Me.LblDateEdit.Text = "1393/15/12"
        '
        'LblDateSabt
        '
        Me.LblDateSabt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDateSabt.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDateSabt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDateSabt.Location = New System.Drawing.Point(345, 209)
        Me.LblDateSabt.Name = "LblDateSabt"
        Me.LblDateSabt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblDateSabt.Size = New System.Drawing.Size(93, 27)
        Me.LblDateSabt.TabIndex = 81
        Me.LblDateSabt.Text = "1393/12/12"
        '
        'LblUserEdit
        '
        Me.LblUserEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUserEdit.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUserEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUserEdit.Location = New System.Drawing.Point(231, 176)
        Me.LblUserEdit.Name = "LblUserEdit"
        Me.LblUserEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserEdit.Size = New System.Drawing.Size(207, 27)
        Me.LblUserEdit.TabIndex = 80
        Me.LblUserEdit.Text = "مهدی لطیفی"
        '
        'LblUserSabt
        '
        Me.LblUserSabt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUserSabt.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUserSabt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUserSabt.Location = New System.Drawing.Point(231, 141)
        Me.LblUserSabt.Name = "LblUserSabt"
        Me.LblUserSabt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUserSabt.Size = New System.Drawing.Size(207, 27)
        Me.LblUserSabt.TabIndex = 79
        Me.LblUserSabt.Text = "مرتضی شاهمرادی"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(445, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(127, 29)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "آخرین تاریخ ویرایش"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(445, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(69, 29)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "تاریخ ثبت"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(445, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(87, 29)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "تحویل گیرنده"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(445, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(40, 29)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "تلفن"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(445, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(46, 29)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "آدرس"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(445, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(53, 29)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "موبایل"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("B Homa", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(445, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(189, 29)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "نام و نام خانوادگی صاحب کارت"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(163, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(49, 29)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "شرکت"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(445, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(43, 29)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "فعال"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(445, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(48, 29)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "رایگان"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(163, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(47, 29)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "سریال"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(163, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(39, 29)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "پلاک"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(445, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "کاربر ویرایش"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(445, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(66, 29)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "کاربر ثبت"
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(584, 106)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(197, 262)
        Me.UcMoneyWallet.TabIndex = 350
        '
        'UCTerafficCardViewerEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTerafficCardViewerEditor"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(804, 445)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.PnlActive.ResumeLayout(false)
        Me.PnlNoMoney.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlActive As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents OpbActive1 As System.Windows.Forms.RadioButton
    Friend WithEvents OpbActive2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PnlNoMoney As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents OpbNoMoney1 As System.Windows.Forms.RadioButton
    Friend WithEvents OpbNoMoney2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblDateEdit As System.Windows.Forms.Label
    Friend WithEvents LblDateSabt As System.Windows.Forms.Label
    Friend WithEvents LblUserEdit As System.Windows.Forms.Label
    Friend WithEvents LblUserSabt As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UcPersianTextBoxNameFamily As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxAddress As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxTahvilg As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxCompany As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxSerial As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxPelak As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcrfidCardTextMaintainer As R2CoreGUI.UCRFIDCardTextMaintainer
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcMoneyWallet As UCMoneyWallet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcCmbTerafficTempCardType As UCCmbTerafficTempCardType
    Friend WithEvents UcCmbTerafficCardType As UCCmbTerafficCardType
    Friend WithEvents UcPersianTextBoxTel As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxMobile As R2CoreGUI.UCPersianTextBox
End Class
