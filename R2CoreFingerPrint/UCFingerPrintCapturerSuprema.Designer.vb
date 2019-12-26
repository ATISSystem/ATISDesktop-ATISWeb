Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFingerPrintCapturerSuprema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCFingerPrintCapturerSuprema))
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtReport = New System.Windows.Forms.TextBox()
        Me.PicFingerPrint = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnUnInitialize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumberOfScanners = New System.Windows.Forms.TextBox()
        Me.BtnInitialize = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEnrolQualitySet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkDetectFake = New System.Windows.Forms.CheckBox()
        Me.TxtScannerType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtScannerID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUDSensitivity = New System.Windows.Forms.NumericUpDown()
        Me.ChkDetectCore = New System.Windows.Forms.CheckBox()
        Me.NUDBrightness = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbTimeout = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtScannerSerial = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnSaveImage = New System.Windows.Forms.Button()
        Me.BtnViewBestTemplate = New System.Windows.Forms.Button()
        Me.BtnAutoCapturing = New System.Windows.Forms.Button()
        Me.BtnSingleCapture = New System.Windows.Forms.Button()
        Me.TxtTemplateSize = New System.Windows.Forms.TextBox()
        Me.BtnExtract = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnStartCapturing = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAbort = New System.Windows.Forms.Button()
        Me.TxtEnrollQuality = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnStartCapturingIdentification = New System.Windows.Forms.Button()
        Me.ChkMatcherFastMode = New System.Windows.Forms.CheckBox()
        Me.BtnIdentification = New System.Windows.Forms.Button()
        Me.BtnVerification = New System.Windows.Forms.Button()
        Me.CmbScanTemplateType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbSecurityLevel = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.NUDSensitivity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NUDBrightness,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox3.SuspendLayout
        Me.GroupBox4.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(247, 150)
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(488, 217)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(49, 28)
        Me.BtnClear.TabIndex = 32
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = false
        '
        'TxtReport
        '
        Me.TxtReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TxtReport.Location = New System.Drawing.Point(226, 211)
        Me.TxtReport.MaxLength = 5000000
        Me.TxtReport.Multiline = true
        Me.TxtReport.Name = "TxtReport"
        Me.TxtReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtReport.Size = New System.Drawing.Size(323, 204)
        Me.TxtReport.TabIndex = 31
        Me.TxtReport.Text = " "
        Me.TxtReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PicFingerPrint
        '
        Me.PicFingerPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicFingerPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicFingerPrint.Location = New System.Drawing.Point(226, 9)
        Me.PicFingerPrint.Name = "PicFingerPrint"
        Me.PicFingerPrint.Size = New System.Drawing.Size(323, 196)
        Me.PicFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFingerPrint.TabIndex = 33
        Me.PicFingerPrint.TabStop = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnUnInitialize)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNumberOfScanners)
        Me.GroupBox1.Controls.Add(Me.BtnInitialize)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 270)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Scanner"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(155, 14)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(53, 25)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = false
        '
        'BtnUnInitialize
        '
        Me.BtnUnInitialize.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnUnInitialize.Location = New System.Drawing.Point(106, 15)
        Me.BtnUnInitialize.Name = "BtnUnInitialize"
        Me.BtnUnInitialize.Size = New System.Drawing.Size(48, 25)
        Me.BtnUnInitialize.TabIndex = 36
        Me.BtnUnInitialize.Text = "UnInit"
        Me.BtnUnInitialize.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ScannersTotal"
        '
        'TxtNumberOfScanners
        '
        Me.TxtNumberOfScanners.Location = New System.Drawing.Point(146, 41)
        Me.TxtNumberOfScanners.Name = "TxtNumberOfScanners"
        Me.TxtNumberOfScanners.ReadOnly = true
        Me.TxtNumberOfScanners.Size = New System.Drawing.Size(61, 20)
        Me.TxtNumberOfScanners.TabIndex = 33
        Me.TxtNumberOfScanners.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInitialize
        '
        Me.BtnInitialize.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnInitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnInitialize.Location = New System.Drawing.Point(6, 14)
        Me.BtnInitialize.Name = "BtnInitialize"
        Me.BtnInitialize.Size = New System.Drawing.Size(99, 25)
        Me.BtnInitialize.TabIndex = 32
        Me.BtnInitialize.Text = "Initialize Scanner"
        Me.BtnInitialize.UseVisualStyleBackColor = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEnrolQualitySet)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ChkDetectFake)
        Me.GroupBox2.Controls.Add(Me.TxtScannerType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtScannerID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.NUDSensitivity)
        Me.GroupBox2.Controls.Add(Me.ChkDetectCore)
        Me.GroupBox2.Controls.Add(Me.NUDBrightness)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CmbTimeout)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtScannerSerial)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 205)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Scanner Parameters"
        '
        'TxtEnrolQualitySet
        '
        Me.TxtEnrolQualitySet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtEnrolQualitySet.Location = New System.Drawing.Point(80, 159)
        Me.TxtEnrolQualitySet.Name = "TxtEnrolQualitySet"
        Me.TxtEnrolQualitySet.Size = New System.Drawing.Size(114, 20)
        Me.TxtEnrolQualitySet.TabIndex = 25
        Me.TxtEnrolQualitySet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "EnrolQuality"
        '
        'ChkDetectFake
        '
        Me.ChkDetectFake.AutoSize = true
        Me.ChkDetectFake.Checked = true
        Me.ChkDetectFake.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDetectFake.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkDetectFake.Location = New System.Drawing.Point(110, 184)
        Me.ChkDetectFake.Name = "ChkDetectFake"
        Me.ChkDetectFake.Size = New System.Drawing.Size(85, 17)
        Me.ChkDetectFake.TabIndex = 24
        Me.ChkDetectFake.Text = "Detect Fake"
        Me.ChkDetectFake.UseVisualStyleBackColor = true
        '
        'TxtScannerType
        '
        Me.TxtScannerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtScannerType.Location = New System.Drawing.Point(80, 66)
        Me.TxtScannerType.Name = "TxtScannerType"
        Me.TxtScannerType.ReadOnly = true
        Me.TxtScannerType.Size = New System.Drawing.Size(113, 20)
        Me.TxtScannerType.TabIndex = 22
        Me.TxtScannerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ScannerType"
        '
        'TxtScannerID
        '
        Me.TxtScannerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtScannerID.Location = New System.Drawing.Point(80, 44)
        Me.TxtScannerID.Name = "TxtScannerID"
        Me.TxtScannerID.ReadOnly = true
        Me.TxtScannerID.Size = New System.Drawing.Size(114, 20)
        Me.TxtScannerID.TabIndex = 20
        Me.TxtScannerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ScannerID"
        '
        'NUDSensitivity
        '
        Me.NUDSensitivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.NUDSensitivity.Location = New System.Drawing.Point(80, 136)
        Me.NUDSensitivity.Name = "NUDSensitivity"
        Me.NUDSensitivity.Size = New System.Drawing.Size(114, 20)
        Me.NUDSensitivity.TabIndex = 5
        Me.NUDSensitivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkDetectCore
        '
        Me.ChkDetectCore.AutoSize = true
        Me.ChkDetectCore.Checked = true
        Me.ChkDetectCore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDetectCore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkDetectCore.Location = New System.Drawing.Point(12, 184)
        Me.ChkDetectCore.Name = "ChkDetectCore"
        Me.ChkDetectCore.Size = New System.Drawing.Size(83, 17)
        Me.ChkDetectCore.TabIndex = 6
        Me.ChkDetectCore.Text = "Detect Core"
        Me.ChkDetectCore.UseVisualStyleBackColor = true
        '
        'NUDBrightness
        '
        Me.NUDBrightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.NUDBrightness.Location = New System.Drawing.Point(80, 113)
        Me.NUDBrightness.Name = "NUDBrightness"
        Me.NUDBrightness.Size = New System.Drawing.Size(114, 20)
        Me.NUDBrightness.TabIndex = 4
        Me.NUDBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Sensitivity"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Brightness"
        '
        'CmbTimeout
        '
        Me.CmbTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CmbTimeout.FormattingEnabled = true
        Me.CmbTimeout.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.CmbTimeout.Location = New System.Drawing.Point(80, 89)
        Me.CmbTimeout.Name = "CmbTimeout"
        Me.CmbTimeout.Size = New System.Drawing.Size(114, 21)
        Me.CmbTimeout.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Timeout"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ScannerSerial"
        '
        'TxtScannerSerial
        '
        Me.TxtScannerSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtScannerSerial.Location = New System.Drawing.Point(80, 19)
        Me.TxtScannerSerial.Multiline = true
        Me.TxtScannerSerial.Name = "TxtScannerSerial"
        Me.TxtScannerSerial.ReadOnly = true
        Me.TxtScannerSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtScannerSerial.Size = New System.Drawing.Size(114, 23)
        Me.TxtScannerSerial.TabIndex = 14
        Me.TxtScannerSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BtnSaveImage)
        Me.GroupBox3.Controls.Add(Me.BtnViewBestTemplate)
        Me.GroupBox3.Controls.Add(Me.BtnAutoCapturing)
        Me.GroupBox3.Controls.Add(Me.BtnSingleCapture)
        Me.GroupBox3.Controls.Add(Me.TxtTemplateSize)
        Me.GroupBox3.Controls.Add(Me.BtnExtract)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.BtnStartCapturing)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BtnAbort)
        Me.GroupBox3.Controls.Add(Me.TxtEnrollQuality)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 143)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Capturing"
        '
        'BtnSaveImage
        '
        Me.BtnSaveImage.BackColor = System.Drawing.Color.Yellow
        Me.BtnSaveImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnSaveImage.Location = New System.Drawing.Point(142, 94)
        Me.BtnSaveImage.Name = "BtnSaveImage"
        Me.BtnSaveImage.Size = New System.Drawing.Size(65, 45)
        Me.BtnSaveImage.TabIndex = 35
        Me.BtnSaveImage.Text = "Save Image"
        Me.BtnSaveImage.UseVisualStyleBackColor = false
        '
        'BtnViewBestTemplate
        '
        Me.BtnViewBestTemplate.BackColor = System.Drawing.Color.Yellow
        Me.BtnViewBestTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnViewBestTemplate.Location = New System.Drawing.Point(121, 36)
        Me.BtnViewBestTemplate.Name = "BtnViewBestTemplate"
        Me.BtnViewBestTemplate.Size = New System.Drawing.Size(86, 36)
        Me.BtnViewBestTemplate.TabIndex = 34
        Me.BtnViewBestTemplate.Text = "View Best Template"
        Me.BtnViewBestTemplate.UseVisualStyleBackColor = false
        '
        'BtnAutoCapturing
        '
        Me.BtnAutoCapturing.BackColor = System.Drawing.Color.LightCoral
        Me.BtnAutoCapturing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnAutoCapturing.Location = New System.Drawing.Point(77, 94)
        Me.BtnAutoCapturing.Name = "BtnAutoCapturing"
        Me.BtnAutoCapturing.Size = New System.Drawing.Size(63, 45)
        Me.BtnAutoCapturing.TabIndex = 33
        Me.BtnAutoCapturing.Text = "Auto Capturing"
        Me.BtnAutoCapturing.UseVisualStyleBackColor = false
        '
        'BtnSingleCapture
        '
        Me.BtnSingleCapture.BackColor = System.Drawing.Color.LightCoral
        Me.BtnSingleCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnSingleCapture.Location = New System.Drawing.Point(6, 13)
        Me.BtnSingleCapture.Name = "BtnSingleCapture"
        Me.BtnSingleCapture.Size = New System.Drawing.Size(109, 34)
        Me.BtnSingleCapture.TabIndex = 25
        Me.BtnSingleCapture.Text = "Capture Single Image"
        Me.BtnSingleCapture.UseVisualStyleBackColor = false
        '
        'TxtTemplateSize
        '
        Me.TxtTemplateSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtTemplateSize.Location = New System.Drawing.Point(77, 49)
        Me.TxtTemplateSize.Name = "TxtTemplateSize"
        Me.TxtTemplateSize.ReadOnly = true
        Me.TxtTemplateSize.Size = New System.Drawing.Size(36, 20)
        Me.TxtTemplateSize.TabIndex = 27
        Me.TxtTemplateSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExtract
        '
        Me.BtnExtract.BackColor = System.Drawing.Color.Yellow
        Me.BtnExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnExtract.Location = New System.Drawing.Point(121, 13)
        Me.BtnExtract.Name = "BtnExtract"
        Me.BtnExtract.Size = New System.Drawing.Size(86, 22)
        Me.BtnExtract.TabIndex = 26
        Me.BtnExtract.Text = "Extract"
        Me.BtnExtract.UseVisualStyleBackColor = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "TemplateSize"
        '
        'BtnStartCapturing
        '
        Me.BtnStartCapturing.BackColor = System.Drawing.Color.LightCoral
        Me.BtnStartCapturing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnStartCapturing.Location = New System.Drawing.Point(6, 94)
        Me.BtnStartCapturing.Name = "BtnStartCapturing"
        Me.BtnStartCapturing.Size = New System.Drawing.Size(71, 45)
        Me.BtnStartCapturing.TabIndex = 31
        Me.BtnStartCapturing.Text = "Start Capturing"
        Me.BtnStartCapturing.UseVisualStyleBackColor = false
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "EnrollQuality"
        '
        'BtnAbort
        '
        Me.BtnAbort.BackColor = System.Drawing.Color.Yellow
        Me.BtnAbort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnAbort.Location = New System.Drawing.Point(121, 72)
        Me.BtnAbort.Name = "BtnAbort"
        Me.BtnAbort.Size = New System.Drawing.Size(86, 23)
        Me.BtnAbort.TabIndex = 32
        Me.BtnAbort.Text = "Abort"
        Me.BtnAbort.UseVisualStyleBackColor = false
        '
        'TxtEnrollQuality
        '
        Me.TxtEnrollQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TxtEnrollQuality.Location = New System.Drawing.Point(77, 72)
        Me.TxtEnrollQuality.Name = "TxtEnrollQuality"
        Me.TxtEnrollQuality.ReadOnly = true
        Me.TxtEnrollQuality.Size = New System.Drawing.Size(36, 20)
        Me.TxtEnrollQuality.TabIndex = 29
        Me.TxtEnrollQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.BtnStartCapturingIdentification)
        Me.GroupBox4.Controls.Add(Me.ChkMatcherFastMode)
        Me.GroupBox4.Controls.Add(Me.BtnIdentification)
        Me.GroupBox4.Controls.Add(Me.BtnVerification)
        Me.GroupBox4.Controls.Add(Me.CmbScanTemplateType)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.CmbSecurityLevel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(546, 75)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Verification-Identification"
        '
        'BtnStartCapturingIdentification
        '
        Me.BtnStartCapturingIdentification.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnStartCapturingIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnStartCapturingIdentification.Location = New System.Drawing.Point(222, 35)
        Me.BtnStartCapturingIdentification.Name = "BtnStartCapturingIdentification"
        Me.BtnStartCapturingIdentification.Size = New System.Drawing.Size(109, 34)
        Me.BtnStartCapturingIdentification.TabIndex = 42
        Me.BtnStartCapturingIdentification.Text = "StartCapturing Identification"
        Me.BtnStartCapturingIdentification.UseVisualStyleBackColor = false
        '
        'ChkMatcherFastMode
        '
        Me.ChkMatcherFastMode.AutoSize = true
        Me.ChkMatcherFastMode.Checked = true
        Me.ChkMatcherFastMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMatcherFastMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.ChkMatcherFastMode.Location = New System.Drawing.Point(337, 16)
        Me.ChkMatcherFastMode.Name = "ChkMatcherFastMode"
        Me.ChkMatcherFastMode.Size = New System.Drawing.Size(73, 17)
        Me.ChkMatcherFastMode.TabIndex = 41
        Me.ChkMatcherFastMode.Text = "FastMode"
        Me.ChkMatcherFastMode.UseVisualStyleBackColor = true
        '
        'BtnIdentification
        '
        Me.BtnIdentification.BackColor = System.Drawing.Color.Yellow
        Me.BtnIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnIdentification.Location = New System.Drawing.Point(337, 35)
        Me.BtnIdentification.Name = "BtnIdentification"
        Me.BtnIdentification.Size = New System.Drawing.Size(86, 34)
        Me.BtnIdentification.TabIndex = 40
        Me.BtnIdentification.Text = "Identification"
        Me.BtnIdentification.UseVisualStyleBackColor = false
        '
        'BtnVerification
        '
        Me.BtnVerification.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnVerification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnVerification.Location = New System.Drawing.Point(222, 13)
        Me.BtnVerification.Name = "BtnVerification"
        Me.BtnVerification.Size = New System.Drawing.Size(109, 21)
        Me.BtnVerification.TabIndex = 39
        Me.BtnVerification.Text = "Verification"
        Me.BtnVerification.UseVisualStyleBackColor = false
        '
        'CmbScanTemplateType
        '
        Me.CmbScanTemplateType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CmbScanTemplateType.FormattingEnabled = true
        Me.CmbScanTemplateType.Items.AddRange(New Object() {"Suprema", "Iso19794_2", "Ansi378"})
        Me.CmbScanTemplateType.Location = New System.Drawing.Point(86, 44)
        Me.CmbScanTemplateType.Name = "CmbScanTemplateType"
        Me.CmbScanTemplateType.Size = New System.Drawing.Size(120, 21)
        Me.CmbScanTemplateType.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "template type"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Security Level"
        '
        'CmbSecurityLevel
        '
        Me.CmbSecurityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CmbSecurityLevel.FormattingEnabled = true
        Me.CmbSecurityLevel.Items.AddRange(New Object() {"1 (FAR1/100)", "2 (1/1,000)", "3 (1/10,000)", "4 (1/100,000)", "5 (1/1,000,000)", "6 (1/10,000,000)", "7 (1/100,000,000)"})
        Me.CmbSecurityLevel.Location = New System.Drawing.Point(86, 21)
        Me.CmbSecurityLevel.Name = "CmbSecurityLevel"
        Me.CmbSecurityLevel.Size = New System.Drawing.Size(120, 21)
        Me.CmbSecurityLevel.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(488, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = false
        '
        'UCFingerPrintCapturerSuprema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PicFingerPrint)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtReport)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "UCFingerPrintCapturerSuprema"
        Me.Size = New System.Drawing.Size(558, 494)
        CType(Me.PicFingerPrint,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.NUDSensitivity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NUDBrightness,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents TxtReport As System.Windows.Forms.TextBox
    Friend WithEvents PicFingerPrint As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnUnInitialize As System.Windows.Forms.Button
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents ChkDetectFake As System.Windows.Forms.CheckBox
    Friend WithEvents TxtScannerType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtScannerID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents NUDSensitivity As System.Windows.Forms.NumericUpDown
    Private WithEvents ChkDetectCore As System.Windows.Forms.CheckBox
    Private WithEvents NUDBrightness As System.Windows.Forms.NumericUpDown
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents CmbTimeout As System.Windows.Forms.ComboBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtScannerSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNumberOfScanners As System.Windows.Forms.TextBox
    Friend WithEvents BtnInitialize As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAutoCapturing As System.Windows.Forms.Button
    Friend WithEvents BtnAbort As System.Windows.Forms.Button
    Friend WithEvents BtnStartCapturing As System.Windows.Forms.Button
    Friend WithEvents BtnSingleCapture As System.Windows.Forms.Button
    Friend WithEvents BtnExtract As System.Windows.Forms.Button
    Friend WithEvents TxtTemplateSize As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEnrollQuality As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnIdentification As System.Windows.Forms.Button
    Friend WithEvents BtnVerification As System.Windows.Forms.Button
    Private WithEvents CmbScanTemplateType As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents CmbSecurityLevel As System.Windows.Forms.ComboBox
    Friend WithEvents TxtEnrolQualitySet As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnViewBestTemplate As System.Windows.Forms.Button
    Friend WithEvents BtnSaveImage As System.Windows.Forms.Button
    Private WithEvents ChkMatcherFastMode As System.Windows.Forms.CheckBox
    Friend WithEvents BtnStartCapturingIdentification As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
