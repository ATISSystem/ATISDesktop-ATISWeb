<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUCMonetarySettingToolCollection
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
        Me.PnlUCs = New System.Windows.Forms.Panel()
        Me.UcLabel = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Controls.Add(Me.UcLabel)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlMain.Size = New System.Drawing.Size(447, 33)
        Me.PnlMain.TabIndex = 0
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.BackColor = System.Drawing.Color.White
        Me.PnlUCs.Location = New System.Drawing.Point(1, 1)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(363, 31)
        Me.PnlUCs.TabIndex = 2
        '
        'UcLabel
        '
        Me.UcLabel._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel.BackColor = System.Drawing.Color.White
        Me.UcLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.UcLabel.Location = New System.Drawing.Point(364, 1)
        Me.UcLabel.Name = "UcLabel"
        Me.UcLabel.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel.Size = New System.Drawing.Size(82, 31)
        Me.UcLabel.TabIndex = 1
        Me.UcLabel.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel.UCValue = "تنظیم مبلغ"
        '
        'UCUCMonetarySettingToolCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCMonetarySettingToolCollection"
        Me.Size = New System.Drawing.Size(447, 33)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabel As UCLabel
    Friend WithEvents PnlUCs As Panel
End Class
