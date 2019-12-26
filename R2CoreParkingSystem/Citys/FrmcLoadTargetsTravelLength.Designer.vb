Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcLoadTargetsTravelLength
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
        Me.PnlLoadTargetsAndTravelLength = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcLoadTargetTravelLength = New R2CoreParkingSystem.UCLoadTargetTravelLength()
        Me.PnlLoadTargetsAndTravelLength.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(171, 178)
        '
        'PnlLoadTargetsAndTravelLength
        '
        Me.PnlLoadTargetsAndTravelLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlLoadTargetsAndTravelLength.BackColor = System.Drawing.Color.Transparent
        Me.PnlLoadTargetsAndTravelLength.Border = true
        Me.PnlLoadTargetsAndTravelLength.BorderColor = System.Drawing.Color.Black
        Me.PnlLoadTargetsAndTravelLength.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlLoadTargetsAndTravelLength.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlLoadTargetsAndTravelLength.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlLoadTargetsAndTravelLength.Controls.Add(Me.UcLoadTargetTravelLength)
        Me.PnlLoadTargetsAndTravelLength.CornerRadius = 20
        Me.PnlLoadTargetsAndTravelLength.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlLoadTargetsAndTravelLength.Gradient = false
        Me.PnlLoadTargetsAndTravelLength.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlLoadTargetsAndTravelLength.GradientOffset = 1!
        Me.PnlLoadTargetsAndTravelLength.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlLoadTargetsAndTravelLength.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlLoadTargetsAndTravelLength.Grayscale = false
        Me.PnlLoadTargetsAndTravelLength.Image = Nothing
        Me.PnlLoadTargetsAndTravelLength.ImageAlpha = 75
        Me.PnlLoadTargetsAndTravelLength.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlLoadTargetsAndTravelLength.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlLoadTargetsAndTravelLength.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlLoadTargetsAndTravelLength.Location = New System.Drawing.Point(5, 50)
        Me.PnlLoadTargetsAndTravelLength.Name = "PnlLoadTargetsAndTravelLength"
        Me.PnlLoadTargetsAndTravelLength.Rounded = true
        Me.PnlLoadTargetsAndTravelLength.Size = New System.Drawing.Size(995, 512)
        Me.PnlLoadTargetsAndTravelLength.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlLoadTargetsAndTravelLength
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlLoadTargetsAndTravelLength
        '
        'UcLoadTargetTravelLength
        '
        Me.UcLoadTargetTravelLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom),System.Windows.Forms.AnchorStyles)
        Me.UcLoadTargetTravelLength.BackColor = System.Drawing.Color.Transparent
        Me.UcLoadTargetTravelLength.Location = New System.Drawing.Point(269, -57)
        Me.UcLoadTargetTravelLength.Name = "UcLoadTargetTravelLength"
        Me.UcLoadTargetTravelLength.Padding = New System.Windows.Forms.Padding(5)
        Me.UcLoadTargetTravelLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcLoadTargetTravelLength.Size = New System.Drawing.Size(459, 567)
        Me.UcLoadTargetTravelLength.TabIndex = 0
        Me.UcLoadTargetTravelLength.UCViewTitle = false
        '
        'FrmcLoadTargetsTravelLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlLoadTargetsAndTravelLength)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcLoadTargetsTravelLength"
        Me.Text = "FrmcLoadTargetsTravelLength"
        Me.Controls.SetChildIndex(Me.PnlLoadTargetsAndTravelLength, 0)
        Me.PnlLoadTargetsAndTravelLength.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlLoadTargetsAndTravelLength As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcLoadTargetTravelLength As UCLoadTargetTravelLength
End Class
