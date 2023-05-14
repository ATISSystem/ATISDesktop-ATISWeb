
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMoneyWalletChargeByTruck
    Inherits FrmcGeneral


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlMoneyWalletCharge = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletCharge = New R2CoreParkingSystem.UCMoneyWalletCharge()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.PnlMoneyWalletCharge.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlMoneyWalletCharge
        '
        Me.PnlMoneyWalletCharge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcMoneyWalletCharge)
        Me.PnlMoneyWalletCharge.Controls.Add(Me.UcCar)
        Me.PnlMoneyWalletCharge.Location = New System.Drawing.Point(5, 50)
        Me.PnlMoneyWalletCharge.Name = "PnlMoneyWalletCharge"
        Me.PnlMoneyWalletCharge.Size = New System.Drawing.Size(995, 512)
        Me.PnlMoneyWalletCharge.TabIndex = 201
        '
        'UcMoneyWalletCharge
        '
        Me.UcMoneyWalletCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top)), System.Windows.Forms.AnchorStyles)
        Me.UcMoneyWalletCharge.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcMoneyWalletCharge.Location = New System.Drawing.Point(63, 120)
        Me.UcMoneyWalletCharge.Name = "UcMoneyWalletCharge"
        Me.UcMoneyWalletCharge.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletCharge.Size = New System.Drawing.Size(874, 340)
        Me.UcMoneyWalletCharge.TabIndex = 0
        Me.UcMoneyWalletCharge.UCConfigurationIndex = CType(4, Long)
        Me.UcMoneyWalletCharge.UCLocalPrintFlagforUCPrintBillan = True
        '
        'UcCar
        '
        Me.UcCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Location = New System.Drawing.Point(205, 10)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(584, 88)
        Me.UcCar.TabIndex = 358
        Me.UcCar.UCViewButtons = False
        '
        'FrmcMoneyWalletChargeByTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMoneyWalletCharge)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletChargeByTruck"
        Me.Text = "FrmcMoneyWalletChargeByTruck"
        Me.Controls.SetChildIndex(Me.PnlMoneyWalletCharge, 0)
        Me.PnlMoneyWalletCharge.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents PnlMoneyWalletCharge As System.Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletCharge As UCMoneyWalletCharge
    Friend WithEvents UcCar As UCCar

End Class
