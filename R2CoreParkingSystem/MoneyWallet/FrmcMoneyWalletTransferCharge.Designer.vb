Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMoneyWalletTransferCharge
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlTransfer = New System.Windows.Forms.Panel()
        Me.UcMoney = New R2CoreGUI.UCMoney()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcButtonTransfer = New R2CoreGUI.UCButton()
        Me.UcMoneyWalletSource = New R2CoreParkingSystem.UCMoneyWallet()
        Me.OpbTarget = New System.Windows.Forms.RadioButton()
        Me.OpbSource = New System.Windows.Forms.RadioButton()
        Me.UcrfidCardTextMaintainerTarget = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcrfidCardTextMaintainerSource = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcMoneyWalletTarget = New R2CoreParkingSystem.UCMoneyWallet()
        Me.PnlAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlTransfer.SuspendLayout
        Me.PnlAccounting.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTransfer
        '
        Me.PnlTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransfer.Controls.Add(Me.UcMoney)
        Me.PnlTransfer.Controls.Add(Me.UcLabel1)
        Me.PnlTransfer.Controls.Add(Me.UcButtonTransfer)
        Me.PnlTransfer.Controls.Add(Me.UcMoneyWalletSource)
        Me.PnlTransfer.Controls.Add(Me.OpbTarget)
        Me.PnlTransfer.Controls.Add(Me.OpbSource)
        Me.PnlTransfer.Controls.Add(Me.UcrfidCardTextMaintainerTarget)
        Me.PnlTransfer.Controls.Add(Me.UcrfidCardTextMaintainerSource)
        Me.PnlTransfer.Controls.Add(Me.UcMoneyWalletTarget)
        Me.PnlTransfer.Location = New System.Drawing.Point(5, 50)
        Me.PnlTransfer.Name = "PnlTransfer"
        Me.PnlTransfer.Size = New System.Drawing.Size(995, 512)
        Me.PnlTransfer.TabIndex = 202
        '
        'UcMoney
        '
        Me.UcMoney.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMoney.Location = New System.Drawing.Point(306, 385)
        Me.UcMoney.Name = "UcMoney"
        Me.UcMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcMoney.Size = New System.Drawing.Size(137, 24)
        Me.UcMoney.TabIndex = 8
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(316, 347)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(116, 32)
        Me.UcLabel1.TabIndex = 7
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مبلغ انتقال"
        '
        'UcButtonTransfer
        '
        Me.UcButtonTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonTransfer.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcButtonTransfer.Location = New System.Drawing.Point(306, 415)
        Me.UcButtonTransfer.Name = "UcButtonTransfer"
        Me.UcButtonTransfer.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonTransfer.Size = New System.Drawing.Size(137, 49)
        Me.UcButtonTransfer.TabIndex = 6
        Me.UcButtonTransfer.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonTransfer.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonTransfer.UCEnable = true
        Me.UcButtonTransfer.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonTransfer.UCForeColor = System.Drawing.Color.White
        Me.UcButtonTransfer.UCValue = "انتقال موجودی"
        '
        'UcMoneyWalletSource
        '
        Me.UcMoneyWalletSource.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMoneyWalletSource.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletSource.Location = New System.Drawing.Point(517, 102)
        Me.UcMoneyWalletSource.Name = "UcMoneyWalletSource"
        Me.UcMoneyWalletSource.Size = New System.Drawing.Size(197, 235)
        Me.UcMoneyWalletSource.TabIndex = 4
        '
        'OpbTarget
        '
        Me.OpbTarget.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OpbTarget.AutoSize = true
        Me.OpbTarget.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.OpbTarget.Location = New System.Drawing.Point(365, 24)
        Me.OpbTarget.Name = "OpbTarget"
        Me.OpbTarget.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OpbTarget.Size = New System.Drawing.Size(113, 32)
        Me.OpbTarget.TabIndex = 3
        Me.OpbTarget.Text = "کیف پول مقصد"
        Me.OpbTarget.UseVisualStyleBackColor = true
        '
        'OpbSource
        '
        Me.OpbSource.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OpbSource.AutoSize = true
        Me.OpbSource.Checked = true
        Me.OpbSource.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.OpbSource.Location = New System.Drawing.Point(604, 24)
        Me.OpbSource.Name = "OpbSource"
        Me.OpbSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OpbSource.Size = New System.Drawing.Size(110, 32)
        Me.OpbSource.TabIndex = 2
        Me.OpbSource.TabStop = true
        Me.OpbSource.Text = "کیف پول مبداء"
        Me.OpbSource.UseVisualStyleBackColor = true
        '
        'UcrfidCardTextMaintainerTarget
        '
        Me.UcrfidCardTextMaintainerTarget.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcrfidCardTextMaintainerTarget.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainerTarget.Location = New System.Drawing.Point(278, 62)
        Me.UcrfidCardTextMaintainerTarget.Name = "UcrfidCardTextMaintainerTarget"
        Me.UcrfidCardTextMaintainerTarget.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainerTarget.Size = New System.Drawing.Size(197, 37)
        Me.UcrfidCardTextMaintainerTarget.TabIndex = 1
        Me.UcrfidCardTextMaintainerTarget.UCEnable = true
        Me.UcrfidCardTextMaintainerTarget.UCValue = ""
        '
        'UcrfidCardTextMaintainerSource
        '
        Me.UcrfidCardTextMaintainerSource.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcrfidCardTextMaintainerSource.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainerSource.Location = New System.Drawing.Point(517, 62)
        Me.UcrfidCardTextMaintainerSource.Name = "UcrfidCardTextMaintainerSource"
        Me.UcrfidCardTextMaintainerSource.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainerSource.Size = New System.Drawing.Size(197, 37)
        Me.UcrfidCardTextMaintainerSource.TabIndex = 0
        Me.UcrfidCardTextMaintainerSource.UCEnable = true
        Me.UcrfidCardTextMaintainerSource.UCValue = ""
        '
        'UcMoneyWalletTarget
        '
        Me.UcMoneyWalletTarget.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMoneyWalletTarget.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletTarget.Location = New System.Drawing.Point(278, 102)
        Me.UcMoneyWalletTarget.Name = "UcMoneyWalletTarget"
        Me.UcMoneyWalletTarget.Size = New System.Drawing.Size(197, 235)
        Me.UcMoneyWalletTarget.TabIndex = 5
        '
        'PnlAccounting
        '
        Me.PnlAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlAccounting.Name = "PnlAccounting"
        Me.PnlAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlAccounting.TabIndex = 203
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAccountingCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'FrmcMoneyWalletTransferCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTransfer)
        Me.Controls.Add(Me.PnlAccounting)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletTransferCharge"
        Me.Text = "FrmcTransferMoneyWalletCharge"
        Me.Controls.SetChildIndex(Me.PnlAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlTransfer, 0)
        Me.PnlTransfer.ResumeLayout(false)
        Me.PnlTransfer.PerformLayout
        Me.PnlAccounting.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlTransfer As System.Windows.Forms.Panel
    Friend WithEvents UcrfidCardTextMaintainerSource As UCRFIDCardTextMaintainer
    Friend WithEvents UcButtonTransfer As UCButton
    Friend WithEvents UcMoneyWalletTarget As UCMoneyWallet
    Friend WithEvents UcMoneyWalletSource As UCMoneyWallet
    Friend WithEvents OpbTarget As System.Windows.Forms.RadioButton
    Friend WithEvents OpbSource As System.Windows.Forms.RadioButton
    Friend WithEvents UcrfidCardTextMaintainerTarget As UCRFIDCardTextMaintainer
    Friend WithEvents PnlAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents UcMoney As UCMoney
    Friend WithEvents UcLabel1 As UCLabel
End Class
