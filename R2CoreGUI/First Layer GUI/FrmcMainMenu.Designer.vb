<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcMainMenu
    Inherits System.Windows.Forms.Form

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
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems2 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcMainMenu))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlToolBoxSmall = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlphaPnlSmall0 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlphaPnlSmall1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlToolBoxBig = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlphaPnlBig00 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlphaPnlBig11 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlR2 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlphaPnlR20 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlphaPnlR21 = New BlueActivity.Controls.ColorWithAlpha()
        Me.LblBottomSystemTitle = New gLabel.gLabel()
        Me.LblBottomSystemPersianTitle = New System.Windows.Forms.Label()
        Me.LblApplicationDomainAbbreviationInner = New System.Windows.Forms.Label()
        Me.LblBottom1ApplicationDomainTitle = New System.Windows.Forms.Label()
        Me.LblBottom0ApplicationDomainTitle = New System.Windows.Forms.Label()
        Me.PnlBottom = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlTop = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.LblTopApplicationDomainEnglishTiltle = New gLabel.gLabel()
        Me.UcDateTime = New R2CoreGUI.UCDateTime()
        Me.LblTopApplicationDomainPersianTitle = New System.Windows.Forms.Label()
        Me.picexit = New System.Windows.Forms.PictureBox()
        Me.UcShutDown = New R2CoreGUI.UCShutDown()
        Me.PicMinimize = New System.Windows.Forms.PictureBox()
        Me.UcUserLogin = New R2CoreGUI.UCUserLogin()
        Me.PnlUserLogin = New System.Windows.Forms.Panel()
        Me.PnlMiddle1 = New System.Windows.Forms.Panel()
        Me.PnlMiddle2 = New System.Windows.Forms.Panel()
        Me.PnlMiddle3 = New System.Windows.Forms.Panel()
        Me.PnlMiddle = New System.Windows.Forms.Panel()
        Me.PnlMiddle4 = New System.Windows.Forms.Panel()
        Me.UcUserImage = New R2CoreGUI.UCUserImage()
        Me.LblApplicationDomainAbbreviationOuter = New System.Windows.Forms.Label()
        Me.UcCollectionofUCActiveForm = New R2CoreGUI.UCCollectionofUCActiveForm()
        Me.UcucProcessGroupCollection = New R2CoreGUI.UCUCProcessGroupCollection()
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlphaPnlBig0 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlphaPnlBig1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlMain.SuspendLayout()
        Me.PnlR2.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlUserLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMain.Controls.Add(Me.PnlToolBoxSmall)
        Me.PnlMain.Controls.Add(Me.PnlToolBoxBig)
        Me.PnlMain.Controls.Add(Me.PnlR2)
        Me.PnlMain.Controls.Add(Me.PnlBottom)
        Me.PnlMain.Controls.Add(Me.PnlTop)
        Me.PnlMain.Controls.Add(Me.UcUserLogin)
        Me.PnlMain.Controls.Add(Me.PnlUserLogin)
        Me.PnlMain.Controls.Add(Me.UcUserImage)
        Me.PnlMain.Controls.Add(Me.LblApplicationDomainAbbreviationOuter)
        Me.PnlMain.Controls.Add(Me.UcCollectionofUCActiveForm)
        Me.PnlMain.Controls.Add(Me.UcucProcessGroupCollection)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(999, 594)
        Me.PnlMain.TabIndex = 2
        '
        'PnlToolBoxSmall
        '
        Me.PnlToolBoxSmall.BackColor = System.Drawing.Color.Transparent
        Me.PnlToolBoxSmall.Border = True
        Me.PnlToolBoxSmall.BorderColor = System.Drawing.Color.Black
        Me.PnlToolBoxSmall.Colors.Add(Me.ColorWithAlphaPnlSmall0)
        Me.PnlToolBoxSmall.Colors.Add(Me.ColorWithAlphaPnlSmall1)
        Me.PnlToolBoxSmall.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlToolBoxSmall.CornerRadius = 30
        Me.PnlToolBoxSmall.Corners = BlueActivity.Controls.Corner.BottomRight
        Me.PnlToolBoxSmall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlToolBoxSmall.Gradient = False
        Me.PnlToolBoxSmall.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlToolBoxSmall.GradientOffset = 1.0!
        Me.PnlToolBoxSmall.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlToolBoxSmall.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlToolBoxSmall.Grayscale = True
        Me.PnlToolBoxSmall.Image = Nothing
        Me.PnlToolBoxSmall.ImageAlpha = 20
        Me.PnlToolBoxSmall.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlToolBoxSmall.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight), BlueActivity.Controls.ImagePosition)
        Me.PnlToolBoxSmall.ImageSize = New System.Drawing.Size(50, 50)
        Me.PnlToolBoxSmall.Location = New System.Drawing.Point(3, 64)
        Me.PnlToolBoxSmall.Name = "PnlToolBoxSmall"
        Me.PnlToolBoxSmall.Rounded = True
        Me.PnlToolBoxSmall.Size = New System.Drawing.Size(231, 42)
        Me.PnlToolBoxSmall.TabIndex = 230
        Me.PnlToolBoxSmall.Visible = False
        '
        'ColorWithAlphaPnlSmall0
        '
        Me.ColorWithAlphaPnlSmall0.Alpha = 255
        Me.ColorWithAlphaPnlSmall0.Color = System.Drawing.Color.IndianRed
        Me.ColorWithAlphaPnlSmall0.Parent = Me.PnlToolBoxSmall
        '
        'ColorWithAlphaPnlSmall1
        '
        Me.ColorWithAlphaPnlSmall1.Alpha = 255
        Me.ColorWithAlphaPnlSmall1.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlphaPnlSmall1.Parent = Me.PnlToolBoxSmall
        '
        'PnlToolBoxBig
        '
        Me.PnlToolBoxBig.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlToolBoxBig.BackColor = System.Drawing.Color.Transparent
        Me.PnlToolBoxBig.Border = True
        Me.PnlToolBoxBig.BorderColor = System.Drawing.Color.Black
        Me.PnlToolBoxBig.Colors.Add(Me.ColorWithAlphaPnlBig00)
        Me.PnlToolBoxBig.Colors.Add(Me.ColorWithAlphaPnlBig11)
        Me.PnlToolBoxBig.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlToolBoxBig.CornerRadius = 30
        Me.PnlToolBoxBig.Corners = BlueActivity.Controls.Corner.TopLeft
        Me.PnlToolBoxBig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlToolBoxBig.Gradient = False
        Me.PnlToolBoxBig.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlToolBoxBig.GradientOffset = 1.0!
        Me.PnlToolBoxBig.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlToolBoxBig.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlToolBoxBig.Grayscale = False
        Me.PnlToolBoxBig.Image = Nothing
        Me.PnlToolBoxBig.ImageAlpha = 75
        Me.PnlToolBoxBig.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlToolBoxBig.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlToolBoxBig.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlToolBoxBig.Location = New System.Drawing.Point(237, 64)
        Me.PnlToolBoxBig.Name = "PnlToolBoxBig"
        Me.PnlToolBoxBig.Rounded = True
        Me.PnlToolBoxBig.Size = New System.Drawing.Size(759, 42)
        Me.PnlToolBoxBig.TabIndex = 229
        Me.PnlToolBoxBig.Visible = False
        '
        'ColorWithAlphaPnlBig00
        '
        Me.ColorWithAlphaPnlBig00.Alpha = 255
        Me.ColorWithAlphaPnlBig00.Color = System.Drawing.Color.Firebrick
        Me.ColorWithAlphaPnlBig00.Parent = Me.PnlToolBoxBig
        '
        'ColorWithAlphaPnlBig11
        '
        Me.ColorWithAlphaPnlBig11.Alpha = 255
        Me.ColorWithAlphaPnlBig11.Color = System.Drawing.Color.Firebrick
        Me.ColorWithAlphaPnlBig11.Parent = Me.PnlToolBoxBig
        '
        'PnlR2
        '
        Me.PnlR2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlR2.BackColor = System.Drawing.Color.Transparent
        Me.PnlR2.Border = True
        Me.PnlR2.BorderColor = System.Drawing.Color.Transparent
        Me.PnlR2.Colors.Add(Me.ColorWithAlphaPnlR20)
        Me.PnlR2.Colors.Add(Me.ColorWithAlphaPnlR21)
        Me.PnlR2.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlR2.Controls.Add(Me.LblBottomSystemTitle)
        Me.PnlR2.Controls.Add(Me.LblBottomSystemPersianTitle)
        Me.PnlR2.Controls.Add(Me.LblApplicationDomainAbbreviationInner)
        Me.PnlR2.Controls.Add(Me.LblBottom1ApplicationDomainTitle)
        Me.PnlR2.Controls.Add(Me.LblBottom0ApplicationDomainTitle)
        Me.PnlR2.CornerRadius = 20
        Me.PnlR2.Corners = BlueActivity.Controls.Corner.None
        Me.PnlR2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlR2.Gradient = True
        Me.PnlR2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlR2.GradientOffset = 1.0!
        Me.PnlR2.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlR2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlR2.Grayscale = False
        Me.PnlR2.Image = Nothing
        Me.PnlR2.ImageAlpha = 75
        Me.PnlR2.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlR2.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlR2.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlR2.Location = New System.Drawing.Point(3, 442)
        Me.PnlR2.Name = "PnlR2"
        Me.PnlR2.Rounded = True
        Me.PnlR2.Size = New System.Drawing.Size(993, 121)
        Me.PnlR2.TabIndex = 228
        '
        'ColorWithAlphaPnlR20
        '
        Me.ColorWithAlphaPnlR20.Alpha = 255
        Me.ColorWithAlphaPnlR20.Color = System.Drawing.Color.IndianRed
        Me.ColorWithAlphaPnlR20.Parent = Me.PnlR2
        '
        'ColorWithAlphaPnlR21
        '
        Me.ColorWithAlphaPnlR21.Alpha = 255
        Me.ColorWithAlphaPnlR21.Color = System.Drawing.Color.IndianRed
        Me.ColorWithAlphaPnlR21.Parent = Me.PnlR2
        '
        'LblBottomSystemTitle
        '
        Me.LblBottomSystemTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblBottomSystemTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblBottomSystemTitle.Feather = 75
        Me.LblBottomSystemTitle.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomSystemTitle.ForeColor = System.Drawing.Color.White
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer)), System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0!, 0.3302469!, 1.0!}
        Me.LblBottomSystemTitle.ForeColorBlend = CBlendItems1
        Me.LblBottomSystemTitle.Glow = 15
        Me.LblBottomSystemTitle.GlowColor = System.Drawing.Color.Gainsboro
        Me.LblBottomSystemTitle.GlowState = False
        Me.LblBottomSystemTitle.Location = New System.Drawing.Point(16, 79)
        Me.LblBottomSystemTitle.MouseOverColor = System.Drawing.Color.Gray
        Me.LblBottomSystemTitle.Name = "LblBottomSystemTitle"
        Me.LblBottomSystemTitle.Size = New System.Drawing.Size(386, 25)
        Me.LblBottomSystemTitle.TabIndex = 228
        Me.LblBottomSystemTitle.Text = "Clockwork Angels"
        Me.LblBottomSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBottomSystemPersianTitle
        '
        Me.LblBottomSystemPersianTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblBottomSystemPersianTitle.Font = New System.Drawing.Font("IranNastaliq", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomSystemPersianTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblBottomSystemPersianTitle.Location = New System.Drawing.Point(19, 35)
        Me.LblBottomSystemPersianTitle.Name = "LblBottomSystemPersianTitle"
        Me.LblBottomSystemPersianTitle.Size = New System.Drawing.Size(322, 53)
        Me.LblBottomSystemPersianTitle.TabIndex = 220
        Me.LblBottomSystemPersianTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApplicationDomainAbbreviationInner
        '
        Me.LblApplicationDomainAbbreviationInner.AutoSize = True
        Me.LblApplicationDomainAbbreviationInner.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainAbbreviationInner.Font = New System.Drawing.Font("Tempus Sans ITC", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApplicationDomainAbbreviationInner.ForeColor = System.Drawing.Color.White
        Me.LblApplicationDomainAbbreviationInner.Location = New System.Drawing.Point(-2, -74)
        Me.LblApplicationDomainAbbreviationInner.Name = "LblApplicationDomainAbbreviationInner"
        Me.LblApplicationDomainAbbreviationInner.Size = New System.Drawing.Size(169, 126)
        Me.LblApplicationDomainAbbreviationInner.TabIndex = 221
        Me.LblApplicationDomainAbbreviationInner.Text = "R2"
        Me.LblApplicationDomainAbbreviationInner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBottom1ApplicationDomainTitle
        '
        Me.LblBottom1ApplicationDomainTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBottom1ApplicationDomainTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblBottom1ApplicationDomainTitle.Font = New System.Drawing.Font("IranNastaliq", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottom1ApplicationDomainTitle.ForeColor = System.Drawing.Color.White
        Me.LblBottom1ApplicationDomainTitle.Location = New System.Drawing.Point(510, 35)
        Me.LblBottom1ApplicationDomainTitle.Name = "LblBottom1ApplicationDomainTitle"
        Me.LblBottom1ApplicationDomainTitle.Size = New System.Drawing.Size(451, 69)
        Me.LblBottom1ApplicationDomainTitle.TabIndex = 215
        Me.LblBottom1ApplicationDomainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBottom1ApplicationDomainTitle.Visible = False
        '
        'LblBottom0ApplicationDomainTitle
        '
        Me.LblBottom0ApplicationDomainTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBottom0ApplicationDomainTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblBottom0ApplicationDomainTitle.Font = New System.Drawing.Font("IranNastaliq", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBottom0ApplicationDomainTitle.ForeColor = System.Drawing.Color.White
        Me.LblBottom0ApplicationDomainTitle.Location = New System.Drawing.Point(807, 7)
        Me.LblBottom0ApplicationDomainTitle.Name = "LblBottom0ApplicationDomainTitle"
        Me.LblBottom0ApplicationDomainTitle.Size = New System.Drawing.Size(193, 68)
        Me.LblBottom0ApplicationDomainTitle.TabIndex = 222
        Me.LblBottom0ApplicationDomainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblBottom0ApplicationDomainTitle.Visible = False
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.Border = True
        Me.PnlBottom.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlBottom.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlBottom.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlBottom.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlBottom.CornerRadius = 20
        Me.PnlBottom.Corners = BlueActivity.Controls.Corner.None
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Gradient = True
        Me.PnlBottom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlBottom.GradientOffset = 1.0!
        Me.PnlBottom.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlBottom.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlBottom.Grayscale = False
        Me.PnlBottom.Image = Nothing
        Me.PnlBottom.ImageAlpha = 75
        Me.PnlBottom.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlBottom.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlBottom.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlBottom.Location = New System.Drawing.Point(0, 566)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Rounded = True
        Me.PnlBottom.Size = New System.Drawing.Size(999, 28)
        Me.PnlBottom.TabIndex = 227
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.DimGray
        Me.ColorWithAlpha3.Parent = Me.PnlBottom
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Black
        Me.ColorWithAlpha4.Parent = Me.PnlBottom
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Black
        Me.PnlTop.Border = True
        Me.PnlTop.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlTop.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlTop.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlTop.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlTop.Controls.Add(Me.LblTopApplicationDomainEnglishTiltle)
        Me.PnlTop.Controls.Add(Me.UcDateTime)
        Me.PnlTop.Controls.Add(Me.LblTopApplicationDomainPersianTitle)
        Me.PnlTop.Controls.Add(Me.picexit)
        Me.PnlTop.Controls.Add(Me.UcShutDown)
        Me.PnlTop.Controls.Add(Me.PicMinimize)
        Me.PnlTop.CornerRadius = 20
        Me.PnlTop.Corners = BlueActivity.Controls.Corner.None
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Gradient = True
        Me.PnlTop.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlTop.GradientOffset = 1.0!
        Me.PnlTop.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlTop.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlTop.Grayscale = False
        Me.PnlTop.Image = Nothing
        Me.PnlTop.ImageAlpha = 75
        Me.PnlTop.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlTop.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlTop.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Rounded = True
        Me.PnlTop.Size = New System.Drawing.Size(999, 35)
        Me.PnlTop.TabIndex = 226
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.DimGray
        Me.ColorWithAlpha1.Parent = Me.PnlTop
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Black
        Me.ColorWithAlpha2.Parent = Me.PnlTop
        '
        'LblTopApplicationDomainEnglishTiltle
        '
        Me.LblTopApplicationDomainEnglishTiltle.BackColor = System.Drawing.Color.Transparent
        Me.LblTopApplicationDomainEnglishTiltle.Feather = 75
        Me.LblTopApplicationDomainEnglishTiltle.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopApplicationDomainEnglishTiltle.ForeColor = System.Drawing.Color.White
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer)), System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0!, 0.3302469!, 1.0!}
        Me.LblTopApplicationDomainEnglishTiltle.ForeColorBlend = CBlendItems2
        Me.LblTopApplicationDomainEnglishTiltle.Glow = 15
        Me.LblTopApplicationDomainEnglishTiltle.GlowColor = System.Drawing.Color.Gainsboro
        Me.LblTopApplicationDomainEnglishTiltle.Location = New System.Drawing.Point(6, 5)
        Me.LblTopApplicationDomainEnglishTiltle.MouseOverColor = System.Drawing.Color.Gray
        Me.LblTopApplicationDomainEnglishTiltle.Name = "LblTopApplicationDomainEnglishTiltle"
        Me.LblTopApplicationDomainEnglishTiltle.Size = New System.Drawing.Size(316, 25)
        Me.LblTopApplicationDomainEnglishTiltle.TabIndex = 227
        Me.LblTopApplicationDomainEnglishTiltle.Text = "Clockwork Angels"
        Me.LblTopApplicationDomainEnglishTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UcDateTime
        '
        Me.UcDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDateTime.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.Location = New System.Drawing.Point(764, 5)
        Me.UcDateTime.Name = "UcDateTime"
        Me.UcDateTime.Size = New System.Drawing.Size(140, 24)
        Me.UcDateTime.TabIndex = 226
        Me.UcDateTime.UCBackColor = System.Drawing.Color.Transparent
        Me.UcDateTime.UCClockIconAppierance = False
        Me.UcDateTime.UCEnable = True
        Me.UcDateTime.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcDateTime.UCForeColor = System.Drawing.Color.White
        '
        'LblTopApplicationDomainPersianTitle
        '
        Me.LblTopApplicationDomainPersianTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTopApplicationDomainPersianTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTopApplicationDomainPersianTitle.Font = New System.Drawing.Font("IranNastaliq", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTopApplicationDomainPersianTitle.ForeColor = System.Drawing.Color.White
        Me.LblTopApplicationDomainPersianTitle.Location = New System.Drawing.Point(328, -2)
        Me.LblTopApplicationDomainPersianTitle.Name = "LblTopApplicationDomainPersianTitle"
        Me.LblTopApplicationDomainPersianTitle.Size = New System.Drawing.Size(343, 37)
        Me.LblTopApplicationDomainPersianTitle.TabIndex = 217
        Me.LblTopApplicationDomainPersianTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picexit
        '
        Me.picexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picexit.BackColor = System.Drawing.Color.Transparent
        Me.picexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picexit.Image = CType(resources.GetObject("picexit.Image"), System.Drawing.Image)
        Me.picexit.Location = New System.Drawing.Point(969, 7)
        Me.picexit.Name = "picexit"
        Me.picexit.Size = New System.Drawing.Size(20, 20)
        Me.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picexit.TabIndex = 206
        Me.picexit.TabStop = False
        '
        'UcShutDown
        '
        Me.UcShutDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcShutDown.BackColor = System.Drawing.Color.Transparent
        Me.UcShutDown.Location = New System.Drawing.Point(909, 3)
        Me.UcShutDown.Name = "UcShutDown"
        Me.UcShutDown.Padding = New System.Windows.Forms.Padding(3)
        Me.UcShutDown.Size = New System.Drawing.Size(32, 28)
        Me.UcShutDown.TabIndex = 208
        '
        'PicMinimize
        '
        Me.PicMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PicMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMinimize.Image = CType(resources.GetObject("PicMinimize.Image"), System.Drawing.Image)
        Me.PicMinimize.Location = New System.Drawing.Point(945, 7)
        Me.PicMinimize.Name = "PicMinimize"
        Me.PicMinimize.Size = New System.Drawing.Size(20, 20)
        Me.PicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMinimize.TabIndex = 207
        Me.PicMinimize.TabStop = False
        '
        'UcUserLogin
        '
        Me.UcUserLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.UcUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.UcUserLogin.Location = New System.Drawing.Point(342, 284)
        Me.UcUserLogin.Name = "UcUserLogin"
        Me.UcUserLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.UcUserLogin.Size = New System.Drawing.Size(315, 144)
        Me.UcUserLogin.TabIndex = 0
        '
        'PnlUserLogin
        '
        Me.PnlUserLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUserLogin.Controls.Add(Me.PnlMiddle1)
        Me.PnlUserLogin.Controls.Add(Me.PnlMiddle2)
        Me.PnlUserLogin.Controls.Add(Me.PnlMiddle3)
        Me.PnlUserLogin.Controls.Add(Me.PnlMiddle)
        Me.PnlUserLogin.Controls.Add(Me.PnlMiddle4)
        Me.PnlUserLogin.Location = New System.Drawing.Point(176, 69)
        Me.PnlUserLogin.Name = "PnlUserLogin"
        Me.PnlUserLogin.Size = New System.Drawing.Size(823, 251)
        Me.PnlUserLogin.TabIndex = 225
        '
        'PnlMiddle1
        '
        Me.PnlMiddle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiddle1.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMiddle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMiddle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMiddle1.Location = New System.Drawing.Point(634, 87)
        Me.PnlMiddle1.Name = "PnlMiddle1"
        Me.PnlMiddle1.Size = New System.Drawing.Size(121, 89)
        Me.PnlMiddle1.TabIndex = 230
        '
        'PnlMiddle2
        '
        Me.PnlMiddle2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiddle2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMiddle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMiddle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMiddle2.Location = New System.Drawing.Point(758, 87)
        Me.PnlMiddle2.Name = "PnlMiddle2"
        Me.PnlMiddle2.Size = New System.Drawing.Size(29, 89)
        Me.PnlMiddle2.TabIndex = 229
        '
        'PnlMiddle3
        '
        Me.PnlMiddle3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiddle3.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMiddle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMiddle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMiddle3.Location = New System.Drawing.Point(789, 87)
        Me.PnlMiddle3.Name = "PnlMiddle3"
        Me.PnlMiddle3.Size = New System.Drawing.Size(22, 89)
        Me.PnlMiddle3.TabIndex = 228
        '
        'PnlMiddle
        '
        Me.PnlMiddle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiddle.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMiddle.Location = New System.Drawing.Point(287, 87)
        Me.PnlMiddle.Name = "PnlMiddle"
        Me.PnlMiddle.Size = New System.Drawing.Size(344, 89)
        Me.PnlMiddle.TabIndex = 223
        '
        'PnlMiddle4
        '
        Me.PnlMiddle4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMiddle4.BackColor = System.Drawing.Color.RoyalBlue
        Me.PnlMiddle4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMiddle4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMiddle4.Location = New System.Drawing.Point(813, 87)
        Me.PnlMiddle4.Name = "PnlMiddle4"
        Me.PnlMiddle4.Size = New System.Drawing.Size(12, 89)
        Me.PnlMiddle4.TabIndex = 227
        '
        'UcUserImage
        '
        Me.UcUserImage.BackColor = System.Drawing.Color.Transparent
        Me.UcUserImage.Location = New System.Drawing.Point(2, 35)
        Me.UcUserImage.Name = "UcUserImage"
        Me.UcUserImage.Padding = New System.Windows.Forms.Padding(2)
        Me.UcUserImage.Size = New System.Drawing.Size(30, 30)
        Me.UcUserImage.TabIndex = 216
        Me.UcUserImage.Visible = False
        '
        'LblApplicationDomainAbbreviationOuter
        '
        Me.LblApplicationDomainAbbreviationOuter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblApplicationDomainAbbreviationOuter.AutoSize = True
        Me.LblApplicationDomainAbbreviationOuter.BackColor = System.Drawing.Color.Transparent
        Me.LblApplicationDomainAbbreviationOuter.Font = New System.Drawing.Font("Tempus Sans ITC", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApplicationDomainAbbreviationOuter.ForeColor = System.Drawing.Color.DimGray
        Me.LblApplicationDomainAbbreviationOuter.Location = New System.Drawing.Point(1, 370)
        Me.LblApplicationDomainAbbreviationOuter.Name = "LblApplicationDomainAbbreviationOuter"
        Me.LblApplicationDomainAbbreviationOuter.Size = New System.Drawing.Size(169, 126)
        Me.LblApplicationDomainAbbreviationOuter.TabIndex = 222
        Me.LblApplicationDomainAbbreviationOuter.Text = "R2"
        Me.LblApplicationDomainAbbreviationOuter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCollectionofUCActiveForm
        '
        Me.UcCollectionofUCActiveForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcCollectionofUCActiveForm.BackColor = System.Drawing.Color.Transparent
        Me.UcCollectionofUCActiveForm.Location = New System.Drawing.Point(32, 34)
        Me.UcCollectionofUCActiveForm.Name = "UcCollectionofUCActiveForm"
        Me.UcCollectionofUCActiveForm.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCollectionofUCActiveForm.Size = New System.Drawing.Size(966, 28)
        Me.UcCollectionofUCActiveForm.TabIndex = 212
        Me.UcCollectionofUCActiveForm.Visible = False
        '
        'UcucProcessGroupCollection
        '
        Me.UcucProcessGroupCollection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucProcessGroupCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucProcessGroupCollection.Location = New System.Drawing.Point(3, 130)
        Me.UcucProcessGroupCollection.Name = "UcucProcessGroupCollection"
        Me.UcucProcessGroupCollection.Padding = New System.Windows.Forms.Padding(10)
        Me.UcucProcessGroupCollection.Size = New System.Drawing.Size(995, 306)
        Me.UcucProcessGroupCollection.TabIndex = 1
        Me.UcucProcessGroupCollection.Visible = False
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.SystemColors.ButtonFace
        Me.ColorWithAlpha6.Parent = Nothing
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.SystemColors.ActiveCaptionText
        Me.ColorWithAlpha8.Parent = Nothing
        '
        'ColorWithAlphaPnlBig0
        '
        Me.ColorWithAlphaPnlBig0.Alpha = 255
        Me.ColorWithAlphaPnlBig0.Color = System.Drawing.Color.Tomato
        Me.ColorWithAlphaPnlBig0.Parent = Nothing
        '
        'ColorWithAlphaPnlBig1
        '
        Me.ColorWithAlphaPnlBig1.Alpha = 255
        Me.ColorWithAlphaPnlBig1.Color = System.Drawing.Color.Tomato
        Me.ColorWithAlphaPnlBig1.Parent = Nothing
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha5.Parent = Nothing
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha7.Parent = Nothing
        '
        'FrmcMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(5, 121)
        Me.Name = "FrmcMainMenu"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmcMainMenu"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        Me.PnlR2.ResumeLayout(False)
        Me.PnlR2.PerformLayout()
        Me.PnlTop.ResumeLayout(False)
        CType(Me.picexit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlUserLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcUserLogin As UCUserLogin
    Friend WithEvents PnlMain As Panel
    Friend WithEvents UcucProcessGroupCollection As UCUCProcessGroupCollection
    Friend WithEvents PicMinimize As PictureBox
    Friend WithEvents picexit As PictureBox
    Friend WithEvents UcShutDown As UCShutDown
    Friend WithEvents UcCollectionofUCActiveForm As UCCollectionofUCActiveForm
    Friend WithEvents LblBottom1ApplicationDomainTitle As Label
    Public WithEvents UcUserImage As UCUserImage
    Friend WithEvents LblTopApplicationDomainPersianTitle As Label
    Friend WithEvents LblApplicationDomainAbbreviationInner As Label
    Friend WithEvents LblBottomSystemPersianTitle As Label
    Friend WithEvents LblApplicationDomainAbbreviationOuter As Label
    Friend WithEvents PnlMiddle As Panel
    Friend WithEvents LblBottom0ApplicationDomainTitle As Label
    Friend WithEvents PnlUserLogin As Panel
    Friend WithEvents UcDateTime As UCDateTime
    Friend WithEvents PnlMiddle4 As Panel
    Friend WithEvents PnlMiddle2 As Panel
    Friend WithEvents PnlMiddle3 As Panel
    Friend WithEvents PnlMiddle1 As Panel
    Friend WithEvents PnlBottom As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlTop As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlR2 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents PnlToolBoxBig As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents LblTopApplicationDomainEnglishTiltle As gLabel.gLabel
    Friend WithEvents PnlToolBoxSmall As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents LblBottomSystemTitle As gLabel.gLabel
    Friend WithEvents ColorWithAlphaPnlSmall0 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlSmall1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlBig0 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlBig1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlBig00 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlBig11 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlR20 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlphaPnlR21 As BlueActivity.Controls.ColorWithAlpha
End Class
