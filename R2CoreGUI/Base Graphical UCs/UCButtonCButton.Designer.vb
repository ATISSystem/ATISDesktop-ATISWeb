<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCButtonCButton
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
        Me.CButton = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.DodgerBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CButton.Corners.LowerLeft = 16
        Me.CButton.Corners.UpperRight = 16
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = False
        Me.CButton.DimFactorHover = 55
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.CButton.FocalPoints.CenterPtX = 0!
        Me.CButton.FocalPoints.CenterPtY = 0!
        Me.CButton.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButton.ForeColor = System.Drawing.Color.Black
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(0, 0)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(122, 37)
        Me.CButton.TabIndex = 5
        Me.CButton.Text = "اطلاعات پایانه"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.DarkRed
        Me.CButton.TextShadowShow = False
        Me.CButton.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'UCButtonCButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CButton)
        Me.Name = "UCButtonCButton"
        Me.Size = New System.Drawing.Size(122, 37)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CButton As CButtonLib.CButton
End Class
