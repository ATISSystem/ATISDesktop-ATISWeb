Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLoadPermissionLocationSelection
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
        Me.RBTransportCompany = New System.Windows.Forms.RadioButton()
        Me.RBAnnouncementHall = New System.Windows.Forms.RadioButton()
        Me.PnlMain.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.RBTransportCompany)
        Me.PnlMain.Controls.Add(Me.RBAnnouncementHall)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(331, 31)
        Me.PnlMain.TabIndex = 0
        '
        'RBTransportCompany
        '
        Me.RBTransportCompany.AutoSize = true
        Me.RBTransportCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBTransportCompany.Font = New System.Drawing.Font("B Homa", 9!)
        Me.RBTransportCompany.Location = New System.Drawing.Point(3, 3)
        Me.RBTransportCompany.Name = "RBTransportCompany"
        Me.RBTransportCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBTransportCompany.Size = New System.Drawing.Size(177, 26)
        Me.RBTransportCompany.TabIndex = 3
        Me.RBTransportCompany.Text = "صادرشده در محل شرکت حمل و نقل"
        Me.RBTransportCompany.UseVisualStyleBackColor = true
        '
        'RBAnnouncementHall
        '
        Me.RBAnnouncementHall.AutoSize = true
        Me.RBAnnouncementHall.Checked = true
        Me.RBAnnouncementHall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBAnnouncementHall.Font = New System.Drawing.Font("B Homa", 9!)
        Me.RBAnnouncementHall.Location = New System.Drawing.Point(186, 3)
        Me.RBAnnouncementHall.Name = "RBAnnouncementHall"
        Me.RBAnnouncementHall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBAnnouncementHall.Size = New System.Drawing.Size(135, 26)
        Me.RBAnnouncementHall.TabIndex = 2
        Me.RBAnnouncementHall.TabStop = true
        Me.RBAnnouncementHall.Text = "صادرشده در سالن اعلام بار"
        Me.RBAnnouncementHall.UseVisualStyleBackColor = true
        '
        'UCLoadPermissionLocationSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCLoadPermissionLocationSelection"
        Me.Size = New System.Drawing.Size(331, 31)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlMain.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents RBTransportCompany As System.Windows.Forms.RadioButton
    Friend WithEvents RBAnnouncementHall As System.Windows.Forms.RadioButton
End Class
