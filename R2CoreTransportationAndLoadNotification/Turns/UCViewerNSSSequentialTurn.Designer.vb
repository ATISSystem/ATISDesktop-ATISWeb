<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSSequentialTurn
    Inherits UCSequentialTurn

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
        Me.CButton = New CButtonLib.CButton()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.CButton)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(5, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(119, 18)
        Me.PnlMain.TabIndex = 0
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.Transparent
        Me.CButton.BorderShow = False
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Red}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.Red
        Me.CButton.Corners.LowerLeft = 8
        Me.CButton.Corners.UpperRight = 8
        Me.CButton.DesignerSelected = True
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.Font = New System.Drawing.Font("B Homa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(0, 0)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(119, 18)
        Me.CButton.TabIndex = 1
        Me.CButton.Text = " اطاقدارها"
        Me.CButton.TextShadow = System.Drawing.Color.Transparent
        Me.CButton.TextShadowShow = False
        Me.CButton.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'UCViewerNSSSequentialTurn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSSequentialTurn"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Size = New System.Drawing.Size(129, 18)
        Me.PnlMain.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
