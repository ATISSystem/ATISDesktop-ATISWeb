Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCmbTerafficTempCardType
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
        Me.CmbTerafficTempCardType = New System.Windows.Forms.ComboBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.CmbTerafficTempCardType)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(168, 33)
        Me.PnlMain.TabIndex = 0
        '
        'CmbTerafficTempCardType
        '
        Me.CmbTerafficTempCardType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CmbTerafficTempCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTerafficTempCardType.Font = New System.Drawing.Font("B Homa", 8.25!)
        Me.CmbTerafficTempCardType.FormattingEnabled = true
        Me.CmbTerafficTempCardType.Location = New System.Drawing.Point(2, 2)
        Me.CmbTerafficTempCardType.Name = "CmbTerafficTempCardType"
        Me.CmbTerafficTempCardType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbTerafficTempCardType.Size = New System.Drawing.Size(161, 28)
        Me.CmbTerafficTempCardType.TabIndex = 1
        '
        'UCCmbTerafficTempCardType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCmbTerafficTempCardType"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(174, 39)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents CmbTerafficTempCardType As System.Windows.Forms.ComboBox
End Class
