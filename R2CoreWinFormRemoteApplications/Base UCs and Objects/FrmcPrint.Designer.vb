Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPrint
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
        Me.BtnPnlPrint = New System.Windows.Forms.Button()
        Me.PnlPrint = New System.Windows.Forms.Panel()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlPrint.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlPrint)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(700, 42)
        Me.PnlTopMenu.TabIndex = 206
        '
        'BtnPnlPrint
        '
        Me.BtnPnlPrint.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlPrint.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPnlPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPnlPrint.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlPrint.Name = "BtnPnlPrint"
        Me.BtnPnlPrint.Size = New System.Drawing.Size(120, 35)
        Me.BtnPnlPrint.TabIndex = 0
        Me.BtnPnlPrint.Text = "پانل چاپ"
        Me.BtnPnlPrint.UseVisualStyleBackColor = false
        '
        'PnlPrint
        '
        Me.PnlPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPrint.Controls.Add(Me.ReportViewer)
        Me.PnlPrint.Location = New System.Drawing.Point(5, 50)
        Me.PnlPrint.Name = "PnlPrint"
        Me.PnlPrint.Size = New System.Drawing.Size(995, 512)
        Me.PnlPrint.TabIndex = 207
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReportViewer.Size = New System.Drawing.Size(993, 510)
        Me.ReportViewer.TabIndex = 3
        Me.ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmcPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPrint)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.FrmEnglishName = "FrmcPrint"
        Me.FrmPersianName = "چاپ گزارش"
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPrint"
        Me.Text = "FrmcPrint"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlPrint, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlPrint.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnPnlPrint As Button
    Friend WithEvents PnlPrint As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
