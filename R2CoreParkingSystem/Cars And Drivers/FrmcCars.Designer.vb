<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcCars
    Inherits System.Windows.Forms.Form

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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.ListBoxCars = New System.Windows.Forms.ListBox()
        Me.UcPersianTextBoxCarNo = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.ListBoxCars)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxCarNo)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlMain.Size = New System.Drawing.Size(269, 372)
        Me.PnlMain.TabIndex = 0
        '
        'ListBoxCars
        '
        Me.ListBoxCars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBoxCars.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ListBoxCars.FormattingEnabled = true
        Me.ListBoxCars.IntegralHeight = false
        Me.ListBoxCars.ItemHeight = 23
        Me.ListBoxCars.Location = New System.Drawing.Point(3, 44)
        Me.ListBoxCars.Name = "ListBoxCars"
        Me.ListBoxCars.Size = New System.Drawing.Size(263, 325)
        Me.ListBoxCars.TabIndex = 2
        '
        'UcPersianTextBoxCarNo
        '
        Me.UcPersianTextBoxCarNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcPersianTextBoxCarNo.Location = New System.Drawing.Point(3, 3)
        Me.UcPersianTextBoxCarNo.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxCarNo.Name = "UcPersianTextBoxCarNo"
        Me.UcPersianTextBoxCarNo.Size = New System.Drawing.Size(263, 35)
        Me.UcPersianTextBoxCarNo.TabIndex = 3
        Me.UcPersianTextBoxCarNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxCarNo.UCEnable = true
        Me.UcPersianTextBoxCarNo.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxCarNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxCarNo.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxCarNo.UCValue = ""
        '
        'FrmcCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(271, 374)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcCars"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmcCars"
        Me.TopMost = true
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents ListBoxCars As System.Windows.Forms.ListBox
    Friend WithEvents UcPersianTextBoxCarNo As R2CoreGUI.UCPersianTextBox
End Class
