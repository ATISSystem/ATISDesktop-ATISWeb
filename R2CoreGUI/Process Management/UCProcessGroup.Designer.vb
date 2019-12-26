<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProcessGroup
    Inherits UCGeneral

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlOutter = New System.Windows.Forms.Panel()
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CButton = New CButtonLib.CButton()
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha()
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha()
        Me.PnlMain.SuspendLayout
        Me.PnlOutter.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Controls.Add(Me.PnlOutter)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.ForeColor = System.Drawing.Color.Black
        Me.PnlMain.Location = New System.Drawing.Point(10, 10)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(268, 46)
        Me.PnlMain.TabIndex = 0
        '
        'PnlOutter
        '
        Me.PnlOutter.BackColor = System.Drawing.Color.Transparent
        Me.PnlOutter.Controls.Add(Me.PnlInner)
        Me.PnlOutter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOutter.Location = New System.Drawing.Point(0, 0)
        Me.PnlOutter.Name = "PnlOutter"
        Me.PnlOutter.Size = New System.Drawing.Size(268, 46)
        Me.PnlOutter.TabIndex = 2
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.Transparent
        Me.PnlInner.Controls.Add(Me.CButton)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(0, 0)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(268, 46)
        Me.PnlInner.TabIndex = 1
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.Black
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Red}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.SandyBrown
        Me.CButton.Corners.All = 10
        Me.CButton.Corners.LowerLeft = 10
        Me.CButton.Corners.LowerRight = 10
        Me.CButton.Corners.UpperLeft = 10
        Me.CButton.Corners.UpperRight = 10
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = true
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.CButton.Font = New System.Drawing.Font("B Homa", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(0, 0)
        Me.CButton.Name = "CButton"
        Me.CButton.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton.Size = New System.Drawing.Size(268, 46)
        Me.CButton.TabIndex = 6
        Me.CButton.Text = "اطلاعات پایه"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.LightSteelBlue
        Me.CButton.TextShadowShow = false
        Me.CButton.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Silver
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.LightGray
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'UCProcessGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCProcessGroup"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(288, 66)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlOutter.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents PnlOutter As Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
