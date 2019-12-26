
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPersonnels
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
        Me.ListBoxPersonnels = New System.Windows.Forms.ListBox()
        Me.UcPersianTextBoxPersonnelNameFamily = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'ListBoxPersonnels
        '
        Me.ListBoxPersonnels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBoxPersonnels.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ListBoxPersonnels.FormattingEnabled = true
        Me.ListBoxPersonnels.IntegralHeight = false
        Me.ListBoxPersonnels.ItemHeight = 23
        Me.ListBoxPersonnels.Location = New System.Drawing.Point(3, 43)
        Me.ListBoxPersonnels.Name = "ListBoxPersonnels"
        Me.ListBoxPersonnels.Size = New System.Drawing.Size(377, 319)
        Me.ListBoxPersonnels.TabIndex = 0
        '
        'UcPersianTextBoxPersonnelNameFamily
        '
        Me.UcPersianTextBoxPersonnelNameFamily.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcPersianTextBoxPersonnelNameFamily.Location = New System.Drawing.Point(3, 3)
        Me.UcPersianTextBoxPersonnelNameFamily.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxPersonnelNameFamily.Name = "UcPersianTextBoxPersonnelNameFamily"
        Me.UcPersianTextBoxPersonnelNameFamily.Size = New System.Drawing.Size(377, 35)
        Me.UcPersianTextBoxPersonnelNameFamily.TabIndex = 1
        Me.UcPersianTextBoxPersonnelNameFamily.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxPersonnelNameFamily.UCEnable = true
        Me.UcPersianTextBoxPersonnelNameFamily.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxPersonnelNameFamily.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxPersonnelNameFamily.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxPersonnelNameFamily.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxPersonnelNameFamily.UCValue = ""
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.ListBoxPersonnels)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxPersonnelNameFamily)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlMain.Size = New System.Drawing.Size(383, 365)
        Me.PnlMain.TabIndex = 2
        '
        'FrmcPersonnels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(385, 367)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcPersonnels"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmcDrivers"
        Me.TopMost = true
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ListBoxPersonnels As ListBox
    Friend WithEvents UcPersianTextBoxPersonnelNameFamily As R2CoreGUI.UCPersianTextBox
    Friend WithEvents PnlMain As Panel
End Class
