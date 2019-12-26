Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcNumbernIdCar = New R2CoreGUI.UCNumber()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcButtonNew = New R2CoreGUI.UCButton()
        Me.UcButtonDel = New R2CoreGUI.UCButton()
        Me.UcButtonSabt = New R2CoreGUI.UCButton()
        Me.UcPersianTextBoxCarNo = New R2CoreGUI.UCPersianTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UcCmbCity = New R2CoreParkingSystem.UCCmbCity()
        Me.UcCmbCarType = New R2CoreParkingSystem.UCCmbCarType()
        Me.UcPersianTextBoxStrCarNo = New R2CoreGUI.UCPersianTextBox()
        Me.UcPersianTextBoxStrCarSerialNo = New R2CoreGUI.UCPersianTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(585, 82)
        Me.PnlMain.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcNumbernIdCar)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.UcButtonNew)
        Me.Panel1.Controls.Add(Me.UcButtonDel)
        Me.Panel1.Controls.Add(Me.UcButtonSabt)
        Me.Panel1.Controls.Add(Me.UcPersianTextBoxCarNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 80)
        Me.Panel1.TabIndex = 1
        '
        'UcNumbernIdCar
        '
        Me.UcNumbernIdCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcNumbernIdCar.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernIdCar.Location = New System.Drawing.Point(278, 5)
        Me.UcNumbernIdCar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UcNumbernIdCar.Name = "UcNumbernIdCar"
        Me.UcNumbernIdCar.Size = New System.Drawing.Size(74, 25)
        Me.UcNumbernIdCar.TabIndex = 20
        Me.UcNumbernIdCar.UCBackColor = System.Drawing.Color.White
        Me.UcNumbernIdCar.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcNumbernIdCar.UCBorder = true
        Me.UcNumbernIdCar.UCBorderColor = System.Drawing.Color.Black
        Me.UcNumbernIdCar.UCEnable = false
        Me.UcNumbernIdCar.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcNumbernIdCar.UCForeColor = System.Drawing.Color.Black
        Me.UcNumbernIdCar.UCMultiLine = false
        Me.UcNumbernIdCar.UCValue = CType(0,Long)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(359, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "کد"
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
        'UcPersianTextBoxCarNo
        '
        Me.UcPersianTextBoxCarNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxCarNo.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxCarNo.Location = New System.Drawing.Point(387, 5)
        Me.UcPersianTextBoxCarNo.MaxCharacterReached = CType(6,Short)
        Me.UcPersianTextBoxCarNo.Name = "UcPersianTextBoxCarNo"
        Me.UcPersianTextBoxCarNo.Size = New System.Drawing.Size(97, 24)
        Me.UcPersianTextBoxCarNo.TabIndex = 2
        Me.UcPersianTextBoxCarNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxCarNo.UCBorder = true
        Me.UcPersianTextBoxCarNo.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxCarNo.UCEnable = true
        Me.UcPersianTextBoxCarNo.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxCarNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxCarNo.UCMultiLine = false
        Me.UcPersianTextBoxCarNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxCarNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxCarNo.UCValue = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(490, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره خودرو"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.UcCmbCity)
        Me.Panel2.Controls.Add(Me.UcCmbCarType)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxStrCarNo)
        Me.Panel2.Controls.Add(Me.UcPersianTextBoxStrCarSerialNo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(6, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(572, 59)
        Me.Panel2.TabIndex = 0
        '
        'UcCmbCity
        '
        Me.UcCmbCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbCity.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbCity.Location = New System.Drawing.Point(271, 13)
        Me.UcCmbCity.Name = "UcCmbCity"
        Me.UcCmbCity.Padding = New System.Windows.Forms.Padding(1)
        Me.UcCmbCity.Size = New System.Drawing.Size(112, 33)
        Me.UcCmbCity.TabIndex = 21
        '
        'UcCmbCarType
        '
        Me.UcCmbCarType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCmbCarType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbCarType.Location = New System.Drawing.Point(12, 13)
        Me.UcCmbCarType.Name = "UcCmbCarType"
        Me.UcCmbCarType.Padding = New System.Windows.Forms.Padding(1)
        Me.UcCmbCarType.Size = New System.Drawing.Size(103, 32)
        Me.UcCmbCarType.TabIndex = 20
        '
        'UcPersianTextBoxStrCarNo
        '
        Me.UcPersianTextBoxStrCarNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrCarNo.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxStrCarNo.Location = New System.Drawing.Point(421, 17)
        Me.UcPersianTextBoxStrCarNo.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxStrCarNo.Name = "UcPersianTextBoxStrCarNo"
        Me.UcPersianTextBoxStrCarNo.Size = New System.Drawing.Size(102, 24)
        Me.UcPersianTextBoxStrCarNo.TabIndex = 17
        Me.UcPersianTextBoxStrCarNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrCarNo.UCBorder = true
        Me.UcPersianTextBoxStrCarNo.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxStrCarNo.UCEnable = true
        Me.UcPersianTextBoxStrCarNo.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxStrCarNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrCarNo.UCMultiLine = false
        Me.UcPersianTextBoxStrCarNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxStrCarNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrCarNo.UCValue = ""
        '
        'UcPersianTextBoxStrCarSerialNo
        '
        Me.UcPersianTextBoxStrCarSerialNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrCarSerialNo.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxStrCarSerialNo.Location = New System.Drawing.Point(179, 17)
        Me.UcPersianTextBoxStrCarSerialNo.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxStrCarSerialNo.Name = "UcPersianTextBoxStrCarSerialNo"
        Me.UcPersianTextBoxStrCarSerialNo.Size = New System.Drawing.Size(43, 24)
        Me.UcPersianTextBoxStrCarSerialNo.TabIndex = 16
        Me.UcPersianTextBoxStrCarSerialNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrCarSerialNo.UCBorder = true
        Me.UcPersianTextBoxStrCarSerialNo.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcPersianTextBoxStrCarSerialNo.UCEnable = true
        Me.UcPersianTextBoxStrCarSerialNo.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxStrCarSerialNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrCarSerialNo.UCMultiLine = false
        Me.UcPersianTextBoxStrCarSerialNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxStrCarSerialNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrCarSerialNo.UCValue = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(65, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "نوع خودرو :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(33, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "شهر :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(44, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "سریال :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(529, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(36, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "پلاک :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UCCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCar"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(591, 88)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcNumbernIdCar As R2CoreGUI.UCNumber
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UcButtonNew As R2CoreGUI.UCButton
    Friend WithEvents UcButtonDel As R2CoreGUI.UCButton
    Friend WithEvents UcButtonSabt As R2CoreGUI.UCButton
    Friend WithEvents UcPersianTextBoxCarNo As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UcPersianTextBoxStrCarNo As R2CoreGUI.UCPersianTextBox
    Friend WithEvents UcPersianTextBoxStrCarSerialNo As R2CoreGUI.UCPersianTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UcCmbCity As UCCmbCity
    Friend WithEvents UcCmbCarType As UCCmbCarType
End Class
