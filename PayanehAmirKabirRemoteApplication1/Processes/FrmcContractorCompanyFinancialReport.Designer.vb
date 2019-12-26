

Imports R2CoreWinFormRemoteApplications

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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPnlContractorCompanyFinancialReport = New System.Windows.Forms.Button()
        Me.PnlContractorCompanyFinancialReport = New System.Windows.Forms.Panel()
        Me.UcContractorCompanyFinancialReport = New UCContractorCompanyFinancialReport()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlContractorCompanyFinancialReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlContractorCompanyFinancialReport)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 205
        '
        'BtnPnlContractorCompanyFinancialReport
        '
        Me.BtnPnlContractorCompanyFinancialReport.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlContractorCompanyFinancialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlContractorCompanyFinancialReport.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPnlContractorCompanyFinancialReport.ForeColor = System.Drawing.Color.White
        Me.BtnPnlContractorCompanyFinancialReport.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlContractorCompanyFinancialReport.Name = "BtnPnlContractorCompanyFinancialReport"
        Me.BtnPnlContractorCompanyFinancialReport.Size = New System.Drawing.Size(186, 35)
        Me.BtnPnlContractorCompanyFinancialReport.TabIndex = 0
        Me.BtnPnlContractorCompanyFinancialReport.Text = "گزارش درآمد حاصل از پارکینگ"
        Me.BtnPnlContractorCompanyFinancialReport.UseVisualStyleBackColor = false
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
        Me.PnlContractorCompanyFinancialReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlContractorCompanyFinancialReport.TabIndex = 206
        '
        'UcContractorCompanyFinancialReport
        '
        Me.UcContractorCompanyFinancialReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcContractorCompanyFinancialReport.BackColor = System.Drawing.Color.Transparent
        Me.UcContractorCompanyFinancialReport.Location = New System.Drawing.Point(213, 15)
        Me.UcContractorCompanyFinancialReport.Name = "UcContractorCompanyFinancialReport"
        Me.UcContractorCompanyFinancialReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcContractorCompanyFinancialReport.Size = New System.Drawing.Size(564, 492)
        Me.UcContractorCompanyFinancialReport.TabIndex = 0
        '
        'FrmcContractorCompanyFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlContractorCompanyFinancialReport)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcContractorCompanyFinancialReport"
        Me.FrmPersianName = "گزارش درآمد حاصل از پارکینگ"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcContractorCompanyFinancialReport"
        Me.Text = "FrmcContractorCompanyFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlContractorCompanyFinancialReport, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlContractorCompanyFinancialReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnPnlContractorCompanyFinancialReport As System.Windows.Forms.Button
    Friend WithEvents PnlContractorCompanyFinancialReport As System.Windows.Forms.Panel
    Friend WithEvents UcContractorCompanyFinancialReport As UCContractorCompanyFinancialReport
End Class
