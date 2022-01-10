Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMoneyWalletsCurrentChargeReport
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
        Me.Pnlxxx = New System.Windows.Forms.Panel()
        Me.UcMoneyWalletsCurrentChargeReport = New R2CoreParkingSystem.UCMoneyWalletsCurrentChargeReport()
        Me.Pnlxxx.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'Pnlxxx
        '
        Me.Pnlxxx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Pnlxxx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pnlxxx.BackColor = System.Drawing.Color.Transparent
        Me.Pnlxxx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnlxxx.Controls.Add(Me.UcMoneyWalletsCurrentChargeReport)
        Me.Pnlxxx.Location = New System.Drawing.Point(5, 50)
        Me.Pnlxxx.Name = "Pnlxxx"
        Me.Pnlxxx.Size = New System.Drawing.Size(995, 512)
        Me.Pnlxxx.TabIndex = 49
        '
        'UcMoneyWalletsCurrentChargeReport
        '
        Me.UcMoneyWalletsCurrentChargeReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcMoneyWalletsCurrentChargeReport.BackColor = System.Drawing.Color.Transparent
        Me.UcMoneyWalletsCurrentChargeReport.Location = New System.Drawing.Point(135, 60)
        Me.UcMoneyWalletsCurrentChargeReport.Name = "UcMoneyWalletsCurrentChargeReport"
        Me.UcMoneyWalletsCurrentChargeReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcMoneyWalletsCurrentChargeReport.Size = New System.Drawing.Size(722, 282)
        Me.UcMoneyWalletsCurrentChargeReport.TabIndex = 0
        Me.UcMoneyWalletsCurrentChargeReport.TabStop = false
        Me.UcMoneyWalletsCurrentChargeReport.UCViewTitle = false
        '
        'FrmcMoneyWalletsCurrentChargeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.Pnlxxx)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMoneyWalletsCurrentChargeReport"
        Me.Text = "FrmcMoneyWalletsCurrentChargeReport"
        Me.Controls.SetChildIndex(Me.Pnlxxx, 0)
        Me.Pnlxxx.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Pnlxxx As Windows.Forms.Panel
    Friend WithEvents UcMoneyWalletsCurrentChargeReport As UCMoneyWalletsCurrentChargeReport
End Class
