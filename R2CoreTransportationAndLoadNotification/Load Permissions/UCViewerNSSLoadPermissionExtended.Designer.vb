<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSLoadPermissionExtended
    Inherits UCLoadPermission

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCViewerNSSLoadPermissionExtended))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PicDoPrintLoadPermission = New System.Windows.Forms.PictureBox()
        Me.UcMinimizeMaximize = New R2CoreGUI.UCMinimizeMaximize()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTransportCompanyTitle = New System.Windows.Forms.Label()
        Me.LabelGoodTitle = New System.Windows.Forms.Label()
        Me.LabelLoadTargetTitle = New System.Windows.Forms.Label()
        Me.LabelTruck = New System.Windows.Forms.Label()
        Me.LabelTruckDriver = New System.Windows.Forms.Label()
        Me.LabelLoadPermissionStatus = New System.Windows.Forms.Label()
        Me.LabelStrDescription = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblnEstelamId = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicDoPrintLoadPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(985, 69)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(4)
        Me.PnlOutter.Size = New System.Drawing.Size(985, 69)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PnlInner.Controls.Add(Me.LabelUserName)
        Me.PnlInner.Controls.Add(Me.PnlTop)
        Me.PnlInner.Controls.Add(Me.Label5)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(4, 4)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(975, 59)
        Me.PnlInner.TabIndex = 0
        '
        'LabelUserName
        '
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelUserName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelUserName.ForeColor = System.Drawing.Color.Black
        Me.LabelUserName.Location = New System.Drawing.Point(876, 89)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(93, 23)
        Me.LabelUserName.TabIndex = 59
        Me.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTop
        '
        Me.PnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTop.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PnlTop.Controls.Add(Me.LblnEstelamId)
        Me.PnlTop.Controls.Add(Me.Label6)
        Me.PnlTop.Controls.Add(Me.PicDoPrintLoadPermission)
        Me.PnlTop.Controls.Add(Me.UcMinimizeMaximize)
        Me.PnlTop.Controls.Add(Me.Label7)
        Me.PnlTop.Controls.Add(Me.Label8)
        Me.PnlTop.Controls.Add(Me.Label4)
        Me.PnlTop.Controls.Add(Me.Label3)
        Me.PnlTop.Controls.Add(Me.Label2)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.LabelTransportCompanyTitle)
        Me.PnlTop.Controls.Add(Me.LabelGoodTitle)
        Me.PnlTop.Controls.Add(Me.LabelLoadTargetTitle)
        Me.PnlTop.Controls.Add(Me.LabelTruck)
        Me.PnlTop.Controls.Add(Me.LabelTruckDriver)
        Me.PnlTop.Controls.Add(Me.LabelLoadPermissionStatus)
        Me.PnlTop.Controls.Add(Me.LabelStrDescription)
        Me.PnlTop.Location = New System.Drawing.Point(3, 3)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(969, 60)
        Me.PnlTop.TabIndex = 1
        '
        'PicDoPrintLoadPermission
        '
        Me.PicDoPrintLoadPermission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDoPrintLoadPermission.Image = CType(resources.GetObject("PicDoPrintLoadPermission.Image"), System.Drawing.Image)
        Me.PicDoPrintLoadPermission.Location = New System.Drawing.Point(0, 0)
        Me.PicDoPrintLoadPermission.Name = "PicDoPrintLoadPermission"
        Me.PicDoPrintLoadPermission.Size = New System.Drawing.Size(19, 21)
        Me.PicDoPrintLoadPermission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDoPrintLoadPermission.TabIndex = 64
        Me.PicDoPrintLoadPermission.TabStop = False
        '
        'UcMinimizeMaximize
        '
        Me.UcMinimizeMaximize.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimizeMaximize.Location = New System.Drawing.Point(1, 25)
        Me.UcMinimizeMaximize.Name = "UcMinimizeMaximize"
        Me.UcMinimizeMaximize.Size = New System.Drawing.Size(19, 21)
        Me.UcMinimizeMaximize.TabIndex = 54
        Me.UcMinimizeMaximize.UCCurrentMaxMinStatus = R2Core.R2Enums.MaxMin.Min
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(8, -6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "وضعیت"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(278, -6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 23)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ناوگان"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(103, -6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "راننده"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(373, -6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "مقصد"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(568, -6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "نوع بار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(752, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "شرکت حمل ونقل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTransportCompanyTitle
        '
        Me.LabelTransportCompanyTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTransportCompanyTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransportCompanyTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTransportCompanyTitle.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransportCompanyTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTransportCompanyTitle.Location = New System.Drawing.Point(756, 12)
        Me.LabelTransportCompanyTitle.Name = "LabelTransportCompanyTitle"
        Me.LabelTransportCompanyTitle.Size = New System.Drawing.Size(210, 23)
        Me.LabelTransportCompanyTitle.TabIndex = 56
        Me.LabelTransportCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGoodTitle
        '
        Me.LabelGoodTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoodTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoodTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelGoodTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelGoodTitle.Location = New System.Drawing.Point(572, 12)
        Me.LabelGoodTitle.Name = "LabelGoodTitle"
        Me.LabelGoodTitle.Size = New System.Drawing.Size(90, 23)
        Me.LabelGoodTitle.TabIndex = 57
        Me.LabelGoodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadTargetTitle
        '
        Me.LabelLoadTargetTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadTargetTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadTargetTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadTargetTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadTargetTitle.Location = New System.Drawing.Point(377, 12)
        Me.LabelLoadTargetTitle.Name = "LabelLoadTargetTitle"
        Me.LabelLoadTargetTitle.Size = New System.Drawing.Size(181, 23)
        Me.LabelLoadTargetTitle.TabIndex = 58
        Me.LabelLoadTargetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTruck
        '
        Me.LabelTruck.BackColor = System.Drawing.Color.Transparent
        Me.LabelTruck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTruck.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelTruck.ForeColor = System.Drawing.Color.Red
        Me.LabelTruck.Location = New System.Drawing.Point(278, 12)
        Me.LabelTruck.Name = "LabelTruck"
        Me.LabelTruck.Size = New System.Drawing.Size(93, 23)
        Me.LabelTruck.TabIndex = 59
        Me.LabelTruck.Text = "456ع45-13"
        Me.LabelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTruckDriver
        '
        Me.LabelTruckDriver.BackColor = System.Drawing.Color.Transparent
        Me.LabelTruckDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTruckDriver.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelTruckDriver.ForeColor = System.Drawing.Color.Black
        Me.LabelTruckDriver.Location = New System.Drawing.Point(107, 12)
        Me.LabelTruckDriver.Name = "LabelTruckDriver"
        Me.LabelTruckDriver.Size = New System.Drawing.Size(165, 23)
        Me.LabelTruckDriver.TabIndex = 60
        Me.LabelTruckDriver.Text = "شیشیشی"
        Me.LabelTruckDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadPermissionStatus
        '
        Me.LabelLoadPermissionStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadPermissionStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadPermissionStatus.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadPermissionStatus.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadPermissionStatus.Location = New System.Drawing.Point(0, 12)
        Me.LabelLoadPermissionStatus.Name = "LabelLoadPermissionStatus"
        Me.LabelLoadPermissionStatus.Size = New System.Drawing.Size(97, 21)
        Me.LabelLoadPermissionStatus.TabIndex = 61
        Me.LabelLoadPermissionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStrDescription
        '
        Me.LabelStrDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStrDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelStrDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelStrDescription.Font = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStrDescription.ForeColor = System.Drawing.Color.Blue
        Me.LabelStrDescription.Location = New System.Drawing.Point(50, 31)
        Me.LabelStrDescription.Name = "LabelStrDescription"
        Me.LabelStrDescription.Size = New System.Drawing.Size(916, 22)
        Me.LabelStrDescription.TabIndex = 63
        Me.LabelStrDescription.Text = "شسیمکنت کشسی تشکیتکشسمیت کشسی"
        Me.LabelStrDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(872, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "کاربر"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(668, -6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "کد بار"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblnEstelamId
        '
        Me.LblnEstelamId.BackColor = System.Drawing.Color.Transparent
        Me.LblnEstelamId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblnEstelamId.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LblnEstelamId.ForeColor = System.Drawing.Color.Red
        Me.LblnEstelamId.Location = New System.Drawing.Point(672, 12)
        Me.LblnEstelamId.Name = "LblnEstelamId"
        Me.LblnEstelamId.Size = New System.Drawing.Size(78, 23)
        Me.LblnEstelamId.TabIndex = 66
        Me.LblnEstelamId.Text = "123456"
        Me.LblnEstelamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCViewerNSSLoadPermissionExtended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSLoadPermissionExtended"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(1005, 89)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.PnlTop.ResumeLayout(false)
        CType(Me.PicDoPrintLoadPermission,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
    Friend WithEvents UcMinimizeMaximize As R2CoreGUI.UCMinimizeMaximize
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTransportCompanyTitle As System.Windows.Forms.Label
    Friend WithEvents LabelGoodTitle As System.Windows.Forms.Label
    Friend WithEvents LabelLoadTargetTitle As System.Windows.Forms.Label
    Friend WithEvents LabelTruck As System.Windows.Forms.Label
    Friend WithEvents LabelTruckDriver As System.Windows.Forms.Label
    Friend WithEvents LabelLoadPermissionStatus As System.Windows.Forms.Label
    Friend WithEvents LabelStrDescription As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PicDoPrintLoadPermission As Windows.Forms.PictureBox
    Friend WithEvents LblnEstelamId As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
