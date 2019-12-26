Imports R2CoreGUI
Imports R2CoreParkingSystem.CamerasManagement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcDriverTruckFingerPrintRegister
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
        Me.PnlDriverTruckFingerPrintRegister = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.UcButtonDeleteFPsDriverTruckFirst = New R2CoreGUI.UCButton()
        Me.UcButtonDeleteFPsDriverTruckSecond = New R2CoreGUI.UCButton()
        Me.UcButtonSavePictureDriverTruckSecond = New R2CoreGUI.UCButton()
        Me.UcButtonSaveFPsDriverTruckSecond = New R2CoreGUI.UCButton()
        Me.UcButtonSavePictureDriverTruckFirst = New R2CoreGUI.UCButton()
        Me.UcButtonSaveFPsDriverTruckFirst = New R2CoreGUI.UCButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.UcButtonGetDriverPicture = New R2CoreGUI.UCButton()
        Me.UcDriverImagePnlRegister = New R2CoreParkingSystem.UCDriverImage()
        Me.UcFingerPrintCapturerDermalog = New R2CoreGUI.UCFingerPrintCapturerDermalog()
        Me.PnlDriverTruckInformationControl = New System.Windows.Forms.Panel()
        Me.UcDriverTruckFirst = New PayanehClassLibrary.UCDriverTruck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcDriverImageFirst = New R2CoreParkingSystem.UCDriverImage()
        Me.UcButtonDriverTruckInformationControl = New R2CoreGUI.UCButton()
        Me.UcDriverTruckSecond = New PayanehClassLibrary.UCDriverTruck()
        Me.UcCarTruck = New PayanehClassLibrary.UCCarTruck()
        Me.UcTrafficCard = New R2CoreParkingSystem.UCTrafficCard()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcDriverImageSecond = New R2CoreParkingSystem.UCDriverImage()
        Me.PnlDriverTruckFingerPrintRegister.SuspendLayout
        Me.GroupBox7.SuspendLayout
        Me.GroupBox8.SuspendLayout
        Me.PnlDriverTruckInformationControl.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlDriverTruckFingerPrintRegister
        '
        Me.PnlDriverTruckFingerPrintRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlDriverTruckFingerPrintRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDriverTruckFingerPrintRegister.Controls.Add(Me.GroupBox7)
        Me.PnlDriverTruckFingerPrintRegister.Controls.Add(Me.GroupBox8)
        Me.PnlDriverTruckFingerPrintRegister.Controls.Add(Me.UcFingerPrintCapturerDermalog)
        Me.PnlDriverTruckFingerPrintRegister.Location = New System.Drawing.Point(5, 50)
        Me.PnlDriverTruckFingerPrintRegister.Name = "PnlDriverTruckFingerPrintRegister"
        Me.PnlDriverTruckFingerPrintRegister.Size = New System.Drawing.Size(995, 512)
        Me.PnlDriverTruckFingerPrintRegister.TabIndex = 206
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.UcButtonDeleteFPsDriverTruckFirst)
        Me.GroupBox7.Controls.Add(Me.UcButtonDeleteFPsDriverTruckSecond)
        Me.GroupBox7.Controls.Add(Me.UcButtonSavePictureDriverTruckSecond)
        Me.GroupBox7.Controls.Add(Me.UcButtonSaveFPsDriverTruckSecond)
        Me.GroupBox7.Controls.Add(Me.UcButtonSavePictureDriverTruckFirst)
        Me.GroupBox7.Controls.Add(Me.UcButtonSaveFPsDriverTruckFirst)
        Me.GroupBox7.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(19, 97)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox7.Size = New System.Drawing.Size(221, 338)
        Me.GroupBox7.TabIndex = 317
        Me.GroupBox7.TabStop = false
        Me.GroupBox7.Text = "عملیات"
        '
        'UcButtonDeleteFPsDriverTruckFirst
        '
        Me.UcButtonDeleteFPsDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeleteFPsDriverTruckFirst.Location = New System.Drawing.Point(6, 245)
        Me.UcButtonDeleteFPsDriverTruckFirst.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonDeleteFPsDriverTruckFirst.Name = "UcButtonDeleteFPsDriverTruckFirst"
        Me.UcButtonDeleteFPsDriverTruckFirst.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonDeleteFPsDriverTruckFirst.Size = New System.Drawing.Size(209, 40)
        Me.UcButtonDeleteFPsDriverTruckFirst.TabIndex = 325
        Me.UcButtonDeleteFPsDriverTruckFirst.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDeleteFPsDriverTruckFirst.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeleteFPsDriverTruckFirst.UCEnable = false
        Me.UcButtonDeleteFPsDriverTruckFirst.UCFont = New System.Drawing.Font("B Homa", 11.25!)
        Me.UcButtonDeleteFPsDriverTruckFirst.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeleteFPsDriverTruckFirst.UCValue = "حذف اثرانگشت راننده اول"
        '
        'UcButtonDeleteFPsDriverTruckSecond
        '
        Me.UcButtonDeleteFPsDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonDeleteFPsDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeleteFPsDriverTruckSecond.Location = New System.Drawing.Point(6, 293)
        Me.UcButtonDeleteFPsDriverTruckSecond.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonDeleteFPsDriverTruckSecond.Name = "UcButtonDeleteFPsDriverTruckSecond"
        Me.UcButtonDeleteFPsDriverTruckSecond.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonDeleteFPsDriverTruckSecond.Size = New System.Drawing.Size(209, 40)
        Me.UcButtonDeleteFPsDriverTruckSecond.TabIndex = 324
        Me.UcButtonDeleteFPsDriverTruckSecond.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDeleteFPsDriverTruckSecond.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeleteFPsDriverTruckSecond.UCEnable = false
        Me.UcButtonDeleteFPsDriverTruckSecond.UCFont = New System.Drawing.Font("B Homa", 11.25!)
        Me.UcButtonDeleteFPsDriverTruckSecond.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeleteFPsDriverTruckSecond.UCValue = "حذف اثرانگشت راننده دوم"
        '
        'UcButtonSavePictureDriverTruckSecond
        '
        Me.UcButtonSavePictureDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSavePictureDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSavePictureDriverTruckSecond.Location = New System.Drawing.Point(6, 192)
        Me.UcButtonSavePictureDriverTruckSecond.Margin = New System.Windows.Forms.Padding(3, 11, 3, 11)
        Me.UcButtonSavePictureDriverTruckSecond.Name = "UcButtonSavePictureDriverTruckSecond"
        Me.UcButtonSavePictureDriverTruckSecond.Padding = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.UcButtonSavePictureDriverTruckSecond.Size = New System.Drawing.Size(209, 46)
        Me.UcButtonSavePictureDriverTruckSecond.TabIndex = 323
        Me.UcButtonSavePictureDriverTruckSecond.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcButtonSavePictureDriverTruckSecond.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSavePictureDriverTruckSecond.UCEnable = false
        Me.UcButtonSavePictureDriverTruckSecond.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSavePictureDriverTruckSecond.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSavePictureDriverTruckSecond.UCValue = "ثبت تصویر راننده دوم"
        '
        'UcButtonSaveFPsDriverTruckSecond
        '
        Me.UcButtonSaveFPsDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSaveFPsDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSaveFPsDriverTruckSecond.Location = New System.Drawing.Point(6, 79)
        Me.UcButtonSaveFPsDriverTruckSecond.Margin = New System.Windows.Forms.Padding(3, 11, 3, 11)
        Me.UcButtonSaveFPsDriverTruckSecond.Name = "UcButtonSaveFPsDriverTruckSecond"
        Me.UcButtonSaveFPsDriverTruckSecond.Padding = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.UcButtonSaveFPsDriverTruckSecond.Size = New System.Drawing.Size(209, 60)
        Me.UcButtonSaveFPsDriverTruckSecond.TabIndex = 322
        Me.UcButtonSaveFPsDriverTruckSecond.UCBackColor = System.Drawing.Color.DarkOliveGreen
        Me.UcButtonSaveFPsDriverTruckSecond.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSaveFPsDriverTruckSecond.UCEnable = false
        Me.UcButtonSaveFPsDriverTruckSecond.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSaveFPsDriverTruckSecond.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSaveFPsDriverTruckSecond.UCValue = "ثبت اثر انگشت راننده دوم"
        '
        'UcButtonSavePictureDriverTruckFirst
        '
        Me.UcButtonSavePictureDriverTruckFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSavePictureDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSavePictureDriverTruckFirst.Location = New System.Drawing.Point(6, 145)
        Me.UcButtonSavePictureDriverTruckFirst.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonSavePictureDriverTruckFirst.Name = "UcButtonSavePictureDriverTruckFirst"
        Me.UcButtonSavePictureDriverTruckFirst.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonSavePictureDriverTruckFirst.Size = New System.Drawing.Size(209, 44)
        Me.UcButtonSavePictureDriverTruckFirst.TabIndex = 320
        Me.UcButtonSavePictureDriverTruckFirst.UCBackColor = System.Drawing.Color.SteelBlue
        Me.UcButtonSavePictureDriverTruckFirst.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSavePictureDriverTruckFirst.UCEnable = false
        Me.UcButtonSavePictureDriverTruckFirst.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSavePictureDriverTruckFirst.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSavePictureDriverTruckFirst.UCValue = "ثبت تصویر راننده اول"
        '
        'UcButtonSaveFPsDriverTruckFirst
        '
        Me.UcButtonSaveFPsDriverTruckFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonSaveFPsDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonSaveFPsDriverTruckFirst.Location = New System.Drawing.Point(6, 24)
        Me.UcButtonSaveFPsDriverTruckFirst.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonSaveFPsDriverTruckFirst.Name = "UcButtonSaveFPsDriverTruckFirst"
        Me.UcButtonSaveFPsDriverTruckFirst.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonSaveFPsDriverTruckFirst.Size = New System.Drawing.Size(209, 53)
        Me.UcButtonSaveFPsDriverTruckFirst.TabIndex = 319
        Me.UcButtonSaveFPsDriverTruckFirst.UCBackColor = System.Drawing.Color.Green
        Me.UcButtonSaveFPsDriverTruckFirst.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSaveFPsDriverTruckFirst.UCEnable = false
        Me.UcButtonSaveFPsDriverTruckFirst.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSaveFPsDriverTruckFirst.UCForeColor = System.Drawing.Color.White
        Me.UcButtonSaveFPsDriverTruckFirst.UCValue = "ثبت اثر انگشت راننده اول"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.UcButtonGetDriverPicture)
        Me.GroupBox8.Controls.Add(Me.UcDriverImagePnlRegister)
        Me.GroupBox8.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(251, 97)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox8.Size = New System.Drawing.Size(206, 338)
        Me.GroupBox8.TabIndex = 318
        Me.GroupBox8.TabStop = false
        Me.GroupBox8.Text = "تصویر راننده"
        '
        'UcButtonGetDriverPicture
        '
        Me.UcButtonGetDriverPicture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonGetDriverPicture.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonGetDriverPicture.Location = New System.Drawing.Point(5, 293)
        Me.UcButtonGetDriverPicture.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcButtonGetDriverPicture.Name = "UcButtonGetDriverPicture"
        Me.UcButtonGetDriverPicture.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.UcButtonGetDriverPicture.Size = New System.Drawing.Size(195, 40)
        Me.UcButtonGetDriverPicture.TabIndex = 319
        Me.UcButtonGetDriverPicture.UCBackColor = System.Drawing.Color.DeepSkyBlue
        Me.UcButtonGetDriverPicture.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonGetDriverPicture.UCEnable = true
        Me.UcButtonGetDriverPicture.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonGetDriverPicture.UCForeColor = System.Drawing.Color.White
        Me.UcButtonGetDriverPicture.UCValue = "دریافت تصویر از دوربین"
        '
        'UcDriverImagePnlRegister
        '
        Me.UcDriverImagePnlRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverImagePnlRegister.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImagePnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImagePnlRegister.Location = New System.Drawing.Point(5, 24)
        Me.UcDriverImagePnlRegister.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcDriverImagePnlRegister.Name = "UcDriverImagePnlRegister"
        Me.UcDriverImagePnlRegister.Padding = New System.Windows.Forms.Padding(12, 18, 12, 18)
        Me.UcDriverImagePnlRegister.Size = New System.Drawing.Size(194, 259)
        Me.UcDriverImagePnlRegister.TabIndex = 319
        '
        'UcFingerPrintCapturerDermalog
        '
        Me.UcFingerPrintCapturerDermalog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcFingerPrintCapturerDermalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcFingerPrintCapturerDermalog.Enabled = false
        Me.UcFingerPrintCapturerDermalog.Location = New System.Drawing.Point(474, 11)
        Me.UcFingerPrintCapturerDermalog.Name = "UcFingerPrintCapturerDermalog"
        Me.UcFingerPrintCapturerDermalog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcFingerPrintCapturerDermalog.Size = New System.Drawing.Size(513, 487)
        Me.UcFingerPrintCapturerDermalog.TabIndex = 0
        Me.UcFingerPrintCapturerDermalog.UCDDevice_OnDetectChekFlag = true
        Me.UcFingerPrintCapturerDermalog.UCLifenessScore = CType(0,Long)
        '
        'PnlDriverTruckInformationControl
        '
        Me.PnlDriverTruckInformationControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlDriverTruckInformationControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.UcDriverTruckFirst)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.GroupBox1)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.UcButtonDriverTruckInformationControl)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.UcDriverTruckSecond)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.UcCarTruck)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.UcTrafficCard)
        Me.PnlDriverTruckInformationControl.Controls.Add(Me.GroupBox2)
        Me.PnlDriverTruckInformationControl.Location = New System.Drawing.Point(5, 50)
        Me.PnlDriverTruckInformationControl.Name = "PnlDriverTruckInformationControl"
        Me.PnlDriverTruckInformationControl.Size = New System.Drawing.Size(995, 512)
        Me.PnlDriverTruckInformationControl.TabIndex = 207
        '
        'UcDriverTruckFirst
        '
        Me.UcDriverTruckFirst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckFirst.Location = New System.Drawing.Point(170, 172)
        Me.UcDriverTruckFirst.Name = "UcDriverTruckFirst"
        Me.UcDriverTruckFirst.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckFirst.Size = New System.Drawing.Size(819, 167)
        Me.UcDriverTruckFirst.TabIndex = 320
        Me.UcDriverTruckFirst.UCViewButtons = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UcDriverImageFirst)
        Me.GroupBox1.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(8, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(156, 175)
        Me.GroupBox1.TabIndex = 319
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "تصویر راننده"
        '
        'UcDriverImageFirst
        '
        Me.UcDriverImageFirst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverImageFirst.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImageFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImageFirst.Location = New System.Drawing.Point(5, 24)
        Me.UcDriverImageFirst.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcDriverImageFirst.Name = "UcDriverImageFirst"
        Me.UcDriverImageFirst.Padding = New System.Windows.Forms.Padding(12, 18, 12, 18)
        Me.UcDriverImageFirst.Size = New System.Drawing.Size(144, 143)
        Me.UcDriverImageFirst.TabIndex = 319
        '
        'UcButtonDriverTruckInformationControl
        '
        Me.UcButtonDriverTruckInformationControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcButtonDriverTruckInformationControl.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDriverTruckInformationControl.Location = New System.Drawing.Point(696, 131)
        Me.UcButtonDriverTruckInformationControl.Name = "UcButtonDriverTruckInformationControl"
        Me.UcButtonDriverTruckInformationControl.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDriverTruckInformationControl.Size = New System.Drawing.Size(291, 39)
        Me.UcButtonDriverTruckInformationControl.TabIndex = 3
        Me.UcButtonDriverTruckInformationControl.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonDriverTruckInformationControl.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDriverTruckInformationControl.UCEnable = true
        Me.UcButtonDriverTruckInformationControl.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonDriverTruckInformationControl.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDriverTruckInformationControl.UCValue = "پس از کنترل مشخصات این کلید را فشار دهید"
        '
        'UcDriverTruckSecond
        '
        Me.UcDriverTruckSecond.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruckSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruckSecond.Location = New System.Drawing.Point(170, 340)
        Me.UcDriverTruckSecond.Name = "UcDriverTruckSecond"
        Me.UcDriverTruckSecond.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDriverTruckSecond.Size = New System.Drawing.Size(819, 167)
        Me.UcDriverTruckSecond.TabIndex = 2
        Me.UcDriverTruckSecond.UCViewButtons = false
        '
        'UcCarTruck
        '
        Me.UcCarTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcCarTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcCarTruck.Location = New System.Drawing.Point(8, 9)
        Me.UcCarTruck.Name = "UcCarTruck"
        Me.UcCarTruck.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCarTruck.Size = New System.Drawing.Size(605, 153)
        Me.UcCarTruck.TabIndex = 1
        Me.UcCarTruck.UCViewButtons = false
        '
        'UcTrafficCard
        '
        Me.UcTrafficCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcTrafficCard.BackColor = System.Drawing.Color.Transparent
        Me.UcTrafficCard.Enabled = false
        Me.UcTrafficCard.Location = New System.Drawing.Point(606, 3)
        Me.UcTrafficCard.Name = "UcTrafficCard"
        Me.UcTrafficCard.Padding = New System.Windows.Forms.Padding(3)
        Me.UcTrafficCard.Size = New System.Drawing.Size(389, 131)
        Me.UcTrafficCard.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UcDriverImageSecond)
        Me.GroupBox2.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(8, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(156, 174)
        Me.GroupBox2.TabIndex = 321
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "تصویر راننده"
        '
        'UcDriverImageSecond
        '
        Me.UcDriverImageSecond.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcDriverImageSecond.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverImageSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcDriverImageSecond.Location = New System.Drawing.Point(5, 24)
        Me.UcDriverImageSecond.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.UcDriverImageSecond.Name = "UcDriverImageSecond"
        Me.UcDriverImageSecond.Padding = New System.Windows.Forms.Padding(12, 18, 12, 18)
        Me.UcDriverImageSecond.Size = New System.Drawing.Size(144, 142)
        Me.UcDriverImageSecond.TabIndex = 319
        '
        'FrmcDriverTruckFingerPrintRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlDriverTruckInformationControl)
        Me.Controls.Add(Me.PnlDriverTruckFingerPrintRegister)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcDriverTruckFingerPrintRegister"
        Me.Text = "FrmcDriverTruckFingerPrintRegister"
        Me.Controls.SetChildIndex(Me.PnlDriverTruckFingerPrintRegister, 0)
        Me.Controls.SetChildIndex(Me.PnlDriverTruckInformationControl, 0)
        Me.PnlDriverTruckFingerPrintRegister.ResumeLayout(false)
        Me.GroupBox7.ResumeLayout(false)
        Me.GroupBox8.ResumeLayout(false)
        Me.PnlDriverTruckInformationControl.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlDriverTruckFingerPrintRegister As System.Windows.Forms.Panel
    Friend WithEvents UcFingerPrintCapturerDermalog As UCFingerPrintCapturerDermalog
    Friend WithEvents PnlDriverTruckInformationControl As System.Windows.Forms.Panel
    Friend WithEvents UcButtonDriverTruckInformationControl As UCButton
    Friend WithEvents UcDriverTruckSecond As UCDriverTruck
    Friend WithEvents UcCarTruck As UCCarTruck
    Friend WithEvents UcTrafficCard As R2CoreParkingSystem.UCTrafficCard
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents UcDriverImagePnlRegister As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcDriverImageFirst As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcButtonGetDriverPicture As UCButton
    Friend WithEvents UcButtonSaveFPsDriverTruckFirst As UCButton
    Friend WithEvents UcButtonSavePictureDriverTruckFirst As UCButton
    Friend WithEvents UcDriverTruckFirst As UCDriverTruck
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcDriverImageSecond As R2CoreParkingSystem.UCDriverImage
    Friend WithEvents UcButtonDeleteFPsDriverTruckFirst As UCButton
    Friend WithEvents UcButtonDeleteFPsDriverTruckSecond As UCButton
    Friend WithEvents UcButtonSavePictureDriverTruckSecond As UCButton
    Friend WithEvents UcButtonSaveFPsDriverTruckSecond As UCButton
End Class
