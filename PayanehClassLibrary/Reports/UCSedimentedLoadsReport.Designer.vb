Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSedimentedLoadsReport
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
        Me.RBTargetCity = New System.Windows.Forms.RadioButton()
        Me.RBTransportCompany = New System.Windows.Forms.RadioButton()
        Me.UcucAnnouncementHallCollection = New R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection()
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
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
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(823, 396)
        Me.PnlMain.TabIndex = 0
        '
        'PnlReportObjects
        '
        Me.PnlReportObjects.BackColor = System.Drawing.Color.Transparent
        Me.PnlReportObjects.Border = false
        Me.PnlReportObjects.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlReportObjects.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlReportObjects.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReportObjects.Controls.Add(Me.RBTargetCity)
        Me.PnlReportObjects.Controls.Add(Me.RBTransportCompany)
        Me.PnlReportObjects.Controls.Add(Me.UcucAnnouncementHallCollection)
        Me.PnlReportObjects.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlReportObjects.CornerRadius = 20
        Me.PnlReportObjects.Corners = BlueActivity.Controls.Corner.None
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
        Me.PnlReportObjects.Size = New System.Drawing.Size(823, 344)
        Me.PnlReportObjects.TabIndex = 352
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
        'RBTargetCity
        '
        Me.RBTargetCity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBTargetCity.AutoSize = true
        Me.RBTargetCity.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBTargetCity.Location = New System.Drawing.Point(432, 34)
        Me.RBTargetCity.Name = "RBTargetCity"
        Me.RBTargetCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBTargetCity.Size = New System.Drawing.Size(161, 33)
        Me.RBTargetCity.TabIndex = 8
        Me.RBTargetCity.Text = "براساس مقصد حمل بار"
        Me.RBTargetCity.UseVisualStyleBackColor = true
        '
        'RBTransportCompany
        '
        Me.RBTransportCompany.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBTransportCompany.AutoSize = true
        Me.RBTransportCompany.Checked = true
        Me.RBTransportCompany.Font = New System.Drawing.Font("B Homa", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RBTransportCompany.Location = New System.Drawing.Point(621, 34)
        Me.RBTransportCompany.Name = "RBTransportCompany"
        Me.RBTransportCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBTransportCompany.Size = New System.Drawing.Size(183, 33)
        Me.RBTransportCompany.TabIndex = 7
        Me.RBTransportCompany.TabStop = true
        Me.RBTransportCompany.Text = "براساس شرکت حمل و نقل"
        Me.RBTransportCompany.UseVisualStyleBackColor = true
        '
        'UcucAnnouncementHallCollection
        '
        Me.UcucAnnouncementHallCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcucAnnouncementHallCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucAnnouncementHallCollection.Location = New System.Drawing.Point(20, 73)
        Me.UcucAnnouncementHallCollection.Name = "UcucAnnouncementHallCollection"
        Me.UcucAnnouncementHallCollection.Size = New System.Drawing.Size(784, 47)
        Me.UcucAnnouncementHallCollection.TabIndex = 5
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
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(307, 127)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(209, 193)
        Me.UcDateTimeHolder.TabIndex = 6
        Me.UcDateTimeHolder.UCDisableTimeSetting = true
        Me.UcDateTimeHolder.UCTime1 = "00:00:00"
        Me.UcDateTimeHolder.UCTime2 = "23:59:59"
        Me.UcDateTimeHolder.UCViewTitle = false
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
        Me.UcLabelTop.Size = New System.Drawing.Size(823, 52)
        Me.UcLabelTop.TabIndex = 351
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش بارهای رسوبی در سالن های اعلام بار"
        '
        'UCSedimentedLoadsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCSedimentedLoadsReport"
        Me.Size = New System.Drawing.Size(823, 396)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlReportObjects.ResumeLayout(false)
        Me.PnlReportObjects.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelTop As UCLabel
    Friend WithEvents PnlReportObjects As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcucAnnouncementHallCollection As R2CoreTransportationAndLoadNotification.UCUCAnnouncementHallCollection
    Friend WithEvents UcDateTimeHolder As UCDateTimeHolder
    Friend WithEvents RBTargetCity As Windows.Forms.RadioButton
    Friend WithEvents RBTransportCompany As Windows.Forms.RadioButton
End Class
