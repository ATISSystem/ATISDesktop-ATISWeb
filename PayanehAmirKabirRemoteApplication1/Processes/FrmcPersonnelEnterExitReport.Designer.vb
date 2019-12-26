
Imports  R2CoreWinFormRemoteApplications

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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPersonnelEnterExitReport = New System.Windows.Forms.Button()
        Me.PnlPersonnelEnterExitReport = New System.Windows.Forms.Panel()
        Me.UcPersonnelEnterExitReport = New UCPersonnelEnterExitReport()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlPersonnelEnterExitReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPersonnelEnterExitReport)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 206
        '
        'BtnPersonnelEnterExitReport
        '
        Me.BtnPersonnelEnterExitReport.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPersonnelEnterExitReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersonnelEnterExitReport.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPersonnelEnterExitReport.ForeColor = System.Drawing.Color.White
        Me.BtnPersonnelEnterExitReport.Location = New System.Drawing.Point(6, 3)
        Me.BtnPersonnelEnterExitReport.Name = "BtnPersonnelEnterExitReport"
        Me.BtnPersonnelEnterExitReport.Size = New System.Drawing.Size(142, 35)
        Me.BtnPersonnelEnterExitReport.TabIndex = 0
        Me.BtnPersonnelEnterExitReport.Text = "گزارش تردد پرسنل"
        Me.BtnPersonnelEnterExitReport.UseVisualStyleBackColor = false
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
        Me.UcPersonnelEnterExitReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcPersonnelEnterExitReport"
        Me.FrmPersianName = "گزارش تردد پرسنل"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonnelEnterExitReport"
        Me.Text = "FrmcPersonnelEnterExitReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlPersonnelEnterExitReport, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlPersonnelEnterExitReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnPersonnelEnterExitReport As Button
    Friend WithEvents PnlPersonnelEnterExitReport As Panel
    Friend WithEvents UcPersonnelEnterExitReport As UCPersonnelEnterExitReport
End Class
