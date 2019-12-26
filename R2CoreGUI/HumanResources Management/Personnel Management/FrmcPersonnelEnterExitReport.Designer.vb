<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcPersonnelEnterExitReport
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
        Me.PnlPersonnelEnterExitReport = New System.Windows.Forms.Panel()
        Me.UcPersonnelEnterExitReport = New R2CoreGUI.UCPersonnelEnterExitReport()
        Me.PnlPersonnelEnterExitReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlPersonnelEnterExitReport
        '
        Me.PnlPersonnelEnterExitReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelEnterExitReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelEnterExitReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelEnterExitReport.Controls.Add(Me.UcPersonnelEnterExitReport)
        Me.PnlPersonnelEnterExitReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelEnterExitReport.Name = "PnlPersonnelEnterExitReport"
        Me.PnlPersonnelEnterExitReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelEnterExitReport.TabIndex = 207
        '
        'UcPersonnelEnterExitReport
        '
        Me.UcPersonnelEnterExitReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersonnelEnterExitReport.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelEnterExitReport.Location = New System.Drawing.Point(249, 51)
        Me.UcPersonnelEnterExitReport.Name = "UcPersonnelEnterExitReport"
        Me.UcPersonnelEnterExitReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelEnterExitReport.Size = New System.Drawing.Size(494, 419)
        Me.UcPersonnelEnterExitReport.TabIndex = 0
        '
        'FrmcPersonnelEnterExitReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersonnelEnterExitReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonnelEnterExitReport"
        Me.Text = "FrmcPersonnelEnterExitReport"
        Me.Controls.SetChildIndex(Me.PnlPersonnelEnterExitReport, 0)
        Me.PnlPersonnelEnterExitReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlPersonnelEnterExitReport As Panel
    Friend WithEvents UcPersonnelEnterExitReport As UCPersonnelEnterExitReport
End Class
