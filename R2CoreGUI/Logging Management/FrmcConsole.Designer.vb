
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcConsole
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
        Me.PnlConsole = New System.Windows.Forms.Panel()
        Me.UcucLoggCollection = New R2CoreGUI.UCUCLogCollection()
        Me.PnlConsole.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PnlConsole
        '
        Me.PnlConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlConsole.Controls.Add(Me.UcucLoggCollection)
        Me.PnlConsole.Location = New System.Drawing.Point(5, 50)
        Me.PnlConsole.Name = "PnlConsole"
        Me.PnlConsole.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlConsole.Size = New System.Drawing.Size(995, 512)
        Me.PnlConsole.TabIndex = 198
        '
        'UcucLoggCollection
        '
        Me.UcucLoggCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoggCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucLoggCollection.Location = New System.Drawing.Point(10, 10)
        Me.UcucLoggCollection.Name = "UcucLoggCollection"
        Me.UcucLoggCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucLoggCollection.RecordCounttoView = CType(10,Short)
        Me.UcucLoggCollection.Size = New System.Drawing.Size(973, 490)
        Me.UcucLoggCollection.TabIndex = 0
        '
        'FrmcConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlConsole)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcConsole"
        Me.Text = "FrmcConsole"
        Me.Controls.SetChildIndex(Me.PnlConsole, 0)
        Me.PnlConsole.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlConsole As System.Windows.Forms.Panel
    Friend WithEvents UcucLoggCollection As UCUCLogCollection
End Class
