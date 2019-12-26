Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarTruck
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
        Me.UcButtonGetInfLocalDataBase = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcPersianTextBoxSmartCardNo = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcButtonGetInfRMTO = New R2CoreWinFormRemoteApplications.UCButton()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel2 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabel3 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelCarTruckSerial = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.UcLabelCarTruckPelak = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.SeaShell
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Controls.Add(Me.UcLabel5)
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(492, 94)
        Me.PnlMain.TabIndex = 0
        '
        'UcLabel5
        '
        Me.UcLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel5.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.Location = New System.Drawing.Point(397, -7)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel5.Size = New System.Drawing.Size(82, 32)
        Me.UcLabel5.TabIndex = 7
        Me.UcLabel5.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel5.UCFont = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel5.UCForeColor = System.Drawing.Color.Red
        Me.UcLabel5.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel5.UCValue = "ناوگان باری"
        '
        'PnlInner
        '
        Me.PnlInner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlInner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInner.Controls.Add(Me.UcButtonGetInfLocalDataBase)
        Me.PnlInner.Controls.Add(Me.UcPersianTextBoxSmartCardNo)
        Me.PnlInner.Controls.Add(Me.UcButtonGetInfRMTO)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.UcLabel2)
        Me.PnlInner.Controls.Add(Me.UcLabel3)
        Me.PnlInner.Controls.Add(Me.UcLabelCarTruckSerial)
        Me.PnlInner.Controls.Add(Me.UcLabelCarTruckPelak)
        Me.PnlInner.Location = New System.Drawing.Point(3, 10)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(485, 79)
        Me.PnlInner.TabIndex = 8
        '
        'UcButtonGetInfLocalDataBase
        '
        Me.UcButtonGetInfLocalDataBase.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonGetInfLocalDataBase.Location = New System.Drawing.Point(3, 35)
        Me.UcButtonGetInfLocalDataBase.Name = "UcButtonGetInfLocalDataBase"
        Me.UcButtonGetInfLocalDataBase.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonGetInfLocalDataBase.Size = New System.Drawing.Size(168, 36)
        Me.UcButtonGetInfLocalDataBase.TabIndex = 8
        Me.UcButtonGetInfLocalDataBase.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonGetInfLocalDataBase.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonGetInfLocalDataBase.UCEnable = true
        Me.UcButtonGetInfLocalDataBase.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonGetInfLocalDataBase.UCForeColor = System.Drawing.Color.White
        Me.UcButtonGetInfLocalDataBase.UCValue = "استعلام از بانک اطلاعات پایانه"
        '
        'UcPersianTextBoxSmartCardNo
        '
        Me.UcPersianTextBoxSmartCardNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcPersianTextBoxSmartCardNo.Location = New System.Drawing.Point(246, 5)
        Me.UcPersianTextBoxSmartCardNo.MaxCharacterReached = CType(50,Short)
        Me.UcPersianTextBoxSmartCardNo.Name = "UcPersianTextBoxSmartCardNo"
        Me.UcPersianTextBoxSmartCardNo.Size = New System.Drawing.Size(142, 28)
        Me.UcPersianTextBoxSmartCardNo.TabIndex = 7
        Me.UcPersianTextBoxSmartCardNo.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxSmartCardNo.UCEnable = true
        Me.UcPersianTextBoxSmartCardNo.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcPersianTextBoxSmartCardNo.UCForeColor = System.Drawing.Color.Black
        Me.UcPersianTextBoxSmartCardNo.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.Any
        Me.UcPersianTextBoxSmartCardNo.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxSmartCardNo.UCValue = ""
        '
        'UcButtonGetInfRMTO
        '
        Me.UcButtonGetInfRMTO.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonGetInfRMTO.Location = New System.Drawing.Point(174, 35)
        Me.UcButtonGetInfRMTO.Name = "UcButtonGetInfRMTO"
        Me.UcButtonGetInfRMTO.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonGetInfRMTO.Size = New System.Drawing.Size(162, 36)
        Me.UcButtonGetInfRMTO.TabIndex = 2
        Me.UcButtonGetInfRMTO.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonGetInfRMTO.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonGetInfRMTO.UCEnable = true
        Me.UcButtonGetInfRMTO.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonGetInfRMTO.UCForeColor = System.Drawing.Color.White
        Me.UcButtonGetInfRMTO.UCValue = "استعلام از وب سایت هوشمند"
        '
        'UcLabel1
        '
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(387, 2)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(91, 32)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "شماره هوشمند"
        '
        'UcLabel2
        '
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(169, -2)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(41, 32)
        Me.UcLabel2.TabIndex = 3
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Green
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel2.UCValue = "پلاک"
        '
        'UcLabel3
        '
        Me.UcLabel3.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.Location = New System.Drawing.Point(46, -2)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel3.Size = New System.Drawing.Size(41, 32)
        Me.UcLabel3.TabIndex = 4
        Me.UcLabel3.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel3.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel3.UCForeColor = System.Drawing.Color.Green
        Me.UcLabel3.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel3.UCValue = "سریال"
        '
        'UcLabelCarTruckSerial
        '
        Me.UcLabelCarTruckSerial.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckSerial.Location = New System.Drawing.Point(14, 4)
        Me.UcLabelCarTruckSerial.Name = "UcLabelCarTruckSerial"
        Me.UcLabelCarTruckSerial.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarTruckSerial.Size = New System.Drawing.Size(33, 25)
        Me.UcLabelCarTruckSerial.TabIndex = 5
        Me.UcLabelCarTruckSerial.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckSerial.UCFont = New System.Drawing.Font("Alborz Titr", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelCarTruckSerial.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCarTruckSerial.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarTruckSerial.UCValue = "13"
        '
        'UcLabelCarTruckPelak
        '
        Me.UcLabelCarTruckPelak.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckPelak.Location = New System.Drawing.Point(88, 2)
        Me.UcLabelCarTruckPelak.Name = "UcLabelCarTruckPelak"
        Me.UcLabelCarTruckPelak.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCarTruckPelak.Size = New System.Drawing.Size(73, 25)
        Me.UcLabelCarTruckPelak.TabIndex = 6
        Me.UcLabelCarTruckPelak.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCarTruckPelak.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelCarTruckPelak.UCForeColor = System.Drawing.Color.Black
        Me.UcLabelCarTruckPelak.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCarTruckPelak.UCValue = "813ع48"
        '
        'UCCarTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarTruck"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(498, 100)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcLabel5 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents UcButtonGetInfRMTO As R2CoreWinFormRemoteApplications.UCButton
    Friend WithEvents UcLabel1 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel2 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabel3 As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelCarTruckSerial As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcLabelCarTruckPelak As R2CoreWinFormRemoteApplications.UCLabel
    Friend WithEvents UcPersianTextBoxSmartCardNo As R2CoreWinFormRemoteApplications.UCPersianTextBox
    Friend WithEvents UcButtonGetInfLocalDataBase As UCButton
End Class
