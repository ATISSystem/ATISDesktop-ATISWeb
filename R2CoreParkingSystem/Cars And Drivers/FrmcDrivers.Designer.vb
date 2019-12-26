
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcDrivers
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
        Me.ListBoxDrivers = New System.Windows.Forms.ListBox()
        Me.UcPersianTextBoxDriverName = New R2CoreGUI.UCPersianTextBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'ListBoxDrivers
        '
        Me.ListBoxDrivers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBoxDrivers.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ListBoxDrivers.FormattingEnabled = true
        Me.ListBoxDrivers.IntegralHeight = false
        Me.ListBoxDrivers.ItemHeight = 23
        Me.ListBoxDrivers.Location = New System.Drawing.Point(3, 43)
        Me.ListBoxDrivers.Name = "ListBoxDrivers"
        Me.ListBoxDrivers.Size = New System.Drawing.Size(377, 319)
        Me.ListBoxDrivers.TabIndex = 0
        '
        'UcPersianTextBoxDriverName
        '
        Me.UcPersianTextBoxDriverName.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcPersianTextBoxDriverName.Location = New System.Drawing.Point(3, 3)
        Me.UcPersianTextBoxDriverName.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxDriverName.Name = "UcPersianTextBoxDriverName"
        Me.UcPersianTextBoxDriverName.Size = New System.Drawing.Size(377, 35)
        Me.UcPersianTextBoxDriverName.TabIndex = 1
        Me.UcPersianTextBoxDriverName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxDriverName.UCEnable = true
        Me.UcPersianTextBoxDriverName.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxDriverName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxDriverName.UCOnlyDigit = R2Core.R2Enums.OnlyDigit.Any
        Me.UcPersianTextBoxDriverName.UCValue = ""
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.ListBoxDrivers)
        Me.PnlMain.Controls.Add(Me.UcPersianTextBoxDriverName)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlMain.Size = New System.Drawing.Size(383, 365)
        Me.PnlMain.TabIndex = 2
        '
        'FrmcDrivers
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
        Me.Name = "FrmcDrivers"
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

    Friend WithEvents ListBoxDrivers As ListBox
    Friend WithEvents UcPersianTextBoxDriverName As R2CoreGUI.UCPersianTextBox
    Friend WithEvents PnlMain As Panel
End Class
