
Imports BlueActivity
Imports BlueActivity.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmcGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmcGeneral))
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.LblformPersianName = New System.Windows.Forms.Label()
        Me.LblformEnglishName = New System.Windows.Forms.Label()
        Me.PicRFIDCardReaderInterface_StartReading = New System.Windows.Forms.PictureBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.PnlHeader = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlBottom = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha()
        Me.LblLocalMessage = New System.Windows.Forms.Label()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicRFIDCardReaderInterface_StartReading,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PnlMain.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.PnlHeader.SuspendLayout
        Me.PnlBottom.SuspendLayout
        Me.SuspendLayout
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicExit.BackColor = System.Drawing.Color.Transparent
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"),System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(969, 5)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(25, 26)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExit.TabIndex = 43
        Me.PicExit.TabStop = false
        '
        'LblformPersianName
        '
        Me.LblformPersianName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblformPersianName.BackColor = System.Drawing.Color.Transparent
        Me.LblformPersianName.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblformPersianName.ForeColor = System.Drawing.Color.White
        Me.LblformPersianName.Location = New System.Drawing.Point(-1, -4)
        Me.LblformPersianName.Name = "LblformPersianName"
        Me.LblformPersianName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblformPersianName.Size = New System.Drawing.Size(939, 31)
        Me.LblformPersianName.TabIndex = 45
        Me.LblformPersianName.Text = "گزارش آماری ورود و خروج پارکینگ به تفکیک نوع کارت تردد   "
        '
        'LblformEnglishName
        '
        Me.LblformEnglishName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblformEnglishName.BackColor = System.Drawing.Color.Transparent
        Me.LblformEnglishName.Font = New System.Drawing.Font("Times New Roman", 6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblformEnglishName.ForeColor = System.Drawing.Color.White
        Me.LblformEnglishName.Location = New System.Drawing.Point(771, 23)
        Me.LblformEnglishName.Name = "LblformEnglishName"
        Me.LblformEnglishName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblformEnglishName.Size = New System.Drawing.Size(161, 14)
        Me.LblformEnglishName.TabIndex = 46
        Me.LblformEnglishName.Text = "FrmcSanadSabt"
        Me.LblformEnglishName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PicRFIDCardReaderInterface_StartReading
        '
        Me.PicRFIDCardReaderInterface_StartReading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PicRFIDCardReaderInterface_StartReading.BackColor = System.Drawing.Color.Transparent
        Me.PicRFIDCardReaderInterface_StartReading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRFIDCardReaderInterface_StartReading.Image = CType(resources.GetObject("PicRFIDCardReaderInterface_StartReading.Image"),System.Drawing.Image)
        Me.PicRFIDCardReaderInterface_StartReading.Location = New System.Drawing.Point(942, 5)
        Me.PicRFIDCardReaderInterface_StartReading.Name = "PicRFIDCardReaderInterface_StartReading"
        Me.PicRFIDCardReaderInterface_StartReading.Size = New System.Drawing.Size(25, 26)
        Me.PicRFIDCardReaderInterface_StartReading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRFIDCardReaderInterface_StartReading.TabIndex = 47
        Me.PicRFIDCardReaderInterface_StartReading.TabStop = false
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.Black
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlMain.Size = New System.Drawing.Size(1005, 600)
        Me.PnlMain.TabIndex = 48
        '
        'PnlInner
        '
        Me.PnlInner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.PnlHeader)
        Me.PnlInner.Controls.Add(Me.PnlBottom)
        Me.PnlInner.Location = New System.Drawing.Point(3, 3)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(999, 594)
        Me.PnlInner.TabIndex = 48
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.Black
        Me.PnlHeader.Border = true
        Me.PnlHeader.BorderColor = System.Drawing.Color.Transparent
        Me.PnlHeader.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlHeader.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlHeader.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlHeader.Controls.Add(Me.LblformPersianName)
        Me.PnlHeader.Controls.Add(Me.PicRFIDCardReaderInterface_StartReading)
        Me.PnlHeader.Controls.Add(Me.PicExit)
        Me.PnlHeader.Controls.Add(Me.LblformEnglishName)
        Me.PnlHeader.CornerRadius = 30
        Me.PnlHeader.Corners = BlueActivity.Controls.Corner.None
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Gradient = true
        Me.PnlHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlHeader.GradientOffset = 0!
        Me.PnlHeader.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlHeader.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlHeader.Grayscale = false
        Me.PnlHeader.Image = Nothing
        Me.PnlHeader.ImageAlpha = 75
        Me.PnlHeader.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlHeader.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlHeader.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Rounded = true
        Me.PnlHeader.Size = New System.Drawing.Size(999, 39)
        Me.PnlHeader.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.SteelBlue
        Me.ColorWithAlpha1.Parent = Me.PnlHeader
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Aqua
        Me.ColorWithAlpha2.Parent = Me.PnlHeader
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottom.Border = true
        Me.PnlBottom.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlBottom.Colors.Add(Me.ColorWithAlpha5)
        Me.PnlBottom.Colors.Add(Me.ColorWithAlpha6)
        Me.PnlBottom.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlBottom.Controls.Add(Me.LblLocalMessage)
        Me.PnlBottom.CornerRadius = 20
        Me.PnlBottom.Corners = BlueActivity.Controls.Corner.None
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Gradient = true
        Me.PnlBottom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlBottom.GradientOffset = 1!
        Me.PnlBottom.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlBottom.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlBottom.Grayscale = false
        Me.PnlBottom.Image = Nothing
        Me.PnlBottom.ImageAlpha = 75
        Me.PnlBottom.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlBottom.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlBottom.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlBottom.Location = New System.Drawing.Point(0, 564)
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Rounded = true
        Me.PnlBottom.Size = New System.Drawing.Size(999, 30)
        Me.PnlBottom.TabIndex = 45
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Black
        Me.ColorWithAlpha5.Parent = Me.PnlBottom
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha6.Parent = Me.PnlBottom
        '
        'LblLocalMessage
        '
        Me.LblLocalMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblLocalMessage.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.LblLocalMessage.ForeColor = System.Drawing.Color.White
        Me.LblLocalMessage.Location = New System.Drawing.Point(0, 0)
        Me.LblLocalMessage.Name = "LblLocalMessage"
        Me.LblLocalMessage.Size = New System.Drawing.Size(999, 30)
        Me.LblLocalMessage.TabIndex = 0
        Me.LblLocalMessage.Text = " "
        Me.LblLocalMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.SteelBlue
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.DodgerBlue
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'FrmcGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.ControlBox = false
        Me.Controls.Add(Me.PnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(10, 121)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmcGeneral"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmcGeneral"
        CType(Me.PicExit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicRFIDCardReaderInterface_StartReading,System.ComponentModel.ISupportInitialize).EndInit
        Me.PnlMain.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.PnlHeader.ResumeLayout(false)
        Me.PnlBottom.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents LblformPersianName As System.Windows.Forms.Label
    Friend WithEvents LblformEnglishName As System.Windows.Forms.Label
    Friend WithEvents PicRFIDCardReaderInterface_StartReading As PictureBox
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents PnlHeader As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As ColorWithAlpha
    Friend WithEvents PnlBottom As AlphaGradientPanel
    Friend WithEvents ColorWithAlpha5 As ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As ColorWithAlpha
    Friend WithEvents LblLocalMessage As Label
End Class
