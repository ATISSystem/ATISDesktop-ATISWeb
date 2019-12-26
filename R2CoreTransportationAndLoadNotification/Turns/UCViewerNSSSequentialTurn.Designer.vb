<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSSequentialTurn
    Inherits UCSequentialTurn

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
        Me.UcLabel = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcLabel)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(198, 23)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel
        '
        Me.UcLabel.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcLabel.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel.Name = "UcLabel1"
        Me.UcLabel.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel.Size = New System.Drawing.Size(198, 23)
        Me.UcLabel.TabIndex = 0
        Me.UcLabel.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel.UCFont = New System.Drawing.Font("B Homa", 9!)
        Me.UcLabel.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel.UCValue = "تسلسل نوبت اطاقدارها"
        '
        'UCViewerNSSSequentialTurn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSSequentialTurn"
        Me.Size = New System.Drawing.Size(198, 23)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel As R2CoreGUI.UCLabel
End Class
