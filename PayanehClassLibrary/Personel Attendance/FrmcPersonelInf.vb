
Imports R2Core
Imports R2CoreGUI
Imports R2Core.DepartementDoreManagement
Imports R2Core.PublicProc
Imports R2Core.DateAndTimeManagement
Imports R2Core.DatabaseManagement
Imports R2Core.LoginManagement
Imports R2CoreParkingSystem.ConfigurationManagement
Imports ParkingSystemAttendanceClassLibrary

Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms


Public Class FrmcPersonelInf
    Inherits FrmcGeneral




#Region " Windows Form Designer generated code "


    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picleft As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PicPersonel As AForge.Controls.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNationalCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtPFatherName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPNameFamily As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPId As System.Windows.Forms.TextBox
    Friend WithEvents BtnFile As System.Windows.Forms.Button
    Friend WithEvents BtnCamera As System.Windows.Forms.Button
    Friend WithEvents BtnSabt As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents UcFingerPrintCapturerSuprema As R2CoreFingerPrint.UCFingerPrintCapturerSuprema
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnGetFP1 As System.Windows.Forms.Button
    Friend WithEvents BtnSabtPicture As System.Windows.Forms.Button
    Friend WithEvents PicRefresh As AForge.Controls.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGetFP4 As System.Windows.Forms.Button
    Friend WithEvents BtnGetFP3 As System.Windows.Forms.Button
    Friend WithEvents BtnGetFP2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnInsertA As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcPersonelInf))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picleft = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnFile = New System.Windows.Forms.Button()
        Me.BtnCamera = New System.Windows.Forms.Button()
        Me.PicPersonel = New AForge.Controls.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNationalCode = New System.Windows.Forms.TextBox()
        Me.TxtPFatherName = New System.Windows.Forms.TextBox()
        Me.TxtPNameFamily = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPId = New System.Windows.Forms.TextBox()
        Me.BtnSabt = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnInsertA = New System.Windows.Forms.Button()
        Me.BtnGetFP4 = New System.Windows.Forms.Button()
        Me.BtnGetFP3 = New System.Windows.Forms.Button()
        Me.BtnGetFP2 = New System.Windows.Forms.Button()
        Me.BtnSabtPicture = New System.Windows.Forms.Button()
        Me.BtnGetFP1 = New System.Windows.Forms.Button()
        Me.PicRefresh = New AForge.Controls.PictureBox()
        Me.UcFingerPrintCapturerSuprema = New R2CoreFingerPrint.UCFingerPrintCapturerSuprema()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picleft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PicPersonel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(134, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "FrmcPersonelInf...."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Zar", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(101, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(186, 45)
        Me.Label34.TabIndex = 114
        Me.Label34.Text = "مشخصات پرسنل"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(0, 646)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1020, 11)
        Me.PictureBox4.TabIndex = 146
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1020, 11)
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'picleft
        '
        Me.picleft.BackColor = System.Drawing.Color.White
        Me.picleft.Image = CType(resources.GetObject("picleft.Image"), System.Drawing.Image)
        Me.picleft.Location = New System.Drawing.Point(77, 77)
        Me.picleft.Name = "picleft"
        Me.picleft.Size = New System.Drawing.Size(237, 15)
        Me.picleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picleft.TabIndex = 187
        Me.picleft.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.ForeColor = System.Drawing.Color.Chocolate
        Me.Panel1.Location = New System.Drawing.Point(-1, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 46)
        Me.Panel1.TabIndex = 305
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 23)
        Me.Label19.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 23)
        Me.Label20.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("B Zar", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(115, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 21)
        Me.Label2.TabIndex = 304
        Me.Label2.Text = "ثبت و ویرایش مشخصات پرسنل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("IRMehr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(421, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(123, 29)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "شماره کارت تردد :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnFile)
        Me.GroupBox4.Controls.Add(Me.BtnCamera)
        Me.GroupBox4.Controls.Add(Me.PicPersonel)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxtNationalCode)
        Me.GroupBox4.Controls.Add(Me.TxtPFatherName)
        Me.GroupBox4.Controls.Add(Me.TxtPNameFamily)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtPId)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(195, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(252, 592)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مشخصات پرسنلی"
        '
        'BtnFile
        '
        Me.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFile.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFile.Location = New System.Drawing.Point(6, 555)
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(240, 31)
        Me.BtnFile.TabIndex = 327
        Me.BtnFile.Text = "فایل"
        Me.BtnFile.UseVisualStyleBackColor = True
        '
        'BtnCamera
        '
        Me.BtnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCamera.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCamera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCamera.Location = New System.Drawing.Point(6, 520)
        Me.BtnCamera.Name = "BtnCamera"
        Me.BtnCamera.Size = New System.Drawing.Size(240, 31)
        Me.BtnCamera.TabIndex = 326
        Me.BtnCamera.Text = "دریافت از دوربین"
        Me.BtnCamera.UseVisualStyleBackColor = True
        '
        'PicPersonel
        '
        Me.PicPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicPersonel.Image = CType(resources.GetObject("PicPersonel.Image"), System.Drawing.Image)
        Me.PicPersonel.Location = New System.Drawing.Point(6, 193)
        Me.PicPersonel.Name = "PicPersonel"
        Me.PicPersonel.Size = New System.Drawing.Size(240, 321)
        Me.PicPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPersonel.TabIndex = 315
        Me.PicPersonel.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(58, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 325
        Me.Label8.Text = "تصویر پرسنل"
        '
        'TxtNationalCode
        '
        Me.TxtNationalCode.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtNationalCode.Location = New System.Drawing.Point(6, 131)
        Me.TxtNationalCode.Name = "TxtNationalCode"
        Me.TxtNationalCode.Size = New System.Drawing.Size(130, 29)
        Me.TxtNationalCode.TabIndex = 324
        Me.TxtNationalCode.Text = "1286939623"
        Me.TxtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPFatherName
        '
        Me.TxtPFatherName.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPFatherName.Location = New System.Drawing.Point(6, 98)
        Me.TxtPFatherName.Name = "TxtPFatherName"
        Me.TxtPFatherName.Size = New System.Drawing.Size(130, 29)
        Me.TxtPFatherName.TabIndex = 323
        Me.TxtPFatherName.Text = "محمود"
        Me.TxtPFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPNameFamily
        '
        Me.TxtPNameFamily.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPNameFamily.Location = New System.Drawing.Point(6, 65)
        Me.TxtPNameFamily.Name = "TxtPNameFamily"
        Me.TxtPNameFamily.Size = New System.Drawing.Size(130, 29)
        Me.TxtPNameFamily.TabIndex = 322
        Me.TxtPNameFamily.Text = "مرتضی شاهمرادی"
        Me.TxtPNameFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(140, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 24)
        Me.Label7.TabIndex = 321
        Me.Label7.Text = "کد ملی"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(140, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 320
        Me.Label6.Text = "نام و نام خانوادگی"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(140, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 319
        Me.Label5.Text = "نام پدر"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(140, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "کد پرسنلی"
        '
        'TxtPId
        '
        Me.TxtPId.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPId.Location = New System.Drawing.Point(6, 32)
        Me.TxtPId.Name = "TxtPId"
        Me.TxtPId.ReadOnly = True
        Me.TxtPId.Size = New System.Drawing.Size(130, 29)
        Me.TxtPId.TabIndex = 317
        Me.TxtPId.Text = "5245"
        Me.TxtPId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSabt
        '
        Me.BtnSabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSabt.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnSabt.Location = New System.Drawing.Point(4, 102)
        Me.BtnSabt.Name = "BtnSabt"
        Me.BtnSabt.Size = New System.Drawing.Size(174, 38)
        Me.BtnSabt.TabIndex = 306
        Me.BtnSabt.Text = "ثبت مشخصات"
        Me.BtnSabt.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Brown
        Me.BtnNew.Location = New System.Drawing.Point(4, 29)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(174, 69)
        Me.BtnNew.TabIndex = 307
        Me.BtnNew.Text = "ایجاد پرسنل جدید"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(320, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 598)
        Me.Panel2.TabIndex = 323
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker)
        Me.GroupBox1.Controls.Add(Me.BtnInsertA)
        Me.GroupBox1.Controls.Add(Me.BtnGetFP4)
        Me.GroupBox1.Controls.Add(Me.BtnGetFP3)
        Me.GroupBox1.Controls.Add(Me.BtnGetFP2)
        Me.GroupBox1.Controls.Add(Me.BtnSabtPicture)
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Controls.Add(Me.BtnGetFP1)
        Me.GroupBox1.Controls.Add(Me.BtnSabt)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 588)
        Me.GroupBox1.TabIndex = 325
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(4, 476)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.RightToLeft = RightToLeft.Yes
        Me.DateTimePicker.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker.TabIndex = 333
        '
        'BtnInsertA
        '
        Me.BtnInsertA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsertA.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnInsertA.ForeColor = System.Drawing.Color.Maroon
        Me.BtnInsertA.Location = New System.Drawing.Point(4, 437)
        Me.BtnInsertA.Name = "BtnInsertA"
        Me.BtnInsertA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnInsertA.Size = New System.Drawing.Size(174, 33)
        Me.BtnInsertA.TabIndex = 332
        Me.BtnInsertA.Text = "تزریق حاضری پرسنل"
        Me.BtnInsertA.UseVisualStyleBackColor = True
        '
        'BtnGetFP4
        '
        Me.BtnGetFP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetFP4.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnGetFP4.ForeColor = System.Drawing.Color.Green
        Me.BtnGetFP4.Location = New System.Drawing.Point(4, 373)
        Me.BtnGetFP4.Name = "BtnGetFP4"
        Me.BtnGetFP4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnGetFP4.Size = New System.Drawing.Size(174, 58)
        Me.BtnGetFP4.TabIndex = 331
        Me.BtnGetFP4.Text = "دریافت و ثبت اثر انگشت چهارم"
        Me.BtnGetFP4.UseVisualStyleBackColor = True
        '
        'BtnGetFP3
        '
        Me.BtnGetFP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetFP3.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnGetFP3.ForeColor = System.Drawing.Color.Green
        Me.BtnGetFP3.Location = New System.Drawing.Point(4, 309)
        Me.BtnGetFP3.Name = "BtnGetFP3"
        Me.BtnGetFP3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnGetFP3.Size = New System.Drawing.Size(174, 58)
        Me.BtnGetFP3.TabIndex = 330
        Me.BtnGetFP3.Text = "دریافت و ثبت اثر انگشت سوم"
        Me.BtnGetFP3.UseVisualStyleBackColor = True
        '
        'BtnGetFP2
        '
        Me.BtnGetFP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetFP2.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnGetFP2.ForeColor = System.Drawing.Color.Green
        Me.BtnGetFP2.Location = New System.Drawing.Point(4, 245)
        Me.BtnGetFP2.Name = "BtnGetFP2"
        Me.BtnGetFP2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnGetFP2.Size = New System.Drawing.Size(174, 58)
        Me.BtnGetFP2.TabIndex = 329
        Me.BtnGetFP2.Text = "دریافت و ثبت اثر انگشت دوم"
        Me.BtnGetFP2.UseVisualStyleBackColor = True
        '
        'BtnSabtPicture
        '
        Me.BtnSabtPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSabtPicture.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnSabtPicture.ForeColor = System.Drawing.Color.Red
        Me.BtnSabtPicture.Location = New System.Drawing.Point(4, 145)
        Me.BtnSabtPicture.Name = "BtnSabtPicture"
        Me.BtnSabtPicture.Size = New System.Drawing.Size(174, 31)
        Me.BtnSabtPicture.TabIndex = 328
        Me.BtnSabtPicture.Text = "ثبت تصویر"
        Me.BtnSabtPicture.UseVisualStyleBackColor = True
        '
        'BtnGetFP1
        '
        Me.BtnGetFP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetFP1.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnGetFP1.ForeColor = System.Drawing.Color.Green
        Me.BtnGetFP1.Location = New System.Drawing.Point(4, 181)
        Me.BtnGetFP1.Name = "BtnGetFP1"
        Me.BtnGetFP1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnGetFP1.Size = New System.Drawing.Size(174, 58)
        Me.BtnGetFP1.TabIndex = 309
        Me.BtnGetFP1.Text = "دریافت و ثبت اثر انگشت اول"
        Me.BtnGetFP1.UseVisualStyleBackColor = True
        '
        'UcFingerPrintCapturerSuprema
        '
        Me.UcFingerPrintCapturerSuprema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UcFingerPrintCapturerSuprema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerSuprema.Location = New System.Drawing.Point(323, 28)
        Me.UcFingerPrintCapturerSuprema.Name = "UcFingerPrintCapturerSuprema"
        Me.UcFingerPrintCapturerSuprema.Scanner = Nothing
        Me.UcFingerPrintCapturerSuprema.Size = New System.Drawing.Size(444, 597)
        Me.UcFingerPrintCapturerSuprema.TabIndex = 322
        '
        'PicRefresh
        '
        Me.PicRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRefresh.Image = CType(resources.GetObject("PicRefresh.Image"), System.Drawing.Image)
        Me.PicRefresh.Location = New System.Drawing.Point(12, 101)
        Me.PicRefresh.Name = "PicRefresh"
        Me.PicRefresh.Size = New System.Drawing.Size(31, 38)
        Me.PicRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRefresh.TabIndex = 324
        Me.PicRefresh.TabStop = False
        '
        'FrmcPersonelInf
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 657)
        Me.Controls.Add(Me.PicRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.picleft)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.UcFingerPrintCapturerSuprema)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 111)
        Me.Name = "FrmcPersonelInf"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmcdaemresidmoavagh"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picleft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PicPersonel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _DateTime As R2DateTime = New R2DateTime
    Private WithEvents SupremaControlTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer



#Region "Overrides"


    Protected Overrides Sub FrmRefreshGeneral()
        Try
        Catch ex As Exception
            Throw New Exception("FrmcPersonelInf.FrmRefreshGeneral" + vbCrLf + ex.Message.ToString)
        End Try
    End Sub

    Public Overrides Sub DisposeResources()
        Try
            UcFingerPrintCapturerSuprema.UCDisposeResources()
            SupremaControlTimer.Enabled = False
            SupremaControlTimer.Stop()
            R2Core.PublicProc.R2MClassPublicProcedures.Setkeyboardlayout("English")
        Catch ex As Exception
            Throw New Exception("FrmcPersonelInf.DisposeResources" + vbCrLf + ex.Message.ToString)
        End Try
    End Sub

    Protected Overrides Sub SetFrmFarsiName()
        myFrmFarsiName = "مشخصات پرسنل"
    End Sub
#End Region

#Region "Frm Top Objects"
    Private Sub BtnInsertA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsertA.Click
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = R2DepartementDore.GetSqlConnectionDepartementsSharing.GetConnection
        Try
            CmdSql.Connection.Open()
            CmdSql.CommandText = "Insert Into TblPersonelAttendance(PId,DateTimeMilladi,DateShamsi,Time,Flag) values('" & TxtPId.Text & "','" & DateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) & "','" & R2DateAndTime.ConvertToShamsiDateFull(DateTimePicker.Value) & "','" & DateTimePicker.Value.ToLongTimeString & "',1)"
            CmdSql.ExecuteNonQuery()
            CmdSql.Connection.Close()
            FrmViewMessage.ViewDialogMessage("ثبت حاضری با موفقیت انجام شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing)
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            MessageBox.Show("FrmcTruckDriverPresentSab.BtnInsertA_Click" + ex.Message)
        End Try
    End Sub

    Private Sub UcComboPersonel_ItemAcceptedEvent() Handles UcComboPersonel.ItemAcceptedEvent
        Try
            RefreshToZero()
            Dim myPId As String = UcComboPersonel.GetValidData.OCode
            Dim DS As New DataSet
            If R2ClassSqlDataBOXManagement.GetDataBOX(R2DepartementDore.GetSqlConnectionDepartementsSharing, "Select * From TblPersonelInf where PId='" & myPId & "'", 10, DS).GetRecordsCount <> 0 Then
                TxtPId.Text = DS.Tables(0).Rows(0).Item("PId").trim
                TxtPNameFamily.Text = DS.Tables(0).Rows(0).Item("PnameFamily").trim
                TxtPFatherName.Text = DS.Tables(0).Rows(0).Item("PFatherName").trim
                TxtNationalCode.Text = DS.Tables(0).Rows(0).Item("NationalCode").trim
                ViewPersonelPicture(DirectCast(DS.Tables(0).Rows(0).Item("PPicture"), Byte()))
            End If
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.UcComboPersonel_ItemAcceptedEvent", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Private Sub UcComboPersonel_ItemSelectedEvent() Handles UcComboPersonel.ItemSelectedEvent
        Try
            RefreshToZero()
            Dim myPId As String = UcComboPersonel.GetValidData.OCode
            Dim DS As New DataSet
            If R2ClassSqlDataBOXManagement.GetDataBOX(R2DepartementDore.GetSqlConnectionDepartementsSharing, "Select * From TblPersonelInf where PId='" & myPId & "'", 10, DS).GetRecordsCount <> 0 Then
                TxtPId.Text = DS.Tables(0).Rows(0).Item("PId").trim
                TxtPNameFamily.Text = DS.Tables(0).Rows(0).Item("PnameFamily").trim
                TxtPFatherName.Text = DS.Tables(0).Rows(0).Item("PFatherName").trim
                TxtNationalCode.Text = DS.Tables(0).Rows(0).Item("NationalCode").trim
                ViewPersonelPicture(DirectCast(DS.Tables(0).Rows(0).Item("PPicture"), Byte()))
            End If
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.UcComboPersonel_ItemSelectedEvent", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try

    End Sub

    Private Sub BtnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        RefreshToZero()
        TxtPNameFamily.Focus()
    End Sub

    Private Sub TxtPNameFamily_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPNameFamily.KeyPress
        If Asc(e.KeyChar) = 13 Then TxtPFatherName.Focus()
    End Sub

    Private Sub TxtPFatherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPFatherName.KeyPress
        If Asc(e.KeyChar) = 13 Then TxtNationalCode.Focus()
    End Sub

    Private Sub TxtNationalCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNationalCode.KeyPress
        If Asc(e.KeyChar) = 13 Then BtnSabt.Focus()
    End Sub

    Private Sub BtnCamera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCamera.Click
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(R2CoreParkingSystem.ConfigurationManagement.R2CoreParkingSystemMClassConfigurationManagement.GetCamera1ConnectionString), Net.HttpWebRequest)
            request.Credentials = New Net.NetworkCredential("admin", "3800000aB")
            request.KeepAlive = False
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            PicPersonel.Image = Image.FromStream(response.GetResponseStream())
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnCamera_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Private Sub BtnFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFile.Click
        Try
            Dim D As OpenFileDialog = New OpenFileDialog
            If D.ShowDialog = DialogResult.OK Then
                PicPersonel.Image = Image.FromFile(D.FileName)
            End If
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnFile_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Private Sub BtnSabt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSabt.Click
        Try
            PersonelSabt()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnSabt_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Private Sub BtnSabtPicture_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSabtPicture.Click
        Try
            PersonelPictureSabt()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnSabtPicture_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Public Enum WFingerPrint
        FP1 = 1
        FP2 = 2
        FP3 = 3
        FP4 = 4
    End Enum
    Public WhichFP As WFingerPrint
    Private Sub BtnGetFP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGetFP1.Click
        Try
            If TxtPId.Text.Trim = "" Then
                MessageBox.Show("پرسنل مشخص نیست")
                Exit Sub
            End If
            UcFingerPrintCapturerSuprema.BringToFront()
            SupremaControlTimer.Enabled = True
            SupremaControlTimer.Start()
            WhichFP = WFingerPrint.FP1
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnGetFP_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub

    Private Sub BtnGetFP2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGetFP2.Click
        Try
            If TxtPId.Text.Trim = "" Then
                MessageBox.Show("پرسنل مشخص نیست")
                Exit Sub
            End If
            UcFingerPrintCapturerSuprema.BringToFront()
            SupremaControlTimer.Enabled = True
            SupremaControlTimer.Start()
            WhichFP = WFingerPrint.FP2
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnGetFP2_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try

    End Sub

    Private Sub BtnGetFP3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGetFP3.Click
        Try
            If TxtPId.Text.Trim = "" Then
                MessageBox.Show("پرسنل مشخص نیست")
                Exit Sub
            End If
            UcFingerPrintCapturerSuprema.BringToFront()
            SupremaControlTimer.Enabled = True
            SupremaControlTimer.Start()
            WhichFP = WFingerPrint.FP3
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnGetFP3_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try

    End Sub

    Private Sub BtnGetFP4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGetFP4.Click
        Try
            If TxtPId.Text.Trim = "" Then
                MessageBox.Show("پرسنل مشخص نیست")
                Exit Sub
            End If
            UcFingerPrintCapturerSuprema.BringToFront()
            SupremaControlTimer.Enabled = True
            SupremaControlTimer.Start()
            WhichFP = WFingerPrint.FP4
            UcFingerPrintCapturerSuprema.UCStartCapturing()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.BtnGetFP4_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try

    End Sub

    Private Sub PicRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicRefresh.Click
        Try
            RefreshToZero()
        Catch ex As Exception
            FrmViewMessage.ViewDialogMessage(ex.Message, "FrmcPersonelInf.PicRefresh_Click", FrmcMessageDialog.MessageType.ErrorMessage, Nothing)
        End Try
    End Sub
#End Region

#Region "General Sub And Function"
    Private Sub RefreshToZero()
        Try
            UcFingerPrintCapturerSuprema.SendToBack()
            PicPersonel.Image = Nothing
            TxtPId.Clear()
            TxtPNameFamily.Clear()
            TxtPFatherName.Clear()
            TxtNationalCode.Clear()
        Catch ex As Exception
            Throw New Exception("RefreshToZero" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub ViewPersonelPicture(ByVal YourPic As Byte())
        Try
            Dim ImageData As Byte() = YourPic
            If Not ImageData Is Nothing Then
                Using MS As New MemoryStream(ImageData, 0, ImageData.Length)
                    MS.Write(ImageData, 0, ImageData.Length)
                    PicPersonel.Image = Image.FromStream(MS, True)
                End Using
            End If
        Catch ex As Exception
            Throw New Exception("FrmcPersonelInf.ViewPersonelPicture" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PersonelPictureSabt()
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = R2DepartementDore.GetSqlConnectionDepartementsSharing.GetConnection
        Try
            If PicPersonel.Image Is Nothing Then
                MessageBox.Show("تصویر پرسنل مشخص نیست")
                Exit Sub
            End If
            If TxtPId.Text.Trim = "" Then
                MessageBox.Show("پرسنل مشخص نیست")
                Exit Sub
            End If
            Dim myPersonelPhoto As Bitmap
            myPersonelPhoto = New Bitmap(PicPersonel.Image, New Size(500, 500))
            Dim MS As New MemoryStream()
            myPersonelPhoto.Save(MS, ImageFormat.Jpeg)
            Dim PersonelPictureData As Byte() = MS.GetBuffer()
            Dim PersonelP As New SqlClient.SqlParameter("@PPicture", SqlDbType.Image)
            PersonelP.Value = PersonelPictureData
            CmdSql.Parameters.Add(PersonelP)
            CmdSql.Parameters.AddWithValue("@DateTimeMilladiEdit", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
            CmdSql.Parameters.AddWithValue("@DateShamsiEdit", R2DateAndTime.GetCurrentDateShamsiFull)
            CmdSql.Parameters.AddWithValue("@UserIdEdit", R2MClassLoginManagement.UserId)
            CmdSql.Connection.Open()
            CmdSql.CommandText = "Update TblPersonelInf Set PPicture=@PPicture,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & TxtPId.Text.Trim & "'"
            CmdSql.ExecuteNonQuery()
            CmdSql.Connection.Close()
            FrmViewMessage.ViewDialogMessage("ثبت تصویر با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing)
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            Throw New Exception("PersonelPictureSabt" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub PersonelSabt()
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = R2DepartementDore.GetSqlConnectionDepartementsSharing.GetConnection
        Try
            If TxtPNameFamily.Text.Trim = "" Then
                MessageBox.Show("نام و نام خانوادگی پرسنل مشخص نیست")
                Exit Sub
            End If

            If TxtPId.Text.Trim <> "" Then  'ثبت ویرایشی
                Dim myPId As String = TxtPId.Text
                Dim myPNameFamily As String = TxtPNameFamily.Text
                Dim myPFatherName As String = TxtPFatherName.Text
                Dim myNationalCode As String = TxtNationalCode.Text
                CmdSql.Parameters.AddWithValue("@PNameFamily", myPNameFamily)
                CmdSql.Parameters.AddWithValue("@PFatherName", myPFatherName)
                CmdSql.Parameters.AddWithValue("@NationalCode", myNationalCode)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiEdit", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
                CmdSql.Parameters.AddWithValue("@DateShamsiEdit", R2DateAndTime.GetCurrentDateShamsiFull)
                CmdSql.Parameters.AddWithValue("@UserIdEdit", R2MClassLoginManagement.UserId)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Update TblPersonelInf Set PNameFamily=@PNameFamily,PFatherName=@PFatherName,NationalCode=@NationalCode,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & myPId & "'"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                UcComboPersonel.RefreshInformation()
                FrmViewMessage.ViewDialogMessage("ثبت مشخصات با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing)
            Else 'ثبت جدید
                If PicPersonel.Image Is Nothing Then
                    MessageBox.Show("تصویر پرسنل مشخص نیست")
                    Exit Sub
                End If
                Dim myPId As String = AttendanceManagement.PublicProc.PublicProc.GetNewPId(R2DepartementDore)
                Dim myPNameFamily As String = TxtPNameFamily.Text
                Dim myPFatherName As String = TxtPFatherName.Text
                Dim myNationalCode As String = TxtNationalCode.Text
                CmdSql.Parameters.AddWithValue("@PId", myPId)
                CmdSql.Parameters.AddWithValue("@PIdOther", "")
                CmdSql.Parameters.AddWithValue("@PNameFamily", myPNameFamily)
                CmdSql.Parameters.AddWithValue("@PFatherName", myPFatherName)
                CmdSql.Parameters.AddWithValue("@NationalCode", myNationalCode)
                CmdSql.Parameters.AddWithValue("@Active", True)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiSabt", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiEdit", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
                CmdSql.Parameters.AddWithValue("@DateShamsiSabt", R2DateAndTime.GetCurrentDateShamsiFull)
                CmdSql.Parameters.AddWithValue("@DateShamsiEdit", R2DateAndTime.GetCurrentDateShamsiFull)
                CmdSql.Parameters.AddWithValue("@UserIdSabt", R2MClassLoginManagement.UserId)
                CmdSql.Parameters.AddWithValue("@UserIdEdit", R2MClassLoginManagement.UserId)
                CmdSql.Parameters.AddWithValue("@FingerPrint", 0)
                CmdSql.Parameters.AddWithValue("@FingerPrint2", 0)
                CmdSql.Parameters.AddWithValue("@FingerPrint3", 0)
                CmdSql.Parameters.AddWithValue("@FingerPrint4", 0)
                Dim myPersonelPhoto As Bitmap
                myPersonelPhoto = New Bitmap(PicPersonel.Image, New Size(500, 500))
                Dim MS As New MemoryStream()
                myPersonelPhoto.Save(MS, ImageFormat.Jpeg)
                Dim PersonelPictureData As Byte() = MS.GetBuffer()
                Dim PersonelP As New SqlClient.SqlParameter("@PPicture", SqlDbType.Image)
                PersonelP.Value = PersonelPictureData
                CmdSql.Parameters.Add(PersonelP)
                CmdSql.Connection.Open()
                CmdSql.CommandText = "Insert Into TblPersonelInf Values(@PId,@PIdOther,@PNameFamily,@PFatherName,@NationalCode,@Active,@PPicture,@DateTimeMilladiSabt,@DateTimeMilladiEdit,@DateShamsiSabt,@DateShamsiEdit,@UserIdSabt,@UserIdEdit,@FingerPrint,@FingerPrint2,@FingerPrint3,@FingerPrint4)"
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                UcComboPersonel.RefreshInformation()
                TxtPId.Text = myPId
                FrmViewMessage.ViewDialogMessage("ثبت مشخصات با موفقیت انجام گرفت", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing)
            End If
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            Throw New Exception("FrmcPersonelInf.PersonelSabt" + vbCrLf + ex.Message)
        End Try
    End Sub

#End Region


#Region "Suprema"
    Private Sub SupremaControlTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupremaControlTimer.Tick
        Dim CmdSql As New SqlClient.SqlCommand
        CmdSql.Connection = R2DepartementDore.GetSqlConnectionDepartementsSharing.GetConnection
        Try
            If UcFingerPrintCapturerSuprema.CapturingStatus = True Then
                SupremaControlTimer.Enabled = False
                SupremaControlTimer.Stop()
                'UcFingerPrintCapturerSuprema.UCAbortCapturing()
                UcFingerPrintCapturerSuprema.SendToBack()
                'ثبت اثر انگشت
                Dim P As SqlClient.SqlParameter = New SqlClient.SqlParameter("@FPTemplate", SqlDbType.VarBinary)
                P.Value = UcFingerPrintCapturerSuprema.CurrentTemplate
                CmdSql.Parameters.Add(P)
                CmdSql.Parameters.AddWithValue("@DateTimeMilladiEdit", R2DateAndTime.GetCurrentDateTimeMilladiFormated)
                CmdSql.Parameters.AddWithValue("@DateShamsiEdit", R2DateAndTime.GetCurrentDateShamsiFull)
                CmdSql.Parameters.AddWithValue("@UserIdEdit", R2MClassLoginManagement.UserId)
                CmdSql.Connection.Open()
                If WhichFP = WFingerPrint.FP1 Then
                    CmdSql.CommandText = "Update TblPersonelInf Set FingerPrint=@FPTemplate,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & TxtPId.Text.Trim & "'"
                ElseIf WhichFP = WFingerPrint.FP2 Then
                    CmdSql.CommandText = "Update TblPersonelInf Set FingerPrint2=@FPTemplate,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & TxtPId.Text.Trim & "'"
                ElseIf WhichFP = WFingerPrint.FP3 Then
                    CmdSql.CommandText = "Update TblPersonelInf Set FingerPrint3=@FPTemplate,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & TxtPId.Text.Trim & "'"
                ElseIf WhichFP = WFingerPrint.FP4 Then
                    CmdSql.CommandText = "Update TblPersonelInf Set FingerPrint4=@FPTemplate,DateTimeMilladiEdit=@DateTimeMilladiEdit,DateShamsiEdit=@DateShamsiEdit,UserIdEdit=@UserIdEdit where PId='" & TxtPId.Text.Trim & "'"
                End If
                CmdSql.ExecuteNonQuery()
                CmdSql.Connection.Close()
                FrmViewMessage.ViewDialogMessage("اثر انگشت با موفقیت ثبت شد", "", FrmcMessageDialog.MessageType.PersianMessage, Nothing)
            End If
        Catch ex As Exception
            If CmdSql.Connection.State <> ConnectionState.Closed Then CmdSql.Connection.Close()
            MessageBox.Show("FrmcTruckDriverPresentSab.SupremaControlTimer_Tick" + ex.Message)
        End Try
    End Sub



#End Region



#Region "General Properties"
#End Region

#Region "Subroutins And Functions"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Try
            FrmRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Protected  Sub FrmRefresh()
        Try
            UcFingerPrintCapturerSuprema.Enabled = R2CoreParkingSystemMClassConfigurationManagement.GetFrmcVerifyIdentifyFPUCEnable
            Dim UCFPStruct = New R2CoreFingerPrintGUI.BaseStandardClass.UCFingerPrintCapturerSupremaSettingStructure
            UCFPStruct.Brightness = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaBrightness
            UCFPStruct.DetectCore = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaDetectCore
            UCFPStruct.DetectFake = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaDetectFake
            UCFPStruct.EnrollQuality = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaEnrollQuality
            UCFPStruct.SecurityLevel = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaSecurityLevel
            UCFPStruct.Sensitivity = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaSensitivity
            UCFPStruct.TemplateType = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaTemplateType
            UCFPStruct.TimeOut = R2CoreParkingSystemMClassConfigurationManagement.GetUCFingerPrintCapturerSupremaTimeOut
            UCFPStruct.UCEnable = R2CoreParkingSystemMClassConfigurationManagement.GetFrmcVerifyIdentifyFPUCEnable
            UcFingerPrintCapturerSuprema.UCInitialize(UCFPStruct)
            SupremaControlTimer.Interval = 1000
            RefreshToZero()
        Catch ex As Exception
            Throw New Exception("FrmcPersonelInf.FrmRefresh" + vbCrLf + ex.Message.ToString)
        End Try
    End Sub


#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region












End Class
