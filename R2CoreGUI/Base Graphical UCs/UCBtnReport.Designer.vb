<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBtnReport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.BtnViewReport = New System.Windows.Forms.Button()
        Me.BtnViewChop = New System.Windows.Forms.Button()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.BtnViewReport)
        Me.PnlMain.Controls.Add(Me.BtnViewChop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(233, 40)
        Me.PnlMain.TabIndex = 0
        '
        'BtnViewReport
        '
        Me.BtnViewReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnViewReport.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewReport.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnViewReport.Location = New System.Drawing.Point(0, 0)
        Me.BtnViewReport.Name = "BtnViewReport"
        Me.BtnViewReport.Size = New System.Drawing.Size(113, 40)
        Me.BtnViewReport.TabIndex = 2
        Me.BtnViewReport.Text = "مشاهده گزارش"
        Me.BtnViewReport.UseVisualStyleBackColor = False
        '
        'BtnViewChop
        '
        Me.BtnViewChop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnViewChop.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnViewChop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewChop.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnViewChop.Location = New System.Drawing.Point(120, 0)
        Me.BtnViewChop.Name = "BtnViewChop"
        Me.BtnViewChop.Size = New System.Drawing.Size(113, 40)
        Me.BtnViewChop.TabIndex = 0
        Me.BtnViewChop.Text = "پیش نمایش چاپ"
        Me.BtnViewChop.UseVisualStyleBackColor = False
        '
        'UCBtnReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCBtnReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(239, 46)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents BtnViewChop As System.Windows.Forms.Button
    Friend WithEvents BtnViewReport As System.Windows.Forms.Button

End Class
