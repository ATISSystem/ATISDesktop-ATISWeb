Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCreatorBillOfLadingControl
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
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcButtonPathOfFile = New R2CoreGUI.UCButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcPersianTextBoxBLCTitle = New R2CoreGUI.UCPersianTextBox()
        Me.UcButtonTransferInformation = New R2CoreGUI.UCButton()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcTextBoxPathOfFile = New R2CoreGUI.UCTextBox()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(479, 203)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlOutter.Size = New System.Drawing.Size(479, 203)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcButtonPathOfFile)
        Me.PnlInner.Controls.Add(Me.GroupBox1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(1, 1)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(477, 201)
        Me.PnlInner.TabIndex = 0
        '
        'UcButtonPathOfFile
        '
        Me.UcButtonPathOfFile.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonPathOfFile.Location = New System.Drawing.Point(18, 3)
        Me.UcButtonPathOfFile.Name = "UcButtonPathOfFile"
        Me.UcButtonPathOfFile.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonPathOfFile.Size = New System.Drawing.Size(99, 42)
        Me.UcButtonPathOfFile.TabIndex = 1
        Me.UcButtonPathOfFile.UCBackColor = System.Drawing.Color.CornflowerBlue
        Me.UcButtonPathOfFile.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonPathOfFile.UCEnable = true
        Me.UcButtonPathOfFile.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonPathOfFile.UCForeColor = System.Drawing.Color.White
        Me.UcButtonPathOfFile.UCValue = "انتخاب فایل"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcLabel2)
        Me.GroupBox1.Controls.Add(Me.UcPersianTextBoxBLCTitle)
        Me.GroupBox1.Controls.Add(Me.UcButtonTransferInformation)
        Me.GroupBox1.Controls.Add(Me.UcLabel1)
        Me.GroupBox1.Controls.Add(Me.UcTextBoxPathOfFile)
        Me.GroupBox1.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(464, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "فایل کنترل بارنامه"
        '
        'UcPersianTextBoxBLCTitle
        '
        Me.UcPersianTextBoxBLCTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxBLCTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianTextBoxBLCTitle.Location = New System.Drawing.Point(12, 109)
        Me.UcPersianTextBoxBLCTitle.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcPersianTextBoxBLCTitle.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxBLCTitle.Name = "UcPersianTextBoxBLCTitle"
        Me.UcPersianTextBoxBLCTitle.Size = New System.Drawing.Size(442, 27)
        Me.UcPersianTextBoxBLCTitle.TabIndex = 3
        Me.UcPersianTextBoxBLCTitle.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxBLCTitle.UCBorder = true
        Me.UcPersianTextBoxBLCTitle.UCBorderColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxBLCTitle.UCEnable = true
        Me.UcPersianTextBoxBLCTitle.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxBLCTitle.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxBLCTitle.UCMultiLine = false
        Me.UcPersianTextBoxBLCTitle.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxBLCTitle.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxBLCTitle.UCValue = ""
        '
        'UcButtonTransferInformation
        '
        Me.UcButtonTransferInformation.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonTransferInformation.Location = New System.Drawing.Point(8, 141)
        Me.UcButtonTransferInformation.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcButtonTransferInformation.Name = "UcButtonTransferInformation"
        Me.UcButtonTransferInformation.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcButtonTransferInformation.Size = New System.Drawing.Size(200, 42)
        Me.UcButtonTransferInformation.TabIndex = 2
        Me.UcButtonTransferInformation.UCBackColor = System.Drawing.Color.ForestGreen
        Me.UcButtonTransferInformation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonTransferInformation.UCEnable = true
        Me.UcButtonTransferInformation.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonTransferInformation.UCForeColor = System.Drawing.Color.White
        Me.UcButtonTransferInformation.UCValue = "انتقال اطلاعات به بانک اطلاعاتی"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(16, 42)
        Me.UcLabel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcLabel1.Size = New System.Drawing.Size(80, 27)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "PathOfFile :"
        '
        'UcTextBoxPathOfFile
        '
        Me.UcTextBoxPathOfFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTextBoxPathOfFile.BackColor = System.Drawing.Color.Transparent
        Me.UcTextBoxPathOfFile.Location = New System.Drawing.Point(12, 40)
        Me.UcTextBoxPathOfFile.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.UcTextBoxPathOfFile.Name = "UcTextBoxPathOfFile"
        Me.UcTextBoxPathOfFile.Size = New System.Drawing.Size(444, 31)
        Me.UcTextBoxPathOfFile.TabIndex = 0
        Me.UcTextBoxPathOfFile.UCBackColor = System.Drawing.Color.White
        Me.UcTextBoxPathOfFile.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcTextBoxPathOfFile.UCBorder = true
        Me.UcTextBoxPathOfFile.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcTextBoxPathOfFile.UCEnable = true
        Me.UcTextBoxPathOfFile.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcTextBoxPathOfFile.UCForeColor = System.Drawing.Color.Black
        Me.UcTextBoxPathOfFile.UCInputLanguageType = R2Core.R2Enums.InputLanguageType.None
        Me.UcTextBoxPathOfFile.UCMaxCharacterReached = CType(50,Short)
        Me.UcTextBoxPathOfFile.UCMaxNumber = CType(99999,Long)
        Me.UcTextBoxPathOfFile.UCMultiLine = false
        Me.UcTextBoxPathOfFile.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcTextBoxPathOfFile.UCPasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTextBoxPathOfFile.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcTextBoxPathOfFile.UCValue = ""
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(40, 76)
        Me.UcLabel2.Margin = New System.Windows.Forms.Padding(12, 16, 12, 16)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcLabel2.Size = New System.Drawing.Size(388, 33)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "عنوانی برای فایل مورد نظر وارد نمایید و سپس کلید انتقال اطلاعات را فشار دهید"
        '
        'UCCreatorBillOfLadingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCreatorBillOfLadingControl"
        Me.Size = New System.Drawing.Size(479, 203)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcButtonTransferInformation As R2CoreGUI.UCButton
    Friend WithEvents UcButtonPathOfFile As R2CoreGUI.UCButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcTextBoxPathOfFile As R2CoreGUI.UCTextBox
    Friend WithEvents UcPersianTextBoxBLCTitle As UCPersianTextBox
    Friend WithEvents UcLabel2 As UCLabel
End Class
