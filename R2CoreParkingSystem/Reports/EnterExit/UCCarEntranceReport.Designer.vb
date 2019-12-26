Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCarEntranceReport
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
        Me.RadioButtonEntranceDateTimeSupportExit = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEntranceDateTimeSupportEnter = New System.Windows.Forms.RadioButton()
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
        Me.PnlTerraficCardOrCar = New System.Windows.Forms.Panel()
        Me.UcCar = New R2CoreParkingSystem.UCCar()
        Me.UcrfidCardTextMaintainer = New R2CoreGUI.UCRFIDCardTextMaintainer()
        Me.RadioButtonTerraficCard = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCar = New System.Windows.Forms.RadioButton()
        Me.GLabel17 = New gLabel.gLabel()
        Me.ChkViewCarImage = New System.Windows.Forms.CheckBox()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.PnlTerraficCardOrCar.SuspendLayout
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
        Me.PnlMain.Size = New System.Drawing.Size(597, 492)
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
        Me.Panel1.Controls.Add(Me.RadioButtonEntranceDateTimeSupportExit)
        Me.Panel1.Controls.Add(Me.RadioButtonEntranceDateTimeSupportEnter)
        Me.Panel1.Controls.Add(Me.UcDateTimeHolder)
        Me.Panel1.Controls.Add(Me.PnlTerraficCardOrCar)
        Me.Panel1.Controls.Add(Me.GLabel17)
        Me.Panel1.Controls.Add(Me.ChkViewCarImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 439)
        Me.Panel1.TabIndex = 16
        '
        'RadioButtonEntranceDateTimeSupportExit
        '
        Me.RadioButtonEntranceDateTimeSupportExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButtonEntranceDateTimeSupportExit.AutoSize = true
        Me.RadioButtonEntranceDateTimeSupportExit.Font = New System.Drawing.Font("B Homa", 11.25!)
        Me.RadioButtonEntranceDateTimeSupportExit.Location = New System.Drawing.Point(142, 177)
        Me.RadioButtonEntranceDateTimeSupportExit.Name = "RadioButtonEntranceDateTimeSupportExit"
        Me.RadioButtonEntranceDateTimeSupportExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButtonEntranceDateTimeSupportExit.Size = New System.Drawing.Size(158, 32)
        Me.RadioButtonEntranceDateTimeSupportExit.TabIndex = 359
        Me.RadioButtonEntranceDateTimeSupportExit.Text = "محدوده زمانی برای خروج"
        Me.RadioButtonEntranceDateTimeSupportExit.UseVisualStyleBackColor = true
        '
        'RadioButtonEntranceDateTimeSupportEnter
        '
        Me.RadioButtonEntranceDateTimeSupportEnter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButtonEntranceDateTimeSupportEnter.AutoSize = true
        Me.RadioButtonEntranceDateTimeSupportEnter.Checked = true
        Me.RadioButtonEntranceDateTimeSupportEnter.Font = New System.Drawing.Font("B Homa", 11.25!)
        Me.RadioButtonEntranceDateTimeSupportEnter.Location = New System.Drawing.Point(301, 177)
        Me.RadioButtonEntranceDateTimeSupportEnter.Name = "RadioButtonEntranceDateTimeSupportEnter"
        Me.RadioButtonEntranceDateTimeSupportEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButtonEntranceDateTimeSupportEnter.Size = New System.Drawing.Size(154, 32)
        Me.RadioButtonEntranceDateTimeSupportEnter.TabIndex = 358
        Me.RadioButtonEntranceDateTimeSupportEnter.TabStop = true
        Me.RadioButtonEntranceDateTimeSupportEnter.Text = "محدوده زمانی برای ورود"
        Me.RadioButtonEntranceDateTimeSupportEnter.UseVisualStyleBackColor = true
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(194, 210)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(209, 184)
        Me.UcDateTimeHolder.TabIndex = 357
        Me.UcDateTimeHolder.UCDisableTimeSetting = false
        Me.UcDateTimeHolder.UCTime1 = "00:00:00"
        Me.UcDateTimeHolder.UCTime2 = "23:59:59"
        Me.UcDateTimeHolder.UCViewTitle = false
        '
        'PnlTerraficCardOrCar
        '
        Me.PnlTerraficCardOrCar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTerraficCardOrCar.Controls.Add(Me.UcCar)
        Me.PnlTerraficCardOrCar.Controls.Add(Me.UcrfidCardTextMaintainer)
        Me.PnlTerraficCardOrCar.Controls.Add(Me.RadioButtonTerraficCard)
        Me.PnlTerraficCardOrCar.Controls.Add(Me.RadioButtonCar)
        Me.PnlTerraficCardOrCar.Location = New System.Drawing.Point(3, 6)
        Me.PnlTerraficCardOrCar.Name = "PnlTerraficCardOrCar"
        Me.PnlTerraficCardOrCar.Size = New System.Drawing.Size(591, 165)
        Me.PnlTerraficCardOrCar.TabIndex = 356
        '
        'UcCar
        '
        Me.UcCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcCar.BackColor = System.Drawing.Color.Transparent
        Me.UcCar.Enabled = false
        Me.UcCar.Location = New System.Drawing.Point(4, 71)
        Me.UcCar.Name = "UcCar"
        Me.UcCar.Padding = New System.Windows.Forms.Padding(3)
        Me.UcCar.Size = New System.Drawing.Size(584, 88)
        Me.UcCar.TabIndex = 358
        Me.UcCar.UCViewButtons = false
        '
        'UcrfidCardTextMaintainer
        '
        Me.UcrfidCardTextMaintainer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcrfidCardTextMaintainer.BackColor = System.Drawing.Color.Transparent
        Me.UcrfidCardTextMaintainer.Location = New System.Drawing.Point(169, 32)
        Me.UcrfidCardTextMaintainer.Name = "UcrfidCardTextMaintainer"
        Me.UcrfidCardTextMaintainer.Padding = New System.Windows.Forms.Padding(3)
        Me.UcrfidCardTextMaintainer.Size = New System.Drawing.Size(245, 37)
        Me.UcrfidCardTextMaintainer.TabIndex = 357
        Me.UcrfidCardTextMaintainer.UCEnable = true
        Me.UcrfidCardTextMaintainer.UCValue = ""
        '
        'RadioButtonTerraficCard
        '
        Me.RadioButtonTerraficCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButtonTerraficCard.AutoSize = true
        Me.RadioButtonTerraficCard.Checked = true
        Me.RadioButtonTerraficCard.Font = New System.Drawing.Font("B Homa", 11.25!)
        Me.RadioButtonTerraficCard.Location = New System.Drawing.Point(283, 3)
        Me.RadioButtonTerraficCard.Name = "RadioButtonTerraficCard"
        Me.RadioButtonTerraficCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButtonTerraficCard.Size = New System.Drawing.Size(126, 32)
        Me.RadioButtonTerraficCard.TabIndex = 354
        Me.RadioButtonTerraficCard.TabStop = true
        Me.RadioButtonTerraficCard.Text = "براساس کارت تردد"
        Me.RadioButtonTerraficCard.UseVisualStyleBackColor = true
        '
        'RadioButtonCar
        '
        Me.RadioButtonCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButtonCar.AutoSize = true
        Me.RadioButtonCar.Font = New System.Drawing.Font("B Homa", 11.25!)
        Me.RadioButtonCar.Location = New System.Drawing.Point(173, 3)
        Me.RadioButtonCar.Name = "RadioButtonCar"
        Me.RadioButtonCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButtonCar.Size = New System.Drawing.Size(104, 32)
        Me.RadioButtonCar.TabIndex = 355
        Me.RadioButtonCar.Text = "براساس خودرو"
        Me.RadioButtonCar.UseVisualStyleBackColor = true
        '
        'GLabel17
        '
        Me.GLabel17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GLabel17.Feather = 70
        Me.GLabel17.Font = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GLabel17.ForeColor = System.Drawing.Color.Gold
        Me.GLabel17.Glow = 30
        Me.GLabel17.GlowColor = System.Drawing.Color.DarkGoldenrod
        Me.GLabel17.Location = New System.Drawing.Point(212, 386)
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
        Me.ChkViewCarImage.Location = New System.Drawing.Point(369, 407)
        Me.ChkViewCarImage.Name = "ChkViewCarImage"
        Me.ChkViewCarImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkViewCarImage.Size = New System.Drawing.Size(15, 14)
        Me.ChkViewCarImage.TabIndex = 351
        Me.ChkViewCarImage.UseVisualStyleBackColor = true
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
        Me.UcLabelTop.Size = New System.Drawing.Size(597, 53)
        Me.UcLabelTop.TabIndex = 12
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش تردد و توقف خودرو در پارکینگ"
        '
        'UCCarEntranceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCarEntranceReport"
        Me.Size = New System.Drawing.Size(597, 492)
        Me.PnlMain.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.PnlTerraficCardOrCar.ResumeLayout(false)
        Me.PnlTerraficCardOrCar.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents PnlTerraficCardOrCar As Windows.Forms.Panel
    Friend WithEvents RadioButtonTerraficCard As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCar As Windows.Forms.RadioButton
    Friend WithEvents GLabel17 As gLabel.gLabel
    Friend WithEvents ChkViewCarImage As Windows.Forms.CheckBox
    Friend WithEvents RadioButtonEntranceDateTimeSupportEnter As Windows.Forms.RadioButton
    Friend WithEvents UcDateTimeHolder As R2CoreGUI.UCDateTimeHolder
    Friend WithEvents UcCar As UCCar
    Friend WithEvents UcrfidCardTextMaintainer As R2CoreGUI.UCRFIDCardTextMaintainer
    Friend WithEvents RadioButtonEntranceDateTimeSupportExit As Windows.Forms.RadioButton
End Class
