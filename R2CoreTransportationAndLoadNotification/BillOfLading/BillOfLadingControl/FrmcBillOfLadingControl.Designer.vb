Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcBillOfLadingControl
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
        Me.PnlBillOfLadingControl = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcManipulationBillOfLadingControl = New R2CoreTransportationAndLoadNotification.UCManipulationBillOfLadingControl()
        Me.UcCreatorBillOfLadingControl = New R2CoreTransportationAndLoadNotification.UCCreatorBillOfLadingControl()
        Me.UcucBillOfLadingControlCollectionAdvance = New R2CoreTransportationAndLoadNotification.UCUCBillOfLadingControlCollectionAdvance()
        Me.PnlInfractions = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlBillOfLadingControl.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(-1000, 178)
        '
        'PnlBillOfLadingControl
        '
        Me.PnlBillOfLadingControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlBillOfLadingControl.BackColor = System.Drawing.Color.Transparent
        Me.PnlBillOfLadingControl.Border = true
        Me.PnlBillOfLadingControl.BorderColor = System.Drawing.Color.Black
        Me.PnlBillOfLadingControl.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlBillOfLadingControl.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlBillOfLadingControl.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlBillOfLadingControl.Controls.Add(Me.UcManipulationBillOfLadingControl)
        Me.PnlBillOfLadingControl.Controls.Add(Me.UcCreatorBillOfLadingControl)
        Me.PnlBillOfLadingControl.Controls.Add(Me.UcucBillOfLadingControlCollectionAdvance)
        Me.PnlBillOfLadingControl.CornerRadius = 20
        Me.PnlBillOfLadingControl.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlBillOfLadingControl.Gradient = true
        Me.PnlBillOfLadingControl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlBillOfLadingControl.GradientOffset = 1!
        Me.PnlBillOfLadingControl.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlBillOfLadingControl.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlBillOfLadingControl.Grayscale = false
        Me.PnlBillOfLadingControl.Image = Nothing
        Me.PnlBillOfLadingControl.ImageAlpha = 75
        Me.PnlBillOfLadingControl.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlBillOfLadingControl.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlBillOfLadingControl.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlBillOfLadingControl.Location = New System.Drawing.Point(5, 50)
        Me.PnlBillOfLadingControl.Name = "PnlBillOfLadingControl"
        Me.PnlBillOfLadingControl.Rounded = true
        Me.PnlBillOfLadingControl.Size = New System.Drawing.Size(995, 512)
        Me.PnlBillOfLadingControl.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlBillOfLadingControl
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlBillOfLadingControl
        '
        'UcManipulationBillOfLadingControl
        '
        Me.UcManipulationBillOfLadingControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcManipulationBillOfLadingControl.BackColor = System.Drawing.Color.Transparent
        Me.UcManipulationBillOfLadingControl.Location = New System.Drawing.Point(57, 308)
        Me.UcManipulationBillOfLadingControl.Name = "UcManipulationBillOfLadingControl"
        Me.UcManipulationBillOfLadingControl.Size = New System.Drawing.Size(553, 116)
        Me.UcManipulationBillOfLadingControl.TabIndex = 2
        Me.UcManipulationBillOfLadingControl.UCNSSCurrent = Nothing
        '
        'UcCreatorBillOfLadingControl
        '
        Me.UcCreatorBillOfLadingControl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcCreatorBillOfLadingControl.BackColor = System.Drawing.Color.Transparent
        Me.UcCreatorBillOfLadingControl.Location = New System.Drawing.Point(57, 93)
        Me.UcCreatorBillOfLadingControl.Name = "UcCreatorBillOfLadingControl"
        Me.UcCreatorBillOfLadingControl.Size = New System.Drawing.Size(553, 209)
        Me.UcCreatorBillOfLadingControl.TabIndex = 1
        '
        'UcucBillOfLadingControlCollectionAdvance
        '
        Me.UcucBillOfLadingControlCollectionAdvance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcucBillOfLadingControlCollectionAdvance.BackColor = System.Drawing.Color.Transparent
        Me.UcucBillOfLadingControlCollectionAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcucBillOfLadingControlCollectionAdvance.Location = New System.Drawing.Point(628, 93)
        Me.UcucBillOfLadingControlCollectionAdvance.Name = "UcucBillOfLadingControlCollectionAdvance"
        Me.UcucBillOfLadingControlCollectionAdvance.Size = New System.Drawing.Size(317, 331)
        Me.UcucBillOfLadingControlCollectionAdvance.TabIndex = 0
        '
        'PnlInfractions
        '
        Me.PnlInfractions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlInfractions.BackColor = System.Drawing.Color.Transparent
        Me.PnlInfractions.Border = true
        Me.PnlInfractions.BorderColor = System.Drawing.Color.Black
        Me.PnlInfractions.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlInfractions.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlInfractions.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlInfractions.CornerRadius = 20
        Me.PnlInfractions.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlInfractions.Gradient = true
        Me.PnlInfractions.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlInfractions.GradientOffset = 1!
        Me.PnlInfractions.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlInfractions.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlInfractions.Grayscale = false
        Me.PnlInfractions.Image = Nothing
        Me.PnlInfractions.ImageAlpha = 75
        Me.PnlInfractions.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlInfractions.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlInfractions.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlInfractions.Location = New System.Drawing.Point(5, 50)
        Me.PnlInfractions.Name = "PnlInfractions"
        Me.PnlInfractions.Rounded = true
        Me.PnlInfractions.Size = New System.Drawing.Size(995, 512)
        Me.PnlInfractions.TabIndex = 50
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlInfractions
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlInfractions
        '
        'FrmcBillOfLadingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlBillOfLadingControl)
        Me.Controls.Add(Me.PnlInfractions)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcBillOfLadingControl"
        Me.Text = "FrmcBillOfLadingControl"
        Me.Controls.SetChildIndex(Me.PnlInfractions, 0)
        Me.Controls.SetChildIndex(Me.PnlBillOfLadingControl, 0)
        Me.PnlBillOfLadingControl.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlBillOfLadingControl As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlInfractions As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcManipulationBillOfLadingControl As UCManipulationBillOfLadingControl
    Friend WithEvents UcCreatorBillOfLadingControl As UCCreatorBillOfLadingControl
    Friend WithEvents UcucBillOfLadingControlCollectionAdvance As UCUCBillOfLadingControlCollectionAdvance
End Class
