Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFingerPrintCapturerFutronic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCFingerPrintCapturerFutronic))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicFingerPrint = New System.Windows.Forms.PictureBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtReport = New System.Windows.Forms.TextBox()
        Me.GroupBoxScanner = New System.Windows.Forms.GroupBox()
        Me.BtnUnInitialize = New System.Windows.Forms.Button()
        Me.BtnInitialize = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdentLimit = New System.Windows.Forms.TextBox()
        Me.NUDMaxFrames = New System.Windows.Forms.NumericUpDown()
        Me.NUDFARLevel = New System.Windows.Forms.NumericUpDown()
        Me.ChkMIOT = New System.Windows.Forms.CheckBox()
        Me.ChkDetectFake = New System.Windows.Forms.CheckBox()
        Me.ChkFastMode = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSaveImage = New System.Windows.Forms.Button()
        Me.BtnEnrollStop = New System.Windows.Forms.Button()
        Me.BtnEnroll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnVIStop = New System.Windows.Forms.Button()
        Me.BtnIdentification = New System.Windows.Forms.Button()
        Me.BtnVerification = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxScanner.SuspendLayout
        CType(Me.NUDMaxFrames,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NUDFARLevel,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(378, 276)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = false
        '
        'PicFingerPrint
        '
        Me.PicFingerPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFingerPrint.Location = New System.Drawing.Point(223, 9)
        Me.PicFingerPrint.Name = "PicFingerPrint"
        Me.PicFingerPrint.Size = New System.Drawing.Size(213, 218)
        Me.PicFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFingerPrint.TabIndex = 46
        Me.PicFingerPrint.TabStop = false
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(378, 242)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(49, 28)
        Me.BtnClear.TabIndex = 45
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = false
        '
        'TxtReport
        '
        Me.TxtReport.Location = New System.Drawing.Point(223, 233)
        Me.TxtReport.MaxLength = 5000000
        Me.TxtReport.Multiline = true
        Me.TxtReport.Name = "TxtReport"
        Me.TxtReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtReport.Size = New System.Drawing.Size(213, 256)
        Me.TxtReport.TabIndex = 44
        Me.TxtReport.Text = " "
        Me.TxtReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxScanner
        '
        Me.GroupBoxScanner.Controls.Add(Me.BtnUnInitialize)
        Me.GroupBoxScanner.Controls.Add(Me.BtnInitialize)
        Me.GroupBoxScanner.Controls.Add(Me.Label3)
        Me.GroupBoxScanner.Controls.Add(Me.TxtIdentLimit)
        Me.GroupBoxScanner.Controls.Add(Me.NUDMaxFrames)
        Me.GroupBoxScanner.Controls.Add(Me.NUDFARLevel)
        Me.GroupBoxScanner.Controls.Add(Me.ChkMIOT)
        Me.GroupBoxScanner.Controls.Add(Me.ChkDetectFake)
        Me.GroupBoxScanner.Controls.Add(Me.ChkFastMode)
        Me.GroupBoxScanner.Controls.Add(Me.Label2)
        Me.GroupBoxScanner.Controls.Add(Me.Label1)
        Me.GroupBoxScanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBoxScanner.Location = New System.Drawing.Point(11, 3)
        Me.GroupBoxScanner.Name = "GroupBoxScanner"
        Me.GroupBoxScanner.Size = New System.Drawing.Size(206, 224)
        Me.GroupBoxScanner.TabIndex = 48
        Me.GroupBoxScanner.TabStop = false
        Me.GroupBoxScanner.Text = "Scanner"
        '
        'BtnUnInitialize
        '
        Me.BtnUnInitialize.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnUnInitialize.ForeColor = System.Drawing.Color.Black
        Me.BtnUnInitialize.Location = New System.Drawing.Point(80, 19)
        Me.BtnUnInitialize.Name = "BtnUnInitialize"
        Me.BtnUnInitialize.Size = New System.Drawing.Size(75, 23)
        Me.BtnUnInitialize.TabIndex = 10
        Me.BtnUnInitialize.Text = "UnInitialize"
        Me.BtnUnInitialize.UseVisualStyleBackColor = false
        '
        'BtnInitialize
        '
        Me.BtnInitialize.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnInitialize.ForeColor = System.Drawing.Color.Black
        Me.BtnInitialize.Location = New System.Drawing.Point(6, 19)
        Me.BtnInitialize.Name = "BtnInitialize"
        Me.BtnInitialize.Size = New System.Drawing.Size(70, 23)
        Me.BtnInitialize.TabIndex = 9
        Me.BtnInitialize.Text = "Initialize"
        Me.BtnInitialize.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "IdentLimit"
        '
        'TxtIdentLimit
        '
        Me.TxtIdentLimit.Location = New System.Drawing.Point(71, 135)
        Me.TxtIdentLimit.Name = "TxtIdentLimit"
        Me.TxtIdentLimit.ReadOnly = true
        Me.TxtIdentLimit.Size = New System.Drawing.Size(120, 20)
        Me.TxtIdentLimit.TabIndex = 7
        '
        'NUDMaxFrames
        '
        Me.NUDMaxFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.NUDMaxFrames.ForeColor = System.Drawing.Color.Red
        Me.NUDMaxFrames.Location = New System.Drawing.Point(71, 186)
        Me.NUDMaxFrames.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUDMaxFrames.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDMaxFrames.Name = "NUDMaxFrames"
        Me.NUDMaxFrames.Size = New System.Drawing.Size(120, 20)
        Me.NUDMaxFrames.TabIndex = 6
        Me.NUDMaxFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUDMaxFrames.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUDFARLevel
        '
        Me.NUDFARLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.NUDFARLevel.ForeColor = System.Drawing.Color.Red
        Me.NUDFARLevel.Location = New System.Drawing.Point(71, 161)
        Me.NUDFARLevel.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUDFARLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDFARLevel.Name = "NUDFARLevel"
        Me.NUDFARLevel.Size = New System.Drawing.Size(120, 20)
        Me.NUDFARLevel.TabIndex = 5
        Me.NUDFARLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUDFARLevel.Value = New Decimal(New Integer() {166, 0, 0, 0})
        '
        'ChkMIOT
        '
        Me.ChkMIOT.AutoSize = true
        Me.ChkMIOT.Checked = true
        Me.ChkMIOT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMIOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkMIOT.Location = New System.Drawing.Point(63, 104)
        Me.ChkMIOT.Name = "ChkMIOT"
        Me.ChkMIOT.Size = New System.Drawing.Size(91, 17)
        Me.ChkMIOT.TabIndex = 4
        Me.ChkMIOT.Text = "Disable MIOT"
        Me.ChkMIOT.UseVisualStyleBackColor = true
        '
        'ChkDetectFake
        '
        Me.ChkDetectFake.AutoSize = true
        Me.ChkDetectFake.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkDetectFake.Location = New System.Drawing.Point(63, 81)
        Me.ChkDetectFake.Name = "ChkDetectFake"
        Me.ChkDetectFake.Size = New System.Drawing.Size(85, 17)
        Me.ChkDetectFake.TabIndex = 3
        Me.ChkDetectFake.Text = "Detect Fake"
        Me.ChkDetectFake.UseVisualStyleBackColor = true
        '
        'ChkFastMode
        '
        Me.ChkFastMode.AutoSize = true
        Me.ChkFastMode.Checked = true
        Me.ChkFastMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFastMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkFastMode.Location = New System.Drawing.Point(63, 58)
        Me.ChkFastMode.Name = "ChkFastMode"
        Me.ChkFastMode.Size = New System.Drawing.Size(76, 17)
        Me.ChkFastMode.TabIndex = 2
        Me.ChkFastMode.Text = "Fast Mode"
        Me.ChkFastMode.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MaxFrames"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FARLevel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSaveImage)
        Me.GroupBox1.Controls.Add(Me.BtnEnrollStop)
        Me.GroupBox1.Controls.Add(Me.BtnEnroll)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 142)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Capture"
        '
        'BtnSaveImage
        '
        Me.BtnSaveImage.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnSaveImage.ForeColor = System.Drawing.Color.White
        Me.BtnSaveImage.Location = New System.Drawing.Point(6, 98)
        Me.BtnSaveImage.Name = "BtnSaveImage"
        Me.BtnSaveImage.Size = New System.Drawing.Size(91, 38)
        Me.BtnSaveImage.TabIndex = 12
        Me.BtnSaveImage.Text = "Save Image"
        Me.BtnSaveImage.UseVisualStyleBackColor = false
        '
        'BtnEnrollStop
        '
        Me.BtnEnrollStop.BackColor = System.Drawing.Color.Red
        Me.BtnEnrollStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnrollStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnEnrollStop.ForeColor = System.Drawing.Color.Black
        Me.BtnEnrollStop.Location = New System.Drawing.Point(6, 59)
        Me.BtnEnrollStop.Name = "BtnEnrollStop"
        Me.BtnEnrollStop.Size = New System.Drawing.Size(88, 33)
        Me.BtnEnrollStop.TabIndex = 11
        Me.BtnEnrollStop.Text = "Stop"
        Me.BtnEnrollStop.UseVisualStyleBackColor = false
        '
        'BtnEnroll
        '
        Me.BtnEnroll.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnEnroll.ForeColor = System.Drawing.Color.Black
        Me.BtnEnroll.Location = New System.Drawing.Point(6, 28)
        Me.BtnEnroll.Name = "BtnEnroll"
        Me.BtnEnroll.Size = New System.Drawing.Size(88, 25)
        Me.BtnEnroll.TabIndex = 10
        Me.BtnEnroll.Text = "Enroll"
        Me.BtnEnroll.UseVisualStyleBackColor = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnVIStop)
        Me.GroupBox2.Controls.Add(Me.BtnIdentification)
        Me.GroupBox2.Controls.Add(Me.BtnVerification)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 375)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 115)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Verification - Identification"
        '
        'BtnVIStop
        '
        Me.BtnVIStop.BackColor = System.Drawing.Color.Gold
        Me.BtnVIStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVIStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnVIStop.ForeColor = System.Drawing.Color.Black
        Me.BtnVIStop.Location = New System.Drawing.Point(9, 81)
        Me.BtnVIStop.Name = "BtnVIStop"
        Me.BtnVIStop.Size = New System.Drawing.Size(88, 26)
        Me.BtnVIStop.TabIndex = 13
        Me.BtnVIStop.Text = "Stop"
        Me.BtnVIStop.UseVisualStyleBackColor = false
        '
        'BtnIdentification
        '
        Me.BtnIdentification.BackColor = System.Drawing.Color.Gold
        Me.BtnIdentification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnIdentification.ForeColor = System.Drawing.Color.Black
        Me.BtnIdentification.Location = New System.Drawing.Point(9, 51)
        Me.BtnIdentification.Name = "BtnIdentification"
        Me.BtnIdentification.Size = New System.Drawing.Size(88, 24)
        Me.BtnIdentification.TabIndex = 12
        Me.BtnIdentification.Text = "Identification"
        Me.BtnIdentification.UseVisualStyleBackColor = false
        '
        'BtnVerification
        '
        Me.BtnVerification.BackColor = System.Drawing.Color.Gold
        Me.BtnVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnVerification.ForeColor = System.Drawing.Color.Black
        Me.BtnVerification.Location = New System.Drawing.Point(9, 19)
        Me.BtnVerification.Name = "BtnVerification"
        Me.BtnVerification.Size = New System.Drawing.Size(88, 26)
        Me.BtnVerification.TabIndex = 11
        Me.BtnVerification.Text = "Verification"
        Me.BtnVerification.UseVisualStyleBackColor = false
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Enroll"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'UCFingerPrintCapturerFutronic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxScanner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicFingerPrint)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtReport)
        Me.Name = "UCFingerPrintCapturerFutronic"
        Me.Size = New System.Drawing.Size(447, 496)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxScanner.ResumeLayout(false)
        Me.GroupBoxScanner.PerformLayout
        CType(Me.NUDMaxFrames,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NUDFARLevel,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicFingerPrint As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents TxtReport As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxScanner As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInitialize As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtIdentLimit As System.Windows.Forms.TextBox
    Friend WithEvents NUDMaxFrames As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUDFARLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChkMIOT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDetectFake As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFastMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnUnInitialize As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEnroll As System.Windows.Forms.Button
    Friend WithEvents BtnEnrollStop As System.Windows.Forms.Button
    Friend WithEvents BtnVIStop As System.Windows.Forms.Button
    Friend WithEvents BtnIdentification As System.Windows.Forms.Button
    Friend WithEvents BtnVerification As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveImage As System.Windows.Forms.Button

End Class
