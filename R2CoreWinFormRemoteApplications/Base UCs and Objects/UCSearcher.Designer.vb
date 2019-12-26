<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSearcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSearcher))
        Me.UcPersianTextBox = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PnlTop = New System.Windows.Forms.Panel()
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlTop.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'UcPersianTextBox
        '
        Me.UcPersianTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBox.Location = New System.Drawing.Point(25, 2)
        Me.UcPersianTextBox.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBox.Name = "UcPersianTextBox"
        Me.UcPersianTextBox.Size = New System.Drawing.Size(217, 24)
        Me.UcPersianTextBox.TabIndex = 0
        Me.UcPersianTextBox.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBox.UCEnable = true
        Me.UcPersianTextBox.UCFont = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBox.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBox.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBox.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBox.UCValue = ""
        '
        'ListBox
        '
        Me.ListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox.ForeColor = System.Drawing.Color.Black
        Me.ListBox.FormattingEnabled = true
        Me.ListBox.IntegralHeight = false
        Me.ListBox.Location = New System.Drawing.Point(2, 37)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(242, 0)
        Me.ListBox.TabIndex = 1
        '
        'PictureBox
        '
        Me.PictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"),System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(23, 24)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = false
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.White
        Me.PnlTop.Controls.Add(Me.PictureBox)
        Me.PnlTop.Controls.Add(Me.UcPersianTextBox)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(2, 2)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(244, 29)
        Me.PnlTop.TabIndex = 3
        '
        'UCSearcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.PnlTop)
        Me.Name = "UCSearcher"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(248, 32)
        CType(Me.PictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlTop.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents UcPersianTextBox As UCPersianTextBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
End Class
