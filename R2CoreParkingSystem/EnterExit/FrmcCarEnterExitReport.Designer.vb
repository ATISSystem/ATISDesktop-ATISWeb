Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcCarEnterExitReport
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
        Me.PnlCarEnterExitReport = New System.Windows.Forms.Panel()
        Me.UcucEnterExitCollection = New R2CoreParkingSystem.UCUCEnterExitCollection()
        Me.PnlCarEnterExitReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlCarEnterExitReport
        '
        Me.PnlCarEnterExitReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlCarEnterExitReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCarEnterExitReport.Controls.Add(Me.UcucEnterExitCollection)
        Me.PnlCarEnterExitReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlCarEnterExitReport.Name = "PnlCarEnterExitReport"
        Me.PnlCarEnterExitReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlCarEnterExitReport.TabIndex = 203
        '
        'UcucEnterExitCollection
        '
        Me.UcucEnterExitCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucEnterExitCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucEnterExitCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucEnterExitCollection.Name = "UcucEnterExitCollection"
        Me.UcucEnterExitCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucEnterExitCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcucEnterExitCollection.TabIndex = 0
        '
        'FrmcCarEnterExitReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlCarEnterExitReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcCarEnterExitReport"
        Me.Text = "FrmCarEnterExitReport"
        Me.Controls.SetChildIndex(Me.PnlCarEnterExitReport, 0)
        Me.PnlCarEnterExitReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlCarEnterExitReport As System.Windows.Forms.Panel
    Friend WithEvents UcucEnterExitCollection As UCUCEnterExitCollection
End Class
