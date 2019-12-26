Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcAnnouncementHallMonitoringControlPanel
    Inherits FrmcGeneral

    'Form overrides dispose to clean up the component list.
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
        Me.PnlTopMenu = New System.Windows.Forms.Panel()
        Me.BtnPersianTextMessageSetting = New System.Windows.Forms.Button()
        Me.PnlPersianTextMessageSetting = New System.Windows.Forms.Panel()
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1 = New PayanehClassLibrary.UCAnnouncementHallMonitoringPersianTextMessageEditor()
        Me.PnlTopMenu.SuspendLayout
        Me.PnlPersianTextMessageSetting.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlTopMenu
        '
        Me.PnlTopMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTopMenu.Controls.Add(Me.BtnPersianTextMessageSetting)
        Me.PnlTopMenu.Location = New System.Drawing.Point(5, 4)
        Me.PnlTopMenu.Name = "PnlTopMenu"
        Me.PnlTopMenu.Size = New System.Drawing.Size(725, 42)
        Me.PnlTopMenu.TabIndex = 201
        '
        'BtnPersianTextMessageSetting
        '
        Me.BtnPersianTextMessageSetting.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPersianTextMessageSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersianTextMessageSetting.Font = New System.Drawing.Font("IRMehr", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.BtnPersianTextMessageSetting.ForeColor = System.Drawing.Color.White
        Me.BtnPersianTextMessageSetting.Location = New System.Drawing.Point(6, 3)
        Me.BtnPersianTextMessageSetting.Name = "BtnPersianTextMessageSetting"
        Me.BtnPersianTextMessageSetting.Size = New System.Drawing.Size(135, 35)
        Me.BtnPersianTextMessageSetting.TabIndex = 0
        Me.BtnPersianTextMessageSetting.Text = "تنظیم متن نمایشگر"
        Me.BtnPersianTextMessageSetting.UseVisualStyleBackColor = false
        '
        'PnlPersianTextMessageSetting
        '
        Me.PnlPersianTextMessageSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlPersianTextMessageSetting.BackColor = System.Drawing.Color.Transparent
        Me.PnlPersianTextMessageSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPersianTextMessageSetting.Controls.Add(Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1)
        Me.PnlPersianTextMessageSetting.Location = New System.Drawing.Point(5, 50)
        Me.PnlPersianTextMessageSetting.Name = "PnlPersianTextMessageSetting"
        Me.PnlPersianTextMessageSetting.Size = New System.Drawing.Size(995, 512)
        Me.PnlPersianTextMessageSetting.TabIndex = 202
        '
        'UcAnnouncementHallMonitoringPersianTextMessageEditor1
        '
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.BackColor = System.Drawing.Color.Transparent
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.Location = New System.Drawing.Point(32, 19)
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.Name = "UcAnnouncementHallMonitoringPersianTextMessageEditor1"
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.Padding = New System.Windows.Forms.Padding(10)
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.Size = New System.Drawing.Size(933, 467)
        Me.UcAnnouncementHallMonitoringPersianTextMessageEditor1.TabIndex = 0
        '
        'FrmcAnnouncementHallMonitoringControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlPersianTextMessageSetting)
        Me.Controls.Add(Me.PnlTopMenu)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcAnnouncementHallMonitoringControlPanel"
        Me.Text = "FrmcAnnouncementHallMonitoringControlPanel"
        Me.Controls.SetChildIndex(Me.PnlTopMenu, 0)
        Me.Controls.SetChildIndex(Me.PnlPersianTextMessageSetting, 0)
        Me.PnlTopMenu.ResumeLayout(false)
        Me.PnlPersianTextMessageSetting.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTopMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnPersianTextMessageSetting As System.Windows.Forms.Button
    Friend WithEvents PnlPersianTextMessageSetting As System.Windows.Forms.Panel
    Friend WithEvents UcAnnouncementHallMonitoringPersianTextMessageEditor1 As UCAnnouncementHallMonitoringPersianTextMessageEditor
End Class
