
Imports System.Windows.Forms 

Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPersonnel
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
        Me.UcNumberPId = New R2CoreGUI.UCNumber()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcNumberNationalCodeSearch = New R2CoreGUI.UCNumber()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.UcButtonDel = New R2CoreGUI.UCButton()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.UcPersianTextBoxSearchName = New R2CoreGUI.UCPersianTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkActive = New System.Windows.Forms.CheckBox()
        Me.UcPersianTextBoxPIdOther = New R2CoreGUI.UCPersianTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcTextBoxNationalCode = New R2CoreGUI.UCTextBox()
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
        Me.PnlMain.Controls.Add(Me.UcNumberPId)
        Me.PnlMain.Controls.Add(Me.Label9)
        Me.PnlMain.Controls.Add(Me.UcNumberNationalCodeSearch)
        Me.PnlMain.Controls.Add(Me.UcButtonNew)
        Me.PnlMain.Controls.Add(Me.UcButtonDel)
        Me.PnlMain.Controls.Add(Me.UcButtonSabt)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxSearchName)
        Me.PnlMain.Controls.Add(Me.Label2)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(799, 99)
        Me.PnlMain.TabIndex = 0
        '
        'UcNumberPId
        '
        Me.UcNumberPId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberPId.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberPId.Location = New System.Drawing.Point(299, 5)
        Me.UcNumberPId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberPId.Name = "UcNumberPId"
        Me.UcNumberPId.Size = New System.Drawing.Size(63, 25)
        Me.UcNumberPId.TabIndex = 20
        Me.UcNumberPId.UCBackColor = System.Drawing.Color.White
        Me.UcNumberPId.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberPId.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberPId.UCEnable = false
        Me.UcNumberPId.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberPId.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberPId.UCValue = CType(0,Long)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(366, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "کد"
        '
        'UcNumberNationalCodeSearch
        '
        Me.UcNumberNationalCodeSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumberNationalCodeSearch.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberNationalCodeSearch.Location = New System.Drawing.Point(397, 5)
        Me.UcNumberNationalCodeSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumberNationalCodeSearch.Name = "UcNumberNationalCodeSearch"
        Me.UcNumberNationalCodeSearch.Size = New System.Drawing.Size(90, 25)
        Me.UcNumberNationalCodeSearch.TabIndex = 18
        Me.UcNumberNationalCodeSearch.UCBackColor = System.Drawing.Color.White
        Me.UcNumberNationalCodeSearch.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumberNationalCodeSearch.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcNumberNationalCodeSearch.UCEnable = true
        Me.UcNumberNationalCodeSearch.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumberNationalCodeSearch.UCForeColor = System.Drawing.Color.Black
        Me.UcNumberNationalCodeSearch.UCValue = CType(0,Long)
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
        'UcPersianTextBoxSearchName
        '
        Me.UcPersianTextBoxSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSearchName.Location = New System.Drawing.Point(576, 5)
        Me.UcPersianTextBoxSearchName.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxSearchName.Name = "UcPersianTextBoxSearchName"
        Me.UcPersianTextBoxSearchName.Size = New System.Drawing.Size(135, 24)
        Me.UcPersianTextBoxSearchName.TabIndex = 2
        Me.UcPersianTextBoxSearchName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSearchName.UCEnable = true
        Me.UcPersianTextBoxSearchName.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxSearchName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSearchName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSearchName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSearchName.UCValue = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(494, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کد ملی پرسنل"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(722, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام پرسنل"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChkActive)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxPIdOther)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UcTextBoxNationalCode)
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
        Me.Panel1.Size = New System.Drawing.Size(785, 75)
        Me.Panel1.TabIndex = 0
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = true
        Me.ChkActive.Checked = true
        Me.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActive.Font = New System.Drawing.Font("B Homa", 9.75!)
        Me.ChkActive.Location = New System.Drawing.Point(188, 43)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActive.Size = New System.Drawing.Size(96, 27)
        Me.ChkActive.TabIndex = 24
        Me.ChkActive.Text = "فعال/غیرفعال"
        Me.ChkActive.UseVisualStyleBackColor = true
        '
        'UcPersianTextBoxPIdOther
        '
        Me.UcPersianTextBoxPIdOther.Location = New System.Drawing.Point(16, 43)
        Me.UcPersianTextBoxPIdOther.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxPIdOther.Name = "UcPersianTextBoxPIdOther"
        Me.UcPersianTextBoxPIdOther.Size = New System.Drawing.Size(99, 24)
        Me.UcPersianTextBoxPIdOther.TabIndex = 22
        Me.UcPersianTextBoxPIdOther.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxPIdOther.UCEnable = true
        Me.UcPersianTextBoxPIdOther.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxPIdOther.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxPIdOther.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxPIdOther.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxPIdOther.UCValue = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(46, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "کدویژه :"
        '
        'UcTextBoxNationalCode
        '
        Me.UcTextBoxNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxNationalCode.Location = New System.Drawing.Point(242, 16)
        Me.UcTextBoxNationalCode.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxNationalCode.Name = "UcTextBoxNationalCode"
        Me.UcTextBoxNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxNationalCode.Size = New System.Drawing.Size(113, 25)
        Me.UcTextBoxNationalCode.TabIndex = 20
        Me.UcTextBoxNationalCode.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxNationalCode.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxNationalCode.UCEnable = true
        Me.UcTextBoxNationalCode.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxNationalCode.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxNationalCode.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxNationalCode.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxNationalCode.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxNationalCode.UCValue = ""
        '
        'UcPersianTextBoxNameFamily
        '
        Me.UcPersianTextBoxNameFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxNameFamily.Location = New System.Drawing.Point(545, 16)
        Me.UcPersianTextBoxNameFamily.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxNameFamily.Name = "UcPersianTextBoxNameFamily"
        Me.UcPersianTextBoxNameFamily.Size = New System.Drawing.Size(125, 24)
        Me.UcPersianTextBoxNameFamily.TabIndex = 17
        Me.UcPersianTextBoxNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxNameFamily.UCEnable = true
        Me.UcPersianTextBoxNameFamily.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxNameFamily.UCValue = ""
        '
        'UcPersianTextBoxFather
        '
        Me.UcPersianTextBoxFather.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxFather.Location = New System.Drawing.Point(412, 16)
        Me.UcPersianTextBoxFather.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxFather.Name = "UcPersianTextBoxFather"
        Me.UcPersianTextBoxFather.Size = New System.Drawing.Size(75, 24)
        Me.UcPersianTextBoxFather.TabIndex = 16
        Me.UcPersianTextBoxFather.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxFather.UCEnable = true
        Me.UcPersianTextBoxFather.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxFather.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxFather.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxFather.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxFather.UCValue = ""
        '
        'UcPersianTextBoxTel
        '
        Me.UcPersianTextBoxTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxTel.Location = New System.Drawing.Point(16, 16)
        Me.UcPersianTextBoxTel.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxTel.Name = "UcPersianTextBoxTel"
        Me.UcPersianTextBoxTel.Size = New System.Drawing.Size(182, 24)
        Me.UcPersianTextBoxTel.TabIndex = 14
        Me.UcPersianTextBoxTel.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTel.UCEnable = true
        Me.UcPersianTextBoxTel.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxTel.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxTel.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxTel.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTel.UCValue = ""
        '
        'UcPersianTextBoxAddress
        '
        Me.UcPersianTextBoxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxAddress.Location = New System.Drawing.Point(292, 43)
        Me.UcPersianTextBoxAddress.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxAddress.Name = "UcPersianTextBoxAddress"
        Me.UcPersianTextBoxAddress.Size = New System.Drawing.Size(378, 24)
        Me.UcPersianTextBoxAddress.TabIndex = 7
        Me.UcPersianTextBoxAddress.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxAddress.UCEnable = true
        Me.UcPersianTextBoxAddress.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxAddress.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxAddress.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxAddress.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxAddress.UCValue = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.Location = New System.Drawing.Point(677, 41)
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
        Me.Label6.Location = New System.Drawing.Point(199, 18)
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
        Me.Label5.Location = New System.Drawing.Point(361, 18)
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
        Me.Label4.Location = New System.Drawing.Point(485, 18)
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
        Me.Label3.Location = New System.Drawing.Point(676, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "نام و نام خانوادگی :"
        '
        'UCPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPersonnel"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(819, 119)
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
    Friend WithEvents UcPersianTextBoxSearchName As R2CoreGUI.UCPersianTextBox
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
    Friend WithEvents UcNumberNationalCodeSearch As R2CoreGUI.UCNumber
    Friend WithEvents UcNumberPId As R2CoreGUI.UCNumber
    Friend WithEvents Label9 As Label
    Friend WithEvents UcTextBoxNationalCode As UCTextBox
    Friend WithEvents UcPersianTextBoxPIdOther As UCPersianTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkActive As CheckBox
End Class
