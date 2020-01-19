<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcMessageDialog
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcMessageDialog))
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PictureBoxGif = New System.Windows.Forms.PictureBox()
        Me.LblHint = New gLabel.gLabel()
        Me.LblMessage = New gLabel.gLabel()
        Me.PnlImage = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMessage = New System.Windows.Forms.PictureBox()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha7 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha8 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout
        CType(Me.PictureBoxGif,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlImage.SuspendLayout
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBoxMessage,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlOutter.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = false
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PictureBoxGif)
        Me.PnlMain.Controls.Add(Me.LblHint)
        Me.PnlMain.Controls.Add(Me.LblMessage)
        Me.PnlMain.Controls.Add(Me.PnlImage)
        Me.PnlMain.CornerRadius = 15
        Me.PnlMain.Corners = BlueActivity.Controls.Corner.None
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = true
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PnlMain.GradientOffset = 1!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = false
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 60
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = CType((BlueActivity.Controls.ImagePosition.TopLeft Or BlueActivity.Controls.ImagePosition.TopRight),BlueActivity.Controls.ImagePosition)
        Me.PnlMain.ImageSize = New System.Drawing.Size(100, 100)
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlMain.Rounded = true
        Me.PnlMain.Size = New System.Drawing.Size(666, 356)
        Me.PnlMain.TabIndex = 2
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.PnlMain
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Red
        Me.ColorWithAlpha2.Parent = Me.PnlMain
        '
        'PictureBoxGif
        '
        Me.PictureBoxGif.Image = CType(resources.GetObject("PictureBoxGif.Image"),System.Drawing.Image)
        Me.PictureBoxGif.ImageLocation = ""
        Me.PictureBoxGif.Location = New System.Drawing.Point(6, 7)
        Me.PictureBoxGif.Name = "PictureBoxGif"
        Me.PictureBoxGif.Size = New System.Drawing.Size(24, 22)
        Me.PictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxGif.TabIndex = 5
        Me.PictureBoxGif.TabStop = false
        '
        'LblHint
        '
        Me.LblHint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblHint.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblHint.Location = New System.Drawing.Point(-4, 293)
        Me.LblHint.Name = "LblHint"
        Me.LblHint.Size = New System.Drawing.Size(466, 57)
        Me.LblHint.TabIndex = 46
        Me.LblHint.Text = " "
        '
        'LblMessage
        '
        Me.LblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblMessage.CheckedColor = System.Drawing.Color.Purple
        Me.LblMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblMessage.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.Black
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1!}
        Me.LblMessage.ForeColorBlend = CBlendItems1
        Me.LblMessage.Glow = 10
        Me.LblMessage.GlowColor = System.Drawing.Color.Crimson
        Me.LblMessage.Location = New System.Drawing.Point(2, -1)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(460, 294)
        Me.LblMessage.TabIndex = 45
        Me.LblMessage.Text = "PayanehClassLibrary.FrmcCarAndDriversInformation.UcButtonSabt_UCClickedEvent"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"مشخ"& _ 
    "صات و اطلاعات کارت تردد ، پلاک و راننده به طور کامل مشخص نیست"
        '
        'PnlImage
        '
        Me.PnlImage.BackColor = System.Drawing.Color.Transparent
        Me.PnlImage.Border = true
        Me.PnlImage.BorderColor = System.Drawing.Color.Black
        Me.PnlImage.Colors.Add(Me.ColorWithAlpha5)
        Me.PnlImage.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlImage.Controls.Add(Me.PicExit)
        Me.PnlImage.Controls.Add(Me.PictureBoxMessage)
        Me.PnlImage.CornerRadius = 20
        Me.PnlImage.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlImage.Gradient = false
        Me.PnlImage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlImage.GradientOffset = 1!
        Me.PnlImage.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlImage.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlImage.Grayscale = false
        Me.PnlImage.Image = Nothing
        Me.PnlImage.ImageAlpha = 75
        Me.PnlImage.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlImage.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlImage.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlImage.Location = New System.Drawing.Point(468, 13)
        Me.PnlImage.Name = "PnlImage"
        Me.PnlImage.Rounded = true
        Me.PnlImage.Size = New System.Drawing.Size(183, 328)
        Me.PnlImage.TabIndex = 47
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 0
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha5.Parent = Me.PnlImage
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicExit.BackColor = System.Drawing.Color.Transparent
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"),System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(148, 13)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(25, 26)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 44
        Me.PicExit.TabStop = false
        '
        'PictureBoxMessage
        '
        Me.PictureBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxMessage.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxMessage.Name = "PictureBoxMessage"
        Me.PictureBoxMessage.Size = New System.Drawing.Size(183, 328)
        Me.PictureBoxMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMessage.TabIndex = 5
        Me.PictureBoxMessage.TabStop = false
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha7.Parent = Nothing
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha8.Parent = Nothing
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Black
        Me.PnlOutter.Controls.Add(Me.PnlMain)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(5, 5)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOutter.Size = New System.Drawing.Size(672, 362)
        Me.PnlOutter.TabIndex = 3
        '
        'FrmcMessageDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 372)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlOutter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmcMessageDialog"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmcMessageDialog"
        Me.TopMost = True
        Me.PnlMain.ResumeLayout(False)
        CType(Me.PictureBoxGif,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlImage.ResumeLayout(false)
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBoxMessage,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlOutter.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha7 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha8 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PictureBoxGif As PictureBox
    Friend WithEvents PictureBoxMessage As PictureBox
    Friend WithEvents PnlOutter As Panel
    Friend WithEvents PicExit As PictureBox
    Friend WithEvents LblMessage As gLabel.gLabel
    Friend WithEvents LblHint As gLabel.gLabel
    Friend WithEvents PnlImage As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
End Class
