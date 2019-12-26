Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcAnnouncementHallsPerformanceReport
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
        Me.PnlAnnouncementHallsPerformanceReport = New System.Windows.Forms.Panel()
        Me.UcAnnouncementHallsPerformanceReport = New PayanehClassLibrary.UCAnnouncementHallsPerformanceReport()
        Me.PnlAnnouncementHallsPerformanceReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlAnnouncementHallsPerformanceReport
        '
        Me.PnlAnnouncementHallsPerformanceReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlAnnouncementHallsPerformanceReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlAnnouncementHallsPerformanceReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAnnouncementHallsPerformanceReport.Controls.Add(Me.UcAnnouncementHallsPerformanceReport)
        Me.PnlAnnouncementHallsPerformanceReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlAnnouncementHallsPerformanceReport.Name = "PnlAnnouncementHallsPerformanceReport"
        Me.PnlAnnouncementHallsPerformanceReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlAnnouncementHallsPerformanceReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlAnnouncementHallsPerformanceReport.TabIndex = 209
        '
        'UcAnnouncementHallsPerformanceReport
        '
        Me.UcAnnouncementHallsPerformanceReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallsPerformanceReport.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallsPerformanceReport.Location = New System.Drawing.Point(18, 8)
        Me.UcAnnouncementHallsPerformanceReport.Name = "UcAnnouncementHallsPerformanceReport"
        Me.UcAnnouncementHallsPerformanceReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcAnnouncementHallsPerformanceReport.Size = New System.Drawing.Size(956, 300)
        Me.UcAnnouncementHallsPerformanceReport.TabIndex = 0
        Me.UcAnnouncementHallsPerformanceReport.UCViewTitle = false
        '
        'FrmcAnnouncementHallsPerformanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlAnnouncementHallsPerformanceReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcAnnouncementHallsPerformanceReport"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.PnlAnnouncementHallsPerformanceReport, 0)
        Me.PnlAnnouncementHallsPerformanceReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlAnnouncementHallsPerformanceReport As System.Windows.Forms.Panel
    Friend WithEvents UcAnnouncementHallsPerformanceReport As UCAnnouncementHallsPerformanceReport
End Class
