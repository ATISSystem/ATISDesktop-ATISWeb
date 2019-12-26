Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcCapacitorLoadsforAnnounceReport
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
        Me.PnlCapacitorLoadsforAnnounce = New System.Windows.Forms.Panel()
        Me.UcCapacitorLoadsforAnnounceReport = New PayanehClassLibrary.UCCapacitorLoadsforAnnounceReport()
        Me.PnlCapacitorLoadsforAnnounce.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlCapacitorLoadsforAnnounce
        '
        Me.PnlCapacitorLoadsforAnnounce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlCapacitorLoadsforAnnounce.BackColor = System.Drawing.Color.Transparent
        Me.PnlCapacitorLoadsforAnnounce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCapacitorLoadsforAnnounce.Controls.Add(Me.UcCapacitorLoadsforAnnounceReport)
        Me.PnlCapacitorLoadsforAnnounce.Location = New System.Drawing.Point(5, 50)
        Me.PnlCapacitorLoadsforAnnounce.Name = "PnlCapacitorLoadsforAnnounce"
        Me.PnlCapacitorLoadsforAnnounce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlCapacitorLoadsforAnnounce.Size = New System.Drawing.Size(995, 512)
        Me.PnlCapacitorLoadsforAnnounce.TabIndex = 208
        '
        'UcCapacitorLoadsforAnnounceReport
        '
        Me.UcCapacitorLoadsforAnnounceReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCapacitorLoadsforAnnounceReport.BackColor = System.Drawing.Color.Transparent
        Me.UcCapacitorLoadsforAnnounceReport.Location = New System.Drawing.Point(17, 15)
        Me.UcCapacitorLoadsforAnnounceReport.Name = "UcCapacitorLoadsforAnnounceReport"
        Me.UcCapacitorLoadsforAnnounceReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCapacitorLoadsforAnnounceReport.Size = New System.Drawing.Size(960, 166)
        Me.UcCapacitorLoadsforAnnounceReport.TabIndex = 0
        Me.UcCapacitorLoadsforAnnounceReport.UCViewTitle = false
        '
        'FrmcCapacitorLoadsforAnnounceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlCapacitorLoadsforAnnounce)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcCapacitorLoadsforAnnounceReport"
        Me.Text = "FrmcCapacitorLoadsforAnnounceReport"
        Me.Controls.SetChildIndex(Me.PnlCapacitorLoadsforAnnounce, 0)
        Me.PnlCapacitorLoadsforAnnounce.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlCapacitorLoadsforAnnounce As System.Windows.Forms.Panel
    Friend WithEvents UcCapacitorLoadsforAnnounceReport As UCCapacitorLoadsforAnnounceReport
End Class
