Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcUserChargeReport
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
        Me.PnlUserChargeReport = New System.Windows.Forms.Panel()
        Me.UcUserChargeReport = New R2CoreParkingSystem.UCUsersChargeReport()
        Me.PnlUserChargeReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlUserChargeReport
        '
        Me.PnlUserChargeReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUserChargeReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserChargeReport.Controls.Add(Me.UcUserChargeReport)
        Me.PnlUserChargeReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlUserChargeReport.Name = "PnlUserChargeReport"
        Me.PnlUserChargeReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlUserChargeReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlUserChargeReport.TabIndex = 206
        '
        'UcUserChargeReport
        '
        Me.UcUserChargeReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcUserChargeReport.BackColor = System.Drawing.Color.Transparent
        Me.UcUserChargeReport.Location = New System.Drawing.Point(396, 45)
        Me.UcUserChargeReport.Name = "UcUserChargeReport"
        Me.UcUserChargeReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUserChargeReport.Size = New System.Drawing.Size(200, 253)
        Me.UcUserChargeReport.TabIndex = 0
        Me.UcUserChargeReport.UCViewTitle = false
        '
        'FrmcUserChargeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlUserChargeReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcUserChargeReport"
        Me.Text = "FrmcMoneyWalletChargeUserReport"
        Me.Controls.SetChildIndex(Me.PnlUserChargeReport, 0)
        Me.PnlUserChargeReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlUserChargeReport As System.Windows.Forms.Panel
    Friend WithEvents UcUserChargeReport As UCUsersChargeReport
End Class
