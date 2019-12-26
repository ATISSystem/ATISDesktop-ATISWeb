Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMoneyWalletChargeSavabegh
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
        Me.PnlMoneyWalletChargeSavabegh = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletChargeSavabeghCollection = New R2CoreParkingSystem.UCMoneyWalletChargeSavabeghCollection()
        Me.PnlMoneyWalletChargeSavabegh.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlMoneyWalletChargeSavabegh
        '
        Me.PnlMoneyWalletChargeSavabegh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletChargeSavabegh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletChargeSavabegh.Controls.Add(Me.UcMoneyWalletChargeSavabeghCollection)
        Me.PnlMoneyWalletChargeSavabegh.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletChargeSavabegh.Name = "PnlMoneyWalletChargeSavabegh"
        Me.PnlMoneyWalletChargeSavabegh.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletChargeSavabegh.TabIndex = 202
        '
        'UcMoneyWalletChargeSavabeghCollection
        '
        Me.UcMoneyWalletChargeSavabeghCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletChargeSavabeghCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletChargeSavabeghCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMoneyWalletChargeSavabeghCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcMoneyWalletChargeSavabeghCollection.Name = "UcMoneyWalletChargeSavabeghCollection"
        Me.UcMoneyWalletChargeSavabeghCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletChargeSavabeghCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcMoneyWalletChargeSavabeghCollection.TabIndex = 0
        '
        'FrmcMoneyWalletChargeSavabegh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletChargeSavabegh)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletChargeSavabegh"
        Me.Text = "FrmcMoneyWalletChargeSavabegh"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletChargeSavabegh, 0)
        Me.PnlMoneyWalletChargeSavabegh.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMoneyWalletChargeSavabegh As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletChargeSavabeghCollection As UCMoneyWalletChargeSavabeghCollection
End Class
