<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCConfiguration
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
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.UcButtonSpecial)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(2, 2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(360, 301)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(360, 53)
        Me.UcLabelTop.TabIndex = 12
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 20.25!)
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "تنظیمات عمومی سیستم"
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(41, 245)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(128, 41)
        Me.UcButtonSpecial.TabIndex = 14
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "ثبت تغییرات"
        '
        'UCConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCConfiguration"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(364, 305)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcButtonSpecial As UCButtonSpecial
End Class
