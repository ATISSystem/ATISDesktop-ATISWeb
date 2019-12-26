<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcComputerMessageBox
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
        Me.PnlComputerMessageBox = New System.Windows.Forms.Panel()
        Me.UcucComputerMessageCollection = New R2CoreGUI.UCUCComputerMessageCollection()
        Me.PnlComputerMessageBox.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlComputerMessageBox
        '
        Me.PnlComputerMessageBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlComputerMessageBox.BackColor = System.Drawing.Color.Transparent
        Me.PnlComputerMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlComputerMessageBox.Controls.Add(Me.UcucComputerMessageCollection)
        Me.PnlComputerMessageBox.Location = New System.Drawing.Point(5, 50)
        Me.PnlComputerMessageBox.Name = "PnlComputerMessageBox"
        Me.PnlComputerMessageBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlComputerMessageBox.Size = New System.Drawing.Size(995, 512)
        Me.PnlComputerMessageBox.TabIndex = 199
        '
        'UcucComputerMessageCollection
        '
        Me.UcucComputerMessageCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucComputerMessageCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucComputerMessageCollection.Location = New System.Drawing.Point(0, 0)
        Me.UcucComputerMessageCollection.Name = "UcucComputerMessageCollection"
        Me.UcucComputerMessageCollection.Padding = New System.Windows.Forms.Padding(10)
        Me.UcucComputerMessageCollection.Size = New System.Drawing.Size(993, 510)
        Me.UcucComputerMessageCollection.TabIndex = 0
        '
        'FrmcComputerMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlComputerMessageBox)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcComputerMessageBox"
        Me.Text = "FrmcComputerMessageBox"
        Me.Controls.SetChildIndex(Me.PnlComputerMessageBox, 0)
        Me.PnlComputerMessageBox.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlComputerMessageBox As Panel
    Friend WithEvents UcucComputerMessageCollection As UCUCComputerMessageCollection
End Class
