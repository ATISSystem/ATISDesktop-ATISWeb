Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCapacitorLoadsforAnnounceReport
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
        Dim R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1 As R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure = New R2CoreTransportationAndLoadNotification.AnnouncementHalls.R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlReportObjects = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.RBSubGroup = New System.Windows.Forms.RadioButton()
        Me.UcucAnnouncementHallSubGroupCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallSubGroupCollection()
        Me.RBAll = New System.Windows.Forms.RadioButton()
        Me.UcucAnnouncementHallCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.PnlMain.SuspendLayout
        Me.PnlReportObjects.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlReportObjects)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(3, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(852, 212)
        Me.PnlMain.TabIndex = 0
        '
        'PnlReportObjects
        '
        Me.PnlReportObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlReportObjects.Border = false
        Me.PnlReportObjects.BorderColor = System.Drawing.Color.Black
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlReportObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReportObjects.Controls.Add(Me.RBSubGroup)
        Me.PnlReportObjects.Controls.Add(Me.UcucAnnouncementHallSubGroupCollection)
        Me.PnlReportObjects.Controls.Add(Me.RBAll)
        Me.PnlReportObjects.Controls.Add(Me.UcucAnnouncementHallCollection)
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
        Me.PnlReportObjects.Size = New System.Drawing.Size(852, 160)
        Me.PnlReportObjects.TabIndex = 360
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlReportObjects
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlReportObjects
        '
        'RBSubGroup
        '
        Me.RBSubGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RBSubGroup.AutoSize = true
        Me.RBSubGroup.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBSubGroup.ForeColor = System.Drawing.Color.MidnightBlue
        Me.RBSubGroup.Location = New System.Drawing.Point(575, 19)
        Me.RBSubGroup.Name = "RBSubGroup"
        Me.RBSubGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBSubGroup.Size = New System.Drawing.Size(161, 32)
        Me.RBSubGroup.TabIndex = 357
        Me.RBSubGroup.Text = "بار مرتبط با زیرگروه سالن"
        Me.RBSubGroup.UseVisualStyleBackColor = true
        '
        'UcucAnnouncementHallSubGroupCollection
        '
        Me.UcucAnnouncementHallSubGroupCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallSubGroupCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallSubGroupCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucAnnouncementHallSubGroupCollection.Location = New System.Drawing.Point(3, 103)
        Me.UcucAnnouncementHallSubGroupCollection.Name = "UcucAnnouncementHallSubGroupCollection"
        Me.UcucAnnouncementHallSubGroupCollection.Size = New System.Drawing.Size(846, 47)
        Me.UcucAnnouncementHallSubGroupCollection.TabIndex = 359
        Me.UcucAnnouncementHallSubGroupCollection.UCCurrentNSS = Nothing
        Me.UcucAnnouncementHallSubGroupCollection.UCViewBorder = true
        '
        'RBAll
        '
        Me.RBAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RBAll.AutoSize = true
        Me.RBAll.Checked = true
        Me.RBAll.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBAll.ForeColor = System.Drawing.Color.MidnightBlue
        Me.RBAll.Location = New System.Drawing.Point(743, 19)
        Me.RBAll.Name = "RBAll"
        Me.RBAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAll.Size = New System.Drawing.Size(94, 32)
        Me.RBAll.TabIndex = 1
        Me.RBAll.TabStop = true
        Me.RBAll.Text = "کل بار سالن"
        Me.RBAll.UseVisualStyleBackColor = true
        '
        'UcucAnnouncementHallCollection
        '
        Me.UcucAnnouncementHallCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucAnnouncementHallCollection.Location = New System.Drawing.Point(3, 55)
        Me.UcucAnnouncementHallCollection.Name = "UcucAnnouncementHallCollection"
        Me.UcucAnnouncementHallCollection.Size = New System.Drawing.Size(846, 47)
        Me.UcucAnnouncementHallCollection.TabIndex = 358
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Active = true
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHColor = "Green"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHId = CType(2,Long)
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.AHTitle = "سالن اعلام بار جاده ای"
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.Deleted = false
        R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1.ViewFlag = true
        Me.UcucAnnouncementHallCollection.UCCurrentNSS = R2CoreTransportationAndLoadNotificationStandardAnnouncementHallStructure1
        Me.UcucAnnouncementHallCollection.UCDefaultAHId = CType(2,Long)
        Me.UcucAnnouncementHallCollection.UCViewBorder = true
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
        Me.UcLabelTop.Size = New System.Drawing.Size(852, 52)
        Me.UcLabelTop.TabIndex = 350
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش بار موجود (شرکتهای حمل و نقل) - مخزن بار"
        '
        'UCCapacitorLoadsforAnnounceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCapacitorLoadsforAnnounceReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(858, 218)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlReportObjects.ResumeLayout(false)
        Me.PnlReportObjects.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents RBSubGroup As System.Windows.Forms.RadioButton
    Friend WithEvents RBAll As System.Windows.Forms.RadioButton
    Friend WithEvents UcucAnnouncementHallSubGroupCollection As R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallSubGroupCollection
    Friend WithEvents UcucAnnouncementHallCollection As R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection
    Friend WithEvents PnlReportObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
End Class
