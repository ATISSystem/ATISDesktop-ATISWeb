Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcClientConfigurations
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
        Me.PnlClientConfigurationOfR2Core = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfComputersOfCore1 = New R2CoreGUI.UCConfigurationOfComputersOfCore()
        Me.PnlClientConfigurationOfR2CoreParkingSystem = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcConfigurationOfComputersOfParkingCore = New R2CoreParkingSystem.UCConfigurationOfComputersOfParkingCore()
        Me.PnlClientConfigurationOfR2Core.SuspendLayout
        Me.PnlClientConfigurationOfR2CoreParkingSystem.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(171, 178)
        '
        'PnlClientConfigurationOfR2Core
        '
        Me.PnlClientConfigurationOfR2Core.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlClientConfigurationOfR2Core.BackColor = System.Drawing.Color.Transparent
        Me.PnlClientConfigurationOfR2Core.Border = true
        Me.PnlClientConfigurationOfR2Core.BorderColor = System.Drawing.Color.Black
        Me.PnlClientConfigurationOfR2Core.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlClientConfigurationOfR2Core.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlClientConfigurationOfR2Core.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlClientConfigurationOfR2Core.Controls.Add(Me.UcConfigurationOfComputersOfCore1)
        Me.PnlClientConfigurationOfR2Core.CornerRadius = 20
        Me.PnlClientConfigurationOfR2Core.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlClientConfigurationOfR2Core.Gradient = true
        Me.PnlClientConfigurationOfR2Core.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlClientConfigurationOfR2Core.GradientOffset = 1!
        Me.PnlClientConfigurationOfR2Core.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlClientConfigurationOfR2Core.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlClientConfigurationOfR2Core.Grayscale = false
        Me.PnlClientConfigurationOfR2Core.Image = Nothing
        Me.PnlClientConfigurationOfR2Core.ImageAlpha = 75
        Me.PnlClientConfigurationOfR2Core.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlClientConfigurationOfR2Core.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlClientConfigurationOfR2Core.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlClientConfigurationOfR2Core.Location = New System.Drawing.Point(5, 50)
        Me.PnlClientConfigurationOfR2Core.Name = "PnlClientConfigurationOfR2Core"
        Me.PnlClientConfigurationOfR2Core.Rounded = true
        Me.PnlClientConfigurationOfR2Core.Size = New System.Drawing.Size(995, 512)
        Me.PnlClientConfigurationOfR2Core.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlClientConfigurationOfR2Core
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlClientConfigurationOfR2Core
        '
        'UcConfigurationOfComputersOfCore1
        '
        Me.UcConfigurationOfComputersOfCore1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfComputersOfCore1.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfComputersOfCore1.Location = New System.Drawing.Point(2, -1)
        Me.UcConfigurationOfComputersOfCore1.Name = "UcConfigurationOfComputersOfCore1"
        Me.UcConfigurationOfComputersOfCore1.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfComputersOfCore1.Size = New System.Drawing.Size(990, 498)
        Me.UcConfigurationOfComputersOfCore1.TabIndex = 0
        Me.UcConfigurationOfComputersOfCore1.UCTitle = ""
        Me.UcConfigurationOfComputersOfCore1.UCViewTitle = false
        '
        'PnlClientConfigurationOfR2CoreParkingSystem
        '
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.BackColor = System.Drawing.Color.Transparent
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Border = true
        Me.PnlClientConfigurationOfR2CoreParkingSystem.BorderColor = System.Drawing.Color.Black
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Colors.Add(Me.ColorWithAlpha3)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Colors.Add(Me.ColorWithAlpha4)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Controls.Add(Me.UcConfigurationOfComputersOfParkingCore)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.CornerRadius = 20
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Gradient = true
        Me.PnlClientConfigurationOfR2CoreParkingSystem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlClientConfigurationOfR2CoreParkingSystem.GradientOffset = 1!
        Me.PnlClientConfigurationOfR2CoreParkingSystem.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Grayscale = false
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Image = Nothing
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ImageAlpha = 75
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Location = New System.Drawing.Point(5, 50)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Name = "PnlClientConfigurationOfR2CoreParkingSystem"
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Rounded = true
        Me.PnlClientConfigurationOfR2CoreParkingSystem.Size = New System.Drawing.Size(995, 512)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.TabIndex = 50
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha3.Parent = Me.PnlClientConfigurationOfR2CoreParkingSystem
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha4.Parent = Me.PnlClientConfigurationOfR2CoreParkingSystem
        '
        'UcConfigurationOfComputersOfParkingCore
        '
        Me.UcConfigurationOfComputersOfParkingCore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.UcConfigurationOfComputersOfParkingCore.BackColor = System.Drawing.Color.Transparent
        Me.UcConfigurationOfComputersOfParkingCore.Location = New System.Drawing.Point(-2, -1)
        Me.UcConfigurationOfComputersOfParkingCore.Name = "UcConfigurationOfComputersOfParkingCore"
        Me.UcConfigurationOfComputersOfParkingCore.Padding = New System.Windows.Forms.Padding(2)
        Me.UcConfigurationOfComputersOfParkingCore.Size = New System.Drawing.Size(990, 417)
        Me.UcConfigurationOfComputersOfParkingCore.TabIndex = 0
        Me.UcConfigurationOfComputersOfParkingCore.UCTitle = ""
        Me.UcConfigurationOfComputersOfParkingCore.UCViewTitle = false
        '
        'FrmcClientConfigurations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlClientConfigurationOfR2Core)
        Me.Controls.Add(Me.PnlClientConfigurationOfR2CoreParkingSystem)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcClientConfigurations"
        Me.Text = "FrmcClientConfigurations"
        Me.Controls.SetChildIndex(Me.PnlClientConfigurationOfR2CoreParkingSystem, 0)
        Me.Controls.SetChildIndex(Me.PnlClientConfigurationOfR2Core, 0)
        Me.PnlClientConfigurationOfR2Core.ResumeLayout(false)
        Me.PnlClientConfigurationOfR2CoreParkingSystem.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlClientConfigurationOfR2Core As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfComputersOfCore1 As UCConfigurationOfComputersOfCore
    Friend WithEvents PnlClientConfigurationOfR2CoreParkingSystem As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcConfigurationOfComputersOfParkingCore As R2CoreParkingSystem.UCConfigurationOfComputersOfParkingCore
End Class
