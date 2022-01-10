<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPersonnelAttendance
    Inherits FrmcGeneral

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
        Me.PnlPersonnelSabtPrecent = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcListBoxPersonnelEnterExit = New R2CoreGUI.UCListBoxPersonnelEnterExit()
        Me.UcDateTime = New R2CoreGUI.UCDateTime()
        Me.UcButtonDisableHook = New R2CoreGUI.UCButton()
        Me.UcButtonEnableHook = New R2CoreGUI.UCButton()
        Me.PicNU1 = New System.Windows.Forms.PictureBox()
        Me.PicNU2 = New System.Windows.Forms.PictureBox()
        Me.PicNU3 = New System.Windows.Forms.PictureBox()
        Me.PicNU4 = New System.Windows.Forms.PictureBox()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.UcFingerPrintCapturerSuprema = New R2CoreGUI.UCFingerPrintCapturerSuprema()
        Me.PnlPersonnelSabtPrecent.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.PicNU1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlPersonnelSabtPrecent
        '
        Me.PnlPersonnelSabtPrecent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelSabtPrecent.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelSabtPrecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.GroupBox1)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.UcDateTime)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.UcButtonDisableHook)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.UcButtonEnableHook)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.PicNU1)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.PicNU2)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.PicNU3)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.PicNU4)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.UcPersonnelImage)
        Me.PnlPersonnelSabtPrecent.Controls.Add(Me.UcFingerPrintCapturerSuprema)
        Me.PnlPersonnelSabtPrecent.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelSabtPrecent.Name = "PnlPersonnelSabtPrecent"
        Me.PnlPersonnelSabtPrecent.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelSabtPrecent.TabIndex = 201
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcListBoxPersonnelEnterExit)
        Me.GroupBox1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(251, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 513)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "سوابق تردد"
        '
        'UcListBoxPersonnelEnterExit
        '
        Me.UcListBoxPersonnelEnterExit.BackColor = System.Drawing.Color.Transparent
        Me.UcListBoxPersonnelEnterExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListBoxPersonnelEnterExit.Location = New System.Drawing.Point(3, 27)
        Me.UcListBoxPersonnelEnterExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcListBoxPersonnelEnterExit.Name = "UcListBoxPersonnelEnterExit"
        Me.UcListBoxPersonnelEnterExit.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UcListBoxPersonnelEnterExit.Size = New System.Drawing.Size(194, 483)
        Me.UcListBoxPersonnelEnterExit.TabIndex = 0
        Me.UcListBoxPersonnelEnterExit.UCBackColor = System.Drawing.Color.White
        Me.UcListBoxPersonnelEnterExit.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcListBoxPersonnelEnterExit.UCForeColor = System.Drawing.Color.Black
        Me.UcListBoxPersonnelEnterExit.UCTitle = "سوابق تردد پرسنل"
        '
        'UcDateTime
        '
        Me.UcDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.Location = New System.Drawing.Point(37, 48)
        Me.UcDateTime.Name = "UcDateTime"
        Me.UcDateTime.Size = New System.Drawing.Size(196, 35)
        Me.UcDateTime.TabIndex = 22
        Me.UcDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.UCClockIconAppierance = true
        Me.UcDateTime.UCEnable = true
        Me.UcDateTime.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcDateTime.UCForeColor = System.Drawing.Color.Black
        '
        'UcButtonDisableHook
        '
        Me.UcButtonDisableHook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonDisableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDisableHook.Location = New System.Drawing.Point(37, 415)
        Me.UcButtonDisableHook.Name = "UcButtonDisableHook"
        Me.UcButtonDisableHook.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDisableHook.Size = New System.Drawing.Size(155, 35)
        Me.UcButtonDisableHook.TabIndex = 19
        Me.UcButtonDisableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDisableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDisableHook.UCEnable = false
        Me.UcButtonDisableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDisableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDisableHook.UCValue = "غیر فعال سازی Hook"
        '
        'UcButtonEnableHook
        '
        Me.UcButtonEnableHook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonEnableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonEnableHook.Location = New System.Drawing.Point(37, 456)
        Me.UcButtonEnableHook.Name = "UcButtonEnableHook"
        Me.UcButtonEnableHook.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonEnableHook.Size = New System.Drawing.Size(155, 35)
        Me.UcButtonEnableHook.TabIndex = 18
        Me.UcButtonEnableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonEnableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonEnableHook.UCEnable = false
        Me.UcButtonEnableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonEnableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonEnableHook.UCValue = "فعال سازی Hook"
        '
        'PicNU1
        '
        Me.PicNU1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicNU1.Location = New System.Drawing.Point(78, 277)
        Me.PicNU1.Name = "PicNU1"
        Me.PicNU1.Size = New System.Drawing.Size(90, 50)
        Me.PicNU1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU1.TabIndex = 12
        Me.PicNU1.TabStop = false
        '
        'PicNU2
        '
        Me.PicNU2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicNU2.Location = New System.Drawing.Point(78, 227)
        Me.PicNU2.Name = "PicNU2"
        Me.PicNU2.Size = New System.Drawing.Size(90, 50)
        Me.PicNU2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU2.TabIndex = 13
        Me.PicNU2.TabStop = false
        '
        'PicNU3
        '
        Me.PicNU3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicNU3.Location = New System.Drawing.Point(78, 177)
        Me.PicNU3.Name = "PicNU3"
        Me.PicNU3.Size = New System.Drawing.Size(90, 50)
        Me.PicNU3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU3.TabIndex = 14
        Me.PicNU3.TabStop = false
        '
        'PicNU4
        '
        Me.PicNU4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicNU4.Location = New System.Drawing.Point(78, 127)
        Me.PicNU4.Name = "PicNU4"
        Me.PicNU4.Size = New System.Drawing.Size(90, 50)
        Me.PicNU4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU4.TabIndex = 15
        Me.PicNU4.TabStop = false
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersonnelImage.Location = New System.Drawing.Point(457, 8)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(522, 494)
        Me.UcPersonnelImage.TabIndex = 16
        '
        'UcFingerPrintCapturerSuprema
        '
        Me.UcFingerPrintCapturerSuprema.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerSuprema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcFingerPrintCapturerSuprema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerSuprema.Enabled = false
        Me.UcFingerPrintCapturerSuprema.Location = New System.Drawing.Point(457, 8)
        Me.UcFingerPrintCapturerSuprema.Name = "UcFingerPrintCapturerSuprema"
        Me.UcFingerPrintCapturerSuprema.Scanner = Nothing
        Me.UcFingerPrintCapturerSuprema.Size = New System.Drawing.Size(522, 494)
        Me.UcFingerPrintCapturerSuprema.TabIndex = 0
        '
        'FrmcPersonnelAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersonnelSabtPrecent)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonnelAttendance"
        Me.Text = "FrmcPersonnelAttendance"
        Me.Controls.SetChildIndex(Me.PnlPersonnelSabtPrecent, 0)
        Me.PnlPersonnelSabtPrecent.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.PicNU1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlPersonnelSabtPrecent As Panel
    Friend WithEvents PicNU1 As PictureBox
    Friend WithEvents PicNU2 As PictureBox
    Friend WithEvents PicNU3 As PictureBox
    Friend WithEvents PicNU4 As PictureBox
    Friend WithEvents UcFingerPrintCapturerSuprema As UCFingerPrintCapturerSuprema
    Friend WithEvents UcPersonnelImage As UCPersonnelImage
    Friend WithEvents UcButtonDisableHook As UCButton
    Friend WithEvents UcButtonEnableHook As UCButton
    Friend WithEvents UcDateTime As UCDateTime
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UcListBoxPersonnelEnterExit As UCListBoxPersonnelEnterExit
End Class
