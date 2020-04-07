Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDriverTruck
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.UcLabel5 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcLabelPersonFullName = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcButtonGetInfLocalDataBase = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcLabel4 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcPersianTextBoxSmartCardNo = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcButtonGetInfRMTO = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel2 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel3 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelDriverTruckDrivingLicenceNo = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelDriverTruckNationalCode = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(248, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.SeaShell
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(739, 91)
        Me.PnlMain.TabIndex = 1
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(644, -7)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel5.Size = New System.Drawing.Size(82, 32)
        Me.UcLabel5.TabIndex = 7
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "راننده باری"
        '
        'PnlInner
        '
        Me.PnlInner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInner.Controls.Add(Me.UcLabelPersonFullName)
        Me.PnlInner.Controls.Add(Me.UcButtonGetInfLocalDataBase)
        Me.PnlInner.Controls.Add(Me.UcLabel4)
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxSmartCardNo)
        Me.PnlInner.Controls.Add(Me.UcButtonGetInfRMTO)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcLabel2)
        Me.PnlInner.Controls.Add(Me.UcLabel3)
        Me.PnlInner.Controls.Add(Me.UcLabelDriverTruckDrivingLicenceNo)
        Me.PnlInner.Controls.Add(Me.UcLabelDriverTruckNationalCode)
        Me.PnlInner.Location = New System.Drawing.Point(3, 10)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(732, 76)
        Me.PnlInner.TabIndex = 8
        '
        'UcLabelPersonFullName
        '
        Me.UcLabelPersonFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelPersonFullName.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelPersonFullName.Location = New System.Drawing.Point(177, 4)
        Me.UcLabelPersonFullName.Name = "UcLabelPersonFullName"
        Me.UcLabelPersonFullName.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelPersonFullName.Size = New System.Drawing.Size(273, 25)
        Me.UcLabelPersonFullName.TabIndex = 9
        Me.UcLabelPersonFullName.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelPersonFullName.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelPersonFullName.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelPersonFullName.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelPersonFullName.UCValue = "مرتضی شاهرمادی چادگانی"
        '
        'UcButtonGetInfLocalDataBase
        '
        Me.UcButtonGetInfLocalDataBase.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonGetInfLocalDataBase.Location = New System.Drawing.Point(3, 2)
        Me.UcButtonGetInfLocalDataBase.Name = "UcButtonGetInfLocalDataBase"
        Me.UcButtonGetInfLocalDataBase.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonGetInfLocalDataBase.Size = New System.Drawing.Size(168, 36)
        Me.UcButtonGetInfLocalDataBase.TabIndex = 10
        Me.UcButtonGetInfLocalDataBase.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonGetInfLocalDataBase.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonGetInfLocalDataBase.UCEnable = True
        Me.UcButtonGetInfLocalDataBase.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonGetInfLocalDataBase.UCForeColor = System.Drawing.Color.White
        Me.UcButtonGetInfLocalDataBase.UCValue = "استعلام از بانک اطلاعات پایانه"
        '
        'UcLabel4
        '
        Me.UcLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel4.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.Location = New System.Drawing.Point(448, 0)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel4.Size = New System.Drawing.Size(39, 32)
        Me.UcLabel4.TabIndex = 8
        Me.UcLabel4.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel4.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel4.UCForeColor = System.Drawing.Color.Green
        Me.UcLabel4.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel4.UCValue = "راننده:"
        '
        'UcPersianTextBoxSmartCardNo
        '
        Me.UcPersianTextBoxSmartCardNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSmartCardNo.Location = New System.Drawing.Point(493, 5)
        Me.UcPersianTextBoxSmartCardNo.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxSmartCardNo.Name = "UcPersianTextBoxSmartCardNo"
        Me.UcPersianTextBoxSmartCardNo.Size = New System.Drawing.Size(143, 28)
        Me.UcPersianTextBoxSmartCardNo.TabIndex = 7
        Me.UcPersianTextBoxSmartCardNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSmartCardNo.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxSmartCardNo.UCEnable = True
        Me.UcPersianTextBoxSmartCardNo.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxSmartCardNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSmartCardNo.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxSmartCardNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSmartCardNo.UCValue = ""
        '
        'UcButtonGetInfRMTO
        '
        Me.UcButtonGetInfRMTO.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonGetInfRMTO.Location = New System.Drawing.Point(3, 37)
        Me.UcButtonGetInfRMTO.Name = "UcButtonGetInfRMTO"
        Me.UcButtonGetInfRMTO.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonGetInfRMTO.Size = New System.Drawing.Size(168, 36)
        Me.UcButtonGetInfRMTO.TabIndex = 2
        Me.UcButtonGetInfRMTO.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonGetInfRMTO.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonGetInfRMTO.UCEnable = True
        Me.UcButtonGetInfRMTO.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonGetInfRMTO.UCForeColor = System.Drawing.Color.White
        Me.UcButtonGetInfRMTO.UCValue = "استعلام از وب سایت هوشمند"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(636, 2)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(91, 32)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "شماره هوشمند"
        '
        'UcLabel2
        '
        Me.UcLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(663, 34)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(59, 32)
        Me.UcLabel2.TabIndex = 3
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Green
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel2.UCValue = "کارت ملی"
        '
        'UcLabel3
        '
        Me.UcLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(518, 34)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel3.Size = New System.Drawing.Size(58, 32)
        Me.UcLabel3.TabIndex = 4
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Green
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel3.UCValue = "گواهینامه"
        '
        'UcLabelDriverTruckDrivingLicenceNo
        '
        Me.UcLabelDriverTruckDrivingLicenceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelDriverTruckDrivingLicenceNo.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverTruckDrivingLicenceNo.Location = New System.Drawing.Point(428, 40)
        Me.UcLabelDriverTruckDrivingLicenceNo.Name = "UcLabelDriverTruckDrivingLicenceNo"
        Me.UcLabelDriverTruckDrivingLicenceNo.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDriverTruckDrivingLicenceNo.Size = New System.Drawing.Size(91, 25)
        Me.UcLabelDriverTruckDrivingLicenceNo.TabIndex = 5
        Me.UcLabelDriverTruckDrivingLicenceNo.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverTruckDrivingLicenceNo.UCFont = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.UcLabelDriverTruckDrivingLicenceNo.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDriverTruckDrivingLicenceNo.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDriverTruckDrivingLicenceNo.UCValue = "5526532564"
        '
        'UcLabelDriverTruckNationalCode
        '
        Me.UcLabelDriverTruckNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLabelDriverTruckNationalCode.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverTruckNationalCode.Location = New System.Drawing.Point(574, 38)
        Me.UcLabelDriverTruckNationalCode.Name = "UcLabelDriverTruckNationalCode"
        Me.UcLabelDriverTruckNationalCode.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDriverTruckNationalCode.Size = New System.Drawing.Size(92, 25)
        Me.UcLabelDriverTruckNationalCode.TabIndex = 6
        Me.UcLabelDriverTruckNationalCode.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDriverTruckNationalCode.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelDriverTruckNationalCode.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelDriverTruckNationalCode.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDriverTruckNationalCode.UCValue = "1286939623"
        '
        'UCDriverTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCDriverTruck"
        Me.Size = New System.Drawing.Size(739, 91)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabel5 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents UcPersianTextBoxSmartCardNo As R2CoreWinFormRemoteApplications.UCPersianTextBox
    Friend WithEvents UcButtonGetInfRMTO As R2CoreWinFormRemoteApplications.UCButton
    Friend WithEvents UcLabel1 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel2 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel3 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelDriverTruckDrivingLicenceNo As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelDriverTruckNationalCode As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelPersonFullName As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel4 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcButtonGetInfLocalDataBase As UCButton
End Class
