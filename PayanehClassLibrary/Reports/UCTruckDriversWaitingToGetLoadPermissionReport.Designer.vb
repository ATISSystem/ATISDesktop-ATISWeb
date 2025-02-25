Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTruckDriversWaitingToGetLoadPermissionReport
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
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcButtonSpecialViewReport = New R2CoreGUI.UCButtonSpecial()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout()
        Me.PnlReportObjects.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Border = False
        Me.PnlMain.BorderColor = System.Drawing.Color.Black
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlMain.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlMain.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlMain.Controls.Add(Me.PnlReportObjects)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.CornerRadius = 20
        Me.PnlMain.Corners = CType((BlueActivity.Controls.Corner.BottomLeft Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
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
        Me.PnlMain.Rounded = True
        Me.PnlMain.Size = New System.Drawing.Size(736, 399)
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
        Me.PnlReportObjects.Border = False
        Me.PnlReportObjects.BorderColor = System.Drawing.Color.Black
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlReportObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReportObjects.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.PnlReportObjects.Controls.Add(Me.RB2)
        Me.PnlReportObjects.Controls.Add(Me.RB1)
        Me.PnlReportObjects.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlReportObjects.Controls.Add(Me.UcButtonSpecialViewReport)
        Me.PnlReportObjects.CornerRadius = 20
        Me.PnlReportObjects.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.PnlReportObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlReportObjects.Gradient = True
        Me.PnlReportObjects.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlReportObjects.GradientOffset = 1.0!
        Me.PnlReportObjects.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlReportObjects.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlReportObjects.Grayscale = False
        Me.PnlReportObjects.Image = Nothing
        Me.PnlReportObjects.ImageAlpha = 75
        Me.PnlReportObjects.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlReportObjects.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlReportObjects.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlReportObjects.Location = New System.Drawing.Point(0, 52)
        Me.PnlReportObjects.Name = "PnlReportObjects"
        Me.PnlReportObjects.Rounded = True
        Me.PnlReportObjects.Size = New System.Drawing.Size(736, 347)
        Me.PnlReportObjects.TabIndex = 351
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
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(348, 184)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(370, 45)
        Me.UcucSequentialTurnCollection.TabIndex = 15
        '
        'RB2
        '
        Me.RB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB2.AutoSize = True
        Me.RB2.Checked = True
        Me.RB2.Font = New System.Drawing.Font("IRMehr", 9.0!)
        Me.RB2.Location = New System.Drawing.Point(586, 153)
        Me.RB2.Name = "RB2"
        Me.RB2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB2.Size = New System.Drawing.Size(132, 25)
        Me.RB2.TabIndex = 14
        Me.RB2.TabStop = True
        Me.RB2.Text = "بر مبنای تسلسل نوبت"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RB1.Location = New System.Drawing.Point(578, 23)
        Me.RB1.Name = "RB1"
        Me.RB1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB1.Size = New System.Drawing.Size(140, 25)
        Me.RB1.TabIndex = 12
        Me.RB1.Text = "بر مبنای زیرگروه اعلام بار"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Enabled = False
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(17, 54)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(702, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 2
        '
        'UcButtonSpecialViewReport
        '
        Me.UcButtonSpecialViewReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcButtonSpecialViewReport.BackColor = System.Drawing.Color.Black
        Me.UcButtonSpecialViewReport.Location = New System.Drawing.Point(305, 266)
        Me.UcButtonSpecialViewReport.Name = "UcButtonSpecialViewReport"
        Me.UcButtonSpecialViewReport.Padding = New System.Windows.Forms.Padding(2)
        Me.UcButtonSpecialViewReport.Size = New System.Drawing.Size(126, 42)
        Me.UcButtonSpecialViewReport.TabIndex = 1
        Me.UcButtonSpecialViewReport.UCBackColor = System.Drawing.Color.White
        Me.UcButtonSpecialViewReport.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcButtonSpecialViewReport.UCEnable = True
        Me.UcButtonSpecialViewReport.UCFont = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcButtonSpecialViewReport.UCForeColor = System.Drawing.Color.Black
        Me.UcButtonSpecialViewReport.UCValue = "نمایش"
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
        Me.UcLabelTop.Size = New System.Drawing.Size(736, 52)
        Me.UcLabelTop.TabIndex = 350
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش رانندگان منتظر دریافت مجوز بارگیری"
        '
        'UCTruckDriversWaitingToGetLoadPermissionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCTruckDriversWaitingToGetLoadPermissionReport"
        Me.Size = New System.Drawing.Size(736, 399)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlReportObjects.ResumeLayout(False)
        Me.PnlReportObjects.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlReportObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents UcButtonSpecialViewReport As R2CoreGUI.UCButtonSpecial
    Friend WithEvents UcAnnouncementHallSelection As R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection
    Friend WithEvents RB1 As Windows.Forms.RadioButton
    Friend WithEvents UcucSequentialTurnCollection As R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection
    Friend WithEvents RB2 As Windows.Forms.RadioButton
End Class
