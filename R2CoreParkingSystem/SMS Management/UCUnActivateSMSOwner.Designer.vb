
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCUnActivateSMSOwner
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
        Me.CButtonUnActivateSMSOwner = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'CButtonUnActivateSMSOwner
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.Green}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonUnActivateSMSOwner.ColorFillBlend = CBlendItems1
        Me.CButtonUnActivateSMSOwner.Corners.LowerRight = 10
        Me.CButtonUnActivateSMSOwner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonUnActivateSMSOwner.DesignerSelected = False
        Me.CButtonUnActivateSMSOwner.Enabled = False
        Me.CButtonUnActivateSMSOwner.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonUnActivateSMSOwner.ForeColor = System.Drawing.Color.Black
        Me.CButtonUnActivateSMSOwner.ImageIndex = 0
        Me.CButtonUnActivateSMSOwner.Location = New System.Drawing.Point(1, 2)
        Me.CButtonUnActivateSMSOwner.Name = "CButtonUnActivateSMSOwner"
        Me.CButtonUnActivateSMSOwner.Size = New System.Drawing.Size(180, 22)
        Me.CButtonUnActivateSMSOwner.TabIndex = 25
        Me.CButtonUnActivateSMSOwner.Text = "غیرفعال سازی سرویس اس ام اس"
        Me.CButtonUnActivateSMSOwner.TextShadowShow = False
        '
        'UCUnActivateSMSOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CButtonUnActivateSMSOwner)
        Me.Name = "UCUnActivateSMSOwner"
        Me.Size = New System.Drawing.Size(185, 22)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CButtonUnActivateSMSOwner As CButtonLib.CButton
End Class
