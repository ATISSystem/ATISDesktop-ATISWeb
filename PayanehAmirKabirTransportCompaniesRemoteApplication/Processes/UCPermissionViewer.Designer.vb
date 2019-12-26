Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCPermissionViewer
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOuter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcPersianTextBoxStrDriverName = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabel8 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel7 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel6 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel5 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel4 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel3 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel2 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelCarTruckLpString = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelStrDrivingLicenseNo = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelStrNationalCode = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelStrSmartCardNo = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelLocation = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelStrAddress = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelStrExitDateTime = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOuter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlOuter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(741, 63)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOuter
        '
        Me.PnlOuter.Controls.Add(Me.PnlInner)
        Me.PnlOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOuter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOuter.Name = "PnlOuter"
        Me.PnlOuter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOuter.Size = New System.Drawing.Size(741, 63)
        Me.PnlOuter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxStrDriverName)
        Me.PnlInner.Controls.Add(Me.UcLabel8)
        Me.PnlInner.Controls.Add(Me.UcLabel7)
        Me.PnlInner.Controls.Add(Me.UcLabel6)
        Me.PnlInner.Controls.Add(Me.UcLabel5)
        Me.PnlInner.Controls.Add(Me.UcLabel4)
        Me.PnlInner.Controls.Add(Me.UcLabel3)
        Me.PnlInner.Controls.Add(Me.UcLabel2)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcLabelCarTruckLpString)
        Me.PnlInner.Controls.Add(Me.UcLabelStrDrivingLicenseNo)
        Me.PnlInner.Controls.Add(Me.UcLabelStrNationalCode)
        Me.PnlInner.Controls.Add(Me.UcLabelStrSmartCardNo)
        Me.PnlInner.Controls.Add(Me.UcLabelLocation)
        Me.PnlInner.Controls.Add(Me.UcLabelStrAddress)
        Me.PnlInner.Controls.Add(Me.UcLabelStrExitDateTime)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.ForeColor = System.Drawing.Color.White
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(737, 59)
        Me.PnlInner.TabIndex = 0
        '
        'UcPersianTextBoxStrDriverName
        '
        Me.UcPersianTextBoxStrDriverName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxStrDriverName.Location = New System.Drawing.Point(533, 17)
        Me.UcPersianTextBoxStrDriverName.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxStrDriverName.Name = "UcPersianTextBoxStrDriverName"
        Me.UcPersianTextBoxStrDriverName.Size = New System.Drawing.Size(122, 42)
        Me.UcPersianTextBoxStrDriverName.TabIndex = 16
        Me.UcPersianTextBoxStrDriverName.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxStrDriverName.UCBorder = System.Windows.Forms.BorderStyle.None
        Me.UcPersianTextBoxStrDriverName.UCEnable = true
        Me.UcPersianTextBoxStrDriverName.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxStrDriverName.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxStrDriverName.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxStrDriverName.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxStrDriverName.UCValue = "مرتضی شاهمرادی نتا نتا نت نتا نتا نا ن"
        '
        'UcLabel8
        '
        Me.UcLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel8.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel8.Location = New System.Drawing.Point(-2, -4)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel8.Size = New System.Drawing.Size(83, 28)
        Me.UcLabel8.TabIndex = 7
        Me.UcLabel8.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel8.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel8.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel8.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel8.UCValue = "توضیحات"
        '
        'UcLabel7
        '
        Me.UcLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel7.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.Location = New System.Drawing.Point(87, -4)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel7.Size = New System.Drawing.Size(85, 28)
        Me.UcLabel7.TabIndex = 6
        Me.UcLabel7.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel7.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel7.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel7.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel7.UCValue = "محل صدورمجوز"
        '
        'UcLabel6
        '
        Me.UcLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel6.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.Location = New System.Drawing.Point(178, -4)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel6.Size = New System.Drawing.Size(79, 28)
        Me.UcLabel6.TabIndex = 5
        Me.UcLabel6.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel6.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel6.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel6.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel6.UCValue = "زمان صدورمجوز"
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(263, -2)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.Size = New System.Drawing.Size(71, 28)
        Me.UcLabel5.TabIndex = 4
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "هوشمند راننده"
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(340, -2)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.Size = New System.Drawing.Size(88, 28)
        Me.UcLabel4.TabIndex = 3
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel4.UCValue = "شماره ملی"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(434, -2)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.Size = New System.Drawing.Size(93, 28)
        Me.UcLabel3.TabIndex = 2
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel3.UCValue = "گواهینامه"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(533, -2)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.Size = New System.Drawing.Size(122, 28)
        Me.UcLabel2.TabIndex = 1
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "راننده"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(661, -4)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(73, 28)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Silver
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "ناوگان"
        '
        'UcLabelCarTruckLpString
        '
        Me.UcLabelCarTruckLpString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelCarTruckLpString.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckLpString.Location = New System.Drawing.Point(661, 17)
        Me.UcLabelCarTruckLpString.Name = "UcLabelCarTruckLpString"
        Me.UcLabelCarTruckLpString.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarTruckLpString.Size = New System.Drawing.Size(73, 44)
        Me.UcLabelCarTruckLpString.TabIndex = 15
        Me.UcLabelCarTruckLpString.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckLpString.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCarTruckLpString.UCForeColor = System.Drawing.Color.OrangeRed
        Me.UcLabelCarTruckLpString.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarTruckLpString.UCValue = "878ع52-25"
        '
        'UcLabelStrDrivingLicenseNo
        '
        Me.UcLabelStrDrivingLicenseNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrDrivingLicenseNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDrivingLicenseNo.Location = New System.Drawing.Point(434, 17)
        Me.UcLabelStrDrivingLicenseNo.Name = "UcLabelStrDrivingLicenseNo"
        Me.UcLabelStrDrivingLicenseNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrDrivingLicenseNo.Size = New System.Drawing.Size(93, 37)
        Me.UcLabelStrDrivingLicenseNo.TabIndex = 13
        Me.UcLabelStrDrivingLicenseNo.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrDrivingLicenseNo.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrDrivingLicenseNo.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelStrDrivingLicenseNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrDrivingLicenseNo.UCValue = "452154215412"
        '
        'UcLabelStrNationalCode
        '
        Me.UcLabelStrNationalCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrNationalCode.Location = New System.Drawing.Point(340, 17)
        Me.UcLabelStrNationalCode.Name = "UcLabelStrNationalCode"
        Me.UcLabelStrNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrNationalCode.Size = New System.Drawing.Size(88, 37)
        Me.UcLabelStrNationalCode.TabIndex = 12
        Me.UcLabelStrNationalCode.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrNationalCode.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelStrNationalCode.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrNationalCode.UCValue = "1286939623"
        '
        'UcLabelStrSmartCardNo
        '
        Me.UcLabelStrSmartCardNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrSmartCardNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrSmartCardNo.Location = New System.Drawing.Point(263, 17)
        Me.UcLabelStrSmartCardNo.Name = "UcLabelStrSmartCardNo"
        Me.UcLabelStrSmartCardNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrSmartCardNo.Size = New System.Drawing.Size(71, 37)
        Me.UcLabelStrSmartCardNo.TabIndex = 11
        Me.UcLabelStrSmartCardNo.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrSmartCardNo.UCFont = New System.Drawing.Font("IRMehr", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrSmartCardNo.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabelStrSmartCardNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrSmartCardNo.UCValue = "4215425"
        '
        'UcLabelLocation
        '
        Me.UcLabelLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelLocation.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLocation.Location = New System.Drawing.Point(87, 17)
        Me.UcLabelLocation.Name = "UcLabelLocation"
        Me.UcLabelLocation.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLocation.Size = New System.Drawing.Size(85, 37)
        Me.UcLabelLocation.TabIndex = 9
        Me.UcLabelLocation.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLocation.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelLocation.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelLocation.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLocation.UCValue = "شرکت حمل ونقل"
        '
        'UcLabelStrAddress
        '
        Me.UcLabelStrAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrAddress.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrAddress.Location = New System.Drawing.Point(0, 17)
        Me.UcLabelStrAddress.Name = "UcLabelStrAddress"
        Me.UcLabelStrAddress.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrAddress.Size = New System.Drawing.Size(81, 37)
        Me.UcLabelStrAddress.TabIndex = 8
        Me.UcLabelStrAddress.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrAddress.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrAddress.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelStrAddress.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrAddress.UCValue = "09132043148"
        '
        'UcLabelStrExitDateTime
        '
        Me.UcLabelStrExitDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelStrExitDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrExitDateTime.Location = New System.Drawing.Point(178, 17)
        Me.UcLabelStrExitDateTime.Name = "UcLabelStrExitDateTime"
        Me.UcLabelStrExitDateTime.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelStrExitDateTime.Size = New System.Drawing.Size(79, 37)
        Me.UcLabelStrExitDateTime.TabIndex = 10
        Me.UcLabelStrExitDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelStrExitDateTime.UCFont = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelStrExitDateTime.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelStrExitDateTime.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelStrExitDateTime.UCValue = "10:59:58"
        '
        'UCPermissionViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPermissionViewer"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(761, 83)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOuter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlOuter As Panel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents UcLabel8 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel7 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel6 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel5 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel4 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel3 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel2 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel1 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelCarTruckLpString As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelStrDrivingLicenseNo As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelStrNationalCode As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelStrSmartCardNo As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelLocation As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelStrAddress As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelStrExitDateTime As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcPersianTextBoxStrDriverName As UCPersianTextBox
End Class
