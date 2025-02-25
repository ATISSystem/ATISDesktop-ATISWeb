Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadPermissionsIssued
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
        Me.PnlLoadPermissionIssued = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLoadPermissionIssued = New PayanehClassLibrary.UCLoadPermissionIssued()
        Me.PnlTurnCancellation = New System.Windows.Forms.Panel()
        Me.UcTurnsCancellation = New PayanehClassLibrary.UCTurnsCancellation()
        Me.PnlLoadPermissionIssued.SuspendLayout()
        Me.PnlTurnCancellation.SuspendLayout()
        Me.SuspendLayout()
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, -1000)
        '
        'PnlLoadPermissionIssued
        '
        Me.PnlLoadPermissionIssued.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLoadPermissionIssued.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadPermissionIssued.Border = True
        Me.PnlLoadPermissionIssued.BorderColor = System.Drawing.Color.Black
        Me.PnlLoadPermissionIssued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLoadPermissionIssued.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlLoadPermissionIssued.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlLoadPermissionIssued.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlLoadPermissionIssued.Controls.Add(Me.UcLoadPermissionIssued)
        Me.PnlLoadPermissionIssued.CornerRadius = 20
        Me.PnlLoadPermissionIssued.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
            Or BlueActivity.Controls.Corner.BottomLeft) _
            Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.PnlLoadPermissionIssued.Gradient = True
        Me.PnlLoadPermissionIssued.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlLoadPermissionIssued.GradientOffset = 1.0!
        Me.PnlLoadPermissionIssued.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlLoadPermissionIssued.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlLoadPermissionIssued.Grayscale = False
        Me.PnlLoadPermissionIssued.Image = Nothing
        Me.PnlLoadPermissionIssued.ImageAlpha = 75
        Me.PnlLoadPermissionIssued.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlLoadPermissionIssued.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlLoadPermissionIssued.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlLoadPermissionIssued.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadPermissionIssued.Name = "PnlLoadPermissionIssued"
        Me.PnlLoadPermissionIssued.Rounded = True
        Me.PnlLoadPermissionIssued.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadPermissionIssued.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlLoadPermissionIssued
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlLoadPermissionIssued
        '
        'UcLoadPermissionIssued
        '
        Me.UcLoadPermissionIssued.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLoadPermissionIssued.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadPermissionIssued.Location = New System.Drawing.Point(37, -1)
        Me.UcLoadPermissionIssued.Name = "UcLoadPermissionIssued"
        Me.UcLoadPermissionIssued.Size = New System.Drawing.Size(918, 479)
        Me.UcLoadPermissionIssued.TabIndex = 0
        Me.UcLoadPermissionIssued.UCViewTitle = False
        '
        'PnlTurnCancellation
        '
        Me.PnlTurnCancellation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlTurnCancellation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTurnCancellation.Controls.Add(Me.UcTurnsCancellation)
        Me.PnlTurnCancellation.Location = New System.Drawing.Point(5, 50)
        Me.PnlTurnCancellation.Name = "PnlTurnCancellation"
        Me.PnlTurnCancellation.Size = New System.Drawing.Size(995, 512)
        Me.PnlTurnCancellation.TabIndex = 50
        '
        'UcTurnsCancellation
        '
        Me.UcTurnsCancellation.BackColor = System.Drawing.Color.Transparent
        Me.UcTurnsCancellation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcTurnsCancellation.Location = New System.Drawing.Point(0, 0)
        Me.UcTurnsCancellation.Name = "UcTurnsCancellation"
        Me.UcTurnsCancellation.Size = New System.Drawing.Size(993, 510)
        Me.UcTurnsCancellation.TabIndex = 0
        Me.UcTurnsCancellation.UCViewTitle = True
        '
        'FrmcLoadPermissionsIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLoadPermissionIssued)
        Me.Controls.Add(Me.PnlTurnCancellation)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadPermissionsIssued"
        Me.Text = "FrmcLoadPermissionsIssuedOrderByPriorityReport"
        Me.Controls.SetChildIndex(Me.PnlTurnCancellation, 0)
        Me.Controls.SetChildIndex(Me.PnlLoadPermissionIssued, 0)
        Me.PnlLoadPermissionIssued.ResumeLayout(False)
        Me.PnlTurnCancellation.ResumeLayout(False)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlLoadPermissionIssued As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLoadPermissionIssued As UCLoadPermissionIssued
    Friend WithEvents PnlTurnCancellation As Windows.Forms.Panel
    Friend WithEvents UcTurnsCancellation As UCTurnsCancellation
End Class
