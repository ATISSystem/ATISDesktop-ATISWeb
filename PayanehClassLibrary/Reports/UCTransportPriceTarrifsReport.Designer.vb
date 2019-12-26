Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTransportPriceTarrifsReport
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
        Me.PnlReportObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.RBOnlyActive = New System.Windows.Forms.RadioButton()
        Me.RBAll = New System.Windows.Forms.RadioButton()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
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
        Me.PnlMain.Size = New System.Drawing.Size(888, 224)
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
        'PnlReportObjects
        '
        Me.PnlReportObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlReportObjects.Border = false
        Me.PnlReportObjects.BorderColor = System.Drawing.Color.Black
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlReportObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReportObjects.Controls.Add(Me.RBOnlyActive)
        Me.PnlReportObjects.Controls.Add(Me.RBAll)
        Me.PnlReportObjects.Controls.Add(Me.UcAnnouncementHallSelection)
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
        Me.PnlReportObjects.Size = New System.Drawing.Size(888, 172)
        Me.PnlReportObjects.TabIndex = 353
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
        'RBOnlyActive
        '
        Me.RBOnlyActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RBOnlyActive.AutoSize = true
        Me.RBOnlyActive.Checked = true
        Me.RBOnlyActive.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBOnlyActive.Location = New System.Drawing.Point(593, 10)
        Me.RBOnlyActive.Name = "RBOnlyActive"
        Me.RBOnlyActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBOnlyActive.Size = New System.Drawing.Size(99, 33)
        Me.RBOnlyActive.TabIndex = 2
        Me.RBOnlyActive.TabStop = true
        Me.RBOnlyActive.Text = "تعرفه فعال"
        Me.RBOnlyActive.UseVisualStyleBackColor = true
        '
        'RBAll
        '
        Me.RBAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RBAll.AutoSize = true
        Me.RBAll.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBAll.Location = New System.Drawing.Point(707, 10)
        Me.RBAll.Name = "RBAll"
        Me.RBAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAll.Size = New System.Drawing.Size(150, 33)
        Me.RBAll.TabIndex = 1
        Me.RBAll.Text = "کلیه سوابق ثبت شده"
        Me.RBAll.UseVisualStyleBackColor = true
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(3, 50)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(882, 84)
        Me.UcAnnouncementHallSelection.TabIndex = 0
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
        Me.UcLabelTop.Size = New System.Drawing.Size(888, 52)
        Me.UcLabelTop.TabIndex = 352
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش تعرفه های حمل بار"
        '
        'UCTransportPriceTarrifsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTransportPriceTarrifsReport"
        Me.Size = New System.Drawing.Size(888, 224)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlReportObjects.ResumeLayout(false)
        Me.PnlReportObjects.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlReportObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcAnnouncementHallSelection As R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection
    Friend WithEvents RBOnlyActive As Windows.Forms.RadioButton
    Friend WithEvents RBAll As Windows.Forms.RadioButton
End Class
