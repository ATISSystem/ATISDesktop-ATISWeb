<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCManipulationBillOfLadingControl
    Inherits UCBillOfLadingControl

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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.UcButtonAnalyzeBLC = New R2CoreGUI.UCButton()
        Me.UcButtonDeleteBLC = New R2CoreGUI.UCButton()
        Me.UcButtonViewBLC = New R2CoreGUI.UCButton()
        Me.UcViewerNSSBillOfLadingControlExtended = New R2CoreTransportationAndLoadNotification.UCViewerNSSBillOfLadingControlExtended()
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLabel1 = New R2CoreGUI.UCLabel()
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
        Me.PnlMain.Size = New System.Drawing.Size(777, 116)
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
        Me.PnlOutter.Size = New System.Drawing.Size(777, 116)
        Me.PnlOutter.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.White
        Me.PnlInner.Controls.Add(Me.UcButtonAnalyzeBLC)
        Me.PnlInner.Controls.Add(Me.UcButtonDeleteBLC)
        Me.PnlInner.Controls.Add(Me.UcButtonViewBLC)
        Me.PnlInner.Controls.Add(Me.UcLabel1)
        Me.PnlInner.Controls.Add(Me.AlphaGradientPanel1)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(2, 2)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(773, 112)
        Me.PnlInner.TabIndex = 0
        '
        'UcButtonAnalyzeBLC
        '
        Me.UcButtonAnalyzeBLC.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonAnalyzeBLC.Location = New System.Drawing.Point(225, 4)
        Me.UcButtonAnalyzeBLC.Name = "UcButtonAnalyzeBLC"
        Me.UcButtonAnalyzeBLC.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonAnalyzeBLC.Size = New System.Drawing.Size(127, 34)
        Me.UcButtonAnalyzeBLC.TabIndex = 3
        Me.UcButtonAnalyzeBLC.UCBackColor = System.Drawing.Color.OrangeRed
        Me.UcButtonAnalyzeBLC.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonAnalyzeBLC.UCEnable = true
        Me.UcButtonAnalyzeBLC.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonAnalyzeBLC.UCForeColor = System.Drawing.Color.White
        Me.UcButtonAnalyzeBLC.UCValue = "بررسی تخلفات"
        '
        'UcButtonDeleteBLC
        '
        Me.UcButtonDeleteBLC.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonDeleteBLC.Location = New System.Drawing.Point(165, 4)
        Me.UcButtonDeleteBLC.Name = "UcButtonDeleteBLC"
        Me.UcButtonDeleteBLC.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonDeleteBLC.Size = New System.Drawing.Size(57, 34)
        Me.UcButtonDeleteBLC.TabIndex = 2
        Me.UcButtonDeleteBLC.UCBackColor = System.Drawing.Color.Red
        Me.UcButtonDeleteBLC.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonDeleteBLC.UCEnable = true
        Me.UcButtonDeleteBLC.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UcButtonDeleteBLC.UCForeColor = System.Drawing.Color.White
        Me.UcButtonDeleteBLC.UCValue = "حذف"
        '
        'UcButtonViewBLC
        '
        Me.UcButtonViewBLC.BackColor = System.Drawing.Color.Transparent
        Me.UcButtonViewBLC.Location = New System.Drawing.Point(36, 4)
        Me.UcButtonViewBLC.Name = "UcButtonViewBLC"
        Me.UcButtonViewBLC.Padding = New System.Windows.Forms.Padding(1)
        Me.UcButtonViewBLC.Size = New System.Drawing.Size(127, 34)
        Me.UcButtonViewBLC.TabIndex = 1
        Me.UcButtonViewBLC.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcButtonViewBLC.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonViewBLC.UCEnable = true
        Me.UcButtonViewBLC.UCFont = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UcButtonViewBLC.UCForeColor = System.Drawing.Color.White
        Me.UcButtonViewBLC.UCValue = "مشاهده جزییات"
        '
        'UcViewerNSSBillOfLadingControlExtended
        '
        Me.UcViewerNSSBillOfLadingControlExtended.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcViewerNSSBillOfLadingControlExtended.BackColor = System.Drawing.Color.Transparent
        Me.UcViewerNSSBillOfLadingControlExtended.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcViewerNSSBillOfLadingControlExtended.Location = New System.Drawing.Point(3, 10)
        Me.UcViewerNSSBillOfLadingControlExtended.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcViewerNSSBillOfLadingControlExtended.Name = "UcViewerNSSBillOfLadingControlExtended"
        Me.UcViewerNSSBillOfLadingControlExtended.Padding = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.UcViewerNSSBillOfLadingControlExtended.Size = New System.Drawing.Size(756, 79)
        Me.UcViewerNSSBillOfLadingControlExtended.TabIndex = 0
        Me.UcViewerNSSBillOfLadingControlExtended.UCNSSCurrent = Nothing
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = true
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Silver
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.UcViewerNSSBillOfLadingControlExtended)
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
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(8, 23)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = true
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(759, 86)
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
        'UcLabel1
        '
        Me.UcLabel1._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabel1._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLabel1.BackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.Location = New System.Drawing.Point(615, 6)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabel1.Size = New System.Drawing.Size(116, 32)
        Me.UcLabel1.TabIndex = 1
        Me.UcLabel1.UCBackColor = System.Drawing.Color.Transparent
        Me.UcLabel1.UCFont = New System.Drawing.Font("IRMehr", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabel1.UCForeColor = System.Drawing.Color.Black
        Me.UcLabel1.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabel1.UCValue = "کنترل بارنامه"
        '
        'UCManipulationBillOfLadingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCManipulationBillOfLadingControl"
        Me.Size = New System.Drawing.Size(777, 116)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.AlphaGradientPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents PnlOutter As Windows.Forms.Panel
    Friend WithEvents PnlInner As Windows.Forms.Panel
    Friend WithEvents UcViewerNSSBillOfLadingControlExtended As UCViewerNSSBillOfLadingControlExtended
    Friend WithEvents UcButtonViewBLC As R2CoreGUI.UCButton
    Friend WithEvents UcButtonDeleteBLC As R2CoreGUI.UCButton
    Friend WithEvents UcButtonAnalyzeBLC As R2CoreGUI.UCButton
    Friend WithEvents UcLabel1 As R2CoreGUI.UCLabel
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
End Class
