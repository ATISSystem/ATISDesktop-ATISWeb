<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLabel
    Inherits UCGeneral

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
        Me.Label = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Label)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(114, 30)
        Me.PnlMain.TabIndex = 0
        '
        'Label
        '
        Me.Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(114, 30)
        Me.Label.TabIndex = 0
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLabel"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(116, 32)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Label As Label
End Class
