<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSTransportComapny
     Inherits UCTransportCompany



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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CButton = New CButtonLib.CButton()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(139, 31)
        Me.Panel1.TabIndex = 0
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.DodgerBlue
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0!, 1!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.White
        Me.CButton.Corners.LowerLeft = 13
        Me.CButton.Corners.UpperRight = 13
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = true
        Me.CButton.DimFactorHover = 55
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton.FocalPoints.CenterPtX = 0!
        Me.CButton.FocalPoints.CenterPtY = 0!
        Me.CButton.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.CButton.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(2, 2)
        Me.CButton.Name = "CButton"
        Me.CButton.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton.Size = New System.Drawing.Size(135, 27)
        Me.CButton.TabIndex = 6
        Me.CButton.Text = "تفنگساز"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.DarkRed
        Me.CButton.TextShadowShow = false
        '
        'UCViewerNSSTransportComapny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCViewerNSSTransportComapny"
        Me.Size = New System.Drawing.Size(139, 31)
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
