
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcNumberDrivernIdPerson = New R2CoreGUI.UCNumber()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcNumberDriverNationalCode = New R2CoreGUI.UCNumber()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.UcButtonDel = New R2CoreGUI.UCButton()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.UcPersianTextBoxDriverName = New R2CoreGUI.UCPersianTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcTextBoxNationalCode = New R2CoreGUI.UCTextBox()
        Me.UcNumberLicenseNo = New R2CoreGUI.UCNumber()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcPersianTextBoxNameFamily = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxFather = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxTel = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxAddress = New R2CoreGUI.UCPersianTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcNumberDrivernIdPerson)
        Me.PnlMain.Controls.Add(Me.Label9)
        Me.PnlMain.Controls.Add(Me.UcNumberDriverNationalCode)
        Me.PnlMain.Controls.Add(Me.UcButtonNew)
        Me.PnlMain.Controls.Add(Me.UcButtonDel)
        Me.PnlMain.Controls.Add(Me.UcButtonSabt)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxDriverName)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(813, 94)
        Me.PnlMain.TabIndex = 0
        '
        'UcNumberDrivernIdPerson
        '
        Me.UcNumberDrivernIdPerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberDrivernIdPerson.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberDrivernIdPerson.Location = New System.Drawing.Point(299, 5)
        Me.UcNumberDrivernIdPerson.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberDrivernIdPerson.Name = "UcNumberDrivernIdPerson"
        Me.UcNumberDrivernIdPerson.Size = New System.Drawing.Size(77, 25)
        Me.UcNumberDrivernIdPerson.TabIndex = 20
        Me.UcNumberDrivernIdPerson.UCAllowedMaxNumber = CType(9223372036854775807,Long)
        Me.UcNumberDrivernIdPerson.UCAllowedMinNumber = CType(-9223372036854775,Long)
        Me.UcNumberDrivernIdPerson.UCBackColor = System.Drawing.Color.White
        Me.UcNumberDrivernIdPerson.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberDrivernIdPerson.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberDrivernIdPerson.UCBorder = true
        Me.UcNumberDrivernIdPerson.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberDrivernIdPerson.UCEnable = false
        Me.UcNumberDrivernIdPerson.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberDrivernIdPerson.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberDrivernIdPerson.UCMultiLine = false
        Me.UcNumberDrivernIdPerson.UCValue = CType(0,Long)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(380, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "کد"
        '
        'UcNumberDriverNationalCode
        '
        Me.UcNumberDriverNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberDriverNationalCode.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberDriverNationalCode.Location = New System.Drawing.Point(411, 5)
        Me.UcNumberDriverNationalCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberDriverNationalCode.Name = "UcNumberDriverNationalCode"
        Me.UcNumberDriverNationalCode.Size = New System.Drawing.Size(90, 25)
        Me.UcNumberDriverNationalCode.TabIndex = 18
        Me.UcNumberDriverNationalCode.UCAllowedMaxNumber = CType(9223372036854775807,Long)
        Me.UcNumberDriverNationalCode.UCAllowedMinNumber = CType(-922337203685477,Long)
        Me.UcNumberDriverNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcNumberDriverNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberDriverNationalCode.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberDriverNationalCode.UCBorder = true
        Me.UcNumberDriverNationalCode.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumberDriverNationalCode.UCEnable = true
        Me.UcNumberDriverNationalCode.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberDriverNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberDriverNationalCode.UCMultiLine = false
        Me.UcNumberDriverNationalCode.UCValue = CType(0,Long)
        '
        'UcButtonNew
        '
        Me.UcButtonNew.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonNew.Location = New System.Drawing.Point(172, 0)
        Me.UcButtonNew.Name = "UcButtonNew"
        Me.UcButtonNew.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonNew.Size = New System.Drawing.Size(84, 32)
        Me.UcButtonNew.TabIndex = 6
        Me.UcButtonNew.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonNew.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonNew.UCEnable = true
        Me.UcButtonNew.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonNew.UCForeColor = System.Drawing.Color.White
        Me.UcButtonNew.UCValue = "جدید"
        '
        'UcButtonDel
        '
        Me.UcButtonDel.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDel.Location = New System.Drawing.Point(109, 0)
        Me.UcButtonDel.Name = "UcButtonDel"
        Me.UcButtonDel.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDel.Size = New System.Drawing.Size(57, 32)
        Me.UcButtonDel.TabIndex = 5
        Me.UcButtonDel.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDel.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDel.UCEnable = true
        Me.UcButtonDel.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDel.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDel.UCValue = "حذف"
        '
        'UcButtonSabt
        '
        Me.UcButtonSabt.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSabt.Location = New System.Drawing.Point(19, 0)
        Me.UcButtonSabt.Name = "UcButtonSabt"
        Me.UcButtonSabt.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSabt.Size = New System.Drawing.Size(84, 32)
        Me.UcButtonSabt.TabIndex = 4
        Me.UcButtonSabt.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonSabt.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSabt.UCEnable = true
        Me.UcButtonSabt.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSabt.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSabt.UCValue = "ثبت"
        '
        'UcPersianTextBoxDriverName
        '
        Me.UcPersianTextBoxDriverName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxDriverName.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxDriverName.Location = New System.Drawing.Point(566, 5)
        Me.UcPersianTextBoxDriverName.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxDriverName.Name = "UcPersianTextBoxDriverName"
        Me.UcPersianTextBoxDriverName.Size = New System.Drawing.Size(135, 24)
        Me.UcPersianTextBoxDriverName.TabIndex = 2
        Me.UcPersianTextBoxDriverName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDriverName.UCBorder = true
        Me.UcPersianTextBoxDriverName.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDriverName.UCEnable = true
        Me.UcPersianTextBoxDriverName.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxDriverName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDriverName.UCMultiLine = false
        Me.UcPersianTextBoxDriverName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxDriverName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxDriverName.UCValue = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(508, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کد ملی"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(704, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام و نام خانوادگی"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcTextBoxNationalCode)
        Me.Panel1.Controls.Add(Me.UcNumberLicenseNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxNameFamily)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxFather)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxTel)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxAddress)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 72)
        Me.Panel1.TabIndex = 0
        '
        'UcTextBoxNationalCode
        '
        Me.UcTextBoxNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcTextBoxNationalCode.Location = New System.Drawing.Point(256, 16)
        Me.UcTextBoxNationalCode.Name = "UcTextBoxNationalCode"
        Me.UcTextBoxNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxNationalCode.Size = New System.Drawing.Size(113, 24)
        Me.UcTextBoxNationalCode.TabIndex = 20
        Me.UcTextBoxNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxNationalCode.UCBorder = false
        Me.UcTextBoxNationalCode.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxNationalCode.UCEnable = true
        Me.UcTextBoxNationalCode.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UcTextBoxNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxNationalCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxNationalCode.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxNationalCode.UCMaxNumber = CType(99999,Long)
        Me.UcTextBoxNationalCode.UCMultiLine = false
        Me.UcTextBoxNationalCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxNationalCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxNationalCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxNationalCode.UCValue = ""
        '
        'UcNumberLicenseNo
        '
        Me.UcNumberLicenseNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberLicenseNo.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberLicenseNo.Location = New System.Drawing.Point(16, 44)
        Me.UcNumberLicenseNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberLicenseNo.Name = "UcNumberLicenseNo"
        Me.UcNumberLicenseNo.Size = New System.Drawing.Size(196, 25)
        Me.UcNumberLicenseNo.TabIndex = 19
        Me.UcNumberLicenseNo.UCAllowedMaxNumber = CType(9223372036854775807,Long)
        Me.UcNumberLicenseNo.UCAllowedMinNumber = CType(-9223372036854775,Long)
        Me.UcNumberLicenseNo.UCBackColor = System.Drawing.Color.White
        Me.UcNumberLicenseNo.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberLicenseNo.UCBackColorInvalidEntryException = System.Drawing.Color.Gold
        Me.UcNumberLicenseNo.UCBorder = true
        Me.UcNumberLicenseNo.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcNumberLicenseNo.UCEnable = true
        Me.UcNumberLicenseNo.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberLicenseNo.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberLicenseNo.UCMultiLine = false
        Me.UcNumberLicenseNo.UCValue = CType(0,Long)
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.Location = New System.Drawing.Point(213, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(61, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "گواهینامه :"
        '
        'UcPersianTextBoxNameFamily
        '
        Me.UcPersianTextBoxNameFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNameFamily.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxNameFamily.Location = New System.Drawing.Point(559, 16)
        Me.UcPersianTextBoxNameFamily.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxNameFamily.Name = "UcPersianTextBoxNameFamily"
        Me.UcPersianTextBoxNameFamily.Size = New System.Drawing.Size(125, 24)
        Me.UcPersianTextBoxNameFamily.TabIndex = 17
        Me.UcPersianTextBoxNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNameFamily.UCBorder = true
        Me.UcPersianTextBoxNameFamily.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxNameFamily.UCEnable = true
        Me.UcPersianTextBoxNameFamily.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNameFamily.UCMultiLine = false
        Me.UcPersianTextBoxNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNameFamily.UCValue = ""
        '
        'UcPersianTextBoxFather
        '
        Me.UcPersianTextBoxFather.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxFather.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxFather.Location = New System.Drawing.Point(426, 16)
        Me.UcPersianTextBoxFather.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxFather.Name = "UcPersianTextBoxFather"
        Me.UcPersianTextBoxFather.Size = New System.Drawing.Size(75, 24)
        Me.UcPersianTextBoxFather.TabIndex = 16
        Me.UcPersianTextBoxFather.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxFather.UCBorder = true
        Me.UcPersianTextBoxFather.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxFather.UCEnable = true
        Me.UcPersianTextBoxFather.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxFather.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxFather.UCMultiLine = false
        Me.UcPersianTextBoxFather.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxFather.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxFather.UCValue = ""
        '
        'UcPersianTextBoxTel
        '
        Me.UcPersianTextBoxTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTel.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxTel.Location = New System.Drawing.Point(16, 16)
        Me.UcPersianTextBoxTel.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxTel.Name = "UcPersianTextBoxTel"
        Me.UcPersianTextBoxTel.Size = New System.Drawing.Size(196, 24)
        Me.UcPersianTextBoxTel.TabIndex = 14
        Me.UcPersianTextBoxTel.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTel.UCBorder = true
        Me.UcPersianTextBoxTel.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxTel.UCEnable = true
        Me.UcPersianTextBoxTel.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxTel.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTel.UCMultiLine = false
        Me.UcPersianTextBoxTel.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTel.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTel.UCValue = ""
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(280, 43)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(404, 24)
        Me.UcPersianTextBoxAddress.TabIndex = 7
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCBorder = true
        Me.UcPersianTextBoxAddress.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxAddress.UCEnable = true
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCMultiLine = false
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.Location = New System.Drawing.Point(691, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(42, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "آدرس :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(37, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "تلفن :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(45, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "کدملی :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.Location = New System.Drawing.Point(499, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "نام پدر :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(690, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "نام و نام خانوادگی :"
        '
        'UCDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDriver"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(819, 100)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcButtonNew As R2CoreGUI.UCButton
    Friend WithEvents UcButtonDel As R2CoreGUI.UCButton
    Friend WithEvents UcButtonSabt As R2CoreGUI.UCButton
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
    Friend WithEvents UcNumberDriverNationalCode As R2CoreGUI.UCNumber
    Friend WithEvents UcNumberLicenseNo As R2CoreGUI.UCNumber
    Friend WithEvents Label8 As Label
    Friend WithEvents UcNumberDrivernIdPerson As R2CoreGUI.UCNumber
    Friend WithEvents Label9 As Label
    Friend WithEvents UcTextBoxNationalCode As UCTextBox
End Class
