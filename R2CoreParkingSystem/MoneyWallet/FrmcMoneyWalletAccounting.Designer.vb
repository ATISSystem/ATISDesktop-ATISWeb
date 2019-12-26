Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMoneyWalletAccounting
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
        Me.PnlMoneyWalletAccounting = New System.Windows.Forms.Panel()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcAccountingCollection = New R2CoreParkingSystem.UCAccountingCollection()
        Me.PnlMoneyWalletAccounting.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlMoneyWalletAccounting
        '
        Me.PnlMoneyWalletAccounting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletAccounting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletAccounting.Controls.Add(Me.UcCar)
        Me.PnlMoneyWalletAccounting.Controls.Add(Me.UcAccountingCollection)
        Me.PnlMoneyWalletAccounting.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletAccounting.Name = "PnlMoneyWalletAccounting"
        Me.PnlMoneyWalletAccounting.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletAccounting.TabIndex = 205
        '
        'UcCar
        '
        Me.UcCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(5, 6)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(985, 88)
        Me.UcCar.TabIndex = 1
        Me.UcCar.UCViewButtons = false
        '
        'UcAccountingCollection
        '
        Me.UcAccountingCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAccountingCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcAccountingCollection.Location = New System.Drawing.Point(5, 97)
        Me.UcAccountingCollection.Name = "UcAccountingCollection"
        Me.UcAccountingCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAccountingCollection.Size = New System.Drawing.Size(985, 410)
        Me.UcAccountingCollection.TabIndex = 0
        '
        'FrmcMoneyWalletAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletAccounting)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletAccounting"
        Me.Text = "FrmcMoneyWalletAccounting"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletAccounting, 0)
        Me.PnlMoneyWalletAccounting.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMoneyWalletAccounting As System.Windows.Forms.Panel
    Friend WithEvents UcAccountingCollection As UCAccountingCollection
    Friend WithEvents UcCar As UCCar
End Class
