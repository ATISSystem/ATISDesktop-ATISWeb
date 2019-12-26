Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTempExitTerafficCard
    Inherits  FrmcGeneral

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
        Me.PnlTempExitTerafficCard = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.UcButtonTaeed = New R2CoreGUI.UCButton()
        Me.UcMoney = New R2CoreGUI.UCMoney()
        Me.UcMoneyWallet = New R2CoreParkingSystem.UCMoneyWallet()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlTempExitTerafficCard.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTempExitTerafficCard
        '
        Me.PnlTempExitTerafficCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTempExitTerafficCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcAccountingCollection)
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcButtonTaeed)
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcMoney)
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcMoneyWallet)
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlTempExitTerafficCard.Controls.Add(Me.UcLabel1)
        Me.PnlTempExitTerafficCard.Location = New System.Drawing.Point(5, 50)
        Me.PnlTempExitTerafficCard.Name = "PnlTempExitTerafficCard"
        Me.PnlTempExitTerafficCard.Size = New System.Drawing.Size(995, 512)
        Me.PnlTempExitTerafficCard.TabIndex = 205
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Location = New System.Drawing.Point(5, 0)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(778, 507)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'UcButtonTaeed
        '
        Me.UcButtonTaeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonTaeed.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonTaeed.Location = New System.Drawing.Point(789, 417)
        Me.UcButtonTaeed.Name = "UcButtonTaeed"
        Me.UcButtonTaeed.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonTaeed.Size = New System.Drawing.Size(188, 46)
        Me.UcButtonTaeed.TabIndex = 4
        Me.UcButtonTaeed.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonTaeed.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonTaeed.UCEnable = true
        Me.UcButtonTaeed.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonTaeed.UCForeColor = System.Drawing.Color.White
        Me.UcButtonTaeed.UCValue = "تایید خروج موفت"
        '
        'UcMoney
        '
        Me.UcMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoney.Location = New System.Drawing.Point(789, 123)
        Me.UcMoney.Name = "UcMoney"
        Me.UcMoney.Size = New System.Drawing.Size(132, 20)
        Me.UcMoney.TabIndex = 2
        '
        'UcMoneyWallet
        '
        Me.UcMoneyWallet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWallet.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWallet.Location = New System.Drawing.Point(789, 149)
        Me.UcMoneyWallet.Name = "UcMoneyWallet"
        Me.UcMoneyWallet.Size = New System.Drawing.Size(188, 262)
        Me.UcMoneyWallet.TabIndex = 1
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(789, 83)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(188, 34)
        Me.UcrfidCardTextMaintainer.TabIndex = 0
        Me.UcrfidCardTextMaintainer.UCEnable = true
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(916, 116)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(50, 32)
        Me.UcLabel1.TabIndex = 3
        Me.UcLabel1.UCBackColor = System.Drawing.Color.White
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "مبلغ :"
        '
        'FrmcTempExitTerafficCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTempExitTerafficCard)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTempExitTerafficCard"
        Me.Text = "FrmcTempExitTerafficCard"
        Me.Controls.SetChildIndex(Me.PnlTempExitTerafficCard, 0)
        Me.PnlTempExitTerafficCard.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlTempExitTerafficCard As System.Windows.Forms.Panel
    Friend WithEvents UcrfidCardTextMaintainer As UCRFIDCardTextMaintainer
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents UcMoney As UCMoney
    Friend WithEvents UcMoneyWallet As UCMoneyWallet
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcButtonTaeed As UCButton
End Class
