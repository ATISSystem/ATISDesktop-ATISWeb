Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCIndigenousTrucksWithUNNativeLPReport
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
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlReportObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcButtonSpecial = New R2CoreGUI.UCButtonSpecial()
        Me.PnlMain.SuspendLayout
        Me.PnlReportObjects.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = false
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PnlReportObjects)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
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
        Me.PnlMain.Size = New System.Drawing.Size(366, 139)
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
        'UcLabelTop
        '
        Me.UcLabelTop._UCBackColorPopup = System.Drawing.Color.Transparent
        Me.UcLabelTop._UCForeColorPopuped = System.Drawing.Color.Red
        Me.UcLabelTop.BackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcLabelTop.Location = New System.Drawing.Point(0, 0)
        Me.UcLabelTop.Name = "UcLabelTop"
        Me.UcLabelTop.Padding = New System.Windows.Forms.Padding(1)
        Me.UcLabelTop.Size = New System.Drawing.Size(366, 52)
        Me.UcLabelTop.TabIndex = 353
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "لیست ناوگان باری بومی با پلاک غیربومی"
        '
        'PnlReportObjects
        '
        Me.PnlReportObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlReportObjects.Border = false
        Me.PnlReportObjects.BorderColor = System.Drawing.Color.Black
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlReportObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReportObjects.Controls.Add(Me.UcButtonSpecial)
        Me.PnlReportObjects.CornerRadius = 20
        Me.PnlReportObjects.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlReportObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlReportObjects.Gradient = true
        Me.PnlReportObjects.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlReportObjects.GradientOffset = 1!
        Me.PnlReportObjects.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlReportObjects.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlReportObjects.Grayscale = false
        Me.PnlReportObjects.Image = Nothing
        Me.PnlReportObjects.ImageAlpha = 75
        Me.PnlReportObjects.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlReportObjects.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlReportObjects.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlReportObjects.Location = New System.Drawing.Point(0, 52)
        Me.PnlReportObjects.Name = "PnlReportObjects"
        Me.PnlReportObjects.Rounded = true
        Me.PnlReportObjects.Size = New System.Drawing.Size(366, 87)
        Me.PnlReportObjects.TabIndex = 354
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlReportObjects
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlReportObjects
        '
        'UcButtonSpecial
        '
        Me.UcButtonSpecial.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.Location = New System.Drawing.Point(105, 18)
        Me.UcButtonSpecial.Name = "UcButtonSpecial"
        Me.UcButtonSpecial.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecial.Size = New System.Drawing.Size(156, 50)
        Me.UcButtonSpecial.TabIndex = 0
        Me.UcButtonSpecial.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecial.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecial.UCEnable = true
        Me.UcButtonSpecial.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcButtonSpecial.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecial.UCValue = "نمایش"
        '
        'UCTblIndigenousTrucksWithUNNativeLPReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTblIndigenousTrucksWithUNNativeLPReport"
        Me.Size = New System.Drawing.Size(366, 139)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlReportObjects.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlReportObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcButtonSpecial As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
End Class
