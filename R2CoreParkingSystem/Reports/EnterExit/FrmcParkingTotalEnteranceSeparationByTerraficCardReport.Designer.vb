Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcParkingTotalEnteranceSeparationByTerraficCardReport
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
        Me.PnlReportPreview = New System.Windows.Forms.Panel()
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport = New R2CoreParkingSystem.UCParkingTotalEnteranceSeparationByTerraficCardReport()
        Me.PnlReportPreview.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(184, 185)
        '
        'PnlReportPreview
        '
        Me.PnlReportPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlReportPreview.BackColor = System.Drawing.Color.Transparent
        Me.PnlReportPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlReportPreview.Controls.Add(Me.UcParkingTotalEnteranceSeparationByTerraficCardReport)
        Me.PnlReportPreview.Location = New System.Drawing.Point(5, 50)
        Me.PnlReportPreview.Name = "PnlReportPreview"
        Me.PnlReportPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlReportPreview.Size = New System.Drawing.Size(995, 512)
        Me.PnlReportPreview.TabIndex = 49
        '
        'UcParkingTotalEnteranceSeparationByTerraficCardReport
        '
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.BackColor = System.Drawing.Color.Transparent
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.Location = New System.Drawing.Point(281, 48)
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.Name = "UcParkingTotalEnteranceSeparationByTerraficCardReport"
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.Size = New System.Drawing.Size(430, 328)
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.TabIndex = 0
        Me.UcParkingTotalEnteranceSeparationByTerraficCardReport.UCViewTitle = false
        '
        'FrmcParkingTotalEnteranceSeparationByTerraficCardReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlReportPreview)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcParkingTotalEnteranceSeparationByTerraficCardReport"
        Me.Text = "FrmcParkingTotalEnteranceSeparationByTerraficCardReport"
        Me.Controls.SetChildIndex(Me.PnlReportPreview, 0)
        Me.PnlReportPreview.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlReportPreview As Windows.Forms.Panel
    Friend WithEvents UcParkingTotalEnteranceSeparationByTerraficCardReport As UCParkingTotalEnteranceSeparationByTerraficCardReport
End Class
