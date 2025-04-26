Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadPermissionIssued
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlReportObjects = New System.Windows.Forms.Panel()
        Me.UcucSequentialTurnCollection = New R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.UcAnnouncementHallSelection = New R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection()
        Me.UcDateTimeHolder = New R2CoreGUI.UCDateTimeHolder()
        Me.UcLabelTop = New R2CoreGUI.UCLabel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlMain.SuspendLayout()
        Me.PnlReportObjects.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlReportObjects)
        Me.PnlMain.Controls.Add(Me.UcLabelTop)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(918, 503)
        Me.PnlMain.TabIndex = 0
        '
        'PnlReportObjects
        '
        Me.PnlReportObjects.Controls.Add(Me.UcucSequentialTurnCollection)
        Me.PnlReportObjects.Controls.Add(Me.RB2)
        Me.PnlReportObjects.Controls.Add(Me.RB1)
        Me.PnlReportObjects.Controls.Add(Me.UcAnnouncementHallSelection)
        Me.PnlReportObjects.Controls.Add(Me.UcDateTimeHolder)
        Me.PnlReportObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlReportObjects.Location = New System.Drawing.Point(0, 52)
        Me.PnlReportObjects.Name = "PnlReportObjects"
        Me.PnlReportObjects.Size = New System.Drawing.Size(918, 451)
        Me.PnlReportObjects.TabIndex = 353
        '
        'UcucSequentialTurnCollection
        '
        Me.UcucSequentialTurnCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcucSequentialTurnCollection.BackColor = System.Drawing.Color.Transparent
        Me.UcucSequentialTurnCollection.Location = New System.Drawing.Point(30, 184)
        Me.UcucSequentialTurnCollection.Name = "UcucSequentialTurnCollection"
        Me.UcucSequentialTurnCollection.Size = New System.Drawing.Size(859, 45)
        Me.UcucSequentialTurnCollection.TabIndex = 13
        '
        'RB2
        '
        Me.RB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB2.AutoSize = True
        Me.RB2.Checked = True
        Me.RB2.Font = New System.Drawing.Font("IRMehr", 9.0!)
        Me.RB2.Location = New System.Drawing.Point(757, 141)
        Me.RB2.Name = "RB2"
        Me.RB2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB2.Size = New System.Drawing.Size(132, 25)
        Me.RB2.TabIndex = 12
        Me.RB2.TabStop = True
        Me.RB2.Text = "بر مبنای تسلسل نوبت"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("IRMehr", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RB1.Location = New System.Drawing.Point(749, 24)
        Me.RB1.Name = "RB1"
        Me.RB1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RB1.Size = New System.Drawing.Size(140, 25)
        Me.RB1.TabIndex = 11
        Me.RB1.Text = "بر مبنای زیرگروه اعلام بار"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'UcAnnouncementHallSelection
        '
        Me.UcAnnouncementHallSelection.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcAnnouncementHallSelection.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallSelection.Enabled = False
        Me.UcAnnouncementHallSelection.Location = New System.Drawing.Point(30, 55)
        Me.UcAnnouncementHallSelection.Name = "UcAnnouncementHallSelection"
        Me.UcAnnouncementHallSelection.Size = New System.Drawing.Size(859, 80)
        Me.UcAnnouncementHallSelection.TabIndex = 8
        '
        'UcDateTimeHolder
        '
        Me.UcDateTimeHolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcDateTimeHolder.BackColor = System.Drawing.Color.Transparent
        Me.UcDateTimeHolder.Location = New System.Drawing.Point(355, 246)
        Me.UcDateTimeHolder.Name = "UcDateTimeHolder"
        Me.UcDateTimeHolder.Padding = New System.Windows.Forms.Padding(3)
        Me.UcDateTimeHolder.Size = New System.Drawing.Size(209, 193)
        Me.UcDateTimeHolder.TabIndex = 7
        Me.UcDateTimeHolder.UCDisableTimeSetting = False
        Me.UcDateTimeHolder.UCTime1 = "00:00:00"
        Me.UcDateTimeHolder.UCTime2 = "23:59:59"
        Me.UcDateTimeHolder.UCViewTitle = False
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
        Me.UcLabelTop.Size = New System.Drawing.Size(918, 52)
        Me.UcLabelTop.TabIndex = 352
        Me.UcLabelTop.UCBackColor = System.Drawing.Color.DodgerBlue
        Me.UcLabelTop.UCFont = New System.Drawing.Font("B Homa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcLabelTop.UCForeColor = System.Drawing.Color.White
        Me.UcLabelTop.UCTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcLabelTop.UCValue = "گزارش مجوزهای صادرشده به ترتیب زمان و اولویت انتخابی"
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'UCLoadPermissionIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadPermissionIssued"
        Me.Size = New System.Drawing.Size(918, 503)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlReportObjects.ResumeLayout(False)
        Me.PnlReportObjects.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Windows.Forms.Panel
    Friend WithEvents UcLabelTop As R2CoreGUI.UCLabel
    Friend WithEvents PnlReportObjects As Windows.Forms.Panel
    Friend WithEvents UcDateTimeHolder As R2CoreGUI.UCDateTimeHolder
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcAnnouncementHallSelection As R2CoreTransportationAndLoadNotification.UCAnnouncementHallSelection
    Friend WithEvents UcucSequentialTurnCollection As R2CoreTransportationAndLoadNotification.UCUCSequentialTurnCollection
    Friend WithEvents RB2 As Windows.Forms.RadioButton
    Friend WithEvents RB1 As Windows.Forms.RadioButton
End Class
