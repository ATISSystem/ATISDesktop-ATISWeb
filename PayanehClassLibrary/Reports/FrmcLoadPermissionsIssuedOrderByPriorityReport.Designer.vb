Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadPermissionsIssuedOrderByPriorityReport
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
        Me.PnlReport = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLoadPermissionIssuedOrderByPriority = New PayanehClassLibrary.UCLoadPermissionIssuedOrderByPriority()
        Me.PnlReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(339, 178)
        '
        'PnlReport
        '
        Me.PnlReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlReport.Border = true
        Me.PnlReport.BorderColor = System.Drawing.Color.Black
        Me.PnlReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlReport.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlReport.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlReport.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlReport.Controls.Add(Me.UcLoadPermissionIssuedOrderByPriority)
        Me.PnlReport.CornerRadius = 20
        Me.PnlReport.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlReport.Gradient = true
        Me.PnlReport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlReport.GradientOffset = 1!
        Me.PnlReport.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlReport.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlReport.Grayscale = false
        Me.PnlReport.Image = Nothing
        Me.PnlReport.ImageAlpha = 75
        Me.PnlReport.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlReport.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlReport.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlReport.Name = "PnlReport"
        Me.PnlReport.Rounded = true
        Me.PnlReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlReport.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlReport
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlReport
        '
        'UcLoadPermissionIssuedOrderByPriority
        '
        Me.UcLoadPermissionIssuedOrderByPriority.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcLoadPermissionIssuedOrderByPriority.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadPermissionIssuedOrderByPriority.Location = New System.Drawing.Point(37, 67)
        Me.UcLoadPermissionIssuedOrderByPriority.Name = "UcLoadPermissionIssuedOrderByPriority"
        Me.UcLoadPermissionIssuedOrderByPriority.Size = New System.Drawing.Size(918, 367)
        Me.UcLoadPermissionIssuedOrderByPriority.TabIndex = 0
        Me.UcLoadPermissionIssuedOrderByPriority.UCViewTitle = false
        '
        'FrmcLoadPermissionsIssuedOrderByPriorityReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadPermissionsIssuedOrderByPriorityReport"
        Me.Text = "FrmcLoadPermissionsIssuedOrderByPriorityReport"
        Me.Controls.SetChildIndex(Me.PnlReport, 0)
        Me.PnlReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlReport As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLoadPermissionIssuedOrderByPriority As UCLoadPermissionIssuedOrderByPriority
End Class
