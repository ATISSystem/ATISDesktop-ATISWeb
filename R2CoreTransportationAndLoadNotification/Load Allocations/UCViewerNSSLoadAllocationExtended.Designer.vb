<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSLoadAllocationExtended
    Inherits UCLoadAllocation

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCViewerNSSLoadAllocationExtended))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.LabelLoadPermissionResult = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.LabelTurnId = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelPriority = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelLAId = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelnEstelamId = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicDecreasePriority = New System.Windows.Forms.PictureBox()
        Me.PicBoxLoadAllocationCancellation = New System.Windows.Forms.PictureBox()
        Me.PicIncreasePriority = New System.Windows.Forms.PictureBox()
        Me.UcMinimizeMaximize = New R2CoreGUI.UCMinimizeMaximize()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTransportCompanyTitle = New System.Windows.Forms.Label()
        Me.LabelGoodTitle = New System.Windows.Forms.Label()
        Me.LabelLoadTargetTitle = New System.Windows.Forms.Label()
        Me.LabelTruck = New System.Windows.Forms.Label()
        Me.LabelDriverTruck = New System.Windows.Forms.Label()
        Me.LabelStrDescription = New System.Windows.Forms.Label()
        Me.LabelLoadAllocationStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PnlMain.SuspendLayout()
        Me.PnlOutter.SuspendLayout()
        Me.PnlInner.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        CType(Me.PicDecreasePriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxLoadAllocationCancellation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIncreasePriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(4)
        Me.PnlMain.Size = New System.Drawing.Size(1049, 80)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(4, 4)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(4)
        Me.PnlOutter.Size = New System.Drawing.Size(1041, 72)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.Honeydew
        Me.PnlInner.Controls.Add(Me.LabelLoadPermissionResult)
        Me.PnlInner.Controls.Add(Me.Label8)
        Me.PnlInner.Controls.Add(Me.PnlTop)
        Me.PnlInner.Controls.Add(Me.Label6)
        Me.PnlInner.Controls.Add(Me.LabelUserName)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(4, 4)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(1031, 62)
        Me.PnlInner.TabIndex = 0
        '
        'LabelLoadPermissionResult
        '
        Me.LabelLoadPermissionResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLoadPermissionResult.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadPermissionResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadPermissionResult.Font = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoadPermissionResult.ForeColor = System.Drawing.Color.Red
        Me.LabelLoadPermissionResult.Location = New System.Drawing.Point(3, 78)
        Me.LabelLoadPermissionResult.Name = "LabelLoadPermissionResult"
        Me.LabelLoadPermissionResult.Size = New System.Drawing.Size(918, 22)
        Me.LabelLoadPermissionResult.TabIndex = 64
        Me.LabelLoadPermissionResult.Text = "پیام دلیل عدم صدور مجوز بارگیری"
        Me.LabelLoadPermissionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(7, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(914, 23)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "توضیحات"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTop
        '
        Me.PnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTop.BackColor = System.Drawing.Color.Honeydew
        Me.PnlTop.Controls.Add(Me.LabelTurnId)
        Me.PnlTop.Controls.Add(Me.Label12)
        Me.PnlTop.Controls.Add(Me.LabelPriority)
        Me.PnlTop.Controls.Add(Me.Label11)
        Me.PnlTop.Controls.Add(Me.LabelLAId)
        Me.PnlTop.Controls.Add(Me.Label10)
        Me.PnlTop.Controls.Add(Me.LabelnEstelamId)
        Me.PnlTop.Controls.Add(Me.Label9)
        Me.PnlTop.Controls.Add(Me.PicDecreasePriority)
        Me.PnlTop.Controls.Add(Me.PicBoxLoadAllocationCancellation)
        Me.PnlTop.Controls.Add(Me.PicIncreasePriority)
        Me.PnlTop.Controls.Add(Me.UcMinimizeMaximize)
        Me.PnlTop.Controls.Add(Me.Label7)
        Me.PnlTop.Controls.Add(Me.Label5)
        Me.PnlTop.Controls.Add(Me.Label4)
        Me.PnlTop.Controls.Add(Me.Label3)
        Me.PnlTop.Controls.Add(Me.Label2)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Controls.Add(Me.LabelTransportCompanyTitle)
        Me.PnlTop.Controls.Add(Me.LabelGoodTitle)
        Me.PnlTop.Controls.Add(Me.LabelLoadTargetTitle)
        Me.PnlTop.Controls.Add(Me.LabelTruck)
        Me.PnlTop.Controls.Add(Me.LabelDriverTruck)
        Me.PnlTop.Controls.Add(Me.LabelStrDescription)
        Me.PnlTop.Controls.Add(Me.LabelLoadAllocationStatus)
        Me.PnlTop.Location = New System.Drawing.Point(3, 3)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1025, 60)
        Me.PnlTop.TabIndex = 1
        '
        'LabelTurnId
        '
        Me.LabelTurnId.BackColor = System.Drawing.Color.Transparent
        Me.LabelTurnId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTurnId.Font = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTurnId.ForeColor = System.Drawing.Color.Red
        Me.LabelTurnId.Location = New System.Drawing.Point(790, 12)
        Me.LabelTurnId.Name = "LabelTurnId"
        Me.LabelTurnId.Size = New System.Drawing.Size(67, 23)
        Me.LabelTurnId.TabIndex = 72
        Me.LabelTurnId.Text = "434780"
        Me.LabelTurnId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(790, -6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 23)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "نوبت"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPriority
        '
        Me.LabelPriority.BackColor = System.Drawing.Color.Transparent
        Me.LabelPriority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPriority.Font = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPriority.ForeColor = System.Drawing.Color.Red
        Me.LabelPriority.Location = New System.Drawing.Point(107, 12)
        Me.LabelPriority.Name = "LabelPriority"
        Me.LabelPriority.Size = New System.Drawing.Size(44, 23)
        Me.LabelPriority.TabIndex = 70
        Me.LabelPriority.Text = "5"
        Me.LabelPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(107, -6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 23)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "اولویت"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLAId
        '
        Me.LabelLAId.BackColor = System.Drawing.Color.Transparent
        Me.LabelLAId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLAId.Font = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLAId.ForeColor = System.Drawing.Color.Red
        Me.LabelLAId.Location = New System.Drawing.Point(696, 12)
        Me.LabelLAId.Name = "LabelLAId"
        Me.LabelLAId.Size = New System.Drawing.Size(88, 23)
        Me.LabelLAId.TabIndex = 68
        Me.LabelLAId.Text = "2128542"
        Me.LabelLAId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(697, -6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 23)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "تخصیص"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelnEstelamId
        '
        Me.LabelnEstelamId.BackColor = System.Drawing.Color.Transparent
        Me.LabelnEstelamId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelnEstelamId.Font = New System.Drawing.Font("IRMehr", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelnEstelamId.ForeColor = System.Drawing.Color.Red
        Me.LabelnEstelamId.Location = New System.Drawing.Point(602, 12)
        Me.LabelnEstelamId.Name = "LabelnEstelamId"
        Me.LabelnEstelamId.Size = New System.Drawing.Size(88, 23)
        Me.LabelnEstelamId.TabIndex = 66
        Me.LabelnEstelamId.Text = "543897"
        Me.LabelnEstelamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(606, -6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "کد بار"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicDecreasePriority
        '
        Me.PicDecreasePriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicDecreasePriority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDecreasePriority.Image = CType(resources.GetObject("PicDecreasePriority.Image"), System.Drawing.Image)
        Me.PicDecreasePriority.Location = New System.Drawing.Point(977, 1)
        Me.PicDecreasePriority.Name = "PicDecreasePriority"
        Me.PicDecreasePriority.Size = New System.Drawing.Size(20, 21)
        Me.PicDecreasePriority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDecreasePriority.TabIndex = 5
        Me.PicDecreasePriority.TabStop = False
        '
        'PicBoxLoadAllocationCancellation
        '
        Me.PicBoxLoadAllocationCancellation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicBoxLoadAllocationCancellation.Image = CType(resources.GetObject("PicBoxLoadAllocationCancellation.Image"), System.Drawing.Image)
        Me.PicBoxLoadAllocationCancellation.Location = New System.Drawing.Point(1, -1)
        Me.PicBoxLoadAllocationCancellation.Name = "PicBoxLoadAllocationCancellation"
        Me.PicBoxLoadAllocationCancellation.Size = New System.Drawing.Size(20, 20)
        Me.PicBoxLoadAllocationCancellation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxLoadAllocationCancellation.TabIndex = 64
        Me.PicBoxLoadAllocationCancellation.TabStop = False
        '
        'PicIncreasePriority
        '
        Me.PicIncreasePriority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicIncreasePriority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicIncreasePriority.Image = CType(resources.GetObject("PicIncreasePriority.Image"), System.Drawing.Image)
        Me.PicIncreasePriority.Location = New System.Drawing.Point(1000, 1)
        Me.PicIncreasePriority.Name = "PicIncreasePriority"
        Me.PicIncreasePriority.Size = New System.Drawing.Size(20, 21)
        Me.PicIncreasePriority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIncreasePriority.TabIndex = 4
        Me.PicIncreasePriority.TabStop = False
        '
        'UcMinimizeMaximize
        '
        Me.UcMinimizeMaximize.BackColor = System.Drawing.Color.Transparent
        Me.UcMinimizeMaximize.Location = New System.Drawing.Point(1, 33)
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
        Me.Label7.Size = New System.Drawing.Size(93, 23)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "وضعیت"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(161, -6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "راننده"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(298, -6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ناوگان"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(403, -6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "مقصد"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(512, -6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
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
        Me.Label1.Location = New System.Drawing.Point(859, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
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
        Me.LabelTransportCompanyTitle.Location = New System.Drawing.Point(863, 12)
        Me.LabelTransportCompanyTitle.Name = "LabelTransportCompanyTitle"
        Me.LabelTransportCompanyTitle.Size = New System.Drawing.Size(159, 23)
        Me.LabelTransportCompanyTitle.TabIndex = 56
        Me.LabelTransportCompanyTitle.Text = "شرکت حمل ونقل"
        Me.LabelTransportCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGoodTitle
        '
        Me.LabelGoodTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelGoodTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelGoodTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelGoodTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelGoodTitle.Location = New System.Drawing.Point(508, 12)
        Me.LabelGoodTitle.Name = "LabelGoodTitle"
        Me.LabelGoodTitle.Size = New System.Drawing.Size(88, 23)
        Me.LabelGoodTitle.TabIndex = 57
        Me.LabelGoodTitle.Text = "آجر نسوز"
        Me.LabelGoodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLoadTargetTitle
        '
        Me.LabelLoadTargetTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadTargetTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadTargetTitle.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadTargetTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelLoadTargetTitle.Location = New System.Drawing.Point(399, 12)
        Me.LabelLoadTargetTitle.Name = "LabelLoadTargetTitle"
        Me.LabelLoadTargetTitle.Size = New System.Drawing.Size(103, 23)
        Me.LabelLoadTargetTitle.TabIndex = 58
        Me.LabelLoadTargetTitle.Text = "تهران ستاره"
        Me.LabelLoadTargetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTruck
        '
        Me.LabelTruck.BackColor = System.Drawing.Color.Transparent
        Me.LabelTruck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTruck.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelTruck.ForeColor = System.Drawing.Color.Red
        Me.LabelTruck.Location = New System.Drawing.Point(298, 12)
        Me.LabelTruck.Name = "LabelTruck"
        Me.LabelTruck.Size = New System.Drawing.Size(95, 23)
        Me.LabelTruck.TabIndex = 59
        Me.LabelTruck.Text = "585ع45-13"
        Me.LabelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDriverTruck
        '
        Me.LabelDriverTruck.BackColor = System.Drawing.Color.Transparent
        Me.LabelDriverTruck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelDriverTruck.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelDriverTruck.ForeColor = System.Drawing.Color.Black
        Me.LabelDriverTruck.Location = New System.Drawing.Point(157, 12)
        Me.LabelDriverTruck.Name = "LabelDriverTruck"
        Me.LabelDriverTruck.Size = New System.Drawing.Size(135, 23)
        Me.LabelDriverTruck.TabIndex = 60
        Me.LabelDriverTruck.Text = "مرتضی شهمرادی"
        Me.LabelDriverTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStrDescription
        '
        Me.LabelStrDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStrDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelStrDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelStrDescription.Font = New System.Drawing.Font("IRMehr", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStrDescription.ForeColor = System.Drawing.Color.Blue
        Me.LabelStrDescription.Location = New System.Drawing.Point(37, 31)
        Me.LabelStrDescription.Name = "LabelStrDescription"
        Me.LabelStrDescription.Size = New System.Drawing.Size(985, 22)
        Me.LabelStrDescription.TabIndex = 63
        Me.LabelStrDescription.Text = "منم مشستی مشسنیتمشسنیت شمسینتشمس نیتمشسی"
        Me.LabelStrDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelLoadAllocationStatus
        '
        Me.LabelLoadAllocationStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoadAllocationStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLoadAllocationStatus.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelLoadAllocationStatus.ForeColor = System.Drawing.Color.Red
        Me.LabelLoadAllocationStatus.Location = New System.Drawing.Point(4, 12)
        Me.LabelLoadAllocationStatus.Name = "LabelLoadAllocationStatus"
        Me.LabelLoadAllocationStatus.Size = New System.Drawing.Size(97, 23)
        Me.LabelLoadAllocationStatus.TabIndex = 62
        Me.LabelLoadAllocationStatus.Text = "عدم صدور مجوز"
        Me.LabelLoadAllocationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(923, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "کاربر"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelUserName
        '
        Me.LabelUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUserName.BackColor = System.Drawing.Color.Transparent
        Me.LabelUserName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelUserName.Font = New System.Drawing.Font("IRMehr", 9.75!)
        Me.LabelUserName.ForeColor = System.Drawing.Color.Black
        Me.LabelUserName.Location = New System.Drawing.Point(927, 78)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(98, 21)
        Me.LabelUserName.TabIndex = 61
        Me.LabelUserName.Text = "تیموری"
        Me.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UCViewerNSSLoadAllocationExtended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSLoadAllocationExtended"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(1069, 100)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.PnlTop.ResumeLayout(false)
        CType(Me.PicDecreasePriority,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicBoxLoadAllocationCancellation,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicIncreasePriority,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlOutter As System.Windows.Forms.Panel
    Friend WithEvents PnlInner As System.Windows.Forms.Panel
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
    Friend WithEvents UcMinimizeMaximize As R2CoreGUI.UCMinimizeMaximize
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTransportCompanyTitle As System.Windows.Forms.Label
    Friend WithEvents LabelGoodTitle As System.Windows.Forms.Label
    Friend WithEvents LabelLoadTargetTitle As System.Windows.Forms.Label
    Friend WithEvents LabelTruck As System.Windows.Forms.Label
    Friend WithEvents LabelDriverTruck As System.Windows.Forms.Label
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents LabelStrDescription As System.Windows.Forms.Label
    Friend WithEvents LabelLoadAllocationStatus As System.Windows.Forms.Label
    Friend WithEvents LabelLoadPermissionResult As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PicBoxLoadAllocationCancellation As Windows.Forms.PictureBox
    Friend WithEvents PicDecreasePriority As Windows.Forms.PictureBox
    Friend WithEvents PicIncreasePriority As Windows.Forms.PictureBox
    Friend WithEvents LabelnEstelamId As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents LabelLAId As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents LabelPriority As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents LabelTurnId As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
End Class
