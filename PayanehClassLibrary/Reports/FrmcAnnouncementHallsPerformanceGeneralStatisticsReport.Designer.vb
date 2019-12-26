Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcAnnouncementHallsPerformanceGeneralStatisticsReport
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
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport = New System.Windows.Forms.Panel()
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport = New PayanehClassLibrary.UCAnnouncementHallsPerformanceGeneralStatisticsReport()
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlAnnouncementHallsPerformanceGeneralStatisticsReport
        '
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.Controls.Add(Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport)
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.Name = "PnlAnnouncementHallsPerformanceGeneralStatisticsReport"
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.TabIndex = 210
        '
        'UcAnnouncementHallsPerformanceGeneralStatisticsReport
        '
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.Location = New System.Drawing.Point(389, 70)
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.Name = "UcAnnouncementHallsPerformanceGeneralStatisticsReport"
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.Size = New System.Drawing.Size(215, 252)
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.TabIndex = 0
        Me.UcAnnouncementHallsPerformanceGeneralStatisticsReport.UCViewTitle = false
        '
        'FrmcAnnouncementHallsPerformanceGeneralStatisticsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcAnnouncementHallsPerformanceGeneralStatisticsReport"
        Me.Text = "FrmcAnnouncementHallsPerformanceGeneralStatisticsReport"
        Me.Controls.SetChildIndex(Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport, 0)
        Me.PnlAnnouncementHallsPerformanceGeneralStatisticsReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlAnnouncementHallsPerformanceGeneralStatisticsReport As System.Windows.Forms.Panel
    Friend WithEvents UcAnnouncementHallsPerformanceGeneralStatisticsReport As UCAnnouncementHallsPerformanceGeneralStatisticsReport
End Class
