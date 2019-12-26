﻿Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcCarEntranceReport
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
        Me.PnlViewReport = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcCarEntranceReport = New R2CoreParkingSystem.UCCarEntranceReport()
        Me.PnlViewReport.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(288, 137)
        '
        'PnlViewReport
        '
        Me.PnlViewReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlViewReport.BackColor = System.Drawing.Color.Transparent
        Me.PnlViewReport.Border = true
        Me.PnlViewReport.BorderColor = System.Drawing.Color.Black
        Me.PnlViewReport.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlViewReport.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlViewReport.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlViewReport.Controls.Add(Me.UcCarEntranceReport)
        Me.PnlViewReport.CornerRadius = 20
        Me.PnlViewReport.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlViewReport.Gradient = true
        Me.PnlViewReport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlViewReport.GradientOffset = 1!
        Me.PnlViewReport.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlViewReport.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlViewReport.Grayscale = false
        Me.PnlViewReport.Image = Nothing
        Me.PnlViewReport.ImageAlpha = 75
        Me.PnlViewReport.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlViewReport.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlViewReport.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlViewReport.Location = New System.Drawing.Point(5, 50)
        Me.PnlViewReport.Name = "PnlViewReport"
        Me.PnlViewReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PnlViewReport.Rounded = true
        Me.PnlViewReport.Size = New System.Drawing.Size(995, 512)
        Me.PnlViewReport.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlViewReport
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlViewReport
        '
        'UcCarEntranceReport
        '
        Me.UcCarEntranceReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcCarEntranceReport.BackColor = System.Drawing.Color.Transparent
        Me.UcCarEntranceReport.Location = New System.Drawing.Point(199, 12)
        Me.UcCarEntranceReport.Name = "UcCarEntranceReport"
        Me.UcCarEntranceReport.Size = New System.Drawing.Size(597, 494)
        Me.UcCarEntranceReport.TabIndex = 0
        Me.UcCarEntranceReport.UCViewTitle = false
        '
        'FrmcCarEntranceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlViewReport)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcCarEntranceReport"
        Me.Text = "FrmcCarEntranceReport"
        Me.Controls.SetChildIndex(Me.PnlViewReport, 0)
        Me.PnlViewReport.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlViewReport As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcCarEntranceReport As UCCarEntranceReport
End Class