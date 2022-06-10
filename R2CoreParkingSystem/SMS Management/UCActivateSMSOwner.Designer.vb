
Imports R2CoreGUI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCActivateSMSOwner
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
        Me.CButtonActivateSMSOwner = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'CButtonActivateSMSOwner
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.Green}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.CButtonActivateSMSOwner.ColorFillBlend = CBlendItems1
        Me.CButtonActivateSMSOwner.Corners.LowerRight = 10
        Me.CButtonActivateSMSOwner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CButtonActivateSMSOwner.DesignerSelected = False
        Me.CButtonActivateSMSOwner.Enabled = False
        Me.CButtonActivateSMSOwner.Font = New System.Drawing.Font("B Homa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CButtonActivateSMSOwner.ForeColor = System.Drawing.Color.Black
        Me.CButtonActivateSMSOwner.ImageIndex = 0
        Me.CButtonActivateSMSOwner.Location = New System.Drawing.Point(1, 2)
        Me.CButtonActivateSMSOwner.Name = "CButtonActivateSMSOwner"
        Me.CButtonActivateSMSOwner.Size = New System.Drawing.Size(155, 22)
        Me.CButtonActivateSMSOwner.TabIndex = 24
        Me.CButtonActivateSMSOwner.Text = "فعال سازی سرویس اس ام اس"
        Me.CButtonActivateSMSOwner.TextShadowShow = False
        '
        'UCActivateSMSOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.CButtonActivateSMSOwner)
        Me.Name = "UCActivateSMSOwner"
        Me.Size = New System.Drawing.Size(159, 27)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CButtonActivateSMSOwner As CButtonLib.CButton
End Class
