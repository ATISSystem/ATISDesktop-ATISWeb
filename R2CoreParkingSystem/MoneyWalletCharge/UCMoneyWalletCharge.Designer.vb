Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMoneyWalletCharge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMoneyWalletCharge))
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcButtonCharge = New R2CoreGUI.UCButton()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcLabelMblgh = New R2CoreGUI.UCLabel()
        Me.PicBeggar = New System.Windows.Forms.PictureBox()
        Me.PicPreapring = New System.Windows.Forms.PictureBox()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        CType(Me.PicBeggar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPreapring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWallet.Location = New System.Drawing.Point(425, 59)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(203, 231)
        Me.UcMoneyWallet.TabIndex = 0
        '
        'UcButtonCharge
        '
        Me.UcButtonCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcButtonCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonCharge.ForeColor = System.Drawing.Color.Transparent
        Me.UcButtonCharge.Location = New System.Drawing.Point(34, 193)
        Me.UcButtonCharge.Name = "UcButtonCharge"
        Me.UcButtonCharge.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonCharge.Size = New System.Drawing.Size(136, 86)
        Me.UcButtonCharge.TabIndex = 7
        Me.UcButtonCharge.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonCharge.UCBackColorDisable = System.Drawing.Color.Gainsboro
        Me.UcButtonCharge.UCEnable = False
        Me.UcButtonCharge.UCFont = New System.Drawing.Font("B Homa", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonCharge.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonCharge.UCValue = "شارژ"
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(628, 53)
        Me.UcLabelTop.TabIndex = 8
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "کیف پول - شارژ موجودی"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(226, 181)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(147, 32)
        Me.UcLabel1.TabIndex = 9
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مبلغ نهایی شارژ"
        '
        'UcLabelMblgh
        '
        Me.UcLabelMblgh._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelMblgh._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelMblgh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcLabelMblgh.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelMblgh.Location = New System.Drawing.Point(229, 212)
        Me.UcLabelMblgh.Name = "UcLabelMblgh"
        Me.UcLabelMblgh.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelMblgh.Size = New System.Drawing.Size(135, 32)
        Me.UcLabelMblgh.TabIndex = 10
        Me.UcLabelMblgh.UCBackColor = System.Drawing.Color.White
        Me.UcLabelMblgh.UCFont = New System.Drawing.Font("Alborz Titr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcLabelMblgh.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelMblgh.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelMblgh.UCValue = "0"
        '
        'PicBeggar
        '
        Me.PicBeggar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicBeggar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBeggar.Image = CType(resources.GetObject("PicBeggar.Image"), System.Drawing.Image)
        Me.PicBeggar.Location = New System.Drawing.Point(296, 251)
        Me.PicBeggar.Name = "PicBeggar"
        Me.PicBeggar.Size = New System.Drawing.Size(31, 28)
        Me.PicBeggar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBeggar.TabIndex = 12
        Me.PicBeggar.TabStop = False
        '
        'PicPreapring
        '
        Me.PicPreapring.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicPreapring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPreapring.Image = CType(resources.GetObject("PicPreapring.Image"), System.Drawing.Image)
        Me.PicPreapring.Location = New System.Drawing.Point(237, 251)
        Me.PicPreapring.Name = "PicPreapring"
        Me.PicPreapring.Size = New System.Drawing.Size(31, 28)
        Me.PicPreapring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPreapring.TabIndex = 13
        Me.PicPreapring.TabStop = False
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"), System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(187, 251)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(31, 28)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 14
        Me.PicExit.TabStop = False
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PicExit)
        Me.PnlMain.Controls.Add(Me.PicPreapring)
        Me.PnlMain.Controls.Add(Me.PicBeggar)
        Me.PnlMain.Controls.Add(Me.UcLabelMblgh)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcButtonCharge)
        Me.PnlMain.Controls.Add(Me.UcMoneyWallet)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(628, 296)
        Me.PnlMain.TabIndex = 0
        '
        'UCMoneyWalletCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMoneyWalletCharge"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(634, 302)
        CType(Me.PicBeggar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPreapring,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcMoneyWallet As UCMoneyWallet
    Friend WithEvents UcButtonCharge As UCButton
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcLabelMblgh As UCLabel
    Friend WithEvents PicBeggar As System.Windows.Forms.PictureBox
    Friend WithEvents PicPreapring As System.Windows.Forms.PictureBox
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
End Class
