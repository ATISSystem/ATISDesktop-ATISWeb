<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcPersonnelAttendance
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlPersonnelAttendance = New System.Windows.Forms.Panel()
        Me.UcFingerPrintCapturerSuprema = New R2CoreGUI.UCFingerPrintCapturerSuprema()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.UcListBoxPersonnelEnterExit = New R2CoreGUI.UCListBoxPersonnelEnterExit()
        Me.UcDateTime = New R2CoreGUI.UCDateTime()
        Me.UcButtonDisableHook = New R2CoreGUI.UCButton()
        Me.UcButtonEnableHook = New R2CoreGUI.UCButton()
        Me.PicNU4 = New System.Windows.Forms.PictureBox()
        Me.PicNU3 = New System.Windows.Forms.PictureBox()
        Me.PicNU2 = New System.Windows.Forms.PictureBox()
        Me.PicNU1 = New System.Windows.Forms.PictureBox()
        Me.PnlPersonnelAttendance.SuspendLayout()
        CType(Me.PicNU4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNU3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNU2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNU1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlPersonnelAttendance
        '
        Me.PnlPersonnelAttendance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelAttendance.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcButtonDisableHook)
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcButtonEnableHook)
        Me.PnlPersonnelAttendance.Controls.Add(Me.PicNU4)
        Me.PnlPersonnelAttendance.Controls.Add(Me.PicNU3)
        Me.PnlPersonnelAttendance.Controls.Add(Me.PicNU2)
        Me.PnlPersonnelAttendance.Controls.Add(Me.PicNU1)
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcDateTime)
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcListBoxPersonnelEnterExit)
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcFingerPrintCapturerSuprema)
        Me.PnlPersonnelAttendance.Controls.Add(Me.UcPersonnelImage)
        Me.PnlPersonnelAttendance.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelAttendance.Name = "PnlPersonnelAttendance"
        Me.PnlPersonnelAttendance.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelAttendance.TabIndex = 201
        '
        'UcFingerPrintCapturerSuprema
        '
        Me.UcFingerPrintCapturerSuprema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerSuprema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcFingerPrintCapturerSuprema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerSuprema.Enabled = False
        Me.UcFingerPrintCapturerSuprema.Location = New System.Drawing.Point(541, 5)
        Me.UcFingerPrintCapturerSuprema.Name = "UcFingerPrintCapturerSuprema"
        Me.UcFingerPrintCapturerSuprema.Scanner = Nothing
        Me.UcFingerPrintCapturerSuprema.Size = New System.Drawing.Size(444, 500)
        Me.UcFingerPrintCapturerSuprema.TabIndex = 1
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersonnelImage.Location = New System.Drawing.Point(541, 5)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(3)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(444, 500)
        Me.UcPersonnelImage.TabIndex = 26
        '
        'UcListBoxPersonnelEnterExit
        '
        Me.UcListBoxPersonnelEnterExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UcListBoxPersonnelEnterExit.BackColor = System.Drawing.Color.Transparent
        Me.UcListBoxPersonnelEnterExit.Location = New System.Drawing.Point(340, 5)
        Me.UcListBoxPersonnelEnterExit.Name = "UcListBoxPersonnelEnterExit"
        Me.UcListBoxPersonnelEnterExit.Padding = New System.Windows.Forms.Padding(2)
        Me.UcListBoxPersonnelEnterExit.Size = New System.Drawing.Size(195, 500)
        Me.UcListBoxPersonnelEnterExit.TabIndex = 27
        Me.UcListBoxPersonnelEnterExit.UCBackColor = System.Drawing.Color.White
        Me.UcListBoxPersonnelEnterExit.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcListBoxPersonnelEnterExit.UCForeColor = System.Drawing.Color.Black
        Me.UcListBoxPersonnelEnterExit.UCTitle = "سوابق تردد پرسنل"
        '
        'UcDateTime
        '
        Me.UcDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.Location = New System.Drawing.Point(84, 31)
        Me.UcDateTime.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcDateTime.Name = "UcDateTime"
        Me.UcDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcDateTime.Size = New System.Drawing.Size(145, 73)
        Me.UcDateTime.TabIndex = 28
        Me.UcDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.UCClockIconAppierance = False
        Me.UcDateTime.UCEnable = True
        Me.UcDateTime.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcDateTime.UCForeColor = System.Drawing.Color.Black
        '
        'UcButtonDisableHook
        '
        Me.UcButtonDisableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDisableHook.Location = New System.Drawing.Point(76, 406)
        Me.UcButtonDisableHook.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonDisableHook.Name = "UcButtonDisableHook"
        Me.UcButtonDisableHook.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonDisableHook.Size = New System.Drawing.Size(153, 37)
        Me.UcButtonDisableHook.TabIndex = 34
        Me.UcButtonDisableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDisableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDisableHook.UCEnable = False
        Me.UcButtonDisableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonDisableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDisableHook.UCValue = "غیر فعال سازی Hook"
        '
        'UcButtonEnableHook
        '
        Me.UcButtonEnableHook.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonEnableHook.Location = New System.Drawing.Point(76, 441)
        Me.UcButtonEnableHook.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonEnableHook.Name = "UcButtonEnableHook"
        Me.UcButtonEnableHook.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonEnableHook.Size = New System.Drawing.Size(153, 37)
        Me.UcButtonEnableHook.TabIndex = 33
        Me.UcButtonEnableHook.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonEnableHook.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonEnableHook.UCEnable = False
        Me.UcButtonEnableHook.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonEnableHook.UCForeColor = System.Drawing.Color.White
        Me.UcButtonEnableHook.UCValue = "فعال سازی Hook"
        '
        'PicNU4
        '
        Me.PicNU4.Location = New System.Drawing.Point(113, 296)
        Me.PicNU4.Name = "PicNU4"
        Me.PicNU4.Size = New System.Drawing.Size(90, 50)
        Me.PicNU4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU4.TabIndex = 29
        Me.PicNU4.TabStop = False
        '
        'PicNU3
        '
        Me.PicNU3.Location = New System.Drawing.Point(113, 246)
        Me.PicNU3.Name = "PicNU3"
        Me.PicNU3.Size = New System.Drawing.Size(90, 50)
        Me.PicNU3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU3.TabIndex = 30
        Me.PicNU3.TabStop = False
        '
        'PicNU2
        '
        Me.PicNU2.Location = New System.Drawing.Point(113, 196)
        Me.PicNU2.Name = "PicNU2"
        Me.PicNU2.Size = New System.Drawing.Size(90, 50)
        Me.PicNU2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU2.TabIndex = 31
        Me.PicNU2.TabStop = False
        '
        'PicNU1
        '
        Me.PicNU1.Location = New System.Drawing.Point(113, 146)
        Me.PicNU1.Name = "PicNU1"
        Me.PicNU1.Size = New System.Drawing.Size(90, 50)
        Me.PicNU1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNU1.TabIndex = 32
        Me.PicNU1.TabStop = False
        '
        'FrmcPersonnelAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersonnelAttendance)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonnelAttendance"
        Me.Text = "FrmcPersonnelAttendance"
        Me.Controls.SetChildIndex(Me.PnlPersonnelAttendance, 0)
        Me.PnlPersonnelAttendance.ResumeLayout(False)
        CType(Me.PicNU4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNU3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNU2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNU1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlPersonnelAttendance As Panel
    Friend WithEvents UcFingerPrintCapturerSuprema As UCFingerPrintCapturerSuprema
    Friend WithEvents UcPersonnelImage As UCPersonnelImage
    Friend WithEvents UcListBoxPersonnelEnterExit As UCListBoxPersonnelEnterExit
    Friend WithEvents UcDateTime As UCDateTime
    Friend WithEvents UcButtonDisableHook As UCButton
    Friend WithEvents UcButtonEnableHook As UCButton
    Friend WithEvents PicNU4 As PictureBox
    Friend WithEvents PicNU3 As PictureBox
    Friend WithEvents PicNU2 As PictureBox
    Friend WithEvents PicNU1 As PictureBox
End Class
