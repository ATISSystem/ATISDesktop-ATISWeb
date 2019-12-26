Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcContractorCompanyFinancialReport
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
        Me.PnlContractorCompanyFinancialReport = New System.Windows.Forms.Panel()
        Me.UcContractorCompanyFinancialReport = New PayanehClassLibrary.UCContractorCompanyFinancialReport()
        Me.PnlContractorCompanyFinancialReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlContractorCompanyFinancialReport
        '
        Me.PnlContractorCompanyFinancialReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlContractorCompanyFinancialReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlContractorCompanyFinancialReport.Controls.Add(Me.UcContractorCompanyFinancialReport)
        Me.PnlContractorCompanyFinancialReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlContractorCompanyFinancialReport.Name = "PnlContractorCompanyFinancialReport"
        Me.PnlContractorCompanyFinancialReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlContractorCompanyFinancialReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlContractorCompanyFinancialReport.TabIndex = 206
        '
        'UcContractorCompanyFinancialReport
        '
        Me.UcContractorCompanyFinancialReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcContractorCompanyFinancialReport.BackColor = System.Drawing.Color.Transparent
        Me.UcContractorCompanyFinancialReport.Location = New System.Drawing.Point(289, 49)
        Me.UcContractorCompanyFinancialReport.Name = "UcContractorCompanyFinancialReport"
        Me.UcContractorCompanyFinancialReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcContractorCompanyFinancialReport.Size = New System.Drawing.Size(415, 331)
        Me.UcContractorCompanyFinancialReport.TabIndex = 0
        Me.UcContractorCompanyFinancialReport.UCViewTitle = false
        '
        'FrmcContractorCompanyFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlContractorCompanyFinancialReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcContractorCompanyFinancialReport"
        Me.Text = "FrmcContractorCompanyFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlContractorCompanyFinancialReport, 0)
        Me.PnlContractorCompanyFinancialReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlContractorCompanyFinancialReport As System.Windows.Forms.Panel
    Friend WithEvents UcContractorCompanyFinancialReport As UCContractorCompanyFinancialReport
End Class
