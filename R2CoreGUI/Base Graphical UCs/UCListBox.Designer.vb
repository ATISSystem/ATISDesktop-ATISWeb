<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCListBox
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
        Me.UcLabelTitle = New R2CoreGUI.UCLabel()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabelTitle)
        Me.PnlMain.Controls.Add(Me.ListBox)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(397, 342)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelTitle
        '
        Me.UcLabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelTitle.Location = New System.Drawing.Point(3, 3)
        Me.UcLabelTitle.Name = "UcLabelTitle"
        Me.UcLabelTitle.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTitle.Size = New System.Drawing.Size(389, 53)
        Me.UcLabelTitle.TabIndex = 1
        Me.UcLabelTitle.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTitle.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTitle.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTitle.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTitle.UCValue = ""
        '
        'ListBox
        '
        Me.ListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBox.BackColor = System.Drawing.Color.White
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox.FormattingEnabled = true
        Me.ListBox.IntegralHeight = false
        Me.ListBox.Location = New System.Drawing.Point(3, 62)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(389, 274)
        Me.ListBox.TabIndex = 0
        '
        'UCListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCListBox"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(401, 346)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents ListBox As ListBox
    Friend WithEvents UcLabelTitle As UCLabel
End Class
