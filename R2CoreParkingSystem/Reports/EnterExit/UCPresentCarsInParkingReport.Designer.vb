Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPresentCarsInParkingReport
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
        Me.PnlMain = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GLabel17 = New gLabel.gLabel()
        Me.ChkViewCarImage = New System.Windows.Forms.CheckBox()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.UcLabel2 = New R2CoreGUI.UCLabel()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
        Me.UcCmbTerafficCardType = New R2CoreParkingSystem.UCCmbTerafficCardType()
        Me.UcPersianShamsiDate = New R2CoreGUI.UCPersianShamsiDate()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = false
        Me.PnlMain.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = BlueActivity.Controls.Corner.None
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Gradient = true
        Me.PnlMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlMain.GradientOffset = 1!
        Me.PnlMain.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlMain.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlMain.Grayscale = false
        Me.PnlMain.Image = Nothing
        Me.PnlMain.ImageAlpha = 75
        Me.PnlMain.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlMain.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Rounded = true
        Me.PnlMain.Size = New System.Drawing.Size(275, 313)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GLabel17)
        Me.Panel1.Controls.Add(Me.ChkViewCarImage)
        Me.Panel1.Controls.Add(Me.UcButtonSpecial)
        Me.Panel1.Controls.Add(Me.UcLabel2)
        Me.Panel1.Controls.Add(Me.UcLabel1)
        Me.Panel1.Controls.Add(Me.UcCmbTerafficCardType)
        Me.Panel1.Controls.Add(Me.UcPersianShamsiDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 260)
        Me.Panel1.TabIndex = 15
        '
        'GLabel17
        '
        Me.GLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabel17.Feather = 70
        Me.GLabel17.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GLabel17.ForeColor = System.Drawing.Color.Gold
        Me.GLabel17.Glow = 30
        Me.GLabel17.GlowColor = System.Drawing.Color.DarkGoldenrod
        Me.GLabel17.Location = New System.Drawing.Point(42, 186)
        Me.GLabel17.MouseOverColor = System.Drawing.Color.Gray
        Me.GLabel17.Name = "GLabel17"
        Me.GLabel17.PulseSpeed = 100
        Me.GLabel17.ShadowOffset = New System.Drawing.Point(3, 3)
        Me.GLabel17.Size = New System.Drawing.Size(151, 51)
        Me.GLabel17.TabIndex = 353
        Me.GLabel17.TabStop = true
        Me.GLabel17.Text = "نمایش تصویر خودرو"
        Me.GLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkViewCarImage
        '
        Me.ChkViewCarImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkViewCarImage.AutoSize = true
        Me.ChkViewCarImage.Font = New System.Drawing.Font("B Homa", 11.25!)
        Me.ChkViewCarImage.Location = New System.Drawing.Point(199, 206)
        Me.ChkViewCarImage.Name = "ChkViewCarImage"
        Me.ChkViewCarImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkViewCarImage.Size = New System.Drawing.Size(15, 14)
        Me.ChkViewCarImage.TabIndex = 351
        Me.ChkViewCarImage.UseVisualStyleBackColor = true
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(75, 127)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(125, 41)
        Me.UcButtonSpecial.TabIndex = 350
        Me.UcButtonSpecial.TabStop = false
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "نمایش"
        '
        'UcLabel2
        '
        Me.UcLabel2._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel2._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel2.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.Location = New System.Drawing.Point(98, 50)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel2.Size = New System.Drawing.Size(78, 32)
        Me.UcLabel2.TabIndex = 3
        Me.UcLabel2.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel2.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel2.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel2.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel2.UCValue = "نوع خودرو"
        '
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(145, 17)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLabel1.Size = New System.Drawing.Size(116, 32)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcLabel1.UCValue = "تاریخ پایه ورود :"
        '
        'UcCmbTerafficCardType
        '
        Me.UcCmbTerafficCardType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcCmbTerafficCardType.BackColor = System.Drawing.Color.Transparent
        Me.UcCmbTerafficCardType.Location = New System.Drawing.Point(62, 79)
        Me.UcCmbTerafficCardType.Name = "UcCmbTerafficCardType"
        Me.UcCmbTerafficCardType.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCmbTerafficCardType.Size = New System.Drawing.Size(150, 42)
        Me.UcCmbTerafficCardType.TabIndex = 1
        Me.UcCmbTerafficCardType.TabStop = false
        '
        'UcPersianShamsiDate
        '
        Me.UcPersianShamsiDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcPersianShamsiDate.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.UcPersianShamsiDate.BackColor = System.Drawing.Color.Transparent
        Me.UcPersianShamsiDate.Location = New System.Drawing.Point(12, 21)
        Me.UcPersianShamsiDate.Name = "UcPersianShamsiDate"
        Me.UcPersianShamsiDate.Size = New System.Drawing.Size(127, 23)
        Me.UcPersianShamsiDate.TabIndex = 0
        Me.UcPersianShamsiDate.TabStop = false
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
        Me.UcLabelTop.Size = New System.Drawing.Size(275, 53)
        Me.UcLabelTop.TabIndex = 11
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش خودروهای حاضر در پارکینگ"
        '
        'UCPresentCarsInParkingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCPresentCarsInParkingReport"
        Me.Size = New System.Drawing.Size(275, 313)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents UcPersianShamsiDate As R2CoreGUI.UCPersianShamsiDate
    Friend WithEvents UcLabel2 As R2CoreGUI.UCLabel
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents UcCmbTerafficCardType As UCCmbTerafficCardType
    Friend WithEvents UcButtonSpecial As R2CoreGUI.UCButtonSpecial
    Friend WithEvents ChkViewCarImage As Windows.Forms.CheckBox
    Friend WithEvents GLabel17 As gLabel.gLabel
End Class
