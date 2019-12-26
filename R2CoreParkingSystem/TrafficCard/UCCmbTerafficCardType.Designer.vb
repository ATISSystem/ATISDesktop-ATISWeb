Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCmbTerafficCardType
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
        Me.CmbTerafficCardType = New System.Windows.Forms.ComboBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'CmbTerafficCardType
        '
        Me.CmbTerafficCardType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CmbTerafficCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTerafficCardType.Font = New System.Drawing.Font("B Homa", 8.25!)
        Me.CmbTerafficCardType.FormattingEnabled = true
        Me.CmbTerafficCardType.Location = New System.Drawing.Point(2, 3)
        Me.CmbTerafficCardType.Name = "CmbTerafficCardType"
        Me.CmbTerafficCardType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbTerafficCardType.Size = New System.Drawing.Size(137, 28)
        Me.CmbTerafficCardType.TabIndex = 0
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.CmbTerafficCardType)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(144, 36)
        Me.PnlMain.TabIndex = 1
        '
        'UCCmbTerafficCardType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCmbTerafficCardType"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(150, 42)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CmbTerafficCardType As System.Windows.Forms.ComboBox
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
End Class
