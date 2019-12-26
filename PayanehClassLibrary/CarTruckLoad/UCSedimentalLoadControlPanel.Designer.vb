Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSedimentalLoadControlPanel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UcButtonDeactivateAnbari_Otaghdar = New R2CoreGUI.UCButton()
        Me.UcButtonActivateAnbari_Otaghdar = New R2CoreGUI.UCButton()
        Me.UcLabel5 = New R2CoreGUI.UCLabel()
        Me.UcLabel4 = New R2CoreGUI.UCLabel()
        Me.UcButtonChangeSedimentalTimeZobi = New R2CoreGUI.UCButton()
        Me.UcTextBoxSedimentTimeZobi = New R2CoreGUI.UCTextBox()
        Me.UcLabel3 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcButtonDeactivateZobi = New R2CoreGUI.UCButton()
        Me.UcButtonActivateZobi = New R2CoreGUI.UCButton()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabel6 = New R2CoreGUI.UCLabel()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcButtonDeactivateAnbari_Otaghdar)
        Me.Panel1.Controls.Add(Me.UcButtonActivateAnbari_Otaghdar)
        Me.Panel1.Controls.Add(Me.UcLabel5)
        Me.Panel1.Controls.Add(Me.UcLabel4)
        Me.Panel1.Controls.Add(Me.UcButtonChangeSedimentalTimeZobi)
        Me.Panel1.Controls.Add(Me.UcTextBoxSedimentTimeZobi)
        Me.Panel1.Controls.Add(Me.UcLabel3)
        Me.Panel1.Controls.Add(Me.UcLabel2)
        Me.Panel1.Controls.Add(Me.UcButtonDeactivateZobi)
        Me.Panel1.Controls.Add(Me.UcButtonActivateZobi)
        Me.Panel1.Controls.Add(Me.UcLabel1)
        Me.Panel1.Controls.Add(Me.UcLabel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 471)
        Me.Panel1.TabIndex = 0
        '
        'UcButtonDeactivateAnbari_Otaghdar
        '
        Me.UcButtonDeactivateAnbari_Otaghdar.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeactivateAnbari_Otaghdar.Location = New System.Drawing.Point(61, 329)
        Me.UcButtonDeactivateAnbari_Otaghdar.Name = "UcButtonDeactivateAnbari_Otaghdar"
        Me.UcButtonDeactivateAnbari_Otaghdar.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDeactivateAnbari_Otaghdar.Size = New System.Drawing.Size(129, 62)
        Me.UcButtonDeactivateAnbari_Otaghdar.TabIndex = 359
        Me.UcButtonDeactivateAnbari_Otaghdar.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonDeactivateAnbari_Otaghdar.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeactivateAnbari_Otaghdar.UCEnable = true
        Me.UcButtonDeactivateAnbari_Otaghdar.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDeactivateAnbari_Otaghdar.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeactivateAnbari_Otaghdar.UCValue = "غیرفعال"
        '
        'UcButtonActivateAnbari_Otaghdar
        '
        Me.UcButtonActivateAnbari_Otaghdar.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonActivateAnbari_Otaghdar.Location = New System.Drawing.Point(61, 261)
        Me.UcButtonActivateAnbari_Otaghdar.Name = "UcButtonActivateAnbari_Otaghdar"
        Me.UcButtonActivateAnbari_Otaghdar.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonActivateAnbari_Otaghdar.Size = New System.Drawing.Size(129, 62)
        Me.UcButtonActivateAnbari_Otaghdar.TabIndex = 358
        Me.UcButtonActivateAnbari_Otaghdar.UCBackColor = System.Drawing.Color.Green
        Me.UcButtonActivateAnbari_Otaghdar.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonActivateAnbari_Otaghdar.UCEnable = true
        Me.UcButtonActivateAnbari_Otaghdar.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonActivateAnbari_Otaghdar.UCForeColor = System.Drawing.Color.White
        Me.UcButtonActivateAnbari_Otaghdar.UCValue = "فعال"
        '
        'UcLabel5
        '
        Me.UcLabel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.Location = New System.Drawing.Point(22, 85)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(210, 54)
        Me.UcLabel5.TabIndex = 357
        Me.UcLabel5.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.White
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "بار انباری و اطاقدار"
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel4.Location = New System.Drawing.Point(255, 85)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(366, 54)
        Me.UcLabel4.TabIndex = 356
        Me.UcLabel4.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.White
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "بار ذوبی"
        '
        'UcButtonChangeSedimentalTimeZobi
        '
        Me.UcButtonChangeSedimentalTimeZobi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonChangeSedimentalTimeZobi.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonChangeSedimentalTimeZobi.Location = New System.Drawing.Point(283, 340)
        Me.UcButtonChangeSedimentalTimeZobi.Name = "UcButtonChangeSedimentalTimeZobi"
        Me.UcButtonChangeSedimentalTimeZobi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonChangeSedimentalTimeZobi.Size = New System.Drawing.Size(124, 43)
        Me.UcButtonChangeSedimentalTimeZobi.TabIndex = 355
        Me.UcButtonChangeSedimentalTimeZobi.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonChangeSedimentalTimeZobi.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonChangeSedimentalTimeZobi.UCEnable = true
        Me.UcButtonChangeSedimentalTimeZobi.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonChangeSedimentalTimeZobi.UCForeColor = System.Drawing.Color.White
        Me.UcButtonChangeSedimentalTimeZobi.UCValue = "تغییر زمان رسوب"
        '
        'UcTextBoxSedimentTimeZobi
        '
        Me.UcTextBoxSedimentTimeZobi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxSedimentTimeZobi.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxSedimentTimeZobi.Location = New System.Drawing.Point(283, 310)
        Me.UcTextBoxSedimentTimeZobi.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxSedimentTimeZobi.Name = "UcTextBoxSedimentTimeZobi"
        Me.UcTextBoxSedimentTimeZobi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcTextBoxSedimentTimeZobi.Size = New System.Drawing.Size(124, 24)
        Me.UcTextBoxSedimentTimeZobi.TabIndex = 354
        Me.UcTextBoxSedimentTimeZobi.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxSedimentTimeZobi.UCBackColorDisable = System.Drawing.Color.WhiteSmoke
        Me.UcTextBoxSedimentTimeZobi.UCEnable = true
        Me.UcTextBoxSedimentTimeZobi.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcTextBoxSedimentTimeZobi.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxSedimentTimeZobi.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxSedimentTimeZobi.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxSedimentTimeZobi.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxSedimentTimeZobi.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxSedimentTimeZobi.UCValue = "00:00:00"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(255, 135)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(202, 101)
        Me.UcLabel3.TabIndex = 352
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "برای تنظیم زمان رسوب بار باید ساعت رسوب را مثل 16:18:15 در باکس زیر وارد نمایید"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(463, 135)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(158, 101)
        Me.UcLabel2.TabIndex = 351
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "از این قسمت می توانید سرویس رسوب بار را فعال یا غیر فعال نمایید"
        '
        'UcButtonDeactivateZobi
        '
        Me.UcButtonDeactivateZobi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonDeactivateZobi.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeactivateZobi.Location = New System.Drawing.Point(476, 320)
        Me.UcButtonDeactivateZobi.Name = "UcButtonDeactivateZobi"
        Me.UcButtonDeactivateZobi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDeactivateZobi.Size = New System.Drawing.Size(129, 62)
        Me.UcButtonDeactivateZobi.TabIndex = 350
        Me.UcButtonDeactivateZobi.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonDeactivateZobi.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeactivateZobi.UCEnable = true
        Me.UcButtonDeactivateZobi.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDeactivateZobi.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeactivateZobi.UCValue = "غیرفعال"
        '
        'UcButtonActivateZobi
        '
        Me.UcButtonActivateZobi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonActivateZobi.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonActivateZobi.Location = New System.Drawing.Point(476, 252)
        Me.UcButtonActivateZobi.Name = "UcButtonActivateZobi"
        Me.UcButtonActivateZobi.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonActivateZobi.Size = New System.Drawing.Size(129, 62)
        Me.UcButtonActivateZobi.TabIndex = 349
        Me.UcButtonActivateZobi.UCBackColor = System.Drawing.Color.Green
        Me.UcButtonActivateZobi.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonActivateZobi.UCEnable = true
        Me.UcButtonActivateZobi.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonActivateZobi.UCForeColor = System.Drawing.Color.White
        Me.UcButtonActivateZobi.UCValue = "فعال"
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(652, 52)
        Me.UcLabel1.TabIndex = 348
        Me.UcLabel1.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "رسوب بار - پنل تنظیمات رسوب بار"
        '
        'UcLabel6
        '
        Me.UcLabel6.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.Location = New System.Drawing.Point(48, 145)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel6.Size = New System.Drawing.Size(158, 101)
        Me.UcLabel6.TabIndex = 360
        Me.UcLabel6.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel6.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel6.UCValue = "از این قسمت می توانید سرویس رسوب بار را فعال یا غیر فعال نمایید"
        '
        'UCSedimentalLoadControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCSedimentalLoadControlPanel"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(674, 491)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UcButtonChangeSedimentalTimeZobi As R2CoreGUI.UCButton
    Friend WithEvents UcTextBoxSedimentTimeZobi As R2CoreGUI.UCTextBox
    Friend WithEvents UcLabel3 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonDeactivateZobi As R2CoreGUI.UCButton
    Friend WithEvents UcButtonActivateZobi As R2CoreGUI.UCButton
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel6 As UCLabel
    Friend WithEvents UcButtonDeactivateAnbari_Otaghdar As UCButton
    Friend WithEvents UcButtonActivateAnbari_Otaghdar As UCButton
    Friend WithEvents UcLabel5 As UCLabel
    Friend WithEvents UcLabel4 As UCLabel
End Class
