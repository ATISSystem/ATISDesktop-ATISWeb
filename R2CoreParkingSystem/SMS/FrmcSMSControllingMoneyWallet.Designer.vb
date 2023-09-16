
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcSMSControllingMoneyWallet
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
        Me.PnlMoneyWalletCharging = New System.Windows.Forms.Panel()
        Me.PnlMoneyWalletAccounting = New System.Windows.Forms.Panel()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.UcMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.PnlMoneyWalletAccounting.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMoneyWalletCharging
        '
        Me.PnlMoneyWalletCharging.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletCharging.BackColor = System.Drawing.Color.Transparent
        Me.PnlMoneyWalletCharging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletCharging.Controls.Add(Me.UcMoneyWalletCharge)
        Me.PnlMoneyWalletCharging.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletCharging.Name = "PnlMoneyWalletCharging"
        Me.PnlMoneyWalletCharging.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletCharging.TabIndex = 49
        '
        'UcMoneyWalletCharge
        '
        Me.UcMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top)), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletCharge.Location = New System.Drawing.Point(137, 100)
        Me.UcMoneyWalletCharge.Name = "UcMoneyWalletCharge"
        Me.UcMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletCharge.Size = New System.Drawing.Size(720, 350)
        Me.UcMoneyWalletCharge.TabIndex = 340
        Me.UcMoneyWalletCharge.UCConfigurationIndex = CType(6, Long)
        Me.UcMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = False
        '
        'PnlMoneyWalletAccounting
        '
        Me.PnlMoneyWalletAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletAccounting.BackColor = System.Drawing.Color.Transparent
        Me.PnlMoneyWalletAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlMoneyWalletAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletAccounting.Name = "PnlMoneyWalletAccounting"
        Me.PnlMoneyWalletAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletAccounting.TabIndex = 50
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
        'FrmcSMSControllingMoneyWallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletCharging)
        Me.Controls.Add(Me.PnlMoneyWalletAccounting)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSMSControllingMoneyWallet"
        Me.Text = "FrmcSMSControllingMoneyWallet"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletAccounting, 0)
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletCharging, 0)
        Me.PnlMoneyWalletAccounting.ResumeLayout(False)
        Me.PnlMoneyWalletCharging.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMoneyWalletCharging As Windows.Forms.Panel
    Friend WithEvents PnlMoneyWalletAccounting As Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletCharge As UCMoneyWalletCharge
    Friend WithEvents UcAccountingCollection As R2CoreParkingSystem.UCAccountingCollection

End Class
