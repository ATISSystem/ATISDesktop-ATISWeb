
Imports R2CoreGUI


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcClearanceLoadsReport
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
        Me.PnlClearanceLoadsReport = New System.Windows.Forms.Panel()
        Me.UcClearanceLoadsReport = New PayanehClassLibrary.UCClearanceLoadsReport()
        Me.PnlClearanceLoadsReport.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1780)
        '
        'PnlClearanceLoadsReport
        '
        Me.PnlClearanceLoadsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlClearanceLoadsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlClearanceLoadsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlClearanceLoadsReport.Controls.Add(Me.UcClearanceLoadsReport)
        Me.PnlClearanceLoadsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlClearanceLoadsReport.Name = "PnlClearanceLoadsReport"
        Me.PnlClearanceLoadsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlClearanceLoadsReport.TabIndex = 49
        '
        'UcClearanceLoadsReport
        '
        Me.UcClearanceLoadsReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcClearanceLoadsReport.BackColor = System.Drawing.Color.Transparent
        Me.UcClearanceLoadsReport.Location = New System.Drawing.Point(372, 128)
        Me.UcClearanceLoadsReport.Name = "UcClearanceLoadsReport"
        Me.UcClearanceLoadsReport.Size = New System.Drawing.Size(248, 266)
        Me.UcClearanceLoadsReport.TabIndex = 0
        Me.UcClearanceLoadsReport.UCViewTitle = False
        '
        'FrmcClearanceLoadsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlClearanceLoadsReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcClearanceLoadsReport"
        Me.Text = "FrmcClearanceLoadsReport"
        Me.Controls.SetChildIndex(Me.PnlClearanceLoadsReport, 0)
        Me.PnlClearanceLoadsReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlClearanceLoadsReport As Windows.Forms.Panel
    Friend WithEvents UcClearanceLoadsReport As UCClearanceLoadsReport
End Class
