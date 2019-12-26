Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFingerPrintCapturerDermalog
    Inherits UCGeneral

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.TxtReport = New System.Windows.Forms.TextBox()
        Me.BtnTxtReportClear = New System.Windows.Forms.Button()
        Me.PicFingerPrint = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnInitialize = New System.Windows.Forms.Button()
        Me.BtnShowDialog = New System.Windows.Forms.Button()
        Me.BtnDeviceInformation = New System.Windows.Forms.Button()
        Me.BtnViewProperties = New System.Windows.Forms.Button()
        Me.BtnDeviceID = New System.Windows.Forms.Button()
        Me.BtnDisplayTextProperty = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnLoadImage = New System.Windows.Forms.Button()
        Me.BtnFreez = New System.Windows.Forms.Button()
        Me.BtnUnfreez = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.BtnSegmentation = New System.Windows.Forms.Button()
        Me.BtnAddFP = New System.Windows.Forms.Button()
        Me.BtnNistQuality = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.PnlFPs = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblFPCount = New System.Windows.Forms.Label()
        Me.BtnSaveFP = New System.Windows.Forms.Button()
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox9.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'TxtReport
        '
        Me.TxtReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TxtReport.Location = New System.Drawing.Point(220, 228)
        Me.TxtReport.Multiline = true
        Me.TxtReport.Name = "TxtReport"
        Me.TxtReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtReport.Size = New System.Drawing.Size(157, 256)
        Me.TxtReport.TabIndex = 3
        '
        'BtnTxtReportClear
        '
        Me.BtnTxtReportClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnTxtReportClear.BackColor = System.Drawing.Color.Red
        Me.BtnTxtReportClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTxtReportClear.ForeColor = System.Drawing.Color.White
        Me.BtnTxtReportClear.Location = New System.Drawing.Point(315, 240)
        Me.BtnTxtReportClear.Name = "BtnTxtReportClear"
        Me.BtnTxtReportClear.Size = New System.Drawing.Size(53, 23)
        Me.BtnTxtReportClear.TabIndex = 25
        Me.BtnTxtReportClear.Text = "Clear"
        Me.BtnTxtReportClear.UseVisualStyleBackColor = false
        '
        'PicFingerPrint
        '
        Me.PicFingerPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicFingerPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFingerPrint.Location = New System.Drawing.Point(220, 6)
        Me.PicFingerPrint.Name = "PicFingerPrint"
        Me.PicFingerPrint.Size = New System.Drawing.Size(157, 216)
        Me.PicFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFingerPrint.TabIndex = 26
        Me.PicFingerPrint.TabStop = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnInitialize)
        Me.GroupBox1.Controls.Add(Me.BtnShowDialog)
        Me.GroupBox1.Controls.Add(Me.BtnDeviceInformation)
        Me.GroupBox1.Controls.Add(Me.BtnViewProperties)
        Me.GroupBox1.Controls.Add(Me.BtnDeviceID)
        Me.GroupBox1.Controls.Add(Me.BtnDisplayTextProperty)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 141)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "ScannerManager"
        '
        'BtnInitialize
        '
        Me.BtnInitialize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnInitialize.BackColor = System.Drawing.Color.Red
        Me.BtnInitialize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnInitialize.ForeColor = System.Drawing.Color.White
        Me.BtnInitialize.Location = New System.Drawing.Point(5, 16)
        Me.BtnInitialize.Name = "BtnInitialize"
        Me.BtnInitialize.Size = New System.Drawing.Size(75, 76)
        Me.BtnInitialize.TabIndex = 0
        Me.BtnInitialize.Text = "Initialize"
        Me.BtnInitialize.UseVisualStyleBackColor = false
        '
        'BtnShowDialog
        '
        Me.BtnShowDialog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnShowDialog.BackColor = System.Drawing.Color.Orchid
        Me.BtnShowDialog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowDialog.ForeColor = System.Drawing.Color.White
        Me.BtnShowDialog.Location = New System.Drawing.Point(86, 17)
        Me.BtnShowDialog.Name = "BtnShowDialog"
        Me.BtnShowDialog.Size = New System.Drawing.Size(123, 23)
        Me.BtnShowDialog.TabIndex = 8
        Me.BtnShowDialog.Text = "ShowDialog"
        Me.BtnShowDialog.UseVisualStyleBackColor = false
        '
        'BtnDeviceInformation
        '
        Me.BtnDeviceInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnDeviceInformation.BackColor = System.Drawing.Color.LightPink
        Me.BtnDeviceInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeviceInformation.Location = New System.Drawing.Point(87, 98)
        Me.BtnDeviceInformation.Name = "BtnDeviceInformation"
        Me.BtnDeviceInformation.Size = New System.Drawing.Size(122, 39)
        Me.BtnDeviceInformation.TabIndex = 11
        Me.BtnDeviceInformation.Text = "Device Information"
        Me.BtnDeviceInformation.UseVisualStyleBackColor = false
        '
        'BtnViewProperties
        '
        Me.BtnViewProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnViewProperties.BackColor = System.Drawing.Color.Fuchsia
        Me.BtnViewProperties.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewProperties.ForeColor = System.Drawing.Color.White
        Me.BtnViewProperties.Location = New System.Drawing.Point(86, 69)
        Me.BtnViewProperties.Name = "BtnViewProperties"
        Me.BtnViewProperties.Size = New System.Drawing.Size(123, 23)
        Me.BtnViewProperties.TabIndex = 12
        Me.BtnViewProperties.Text = "ViewPropertis"
        Me.BtnViewProperties.UseVisualStyleBackColor = false
        '
        'BtnDeviceID
        '
        Me.BtnDeviceID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnDeviceID.BackColor = System.Drawing.Color.Magenta
        Me.BtnDeviceID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeviceID.ForeColor = System.Drawing.Color.White
        Me.BtnDeviceID.Location = New System.Drawing.Point(86, 43)
        Me.BtnDeviceID.Name = "BtnDeviceID"
        Me.BtnDeviceID.Size = New System.Drawing.Size(123, 23)
        Me.BtnDeviceID.TabIndex = 13
        Me.BtnDeviceID.Text = "DeviceID"
        Me.BtnDeviceID.UseVisualStyleBackColor = false
        '
        'BtnDisplayTextProperty
        '
        Me.BtnDisplayTextProperty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnDisplayTextProperty.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnDisplayTextProperty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDisplayTextProperty.Location = New System.Drawing.Point(6, 98)
        Me.BtnDisplayTextProperty.Name = "BtnDisplayTextProperty"
        Me.BtnDisplayTextProperty.Size = New System.Drawing.Size(75, 39)
        Me.BtnDisplayTextProperty.TabIndex = 14
        Me.BtnDisplayTextProperty.Text = "DisplayTextProperty"
        Me.BtnDisplayTextProperty.UseVisualStyleBackColor = false
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BtnLoadImage)
        Me.GroupBox3.Controls.Add(Me.BtnFreez)
        Me.GroupBox3.Controls.Add(Me.BtnUnfreez)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 114)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Image"
        '
        'BtnLoadImage
        '
        Me.BtnLoadImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnLoadImage.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnLoadImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoadImage.ForeColor = System.Drawing.Color.White
        Me.BtnLoadImage.Location = New System.Drawing.Point(3, 15)
        Me.BtnLoadImage.Name = "BtnLoadImage"
        Me.BtnLoadImage.Size = New System.Drawing.Size(104, 24)
        Me.BtnLoadImage.TabIndex = 15
        Me.BtnLoadImage.Text = "LoadImage"
        Me.BtnLoadImage.UseVisualStyleBackColor = false
        '
        'BtnFreez
        '
        Me.BtnFreez.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnFreez.BackColor = System.Drawing.Color.Black
        Me.BtnFreez.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFreez.ForeColor = System.Drawing.Color.White
        Me.BtnFreez.Location = New System.Drawing.Point(3, 77)
        Me.BtnFreez.Name = "BtnFreez"
        Me.BtnFreez.Size = New System.Drawing.Size(104, 34)
        Me.BtnFreez.TabIndex = 9
        Me.BtnFreez.Text = "Freez"
        Me.BtnFreez.UseVisualStyleBackColor = false
        '
        'BtnUnfreez
        '
        Me.BtnUnfreez.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnUnfreez.BackColor = System.Drawing.Color.White
        Me.BtnUnfreez.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUnfreez.Location = New System.Drawing.Point(3, 41)
        Me.BtnUnfreez.Name = "BtnUnfreez"
        Me.BtnUnfreez.Size = New System.Drawing.Size(104, 35)
        Me.BtnUnfreez.TabIndex = 10
        Me.BtnUnfreez.Text = "UnFreez"
        Me.BtnUnfreez.UseVisualStyleBackColor = false
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.BtnSegmentation)
        Me.GroupBox9.Controls.Add(Me.BtnAddFP)
        Me.GroupBox9.Controls.Add(Me.BtnNistQuality)
        Me.GroupBox9.Location = New System.Drawing.Point(4, 202)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(113, 166)
        Me.GroupBox9.TabIndex = 328
        Me.GroupBox9.TabStop = false
        Me.GroupBox9.Text = "Segmentation"
        '
        'BtnSegmentation
        '
        Me.BtnSegmentation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnSegmentation.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnSegmentation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSegmentation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnSegmentation.ForeColor = System.Drawing.Color.White
        Me.BtnSegmentation.Location = New System.Drawing.Point(3, 19)
        Me.BtnSegmentation.Name = "BtnSegmentation"
        Me.BtnSegmentation.Size = New System.Drawing.Size(104, 50)
        Me.BtnSegmentation.TabIndex = 18
        Me.BtnSegmentation.Text = "Segmentation"
        Me.BtnSegmentation.UseVisualStyleBackColor = false
        '
        'BtnAddFP
        '
        Me.BtnAddFP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnAddFP.BackColor = System.Drawing.Color.Red
        Me.BtnAddFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddFP.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnAddFP.ForeColor = System.Drawing.Color.White
        Me.BtnAddFP.Location = New System.Drawing.Point(3, 68)
        Me.BtnAddFP.Name = "BtnAddFP"
        Me.BtnAddFP.Size = New System.Drawing.Size(104, 49)
        Me.BtnAddFP.TabIndex = 312
        Me.BtnAddFP.TabStop = false
        Me.BtnAddFP.Text = "Add To List"
        Me.BtnAddFP.UseVisualStyleBackColor = false
        '
        'BtnNistQuality
        '
        Me.BtnNistQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnNistQuality.BackColor = System.Drawing.Color.Aqua
        Me.BtnNistQuality.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNistQuality.Location = New System.Drawing.Point(3, 119)
        Me.BtnNistQuality.Name = "BtnNistQuality"
        Me.BtnNistQuality.Size = New System.Drawing.Size(104, 41)
        Me.BtnNistQuality.TabIndex = 17
        Me.BtnNistQuality.Text = "NISTQualityCheck"
        Me.BtnNistQuality.UseVisualStyleBackColor = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnStart)
        Me.GroupBox2.Controls.Add(Me.BtnStop)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 63)
        Me.GroupBox2.TabIndex = 329
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Capture"
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnStart.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnStart.Location = New System.Drawing.Point(3, 14)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(104, 46)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = false
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnStop.BackColor = System.Drawing.Color.Red
        Me.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnStop.ForeColor = System.Drawing.Color.White
        Me.BtnStop.Location = New System.Drawing.Point(113, 14)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(88, 46)
        Me.BtnStop.TabIndex = 3
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = false
        '
        'PnlFPs
        '
        Me.PnlFPs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.PnlFPs.AutoScroll = true
        Me.PnlFPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFPs.Location = New System.Drawing.Point(123, 202)
        Me.PnlFPs.Name = "PnlFPs"
        Me.PnlFPs.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlFPs.Size = New System.Drawing.Size(91, 258)
        Me.PnlFPs.TabIndex = 330
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(128, 463)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 332
        Me.Label14.Text = "FPCount"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFPCount
        '
        Me.LblFPCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.LblFPCount.BackColor = System.Drawing.Color.White
        Me.LblFPCount.Font = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.LblFPCount.ForeColor = System.Drawing.Color.Navy
        Me.LblFPCount.Location = New System.Drawing.Point(189, 464)
        Me.LblFPCount.Name = "LblFPCount"
        Me.LblFPCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblFPCount.Size = New System.Drawing.Size(21, 20)
        Me.LblFPCount.TabIndex = 331
        Me.LblFPCount.Text = "0"
        Me.LblFPCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSaveFP
        '
        Me.BtnSaveFP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnSaveFP.BackColor = System.Drawing.Color.Red
        Me.BtnSaveFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveFP.ForeColor = System.Drawing.Color.White
        Me.BtnSaveFP.Location = New System.Drawing.Point(293, 14)
        Me.BtnSaveFP.Name = "BtnSaveFP"
        Me.BtnSaveFP.Size = New System.Drawing.Size(75, 26)
        Me.BtnSaveFP.TabIndex = 28
        Me.BtnSaveFP.Text = "SaveImage"
        Me.BtnSaveFP.UseVisualStyleBackColor = false
        '
        'UCFingerPrintCapturerDermalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnSaveFP)
        Me.Controls.Add(Me.LblFPCount)
        Me.Controls.Add(Me.PnlFPs)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PicFingerPrint)
        Me.Controls.Add(Me.BtnTxtReportClear)
        Me.Controls.Add(Me.TxtReport)
        Me.Name = "UCFingerPrintCapturerDermalog"
        Me.Size = New System.Drawing.Size(389, 487)
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox9.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TxtReport As System.Windows.Forms.TextBox
    Friend WithEvents BtnTxtReportClear As System.Windows.Forms.Button
    Friend WithEvents PicFingerPrint As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInitialize As System.Windows.Forms.Button
    Friend WithEvents BtnShowDialog As System.Windows.Forms.Button
    Friend WithEvents BtnDeviceInformation As System.Windows.Forms.Button
    Friend WithEvents BtnViewProperties As System.Windows.Forms.Button
    Friend WithEvents BtnDeviceID As System.Windows.Forms.Button
    Friend WithEvents BtnDisplayTextProperty As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLoadImage As System.Windows.Forms.Button
    Friend WithEvents BtnFreez As System.Windows.Forms.Button
    Friend WithEvents BtnUnfreez As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSegmentation As System.Windows.Forms.Button
    Friend WithEvents BtnAddFP As System.Windows.Forms.Button
    Friend WithEvents BtnNistQuality As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents PnlFPs As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblFPCount As System.Windows.Forms.Label
    Friend WithEvents BtnSaveFP As System.Windows.Forms.Button

End Class
