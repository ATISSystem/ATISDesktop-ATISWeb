<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCUCDomainSelectorCollection
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUCDomainSelectorCollection))
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlUPDown = New System.Windows.Forms.Panel()
        Me.PicUP = New System.Windows.Forms.PictureBox()
        Me.PicDown = New System.Windows.Forms.PictureBox()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlUCDomain = New System.Windows.Forms.Panel()
        Me.PnlMain.SuspendLayout()
        Me.PnlUPDown.SuspendLayout()
        CType(Me.PicUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = True
        Me.PnlMain.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PnlUPDown)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Controls.Add(Me.PnlUCDomain)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = True
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlMain.GradientOffset = 1.0!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = False
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 75
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlMain.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = False
        Me.PnlMain.Size = New System.Drawing.Size(186, 58)
        Me.PnlMain.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlMain
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlMain
        '
        'PnlUPDown
        '
        Me.PnlUPDown.Controls.Add(Me.PicUP)
        Me.PnlUPDown.Controls.Add(Me.PicDown)
        Me.PnlUPDown.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlUPDown.Location = New System.Drawing.Point(0, 25)
        Me.PnlUPDown.Name = "PnlUPDown"
        Me.PnlUPDown.Size = New System.Drawing.Size(17, 33)
        Me.PnlUPDown.TabIndex = 13
        '
        'PicUP
        '
        Me.PicUP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PicUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUP.Image = CType(resources.GetObject("PicUP.Image"), System.Drawing.Image)
        Me.PicUP.Location = New System.Drawing.Point(1, 5)
        Me.PicUP.Name = "PicUP"
        Me.PicUP.Size = New System.Drawing.Size(16, 10)
        Me.PicUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUP.TabIndex = 0
        Me.PicUP.TabStop = False
        '
        'PicDown
        '
        Me.PicDown.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PicDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDown.Image = CType(resources.GetObject("PicDown.Image"), System.Drawing.Image)
        Me.PicDown.Location = New System.Drawing.Point(1, 15)
        Me.PicDown.Name = "PicDown"
        Me.PicDown.Size = New System.Drawing.Size(16, 10)
        Me.PicDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDown.TabIndex = 1
        Me.PicDown.TabStop = False
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
        Me.UcLabelTop.Size = New System.Drawing.Size(186, 25)
        Me.UcLabelTop.TabIndex = 11
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "عنوان"
        '
        'PnlUCDomain
        '
        Me.PnlUCDomain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUCDomain.BackColor = System.Drawing.Color.Transparent
        Me.PnlUCDomain.Location = New System.Drawing.Point(17, 25)
        Me.PnlUCDomain.Name = "PnlUCDomain"
        Me.PnlUCDomain.Size = New System.Drawing.Size(169, 33)
        Me.PnlUCDomain.TabIndex = 12
        '
        'UCUCDomainSelectorCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCUCDomainSelectorCollection"
        Me.Size = New System.Drawing.Size(186, 58)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlUPDown.ResumeLayout(False)
        CType(Me.PicUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents PicUP As PictureBox
    Friend WithEvents PicDown As PictureBox
    Friend WithEvents PnlUCDomain As Panel
    Friend WithEvents PnlUPDown As Panel
End Class
