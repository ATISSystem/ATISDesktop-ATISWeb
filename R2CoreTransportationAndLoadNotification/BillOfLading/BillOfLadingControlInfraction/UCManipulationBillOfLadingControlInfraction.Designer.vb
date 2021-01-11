<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCManipulationBillOfLadingControlInfraction
    Inherits UCBillOfLadingControlInfraction

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
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty1 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CornersProperty2 As CButtonLib.CornersProperty = New CButtonLib.CornersProperty()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcButtonCButtonDeleteBLCI = New R2CoreGUI.UCButtonCButton()
        Me.UcButtonCButtonViewBLCI = New R2CoreGUI.UCButtonCButton()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcViewerNSSBillOfLadingControlInfractionExtended = New R2CoreTransportationAndLoadNotification.UCViewerNSSBillOfLadingControlInfractionExtended()
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
        Me.PnlMain.Size = New System.Drawing.Size(750, 237)
        Me.PnlMain.TabIndex = 1
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlOutter.Size = New System.Drawing.Size(750, 237)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcButtonCButtonDeleteBLCI)
        Me.PnlInner.Controls.Add(Me.UcButtonCButtonViewBLCI)
        Me.PnlInner.Controls.Add(Me.UcLabelTop)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(746, 233)
        Me.PnlInner.TabIndex = 0
        '
        'UcButtonCButtonDeleteBLCI
        '
        Me.UcButtonCButtonDeleteBLCI.Location = New System.Drawing.Point(158, 59)
        Me.UcButtonCButtonDeleteBLCI.Name = "UcButtonCButtonDeleteBLCI"
        Me.UcButtonCButtonDeleteBLCI.Size = New System.Drawing.Size(68, 37)
        Me.UcButtonCButtonDeleteBLCI.TabIndex = 355
        Me.UcButtonCButtonDeleteBLCI.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Magenta}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.UcButtonCButtonDeleteBLCI.UCColorFillBlend = CBlendItems1
        Me.UcButtonCButtonDeleteBLCI.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty1.LowerLeft = 16
        CornersProperty1.UpperRight = 16
        Me.UcButtonCButtonDeleteBLCI.UCCorners = CornersProperty1
        Me.UcButtonCButtonDeleteBLCI.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonDeleteBLCI.UCEnable = true
        Me.UcButtonCButtonDeleteBLCI.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonCButtonDeleteBLCI.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonDeleteBLCI.UCText = "حذف"
        '
        'UcButtonCButtonViewBLCI
        '
        Me.UcButtonCButtonViewBLCI.Location = New System.Drawing.Point(30, 59)
        Me.UcButtonCButtonViewBLCI.Name = "UcButtonCButtonViewBLCI"
        Me.UcButtonCButtonViewBLCI.Size = New System.Drawing.Size(122, 37)
        Me.UcButtonCButtonViewBLCI.TabIndex = 354
        Me.UcButtonCButtonViewBLCI.UCBorderColor = System.Drawing.Color.Blue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.HotPink}
        CBlendItems2.iPoint = New Single() {0!, 1!}
        Me.UcButtonCButtonViewBLCI.UCColorFillBlend = CBlendItems2
        Me.UcButtonCButtonViewBLCI.UCColorFillSolid = System.Drawing.Color.Transparent
        CornersProperty2.LowerLeft = 16
        CornersProperty2.UpperRight = 16
        Me.UcButtonCButtonViewBLCI.UCCorners = CornersProperty2
        Me.UcButtonCButtonViewBLCI.UCCursor = System.Windows.Forms.Cursors.Hand
        Me.UcButtonCButtonViewBLCI.UCEnable = true
        Me.UcButtonCButtonViewBLCI.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonCButtonViewBLCI.UCForeColor = System.Drawing.Color.White
        Me.UcButtonCButtonViewBLCI.UCText = "مشاهده جزییات"
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
        Me.UcLabelTop.Size = New System.Drawing.Size(746, 52)
        Me.UcLabelTop.TabIndex = 353
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "تخلفات کنترل بارنامه"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(538, 62)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(166, 32)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "تخلفات کنترل بارنامه"
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = true
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Silver
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcViewerNSSBillOfLadingControlInfractionExtended)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = BlueActivity.Controls.Corner.TopRight
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
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(8, 79)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = true
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(732, 147)
        Me.AlphaGradientPanel1.TabIndex = 4
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
        'UcViewerNSSBillOfLadingControlInfractionExtended
        '
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.Location = New System.Drawing.Point(3, 21)
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.Name = "UcViewerNSSBillOfLadingControlInfractionExtended"
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.Size = New System.Drawing.Size(724, 120)
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.TabIndex = 0
        Me.UcViewerNSSBillOfLadingControlInfractionExtended.UCNSSCurrent = Nothing
        '
        'UCManipulationBillOfLadingControlInfraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCManipulationBillOfLadingControlInfraction"
        Me.Size = New System.Drawing.Size(750, 237)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.AlphaGradientPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcViewerNSSBillOfLadingControlInfractionExtended As UCViewerNSSBillOfLadingControlInfractionExtended
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonCButtonDeleteBLCI As R2CoreGUI.UCButtonCButton
    Friend WithEvents UcButtonCButtonViewBLCI As R2CoreGUI.UCButtonCButton
End Class
