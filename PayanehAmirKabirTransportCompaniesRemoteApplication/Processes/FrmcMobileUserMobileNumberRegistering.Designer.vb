
Imports R2CoreWinFormRemoteApplications

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMobileUserMobileNumberRegistering
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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPnlMobileUserMobileNumberRegistering = New System.Windows.Forms.Button()
        Me.PnlMobileUserMobileNumberRegistering = New System.Windows.Forms.Panel()
        Me.UcDriverTruck = New PAKTCRemoteApplication.UCDriverTruck()
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering = New R2CoreWinFormRemoteApplications.UCButtonSpecial()
        Me.UcPersianTextBoxTruckDriverMobileNumber = New R2CoreWinFormRemoteApplications.UCPersianTextBox()
        Me.UcLabel1 = New R2CoreWinFormRemoteApplications.UCLabel()
        Me.PnlTopMenu.SuspendLayout()
        Me.PnlMobileUserMobileNumberRegistering.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPnlMobileUserMobileNumberRegistering)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 207
        '
        'BtnPnlMobileUserMobileNumberRegistering
        '
        Me.BtnPnlMobileUserMobileNumberRegistering.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPnlMobileUserMobileNumberRegistering.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPnlMobileUserMobileNumberRegistering.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPnlMobileUserMobileNumberRegistering.ForeColor = System.Drawing.Color.White
        Me.BtnPnlMobileUserMobileNumberRegistering.Location = New System.Drawing.Point(6, 3)
        Me.BtnPnlMobileUserMobileNumberRegistering.Name = "BtnPnlMobileUserMobileNumberRegistering"
        Me.BtnPnlMobileUserMobileNumberRegistering.Size = New System.Drawing.Size(140, 35)
        Me.BtnPnlMobileUserMobileNumberRegistering.TabIndex = 0
        Me.BtnPnlMobileUserMobileNumberRegistering.Text = "ثبت موبایل راننده"
        Me.BtnPnlMobileUserMobileNumberRegistering.UseVisualStyleBackColor = False
        '
        'PnlMobileUserMobileNumberRegistering
        '
        Me.PnlMobileUserMobileNumberRegistering.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMobileUserMobileNumberRegistering.BackColor = System.Drawing.Color.Transparent
        Me.PnlMobileUserMobileNumberRegistering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMobileUserMobileNumberRegistering.Controls.Add(Me.UcLabel1)
        Me.PnlMobileUserMobileNumberRegistering.Controls.Add(Me.UcPersianTextBoxTruckDriverMobileNumber)
        Me.PnlMobileUserMobileNumberRegistering.Controls.Add(Me.UcButtonSpecialTruckDriverMobileNumberRegistering)
        Me.PnlMobileUserMobileNumberRegistering.Controls.Add(Me.UcDriverTruck)
        Me.PnlMobileUserMobileNumberRegistering.Location = New System.Drawing.Point(5, 50)
        Me.PnlMobileUserMobileNumberRegistering.Name = "PnlMobileUserMobileNumberRegistering"
        Me.PnlMobileUserMobileNumberRegistering.Size = New System.Drawing.Size(995, 512)
        Me.PnlMobileUserMobileNumberRegistering.TabIndex = 208
        '
        'UcDriverTruck
        '
        Me.UcDriverTruck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDriverTruck.BackColor = System.Drawing.Color.Transparent
        Me.UcDriverTruck.Location = New System.Drawing.Point(92, 110)
        Me.UcDriverTruck.Name = "UcDriverTruck"
        Me.UcDriverTruck.Size = New System.Drawing.Size(800, 92)
        Me.UcDriverTruck.TabIndex = 5
        '
        'UcButtonSpecialTruckDriverMobileNumberRegistering
        '
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.Location = New System.Drawing.Point(92, 246)
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.Name = "UcButtonSpecialTruckDriverMobileNumberRegistering"
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.Size = New System.Drawing.Size(141, 40)
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.TabIndex = 6
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCEnable = True
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCForeColor = System.Drawing.Color.Blue
        Me.UcButtonSpecialTruckDriverMobileNumberRegistering.UCValue = "ثبت شماره موبایل"
        '
        'UcPersianTextBoxTruckDriverMobileNumber
        '
        Me.UcPersianTextBoxTruckDriverMobileNumber.Location = New System.Drawing.Point(92, 208)
        Me.UcPersianTextBoxTruckDriverMobileNumber.MaxCharacterReached = CType(50, Short)
        Me.UcPersianTextBoxTruckDriverMobileNumber.Name = "UcPersianTextBoxTruckDriverMobileNumber"
        Me.UcPersianTextBoxTruckDriverMobileNumber.Size = New System.Drawing.Size(141, 30)
        Me.UcPersianTextBoxTruckDriverMobileNumber.TabIndex = 7
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCBackColor = System.Drawing.Color.White
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCBorder = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCEnable = True
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCForeColor = System.Drawing.Color.Blue
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCOnlyDigit = R2CoreWinFormRemoteApplications.R2CoreWinFormRemoteApplicationsEnums.OnlyDigit.OnlyDigit
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UcPersianTextBoxTruckDriverMobileNumber.UCValue = "091"
        '
        'UcLabel1
        '
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(239, 208)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(140, 32)
        Me.UcLabel1.TabIndex = 8
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Blue
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "شماره موبایل راننده:"
        '
        'FrmcMobileUserRegistering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMobileUserMobileNumberRegistering)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcMobileUserRegistering"
        Me.Text = "FrmcMobileUserRegistering"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlMobileUserMobileNumberRegistering, 0)
        Me.PnlTopMenu.ResumeLayout(False)
        Me.PnlMobileUserMobileNumberRegistering.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTopMenu As Panel
    Friend WithEvents BtnPnlMobileUserMobileNumberRegistering As Button
    Friend WithEvents PnlMobileUserMobileNumberRegistering As Panel
    Friend WithEvents UcDriverTruck As UCDriverTruck
    Friend WithEvents UcLabel1 As UCLabel
    Friend WithEvents UcPersianTextBoxTruckDriverMobileNumber As UCPersianTextBox
    Friend WithEvents UcButtonSpecialTruckDriverMobileNumberRegistering As UCButtonSpecial
End Class
