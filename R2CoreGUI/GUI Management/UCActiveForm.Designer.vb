<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCActiveForm
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
        Me.CButton = New CButtonLib.CButton()
        Me.SuspendLayout
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.MidnightBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.Red}
        CBlendItems1.iPoint = New Single() {0!, -0.00308642!, 0.9969136!, 1!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.Red
        Me.CButton.Corners.LowerLeft = 10
        Me.CButton.Corners.LowerRight = 10
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = true
        Me.CButton.DimFactorHover = 0
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CButton.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(2, 2)
        Me.CButton.Name = "CButton"
        Me.CButton.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton.Size = New System.Drawing.Size(114, 21)
        Me.CButton.TabIndex = 8
        Me.CButton.Text = "اطلاعات پایه"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.LightSteelBlue
        Me.CButton.TextShadowShow = false
        '
        'UCActiveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UCActiveForm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Size = New System.Drawing.Size(118, 25)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CButton As CButtonLib.CButton
End Class
