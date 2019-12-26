Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMoneyWalletChargeSavabeghCollection
    Inherits  UCGeneral

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
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.AutoScroll = true
        Me.PnlMain.Controls.Add(Me.PnlUCs)
        Me.PnlMain.Controls.Add(Me.UcLabel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(500, 256)
        Me.PnlMain.TabIndex = 0
        '
        'PnlUCs
        '
        Me.PnlUCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlUCs.AutoScroll = true
        Me.PnlUCs.Location = New System.Drawing.Point(3, 55)
        Me.PnlUCs.Name = "PnlUCs"
        Me.PnlUCs.Size = New System.Drawing.Size(494, 198)
        Me.PnlUCs.TabIndex = 1
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.UcLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabel1.Location = New System.Drawing.Point(0, 0)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(500, 49)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabel1.UCForeColor = System.Drawing.Color.White
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کیف پول - سوابق شارژ"
        '
        'UCMoneyWalletChargeSavabeghCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMoneyWalletChargeSavabeghCollection"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(506, 262)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents PnlUCs As System.Windows.Forms.Panel
End Class
