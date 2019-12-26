Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcBlackListFinancialReport
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
        Me.PnlContractorCompanyBlackListFinancialReport = New System.Windows.Forms.Panel()
        Me.UcBlackListFinacialReport = New R2CoreParkingSystem.UCBlackListFinacialReport()
        Me.PnlContractorCompanyBlackListFinancialReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlContractorCompanyBlackListFinancialReport
        '
        Me.PnlContractorCompanyBlackListFinancialReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlContractorCompanyBlackListFinancialReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlContractorCompanyBlackListFinancialReport.Controls.Add(Me.UcBlackListFinacialReport)
        Me.PnlContractorCompanyBlackListFinancialReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlContractorCompanyBlackListFinancialReport.Name = "PnlContractorCompanyBlackListFinancialReport"
        Me.PnlContractorCompanyBlackListFinancialReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlContractorCompanyBlackListFinancialReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlContractorCompanyBlackListFinancialReport.TabIndex = 207
        '
        'UcBlackListFinacialReport
        '
        Me.UcBlackListFinacialReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcBlackListFinacialReport.BackColor = System.Drawing.Color.Transparent
        Me.UcBlackListFinacialReport.Location = New System.Drawing.Point(313, 104)
        Me.UcBlackListFinacialReport.Name = "UcBlackListFinacialReport"
        Me.UcBlackListFinacialReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcBlackListFinacialReport.Size = New System.Drawing.Size(366, 267)
        Me.UcBlackListFinacialReport.TabIndex = 0
        Me.UcBlackListFinacialReport.UCViewTitle = false
        '
        'FrmcBlackListFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlContractorCompanyBlackListFinancialReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcBlackListFinancialReport"
        Me.Text = "FrmcContractorCompanyBlackListFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlContractorCompanyBlackListFinancialReport, 0)
        Me.PnlContractorCompanyBlackListFinancialReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlContractorCompanyBlackListFinancialReport As System.Windows.Forms.Panel
    Friend WithEvents UcBlackListFinacialReport As UCBlackListFinacialReport
End Class
