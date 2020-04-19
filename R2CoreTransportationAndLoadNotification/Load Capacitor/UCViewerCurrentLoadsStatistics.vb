
Imports System.ComponentModel
Imports System.Reflection

Imports R2CoreGUI
Imports R2CoreTransportationAndLoadNotification.AnnouncementHalls
Imports R2CoreTransportationAndLoadNotification.LoadCapacitor.LoadCapacitorLoad

Public Class UCViewerCurrentLoadsStatistics
    Inherits UCGeneral

#Region "General Properties"

    Private _UCViewTitle As Boolean = True
    <Browsable(True)>
    Public Property UCViewTitle() As Boolean
        Get
            Return _UCViewTitle
        End Get
        Set(value As Boolean)
            _UCViewTitle = value
            UcLabelTop.Visible = value
        End Set
    End Property



#End Region

#Region "Subroutins And Functions"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabelReminder As UCLabel
    Friend WithEvents UcLabelRegistered As UCLabel
    Friend WithEvents UcLabelLoadAllocated As UCLabel

    Private Sub InitializeComponent()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UcLabelRegistered = New R2CoreGUI.UCLabel()
        Me.UcLabelSedimented = New R2CoreGUI.UCLabel()
        Me.UcLabelDeleted = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadPermissionCancelled = New R2CoreGUI.UCLabel()
        Me.UcLabelIncremented = New R2CoreGUI.UCLabel()
        Me.UcLabelCancelled = New R2CoreGUI.UCLabel()
        Me.UcLabelDecremented = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadPermissioned = New R2CoreGUI.UCLabel()
        Me.UcLabelFreeLined = New R2CoreGUI.UCLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UcLabelAnnounced = New R2CoreGUI.UCLabel()
        Me.UcLabelLoadAllocated = New R2CoreGUI.UCLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UcLabelLoadAllocationCancelled = New R2CoreGUI.UCLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UcLabelReminder = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.AlphaGradientPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(804, 406)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(804, 406)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcLabelTop)
        Me.PnlInner.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(800, 402)
        Me.PnlInner.TabIndex = 0
        '
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(800, 37)
        Me.UcLabelTop.TabIndex = 352
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "آمار بار"
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = false
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label12)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelRegistered)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelSedimented)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelDeleted)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelLoadPermissionCancelled)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelIncremented)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelCancelled)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelDecremented)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelLoadPermissioned)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelFreeLined)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label13)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelAnnounced)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelLoadAllocated)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label11)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelLoadAllocationCancelled)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label10)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label9)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label8)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label2)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label7)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label3)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label6)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label4)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label5)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcLabelReminder)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AlphaGradientPanel1.Gradient = true
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = false
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 42)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = true
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(800, 360)
        Me.AlphaGradientPanel1.TabIndex = 356
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(13, 10)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(777, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 355
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(296, 292)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(237, 39)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "باقیمانده بار سالن اعلام بار"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelRegistered
        '
        Me.UcLabelRegistered._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelRegistered._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelRegistered.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelRegistered.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelRegistered.ForeColor = System.Drawing.Color.MediumBlue
        Me.UcLabelRegistered.Location = New System.Drawing.Point(362, 122)
        Me.UcLabelRegistered.Name = "UcLabelRegistered"
        Me.UcLabelRegistered.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelRegistered.Size = New System.Drawing.Size(105, 22)
        Me.UcLabelRegistered.TabIndex = 0
        Me.UcLabelRegistered.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelRegistered.UCFont = New System.Drawing.Font("Alborz Titr", 14.25!)
        Me.UcLabelRegistered.UCForeColor = System.Drawing.Color.Green
        Me.UcLabelRegistered.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelRegistered.UCValue = "126"
        '
        'UcLabelSedimented
        '
        Me.UcLabelSedimented._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelSedimented._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelSedimented.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelSedimented.Location = New System.Drawing.Point(248, 269)
        Me.UcLabelSedimented.Name = "UcLabelSedimented"
        Me.UcLabelSedimented.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelSedimented.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelSedimented.TabIndex = 26
        Me.UcLabelSedimented.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelSedimented.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelSedimented.UCForeColor = System.Drawing.Color.DarkViolet
        Me.UcLabelSedimented.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelSedimented.UCValue = "126"
        '
        'UcLabelDeleted
        '
        Me.UcLabelDeleted._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDeleted._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDeleted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDeleted.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDeleted.ForeColor = System.Drawing.Color.Red
        Me.UcLabelDeleted.Location = New System.Drawing.Point(729, 175)
        Me.UcLabelDeleted.Name = "UcLabelDeleted"
        Me.UcLabelDeleted.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDeleted.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelDeleted.TabIndex = 17
        Me.UcLabelDeleted.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDeleted.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelDeleted.UCForeColor = System.Drawing.Color.Red
        Me.UcLabelDeleted.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDeleted.UCValue = "126"
        '
        'UcLabelLoadPermissionCancelled
        '
        Me.UcLabelLoadPermissionCancelled._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissionCancelled._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadPermissionCancelled.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissionCancelled.ForeColor = System.Drawing.Color.Cyan
        Me.UcLabelLoadPermissionCancelled.Location = New System.Drawing.Point(148, 268)
        Me.UcLabelLoadPermissionCancelled.Name = "UcLabelLoadPermissionCancelled"
        Me.UcLabelLoadPermissionCancelled.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadPermissionCancelled.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelLoadPermissionCancelled.TabIndex = 25
        Me.UcLabelLoadPermissionCancelled.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissionCancelled.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelLoadPermissionCancelled.UCForeColor = System.Drawing.Color.MediumSlateBlue
        Me.UcLabelLoadPermissionCancelled.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadPermissionCancelled.UCValue = "126"
        '
        'UcLabelIncremented
        '
        Me.UcLabelIncremented._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelIncremented._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelIncremented.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelIncremented.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelIncremented.Location = New System.Drawing.Point(651, 175)
        Me.UcLabelIncremented.Name = "UcLabelIncremented"
        Me.UcLabelIncremented.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelIncremented.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelIncremented.TabIndex = 18
        Me.UcLabelIncremented.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelIncremented.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelIncremented.UCForeColor = System.Drawing.Color.Green
        Me.UcLabelIncremented.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelIncremented.UCValue = "126"
        '
        'UcLabelCancelled
        '
        Me.UcLabelCancelled._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelCancelled._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelCancelled.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelCancelled.Location = New System.Drawing.Point(38, 268)
        Me.UcLabelCancelled.Name = "UcLabelCancelled"
        Me.UcLabelCancelled.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelCancelled.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelCancelled.TabIndex = 24
        Me.UcLabelCancelled.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelCancelled.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelCancelled.UCForeColor = System.Drawing.Color.BlueViolet
        Me.UcLabelCancelled.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelCancelled.UCValue = "126"
        '
        'UcLabelDecremented
        '
        Me.UcLabelDecremented._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelDecremented._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelDecremented.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelDecremented.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelDecremented.Location = New System.Drawing.Point(583, 175)
        Me.UcLabelDecremented.Name = "UcLabelDecremented"
        Me.UcLabelDecremented.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelDecremented.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelDecremented.TabIndex = 19
        Me.UcLabelDecremented.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelDecremented.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelDecremented.UCForeColor = System.Drawing.Color.OrangeRed
        Me.UcLabelDecremented.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelDecremented.UCValue = "126"
        '
        'UcLabelLoadPermissioned
        '
        Me.UcLabelLoadPermissioned._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissioned._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadPermissioned.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelLoadPermissioned.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissioned.Location = New System.Drawing.Point(327, 269)
        Me.UcLabelLoadPermissioned.Name = "UcLabelLoadPermissioned"
        Me.UcLabelLoadPermissioned.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadPermissioned.Size = New System.Drawing.Size(463, 22)
        Me.UcLabelLoadPermissioned.TabIndex = 23
        Me.UcLabelLoadPermissioned.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadPermissioned.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelLoadPermissioned.UCForeColor = System.Drawing.Color.Magenta
        Me.UcLabelLoadPermissioned.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadPermissioned.UCValue = "126"
        '
        'UcLabelFreeLined
        '
        Me.UcLabelFreeLined._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelFreeLined._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelFreeLined.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelFreeLined.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelFreeLined.Location = New System.Drawing.Point(514, 175)
        Me.UcLabelFreeLined.Name = "UcLabelFreeLined"
        Me.UcLabelFreeLined.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelFreeLined.Size = New System.Drawing.Size(40, 22)
        Me.UcLabelFreeLined.TabIndex = 21
        Me.UcLabelFreeLined.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelFreeLined.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelFreeLined.UCForeColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelFreeLined.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelFreeLined.UCValue = "126"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(8, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(503, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "اعلام شده"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelAnnounced
        '
        Me.UcLabelAnnounced._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelAnnounced.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabelAnnounced.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced.Location = New System.Drawing.Point(13, 175)
        Me.UcLabelAnnounced.Name = "UcLabelAnnounced"
        Me.UcLabelAnnounced.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelAnnounced.Size = New System.Drawing.Size(498, 22)
        Me.UcLabelAnnounced.TabIndex = 22
        Me.UcLabelAnnounced.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelAnnounced.UCFont = New System.Drawing.Font("Alborz Titr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelAnnounced.UCForeColor = System.Drawing.Color.MidnightBlue
        Me.UcLabelAnnounced.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelAnnounced.UCValue = "126"
        '
        'UcLabelLoadAllocated
        '
        Me.UcLabelLoadAllocated._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocated._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadAllocated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelLoadAllocated.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocated.Location = New System.Drawing.Point(458, 219)
        Me.UcLabelLoadAllocated.Name = "UcLabelLoadAllocated"
        Me.UcLabelLoadAllocated.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadAllocated.Size = New System.Drawing.Size(46, 22)
        Me.UcLabelLoadAllocated.TabIndex = 1
        Me.UcLabelLoadAllocated.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocated.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelLoadAllocated.UCForeColor = System.Drawing.Color.Crimson
        Me.UcLabelLoadAllocated.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadAllocated.UCValue = "126"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Magenta
        Me.Label11.Location = New System.Drawing.Point(322, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(468, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ترخیص شده"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelLoadAllocationCancelled
        '
        Me.UcLabelLoadAllocationCancelled._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocationCancelled._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelLoadAllocationCancelled.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelLoadAllocationCancelled.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocationCancelled.Location = New System.Drawing.Point(323, 219)
        Me.UcLabelLoadAllocationCancelled.Name = "UcLabelLoadAllocationCancelled"
        Me.UcLabelLoadAllocationCancelled.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelLoadAllocationCancelled.Size = New System.Drawing.Size(46, 22)
        Me.UcLabelLoadAllocationCancelled.TabIndex = 353
        Me.UcLabelLoadAllocationCancelled.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelLoadAllocationCancelled.UCFont = New System.Drawing.Font("Alborz Titr", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelLoadAllocationCancelled.UCForeColor = System.Drawing.Color.HotPink
        Me.UcLabelLoadAllocationCancelled.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelLoadAllocationCancelled.UCValue = "126"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label10.Location = New System.Drawing.Point(119, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "کنسلی مجوز"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.HotPink
        Me.Label9.Location = New System.Drawing.Point(278, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "کنسلی تخصیص"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("B Homa", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(362, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ثبت شده"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label8.Location = New System.Drawing.Point(8, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "کنسل شده"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(507, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "خط آزاد"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(715, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "حذف شده"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(418, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "تخصیص داده شده"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(567, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "کاهش"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label4.Location = New System.Drawing.Point(231, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "رسوب شده"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(641, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "افزایش"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcLabelReminder
        '
        Me.UcLabelReminder._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelReminder._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelReminder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabelReminder.BackColor = System.Drawing.Color.Transparent
        Me.UcLabelReminder.Location = New System.Drawing.Point(380, 326)
        Me.UcLabelReminder.Name = "UcLabelReminder"
        Me.UcLabelReminder.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelReminder.Size = New System.Drawing.Size(69, 34)
        Me.UcLabelReminder.TabIndex = 2
        Me.UcLabelReminder.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabelReminder.UCFont = New System.Drawing.Font("Alborz Titr", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.UcLabelReminder.UCForeColor = System.Drawing.Color.Navy
        Me.UcLabelReminder.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelReminder.UCValue = "126"
        '
        'UCViewerCurrentLoadsStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerCurrentLoadsStatistics"
        Me.Size = New System.Drawing.Size(804, 406)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.AlphaGradientPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents UcLabelDecremented As UCLabel
    Friend WithEvents UcLabelIncremented As UCLabel
    Friend WithEvents UcLabelDeleted As UCLabel
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents UcLabelSedimented As UCLabel
    Friend WithEvents UcLabelLoadPermissionCancelled As UCLabel
    Friend WithEvents UcLabelCancelled As UCLabel
    Friend WithEvents UcLabelLoadPermissioned As UCLabel
    Friend WithEvents UcLabelAnnounced As UCLabel
    Friend WithEvents UcLabelFreeLined As UCLabel
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents UcLabelLoadAllocationCancelled As UCLabel
    Friend WithEvents UcAnnouncementHallSelection As UCAnnouncementHallSelection

    Public Overloads Sub UCRefreshGeneral()
        Try
            UcLabelRegistered.UCRefresh()
            UcLabelDeleted.UCRefresh()
            UcLabelIncremented.UCRefresh()
            UcLabelDecremented.UCRefresh()
            UcLabelFreeLined.UCRefresh()
            UcLabelAnnounced.UCRefresh()
            UcLabelLoadAllocated.UCRefresh()
            UcLabelLoadAllocationCancelled.UCRefresh()
            UcLabelLoadPermissioned.UCRefresh()
            UcLabelSedimented.UCRefresh()
            UcLabelLoadPermissionCancelled.UCRefresh()
            UcLabelCancelled.UCRefresh()
            UcLabelReminder.UCRefresh()
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub UCRefreshInformation(YourAHId As Int64, YourAHSGId As Int64)
        Try
            UCRefreshGeneral()
            UcLabelRegistered.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfRegisteredLoads(YourAHId, YourAHSGId)
            UcLabelDeleted.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfDeletedLoads(YourAHId, YourAHSGId)
            UcLabelIncremented.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfIncrementedLoads(YourAHId, YourAHSGId)
            UcLabelDecremented.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfDecrementedLoads(YourAHId, YourAHSGId)
            UcLabelFreeLined.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfFreeLinedLoads(YourAHId, YourAHSGId)
            UcLabelAnnounced.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfAnnouncedLoads(YourAHId, YourAHSGId)
            UcLabelLoadAllocated.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfLoadAllocated(YourAHId, YourAHSGId)
            UcLabelLoadAllocationCancelled.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfLoadAllocationCancelled(YourAHId, YourAHSGId)
            UcLabelLoadPermissioned.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfReleasedLoads(YourAHId, YourAHSGId)
            UcLabelSedimented.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfSedimentedLoads(YourAHId, YourAHSGId)
            UcLabelLoadPermissionCancelled.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfLoadPermissionCancelledLoads(YourAHId, YourAHSGId)
            UcLabelCancelled.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfCancelledLoads(YourAHId, YourAHSGId)
            UcLabelReminder.UCValue = R2CoreTransportationAndLoadNotificationMClassLoadCapacitorLoadManagement.GetTotalAmountOfReminderOfLoads(YourAHId, YourAHSGId)
        Catch ex As Exception
            Throw New Exception(MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message)
        End Try
    End Sub





#End Region

#Region "Events"
#End Region

#Region "Event Handlers"

    Private Sub UcAnnouncementHallSelection_UCCurrentNSSAnnouncementHallSubGroupChangedEvent(NSSAnnouncementHall As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure, NSSAnnouncementHallSubGroup As R2CoreTransportationAndLoadNotificationStandardAnnouncementHallSubGroupStructure) Handles UcAnnouncementHallSelection.UCCurrentNSSAnnouncementHallSubGroupChangedEvent
        Try
            UCRefreshInformation(NSSAnnouncementHall.AHId, NSSAnnouncementHallSubGroup.AHSGId)
        Catch ex As Exception
            UCFrmMessageDialog.ViewDialogMessage(FrmcMessageDialog.DialogColorType.ErrorType, MethodBase.GetCurrentMethod().ReflectedType.FullName + "." + MethodBase.GetCurrentMethod().Name + vbCrLf + ex.Message, "", FrmcMessageDialog.MessageType.ErrorMessage, Nothing, Me)
        End Try
    End Sub

    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha

#End Region

#Region "Override Methods"
#End Region

#Region "Abstract Methods"
#End Region

#Region "Implemented Members"
#End Region





End Class
