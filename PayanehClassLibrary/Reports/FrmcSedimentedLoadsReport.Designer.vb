Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcSedimentedLoadsReport
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
        Me.PnlSedimentedLoadsReport = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcSedimentedLoadsReport = New PayanehClassLibrary.UCSedimentedLoadsReport()
        Me.PnlSedimentedLoadsReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(339, 178)
        '
        'PnlSedimentedLoadsReport
        '
        Me.PnlSedimentedLoadsReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlSedimentedLoadsReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlSedimentedLoadsReport.Border = true
        Me.PnlSedimentedLoadsReport.BorderColor = System.Drawing.Color.Black
        Me.PnlSedimentedLoadsReport.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlSedimentedLoadsReport.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlSedimentedLoadsReport.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlSedimentedLoadsReport.Controls.Add(Me.UcSedimentedLoadsReport)
        Me.PnlSedimentedLoadsReport.CornerRadius = 20
        Me.PnlSedimentedLoadsReport.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlSedimentedLoadsReport.Gradient = true
        Me.PnlSedimentedLoadsReport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlSedimentedLoadsReport.GradientOffset = 1!
        Me.PnlSedimentedLoadsReport.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlSedimentedLoadsReport.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlSedimentedLoadsReport.Grayscale = false
        Me.PnlSedimentedLoadsReport.Image = Nothing
        Me.PnlSedimentedLoadsReport.ImageAlpha = 75
        Me.PnlSedimentedLoadsReport.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlSedimentedLoadsReport.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlSedimentedLoadsReport.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlSedimentedLoadsReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlSedimentedLoadsReport.Name = "PnlSedimentedLoadsReport"
        Me.PnlSedimentedLoadsReport.Rounded = true
        Me.PnlSedimentedLoadsReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlSedimentedLoadsReport.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlSedimentedLoadsReport
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlSedimentedLoadsReport
        '
        'UcSedimentedLoadsReport
        '
        Me.UcSedimentedLoadsReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcSedimentedLoadsReport.BackColor = System.Drawing.Color.Transparent
        Me.UcSedimentedLoadsReport.Location = New System.Drawing.Point(86, 36)
        Me.UcSedimentedLoadsReport.Name = "UcSedimentedLoadsReport"
        Me.UcSedimentedLoadsReport.Size = New System.Drawing.Size(823, 396)
        Me.UcSedimentedLoadsReport.TabIndex = 0
        Me.UcSedimentedLoadsReport.UCViewTitle = false
        '
        'FrmcSedimentedLoadsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlSedimentedLoadsReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcSedimentedLoadsReport"
        Me.Text = "FrmcSedimentedLoadsReport"
        Me.Controls.SetChildIndex(Me.PnlSedimentedLoadsReport, 0)
        Me.PnlSedimentedLoadsReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlSedimentedLoadsReport As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcSedimentedLoadsReport As UCSedimentedLoadsReport
End Class
