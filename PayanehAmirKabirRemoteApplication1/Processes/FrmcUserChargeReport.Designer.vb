
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcUserChargeReport
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
        Me.BtnPnlUserChargeReport = New System.Windows.Forms.Button()
        Me.PnlUserChargeReport = New System.Windows.Forms.Panel()
        Me.UcUsersChargeReport = New PayanehAmirKabirRemoteApplication.UCUsersChargeReport()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlUserChargeReport.SuspendLayout
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
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlUserChargeReport)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 206
        '
        'BtnPnlUserChargeReport
        '
        Me.BtnPnlUserChargeReport.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlUserChargeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlUserChargeReport.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPnlUserChargeReport.ForeColor = System.Drawing.Color.White
        Me.BtnPnlUserChargeReport.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlUserChargeReport.Name = "BtnPnlUserChargeReport"
        Me.BtnPnlUserChargeReport.Size = New System.Drawing.Size(179, 35)
        Me.BtnPnlUserChargeReport.TabIndex = 0
        Me.BtnPnlUserChargeReport.Text = "گزارش عملکرد کاربران شارژ"
        Me.BtnPnlUserChargeReport.UseVisualStyleBackColor = false
        '
        'PnlUserChargeReport
        '
        Me.PnlUserChargeReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUserChargeReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlUserChargeReport.Controls.Add(Me.UcUsersChargeReport)
        Me.PnlUserChargeReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlUserChargeReport.Name = "PnlUserChargeReport"
        Me.PnlUserChargeReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlUserChargeReport.TabIndex = 207
        '
        'UcUsersChargeReport
        '
        Me.UcUsersChargeReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcUsersChargeReport.BackColor = System.Drawing.Color.Transparent
        Me.UcUsersChargeReport.Location = New System.Drawing.Point(249, 38)
        Me.UcUsersChargeReport.Name = "UcUsersChargeReport"
        Me.UcUsersChargeReport.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUsersChargeReport.Size = New System.Drawing.Size(494, 419)
        Me.UcUsersChargeReport.TabIndex = 0
        '
        'FrmcUserChargeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlUserChargeReport)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcUserChargeReport"
        Me.FrmPersianName = "گزارش عملکرد کاربران شارژ"
        Me.Location = New System.Drawing.Point(5, 121)
        Me.Name = "FrmcUserChargeReport"
        Me.Text = "FrmcUserChargeReport"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlUserChargeReport, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlUserChargeReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnPnlUserChargeReport As Button
    Friend WithEvents PnlUserChargeReport As Panel
    Friend WithEvents UcUsersChargeReport As UCUsersChargeReport
End Class
