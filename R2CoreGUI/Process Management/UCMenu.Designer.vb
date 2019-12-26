<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMenu
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
        Me.PnlInner = New System.Windows.Forms.Panel()
        Me.CButton = New CButtonLib.CButton()
        Me.PnlMain.SuspendLayout
        Me.PnlInner.SuspendLayout
        Me.SuspendLayout
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.Controls.Add(Me.PnlInner)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 5)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(96, 36)
        Me.PnlMain.TabIndex = 0
        '
        'PnlInner
        '
        Me.PnlInner.BackColor = System.Drawing.Color.Transparent
        Me.PnlInner.Controls.Add(Me.CButton)
        Me.PnlInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInner.Location = New System.Drawing.Point(0, 0)
        Me.PnlInner.Name = "PnlInner"
        Me.PnlInner.Size = New System.Drawing.Size(96, 36)
        Me.PnlInner.TabIndex = 1
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.DodgerBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CButton.Corners.LowerLeft = 16
        Me.CButton.Corners.UpperRight = 16
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = true
        Me.CButton.DimFactorHover = 55
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.CButton.FocalPoints.CenterPtX = 0!
        Me.CButton.FocalPoints.CenterPtY = 0!
        Me.CButton.Font = New System.Drawing.Font("B Homa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButton.ForeColor = System.Drawing.Color.Black
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(0, 0)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(96, 36)
        Me.CButton.TabIndex = 4
        Me.CButton.Text = "اطلاعات پایانه"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.DarkRed
        Me.CButton.TextShadowShow = false
        Me.CButton.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'UCMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCMenu"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(106, 46)
        Me.PnlMain.ResumeLayout(false)
        Me.PnlInner.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents PnlInner As Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
