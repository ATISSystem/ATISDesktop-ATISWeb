<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCViewerNSSMonetaryCreditSupplySource
    Inherits UCMonetaryCreditSupplySource

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
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlMain.Size = New System.Drawing.Size(97, 22)
        Me.PnlMain.TabIndex = 0
        '
        'CButton
        '
        Me.CButton.BorderColor = System.Drawing.Color.OrangeRed
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CButton.ColorFillBlend = CBlendItems1
        Me.CButton.ColorFillSolid = System.Drawing.Color.White
        Me.CButton.Corners.LowerLeft = 8
        Me.CButton.Corners.UpperRight = 8
        Me.CButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButton.DesignerSelected = True
        Me.CButton.DimFactorHover = 55
        Me.CButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CButton.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton.FocalPoints.CenterPtX = 0!
        Me.CButton.FocalPoints.CenterPtY = 0!
        Me.CButton.Font = New System.Drawing.Font("B Homa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButton.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CButton.ImageIndex = 0
        Me.CButton.Location = New System.Drawing.Point(2, 2)
        Me.CButton.Name = "CButton"
        Me.CButton.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton.Size = New System.Drawing.Size(93, 18)
        Me.CButton.TabIndex = 7
        Me.CButton.Text = "وجه نقد"
        Me.CButton.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CButton.TextShadow = System.Drawing.Color.DarkRed
        Me.CButton.TextShadowShow = False
        '
        'UCViewerNSSMonetaryCreditSupplySource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PnlMain)
        Me.Name = "UCViewerNSSMonetaryCreditSupplySource"
        Me.Size = New System.Drawing.Size(97, 22)
        Me.PnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMain As Panel
    Friend WithEvents CButton As CButtonLib.CButton
End Class
