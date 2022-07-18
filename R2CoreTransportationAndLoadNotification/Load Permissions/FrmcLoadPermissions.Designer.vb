Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadPermissions
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
        Me.PnlLoadPermissions = New System.Windows.Forms.Panel()
        Me.UcucLoadPermissionCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCLoadPermissionCollectionAdvance()
        Me.PnlLoadPermissionCancellation = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLoadPermissionCancellation = New R2CoreTransportationAndLoadNotification.UCLoadPermissionCancellation()
        Me.PnlLoadPermissions.SuspendLayout()
        Me.PnlLoadPermissionCancellation.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlLoadPermissions
        '
        Me.PnlLoadPermissions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLoadPermissions.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadPermissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadPermissions.Controls.Add(Me.UcucLoadPermissionCollectionAdvance)
        Me.PnlLoadPermissions.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadPermissions.Name = "PnlLoadPermissions"
        Me.PnlLoadPermissions.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadPermissions.TabIndex = 49
        '
        'UcucLoadPermissionCollectionAdvance
        '
        Me.UcucLoadPermissionCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucLoadPermissionCollectionAdvance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcucLoadPermissionCollectionAdvance.Location = New System.Drawing.Point(0, 0)
        Me.UcucLoadPermissionCollectionAdvance.Name = "UcucLoadPermissionCollectionAdvance"
        Me.UcucLoadPermissionCollectionAdvance.Size = New System.Drawing.Size(993, 510)
        Me.UcucLoadPermissionCollectionAdvance.TabIndex = 0
        '
        'PnlLoadPermissionCancellation
        '
        Me.PnlLoadPermissionCancellation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLoadPermissionCancellation.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadPermissionCancellation.Border = True
        Me.PnlLoadPermissionCancellation.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlLoadPermissionCancellation.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlLoadPermissionCancellation.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlLoadPermissionCancellation.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlLoadPermissionCancellation.Controls.Add(Me.UcLoadPermissionCancellation)
        Me.PnlLoadPermissionCancellation.CornerRadius = 20
        Me.PnlLoadPermissionCancellation.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.PnlLoadPermissionCancellation.Gradient = True
        Me.PnlLoadPermissionCancellation.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlLoadPermissionCancellation.GradientOffset = 1.0!
        Me.PnlLoadPermissionCancellation.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlLoadPermissionCancellation.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlLoadPermissionCancellation.Grayscale = False
        Me.PnlLoadPermissionCancellation.Image = Nothing
        Me.PnlLoadPermissionCancellation.ImageAlpha = 75
        Me.PnlLoadPermissionCancellation.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlLoadPermissionCancellation.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlLoadPermissionCancellation.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlLoadPermissionCancellation.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadPermissionCancellation.Name = "PnlLoadPermissionCancellation"
        Me.PnlLoadPermissionCancellation.Rounded = True
        Me.PnlLoadPermissionCancellation.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadPermissionCancellation.TabIndex = 50
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlLoadPermissionCancellation
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlLoadPermissionCancellation
        '
        'UcLoadPermissionCancellation
        '
        Me.UcLoadPermissionCancellation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLoadPermissionCancellation.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadPermissionCancellation.Location = New System.Drawing.Point(7, 15)
        Me.UcLoadPermissionCancellation.Name = "UcLoadPermissionCancellation"
        Me.UcLoadPermissionCancellation.Size = New System.Drawing.Size(981, 346)
        Me.UcLoadPermissionCancellation.TabIndex = 0
        Me.UcLoadPermissionCancellation.UCBackColor = System.Drawing.Color.SkyBlue
        Me.UcLoadPermissionCancellation.UCBackColorDisable = System.Drawing.Color.Gray
        Me.UcLoadPermissionCancellation.UCNSSCurrent = Nothing
        '
        'FrmcLoadPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLoadPermissions)
        Me.Controls.Add(Me.PnlLoadPermissionCancellation)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadPermissions"
        Me.Text = "FrmcLoadPermissions"
        Me.Controls.SetChildIndex(Me.PnlLoadPermissionCancellation, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadPermissions, 0)
        Me.PnlLoadPermissions.ResumeLayout(False)
        Me.PnlLoadPermissionCancellation.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlLoadPermissions As Windows.Forms.Panel
    Friend WithEvents PnlLoadPermissionCancellation As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLoadPermissionCancellation As UCLoadPermissionCancellation
    Friend WithEvents UcucLoadPermissionCollectionAdvance As UCUCLoadPermissionCollectionAdvance
End Class
