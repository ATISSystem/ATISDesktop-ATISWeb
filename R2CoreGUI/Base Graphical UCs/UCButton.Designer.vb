<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCButton
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
        Me.Button = New System.Windows.Forms.Button()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Button)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(127, 32)
        Me.PnlMain.TabIndex = 0
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.Color.OrangeRed
        Me.Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Button.Location = New System.Drawing.Point(0, 0)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(127, 32)
        Me.Button.TabIndex = 0
        Me.Button.UseVisualStyleBackColor = false
        '
        'UCButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCButton"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(129, 34)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents Button As Button
End Class
