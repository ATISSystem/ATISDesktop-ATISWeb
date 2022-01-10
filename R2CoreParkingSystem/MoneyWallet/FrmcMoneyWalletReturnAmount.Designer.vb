Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMoneyWalletReturnAmount
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
        Me.PnlMoneyWalletReturnAmount = New System.Windows.Forms.Panel()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.UcButton = New R2CoreGUI.UCButton()
        Me.UcMoney = New R2CoreGUI.UCMoney()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMoneyWalletReturnAmount.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMoneyWalletReturnAmount
        '
        Me.PnlMoneyWalletReturnAmount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletReturnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcAccountingCollection)
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcButton)
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcMoney)
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcMoneyWallet)
        Me.PnlMoneyWalletReturnAmount.Controls.Add(Me.UcLabel1)
        Me.PnlMoneyWalletReturnAmount.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletReturnAmount.Name = "PnlMoneyWalletReturnAmount"
        Me.PnlMoneyWalletReturnAmount.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletReturnAmount.TabIndex = 206
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(788, 39)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(202, 34)
        Me.UcrfidCardTextMaintainer.TabIndex = 6
        Me.UcrfidCardTextMaintainer.UCEnable = true
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Location = New System.Drawing.Point(5, 6)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(780, 501)
        Me.UcAccountingCollection.TabIndex = 5
        '
        'UcButton
        '
        Me.UcButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButton.BackColor = System.Drawing.Color.Transparent
        Me.UcButton.Location = New System.Drawing.Point(791, 396)
        Me.UcButton.Name = "UcButton"
        Me.UcButton.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButton.Size = New System.Drawing.Size(197, 46)
        Me.UcButton.TabIndex = 4
        Me.UcButton.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButton.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButton.UCEnable = true
        Me.UcButton.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButton.UCForeColor = System.Drawing.Color.White
        Me.UcButton.UCValue = "تایید بازگشت مبلغ"
        '
        'UcMoney
        '
        Me.UcMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoney.Location = New System.Drawing.Point(794, 365)
        Me.UcMoney.Name = "UcMoney"
        Me.UcMoney.Size = New System.Drawing.Size(141, 20)
        Me.UcMoney.TabIndex = 2
        Me.UcMoney.UCBackColor = System.Drawing.Color.White
        Me.UcMoney.UCBorder = True
        Me.UcMoney.UCBorderColor = System.Drawing.Color.DarkGray
        Me.UcMoney.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcMoney.UCForeColor = System.Drawing.Color.Black
        Me.UcMoney.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcMoney.UCValue = ""
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(791, 79)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(197, 262)
        Me.UcMoneyWallet.TabIndex = 1
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(933, 358)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(50, 32)
        Me.UcLabel1.TabIndex = 3
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مبلغ :"
        '
        'FrmcMoneyWalletReturnAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletReturnAmount)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletReturnAmount"
        Me.Text = "FrmcMoneyWalletReturnAmount"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletReturnAmount, 0)
        Me.PnlMoneyWalletReturnAmount.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMoneyWalletReturnAmount As System.Windows.Forms.Panel
    Friend WithEvents UcButton As UCButton
    Friend WithEvents UcMoney As UCMoney
    Friend WithEvents UcMoneyWallet As UCMoneyWallet
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents UcrfidCardTextMaintainer As UCRFIDCardTextMaintainer
End Class
