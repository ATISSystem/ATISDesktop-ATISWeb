
Imports R2CoreWinFormRemoteApplications


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTruckersAssociationFinancialReport
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
        Me.BtnPnlTruckersAssociationFinancialReport = New System.Windows.Forms.Button()
        Me.PnlTruckersAssiciationFinanceReport = New System.Windows.Forms.Panel()
        Me.UcTruckersAssociationFinacialReport = New PayanehAmirKabirRemoteApplication.UCTruckersAssociationFinacialReport()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlTruckersAssiciationFinanceReport.SuspendLayout
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
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlTruckersAssociationFinancialReport)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 204
        '
        'BtnPnlTruckersAssociationFinancialReport
        '
        Me.BtnPnlTruckersAssociationFinancialReport.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlTruckersAssociationFinancialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlTruckersAssociationFinancialReport.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPnlTruckersAssociationFinancialReport.ForeColor = System.Drawing.Color.White
        Me.BtnPnlTruckersAssociationFinancialReport.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlTruckersAssociationFinancialReport.Name = "BtnPnlTruckersAssociationFinancialReport"
        Me.BtnPnlTruckersAssociationFinancialReport.Size = New System.Drawing.Size(264, 35)
        Me.BtnPnlTruckersAssociationFinancialReport.TabIndex = 0
        Me.BtnPnlTruckersAssociationFinancialReport.Text = "گزارش درآمد حاصل از نوبت ناوگان باری"
        Me.BtnPnlTruckersAssociationFinancialReport.UseVisualStyleBackColor = false
        '
        'PnlTruckersAssiciationFinanceReport
        '
        Me.PnlTruckersAssiciationFinanceReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTruckersAssiciationFinanceReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTruckersAssiciationFinanceReport.Controls.Add(Me.UcTruckersAssociationFinacialReport)
        Me.PnlTruckersAssiciationFinanceReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlTruckersAssiciationFinanceReport.Name = "PnlTruckersAssiciationFinanceReport"
        Me.PnlTruckersAssiciationFinanceReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlTruckersAssiciationFinanceReport.TabIndex = 205
        '
        'UcTruckersAssociationFinacialReport
        '
        Me.UcTruckersAssociationFinacialReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcTruckersAssociationFinacialReport.BackColor = System.Drawing.Color.Transparent
        Me.UcTruckersAssociationFinacialReport.Location = New System.Drawing.Point(308, 40)
        Me.UcTruckersAssociationFinacialReport.Name = "UcTruckersAssociationFinacialReport"
        Me.UcTruckersAssociationFinacialReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTruckersAssociationFinacialReport.Size = New System.Drawing.Size(377, 430)
        Me.UcTruckersAssociationFinacialReport.TabIndex = 0
        '
        'FrmcTruckersAssociationFinancialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTruckersAssiciationFinanceReport)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcTruckersAssociationFinancialReport"
        Me.FrmPersianName = "گزارش درآمد حاصل از نوبت"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTruckersAssociationFinancialReport"
        Me.Text = "FrmcTruckersAssociationFinancialReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlTruckersAssiciationFinanceReport, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlTruckersAssiciationFinanceReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnPnlTruckersAssociationFinancialReport As System.Windows.Forms.Button
    Friend WithEvents PnlTruckersAssiciationFinanceReport As System.Windows.Forms.Panel
    Friend WithEvents UcTruckersAssociationFinacialReport As UCTruckersAssociationFinacialReport
End Class
