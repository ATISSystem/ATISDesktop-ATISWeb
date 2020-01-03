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
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PicPreapring = New System.Windows.Forms.PictureBox()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcMonetarySupply = New R2CoreGUI.UCMonetarySupply()
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
        Me.UcMoneyWallet.Location = New System.Drawing.Point(617, 56)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(203, 233)
        Me.UcMoneyWallet.TabIndex = 0
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
        Me.UcLabelTop.Size = New System.Drawing.Size(824, 53)
        Me.UcLabelTop.TabIndex = 8
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "کیف پول - شارژ موجودی"
        '
        'PicPreapring
        '
        Me.PicPreapring.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicPreapring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPreapring.Image = CType(resources.GetObject("PicPreapring.Image"), System.Drawing.Image)
        Me.PicPreapring.Location = New System.Drawing.Point(8, 214)
        Me.PicPreapring.Name = "PicPreapring"
        Me.PicPreapring.Size = New System.Drawing.Size(33, 29)
        Me.PicPreapring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPreapring.TabIndex = 13
        Me.PicPreapring.TabStop = False
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"), System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(784, 12)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(31, 28)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 14
        Me.PicExit.TabStop = False
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PicPreapring)
        Me.PnlMain.Controls.Add(Me.UcMonetarySupply)
        Me.PnlMain.Controls.Add(Me.PicExit)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.UcMoneyWallet)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(824, 296)
        Me.PnlMain.TabIndex = 0
        '
        'UcMonetarySupply
        '
        Me.UcMonetarySupply._MonetarySupply = Nothing
        Me.UcMonetarySupply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMonetarySupply.BackColor = System.Drawing.Color.Black
        Me.UcMonetarySupply.Location = New System.Drawing.Point(3, 56)
        Me.UcMonetarySupply.Name = "UcMonetarySupply"
        Me.UcMonetarySupply.Padding = New System.Windows.Forms.Padding(2)
        Me.UcMonetarySupply.Size = New System.Drawing.Size(608, 234)
        Me.UcMonetarySupply.TabIndex = 15
        Me.UcMonetarySupply.UCConfigurationIndex = CType(0, Long)
        Me.UcMonetarySupply.UCEnable = True
        '
        'UCMoneyWalletCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMoneyWalletCharge"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(830, 302)
        CType(Me.PicPreapring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcMoneyWallet As UCMoneyWallet
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents PicPreapring As System.Windows.Forms.PictureBox
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcMonetarySupply As UCMonetarySupply
End Class
