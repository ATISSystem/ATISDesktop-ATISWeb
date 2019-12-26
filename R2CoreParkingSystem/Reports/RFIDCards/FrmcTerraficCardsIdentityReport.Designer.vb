Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcTerraficCardsIdentityReport
    Inherits  FrmcGeneral

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
        Me.PnlTerraficCardsIdentity = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcTerraficCardsIdentity = New R2CoreParkingSystem.UCTerraficCardsIdentity()
        Me.PnlTerraficCardsIdentity.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(339, 178)
        '
        'PnlTerraficCardsIdentity
        '
        Me.PnlTerraficCardsIdentity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlTerraficCardsIdentity.BackColor = System.Drawing.Color.Transparent
        Me.PnlTerraficCardsIdentity.Border = true
        Me.PnlTerraficCardsIdentity.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlTerraficCardsIdentity.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlTerraficCardsIdentity.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlTerraficCardsIdentity.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlTerraficCardsIdentity.Controls.Add(Me.UcTerraficCardsIdentity)
        Me.PnlTerraficCardsIdentity.CornerRadius = 20
        Me.PnlTerraficCardsIdentity.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlTerraficCardsIdentity.Gradient = true
        Me.PnlTerraficCardsIdentity.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlTerraficCardsIdentity.GradientOffset = 1!
        Me.PnlTerraficCardsIdentity.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlTerraficCardsIdentity.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlTerraficCardsIdentity.Grayscale = false
        Me.PnlTerraficCardsIdentity.Image = Nothing
        Me.PnlTerraficCardsIdentity.ImageAlpha = 75
        Me.PnlTerraficCardsIdentity.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlTerraficCardsIdentity.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlTerraficCardsIdentity.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlTerraficCardsIdentity.Location = New System.Drawing.Point(5, 50)
        Me.PnlTerraficCardsIdentity.Name = "PnlTerraficCardsIdentity"
        Me.PnlTerraficCardsIdentity.Rounded = true
        Me.PnlTerraficCardsIdentity.Size = New System.Drawing.Size(995, 512)
        Me.PnlTerraficCardsIdentity.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlTerraficCardsIdentity
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlTerraficCardsIdentity
        '
        'UcTerraficCardsIdentity
        '
        Me.UcTerraficCardsIdentity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcTerraficCardsIdentity.BackColor = System.Drawing.Color.Transparent
        Me.UcTerraficCardsIdentity.Location = New System.Drawing.Point(336, 61)
        Me.UcTerraficCardsIdentity.Name = "UcTerraficCardsIdentity"
        Me.UcTerraficCardsIdentity.Padding = New System.Windows.Forms.Padding(10)
        Me.UcTerraficCardsIdentity.Size = New System.Drawing.Size(322, 258)
        Me.UcTerraficCardsIdentity.TabIndex = 0
        Me.UcTerraficCardsIdentity.UCViewTitle = false
        '
        'FrmcTerraficCardsIdentityReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlTerraficCardsIdentity)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcTerraficCardsIdentityReport"
        Me.Text = "FrmcTerraficCardsIdentityReport"
        Me.Controls.SetChildIndex(Me.PnlTerraficCardsIdentity, 0)
        Me.PnlTerraficCardsIdentity.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlTerraficCardsIdentity As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcTerraficCardsIdentity As UCTerraficCardsIdentity
End Class
