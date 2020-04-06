<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcAttendane
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcAttendane))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcListBoxPersonnelEnterExit = New R2CoreGUI.UCListBoxPersonnelEnterExit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcDateTime = New R2CoreGUI.UCDateTime()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.UcButtonDisableHook = New R2CoreGUI.UCButton()
        Me.UcButtonEnableHook = New R2CoreGUI.UCButton()
        Me.PicNU4 = New System.Windows.Forms.PictureBox()
        Me.PicNU3 = New System.Windows.Forms.PictureBox()
        Me.PicNU2 = New System.Windows.Forms.PictureBox()
        Me.PicNU1 = New System.Windows.Forms.PictureBox()
        Me.UcFingerPrintCapturerSuprema = New R2CoreGUI.UCFingerPrintCapturerSuprema()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.PnlMain.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicNU1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.UcListBoxPersonnelEnterExit)
        Me.PnlMain.Controls.Add(Me.GroupBox2)
        Me.PnlMain.Controls.Add(Me.UcFingerPrintCapturerSuprema)
        Me.PnlMain.Controls.Add(Me.UcPersonnelImage)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(1, 1)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(829, 560)
        Me.PnlMain.TabIndex = 0
        '
        'UcListBoxPersonnelEnterExit
        '
        Me.UcListBoxPersonnelEnterExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.UcListBoxPersonnelEnterExit.BackColor = System.Drawing.Color.Transparent
        Me.UcListBoxPersonnelEnterExit.Location = New System.Drawing.Point(175, 5)
        Me.UcListBoxPersonnelEnterExit.Name = "UcListBoxPersonnelEnterExit"
        Me.UcListBoxPersonnelEnterExit.Padding = New System.Windows.Forms.Padding(2)
        Me.UcListBoxPersonnelEnterExit.Size = New System.Drawing.Size(195, 547)
        Me.UcListBoxPersonnelEnterExit.TabIndex = 0
        Me.UcListBoxPersonnelEnterExit.UCBackColor = System.Drawing.Color.White
        Me.UcListBoxPersonnelEnterExit.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcListBoxPersonnelEnterExit.UCForeColor = System.Drawing.Color.Black
        Me.UcListBoxPersonnelEnterExit.UCTitle = "سوابق تردد پرسنل"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.UcDateTime)
        Me.GroupBox2.Controls.Add(Me.PicExit)
        Me.GroupBox2.Controls.Add(Me.UcButtonDisableHook)
        Me.GroupBox2.Controls.Add(Me.UcButtonEnableHook)
        Me.GroupBox2.Controls.Add(Me.PicNU4)
        Me.GroupBox2.Controls.Add(Me.PicNU3)
        Me.GroupBox2.Controls.Add(Me.PicNU2)
        Me.GroupBox2.Controls.Add(Me.PicNU1)
        Me.GroupBox2.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, -5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(166, 557)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'UcDateTime
        '
        Me.UcDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.Location = New System.Drawing.Point(13, 79)
        Me.UcDateTime.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcDateTime.Name = "UcDateTime"
        Me.UcDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcDateTime.Size = New System.Drawing.Size(145, 73)
        Me.UcDateTime.TabIndex = 25
        Me.UcDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.UCClockIconAppierance = False
        Me.UcDateTime.UCEnable = True
        Me.UcDateTime.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcDateTime.UCForeColor = System.Drawing.Color.Black
        '
        'PicExit
        '
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"), System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(6, 19)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(37, 30)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 24
        Me.PicExit.TabStop = False
        '
        'UcButtonDisableHook
        '
        Me.UcButtonDisableHook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcButtonDisableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDisableHook.Location = New System.Drawing.Point(7, 472)
        Me.UcButtonDisableHook.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonDisableHook.Name = "UcButtonDisableHook"
        Me.UcButtonDisableHook.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonDisableHook.Size = New System.Drawing.Size(153, 37)
        Me.UcButtonDisableHook.TabIndex = 21
        Me.UcButtonDisableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDisableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDisableHook.UCEnable = False
        Me.UcButtonDisableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonDisableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDisableHook.UCValue = "غیر فعال سازی Hook"
        '
        'UcButtonEnableHook
        '
        Me.UcButtonEnableHook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcButtonEnableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonEnableHook.Location = New System.Drawing.Point(7, 507)
        Me.UcButtonEnableHook.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonEnableHook.Name = "UcButtonEnableHook"
        Me.UcButtonEnableHook.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonEnableHook.Size = New System.Drawing.Size(153, 37)
        Me.UcButtonEnableHook.TabIndex = 20
        Me.UcButtonEnableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonEnableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonEnableHook.UCEnable = False
        Me.UcButtonEnableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonEnableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonEnableHook.UCValue = "فعال سازی Hook"
        '
        'PicNU4
        '
        Me.PicNU4.Location = New System.Drawing.Point(36, 346)
        Me.PicNU4.Name = "PicNU4"
        Me.PicNU4.Size = New System.Drawing.Size(90, 50)
        Me.PicNU4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU4.TabIndex = 9
        Me.PicNU4.TabStop = False
        '
        'PicNU3
        '
        Me.PicNU3.Location = New System.Drawing.Point(36, 296)
        Me.PicNU3.Name = "PicNU3"
        Me.PicNU3.Size = New System.Drawing.Size(90, 50)
        Me.PicNU3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU3.TabIndex = 9
        Me.PicNU3.TabStop = False
        '
        'PicNU2
        '
        Me.PicNU2.Location = New System.Drawing.Point(36, 246)
        Me.PicNU2.Name = "PicNU2"
        Me.PicNU2.Size = New System.Drawing.Size(90, 50)
        Me.PicNU2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU2.TabIndex = 9
        Me.PicNU2.TabStop = False
        '
        'PicNU1
        '
        Me.PicNU1.Location = New System.Drawing.Point(36, 196)
        Me.PicNU1.Name = "PicNU1"
        Me.PicNU1.Size = New System.Drawing.Size(90, 50)
        Me.PicNU1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU1.TabIndex = 9
        Me.PicNU1.TabStop = False
        '
        'UcFingerPrintCapturerSuprema
        '
        Me.UcFingerPrintCapturerSuprema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerSuprema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcFingerPrintCapturerSuprema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerSuprema.Enabled = False
        Me.UcFingerPrintCapturerSuprema.Location = New System.Drawing.Point(376, 7)
        Me.UcFingerPrintCapturerSuprema.Name = "UcFingerPrintCapturerSuprema"
        Me.UcFingerPrintCapturerSuprema.Scanner = Nothing
        Me.UcFingerPrintCapturerSuprema.Size = New System.Drawing.Size(444, 545)
        Me.UcFingerPrintCapturerSuprema.TabIndex = 0
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersonnelImage.Location = New System.Drawing.Point(376, 7)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(444, 545)
        Me.UcPersonnelImage.TabIndex = 25
        '
        'FrmcAttendane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(831, 562)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmcAttendane"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnlMain.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(false)
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicNU1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PicNU4 As PictureBox
    Friend WithEvents PicNU3 As PictureBox
    Friend WithEvents PicNU2 As PictureBox
    Friend WithEvents PicNU1 As PictureBox
    Friend WithEvents UcFingerPrintCapturerSuprema As R2CoreGUI.UCFingerPrintCapturerSuprema
    Friend WithEvents UcButtonDisableHook As R2CoreGUI.UCButton
    Friend WithEvents UcButtonEnableHook As R2CoreGUI.UCButton
    Friend WithEvents UcPersonnelImage As R2CoreGUI.UCPersonnelImage
    Friend WithEvents PicExit As PictureBox
    Friend WithEvents UcDateTime As R2CoreGUI.UCDateTime
    Friend WithEvents UcListBoxPersonnelEnterExit As R2CoreGUI.UCListBoxPersonnelEnterExit
End Class
