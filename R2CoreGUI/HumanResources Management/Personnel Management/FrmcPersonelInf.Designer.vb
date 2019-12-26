<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcPersonelInf
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
        Me.PnlPersonnelInfList = New System.Windows.Forms.Panel()
        Me.UcucPersonnelCollection = New R2CoreGUI.UCUCPersonnelCollection()
        Me.UcPersonnelPnlPersonnelInfList = New R2CoreGUI.UCPersonnel()
        Me.PnlPersonnelImage = New System.Windows.Forms.Panel()
        Me.UcButtonSelectPersonnelImage = New R2CoreGUI.UCButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcPersonnelImage = New R2CoreGUI.UCPersonnelImage()
        Me.UcButtonPersonnelImageSave = New R2CoreGUI.UCButton()
        Me.UcPersonnelPnlPersonnelImage = New R2CoreGUI.UCPersonnel()
        Me.PnlPersonnelFingerPrints = New System.Windows.Forms.Panel()
        Me.UcFingerPrintCapturerSuprema = New R2CoreGUI.UCFingerPrintCapturerSuprema()
        Me.UcPersonnelPnlPersonnelFingerPrints = New R2CoreGUI.UCPersonnel()
        Me.UcButtonRegisteringFingerPrint4 = New R2CoreGUI.UCButton()
        Me.UcButtonRegisteringFingerPrint3 = New R2CoreGUI.UCButton()
        Me.UcButtonRegisteringFingerPrint2 = New R2CoreGUI.UCButton()
        Me.UcButtonRegisteringFingerPrint1 = New R2CoreGUI.UCButton()
        Me.PnlInsertPersonnelPresent = New System.Windows.Forms.Panel()
        Me.UcButtonInsertpersonnelPresent = New R2CoreGUI.UCButton()
        Me.UcPersonnelPnlInsertPersonnelPresent = New R2CoreGUI.UCPersonnel()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PnlPersonnelInfList.SuspendLayout
        Me.PnlPersonnelImage.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.PnlPersonnelFingerPrints.SuspendLayout
        Me.PnlInsertPersonnelPresent.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlPersonnelInfList
        '
        Me.PnlPersonnelInfList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelInfList.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelInfList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelInfList.Controls.Add(Me.UcucPersonnelCollection)
        Me.PnlPersonnelInfList.Controls.Add(Me.UcPersonnelPnlPersonnelInfList)
        Me.PnlPersonnelInfList.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelInfList.Name = "PnlPersonnelInfList"
        Me.PnlPersonnelInfList.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelInfList.TabIndex = 200
        '
        'UcucPersonnelCollection
        '
        Me.UcucPersonnelCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucPersonnelCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucPersonnelCollection.Location = New System.Drawing.Point(5, 119)
        Me.UcucPersonnelCollection.Name = "UcucPersonnelCollection"
        Me.UcucPersonnelCollection.Padding = New System.Windows.Forms.Padding(3)
        Me.UcucPersonnelCollection.Size = New System.Drawing.Size(983, 392)
        Me.UcucPersonnelCollection.TabIndex = 1
        '
        'UcPersonnelPnlPersonnelInfList
        '
        Me.UcPersonnelPnlPersonnelInfList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelPnlPersonnelInfList.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelPnlPersonnelInfList.Location = New System.Drawing.Point(0, 3)
        Me.UcPersonnelPnlPersonnelInfList.Name = "UcPersonnelPnlPersonnelInfList"
        Me.UcPersonnelPnlPersonnelInfList.Padding = New System.Windows.Forms.Padding(10)
        Me.UcPersonnelPnlPersonnelInfList.Size = New System.Drawing.Size(992, 119)
        Me.UcPersonnelPnlPersonnelInfList.TabIndex = 0
        '
        'PnlPersonnelImage
        '
        Me.PnlPersonnelImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelImage.Controls.Add(Me.UcButtonSelectPersonnelImage)
        Me.PnlPersonnelImage.Controls.Add(Me.GroupBox1)
        Me.PnlPersonnelImage.Controls.Add(Me.UcButtonPersonnelImageSave)
        Me.PnlPersonnelImage.Controls.Add(Me.UcPersonnelPnlPersonnelImage)
        Me.PnlPersonnelImage.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelImage.Name = "PnlPersonnelImage"
        Me.PnlPersonnelImage.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelImage.TabIndex = 201
        '
        'UcButtonSelectPersonnelImage
        '
        Me.UcButtonSelectPersonnelImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSelectPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSelectPersonnelImage.Location = New System.Drawing.Point(800, 465)
        Me.UcButtonSelectPersonnelImage.Name = "UcButtonSelectPersonnelImage"
        Me.UcButtonSelectPersonnelImage.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonSelectPersonnelImage.Size = New System.Drawing.Size(96, 42)
        Me.UcButtonSelectPersonnelImage.TabIndex = 3
        Me.UcButtonSelectPersonnelImage.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonSelectPersonnelImage.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSelectPersonnelImage.UCEnable = true
        Me.UcButtonSelectPersonnelImage.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSelectPersonnelImage.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSelectPersonnelImage.UCValue = "انتخاب تصویر"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UcPersonnelImage)
        Me.GroupBox1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(596, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 319)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "تصویر"
        '
        'UcPersonnelImage
        '
        Me.UcPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersonnelImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPersonnelImage.Location = New System.Drawing.Point(3, 27)
        Me.UcPersonnelImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcPersonnelImage.Name = "UcPersonnelImage"
        Me.UcPersonnelImage.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcPersonnelImage.Size = New System.Drawing.Size(297, 289)
        Me.UcPersonnelImage.TabIndex = 1
        '
        'UcButtonPersonnelImageSave
        '
        Me.UcButtonPersonnelImageSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonPersonnelImageSave.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonPersonnelImageSave.Location = New System.Drawing.Point(696, 465)
        Me.UcButtonPersonnelImageSave.Name = "UcButtonPersonnelImageSave"
        Me.UcButtonPersonnelImageSave.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonPersonnelImageSave.Size = New System.Drawing.Size(98, 42)
        Me.UcButtonPersonnelImageSave.TabIndex = 2
        Me.UcButtonPersonnelImageSave.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonPersonnelImageSave.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonPersonnelImageSave.UCEnable = true
        Me.UcButtonPersonnelImageSave.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonPersonnelImageSave.UCForeColor = System.Drawing.Color.White
        Me.UcButtonPersonnelImageSave.UCValue = "ذخیره تصویر"
        '
        'UcPersonnelPnlPersonnelImage
        '
        Me.UcPersonnelPnlPersonnelImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelPnlPersonnelImage.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelPnlPersonnelImage.Location = New System.Drawing.Point(91, 24)
        Me.UcPersonnelPnlPersonnelImage.Name = "UcPersonnelPnlPersonnelImage"
        Me.UcPersonnelPnlPersonnelImage.Padding = New System.Windows.Forms.Padding(10)
        Me.UcPersonnelPnlPersonnelImage.Size = New System.Drawing.Size(818, 119)
        Me.UcPersonnelPnlPersonnelImage.TabIndex = 0
        Me.UcPersonnelPnlPersonnelImage.UCViewButtons = false
        '
        'PnlPersonnelFingerPrints
        '
        Me.PnlPersonnelFingerPrints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersonnelFingerPrints.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersonnelFingerPrints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcFingerPrintCapturerSuprema)
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcPersonnelPnlPersonnelFingerPrints)
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcButtonRegisteringFingerPrint4)
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcButtonRegisteringFingerPrint3)
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcButtonRegisteringFingerPrint2)
        Me.PnlPersonnelFingerPrints.Controls.Add(Me.UcButtonRegisteringFingerPrint1)
        Me.PnlPersonnelFingerPrints.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersonnelFingerPrints.Name = "PnlPersonnelFingerPrints"
        Me.PnlPersonnelFingerPrints.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersonnelFingerPrints.TabIndex = 202
        '
        'UcFingerPrintCapturerSuprema
        '
        Me.UcFingerPrintCapturerSuprema.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerSuprema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcFingerPrintCapturerSuprema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerSuprema.Enabled = false
        Me.UcFingerPrintCapturerSuprema.Location = New System.Drawing.Point(246, 8)
        Me.UcFingerPrintCapturerSuprema.Name = "UcFingerPrintCapturerSuprema"
        Me.UcFingerPrintCapturerSuprema.Scanner = Nothing
        Me.UcFingerPrintCapturerSuprema.Size = New System.Drawing.Size(500, 494)
        Me.UcFingerPrintCapturerSuprema.TabIndex = 1
        Me.UcFingerPrintCapturerSuprema.Visible = false
        '
        'UcPersonnelPnlPersonnelFingerPrints
        '
        Me.UcPersonnelPnlPersonnelFingerPrints.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelPnlPersonnelFingerPrints.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelPnlPersonnelFingerPrints.Location = New System.Drawing.Point(95, 24)
        Me.UcPersonnelPnlPersonnelFingerPrints.Name = "UcPersonnelPnlPersonnelFingerPrints"
        Me.UcPersonnelPnlPersonnelFingerPrints.Padding = New System.Windows.Forms.Padding(10)
        Me.UcPersonnelPnlPersonnelFingerPrints.Size = New System.Drawing.Size(803, 119)
        Me.UcPersonnelPnlPersonnelFingerPrints.TabIndex = 0
        Me.UcPersonnelPnlPersonnelFingerPrints.UCViewButtons = false
        '
        'UcButtonRegisteringFingerPrint4
        '
        Me.UcButtonRegisteringFingerPrint4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonRegisteringFingerPrint4.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonRegisteringFingerPrint4.Location = New System.Drawing.Point(721, 332)
        Me.UcButtonRegisteringFingerPrint4.Name = "UcButtonRegisteringFingerPrint4"
        Me.UcButtonRegisteringFingerPrint4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonRegisteringFingerPrint4.Size = New System.Drawing.Size(173, 48)
        Me.UcButtonRegisteringFingerPrint4.TabIndex = 5
        Me.UcButtonRegisteringFingerPrint4.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonRegisteringFingerPrint4.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonRegisteringFingerPrint4.UCEnable = false
        Me.UcButtonRegisteringFingerPrint4.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonRegisteringFingerPrint4.UCForeColor = System.Drawing.Color.White
        Me.UcButtonRegisteringFingerPrint4.UCValue = "ثبت اثر انگشت چهارم"
        '
        'UcButtonRegisteringFingerPrint3
        '
        Me.UcButtonRegisteringFingerPrint3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonRegisteringFingerPrint3.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonRegisteringFingerPrint3.Location = New System.Drawing.Point(721, 278)
        Me.UcButtonRegisteringFingerPrint3.Name = "UcButtonRegisteringFingerPrint3"
        Me.UcButtonRegisteringFingerPrint3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonRegisteringFingerPrint3.Size = New System.Drawing.Size(173, 48)
        Me.UcButtonRegisteringFingerPrint3.TabIndex = 4
        Me.UcButtonRegisteringFingerPrint3.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonRegisteringFingerPrint3.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonRegisteringFingerPrint3.UCEnable = false
        Me.UcButtonRegisteringFingerPrint3.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonRegisteringFingerPrint3.UCForeColor = System.Drawing.Color.White
        Me.UcButtonRegisteringFingerPrint3.UCValue = "ثبت اثر انگشت سوم"
        '
        'UcButtonRegisteringFingerPrint2
        '
        Me.UcButtonRegisteringFingerPrint2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonRegisteringFingerPrint2.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonRegisteringFingerPrint2.Location = New System.Drawing.Point(721, 224)
        Me.UcButtonRegisteringFingerPrint2.Name = "UcButtonRegisteringFingerPrint2"
        Me.UcButtonRegisteringFingerPrint2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonRegisteringFingerPrint2.Size = New System.Drawing.Size(173, 48)
        Me.UcButtonRegisteringFingerPrint2.TabIndex = 3
        Me.UcButtonRegisteringFingerPrint2.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonRegisteringFingerPrint2.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonRegisteringFingerPrint2.UCEnable = false
        Me.UcButtonRegisteringFingerPrint2.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonRegisteringFingerPrint2.UCForeColor = System.Drawing.Color.White
        Me.UcButtonRegisteringFingerPrint2.UCValue = "ثبت اثر انگشت دوم"
        '
        'UcButtonRegisteringFingerPrint1
        '
        Me.UcButtonRegisteringFingerPrint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonRegisteringFingerPrint1.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonRegisteringFingerPrint1.Location = New System.Drawing.Point(721, 170)
        Me.UcButtonRegisteringFingerPrint1.Name = "UcButtonRegisteringFingerPrint1"
        Me.UcButtonRegisteringFingerPrint1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonRegisteringFingerPrint1.Size = New System.Drawing.Size(173, 48)
        Me.UcButtonRegisteringFingerPrint1.TabIndex = 2
        Me.UcButtonRegisteringFingerPrint1.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonRegisteringFingerPrint1.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonRegisteringFingerPrint1.UCEnable = false
        Me.UcButtonRegisteringFingerPrint1.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonRegisteringFingerPrint1.UCForeColor = System.Drawing.Color.White
        Me.UcButtonRegisteringFingerPrint1.UCValue = "ثبت اثر انگشت اول"
        '
        'PnlInsertPersonnelPresent
        '
        Me.PnlInsertPersonnelPresent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlInsertPersonnelPresent.BackColor = System.Drawing.Color.Transparent
        Me.PnlInsertPersonnelPresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInsertPersonnelPresent.Controls.Add(Me.UcButtonInsertpersonnelPresent)
        Me.PnlInsertPersonnelPresent.Controls.Add(Me.UcPersonnelPnlInsertPersonnelPresent)
        Me.PnlInsertPersonnelPresent.Controls.Add(Me.DateTimePicker)
        Me.PnlInsertPersonnelPresent.Location = New System.Drawing.Point(5, 50)
        Me.PnlInsertPersonnelPresent.Name = "PnlInsertPersonnelPresent"
        Me.PnlInsertPersonnelPresent.Size = New System.Drawing.Size(995, 512)
        Me.PnlInsertPersonnelPresent.TabIndex = 203
        '
        'UcButtonInsertpersonnelPresent
        '
        Me.UcButtonInsertpersonnelPresent.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonInsertpersonnelPresent.Location = New System.Drawing.Point(84, 196)
        Me.UcButtonInsertpersonnelPresent.Name = "UcButtonInsertpersonnelPresent"
        Me.UcButtonInsertpersonnelPresent.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonInsertpersonnelPresent.Size = New System.Drawing.Size(105, 40)
        Me.UcButtonInsertpersonnelPresent.TabIndex = 335
        Me.UcButtonInsertpersonnelPresent.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonInsertpersonnelPresent.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonInsertpersonnelPresent.UCEnable = true
        Me.UcButtonInsertpersonnelPresent.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonInsertpersonnelPresent.UCForeColor = System.Drawing.Color.White
        Me.UcButtonInsertpersonnelPresent.UCValue = "ثبت حاضری"
        '
        'UcPersonnelPnlInsertPersonnelPresent
        '
        Me.UcPersonnelPnlInsertPersonnelPresent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersonnelPnlInsertPersonnelPresent.BackColor = System.Drawing.Color.Transparent
        Me.UcPersonnelPnlInsertPersonnelPresent.Location = New System.Drawing.Point(74, 24)
        Me.UcPersonnelPnlInsertPersonnelPresent.Name = "UcPersonnelPnlInsertPersonnelPresent"
        Me.UcPersonnelPnlInsertPersonnelPresent.Padding = New System.Windows.Forms.Padding(10)
        Me.UcPersonnelPnlInsertPersonnelPresent.Size = New System.Drawing.Size(819, 119)
        Me.UcPersonnelPnlInsertPersonnelPresent.TabIndex = 334
        Me.UcPersonnelPnlInsertPersonnelPresent.UCViewButtons = false
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePicker.Font = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(86, 167)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker.RightToLeftLayout = true
        Me.DateTimePicker.ShowUpDown = true
        Me.DateTimePicker.Size = New System.Drawing.Size(184, 23)
        Me.DateTimePicker.TabIndex = 333
        '
        'FrmcPersonelInf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersonnelInfList)
        Me.Controls.Add(Me.PnlPersonnelImage)
        Me.Controls.Add(Me.PnlInsertPersonnelPresent)
        Me.Controls.Add(Me.PnlPersonnelFingerPrints)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcPersonelInf"
        Me.Text = "FrmcPersonelInf"
        Me.Controls.SetChildIndex(Me.PnlPersonnelFingerPrints, 0)
        Me.Controls.SetChildIndex(Me.PnlInsertPersonnelPresent, 0)
        Me.Controls.SetChildIndex(Me.PnlPersonnelImage, 0)
        Me.Controls.SetChildIndex(Me.PnlPersonnelInfList, 0)
        Me.PnlPersonnelInfList.ResumeLayout(false)
        Me.PnlPersonnelImage.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.PnlPersonnelFingerPrints.ResumeLayout(false)
        Me.PnlInsertPersonnelPresent.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlPersonnelInfList As Panel
    Friend WithEvents UcucPersonnelCollection As UCUCPersonnelCollection
    Friend WithEvents UcPersonnelPnlPersonnelInfList As UCPersonnel
    Friend WithEvents PnlPersonnelImage As Panel
    Friend WithEvents UcButtonPersonnelImageSave As UCButton
    Friend WithEvents UcPersonnelImage As UCPersonnelImage
    Friend WithEvents UcPersonnelPnlPersonnelImage As UCPersonnel
    Friend WithEvents UcButtonSelectPersonnelImage As UCButton
    Friend WithEvents PnlPersonnelFingerPrints As Panel
    Friend WithEvents UcPersonnelPnlPersonnelFingerPrints As UCPersonnel
    Friend WithEvents UcButtonRegisteringFingerPrint4 As UCButton
    Friend WithEvents UcButtonRegisteringFingerPrint3 As UCButton
    Friend WithEvents UcButtonRegisteringFingerPrint2 As UCButton
    Friend WithEvents UcButtonRegisteringFingerPrint1 As UCButton
    Friend WithEvents UcFingerPrintCapturerSuprema As UCFingerPrintCapturerSuprema
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PnlInsertPersonnelPresent As Panel
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents UcButtonInsertpersonnelPresent As UCButton
    Friend WithEvents UcPersonnelPnlInsertPersonnelPresent As UCPersonnel
End Class
