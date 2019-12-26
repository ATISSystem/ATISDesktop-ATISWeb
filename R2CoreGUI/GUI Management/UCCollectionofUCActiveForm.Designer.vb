<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCollectionofUCActiveForm
    Inherits System.Windows.Forms.UserControl

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
        Me.CButtonMainMenuRefrence = New CButtonLib.CButton()
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PnlMain.Location = New System.Drawing.Point(0, 3)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(269, 23)
        Me.PnlMain.TabIndex = 0
        '
        'CButtonMainMenuRefrence
        '
        Me.CButtonMainMenuRefrence.BorderColor = System.Drawing.Color.MidnightBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))}
        CBlendItems1.iPoint = New Single() {0!, 0.1208791!, 0.4322344!, 0.5494506!, 1!}
        Me.CButtonMainMenuRefrence.ColorFillBlend = CBlendItems1
        Me.CButtonMainMenuRefrence.ColorFillSolid = System.Drawing.Color.SandyBrown
        Me.CButtonMainMenuRefrence.Corners.LowerLeft = 10
        Me.CButtonMainMenuRefrence.Corners.LowerRight = 10
        Me.CButtonMainMenuRefrence.DesignerSelected = true
        Me.CButtonMainMenuRefrence.Dock = System.Windows.Forms.DockStyle.Right
        Me.CButtonMainMenuRefrence.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CButtonMainMenuRefrence.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButtonMainMenuRefrence.ForeColor = System.Drawing.Color.Navy
        Me.CButtonMainMenuRefrence.ImageIndex = 0
        Me.CButtonMainMenuRefrence.Location = New System.Drawing.Point(275, 3)
        Me.CButtonMainMenuRefrence.Name = "CButtonMainMenuRefrence"
        Me.CButtonMainMenuRefrence.Size = New System.Drawing.Size(71, 22)
        Me.CButtonMainMenuRefrence.TabIndex = 6
        Me.CButtonMainMenuRefrence.Text = "منوی اصلی"
        Me.CButtonMainMenuRefrence.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButtonMainMenuRefrence.TextShadow = System.Drawing.Color.LightSteelBlue
        Me.CButtonMainMenuRefrence.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'UCCollectionofUCActiveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CButtonMainMenuRefrence)
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCCollectionofUCActiveForm"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(349, 28)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents CButtonMainMenuRefrence As CButtonLib.CButton
End Class
