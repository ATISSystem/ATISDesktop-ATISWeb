Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCBlackListCollection
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
        Me.UcDriver = New R2CoreParkingSystem.UCDriver()
        Me.UcMoney = New R2CoreGUI.UCMoney()
        Me.UcButtonAdd = New R2CoreGUI.UCButton()
        Me.UcPersianTextBoxSharh = New R2CoreGUI.UCPersianTextBox()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcDriver)
        Me.PnlMain.Controls.Add(Me.UcMoney)
        Me.PnlMain.Controls.Add(Me.UcButtonAdd)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxSharh)
        Me.PnlMain.Controls.Add(Me.UcCar)
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcLabel2)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(874, 451)
        Me.PnlMain.TabIndex = 0
        '
        'UcDriver
        '
        Me.UcDriver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriver.BackColor = System.Drawing.Color.Transparent
        Me.UcDriver.Enabled = false
        Me.UcDriver.Location = New System.Drawing.Point(3, 156)
        Me.UcDriver.Name = "UcDriver"
        Me.UcDriver.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriver.Size = New System.Drawing.Size(865, 100)
        Me.UcDriver.TabIndex = 21
        Me.UcDriver.UCViewButtons = false
        '
        'UcMoney
        '
        Me.UcMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcMoney.Location = New System.Drawing.Point(112, 417)
        Me.UcMoney.Name = "UcMoney"
        Me.UcMoney.Size = New System.Drawing.Size(123, 26)
        Me.UcMoney.TabIndex = 0
        Me.UcMoney.UCValue = "23423424"
        '
        'UcButtonAdd
        '
        Me.UcButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonAdd.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonAdd.Location = New System.Drawing.Point(13, 415)
        Me.UcButtonAdd.Name = "UcButtonAdd"
        Me.UcButtonAdd.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonAdd.Size = New System.Drawing.Size(93, 30)
        Me.UcButtonAdd.TabIndex = 20
        Me.UcButtonAdd.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonAdd.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonAdd.UCEnable = true
        Me.UcButtonAdd.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonAdd.UCForeColor = System.Drawing.Color.White
        Me.UcButtonAdd.UCValue = "اضافه به لیست"
        '
        'UcPersianTextBoxSharh
        '
        Me.UcPersianTextBoxSharh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSharh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxSharh.Location = New System.Drawing.Point(280, 417)
        Me.UcPersianTextBoxSharh.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxSharh.Name = "UcPersianTextBoxSharh"
        Me.UcPersianTextBoxSharh.Size = New System.Drawing.Size(551, 26)
        Me.UcPersianTextBoxSharh.TabIndex = 17
        Me.UcPersianTextBoxSharh.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSharh.UCEnable = true
        Me.UcPersianTextBoxSharh.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxSharh.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSharh.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxSharh.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSharh.UCValue = "sdfdsdfs"
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(3, 62)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(866, 88)
        Me.UcCar.TabIndex = 13
        Me.UcCar.UCViewButtons = false
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUCs.Location = New System.Drawing.Point(6, 257)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlUCs.Size = New System.Drawing.Size(862, 155)
        Me.PnlUCs.TabIndex = 14
        '
        'UcLabelTop
        '
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(872, 53)
        Me.UcLabelTop.TabIndex = 12
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "لیست سیاه - تخلفات"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(829, 412)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(46, 32)
        Me.UcLabel1.TabIndex = 16
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "شرح :"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(231, 412)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(55, 29)
        Me.UcLabel2.TabIndex = 18
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "مبلغ :"
        '
        'UCUCBlackListCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCBlackListCollection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(880, 457)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlUCs As System.Windows.Forms.Panel
    Friend WithEvents UcCar As UCCar
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcPersianTextBoxSharh As UCPersianTextBox
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabel2 As UCLabel
    Friend WithEvents UcButtonAdd As UCButton
    Friend WithEvents UcMoney As UCMoney
    Friend WithEvents UcDriver As UCDriver
End Class
