Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcBlackListReport
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
        Me.PnlBlackList = New BlueActivity.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.UcBlackListReport1 = New R2CoreParkingSystem.UCBlackListReport()
        Me.PnlBlackList.SuspendLayout
        Me.SuspendLayout
        '
        '_FrmMessageDialog
        '
        Me._FrmMessageDialog.Location = New System.Drawing.Point(339, 178)
        '
        'PnlBlackList
        '
        Me.PnlBlackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlBlackList.BackColor = System.Drawing.Color.Transparent
        Me.PnlBlackList.Border = true
        Me.PnlBlackList.BorderColor = System.Drawing.Color.Black
        Me.PnlBlackList.Colors.Add(Me.ColorWithAlpha1)
        Me.PnlBlackList.Colors.Add(Me.ColorWithAlpha2)
        Me.PnlBlackList.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.PnlBlackList.Controls.Add(Me.UcBlackListReport1)
        Me.PnlBlackList.CornerRadius = 20
        Me.PnlBlackList.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight)  _
            Or BlueActivity.Controls.Corner.BottomLeft)  _
            Or BlueActivity.Controls.Corner.BottomRight),BlueActivity.Controls.Corner)
        Me.PnlBlackList.Gradient = true
        Me.PnlBlackList.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PnlBlackList.GradientOffset = 1!
        Me.PnlBlackList.GradientSize = New System.Drawing.Size(0, 0)
        Me.PnlBlackList.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.PnlBlackList.Grayscale = false
        Me.PnlBlackList.Image = Nothing
        Me.PnlBlackList.ImageAlpha = 75
        Me.PnlBlackList.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.PnlBlackList.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.PnlBlackList.ImageSize = New System.Drawing.Size(48, 48)
        Me.PnlBlackList.Location = New System.Drawing.Point(5, 50)
        Me.PnlBlackList.Name = "PnlBlackList"
        Me.PnlBlackList.Rounded = true
        Me.PnlBlackList.Size = New System.Drawing.Size(995, 512)
        Me.PnlBlackList.TabIndex = 49
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha1.Parent = Me.PnlBlackList
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Transparent
        Me.ColorWithAlpha2.Parent = Me.PnlBlackList
        '
        'UcBlackListReport1
        '
        Me.UcBlackListReport1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UcBlackListReport1.BackColor = System.Drawing.Color.Transparent
        Me.UcBlackListReport1.Location = New System.Drawing.Point(345, 49)
        Me.UcBlackListReport1.Name = "UcBlackListReport1"
        Me.UcBlackListReport1.Padding = New System.Windows.Forms.Padding(10)
        Me.UcBlackListReport1.Size = New System.Drawing.Size(304, 295)
        Me.UcBlackListReport1.TabIndex = 0
        Me.UcBlackListReport1.UCViewTitle = false
        '
        'FrmcBlackListReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.Controls.Add(Me.PnlBlackList)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmcBlackListReport"
        Me.Text = "FrmcBlackListReport"
        Me.Controls.SetChildIndex(Me.PnlBlackList, 0)
        Me.PnlBlackList.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlBlackList As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents UcBlackListReport1 As UCBlackListReport
End Class
